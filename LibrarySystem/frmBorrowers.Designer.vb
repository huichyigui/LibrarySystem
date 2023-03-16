<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowers
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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBorrowers = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddBorrower = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBorrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProgram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditBorrower = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDeleteBorrower = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(200, 9)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(97, 18)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Record(s) Found :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 554)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1223, 37)
        Me.Panel2.TabIndex = 7
        '
        'dgvBorrowers
        '
        Me.dgvBorrowers.AllowUserToAddRows = False
        Me.dgvBorrowers.AllowUserToDeleteRows = False
        Me.dgvBorrowers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBorrowers.BackgroundColor = System.Drawing.Color.White
        Me.dgvBorrowers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBorrowers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrowers.ColumnHeadersHeight = 31
        Me.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBorrowers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.colBorrowerID, Me.colName, Me.colProgram, Me.colDOB, Me.colGender, Me.colContact, Me.colEmail, Me.colStatus, Me.colEditBorrower, Me.colDeleteBorrower})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBorrowers.EnableHeadersVisualStyles = False
        Me.dgvBorrowers.GridColor = System.Drawing.SystemColors.Control
        Me.dgvBorrowers.Location = New System.Drawing.Point(13, 70)
        Me.dgvBorrowers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBorrowers.Name = "dgvBorrowers"
        Me.dgvBorrowers.ReadOnly = True
        Me.dgvBorrowers.RowHeadersVisible = False
        Me.dgvBorrowers.RowHeadersWidth = 49
        Me.dgvBorrowers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBorrowers.RowTemplate.Height = 25
        Me.dgvBorrowers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowers.Size = New System.Drawing.Size(1193, 476)
        Me.dgvBorrowers.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1073, 15)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 32)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Location = New System.Drawing.Point(531, 16)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(401, 31)
        Me.txtSearch.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrowers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnAddBorrower)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1223, 64)
        Me.Panel1.TabIndex = 5
        '
        'btnAddBorrower
        '
        Me.btnAddBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBorrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddBorrower.FlatAppearance.BorderSize = 0
        Me.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBorrower.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrower.ForeColor = System.Drawing.Color.White
        Me.btnAddBorrower.Image = Global.LibrarySystem.My.Resources.Resources.icons8_add_30_2_
        Me.btnAddBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBorrower.Location = New System.Drawing.Point(941, 16)
        Me.btnAddBorrower.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddBorrower.Name = "btnAddBorrower"
        Me.btnAddBorrower.Size = New System.Drawing.Size(124, 32)
        Me.btnAddBorrower.TabIndex = 4
        Me.btnAddBorrower.Text = "    &Add"
        Me.btnAddBorrower.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 120
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 120
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
        Me.colBorrowerID.Width = 95
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
        Me.colDOB.Width = 48
        '
        'colGender
        '
        Me.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGender.HeaderText = "Gender"
        Me.colGender.MinimumWidth = 6
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colGender.Width = 65
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
        Me.colStatus.Width = 58
        '
        'colEditBorrower
        '
        Me.colEditBorrower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditBorrower.HeaderText = ""
        Me.colEditBorrower.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.colEditBorrower.MinimumWidth = 6
        Me.colEditBorrower.Name = "colEditBorrower"
        Me.colEditBorrower.ReadOnly = True
        Me.colEditBorrower.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEditBorrower.Width = 6
        '
        'colDeleteBorrower
        '
        Me.colDeleteBorrower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDeleteBorrower.HeaderText = ""
        Me.colDeleteBorrower.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.colDeleteBorrower.MinimumWidth = 6
        Me.colDeleteBorrower.Name = "colDeleteBorrower"
        Me.colDeleteBorrower.ReadOnly = True
        Me.colDeleteBorrower.Width = 6
        '
        'frmBorrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1223, 591)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvBorrowers)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBorrowers"
        Me.Text = "frmBorrowers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvBorrowers As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddBorrower As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents colBorrowerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colProgram As DataGridViewTextBoxColumn
    Friend WithEvents colDOB As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colEditBorrower As DataGridViewImageColumn
    Friend WithEvents colDeleteBorrower As DataGridViewImageColumn
End Class
