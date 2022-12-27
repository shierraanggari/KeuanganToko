Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class TambahBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CenterToParent()
        Barang.data_barang.GetDataForComboBox(ComboJenisBarang)

        DatePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        DatePickTanggalKadaluarsa.Format = DateTimePickerFormat.Custom
        DatePickTanggalKadaluarsa.CustomFormat = "yyyy/MM/dd"
    End Sub

    'Private Sub GetDataForComboBox()
    '    Barang.data_barang.dbConn.ConnectionString = "server = " + Barang.data_barang.server +
    '        "; user id = " + Barang.data_barang.username +
    '        "; password = " + Barang.data_barang.password +
    '        "; database = " + Barang.data_barang.database +
    '        "; Convert Zero Datetime = True"

    '    Barang.data_barang.dbConn.Open()
    '    Barang.data_barang.sqlCommand.Connection = Barang.data_barang.dbConn
    '    Barang.data_barang.sqlCommand.CommandText = "SELECT id_jenis, jenis FROM jenis_barang"
    '    Barang.data_barang.sqlRead = Barang.data_barang.sqlCommand.ExecuteReader

    '    While Barang.data_barang.sqlRead.Read
    '        ComboJenisBarang.Items.Add(Barang.data_barang.sqlRead(0) & ", " & Barang.data_barang.sqlRead(1))
    '        'ComboJenisBarang.DisplayMember = Barang.data_barang.sqlRead(1)
    '        ComboJenisBarang.ValueMember = Barang.data_barang.sqlRead(0)
    '    End While

    '    Barang.data_barang.sqlRead.Close()
    '    Barang.data_barang.dbConn.Close()
    'End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Barang.data_barang.GSNamaBarang = TxtNamaBarang.Text.ToString()
        Barang.data_barang.GSJenisBarang = ComboJenisBarang.SelectedValue().ToString()
        Barang.data_barang.GSStok = Integer.Parse(TxtStok.Text)
        Barang.data_barang.GSHarga = Integer.Parse(TxtHarga.Text)
        Barang.data_barang.GSTanggalMasuk = DatePickTanggalMasuk.Value.ToShortDateString()
        Barang.data_barang.GSTanggalKadaluarsa = DatePickTanggalKadaluarsa.Value.ToShortDateString()

        Barang.data_barang.AddDataBarangDatabase(
            Barang.data_barang.GSNamaBarang,
            Barang.data_barang.GSJenisBarang,
            Barang.data_barang.GSStok,
            Barang.data_barang.GSHarga,
            Barang.data_barang.GSTanggalMasuk,
            Barang.data_barang.GSTanggalKadaluarsa
        )
        Me.Close()
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan angka.")
        End If
    End Sub

    Private Sub TxtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Mohon hanya memasukkan angka.")
        End If
    End Sub
End Class