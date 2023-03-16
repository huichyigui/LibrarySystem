<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabReport = New System.Windows.Forms.TabControl()
        Me.tabBorrowers = New System.Windows.Forms.TabPage()
        Me.cboReportFilter = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGenerateBorrowerReport = New System.Windows.Forms.Button()
        Me.btnViewBorrowerReport = New System.Windows.Forms.Button()
        Me.dgvBorrowersReporting = New System.Windows.Forms.DataGridView()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProgram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabBookInventory = New System.Windows.Forms.TabPage()
        Me.btnInventoryPDF = New System.Windows.Forms.Button()
        Me.btnPrintInventory = New System.Windows.Forms.Button()
        Me.dgvBookInventory = New System.Windows.Forms.DataGridView()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearPublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDamage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAvailableCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCountInventory = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabBookMasterlist = New System.Windows.Forms.TabPage()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMasterlist = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMasterlistPDF = New System.Windows.Forms.Button()
        Me.btnPrintMasterlist = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCountMasterlist = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabIssueRecord = New System.Windows.Forms.TabPage()
        Me.btnSavePDFIssue = New System.Windows.Forms.Button()
        Me.btnPrintIssueRecord = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboIssueStatus = New System.Windows.Forms.ComboBox()
        Me.mskBorrowerID = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvIssueReturn = New System.Windows.Forms.DataGridView()
        Me.colRowNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPayment = New System.Windows.Forms.TabPage()
        Me.btnPDFPayment = New System.Windows.Forms.Button()
        Me.btnPrintPaymentReport = New System.Windows.Forms.Button()
        Me.dgvPaymentList = New System.Windows.Forms.DataGridView()
        Me.Payment_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_Method = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot_paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mskPaymentBorrower = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.tabBorrowers.SuspendLayout()
        CType(Me.dgvBorrowersReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBookInventory.SuspendLayout()
        CType(Me.dgvBookInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.tabBookMasterlist.SuspendLayout()
        CType(Me.dgvMasterlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tabIssueRecord.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvIssueReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayment.SuspendLayout()
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 52)
        Me.Panel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(794, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 26)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports Generation"
        '
        'tabReport
        '
        Me.tabReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabReport.Controls.Add(Me.tabBorrowers)
        Me.tabReport.Controls.Add(Me.tabBookInventory)
        Me.tabReport.Controls.Add(Me.tabBookMasterlist)
        Me.tabReport.Controls.Add(Me.tabIssueRecord)
        Me.tabReport.Controls.Add(Me.tabPayment)
        Me.tabReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabReport.Location = New System.Drawing.Point(16, 58)
        Me.tabReport.Margin = New System.Windows.Forms.Padding(2)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.SelectedIndex = 0
        Me.tabReport.Size = New System.Drawing.Size(870, 559)
        Me.tabReport.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabReport.TabIndex = 10
        '
        'tabBorrowers
        '
        Me.tabBorrowers.Controls.Add(Me.cboReportFilter)
        Me.tabBorrowers.Controls.Add(Me.Label6)
        Me.tabBorrowers.Controls.Add(Me.btnGenerateBorrowerReport)
        Me.tabBorrowers.Controls.Add(Me.btnViewBorrowerReport)
        Me.tabBorrowers.Controls.Add(Me.dgvBorrowersReporting)
        Me.tabBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBorrowers.Location = New System.Drawing.Point(4, 25)
        Me.tabBorrowers.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBorrowers.Name = "tabBorrowers"
        Me.tabBorrowers.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBorrowers.Size = New System.Drawing.Size(862, 530)
        Me.tabBorrowers.TabIndex = 0
        Me.tabBorrowers.Text = "Borrowers"
        Me.tabBorrowers.UseVisualStyleBackColor = True
        '
        'cboReportFilter
        '
        Me.cboReportFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReportFilter.FormattingEnabled = True
        Me.cboReportFilter.Items.AddRange(New Object() {"Shows All", "Shows Only Active Borrowers", "Shows Only Deactivated Borrowers", "Shows Male Borrowers", "Shows Female Borrowers"})
        Me.cboReportFilter.Location = New System.Drawing.Point(101, 11)
        Me.cboReportFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.cboReportFilter.Name = "cboReportFilter"
        Me.cboReportFilter.Size = New System.Drawing.Size(292, 24)
        Me.cboReportFilter.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Report Filter:"
        '
        'btnGenerateBorrowerReport
        '
        Me.btnGenerateBorrowerReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateBorrowerReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnGenerateBorrowerReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateBorrowerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateBorrowerReport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateBorrowerReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateBorrowerReport.Location = New System.Drawing.Point(748, 15)
        Me.btnGenerateBorrowerReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerateBorrowerReport.Name = "btnGenerateBorrowerReport"
        Me.btnGenerateBorrowerReport.Size = New System.Drawing.Size(100, 26)
        Me.btnGenerateBorrowerReport.TabIndex = 16
        Me.btnGenerateBorrowerReport.Text = "&Save As PDF"
        Me.btnGenerateBorrowerReport.UseVisualStyleBackColor = False
        '
        'btnViewBorrowerReport
        '
        Me.btnViewBorrowerReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewBorrowerReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnViewBorrowerReport.FlatAppearance.BorderSize = 0
        Me.btnViewBorrowerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBorrowerReport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBorrowerReport.ForeColor = System.Drawing.Color.White
        Me.btnViewBorrowerReport.Location = New System.Drawing.Point(613, 15)
        Me.btnViewBorrowerReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewBorrowerReport.Name = "btnViewBorrowerReport"
        Me.btnViewBorrowerReport.Size = New System.Drawing.Size(100, 26)
        Me.btnViewBorrowerReport.TabIndex = 15
        Me.btnViewBorrowerReport.Text = "&Preview / Print"
        Me.btnViewBorrowerReport.UseVisualStyleBackColor = False
        '
        'dgvBorrowersReporting
        '
        Me.dgvBorrowersReporting.AllowUserToAddRows = False
        Me.dgvBorrowersReporting.AllowUserToDeleteRows = False
        Me.dgvBorrowersReporting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrowersReporting.BackgroundColor = System.Drawing.Color.White
        Me.dgvBorrowersReporting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBorrowersReporting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowersReporting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrowersReporting.ColumnHeadersHeight = 31
        Me.dgvBorrowersReporting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBorrowersReporting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.colBorrowerID, Me.colName, Me.colProgram, Me.colDOB, Me.colGender, Me.colContact, Me.colEmail, Me.colStatus})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowersReporting.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBorrowersReporting.EnableHeadersVisualStyles = False
        Me.dgvBorrowersReporting.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBorrowersReporting.Location = New System.Drawing.Point(8, 56)
        Me.dgvBorrowersReporting.Name = "dgvBorrowersReporting"
        Me.dgvBorrowersReporting.ReadOnly = True
        Me.dgvBorrowersReporting.RowHeadersVisible = False
        Me.dgvBorrowersReporting.RowHeadersWidth = 49
        Me.dgvBorrowersReporting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBorrowersReporting.RowTemplate.Height = 25
        Me.dgvBorrowersReporting.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowersReporting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowersReporting.Size = New System.Drawing.Size(851, 460)
        Me.dgvBorrowersReporting.TabIndex = 7
        '
        'ColRowNo
        '
        Me.ColRowNo.HeaderText = "#"
        Me.ColRowNo.MinimumWidth = 6
        Me.ColRowNo.Name = "ColRowNo"
        Me.ColRowNo.ReadOnly = True
        Me.ColRowNo.Width = 40
        '
        'colBorrowerID
        '
        Me.colBorrowerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBorrowerID.HeaderText = "Borrower ID"
        Me.colBorrowerID.MinimumWidth = 6
        Me.colBorrowerID.Name = "colBorrowerID"
        Me.colBorrowerID.ReadOnly = True
        Me.colBorrowerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBorrowerID.Width = 137
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 6
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colProgram
        '
        Me.colProgram.HeaderText = "Program"
        Me.colProgram.MinimumWidth = 6
        Me.colProgram.Name = "colProgram"
        Me.colProgram.ReadOnly = True
        Me.colProgram.Width = 120
        '
        'colDOB
        '
        Me.colDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDOB.HeaderText = "DOB"
        Me.colDOB.MinimumWidth = 6
        Me.colDOB.Name = "colDOB"
        Me.colDOB.ReadOnly = True
        Me.colDOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDOB.Width = 69
        '
        'colGender
        '
        Me.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGender.HeaderText = "Gender"
        Me.colGender.MinimumWidth = 6
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colGender.Width = 93
        '
        'colContact
        '
        Me.colContact.HeaderText = "Contact"
        Me.colContact.MinimumWidth = 6
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colContact.Width = 120
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.MinimumWidth = 6
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colStatus
        '
        Me.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colStatus.Width = 83
        '
        'tabBookInventory
        '
        Me.tabBookInventory.Controls.Add(Me.btnInventoryPDF)
        Me.tabBookInventory.Controls.Add(Me.btnPrintInventory)
        Me.tabBookInventory.Controls.Add(Me.dgvBookInventory)
        Me.tabBookInventory.Controls.Add(Me.Panel3)
        Me.tabBookInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBookInventory.Location = New System.Drawing.Point(4, 25)
        Me.tabBookInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBookInventory.Name = "tabBookInventory"
        Me.tabBookInventory.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBookInventory.Size = New System.Drawing.Size(862, 530)
        Me.tabBookInventory.TabIndex = 1
        Me.tabBookInventory.Text = "Book Inventory"
        Me.tabBookInventory.UseVisualStyleBackColor = True
        '
        'btnInventoryPDF
        '
        Me.btnInventoryPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventoryPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnInventoryPDF.FlatAppearance.BorderSize = 0
        Me.btnInventoryPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryPDF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryPDF.ForeColor = System.Drawing.Color.White
        Me.btnInventoryPDF.Location = New System.Drawing.Point(746, 9)
        Me.btnInventoryPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventoryPDF.Name = "btnInventoryPDF"
        Me.btnInventoryPDF.Size = New System.Drawing.Size(100, 26)
        Me.btnInventoryPDF.TabIndex = 23
        Me.btnInventoryPDF.Text = "&Save As PDF"
        Me.btnInventoryPDF.UseVisualStyleBackColor = False
        '
        'btnPrintInventory
        '
        Me.btnPrintInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrintInventory.FlatAppearance.BorderSize = 0
        Me.btnPrintInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintInventory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintInventory.ForeColor = System.Drawing.Color.White
        Me.btnPrintInventory.Location = New System.Drawing.Point(600, 9)
        Me.btnPrintInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintInventory.Name = "btnPrintInventory"
        Me.btnPrintInventory.Size = New System.Drawing.Size(114, 26)
        Me.btnPrintInventory.TabIndex = 22
        Me.btnPrintInventory.Text = "&Preview / Print"
        Me.btnPrintInventory.UseVisualStyleBackColor = False
        '
        'dgvBookInventory
        '
        Me.dgvBookInventory.AllowUserToAddRows = False
        Me.dgvBookInventory.AllowUserToDeleteRows = False
        Me.dgvBookInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBookInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBookInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBookInventory.ColumnHeadersHeight = 35
        Me.dgvBookInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBookInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colBookID, Me.colBookTitle, Me.colAuthor, Me.colYearPublished, Me.colTotalCopies, Me.colDamage, Me.colLost, Me.colBorrowed, Me.colAvailableCopies})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookInventory.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBookInventory.EnableHeadersVisualStyles = False
        Me.dgvBookInventory.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBookInventory.Location = New System.Drawing.Point(6, 50)
        Me.dgvBookInventory.Name = "dgvBookInventory"
        Me.dgvBookInventory.ReadOnly = True
        Me.dgvBookInventory.RowHeadersVisible = False
        Me.dgvBookInventory.RowHeadersWidth = 49
        Me.dgvBookInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBookInventory.RowTemplate.Height = 25
        Me.dgvBookInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookInventory.Size = New System.Drawing.Size(851, 433)
        Me.dgvBookInventory.TabIndex = 21
        '
        'colNum
        '
        Me.colNum.HeaderText = "#"
        Me.colNum.MinimumWidth = 6
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.Width = 40
        '
        'colBookID
        '
        Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBookID.HeaderText = "Book ID"
        Me.colBookID.MinimumWidth = 6
        Me.colBookID.Name = "colBookID"
        Me.colBookID.ReadOnly = True
        Me.colBookID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBookID.Width = 99
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
        'colAuthor
        '
        Me.colAuthor.HeaderText = "Author"
        Me.colAuthor.MinimumWidth = 6
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.ReadOnly = True
        Me.colAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAuthor.Width = 120
        '
        'colYearPublished
        '
        Me.colYearPublished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colYearPublished.HeaderText = "Year Published"
        Me.colYearPublished.MinimumWidth = 6
        Me.colYearPublished.Name = "colYearPublished"
        Me.colYearPublished.ReadOnly = True
        Me.colYearPublished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colYearPublished.Width = 170
        '
        'colTotalCopies
        '
        Me.colTotalCopies.HeaderText = "Total Copies"
        Me.colTotalCopies.MinimumWidth = 6
        Me.colTotalCopies.Name = "colTotalCopies"
        Me.colTotalCopies.ReadOnly = True
        Me.colTotalCopies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTotalCopies.Width = 80
        '
        'colDamage
        '
        Me.colDamage.HeaderText = "Damaged"
        Me.colDamage.MinimumWidth = 6
        Me.colDamage.Name = "colDamage"
        Me.colDamage.ReadOnly = True
        Me.colDamage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDamage.Width = 80
        '
        'colLost
        '
        Me.colLost.HeaderText = "Lost"
        Me.colLost.MinimumWidth = 6
        Me.colLost.Name = "colLost"
        Me.colLost.ReadOnly = True
        Me.colLost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colLost.Width = 80
        '
        'colBorrowed
        '
        Me.colBorrowed.HeaderText = "Borrowed"
        Me.colBorrowed.MinimumWidth = 6
        Me.colBorrowed.Name = "colBorrowed"
        Me.colBorrowed.ReadOnly = True
        Me.colBorrowed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBorrowed.Width = 80
        '
        'colAvailableCopies
        '
        Me.colAvailableCopies.HeaderText = "Available Copies"
        Me.colAvailableCopies.MinimumWidth = 6
        Me.colAvailableCopies.Name = "colAvailableCopies"
        Me.colAvailableCopies.ReadOnly = True
        Me.colAvailableCopies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAvailableCopies.Width = 80
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblCountInventory)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(2, 498)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 30)
        Me.Panel3.TabIndex = 24
        '
        'lblCountInventory
        '
        Me.lblCountInventory.BackColor = System.Drawing.Color.Transparent
        Me.lblCountInventory.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblCountInventory.Location = New System.Drawing.Point(132, 7)
        Me.lblCountInventory.Name = "lblCountInventory"
        Me.lblCountInventory.Size = New System.Drawing.Size(73, 15)
        Me.lblCountInventory.TabIndex = 1
        Me.lblCountInventory.Text = "0"
        Me.lblCountInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Record(s) Found :"
        '
        'tabBookMasterlist
        '
        Me.tabBookMasterlist.Controls.Add(Me.cboStatus)
        Me.tabBookMasterlist.Controls.Add(Me.Label10)
        Me.tabBookMasterlist.Controls.Add(Me.txtSearch)
        Me.tabBookMasterlist.Controls.Add(Me.Label7)
        Me.tabBookMasterlist.Controls.Add(Me.Label5)
        Me.tabBookMasterlist.Controls.Add(Me.Label4)
        Me.tabBookMasterlist.Controls.Add(Me.Label3)
        Me.tabBookMasterlist.Controls.Add(Me.Label2)
        Me.tabBookMasterlist.Controls.Add(Me.dgvMasterlist)
        Me.tabBookMasterlist.Controls.Add(Me.btnMasterlistPDF)
        Me.tabBookMasterlist.Controls.Add(Me.btnPrintMasterlist)
        Me.tabBookMasterlist.Controls.Add(Me.Panel4)
        Me.tabBookMasterlist.Location = New System.Drawing.Point(4, 25)
        Me.tabBookMasterlist.Name = "tabBookMasterlist"
        Me.tabBookMasterlist.Size = New System.Drawing.Size(862, 530)
        Me.tabBookMasterlist.TabIndex = 2
        Me.tabBookMasterlist.Text = "Book Masterlist"
        Me.tabBookMasterlist.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Shows All", "Shows Available", "Shows Borrowed", "Shows Damaged", "Shows Lost"})
        Me.cboStatus.Location = New System.Drawing.Point(70, 44)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(161, 24)
        Me.cboStatus.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(444, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Book Title"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(544, 44)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(302, 26)
        Me.txtSearch.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "AVAILABLE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(118, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "BORROWED"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(330, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "LOST"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(224, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "DAMAGED"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMasterlist
        '
        Me.dgvMasterlist.AllowUserToAddRows = False
        Me.dgvMasterlist.AllowUserToDeleteRows = False
        Me.dgvMasterlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMasterlist.BackgroundColor = System.Drawing.Color.White
        Me.dgvMasterlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMasterlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMasterlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMasterlist.ColumnHeadersHeight = 35
        Me.dgvMasterlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMasterlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colAccessionNo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.colPublisher, Me.colCategory, Me.colPrice, Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMasterlist.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMasterlist.EnableHeadersVisualStyles = False
        Me.dgvMasterlist.GridColor = System.Drawing.SystemColors.Control
        Me.dgvMasterlist.Location = New System.Drawing.Point(6, 78)
        Me.dgvMasterlist.Name = "dgvMasterlist"
        Me.dgvMasterlist.ReadOnly = True
        Me.dgvMasterlist.RowHeadersVisible = False
        Me.dgvMasterlist.RowHeadersWidth = 49
        Me.dgvMasterlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMasterlist.RowTemplate.Height = 25
        Me.dgvMasterlist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMasterlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMasterlist.Size = New System.Drawing.Size(851, 404)
        Me.dgvMasterlist.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'colAccessionNo
        '
        Me.colAccessionNo.HeaderText = "Accession No"
        Me.colAccessionNo.MinimumWidth = 6
        Me.colAccessionNo.Name = "colAccessionNo"
        Me.colAccessionNo.ReadOnly = True
        Me.colAccessionNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAccessionNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAccessionNo.Width = 105
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Book ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Book Title"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Author"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Year Published"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'colPublisher
        '
        Me.colPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPublisher.HeaderText = "Publisher"
        Me.colPublisher.MinimumWidth = 6
        Me.colPublisher.Name = "colPublisher"
        Me.colPublisher.ReadOnly = True
        Me.colPublisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPublisher.Width = 76
        '
        'colCategory
        '
        Me.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.MinimumWidth = 6
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCategory.Width = 74
        '
        'colPrice
        '
        Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPrice.HeaderText = "Price (RM)"
        Me.colPrice.MinimumWidth = 6
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPrice.Width = 84
        '
        'Column1
        '
        Me.Column1.HeaderText = "Status"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 120
        '
        'btnMasterlistPDF
        '
        Me.btnMasterlistPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMasterlistPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnMasterlistPDF.FlatAppearance.BorderSize = 0
        Me.btnMasterlistPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasterlistPDF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterlistPDF.ForeColor = System.Drawing.Color.White
        Me.btnMasterlistPDF.Location = New System.Drawing.Point(746, 8)
        Me.btnMasterlistPDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMasterlistPDF.Name = "btnMasterlistPDF"
        Me.btnMasterlistPDF.Size = New System.Drawing.Size(100, 26)
        Me.btnMasterlistPDF.TabIndex = 27
        Me.btnMasterlistPDF.Text = "&Save As PDF"
        Me.btnMasterlistPDF.UseVisualStyleBackColor = False
        '
        'btnPrintMasterlist
        '
        Me.btnPrintMasterlist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintMasterlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrintMasterlist.FlatAppearance.BorderSize = 0
        Me.btnPrintMasterlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintMasterlist.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintMasterlist.ForeColor = System.Drawing.Color.White
        Me.btnPrintMasterlist.Location = New System.Drawing.Point(601, 8)
        Me.btnPrintMasterlist.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintMasterlist.Name = "btnPrintMasterlist"
        Me.btnPrintMasterlist.Size = New System.Drawing.Size(110, 26)
        Me.btnPrintMasterlist.TabIndex = 26
        Me.btnPrintMasterlist.Text = "&Preview / Print"
        Me.btnPrintMasterlist.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblCountMasterlist)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 500)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(862, 30)
        Me.Panel4.TabIndex = 33
        '
        'lblCountMasterlist
        '
        Me.lblCountMasterlist.BackColor = System.Drawing.Color.Transparent
        Me.lblCountMasterlist.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountMasterlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblCountMasterlist.Location = New System.Drawing.Point(132, 7)
        Me.lblCountMasterlist.Name = "lblCountMasterlist"
        Me.lblCountMasterlist.Size = New System.Drawing.Size(73, 15)
        Me.lblCountMasterlist.TabIndex = 1
        Me.lblCountMasterlist.Text = "0"
        Me.lblCountMasterlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Record(s) Found :"
        '
        'tabIssueRecord
        '
        Me.tabIssueRecord.Controls.Add(Me.btnSavePDFIssue)
        Me.tabIssueRecord.Controls.Add(Me.btnPrintIssueRecord)
        Me.tabIssueRecord.Controls.Add(Me.GroupBox1)
        Me.tabIssueRecord.Controls.Add(Me.dgvIssueReturn)
        Me.tabIssueRecord.Location = New System.Drawing.Point(4, 25)
        Me.tabIssueRecord.Name = "tabIssueRecord"
        Me.tabIssueRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIssueRecord.Size = New System.Drawing.Size(862, 530)
        Me.tabIssueRecord.TabIndex = 3
        Me.tabIssueRecord.Text = "Issue Reports"
        Me.tabIssueRecord.UseVisualStyleBackColor = True
        '
        'btnSavePDFIssue
        '
        Me.btnSavePDFIssue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSavePDFIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSavePDFIssue.FlatAppearance.BorderSize = 0
        Me.btnSavePDFIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePDFIssue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePDFIssue.ForeColor = System.Drawing.Color.White
        Me.btnSavePDFIssue.Location = New System.Drawing.Point(711, 49)
        Me.btnSavePDFIssue.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSavePDFIssue.Name = "btnSavePDFIssue"
        Me.btnSavePDFIssue.Size = New System.Drawing.Size(100, 26)
        Me.btnSavePDFIssue.TabIndex = 47
        Me.btnSavePDFIssue.Text = "&Save As PDF"
        Me.btnSavePDFIssue.UseVisualStyleBackColor = False
        '
        'btnPrintIssueRecord
        '
        Me.btnPrintIssueRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintIssueRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrintIssueRecord.FlatAppearance.BorderSize = 0
        Me.btnPrintIssueRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintIssueRecord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintIssueRecord.ForeColor = System.Drawing.Color.White
        Me.btnPrintIssueRecord.Location = New System.Drawing.Point(578, 49)
        Me.btnPrintIssueRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintIssueRecord.Name = "btnPrintIssueRecord"
        Me.btnPrintIssueRecord.Size = New System.Drawing.Size(110, 26)
        Me.btnPrintIssueRecord.TabIndex = 46
        Me.btnPrintIssueRecord.Text = "&Preview / Print"
        Me.btnPrintIssueRecord.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboIssueStatus)
        Me.GroupBox1.Controls.Add(Me.mskBorrowerID)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 100)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort"
        '
        'cboIssueStatus
        '
        Me.cboIssueStatus.FormattingEnabled = True
        Me.cboIssueStatus.Items.AddRange(New Object() {"All", "Returned", "Borrowed", "Lost", "Damaged"})
        Me.cboIssueStatus.Location = New System.Drawing.Point(112, 15)
        Me.cboIssueStatus.Name = "cboIssueStatus"
        Me.cboIssueStatus.Size = New System.Drawing.Size(140, 24)
        Me.cboIssueStatus.TabIndex = 48
        '
        'mskBorrowerID
        '
        Me.mskBorrowerID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskBorrowerID.Location = New System.Drawing.Point(112, 48)
        Me.mskBorrowerID.Mask = "99???99999"
        Me.mskBorrowerID.Name = "mskBorrowerID"
        Me.mskBorrowerID.Size = New System.Drawing.Size(140, 23)
        Me.mskBorrowerID.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 18)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Borrower ID:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Status:"
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssueReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvIssueReturn.ColumnHeadersHeight = 31
        Me.dgvIssueReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIssueReturn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRowNum, Me.DataGridViewTextBoxColumn7, Me.colBorrowDate, Me.DataGridViewTextBoxColumn8, Me.AccessionID, Me.BorrowerID})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssueReturn.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvIssueReturn.EnableHeadersVisualStyles = False
        Me.dgvIssueReturn.GridColor = System.Drawing.SystemColors.Control
        Me.dgvIssueReturn.Location = New System.Drawing.Point(7, 116)
        Me.dgvIssueReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIssueReturn.Name = "dgvIssueReturn"
        Me.dgvIssueReturn.ReadOnly = True
        Me.dgvIssueReturn.RowHeadersVisible = False
        Me.dgvIssueReturn.RowHeadersWidth = 49
        Me.dgvIssueReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssueReturn.RowTemplate.Height = 25
        Me.dgvIssueReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssueReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIssueReturn.Size = New System.Drawing.Size(843, 327)
        Me.dgvIssueReturn.TabIndex = 44
        '
        'colRowNum
        '
        Me.colRowNum.HeaderText = "#"
        Me.colRowNum.MinimumWidth = 6
        Me.colRowNum.Name = "colRowNum"
        Me.colRowNum.ReadOnly = True
        Me.colRowNum.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.HeaderText = "Book Title"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colBorrowDate
        '
        Me.colBorrowDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBorrowDate.HeaderText = "Date Borrowed"
        Me.colBorrowDate.Name = "colBorrowDate"
        Me.colBorrowDate.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Return Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
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
        'tabPayment
        '
        Me.tabPayment.Controls.Add(Me.btnPDFPayment)
        Me.tabPayment.Controls.Add(Me.btnPrintPaymentReport)
        Me.tabPayment.Controls.Add(Me.dgvPaymentList)
        Me.tabPayment.Controls.Add(Me.GroupBox2)
        Me.tabPayment.Location = New System.Drawing.Point(4, 25)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPayment.Size = New System.Drawing.Size(862, 530)
        Me.tabPayment.TabIndex = 4
        Me.tabPayment.Text = "Payment History"
        Me.tabPayment.UseVisualStyleBackColor = True
        '
        'btnPDFPayment
        '
        Me.btnPDFPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDFPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPDFPayment.FlatAppearance.BorderSize = 0
        Me.btnPDFPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFPayment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPDFPayment.ForeColor = System.Drawing.Color.White
        Me.btnPDFPayment.Location = New System.Drawing.Point(726, 57)
        Me.btnPDFPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPDFPayment.Name = "btnPDFPayment"
        Me.btnPDFPayment.Size = New System.Drawing.Size(100, 26)
        Me.btnPDFPayment.TabIndex = 49
        Me.btnPDFPayment.Text = "&Save As PDF"
        Me.btnPDFPayment.UseVisualStyleBackColor = False
        '
        'btnPrintPaymentReport
        '
        Me.btnPrintPaymentReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintPaymentReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrintPaymentReport.FlatAppearance.BorderSize = 0
        Me.btnPrintPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPaymentReport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPaymentReport.ForeColor = System.Drawing.Color.White
        Me.btnPrintPaymentReport.Location = New System.Drawing.Point(595, 57)
        Me.btnPrintPaymentReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintPaymentReport.Name = "btnPrintPaymentReport"
        Me.btnPrintPaymentReport.Size = New System.Drawing.Size(110, 26)
        Me.btnPrintPaymentReport.TabIndex = 48
        Me.btnPrintPaymentReport.Text = "&Preview / Print"
        Me.btnPrintPaymentReport.UseVisualStyleBackColor = False
        '
        'dgvPaymentList
        '
        Me.dgvPaymentList.AllowUserToAddRows = False
        Me.dgvPaymentList.AllowUserToDeleteRows = False
        Me.dgvPaymentList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPaymentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaymentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPaymentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaymentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPaymentList.ColumnHeadersHeight = 31
        Me.dgvPaymentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPaymentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Payment_no, Me.DataGridViewTextBoxColumn6, Me.Description, Me.Payment_Method, Me.Payment_date, Me.tot_paid})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentList.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPaymentList.EnableHeadersVisualStyles = False
        Me.dgvPaymentList.GridColor = System.Drawing.SystemColors.Control
        Me.dgvPaymentList.Location = New System.Drawing.Point(23, 90)
        Me.dgvPaymentList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPaymentList.Name = "dgvPaymentList"
        Me.dgvPaymentList.ReadOnly = True
        Me.dgvPaymentList.RowHeadersVisible = False
        Me.dgvPaymentList.RowHeadersWidth = 49
        Me.dgvPaymentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPaymentList.RowTemplate.Height = 25
        Me.dgvPaymentList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPaymentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentList.Size = New System.Drawing.Size(820, 389)
        Me.dgvPaymentList.TabIndex = 47
        '
        'Payment_no
        '
        Me.Payment_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Payment_no.HeaderText = "Payment No."
        Me.Payment_no.Name = "Payment_no"
        Me.Payment_no.ReadOnly = True
        Me.Payment_no.Width = 117
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.HeaderText = "Borrower ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Payment_Method
        '
        Me.Payment_Method.HeaderText = "Payment Method"
        Me.Payment_Method.Name = "Payment_Method"
        Me.Payment_Method.ReadOnly = True
        '
        'Payment_date
        '
        Me.Payment_date.HeaderText = "Date"
        Me.Payment_date.Name = "Payment_date"
        Me.Payment_date.ReadOnly = True
        '
        'tot_paid
        '
        Me.tot_paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tot_paid.HeaderText = "Total Paid"
        Me.tot_paid.Name = "tot_paid"
        Me.tot_paid.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.mskPaymentBorrower)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 67)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'mskPaymentBorrower
        '
        Me.mskPaymentBorrower.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskPaymentBorrower.Location = New System.Drawing.Point(132, 24)
        Me.mskPaymentBorrower.Mask = "99???99999"
        Me.mskPaymentBorrower.Name = "mskPaymentBorrower"
        Me.mskPaymentBorrower.Size = New System.Drawing.Size(203, 23)
        Me.mskPaymentBorrower.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(28, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 18)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Borrower ID:"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(904, 638)
        Me.Controls.Add(Me.tabReport)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(904, 638)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabReport.ResumeLayout(False)
        Me.tabBorrowers.ResumeLayout(False)
        CType(Me.dgvBorrowersReporting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBookInventory.ResumeLayout(False)
        CType(Me.dgvBookInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.tabBookMasterlist.ResumeLayout(False)
        Me.tabBookMasterlist.PerformLayout()
        CType(Me.dgvMasterlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.tabIssueRecord.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvIssueReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayment.ResumeLayout(False)
        CType(Me.dgvPaymentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents tabReport As TabControl
    Friend WithEvents tabBorrowers As TabPage
    Friend WithEvents tabBookInventory As TabPage
    Friend WithEvents dgvBorrowersReporting As DataGridView
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colProgram As DataGridViewTextBoxColumn
    Friend WithEvents colDOB As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnViewBorrowerReport As Button
    Friend WithEvents btnGenerateBorrowerReport As Button
    Friend WithEvents btnInventoryPDF As Button
    Friend WithEvents btnPrintInventory As Button
    Friend WithEvents dgvBookInventory As DataGridView
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colYearPublished As DataGridViewTextBoxColumn
    Friend WithEvents colTotalCopies As DataGridViewTextBoxColumn
    Friend WithEvents colDamage As DataGridViewTextBoxColumn
    Friend WithEvents colLost As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowed As DataGridViewTextBoxColumn
    Friend WithEvents colAvailableCopies As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCountInventory As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tabBookMasterlist As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMasterlist As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colAccessionNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents colPublisher As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btnMasterlistPDF As Button
    Friend WithEvents btnPrintMasterlist As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCountMasterlist As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboReportFilter As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents tabIssueRecord As TabPage
    Friend WithEvents btnSavePDFIssue As Button
    Friend WithEvents btnPrintIssueRecord As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mskBorrowerID As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboIssueStatus As ComboBox
    Friend WithEvents dgvIssueReturn As DataGridView
    Friend WithEvents colRowNum As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents AccessionID As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerID As DataGridViewTextBoxColumn
    Friend WithEvents tabPayment As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvPaymentList As DataGridView
    Friend WithEvents Payment_no As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Payment_Method As DataGridViewTextBoxColumn
    Friend WithEvents Payment_date As DataGridViewTextBoxColumn
    Friend WithEvents tot_paid As DataGridViewTextBoxColumn
    Friend WithEvents btnPDFPayment As Button
    Friend WithEvents btnPrintPaymentReport As Button
    Friend WithEvents mskPaymentBorrower As MaskedTextBox
    Friend WithEvents Label15 As Label
End Class
