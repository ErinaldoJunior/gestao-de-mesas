<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRelatorios
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formRelatorios))
        valor_total = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        list_relatorio = New ListBox()
        Label3 = New Label()
        btnImprimir = New Button()
        SuspendLayout()
        ' 
        ' valor_total
        ' 
        valor_total.AutoSize = True
        valor_total.BackColor = Color.Transparent
        valor_total.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        valor_total.ForeColor = SystemColors.ButtonHighlight
        valor_total.Location = New Point(356, 123)
        valor_total.Name = "valor_total"
        valor_total.Size = New Size(80, 36)
        valor_total.TabIndex = 13
        valor_total.Text = "€ 0,00"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = SystemColors.GradientActiveCaption
        DateTimePicker1.Location = New Point(247, 72)
        DateTimePicker1.Margin = New Padding(3, 5, 3, 5)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(301, 32)
        DateTimePicker1.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(247, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 42)
        Label1.TabIndex = 15
        Label1.Text = "Relatório por dia"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(247, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 30)
        Label2.TabIndex = 16
        Label2.Text = "Valor vendido:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(838, 454)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 65)
        Button1.TabIndex = 17
        Button1.Text = "Voltar"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' list_relatorio
        ' 
        list_relatorio.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        list_relatorio.BorderStyle = BorderStyle.None
        list_relatorio.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point)
        list_relatorio.ForeColor = SystemColors.ButtonHighlight
        list_relatorio.FormattingEnabled = True
        list_relatorio.ItemHeight = 36
        list_relatorio.Location = New Point(247, 246)
        list_relatorio.Margin = New Padding(3, 5, 3, 5)
        list_relatorio.Name = "list_relatorio"
        list_relatorio.Size = New Size(488, 252)
        list_relatorio.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(247, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 30)
        Label3.TabIndex = 19
        Label3.Text = "Pratos vendidos:"
        ' 
        ' btnImprimir
        ' 
        btnImprimir.BackColor = Color.Transparent
        btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), Image)
        btnImprimir.BackgroundImageLayout = ImageLayout.Stretch
        btnImprimir.Location = New Point(838, 287)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(94, 93)
        btnImprimir.TabIndex = 20
        btnImprimir.UseVisualStyleBackColor = False
        ' 
        ' formRelatorios
        ' 
        AutoScaleDimensions = New SizeF(10F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(964, 531)
        Controls.Add(btnImprimir)
        Controls.Add(Label3)
        Controls.Add(list_relatorio)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(valor_total)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "formRelatorios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Relatório - Dia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents valor_total As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents list_relatorio As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnImprimir As Button
End Class
