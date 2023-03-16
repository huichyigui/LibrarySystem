<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookEntry))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearPublished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBookPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrint = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colEditBook = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnAddBook)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 52)
        Me.Panel1.TabIndex = 0
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
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(414, 13)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(302, 26)
        Me.txtSearch.TabIndex = 2
        '
        'btnAddBook
        '
        Me.btnAddBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddBook.FlatAppearance.BorderSize = 0
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.ForeColor = System.Drawing.Color.White
        Me.btnAddBook.Location = New System.Drawing.Point(722, 13)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(93, 26)
        Me.btnAddBook.TabIndex = 3
        Me.btnAddBook.Text = "&Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Entry"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.White
        Me.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooks.ColumnHeadersHeight = 31
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.colBookID, Me.colBookTitle, Me.colAuthor, Me.colYearPublished, Me.colPublisher, Me.colCopies, Me.colCategory, Me.colBookPrice, Me.colPrint, Me.colEditBook})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooks.EnableHeadersVisualStyles = False
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBooks.Location = New System.Drawing.Point(12, 58)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.RowHeadersWidth = 49
        Me.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBooks.RowTemplate.Height = 25
        Me.dgvBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(909, 425)
        Me.dgvBooks.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(933, 30)
        Me.Panel2.TabIndex = 0
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
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
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
        Me.colAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAuthor.HeaderText = "Author(s)"
        Me.colAuthor.MinimumWidth = 6
        Me.colAuthor.Name = "colAuthor"
        Me.colAuthor.ReadOnly = True
        Me.colAuthor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colAuthor.Width = 67
        '
        'colYearPublished
        '
        Me.colYearPublished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colYearPublished.HeaderText = "Year Published"
        Me.colYearPublished.MinimumWidth = 6
        Me.colYearPublished.Name = "colYearPublished"
        Me.colYearPublished.ReadOnly = True
        Me.colYearPublished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colYearPublished.Width = 97
        '
        'colPublisher
        '
        Me.colPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPublisher.HeaderText = "Publisher"
        Me.colPublisher.MinimumWidth = 6
        Me.colPublisher.Name = "colPublisher"
        Me.colPublisher.ReadOnly = True
        Me.colPublisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPublisher.Width = 69
        '
        'colCopies
        '
        Me.colCopies.HeaderText = "Available Copies"
        Me.colCopies.MinimumWidth = 6
        Me.colCopies.Name = "colCopies"
        Me.colCopies.ReadOnly = True
        Me.colCopies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCopies.Width = 90
        '
        'colCategory
        '
        Me.colCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.MinimumWidth = 6
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCategory.Width = 64
        '
        'colBookPrice
        '
        Me.colBookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBookPrice.HeaderText = "Price (RM)"
        Me.colBookPrice.MinimumWidth = 6
        Me.colBookPrice.Name = "colBookPrice"
        Me.colBookPrice.ReadOnly = True
        Me.colBookPrice.Width = 92
        '
        'colPrint
        '
        Me.colPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPrint.HeaderText = ""
        Me.colPrint.Image = CType(resources.GetObject("colPrint.Image"), System.Drawing.Image)
        Me.colPrint.MinimumWidth = 6
        Me.colPrint.Name = "colPrint"
        Me.colPrint.ReadOnly = True
        Me.colPrint.Width = 6
        '
        'colEditBook
        '
        Me.colEditBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditBook.HeaderText = ""
        Me.colEditBook.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.colEditBook.MinimumWidth = 6
        Me.colEditBook.Name = "colEditBook"
        Me.colEditBook.ReadOnly = True
        Me.colEditBook.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEditBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEditBook.Width = 22
        '
        'frmBookEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBookEntry"
        Me.Text = "Book Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddBook As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents colBookID As DataGridViewTextBoxColumn
    Friend WithEvents colBookTitle As DataGridViewTextBoxColumn
    Friend WithEvents colAuthor As DataGridViewTextBoxColumn
    Friend WithEvents colYearPublished As DataGridViewTextBoxColumn
    Friend WithEvents colPublisher As DataGridViewTextBoxColumn
    Friend WithEvents colCopies As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colBookPrice As DataGridViewTextBoxColumn
    Friend WithEvents colPrint As DataGridViewImageColumn
    Friend WithEvents colEditBook As DataGridViewImageColumn
End Class
