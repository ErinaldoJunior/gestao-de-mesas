Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class formCadastro
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Function CalcularHashSHA256(texto As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim hash As New StringBuilder()

            For i As Integer = 0 To hashBytes.Length - 1
                hash.Append(hashBytes(i).ToString("x2")) ' Converte para formato hexadecimal
            Next

            Return hash.ToString()
        End Using
    End Function

    Private Sub btn_Cancelar_Click_1(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub btn_criarConta_Click_1(sender As Object, e As EventArgs) Handles btn_criarConta.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Using transaction As MySqlTransaction = conn.BeginTransaction()

                Dim senhaDoUsuario As String = input_Senha.Text
                Dim senhaDoUsuarioRepetida As String = input_SenhaRepetida.Text

                Dim nomeUsuario As String = input_Username.Text

                If Not String.IsNullOrEmpty(input_nomeUsuario.Text) Then

                    If Not String.IsNullOrEmpty(input_Username.Text) Then

                        If Not String.IsNullOrEmpty(input_Senha.Text) Then

                            If Not String.IsNullOrEmpty(input_SenhaRepetida.Text) Then

                                If (senhaDoUsuario = senhaDoUsuarioRepetida) Then

                                    ' Verificar se o nome de usuário já existe no banco de dados
                                    Dim queryVerificarUsuario As String = "SELECT COUNT(*) FROM usuario WHERE username = @nomeUsuario"
                                    Dim cmdVerificarUsuario As New MySqlCommand(queryVerificarUsuario, conn)
                                    cmdVerificarUsuario.Parameters.AddWithValue("@nomeUsuario", nomeUsuario)

                                    Dim numUsuariosExistentes As Integer = Convert.ToInt32(cmdVerificarUsuario.ExecuteScalar())

                                    If numUsuariosExistentes > 0 Then
                                        MessageBox.Show("Nome de usuário já existe. Por favor, escolha outro nome de usuário.", "Nome de Usuário Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        input_Username.Clear()
                                        input_Username.Focus()
                                        input_Senha.Clear()
                                        input_SenhaRepetida.Clear()
                                    Else

                                        Dim query As String = "INSERT INTO usuario (nome, username, senha) VALUES (@nome, @username, @senha)"
                                        Dim hash As String = CalcularHashSHA256(senhaDoUsuario)
                                        Dim cmd As New MySqlCommand(query, conn)
                                        cmd.Parameters.AddWithValue("@nome", input_nomeUsuario.Text)
                                        cmd.Parameters.AddWithValue("@username", input_Username.Text)
                                        cmd.Parameters.AddWithValue("@senha", hash)

                                        cmd.ExecuteNonQuery()

                                        MessageBox.Show("Conta criada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        transaction.Commit()
                                        conn.Close()
                                        Me.Close()
                                        login.Show()

                                    End If
                                Else
                                    MessageBox.Show("As senhas informadas são diferentes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    input_Senha.Clear()
                                    input_SenhaRepetida.Clear()
                                    input_Senha.Focus()
                                End If
                            Else
                                MessageBox.Show("As senhas informadas são diferentes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                input_Senha.Clear()
                                input_SenhaRepetida.Clear()
                                input_Senha.Focus()
                            End If
                        Else
                            MessageBox.Show("Senha inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            input_Senha.Clear()
                            input_SenhaRepetida.Clear()
                            input_Senha.Focus()
                        End If
                    Else
                        MessageBox.Show("Por favor, insira um username válido.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        input_Username.Clear()
                        input_Username.Focus()
                    End If
                Else
                    MessageBox.Show("Por favor, insira o nome de usuário.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    input_nomeUsuario.Clear()
                    input_nomeUsuario.Focus()
                End If

            End Using
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

                botao.Region = New Region(retanguloArredondado)
            End If
        Next
    End Sub
    Private Sub formCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estiloBnt()
    End Sub
End Class