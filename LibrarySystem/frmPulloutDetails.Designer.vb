<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPulloutDetails
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPulloutDetails))
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearPublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboAction = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblAccessionNo = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblYearPublished = New System.Windows.Forms.Label()
        Me.lblBookPrice = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblProgram = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPullout = New System.Windows.Forms.Button()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBook
        '
        Me.dgvBook.AllowUserToAddRows = False
        Me.dgvBook.AllowUserToDeleteRows = False
        Me.dgvBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvBook.BackgroundColor = System.Drawing.Color.White
        Me.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBook.ColumnHeadersHeight = 31
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.colBookID, Me.colAccessionNo, Me.colBookTitle, Me.colAuthor, Me.colCategory, Me.colYearPublished, Me.colPublisher, Me.colBookPrice, Me.colSelect})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBook.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBook.EnableHeadersVisualStyles = False
        Me.dgvBook.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBook.Location = New System.Drawing.Point(12, 76)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.RowHeadersVisible = False
        Me.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBook.RowTemplate.Height = 25
        Me.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBook.Size = New System.Drawing.Size(383, 373)
        Me.dgvBook.TabIndex = 3
        '
        'ColRowNo
        '
        Me.ColRowNo.HeaderText = "#"
        Me.ColRowNo.Name = "ColRowNo"
        Me.ColRowNo.ReadOnly = True
        Me.ColRowNo.Width = 40
        '
        'colBookID
        '
        Me.colBookID.HeaderText = "Book ID"
        Me.colBookID.Name = "colBookID"
        Me.colBookID.ReadOnly = True
        Me.colBookID.Visible = False
        '
        'colAccessionNo
        '
        Me.colAccessionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAccessionNo.HeaderText = "Accession No"
        Me.colAccessionNo.Name = "colAccessionNo"
        Me.colAccessionNo.ReadOnly = True
        Me.colAccessionNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAccessionNo.Width = 89
        '
        'colBookTitle
        '
        Me.colBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBookTitle.HeaderText = "Book Title"
        Me.colBookTitle.Name = "colBookTitle"
        Me.colBookTitle.ReadOnly = True
        Me.colBookTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAuthor
        '
        Me.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAuthor.HeaderText = "Author"
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.ReadOnly = True
        Me.colAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAuthor.Visible = False
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCategory.Visible = False
        '
        'colYearPublished
        '
        Me.colYearPublished.HeaderText = "Year Published"
        Me.colYearPublished.Name = "colYearPublished"
        Me.colYearPublished.ReadOnly = True
        Me.colYearPublished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colYearPublished.Visible = False
        '
        'colPublisher
        '
        Me.colPublisher.HeaderText = "Publisher"
        Me.colPublisher.Name = "colPublisher"
        Me.colPublisher.ReadOnly = True
        Me.colPublisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPublisher.Visible = False
        '
        'colBookPrice
        '
        Me.colBookPrice.HeaderText = "Book Price"
        Me.colBookPrice.Name = "colBookPrice"
        Me.colBookPrice.ReadOnly = True
        Me.colBookPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBookPrice.Visible = False
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSelect.HeaderText = ""
        Me.colSelect.Image = CType(resources.GetObject("colSelect.Image"), System.Drawing.Image)
        Me.colSelect.Name = "colSelect"
        Me.colSelect.ReadOnly = True
        Me.colSelect.Width = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(93, 44)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(302, 26)
        Me.txtSearch.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Book ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Book List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Book Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Accession No"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Book Price(RM)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Year Published"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(416, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Publisher"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(416, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Author"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(416, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Book Title"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(416, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(796, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(797, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Last Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(796, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Contact"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(796, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 19)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Program"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(906, 278)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(240, 72)
        Me.txtRemarks.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(796, 280)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 45)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "&Remarks (If any)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(796, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "First Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(796, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 19)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Borrower Details"
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(906, 54)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(240, 26)
        Me.txtBorrowerID.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(796, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 19)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "&Borrower ID*"
        '
        'cboAction
        '
        Me.cboAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAction.FormattingEnabled = True
        Me.cboAction.Items.AddRange(New Object() {"Damaged", "Lost"})
        Me.cboAction.Location = New System.Drawing.Point(906, 246)
        Me.cboAction.Name = "cboAction"
        Me.cboAction.Size = New System.Drawing.Size(240, 26)
        Me.cboAction.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(797, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 19)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "&Action*"
        '
        'lblBookID
        '
        Me.lblBookID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(526, 51)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(240, 26)
        Me.lblBookID.TabIndex = 6
        Me.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAccessionNo
        '
        Me.lblAccessionNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAccessionNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAccessionNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessionNo.Location = New System.Drawing.Point(526, 83)
        Me.lblAccessionNo.Name = "lblAccessionNo"
        Me.lblAccessionNo.Size = New System.Drawing.Size(240, 26)
        Me.lblAccessionNo.TabIndex = 8
        Me.lblAccessionNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookTitle
        '
        Me.lblBookTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookTitle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(526, 118)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(240, 72)
        Me.lblBookTitle.TabIndex = 10
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(526, 195)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(240, 26)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(526, 227)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(240, 26)
        Me.lblAuthor.TabIndex = 14
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisher
        '
        Me.lblPublisher.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPublisher.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.Location = New System.Drawing.Point(526, 259)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(240, 26)
        Me.lblPublisher.TabIndex = 16
        Me.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYearPublished
        '
        Me.lblYearPublished.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblYearPublished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearPublished.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearPublished.Location = New System.Drawing.Point(526, 291)
        Me.lblYearPublished.Name = "lblYearPublished"
        Me.lblYearPublished.Size = New System.Drawing.Size(240, 26)
        Me.lblYearPublished.TabIndex = 18
        Me.lblYearPublished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBookPrice
        '
        Me.lblBookPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBookPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookPrice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookPrice.Location = New System.Drawing.Point(526, 323)
        Me.lblBookPrice.Name = "lblBookPrice"
        Me.lblBookPrice.Size = New System.Drawing.Size(240, 26)
        Me.lblBookPrice.TabIndex = 20
        Me.lblBookPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFName
        '
        Me.lblFName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFName.Location = New System.Drawing.Point(906, 86)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(240, 26)
        Me.lblFName.TabIndex = 25
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLName
        '
        Me.lblLName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLName.Location = New System.Drawing.Point(906, 118)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(240, 26)
        Me.lblLName.TabIndex = 27
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Location = New System.Drawing.Point(906, 149)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(240, 26)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContact.Location = New System.Drawing.Point(906, 181)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(240, 26)
        Me.lblContact.TabIndex = 32
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProgram
        '
        Me.lblProgram.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProgram.Location = New System.Drawing.Point(906, 213)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(240, 26)
        Me.lblProgram.TabIndex = 34
        Me.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorker1
        '
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1046, 377)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 26)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPullout
        '
        Me.btnPullout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPullout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPullout.FlatAppearance.BorderSize = 0
        Me.btnPullout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPullout.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPullout.ForeColor = System.Drawing.Color.White
        Me.btnPullout.Location = New System.Drawing.Point(928, 378)
        Me.btnPullout.Name = "btnPullout"
        Me.btnPullout.Size = New System.Drawing.Size(112, 26)
        Me.btnPullout.TabIndex = 39
        Me.btnPullout.Text = "&Pull Out Book"
        Me.btnPullout.UseVisualStyleBackColor = False
        '
        'frmPulloutDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 461)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPullout)
        Me.Controls.Add(Me.lblProgram)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblBookPrice)
        Me.Controls.Add(Me.lblYearPublished)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblAccessionNo)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboAction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.Label20)
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
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPulloutDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pull-Out Details"
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBook As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colAccessionNo As DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colYearPublished As DataGridViewTextBoxColumn
    Friend WithEvents colPublisher As DataGridViewTextBoxColumn
    Friend WithEvents colBookPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSelect As DataGridViewImageColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBorrowerID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cboAction As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents lblAccessionNo As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents lblYearPublished As Label
    Friend WithEvents lblBookPrice As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPullout As Button
End Class
