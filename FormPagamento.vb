Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports MySql.Data.MySqlClient

Public Class FormPagamento
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private _formPedidoChamador As FormPedido
    Public pedidoIds As New List(Of String)

    Public Property FormPedidoChamador As FormPedido
        Get
            Return _formPedidoChamador
        End Get
        Set(ByVal value As FormPedido)
            _formPedidoChamador = value
        End Set
    End Property

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
    Private Sub FormPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Multibanco")
        ComboBox1.Items.Add("MBWAY")
        ComboBox1.Items.Add("Numerário")
        estiloBnt()

    End Sub

    Private Sub input_valorPago_TextChanged(sender As Object, e As EventArgs) Handles input_valorPago.TextChanged
        Dim valorPago As Decimal
        Dim troco As Decimal

        If Decimal.TryParse(input_valorPago.Text, valorPago) Then
            troco = valorPago - _formPedidoChamador.totalPedido
            If troco >= 0 Then
                lb_troco.Text = $"€ {troco}"
            Else
                lb_troco.Text = "€0,00"
            End If
        End If
    End Sub

    Private Sub btnPagar_Click_1(sender As Object, e As EventArgs) Handles btnPagar.Click

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"
        Try
            conn.Open()

            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Dim dataAtual As Date = Date.Today
                Dim formatoMySQL As String = "yyyy-MM-dd"
                Dim dataFormatada As String = dataAtual.ToString(formatoMySQL)

                Dim pedidoIdsTexto As String = String.Join(", ", pedidoIds)

                Dim query As String = "INSERT INTO pedido (data, valor, id_produto) VALUES (@data, @valor, @id_produto)"
                Dim cmd As New MySqlCommand(query, conn, transaction)
                cmd.Parameters.AddWithValue("@data", dataFormatada)
                cmd.Parameters.AddWithValue("@valor", Decimal.Parse(_formPedidoChamador.totalPedido))
                cmd.Parameters.AddWithValue("@id_produto", pedidoIdsTexto)
                cmd.ExecuteNonQuery()

                transaction.Commit()
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try


        Dim valorPago As Decimal
        Dim valorRestante As Decimal
        valorRestante = _formPedidoChamador.totalPedido

        If Decimal.TryParse(input_valorPago.Text, valorPago) Then
            ' Verifica se uma forma de pagamento foi selecionada
            If ComboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Escolha uma forma de pagamento!", "Selecione o pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ComboBox1.Focus()
            Else
                If valorPago < valorRestante Then
                    valorRestante -= valorPago
                    lb_valorRestante.Text = $"€ {valorRestante}"
                    MessageBox.Show("Insira o restante do pagamento para concluir.", "Pagamento em falta.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    input_valorPago.Focus()
                    _formPedidoChamador.totalPedido = valorRestante
                Else
                    Form1.botaoClicado.BackColor = Color.Green
                    If _formPedidoChamador IsNot Nothing Then
                        Dim numItens As Integer = _formPedidoChamador.pedidoItens.Count - 1
                        For i As Integer = numItens To 0 Step -1
                            _formPedidoChamador.pedidoItens.RemoveAt(i)
                        Next
                        _formPedidoChamador.list_pedido.Items.Clear()
                        _formPedidoChamador.totalPedido = 0.0
                        _formPedidoChamador.valor_total.Text = ""
                    End If
                    MessageBox.Show("Pedido pago com sucesso!", "Pedido Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End If
            End If
        Else
            MessageBox.Show("Informe um valor de pagamento válido", "Valor de Pagamento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class