Public Class FormJenisBarang
    Public Shared jenis As New DataJenisBarang
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReloadDataTable()


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Function ReloadDataTable()
        GridJenisBarang.DataSource = jenis.IndexJenisBarang

    End Function

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormTambahJenisBarang.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If GridJenisBarang.SelectedRows.Count < 1 Then
            MessageBox.Show("Silahkan Pilih Jenis Barang!")
        Else
            Dim idJenis = GridJenisBarang.Item("ID Jenis Barang", GridJenisBarang.CurrentRow.Index).Value
            Dim namaJenis = GridJenisBarang.Item("Jenis Barang", GridJenisBarang.CurrentRow.Index).Value

            jenis.GSID = idJenis
            jenis.GSNama = namaJenis

            FormUpdateJenisBarang.LblVarID.Text = idJenis
            FormUpdateJenisBarang.TxtUpdateJenis.Text = namaJenis
            FormUpdateJenisBarang.Show()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If GridJenisBarang.SelectedRows.Count < 1 Then
            MessageBox.Show("Silahkan Pilih Jenis Barang!")
        Else
            Dim idJenis = GridJenisBarang.Item("ID Jenis Barang", GridJenisBarang.CurrentRow.Index).Value
            Dim namaJenis = GridJenisBarang.Item("Jenis Barang", GridJenisBarang.CurrentRow.Index).Value
            jenis.GSID = idJenis
            jenis.GSNama = namaJenis

            FormHapusJenisBarang.LblID.Text = idJenis
            FormHapusJenisBarang.LblJenis.Text = namaJenis
            FormHapusJenisBarang.Show()
        End If
    End Sub
End Class