Imports System.Data.SqlClient

Module MdlDatabase

    Private Const ConnString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\System Analysis and Design\System Analysis and Design\dbUsers.mdf;Integrated Security=True"

    Private Function CreateConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function

    Public Function DisplayData(tblName As String) As DataTable
        Using conn As SqlConnection = CreateConnection()
            Dim selectCommand As New SqlCommand($"SELECT * FROM {tblName}", conn)
            Dim adapter As New SqlDataAdapter(selectCommand)
            Dim dataset As New DataSet()
            conn.Open()
            adapter.Fill(dataset)
            Return dataset.Tables(0)
        End Using
    End Function

#Region "Sign in screen functions"
    Public Function SignInScreen() As Boolean
        Dim email = FrmLogin.TxtEmail.Text
        Dim password = FrmLogin.TxtPassword.Text
        Dim tableName As String = If(CheckExists("tblLibrarians", email), "tblLibrarians", If(CheckExists("tblAsstLibrarian", email), "tblAsstLibrarian", String.Empty))

        If String.IsNullOrEmpty(tableName) Then
            MessageBox.Show("Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE email = @email AND password = @password"
        Using conn As SqlConnection = CreateConnection()
            Dim command As New SqlCommand(query, conn)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@password", password)
            conn.Open()
            If command.ExecuteScalar() > 0 Then
                FrmLogin.Hide()
                FrmMain.Show()
                Return True
            Else
                MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End Using
    End Function

    Private Function CheckExists(tableName As String, email As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE email = @email"
        Using conn As SqlConnection = CreateConnection()
            Dim command As New SqlCommand(query, conn)
            command.Parameters.AddWithValue("@email", email)
            conn.Open()
            Return command.ExecuteScalar() > 0
        End Using
    End Function

#End Region

#Region "manage borrower functions"
    Public Sub InsertBorrowers()
        Using conn As SqlConnection = CreateConnection()
            Dim insertCommand As New SqlCommand("INSERT INTO tblBorrowers (lrn, firstName, lastName, grade, section, guardianContact) VALUES (@lrn, @firstName, @lastName, @grade, @section, @guardianContact)", conn)
            With insertCommand.Parameters
                .AddWithValue("@lrn", FrmNewBorrower.TxtLRN.Text)
                .AddWithValue("@firstName", FrmNewBorrower.TxtFirstName.Text)
                .AddWithValue("@lastName", FrmNewBorrower.TxtLastName.Text)
                .AddWithValue("@grade", FrmNewBorrower.TxtGrade.Text)
                .AddWithValue("@section", FrmNewBorrower.TxtSection.Text)
                .AddWithValue("@guardianContact", FrmNewBorrower.TxtContact.Text)
            End With
            conn.Open()
            insertCommand.ExecuteNonQuery()
            MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmNewBorrower.Close()
            Dim table As DataTable = DisplayData("tblBorrowers")
            FrmBorrowers.Datagridview.DataSource = table
        End Using
    End Sub

#End Region

End Module
