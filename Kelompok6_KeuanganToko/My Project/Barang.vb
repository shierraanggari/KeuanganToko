Imports Mysqlx.XDevAPI.Relational

Public Class Barang
    'Public Shared data_barang = New DataBarang()

    Public Shared data_barang As DataBarang
    Public Shared selectedDataBarang
    Public Shared selectedTableBarang
    Public Shared selectedTableBarangNama
    'Public Shared kol_nama As DataGridViewColumn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        data_barang = New DataBarang()
        Me.CenterToScreen()
        ReloadDataTableDatabase()

        'kol_nama = DataGridViewBarang.Columns[3];
        'kol_nama.Width = 60;

        'Dim ds
        'DataGridViewBarang.Columns[3].Width = 60;
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TambahBarang.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapusbarang = New HapusBarang()
        hapusbarang.Show()
    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarang.Rows(index)

        selectedTableBarang = selectedRow.Cells(0).Value
        selectedTableBarangNama = selectedRow.Cells(1).Value
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridViewBarang.DataSource = data_barang.GetDataBarangDatabase
    End Sub

    Private Sub Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
End Class