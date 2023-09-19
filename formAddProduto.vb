Imports MySql.Data.MySqlClient

Public Class formAddProduto
    Dim conn As MySqlConnection
    Dim command As MySqlCommand


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

    Private Sub formAddProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configBD()
        estiloBnt()
    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Using transaction As MySqlTransaction = conn.BeginTransaction()

                Dim query As String = "INSERT INTO produtos (nome, descricao, categoria, preco) VALUES (@nome, @descricao, @categoria, @preco)"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nome", input_nome.Text)
                cmd.Parameters.AddWithValue("@descricao", input_descricao.Text)
                cmd.Parameters.AddWithValue("@categoria", DirectCast(cb_categorias.SelectedItem, DataRowView)("categoria").ToString())
                cmd.Parameters.AddWithValue("@preco", Decimal.Parse(input_valor.Text))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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