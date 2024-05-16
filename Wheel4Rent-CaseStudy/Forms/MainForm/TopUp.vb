Public Class TopUp
    Dim _user As New UserTemplate
    Dim db As New Database()
    Dim _costumerBookingForm As CostumerBooking

    Public Sub New(user As UserTemplate, costumerBookingForm As CostumerBooking)
        InitializeComponent()
        _user = user
        _costumerBookingForm = costumerBookingForm
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (txtb_input.Text = "Sir Julius Best Prof In The World") Then

            db.AddCreditToUser(_user.UID, "999999")

        Else
            MsgBox("Invalid Code")
        End If

        Dim updatedUser As UserTemplate = db.GetSpecificUser(_user.UID)
        _costumerBookingForm.UpdateCreditsLabel(updatedUser.Credits)

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



End Class
