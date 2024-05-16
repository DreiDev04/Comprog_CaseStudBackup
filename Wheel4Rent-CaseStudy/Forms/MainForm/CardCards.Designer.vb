<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardCards
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
        pb_carPoster = New PictureBox()
        lbl_carModel = New Label()
        lbl_carType = New Label()
        PictureBox3 = New PictureBox()
        btnRentNow = New Button()
        lbl_carCapacity = New Label()
        Label4 = New Label()
        lbl_available = New Label()
        lbl_carPrice = New Label()
        lbl_carColor = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        CType(pb_carPoster, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_carPoster
        ' 
        pb_carPoster.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pb_carPoster.BackColor = Color.Transparent
        pb_carPoster.BackgroundImageLayout = ImageLayout.Zoom
        pb_carPoster.Image = My.Resources.Resources._320x240
        pb_carPoster.Location = New Point(10, 37)
        pb_carPoster.Name = "pb_carPoster"
        pb_carPoster.Size = New Size(211, 161)
        pb_carPoster.SizeMode = PictureBoxSizeMode.Zoom
        pb_carPoster.TabIndex = 37
        pb_carPoster.TabStop = False
        ' 
        ' lbl_carModel
        ' 
        lbl_carModel.Anchor = AnchorStyles.Left
        lbl_carModel.BackColor = Color.Transparent
        lbl_carModel.Font = New Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carModel.ForeColor = Color.Black
        lbl_carModel.Location = New Point(10, 177)
        lbl_carModel.Name = "lbl_carModel"
        lbl_carModel.Size = New Size(211, 22)
        lbl_carModel.TabIndex = 40
        lbl_carModel.Text = "<CAR BRAND>"
        ' 
        ' lbl_carType
        ' 
        lbl_carType.Anchor = AnchorStyles.Left
        lbl_carType.AutoSize = True
        lbl_carType.BackColor = Color.Transparent
        lbl_carType.Font = New Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_carType.ForeColor = Color.Black
        lbl_carType.Location = New Point(16, 200)
        lbl_carType.Name = "lbl_carType"
        lbl_carType.Size = New Size(50, 15)
        lbl_carType.TabIndex = 41
        lbl_carType.Text = "<TYPE>"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.DarkGray
        PictureBox3.Location = New Point(14, 218)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(207, 34)
        PictureBox3.TabIndex = 52
        PictureBox3.TabStop = False
        ' 
        ' btnRentNow
        ' 
        btnRentNow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRentNow.BackColor = Color.Maroon
        btnRentNow.Dock = DockStyle.Bottom
        btnRentNow.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRentNow.ForeColor = Color.Snow
        btnRentNow.Location = New Point(0, 280)
        btnRentNow.Name = "btnRentNow"
        btnRentNow.Size = New Size(230, 40)
        btnRentNow.TabIndex = 53
        btnRentNow.Text = "RENT NOW"
        btnRentNow.UseVisualStyleBackColor = False
        ' 
        ' lbl_carCapacity
        ' 
        lbl_carCapacity.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_carCapacity.BackColor = Color.DarkGray
        lbl_carCapacity.Font = New Font("Dubai", 8.249999F, FontStyle.Bold)
        lbl_carCapacity.ForeColor = Color.Black
        lbl_carCapacity.Location = New Point(20, 233)
        lbl_carCapacity.Name = "lbl_carCapacity"
        lbl_carCapacity.Size = New Size(94, 18)
        lbl_carCapacity.TabIndex = 61
        lbl_carCapacity.Text = "<capacity>"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.BackColor = Color.DarkGray
        Label4.Font = New Font("Dubai", 8.249999F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(21, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 13)
        Label4.TabIndex = 57
        Label4.Text = "CAPACITY"
        ' 
        ' lbl_available
        ' 
        lbl_available.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_available.BackColor = Color.Transparent
        lbl_available.Font = New Font("Cambria", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_available.ForeColor = Color.FromArgb(CByte(0), CByte(179), CByte(0))
        lbl_available.Location = New Point(3, 37)
        lbl_available.Name = "lbl_available"
        lbl_available.Size = New Size(218, 26)
        lbl_available.TabIndex = 62
        lbl_available.Text = "<AVAILABLE>"
        lbl_available.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_carPrice
        ' 
        lbl_carPrice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lbl_carPrice.BackColor = Color.Transparent
        lbl_carPrice.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_carPrice.ForeColor = Color.Maroon
        lbl_carPrice.Location = New Point(16, 253)
        lbl_carPrice.Name = "lbl_carPrice"
        lbl_carPrice.Size = New Size(205, 24)
        lbl_carPrice.TabIndex = 64
        lbl_carPrice.Text = "<Price>"
        lbl_carPrice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_carColor
        ' 
        lbl_carColor.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lbl_carColor.BackColor = Color.DarkGray
        lbl_carColor.Font = New Font("Dubai", 8.249999F, FontStyle.Bold)
        lbl_carColor.ForeColor = Color.Black
        lbl_carColor.Location = New Point(120, 231)
        lbl_carColor.Name = "lbl_carColor"
        lbl_carColor.Size = New Size(87, 18)
        lbl_carColor.TabIndex = 65
        lbl_carColor.Text = "<color>"
        lbl_carColor.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.BackColor = Color.DarkGray
        Label2.Font = New Font("Dubai", 8.249999F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(166, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 17)
        Label2.TabIndex = 66
        Label2.Text = "COLOR"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Maroon
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(244, 35)
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' CardCards
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Controls.Add(Label2)
        Controls.Add(lbl_carColor)
        Controls.Add(lbl_carPrice)
        Controls.Add(lbl_available)
        Controls.Add(lbl_carCapacity)
        Controls.Add(Label4)
        Controls.Add(btnRentNow)
        Controls.Add(PictureBox3)
        Controls.Add(lbl_carType)
        Controls.Add(lbl_carModel)
        Controls.Add(PictureBox2)
        Controls.Add(pb_carPoster)
        Name = "CardCards"
        Size = New Size(230, 320)
        CType(pb_carPoster, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_carPoster As PictureBox
    Friend WithEvents lbl_carModel As Label
    Friend WithEvents lbl_carType As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnRentNow As Button
    Friend WithEvents lbl_carCapacity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_available As Label
    Friend WithEvents lbl_carPrice As Label
    Friend WithEvents lbl_carColor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
