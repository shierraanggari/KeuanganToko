Imports System.ComponentModel

Public Class Barang
    'Public Shared data_barang = New DataBarang()

    Public Shared data_barang As DataBarang

    Public Shared selectedTableBarang
    Public Shared selectedTableBarangNama
    'Public Shared kol_nama As DataGridViewColumn

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToScreen()

        data_barang = New DataBarang()
        NamaToolStripMenuItem.Text = Login.data_user.GSUsername

        ReloadDataTableDatabase()
        DataGridViewProperties()

        'Dim kol_nama = DataGridViewBarang.Columns["Nama Barang"].FillWeight
        'kol_nama = 60

        'Dim ds
        'DataGridViewBarang.Columns[3].Width = 60;
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambahbarang = New TambahBarang()
        tambahbarang.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim dataselected As List(Of String) = data_barang.GetDataBarangByIDDatabase(selectedTableBarang)

        data_barang.GSNamaBarang = dataselected(1)
        data_barang.GSJenisBarang = dataselected(2)
        data_barang.GSStok = dataselected(3)
        data_barang.GSHarga = dataselected(4)
        data_barang.GSTanggalMasuk = dataselected(5)
        data_barang.GSTanggalKadaluarsa = dataselected(6)

        Dim updatebarang = New UpdateBarang()
        updatebarang.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapusbarang = New HapusBarang()
        hapusbarang.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Dim login = New Login()
        login.Show()
    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarang.Rows(index)

        selectedTableBarang = selectedRow.Cells(0).Value
        selectedTableBarangNama = selectedRow.Cells(1).Value

        BtnUpdate.Show()
        BtnHapus.Show()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridViewBarang.DataSource = data_barang.GetDataBarangDatabase
    End Sub

    Private Sub Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub Barang_Click(sender As Object, e As EventArgs) Handles Me.Click
        DataGridViewBarang.ClearSelection()
        BtnUpdate.Hide()
        BtnHapus.Hide()
    End Sub

    Private Sub DataGridViewProperties()
        With DataGridViewBarang.DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .Font = New Font("Arial", 9, FontStyle.Regular)
        End With

        With DataGridViewBarang.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .Font = New Font("Arial", 9, FontStyle.Bold)
        End With

        With DataGridViewBarang.Columns("Nama Barang")
            .Width = 180
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        DataGridViewBarang.Columns("ID Barang").Width = 80
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FormJenisBarang.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FormPenjualan.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MainBarangMasuk.Show()
    End Sub
End Class