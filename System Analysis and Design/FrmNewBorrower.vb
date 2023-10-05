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
        InsertBorrowers()
    End Sub

    Private Sub InputKeydown(sender As Object, e As EventArgs) Handles TxtContact.KeyDown, TxtFirstName.KeyDown, TxtGrade.KeyDown, TxtLastName.KeyDown, TxtLRN.KeyDown, TxtSection.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub
    Private Sub InputKeypress(sender As Object, e As KeyPressEventArgs) Handles TxtFirstName.KeyPress, TxtLastName.KeyPress, TxtSection.KeyPress
        AntiSymbolsandNumberInput(sender, e)
    End Sub

    Private Sub ContactLimit(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress
        If TxtContact.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumberInputs(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress, TxtGrade.KeyPress, TxtLRN.KeyPress
        NumberOnly(sender, e)
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class