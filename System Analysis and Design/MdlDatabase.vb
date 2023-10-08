Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Module MdlDatabase

    Private Const ConnString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\System Analysis and Design\System Analysis and Design\dbUsers.mdf;Integrated Security=True"
    Private Const ConnStringBooks As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\System Analysis and Design\System Analysis and Design\dbBooks.mdf;Integrated Security=True"
    Private Function CreateConnection() As SqlConnection
        Return New SqlConnection(ConnString)
    End Function

    Private Function CreateConnectionBooks() As SqlConnection
        Return New SqlConnection(ConnStringBooks)
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

#Region "manage books"
    Public Sub AddNewBook(ByVal ISBN As String, ByVal Title As String, ByVal DatePublished As Date, ByVal Author As String, ByVal Copies As Integer)
        Using conn As SqlConnection = CreateConnectionBooks()
            Dim insertBookQuery As String = "INSERT INTO tblBooks (ISBN, Title, DatePublished, Author) VALUES (@ISBN, @Title, @DatePublished, @Author); SELECT SCOPE_IDENTITY();"
            Using command As New SqlCommand(insertBookQuery, conn)
                command.Parameters.AddWithValue("@ISBN", ISBN)
                command.Parameters.AddWithValue("@Title", Title)
                command.Parameters.AddWithValue("@DatePublished", DatePublished)
                command.Parameters.AddWithValue("@Author", Author)
                conn.Open()
                Dim bookID As Integer = Convert.ToInt32(command.ExecuteScalar())
                conn.Close()

                Dim insertInstancesQuery As String = "INSERT INTO tblBookInstances (BookID, AcquisitionDate, Status) VALUES (@BookID, GETDATE(), 'Available')"
                Using commandInsertInstance As New SqlCommand(insertInstancesQuery, conn)
                    commandInsertInstance.Parameters.AddWithValue("@BookID", bookID)
                    conn.Open()
                    For i As Integer = 1 To Copies
                        commandInsertInstance.ExecuteNonQuery()
                    Next
                    conn.Close()
                End Using
            End Using
        End Using
        MessageBox.Show("Book/s have been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmNewBooks.Close()
    End Sub

    Public Function ISBNExists(ByVal isbn As String) As Boolean
        Dim exists As Boolean = False
        Using connection As SqlConnection = CreateConnectionBooks()
            Dim query As String = "SELECT COUNT(*) FROM tblBooks WHERE ISBN = @ISBN"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ISBN", isbn)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count > 0 Then
                    exists = True
                End If
            End Using
        End Using
        Return exists
    End Function

    Public Sub LoadBooksAndCopies()

        Using connection As SqlConnection = CreateConnectionBooks()
            Dim query As String = "SELECT b.Title, b.ISBN, b.Author, i.Status " &
                                  "FROM tblBooks b " &
                                  "JOIN tblBookInstances i ON b.BookID = i.BookID"
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)
            FrmBooks.Datagridview.DataSource = dataTable
        End Using
    End Sub

#End Region
End Module
