Public Class Login

    Public Shared data_user As DataUsers


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToScreen()

        data_user = New DataUsers()
        TxtPassword.PasswordChar = "•"
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUnameEmail As String = TxtUnameEmail.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim datauser As List(Of String)

        If plainUnameEmail.Contains("@"c) Then
            datauser = data_user.CheckAuthDatabase(plainUnameEmail, plainPassword, True)
        Else
            datauser = data_user.CheckAuthDatabase(plainUnameEmail, plainPassword, False)
        End If

        'MessageBox.Show(plainUnameEmail + plainPassword + datauser(0) + datauser(1))

        If datauser.Count > 0 Then
            data_user.GSUsername = datauser(1)
            Barang.Show()
            Me.Hide()
        Else
            MessageBox.Show("wrong password.")
        End If
    End Sub

    Private Sub LblDaftar_Click(sender As Object, e As EventArgs) Handles LblDaftar.Click
        Dim daftar = New Daftar
        daftar.Show()
    End Sub

    Private Sub PicPassword_Click(sender As Object, e As EventArgs) Handles PicPassword.Click
        If TxtPassword.PasswordChar = "•" Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "•"
        End If
    End Sub
End Class