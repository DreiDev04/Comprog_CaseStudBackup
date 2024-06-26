﻿Public Class SignUp
    Dim auth As New AuthManager

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_Birthday.MinDate = Date.Today.AddYears(-100)
        dtp_Birthday.MaxDate = Date.Today.AddYears(-18)
        dtp_Birthday.Value = dtp_Birthday.MaxDate
    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        If Not ValidateFields() Then
            Return
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtb_Age.Text, age) Then
            MessageBox.Show("Age must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim sex As String = GetSelectedGender()
        If sex = "" Then
            MessageBox.Show("Please select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim birthday As Date = dtp_Birthday.Value ' Ensure this is correctly assigned
            auth.SignUp(txtb_Name.Text, age, birthday, sex, txtb_Address.Text, txtb_Username.Text, txtb_Password.Text, txtb_Email.Text)
            MessageBox.Show("Signup successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'ClearFields()
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateFields() As Boolean
        If txtb_Name.Text = "" OrElse
       txtb_Age.Text = "" OrElse
       dtp_Birthday.Value = Nothing OrElse
       txtb_Address.Text = "" OrElse
       txtb_Username.Text = "" OrElse
       txtb_Password.Text = "" OrElse
       txtb_Email.Text = "" OrElse
       txtb_ConfPassword.Text = "" OrElse
       txtb_Password.Text <> txtb_ConfPassword.Text Then
            MessageBox.Show("Please fill in all the fields and ensure passwords match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not IsPasswordValid(txtb_Password.Text) Then
            MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one numeric character, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If CalculateAge(dtp_Birthday.Value) < 18 Then
            MessageBox.Show("You must be at least 18 years old to sign up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If dtp_Birthday.Value > dtp_Birthday.MaxDate Or dtp_Birthday.Value < dtp_Birthday.MinDate Then
            MessageBox.Show("Birthday must be within the allowed range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function GetSelectedGender() As String
        If rbtn_Male.Checked Then
            Return "Male"
        ElseIf rbtn_Female.Checked Then
            Return "Female"
        Else
            Return ""
        End If
    End Function

    Private Sub ClearFields()
        txtb_Name.Clear()
        txtb_Age.Clear()
        dtp_Birthday.Value = Date.Today
        txtb_Address.Clear()
        txtb_Username.Clear()
        txtb_Password.Clear()
        txtb_ConfPassword.Clear()
        txtb_Email.Clear()
        Me.Dispose()
        LogIn.Show()
    End Sub

    Private Sub dtp_Birthday_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Birthday.ValueChanged
        If dtp_Birthday.Value > dtp_Birthday.MaxDate Or dtp_Birthday.Value < dtp_Birthday.MinDate Then
            MessageBox.Show("Invalid birthday", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtp_Birthday.Value = dtp_Birthday.MaxDate ' Reset to the max allowable date
        End If
        txtb_Age.Text = CalculateAge(dtp_Birthday.Value).ToString()
    End Sub

    Private Function IsPasswordValid(password As String) As Boolean
        ' Check if password length is at least 8 characters
        If password.Length < 8 Then
            Return False
        End If

        ' Check if password contains at least one uppercase letter
        Dim hasUpperCase As Boolean = False
        For Each c As Char In password
            If Char.IsUpper(c) Then
                hasUpperCase = True
                Exit For
            End If
        Next

        If Not hasUpperCase Then
            Return False
        End If

        ' Check if password contains at least one numeric character
        Dim hasNumeric As Boolean = False
        For Each c As Char In password
            If Char.IsDigit(c) Then
                hasNumeric = True
                Exit For
            End If
        Next

        If Not hasNumeric Then
            Return False
        End If

        ' Check if password contains at least one special character
        Dim hasSpecial As Boolean = False
        For Each c As Char In password
            If Not Char.IsLetterOrDigit(c) Then
                hasSpecial = True
                Exit For
            End If
        Next

        If Not hasSpecial Then
            Return False
        End If

        ' If all criteria are met, return true
        Return True
    End Function

    Private Function CalculateAge(birthday As Date) As Integer
        Dim age As Integer = Date.Today.Year - birthday.Year
        If (birthday > Date.Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub lklbl_ClickHere_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklbl_ClickHere.LinkClicked
        Me.Dispose()
        Dim loginForm As New LogIn()
        loginForm.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub

End Class
