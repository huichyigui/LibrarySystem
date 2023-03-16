<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.Payment_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_Method = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot_paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskBorrowerID = New System.Windows.Forms.MaskedTextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblOutstanding = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.tpHistory = New System.Windows.Forms.TabPage()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvFine = New System.Windows.Forms.DataGridView()
        Me.Borrower_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpPayments = New System.Windows.Forms.TabPage()
        Me.TabControlPayments = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCloseIR = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tooltipError = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHistory.SuspendLayout()
        CType(Me.dgvFine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPayments.SuspendLayout()
        Me.TabControlPayments.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fine
        '
        Me.Fine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fine.HeaderText = "Fine(RM)"
        Me.Fine.Name = "Fine"
        Me.Fine.ReadOnly = True
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistory.ColumnHeadersHeight = 31
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Payment_no, Me.BorrowerID, Me.Description, Me.Payment_Method, Me.Payment_date, Me.tot_paid})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistory.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistory.EnableHeadersVisualStyles = False
        Me.dgvHistory.GridColor = System.Drawing.SystemColors.Control
        Me.dgvHistory.Location = New System.Drawing.Point(5, 9)
        Me.dgvHistory.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowHeadersWidth = 49
        Me.dgvHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHistory.RowTemplate.Height = 25
        Me.dgvHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistory.Size = New System.Drawing.Size(1421, 646)
        Me.dgvHistory.TabIndex = 44
        '
        'Payment_no
        '
        Me.Payment_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Payment_no.HeaderText = "Payment No."
        Me.Payment_no.Name = "Payment_no"
        Me.Payment_no.ReadOnly = True
        Me.Payment_no.Width = 127
        '
        'BorrowerID
        '
        Me.BorrowerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BorrowerID.HeaderText = "Borrower ID"
        Me.BorrowerID.Name = "BorrowerID"
        Me.BorrowerID.ReadOnly = True
        Me.BorrowerID.Width = 122
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
        Me.tot_paid.Width = 107
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(805, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Description :"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(1001, 123)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(393, 22)
        Me.txtDescription.TabIndex = 2
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.BackColor = System.Drawing.Color.DarkGray
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Red
        Me.lblChange.Location = New System.Drawing.Point(1132, 279)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(263, 73)
        Me.lblChange.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1125, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 36)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Change(RM):"
        '
        'mskBorrowerID
        '
        Me.mskBorrowerID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskBorrowerID.Location = New System.Drawing.Point(1001, 90)
        Me.mskBorrowerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskBorrowerID.Mask = "99???99999"
        Me.mskBorrowerID.Name = "mskBorrowerID"
        Me.mskBorrowerID.Size = New System.Drawing.Size(393, 26)
        Me.mskBorrowerID.TabIndex = 1
        '
        'btnPay
        '
        Me.btnPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(809, 388)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(587, 87)
        Me.btnPay.TabIndex = 5
        Me.btnPay.Text = "&Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'lblOutstanding
        '
        Me.lblOutstanding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutstanding.BackColor = System.Drawing.Color.DarkGray
        Me.lblOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutstanding.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutstanding.ForeColor = System.Drawing.Color.Red
        Me.lblOutstanding.Location = New System.Drawing.Point(809, 279)
        Me.lblOutstanding.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutstanding.Name = "lblOutstanding"
        Me.lblOutstanding.Size = New System.Drawing.Size(263, 73)
        Me.lblOutstanding.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(803, 244)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 36)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Outstanding(RM):"
        '
        'cboPayment
        '
        Me.cboPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Location = New System.Drawing.Point(1001, 196)
        Me.cboPayment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(393, 28)
        Me.cboPayment.TabIndex = 4
        '
        'tpHistory
        '
        Me.tpHistory.Controls.Add(Me.dgvHistory)
        Me.tpHistory.Location = New System.Drawing.Point(4, 29)
        Me.tpHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpHistory.Name = "tpHistory"
        Me.tpHistory.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpHistory.Size = New System.Drawing.Size(1439, 659)
        Me.tpHistory.TabIndex = 1
        Me.tpHistory.Text = "History"
        Me.tpHistory.UseVisualStyleBackColor = True
        '
        'txtPayments
        '
        Me.txtPayments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayments.Location = New System.Drawing.Point(1001, 160)
        Me.txtPayments.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.Size = New System.Drawing.Size(393, 22)
        Me.txtPayments.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(805, 199)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 18)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Payment method:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(804, 90)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 18)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Borrower ID:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(805, 162)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Payment(RM):"
        '
        'dgvFine
        '
        Me.dgvFine.AllowUserToAddRows = False
        Me.dgvFine.AllowUserToDeleteRows = False
        Me.dgvFine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFine.BackgroundColor = System.Drawing.Color.White
        Me.dgvFine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFine.ColumnHeadersHeight = 31
        Me.dgvFine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Borrower_ID, Me.Fine})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFine.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFine.EnableHeadersVisualStyles = False
        Me.dgvFine.GridColor = System.Drawing.SystemColors.Control
        Me.dgvFine.Location = New System.Drawing.Point(41, 25)
        Me.dgvFine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvFine.Name = "dgvFine"
        Me.dgvFine.ReadOnly = True
        Me.dgvFine.RowHeadersVisible = False
        Me.dgvFine.RowHeadersWidth = 49
        Me.dgvFine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFine.RowTemplate.Height = 25
        Me.dgvFine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFine.Size = New System.Drawing.Size(605, 618)
        Me.dgvFine.TabIndex = 45
        '
        'Borrower_ID
        '
        Me.Borrower_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Borrower_ID.HeaderText = "Borrower ID"
        Me.Borrower_ID.Name = "Borrower_ID"
        Me.Borrower_ID.ReadOnly = True
        Me.Borrower_ID.Width = 122
        '
        'tpPayments
        '
        Me.tpPayments.Controls.Add(Me.Label3)
        Me.tpPayments.Controls.Add(Me.txtDescription)
        Me.tpPayments.Controls.Add(Me.lblChange)
        Me.tpPayments.Controls.Add(Me.Label2)
        Me.tpPayments.Controls.Add(Me.mskBorrowerID)
        Me.tpPayments.Controls.Add(Me.btnPay)
        Me.tpPayments.Controls.Add(Me.lblOutstanding)
        Me.tpPayments.Controls.Add(Me.Label1)
        Me.tpPayments.Controls.Add(Me.txtPayments)
        Me.tpPayments.Controls.Add(Me.cboPayment)
        Me.tpPayments.Controls.Add(Me.Label16)
        Me.tpPayments.Controls.Add(Me.Label13)
        Me.tpPayments.Controls.Add(Me.Label12)
        Me.tpPayments.Controls.Add(Me.dgvFine)
        Me.tpPayments.Location = New System.Drawing.Point(4, 29)
        Me.tpPayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpPayments.Name = "tpPayments"
        Me.tpPayments.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpPayments.Size = New System.Drawing.Size(1439, 659)
        Me.tpPayments.TabIndex = 0
        Me.tpPayments.Text = "Payments"
        Me.tpPayments.UseVisualStyleBackColor = True
        '
        'TabControlPayments
        '
        Me.TabControlPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlPayments.Controls.Add(Me.tpPayments)
        Me.TabControlPayments.Controls.Add(Me.tpHistory)
        Me.TabControlPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlPayments.Location = New System.Drawing.Point(16, 140)
        Me.TabControlPayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlPayments.Name = "TabControlPayments"
        Me.TabControlPayments.SelectedIndex = 0
        Me.TabControlPayments.Size = New System.Drawing.Size(1447, 692)
        Me.TabControlPayments.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCloseIR)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1508, 79)
        Me.Panel1.TabIndex = 7
        '
        'btnCloseIR
        '
        Me.btnCloseIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCloseIR.FlatAppearance.BorderSize = 0
        Me.btnCloseIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseIR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseIR.ForeColor = System.Drawing.Color.White
        Me.btnCloseIR.Location = New System.Drawing.Point(1344, 17)
        Me.btnCloseIR.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnCloseIR.Name = "btnCloseIR"
        Me.btnCloseIR.Size = New System.Drawing.Size(136, 39)
        Me.btnCloseIR.TabIndex = 6
        Me.btnCloseIR.Text = "&Close"
        Me.btnCloseIR.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(2845, 18)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(200, 39)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Issued / Return"
        '
        'frmPayments
        '
        Me.AcceptButton = Me.btnPay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 847)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlPayments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPayments"
        Me.Text = "frmPayments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHistory.ResumeLayout(False)
        CType(Me.dgvFine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPayments.ResumeLayout(False)
        Me.tpPayments.PerformLayout()
        Me.TabControlPayments.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Fine As DataGridViewTextBoxColumn
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mskBorrowerID As MaskedTextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents lblOutstanding As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents tpHistory As TabPage
    Friend WithEvents txtPayments As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvFine As DataGridView
    Friend WithEvents Borrower_ID As DataGridViewTextBoxColumn
    Friend WithEvents tpPayments As TabPage
    Friend WithEvents TabControlPayments As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseIR As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Payment_no As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerID As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Payment_Method As DataGridViewTextBoxColumn
    Friend WithEvents Payment_date As DataGridViewTextBoxColumn
    Friend WithEvents tot_paid As DataGridViewTextBoxColumn
    Friend WithEvents tooltipError As ToolTip
End Class
