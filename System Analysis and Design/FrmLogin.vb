Imports System.Web

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCorners(Me)
        TxtEmail.ContextMenuStrip = New ContextMenuStrip()
        TxtPassword.ContextMenuStrip = New ContextMenuStrip()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtEmail.Text) Or String.IsNullOrEmpty(TxtPassword.Text) Then
            EmptyTextbox()
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.V OrElse e.KeyCode = Keys.C) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.V OrElse e.KeyCode = Keys.C) Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class