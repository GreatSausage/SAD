Public Class FrmBorrowers
    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBorrower.Show()
    End Sub

    Private Sub FrmBorrowers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As DataTable = DisplayData("tblBorrowers")
        Datagridview.DataSource = table
    End Sub
End Class