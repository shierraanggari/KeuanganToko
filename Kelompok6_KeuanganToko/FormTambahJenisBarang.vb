Imports System.Threading

Public Class FormTambahJenisBarang
    Public Shared jenis As New DataJenisBarang
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim namaJenis = TxtJenisBarang.Text

        If String.IsNullOrEmpty(namaJenis) Then
            MessageBox.Show("Masukkan Jenis Barang!")
        Else
            jenis.AddJenis(namaJenis)
            MessageBox.Show("Jenis Barang Berhasil Ditambahkan!")
            Me.Close()
            FormJenisBarang.ReloadDataTable()
        End If

    End Sub
End Class