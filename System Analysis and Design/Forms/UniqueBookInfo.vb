Public Class UniqueBookInfo

    Public Sub New(ByVal bookID As Integer, ByVal isbn As String, ByVal title As String, ByVal author As String, ByVal datePublished As DateTime, ByVal availableCopies As Integer, ByVal totalCopies As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        TxtBookID.Text = bookID
        TxtISBN.Text = isbn
        TxtTitle.Text = title
        TxtAuthor.Text = author
        TxtDatePublished.Text = datePublished
        TxtAvailableCopies.Text = availableCopies
        TxtTotalCopies.Text = totalCopies
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim copiesToAdd As Integer = CInt(TxtAddCopies.Value)
        AddMultipleCopies(TxtBookID.Text, copiesToAdd)
        MessageBox.Show($"{copiesToAdd} copies added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TxtAddCopies.Value = 1
        LoadBookCopies()
        LoadUniqueBooks()
        Me.Close()
    End Sub
End Class