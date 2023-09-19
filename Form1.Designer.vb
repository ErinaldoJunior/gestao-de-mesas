<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        MenuStrip1 = New MenuStrip()
        ProdutosToolStripMenuItem = New ToolStripMenuItem()
        AdicionarProdutosToolStripMenuItem = New ToolStripMenuItem()
        RemoverProdutoToolStripMenuItem = New ToolStripMenuItem()
        RelayToolStripMenuItem = New ToolStripMenuItem()
        VendasToolStripMenuItem = New ToolStripMenuItem()
        PorDiaToolStripMenuItem = New ToolStripMenuItem()
        PorMêsToolStripMenuItem = New ToolStripMenuItem()
        PorAnoToolStripMenuItem = New ToolStripMenuItem()
        Button8 = New Button()
        txt_bemvindo = New Label()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(268, 75)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 86)
        Button1.TabIndex = 0
        Button1.Text = "MESA 1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(596, 85)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(84, 86)
        Button2.TabIndex = 1
        Button2.Text = "MESA 2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(850, 85)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 86)
        Button3.TabIndex = 2
        Button3.Text = "MESA 3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Green
        Button4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(441, 231)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(84, 86)
        Button4.TabIndex = 3
        Button4.Text = "MESA 4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Green
        Button5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(205, 343)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(84, 86)
        Button5.TabIndex = 4
        Button5.Text = "MESA 5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Green
        Button6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(475, 427)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(84, 86)
        Button6.TabIndex = 5
        Button6.Text = "MESA 6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Green
        Button7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = SystemColors.ButtonHighlight
        Button7.Location = New Point(687, 325)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(84, 86)
        Button7.TabIndex = 6
        Button7.Text = "MESA 7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProdutosToolStripMenuItem, RelayToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Table
        MenuStrip1.Location = New Point(0, 306)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 5, 0, 5)
        MenuStrip1.Size = New Size(144, 90)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        MenuStrip1.Visible = False
        ' 
        ' ProdutosToolStripMenuItem
        ' 
        ProdutosToolStripMenuItem.BackColor = Color.Transparent
        ProdutosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdicionarProdutosToolStripMenuItem, RemoverProdutoToolStripMenuItem})
        ProdutosToolStripMenuItem.ForeColor = Color.Black
        ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        ProdutosToolStripMenuItem.Size = New Size(122, 40)
        ProdutosToolStripMenuItem.Text = "Produtos"
        ' 
        ' AdicionarProdutosToolStripMenuItem
        ' 
        AdicionarProdutosToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AdicionarProdutosToolStripMenuItem.BackgroundImage"), Image)
        AdicionarProdutosToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        AdicionarProdutosToolStripMenuItem.Name = "AdicionarProdutosToolStripMenuItem"
        AdicionarProdutosToolStripMenuItem.Size = New Size(294, 40)
        AdicionarProdutosToolStripMenuItem.Text = "Adicionar produto"
        ' 
        ' RemoverProdutoToolStripMenuItem
        ' 
        RemoverProdutoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("RemoverProdutoToolStripMenuItem.BackgroundImage"), Image)
        RemoverProdutoToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        RemoverProdutoToolStripMenuItem.Name = "RemoverProdutoToolStripMenuItem"
        RemoverProdutoToolStripMenuItem.Size = New Size(294, 40)
        RemoverProdutoToolStripMenuItem.Text = "Remover produto"
        ' 
        ' RelayToolStripMenuItem
        ' 
        RelayToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VendasToolStripMenuItem})
        RelayToolStripMenuItem.ForeColor = Color.Black
        RelayToolStripMenuItem.Name = "RelayToolStripMenuItem"
        RelayToolStripMenuItem.Size = New Size(134, 40)
        RelayToolStripMenuItem.Text = "Relatórios"
        ' 
        ' VendasToolStripMenuItem
        ' 
        VendasToolStripMenuItem.BackgroundImage = CType(resources.GetObject("VendasToolStripMenuItem.BackgroundImage"), Image)
        VendasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PorDiaToolStripMenuItem, PorMêsToolStripMenuItem, PorAnoToolStripMenuItem})
        VendasToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        VendasToolStripMenuItem.Size = New Size(183, 40)
        VendasToolStripMenuItem.Text = "Vendas"
        ' 
        ' PorDiaToolStripMenuItem
        ' 
        PorDiaToolStripMenuItem.BackgroundImage = CType(resources.GetObject("PorDiaToolStripMenuItem.BackgroundImage"), Image)
        PorDiaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        PorDiaToolStripMenuItem.Name = "PorDiaToolStripMenuItem"
        PorDiaToolStripMenuItem.Size = New Size(186, 40)
        PorDiaToolStripMenuItem.Text = "Por dia"
        ' 
        ' PorMêsToolStripMenuItem
        ' 
        PorMêsToolStripMenuItem.BackgroundImage = CType(resources.GetObject("PorMêsToolStripMenuItem.BackgroundImage"), Image)
        PorMêsToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        PorMêsToolStripMenuItem.Name = "PorMêsToolStripMenuItem"
        PorMêsToolStripMenuItem.Size = New Size(186, 40)
        PorMêsToolStripMenuItem.Text = "Por mês"
        ' 
        ' PorAnoToolStripMenuItem
        ' 
        PorAnoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("PorAnoToolStripMenuItem.BackgroundImage"), Image)
        PorAnoToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight
        PorAnoToolStripMenuItem.Name = "PorAnoToolStripMenuItem"
        PorAnoToolStripMenuItem.Size = New Size(186, 40)
        PorAnoToolStripMenuItem.Text = "Por ano"
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), Image)
        Button8.BackgroundImageLayout = ImageLayout.Center
        Button8.Location = New Point(23, 510)
        Button8.Name = "Button8"
        Button8.Size = New Size(76, 74)
        Button8.TabIndex = 8
        Button8.UseVisualStyleBackColor = False
        ' 
        ' txt_bemvindo
        ' 
        txt_bemvindo.AutoSize = True
        txt_bemvindo.BackColor = Color.Transparent
        txt_bemvindo.Font = New Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txt_bemvindo.ForeColor = SystemColors.ButtonHighlight
        txt_bemvindo.Location = New Point(16, 327)
        txt_bemvindo.Name = "txt_bemvindo"
        txt_bemvindo.Size = New Size(129, 31)
        txt_bemvindo.TabIndex = 9
        txt_bemvindo.Text = "BEM-VINDO!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1195, 605)
        Controls.Add(txt_bemvindo)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Font = New Font("Benfica 2023 2024", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restaurante RW | Mesas"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdicionarProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoverProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorDiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorMêsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorAnoToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button8 As Button
    Friend WithEvents txt_bemvindo As Label
End Class
