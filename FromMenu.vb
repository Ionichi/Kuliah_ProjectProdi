Public Class FromMenu
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
End Class
