Public Class UserTemplate
    Private _uid As String
    Private _name As String
    Private _age As Integer
    Private _birthday As Date
    Private _sex As String
    Private _address As String
    Private _username As String
    Private _password As String
    Private _email As String
    Private _remainingDays As Integer
    Private _isGoodRecord As Boolean
    Private _credits As Double

    Public Sub New()
        Me.New("", "", 0, Date.Now, "", "", "", "", "")
    End Sub
    Public Sub New(uid As String, name As String, age As Integer, birthday As Date, sex As String, address As String, username As String, password As String, email As String, remainingDays As Integer, isGoodRecord As Boolean, credits As Double)
        _uid = uid
        _name = name
        _age = age
        _birthday = birthday
        _sex = sex
        _address = address
        _username = username
        _password = password
        _email = email
        _remainingDays = remainingDays
        _isGoodRecord = isGoodRecord
        _credits = credits

    End Sub
    Public Sub New(uid As String, name As String, age As Integer, birthday As Date, sex As String, address As String, username As String, password As String, email As String)
        Me.New(uid, name, age, birthday, sex, address, username, password, email, 0, True, 0.0)
    End Sub

    Public Property UID As String
        Get
            Return _uid
        End Get
        Private Set(value As String)
            _uid = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Private Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Private Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Birthday As Date
        Get
            Return _birthday
        End Get
        Private Set(value As Date)
            _birthday = value
        End Set
    End Property

    Public Property Sex As String
        Get
            Return _sex
        End Get
        Private Set(value As String)
            _sex = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Private Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Private Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Private Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Private Set(value As String)
            _email = value
        End Set
    End Property


    Public Property RemainingDays As Integer
        Get
            Return _remainingDays
        End Get
        Private Set(value As Integer)
            _remainingDays = value
        End Set
    End Property

    Public Property IsGoodRecord As Boolean
        Get
            Return _isGoodRecord
        End Get
        Set(value As Boolean)
            _isGoodRecord = value
        End Set
    End Property

    Public Property Credits As Double
        Get
            Return _credits
        End Get
        Set(value As Double)
            _credits = value
        End Set
    End Property
End Class
