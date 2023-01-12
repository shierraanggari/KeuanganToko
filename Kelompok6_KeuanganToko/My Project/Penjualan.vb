Public Class Penjualan
    Public Shared penjualan As New Penjualan
    Public Property Gridpenjualan_Load As Object

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reloadBarangMasukTable()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        BtnTambah.Show()
    End Sub




    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DataGridViewPenjualan.SelectedRows.Count = 1 Then

            penjualan.GSId = DataGridViewPenjualan.Item("ID", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSNamaBarang = DataGridViewPenjualan.Item("NAMA BARANG", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSQty = DataGridViewPenjualan.Item("QTY", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSTanggalMasuk = DataGridViewPenjualan.Item("Tanggl masuk", DataGridViewPenjualan.CurrentRow.Index).Value

            UpdatePenjualan.Show()

        Else
            MessageBox.Show("perlu memilih data ditampilkan dalam tabel")
        End If
    End Sub

    Public Sub reloadBarangMasukTable()
        DataGridViewPenjualan.DataSource = penjualan.ShowAllData()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Gridpenjualan_Load.SelectedRows.Count = 1 Then
            penjualan.GSId = DataGridViewPenjualan.Item("ID", DataGridViewPenjualan.CurrentRow.Index).Value
            penjualan.GSNamaBarang = DataGridViewPenjualan.Item("nama barang", DataGridViewPenjualan.CurrentRow.Index).Value
            HapusPenjualan.Show()
        Else
            MessageBox.Show("Pilih Data Dalam Table")
        End If
    End Sub

    Private Sub penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class