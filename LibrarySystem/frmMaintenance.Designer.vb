<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageCategory = New System.Windows.Forms.TabPage()
        Me.btnCategoryCancel = New System.Windows.Forms.Button()
        Me.btnCategoryUpdate = New System.Windows.Forms.Button()
        Me.btnCategorySave = New System.Windows.Forms.Button()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.ColRowNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditCategory = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColDeleteCategory = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageProgram = New System.Windows.Forms.TabPage()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProgramCancel = New System.Windows.Forms.Button()
        Me.btnProgramUpdate = New System.Windows.Forms.Button()
        Me.btnProgramSave = New System.Windows.Forms.Button()
        Me.dgvProgram = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditProgram = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDeleteProgram = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.btnSettingsCancel = New System.Windows.Forms.Button()
        Me.btnSettingsSave = New System.Windows.Forms.Button()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBooksAllowed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDaysAllowed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPageCategory.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageProgram.SuspendLayout()
        CType(Me.dgvProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageCategory)
        Me.TabControl1.Controls.Add(Me.TabPageProgram)
        Me.TabControl1.Controls.Add(Me.TabPageSettings)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(909, 495)
        Me.TabControl1.TabIndex = 1
        '
        'TabPageCategory
        '
        Me.TabPageCategory.Controls.Add(Me.btnCategoryCancel)
        Me.TabPageCategory.Controls.Add(Me.btnCategoryUpdate)
        Me.TabPageCategory.Controls.Add(Me.btnCategorySave)
        Me.TabPageCategory.Controls.Add(Me.dgvCategory)
        Me.TabPageCategory.Controls.Add(Me.txtCategory)
        Me.TabPageCategory.Controls.Add(Me.Label1)
        Me.TabPageCategory.Location = New System.Drawing.Point(4, 28)
        Me.TabPageCategory.Name = "TabPageCategory"
        Me.TabPageCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCategory.Size = New System.Drawing.Size(901, 463)
        Me.TabPageCategory.TabIndex = 0
        Me.TabPageCategory.Text = "Category"
        Me.TabPageCategory.UseVisualStyleBackColor = True
        '
        'btnCategoryCancel
        '
        Me.btnCategoryCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCategoryCancel.FlatAppearance.BorderSize = 0
        Me.btnCategoryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryCancel.ForeColor = System.Drawing.Color.White
        Me.btnCategoryCancel.Location = New System.Drawing.Point(407, 55)
        Me.btnCategoryCancel.Name = "btnCategoryCancel"
        Me.btnCategoryCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCategoryCancel.TabIndex = 5
        Me.btnCategoryCancel.Text = "&Cancel"
        Me.btnCategoryCancel.UseVisualStyleBackColor = False
        '
        'btnCategoryUpdate
        '
        Me.btnCategoryUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCategoryUpdate.Enabled = False
        Me.btnCategoryUpdate.FlatAppearance.BorderSize = 0
        Me.btnCategoryUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryUpdate.ForeColor = System.Drawing.Color.White
        Me.btnCategoryUpdate.Location = New System.Drawing.Point(324, 55)
        Me.btnCategoryUpdate.Name = "btnCategoryUpdate"
        Me.btnCategoryUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnCategoryUpdate.TabIndex = 4
        Me.btnCategoryUpdate.Text = "&Update"
        Me.btnCategoryUpdate.UseVisualStyleBackColor = False
        '
        'btnCategorySave
        '
        Me.btnCategorySave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCategorySave.FlatAppearance.BorderSize = 0
        Me.btnCategorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategorySave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorySave.ForeColor = System.Drawing.Color.White
        Me.btnCategorySave.Location = New System.Drawing.Point(243, 55)
        Me.btnCategorySave.Name = "btnCategorySave"
        Me.btnCategorySave.Size = New System.Drawing.Size(75, 26)
        Me.btnCategorySave.TabIndex = 3
        Me.btnCategorySave.Text = "&Save"
        Me.btnCategorySave.UseVisualStyleBackColor = False
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.BackgroundColor = System.Drawing.Color.White
        Me.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategory.ColumnHeadersHeight = 31
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRowNo, Me.ColCategory, Me.colEditCategory, Me.ColDeleteCategory})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategory.EnableHeadersVisualStyles = False
        Me.dgvCategory.GridColor = System.Drawing.SystemColors.Control
        Me.dgvCategory.Location = New System.Drawing.Point(6, 93)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.RowHeadersVisible = False
        Me.dgvCategory.RowHeadersWidth = 49
        Me.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCategory.RowTemplate.Height = 25
        Me.dgvCategory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(889, 364)
        Me.dgvCategory.TabIndex = 2
        '
        'ColRowNo
        '
        Me.ColRowNo.HeaderText = "#"
        Me.ColRowNo.MinimumWidth = 6
        Me.ColRowNo.Name = "ColRowNo"
        Me.ColRowNo.ReadOnly = True
        Me.ColRowNo.Width = 40
        '
        'ColCategory
        '
        Me.ColCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColCategory.HeaderText = "Category"
        Me.ColCategory.MinimumWidth = 6
        Me.ColCategory.Name = "ColCategory"
        Me.ColCategory.ReadOnly = True
        Me.ColCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colEditCategory
        '
        Me.colEditCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditCategory.HeaderText = ""
        Me.colEditCategory.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.colEditCategory.MinimumWidth = 6
        Me.colEditCategory.Name = "colEditCategory"
        Me.colEditCategory.ReadOnly = True
        Me.colEditCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEditCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEditCategory.Width = 22
        '
        'ColDeleteCategory
        '
        Me.ColDeleteCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColDeleteCategory.HeaderText = ""
        Me.ColDeleteCategory.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.ColDeleteCategory.MinimumWidth = 6
        Me.ColDeleteCategory.Name = "ColDeleteCategory"
        Me.ColDeleteCategory.ReadOnly = True
        Me.ColDeleteCategory.Width = 6
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(146, 22)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(336, 27)
        Me.txtCategory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Category"
        '
        'TabPageProgram
        '
        Me.TabPageProgram.Controls.Add(Me.txtDescription)
        Me.TabPageProgram.Controls.Add(Me.Label3)
        Me.TabPageProgram.Controls.Add(Me.btnProgramCancel)
        Me.TabPageProgram.Controls.Add(Me.btnProgramUpdate)
        Me.TabPageProgram.Controls.Add(Me.btnProgramSave)
        Me.TabPageProgram.Controls.Add(Me.dgvProgram)
        Me.TabPageProgram.Controls.Add(Me.txtProgram)
        Me.TabPageProgram.Controls.Add(Me.Label2)
        Me.TabPageProgram.Location = New System.Drawing.Point(4, 28)
        Me.TabPageProgram.Name = "TabPageProgram"
        Me.TabPageProgram.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProgram.Size = New System.Drawing.Size(901, 463)
        Me.TabPageProgram.TabIndex = 1
        Me.TabPageProgram.Text = "Program"
        Me.TabPageProgram.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(132, 45)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(763, 27)
        Me.txtDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'btnProgramCancel
        '
        Me.btnProgramCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnProgramCancel.FlatAppearance.BorderSize = 0
        Me.btnProgramCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgramCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgramCancel.ForeColor = System.Drawing.Color.White
        Me.btnProgramCancel.Location = New System.Drawing.Point(820, 13)
        Me.btnProgramCancel.Name = "btnProgramCancel"
        Me.btnProgramCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnProgramCancel.TabIndex = 6
        Me.btnProgramCancel.Text = "&Cancel"
        Me.btnProgramCancel.UseVisualStyleBackColor = False
        '
        'btnProgramUpdate
        '
        Me.btnProgramUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProgramUpdate.Enabled = False
        Me.btnProgramUpdate.FlatAppearance.BorderSize = 0
        Me.btnProgramUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgramUpdate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgramUpdate.ForeColor = System.Drawing.Color.White
        Me.btnProgramUpdate.Location = New System.Drawing.Point(737, 13)
        Me.btnProgramUpdate.Name = "btnProgramUpdate"
        Me.btnProgramUpdate.Size = New System.Drawing.Size(75, 26)
        Me.btnProgramUpdate.TabIndex = 5
        Me.btnProgramUpdate.Text = "&Update"
        Me.btnProgramUpdate.UseVisualStyleBackColor = False
        '
        'btnProgramSave
        '
        Me.btnProgramSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProgramSave.FlatAppearance.BorderSize = 0
        Me.btnProgramSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgramSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgramSave.ForeColor = System.Drawing.Color.White
        Me.btnProgramSave.Location = New System.Drawing.Point(656, 13)
        Me.btnProgramSave.Name = "btnProgramSave"
        Me.btnProgramSave.Size = New System.Drawing.Size(75, 26)
        Me.btnProgramSave.TabIndex = 4
        Me.btnProgramSave.Text = "&Save"
        Me.btnProgramSave.UseVisualStyleBackColor = False
        '
        'dgvProgram
        '
        Me.dgvProgram.AllowUserToAddRows = False
        Me.dgvProgram.AllowUserToDeleteRows = False
        Me.dgvProgram.BackgroundColor = System.Drawing.Color.White
        Me.dgvProgram.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProgram.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProgram.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProgram.ColumnHeadersHeight = 31
        Me.dgvProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProgram.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.colDescription, Me.colEditProgram, Me.colDeleteProgram})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProgram.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProgram.EnableHeadersVisualStyles = False
        Me.dgvProgram.GridColor = System.Drawing.SystemColors.Control
        Me.dgvProgram.Location = New System.Drawing.Point(6, 93)
        Me.dgvProgram.Name = "dgvProgram"
        Me.dgvProgram.ReadOnly = True
        Me.dgvProgram.RowHeadersVisible = False
        Me.dgvProgram.RowHeadersWidth = 49
        Me.dgvProgram.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProgram.RowTemplate.Height = 25
        Me.dgvProgram.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProgram.Size = New System.Drawing.Size(889, 364)
        Me.dgvProgram.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colEditProgram
        '
        Me.colEditProgram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditProgram.HeaderText = ""
        Me.colEditProgram.Image = Global.LibrarySystem.My.Resources.Resources.icons8_edit_20
        Me.colEditProgram.MinimumWidth = 6
        Me.colEditProgram.Name = "colEditProgram"
        Me.colEditProgram.ReadOnly = True
        Me.colEditProgram.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEditProgram.Width = 6
        '
        'colDeleteProgram
        '
        Me.colDeleteProgram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDeleteProgram.HeaderText = ""
        Me.colDeleteProgram.Image = Global.LibrarySystem.My.Resources.Resources.icons8_delete_bin_20
        Me.colDeleteProgram.MinimumWidth = 6
        Me.colDeleteProgram.Name = "colDeleteProgram"
        Me.colDeleteProgram.ReadOnly = True
        Me.colDeleteProgram.Width = 6
        '
        'txtProgram
        '
        Me.txtProgram.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProgram.Location = New System.Drawing.Point(132, 12)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(518, 27)
        Me.txtProgram.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter Program"
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.btnSettingsCancel)
        Me.TabPageSettings.Controls.Add(Me.btnSettingsSave)
        Me.TabPageSettings.Controls.Add(Me.txtPenalty)
        Me.TabPageSettings.Controls.Add(Me.Label6)
        Me.TabPageSettings.Controls.Add(Me.txtBooksAllowed)
        Me.TabPageSettings.Controls.Add(Me.Label5)
        Me.TabPageSettings.Controls.Add(Me.txtDaysAllowed)
        Me.TabPageSettings.Controls.Add(Me.Label4)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 28)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Size = New System.Drawing.Size(901, 463)
        Me.TabPageSettings.TabIndex = 2
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'btnSettingsCancel
        '
        Me.btnSettingsCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSettingsCancel.FlatAppearance.BorderSize = 0
        Me.btnSettingsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettingsCancel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsCancel.ForeColor = System.Drawing.Color.White
        Me.btnSettingsCancel.Location = New System.Drawing.Point(568, 277)
        Me.btnSettingsCancel.Name = "btnSettingsCancel"
        Me.btnSettingsCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnSettingsCancel.TabIndex = 15
        Me.btnSettingsCancel.Text = "&Cancel"
        Me.btnSettingsCancel.UseVisualStyleBackColor = False
        '
        'btnSettingsSave
        '
        Me.btnSettingsSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsSave.FlatAppearance.BorderSize = 0
        Me.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettingsSave.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsSave.ForeColor = System.Drawing.Color.White
        Me.btnSettingsSave.Location = New System.Drawing.Point(487, 277)
        Me.btnSettingsSave.Name = "btnSettingsSave"
        Me.btnSettingsSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSettingsSave.TabIndex = 14
        Me.btnSettingsSave.Text = "&Save"
        Me.btnSettingsSave.UseVisualStyleBackColor = False
        '
        'txtPenalty
        '
        Me.txtPenalty.Location = New System.Drawing.Point(365, 244)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(278, 27)
        Me.txtPenalty.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(261, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Penalty (RM)"
        '
        'txtBooksAllowed
        '
        Me.txtBooksAllowed.Location = New System.Drawing.Point(365, 211)
        Me.txtBooksAllowed.Name = "txtBooksAllowed"
        Me.txtBooksAllowed.Size = New System.Drawing.Size(278, 27)
        Me.txtBooksAllowed.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Books allowed to borrow"
        '
        'txtDaysAllowed
        '
        Me.txtDaysAllowed.Location = New System.Drawing.Point(365, 170)
        Me.txtDaysAllowed.Name = "txtDaysAllowed"
        Me.txtDaysAllowed.Size = New System.Drawing.Size(278, 27)
        Me.txtDaysAllowed.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No. of days allowed"
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 519)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageCategory.ResumeLayout(False)
        Me.TabPageCategory.PerformLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageProgram.ResumeLayout(False)
        Me.TabPageProgram.PerformLayout()
        CType(Me.dgvProgram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSettings.ResumeLayout(False)
        Me.TabPageSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageCategory As TabPage
    Friend WithEvents btnCategoryCancel As Button
    Friend WithEvents btnCategoryUpdate As Button
    Friend WithEvents btnCategorySave As Button
    Friend WithEvents dgvCategory As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPageProgram As TabPage
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnProgramCancel As Button
    Friend WithEvents btnProgramUpdate As Button
    Friend WithEvents btnProgramSave As Button
    Friend WithEvents dgvProgram As DataGridView
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSettingsCancel As Button
    Friend WithEvents btnSettingsSave As Button
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBooksAllowed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDaysAllowed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ColRowNo As DataGridViewTextBoxColumn
    Friend WithEvents ColCategory As DataGridViewTextBoxColumn
    Friend WithEvents colEditCategory As DataGridViewImageColumn
    Friend WithEvents ColDeleteCategory As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colEditProgram As DataGridViewImageColumn
    Friend WithEvents colDeleteProgram As DataGridViewImageColumn
End Class
