Public Class HapusBarang

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToScreen()
        LblNamaBarang.Text = Barang.selectedTableBarangNama
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Barang.data_barang.DeleteDataBarangByIDDatabase(Barang.selectedTableBarang)
        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class