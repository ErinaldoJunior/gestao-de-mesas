Imports MySql.Data.MySqlClient

Public Class formRemoveProduto
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
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
    Private Sub configView()
        Dim produtosTable As New DataTable()

        If cb_categorias.SelectedItem IsNot Nothing Then
            Dim categoriaSelecionada As String = DirectCast(cb_categorias.SelectedItem, DataRowView)("categoria").ToString()
            Dim produtosAdapter As New MySqlDataAdapter($"SELECT * FROM produtos WHERE categoria = '{categoriaSelecionada}'", conn)
            produtosAdapter.Fill(produtosTable)

            cb_produtos.DataSource = produtosTable
            cb_produtos.DisplayMember = "nome"

        End If
    End Sub
    Private Sub cb_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_categorias.SelectedIndexChanged
        configView()
    End Sub

    Private Sub cb_produtos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_produtos.SelectedIndexChanged
        If cb_produtos.SelectedItem IsNot Nothing Then
            Dim valorSelecionado As String = DirectCast(cb_produtos.SelectedItem, DataRowView)("preco").ToString()

        End If
    End Sub


    Private Sub formRemoveProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configBD()
        estiloBnt()

    End Sub

    Private Sub btn_remove_Click_1(sender As Object, e As EventArgs) Handles btn_remove.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try

            conn.Open()
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Dim query As String = "DELETE FROM produtos WHERE nome = @nome"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nome", DirectCast(cb_produtos.SelectedItem, DataRowView)("nome").ToString())

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                Dim resp As Integer

                If rowsAffected > 0 Then
                    resp = MessageBox.Show("Produto excluído com sucesso! Deseja remover mais produtos?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    If resp = vbYes Then
                        Me.Show()
                    Else
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Nenhum produto foi excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                transaction.Commit()


                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_Cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
    End Sub
End Class