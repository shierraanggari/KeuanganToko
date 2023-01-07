Imports System.Text 'cek ini
Imports MySql.Data.MySqlClient

Public Class DataBarang
    Private nama_barang
    Private jenis_barang
    Private stok
    Private harga
    Private tanggal_masuk
    Private tanggal_kadaluarsa
    Public Shared buat_tes

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

    Public Property GSJenisBarang() As String
        Get
            Return jenis_barang
        End Get
        Set(value As String)
            jenis_barang = value
        End Set
    End Property

    Public Property GSStok() As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property

    Public Property GSHarga() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
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

    Public Function AddDataBarangDatabase(nama_barang As String,
                                          jenis_barang As String,
                                          stok As Integer,
                                          harga As Integer,
                                          tanggal_masuk As Date,
                                          tanggal_kadaluarsa As Date)

        dbConn.ConnectionString = "server = " + server + "; user id = " + username + "; password = " + password + "; database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO barang (nama_barang, id_jenis, stock, harga,
                        tanggal_masuk, tanggal_kadaluarsa) VALUE('" &
                        nama_barang & "', '" &
                        jenis_barang & "', '" &
                        stok & "', '" &
                        harga & "', '" &
                        tanggal_masuk.ToString("yyyy/MM/dd") & "', '" &
                        tanggal_kadaluarsa.ToString("yyyy/MM/dd") & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataBarangByIDDatabase(id_barang As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + "; user id = " + username +
            "; password = " + password + "; database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang,
                                  nama_barang, 
                                  id_jenis,
                                  stock, 
                                  harga, 
                                  tanggal_masuk, 
                                  tanggal_kadaluarsa
                                  FROM barang
                                  WHERE id_barang = '" & id_barang & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataBarangByIDDatabase(id_barang As Integer,
                                                 nama_barang As String,
                                                 jenis_barang As String,
                                                 stok As String,
                                                 harga As String,
                                                 tanggal_masuk As String,
                                                 tanggal_kadaluarsa As String)

        dbConn.ConnectionString = "server = " + server + "; user id = " + username +
            "; password = " + password + "; database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE barang SET " &
                       "nama_barang = '" & nama_barang & "', " &
                       "id_jenis = '" & jenis_barang & "', " &
                       "stock = '" & stok & "', " &
                       "harga = '" & harga & "', " &
                       "tanggal_masuk = '" & tanggal_masuk & "', " &
                       "tanggal_kadaluarsa = '" & tanggal_kadaluarsa & "' " &
                       "WHERE id_barang = '" & id_barang & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataBarangByIDDatabase(id_barang As Integer)
        dbConn.ConnectionString = "server = " + server + "; user id = " + username +
            "; password = " + password + "; database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM barang WHERE id_barang ='" & id_barang & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class