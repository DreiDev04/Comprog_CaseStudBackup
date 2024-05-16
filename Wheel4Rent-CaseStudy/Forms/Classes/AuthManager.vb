Public Class AuthManager
    ReadOnly db As New Database()
    Private Shared currentUser As UserSession

    Public Sub SignUp(name As String, age As Integer, birthday As Date, sex As String, address As String, username As String, password As String, email As String)
        Dim uid As String = CreateUID()


        Dim newUser As New UserTemplate(uid, name, age, birthday, sex, address, username, password, email)
        db.AddUserToDB(newUser)

    End Sub

    Public Sub LogIn(username As String, password As String)

        Dim users As List(Of UserTemplate) = db.GetUsers()
        Dim user As UserTemplate = users.Find(Function(u) u.Username = username And u.Password = password)

        If user Is Nothing Then
            Throw New Exception("Invalid username or password")
        End If

        currentUser = New UserSession() With {
            .Username = username,
            .UID = user.UID
        }
        'MsgBox("Logged in as " + currentUser.Username + " " + currentUser.UID)

    End Sub
    Public Sub LogOut()
        currentUser = Nothing
    End Sub

    Public Shared Function GetCurrentSession() As UserSession
        Return currentUser
    End Function

    Public Function CreateUID() As String
        Return Guid.NewGuid().ToString()
    End Function
End Class
