Public Class FrmBookInfo


    Public Sub New(ByVal instanceID As Integer, ByVal isbn As String, ByVal title As String, ByVal datePublished As DateTime, ByVal authors As String, ByVal status As String, ByVal dateAdded As DateTime)

        InitializeComponent()

        TxtInstanceID.Text = instanceID
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

End Class