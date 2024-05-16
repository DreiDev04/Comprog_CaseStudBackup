<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_to_Cars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_to_Cars))
        pb_carPoster = New PictureBox()
        Panel1 = New Panel()
        lbl_carType = New Label()
        lbl_CarModel = New Label()
        Panel5 = New Panel()
        lbl_carPrice = New Label()
        btn_delete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        dtp_start = New DateTimePicker()
        dtp_return = New DateTimePicker()
        lbl_totalPrice = New Label()
        btn_payNow = New Button()
        CType(pb_carPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_carPoster
        ' 
        pb_carPoster.BackColor = Color.Transparent
        pb_carPoster.BackgroundImageLayout = ImageLayout.Zoom
        pb_carPoster.Image = My.Resources.Resources._320x240
        pb_carPoster.Location = New Point(41, 1)
        pb_carPoster.Name = "pb_carPoster"
        pb_carPoster.Size = New Size(192, 159)
        pb_carPoster.SizeMode = PictureBoxSizeMode.Zoom
        pb_carPoster.TabIndex = 38
        pb_carPoster.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(39, 161)
        Panel1.TabIndex = 39
        ' 
        ' lbl_carType
        ' 
        lbl_carType.AutoSize = True
        lbl_carType.BackColor = Color.Transparent
        lbl_carType.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carType.ForeColor = Color.Black
        lbl_carType.Location = New Point(266, 45)
        lbl_carType.Name = "lbl_carType"
        lbl_carType.Size = New Size(55, 15)
        lbl_carType.TabIndex = 43
        lbl_carType.Text = "<TYPE>"
        ' 
        ' lbl_CarModel
        ' 
        lbl_CarModel.AutoSize = True
        lbl_CarModel.BackColor = Color.Transparent
        lbl_CarModel.Font = New Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_CarModel.ForeColor = Color.Black
        lbl_CarModel.Location = New Point(262, 15)
        lbl_CarModel.Name = "lbl_CarModel"
        lbl_CarModel.Size = New Size(146, 26)
        lbl_CarModel.TabIndex = 42
        lbl_CarModel.Text = "<CAR MODEL>"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        Panel5.Location = New Point(227, 21)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(33, 117)
        Panel5.TabIndex = 41
        ' 
        ' lbl_carPrice
        ' 
        lbl_carPrice.BackColor = Color.Transparent
        lbl_carPrice.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carPrice.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        lbl_carPrice.Location = New Point(517, 78)
        lbl_carPrice.Name = "lbl_carPrice"
        lbl_carPrice.Size = New Size(177, 24)
        lbl_carPrice.TabIndex = 65
        lbl_carPrice.Text = "<Price>"
        lbl_carPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_delete.FlatStyle = FlatStyle.Flat
        btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), Image)
        btn_delete.Location = New Point(700, -1)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(54, 161)
        btn_delete.TabIndex = 66
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(270, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 67
        Label1.Text = "Start:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(386, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 68
        Label2.Text = "Return:"
        ' 
        ' dtp_start
        ' 
        dtp_start.Enabled = False
        dtp_start.Format = DateTimePickerFormat.Short
        dtp_start.Location = New Point(270, 90)
        dtp_start.Name = "dtp_start"
        dtp_start.Size = New Size(110, 23)
        dtp_start.TabIndex = 69
        ' 
        ' dtp_return
        ' 
        dtp_return.Enabled = False
        dtp_return.Format = DateTimePickerFormat.Short
        dtp_return.Location = New Point(386, 90)
        dtp_return.Name = "dtp_return"
        dtp_return.Size = New Size(110, 23)
        dtp_return.TabIndex = 70
        ' 
        ' lbl_totalPrice
        ' 
        lbl_totalPrice.BackColor = Color.Transparent
        lbl_totalPrice.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_totalPrice.ForeColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        lbl_totalPrice.Location = New Point(270, 118)
        lbl_totalPrice.Name = "lbl_totalPrice"
        lbl_totalPrice.Size = New Size(298, 24)
        lbl_totalPrice.TabIndex = 71
        lbl_totalPrice.Text = "<Total Price>"
        lbl_totalPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btn_payNow
        ' 
        btn_payNow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_payNow.BackColor = Color.FromArgb(CByte(125), CByte(0), CByte(0))
        btn_payNow.FlatStyle = FlatStyle.Flat
        btn_payNow.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_payNow.ForeColor = Color.FromArgb(CByte(242), CByte(242), CByte(247))
        btn_payNow.Location = New Point(571, 116)
        btn_payNow.Name = "btn_payNow"
        btn_payNow.Size = New Size(120, 35)
        btn_payNow.TabIndex = 72
        btn_payNow.Text = "Pay now"
        btn_payNow.UseVisualStyleBackColor = False
        ' 
        ' Add_to_Cars
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(btn_payNow)
        Controls.Add(lbl_totalPrice)
        Controls.Add(dtp_return)
        Controls.Add(dtp_start)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_carPrice)
        Controls.Add(lbl_carType)
        Controls.Add(lbl_CarModel)
        Controls.Add(Panel1)
        Controls.Add(pb_carPoster)
        Controls.Add(Panel5)
        Controls.Add(btn_delete)
        Name = "Add_to_Cars"
        Size = New Size(750, 160)
        CType(pb_carPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_carPoster As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_carType As Label
    Friend WithEvents lbl_CarModel As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_carPrice As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents dtp_return As DateTimePicker
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents btn_payNow As Button

End Class
