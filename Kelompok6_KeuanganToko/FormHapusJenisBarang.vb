Public Class FormHapusJenisBarang
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        FormJenisBarang.jenis.DeleteData(FormJenisBarang.jenis.GSID)
        FormJenisBarang.ReloadDataTable()
        MessageBox.Show("Jenis Barang Berhasil Dihapus!")
        Me.Close()
    End Sub
End Class