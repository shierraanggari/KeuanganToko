Imports MySql.Data.MySqlClient

Public Class UpdateBarang

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
        Me.CenterToScreen()
        NamaToolStripMenuItem.Text = Login.data_user.GSUsername

        DatePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        DatePickTanggalKadaluarsa.Format = DateTimePickerFormat.Custom
        DatePickTanggalKadaluarsa.CustomFormat = "yyyy/MM/dd"

        TxtNamaBarang.Text = Barang.data_barang.GSNamaBarang
        TxtStok.Text = Barang.data_barang.GSStok
        TxtHarga.Text = Barang.data_barang.GSHarga
        DatePickTanggalMasuk.Text = Barang.data_barang.GSTanggalMasuk
        DatePickTanggalKadaluarsa.Text = Barang.data_barang.GSTanggalKadaluarsa
    End Sub

    Private Sub UpdateBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ComboJenisBarang.SelectedValue = Barang.data_barang.GSJenisBarang

        dbConn.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Barang.data_barang.GSNamaBarang = TxtNamaBarang.Text.ToString
        Barang.data_barang.GSJenisBarang = ComboJenisBarang.SelectedValue().ToString
        Barang.data_barang.GSStok = Integer.Parse(TxtStok.Text)
        Barang.data_barang.GSHarga = Integer.Parse(TxtHarga.Text)
        Barang.data_barang.GSTanggalMasuk = DatePickTanggalMasuk.Value.ToString("yyyy/MM/dd")
        Barang.data_barang.GSTanggalKadaluarsa = DatePickTanggalKadaluarsa.Value.ToString("yyyy/MM/dd")

        Barang.data_barang.UpdateDataBarangByIDDatabase(Barang.selectedTableBarang,
                                                        Barang.data_barang.GSNamaBarang,
                                                        Barang.data_barang.GSJenisBarang,
                                                        Barang.data_barang.GSStok,
                                                        Barang.data_barang.GSHarga,
                                                        Barang.data_barang.GSTanggalMasuk,
                                                        Barang.data_barang.GSTanggalKadaluarsa)

        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class