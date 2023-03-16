Imports System.Data.SqlClient
Public Class frmReports
    Sub loadReportBorrower()
        Try
            dgvBorrowersReporting.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            If cboReportFilter.SelectedIndex = 0 Then 'Pass the value to frmPrint strSelectedBorrowerReportFilter so the report content can be filtered
                cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers ORDER BY status, fullname", con)
            ElseIf cboReportFilter.SelectedIndex = 1 Then
                cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Active' ORDER BY status, fullname", con)
            ElseIf cboReportFilter.SelectedIndex = 2 Then
                cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Deactivated' ORDER BY status, fullname", con)
            ElseIf cboReportFilter.SelectedIndex = 3 Then
                cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Male' ORDER BY status, fullname", con)
            ElseIf cboReportFilter.SelectedIndex = 4 Then
                cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Female' ORDER BY status, fullname", con)
            End If

            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvBorrowersReporting.Rows.Add(intNo, dr.Item("borrower_id").ToString, dr.Item("fullname").ToString, dr.Item("program").ToString, dr.Item("DOB").ToString, dr.Item("gender").ToString, dr.Item("contact").ToString, dr.Item("email").ToString, dr.Item("status").ToString)
                dgvBorrowersReporting.ClearSelection()
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadBookInventory()
        Try
            dgvBookInventory.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM vw_BookInventory", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvBookInventory.Rows.Add(intNo, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("yr_published").ToString, dr.Item("totalcopies").ToString, dr.Item("damaged").ToString, dr.Item("lost").ToString, dr.Item("borrowed").ToString, dr.Item("available").ToString)
                dgvBookInventory.ClearSelection()
                lblCountInventory.Text = dgvBookInventory.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub loadBookMasterlist()
        Try
            dgvMasterlist.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            If cboStatus.SelectedIndex = 0 Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & txtSearch.Text & "%' ORDER BY accession_no", con)
            ElseIf cboStatus.SelectedIndex = 1 Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & txtSearch.Text & "%' AND status='Available' ORDER BY accession_no", con)
            ElseIf cboStatus.SelectedIndex = 2 Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & txtSearch.Text & "%' AND status='Borrowed' ORDER BY accession_no", con)
            ElseIf cboStatus.SelectedIndex = 3 Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & txtSearch.Text & "%' AND status='Damaged' ORDER BY accession_no", con)
            ElseIf cboStatus.SelectedIndex = 4 Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & txtSearch.Text & "%' AND status='Lost' ORDER BY accession_no", con)
            End If
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvMasterlist.Rows.Add(intNo, dr.Item("accession_no").ToString, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("yr_published").ToString, dr.Item("publisher").ToString, dr.Item("category").ToString, dr.Item("book_price").ToString, dr.Item("status").ToString)
                dgvMasterlist.ClearSelection()
                lblCountMasterlist.Text = dgvMasterlist.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadIssueList()
        dgvIssueReturn.Rows.Clear()
        Dim intI As Integer
        con.Open()
        If cboIssueStatus.SelectedIndex = 0 Then
            cmd = New SqlCommand("SELECT * FROM tblIssue", con)
        Else
            cmd = New SqlCommand("SELECT * FROM tblIssue WHERE Status = '" & cboIssueStatus.Text & "'", con)
        End If
        dr = cmd.ExecuteReader
        While dr.Read
            intI += 1
            dgvIssueReturn.Rows.Add(intI, dr.Item("Book_Title"), dr.Item("Borrowed_Date"), dr.Item("Status"), dr.Item("Accession_ID"), dr.Item("Borrower_ID"))
        End While
        con.Close()
    End Sub
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvBorrowersReporting.Font = New Font("Calibri", 10) ' Manually set the data grid font size as the properties got bug
        Me.dgvBookInventory.Font = New Font("Calibri", 10)
        Me.dgvMasterlist.Font = New Font("Calibri", 10)
        Me.dgvIssueReturn.Font = New Font("Calibri", 10)
        cboReportFilter.SelectedIndex = 0 ' Set default filter to Show All
        cboStatus.SelectedIndex = 0
        cboIssueStatus.SelectedIndex = 0
        loadReportBorrower() ' Load Borrower's data from SQL when this form load
        loadBookMasterlist()
        loadIssueList()
        LoadPaymentReport()
    End Sub
    Private Sub cboReportFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportFilter.SelectedIndexChanged
        loadReportBorrower()
        If cboReportFilter.SelectedIndex = 0 Then 'Pass the value to frmPrint strSelectedBorrowerReportFilter so the report content can be filtered
            frmPrint.strSelectedBorrowerReportFilter = "All"
        ElseIf cboReportFilter.SelectedIndex = 1 Then
            frmPrint.strSelectedBorrowerReportFilter = "Active"
        ElseIf cboReportFilter.SelectedIndex = 2 Then
            frmPrint.strSelectedBorrowerReportFilter = "Deactivated"
        ElseIf cboReportFilter.SelectedIndex = 3 Then
            frmPrint.strSelectedBorrowerReportFilter = "Male"
        ElseIf cboReportFilter.SelectedIndex = 4 Then
            frmPrint.strSelectedBorrowerReportFilter = "Female"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnViewBorrowerReport_Click(sender As Object, e As EventArgs) Handles btnViewBorrowerReport.Click
        With frmPrint
            .TopLevel = False
            frmMain.MainPanel.Controls.Add(frmPrint)
            .showBorrowerReport()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnGenerateBorrowerReport_Click(sender As Object, e As EventArgs) Handles btnGenerateBorrowerReport.Click
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .printBorrowerReport()
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
             "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Sub dgvBookInventory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBookInventory.CellFormatting
        For i = 0 To dgvBookInventory.Rows.Count - 1
            dgvBookInventory.Rows(i).Cells(5).Style.ForeColor = Color.FromArgb(0, 0, 255) 'Total Copies
            dgvBookInventory.Rows(i).Cells(6).Style.ForeColor = Color.FromArgb(230, 0, 126) 'Damaged
            dgvBookInventory.Rows(i).Cells(7).Style.ForeColor = Color.FromArgb(136, 40, 122) 'Lost
            dgvBookInventory.Rows(i).Cells(8).Style.ForeColor = Color.FromArgb(204, 0, 0) 'Borrowed
            dgvBookInventory.Rows(i).Cells(9).Style.ForeColor = Color.FromArgb(0, 153, 0) 'Total Copies
        Next
    End Sub

    Private Sub btnPrintInventory_Click(sender As Object, e As EventArgs) Handles btnPrintInventory.Click
        With frmPrint
            .TopLevel = False
            frmMain.MainPanel.Controls.Add(frmPrint)
            .PrintBookInventory()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnInventoryPDF_Click(sender As Object, e As EventArgs) Handles btnInventoryPDF.Click
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .BookInventoryPDF()
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub dgvMasterlist_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMasterlist.CellFormatting
        For i = 0 To dgvMasterlist.Rows.Count - 1
            If dgvMasterlist.Rows(i).Cells(9).Value.ToString = "Damaged" Then
                dgvMasterlist.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(0, 32, 255)
            ElseIf dgvMasterlist.Rows(i).Cells(9).Value.ToString = "Lost" Then
                dgvMasterlist.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(248, 24, 148)
            ElseIf dgvMasterlist.Rows(i).Cells(9).Value.ToString = "Borrowed" Then
                dgvMasterlist.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(231, 47, 51)
            End If
        Next
    End Sub

    Private Sub btnPrintMasterlist_Click(sender As Object, e As EventArgs) Handles btnPrintMasterlist.Click
        With frmPrint
            .TopLevel = False
            frmMain.MainPanel.Controls.Add(frmPrint)
            .PrintBookMasterlist(txtSearch.Text)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnMasterlistPDF_Click(sender As Object, e As EventArgs) Handles btnMasterlistPDF.Click
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .BookMasterlistPDF(txtSearch.Text)
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadBookMasterlist()
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        loadBookMasterlist()
        If cboStatus.SelectedIndex = 0 Then
            frmPrint.strMasterlistStatus = "All"
        ElseIf cboStatus.SelectedIndex = 1 Then
            frmPrint.strMasterlistStatus = "Available"
        ElseIf cboStatus.SelectedIndex = 2 Then
            frmPrint.strMasterlistStatus = "Borrowed"
        ElseIf cboStatus.SelectedIndex = 3 Then
            frmPrint.strMasterlistStatus = "Damaged"
        ElseIf cboStatus.SelectedIndex = 4 Then
            frmPrint.strMasterlistStatus = "Lost"
        End If
    End Sub

    Private Sub MskBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles mskBorrowerID.TextChanged, cboIssueStatus.SelectedIndexChanged
        Dim intI As Integer
        Try
            Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
            If (mskBorrowerID.Text = "") Then
                loadIssueList()
            Else
                If cboIssueStatus.SelectedIndex = 1 Then
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "%' AND Status = 'Returned' ORDER BY Issue_ID", con)
                ElseIf cboIssueStatus.SelectedIndex = 2 Then
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "%' AND Status = 'Borrowed' ORDER BY Issue_ID", con)
                ElseIf cboIssueStatus.SelectedIndex = 3 Then
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "%' AND Status = 'Lost' ORDER BY Issue_ID", con)
                ElseIf cboIssueStatus.SelectedIndex = 4 Then
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "%' AND Status = 'Damaged' ORDER BY Issue_ID", con)
                Else
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "%' ORDER BY Issue_ID", con)
                End If
                con.Open()
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dgvIssueReturn.Rows.Clear()
                    While dr.Read
                        intI += 1
                        dgvIssueReturn.Rows.Add(intI, dr.Item("Book_Title"), dr.Item("Borrowed_Date"), dr.Item("Status"), dr.Item("Accession_ID"), dr.Item("Borrower_ID"))
                    End While
                    dr.Close()
                End If
                con.Close()
            End If

        Catch ex As Exception
            dr.Close()
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LoadPaymentReport()
        dgvPaymentList.Rows.Clear()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblPayments", con)
        dr = cmd.ExecuteReader
        While dr.Read
            dgvPaymentList.Rows.Add(dr.Item("Payment_No"), dr.Item("Borrower_ID"), dr.Item("Description"), dr.Item("Payment_mode"), dr.Item("Date"), dr.Item("Paid"))
        End While
        con.Close()
    End Sub
    Private Sub mskPaymentBorrower_TextChanged(sender As Object, e As EventArgs) Handles mskPaymentBorrower.TextChanged

        Dim strBorrowerID As String = mskPaymentBorrower.Text.ToUpper()

        If strBorrowerID = "" Then
            LoadPaymentReport()
        Else
            dgvPaymentList.Rows.Clear()
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblPayments WHERE borrower_ID Like '" & strBorrowerID & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvPaymentList.Rows.Add(dr.Item("Payment_NO"), dr.Item("Borrower_ID"), dr.Item("Description"), dr.Item("Payment_mode"), dr.Item("Date"), dr.Item("Paid"))
            End While
            dr.Close()
            con.Close()
        End If
    End Sub

    Private Sub btnPrintIssueRecord_Click(sender As Object, e As EventArgs) Handles btnPrintIssueRecord.Click
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Dim strStatus As String = cboIssueStatus.Text
        With frmPrint
            .TopLevel = False
            frmMain.MainPanel.Controls.Add(frmPrint)
            .printIssueRecord(strborrowerid, strStatus)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnPrintPaymentReport_Click(sender As Object, e As EventArgs) Handles btnPrintPaymentReport.Click
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .printPaymentRecord(strborrowerid)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnSaveIssuReport_Click(sender As Object, e As EventArgs) Handles btnSavePDFIssue.Click
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Dim strStatus As String = cboIssueStatus.Text
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .PDFIssueRecord(strborrowerid, strBookStatus)
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnPDFPayment_Click(sender As Object, e As EventArgs) Handles btnPDFPayment.Click
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .PDFPayment(strborrowerid)
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class