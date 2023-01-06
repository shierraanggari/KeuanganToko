Imports MySql.Data.MySqlClient

Public Class TambahBarang

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand

    Public Shared server As String = "localhost"
    Public Shared username As String = "root"
    Public Shared password As String = ""
    Public Shared database As String = "keuangan_toko"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CenterToParent()
        'Barang.data_barang.GetDataForComboBox(ComboJenisBarang)

        DatePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        DatePickTanggalKadaluarsa.Format = DateTimePickerFormat.Custom
        DatePickTanggalKadaluarsa.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub TambahBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn.ConnectionString = "server = " + server +
            "; user id = " + username +
            "; password = " + password +
            "; database = " + database

        Dim Result As New DataTable()

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT * FROM jenis_barang"

        Dim adapter As New MySqlDataAdapter(sqlCommand)

        adapter.Fill(Result)

        ComboJenisBarang.DataSource = Result
        ComboJenisBarang.DisplayMember = "jenis"
        ComboJenisBarang.ValueMember = "id_jenis"
    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Barang.data_barang.GSNamaBarang = TxtNamaBarang.Text.ToString
        Barang.data_barang.GSJenisBarang = ComboJenisBarang.SelectedValue().ToString
        Barang.data_barang.GSStok = Integer.Parse(TxtStok.Text)
        Barang.data_barang.GSHarga = Integer.Parse(TxtHarga.Text)
        Barang.data_barang.GSTanggalMasuk = DatePickTanggalMasuk.Value.ToShortDateString
        Barang.data_barang.GSTanggalKadaluarsa = DatePickTanggalKadaluarsa.Value.ToShortDateString

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