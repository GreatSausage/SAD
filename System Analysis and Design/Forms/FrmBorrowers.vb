Public Class FrmBorrowers
    Private Sub BtnNewBorrower_Click(sender As Object, e As EventArgs) Handles BtnNewBorrower.Click
        FrmNewBorrower.Show()
    End Sub

    Private Sub FrmBorrowers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As DataTable = DisplayData("tblBorrowers")
        Datagridview.DataSource = table
    End Sub

    Private Sub Datagridview_DoubleClick(sender As Object, e As EventArgs) Handles Datagridview.DoubleClick
        If Datagridview.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = Datagridview.CurrentRow
            Dim borrowerID As Integer = Convert.ToInt32(selectedRow.Cells("BorrowerID").Value)
            Dim lrn As String = selectedRow.Cells("LRN").Value.ToString
            Dim firstname As String = selectedRow.Cells("Firstname").Value.ToString
            Dim lastname As String = selectedRow.Cells("Lastname").Value.ToString
            Dim grade As Integer = selectedRow.Cells("Grade").Value.ToString
            Dim section As String = selectedRow.Cells("Section").Value.ToString
            Dim contact As String = selectedRow.Cells("GuardianContact").Value.ToString
            Dim borrowerInfo As New FrmBorrowerInfo(borrowerID, lrn, firstname, lastname, grade, section, contact)
            borrowerInfo.Show()
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        SearchBorrowers(Datagridview, TxtSearch.Text)
    End Sub

End Class