<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        PictureBox1 = New PictureBox()
        btn_login = New Button()
        lbl_word1quality = New Label()
        lbl_word2car = New Label()
        lbl_word3best = New Label()
        btn_register = New Button()
        lbl_name = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveBorder
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1116, 562)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btn_login
        ' 
        btn_login.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_login.BackColor = Color.Transparent
        btn_login.FlatAppearance.BorderColor = Color.White
        btn_login.FlatAppearance.MouseOverBackColor = Color.IndianRed
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Location = New Point(920, 58)
        btn_login.Margin = New Padding(3, 2, 3, 2)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(103, 26)
        btn_login.TabIndex = 2
        btn_login.Text = "LOG IN"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' lbl_word1quality
        ' 
        lbl_word1quality.Anchor = AnchorStyles.Left
        lbl_word1quality.BackColor = Color.Transparent
        lbl_word1quality.Location = New Point(102, 181)
        lbl_word1quality.Name = "lbl_word1quality"
        lbl_word1quality.Size = New Size(254, 29)
        lbl_word1quality.TabIndex = 3
        lbl_word1quality.Text = "QUALITY AT A BEST PRICE?"
        lbl_word1quality.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_word2car
        ' 
        lbl_word2car.Anchor = AnchorStyles.Left
        lbl_word2car.BackColor = Color.Transparent
        lbl_word2car.Location = New Point(94, 210)
        lbl_word2car.Name = "lbl_word2car"
        lbl_word2car.Size = New Size(640, 145)
        lbl_word2car.TabIndex = 4
        lbl_word2car.Text = "CHOOSE YOUR CAR NOW! "
        lbl_word2car.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_word3best
        ' 
        lbl_word3best.Anchor = AnchorStyles.Left
        lbl_word3best.BackColor = Color.Transparent
        lbl_word3best.Location = New Point(86, 355)
        lbl_word3best.Name = "lbl_word3best"
        lbl_word3best.Size = New Size(254, 28)
        lbl_word3best.TabIndex = 5
        lbl_word3best.Text = "WE GIVE THE BEST JUST FOR YOU!!!"
        lbl_word3best.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_register
        ' 
        btn_register.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btn_register.FlatAppearance.BorderColor = Color.Black
        btn_register.FlatAppearance.MouseOverBackColor = Color.Black
        btn_register.FlatStyle = FlatStyle.Flat
        btn_register.ForeColor = Color.Red
        btn_register.Location = New Point(111, 472)
        btn_register.Margin = New Padding(3, 2, 3, 2)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(168, 34)
        btn_register.TabIndex = 6
        btn_register.Text = ">>>REGISTER NOW"
        btn_register.UseVisualStyleBackColor = True
        ' 
        ' lbl_name
        ' 
        lbl_name.BackColor = Color.Transparent
        lbl_name.Location = New Point(94, 46)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(378, 68)
        lbl_name.TabIndex = 1
        lbl_name.Text = "Wheels4Rent"
        lbl_name.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1116, 562)
        Controls.Add(btn_register)
        Controls.Add(lbl_word3best)
        Controls.Add(lbl_word2car)
        Controls.Add(lbl_word1quality)
        Controls.Add(btn_login)
        Controls.Add(lbl_name)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_word1quality As Label
    Friend WithEvents lbl_word2car As Label
    Friend WithEvents lbl_word3best As Label
    Friend WithEvents btn_register As Button
    Friend WithEvents lbl_name As Label
End Class
