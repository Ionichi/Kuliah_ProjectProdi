Imports MySql.Data.MySqlClient
Public Class FormMahasiswa

    Private _SIMPAN As Boolean = True
    Private NIM_TEMP As String = ""
    Private Sub showData(filter)
        ConnectionModule.connection()

        dataAdapter = New MySqlDataAdapter($"SELECT * FROM tbmahasiswa WHERE (nim LIKE '%{filter(1)}%' OR nama LIKE '%{filter(1)}%' OR no_telp LIKE '%{filter(1)}%' OR email LIKE '%{filter(1)}%' OR jenis_kelamin LIKE '%{filter(1)}%' OR alamat LIKE '%{filter(1)}%') AND jenis_kelamin LIKE '%{filter(0)}%'", conn)
        dataTable = New DataTable
        dataAdapter.Fill(dataTable)
        DataGridViewMahasiswa.Rows.Clear()

        For i = 0 To dataTable.Rows.Count - 1
            DataGridViewMahasiswa.Rows.Add(dataTable.Rows(i).Item(1)) 'nim
            DataGridViewMahasiswa.Rows(i).Cells(1).Value = dataTable.Rows(i).Item(2) 'nama
            DataGridViewMahasiswa.Rows(i).Cells(2).Value = dataTable.Rows(i).Item(3) 'no_telp
            DataGridViewMahasiswa.Rows(i).Cells(3).Value = dataTable.Rows(i).Item(4) 'email
            DataGridViewMahasiswa.Rows(i).Cells(4).Value = dataTable.Rows(i).Item(5) 'jenis_kelamin
            DataGridViewMahasiswa.Rows(i).Cells(5).Value = dataTable.Rows(i).Item(6) 'alamat
        Next

        ConnectionModule.disconnection()
    End Sub

    Private Sub processFilterForShowData()
        Dim keyGender As String = Replace(filterGender.Text, "?", "%")
        Dim keySearch As String = Replace(searchBox.Text, "?", "%")
        Dim filter() As String = {keyGender, keySearch} '0 = gender 1 = keyword
        showData(filter)
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        txtNIM.Clear()
        txtNama.Clear()
        txtTelp.Clear()
        txtEmail.Clear()
        txtAlamat.Clear()
        radioLaki.Checked = True

        Me._SIMPAN = True
        Me.NIM_TEMP = ""
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtNIM.Select()

        processFilterForShowData()
    End Sub

    Private Function validation()
        If txtNIM.Text.Length <= 0 Then
            MessageBox.Show("[NIM] belum diisi!")
            Return False
        ElseIf txtNIM.Text.Length > 9 Then
            MessageBox.Show("[NIM] Maximal karakter 9!")
            Return False
        ElseIf txtNama.Text.Length <= 0 Then
            MessageBox.Show("[Nama Lengkap] belum diisi!")
            Return False
        ElseIf txtTelp.Text.Length <= 0 Then
            MessageBox.Show("[No. Telepon] belum diisi!")
            Return False
        ElseIf txtTelp.Text.Length > 15 Then
            MessageBox.Show("[No. Telepon] Maximal karakter 15!")
            Return False
        ElseIf txtEmail.Text.Length <= 0 Then
            MessageBox.Show("[Email] belum diisi!")
            Return False
        ElseIf txtAlamat.Text.Length <= 0 Then
            MessageBox.Show("[Alamat] belum diisi!")
            Return False
        Else
            Return True
        End If

    End Function


    Private Sub insertUpdate(sql As String, todo As String, sender As Object, e As EventArgs)
        Dim nim, nama, no_telp, email, jenis_kelamin, alamat As String
        Try
            ConnectionModule.connection()

            If _SIMPAN = True Then
                nim = txtNIM.Text.ToString()
            Else
                nim = Me.NIM_TEMP
            End If

            nama = txtNama.Text.ToString()
            no_telp = txtTelp.Text.ToString()
            email = txtEmail.Text.ToString()
            alamat = txtAlamat.Text.ToString()

            If radioLaki.Checked = True Then
                jenis_kelamin = "Laki-laki"
            ElseIf radioPerempuan.Checked = True Then
                jenis_kelamin = "Perempuan"
            Else
                jenis_kelamin = "Lainnya"
            End If


            cmd = New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@nim", nim)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@no_telp", no_telp)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            If _SIMPAN = True Then
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss"))
            End If
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Mahasiswa " & nim & " Berhasil " & todo, "Data mahasiswa berhasil " & todo, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ConnectionModule.disconnection()

            btnUndo_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Gagal Menyimpan data Mahasiswa!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DataGridViewMahasiswa_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridViewMahasiswa.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIndex As String = (e.RowIndex + 1).ToString()

        Dim centerFormat As New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIndex, grid.DefaultCellStyle.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub


    Private Sub DataGridViewMahasiswa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMahasiswa.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewMahasiswa.Rows.Count Then
            Me.NIM_TEMP = DataGridViewMahasiswa.Rows(e.RowIndex).Cells("NIM").Value().ToString()

            Try
                ConnectionModule.connection()

                Dim sql As String

                sql = "SELECT * FROM tbmahasiswa where nim=@nim"

                cmd = New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@nim", Me.NIM_TEMP)

                dataReader = cmd.ExecuteReader()

                If dataReader.Read() Then
                    txtNIM.Text = dataReader.GetString(1)
                    txtNama.Text = dataReader.GetString(2)
                    txtTelp.Text = dataReader.GetString(3)
                    txtEmail.Text = dataReader.GetString(4)
                    If dataReader.GetString(5) = "Laki-laki" Then
                        radioLaki.Checked = True
                    ElseIf dataReader.GetString(5) = "Perempuan" Then
                        radioPerempuan.Checked = True
                    Else
                        radioLainnya.Checked = True
                    End If

                    txtAlamat.Text = dataReader.GetString(6)

                    Me._SIMPAN = False
                    btnUpdate.Enabled = True

                Else
                    MessageBox.Show("Data " & Me.NIM_TEMP & " tidak ditermukan!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ConnectionModule.disconnection()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Gagal Mendapatkan Data Mahasiswa!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DataGridViewMahasiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMahasiswa.CellClick
        Me.NIM_TEMP = DataGridViewMahasiswa.Rows(e.RowIndex).Cells("NIM").Value().ToString()
        btnDelete.Enabled = True
    End Sub

    Private Sub btnAddUpdate_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnUpdate.Click
        If validation() = True Then
            Dim sql, todo As String

            If Me._SIMPAN = True Then
                sql = "INSERT INTO tbmahasiswa (nim, nama, no_telp, email, jenis_kelamin, alamat, created_at, updated_at) VALUES(@nim, @nama, @no_telp, @email, @jenis_kelamin, @alamat, @created_at, @updated_at)"
                todo = "disimpan!"
            Else
                sql = "UPDATE tbmahasiswa set nama=@nama, no_telp=@no_telp, email=@email, jenis_kelamin=@jenis_kelamin, alamat=@alamat, updated_at=@updated_at where nim=@nim"
                todo = "diupdate!"
            End If
            insertUpdate(sql, todo, sender, e)
        Else
            txtNIM.Select()
            txtNIM.SelectAll()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Me.NIM_TEMP = "" Then
            MessageBox.Show("Mohon pilih data yang ingin dihapus terlebih dahulu!")
        Else
            Dim res As DialogResult = MessageBox.Show("Yakin ingin menghapus data dengan nim " & Me.NIM_TEMP & "?", "Konfirmasi hapus data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = 6 Then
                Try
                    ConnectionModule.connection()

                    Dim sql As String

                    sql = "DELETE FROM tbmahasiswa where nim=@nim"

                    cmd = New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@nim", Me.NIM_TEMP)

                    cmd.ExecuteNonQuery()

                    ConnectionModule.disconnection()

                    btnUndo_Click(sender, e)
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Gagal Menghapus Data Mahasiswa!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUndo_Click(sender, e)
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        processFilterForShowData()
    End Sub

    Private Sub filterGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterGender.SelectedIndexChanged
        processFilterForShowData()
    End Sub
End Class