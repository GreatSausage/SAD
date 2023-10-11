Imports System.Runtime.Remoting.Channels

Public Class FrmNewBooks
    Private Sub AntiCopyPaste(sender As Object, e As KeyEventArgs) Handles TxtISBN.KeyDown, TxtTitle.KeyDown, TxtAuthor.KeyDown, TxtCopies.KeyDown, TxtDatePublished.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub

    Private Sub NumberInputs(sender As Object, e As KeyPressEventArgs) Handles TxtISBN.KeyPress, TxtCopies.KeyPress
        NumberOnly(sender, e)
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles TxtAuthor.KeyPress
        AntiSymbolsandNumberInput(sender, e)
    End Sub

    Private Sub InputLimits(sender As Object, e As KeyPressEventArgs) Handles TxtISBN.KeyPress
        If e.KeyChar = Chr(8) Then
            Exit Sub
        End If
        If TxtISBN.Text.Length >= 12 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtISBN.Text.Length = 12 Then
            If String.IsNullOrEmpty(TxtAuthor.Text) Then
                EmptyTextbox()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TxtDatePublished.text) Then
                EmptyTextbox()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TxtISBN.Text) Then
                EmptyTextbox()
                Exit Sub
            ElseIf String.IsNullOrEmpty(TxtTitle.Text) Then
                EmptyTextbox()
                Exit Sub
            ElseIf ISBNExists(TxtISBN.Text) Then
                MessageBox.Show("The ISBN already exists, please provide a unique ISBN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                AddNewBook(TxtISBN.Text, TxtTitle.Text, DateTime.Parse(TxtDatePublished.Text), TxtDatePublished.Text, Integer.Parse(TxtCopies.Text))
                LoadUniqueBooks()
                LoadBookCopies()
            End If
        Else
            MessageBox.Show("Invalid ISBN")
        End If
    End Sub
End Class