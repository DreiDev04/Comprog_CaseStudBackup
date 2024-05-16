Imports System.IO

Public Class CardCards
    Dim db As New Database()
    Dim _car As VehicleDetails
    Dim _session As UserSession
    Dim _costumerBooking As CostumerBooking

    Public Sub New(car As VehicleDetails, session As UserSession, costumerBooking As CostumerBooking)
        InitializeComponent()


        _car = car
        _session = session
        _costumerBooking = costumerBooking

        If car.IsAvailable = True Then
            lbl_available.Text = "Available"
        Else
            lbl_available.Text = "Not Available"
            lbl_available.ForeColor = ColorTranslator.FromHtml("#7D0000")
        End If
        If car.DailyPrice >= 10000 Then
            lbl_Premium.Visible = True
        End If

        lbl_carModel.Text = car.ModelName
        lbl_carType.Text = car.Type
        lbl_carCapacity.Text = car.Capacity.ToString()
        lbl_carColor.Text = car.Color
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

    Private Sub btnRentNow_Click(sender As Object, e As EventArgs) Handles btnRentNow.Click
        'If db.GetUserCredit(_session.UID) > _car.DailyPrice Then
        '    Dim rentnow As New RentNowDetails(_car, _session, _costumerBooking)
        '    rentnow.ShowDialog()
        'Else
        '    MessageBox.Show("Insufficient Credits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Dim rentnow As New RentNowDetails(_car, _session, _costumerBooking)
        rentnow.ShowDialog()


    End Sub

End Class
