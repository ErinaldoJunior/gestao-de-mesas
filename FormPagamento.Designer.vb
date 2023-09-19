<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagamento
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPagamento))
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        ItensDoPedido = New ListBox()
        Label3 = New Label()
        TotalDoPedido = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lb_troco = New Label()
        lb_valorRestante = New Label()
        input_valorPago = New TextBox()
        btnPagar = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(3, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 48)
        Label2.TabIndex = 2
        Label2.Text = "PAGAMENTO"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(361, 11)
        ComboBox1.Margin = New Padding(3, 5, 3, 5)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(267, 31)
        ComboBox1.TabIndex = 4
        ComboBox1.Text = "Escolha uma forma de pagamento:"
        ' 
        ' ItensDoPedido
        ' 
        ItensDoPedido.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ItensDoPedido.FormattingEnabled = True
        ItensDoPedido.ItemHeight = 28
        ItensDoPedido.Location = New Point(361, 52)
        ItensDoPedido.Margin = New Padding(3, 5, 3, 5)
        ItensDoPedido.Name = "ItensDoPedido"
        ItensDoPedido.Size = New Size(577, 284)
        ItensDoPedido.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(362, 351)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 28)
        Label3.TabIndex = 13
        Label3.Text = "VALOR TOTAL:"
        ' 
        ' TotalDoPedido
        ' 
        TotalDoPedido.AutoSize = True
        TotalDoPedido.BackColor = Color.Transparent
        TotalDoPedido.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalDoPedido.ForeColor = SystemColors.ControlLightLight
        TotalDoPedido.Location = New Point(494, 351)
        TotalDoPedido.Name = "TotalDoPedido"
        TotalDoPedido.Size = New Size(63, 28)
        TotalDoPedido.TabIndex = 14
        TotalDoPedido.Text = "€ 0,00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(362, 379)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 28)
        Label1.TabIndex = 16
        Label1.Text = "VALOR PAGO:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(362, 411)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 28)
        Label4.TabIndex = 17
        Label4.Text = "VALOR RESTANTE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(362, 439)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 28)
        Label5.TabIndex = 18
        Label5.Text = "TROCO:"
        ' 
        ' lb_troco
        ' 
        lb_troco.AutoSize = True
        lb_troco.BackColor = Color.Transparent
        lb_troco.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lb_troco.ForeColor = SystemColors.ButtonHighlight
        lb_troco.Location = New Point(442, 439)
        lb_troco.Name = "lb_troco"
        lb_troco.Size = New Size(63, 28)
        lb_troco.TabIndex = 19
        lb_troco.Text = "€ 0,00"
        ' 
        ' lb_valorRestante
        ' 
        lb_valorRestante.AutoSize = True
        lb_valorRestante.BackColor = Color.Transparent
        lb_valorRestante.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lb_valorRestante.ForeColor = SystemColors.ButtonHighlight
        lb_valorRestante.Location = New Point(512, 411)
        lb_valorRestante.Name = "lb_valorRestante"
        lb_valorRestante.Size = New Size(63, 28)
        lb_valorRestante.TabIndex = 20
        lb_valorRestante.Text = "€ 0,00"
        ' 
        ' input_valorPago
        ' 
        input_valorPago.Location = New Point(490, 379)
        input_valorPago.Margin = New Padding(3, 5, 3, 5)
        input_valorPago.Name = "input_valorPago"
        input_valorPago.Size = New Size(180, 27)
        input_valorPago.TabIndex = 21
        ' 
        ' btnPagar
        ' 
        btnPagar.BackColor = SystemColors.Window
        btnPagar.Cursor = Cursors.Hand
        btnPagar.FlatStyle = FlatStyle.Flat
        btnPagar.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPagar.ForeColor = SystemColors.ActiveCaptionText
        btnPagar.Image = CType(resources.GetObject("btnPagar.Image"), Image)
        btnPagar.ImageAlign = ContentAlignment.BottomCenter
        btnPagar.Location = New Point(362, 480)
        btnPagar.Name = "btnPagar"
        btnPagar.Size = New Size(136, 83)
        btnPagar.TabIndex = 22
        btnPagar.Text = "Pagar"
        btnPagar.TextAlign = ContentAlignment.TopCenter
        btnPagar.TextImageRelation = TextImageRelation.ImageAboveText
        btnPagar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(811, 480)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 83)
        Button1.TabIndex = 23
        Button1.Text = "Voltar"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormPagamento
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1066, 584)
        Controls.Add(Button1)
        Controls.Add(btnPagar)
        Controls.Add(input_valorPago)
        Controls.Add(lb_valorRestante)
        Controls.Add(lb_troco)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(TotalDoPedido)
        Controls.Add(Label3)
        Controls.Add(ItensDoPedido)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        Name = "FormPagamento"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Pagamento"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ItensDoPedido As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalDoPedido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lb_troco As Label
    Friend WithEvents lb_valorRestante As Label
    Friend WithEvents input_valorPago As TextBox
    Friend WithEvents btnPagar As Button
    Friend WithEvents Button1 As Button
End Class
