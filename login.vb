Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class login
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Function CalcularHashSHA256(texto As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim hash As New StringBuilder()

            For i As Integer = 0 To hashBytes.Length - 1
                hash.Append(hashBytes(i).ToString("x2"))
            Next

            Return hash.ToString()
        End Using
    End Function
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

                botao.Region = New Region(retanguloArredondado)
            End If
        Next
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Dim nomeUsuario As String = input_Username.Text
            Dim senhaUsuario As String = input_Senha.Text

            Dim query As String = "SELECT senha FROM usuario WHERE username = @nomeUsuario"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario)

            Dim senhaHashDoBanco As String = Convert.ToString(cmd.ExecuteScalar())

            Dim hashDaSenhaFornecida As String = CalcularHashSHA256(senhaUsuario)

            If senhaHashDoBanco = hashDaSenhaFornecida Then
                Me.Hide()
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
            Else

                MessageBox.Show("Nome de usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                input_Username.Clear()
                input_Senha.Clear()
                input_Username.Focus()

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        formCadastro.Show()
        Me.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estiloBnt()
    End Sub
End Class
