Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lbl_name.Parent = PictureBox1
        'Dim fnt1 As PrivateFontCollection = New PrivateFontCollection
        'fnt1.AddFontFile("Frijole-Regular.ttf")
        'lbl_name.Font = New Font(fnt1.Families(0), 24)
        'lbl_name.ForeColor = Color.White

        'lbl_word1quality.Parent = PictureBox1
        'Dim fnt2 As PrivateFontCollection = New PrivateFontCollection
        'fnt2.AddFontFile("YaldeviColombo-Bold.ttf")
        'lbl_word1quality.Font = New Font(fnt2.Families(0), 14)
        'lbl_word1quality.ForeColor = Color.OrangeRed

        'lbl_word2car.Parent = PictureBox1
        'Dim fnt3 As PrivateFontCollection = New PrivateFontCollection
        'fnt3.AddFontFile("PassionOne-Bold.ttf")
        'lbl_word2car.Font = New Font(fnt3.Families(0), 48)
        'lbl_word2car.ForeColor = Color.White

        'lbl_word3best.Parent = PictureBox1
        'Dim fnt4 As PrivateFontCollection = New PrivateFontCollection
        'fnt4.AddFontFile("Share-Bold.ttf")
        'lbl_word3best.Font = New Font(fnt4.Families(0), 11)
        'lbl_word3best.ForeColor = Color.White

        'Dim fntb As PrivateFontCollection = New PrivateFontCollection
        'fntb.AddFontFile("Share-Bold.ttf")
        'btn_login.Font = New Font(fntb.Families(0), 9)
        'btn_login.ForeColor = Color.Black
        'btn_login.BackColor = Color.Transparent
        ''btn_login.FlatStyle = FlatStyle.Flat

        'Dim fntb2 As PrivateFontCollection = New PrivateFontCollection
        'fntb2.AddFontFile("Share-Bold.ttf")
        'btn_register.Font = New Font(fnt2.Families(0), 10.2)
        'btn_register.ForeColor = Color.Red

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        SignUp.Show()
        Me.Hide()
    End Sub
End Class