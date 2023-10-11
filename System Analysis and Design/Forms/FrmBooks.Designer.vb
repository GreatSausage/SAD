<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBooks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnNewBorrower = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Unique = New System.Windows.Forms.TabPage()
        Me.UniqueDatagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueDatePublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueAvailableCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniqueTotalCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Copies = New System.Windows.Forms.TabPage()
        Me.Datagridview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcquisitionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstanceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Unique.SuspendLayout()
        CType(Me.UniqueDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Copies.SuspendLayout()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 23)
        Me.Panel1.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 23)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1924, 136)
        Me.Panel8.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(449, 136)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "MANAGE BOOKS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnNewBorrower)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.TxtSearch)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1134, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(790, 136)
        Me.Panel4.TabIndex = 3
        '
        'BtnNewBorrower
        '
        Me.BtnNewBorrower.BorderRadius = 5
        Me.BtnNewBorrower.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnNewBorrower.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnNewBorrower.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnNewBorrower.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNewBorrower.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNewBorrower.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnNewBorrower.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnNewBorrower.ForeColor = System.Drawing.Color.White
        Me.BtnNewBorrower.Location = New System.Drawing.Point(691, 45)
        Me.BtnNewBorrower.Name = "BtnNewBorrower"
        Me.BtnNewBorrower.Size = New System.Drawing.Size(89, 46)
        Me.BtnNewBorrower.TabIndex = 4
        Me.BtnNewBorrower.Text = "NEW"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(780, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 46)
        Me.Panel5.TabIndex = 3
        '
        'TxtSearch
        '
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSearch.Location = New System.Drawing.Point(0, 45)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TxtSearch.PlaceholderText = "Search Books"
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(684, 46)
        Me.TxtSearch.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 45)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 45)
        Me.Panel2.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1914, 159)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 915)
        Me.Panel10.TabIndex = 11
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(10, 1074)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1914, 10)
        Me.Panel9.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 159)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 925)
        Me.Panel7.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Unique)
        Me.TabControl1.Controls.Add(Me.Copies)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 159)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1904, 915)
        Me.TabControl1.TabIndex = 12
        '
        'Unique
        '
        Me.Unique.Controls.Add(Me.UniqueDatagrid)
        Me.Unique.Location = New System.Drawing.Point(4, 32)
        Me.Unique.Name = "Unique"
        Me.Unique.Size = New System.Drawing.Size(1896, 879)
        Me.Unique.TabIndex = 0
        Me.Unique.Text = "Unique"
        Me.Unique.UseVisualStyleBackColor = True
        '
        'UniqueDatagrid
        '
        Me.UniqueDatagrid.AllowUserToAddRows = False
        Me.UniqueDatagrid.AllowUserToDeleteRows = False
        Me.UniqueDatagrid.AllowUserToResizeColumns = False
        Me.UniqueDatagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.UniqueDatagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UniqueDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UniqueDatagrid.ColumnHeadersHeight = 25
        Me.UniqueDatagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.UniqueISBN, Me.UniqueTitle, Me.UniqueAuthor, Me.UniqueDatePublished, Me.UniqueAvailableCopies, Me.UniqueTotalCopies})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UniqueDatagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.UniqueDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UniqueDatagrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UniqueDatagrid.Location = New System.Drawing.Point(0, 0)
        Me.UniqueDatagrid.MultiSelect = False
        Me.UniqueDatagrid.Name = "UniqueDatagrid"
        Me.UniqueDatagrid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UniqueDatagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.UniqueDatagrid.RowHeadersVisible = False
        Me.UniqueDatagrid.RowHeadersWidth = 51
        Me.UniqueDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.UniqueDatagrid.RowTemplate.Height = 24
        Me.UniqueDatagrid.Size = New System.Drawing.Size(1896, 879)
        Me.UniqueDatagrid.TabIndex = 15
        Me.UniqueDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.UniqueDatagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UniqueDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.UniqueDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UniqueDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UniqueDatagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.UniqueDatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.UniqueDatagrid.ThemeStyle.HeaderStyle.Height = 25
        Me.UniqueDatagrid.ThemeStyle.ReadOnly = True
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.Height = 24
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UniqueDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BookID
        '
        Me.BookID.DataPropertyName = "BookID"
        Me.BookID.HeaderText = "Book ID"
        Me.BookID.MinimumWidth = 6
        Me.BookID.Name = "BookID"
        Me.BookID.ReadOnly = True
        '
        'UniqueISBN
        '
        Me.UniqueISBN.DataPropertyName = "ISBN"
        Me.UniqueISBN.HeaderText = "ISBN"
        Me.UniqueISBN.MinimumWidth = 6
        Me.UniqueISBN.Name = "UniqueISBN"
        Me.UniqueISBN.ReadOnly = True
        '
        'UniqueTitle
        '
        Me.UniqueTitle.DataPropertyName = "Title"
        Me.UniqueTitle.HeaderText = "Title"
        Me.UniqueTitle.MinimumWidth = 6
        Me.UniqueTitle.Name = "UniqueTitle"
        Me.UniqueTitle.ReadOnly = True
        '
        'UniqueAuthor
        '
        Me.UniqueAuthor.DataPropertyName = "Author"
        Me.UniqueAuthor.HeaderText = "Author"
        Me.UniqueAuthor.MinimumWidth = 6
        Me.UniqueAuthor.Name = "UniqueAuthor"
        Me.UniqueAuthor.ReadOnly = True
        '
        'UniqueDatePublished
        '
        Me.UniqueDatePublished.DataPropertyName = "DatePublished"
        Me.UniqueDatePublished.HeaderText = "Date Published"
        Me.UniqueDatePublished.MinimumWidth = 6
        Me.UniqueDatePublished.Name = "UniqueDatePublished"
        Me.UniqueDatePublished.ReadOnly = True
        '
        'UniqueAvailableCopies
        '
        Me.UniqueAvailableCopies.DataPropertyName = "Available Copies"
        Me.UniqueAvailableCopies.HeaderText = "Available Copies"
        Me.UniqueAvailableCopies.MinimumWidth = 6
        Me.UniqueAvailableCopies.Name = "UniqueAvailableCopies"
        Me.UniqueAvailableCopies.ReadOnly = True
        '
        'UniqueTotalCopies
        '
        Me.UniqueTotalCopies.DataPropertyName = "Total Copies"
        Me.UniqueTotalCopies.HeaderText = "Total Copies"
        Me.UniqueTotalCopies.MinimumWidth = 6
        Me.UniqueTotalCopies.Name = "UniqueTotalCopies"
        Me.UniqueTotalCopies.ReadOnly = True
        '
        'Copies
        '
        Me.Copies.Controls.Add(Me.Datagridview)
        Me.Copies.Location = New System.Drawing.Point(4, 32)
        Me.Copies.Name = "Copies"
        Me.Copies.Size = New System.Drawing.Size(1896, 879)
        Me.Copies.TabIndex = 1
        Me.Copies.Text = "Copies"
        Me.Copies.UseVisualStyleBackColor = True
        '
        'Datagridview
        '
        Me.Datagridview.AllowUserToAddRows = False
        Me.Datagridview.AllowUserToDeleteRows = False
        Me.Datagridview.AllowUserToResizeColumns = False
        Me.Datagridview.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Datagridview.ColumnHeadersHeight = 25
        Me.Datagridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBN, Me.Title, Me.Author, Me.DatePublished, Me.Status, Me.AcquisitionDate, Me.InstanceID})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview.DefaultCellStyle = DataGridViewCellStyle7
        Me.Datagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Datagridview.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagridview.Location = New System.Drawing.Point(0, 0)
        Me.Datagridview.MultiSelect = False
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Datagridview.RowHeadersVisible = False
        Me.Datagridview.RowHeadersWidth = 51
        Me.Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Datagridview.RowTemplate.Height = 24
        Me.Datagridview.Size = New System.Drawing.Size(1896, 879)
        Me.Datagridview.TabIndex = 14
        Me.Datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagridview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datagridview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Datagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagridview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagridview.ThemeStyle.HeaderStyle.Height = 25
        Me.Datagridview.ThemeStyle.ReadOnly = True
        Me.Datagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagridview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Datagridview.ThemeStyle.RowsStyle.Height = 24
        Me.Datagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ISBN
        '
        Me.ISBN.DataPropertyName = "ISBN"
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.ReadOnly = True
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        Me.Title.HeaderText = "Title"
        Me.Title.MinimumWidth = 6
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'Author
        '
        Me.Author.DataPropertyName = "Author"
        Me.Author.HeaderText = "Author"
        Me.Author.MinimumWidth = 6
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'DatePublished
        '
        Me.DatePublished.DataPropertyName = "DatePublished"
        Me.DatePublished.HeaderText = "Date Published"
        Me.DatePublished.MinimumWidth = 6
        Me.DatePublished.Name = "DatePublished"
        Me.DatePublished.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'AcquisitionDate
        '
        Me.AcquisitionDate.DataPropertyName = "AcquisitionDate"
        Me.AcquisitionDate.HeaderText = "Date Added"
        Me.AcquisitionDate.MinimumWidth = 6
        Me.AcquisitionDate.Name = "AcquisitionDate"
        Me.AcquisitionDate.ReadOnly = True
        '
        'InstanceID
        '
        Me.InstanceID.DataPropertyName = "InstanceID"
        Me.InstanceID.HeaderText = "Instance ID"
        Me.InstanceID.MinimumWidth = 6
        Me.InstanceID.Name = "InstanceID"
        Me.InstanceID.ReadOnly = True
        '
        'FrmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1084)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Unique.ResumeLayout(False)
        CType(Me.UniqueDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Copies.ResumeLayout(False)
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnNewBorrower As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Unique As TabPage
    Friend WithEvents Copies As TabPage
    Friend WithEvents UniqueDatagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Datagridview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents UniqueISBN As DataGridViewTextBoxColumn
    Friend WithEvents UniqueTitle As DataGridViewTextBoxColumn
    Friend WithEvents UniqueAuthor As DataGridViewTextBoxColumn
    Friend WithEvents UniqueDatePublished As DataGridViewTextBoxColumn
    Friend WithEvents UniqueAvailableCopies As DataGridViewTextBoxColumn
    Friend WithEvents UniqueTotalCopies As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents DatePublished As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AcquisitionDate As DataGridViewTextBoxColumn
    Friend WithEvents InstanceID As DataGridViewTextBoxColumn
End Class
