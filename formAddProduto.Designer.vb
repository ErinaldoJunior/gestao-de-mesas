<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddProduto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formAddProduto))
        Label1 = New Label()
        input_nome = New TextBox()
        Label2 = New Label()
        input_descricao = New TextBox()
        Label3 = New Label()
        input_valor = New TextBox()
        Label4 = New Label()
        cb_categorias = New ComboBox()
        btn_add = New Button()
        btn_Cancelar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(223, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 23)
        Label1.TabIndex = 0
        Label1.Text = "Nome do produto"
        ' 
        ' input_nome
        ' 
        input_nome.Location = New Point(223, 42)
        input_nome.Name = "input_nome"
        input_nome.Size = New Size(238, 27)
        input_nome.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(223, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 23)
        Label2.TabIndex = 2
        Label2.Text = "Descrição do produto"
        ' 
        ' input_descricao
        ' 
        input_descricao.Location = New Point(223, 107)
        input_descricao.Name = "input_descricao"
        input_descricao.Size = New Size(367, 27)
        input_descricao.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(223, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 23)
        Label3.TabIndex = 4
        Label3.Text = "Categoria do produto"
        ' 
        ' input_valor
        ' 
        input_valor.Location = New Point(223, 240)
        input_valor.Name = "input_valor"
        input_valor.Size = New Size(78, 27)
        input_valor.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(223, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 23)
        Label4.TabIndex = 7
        Label4.Text = "Valor do produto"
        ' 
        ' cb_categorias
        ' 
        cb_categorias.FormattingEnabled = True
        cb_categorias.Location = New Point(223, 171)
        cb_categorias.Margin = New Padding(3, 5, 3, 5)
        cb_categorias.Name = "cb_categorias"
        cb_categorias.Size = New Size(175, 31)
        cb_categorias.TabIndex = 9
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = SystemColors.Window
        btn_add.Cursor = Cursors.Hand
        btn_add.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ActiveCaptionText
        btn_add.Image = CType(resources.GetObject("btn_add.Image"), Image)
        btn_add.ImageAlign = ContentAlignment.BottomCenter
        btn_add.Location = New Point(223, 286)
        btn_add.Margin = New Padding(3, 5, 3, 5)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(106, 73)
        btn_add.TabIndex = 15
        btn_add.Text = "Adicionar"
        btn_add.TextAlign = ContentAlignment.TopCenter
        btn_add.TextImageRelation = TextImageRelation.ImageAboveText
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.BackColor = SystemColors.Window
        btn_Cancelar.Cursor = Cursors.Hand
        btn_Cancelar.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText
        btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), Image)
        btn_Cancelar.ImageAlign = ContentAlignment.BottomCenter
        btn_Cancelar.Location = New Point(487, 286)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(103, 73)
        btn_Cancelar.TabIndex = 16
        btn_Cancelar.Text = "Cancelar"
        btn_Cancelar.TextAlign = ContentAlignment.TopCenter
        btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText
        btn_Cancelar.UseVisualStyleBackColor = False
        ' 
        ' formAddProduto
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(678, 371)
        Controls.Add(btn_Cancelar)
        Controls.Add(btn_add)
        Controls.Add(cb_categorias)
        Controls.Add(Label4)
        Controls.Add(input_valor)
        Controls.Add(Label3)
        Controls.Add(input_descricao)
        Controls.Add(Label2)
        Controls.Add(input_nome)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "formAddProduto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Adicionar Produtos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents input_descricao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents input_valor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_categorias As ComboBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_Cancelar As Button
End Class
