Public Class FrmBooks
    Private Sub FrmBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As DataTable = DisplayDataBooks("tblBooksList")
        Datagridview.DataSource = table
    End Sub
End Class