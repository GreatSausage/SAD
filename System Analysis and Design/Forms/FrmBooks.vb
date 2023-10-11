Public Class FrmBooks
    Private Sub FrmBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUniqueBooks()
        LoadBookCopies()
        Datagridview.Columns("InstanceID").Visible = False
        UniqueDatagrid.Columns("BookID").Visible = False
    End Sub

    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBooks.Show()
    End Sub

    Private Sub Datagridview_DoubleClick_1(sender As Object, e As EventArgs) Handles Datagridview.DoubleClick
        If Datagridview.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = Datagridview.CurrentRow
            Dim instanceID As Integer = Convert.ToInt32(selectedRow.Cells("InstanceID").Value)
            Dim isbn As String = selectedRow.Cells("ISBN").Value.ToString
            Dim title As String = selectedRow.Cells("Title").Value.ToString
            Dim datePublished As DateTime = Convert.ToDateTime(selectedRow.Cells("DatePublished").Value)
            Dim authors As String = selectedRow.Cells("Author").Value.ToString
            Dim status As String = selectedRow.Cells("Status").Value.ToString
            Dim dateAdded As DateTime = Convert.ToDateTime(selectedRow.Cells("AcquisitionDate").Value)
            Dim bookInfoForm As New FrmBookInfo(InstanceID, isbn, title, datePublished, authors, status, dateAdded)
            bookInfoForm.Show()
        End If
    End Sub

    Private Sub UniqueDatagrid_DoubleClick(sender As Object, e As EventArgs) Handles UniqueDatagrid.DoubleClick
        If UniqueDatagrid.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = UniqueDatagrid.CurrentRow
            Dim bookID As Integer = Convert.ToInt32(selectedRow.Cells("BookID").Value)
            Dim isbn As String = selectedRow.Cells("UniqueISBN").Value.ToString
            Dim title As String = selectedRow.Cells("UniqueTitle").Value.ToString
            Dim author As String = selectedRow.Cells("UniqueAuthor").Value.ToString
            Dim datePublished As DateTime = Convert.ToDateTime(selectedRow.Cells("UniqueDatePublished").Value)
            Dim availableCopies As Integer = Convert.ToInt32(selectedRow.Cells("UniqueAvailableCopies").Value)
            Dim totalCopies As Integer = Convert.ToInt32(selectedRow.Cells("UniqueTotalCopies").Value)
            Dim bookInfo As New UniqueBookInfo(bookID, isbn, title, author, datePublished, availableCopies, totalCopies)
            bookInfo.Show()
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchBooks(UniqueDatagrid, TxtSearch.Text)
        SearchBooks(Datagridview, TxtSearch.Text)
    End Sub
End Class