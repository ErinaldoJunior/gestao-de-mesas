Imports MySql.Data.MySqlClient

Public Class formRelatorioAno
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Sub queryValor()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"


        Dim anoSelecionado As Integer = Integer.Parse(ComboBox1.SelectedItem)


        Try
            conn.Open()

            Dim query As String = "SELECT SUM(valor) FROM pedido WHERE YEAR(data) = @ano"


            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ano", anoSelecionado)
            Dim valorDoBanco As Object = cmd.ExecuteScalar()

            If valorDoBanco IsNot DBNull.Value AndAlso valorDoBanco IsNot Nothing Then

                Dim totalValor As Decimal = Convert.ToDecimal(valorDoBanco)
                totalValor = totalValor.ToString("N2")
                valor_total.Text = $"€ {totalValor}"
            Else

                valor_total.Text = "Nenhuma venda encontrada neste ano."
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        queryValor()
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
    Private Sub formRelatorioAno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estiloBnt()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class