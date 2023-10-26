Imports MySql.Data.MySqlClient

Module ConnectionModule
    Dim connString = "server=localhost; database=db_project_prodi; user=root; password=;"

    Public conn As New MySqlConnection(connString)

    Public dataAdapter As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dataTable As New DataTable
    Public dataReader As MySqlDataReader

    Public foundData As Boolean = False

    Public Sub connection()
        Try
            If Not conn Is Nothing Then conn.Close()
            conn.Open()
        Catch ex As Exception
            Dim res As DialogResult = MessageBox.Show(ex.Message, "Failed to connect server!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If res = 1 Then
                Application.Exit()
            End If
        End Try
    End Sub

    Function disconnection()
        conn.Close()
        Return conn
    End Function
End Module
