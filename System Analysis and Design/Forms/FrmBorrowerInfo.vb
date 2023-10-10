Public Class FrmBorrowerInfo

    Public borrowerID As Integer
    Public Sub New(ByVal borrowerID As Integer, ByVal lrn As String, ByVal firstname As String, ByVal lastname As String, ByVal grade As String, ByVal section As String, ByVal guardianContact As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.borrowerID = borrowerID
        TxtLrn.Text = lrn
        TxtFirstname.Text = firstname
        TxtLastname.Text = lastname
        TxtGrade.Text = grade
        TxtSection.Text = section
        TxtGuardianContact.Text = guardianContact

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub AntiCopyPaste(sender As Object, e As KeyEventArgs) Handles TxtFirstname.KeyDown, TxtGrade.KeyDown, TxtGuardianContact.KeyDown, TxtLastname.KeyDown, TxtLrn.KeyDown, TxtSection.KeyDown
        AntiCopyPasteInput(sender, e)
    End Sub

    Private Sub NumbersOnly(sender As Object, e As KeyPressEventArgs) Handles TxtLrn.KeyPress, TxtGrade.KeyPress, TxtSection.KeyPress, TxtGuardianContact.KeyPress
        NumberOnly(sender, e)
    End Sub

    Private Sub LettersOnly(sender As Object, e As KeyPressEventArgs) Handles TxtFirstname.KeyPress, TxtLastname.KeyPress
        LetterOnly(sender, e)
    End Sub

    Private Sub ContactLimit(sender As Object, e As KeyPressEventArgs) Handles TxtGuardianContact.KeyPress, TxtLrn.KeyPress
        Dim currentTextBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)

        If e.KeyChar = Chr(8) Then
            Exit Sub
        End If

        If currentTextBox Is TxtLrn AndAlso TxtLrn.Text.Length >= 12 Then
            e.Handled = True
        ElseIf currentTextBox Is TxtGuardianContact AndAlso TxtGuardianContact.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtGuardianContact.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtFirstname.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtGrade.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLastname.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtLrn.Text) Then
            EmptyTextbox()
            Exit Sub
        ElseIf String.IsNullOrEmpty(TxtSection.Text) Then
            EmptyTextbox()
            Exit Sub
        Else
            UpdateBorrowers(Me.borrowerID, TxtLrn.Text, TxtFirstname.Text, TxtLastname.Text, TxtGrade.Text, TxtSection.Text, TxtGuardianContact.Text)
            DisplayData("tblBorrowers")
            Me.Close()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

End Class