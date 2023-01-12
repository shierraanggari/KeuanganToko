Public Class AddBarangMasuk
    Public Shared barangMasuk As New BarangMasuk

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'me-load item-item combobox yang asalnya dari eksekusi query di class BarangMasuk,
        'method GetListBarang()
        CBNamaBarang.DataSource = barangMasuk.GetListBarang()
        'ValueMember berguna untuk memberikan value tiap itemnya berupa id barang dari database
        CBNamaBarang.ValueMember = "id"
        'item-item yang ditampilkan di combobox adalah data-data "nama_barang" dari database
        CBNamaBarang.DisplayMember = "nama_barang"

    End Sub

    Private Sub BTNTambah_Click(sender As Object, e As EventArgs) Handles BTNTambah.Click

        If NumberQTY.Value > 0 Then

            'menyimpan item combobox yang dipilih ke variable barangId
            Dim barangId = CBNamaBarang.SelectedValue()
            'menyimpan tanggal yang dipilih dengan DateTimePicker ke variable dateBarangMasuk
            Dim dateBarangMasuk = DTMasuk.Value.ToString("yyyy-MM-dd")
            'menyimpan jumlah barang ke variable qty
            Dim qty = NumberQTY.Value.ToString()

            'memanggil fungsi AddBarangMasuk untuk menyimpan barang masuk ke dalam database
            Dim isAdded = barangMasuk.AddBarangMasuk(barangId.ToString(), qty, dateBarangMasuk)

            'apabila fungsi AddBarangMasuk bernilai true, maka statement if akan dijalankan
            If isAdded Then
                MessageBox.Show("List Barang Masuk Berhasil dibuat !")
                Me.Close()
                MainBarangMasuk.reloadBarangMasuktable()

                'jika bernilai false, maka statement else akan dijalankan
            Else
                MessageBox.Show("Gagal !!!")
            End If
        Else
            MessageBox.Show("Data form perlu diisi")
        End If

    End Sub

    Private Sub AddBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class