Public Class LogIn
    Dim auth As New AuthManager
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Try
            auth.LogIn(txtb_userName.Text, txtb_password.Text)
            Dim user As UserSession = AuthManager.GetCurrentSession()
            Dim instance As New CostumerBooking(user)
            instance.Show()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        SignUp.Show()
        Me.Dispose()
    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtb_userName.Focus()
    End Sub

    Private Sub lnklbl_admin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_admin.LinkClicked
        Me.Dispose()
        LoginAdmin.Show()

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub
End Class