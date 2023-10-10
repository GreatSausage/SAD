Public Class FrmBorrowerInfo

    Public Sub New(ByVal lrn As Integer, ByVal firstname As String, ByVal lastname As String, ByVal grade As Integer, ByVal section As Integer, ByVal guardianContact As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        TxtLrn.Text = lrn
        TxtFirstname.Text = firstname
        TxtLastname.Text = lastname
        TxtGrade.Text = grade
        TxtSection.Text = section
        TxtGuardianContact.Text = guardianContact

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class