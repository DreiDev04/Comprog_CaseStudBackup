<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenV2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenV2))
        Panel4 = New Panel()
        btn_Exit = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        btn_Register = New Button()
        Label2 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button1 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button2 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Button3 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        btn_Login = New Button()
        Button4 = New Button()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Timer1 = New Timer(components)
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(btn_Exit)
        Panel4.Dock = DockStyle.Left
        Panel4.ForeColor = Color.Transparent
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(89, 523)
        Panel4.TabIndex = 6
        Panel4.Visible = False
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Dock = DockStyle.Bottom
        btn_Exit.FlatAppearance.BorderSize = 0
        btn_Exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold)
        btn_Exit.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_Exit.Image = CType(resources.GetObject("btn_Exit.Image"), Image)
        btn_Exit.ImageAlign = ContentAlignment.MiddleLeft
        btn_Exit.Location = New Point(0, 479)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(89, 44)
        btn_Exit.TabIndex = 2
        btn_Exit.Text = "Exit"
        btn_Exit.TextAlign = ContentAlignment.MiddleRight
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.92592573F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.96296F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.0288057F))
        TableLayoutPanel1.Controls.Add(btn_Register, 1, 7)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.Size = New Size(200, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btn_Register
        ' 
        btn_Register.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        btn_Register.Dock = DockStyle.Left
        btn_Register.FlatAppearance.BorderSize = 0
        btn_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        btn_Register.FlatStyle = FlatStyle.Flat
        btn_Register.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Register.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_Register.Image = CType(resources.GetObject("btn_Register.Image"), Image)
        btn_Register.ImageAlign = ContentAlignment.MiddleRight
        btn_Register.Location = New Point(14, 3)
        btn_Register.Name = "btn_Register"
        btn_Register.Size = New Size(160, 94)
        btn_Register.TabIndex = 1
        btn_Register.Text = "Register Now"
        btn_Register.TextAlign = ContentAlignment.MiddleLeft
        btn_Register.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label2.Location = New Point(14, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 180)
        Label2.TabIndex = 1
        Label2.Text = "FIND YOUR DREAM CAR" & vbCrLf & "FOR RENT TODAY!"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.92592573F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.96296F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.0288057F))
        TableLayoutPanel2.Controls.Add(Button1, 1, 7)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 8
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Button1.Dock = DockStyle.Left
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(14, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 94)
        Button1.TabIndex = 1
        Button1.Text = "Register Now"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label1.Location = New Point(14, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 180)
        Label1.TabIndex = 1
        Label1.Text = "FIND YOUR DREAM CAR" & vbCrLf & "FOR RENT TODAY!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Corbel", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label3.Location = New Point(0, -145)
        Label3.Name = "Label3"
        Label3.Size = New Size(375, 78)
        Label3.TabIndex = 0
        Label3.Text = "Wheel4Rent"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.92592573F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.96296F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.0288057F))
        TableLayoutPanel3.Controls.Add(Button2, 1, 7)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 8
        TableLayoutPanel3.Size = New Size(200, 100)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Button2.Dock = DockStyle.Left
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleRight
        Button2.Location = New Point(14, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 94)
        Button2.TabIndex = 1
        Button2.Text = "Register Now"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label4.Location = New Point(14, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 180)
        Label4.TabIndex = 1
        Label4.Text = "FIND YOUR DREAM CAR" & vbCrLf & "FOR RENT TODAY!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Label5.Dock = DockStyle.Bottom
        Label5.Font = New Font("Corbel", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label5.Location = New Point(0, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(375, 78)
        Label5.TabIndex = 0
        Label5.Text = "Wheel4Rent"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.BackColor = Color.Transparent
        TableLayoutPanel4.ColumnCount = 3
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5.92592573F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.96296F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.0288057F))
        TableLayoutPanel4.Controls.Add(Button3, 1, 7)
        TableLayoutPanel4.Controls.Add(Label6, 1, 1)
        TableLayoutPanel4.Controls.Add(Label7, 1, 3)
        TableLayoutPanel4.Controls.Add(Label8, 1, 5)
        TableLayoutPanel4.Dock = DockStyle.Top
        TableLayoutPanel4.Location = New Point(0, 145)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 9
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 14.7692308F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 26.6159687F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 3.041825F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 40.3508759F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 4.21052647F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 11.22807F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 16F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 44F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 79F))
        TableLayoutPanel4.Size = New Size(405, 426)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Button3.Dock = DockStyle.Left
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(27, 304)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 38)
        Button3.TabIndex = 1
        Button3.Text = "Register Now"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Dock = DockStyle.Left
        Label6.Font = New Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label6.Location = New Point(27, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(320, 76)
        Label6.TabIndex = 1
        Label6.Text = "FIND YOUR DREAM CAR" & vbCrLf & "FOR RENT TODAY!"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Dock = DockStyle.Left
        Label7.Font = New Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label7.Location = New Point(27, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(249, 115)
        Label7.TabIndex = 2
        Label7.Text = "Wheel4Rent’s simple " & vbCrLf & "interface provides " & vbCrLf & "opportunity to rent the finest " & vbCrLf & "cars in the city for an " & vbCrLf & "affordable prices.  "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Dock = DockStyle.Left
        Label8.Font = New Font("Corbel", 21F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label8.Location = New Point(27, 253)
        Label8.Name = "Label8"
        Label8.Size = New Size(326, 32)
        Label8.TabIndex = 3
        Label8.Text = "CREATING ADVENTURES"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(TableLayoutPanel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(711, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 562)
        Panel1.TabIndex = 5
        Panel1.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label5)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 56)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(405, 89)
        Panel3.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btn_Login)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(405, 56)
        Panel2.TabIndex = 1
        ' 
        ' btn_Login
        ' 
        btn_Login.Dock = DockStyle.Right
        btn_Login.FlatAppearance.BorderSize = 0
        btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        btn_Login.FlatStyle = FlatStyle.Flat
        btn_Login.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Login.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_Login.Image = CType(resources.GetObject("btn_Login.Image"), Image)
        btn_Login.ImageAlign = ContentAlignment.MiddleRight
        btn_Login.Location = New Point(292, 0)
        btn_Login.Name = "btn_Login"
        btn_Login.Padding = New Padding(5)
        btn_Login.Size = New Size(113, 56)
        btn_Login.TabIndex = 0
        btn_Login.Text = "Log In"
        btn_Login.TextAlign = ContentAlignment.MiddleLeft
        btn_Login.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Bottom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(0, 518)
        Button4.Name = "Button4"
        Button4.Size = New Size(89, 44)
        Button4.TabIndex = 2
        Button4.Text = "Exit"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(99, 537)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(919, 25)
        Panel5.TabIndex = 7
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Panel6.BackgroundImageLayout = ImageLayout.Stretch
        Panel6.Controls.Add(Panel7)
        Panel6.Location = New Point(-130, -34)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(179, 83)
        Panel6.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.BackgroundImageLayout = ImageLayout.Zoom
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(179, 83)
        Panel7.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Transparent
        Panel8.Controls.Add(Button4)
        Panel8.Dock = DockStyle.Left
        Panel8.ForeColor = Color.Transparent
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(89, 562)
        Panel8.TabIndex = 6
        Panel8.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 15
        ' 
        ' SplashScreenV2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Your_paragraph_text
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1116, 562)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        Controls.Add(Panel8)
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreenV2"
        StartPosition = FormStartPosition.CenterScreen
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_Exit As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_Register As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Login As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Timer1 As Timer
End Class
