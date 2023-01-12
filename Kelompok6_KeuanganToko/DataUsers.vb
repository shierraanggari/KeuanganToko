Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class DataUsers
    Private username As String
    Private email As String
    Private password As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private TripleDes As New TripleDESCryptoServiceProvider

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "keuangan_toko"

    Public Property GSUsername As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSEmail As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property GSPassword As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Function AddUsersDatabase(uname_regist As String,
                              email_regist As String,
                              password_regist As String)
        Try
            dbConn.ConnectionString = "server = " + server + "; user id = " + username_db + "; password = " + password_db +
                "; database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO users (username, email, password) VALUE ('" &
                uname_regist & "', '" &
                email_regist & "', '" &
                EncryptMD5(password_regist) & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            dbConn.Dispose()
        End Try
    End Function

    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream

        Dim encStream As New CryptoStream(ms,
                                        TripleDes.CreateEncryptor(),
                                        System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)

        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()

        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next

        Return s.ToString()
    End Function

    Public Function CheckAuthDatabase(uname_email_login As String,
                                      password_login As String,
                                      login_email As Boolean)
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server = " + server + "; user id = " + username_db + "; password = " + password_db +
                "; database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = ""

            If login_email = True Then
                queryAuth = "SELECT id_users, username FROM users " &
                            "WHERE email = '" & uname_email_login &
                            "' AND password = '" & EncryptMD5(password_login) & "'"
            Else
                queryAuth = "SELECT id_users, username FROM users " &
                            "WHERE username = '" & uname_email_login &
                            "' AND password = '" & EncryptMD5(password_login) & "'"
            End If

            sqlCommand.CommandText = queryAuth
                Debug.WriteLine(queryAuth)
                sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                    While sqlRead.Read
                        result.Add(sqlRead.GetString(0).ToString())
                        result.Add(sqlRead.GetString(1).ToString())
                    End While
                End If

                sqlRead.Close()
                dbConn.Close()
                Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
