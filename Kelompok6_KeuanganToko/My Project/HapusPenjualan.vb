Public Class HapusPenjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabID.Text = Penjualan.barangMasuk.GSId.ToString

        LabNamaBarang.Text = Penjualan.barangMasuk.GSNamaBarang
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim isDeleted = Penjualan.barangMasuk.DeleteBarangMasuk(Penjualan.barangMasuk.GSId)

        If isDeleted Then
            MessageBox.Show("data berhasil dihapus")
            Me.Close()
            Penjualan.reloadBarangMasukTable()
        Else
            MessageBox.Show("terjadi kesalahan")
        End If
    End Sub
End Class