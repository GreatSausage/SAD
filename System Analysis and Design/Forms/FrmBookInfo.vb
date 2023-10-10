Public Class FrmBookInfo

    Private currentBookID As Integer

    Public Sub New(ByVal bookID As Integer, ByVal isbn As String, ByVal title As String, ByVal datePublished As DateTime, ByVal authors As String, ByVal status As String, ByVal dateAdded As DateTime)

        InitializeComponent()

        currentBookID = bookID
        TxtISBN.Text = isbn
        TxtTitle.Text = title
        TxtDatePublished.Text = datePublished.ToShortDateString()
        TxtAuthor.Text = authors
        TxtStatus.Text = status
        TxtDateAdded.Text = dateAdded.ToShortDateString()
    End Sub


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnAddCopies_Click(sender As Object, e As EventArgs) Handles BtnAddCopies.Click
        Dim copiesToAdd As Integer = CInt(NumCopiesToAdd.Value)
        AddMultipleCopies(currentBookID, copiesToAdd)
        MessageBox.Show($"{copiesToAdd} copies added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NumCopiesToAdd.Value = 1
        LoadBookCopies()
        Me.Close()
    End Sub
End Class