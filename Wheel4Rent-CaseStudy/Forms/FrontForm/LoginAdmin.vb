Public Class LoginAdmin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If (txtb_userName.Text = "admin" And txtb_password.Text = "admin") Then
            Me.Dispose()
            AdminForm.Show()
        End If
    End Sub

    Private Sub lnklbl_admin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_admin.LinkClicked
        Me.Dispose()
        LogIn.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub
End Class