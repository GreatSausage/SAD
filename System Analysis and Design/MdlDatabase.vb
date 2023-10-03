Imports System.Data.SqlClient
Module MdlDatabase
    Public connection As SqlConnection = OpenSesame("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\System Analysis and Design\System Analysis and Design\dbUsers.mdf;Integrated Security=True")

    Public Function OpenSesame(connString As String) As SqlConnection
        Dim connection As SqlConnection = Nothing
        Try
            connection = New SqlConnection(connString)
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connection
    End Function

#Region "Sign in screen functions"
    Public Sub SignInScreen()

        Dim librarianCommand As New SqlCommand("SELECT * FROM tblLibrarians WHERE email = @email", connection)
        librarianCommand.Parameters.AddWithValue("@email", FrmLogin.TxtEmail.Text)
        Dim asstLibrarianCommand As New SqlCommand("SELECT * FROM tblAsstLibrarian WHERE email = @email", connection)
        asstLibrarianCommand.Parameters.AddWithValue("@email", FrmLogin.TxtEmail.Text)
        If (librarianCommand.ExecuteScalar() > 0) Then
            Dim librarianPassword As New SqlCommand("SELECT * FROM tblLibrarians WHERE password = @password", connection)
            librarianPassword.Parameters.AddWithValue("@password", FrmLogin.TxtPassword.Text)
            If (librarianPassword.ExecuteScalar() > 0) Then
                MessageBox.Show("tada")
                FrmMain.Show()
                FrmLogin.Close()
            Else
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf (asstLibrarianCommand.ExecuteScalar() > 0) Then
        Dim asstLibrarianPassword As New SqlCommand("SELECT * FROM tblAsstLibrarian WHERE password = @password", connection)
            asstLibrarianPassword.Parameters.AddWithValue("@password", FrmLogin.TxtPassword.Text)

            If (asstLibrarianPassword.ExecuteScalar() > 0) Then
                MessageBox.Show("tada")
                FrmMain.Show()
                FrmLogin.Close()
            Else
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
#End Region

#Region "manage borrower functions"
    Public Sub IinsertMoTo()
        Dim insertCommand As New SqlCommand("INSERT INTO tblBorrowers (lrn, firstName, lastName, grade, section, guardianContact) 
        VALUES (@lrn, @firstName, @lastName, @grade, @section, @guardianContact)", connection)
        With insertCommand.Parameters
            .AddWithValue("@lrn", FrmNewBorrower.TxtLRN.Text)
            .AddWithValue("@firstName", FrmNewBorrower.TxtFirstName.Text)
            .AddWithValue("@lastName", FrmNewBorrower.TxtLastName.Text)
            .AddWithValue("@grade", FrmNewBorrower.TxtGrade.Text)
            .AddWithValue("@section", FrmNewBorrower.TxtSection.Text)
            .AddWithValue("@guardianContact", FrmNewBorrower.TxtContact.Text)
        End With
        insertCommand.ExecuteNonQuery()
        MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


#End Region
End Module

