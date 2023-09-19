<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCadastro
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formCadastro))
        input_nomeUsuario = New TextBox()
        Label1 = New Label()
        input_Username = New TextBox()
        input_Senha = New TextBox()
        input_SenhaRepetida = New TextBox()
        btn_Cancelar = New Button()
        btn_criarConta = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' input_nomeUsuario
        ' 
        input_nomeUsuario.Location = New Point(209, 48)
        input_nomeUsuario.Margin = New Padding(3, 5, 3, 5)
        input_nomeUsuario.Name = "input_nomeUsuario"
        input_nomeUsuario.Size = New Size(367, 27)
        input_nomeUsuario.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(209, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 23)
        Label1.TabIndex = 1
        Label1.Text = "Nome completo"
        ' 
        ' input_Username
        ' 
        input_Username.Location = New Point(209, 112)
        input_Username.Margin = New Padding(3, 5, 3, 5)
        input_Username.Name = "input_Username"
        input_Username.Size = New Size(367, 27)
        input_Username.TabIndex = 3
        ' 
        ' input_Senha
        ' 
        input_Senha.Location = New Point(209, 176)
        input_Senha.Margin = New Padding(3, 5, 3, 5)
        input_Senha.Name = "input_Senha"
        input_Senha.PasswordChar = "*"c
        input_Senha.Size = New Size(367, 27)
        input_Senha.TabIndex = 5
        ' 
        ' input_SenhaRepetida
        ' 
        input_SenhaRepetida.Location = New Point(209, 243)
        input_SenhaRepetida.Margin = New Padding(3, 5, 3, 5)
        input_SenhaRepetida.Name = "input_SenhaRepetida"
        input_SenhaRepetida.PasswordChar = "*"c
        input_SenhaRepetida.Size = New Size(367, 27)
        input_SenhaRepetida.TabIndex = 7
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.BackColor = SystemColors.Window
        btn_Cancelar.Cursor = Cursors.Hand
        btn_Cancelar.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText
        btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), Image)
        btn_Cancelar.ImageAlign = ContentAlignment.BottomCenter
        btn_Cancelar.Location = New Point(473, 293)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(103, 73)
        btn_Cancelar.TabIndex = 17
        btn_Cancelar.Text = "Cancelar"
        btn_Cancelar.TextAlign = ContentAlignment.TopCenter
        btn_Cancelar.TextImageRelation = TextImageRelation.ImageAboveText
        btn_Cancelar.UseVisualStyleBackColor = False
        ' 
        ' btn_criarConta
        ' 
        btn_criarConta.BackColor = SystemColors.Window
        btn_criarConta.Cursor = Cursors.Hand
        btn_criarConta.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btn_criarConta.ForeColor = SystemColors.ActiveCaptionText
        btn_criarConta.Image = CType(resources.GetObject("btn_criarConta.Image"), Image)
        btn_criarConta.ImageAlign = ContentAlignment.BottomCenter
        btn_criarConta.Location = New Point(209, 292)
        btn_criarConta.Name = "btn_criarConta"
        btn_criarConta.Size = New Size(103, 73)
        btn_criarConta.TabIndex = 18
        btn_criarConta.Text = "Criar conta"
        btn_criarConta.TextAlign = ContentAlignment.TopCenter
        btn_criarConta.TextImageRelation = TextImageRelation.ImageAboveText
        btn_criarConta.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(207, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 23)
        Label2.TabIndex = 19
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(207, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 23)
        Label3.TabIndex = 20
        Label3.Text = "Senha"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(209, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 23)
        Label4.TabIndex = 21
        Label4.Text = "Repita a senha"
        ' 
        ' formCadastro
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(667, 379)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_criarConta)
        Controls.Add(btn_Cancelar)
        Controls.Add(input_SenhaRepetida)
        Controls.Add(input_Senha)
        Controls.Add(input_Username)
        Controls.Add(Label1)
        Controls.Add(input_nomeUsuario)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        Name = "formCadastro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Criar Conta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents input_nomeUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents input_Username As TextBox
    Friend WithEvents input_Senha As TextBox
    Friend WithEvents input_SenhaRepetida As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_criarConta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
