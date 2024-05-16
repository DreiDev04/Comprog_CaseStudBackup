<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class TopUp
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtb_input As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PasswordLabel = New Label()
        txtb_input = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(12, 93)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Redeem Wallet Code"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtb_input
        ' 
        txtb_input.Location = New Point(12, 119)
        txtb_input.Name = "txtb_input"
        txtb_input.Size = New Size(264, 23)
        txtb_input.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(82, 161)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(182, 161)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 93)
        Label1.TabIndex = 6
        Label1.Text = "Go to nearest Wheel4Rent branch to Add Credits"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TopUp
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(288, 192)
        Controls.Add(Label1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(txtb_input)
        Controls.Add(PasswordLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "TopUp"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Credits"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label

End Class
