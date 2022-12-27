Public Class HapusBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToParent()
        LblNamaBarang.Text = Barang.selectedTableBarangNama
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Barang.data_barang.DeleteDataBarangByIDDatabase(Barang.selectedTableBarang)
        Me.Close()
    End Sub

    'Private Sub LblNamaBarang_TextChanged(sender As Object, e As EventArgs) Handles LblNamaBarang.TextChanged
    '    Dim dataselected As List(Of String) = Barang.data_barang.GetDataBarangByIDDatabase(Barang.selectedTableBarang)
    '    LblNamaBarang.Text = dataselected(2)
    'End Sub
End Class