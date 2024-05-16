Imports System.IO

Public Class CarBooking
    ReadOnly db As New Database

    Dim _carID As String
    Dim _startDate As Date
    Dim _returnDate As Date
    Dim _isOverdue As Boolean
    Dim _totalprice As Double


    Public Sub New(carID As String, startDate As Date, returnDate As Date, isOverdue As Boolean, totalprice As Double)
        InitializeComponent()

        _carID = carID
        _startDate = startDate
        _returnDate = returnDate
        _isOverdue = isOverdue
        _totalprice = totalprice

        Dim car As VehicleDetails = db.GetSpecificCar(carID)

        lbl_CarModel.Text = car.ModelName
        lbl_carType.Text = car.Type
        lbl_totalPrice.Text = String.Format("{0:C}", _totalprice)
        dtp_start.Value = _startDate
        dtp_return.Value = _returnDate


        Dim posterPath = Directory.GetParent(db.get_FileDir()).ToString() + "\Resources\Images\Cars\" + car.PosterPath
        If File.Exists(posterPath) Then
            pb_carPoster.Image = Image.FromFile(posterPath)
        End If

        Dim daysLeft As Integer = DateDiff(DateInterval.Day, Date.Now, _returnDate) + 1


        If daysLeft = 0 Then
            lbl_daysLeft.Text = "Today is the return date"
        ElseIf daysLeft < 0 Then
            lbl_daysLeft.Text = "Overdue by " + Math.Abs(daysLeft).ToString() + " Day/s"
        Else
            lbl_daysLeft.ForeColor = ColorTranslator.FromHtml("#00B300")
            lbl_daysLeft.Text = daysLeft.ToString() + " Day/s left before return"
        End If

    End Sub

End Class
