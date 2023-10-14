Imports System.Data.SqlClient

Public Class FrmBorrow

    Public Sub New(Optional ByVal lrn As String = Nothing, Optional ByVal firstname As String = Nothing, Optional ByVal lastname As String = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        TxtLRN.Text = lrn
        TxtFirstname.Text = firstname
        TxtLastname.Text = lastname
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FacultyType_CheckedChanged(sender As Object, e As EventArgs) Handles FacultyType.CheckedChanged
        If FacultyType.Checked = True Then
            TxtISBN.Enabled = False
        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)
        FrmBorrowerList.Show()
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        FrmBorrowerList.Show()
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtISBN.KeyPress
        'If e.KeyChar = Chr(8) Then
        '    Exit Sub
        'End If
        'If TxtISBN.Text.Length >= 13 Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Using conn As SqlConnection = MdlDatabase.CreateConnectionBooks()
            Dim command As New SqlCommand("SELECT * FROM tblBooks WHERE ISBN = @isbn", conn)
            command.Parameters.AddWithValue("@isbn", TxtISBN.Text)
            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataset)
            Dim table As DataTable = dataset.Tables(0)

            If table.Rows.Count > 0 Then
                TxtBookID.Text = table.Rows.Item(0).Item("BookID")
                TxtISBN.Text = table.Rows.Item(0).Item("ISBN")
                TxtTitle.Text = table.Rows.Item(0).Item("Title")
                TxtAuthor.Text = table.Rows.Item(0).Item("Author")
            End If
        End Using
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Using conn As SqlConnection = MdlDatabase.CreateConnectionBooks()

            Dim insertCommand As New SqlCommand("INSERT INTO tblBorrowedBooks (BorrowerID, BookBorrowed, InstanceBorrowed, DateBorrowed, DueDate) 
                                                 VALUES (@borrowerID, @bookBorrowed, @instanceBorrowed, GETDATE(), DATEADD(day, 7, GETDATE()))", conn)
            With insertCommand.Parameters
                .AddWithValue("@borrowerID", TxtLRN.Text)
                .AddWithValue("@bookBorrowed", TxtBookID.Text)
                .AddWithValue("@instanceBorrowed", TxtCallno.Text)
            End With

            Dim updateCommand As New SqlCommand("UPDATE tblBookInstances
                                                 SET Status = 'Borrowed'
                                                 WHERE BookID = @bookID AND InstanceID = @instanceID", conn)

            updateCommand.Parameters.AddWithValue("@bookID", TxtBookID.Text)
            updateCommand.Parameters.AddWithValue("@instanceID", TxtCallno.Text)
            conn.Open()
            insertCommand.ExecuteNonQuery()
            updateCommand.ExecuteNonQuery()
            MessageBox.Show("Book has been borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUniqueBooks()
            LoadBookCopies()
            Displaydata()
        End Using
    End Sub

    Public Sub Displaydata()
        Using conn As SqlConnection = MdlDatabase.CreateConnectionBooks()
            Dim selectCommand As New SqlCommand("SELECT br.BorrowedID, br.DateBorrowed, br.DueDate, 
                                                        bu.Firstname, bu.Lastname, bu.LRN,
                                                        bk.Title,
                                                        bi.InstanceID
                                                        FROM tblBorrowedBooks br
                                                        INNER JOIN tblBorrowers bu ON br.BorrowerID = bu.LRN 
                                                        INNER JOIN tblBooks bk ON br.BookBorrowed = bk.BookID 
                                                        INNER JOIN tblBookInstances bi ON br.InstanceBorrowed = bi.InstanceID", conn)

            Dim dataset As New DataSet
            Dim adapter As New SqlDataAdapter(selectCommand)
            adapter.Fill(dataset)
            BorrowedDatagrid.DataSource = dataset.Tables(0)
        End Using
    End Sub

    Private Sub FrmBorrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        Displaydata()
    End Sub
End Class