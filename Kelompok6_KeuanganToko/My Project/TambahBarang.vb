Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class TambahBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.CenterToParent()
        GetDataForComboBox()

        DatePickTanggalMasuk.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasuk.CustomFormat = "yyyy/MM/dd"
        DatePickTanggalKadaluarsa.Format = DateTimePickerFormat.Custom
        DatePickTanggalKadaluarsa.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub GetDataForComboBox()
        Barang.data_barang.dbConn.ConnectionString = "server = " + Barang.data_barang.server +
            "; user id = " + Barang.data_barang.username +
            "; password = " + Barang.data_barang.password +
            "; database = " + Barang.data_barang.database +
            "; Convert Zero Datetime = True"

        Barang.data_barang.dbConn.Open()
        Barang.data_barang.sqlCommand.Connection = Barang.data_barang.dbConn
        Barang.data_barang.sqlCommand.CommandText = "SELECT id_jenis, jenis FROM jenis_barang"
        Barang.data_barang.sqlRead = Barang.data_barang.sqlCommand.ExecuteReader

        While Barang.data_barang.sqlRead.Read
            ComboJenisBarang.Items.Add(Barang.data_barang.sqlRead(0) & ", " & Barang.data_barang.sqlRead(1))
            ComboJenisBarang.ValueMember = Barang.data_barang.sqlRead(0)
        End While

        Barang.data_barang.sqlRead.Close()
        Barang.data_barang.dbConn.Close()
    End Sub
End Class