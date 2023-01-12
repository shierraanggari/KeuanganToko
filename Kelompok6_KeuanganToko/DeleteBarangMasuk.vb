Public Class DeleteBarangMasuk

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'mendefinisikan text label ID di dalam form menggunakan getter GSID
        LabID.Text = MainBarangMasuk.barangMasuk.GSId.ToString
        'mendefinisikan text label Nama Barang di dalam form menggunakan getter GSNamaBarang
        LabelNamaBarang.Text = MainBarangMasuk.barangMasuk.GSNamaBarang

    End Sub

    'fungsi BNYa_Click dijalankan saat user mengclick tombol
    Private Sub BTNYa_Click(sender As Object, e As EventArgs) Handles BTNYa.Click

        'memanggil fungsi DeleteBarangMasuk untuk menghapus data barang masuk ke dalam database
        'berdasarkan id yang telah dideklarasikan menggunakan setter tadi
        Dim isDeleted = MainBarangMasuk.barangMasuk.DeleteBarangMasuk(MainBarangMasuk.barangMasuk.GSId)

        'apabila fungsi DeleteBarangMasuk bernilai true, maka statement if akan dijalankan
        If isDeleted Then
            MainBarangMasuk.barangMasuk.UpdateDecreaseStockBarang(MainBarangMasuk.barangMasuk.GSQty, LabelNamaBarang.Text)
            MessageBox.Show("Data berhasil dihapus")
            Me.Close()
            MainBarangMasuk.reloadBarangMasuktable()
            Barang.ReloadDataTableDatabase()

            'jika bernilai false, maka statement else akan dijalankan
        Else
            MessageBox.Show("Terjadi Kesalahan")
        End If
    End Sub
End Class