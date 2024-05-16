<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarBooking
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        lbl_totalPrice = New Label()
        dtp_return = New DateTimePicker()
        dtp_start = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        lbl_daysLeft = New Label()
        lbl_carType = New Label()
        lbl_CarModel = New Label()
        Panel1 = New Panel()
        pb_carPoster = New PictureBox()
        Panel5 = New Panel()
        btn_delete = New Button()
        CType(pb_carPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_totalPrice
        ' 
        lbl_totalPrice.BackColor = Color.Transparent
        lbl_totalPrice.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_totalPrice.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        lbl_totalPrice.Location = New Point(269, 119)
        lbl_totalPrice.Name = "lbl_totalPrice"
        lbl_totalPrice.Size = New Size(298, 24)
        lbl_totalPrice.TabIndex = 84
        lbl_totalPrice.Text = "<Total Price>"
        lbl_totalPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtp_return
        ' 
        dtp_return.Enabled = False
        dtp_return.Format = DateTimePickerFormat.Short
        dtp_return.Location = New Point(385, 91)
        dtp_return.Name = "dtp_return"
        dtp_return.Size = New Size(110, 23)
        dtp_return.TabIndex = 83
        ' 
        ' dtp_start
        ' 
        dtp_start.Enabled = False
        dtp_start.Format = DateTimePickerFormat.Short
        dtp_start.Location = New Point(269, 91)
        dtp_start.Name = "dtp_start"
        dtp_start.Size = New Size(110, 23)
        dtp_start.TabIndex = 82
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(385, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 81
        Label2.Text = "Return:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(269, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 80
        Label1.Text = "Start:"
        ' 
        ' lbl_daysLeft
        ' 
        lbl_daysLeft.BackColor = Color.Transparent
        lbl_daysLeft.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_daysLeft.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        lbl_daysLeft.Location = New Point(425, 16)
        lbl_daysLeft.Name = "lbl_daysLeft"
        lbl_daysLeft.Size = New Size(270, 24)
        lbl_daysLeft.TabIndex = 78
        lbl_daysLeft.Text = "<Days Left before return>"
        lbl_daysLeft.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_carType
        ' 
        lbl_carType.AutoSize = True
        lbl_carType.BackColor = Color.Transparent
        lbl_carType.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carType.ForeColor = Color.Black
        lbl_carType.Location = New Point(265, 46)
        lbl_carType.Name = "lbl_carType"
        lbl_carType.Size = New Size(55, 15)
        lbl_carType.TabIndex = 77
        lbl_carType.Text = "<TYPE>"
        ' 
        ' lbl_CarModel
        ' 
        lbl_CarModel.AutoSize = True
        lbl_CarModel.BackColor = Color.Transparent
        lbl_CarModel.Font = New Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_CarModel.ForeColor = Color.Black
        lbl_CarModel.Location = New Point(261, 16)
        lbl_CarModel.Name = "lbl_CarModel"
        lbl_CarModel.Size = New Size(146, 26)
        lbl_CarModel.TabIndex = 76
        lbl_CarModel.Text = "<CAR MODEL>"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(39, 161)
        Panel1.TabIndex = 74
        ' 
        ' pb_carPoster
        ' 
        pb_carPoster.BackColor = Color.Transparent
        pb_carPoster.BackgroundImageLayout = ImageLayout.Zoom
        pb_carPoster.Image = My.Resources.Resources._320x240
        pb_carPoster.Location = New Point(40, 2)
        pb_carPoster.Name = "pb_carPoster"
        pb_carPoster.Size = New Size(192, 159)
        pb_carPoster.SizeMode = PictureBoxSizeMode.Zoom
        pb_carPoster.TabIndex = 73
        pb_carPoster.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        Panel5.Location = New Point(226, 22)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(33, 117)
        Panel5.TabIndex = 75
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Location = New Point(699, 0)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(54, 161)
        btn_delete.TabIndex = 79
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' CarBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(lbl_totalPrice)
        Controls.Add(dtp_return)
        Controls.Add(dtp_start)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_daysLeft)
        Controls.Add(lbl_carType)
        Controls.Add(lbl_CarModel)
        Controls.Add(Panel1)
        Controls.Add(pb_carPoster)
        Controls.Add(Panel5)
        Controls.Add(btn_delete)
        Name = "CarBooking"
        Size = New Size(748, 158)
        CType(pb_carPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents dtp_return As DateTimePicker
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_daysLeft As Label
    Friend WithEvents lbl_carType As Label
    Friend WithEvents lbl_CarModel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_carPoster As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_delete As Button

End Class
