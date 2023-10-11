<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookInfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtInstanceID = New System.Windows.Forms.Label()
        Me.TxtDateAdded = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDatePublished = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 10)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtInstanceID)
        Me.Panel3.Controls.Add(Me.TxtDateAdded)
        Me.Panel3.Controls.Add(Me.TxtStatus)
        Me.Panel3.Controls.Add(Me.TxtAuthor)
        Me.Panel3.Controls.Add(Me.TxtDatePublished)
        Me.Panel3.Controls.Add(Me.TxtTitle)
        Me.Panel3.Controls.Add(Me.TxtISBN)
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Controls.Add(Me.Panel34)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(401, 457)
        Me.Panel3.TabIndex = 5
        '
        'TxtInstanceID
        '
        Me.TxtInstanceID.AutoSize = True
        Me.TxtInstanceID.Location = New System.Drawing.Point(12, 386)
        Me.TxtInstanceID.Name = "TxtInstanceID"
        Me.TxtInstanceID.Size = New System.Drawing.Size(48, 16)
        Me.TxtInstanceID.TabIndex = 22
        Me.TxtInstanceID.Text = "Label2"
        Me.TxtInstanceID.Visible = False
        '
        'TxtDateAdded
        '
        Me.TxtDateAdded.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDateAdded.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDateAdded.DefaultText = ""
        Me.TxtDateAdded.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDateAdded.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDateAdded.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDateAdded.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDateAdded.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDateAdded.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDateAdded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDateAdded.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDateAdded.Location = New System.Drawing.Point(6, 341)
        Me.TxtDateAdded.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDateAdded.Name = "TxtDateAdded"
        Me.TxtDateAdded.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDateAdded.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtDateAdded.PlaceholderText = "Date Added"
        Me.TxtDateAdded.ReadOnly = True
        Me.TxtDateAdded.SelectedText = ""
        Me.TxtDateAdded.Size = New System.Drawing.Size(389, 44)
        Me.TxtDateAdded.TabIndex = 33
        '
        'TxtStatus
        '
        Me.TxtStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtStatus.DefaultText = ""
        Me.TxtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtStatus.Location = New System.Drawing.Point(6, 289)
        Me.TxtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtStatus.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtStatus.PlaceholderText = "Status"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.SelectedText = ""
        Me.TxtStatus.Size = New System.Drawing.Size(389, 44)
        Me.TxtStatus.TabIndex = 32
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
        Me.TxtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtAuthor.Location = New System.Drawing.Point(6, 185)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAuthor.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtAuthor.PlaceholderText = "Author/s"
        Me.TxtAuthor.ReadOnly = True
        Me.TxtAuthor.SelectedText = ""
        Me.TxtAuthor.Size = New System.Drawing.Size(389, 44)
        Me.TxtAuthor.TabIndex = 31
        '
        'TxtDatePublished
        '
        Me.TxtDatePublished.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDatePublished.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDatePublished.DefaultText = ""
        Me.TxtDatePublished.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDatePublished.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDatePublished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDatePublished.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDatePublished.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDatePublished.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtDatePublished.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDatePublished.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtDatePublished.Location = New System.Drawing.Point(6, 237)
        Me.TxtDatePublished.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDatePublished.Name = "TxtDatePublished"
        Me.TxtDatePublished.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDatePublished.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtDatePublished.PlaceholderText = "Date Published"
        Me.TxtDatePublished.ReadOnly = True
        Me.TxtDatePublished.SelectedText = ""
        Me.TxtDatePublished.Size = New System.Drawing.Size(389, 44)
        Me.TxtDatePublished.TabIndex = 30
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
        Me.TxtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtTitle.Location = New System.Drawing.Point(6, 133)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle.PlaceholderText = "Title"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.SelectedText = ""
        Me.TxtTitle.Size = New System.Drawing.Size(389, 44)
        Me.TxtTitle.TabIndex = 29
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
        Me.TxtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtISBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtISBN.Location = New System.Drawing.Point(6, 81)
        Me.TxtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtISBN.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtISBN.PlaceholderText = "ISBN"
        Me.TxtISBN.ReadOnly = True
        Me.TxtISBN.SelectedText = ""
        Me.TxtISBN.Size = New System.Drawing.Size(389, 44)
        Me.TxtISBN.TabIndex = 28
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(6, 405)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(389, 40)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Cancel"
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
        Me.Label1.Text = "Book Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel36
        '
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel36.Location = New System.Drawing.Point(790, 10)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(10, 457)
        Me.Panel36.TabIndex = 21
        '
        'FrmBookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel36)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBookInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtDateAdded As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtStatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDatePublished As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtInstanceID As Label
End Class
