<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRelatorioMes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formRelatorioMes))
        Label1 = New Label()
        Label2 = New Label()
        valor_total = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(217, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 34)
        Label1.TabIndex = 16
        Label1.Text = "Relatório por mês - 2023"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(189, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 23)
        Label2.TabIndex = 18
        Label2.Text = "Valor vendido:"
        ' 
        ' valor_total
        ' 
        valor_total.AutoSize = True
        valor_total.BackColor = Color.Transparent
        valor_total.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        valor_total.ForeColor = SystemColors.ButtonHighlight
        valor_total.Location = New Point(297, 154)
        valor_total.Name = "valor_total"
        valor_total.Size = New Size(63, 28)
        valor_total.TabIndex = 19
        valor_total.Text = "€ 0,00"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        ComboBox1.Location = New Point(189, 98)
        ComboBox1.Margin = New Padding(3, 5, 3, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(340, 31)
        ComboBox1.TabIndex = 20
        ComboBox1.Text = "Escolha o mês:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(620, 243)
        Button1.Margin = New Padding(3, 5, 3, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 77)
        Button1.TabIndex = 25
        Button1.Text = "Voltar"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' formRelatorioMes
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(730, 352)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(valor_total)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        Name = "formRelatorioMes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Relatório - Mês"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents valor_total As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
