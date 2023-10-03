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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAccountSettings_Click(sender As Object, e As EventArgs) Handles BtnAccountSettings.Click

    End Sub

    Private Sub BtnSignout_Click(sender As Object, e As EventArgs) Handles BtnSignout.Click

    End Sub

    Private Sub BtnAuditTrails_Click(sender As Object, e As EventArgs) Handles BtnAuditTrails.Click

    End Sub

    Private Sub BtnOverdue_Click(sender As Object, e As EventArgs) Handles BtnOverdue.Click

    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click

    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click

    End Sub

    Private Sub BtnBooks_Click(sender As Object, e As EventArgs) Handles BtnBooks.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub PanelDisplay_Paint(sender As Object, e As PaintEventArgs) Handles PanelDisplay.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class