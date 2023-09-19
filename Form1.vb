
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Public botaoClicado As Button = Nothing
    Private formPedidoDictionary As New Dictionary(Of Button, FormPedido)()

    Sub estiloBnt()
        For Each controle As Control In Me.Controls

            If TypeOf controle Is Button Then
                Dim botao As Button = DirectCast(controle, Button)


                botao.FlatStyle = FlatStyle.Flat


                botao.FlatAppearance.BorderSize = 0
                Dim raioArredondamento As Integer = 80
                Dim retanguloArredondado As New Drawing2D.GraphicsPath()
                retanguloArredondado.AddArc(0, 0, raioArredondamento, raioArredondamento, 180, 90)
                retanguloArredondado.AddArc(botao.Width - raioArredondamento, 0, raioArredondamento, raioArredondamento, 270, 90)
                retanguloArredondado.AddArc(botao.Width - raioArredondamento, botao.Height - raioArredondamento, raioArredondamento, raioArredondamento, 0, 90)
                retanguloArredondado.AddArc(0, botao.Height - raioArredondamento, raioArredondamento, raioArredondamento, 90, 90)

                botao.Region = New Region(retanguloArredondado)
            End If
        Next
    End Sub

    Sub configBotao(botao As Button)
        If Not formPedidoDictionary.ContainsKey(botao) OrElse formPedidoDictionary(botao) Is Nothing OrElse formPedidoDictionary(botao).IsDisposed Then
            formPedidoDictionary(botao) = New FormPedido()
        End If
        formPedidoDictionary(botao).Show()
    End Sub
    Private Sub config_Clicks(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click
        Dim botao As Button = DirectCast(sender, Button)
        botao.BackColor = Color.Red
        botaoClicado = botao
        configBotao(botao)
    End Sub

    Private Sub AdicionarProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarProdutosToolStripMenuItem.Click
        formAddProduto.ShowDialog()

    End Sub

    Private Sub RemoverProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverProdutoToolStripMenuItem.Click
        formRemoveProduto.ShowDialog()
    End Sub

    Private Sub PorDiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorDiaToolStripMenuItem.Click
        formRelatorios.Show()
    End Sub

    Private Sub PorMêsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorMêsToolStripMenuItem.Click
        formRelatorioMes.Show()
    End Sub

    Private Sub PorAnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorAnoToolStripMenuItem.Click
        formRelatorioAno.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estiloBnt()

        If login.input_Username.Text = "admin" Then
            MenuStrip1.Visible = True
            txt_bemvindo.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        login.Show()
        login.input_Senha.Clear()
        login.input_Username.Clear()
    End Sub
End Class
