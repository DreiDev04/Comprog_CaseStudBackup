Imports System.IO

Public Class RentNowDetails
    Dim db As New Database()

    Dim _car As New VehicleDetails
    Dim _session As UserSession

    Dim _costumerBookingForm As CostumerBooking

    Public Sub New(car As VehicleDetails, session As UserSession, costumerBookingForm As CostumerBooking)
        InitializeComponent()
        _car = car
        _session = session
        _costumerBookingForm = costumerBookingForm

        dtp_start.MinDate = DateTime.Now
        dtp_return.MinDate = DateTime.Now.AddDays(1)
        dtp_return.MaxDate = DateTime.Now.AddDays(30)


        lbl_carModel.Text = car.ModelName
        lbl_carType.Text = car.Type
        lbl_carDesc.Text = car.Description
        lbl_carColor.Text = "Color: " + car.Color
        lbl_carCapacity.Text = "Capacity: " + car.Capacity.ToString()
        lbl_carPrice.Text = String.Format("{0:C}", car.DailyPrice) + "/day"

        Dim posterDir As String = Directory.GetParent(db.get_FileDir()).ToString() + "\Resources\Images\Cars\" + car.PosterPath
        Try
            If File.Exists(posterDir) Then
                pb_carPoster.Image = Image.FromFile(posterDir)
            End If
        Catch ex As Exception
            MsgBox("Error loading image: " & ex.Message)
        End Try



    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

    Private Sub btn_rentNow_Click(sender As Object, e As EventArgs) Handles btn_rentNow.Click

    End Sub

    Private Sub btn_addToCart_Click(sender As Object, e As EventArgs) Handles btn_addToCart.Click
        Dim startDate As DateTime = dtp_start.Value
        Dim returnDate As DateTime = dtp_return.Value

        If startDate > returnDate Then
            MessageBox.Show("Invalid date range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim addToCar As New Add_to_Cars(_car, _session, startDate, returnDate, _costumerBookingForm)

            _costumerBookingForm.flp_billing.Controls.Add(addToCar)
            MessageBox.Show("Car added to cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class