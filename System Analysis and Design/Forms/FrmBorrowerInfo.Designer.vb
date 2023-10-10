<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBorrowerInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Datagridview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtGuardianContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtSection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtGrade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtLrn = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel34.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 548)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 10)
        Me.Panel2.TabIndex = 34
        '
        'Datagridview
        '
        Me.Datagridview.AllowUserToAddRows = False
        Me.Datagridview.AllowUserToDeleteRows = False
        Me.Datagridview.AllowUserToResizeColumns = False
        Me.Datagridview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datagridview.ColumnHeadersHeight = 25
        Me.Datagridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Section, Me.GuardianContact})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagridview.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datagridview.Dock = System.Windows.Forms.DockStyle.Right
        Me.Datagridview.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagridview.Location = New System.Drawing.Point(407, 0)
        Me.Datagridview.MultiSelect = False
        Me.Datagridview.Name = "Datagridview"
        Me.Datagridview.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Datagridview.RowHeadersVisible = False
        Me.Datagridview.RowHeadersWidth = 51
        Me.Datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Datagridview.RowTemplate.Height = 24
        Me.Datagridview.Size = New System.Drawing.Size(393, 548)
        Me.Datagridview.TabIndex = 35
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
        'Section
        '
        Me.Section.DataPropertyName = "Section"
        Me.Section.HeaderText = "Borrowed"
        Me.Section.MinimumWidth = 6
        Me.Section.Name = "Section"
        Me.Section.ReadOnly = True
        '
        'GuardianContact
        '
        Me.GuardianContact.DataPropertyName = "GuardianContact"
        Me.GuardianContact.HeaderText = "Date Borrowed"
        Me.GuardianContact.MinimumWidth = 6
        Me.GuardianContact.Name = "GuardianContact"
        Me.GuardianContact.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 31)
        Me.Panel1.TabIndex = 37
        '
        'Panel34
        '
        Me.Panel34.Controls.Add(Me.Label1)
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(0, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(401, 60)
        Me.Panel34.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(6, 457)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(388, 50)
        Me.Guna2Button1.TabIndex = 28
        Me.Guna2Button1.Text = "Cancel"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(6, 401)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(388, 50)
        Me.BtnUpdate.TabIndex = 29
        Me.BtnUpdate.Text = "Update"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtGuardianContact)
        Me.Panel3.Controls.Add(Me.TxtSection)
        Me.Panel3.Controls.Add(Me.TxtGrade)
        Me.Panel3.Controls.Add(Me.TxtLastname)
        Me.Panel3.Controls.Add(Me.TxtFirstname)
        Me.Panel3.Controls.Add(Me.TxtLrn)
        Me.Panel3.Controls.Add(Me.BtnUpdate)
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Controls.Add(Me.Panel34)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(401, 517)
        Me.Panel3.TabIndex = 38
        '
        'TxtGuardianContact
        '
        Me.TxtGuardianContact.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGuardianContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGuardianContact.DefaultText = ""
        Me.TxtGuardianContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtGuardianContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtGuardianContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGuardianContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGuardianContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGuardianContact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtGuardianContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGuardianContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGuardianContact.Location = New System.Drawing.Point(6, 338)
        Me.TxtGuardianContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGuardianContact.Name = "TxtGuardianContact"
        Me.TxtGuardianContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtGuardianContact.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtGuardianContact.PlaceholderText = "Guardian Contact"
        Me.TxtGuardianContact.SelectedText = ""
        Me.TxtGuardianContact.Size = New System.Drawing.Size(388, 44)
        Me.TxtGuardianContact.TabIndex = 48
        '
        'TxtSection
        '
        Me.TxtSection.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSection.DefaultText = ""
        Me.TxtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSection.Location = New System.Drawing.Point(6, 286)
        Me.TxtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSection.Name = "TxtSection"
        Me.TxtSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSection.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtSection.PlaceholderText = "Section"
        Me.TxtSection.SelectedText = ""
        Me.TxtSection.Size = New System.Drawing.Size(388, 44)
        Me.TxtSection.TabIndex = 47
        '
        'TxtGrade
        '
        Me.TxtGrade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGrade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtGrade.DefaultText = ""
        Me.TxtGrade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtGrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtGrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGrade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtGrade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGrade.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGrade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtGrade.Location = New System.Drawing.Point(6, 234)
        Me.TxtGrade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGrade.Name = "TxtGrade"
        Me.TxtGrade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtGrade.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtGrade.PlaceholderText = "Grade"
        Me.TxtGrade.SelectedText = ""
        Me.TxtGrade.Size = New System.Drawing.Size(388, 44)
        Me.TxtGrade.TabIndex = 46
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
        Me.TxtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLastname.Location = New System.Drawing.Point(6, 182)
        Me.TxtLastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtLastname.PlaceholderText = "Lastname"
        Me.TxtLastname.SelectedText = ""
        Me.TxtLastname.Size = New System.Drawing.Size(388, 44)
        Me.TxtLastname.TabIndex = 45
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
        Me.TxtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtFirstname.Location = New System.Drawing.Point(6, 130)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtFirstname.PlaceholderText = "Firstname"
        Me.TxtFirstname.SelectedText = ""
        Me.TxtFirstname.Size = New System.Drawing.Size(388, 44)
        Me.TxtFirstname.TabIndex = 44
        '
        'TxtLrn
        '
        Me.TxtLrn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLrn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLrn.DefaultText = ""
        Me.TxtLrn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtLrn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtLrn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLrn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtLrn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLrn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtLrn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLrn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtLrn.Location = New System.Drawing.Point(6, 78)
        Me.TxtLrn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtLrn.Name = "TxtLrn"
        Me.TxtLrn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLrn.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtLrn.PlaceholderText = "LRN"
        Me.TxtLrn.ReadOnly = True
        Me.TxtLrn.SelectedText = ""
        Me.TxtLrn.Size = New System.Drawing.Size(388, 44)
        Me.TxtLrn.TabIndex = 43
        '
        'FrmBorrowerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Datagridview)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBorrowerInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel34.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Datagridview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents GuardianContact As DataGridViewTextBoxColumn
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtLrn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtGuardianContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtSection As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtGrade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtFirstname As Guna.UI2.WinForms.Guna2TextBox
End Class
