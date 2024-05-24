<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentNowDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentNowDetails))
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        lbl_carModel = New Label()
        lbl_carType = New Label()
        lbl_carDesc = New Label()
        lbl_carPrice = New Label()
        TableLayoutPanel7 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        dtp_start = New DateTimePicker()
        dtp_return = New DateTimePicker()
        TableLayoutPanel6 = New TableLayoutPanel()
        lbl_carColor = New Label()
        pb_carPoster = New PictureBox()
        Panel1 = New Panel()
        lbl_carCapacity = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btn_cancel = New Button()
        btn_addToCart = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        CType(pb_carPoster, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(704, 434)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(199), CByte(199), CByte(204))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(73, 46)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel2.Size = New Size(557, 341)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 1, 0)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel6, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(551, 283)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Controls.Add(lbl_carModel, 0, 0)
        TableLayoutPanel4.Controls.Add(lbl_carType, 0, 1)
        TableLayoutPanel4.Controls.Add(lbl_carDesc, 0, 2)
        TableLayoutPanel4.Controls.Add(lbl_carPrice, 0, 5)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel7, 0, 3)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(223, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 6
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 8.361204F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 7.02341127F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 47.16312F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 22.3404255F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 2.83687949F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 12.0401335F))
        TableLayoutPanel4.Size = New Size(325, 277)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' lbl_carModel
        ' 
        lbl_carModel.AutoSize = True
        lbl_carModel.Dock = DockStyle.Fill
        lbl_carModel.Font = New Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carModel.Location = New Point(3, 0)
        lbl_carModel.Name = "lbl_carModel"
        lbl_carModel.Size = New Size(319, 23)
        lbl_carModel.TabIndex = 0
        lbl_carModel.Text = "<Car Model>"
        ' 
        ' lbl_carType
        ' 
        lbl_carType.AutoSize = True
        lbl_carType.Dock = DockStyle.Fill
        lbl_carType.Font = New Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carType.Location = New Point(3, 23)
        lbl_carType.Name = "lbl_carType"
        lbl_carType.Size = New Size(319, 19)
        lbl_carType.TabIndex = 1
        lbl_carType.Text = "<Car Type>"
        ' 
        ' lbl_carDesc
        ' 
        lbl_carDesc.AutoSize = True
        lbl_carDesc.Dock = DockStyle.Fill
        lbl_carDesc.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_carDesc.Location = New Point(3, 42)
        lbl_carDesc.Name = "lbl_carDesc"
        lbl_carDesc.Size = New Size(319, 130)
        lbl_carDesc.TabIndex = 2
        lbl_carDesc.Text = resources.GetString("lbl_carDesc.Text")
        lbl_carDesc.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_carPrice
        ' 
        lbl_carPrice.AutoSize = True
        lbl_carPrice.Dock = DockStyle.Fill
        lbl_carPrice.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carPrice.Location = New Point(3, 241)
        lbl_carPrice.Name = "lbl_carPrice"
        lbl_carPrice.Size = New Size(319, 36)
        lbl_carPrice.TabIndex = 5
        lbl_carPrice.Text = "<Price>"
        lbl_carPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(Label1, 0, 0)
        TableLayoutPanel7.Controls.Add(Label2, 1, 0)
        TableLayoutPanel7.Controls.Add(dtp_start, 0, 1)
        TableLayoutPanel7.Controls.Add(dtp_return, 1, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 175)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 36.8421059F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 63.1578941F))
        TableLayoutPanel7.Size = New Size(319, 56)
        TableLayoutPanel7.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Cascadia Mono", 11.25F)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 20)
        Label1.TabIndex = 0
        Label1.Text = "Starting day:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Cascadia Mono", 11.25F)
        Label2.Location = New Point(162, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 1
        Label2.Text = "Returning Day:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtp_start
        ' 
        dtp_start.Dock = DockStyle.Fill
        dtp_start.Format = DateTimePickerFormat.Short
        dtp_start.Location = New Point(3, 23)
        dtp_start.Name = "dtp_start"
        dtp_start.Size = New Size(153, 23)
        dtp_start.TabIndex = 2
        ' 
        ' dtp_return
        ' 
        dtp_return.Dock = DockStyle.Fill
        dtp_return.Format = DateTimePickerFormat.Short
        dtp_return.Location = New Point(162, 23)
        dtp_return.Name = "dtp_return"
        dtp_return.Size = New Size(154, 23)
        dtp_return.TabIndex = 3
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(lbl_carColor, 0, 2)
        TableLayoutPanel6.Controls.Add(pb_carPoster, 0, 0)
        TableLayoutPanel6.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 3
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel6.Size = New Size(214, 277)
        TableLayoutPanel6.TabIndex = 2
        ' 
        ' lbl_carColor
        ' 
        lbl_carColor.AutoSize = True
        lbl_carColor.Dock = DockStyle.Fill
        lbl_carColor.Font = New Font("Cambria", 11.25F, FontStyle.Bold)
        lbl_carColor.Location = New Point(3, 248)
        lbl_carColor.Name = "lbl_carColor"
        lbl_carColor.Size = New Size(208, 29)
        lbl_carColor.TabIndex = 4
        lbl_carColor.Text = "<Color>"
        lbl_carColor.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pb_carPoster
        ' 
        pb_carPoster.Dock = DockStyle.Fill
        pb_carPoster.Image = My.Resources.Resources._320x240
        pb_carPoster.Location = New Point(3, 3)
        pb_carPoster.Name = "pb_carPoster"
        pb_carPoster.Size = New Size(208, 215)
        pb_carPoster.SizeMode = PictureBoxSizeMode.Zoom
        pb_carPoster.TabIndex = 0
        pb_carPoster.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbl_carCapacity)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 224)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(208, 21)
        Panel1.TabIndex = 1
        ' 
        ' lbl_carCapacity
        ' 
        lbl_carCapacity.AutoSize = True
        lbl_carCapacity.Dock = DockStyle.Fill
        lbl_carCapacity.Font = New Font("Cambria", 11.25F, FontStyle.Bold)
        lbl_carCapacity.Location = New Point(0, 0)
        lbl_carCapacity.Name = "lbl_carCapacity"
        lbl_carCapacity.Size = New Size(85, 17)
        lbl_carCapacity.TabIndex = 3
        lbl_carCapacity.Text = "<Capacity>"
        lbl_carCapacity.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel5.Controls.Add(FlowLayoutPanel1, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 292)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(551, 46)
        TableLayoutPanel5.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btn_cancel)
        FlowLayoutPanel1.Controls.Add(btn_addToCart)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(58, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(434, 40)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.Transparent
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.Font = New Font("Cascadia Mono", 9.75F)
        btn_cancel.ForeColor = Color.FromArgb(CByte(28), CByte(28), CByte(30))
        btn_cancel.Location = New Point(3, 3)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(137, 37)
        btn_cancel.TabIndex = 0
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_addToCart
        ' 
        btn_addToCart.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_addToCart.FlatStyle = FlatStyle.Flat
        btn_addToCart.Font = New Font("Cascadia Mono", 9.75F)
        btn_addToCart.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_addToCart.Location = New Point(146, 3)
        btn_addToCart.Name = "btn_addToCart"
        btn_addToCart.Size = New Size(137, 37)
        btn_addToCart.TabIndex = 2
        btn_addToCart.Text = "Add to Cart"
        btn_addToCart.UseVisualStyleBackColor = False
        ' 
        ' RentNowDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        ClientSize = New Size(704, 434)
        ControlBox = False
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(720, 450)
        MinimumSize = New Size(720, 450)
        Name = "RentNowDetails"
        StartPosition = FormStartPosition.CenterScreen
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        CType(pb_carPoster, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents pb_carPoster As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lbl_carModel As Label
    Friend WithEvents lbl_carType As Label
    Friend WithEvents lbl_carDesc As Label
    Friend WithEvents lbl_carCapacity As Label
    Friend WithEvents lbl_carColor As Label
    Friend WithEvents lbl_carPrice As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_addToCart As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents dtp_return As DateTimePicker
End Class
