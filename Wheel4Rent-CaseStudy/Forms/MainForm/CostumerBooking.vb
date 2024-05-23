Imports System.Globalization

Public Class CostumerBooking
    Private _userSession As UserSession
    Private _currentUser As UserTemplate
    Private db As New Database()
    Private auth As New AuthManager()

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(userSession As UserSession)
        InitializeComponent()
        _userSession = userSession
    End Sub

    Private Sub CostumerBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupControls()

        ValidateOverDue()



        LoadCars(_userSession.UID)
        lbl_currRecord.Text = GoodRecordPrint(_userSession.UID)


        FetchRentals()
        _currentUser = db.GetSpecificUser(_userSession.UID)
        UpdateAccountInfo(_currentUser)
        lbl_heroTitle.Parent = pb_image
        lbl_subHero.Parent = pb_image
    End Sub

    Function GoodRecordPrint(UID As String)
        Dim user As UserTemplate = db.GetSpecificUser(UID)
        If user Is Nothing Then
            MsgBox("User with UID " & UID & " not found.")
            Exit Function
        End If
        If user.IsGoodRecord = True Then
            Return "Record: Good"
        Else
            Return "Record: Bad"
        End If
    End Function

    Private Sub SetupControls()
        For Each ctrl As Control In tblLayout_body.Controls
            ctrl.Margin = New Padding(0)
        Next
        tblLayout_body.Margin = New Padding(0)
        tabCtrl_body.ItemSize = New Size(0, 1)
        tabCtrl_body.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub LoadCars(UID As String)
        flp_rentCarsMain.Controls.Clear()

        Dim user As UserTemplate = db.GetSpecificUser(UID)
        Dim cars As List(Of VehicleDetails) = db.GetCars()

        If user Is Nothing Then
            MsgBox("User with UID " & UID & " not found.")
            Exit Sub
        End If

        If user.IsGoodRecord = False Then
            For Each car As VehicleDetails In cars
                Dim pnl As New CardCards(car, _userSession, Me)
                pnl.btnRentNow.Enabled = False
                flp_rentCarsMain.Controls.Add(pnl)
            Next
        Else
            For Each car As VehicleDetails In cars
                Dim pnl As New CardCards(car, _userSession, Me)
                flp_rentCarsMain.Controls.Add(pnl)
            Next
        End If

        'For Each car As VehicleDetails In cars
        '    Dim pnl As New CardCards(car, _userSession, Me)
        '    flp_rentCarsMain.Controls.Add(pnl)
        'Next
    End Sub

    Private Sub FetchRentals()
        flp_booking.Controls.Clear()
        Dim Rentals As List(Of RentalTemplate) = db.GetBokkingToDB()
        For Each rent As RentalTemplate In Rentals
            If (rent.UID = _userSession.UID) Then
                Dim pnl As New CarBooking(rent.CarID, rent.StartDate, rent.ReturnDate, rent.IsOverdue, rent.TotalPrice)
                flp_booking.Controls.Add(pnl)
            End If
        Next
    End Sub

    Private Sub UpdateAccountInfo(user As UserTemplate)
        lbl_accountName.Text = user.Username
        lbl_accCreds.Text = user.Credits.ToString("C2", New CultureInfo("en-PH"))
    End Sub

    Private Sub ValidateOverDue()
        Dim Rentals As List(Of RentalTemplate) = db.GetBokkingToDB()
        For Each rent As RentalTemplate In Rentals
            If (rent.UID = _userSession.UID) Then
                If (rent.ReturnDate < Date.Now) Then
                    db.UpdateOverdue(_userSession.UID, rent.OrderID)
                    MessageBox.Show("You have an overdue booking. Please pay the overdue fee to Wheels4Rent main branch before renting.", "Overdue Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    db.ValidateGoodRecord(_userSession.UID, False)
                End If
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
        FetchRentals()
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
        lbl_accCreds.Text = credits.ToString("C2", New CultureInfo("en-PH"))
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub
End Class
