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
            'MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed connect to server!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function disconnection()
        conn.Close()
        Return conn
    End Function
End Module
