<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login
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
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents input_Username As TextBox
    Friend WithEvents input_Senha As TextBox

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login))
        UsernameLabel = New Label()
        input_Username = New TextBox()
        input_Senha = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Cancel = New Button()
        OK = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        UsernameLabel.ForeColor = SystemColors.ButtonHighlight
        UsernameLabel.Location = New Point(180, 4)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(82, 35)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' input_Username
        ' 
        input_Username.Location = New Point(180, 35)
        input_Username.Margin = New Padding(3, 5, 3, 5)
        input_Username.Name = "input_Username"
        input_Username.Size = New Size(251, 27)
        input_Username.TabIndex = 1
        ' 
        ' input_Senha
        ' 
        input_Senha.Location = New Point(180, 103)
        input_Senha.Margin = New Padding(3, 5, 3, 5)
        input_Senha.Name = "input_Senha"
        input_Senha.PasswordChar = "*"c
        input_Senha.Size = New Size(251, 27)
        input_Senha.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(180, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 35)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(229, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 35)
        Label1.TabIndex = 9
        Label1.Text = "Não tem uma conta?"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = SystemColors.Window
        Cancel.Cursor = Cursors.Hand
        Cancel.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.ForeColor = SystemColors.ActiveCaptionText
        Cancel.Image = CType(resources.GetObject("Cancel.Image"), Image)
        Cancel.ImageAlign = ContentAlignment.MiddleRight
        Cancel.Location = New Point(317, 148)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(114, 56)
        Cancel.TabIndex = 18
        Cancel.Text = "Cancelar"
        Cancel.TextImageRelation = TextImageRelation.TextBeforeImage
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' OK
        ' 
        OK.BackColor = SystemColors.Window
        OK.Cursor = Cursors.Hand
        OK.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        OK.ForeColor = SystemColors.ActiveCaptionText
        OK.Image = CType(resources.GetObject("OK.Image"), Image)
        OK.ImageAlign = ContentAlignment.BottomRight
        OK.Location = New Point(180, 147)
        OK.Name = "OK"
        OK.Padding = New Padding(10)
        OK.Size = New Size(110, 56)
        OK.TabIndex = 19
        OK.Text = "Entrar"
        OK.TextImageRelation = TextImageRelation.TextBeforeImage
        OK.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(230, 240)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 47)
        Button1.TabIndex = 20
        Button1.Text = "Inscreva-se"
        Button1.TextImageRelation = TextImageRelation.TextBeforeImage
        Button1.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(514, 303)
        Controls.Add(Button1)
        Controls.Add(OK)
        Controls.Add(Cancel)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(input_Senha)
        Controls.Add(input_Username)
        Controls.Add(UsernameLabel)
        DoubleBuffered = True
        Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 5, 3, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Button1 As Button
End Class
