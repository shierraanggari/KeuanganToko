Public Class Daftar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToScreen()

    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        If TxtUname.Text.Length > 0 And TxtEmail.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
            Login.data_user.AddUsersDatabase(TxtUname.Text, TxtEmail.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Please fill username, email, and password.")
        End If
    End Sub

    Private Sub LblMasuk_Click(sender As Object, e As EventArgs) Handles LblMasuk.Click
        Me.Close()
    End Sub
End Class