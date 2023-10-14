
Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BilognaPictureBox(PictureBox1)
        DisplayFormPanel(FrmDashboard, PanelDisplay)
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim y As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = x
        Me.Height = y - (y - Screen.PrimaryScreen.WorkingArea.Height)
        Me.Left = 0
        Me.Top = 0
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        DisplayFormPanel(FrmDashboard, PanelDisplay)
    End Sub

    Private Sub BtnBorrowers_Click(sender As Object, e As EventArgs) Handles BtnBorrowers.Click
        DisplayFormPanel(FrmBorrowers, PanelDisplay)
    End Sub

    Private Sub BtnBooks_Click(sender As Object, e As EventArgs) Handles BtnBooks.Click
        DisplayFormPanel(FrmBooks, PanelDisplay)
    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click
        Dim s As New FrmBorrow
        s.Show()
    End Sub
End Class