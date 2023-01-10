Public Class EditBarangMasuk

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'me-load item-item combobox yang asalnya dari eksekusi query di class BarangMasuk,
        'method GetListBarang()
        CBNamaBarang.DataSource = MainBarangMasuk.barangMasuk.GetListBarang()
        CBNamaBarang.ValueMember = "id"
        CBNamaBarang.DisplayMember = "nama_barang"

        'mendefinisikan text label Kode di dalam form menggunakan getter GSID
        LblKode.Text = MainBarangMasuk.barangMasuk.GSId.ToString

        CBNamaBarang.SelectedIndex = CBNamaBarang.FindStringExact(MainBarangMasuk.barangMasuk.GSNamaBarang)
        DTMasuk.Value = MainBarangMasuk.barangMasuk.GSTanggalMasuk
        NumberQTY.Value = MainBarangMasuk.barangMasuk.GSQty
    End Sub

    Private Sub BTNEdit_Click(sender As Object, e As EventArgs) Handles BTNEdit.Click
        If NumberQTY.Value > 0 Then
            Dim idBarangMasuk = MainBarangMasuk.barangMasuk.GSId
            Dim newNama = CBNamaBarang.SelectedValue
            Dim newDate = DTMasuk.Value.ToString("yyyy-MM-dd")
            Dim newQty = NumberQTY.Value

            Dim isUpdated = MainBarangMasuk.barangMasuk.UpdateBarangMasuk(idBarangMasuk.ToString, newNama.ToString, newQty.ToString, newDate)

            If isUpdated Then

                MainBarangMasuk.reloadBarangMasuktable()

                MessageBox.Show("Kode barang masuk " + idBarangMasuk.ToString + " berhasil diperbarui !")
                Me.Close()

            Else
                MessageBox.Show("Gagal memperbarui data")
            End If
        Else
            MessageBox.Show("Data form perlu diisi")
        End If
    End Sub

    Private Sub EditBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class