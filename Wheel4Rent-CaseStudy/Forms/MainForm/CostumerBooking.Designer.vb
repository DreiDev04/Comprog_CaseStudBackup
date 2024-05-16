<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostumerBooking
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
        spltCont_main = New SplitContainer()
        flowCont_details = New FlowLayoutPanel()
        btn_addCredit = New Button()
        lbl_accCreds = New Label()
        lbl_navLogoTitle1 = New Label()
        tblLayout_body = New TableLayoutPanel()
        pnl_aside = New Panel()
        tbl_layoutAside = New TableLayoutPanel()
        btn_logOut = New Button()
        lbl_welcome = New Label()
        btn_booking = New Button()
        btn_rentCars = New Button()
        btn_billings = New Button()
        lbl_accountName = New Label()
        Panel1 = New Panel()
        tabCtrl_body = New TabControl()
        TabPage4 = New TabPage()
        Panel3 = New Panel()
        lbl_subHero = New Label()
        lbl_heroTitle = New Label()
        pb_image = New PictureBox()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        btn_Rent = New Button()
        TabPage1 = New TabPage()
        tblLayout_RentCars = New TableLayoutPanel()
        flp_rentCarsMain = New FlowLayoutPanel()
        Panel5 = New Panel()
        Label1 = New Label()
        TabPage2 = New TabPage()
        flp_billing = New FlowLayoutPanel()
        TabPage3 = New TabPage()
        flp_booking = New FlowLayoutPanel()
        CType(spltCont_main, ComponentModel.ISupportInitialize).BeginInit()
        spltCont_main.Panel1.SuspendLayout()
        spltCont_main.Panel2.SuspendLayout()
        spltCont_main.SuspendLayout()
        flowCont_details.SuspendLayout()
        tblLayout_body.SuspendLayout()
        pnl_aside.SuspendLayout()
        tbl_layoutAside.SuspendLayout()
        Panel1.SuspendLayout()
        tabCtrl_body.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(pb_image, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabPage1.SuspendLayout()
        tblLayout_RentCars.SuspendLayout()
        Panel5.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' spltCont_main
        ' 
        spltCont_main.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        spltCont_main.Dock = DockStyle.Fill
        spltCont_main.Location = New Point(0, 0)
        spltCont_main.Name = "spltCont_main"
        spltCont_main.Orientation = Orientation.Horizontal
        ' 
        ' spltCont_main.Panel1
        ' 
        spltCont_main.Panel1.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        spltCont_main.Panel1.Controls.Add(flowCont_details)
        spltCont_main.Panel1.Controls.Add(lbl_navLogoTitle1)
        spltCont_main.Panel1MinSize = 60
        ' 
        ' spltCont_main.Panel2
        ' 
        spltCont_main.Panel2.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        spltCont_main.Panel2.Controls.Add(tblLayout_body)
        spltCont_main.Panel2MinSize = 60
        spltCont_main.Size = New Size(1064, 681)
        spltCont_main.SplitterDistance = 60
        spltCont_main.SplitterWidth = 1
        spltCont_main.TabIndex = 0
        ' 
        ' flowCont_details
        ' 
        flowCont_details.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        flowCont_details.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flowCont_details.Controls.Add(btn_addCredit)
        flowCont_details.Controls.Add(lbl_accCreds)
        flowCont_details.FlowDirection = FlowDirection.RightToLeft
        flowCont_details.Location = New Point(603, 9)
        flowCont_details.Margin = New Padding(0)
        flowCont_details.Name = "flowCont_details"
        flowCont_details.RightToLeft = RightToLeft.No
        flowCont_details.Size = New Size(452, 41)
        flowCont_details.TabIndex = 4
        ' 
        ' btn_addCredit
        ' 
        btn_addCredit.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        btn_addCredit.FlatStyle = FlatStyle.Popup
        btn_addCredit.Font = New Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_addCredit.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        btn_addCredit.Location = New Point(349, 3)
        btn_addCredit.Name = "btn_addCredit"
        btn_addCredit.Size = New Size(100, 38)
        btn_addCredit.TabIndex = 4
        btn_addCredit.Text = "Add Credit"
        btn_addCredit.UseVisualStyleBackColor = False
        ' 
        ' lbl_accCreds
        ' 
        lbl_accCreds.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_accCreds.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        lbl_accCreds.Location = New Point(108, 0)
        lbl_accCreds.Name = "lbl_accCreds"
        lbl_accCreds.Size = New Size(235, 44)
        lbl_accCreds.TabIndex = 2
        lbl_accCreds.Text = "0.0"
        lbl_accCreds.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_navLogoTitle1
        ' 
        lbl_navLogoTitle1.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_navLogoTitle1.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        lbl_navLogoTitle1.Location = New Point(14, 14)
        lbl_navLogoTitle1.Name = "lbl_navLogoTitle1"
        lbl_navLogoTitle1.Size = New Size(246, 32)
        lbl_navLogoTitle1.TabIndex = 1
        lbl_navLogoTitle1.Text = "Wheel4Rent"
        lbl_navLogoTitle1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tblLayout_body
        ' 
        tblLayout_body.ColumnCount = 2
        tblLayout_body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        tblLayout_body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 75F))
        tblLayout_body.Controls.Add(pnl_aside, 0, 0)
        tblLayout_body.Controls.Add(Panel1, 1, 0)
        tblLayout_body.Dock = DockStyle.Fill
        tblLayout_body.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        tblLayout_body.Location = New Point(0, 0)
        tblLayout_body.Margin = New Padding(0)
        tblLayout_body.Name = "tblLayout_body"
        tblLayout_body.RowCount = 1
        tblLayout_body.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tblLayout_body.Size = New Size(1064, 620)
        tblLayout_body.TabIndex = 0
        ' 
        ' pnl_aside
        ' 
        pnl_aside.BackColor = Color.RosyBrown
        pnl_aside.Controls.Add(tbl_layoutAside)
        pnl_aside.Dock = DockStyle.Fill
        pnl_aside.Location = New Point(3, 3)
        pnl_aside.Name = "pnl_aside"
        pnl_aside.Size = New Size(260, 614)
        pnl_aside.TabIndex = 0
        ' 
        ' tbl_layoutAside
        ' 
        tbl_layoutAside.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        tbl_layoutAside.ColumnCount = 1
        tbl_layoutAside.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tbl_layoutAside.Controls.Add(btn_logOut, 0, 6)
        tbl_layoutAside.Controls.Add(lbl_welcome, 0, 0)
        tbl_layoutAside.Controls.Add(btn_booking, 0, 4)
        tbl_layoutAside.Controls.Add(btn_rentCars, 0, 2)
        tbl_layoutAside.Controls.Add(btn_billings, 0, 3)
        tbl_layoutAside.Controls.Add(lbl_accountName, 0, 1)
        tbl_layoutAside.Dock = DockStyle.Fill
        tbl_layoutAside.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        tbl_layoutAside.Location = New Point(0, 0)
        tbl_layoutAside.Name = "tbl_layoutAside"
        tbl_layoutAside.RowCount = 7
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Percent, 22.22222F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Percent, 77.77778F))
        tbl_layoutAside.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        tbl_layoutAside.Size = New Size(260, 614)
        tbl_layoutAside.TabIndex = 0
        ' 
        ' btn_logOut
        ' 
        btn_logOut.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_logOut.Dock = DockStyle.Top
        btn_logOut.FlatStyle = FlatStyle.Flat
        btn_logOut.Font = New Font("Cascadia Mono", 12F)
        btn_logOut.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        btn_logOut.Location = New Point(0, 563)
        btn_logOut.Margin = New Padding(0)
        btn_logOut.Name = "btn_logOut"
        btn_logOut.Size = New Size(260, 50)
        btn_logOut.TabIndex = 2
        btn_logOut.Text = "Logout"
        btn_logOut.UseVisualStyleBackColor = False
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.Dock = DockStyle.Fill
        lbl_welcome.Font = New Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_welcome.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        lbl_welcome.Location = New Point(3, 0)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(254, 30)
        lbl_welcome.TabIndex = 0
        lbl_welcome.Text = "Welcome!"
        lbl_welcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_booking
        ' 
        btn_booking.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_booking.Dock = DockStyle.Top
        btn_booking.FlatStyle = FlatStyle.Flat
        btn_booking.Font = New Font("Cascadia Mono", 12F)
        btn_booking.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        btn_booking.Location = New Point(0, 215)
        btn_booking.Margin = New Padding(0)
        btn_booking.Name = "btn_booking"
        btn_booking.Size = New Size(260, 50)
        btn_booking.TabIndex = 1
        btn_booking.Text = "Booking"
        btn_booking.UseVisualStyleBackColor = False
        ' 
        ' btn_rentCars
        ' 
        btn_rentCars.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_rentCars.Dock = DockStyle.Top
        btn_rentCars.FlatStyle = FlatStyle.Flat
        btn_rentCars.Font = New Font("Cascadia Mono", 12F)
        btn_rentCars.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        btn_rentCars.Location = New Point(0, 115)
        btn_rentCars.Margin = New Padding(0)
        btn_rentCars.Name = "btn_rentCars"
        btn_rentCars.Size = New Size(260, 50)
        btn_rentCars.TabIndex = 0
        btn_rentCars.Text = "Rent Cars"
        btn_rentCars.UseVisualStyleBackColor = False
        ' 
        ' btn_billings
        ' 
        btn_billings.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_billings.Dock = DockStyle.Top
        btn_billings.FlatStyle = FlatStyle.Flat
        btn_billings.Font = New Font("Cascadia Mono", 12F)
        btn_billings.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        btn_billings.Location = New Point(0, 165)
        btn_billings.Margin = New Padding(0)
        btn_billings.Name = "btn_billings"
        btn_billings.Size = New Size(260, 50)
        btn_billings.TabIndex = 2
        btn_billings.Text = "Billings and Payment"
        btn_billings.UseVisualStyleBackColor = False
        ' 
        ' lbl_accountName
        ' 
        lbl_accountName.Dock = DockStyle.Fill
        lbl_accountName.Font = New Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_accountName.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        lbl_accountName.Location = New Point(3, 30)
        lbl_accountName.Name = "lbl_accountName"
        lbl_accountName.Size = New Size(254, 85)
        lbl_accountName.TabIndex = 1
        lbl_accountName.Text = "<Account Name>"
        lbl_accountName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(tabCtrl_body)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(269, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(792, 614)
        Panel1.TabIndex = 1
        ' 
        ' tabCtrl_body
        ' 
        tabCtrl_body.Alignment = TabAlignment.Bottom
        tabCtrl_body.Controls.Add(TabPage4)
        tabCtrl_body.Controls.Add(TabPage1)
        tabCtrl_body.Controls.Add(TabPage2)
        tabCtrl_body.Controls.Add(TabPage3)
        tabCtrl_body.Dock = DockStyle.Fill
        tabCtrl_body.Location = New Point(0, 0)
        tabCtrl_body.Multiline = True
        tabCtrl_body.Name = "tabCtrl_body"
        tabCtrl_body.SelectedIndex = 0
        tabCtrl_body.Size = New Size(792, 614)
        tabCtrl_body.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        TabPage4.Controls.Add(Panel3)
        TabPage4.Location = New Point(4, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(784, 586)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Default"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lbl_subHero)
        Panel3.Controls.Add(lbl_heroTitle)
        Panel3.Controls.Add(pb_image)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(778, 580)
        Panel3.TabIndex = 0
        ' 
        ' lbl_subHero
        ' 
        lbl_subHero.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_subHero.BackColor = Color.Transparent
        lbl_subHero.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_subHero.ForeColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        lbl_subHero.Location = New Point(77, 175)
        lbl_subHero.Name = "lbl_subHero"
        lbl_subHero.Size = New Size(396, 49)
        lbl_subHero.TabIndex = 3
        lbl_subHero.Text = "Experience convenience at your fingertips with our hassle-free car rental solutions."
        lbl_subHero.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_heroTitle
        ' 
        lbl_heroTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_heroTitle.BackColor = Color.Transparent
        lbl_heroTitle.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_heroTitle.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        lbl_heroTitle.Location = New Point(76, 52)
        lbl_heroTitle.Name = "lbl_heroTitle"
        lbl_heroTitle.Size = New Size(397, 100)
        lbl_heroTitle.TabIndex = 2
        lbl_heroTitle.Text = "Renting cars have " & vbLf & "never been this easy"
        lbl_heroTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pb_image
        ' 
        pb_image.Dock = DockStyle.Fill
        pb_image.Image = My.Resources.Resources.Hero_BG
        pb_image.Location = New Point(0, 0)
        pb_image.Name = "pb_image"
        pb_image.Size = New Size(778, 398)
        pb_image.SizeMode = PictureBoxSizeMode.Zoom
        pb_image.TabIndex = 1
        pb_image.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 398)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(778, 182)
        Panel4.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(btn_Rent, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(778, 182)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btn_Rent
        ' 
        btn_Rent.BackColor = Color.FromArgb(CByte(179), CByte(0), CByte(0))
        btn_Rent.Dock = DockStyle.Fill
        btn_Rent.FlatStyle = FlatStyle.Flat
        btn_Rent.Font = New Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Rent.ForeColor = Color.Transparent
        btn_Rent.Location = New Point(262, 63)
        btn_Rent.Name = "btn_Rent"
        btn_Rent.Size = New Size(253, 54)
        btn_Rent.TabIndex = 0
        btn_Rent.Text = "Rent a Car"
        btn_Rent.UseVisualStyleBackColor = False
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        TabPage1.Controls.Add(tblLayout_RentCars)
        TabPage1.Location = New Point(4, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(784, 586)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Rent Cars"
        ' 
        ' tblLayout_RentCars
        ' 
        tblLayout_RentCars.ColumnCount = 1
        tblLayout_RentCars.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tblLayout_RentCars.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        tblLayout_RentCars.Controls.Add(flp_rentCarsMain, 0, 1)
        tblLayout_RentCars.Controls.Add(Panel5, 0, 0)
        tblLayout_RentCars.Dock = DockStyle.Fill
        tblLayout_RentCars.Location = New Point(3, 3)
        tblLayout_RentCars.Name = "tblLayout_RentCars"
        tblLayout_RentCars.RowCount = 2
        tblLayout_RentCars.RowStyles.Add(New RowStyle(SizeType.Percent, 10.3448277F))
        tblLayout_RentCars.RowStyles.Add(New RowStyle(SizeType.Percent, 89.6551743F))
        tblLayout_RentCars.Size = New Size(778, 580)
        tblLayout_RentCars.TabIndex = 0
        ' 
        ' flp_rentCarsMain
        ' 
        flp_rentCarsMain.AutoScroll = True
        flp_rentCarsMain.BackColor = Color.Transparent
        flp_rentCarsMain.Dock = DockStyle.Fill
        flp_rentCarsMain.Location = New Point(3, 63)
        flp_rentCarsMain.Name = "flp_rentCarsMain"
        flp_rentCarsMain.Size = New Size(772, 514)
        flp_rentCarsMain.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkGray
        Panel5.Controls.Add(Label1)
        Panel5.Dock = DockStyle.Fill
        Panel5.ForeColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(3, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(772, 54)
        Panel5.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(3)
        Label1.Name = "Label1"
        Label1.Size = New Size(772, 54)
        Label1.TabIndex = 0
        Label1.Text = "Google's ad space"
        Label1.TextAlign = ContentAlignment.BottomRight
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        TabPage2.Controls.Add(flp_billing)
        TabPage2.Location = New Point(4, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(784, 586)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Billings"
        ' 
        ' flp_billing
        ' 
        flp_billing.AutoScroll = True
        flp_billing.AutoSize = True
        flp_billing.Dock = DockStyle.Fill
        flp_billing.Location = New Point(3, 3)
        flp_billing.Name = "flp_billing"
        flp_billing.Size = New Size(778, 580)
        flp_billing.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        TabPage3.Controls.Add(flp_booking)
        TabPage3.Location = New Point(4, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(784, 586)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Bookings"
        ' 
        ' flp_booking
        ' 
        flp_booking.AutoScroll = True
        flp_booking.BackColor = Color.Transparent
        flp_booking.Dock = DockStyle.Fill
        flp_booking.Location = New Point(3, 3)
        flp_booking.Name = "flp_booking"
        flp_booking.Size = New Size(778, 580)
        flp_booking.TabIndex = 0
        ' 
        ' CostumerBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 681)
        Controls.Add(spltCont_main)
        Name = "CostumerBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CostumerBooking"
        spltCont_main.Panel1.ResumeLayout(False)
        spltCont_main.Panel2.ResumeLayout(False)
        CType(spltCont_main, ComponentModel.ISupportInitialize).EndInit()
        spltCont_main.ResumeLayout(False)
        flowCont_details.ResumeLayout(False)
        tblLayout_body.ResumeLayout(False)
        pnl_aside.ResumeLayout(False)
        tbl_layoutAside.ResumeLayout(False)
        tbl_layoutAside.PerformLayout()
        Panel1.ResumeLayout(False)
        tabCtrl_body.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(pb_image, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        tblLayout_RentCars.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents spltCont_main As SplitContainer
    Friend WithEvents lbl_navLogoTitle1 As Label
    Friend WithEvents flowCont_details As FlowLayoutPanel
    Friend WithEvents tblLayout_body As TableLayoutPanel
    Friend WithEvents pnl_aside As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbl_layoutAside As TableLayoutPanel
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents lbl_accountName As Label
    Friend WithEvents btn_rentCars As Button
    Friend WithEvents btn_booking As Button
    Friend WithEvents btn_billings As Button
    Friend WithEvents tabCtrl_body As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_logOut As Button
    Friend WithEvents tblLayout_RentCars As TableLayoutPanel
    Friend WithEvents flp_rentCarsMain As FlowLayoutPanel
    Friend WithEvents lbl_accCreds As Label
    Friend WithEvents btn_addCredit As Button
    Friend WithEvents flp_billing As FlowLayoutPanel
    Friend WithEvents flp_booking As FlowLayoutPanel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pb_image As PictureBox
    Friend WithEvents lbl_heroTitle As Label
    Friend WithEvents lbl_subHero As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_Rent As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
End Class
