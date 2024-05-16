<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdmin
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
        Dim Label2 As Label
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        btn_login = New Button()
        TableLayoutPanel5 = New TableLayoutPanel()
        txtb_password = New TextBox()
        Label1 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        txtb_userName = New TextBox()
        lnklbl_admin = New LinkLabel()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label2.Location = New Point(3, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(358, 15)
        Label2.TabIndex = 999
        Label2.Text = "Welcome to Wheels4Rent"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(Panel1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(464, 681)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(199), CByte(199), CByte(204))
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Location = New Point(49, 71)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 538)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel7, 0, 8)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 0, 6)
        TableLayoutPanel2.Controls.Add(Label1, 0, 1)
        TableLayoutPanel2.Controls.Add(Label2, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 4)
        TableLayoutPanel2.Controls.Add(lnklbl_admin, 0, 12)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 14
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 3.70837712F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 9.219314F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 2.843514F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 5.883886F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 9.219314F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 1.02211869F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10.109581F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 1.1159482F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 13.099515F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.7499676F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12.8211536F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 1.86489511F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 3.762426F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.579984F))
        TableLayoutPanel2.Size = New Size(364, 538)
        TableLayoutPanel2.TabIndex = 999
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 3
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel7.Controls.Add(btn_login, 1, 0)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 231)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(358, 64)
        TableLayoutPanel7.TabIndex = 0
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_login.Dock = DockStyle.Fill
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_login.ForeColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        btn_login.Location = New Point(56, 3)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(244, 58)
        btn_login.TabIndex = 12
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel5.Controls.Add(txtb_password, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 171)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(358, 48)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' txtb_password
        ' 
        txtb_password.Dock = DockStyle.Fill
        txtb_password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtb_password.Location = New Point(38, 3)
        txtb_password.Name = "txtb_password"
        txtb_password.PasswordChar = "*"c
        txtb_password.PlaceholderText = "Password"
        txtb_password.Size = New Size(280, 29)
        txtb_password.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Corbel", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        Label1.Location = New Point(3, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(358, 49)
        Label1.TabIndex = 999
        Label1.Text = "Admin Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Controls.Add(txtb_userName, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 117)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(358, 43)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' txtb_userName
        ' 
        txtb_userName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtb_userName.Location = New Point(38, 3)
        txtb_userName.Name = "txtb_userName"
        txtb_userName.PlaceholderText = "Username"
        txtb_userName.Size = New Size(280, 29)
        txtb_userName.TabIndex = 10
        ' 
        ' lnklbl_admin
        ' 
        lnklbl_admin.AutoSize = True
        lnklbl_admin.Dock = DockStyle.Fill
        lnklbl_admin.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnklbl_admin.LinkColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lnklbl_admin.Location = New Point(3, 466)
        lnklbl_admin.Name = "lnklbl_admin"
        lnklbl_admin.Size = New Size(358, 20)
        lnklbl_admin.TabIndex = 14
        lnklbl_admin.TabStop = True
        lnklbl_admin.Text = "Go back to Login"
        lnklbl_admin.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 681)
        Controls.Add(TableLayoutPanel1)
        MaximumSize = New Size(480, 720)
        MinimumSize = New Size(480, 720)
        Name = "LoginAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginAdmin"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btn_login As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtb_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtb_userName As TextBox
    Friend WithEvents lnklbl_admin As LinkLabel
End Class
