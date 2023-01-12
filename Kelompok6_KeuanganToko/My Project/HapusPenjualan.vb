Public Class HapusPenjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabID.Text = Penjualan.penjualan.GSId.ToString

        LabNamaBarang.Text = Penjualan.penjualan.GSNamaBarang
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim isDeleted = Penjualan.penjualan.DeletePenjualan(Penjualan.penjualan.GSId)

        If isDeleted Then
            MessageBox.Show("data berhasil dihapus")
            Me.Close()
            Penjualan.reloadBarangMasukTable()
        Else
            MessageBox.Show("terjadi kesalahan")
        End If
    End Sub
End Class