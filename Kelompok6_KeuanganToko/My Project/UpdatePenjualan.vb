Public Class UpdatePenjualan

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBNamaBarang.DataSource = Penjualan.penjualan.GetListBarang()
        CBNamaBarang.ValueMember = "id"
        CBNamaBarang.DisplayMember = "nama_barang"

        LblKode.Text = Penjualan.penjualan.GSId.ToString

        CBNamaBarang.SelectedIndex = CBNamaBarang.FindStringExact(Penjualan.penjualan.GSNamaBarang)
        DTMasuk.Value = Penjualan.penjualan.GSTanggalMasuk
        NumberQTY.Value = Penjualan.penjualan.GSQty
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If NumberQTY.Value > 0 Then
            Dim idbarangmasuk = Penjualan.penjualan.GSId
            Dim newNama = CBNamaBarang.SelectedValue
            Dim newDate = DTMasuk.Value.ToString("yyyy-MM-dd")
            Dim newQty = NumberQTY.Value

            Dim isUpdated = Penjualan.tambahPenjualan(idbarangmasuk.ToString, newNama.ToString, newQty.ToString, newDate)

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

    Private Sub UpdatePenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class