Public Class FrmBooks
    Private Sub FrmBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBooks.Show()
    End Sub
End Class