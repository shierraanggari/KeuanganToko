Public Class MainBarangMasuk

    Public Shared barangMasuk As New BarangMasuk

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Memuat seluruh data yang ada di database tabel barang_masuk ke dalam datagrid
        'saat form pertama kali dijalankan
        reloadBarangMasuktable()

    End Sub

    Private Sub BTNTambah_Click(sender As Object, e As EventArgs) Handles BTNTambah.Click
        AddBarangMasuk.Show()
    End Sub

    Private Sub BTNEdit_Click(sender As Object, e As EventArgs) Handles BTNEdit.Click
        'if di bawah berfungsi untuk mengecek apakah user memilih salah satu kolom yang ada
        'di tabel atau tidak. jika tidak, maka akan muncul message box yang ada di statement ELSE 
        If GridBarangMasuk.SelectedRows.Count = 1 Then

            'Menyimpan data-data yang ada di dalam tabel ke dalam setter yang telah dibuat di class BarangMasuk
            'data yang disimpan merupakan item-item berdasarkan baris yang kita pilih (CurrentRow.Index)
            'bukan berdasarkan index cells
            '"ID" = nama kolom       `GridBarangMasuk.CurrentRow.Index = index yang dipilih      `Value = mengambil value dari column yang dipilih 
            barangMasuk.GSId = GridBarangMasuk.Item("ID", GridBarangMasuk.CurrentRow.Index).Value
            barangMasuk.GSNamaBarang = GridBarangMasuk.Item("NAMA BARANG", GridBarangMasuk.CurrentRow.Index).Value
            barangMasuk.GSQty = GridBarangMasuk.Item("QTY", GridBarangMasuk.CurrentRow.Index).Value
            barangMasuk.GSTanggalMasuk = GridBarangMasuk.Item("TANGGAL MASUK", GridBarangMasuk.CurrentRow.Index).Value

            EditBarangMasuk.Show()
        Else
            MessageBox.Show("Perlu memilih data yang ditampilkan di dalam tabel")
        End If
    End Sub

    Public Sub reloadBarangMasuktable()
        'Menginput data yang dihasilkan dari eksekusi query yang ada di dalam class
        'BarangMasuk.vb (method Index()) ke dalam datasource Data Grid
        GridBarangMasuk.DataSource = barangMasuk.ShowAllData()
    End Sub

    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        'sama kaya BTNEdit_Click
        If GridBarangMasuk.SelectedRows.Count = 1 Then
            barangMasuk.GSId = GridBarangMasuk.Item("ID", GridBarangMasuk.CurrentRow.Index).Value
            barangMasuk.GSNamaBarang = GridBarangMasuk.Item("NAMA BARANG", GridBarangMasuk.CurrentRow.Index).Value
            DeleteBarangMasuk.Show()
        Else
            MessageBox.Show("Perlu memilih data di dalam tabel")
        End If
    End Sub
End Class