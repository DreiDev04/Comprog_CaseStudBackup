Public Class RentalTemplate

    Private _UID As String
    Private _orderID As String
    Private _carID As String
    Private _startDate As Date
    Private _returnDate As Date
    Private _isOverdue As Boolean
    Private _totalPrice As Double
    Private _isReturned As Boolean


    Public Sub New(UID As String, orderId As String, carID As String, startDate As Date, returnDate As Date, isReturned As Boolean, isOverdue As Boolean, totalPrice As Double)
        _UID = UID
        _orderID = orderId
        _carID = carID
        _startDate = startDate
        _returnDate = returnDate
        _isReturned = isReturned
        _isOverdue = isOverdue
        _totalPrice = totalPrice
    End Sub

    Public Property UID As String
        Get
            Return _UID
        End Get
        Set(value As String)
            _UID = value
        End Set
    End Property
    Public Property OrderID As String
        Get
            Return _orderID
        End Get
        Set(value As String)
            _orderID = value
        End Set
    End Property

    Public Property CarID As String
        Get
            Return _carID
        End Get
        Set(value As String)
            _carID = value
        End Set
    End Property


    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property ReturnDate As Date
        Get
            Return _returnDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property
    Public Property IsReturned As Boolean
        Get
            Return _isReturned
        End Get
        Set(value As Boolean)
            _isReturned = value
        End Set
    End Property
    Public Property IsOverdue As Boolean
        Get
            Return _isOverdue
        End Get
        Set(value As Boolean)
            _isOverdue = value
        End Set
    End Property

    Public Property TotalPrice As Double
        Get
            Return _totalPrice
        End Get
        Set(value As Double)
            _totalPrice = value
        End Set
    End Property


End Class
