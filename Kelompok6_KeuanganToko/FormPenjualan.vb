Public Class FormPenjualan
    Public Shared penjualan As New Penjualan
    Public Property Gridpenjualan_Load As Object

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reloadBarangMasukTable()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahPenjualan.Show()
    End Sub




    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DataGridViewPenjualan.SelectedRows.Count = 1 Then

            penjualan.GSId = DataGridViewPenjualan.Item("ID", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSNamaBarang = DataGridViewPenjualan.Item("NAMA BARANG", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSQty = DataGridViewPenjualan.Item("JUMlAH", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSTanggalMasuk = DataGridViewPenjualan.Item("TANGGAL JUAL", DataGridViewPenjualan.CurrentRow.Index).Value

            UpdatePenjualan.Show()

        Else
            MessageBox.Show("perlu memilih data ditampilkan dalam tabel")
        End If
    End Sub

    Public Sub reloadBarangMasukTable()
        DataGridViewPenjualan.DataSource = penjualan.ShowAllData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridViewPenjualan.SelectedRows.Count = 1 Then
            penjualan.GSId = DataGridViewPenjualan.Item("ID", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSNamaBarang = DataGridViewPenjualan.Item("nama barang", DataGridViewPenjualan.CurrentRow.Index).Value
            HapusPenjualan.Show()
        Else
            MessageBox.Show("Pilih Data Dalam Table")
        End If
    End Sub


End Class