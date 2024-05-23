<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        spltCont = New SplitContainer()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        lbl_navLogoTitle = New Label()
        pnl_main = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TableLayoutPanel2 = New TableLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        btn_UaddRow = New Button()
        btn_UdEdit = New Button()
        btn_UdeleteByUsername = New Button()
        dgv_user = New DataGridView()
        TabPage2 = New TabPage()
        TableLayoutPanel3 = New TableLayoutPanel()
        dgv_rental = New DataGridView()
        Panel4 = New Panel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        btn_Redit = New Button()
        TabPage3 = New TabPage()
        TableLayoutPanel4 = New TableLayoutPanel()
        dgv_vehicle = New DataGridView()
        Panel5 = New Panel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        btn_VaddRow = New Button()
        btn_Vedit = New Button()
        btn_Vdel = New Button()
        CType(spltCont, ComponentModel.ISupportInitialize).BeginInit()
        spltCont.Panel1.SuspendLayout()
        spltCont.Panel2.SuspendLayout()
        spltCont.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        pnl_main.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        CType(dgv_user, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgv_rental, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        TabPage3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(dgv_vehicle, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' spltCont
        ' 
        spltCont.Dock = DockStyle.Fill
        spltCont.Location = New Point(0, 0)
        spltCont.Name = "spltCont"
        spltCont.Orientation = Orientation.Horizontal
        ' 
        ' spltCont.Panel1
        ' 
        spltCont.Panel1.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        spltCont.Panel1.Controls.Add(FlowLayoutPanel1)
        spltCont.Panel1.Controls.Add(lbl_navLogoTitle)
        spltCont.Panel1.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        spltCont.Panel1MinSize = 60
        ' 
        ' spltCont.Panel2
        ' 
        spltCont.Panel2.Controls.Add(pnl_main)
        spltCont.Panel2MinSize = 60
        spltCont.Size = New Size(1264, 681)
        spltCont.SplitterDistance = 60
        spltCont.SplitterWidth = 1
        spltCont.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New Point(810, 9)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.RightToLeft = RightToLeft.No
        FlowLayoutPanel1.Size = New Size(405, 41)
        FlowLayoutPanel1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Cascadia Mono", 12F)
        Button1.Location = New Point(302, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 35)
        Button1.TabIndex = 1
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lbl_navLogoTitle
        ' 
        lbl_navLogoTitle.Font = New Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_navLogoTitle.Location = New Point(33, 18)
        lbl_navLogoTitle.Name = "lbl_navLogoTitle"
        lbl_navLogoTitle.Size = New Size(246, 32)
        lbl_navLogoTitle.TabIndex = 0
        lbl_navLogoTitle.Text = "Wheel4Rent Admin"
        lbl_navLogoTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnl_main
        ' 
        pnl_main.BackColor = Color.White
        pnl_main.Controls.Add(TableLayoutPanel1)
        pnl_main.Dock = DockStyle.Fill
        pnl_main.Location = New Point(0, 0)
        pnl_main.Name = "pnl_main"
        pnl_main.Size = New Size(1264, 620)
        pnl_main.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel2, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1264, 620)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(120, 614)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Dock = DockStyle.Fill
        Panel2.ForeColor = Color.FromArgb(CByte(245), CByte(245), CByte(247))
        Panel2.Location = New Point(1140, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(121, 614)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TabControl1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(129, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1005, 614)
        Panel3.TabIndex = 2
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1005, 614)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(TableLayoutPanel2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(997, 586)
        TabPage1.TabIndex = 0
        TabPage1.Text = "User Database"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel2, 0, 0)
        TableLayoutPanel2.Controls.Add(dgv_user, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel2.Size = New Size(991, 580)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(btn_UaddRow)
        FlowLayoutPanel2.Controls.Add(btn_UdEdit)
        FlowLayoutPanel2.Controls.Add(btn_UdeleteByUsername)
        FlowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel2.Location = New Point(3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(985, 43)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' btn_UaddRow
        ' 
        btn_UaddRow.Cursor = Cursors.Hand
        btn_UaddRow.FlatStyle = FlatStyle.Flat
        btn_UaddRow.Font = New Font("Cascadia Mono", 12F)
        btn_UaddRow.Location = New Point(869, 3)
        btn_UaddRow.Name = "btn_UaddRow"
        btn_UaddRow.Size = New Size(113, 35)
        btn_UaddRow.TabIndex = 0
        btn_UaddRow.Text = "Add Row"
        btn_UaddRow.UseVisualStyleBackColor = True
        ' 
        ' btn_UdEdit
        ' 
        btn_UdEdit.Cursor = Cursors.Hand
        btn_UdEdit.FlatStyle = FlatStyle.Flat
        btn_UdEdit.Font = New Font("Cascadia Mono", 12F)
        btn_UdEdit.Location = New Point(750, 3)
        btn_UdEdit.Name = "btn_UdEdit"
        btn_UdEdit.Size = New Size(113, 35)
        btn_UdEdit.TabIndex = 1
        btn_UdEdit.Text = "Edit"
        btn_UdEdit.UseVisualStyleBackColor = True
        ' 
        ' btn_UdeleteByUsername
        ' 
        btn_UdeleteByUsername.Cursor = Cursors.Hand
        btn_UdeleteByUsername.FlatStyle = FlatStyle.Flat
        btn_UdeleteByUsername.Font = New Font("Cascadia Mono", 12F)
        btn_UdeleteByUsername.Location = New Point(614, 3)
        btn_UdeleteByUsername.Name = "btn_UdeleteByUsername"
        btn_UdeleteByUsername.Size = New Size(130, 35)
        btn_UdeleteByUsername.TabIndex = 2
        btn_UdeleteByUsername.Text = "Delete by ID"
        btn_UdeleteByUsername.UseVisualStyleBackColor = True
        ' 
        ' dgv_user
        ' 
        dgv_user.AllowUserToAddRows = False
        dgv_user.AllowUserToDeleteRows = False
        dgv_user.AllowUserToResizeColumns = False
        dgv_user.AllowUserToResizeRows = False
        dgv_user.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgv_user.BorderStyle = BorderStyle.None
        dgv_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_user.Location = New Point(3, 61)
        dgv_user.Name = "dgv_user"
        dgv_user.ReadOnly = True
        dgv_user.RowHeadersVisible = False
        dgv_user.Size = New Size(985, 516)
        dgv_user.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Transparent
        TabPage2.Controls.Add(TableLayoutPanel3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(997, 586)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Rental Database"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(dgv_rental, 0, 1)
        TableLayoutPanel3.Controls.Add(Panel4, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(991, 580)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' dgv_rental
        ' 
        dgv_rental.AllowUserToAddRows = False
        dgv_rental.AllowUserToDeleteRows = False
        dgv_rental.AllowUserToResizeColumns = False
        dgv_rental.AllowUserToResizeRows = False
        dgv_rental.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgv_rental.BorderStyle = BorderStyle.None
        dgv_rental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rental.Dock = DockStyle.Fill
        dgv_rental.Location = New Point(3, 61)
        dgv_rental.Name = "dgv_rental"
        dgv_rental.ReadOnly = True
        dgv_rental.RowHeadersVisible = False
        dgv_rental.Size = New Size(985, 516)
        dgv_rental.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(FlowLayoutPanel3)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(985, 52)
        Panel4.TabIndex = 2
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(btn_Redit)
        FlowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel3.Location = New Point(0, 5)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(985, 43)
        FlowLayoutPanel3.TabIndex = 1
        ' 
        ' btn_Redit
        ' 
        btn_Redit.Cursor = Cursors.Hand
        btn_Redit.FlatStyle = FlatStyle.Flat
        btn_Redit.Font = New Font("Cascadia Mono", 12F)
        btn_Redit.Location = New Point(869, 3)
        btn_Redit.Name = "btn_Redit"
        btn_Redit.Size = New Size(113, 35)
        btn_Redit.TabIndex = 1
        btn_Redit.Text = "Edit"
        btn_Redit.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        TabPage3.Controls.Add(TableLayoutPanel4)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(997, 586)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Vehicle Database"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(dgv_vehicle, 0, 1)
        TableLayoutPanel4.Controls.Add(Panel5, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel4.Size = New Size(991, 580)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' dgv_vehicle
        ' 
        dgv_vehicle.AllowUserToAddRows = False
        dgv_vehicle.AllowUserToDeleteRows = False
        dgv_vehicle.AllowUserToResizeColumns = False
        dgv_vehicle.AllowUserToResizeRows = False
        dgv_vehicle.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgv_vehicle.BorderStyle = BorderStyle.None
        dgv_vehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vehicle.Dock = DockStyle.Fill
        dgv_vehicle.Location = New Point(3, 61)
        dgv_vehicle.Name = "dgv_vehicle"
        dgv_vehicle.ReadOnly = True
        dgv_vehicle.RowHeadersVisible = False
        dgv_vehicle.Size = New Size(985, 516)
        dgv_vehicle.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(FlowLayoutPanel4)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(3, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(985, 52)
        Panel5.TabIndex = 2
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(btn_VaddRow)
        FlowLayoutPanel4.Controls.Add(btn_Vedit)
        FlowLayoutPanel4.Controls.Add(btn_Vdel)
        FlowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel4.Location = New Point(0, 5)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(985, 43)
        FlowLayoutPanel4.TabIndex = 1
        ' 
        ' btn_VaddRow
        ' 
        btn_VaddRow.Cursor = Cursors.Hand
        btn_VaddRow.FlatStyle = FlatStyle.Flat
        btn_VaddRow.Font = New Font("Cascadia Mono", 12F)
        btn_VaddRow.Location = New Point(869, 3)
        btn_VaddRow.Name = "btn_VaddRow"
        btn_VaddRow.Size = New Size(113, 35)
        btn_VaddRow.TabIndex = 0
        btn_VaddRow.Text = "Add Row"
        btn_VaddRow.UseVisualStyleBackColor = True
        ' 
        ' btn_Vedit
        ' 
        btn_Vedit.Cursor = Cursors.Hand
        btn_Vedit.FlatStyle = FlatStyle.Flat
        btn_Vedit.Font = New Font("Cascadia Mono", 12F)
        btn_Vedit.Location = New Point(750, 3)
        btn_Vedit.Name = "btn_Vedit"
        btn_Vedit.Size = New Size(113, 35)
        btn_Vedit.TabIndex = 1
        btn_Vedit.Text = "Edit"
        btn_Vedit.UseVisualStyleBackColor = True
        ' 
        ' btn_Vdel
        ' 
        btn_Vdel.Cursor = Cursors.Hand
        btn_Vdel.FlatStyle = FlatStyle.Flat
        btn_Vdel.Font = New Font("Cascadia Mono", 12F)
        btn_Vdel.Location = New Point(594, 3)
        btn_Vdel.Name = "btn_Vdel"
        btn_Vdel.Size = New Size(150, 35)
        btn_Vdel.TabIndex = 2
        btn_Vdel.Text = "Delete by ID"
        btn_Vdel.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(spltCont)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        spltCont.Panel1.ResumeLayout(False)
        spltCont.Panel2.ResumeLayout(False)
        CType(spltCont, ComponentModel.ISupportInitialize).EndInit()
        spltCont.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        pnl_main.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        CType(dgv_user, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(dgv_rental, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        FlowLayoutPanel3.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        CType(dgv_vehicle, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        FlowLayoutPanel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents spltCont As SplitContainer
    Friend WithEvents lbl_navLogoTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnl_main As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btn_UaddRow As Button
    Friend WithEvents btn_UdEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgv_rental As DataGridView
    Friend WithEvents dgv_vehicle As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents btn_Redit As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents btn_VaddRow As Button
    Friend WithEvents btn_Vedit As Button
    Friend WithEvents btn_UdeleteByUsername As Button
    Friend WithEvents btn_Vdel As Button
End Class
