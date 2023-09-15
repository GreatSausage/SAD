Public Class FrmSignInScreen
    Private Sub FrmSignInScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        TxtPassword.UseSystemPasswordChar = False

    End Sub
End Class