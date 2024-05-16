Imports System.IO

Public Class Add_to_Cars
    ReadOnly db As New Database
    Dim rm As New RentalManager

    Dim _car As VehicleDetails
    Dim _session As UserSession

    Dim _startDate As DateTime
    Dim _returnDate As DateTime
    Dim _costumerBookingForm As CostumerBooking

    Dim totalPrice As Double
    Dim totalDays As Integer


    Public Sub New(car As VehicleDetails, session As UserSession, startDate As DateTime, rutrnDate As DateTime, costumerBookingForm As CostumerBooking)
        InitializeComponent()

        _car = car
        _session = session
        _startDate = startDate
        _returnDate = rutrnDate
        _costumerBookingForm = costumerBookingForm


        lbl_CarModel.Text = car.ModelName
        lbl_carType.Text = car.Type
        lbl_carPrice.Text = String.Format("{0:C}", car.DailyPrice) + "/day"
        dtp_start.Value = startDate
        dtp_return.Value = rutrnDate

        Dim posterPath = Directory.GetParent(db.get_FileDir()).ToString() + "\Resources\Images\Cars\" + car.PosterPath
        If File.Exists(posterPath) Then
            pb_carPoster.Image = Image.FromFile(posterPath)
        End If

        totalPrice = (rutrnDate - startDate).TotalDays * car.DailyPrice
        totalDays = (rutrnDate - startDate).TotalDays

        lbl_totalPrice.Text = String.Format("{0:C}", totalPrice) + " for " + totalDays.ToString() + " day/s"

    End Sub

    Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_return.KeyPress
        ' Cancel any key presses to prevent editing
        e.Handled = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Assuming addToCar is the control you want to remove
            _costumerBookingForm.flp_billing.Controls.Remove(Me)
        Else
            MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_payNow_Click(sender As Object, e As EventArgs) Handles btn_payNow.Click

        Dim confirmationMessage As String = String.Format("Are you sure you want to pay now? Total cost: {0:C}", totalPrice)
        Dim result As DialogResult = MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            rm.ProcessPayment(_session, totalPrice, _costumerBookingForm)

            db.AddBooking(New RentalTemplate(_session.UID, _car.CarID, _startDate, _returnDate, False, False, totalPrice))


            MessageBox.Show("Payment accepted", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _costumerBookingForm.flp_billing.Controls.Remove(Me)


        Else
            ' Payment canceled
            MessageBox.Show("Payment canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
