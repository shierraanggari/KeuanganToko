Public Class Penjualan
    Public Shared barangMasuk As New Penjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reloadBarangMasukTable()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Penjualan.Show()
    End Sub




    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If GridBarangMasuk.SelectedRows.count = 1 Then

            barangMasuk.GSId = UpdatePenjualan.Item("ID", GridBarangMasuk.CurrentRow.Index).value
            barangMasuk.GSNamaBarang = GridupdatePenjualan.Item("NAMA BARANG", GridBarangMasuk.CurrentRow.index)Value
            barangMasuk.GSQty = GridBarangMasuk.Item("QTY", GridbarangMasuk.CurrentRow.index)Value
            barangMasuk.GSTanggalMasuk = GridBarangMasuk.Item("Tanggl masuk", GridBarangMasuk.CurrentRow.index)Value

            UpdatePenjualan.Show()

        Else
            MessageBox.Show("perlu memilih data ditampilkan dalam tabel")
        End If
    End Sub

    Public Sub reloadBarangMasukTable()
        GridBarangMasuk.Datasource = barangMasuk.showALLData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If GridBarangMasuk.SelectedRows.Count = 1 Then
            barangMasuk.GSId = GridBarangMasuk.Item("ID", GridBarangMasuk.CurrentRow.Index).Value
            barangMasuk.GSNamaBarang = GridBarangMasuk.Item("nama barang", GridBarangMasuk.CurrentRow.Index).value
            DeleteBarangMasuk.Show()
        Else
            MessageBox.Show("Pilih Data Dalam Table")
        End If
    End Sub
End Class