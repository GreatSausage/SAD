Imports System.Runtime.Remoting.Channels

Public Class FrmNewBooks
    Private Sub AntiCopyPaste(sender As Object, e As KeyEventArgs) Handles TxtAuthor.KeyDown, TxtCopies.KeyDown, TxtDatePublished.KeyDown, TxtISBN.KeyDown, TxtTitle.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub

    Private Sub NumberInputs(sender As Object, e As KeyPressEventArgs) Handles TxtCopies.KeyPress, TxtISBN.KeyPress
        NumberOnly(sender, e)
    End Sub

    Private Sub LetterOnly(sender As Object, e As KeyPressEventArgs) Handles TxtAuthor.KeyPress
        AntiSymbolsandNumberInput(sender, e)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If ISBNExists(TxtISBN.Text) Then
            MessageBox.Show("The ISBN already exists, please provide a unique ISBN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            AddNewBook(TxtISBN.Text, TxtTitle.Text, DateTime.Parse(TxtDatePublished.Text), TxtAuthor.Text, Integer.Parse(TxtCopies.Text))
            LoadUniqueBooks()
            LoadBookCopies()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class