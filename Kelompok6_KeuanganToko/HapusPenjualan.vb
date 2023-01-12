Public Class HapusPenjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabID.Text = FormPenjualan.penjualan.GSId.ToString

        LabNamaBarang.Text = FormPenjualan.penjualan.GSNamaBarang
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim isDeleted = FormPenjualan.penjualan.DeletePenjualan(FormPenjualan.penjualan.GSId)

        If isDeleted Then
            MessageBox.Show("data berhasil dihapus")
            Me.Close()
            FormPenjualan.reloadBarangMasukTable()
        Else
            MessageBox.Show("terjadi kesalahan")
        End If
    End Sub
End Class