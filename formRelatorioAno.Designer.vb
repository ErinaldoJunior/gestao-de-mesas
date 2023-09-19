<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRelatorioAno
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formRelatorioAno))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        valor_total = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(231, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 34)
        Label1.TabIndex = 17
        Label1.Text = "Relatório por ano"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        ComboBox1.Location = New Point(147, 110)
        ComboBox1.Margin = New Padding(3, 5, 3, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(340, 31)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "Escolha o ano:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(147, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 23)
        Label2.TabIndex = 22
        Label2.Text = "Valor vendido:"
        ' 
        ' valor_total
        ' 
        valor_total.AutoSize = True
        valor_total.BackColor = Color.Transparent
        valor_total.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        valor_total.ForeColor = SystemColors.ButtonHighlight
        valor_total.Location = New Point(258, 162)
        valor_total.Name = "valor_total"
        valor_total.Size = New Size(63, 28)
        valor_total.TabIndex = 23
        valor_total.Text = "€ 0,00"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(540, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 65)
        Button1.TabIndex = 24
        Button1.Text = "Voltar"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' formRelatorioAno
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(678, 330)
        Controls.Add(Button1)
        Controls.Add(valor_total)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        Name = "formRelatorioAno"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Relatório - Ano"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents valor_total As Label
    Friend WithEvents Button1 As Button
End Class
