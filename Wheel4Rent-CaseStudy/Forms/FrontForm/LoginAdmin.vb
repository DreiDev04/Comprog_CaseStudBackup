Public Class LoginAdmin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Const defaultUserName As String = "admin"
        Const defaultPassword As String = "admin"

        Dim userName As String = txtb_userName.Text.Trim()
        Dim password As String = txtb_password.Text.Trim()

        If String.IsNullOrEmpty(userName) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username and password cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If userName = defaultUserName AndAlso password = defaultPassword Then
            Me.Dispose()
            AdminForm.Show()
        Else
            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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