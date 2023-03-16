<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatistics
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabStatistics = New System.Windows.Forms.TabControl()
        Me.tabBorrower = New System.Windows.Forms.TabPage()
        Me.btnClearBorrowerReport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBorrowersStatistics = New System.Windows.Forms.ComboBox()
        Me.ChartBorrowers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tablActivityLog = New System.Windows.Forms.TabPage()
        Me.btnActivityLogPDF = New System.Windows.Forms.Button()
        Me.btnPrintActivityLog = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpToLog = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvLogHistory = New System.Windows.Forms.DataGridView()
        Me.colNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFromLog = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.tabStatistics.SuspendLayout()
        Me.tabBorrower.SuspendLayout()
        CType(Me.ChartBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablActivityLog.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1223, 64)
        Me.Panel1.TabIndex = 6
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
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 32)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Statistics"
        '
        'tabStatistics
        '
        Me.tabStatistics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabStatistics.Controls.Add(Me.tabBorrower)
        Me.tabStatistics.Controls.Add(Me.tablActivityLog)
        Me.tabStatistics.Location = New System.Drawing.Point(12, 71)
        Me.tabStatistics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabStatistics.Name = "tabStatistics"
        Me.tabStatistics.SelectedIndex = 0
        Me.tabStatistics.Size = New System.Drawing.Size(1199, 508)
        Me.tabStatistics.TabIndex = 7
        '
        'tabBorrower
        '
        Me.tabBorrower.Controls.Add(Me.btnClearBorrowerReport)
        Me.tabBorrower.Controls.Add(Me.Label3)
        Me.tabBorrower.Controls.Add(Me.cboBorrowersStatistics)
        Me.tabBorrower.Controls.Add(Me.ChartBorrowers)
        Me.tabBorrower.Location = New System.Drawing.Point(4, 25)
        Me.tabBorrower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBorrower.Name = "tabBorrower"
        Me.tabBorrower.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabBorrower.Size = New System.Drawing.Size(1191, 479)
        Me.tabBorrower.TabIndex = 0
        Me.tabBorrower.Text = "Borrowers"
        Me.tabBorrower.UseVisualStyleBackColor = True
        '
        'btnClearBorrowerReport
        '
        Me.btnClearBorrowerReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearBorrowerReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnClearBorrowerReport.FlatAppearance.BorderSize = 0
        Me.btnClearBorrowerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearBorrowerReport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearBorrowerReport.ForeColor = System.Drawing.Color.White
        Me.btnClearBorrowerReport.Location = New System.Drawing.Point(941, 11)
        Me.btnClearBorrowerReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearBorrowerReport.Name = "btnClearBorrowerReport"
        Me.btnClearBorrowerReport.Size = New System.Drawing.Size(133, 32)
        Me.btnClearBorrowerReport.TabIndex = 19
        Me.btnClearBorrowerReport.Text = "&Clear"
        Me.btnClearBorrowerReport.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(435, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Instruction: Please select using drop-down-boxes : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboBorrowersStatistics
        '
        Me.cboBorrowersStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboBorrowersStatistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBorrowersStatistics.FormattingEnabled = True
        Me.cboBorrowersStatistics.Items.AddRange(New Object() {"Pie chart of Borrowers's Status Percentage", "Pie chart of Borrowers's Gender Percentage"})
        Me.cboBorrowersStatistics.Location = New System.Drawing.Point(568, 16)
        Me.cboBorrowersStatistics.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboBorrowersStatistics.Name = "cboBorrowersStatistics"
        Me.cboBorrowersStatistics.Size = New System.Drawing.Size(353, 24)
        Me.cboBorrowersStatistics.TabIndex = 17
        '
        'ChartBorrowers
        '
        Me.ChartBorrowers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ChartBorrowers.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartBorrowers.Legends.Add(Legend1)
        Me.ChartBorrowers.Location = New System.Drawing.Point(33, 49)
        Me.ChartBorrowers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChartBorrowers.Name = "ChartBorrowers"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartBorrowers.Series.Add(Series1)
        Me.ChartBorrowers.Size = New System.Drawing.Size(1141, 423)
        Me.ChartBorrowers.TabIndex = 0
        Me.ChartBorrowers.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.17391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Me.ChartBorrowers.Titles.Add(Title1)
        Me.ChartBorrowers.Visible = False
        '
        'tablActivityLog
        '
        Me.tablActivityLog.Controls.Add(Me.btnActivityLogPDF)
        Me.tablActivityLog.Controls.Add(Me.btnPrintActivityLog)
        Me.tablActivityLog.Controls.Add(Me.txtSearch)
        Me.tablActivityLog.Controls.Add(Me.Label6)
        Me.tablActivityLog.Controls.Add(Me.dtpToLog)
        Me.tablActivityLog.Controls.Add(Me.Label5)
        Me.tablActivityLog.Controls.Add(Me.Panel2)
        Me.tablActivityLog.Controls.Add(Me.dgvLogHistory)
        Me.tablActivityLog.Controls.Add(Me.dtpFromLog)
        Me.tablActivityLog.Controls.Add(Me.Label2)
        Me.tablActivityLog.Location = New System.Drawing.Point(4, 25)
        Me.tablActivityLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tablActivityLog.Name = "tablActivityLog"
        Me.tablActivityLog.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tablActivityLog.Size = New System.Drawing.Size(1191, 479)
        Me.tablActivityLog.TabIndex = 1
        Me.tablActivityLog.Text = "Activity Log"
        Me.tablActivityLog.UseVisualStyleBackColor = True
        '
        'btnActivityLogPDF
        '
        Me.btnActivityLogPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActivityLogPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnActivityLogPDF.FlatAppearance.BorderSize = 0
        Me.btnActivityLogPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivityLogPDF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivityLogPDF.ForeColor = System.Drawing.Color.White
        Me.btnActivityLogPDF.Location = New System.Drawing.Point(1056, 34)
        Me.btnActivityLogPDF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActivityLogPDF.Name = "btnActivityLogPDF"
        Me.btnActivityLogPDF.Size = New System.Drawing.Size(123, 34)
        Me.btnActivityLogPDF.TabIndex = 24
        Me.btnActivityLogPDF.Text = "&Save As PDF"
        Me.btnActivityLogPDF.UseVisualStyleBackColor = False
        '
        'btnPrintActivityLog
        '
        Me.btnPrintActivityLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintActivityLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPrintActivityLog.FlatAppearance.BorderSize = 0
        Me.btnPrintActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintActivityLog.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintActivityLog.ForeColor = System.Drawing.Color.White
        Me.btnPrintActivityLog.Location = New System.Drawing.Point(916, 34)
        Me.btnPrintActivityLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrintActivityLog.Name = "btnPrintActivityLog"
        Me.btnPrintActivityLog.Size = New System.Drawing.Size(135, 34)
        Me.btnPrintActivityLog.TabIndex = 23
        Me.btnPrintActivityLog.Text = "&Print / Preview"
        Me.btnPrintActivityLog.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtSearch.Location = New System.Drawing.Point(759, 4)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(421, 22)
        Me.txtSearch.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(651, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Search Name:"
        '
        'dtpToLog
        '
        Me.dtpToLog.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToLog.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToLog.Location = New System.Drawing.Point(373, 4)
        Me.dtpToLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpToLog.Name = "dtpToLog"
        Me.dtpToLog.Size = New System.Drawing.Size(216, 22)
        Me.dtpToLog.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "[ To ]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 440)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1185, 37)
        Me.Panel2.TabIndex = 13
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
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Record(s) Found :"
        '
        'dgvLogHistory
        '
        Me.dgvLogHistory.AllowUserToAddRows = False
        Me.dgvLogHistory.AllowUserToDeleteRows = False
        Me.dgvLogHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLogHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvLogHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLogHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLogHistory.ColumnHeadersHeight = 31
        Me.dgvLogHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLogHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNum, Me.colUsername, Me.colFullName, Me.colDateIn, Me.colTimeIn, Me.colDateOut, Me.colTimeOut})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLogHistory.EnableHeadersVisualStyles = False
        Me.dgvLogHistory.GridColor = System.Drawing.SystemColors.Control
        Me.dgvLogHistory.Location = New System.Drawing.Point(13, 75)
        Me.dgvLogHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLogHistory.Name = "dgvLogHistory"
        Me.dgvLogHistory.ReadOnly = True
        Me.dgvLogHistory.RowHeadersVisible = False
        Me.dgvLogHistory.RowHeadersWidth = 49
        Me.dgvLogHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLogHistory.RowTemplate.Height = 25
        Me.dgvLogHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogHistory.Size = New System.Drawing.Size(1168, 352)
        Me.dgvLogHistory.TabIndex = 12
        '
        'colNum
        '
        Me.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNum.HeaderText = "#"
        Me.colNum.MinimumWidth = 6
        Me.colNum.Name = "colNum"
        Me.colNum.ReadOnly = True
        Me.colNum.Width = 49
        '
        'colUsername
        '
        Me.colUsername.HeaderText = "Username"
        Me.colUsername.MinimumWidth = 6
        Me.colUsername.Name = "colUsername"
        Me.colUsername.ReadOnly = True
        Me.colUsername.Width = 150
        '
        'colFullName
        '
        Me.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFullName.HeaderText = "Full Name"
        Me.colFullName.MinimumWidth = 6
        Me.colFullName.Name = "colFullName"
        Me.colFullName.ReadOnly = True
        Me.colFullName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDateIn
        '
        Me.colDateIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDateIn.HeaderText = "DateIn"
        Me.colDateIn.MinimumWidth = 6
        Me.colDateIn.Name = "colDateIn"
        Me.colDateIn.ReadOnly = True
        Me.colDateIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDateIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDateIn.Width = 61
        '
        'colTimeIn
        '
        Me.colTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTimeIn.HeaderText = "TimeIn"
        Me.colTimeIn.MinimumWidth = 6
        Me.colTimeIn.Name = "colTimeIn"
        Me.colTimeIn.ReadOnly = True
        Me.colTimeIn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTimeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTimeIn.Width = 62
        '
        'colDateOut
        '
        Me.colDateOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDateOut.HeaderText = "Date Out"
        Me.colDateOut.MinimumWidth = 6
        Me.colDateOut.Name = "colDateOut"
        Me.colDateOut.ReadOnly = True
        Me.colDateOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDateOut.Width = 77
        '
        'colTimeOut
        '
        Me.colTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTimeOut.HeaderText = "Time Out"
        Me.colTimeOut.MinimumWidth = 6
        Me.colTimeOut.Name = "colTimeOut"
        Me.colTimeOut.ReadOnly = True
        Me.colTimeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTimeOut.Width = 78
        '
        'dtpFromLog
        '
        Me.dtpFromLog.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromLog.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromLog.Location = New System.Drawing.Point(88, 4)
        Me.dtpFromLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFromLog.Name = "dtpFromLog"
        Me.dtpFromLog.Size = New System.Drawing.Size(216, 22)
        Me.dtpFromLog.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "[ From ]"
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 591)
        Me.Controls.Add(Me.tabStatistics)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmStatistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabStatistics.ResumeLayout(False)
        Me.tabBorrower.ResumeLayout(False)
        CType(Me.ChartBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablActivityLog.ResumeLayout(False)
        Me.tablActivityLog.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tabStatistics As TabControl
    Friend WithEvents tabBorrower As TabPage
    Friend WithEvents tablActivityLog As TabPage
    Friend WithEvents ChartBorrowers As DataVisualization.Charting.Chart
    Friend WithEvents cboBorrowersStatistics As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearBorrowerReport As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpToLog As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvLogHistory As DataGridView
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colFullName As DataGridViewTextBoxColumn
    Friend WithEvents colDateIn As DataGridViewTextBoxColumn
    Friend WithEvents colTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colDateOut As DataGridViewTextBoxColumn
    Friend WithEvents colTimeOut As DataGridViewTextBoxColumn
    Friend WithEvents dtpFromLog As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPrintActivityLog As Button
    Friend WithEvents btnActivityLogPDF As Button
End Class
