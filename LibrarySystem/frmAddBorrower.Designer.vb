<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBorrower
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBorrower))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.cboProgram = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskContact = New System.Windows.Forms.MaskedTextBox()
        Me.mskBorrowerID = New System.Windows.Forms.MaskedTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TimerBorrower = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDateJoined = New System.Windows.Forms.DateTimePicker()
        Me.lblLastModifiedDate = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(603, 692)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(387, 692)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 32)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(277, 692)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 32)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboGender
        '
        Me.cboGender.ContextMenuStrip = Me.ContextMenuStrip1
        Me.cboGender.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(411, 242)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(292, 31)
        Me.cboGender.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClearAll})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 30)
        '
        'mnuClearAll
        '
        Me.mnuClearAll.Image = Global.LibrarySystem.My.Resources.Resources.icons8_xbox_x_30
        Me.mnuClearAll.Name = "mnuClearAll"
        Me.mnuClearAll.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuClearAll.Size = New System.Drawing.Size(161, 26)
        Me.mnuClearAll.Text = "Clear All"
        '
        'txtEmail
        '
        Me.txtEmail.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtEmail.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(411, 354)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 29)
        Me.txtEmail.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 354)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 299)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 30)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Contact:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(301, 244)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Gender:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DOB:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Last Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLName.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtLName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(411, 142)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(292, 29)
        Me.txtLName.TabIndex = 2
        '
        'dtpDOB
        '
        Me.dtpDOB.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtpDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(411, 194)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(292, 25)
        Me.dtpDOB.TabIndex = 3
        '
        'txtFName
        '
        Me.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFName.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtFName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(411, 85)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(292, 29)
        Me.txtFName.TabIndex = 1
        '
        'cboProgram
        '
        Me.cboProgram.ContextMenuStrip = Me.ContextMenuStrip1
        Me.cboProgram.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgram.FormattingEnabled = True
        Me.cboProgram.Location = New System.Drawing.Point(411, 410)
        Me.cboProgram.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProgram.Name = "cboProgram"
        Me.cboProgram.Size = New System.Drawing.Size(292, 31)
        Me.cboProgram.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 409)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Programme:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mskContact
        '
        Me.mskContact.ContextMenuStrip = Me.ContextMenuStrip1
        Me.mskContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContact.Location = New System.Drawing.Point(411, 302)
        Me.mskContact.Margin = New System.Windows.Forms.Padding(4)
        Me.mskContact.Mask = "(999) 000-0000"
        Me.mskContact.Name = "mskContact"
        Me.mskContact.Size = New System.Drawing.Size(292, 28)
        Me.mskContact.TabIndex = 5
        '
        'mskBorrowerID
        '
        Me.mskBorrowerID.ContextMenuStrip = Me.ContextMenuStrip1
        Me.mskBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskBorrowerID.Location = New System.Drawing.Point(411, 34)
        Me.mskBorrowerID.Margin = New System.Windows.Forms.Padding(4)
        Me.mskBorrowerID.Mask = "99???99999"
        Me.mskBorrowerID.Name = "mskBorrowerID"
        Me.mskBorrowerID.Size = New System.Drawing.Size(292, 28)
        Me.mskBorrowerID.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.AutoSize = True
        Me.btnSelectPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSelectPicture.FlatAppearance.BorderSize = 0
        Me.btnSelectPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectPicture.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPicture.ForeColor = System.Drawing.Color.White
        Me.btnSelectPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectPicture.Location = New System.Drawing.Point(58, 258)
        Me.btnSelectPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(159, 36)
        Me.btnSelectPicture.TabIndex = 10
        Me.btnSelectPicture.Text = "S&elect Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 468)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 30)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Status:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.White
        Me.cboStatus.ContextMenuStrip = Me.ContextMenuStrip1
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Deactivated"})
        Me.cboStatus.Location = New System.Drawing.Point(411, 469)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(292, 31)
        Me.cboStatus.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.imgBorrower_Default_Image
        Me.PictureBox1.InitialImage = Global.LibrarySystem.My.Resources.Resources.imgBorrower_Default_Image
        Me.PictureBox1.Location = New System.Drawing.Point(58, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(281, 569)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 30)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Remark:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(411, 522)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(292, 22)
        Me.TextBox1.TabIndex = 25
        '
        'txtRemark
        '
        Me.txtRemark.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtRemark.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.ForeColor = System.Drawing.Color.Silver
        Me.txtRemark.Location = New System.Drawing.Point(411, 571)
        Me.txtRemark.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(292, 78)
        Me.txtRemark.TabIndex = 26
        Me.txtRemark.Text = "If Applicable"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(493, 692)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(259, 519)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 30)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Date Joined :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateJoined
        '
        Me.dtpDateJoined.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateJoined.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtpDateJoined.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateJoined.Location = New System.Drawing.Point(411, 522)
        Me.dtpDateJoined.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateJoined.Name = "dtpDateJoined"
        Me.dtpDateJoined.Size = New System.Drawing.Size(292, 25)
        Me.dtpDateJoined.TabIndex = 9
        '
        'lblLastModifiedDate
        '
        Me.lblLastModifiedDate.Location = New System.Drawing.Point(0, 711)
        Me.lblLastModifiedDate.Name = "lblLastModifiedDate"
        Me.lblLastModifiedDate.Size = New System.Drawing.Size(245, 23)
        Me.lblLastModifiedDate.TabIndex = 30
        '
        'frmAddBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 735)
        Me.Controls.Add(Me.lblLastModifiedDate)
        Me.Controls.Add(Me.dtpDateJoined)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mskBorrowerID)
        Me.Controls.Add(Me.mskContact)
        Me.Controls.Add(Me.cboProgram)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Borrower"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtFName As TextBox
    Friend WithEvents cboProgram As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents mskBorrowerID As MaskedTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents mnuClearAll As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSelectPicture As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents TimerBorrower As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpDateJoined As DateTimePicker
    Friend WithEvents lblLastModifiedDate As Label
End Class
