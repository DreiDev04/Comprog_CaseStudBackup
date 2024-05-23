Public Class SplashScreenV2
    Dim db As New Database()
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignUp.Show()
        'Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel6.Width += 3
        If Panel6.Width >= 965 Then
            Timer1.Stop()
            Panel1.Visible = True
            Panel4.Visible = True
            Panel8.Visible = True
            Panel5.Visible = False

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class