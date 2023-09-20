Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        DisplayTime.Text = DateTime.Now.ToString("               hh:mm:ss tt")
    End Sub
End Class