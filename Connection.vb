Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Connection
    Private conn As MySqlConnection
    Public Function Connection() As MySqlConnection
        Dim connString As String
        connString = ";server=localhost" & ";user=root" & ";password=''" & ";database=database-prodi"
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error" + ex.Message)
        End Try
        Return conn
    End Function
End Class
