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
                Dim login As New Form
                login.Dispose()
                FrmMain.Show()

            Else
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If (asstLibrarianCommand.ExecuteScalar() > 0) Then
            Dim asstLibrarianPassword As New SqlCommand("SELECT * FROM tblAsstLibrarian WHERE password = @password", connection)
            asstLibrarianPassword.Parameters.AddWithValue("@password", FrmLogin.TxtPassword.Text)

            If (asstLibrarianPassword.ExecuteScalar() > 0) Then
                MessageBox.Show("tada")
                Dim login As New Form
                FrmMain.Show()
                login.Dispose()

            Else
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub
End Module

