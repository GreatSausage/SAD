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
        ElseIf LRNExists(TxtLRN.text) Then
            MessageBox.Show("The LRN already exists, please provide a unique LRN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            InsertBorrowers()
        End If
    End Sub

    Private Sub AntiCopyPaste(sender As Object, e As KeyEventArgs) Handles TxtFirstName.KeyDown, TxtGrade.KeyDown, TxtContact.KeyDown, TxtLastName.KeyDown, TxtLRN.KeyDown, TxtSection.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub

    Private Sub NumbersOnly(sender As Object, e As KeyPressEventArgs) Handles TxtLRN.KeyPress, TxtGrade.KeyPress, TxtSection.KeyPress, TxtContact.KeyPress
        NumberOnly(sender, e)
    End Sub

    Private Sub LettersOnly(sender As Object, e As KeyPressEventArgs) Handles TxtFirstName.KeyPress, TxtLastName.KeyPress
        LetterOnly(sender, e)
    End Sub

    Private Sub ContactLimit(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress, TxtLRN.KeyPress
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)

        If e.KeyChar = Chr(8) Then
            Exit Sub
        End If

        If currentTextBox Is TxtLRN AndAlso TxtLRN.Text.Length >= 12 Then
            e.Handled = True
        ElseIf currentTextBox Is TxtContact AndAlso TxtContact.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class