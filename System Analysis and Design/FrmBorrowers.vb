Public Class FrmBorrowers
    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBorrower.Show()
    End Sub

    Private Sub FrmBorrowers_Load(sender As Object, e As EventArgs) Handles Me.Load
        IdisplayMoTo(Datagridview, "tblBorrowers")
    End Sub
End Class