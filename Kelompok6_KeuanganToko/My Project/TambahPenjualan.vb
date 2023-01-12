Imports System.Data.Common

Public Class TambahPenjualan
    Public Shared ID_barang
    Public Shared jumlah_barang
    Public Shared tanggal_barang

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBIDbarang.DataSource = barangmasuk.GetListBarang()
        CBIDbarang.ValueMember = "id"
        CBIDbarang.DisplayMember = "nama_barang"
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If NumberQTY.Value > 0 Then

            Dim barangid = CBIDbarang.SelectedValue()
            Dim dateBarangMasuk = DTMasuk.value.ToString("yyyy-MM-dd")
            Dim qty = NumberQTY.Value.ToString()

            Dim isAdded = tanggal_barang.AddBarangMasuk(barangid.ToString(), qty, dateBarangMasuk)

            If isAdded Then
                MessageBox.Show("List Barang Masuk Berhasil")
                Me.Close()
                Penjualan.reloadBarangMasukTable()
            Else
                MessageBox.Show("data harus diisi!!")
            End If
        End If
    End Sub

    Private Sub TambahPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class