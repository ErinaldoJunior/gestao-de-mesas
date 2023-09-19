Imports MySql.Data.MySqlClient
Public Class FormPedido
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Public pedidoItens As New List(Of Produto)()
    Public totalPedido As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub configBD()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Dim table As New DataTable
            Dim adapter As New MySqlDataAdapter("SELECT DISTINCT categoria FROM produtos", conn)

            adapter.Fill(table)

            cb_categorias.DataSource = table
            cb_categorias.DisplayMember = "categoria"

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub configView()
        Dim produtosTable As New DataTable()

        If cb_categorias.SelectedItem IsNot Nothing Then
            Dim categoriaSelecionada As String = DirectCast(cb_categorias.SelectedItem, DataRowView)("categoria").ToString()
            Dim produtosAdapter As New MySqlDataAdapter($"SELECT id_produto, nome, preco, categoria FROM produtos WHERE categoria = '{categoriaSelecionada}'", conn)
            produtosAdapter.Fill(produtosTable)

            cb_produtos.DataSource = produtosTable
            cb_produtos.DisplayMember = "nome"
            cb_produtos.ValueMember = "id_produto"
        End If
    End Sub

    Private Sub cb_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_categorias.SelectedIndexChanged
        configView()
    End Sub

    Sub estiloBnt()
        For Each controle As Control In Me.Controls

            If TypeOf controle Is Button Then
                Dim botao As Button = DirectCast(controle, Button)

                Dim corHexadecimal As String = "#afccab"

                Dim cor As Color = ColorTranslator.FromHtml(corHexadecimal)

                botao.FlatStyle = FlatStyle.Flat

                botao.FlatAppearance.BorderSize = 0
                botao.FlatAppearance.MouseDownBackColor = cor
                botao.FlatAppearance.MouseOverBackColor = cor

                Dim raioArredondamento As Integer = 20
                Dim retanguloArredondado As New Drawing2D.GraphicsPath()
                retanguloArredondado.AddArc(0, 0, raioArredondamento, raioArredondamento, 180, 90)
                retanguloArredondado.AddArc(botao.Width - raioArredondamento, 0, raioArredondamento, raioArredondamento, 270, 90)
                retanguloArredondado.AddArc(botao.Width - raioArredondamento, botao.Height - raioArredondamento, raioArredondamento, raioArredondamento, 0, 90)
                retanguloArredondado.AddArc(0, botao.Height - raioArredondamento, raioArredondamento, raioArredondamento, 90, 90)

                ' Aplica o retângulo arredondado como a máscara de forma do botão
                botao.Region = New Region(retanguloArredondado)
            End If
        Next
    End Sub

    Private Sub FormPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configBD()
        estiloBnt()
    End Sub

    Private Sub cb_produtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_produtos.SelectedIndexChanged
        If cb_produtos.SelectedItem IsNot Nothing Then
            Dim valorSelecionado As String = DirectCast(cb_produtos.SelectedItem, DataRowView)("preco").ToString()
            lb_valor.Text = $"Valor: €{valorSelecionado}"
        End If
    End Sub

    Public Class Produto
        Public Property Nome As String
        Public Property Valor As Decimal

        Public Property IdProduto As String
    End Class

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cb_produtos.SelectedItem IsNot Nothing Then
            Dim produtoSelecionado As DataRowView = DirectCast(cb_produtos.SelectedItem, DataRowView)

            Dim nomeProduto As String = produtoSelecionado("nome").ToString()
            Dim valorProduto As Decimal = Decimal.Parse(produtoSelecionado("preco").ToString())
            Dim idProduto As Integer = Integer.Parse(produtoSelecionado("id_produto").ToString()) ' Supondo que você tenha o id_produto na sua consulta SQL

            Dim novoProduto As New Produto()
            novoProduto.IdProduto = idProduto
            novoProduto.Nome = nomeProduto
            novoProduto.Valor = valorProduto

            pedidoItens.Add(novoProduto)
            totalPedido += valorProduto

            AtualizarListaPedidos()
        End If
    End Sub

    Private Sub AtualizarListaPedidos()
        Dim produtosInfo As List(Of Tuple(Of String, Decimal, String)) = pedidoItens.Select(Function(produto) Tuple.Create(produto.Nome, produto.Valor, produto.IdProduto)).ToList()

        list_pedido.Items.Clear()

        For Each produtoInfo In produtosInfo
            Dim itemText As String = $"{produtoInfo.Item1}: €{produtoInfo.Item2}"
            list_pedido.Items.Add(itemText)
        Next
        valor_total.Text = "€" + totalPedido.ToString()
    End Sub

    Private Sub btnPagar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPagar.Click

        If pedidoItens.Count = 0 Then
            ' A lista está vazia
            MessageBox.Show("O pedido está vazio.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim formPagamento As New FormPagamento()
            formPagamento.FormPedidoChamador = Me

            Dim produtosInfo As List(Of Tuple(Of String, Decimal, String)) = pedidoItens.Select(Function(produto) Tuple.Create(produto.Nome, produto.Valor, produto.IdProduto)).ToList()

            For Each produtoInfo In produtosInfo
                Dim itemText As String = $"{produtoInfo.Item1}: €{produtoInfo.Item2}"
                formPagamento.ItensDoPedido.Items.Add(itemText)
                formPagamento.pedidoIds.Add(produtoInfo.Item3)
            Next

            Dim pedidoIdsTexto As String = String.Join(", ", formPagamento.pedidoIds)

            formPagamento.TotalDoPedido.Text = "€" + totalPedido.ToString()

            formPagamento.Show()
        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        Dim resp As Integer

        resp = MessageBox.Show("Tem certeza que deseja cancelar? As informações do pedido serão perdidas.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If resp = vbYes Then
            Form1.botaoClicado.BackColor = Color.Green

            Dim numItens As Integer = pedidoItens.Count - 1
            For i As Integer = numItens To 0 Step -1
                pedidoItens.RemoveAt(i)
            Next

            list_pedido.Items.Clear()
            totalPedido = 0.0
            valor_total.Text = ""
            Me.Close()
        Else
            Return
        End If

    End Sub

    Private Sub btn_remove_Click_1(sender As Object, e As EventArgs) Handles btn_remove.Click
        If pedidoItens.Count > 0 Then
            Dim ultimoProduto As Produto = pedidoItens(pedidoItens.Count - 1)
            totalPedido -= ultimoProduto.Valor
            pedidoItens.RemoveAt(pedidoItens.Count - 1)
            AtualizarListaPedidos()

        Else
            MessageBox.Show("A lista está vazia.", "Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class