Public Class TopUp
    Dim _user As New UserTemplate
    Dim db As New Database()
    Dim _costumerBookingForm As CostumerBooking

    Dim walletCodes As New Dictionary(Of String, Integer) From {
        {"Sir Julius Best Prof In The World", 999999},
        {"XR78-PL5V-ZN43-HG1Y", 100000},
        {"KW93-DB6E-QT72-JF4U", 10000},
        {"LQ45-ME9X-SB86-KR2V", 1000}
    }


    Public Sub New(user As UserTemplate, costumerBookingForm As CostumerBooking)
        InitializeComponent()
        _user = user
        _costumerBookingForm = costumerBookingForm
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim codeFound As Boolean = False
        Dim codeVal As Double
        For Each code In walletCodes
            If (txtb_input.Text = code.Key) Then
                db.AddCreditToUser(_user.UID, code.Value)
                Dim updatedUser As UserTemplate = db.GetSpecificUser(_user.UID)
                _costumerBookingForm.UpdateCreditsLabel(updatedUser.Credits)
                codeVal = code.Value
                codeFound = True
                Exit For
            End If
        Next

        If codeFound Then
            MessageBox.Show("Redeemed: " + codeVal.ToString() + " to your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Invalid Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



End Class
