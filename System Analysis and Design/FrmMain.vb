﻿Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BilognaPictureBox(PictureBox1)
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub
End Class