Public Class FrmBorrowerList


    Private Sub Datagridview_DoubleClick(sender As Object, e As EventArgs) Handles Datagridview.DoubleClick
        If Datagridview.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = Datagridview.CurrentRow
            Dim lrn As String = selectedRow.Cells("LRN").Value.ToString
            Dim firstname As String = selectedRow.Cells("Firstname").Value.ToString
            Dim lastname As String = selectedRow.Cells("Lastname").Value.ToString
            Dim borrowers As New FrmBorrow(lrn, firstname, lastname)
            Me.Close()
            borrowers.Show()
        End If
    End Sub

    Private Sub BorrowerList_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As DataTable = DisplayData("tblBorrowers")
        Datagridview.DataSource = table
    End Sub

    Private Sub FacultyDatagridview_DoubleClick(sender As Object, e As EventArgs) Handles FacultyDatagridview.DoubleClick
        If Datagridview.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = FacultyDatagridview.CurrentRow
            Dim firstname As String = selectedRow.Cells("Firstname").Value.ToString
            Dim lastname As String = selectedRow.Cells("Lastname").Value.ToString
            Dim borrowers As New FrmBorrow("", firstname, lastname)
            Me.Close()
            borrowers.Show()
        End If
    End Sub

End Class