Public Class CostumerBooking
    Dim _userSession As New UserSession
    Dim _currentUser As New UserTemplate
    Dim db As New Database()
    Dim auth As New AuthManager()



    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(Usersession As UserSession)
        InitializeComponent()
        _userSession = Usersession
    End Sub
    Private Sub CostumerBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set Padding to 0
        For Each ctrl As Control In tblLayout_body.Controls
            ctrl.Margin = New Padding(0)
        Next
        tblLayout_body.Margin = New Padding(0)

        ' Set tab control appearance
        tabCtrl_body.ItemSize = New Size(0, 1)
        tabCtrl_body.SizeMode = TabSizeMode.Fixed


        'load cars
        Dim cars As List(Of VehicleDetails) = db.GetCars()
        For Each car As VehicleDetails In cars
            'do a code if car is not available
            Dim pnl As New CardCards(car, _userSession, Me)
            flp_rentCarsMain.Controls.Add(pnl)
        Next


        fetchRentals()



        _currentUser = db.GetSpecificUser(_userSession.UID)
        lbl_accountName.Text = _currentUser.Username

        Dim creds As Double = _currentUser.Credits
        Dim pesoCulture As New System.Globalization.CultureInfo("en-PH")
        lbl_accCreds.Text = creds.ToString("C2", pesoCulture)


        lbl_heroTitle.Parent = pb_image
        lbl_subHero.Parent = pb_image




    End Sub

    Private Sub fetchRentals()
        flp_booking.Controls.Clear()
        Dim Rentals As List(Of RentalTemplate) = db.GetBokkingToDB()
        For Each rent As RentalTemplate In Rentals
            If (rent.UID = _userSession.UID) Then
                Dim pnl As New CarBooking(rent.CarID, rent.StartDate, rent.ReturnDate, rent.IsOverdue, rent.TotalPrice)

                flp_booking.Controls.Add(pnl)
            End If
        Next
    End Sub

    Private Sub lbl_navLogoTitle1_Click(sender As Object, e As EventArgs) Handles lbl_navLogoTitle1.Click
        tabCtrl_body.SelectedTab = tabCtrl_body.TabPages(0)
    End Sub
    Private Sub btn_rentCars_CLick(sender As Object, e As EventArgs) Handles btn_rentCars.Click
        tabCtrl_body.SelectedTab = tabCtrl_body.TabPages(1)
    End Sub

    Private Sub btn_billings_Click(sender As Object, e As EventArgs) Handles btn_billings.Click
        tabCtrl_body.SelectedTab = tabCtrl_body.TabPages(2)
    End Sub

    Private Sub btn_booking_Click(sender As Object, e As EventArgs) Handles btn_booking.Click
        tabCtrl_body.SelectedTab = tabCtrl_body.TabPages(3)
        fetchRentals()
    End Sub

    Private Sub btn_addCredit_Click(sender As Object, e As EventArgs) Handles btn_addCredit.Click
        Dim topUp As New TopUp(_currentUser, Me)
        topUp.ShowDialog()
    End Sub
    Private Sub btn_Rent_Click(sender As Object, e As EventArgs) Handles btn_Rent.Click
        tabCtrl_body.SelectedTab = tabCtrl_body.TabPages(1)
    End Sub

    Private Sub btn_logOut_Click(sender As Object, e As EventArgs) Handles btn_logOut.Click
        auth.LogOut()
        Me.Dispose()
        LogIn.Show()
    End Sub

    Public Sub UpdateCreditsLabel(credits As Double)
        Dim pesoCulture As New System.Globalization.CultureInfo("en-PH")
        lbl_accCreds.Text = credits.ToString("C2", pesoCulture)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreen.Dispose()
    End Sub

End Class