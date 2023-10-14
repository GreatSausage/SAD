<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBorrow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBorrow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtLRN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FacultyType = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.TxtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BorrowedDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TxtCallno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ImageButton2 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.TxtBookID = New System.Windows.Forms.TextBox()
        Me.BorrowedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BorrowedDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 10)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(998, 57)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Book Information                                            Borrower Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLastname
        '
        Me.TxtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastname.DefaultText = ""
        Me.TxtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtLastname.Location = New System.Drawing.Point(506, 203)
        Me.TxtLastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtLastname.PlaceholderText = "Lastname"
        Me.TxtLastname.SelectedText = ""
        Me.TxtLastname.Size = New System.Drawing.Size(487, 44)
        Me.TxtLastname.TabIndex = 7
        '
        'TxtFirstname
        '
        Me.TxtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstname.DefaultText = ""
        Me.TxtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFirstname.Location = New System.Drawing.Point(506, 151)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtFirstname.PlaceholderText = "Firstname"
        Me.TxtFirstname.SelectedText = ""
        Me.TxtFirstname.Size = New System.Drawing.Size(487, 44)
        Me.TxtFirstname.TabIndex = 6
        '
        'TxtLRN
        '
        Me.TxtLRN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLRN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLRN.DefaultText = ""
        Me.TxtLRN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLRN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLRN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLRN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLRN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtLRN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLRN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtLRN.Location = New System.Drawing.Point(506, 99)
        Me.TxtLRN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLRN.Name = "TxtLRN"
        Me.TxtLRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLRN.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtLRN.PlaceholderText = "LRN"
        Me.TxtLRN.SelectedText = ""
        Me.TxtLRN.Size = New System.Drawing.Size(420, 44)
        Me.TxtLRN.TabIndex = 5
        '
        'FacultyType
        '
        Me.FacultyType.AutoSize = True
        Me.FacultyType.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.FacultyType.CheckedState.BorderRadius = 0
        Me.FacultyType.CheckedState.BorderThickness = 0
        Me.FacultyType.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.FacultyType.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FacultyType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyType.Location = New System.Drawing.Point(6, 68)
        Me.FacultyType.Name = "FacultyType"
        Me.FacultyType.Size = New System.Drawing.Size(76, 24)
        Me.FacultyType.TabIndex = 16
        Me.FacultyType.Text = "Faculty"
        Me.FacultyType.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.FacultyType.UncheckedState.BorderRadius = 0
        Me.FacultyType.UncheckedState.BorderThickness = 1
        Me.FacultyType.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'TxtAuthor
        '
        Me.TxtAuthor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAuthor.DefaultText = ""
        Me.TxtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAuthor.Location = New System.Drawing.Point(6, 203)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAuthor.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtAuthor.PlaceholderText = "Author"
        Me.TxtAuthor.SelectedText = ""
        Me.TxtAuthor.Size = New System.Drawing.Size(487, 44)
        Me.TxtAuthor.TabIndex = 3
        '
        'TxtTitle
        '
        Me.TxtTitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTitle.DefaultText = ""
        Me.TxtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTitle.Location = New System.Drawing.Point(6, 151)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle.PlaceholderText = "Title"
        Me.TxtTitle.SelectedText = ""
        Me.TxtTitle.Size = New System.Drawing.Size(487, 44)
        Me.TxtTitle.TabIndex = 2
        '
        'TxtISBN
        '
        Me.TxtISBN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtISBN.DefaultText = ""
        Me.TxtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtISBN.Location = New System.Drawing.Point(6, 99)
        Me.TxtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtISBN.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtISBN.PlaceholderText = "ISBN"
        Me.TxtISBN.SelectedText = ""
        Me.TxtISBN.Size = New System.Drawing.Size(420, 44)
        Me.TxtISBN.TabIndex = 1
        '
        'BorrowedDatagrid
        '
        Me.BorrowedDatagrid.AllowUserToAddRows = False
        Me.BorrowedDatagrid.AllowUserToDeleteRows = False
        Me.BorrowedDatagrid.AllowUserToResizeColumns = False
        Me.BorrowedDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.BorrowedDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BorrowedDatagrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowedDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BorrowedDatagrid.ColumnHeadersHeight = 25
        Me.BorrowedDatagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BorrowedID, Me.Firstname, Me.Lastname, Me.LRN, Me.Title, Me.InstanceID, Me.DateBorrowed, Me.DueDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BorrowedDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.BorrowedDatagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorrowedDatagrid.Location = New System.Drawing.Point(6, 329)
        Me.BorrowedDatagrid.MultiSelect = False
        Me.BorrowedDatagrid.Name = "BorrowedDatagrid"
        Me.BorrowedDatagrid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowedDatagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BorrowedDatagrid.RowHeadersVisible = False
        Me.BorrowedDatagrid.RowHeadersWidth = 51
        Me.BorrowedDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.BorrowedDatagrid.RowTemplate.Height = 24
        Me.BorrowedDatagrid.Size = New System.Drawing.Size(987, 162)
        Me.BorrowedDatagrid.TabIndex = 17
        Me.BorrowedDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BorrowedDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BorrowedDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BorrowedDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BorrowedDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BorrowedDatagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BorrowedDatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BorrowedDatagrid.ThemeStyle.HeaderStyle.Height = 25
        Me.BorrowedDatagrid.ThemeStyle.ReadOnly = True
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.Height = 24
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorrowedDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TxtCallno
        '
        Me.TxtCallno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtCallno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCallno.DefaultText = ""
        Me.TxtCallno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCallno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCallno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCallno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCallno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCallno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCallno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCallno.Location = New System.Drawing.Point(6, 255)
        Me.TxtCallno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCallno.Name = "TxtCallno"
        Me.TxtCallno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCallno.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtCallno.PlaceholderText = "Call No."
        Me.TxtCallno.SelectedText = ""
        Me.TxtCallno.Size = New System.Drawing.Size(487, 44)
        Me.TxtCallno.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(506, 255)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(235, 44)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(758, 255)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(235, 44)
        Me.BtnConfirm.TabIndex = 9
        Me.BtnConfirm.Text = "Confirm"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 100
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2ImageButton2
        '
        Me.Guna2ImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ImageButton2.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.Guna2ImageButton2.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.Guna2ImageButton2.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Image = CType(resources.GetObject("Guna2ImageButton2.Image"), System.Drawing.Image)
        Me.Guna2ImageButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton2.ImageRotate = 0!
        Me.Guna2ImageButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Location = New System.Drawing.Point(932, 99)
        Me.Guna2ImageButton2.Name = "Guna2ImageButton2"
        Me.Guna2ImageButton2.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton2.Size = New System.Drawing.Size(61, 44)
        Me.Guna2ImageButton2.TabIndex = 19
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ImageButton1.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(432, 99)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(61, 44)
        Me.Guna2ImageButton1.TabIndex = 21
        '
        'TxtBookID
        '
        Me.TxtBookID.Location = New System.Drawing.Point(298, 70)
        Me.TxtBookID.Name = "TxtBookID"
        Me.TxtBookID.Size = New System.Drawing.Size(100, 22)
        Me.TxtBookID.TabIndex = 22
        '
        'BorrowedID
        '
        Me.BorrowedID.DataPropertyName = "BorrowedID"
        Me.BorrowedID.HeaderText = "Borrowed ID"
        Me.BorrowedID.MinimumWidth = 6
        Me.BorrowedID.Name = "BorrowedID"
        Me.BorrowedID.ReadOnly = True
        Me.BorrowedID.Visible = False
        '
        'Firstname
        '
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.MinimumWidth = 6
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        '
        'Lastname
        '
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.MinimumWidth = 6
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        '
        'LRN
        '
        Me.LRN.DataPropertyName = "LRN"
        Me.LRN.HeaderText = "LRN"
        Me.LRN.MinimumWidth = 6
        Me.LRN.Name = "LRN"
        Me.LRN.ReadOnly = True
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.MinimumWidth = 6
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'InstanceID
        '
        Me.InstanceID.DataPropertyName = "InstanceID"
        Me.InstanceID.HeaderText = "Call No."
        Me.InstanceID.MinimumWidth = 6
        Me.InstanceID.Name = "InstanceID"
        Me.InstanceID.ReadOnly = True
        '
        'DateBorrowed
        '
        Me.DateBorrowed.DataPropertyName = "DateBorrowed"
        Me.DateBorrowed.HeaderText = "Date Borrowed"
        Me.DateBorrowed.MinimumWidth = 6
        Me.DateBorrowed.Name = "DateBorrowed"
        Me.DateBorrowed.ReadOnly = True
        '
        'DueDate
        '
        Me.DueDate.DataPropertyName = "DueDate"
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.MinimumWidth = 6
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
        '
        'FrmBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtBookID)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.Guna2ImageButton2)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtCallno)
        Me.Controls.Add(Me.BorrowedDatagrid)
        Me.Controls.Add(Me.FacultyType)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.TxtISBN)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.TxtLRN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BorrowedDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtLRN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FacultyType As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents TxtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BorrowedDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TxtCallno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ImageButton2 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents TxtBookID As TextBox
    Friend WithEvents BorrowedID As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents LRN As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents InstanceID As DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
End Class
