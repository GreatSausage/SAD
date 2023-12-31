﻿Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCorners(Me)
        TxtEmail.ContextMenuStrip = New ContextMenuStrip()
        TxtPassword.ContextMenuStrip = New ContextMenuStrip()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtEmail.Text) Or String.IsNullOrEmpty(TxtPassword.Text) Then
            EmptyTextbox()
            Exit Sub
        End If

        SignInScreen()
    End Sub

    Private Sub InputKeydown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown, TxtPassword.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        AntiSymbolsandNumberInput(sender, e)
    End Sub

End Class