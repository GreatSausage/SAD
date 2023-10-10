<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAccountSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSignout = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAuditTrails = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnOverdue = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBorrow = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBooks = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBorrowers = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelDisplay = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnAccountSettings)
        Me.Panel1.Controls.Add(Me.BtnSignout)
        Me.Panel1.Controls.Add(Me.BtnAuditTrails)
        Me.Panel1.Controls.Add(Me.BtnOverdue)
        Me.Panel1.Controls.Add(Me.BtnReturn)
        Me.Panel1.Controls.Add(Me.BtnBorrow)
        Me.Panel1.Controls.Add(Me.BtnBooks)
        Me.Panel1.Controls.Add(Me.BtnBorrowers)
        Me.Panel1.Controls.Add(Me.BtnDashboard)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 1100)
        Me.Panel1.TabIndex = 0
        '
        'BtnAccountSettings
        '
        Me.BtnAccountSettings.BackColor = System.Drawing.Color.Transparent
        Me.BtnAccountSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAccountSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAccountSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAccountSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAccountSettings.FillColor = System.Drawing.Color.Transparent
        Me.BtnAccountSettings.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccountSettings.ForeColor = System.Drawing.Color.White
        Me.BtnAccountSettings.Location = New System.Drawing.Point(0, 711)
        Me.BtnAccountSettings.Name = "BtnAccountSettings"
        Me.BtnAccountSettings.Size = New System.Drawing.Size(325, 69)
        Me.BtnAccountSettings.TabIndex = 9
        Me.BtnAccountSettings.Text = "     Account Settings"
        Me.BtnAccountSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnSignout
        '
        Me.BtnSignout.BackColor = System.Drawing.Color.Transparent
        Me.BtnSignout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSignout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSignout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSignout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSignout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSignout.FillColor = System.Drawing.Color.Transparent
        Me.BtnSignout.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignout.ForeColor = System.Drawing.Color.White
        Me.BtnSignout.Location = New System.Drawing.Point(0, 1031)
        Me.BtnSignout.Name = "BtnSignout"
        Me.BtnSignout.Size = New System.Drawing.Size(325, 69)
        Me.BtnSignout.TabIndex = 8
        Me.BtnSignout.Text = "     Sign Out"
        Me.BtnSignout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnAuditTrails
        '
        Me.BtnAuditTrails.BackColor = System.Drawing.Color.Transparent
        Me.BtnAuditTrails.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAuditTrails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAuditTrails.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAuditTrails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAuditTrails.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAuditTrails.FillColor = System.Drawing.Color.Transparent
        Me.BtnAuditTrails.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAuditTrails.ForeColor = System.Drawing.Color.White
        Me.BtnAuditTrails.Location = New System.Drawing.Point(0, 642)
        Me.BtnAuditTrails.Name = "BtnAuditTrails"
        Me.BtnAuditTrails.Size = New System.Drawing.Size(325, 69)
        Me.BtnAuditTrails.TabIndex = 7
        Me.BtnAuditTrails.Text = "     Audit Trail"
        Me.BtnAuditTrails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnOverdue
        '
        Me.BtnOverdue.BackColor = System.Drawing.Color.Transparent
        Me.BtnOverdue.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOverdue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOverdue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOverdue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOverdue.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOverdue.FillColor = System.Drawing.Color.Transparent
        Me.BtnOverdue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOverdue.ForeColor = System.Drawing.Color.White
        Me.BtnOverdue.Location = New System.Drawing.Point(0, 573)
        Me.BtnOverdue.Name = "BtnOverdue"
        Me.BtnOverdue.Size = New System.Drawing.Size(325, 69)
        Me.BtnOverdue.TabIndex = 6
        Me.BtnOverdue.Text = "     Overdue"
        Me.BtnOverdue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.Transparent
        Me.BtnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReturn.FillColor = System.Drawing.Color.Transparent
        Me.BtnReturn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturn.ForeColor = System.Drawing.Color.White
        Me.BtnReturn.Location = New System.Drawing.Point(0, 504)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(325, 69)
        Me.BtnReturn.TabIndex = 5
        Me.BtnReturn.Text = "     Return Books"
        Me.BtnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnBorrow
        '
        Me.BtnBorrow.BackColor = System.Drawing.Color.Transparent
        Me.BtnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBorrow.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrow.FillColor = System.Drawing.Color.Transparent
        Me.BtnBorrow.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrow.ForeColor = System.Drawing.Color.White
        Me.BtnBorrow.Location = New System.Drawing.Point(0, 435)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(325, 69)
        Me.BtnBorrow.TabIndex = 4
        Me.BtnBorrow.Text = "     Borrow Books"
        Me.BtnBorrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnBooks
        '
        Me.BtnBooks.BackColor = System.Drawing.Color.Transparent
        Me.BtnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBooks.FillColor = System.Drawing.Color.Transparent
        Me.BtnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooks.ForeColor = System.Drawing.Color.White
        Me.BtnBooks.Location = New System.Drawing.Point(0, 366)
        Me.BtnBooks.Name = "BtnBooks"
        Me.BtnBooks.Size = New System.Drawing.Size(325, 69)
        Me.BtnBooks.TabIndex = 3
        Me.BtnBooks.Text = "     Manage Books"
        Me.BtnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnBorrowers
        '
        Me.BtnBorrowers.BackColor = System.Drawing.Color.Transparent
        Me.BtnBorrowers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBorrowers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBorrowers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBorrowers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBorrowers.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrowers.FillColor = System.Drawing.Color.Transparent
        Me.BtnBorrowers.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrowers.ForeColor = System.Drawing.Color.White
        Me.BtnBorrowers.Location = New System.Drawing.Point(0, 297)
        Me.BtnBorrowers.Name = "BtnBorrowers"
        Me.BtnBorrowers.Size = New System.Drawing.Size(325, 69)
        Me.BtnBorrowers.TabIndex = 2
        Me.BtnBorrowers.Text = "     Borrowers"
        Me.BtnBorrowers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 228)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(325, 69)
        Me.BtnDashboard.TabIndex = 1
        Me.BtnDashboard.Text = "     Dashboard"
        Me.BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(325, 2)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 226)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(133, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ROLE"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Villena, Clifford T."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(325, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1615, 8)
        Me.Panel4.TabIndex = 1
        '
        'PanelDisplay
        '
        Me.PanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDisplay.Location = New System.Drawing.Point(325, 8)
        Me.PanelDisplay.Name = "PanelDisplay"
        Me.PanelDisplay.Size = New System.Drawing.Size(1615, 1092)
        Me.PanelDisplay.TabIndex = 2
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1940, 1100)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelDisplay)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBorrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBooks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBorrowers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAuditTrails As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnOverdue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSignout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAccountSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelDisplay As Panel
End Class
