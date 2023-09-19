Imports System.Drawing.Printing
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Public Class formRelatorios
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private printDocument As New PrintDocument


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ' Iniciar o processo de impressão
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim font As New Font("Arial", 12)
        Dim lineHeight As Single = font.GetHeight(graphics)
        Dim startX As Single = 100
        Dim startY As Single = 100

        Dim dataSelecionada As String = DateTimePicker1.Value.ToString("dd/MM/yyyy")
        graphics.DrawString("Data Selecionada: " & dataSelecionada, font, Brushes.Black, startX, startY)
        startY += lineHeight * 2 ' aumentar espaçamento

        ' gerar lista de produtos
        For Each item As Object In list_relatorio.Items
            Dim textoItem As String = item.ToString()
            graphics.DrawString("Pratos Vendidos: " & textoItem, font, Brushes.Black, startX, startY)
            startY += lineHeight * 2
        Next

        Dim valorTotal As String = valor_total.Text
        graphics.DrawString("Valor Total: " & valorTotal, font, Brushes.Black, startX, startY)
    End Sub



    Sub queryValor()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Dim query As String = "SELECT valor FROM pedido WHERE data = @data"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@data", DateTimePicker1.Value.Date)


            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim soma As Decimal = 0

                For Each row As DataRow In table.Rows
                    If table.Columns.Contains("valor") AndAlso Not row.IsNull("valor") Then
                        soma += Convert.ToDecimal(row("valor"))
                    End If
                Next
                valor_total.Text = $"€ {soma}"
            Else
                valor_total.Text = "Nenhuma venda encontrada neste dia."

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub


    Sub queryLista()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=restaurante"

        Try
            conn.Open()

            Dim query As String = "SELECT id_produto FROM pedido WHERE data = @data"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@data", DateTimePicker1.Value.Date)

            Dim table As New DataTable
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim produtos As New List(Of String)

                For Each row As DataRow In table.Rows
                    If table.Columns.Contains("id_produto") AndAlso Not row.IsNull("id_produto") Then
                        produtos.Add(Convert.ToString(row("id_produto")))
                    End If
                Next

                Dim idsProdutos As String = String.Join(", ", produtos)

                Dim queryNomesProdutos As String = "SELECT nome FROM produtos WHERE id_produto IN (" & idsProdutos & ")"

                Using cmdNomesProdutos As New MySqlCommand(queryNomesProdutos, conn)
                    Using readerNomesProdutos As MySqlDataReader = cmdNomesProdutos.ExecuteReader()
                        While readerNomesProdutos.Read()
                            Dim nomeProduto As String = readerNomesProdutos.GetString(0)
                            list_relatorio.Items.Add("- " + nomeProduto)
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        list_relatorio.Items.Clear()
        queryValor()
        queryLista()
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
    Private Sub formRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estiloBnt()
        AddHandler printDocument.PrintPage, AddressOf PrintPageHandler
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class