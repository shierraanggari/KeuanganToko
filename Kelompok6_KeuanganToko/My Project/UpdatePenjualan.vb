Public Class UpdatePenjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBNamaBarang.DataSource = Penjualan.barangMasuk.GetListBarang()
        CBNamaBarang.ValueMember = "id"
        CBNamaBarang.DisplayMember = "nama_barang"

        LblKode.Text = Penjualan.barangMasuk.GSId.ToString

        CBNamaBarang.SelectedIndex = CBNamaBarang.FindStringExact(Penjualan.barangMasuk.GSNamaBarang)
        DTMasuk.Value = Penjualan.barangMasuk.GSTanggalMasuk
        NumberQTY.Value = Penjualan.barangMasuk.GSQty
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If NumberQTY.Value > 0 Then
            Dim idbarangmasuk = Penjualan.barangMasuk.GSId
            Dim newNama = CBNamaBarang.SelectedValue
            Dim newDate = DTMasuk.Value.ToString("yyyy-MM-dd")
            Dim newQty = NumberQTY.Value

            Dim isUpdated = Penjualan.barangMasuk.UpdateBarangMasuk(idbarangmasuk.Tostring, newNama.ToString, newQty.ToString, newDate)

            If isUpdated Then
                Penjualan.reloadBarangMasukTable()

                MessageBox.Show("kode barang masuk " + idbarangmasuk.Tostring + "berhasil diperbarui !")
                Me.Close()

            Else
                MessageBox.Show("gagal memperbarui data")
            End If
        Else
        End If
    End Sub


End Class