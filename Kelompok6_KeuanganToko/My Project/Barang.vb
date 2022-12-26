Public Class Barang
    'Public Shared data_barang = New DataBarang
    Public Shared selectedDataBarang
    Public Shared selectedTableBarang
    Public Shared selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CenterToScreen()

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewBarang.Rows(index)

        selectedTableBarang = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub
End Class