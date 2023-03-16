<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnIssuedReturn = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.PanelBook = New System.Windows.Forms.Panel()
        Me.btnBookAcquired = New System.Windows.Forms.Button()
        Me.btnBookEntry = New System.Windows.Forms.Button()
        Me.btnPulloutBooks = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnBorrowers = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnStatistical = New System.Windows.Forms.Button()
        Me.btnUserAcc = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.PanelBook.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1217, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnIssuedReturn)
        Me.Panel2.Controls.Add(Me.btnRoom)
        Me.Panel2.Controls.Add(Me.PanelBook)
        Me.Panel2.Controls.Add(Me.btnBooks)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.btnBorrowers)
        Me.Panel2.Controls.Add(Me.btnPayment)
        Me.Panel2.Controls.Add(Me.btnStatistical)
        Me.Panel2.Controls.Add(Me.btnUserAcc)
        Me.Panel2.Controls.Add(Me.btnMaintenance)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 762)
        Me.Panel2.TabIndex = 1
        '
        'btnIssuedReturn
        '
        Me.btnIssuedReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIssuedReturn.FlatAppearance.BorderSize = 0
        Me.btnIssuedReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedReturn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuedReturn.ForeColor = System.Drawing.Color.White
        Me.btnIssuedReturn.Image = Global.LibrarySystem.My.Resources.Resources.icons8_event_24
        Me.btnIssuedReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedReturn.Location = New System.Drawing.Point(0, 690)
        Me.btnIssuedReturn.Name = "btnIssuedReturn"
        Me.btnIssuedReturn.Size = New System.Drawing.Size(261, 36)
        Me.btnIssuedReturn.TabIndex = 9
        Me.btnIssuedReturn.Text = "   &Issued/Return"
        Me.btnIssuedReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssuedReturn.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRoom.FlatAppearance.BorderSize = 0
        Me.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoom.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoom.ForeColor = System.Drawing.Color.White
        Me.btnRoom.Image = Global.LibrarySystem.My.Resources.Resources.icons8_room_24
        Me.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoom.Location = New System.Drawing.Point(0, 654)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(261, 36)
        Me.btnRoom.TabIndex = 12
        Me.btnRoom.Text = "   &Room"
        Me.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'PanelBook
        '
        Me.PanelBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelBook.Controls.Add(Me.btnBookAcquired)
        Me.PanelBook.Controls.Add(Me.btnBookEntry)
        Me.PanelBook.Controls.Add(Me.btnPulloutBooks)
        Me.PanelBook.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBook.Location = New System.Drawing.Point(0, 545)
        Me.PanelBook.Name = "PanelBook"
        Me.PanelBook.Size = New System.Drawing.Size(261, 109)
        Me.PanelBook.TabIndex = 14
        '
        'btnBookAcquired
        '
        Me.btnBookAcquired.FlatAppearance.BorderSize = 0
        Me.btnBookAcquired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookAcquired.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookAcquired.ForeColor = System.Drawing.Color.White
        Me.btnBookAcquired.Image = Global.LibrarySystem.My.Resources.Resources.icons8_book_24
        Me.btnBookAcquired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookAcquired.Location = New System.Drawing.Point(0, 36)
        Me.btnBookAcquired.Name = "btnBookAcquired"
        Me.btnBookAcquired.Size = New System.Drawing.Size(261, 36)
        Me.btnBookAcquired.TabIndex = 7
        Me.btnBookAcquired.Text = "   Books &Acquired"
        Me.btnBookAcquired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookAcquired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookAcquired.UseVisualStyleBackColor = True
        '
        'btnBookEntry
        '
        Me.btnBookEntry.FlatAppearance.BorderSize = 0
        Me.btnBookEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookEntry.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookEntry.ForeColor = System.Drawing.Color.White
        Me.btnBookEntry.Image = Global.LibrarySystem.My.Resources.Resources.icons8_enter_24__1_
        Me.btnBookEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookEntry.Location = New System.Drawing.Point(0, 0)
        Me.btnBookEntry.Name = "btnBookEntry"
        Me.btnBookEntry.Size = New System.Drawing.Size(261, 36)
        Me.btnBookEntry.TabIndex = 10
        Me.btnBookEntry.Text = "   Book &Entry"
        Me.btnBookEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookEntry.UseVisualStyleBackColor = True
        '
        'btnPulloutBooks
        '
        Me.btnPulloutBooks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPulloutBooks.FlatAppearance.BorderSize = 0
        Me.btnPulloutBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPulloutBooks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulloutBooks.ForeColor = System.Drawing.Color.White
        Me.btnPulloutBooks.Image = Global.LibrarySystem.My.Resources.Resources.icons8_cancel_subscription_24
        Me.btnPulloutBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPulloutBooks.Location = New System.Drawing.Point(0, 73)
        Me.btnPulloutBooks.Name = "btnPulloutBooks"
        Me.btnPulloutBooks.Size = New System.Drawing.Size(261, 36)
        Me.btnPulloutBooks.TabIndex = 8
        Me.btnPulloutBooks.Text = "   Pull&out Books"
        Me.btnPulloutBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPulloutBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPulloutBooks.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.Image = Global.LibrarySystem.My.Resources.Resources.book_icon
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(0, 509)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(261, 36)
        Me.btnBooks.TabIndex = 6
        Me.btnBooks.Text = "   &Book"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.LibrarySystem.My.Resources.Resources.icons8_logout_rounded_left_24
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 726)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(261, 36)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "   &Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Image = Global.LibrarySystem.My.Resources.Resources.icons8_database_24
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 473)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(261, 36)
        Me.btnReports.TabIndex = 15
        Me.btnReports.Text = "   &Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnBorrowers
        '
        Me.btnBorrowers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrowers.FlatAppearance.BorderSize = 0
        Me.btnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowers.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowers.ForeColor = System.Drawing.Color.White
        Me.btnBorrowers.Image = Global.LibrarySystem.My.Resources.Resources.icons8_borrow_book_24
        Me.btnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowers.Location = New System.Drawing.Point(0, 437)
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.Size = New System.Drawing.Size(261, 36)
        Me.btnBorrowers.TabIndex = 5
        Me.btnBorrowers.Text = "   &Borrowers"
        Me.btnBorrowers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowers.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Image = Global.LibrarySystem.My.Resources.Resources.icons8_credit_card_24
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(0, 401)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(261, 36)
        Me.btnPayment.TabIndex = 4
        Me.btnPayment.Text = "   &Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnStatistical
        '
        Me.btnStatistical.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStatistical.FlatAppearance.BorderSize = 0
        Me.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistical.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistical.ForeColor = System.Drawing.Color.White
        Me.btnStatistical.Image = Global.LibrarySystem.My.Resources.Resources.icons8_statistics_24
        Me.btnStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistical.Location = New System.Drawing.Point(0, 365)
        Me.btnStatistical.Name = "btnStatistical"
        Me.btnStatistical.Size = New System.Drawing.Size(261, 36)
        Me.btnStatistical.TabIndex = 3
        Me.btnStatistical.Text = "   &Statistics"
        Me.btnStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatistical.UseVisualStyleBackColor = True
        '
        'btnUserAcc
        '
        Me.btnUserAcc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserAcc.FlatAppearance.BorderSize = 0
        Me.btnUserAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserAcc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAcc.ForeColor = System.Drawing.Color.White
        Me.btnUserAcc.Image = Global.LibrarySystem.My.Resources.Resources.icons8_male_user_24__1_
        Me.btnUserAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAcc.Location = New System.Drawing.Point(0, 329)
        Me.btnUserAcc.Name = "btnUserAcc"
        Me.btnUserAcc.Size = New System.Drawing.Size(261, 36)
        Me.btnUserAcc.TabIndex = 2
        Me.btnUserAcc.Text = "   &User Account"
        Me.btnUserAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserAcc.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.Image = Global.LibrarySystem.My.Resources.Resources.icons8_settings_24
        Me.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 293)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(261, 36)
        Me.btnMaintenance.TabIndex = 1
        Me.btnMaintenance.Text = "   &Maintenance"
        Me.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.LibrarySystem.My.Resources.Resources.icons8_dashboard_layout_24__1_
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 257)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(261, 36)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   &Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lblRole)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(261, 257)
        Me.Panel3.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(0, 216)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(261, 20)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "DateTime"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources._7019995_thumb
        Me.PictureBox1.Location = New System.Drawing.Point(48, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(0, 194)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(261, 22)
        Me.lblRole.TabIndex = 1
        Me.lblRole.Text = "Administrator"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(-1, 175)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(262, 19)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(261, 10)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(956, 762)
        Me.MainPanel.TabIndex = 1
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.PanelBook.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnIssuedReturn As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnBorrowers As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnStatistical As Button
    Friend WithEvents btnUserAcc As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBookEntry As Button
    Friend WithEvents btnPulloutBooks As Button
    Friend WithEvents btnBookAcquired As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents PanelBook As Panel
End Class
