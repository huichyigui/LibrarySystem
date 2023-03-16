<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIR))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCloseIR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblBorrowerStatus = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.dgvIssueReturn = New System.Windows.Forms.DataGridView()
        Me.colRowNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIssueID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDaysAllowed = New System.Windows.Forms.Label()
        Me.lblBooksAllowed = New System.Windows.Forms.Label()
        Me.lblPenalty = New System.Windows.Forms.Label()
        Me.mskBorrowerID = New System.Windows.Forms.MaskedTextBox()
        Me.tooltipError = New System.Windows.Forms.ToolTip(Me.components)
        Me.llkBook = New System.Windows.Forms.LinkLabel()
        Me.llkBorrower = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAccessionID = New System.Windows.Forms.TextBox()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblBookPrice = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.llkBookBrowser = New System.Windows.Forms.LinkLabel()
        Me.lblBookStatus = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvIssueReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(2082, 15)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 32)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Issued / Return"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCloseIR)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1079, 64)
        Me.Panel1.TabIndex = 6
        '
        'btnCloseIR
        '
        Me.btnCloseIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCloseIR.FlatAppearance.BorderSize = 0
        Me.btnCloseIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseIR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseIR.ForeColor = System.Drawing.Color.White
        Me.btnCloseIR.Location = New System.Drawing.Point(956, 14)
        Me.btnCloseIR.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCloseIR.Name = "btnCloseIR"
        Me.btnCloseIR.Size = New System.Drawing.Size(102, 32)
        Me.btnCloseIR.TabIndex = 8
        Me.btnCloseIR.Text = "&Close"
        Me.btnCloseIR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Borrower ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 361)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contact"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 319)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Program"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(18, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Borrower's Information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(19, 397)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 15)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Days Allowed"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(187, 397)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 15)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Books Allowed"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(352, 397)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 15)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Penalty (RM) :"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(126, 158)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(352, 24)
        Me.lblName.TabIndex = 31
        '
        'lblProgram
        '
        Me.lblProgram.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.Location = New System.Drawing.Point(127, 200)
        Me.lblProgram.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(352, 24)
        Me.lblProgram.TabIndex = 32
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(127, 239)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(352, 24)
        Me.lblEmail.TabIndex = 33
        '
        'lblBorrowerStatus
        '
        Me.lblBorrowerStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBorrowerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorrowerStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowerStatus.Location = New System.Drawing.Point(126, 319)
        Me.lblBorrowerStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBorrowerStatus.Name = "lblBorrowerStatus"
        Me.lblBorrowerStatus.Size = New System.Drawing.Size(352, 24)
        Me.lblBorrowerStatus.TabIndex = 34
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(127, 276)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(352, 24)
        Me.lblGender.TabIndex = 35
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(127, 357)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(352, 24)
        Me.lblContact.TabIndex = 36
        '
        'dgvIssueReturn
        '
        Me.dgvIssueReturn.AllowUserToAddRows = False
        Me.dgvIssueReturn.AllowUserToDeleteRows = False
        Me.dgvIssueReturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssueReturn.BackgroundColor = System.Drawing.Color.White
        Me.dgvIssueReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvIssueReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssueReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIssueReturn.ColumnHeadersHeight = 31
        Me.dgvIssueReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIssueReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRowNum, Me.colIssueID, Me.colBookID, Me.colBookTitle, Me.colBorrowDate, Me.colDueDate, Me.colStatus, Me.colPrice, Me.AccessionID, Me.BorrowerID})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssueReturn.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvIssueReturn.EnableHeadersVisualStyles = False
        Me.dgvIssueReturn.GridColor = System.Drawing.SystemColors.Control
        Me.dgvIssueReturn.Location = New System.Drawing.Point(24, 443)
        Me.dgvIssueReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIssueReturn.Name = "dgvIssueReturn"
        Me.dgvIssueReturn.ReadOnly = True
        Me.dgvIssueReturn.RowHeadersVisible = False
        Me.dgvIssueReturn.RowHeadersWidth = 49
        Me.dgvIssueReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssueReturn.RowTemplate.Height = 25
        Me.dgvIssueReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssueReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIssueReturn.Size = New System.Drawing.Size(1034, 232)
        Me.dgvIssueReturn.TabIndex = 43
        '
        'colRowNum
        '
        Me.colRowNum.HeaderText = "#"
        Me.colRowNum.MinimumWidth = 6
        Me.colRowNum.Name = "colRowNum"
        Me.colRowNum.ReadOnly = True
        Me.colRowNum.Width = 40
        '
        'colIssueID
        '
        Me.colIssueID.HeaderText = "Issue ID"
        Me.colIssueID.Name = "colIssueID"
        Me.colIssueID.ReadOnly = True
        '
        'colBookID
        '
        Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBookID.HeaderText = "Book ID"
        Me.colBookID.MinimumWidth = 6
        Me.colBookID.Name = "colBookID"
        Me.colBookID.ReadOnly = True
        Me.colBookID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colBookTitle
        '
        Me.colBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBookTitle.HeaderText = "Book Title"
        Me.colBookTitle.MinimumWidth = 6
        Me.colBookTitle.Name = "colBookTitle"
        Me.colBookTitle.ReadOnly = True
        Me.colBookTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colBorrowDate
        '
        Me.colBorrowDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBorrowDate.HeaderText = "Date Borrowed"
        Me.colBorrowDate.Name = "colBorrowDate"
        Me.colBorrowDate.ReadOnly = True
        '
        'colDueDate
        '
        Me.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDueDate.HeaderText = "Due Date"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 80
        '
        'AccessionID
        '
        Me.AccessionID.HeaderText = "Accession ID"
        Me.AccessionID.Name = "AccessionID"
        Me.AccessionID.ReadOnly = True
        Me.AccessionID.Width = 150
        '
        'BorrowerID
        '
        Me.BorrowerID.HeaderText = "Borrower ID"
        Me.BorrowerID.Name = "BorrowerID"
        Me.BorrowerID.ReadOnly = True
        Me.BorrowerID.Width = 150
        '
        'lblDaysAllowed
        '
        Me.lblDaysAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaysAllowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysAllowed.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDaysAllowed.Location = New System.Drawing.Point(126, 391)
        Me.lblDaysAllowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaysAllowed.Name = "lblDaysAllowed"
        Me.lblDaysAllowed.Size = New System.Drawing.Size(45, 24)
        Me.lblDaysAllowed.TabIndex = 48
        Me.lblDaysAllowed.Text = "0"
        '
        'lblBooksAllowed
        '
        Me.lblBooksAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBooksAllowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksAllowed.ForeColor = System.Drawing.Color.DarkRed
        Me.lblBooksAllowed.Location = New System.Drawing.Point(282, 393)
        Me.lblBooksAllowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBooksAllowed.Name = "lblBooksAllowed"
        Me.lblBooksAllowed.Size = New System.Drawing.Size(45, 24)
        Me.lblBooksAllowed.TabIndex = 49
        Me.lblBooksAllowed.Text = "0"
        '
        'lblPenalty
        '
        Me.lblPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenalty.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPenalty.Location = New System.Drawing.Point(434, 394)
        Me.lblPenalty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenalty.Name = "lblPenalty"
        Me.lblPenalty.Size = New System.Drawing.Size(45, 24)
        Me.lblPenalty.TabIndex = 50
        Me.lblPenalty.Text = "0"
        '
        'mskBorrowerID
        '
        Me.mskBorrowerID.Location = New System.Drawing.Point(126, 124)
        Me.mskBorrowerID.Mask = "99???99999"
        Me.mskBorrowerID.Name = "mskBorrowerID"
        Me.mskBorrowerID.Size = New System.Drawing.Size(352, 22)
        Me.mskBorrowerID.TabIndex = 52
        '
        'llkBook
        '
        Me.llkBook.BackColor = System.Drawing.Color.Transparent
        Me.llkBook.Image = CType(resources.GetObject("llkBook.Image"), System.Drawing.Image)
        Me.llkBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llkBook.LinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.llkBook.Location = New System.Drawing.Point(1208, 97)
        Me.llkBook.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llkBook.Name = "llkBook"
        Me.llkBook.Size = New System.Drawing.Size(140, 25)
        Me.llkBook.TabIndex = 47
        Me.llkBook.TabStop = True
        Me.llkBook.Text = "Browse Book"
        Me.llkBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.llkBook.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        '
        'llkBorrower
        '
        Me.llkBorrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llkBorrower.Image = CType(resources.GetObject("llkBorrower.Image"), System.Drawing.Image)
        Me.llkBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llkBorrower.LinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.llkBorrower.Location = New System.Drawing.Point(288, 91)
        Me.llkBorrower.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llkBorrower.Name = "llkBorrower"
        Me.llkBorrower.Size = New System.Drawing.Size(191, 30)
        Me.llkBorrower.TabIndex = 46
        Me.llkBorrower.TabStop = True
        Me.llkBorrower.Text = "Browse Borrower"
        Me.llkBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.llkBorrower.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(555, 397)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Due Date"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(553, 204)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Book Title"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(553, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Book ID"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(553, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 18)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Accession No"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(553, 295)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 18)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Category"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(553, 329)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 18)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Book Price (RM)"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(553, 254)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 18)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Author"
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkRed
        Me.Label20.Location = New System.Drawing.Point(554, 93)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 19)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Book's Information"
        '
        'txtAccessionID
        '
        Me.txtAccessionID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessionID.Location = New System.Drawing.Point(669, 122)
        Me.txtAccessionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccessionID.Name = "txtAccessionID"
        Me.txtAccessionID.Size = New System.Drawing.Size(389, 22)
        Me.txtAccessionID.TabIndex = 27
        '
        'lblBookID
        '
        Me.lblBookID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(669, 160)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(389, 22)
        Me.lblBookID.TabIndex = 37
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(669, 198)
        Me.lblBookTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(389, 46)
        Me.lblBookTitle.TabIndex = 38
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCategory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(669, 295)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(389, 22)
        Me.lblCategory.TabIndex = 39
        '
        'lblBookPrice
        '
        Me.lblBookPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookPrice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBookPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookPrice.Location = New System.Drawing.Point(669, 325)
        Me.lblBookPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookPrice.Name = "lblBookPrice"
        Me.lblBookPrice.Size = New System.Drawing.Size(389, 22)
        Me.lblBookPrice.TabIndex = 40
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(669, 254)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(389, 22)
        Me.lblAuthor.TabIndex = 41
        '
        'btnBorrow
        '
        Me.btnBorrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBorrow.FlatAppearance.BorderSize = 0
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.White
        Me.btnBorrow.Location = New System.Drawing.Point(870, 393)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(89, 27)
        Me.btnBorrow.TabIndex = 44
        Me.btnBorrow.Text = "&Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(967, 391)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 30)
        Me.btnClear.TabIndex = 45
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'llkBookBrowser
        '
        Me.llkBookBrowser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llkBookBrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llkBookBrowser.Image = CType(resources.GetObject("llkBookBrowser.Image"), System.Drawing.Image)
        Me.llkBookBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llkBookBrowser.LinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.llkBookBrowser.Location = New System.Drawing.Point(861, 87)
        Me.llkBookBrowser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.llkBookBrowser.Name = "llkBookBrowser"
        Me.llkBookBrowser.Size = New System.Drawing.Size(197, 35)
        Me.llkBookBrowser.TabIndex = 51
        Me.llkBookBrowser.TabStop = True
        Me.llkBookBrowser.Text = "Book Browser"
        Me.llkBookBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.llkBookBrowser.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        '
        'lblBookStatus
        '
        Me.lblBookStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBookStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookStatus.Location = New System.Drawing.Point(669, 357)
        Me.lblBookStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookStatus.Name = "lblBookStatus"
        Me.lblBookStatus.Size = New System.Drawing.Size(389, 24)
        Me.lblBookStatus.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(555, 361)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 18)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Status"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDueDate.CustomFormat = "dd/mm/yyyy"
        Me.dtpDueDate.Location = New System.Drawing.Point(669, 398)
        Me.dtpDueDate.MaxDate = New Date(2021, 9, 7, 0, 0, 0, 0)
        Me.dtpDueDate.MinDate = New Date(2021, 9, 7, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(182, 22)
        Me.dtpDueDate.TabIndex = 55
        Me.dtpDueDate.Value = New Date(2021, 9, 7, 0, 0, 0, 0)
        '
        'frmIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1079, 688)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblBookStatus)
        Me.Controls.Add(Me.mskBorrowerID)
        Me.Controls.Add(Me.llkBookBrowser)
        Me.Controls.Add(Me.lblPenalty)
        Me.Controls.Add(Me.lblBooksAllowed)
        Me.Controls.Add(Me.lblDaysAllowed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.llkBook)
        Me.Controls.Add(Me.llkBorrower)
        Me.Controls.Add(Me.dgvIssueReturn)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblBookPrice)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBorrowerStatus)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtAccessionID)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmIR"
        Me.Text = "frmIR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvIssueReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBorrowerStatus As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents dgvIssueReturn As DataGridView
    Friend WithEvents llkBorrower As LinkLabel
    Friend WithEvents llkBook As LinkLabel
    Friend WithEvents lblDaysAllowed As Label
    Friend WithEvents lblBooksAllowed As Label
    Friend WithEvents lblPenalty As Label
    Friend WithEvents btnCloseIR As Button
    Friend WithEvents mskBorrowerID As MaskedTextBox
    Friend WithEvents tooltipError As ToolTip
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtAccessionID As TextBox
    Friend WithEvents lblBookID As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblBookPrice As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents llkBookBrowser As LinkLabel
    Friend WithEvents lblBookStatus As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents colRowNum As DataGridViewTextBoxColumn
    Friend WithEvents colIssueID As DataGridViewTextBoxColumn
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents colDueDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents AccessionID As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerID As DataGridViewTextBoxColumn
End Class
