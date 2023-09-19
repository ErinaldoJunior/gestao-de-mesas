<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRemoveProduto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formRemoveProduto))
        cb_categorias = New ComboBox()
        cb_produtos = New ComboBox()
        btn_Cancelar = New Button()
        btn_remove = New Button()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' cb_categorias
        ' 
        cb_categorias.FormattingEnabled = True
        cb_categorias.Location = New Point(166, 55)
        cb_categorias.Margin = New Padding(3, 5, 3, 5)
        cb_categorias.Name = "cb_categorias"
        cb_categorias.Size = New Size(175, 31)
        cb_categorias.TabIndex = 9
        ' 
        ' cb_produtos
        ' 
        cb_produtos.FormattingEnabled = True
        cb_produtos.Location = New Point(166, 137)
        cb_produtos.Margin = New Padding(3, 5, 3, 5)
        cb_produtos.Name = "cb_produtos"
        cb_produtos.Size = New Size(243, 31)
        cb_produtos.TabIndex = 10
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.BackColor = SystemColors.Window
        btn_Cancelar.Cursor = Cursors.Hand
        btn_Cancelar.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText
        btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), Image)
        btn_Cancelar.ImageAlign = ContentAlignment.BottomCenter
        btn_Cancelar.Location = New Point(449, 207)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(103, 73)
        btn_Cancelar.TabIndex = 17
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
        btn_remove.Location = New Point(166, 205)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(105, 73)
        btn_remove.TabIndex = 18
        btn_remove.Text = "Remover"
        btn_remove.TextAlign = ContentAlignment.TopCenter
        btn_remove.TextImageRelation = TextImageRelation.ImageAboveText
        btn_remove.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(166, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 23)
        Label1.TabIndex = 19
        Label1.Text = "Nome do produto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(166, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 23)
        Label3.TabIndex = 20
        Label3.Text = "Categoria do produto"
        ' 
        ' formRemoveProduto
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(578, 305)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btn_remove)
        Controls.Add(btn_Cancelar)
        Controls.Add(cb_produtos)
        Controls.Add(cb_categorias)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "formRemoveProduto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Remover Produto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cb_categorias As ComboBox
    Friend WithEvents cb_produtos As ComboBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
