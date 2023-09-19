<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPedido
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormPedido))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnPagar = New Button()
        btn_add = New Button()
        cb_categorias = New ComboBox()
        cb_produtos = New ComboBox()
        lb_valor = New Label()
        list_pedido = New ListBox()
        valor_total = New Label()
        btn_Cancelar = New Button()
        btn_remove = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.BottomCenter
        Button1.Location = New Point(869, 620)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 111)
        Button1.TabIndex = 0
        Button1.Text = "Voltar"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(14, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 70)
        Label1.TabIndex = 1
        Label1.Text = "PEDIDO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(258, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(267, 42)
        Label2.TabIndex = 3
        Label2.Text = "RESUMO DO PEDIDO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(258, 577)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 36)
        Label3.TabIndex = 5
        Label3.Text = "VALOR TOTAL:"
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
        btnPagar.Location = New Point(258, 619)
        btnPagar.Margin = New Padding(3, 4, 3, 4)
        btnPagar.Name = "btnPagar"
        btnPagar.Size = New Size(155, 111)
        btnPagar.TabIndex = 6
        btnPagar.Text = "Pagamento"
        btnPagar.TextAlign = ContentAlignment.TopCenter
        btnPagar.TextImageRelation = TextImageRelation.ImageAboveText
        btnPagar.UseVisualStyleBackColor = False
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = SystemColors.Window
        btn_add.Cursor = Cursors.Hand
        btn_add.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ActiveCaptionText
        btn_add.Image = CType(resources.GetObject("btn_add.Image"), Image)
        btn_add.ImageAlign = ContentAlignment.BottomCenter
        btn_add.Location = New Point(1064, 179)
        btn_add.Margin = New Padding(3, 4, 3, 4)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(112, 89)
        btn_add.TabIndex = 7
        btn_add.Text = "Adicionar"
        btn_add.TextAlign = ContentAlignment.TopCenter
        btn_add.TextImageRelation = TextImageRelation.ImageAboveText
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' cb_categorias
        ' 
        cb_categorias.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cb_categorias.FormattingEnabled = True
        cb_categorias.Location = New Point(258, 56)
        cb_categorias.Margin = New Padding(3, 4, 3, 4)
        cb_categorias.Name = "cb_categorias"
        cb_categorias.Size = New Size(175, 34)
        cb_categorias.TabIndex = 8
        ' 
        ' cb_produtos
        ' 
        cb_produtos.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cb_produtos.FormattingEnabled = True
        cb_produtos.Location = New Point(511, 56)
        cb_produtos.Margin = New Padding(3, 4, 3, 4)
        cb_produtos.Name = "cb_produtos"
        cb_produtos.Size = New Size(243, 34)
        cb_produtos.TabIndex = 9
        ' 
        ' lb_valor
        ' 
        lb_valor.AutoSize = True
        lb_valor.BackColor = Color.Transparent
        lb_valor.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lb_valor.ForeColor = SystemColors.ButtonHighlight
        lb_valor.Location = New Point(827, 56)
        lb_valor.Name = "lb_valor"
        lb_valor.Size = New Size(72, 36)
        lb_valor.TabIndex = 10
        lb_valor.Text = "Valor"
        ' 
        ' list_pedido
        ' 
        list_pedido.Font = New Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point)
        list_pedido.FormattingEnabled = True
        list_pedido.ItemHeight = 36
        list_pedido.Location = New Point(258, 179)
        list_pedido.Margin = New Padding(3, 4, 3, 4)
        list_pedido.Name = "list_pedido"
        list_pedido.Size = New Size(755, 364)
        list_pedido.TabIndex = 11
        ' 
        ' valor_total
        ' 
        valor_total.AutoSize = True
        valor_total.BackColor = Color.Transparent
        valor_total.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        valor_total.ForeColor = SystemColors.ButtonHighlight
        valor_total.Location = New Point(409, 577)
        valor_total.Name = "valor_total"
        valor_total.Size = New Size(80, 36)
        valor_total.TabIndex = 12
        valor_total.Text = "€ 0,00"
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.BackColor = SystemColors.Window
        btn_Cancelar.Cursor = Cursors.Hand
        btn_Cancelar.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText
        btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), Image)
        btn_Cancelar.ImageAlign = ContentAlignment.BottomCenter
        btn_Cancelar.Location = New Point(560, 620)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(151, 111)
        btn_Cancelar.TabIndex = 13
        btn_Cancelar.Text = "Cancelar"
        btn_Cancelar.TextAlign = ContentAlignment.TopCenter
        btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText
        btn_Cancelar.UseVisualStyleBackColor = False
        ' 
        ' btn_remove
        ' 
        btn_remove.BackColor = SystemColors.Window
        btn_remove.Cursor = Cursors.Hand
        btn_remove.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_remove.ForeColor = SystemColors.ActiveCaptionText
        btn_remove.Image = CType(resources.GetObject("btn_remove.Image"), Image)
        btn_remove.ImageAlign = ContentAlignment.BottomCenter
        btn_remove.Location = New Point(1064, 468)
        btn_remove.Margin = New Padding(3, 4, 3, 4)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(112, 89)
        btn_remove.TabIndex = 14
        btn_remove.Text = "Remover"
        btn_remove.TextAlign = ContentAlignment.TopCenter
        btn_remove.TextImageRelation = TextImageRelation.ImageAboveText
        btn_remove.UseVisualStyleBackColor = False
        ' 
        ' FormPedido
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1205, 745)
        Controls.Add(btn_remove)
        Controls.Add(btn_Cancelar)
        Controls.Add(valor_total)
        Controls.Add(list_pedido)
        Controls.Add(lb_valor)
        Controls.Add(cb_produtos)
        Controls.Add(cb_categorias)
        Controls.Add(btn_add)
        Controls.Add(btnPagar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormPedido"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Pedido"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPagar As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents cb_categorias As ComboBox
    Friend WithEvents cb_produtos As ComboBox
    Friend WithEvents lb_valor As Label
    Friend WithEvents list_pedido As ListBox
    Friend WithEvents valor_total As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_remove As Button
End Class
