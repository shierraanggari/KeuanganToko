Public Class FormUpdateJenisBarang
    Private Sub BtnUpdateJenis_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenis.Click
        Dim namaJenis = TxtUpdateJenis.Text

        If String.IsNullOrEmpty(namaJenis) Then
            MessageBox.Show("Masukkan Jenis Barang Yang Ingin Diupdate!")
        Else
            FormJenisBarang.jenis.UpdateJenis(FormJenisBarang.jenis.GSID, namaJenis)
            MessageBox.Show("Jenis Barang Berhasil Diupdate!")
            Me.Close()
            FormJenisBarang.ReloadDataTable()
        End If
    End Sub
End Class