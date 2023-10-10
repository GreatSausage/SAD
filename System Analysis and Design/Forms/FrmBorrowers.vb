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

            Dim lrn As Integer = Convert.ToInt32(selectedRow.Cells("lrn").Value)
            Dim firstname As String = selectedRow.Cells("firstName").Value.ToString
            Dim lastname As String = selectedRow.Cells("lastName").Value.ToString
            Dim grade As Integer = Convert.ToInt32(selectedRow.Cells("grade").Value)
            Dim section As String = selectedRow.Cells("section").Value.ToString
            Dim contact As Integer = Convert.ToInt32(selectedRow.Cells("contactGuardian").Value)

            Dim borrowerInfo As New FrmBorrowerInfo(lrn, firstname, lastname, grade, section, contact)
            borrowerInfo.Show()
        End If
    End Sub
End Class