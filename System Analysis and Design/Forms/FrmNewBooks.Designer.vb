<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewBooks
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDatePublished = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCopies = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.TxtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 10)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 10)
        Me.Panel2.TabIndex = 1
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
        Me.TxtISBN.Location = New System.Drawing.Point(6, 86)
        Me.TxtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtISBN.Name = "TxtISBN"
        Me.TxtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtISBN.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtISBN.PlaceholderText = "ISBN"
        Me.TxtISBN.SelectedText = ""
        Me.TxtISBN.Size = New System.Drawing.Size(381, 44)
        Me.TxtISBN.TabIndex = 14
        '
        'BtnCancel
        '
        Me.BtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(6, 422)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(381, 51)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(6, 365)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(381, 51)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 60)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Import Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TxtTitle.Location = New System.Drawing.Point(6, 138)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtTitle.PlaceholderText = "Title"
        Me.TxtTitle.SelectedText = ""
        Me.TxtTitle.Size = New System.Drawing.Size(381, 44)
        Me.TxtTitle.TabIndex = 18
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
        Me.TxtDatePublished.Location = New System.Drawing.Point(6, 242)
        Me.TxtDatePublished.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDatePublished.Name = "TxtDatePublished"
        Me.TxtDatePublished.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDatePublished.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtDatePublished.PlaceholderText = "Date Published (MM-dd-yyyy)"
        Me.TxtDatePublished.SelectedText = ""
        Me.TxtDatePublished.Size = New System.Drawing.Size(381, 44)
        Me.TxtDatePublished.TabIndex = 20
        '
        'TxtCopies
        '
        Me.TxtCopies.BackColor = System.Drawing.Color.Transparent
        Me.TxtCopies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtCopies.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCopies.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCopies.Location = New System.Drawing.Point(6, 294)
        Me.TxtCopies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCopies.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TxtCopies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtCopies.Name = "TxtCopies"
        Me.TxtCopies.Size = New System.Drawing.Size(381, 44)
        Me.TxtCopies.TabIndex = 21
        Me.TxtCopies.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtCopies.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TxtCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.TxtAuthor.Location = New System.Drawing.Point(6, 190)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAuthor.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TxtAuthor.PlaceholderText = "Author/s"
        Me.TxtAuthor.SelectedText = ""
        Me.TxtAuthor.Size = New System.Drawing.Size(381, 44)
        Me.TxtAuthor.TabIndex = 22
        '
        'FrmNewBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.TxtCopies)
        Me.Controls.Add(Me.TxtDatePublished)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtISBN)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.TxtCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDatePublished As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCopies As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents TxtAuthor As Guna.UI2.WinForms.Guna2TextBox
End Class
