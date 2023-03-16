<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookAcquired
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookAcquired))
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBookAcquired = New System.Windows.Forms.DataGridView()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearPublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudCopies = New System.Windows.Forms.NumericUpDown()
        Me.btnAddCopies = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBookAcquired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(150, 7)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(73, 15)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Record(s) Found :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 597)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(933, 30)
        Me.Panel2.TabIndex = 7
        '
        'dgvBookAcquired
        '
        Me.dgvBookAcquired.AllowUserToAddRows = False
        Me.dgvBookAcquired.AllowUserToDeleteRows = False
        Me.dgvBookAcquired.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvBookAcquired.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookAcquired.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBookAcquired.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookAcquired.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookAcquired.ColumnHeadersHeight = 31
        Me.dgvBookAcquired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBookAcquired.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.colBookID, Me.colBookTitle, Me.colAuthor, Me.colCategory, Me.colYearPublished, Me.colPublisher, Me.colBookPrice, Me.colSelect})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookAcquired.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBookAcquired.EnableHeadersVisualStyles = False
        Me.dgvBookAcquired.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBookAcquired.Location = New System.Drawing.Point(12, 58)
        Me.dgvBookAcquired.Name = "dgvBookAcquired"
        Me.dgvBookAcquired.ReadOnly = True
        Me.dgvBookAcquired.RowHeadersVisible = False
        Me.dgvBookAcquired.RowHeadersWidth = 49
        Me.dgvBookAcquired.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBookAcquired.RowTemplate.Height = 25
        Me.dgvBookAcquired.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookAcquired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookAcquired.Size = New System.Drawing.Size(469, 533)
        Me.dgvBookAcquired.TabIndex = 1
        '
        'ColRowNo
        '
        Me.ColRowNo.HeaderText = "#"
        Me.ColRowNo.MinimumWidth = 6
        Me.ColRowNo.Name = "ColRowNo"
        Me.ColRowNo.ReadOnly = True
        Me.ColRowNo.Width = 40
        '
        'colBookID
        '
        Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBookID.HeaderText = "Book ID"
        Me.colBookID.MinimumWidth = 6
        Me.colBookID.Name = "colBookID"
        Me.colBookID.ReadOnly = True
        Me.colBookID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBookID.Width = 58
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
        Me.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAuthor.HeaderText = "Author"
        Me.colAuthor.MinimumWidth = 6
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.ReadOnly = True
        Me.colAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAuthor.Visible = False
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.MinimumWidth = 6
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCategory.Visible = False
        Me.colCategory.Width = 120
        '
        'colYearPublished
        '
        Me.colYearPublished.HeaderText = "Year Published"
        Me.colYearPublished.MinimumWidth = 6
        Me.colYearPublished.Name = "colYearPublished"
        Me.colYearPublished.ReadOnly = True
        Me.colYearPublished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colYearPublished.Visible = False
        Me.colYearPublished.Width = 120
        '
        'colPublisher
        '
        Me.colPublisher.HeaderText = "Publisher"
        Me.colPublisher.MinimumWidth = 6
        Me.colPublisher.Name = "colPublisher"
        Me.colPublisher.ReadOnly = True
        Me.colPublisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPublisher.Visible = False
        Me.colPublisher.Width = 120
        '
        'colBookPrice
        '
        Me.colBookPrice.HeaderText = "Book Price"
        Me.colBookPrice.MinimumWidth = 6
        Me.colBookPrice.Name = "colBookPrice"
        Me.colBookPrice.ReadOnly = True
        Me.colBookPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colBookPrice.Visible = False
        Me.colBookPrice.Width = 120
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSelect.HeaderText = ""
        Me.colSelect.Image = CType(resources.GetObject("colSelect.Image"), System.Drawing.Image)
        Me.colSelect.MinimumWidth = 6
        Me.colSelect.Name = "colSelect"
        Me.colSelect.ReadOnly = True
        Me.colSelect.Width = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(821, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(490, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Title"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(570, 58)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(351, 26)
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Acquired"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(494, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Book ID"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(494, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Book Title"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(494, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Copies"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(494, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Author(s)"
        '
        'nudCopies
        '
        Me.nudCopies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCopies.Location = New System.Drawing.Point(494, 269)
        Me.nudCopies.Name = "nudCopies"
        Me.nudCopies.Size = New System.Drawing.Size(427, 24)
        Me.nudCopies.TabIndex = 11
        Me.nudCopies.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'btnAddCopies
        '
        Me.btnAddCopies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddCopies.FlatAppearance.BorderSize = 0
        Me.btnAddCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCopies.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCopies.ForeColor = System.Drawing.Color.White
        Me.btnAddCopies.Location = New System.Drawing.Point(497, 298)
        Me.btnAddCopies.Name = "btnAddCopies"
        Me.btnAddCopies.Size = New System.Drawing.Size(108, 26)
        Me.btnAddCopies.TabIndex = 12
        Me.btnAddCopies.Text = "Add Copies"
        Me.btnAddCopies.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(630, 298)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 26)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'picQRCode
        '
        Me.picQRCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picQRCode.Location = New System.Drawing.Point(592, 348)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(241, 223)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picQRCode.TabIndex = 19
        Me.picQRCode.TabStop = False
        '
        'lblBookID
        '
        Me.lblBookID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.Location = New System.Drawing.Point(497, 112)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(427, 24)
        Me.lblBookID.TabIndex = 5
        '
        'lblBookTitle
        '
        Me.lblBookTitle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBookTitle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(497, 163)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(427, 24)
        Me.lblBookTitle.TabIndex = 7
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(497, 214)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(427, 24)
        Me.lblAuthor.TabIndex = 9
        '
        'frmBookAcquired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 627)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddCopies)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblBookID)
        Me.Controls.Add(Me.picQRCode)
        Me.Controls.Add(Me.nudCopies)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvBookAcquired)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBookAcquired"
        Me.Text = "frmBookAcquired"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvBookAcquired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvBookAcquired As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nudCopies As NumericUpDown
    Friend WithEvents btnAddCopies As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colYearPublished As DataGridViewTextBoxColumn
    Friend WithEvents colPublisher As DataGridViewTextBoxColumn
    Friend WithEvents colBookPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSelect As DataGridViewImageColumn
    Friend WithEvents lblBookID As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblAuthor As Label
End Class
