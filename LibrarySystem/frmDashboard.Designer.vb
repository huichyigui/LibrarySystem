<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBorrowerCount = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBookCount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBorrowedCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDamagedCount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblProgramCount = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblBooksCount = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblReturnedCount = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblCategoryCount = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblLostCount = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTotalFine = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblCopiesCount = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblOverdueCount = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblUnpaidFineCount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 142)
        Me.Label1.TabIndex = 39
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 29)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Dashboard"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "BORROWERS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrowerCount
        '
        Me.lblBorrowerCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBorrowerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowerCount.ForeColor = System.Drawing.Color.White
        Me.lblBorrowerCount.Location = New System.Drawing.Point(46, 190)
        Me.lblBorrowerCount.Name = "lblBorrowerCount"
        Me.lblBorrowerCount.Size = New System.Drawing.Size(158, 25)
        Me.lblBorrowerCount.TabIndex = 42
        Me.lblBorrowerCount.Text = "0"
        Me.lblBorrowerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(505, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(438, 50)
        Me.lblDate.TabIndex = 43
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(565, 59)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(378, 41)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(245, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 142)
        Me.Label4.TabIndex = 45
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookCount
        '
        Me.lblBookCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookCount.BackColor = System.Drawing.Color.SteelBlue
        Me.lblBookCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCount.ForeColor = System.Drawing.Color.White
        Me.lblBookCount.Location = New System.Drawing.Point(483, 148)
        Me.lblBookCount.Name = "lblBookCount"
        Me.lblBookCount.Size = New System.Drawing.Size(230, 142)
        Me.lblBookCount.TabIndex = 46
        Me.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SlateBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(7, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(230, 142)
        Me.Label10.TabIndex = 47
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SlateBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(10, 424)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 25)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "BOOKS BORROWED"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrowedCount
        '
        Me.lblBorrowedCount.BackColor = System.Drawing.Color.SlateBlue
        Me.lblBorrowedCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowedCount.ForeColor = System.Drawing.Color.White
        Me.lblBorrowedCount.Location = New System.Drawing.Point(36, 337)
        Me.lblBorrowedCount.Name = "lblBorrowedCount"
        Me.lblBorrowedCount.Size = New System.Drawing.Size(168, 25)
        Me.lblBorrowedCount.TabIndex = 49
        Me.lblBorrowedCount.Text = "Count"
        Me.lblBorrowedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(245, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 142)
        Me.Label7.TabIndex = 50
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(483, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 142)
        Me.Label6.TabIndex = 51
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(7, 465)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(230, 142)
        Me.Label15.TabIndex = 52
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 578)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(218, 25)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "DAMAGED"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDamagedCount
        '
        Me.lblDamagedCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblDamagedCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblDamagedCount.ForeColor = System.Drawing.Color.White
        Me.lblDamagedCount.Location = New System.Drawing.Point(36, 494)
        Me.lblDamagedCount.Name = "lblDamagedCount"
        Me.lblDamagedCount.Size = New System.Drawing.Size(168, 25)
        Me.lblDamagedCount.TabIndex = 54
        Me.lblDamagedCount.Text = "Count"
        Me.lblDamagedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(245, 465)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 142)
        Me.Label12.TabIndex = 55
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(483, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 142)
        Me.Label11.TabIndex = 56
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(250, 262)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(225, 25)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "PROGRAM"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProgramCount
        '
        Me.lblProgramCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblProgramCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblProgramCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblProgramCount.ForeColor = System.Drawing.Color.White
        Me.lblProgramCount.Location = New System.Drawing.Point(281, 190)
        Me.lblProgramCount.Name = "lblProgramCount"
        Me.lblProgramCount.Size = New System.Drawing.Size(168, 25)
        Me.lblProgramCount.TabIndex = 58
        Me.lblProgramCount.Text = "Count"
        Me.lblProgramCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.BackColor = System.Drawing.Color.SteelBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(508, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(197, 25)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "BOOKS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBooksCount
        '
        Me.lblBooksCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBooksCount.BackColor = System.Drawing.Color.SteelBlue
        Me.lblBooksCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblBooksCount.ForeColor = System.Drawing.Color.White
        Me.lblBooksCount.Location = New System.Drawing.Point(522, 190)
        Me.lblBooksCount.Name = "lblBooksCount"
        Me.lblBooksCount.Size = New System.Drawing.Size(168, 25)
        Me.lblBooksCount.TabIndex = 60
        Me.lblBooksCount.Text = "Count"
        Me.lblBooksCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(250, 424)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(208, 25)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "BOOKS RETURNED"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturnedCount
        '
        Me.lblReturnedCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblReturnedCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblReturnedCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblReturnedCount.ForeColor = System.Drawing.Color.White
        Me.lblReturnedCount.Location = New System.Drawing.Point(281, 337)
        Me.lblReturnedCount.Name = "lblReturnedCount"
        Me.lblReturnedCount.Size = New System.Drawing.Size(168, 25)
        Me.lblReturnedCount.TabIndex = 62
        Me.lblReturnedCount.Text = "Count"
        Me.lblReturnedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(508, 424)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(199, 25)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "CATEGORY"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategoryCount
        '
        Me.lblCategoryCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategoryCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.lblCategoryCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCategoryCount.ForeColor = System.Drawing.Color.White
        Me.lblCategoryCount.Location = New System.Drawing.Point(522, 337)
        Me.lblCategoryCount.Name = "lblCategoryCount"
        Me.lblCategoryCount.Size = New System.Drawing.Size(168, 25)
        Me.lblCategoryCount.TabIndex = 64
        Me.lblCategoryCount.Text = "Count"
        Me.lblCategoryCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(245, 578)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(230, 25)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "LOST"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLostCount
        '
        Me.lblLostCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLostCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblLostCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblLostCount.ForeColor = System.Drawing.Color.White
        Me.lblLostCount.Location = New System.Drawing.Point(281, 494)
        Me.lblLostCount.Name = "lblLostCount"
        Me.lblLostCount.Size = New System.Drawing.Size(168, 25)
        Me.lblLostCount.TabIndex = 66
        Me.lblLostCount.Text = "Count"
        Me.lblLostCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(488, 567)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(221, 40)
        Me.Label27.TabIndex = 67
        Me.Label27.Text = "Total Fine(RM)"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalFine
        '
        Me.lblTotalFine.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalFine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblTotalFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalFine.ForeColor = System.Drawing.Color.White
        Me.lblTotalFine.Location = New System.Drawing.Point(522, 494)
        Me.lblTotalFine.Name = "lblTotalFine"
        Me.lblTotalFine.Size = New System.Drawing.Size(168, 25)
        Me.lblTotalFine.TabIndex = 68
        Me.lblTotalFine.Text = "Count"
        Me.lblTotalFine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(720, 148)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(230, 142)
        Me.Label36.TabIndex = 69
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(720, 307)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(230, 142)
        Me.Label35.TabIndex = 70
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(720, 465)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(230, 142)
        Me.Label34.TabIndex = 71
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(737, 262)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(207, 25)
        Me.Label33.TabIndex = 72
        Me.Label33.Text = "TOTAL COPIES"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopiesCount
        '
        Me.lblCopiesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopiesCount.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblCopiesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCopiesCount.ForeColor = System.Drawing.Color.White
        Me.lblCopiesCount.Location = New System.Drawing.Point(755, 190)
        Me.lblCopiesCount.Name = "lblCopiesCount"
        Me.lblCopiesCount.Size = New System.Drawing.Size(168, 25)
        Me.lblCopiesCount.TabIndex = 73
        Me.lblCopiesCount.Text = "Count"
        Me.lblCopiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(737, 424)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(194, 25)
        Me.Label31.TabIndex = 74
        Me.Label31.Text = "OVERDUE"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverdueCount
        '
        Me.lblOverdueCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOverdueCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOverdueCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblOverdueCount.ForeColor = System.Drawing.Color.White
        Me.lblOverdueCount.Location = New System.Drawing.Point(755, 337)
        Me.lblOverdueCount.Name = "lblOverdueCount"
        Me.lblOverdueCount.Size = New System.Drawing.Size(168, 25)
        Me.lblOverdueCount.TabIndex = 75
        Me.lblOverdueCount.Text = "Count"
        Me.lblOverdueCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(755, 578)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(176, 25)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "Unpaid Fine"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUnpaidFineCount
        '
        Me.lblUnpaidFineCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnpaidFineCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUnpaidFineCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblUnpaidFineCount.ForeColor = System.Drawing.Color.White
        Me.lblUnpaidFineCount.Location = New System.Drawing.Point(755, 494)
        Me.lblUnpaidFineCount.Name = "lblUnpaidFineCount"
        Me.lblUnpaidFineCount.Size = New System.Drawing.Size(168, 25)
        Me.lblUnpaidFineCount.TabIndex = 77
        Me.lblUnpaidFineCount.Text = "Count"
        Me.lblUnpaidFineCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 741)
        Me.Controls.Add(Me.lblUnpaidFineCount)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lblOverdueCount)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lblCopiesCount)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.lblTotalFine)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblLostCount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblCategoryCount)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblReturnedCount)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblBooksCount)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblProgramCount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblDamagedCount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblBorrowedCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblBookCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblBorrowerCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblBorrowerCount As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBookCount As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBorrowedCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDamagedCount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblProgramCount As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblBooksCount As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblReturnedCount As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblCategoryCount As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblLostCount As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblTotalFine As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblCopiesCount As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblOverdueCount As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblUnpaidFineCount As Label
    Friend WithEvents Timer1 As Timer
End Class
