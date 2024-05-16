<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        tlp_SignUpBorder = New TableLayoutPanel()
        Panel4 = New Panel()
        Panel1 = New Panel()
        tlp_Main = New TableLayoutPanel()
        lbl_GettingStart = New Label()
        lbl_Name = New Label()
        lbl_Age = New Label()
        lbl_Birthday = New Label()
        lbl_LnFnMi = New Label()
        lbl_Address = New Label()
        lbl_Sex = New Label()
        lbl_Username = New Label()
        lbl_Email = New Label()
        lbl_Password = New Label()
        lbl_ConfPassword = New Label()
        txtb_Name = New TextBox()
        txtb_Age = New TextBox()
        flp_Sex = New FlowLayoutPanel()
        rbtn_Male = New RadioButton()
        rbtn_Female = New RadioButton()
        txtb_Address = New TextBox()
        txtb_Username = New TextBox()
        txtb_Email = New TextBox()
        dtp_Birthday = New DateTimePicker()
        txtb_Password = New TextBox()
        txtb_ConfPassword = New TextBox()
        btn_Confirm = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        lbl_AlreadyHave = New Label()
        lklbl_ClickHere = New LinkLabel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label13 = New Label()
        Label14 = New Label()
        tlp_SignUpBorder.SuspendLayout()
        Panel1.SuspendLayout()
        tlp_Main.SuspendLayout()
        flp_Sex.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlp_SignUpBorder
        ' 
        tlp_SignUpBorder.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        tlp_SignUpBorder.ColumnCount = 3
        tlp_SignUpBorder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tlp_SignUpBorder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        tlp_SignUpBorder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tlp_SignUpBorder.Controls.Add(Panel4, 2, 2)
        tlp_SignUpBorder.Controls.Add(Panel1, 1, 1)
        tlp_SignUpBorder.Controls.Add(Panel2, 2, 1)
        tlp_SignUpBorder.Controls.Add(Panel3, 1, 2)
        tlp_SignUpBorder.Dock = DockStyle.Fill
        tlp_SignUpBorder.Location = New Point(0, 0)
        tlp_SignUpBorder.Margin = New Padding(0)
        tlp_SignUpBorder.Name = "tlp_SignUpBorder"
        tlp_SignUpBorder.RowCount = 3
        tlp_SignUpBorder.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlp_SignUpBorder.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        tlp_SignUpBorder.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlp_SignUpBorder.Size = New Size(704, 441)
        tlp_SignUpBorder.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Panel4.Location = New Point(633, 396)
        Panel4.Margin = New Padding(0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(20, 20)
        Panel4.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(199), CByte(199), CByte(199))
        Panel1.Controls.Add(tlp_Main)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(73, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(557, 346)
        Panel1.TabIndex = 0
        ' 
        ' tlp_Main
        ' 
        tlp_Main.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        tlp_Main.ColumnCount = 3
        tlp_Main.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlp_Main.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlp_Main.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        tlp_Main.Controls.Add(lbl_GettingStart, 0, 1)
        tlp_Main.Controls.Add(lbl_Name, 0, 3)
        tlp_Main.Controls.Add(lbl_Age, 1, 3)
        tlp_Main.Controls.Add(lbl_Birthday, 2, 3)
        tlp_Main.Controls.Add(lbl_LnFnMi, 0, 5)
        tlp_Main.Controls.Add(lbl_Address, 0, 6)
        tlp_Main.Controls.Add(lbl_Sex, 1, 6)
        tlp_Main.Controls.Add(lbl_Username, 0, 9)
        tlp_Main.Controls.Add(lbl_Email, 0, 12)
        tlp_Main.Controls.Add(lbl_Password, 1, 9)
        tlp_Main.Controls.Add(lbl_ConfPassword, 2, 9)
        tlp_Main.Controls.Add(txtb_Name, 0, 4)
        tlp_Main.Controls.Add(txtb_Age, 1, 4)
        tlp_Main.Controls.Add(flp_Sex, 1, 7)
        tlp_Main.Controls.Add(txtb_Address, 0, 7)
        tlp_Main.Controls.Add(txtb_Username, 0, 10)
        tlp_Main.Controls.Add(txtb_Email, 0, 13)
        tlp_Main.Controls.Add(dtp_Birthday, 2, 4)
        tlp_Main.Controls.Add(txtb_Password, 1, 10)
        tlp_Main.Controls.Add(txtb_ConfPassword, 2, 10)
        tlp_Main.Controls.Add(btn_Confirm, 2, 15)
        tlp_Main.Controls.Add(FlowLayoutPanel1, 2, 16)
        tlp_Main.Controls.Add(Panel5, 1, 15)
        tlp_Main.Dock = DockStyle.Fill
        tlp_Main.Location = New Point(0, 0)
        tlp_Main.Margin = New Padding(0, 3, 3, 0)
        tlp_Main.Name = "tlp_Main"
        tlp_Main.Padding = New Padding(15, 0, 8, 0)
        tlp_Main.RowCount = 17
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 3.01369858F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 9.248555F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 3.17919064F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 7.803468F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 2.601156F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.49132967F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 4.913295F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 5.882352F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 6.35838127F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 12.7167625F))
        tlp_Main.RowStyles.Add(New RowStyle(SizeType.Percent, 3.468208F))
        tlp_Main.Size = New Size(557, 346)
        tlp_Main.TabIndex = 0
        ' 
        ' lbl_GettingStart
        ' 
        lbl_GettingStart.AutoSize = True
        lbl_GettingStart.Dock = DockStyle.Fill
        lbl_GettingStart.Font = New Font("Corbel", 18F, FontStyle.Bold)
        lbl_GettingStart.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_GettingStart.Location = New Point(18, 10)
        lbl_GettingStart.Name = "lbl_GettingStart"
        lbl_GettingStart.Size = New Size(172, 32)
        lbl_GettingStart.TabIndex = 0
        lbl_GettingStart.Text = "Getting Started"
        ' 
        ' lbl_Name
        ' 
        lbl_Name.AutoSize = True
        lbl_Name.Dock = DockStyle.Fill
        lbl_Name.Font = New Font("Cambria", 11.25F)
        lbl_Name.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Name.Location = New Point(18, 53)
        lbl_Name.Name = "lbl_Name"
        lbl_Name.Size = New Size(172, 20)
        lbl_Name.TabIndex = 1
        lbl_Name.Text = "Name"
        lbl_Name.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Age
        ' 
        lbl_Age.AutoSize = True
        lbl_Age.Dock = DockStyle.Fill
        lbl_Age.Font = New Font("Cambria", 11.25F)
        lbl_Age.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Age.Location = New Point(196, 53)
        lbl_Age.Name = "lbl_Age"
        lbl_Age.Size = New Size(172, 20)
        lbl_Age.TabIndex = 2
        lbl_Age.Text = "Age"
        lbl_Age.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Birthday
        ' 
        lbl_Birthday.AutoSize = True
        lbl_Birthday.Dock = DockStyle.Fill
        lbl_Birthday.Font = New Font("Cambria", 11.25F)
        lbl_Birthday.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Birthday.Location = New Point(374, 53)
        lbl_Birthday.Name = "lbl_Birthday"
        lbl_Birthday.Size = New Size(172, 20)
        lbl_Birthday.TabIndex = 3
        lbl_Birthday.Text = "Birthday"
        lbl_Birthday.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_LnFnMi
        ' 
        lbl_LnFnMi.AutoSize = True
        lbl_LnFnMi.BackColor = Color.Transparent
        lbl_LnFnMi.Dock = DockStyle.Top
        lbl_LnFnMi.Font = New Font("Franklin Gothic Medium", 7.5F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_LnFnMi.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_LnFnMi.ImageAlign = ContentAlignment.MiddleLeft
        lbl_LnFnMi.Location = New Point(15, 98)
        lbl_LnFnMi.Margin = New Padding(0, 5, 0, 0)
        lbl_LnFnMi.Name = "lbl_LnFnMi"
        lbl_LnFnMi.Size = New Size(178, 14)
        lbl_LnFnMi.TabIndex = 4
        lbl_LnFnMi.Text = "First Name/ Last Name"
        ' 
        ' lbl_Address
        ' 
        lbl_Address.AutoSize = True
        lbl_Address.Dock = DockStyle.Fill
        lbl_Address.Font = New Font("Cambria", 11.25F)
        lbl_Address.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Address.Location = New Point(18, 113)
        lbl_Address.Name = "lbl_Address"
        lbl_Address.Size = New Size(172, 20)
        lbl_Address.TabIndex = 5
        lbl_Address.Text = "Address"
        lbl_Address.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Sex
        ' 
        lbl_Sex.AutoSize = True
        lbl_Sex.Dock = DockStyle.Fill
        lbl_Sex.Font = New Font("Cambria", 11.25F)
        lbl_Sex.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Sex.Location = New Point(196, 113)
        lbl_Sex.Name = "lbl_Sex"
        lbl_Sex.Size = New Size(172, 20)
        lbl_Sex.TabIndex = 6
        lbl_Sex.Text = "Sex"
        lbl_Sex.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Username
        ' 
        lbl_Username.AutoSize = True
        lbl_Username.Dock = DockStyle.Fill
        lbl_Username.Font = New Font("Cambria", 11.25F)
        lbl_Username.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Username.Location = New Point(18, 169)
        lbl_Username.Name = "lbl_Username"
        lbl_Username.Size = New Size(172, 20)
        lbl_Username.TabIndex = 7
        lbl_Username.Text = "Username"
        lbl_Username.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Email
        ' 
        lbl_Email.AutoSize = True
        lbl_Email.Dock = DockStyle.Fill
        lbl_Email.Font = New Font("Cambria", 11.25F)
        lbl_Email.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Email.Location = New Point(18, 228)
        lbl_Email.Name = "lbl_Email"
        lbl_Email.Size = New Size(172, 17)
        lbl_Email.TabIndex = 8
        lbl_Email.Text = "Email"
        lbl_Email.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_Password
        ' 
        lbl_Password.AutoSize = True
        lbl_Password.Dock = DockStyle.Fill
        lbl_Password.Font = New Font("Cambria", 11.25F)
        lbl_Password.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_Password.Location = New Point(196, 169)
        lbl_Password.Name = "lbl_Password"
        lbl_Password.Size = New Size(172, 20)
        lbl_Password.TabIndex = 10
        lbl_Password.Text = "Password"
        lbl_Password.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lbl_ConfPassword
        ' 
        lbl_ConfPassword.AutoSize = True
        lbl_ConfPassword.Dock = DockStyle.Fill
        lbl_ConfPassword.Font = New Font("Cambria", 11.25F)
        lbl_ConfPassword.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_ConfPassword.Location = New Point(374, 169)
        lbl_ConfPassword.Name = "lbl_ConfPassword"
        lbl_ConfPassword.Size = New Size(172, 20)
        lbl_ConfPassword.TabIndex = 11
        lbl_ConfPassword.Text = "Confirm Password"
        lbl_ConfPassword.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtb_Name
        ' 
        txtb_Name.Dock = DockStyle.Fill
        txtb_Name.Location = New Point(18, 76)
        txtb_Name.Margin = New Padding(3, 3, 20, 3)
        txtb_Name.Name = "txtb_Name"
        txtb_Name.Size = New Size(155, 23)
        txtb_Name.TabIndex = 0
        ' 
        ' txtb_Age
        ' 
        txtb_Age.Dock = DockStyle.Fill
        txtb_Age.Location = New Point(196, 76)
        txtb_Age.Margin = New Padding(3, 3, 90, 3)
        txtb_Age.Name = "txtb_Age"
        txtb_Age.Size = New Size(85, 23)
        txtb_Age.TabIndex = 1
        ' 
        ' flp_Sex
        ' 
        flp_Sex.Controls.Add(rbtn_Male)
        flp_Sex.Controls.Add(rbtn_Female)
        flp_Sex.Dock = DockStyle.Fill
        flp_Sex.Location = New Point(194, 134)
        flp_Sex.Margin = New Padding(1)
        flp_Sex.Name = "flp_Sex"
        flp_Sex.Size = New Size(176, 25)
        flp_Sex.TabIndex = 14
        ' 
        ' rbtn_Male
        ' 
        rbtn_Male.AutoSize = True
        rbtn_Male.Font = New Font("Cascadia Mono", 9F)
        rbtn_Male.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        rbtn_Male.Location = New Point(3, 3)
        rbtn_Male.Name = "rbtn_Male"
        rbtn_Male.Size = New Size(53, 20)
        rbtn_Male.TabIndex = 4
        rbtn_Male.TabStop = True
        rbtn_Male.Text = "Male"
        rbtn_Male.UseVisualStyleBackColor = True
        ' 
        ' rbtn_Female
        ' 
        rbtn_Female.AutoSize = True
        rbtn_Female.Font = New Font("Cascadia Mono", 9F)
        rbtn_Female.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        rbtn_Female.Location = New Point(62, 3)
        rbtn_Female.Name = "rbtn_Female"
        rbtn_Female.Size = New Size(67, 20)
        rbtn_Female.TabIndex = 5
        rbtn_Female.TabStop = True
        rbtn_Female.Text = "Female"
        rbtn_Female.UseVisualStyleBackColor = True
        ' 
        ' txtb_Address
        ' 
        txtb_Address.Dock = DockStyle.Fill
        txtb_Address.Location = New Point(18, 136)
        txtb_Address.Margin = New Padding(3, 3, 20, 3)
        txtb_Address.Name = "txtb_Address"
        txtb_Address.Size = New Size(155, 23)
        txtb_Address.TabIndex = 3
        ' 
        ' txtb_Username
        ' 
        txtb_Username.Dock = DockStyle.Fill
        txtb_Username.Location = New Point(18, 192)
        txtb_Username.Margin = New Padding(3, 3, 20, 3)
        txtb_Username.Name = "txtb_Username"
        txtb_Username.Size = New Size(155, 23)
        txtb_Username.TabIndex = 6
        ' 
        ' txtb_Email
        ' 
        txtb_Email.Dock = DockStyle.Fill
        txtb_Email.Location = New Point(18, 248)
        txtb_Email.Margin = New Padding(3, 3, 20, 3)
        txtb_Email.Name = "txtb_Email"
        txtb_Email.Size = New Size(155, 23)
        txtb_Email.TabIndex = 9
        ' 
        ' dtp_Birthday
        ' 
        dtp_Birthday.Dock = DockStyle.Fill
        dtp_Birthday.Format = DateTimePickerFormat.Short
        dtp_Birthday.Location = New Point(374, 76)
        dtp_Birthday.Margin = New Padding(3, 3, 20, 3)
        dtp_Birthday.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        dtp_Birthday.Name = "dtp_Birthday"
        dtp_Birthday.Size = New Size(155, 23)
        dtp_Birthday.TabIndex = 2
        dtp_Birthday.Value = New Date(1753, 1, 1, 0, 0, 0, 0)
        ' 
        ' txtb_Password
        ' 
        txtb_Password.Dock = DockStyle.Fill
        txtb_Password.Location = New Point(196, 192)
        txtb_Password.Margin = New Padding(3, 3, 20, 3)
        txtb_Password.Name = "txtb_Password"
        txtb_Password.PasswordChar = "*"c
        txtb_Password.Size = New Size(155, 23)
        txtb_Password.TabIndex = 7
        ' 
        ' txtb_ConfPassword
        ' 
        txtb_ConfPassword.Dock = DockStyle.Fill
        txtb_ConfPassword.Location = New Point(374, 192)
        txtb_ConfPassword.Margin = New Padding(3, 3, 20, 3)
        txtb_ConfPassword.Name = "txtb_ConfPassword"
        txtb_ConfPassword.PasswordChar = "*"c
        txtb_ConfPassword.Size = New Size(155, 23)
        txtb_ConfPassword.TabIndex = 8
        ' 
        ' btn_Confirm
        ' 
        btn_Confirm.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_Confirm.Dock = DockStyle.Fill
        btn_Confirm.FlatAppearance.BorderColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_Confirm.FlatAppearance.BorderSize = 2
        btn_Confirm.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_Confirm.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_Confirm.FlatStyle = FlatStyle.Flat
        btn_Confirm.Font = New Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Confirm.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_Confirm.Location = New Point(374, 290)
        btn_Confirm.Name = "btn_Confirm"
        btn_Confirm.Size = New Size(172, 38)
        btn_Confirm.TabIndex = 11
        btn_Confirm.Text = "Confirm"
        btn_Confirm.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(lbl_AlreadyHave)
        FlowLayoutPanel1.Controls.Add(lklbl_ClickHere)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(373, 333)
        FlowLayoutPanel1.Margin = New Padding(2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(174, 11)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' lbl_AlreadyHave
        ' 
        lbl_AlreadyHave.AutoSize = True
        lbl_AlreadyHave.Font = New Font("Franklin Gothic Medium", 6.75F)
        lbl_AlreadyHave.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        lbl_AlreadyHave.Location = New Point(3, 0)
        lbl_AlreadyHave.Name = "lbl_AlreadyHave"
        lbl_AlreadyHave.Size = New Size(105, 12)
        lbl_AlreadyHave.TabIndex = 9
        lbl_AlreadyHave.Text = "Already have an account?"
        lbl_AlreadyHave.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lklbl_ClickHere
        ' 
        lklbl_ClickHere.AutoSize = True
        lklbl_ClickHere.Font = New Font("Franklin Gothic Medium", 6.75F)
        lklbl_ClickHere.Location = New Point(114, 0)
        lklbl_ClickHere.Name = "lklbl_ClickHere"
        lklbl_ClickHere.Size = New Size(46, 12)
        lklbl_ClickHere.TabIndex = 12
        lklbl_ClickHere.TabStop = True
        lklbl_ClickHere.Text = "Click Here!"
        lklbl_ClickHere.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(196, 290)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(172, 38)
        Panel5.TabIndex = 25
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(633, 64)
        Panel2.Margin = New Padding(0, 20, 3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(20, 329)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(90, 396)
        Panel3.Margin = New Padding(20, 0, 3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(540, 20)
        Panel3.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(Label13, 0, 1)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(200, 100)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Fill
        Label13.Location = New Point(3, 20)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 80)
        Label13.TabIndex = 0
        Label13.Text = "Getting Started"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Dock = DockStyle.Fill
        Label14.Location = New Point(3, 30)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 70)
        Label14.TabIndex = 1
        Label14.Text = "Name"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 441)
        Controls.Add(tlp_SignUpBorder)
        MaximumSize = New Size(1080, 720)
        MinimumSize = New Size(720, 480)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign up"
        tlp_SignUpBorder.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        tlp_Main.ResumeLayout(False)
        tlp_Main.PerformLayout()
        flp_Sex.ResumeLayout(False)
        flp_Sex.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlp_SignUpBorder As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tlp_Main As TableLayoutPanel
    Friend WithEvents lbl_GettingStart As Label
    Friend WithEvents lbl_Name As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Birthday As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents lbl_AlreadyHave As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_ConfPassword As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lklbl_ClickHere As LinkLabel
    Friend WithEvents txtb_Name As TextBox
    Friend WithEvents txtb_Age As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents flp_Sex As FlowLayoutPanel
    Friend WithEvents rbtn_Male As RadioButton
    Friend WithEvents rbtn_Female As RadioButton
    Friend WithEvents txtb_Address As TextBox
    Friend WithEvents txtb_Username As TextBox
    Friend WithEvents txtb_Email As TextBox
    Friend WithEvents dtp_Birthday As DateTimePicker
    Friend WithEvents txtb_Password As TextBox
    Friend WithEvents txtb_ConfPassword As TextBox
    Friend WithEvents btn_Confirm As Button
    Friend WithEvents lbl_LnFnMi As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
End Class
