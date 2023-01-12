
Imports MySql.Data.MySqlClient
Public Class Penjualan
    'variabel2 yang dibutuhkan untuk mengoneksikan aplikasi dengan database
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared errMessage As String

    Private sqlQuery As String

    'Kredensial yang digunakan untuk connect ke database
    Private ReadOnly server As String = "localhost"
    Private ReadOnly usernameDB As String = "root"
    Private ReadOnly passwordDB As String = ""
    Private ReadOnly database As String = "keuangan_toko"

    Private id As Integer
    Private namaBarang As String
    Private tanggalMasuk As Date
    Private qty As Integer

    Public Property GSId() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property GSNamaBarang() As String
        Get
            Return namaBarang
        End Get
        Set(value As String)
            namaBarang = value
        End Set
    End Property

    Public Property GSTanggalMasuk() As Date
        Get
            Return tanggalMasuk
        End Get
        Set(value As Date)
            tanggalMasuk = value
        End Set
    End Property

    Public Property GSQty() As Integer
        Get
            Return qty
        End Get
        Set(value As Integer)
            qty = value
        End Set
    End Property

    'fungsi method ConnectionString adalah untuk menghindari repetisi dalam menulis kode
    Public Function ConnectionString()
        Return "server =" + server + ";" + "user id=" + usernameDB + ";" + "password =" + passwordDB + ";" + "database =" + database
    End Function

    Public Function ShowAllData()
        Try
            'Membuat variabel result dengan tipe data DataTable
            Dim result As New DataTable

            'dbConn.ConnectionString adalah perintah string yang berisi kredensial yang digunakan untuk connect
            'ke database sebelum membuka database connection menggunakan dbConn.Open()
            dbConn.ConnectionString = ConnectionString()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            'sqlquery = string yang berisi perintah-perintah query
            sqlQuery = "SELECT
                                BM.ID_BARANG_MASUK AS ID,
                                BR.NAMA_BARANG AS 'NAMA BARANG',
                                BM.JUMLAH_BARANG_MASUK AS QTY,
                                BM.TANGGAL_BARANG_MASUK AS 'TANGGAL MASUK'
                             FROM BARANG_MASUK AS BM
                             JOIN BARANG AS BR ON BR.ID_BARANG = BM.ID_BARANG"
            'perintah query di atas akan disimpan di dalam properti sqlCommand.CommandText
            sqlCommand.CommandText = sqlQuery
            'query yang telah disimpan di CommandText akan dieksekusi menggunakan method ExecuteReader
            'dan hasil eksekusi akan di-store di dalam variable sqlRead seperti di bawah. 
            sqlRead = sqlCommand.ExecuteReader

            'data hasil eksekusi di dalam sqlRead kemudian di-store ke dalam variable result
            'yang telah didibuat sebelumnya
            result.Load(sqlRead)

            'menutup koneksi database
            dbConn.Close()

            'mengembalikan data result yang telah terisi oleh data yang dihasilkan dari proses eksekusi
            Return result
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function AddPenjualan(barangId As String, quantity As String, dateBarang As String)

        Try
            dbConn.ConnectionString = ConnectionString()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO 
                            barang_masuk(id_barang, jumlah_barang_masuk, tanggal_barang_masuk)
                        VALUE ('" & barangId & "', '" & quantity & "', '" & dateBarang & "')"
            sqlCommand.CommandText = sqlQuery
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()

            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function tambahPenjualan(barangMasukID As String, barangId As String, quantity As String, dateBarang As String)
        Try
            dbConn.ConnectionString = ConnectionString()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE barang_masuk
                        SET id_barang = " & barangId & "
                        ,jumlah_barang_masuk = " & quantity & "
                        ,tanggal_barang_masuk = '" & dateBarang & "'
                        WHERE id_barang_masuk = " & barangMasukID & ""

            sqlCommand.CommandText = sqlQuery
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()

            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetListBarang()
        Try

            Dim result As New DataTable

            dbConn.ConnectionString = ConnectionString()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "SELECT id_barang AS id,nama_barang FROM barang"

            sqlCommand.CommandText = sqlQuery
            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            dbConn.Close()

            Return result

        Catch ex As Exception

            Debug.WriteLine(ex.Message)

        Finally
            dbConn.Dispose()

        End Try
    End Function

    Public Function DeletePenjualan(barangMasukId As String)
        Try


            dbConn.ConnectionString = ConnectionString()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE FROM barang_masuk WHERE id_barang_masuk =" + barangMasukId

            sqlCommand.CommandText = sqlQuery
            sqlRead = sqlCommand.ExecuteReader


            dbConn.Close()

            Return True

        Catch ex As Exception

            Debug.WriteLine(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class
