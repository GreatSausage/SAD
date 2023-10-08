Public Class FrmBooks
    Private Sub FrmBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooksAndCopies()
        Datagridview.Columns("BookID").Visible = False
    End Sub

    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBooks.Show()
    End Sub

    Private Sub Datagridview_DoubleClick(sender As Object, e As EventArgs) Handles Datagridview.DoubleClick
        If Datagridview.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = Datagridview.CurrentRow

            Dim bookID As Integer = Convert.ToInt32(selectedRow.Cells("BookID").Value)
            Dim isbn As String = selectedRow.Cells("ISBN").Value.ToString()
            Dim title As String = selectedRow.Cells("Title").Value.ToString()
            Dim datePublished As DateTime = Convert.ToDateTime(selectedRow.Cells("DatePublished").Value)
            Dim authors As String = selectedRow.Cells("Author").Value.ToString()
            Dim status As String = selectedRow.Cells("Status").Value.ToString()
            Dim dateAdded As DateTime = Convert.ToDateTime(selectedRow.Cells("AcquisitionDate").Value)

            Dim bookInfoForm As New FrmBookInfo(bookID, isbn, title, datePublished, authors, status, dateAdded)
            bookInfoForm.Show()
        End If
    End Sub
End Class