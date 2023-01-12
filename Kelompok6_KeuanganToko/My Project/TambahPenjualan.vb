Imports System.Data.Common

Public Class TambahPenjualan
    Public Shared penjualan As Penjualan
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CbIdBarang.DataSource = penjualan.getlistbarang()
        CbIdBarang.ValueMember = "id"
        CbIdBarang.DisplayMember = "nama_barang"
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If NumberQTY.Value > 0 Then

            Dim barangid = CbIdBarang.SelectedValue()
            Dim dateBarangMasuk = DTMTanggalJual.Value.ToString("yyyy-MM-dd")
            Dim qty = NumberQTY.Value.ToString()

            Dim isAdded = (barangid.ToString(), qty, dateBarangMasuk)

            If isAdded Then
                MessageBox.Show("List Barang Masuk Berhasil")
                Me.Close()
                penjualan.reloadBarangMasukTable()
            Else
                MessageBox.Show("data harus diisi!!")
            End If
        End If
    End Sub

    Private Sub TambahPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CbIdBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdBarang.SelectedIndexChanged

    End Sub
End Class