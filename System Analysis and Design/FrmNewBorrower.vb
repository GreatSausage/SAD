Public Class FrmNewBorrower
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If String.IsNullOrEmpty(TxtContact.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtFirstName.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtGrade.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLastName.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLRN.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtSection.Text) Then
            EmptyTextbox()
            Exit Sub
        End If
        IinsertMoTo()
    End Sub
End Class