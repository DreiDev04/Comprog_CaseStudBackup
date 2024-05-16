Public Class VehicleDetails
    Private _modelName As String
    Private _carBrand As String
    Private _carID As String
    Private _plateNumber As String
    Private _color As String
    Private _type As String
    Private _capacity As Integer
    Private _bodyNumber As String
    Private _isAvailable As Boolean
    Private _dailyPrice As Double
    Private _posterPath As String
    Private _description As String

    Public Sub New(carID As String, modelName As String, plateNumber As String, color As String, type As String, capacity As Integer, bodyNumber As String, isAvailable As String, dailyPrice As Double, posterPath As String, description As String)
        _carID = carID
        _modelName = modelName
        _plateNumber = plateNumber
        _color = color
        _type = type
        _capacity = capacity
        _bodyNumber = bodyNumber
        _isAvailable = isAvailable
        _dailyPrice = dailyPrice
        _posterPath = posterPath
        _description = description


    End Sub

    Public Sub New()

    End Sub


    Public Property PosterPath As String
        Get
            Return _posterPath
        End Get
        Private Set(value As String)
            _posterPath = value
        End Set
    End Property

    Public Property ModelName As String
        Get
            Return _modelName
        End Get
        Private Set(value As String)
            _modelName = value
        End Set
    End Property


    Public Property CarID As String
        Get
            Return _carID
        End Get
        Private Set(value As String)
            _carID = value
        End Set
    End Property

    Public Property PlateNumber As String
        Get
            Return _plateNumber
        End Get
        Private Set(value As String)
            _plateNumber = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Private Set(value As String)
            _color = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _type
        End Get
        Private Set(value As String)
            _type = value
        End Set
    End Property

    Public Property Capacity As Integer
        Get
            Return _capacity
        End Get
        Private Set(value As Integer)
            _capacity = value
        End Set
    End Property

    Public Property BodyNumber As String
        Get
            Return _bodyNumber
        End Get
        Private Set(value As String)
            _bodyNumber = value
        End Set
    End Property

    Public Property IsAvailable As Boolean
        Get
            Return _isAvailable
        End Get
        Private Set(value As Boolean)
            _isAvailable = value
        End Set
    End Property

    Public Property DailyPrice As Double
        Get
            Return _dailyPrice
        End Get
        Private Set(value As Double)
            _dailyPrice = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return _description
        End Get
        Private Set(value As String)
            _description = value
        End Set
    End Property
End Class
