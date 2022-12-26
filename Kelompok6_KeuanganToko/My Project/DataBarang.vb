Imports System.Text 'cek ini
Imports MySql.Data.MySqlClient

Public Class DataBarang
    Private nama_barang As String
    Private stok As String
    Private harga As String
    Private tanggal_masuk As String
    Private tanggal_kadaluarsa As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Public Shared server As String = "localhost"
    Public Shared username As String = "root"
    Public Shared password As String = ""
    Public Shared database As String = "keuangan_toko"

    Public Property GSNamaBarang() As String
        Get
            Return nama_barang
        End Get
        Set(value As String)
            nama_barang = value
        End Set
    End Property

    Public Property GSStok() As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property

    Public Property GSHarga() As String
        Get
            Return harga
        End Get
        Set(value As String)
            harga = value
        End Set
    End Property

    Public Property GSTanggalMasuk() As String
        Get
            Return tanggal_masuk
        End Get
        Set(value As String)
            tanggal_masuk = value
        End Set
    End Property

    Public Property GSTanggalKadaluarsa() As String
        Get
            Return tanggal_kadaluarsa
        End Get
        Set(value As String)
            tanggal_kadaluarsa = value
        End Set
    End Property

    Public Function GetDataBarangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + "; user id = " + username + "; password = " + password + "; database = " + database + "; Convert Zero Datetime = True"
        dbConn.Open()
        sqlCommand.Connection = dbConn
        'sqlCommand.CommandText = "SELECT id_barang AS 'ID Barang',
        '                          id_jenis AS 'ID Jenis',
        '                          nama_barang AS 'Nama Barang',
        '                          stock AS 'Stok' FROM barang;
        '                          SELECT
        '                          harga AS 'Harga',
        '                          tanggal_masuk AS 'Tanggal Masuk',
        '                          tanggal_kadaluarsa AS 'Tanggal Kadaluarsa'
        '                          FROM barang;"

        sqlCommand.CommandText = "SELECT id_barang AS 'ID Barang',
                                  nama_barang AS 'Nama Barang',
                                  jenis AS 'Jenis Barang',
                                  stock AS 'Stok',
                                  harga AS 'Harga',
                                  tanggal_masuk AS 'Tanggal Masuk',
                                  tanggal_kadaluarsa AS 'Tanggal Kadaluarsa'
                                  FROM barang
                                  INNER JOIN jenis_barang
                                  ON barang.id_jenis = jenis_barang.id_jenis"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    'Public Function GetDataForComboBox() As List(Of String)
    '    Dim result As New List(Of String)

    '    dbConn.ConnectionString = "server = " + server + "; user id = " + username + "; password = " + password + "; database = " + database + "; Convert Zero Datetime = True"
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "SELECT id_jenis + ', ' + jenis FROM jenis_barang"

    '    sqlRead = sqlCommand.ExecuteReader

    '    result.Add(sqlRead)
    '    sqlRead.Close()
    '    dbConn.Close()
    '    Return result
    'End Function
End Class
