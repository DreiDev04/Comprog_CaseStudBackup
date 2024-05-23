Imports System.IO

Public Class Database
    Private ReadOnly _Directory As String
    Private ReadOnly _FileDir As String
    Private ReadOnly _USER_CSV_FILE As String
    Private ReadOnly _VEHICLE_CSV_FILE As String
    Private ReadOnly _RENTAL_CSV_FILE As String


    Public Sub New()
        _Directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\Forms\Database"
        _FileDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\Forms"

        _USER_CSV_FILE = Path.Combine(_Directory, "user_csv_file.csv")
        _VEHICLE_CSV_FILE = Path.Combine(_Directory, "vehicle_csv_file.csv")
        _RENTAL_CSV_FILE = Path.Combine(_Directory, "rental_csv_file.csv")

        If Not Directory.Exists(_Directory) Then
            Directory.CreateDirectory(_Directory)
        End If

    End Sub


    Public Sub AddBooking(rental As RentalTemplate)
        If Not File.Exists(_RENTAL_CSV_FILE) Then

            Using writer As New StreamWriter(_RENTAL_CSV_FILE)
                writer.WriteLine("UID~Order ID~Card ID~Start Date~Return Date~IsReturuned~IsOverdue~Total Price")
            End Using
        End If

        Using writer As New StreamWriter(_RENTAL_CSV_FILE, True)
            writer.WriteLine($"{rental.UID}~{rental.OrderID}~{rental.CarID}~{rental.StartDate}~{rental.ReturnDate}~{rental.IsReturned}~{rental.IsOverdue}~{rental.TotalPrice}")
        End Using
    End Sub

    Public Function GetBokkingToDB() As List(Of RentalTemplate)
        Dim bookingList As New List(Of RentalTemplate)
        Using reader As New StreamReader(_RENTAL_CSV_FILE)
            Dim line As String
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If isFirstLine Then
                    isFirstLine = False
                    Continue While
                End If
                Dim fields As String() = line.Split("~")
                Dim booking As New RentalTemplate(fields(0), (fields(1)), fields(2), Date.Parse(fields(3)), Date.Parse(fields(4)), Boolean.Parse(fields(5)), Boolean.Parse(fields(6)), Double.Parse(fields(7)))

                bookingList.Add(booking)
            End While
        End Using
        Return bookingList

    End Function


    Public Sub AddUserToDB(user As UserTemplate)

        If Not File.Exists(_USER_CSV_FILE) Then

            Using writer As New StreamWriter(_USER_CSV_FILE)
                writer.WriteLine("UID~Name~Age~Birthday~Sex~Address~Username~Password~Email~RemainingDays~IsGoodRecord~credits")
            End Using
        End If

        Using writer As New StreamWriter(_USER_CSV_FILE, True)
            writer.WriteLine($"{user.UID}~{user.Name}~{user.Age}~{user.Birthday.Date}~{user.Sex}~{user.Address}~{user.Username}~{user.Password}~{user.Email}~{user.RemainingDays}~{user.IsGoodRecord}~{user.Credits}")
        End Using
    End Sub
    Public Sub AddCarToDB(car As VehicleDetails)

        If Not File.Exists(_VEHICLE_CSV_FILE) Then

            Using writer As New StreamWriter(_VEHICLE_CSV_FILE)
                writer.WriteLine("CarID~ModelName~PlateNumber~Color~Type~Capacity~BodyNumber~IsAvailable~DailyPrice~PosterPath~Description")
            End Using
        End If

        Using writer As New StreamWriter(_VEHICLE_CSV_FILE, True)
            writer.WriteLine($"{car.CarID}~{car.ModelName}~{car.PlateNumber}~{car.Color}~{car.Type}~{car.Capacity}~{car.BodyNumber}~{car.IsAvailable}~{car.DailyPrice}~{car.PosterPath}~{car.Description}")

        End Using
    End Sub
    Public Function GetUsers() As List(Of UserTemplate)
        Dim userList As New List(Of UserTemplate)()

        Using reader As New StreamReader(_USER_CSV_FILE)
            Dim line As String
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If isFirstLine Then
                    isFirstLine = False
                    Continue While
                End If
                Dim fields As String() = line.Split("~")
                Dim user As New UserTemplate(fields(0), fields(1), Integer.Parse(fields(2)), Date.Parse(fields(3)), fields(4), fields(5), fields(6), fields(7), fields(8), Integer.Parse(fields(9)), Boolean.Parse(fields(10)), Double.Parse(fields(11)))
                userList.Add(user)

            End While
        End Using
        Return userList
    End Function
    Public Function GetSpecificUser(UID As String) As UserTemplate
        Dim userToReturn As UserTemplate = Nothing
        Using reader As New StreamReader(_USER_CSV_FILE)
            Dim line As String
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If isFirstLine Then
                    isFirstLine = False
                    Continue While
                End If
                Dim fields As String() = line.Split("~")
                Dim user As New UserTemplate(fields(0), fields(1), Integer.Parse(fields(2)), Date.Parse(fields(3)), fields(4), fields(5), fields(6), fields(7), fields(8), Integer.Parse(fields(9)), Boolean.Parse(fields(10)), Double.Parse(fields(11)))
                If user.UID = UID Then
                    userToReturn = user
                    Exit While
                End If
            End While
        End Using
        Return userToReturn
    End Function
    Public Function GetCars() As List(Of VehicleDetails)
        Dim carList As New List(Of VehicleDetails)()

        Using reader As New StreamReader(_VEHICLE_CSV_FILE)
            Dim line As String
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If isFirstLine Then
                    isFirstLine = False
                    Continue While
                End If
                Dim fields As String() = line.Split("~")
                Dim car As New VehicleDetails(fields(0), fields(1), fields(2), fields(3), fields(4), Integer.Parse(fields(5)), fields(6), Boolean.Parse(fields(7)), Double.Parse(fields(8)), fields(9), fields(10))
                carList.Add(car)

            End While
        End Using
        Return carList
    End Function

    Public Function GetSpecificCar(CarUID As String) As VehicleDetails
        Dim carToReturn As VehicleDetails = Nothing
        Using reader As New StreamReader(_VEHICLE_CSV_FILE)
            Dim line As String
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                line = reader.ReadLine()
                If isFirstLine Then
                    isFirstLine = False
                    Continue While
                End If
                Dim fields As String() = line.Split("~")
                Dim car As New VehicleDetails(fields(0), fields(1), fields(2), fields(3), fields(4), Integer.Parse(fields(5)), fields(6), Boolean.Parse(fields(7)), Double.Parse(fields(8)), fields(9), fields(10))

                If car.CarID = CarUID Then
                    carToReturn = car
                    Exit While
                End If
            End While
        End Using
        Return carToReturn
    End Function
    Public Function AddCreditToUser(UID As String, credit As Double) As Boolean
        Dim user As UserTemplate = GetSpecificUser(UID)
        If user Is Nothing Then
            Return False
        End If
        user.Credits += credit
        Dim users As List(Of UserTemplate) = GetUsers()
        Dim userIndex As Integer = users.FindIndex(Function(u) u.UID = UID)
        users(userIndex) = user
        File.Delete(_USER_CSV_FILE)
        For Each u As UserTemplate In users
            AddUserToDB(u)
        Next
        Return True
    End Function
    Public Function GetUserCredit(UID As String)
        Dim user As UserTemplate = GetSpecificUser(UID)
        If user Is Nothing Then
            Return 0
        End If
        Return user.Credits
    End Function
    Public Function SubtractCreditToUser(UID As String, credit As Double)
        Dim user As UserTemplate = GetSpecificUser(UID)
        If user Is Nothing Then
            Return False
        End If
        user.Credits -= credit
        Dim users As List(Of UserTemplate) = GetUsers()
        Dim userIndex As Integer = users.FindIndex(Function(u) u.UID = UID)
        users(userIndex) = user
        File.Delete(_USER_CSV_FILE)
        For Each u As UserTemplate In users
            AddUserToDB(u)
        Next
        Return True

    End Function

    Public Sub UpdateOverdue(UID As String, orderID As String)
        Dim rentals As List(Of RentalTemplate) = GetBokkingToDB()
        Dim rentalIndex As Integer = rentals.FindIndex(Function(r) r.UID = UID AndAlso r.OrderID = orderID)
        If rentalIndex <> -1 Then
            rentals(rentalIndex).IsOverdue = True

            ' Rewrite the entire list of rentals to the file
            File.Delete(_RENTAL_CSV_FILE)
            For Each r As RentalTemplate In rentals
                AddBooking(r)
            Next
        Else
            MsgBox("Rental with UID " & UID & " and orderID " & orderID & " not found.")
        End If
    End Sub
    Public Sub ValidateGoodRecord(UID As String, BoolVal As Boolean)

        Dim user As UserTemplate = GetSpecificUser(UID)
        If user Is Nothing Then
            MsgBox("User with UID " & UID & " not found.")
            Exit Sub
        End If
        user.IsGoodRecord = BoolVal
        Dim users As List(Of UserTemplate) = GetUsers()
        Dim userIndex As Integer = users.FindIndex(Function(u) u.UID = UID)
        users(userIndex) = user
        File.Delete(_USER_CSV_FILE)
        For Each u As UserTemplate In users
            AddUserToDB(u)
        Next
    End Sub

    Public ReadOnly Property get_Directory As String
        Get
            Return _Directory
        End Get
    End Property
    Public ReadOnly Property get_FileDir As String
        Get
            Return _FileDir
        End Get
    End Property
    Public ReadOnly Property get_UserCsvFile As String
        Get
            Return _USER_CSV_FILE
        End Get
    End Property
    Public ReadOnly Property get_VehicleCsvFile As String
        Get
            Return _VEHICLE_CSV_FILE
        End Get
    End Property

    Public ReadOnly Property get_RentalCsvFile As String
        Get
            Return _RENTAL_CSV_FILE
        End Get
    End Property



End Class
