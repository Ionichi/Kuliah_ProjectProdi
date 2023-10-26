Public Class FormMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnShowFormMahasiswa_Click(sender As Object, e As EventArgs) Handles btnShowFormMahasiswa.Click
        Dim frmMhs As Form
        frmMhs = New FormMahasiswa()
        frmMhs.ShowDialog()
    End Sub

    Private Sub btnShowFormDosen_Click(sender As Object, e As EventArgs) Handles btnShowFormDosen.Click
        Dim frmDosen As Form
        frmDosen = New FormDosen()
        frmDosen.ShowDialog()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        copyRight.Text = "Powered by " & My.Application.Info.CompanyName
        machineName.Text = Environment.MachineName

        Try
            ConnectionModule.connection()
            ConnectionModule.disconnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
