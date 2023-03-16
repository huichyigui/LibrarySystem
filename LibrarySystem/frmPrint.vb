Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode.Codec
Public Class frmPrint
    Private ds As New LibrarySystem
    Public strSelectedBorrowerReportFilter As String
    Public strMasterlistStatus As String
    Sub PrintQRCode(book_id As String)
        Try
            con.Open()
            cmd = New SqlCommand("SELECT accession_no, book_title, author, yr_published, publisher FROM tblBooks WHERE book_id LIKE '" & book_id & "' AND status = 'Available' ", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim qrCodeEncoder As New QRCodeEncoder

                Dim strType As String = "byte"
                If strType = "byte" Then
                    qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
                End If

                qrCodeEncoder.QRCodeVersion = 7
                qrCodeEncoder.QRCodeScale = 5
                qrCodeEncoder.QRCodeForegroundColor = Color.Black

                Dim errorCorrect As String = "M"
                If errorCorrect = "M" Then
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
                End If

                Dim str As String = dr.Item("accession_no").ToString & Environment.NewLine &
                    dr.Item("book_title").ToString & Environment.NewLine &
                    dr.Item("author").ToString & Environment.NewLine &
                    dr.Item("yr_published").ToString & Environment.NewLine &
                    dr.Item("publisher").ToString & Environment.NewLine
                Dim imgQR As Image = qrCodeEncoder.Encode(str)
                Dim ms As New System.IO.MemoryStream
                imgQR.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Dim arrImage() As Byte = ms.ToArray

                Dim label As String = dr.Item("accession_no").ToString
                ds.Tables("dtQRCode").Rows.Add(arrImage, label)
            End While
            dr.Close()
            con.Close()

            Dim rpt As New rptPrintQRCode
            rpt.Load(Application.StartupPath & "\Reports\rptPrintQRCode")
            rpt.SetDataSource(ds.Tables("dtQRCode"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Show Borrower's Report with Crystal Report Viewer
    Sub showBorrowerReport()
        Try
            con.Open()
            If strSelectedBorrowerReportFilter = "Active" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Active' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Deactivated" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Deactivated' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Male" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Male' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Female" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Female' ORDER BY status, fname", con)
            Else
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers ORDER BY status, fname", con)
            End If

            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("tblBorrowers"))
            con.Close()

            Dim rpt As New rptBorrowersReport
            rpt.Load(Application.StartupPath & "\Reports\rptBorrowersReport")
            rpt.SetDataSource(ds.Tables("tblBorrowers"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()

        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Export Borrower's Report in PDF and save in PC Local Disk
    Sub printBorrowerReport()
        Try
            con.Open()
            If strSelectedBorrowerReportFilter = "Active" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Active' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Deactivated" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE status='Deactivated' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Male" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Male' ORDER BY status, fname", con)
            ElseIf strSelectedBorrowerReportFilter = "Female" Then
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE gender='Female' ORDER BY status, fname", con)
            Else
                cmd = New SqlCommand("SELECT borrower_id, fname, lname, program, DOB, gender, contact, email, status FROM tblBorrowers ORDER BY status, fname", con)
            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("tblBorrowers"))
            con.Close()

            Dim rpt As New rptBorrowersReport
            rpt.Load(Application.StartupPath & "\Reports\rptBorrowersReport")
            rpt.SetDataSource(ds.Tables("tblBorrowers"))
            CrystalReportViewer1.ReportSource = rpt

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)

            MessageBox.Show("PDF Successfully Generated. ", "Save As PDF", MessageBoxButtons.OK)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub PrintBookInventory()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM vw_BookInventory", con)
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtBookInventory"))
            con.Close()

            Dim rpt As New rptBookInventory
            rpt.Load(Application.StartupPath & "\Reports\rptBookInventory.rpt")
            rpt.SetDataSource(ds.Tables("dtBookInventory"))
            rpt.SetParameterValue("User", strFullName)
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BookInventoryPDF()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM vw_BookInventory", con)
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtBookInventory"))
            con.Close()

            Dim rpt As New rptBookInventory
            rpt.Load(Application.StartupPath & "\Reports\rptBookInventory.rpt")
            rpt.SetDataSource(ds.Tables("dtBookInventory"))
            rpt.SetParameterValue("User", strFullName)
            CrystalReportViewer1.ReportSource = rpt

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)

            MessageBox.Show("PDF Successfully Generated. ", "Save As PDF", MessageBoxButtons.OK)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PrintBookMasterlist(book_title As String)
        Try
            con.Open()
            If strMasterlistStatus = "Available" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Available' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Borrowed" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Borrowed' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Damaged" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Damaged' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Lost" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Lost' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "All" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' ORDER BY accession_no", con)
            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtBookMasterlist"))
            con.Close()

            Dim rpt As New rptBookMasterlist
            rpt.Load(Application.StartupPath & "\Reports\rptBookMasterlist.rpt")
            rpt.SetDataSource(ds.Tables("dtBookMasterlist"))
            rpt.SetParameterValue("User", strFullName)
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub printIssueRecord(strborrowerid As String, strStatus As String)
        Try
            con.Open()
            If strStatus = "All" Then
                If (strborrowerid = "") Then
                    cmd = New SqlCommand("select * FROM tblIssue", con)
                Else
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "'", con)
                End If
            Else
                If (strborrowerid = "") Then
                    cmd = New SqlCommand("select * FROM tblIssue WHERE status = '" & strStatus & "'", con)
                Else
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "' AND Status ='" & strStatus & "'", con)
                End If
            End If

            If (strborrowerid = "") Then
                cmd = New SqlCommand("select * FROM tblIssue", con)
            Else

            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtIssue"))
            con.Close()

            Dim rpt As New rptIssueRecord
            rpt.Load(Application.StartupPath & "\Reports\rptIssueRecord.rpt")
            rpt.SetDataSource(ds.Tables("dtIssue"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PDFIssueRecord(strborrowerid As String, strStatus As String)
        Try
            con.Open()
            If strStatus = "All" Then
                If (strborrowerid = "") Then
                    cmd = New SqlCommand("select * FROM tblIssue", con)
                Else
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "'", con)
                End If
            Else
                If (strborrowerid = "") Then
                    cmd = New SqlCommand("select * FROM tblIssue WHERE status = '" & strStatus & "'", con)
                Else
                    cmd = New SqlCommand("SELECT * FROM tblIssue WHERE borrower_id LIKE '" & strborrowerid & "' AND Status ='" & strStatus & "'", con)
                End If
            End If

            If (strborrowerid = "") Then
                cmd = New SqlCommand("select * FROM tblIssue", con)
            Else

            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtIssue"))
            con.Close()

            Dim rpt As New rptIssueRecord
            rpt.Load(Application.StartupPath & "\Reports\rptIssueRecord.rpt")
            rpt.SetDataSource(ds.Tables("dtIssue"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub printPaymentRecord(strborrowerid As String)
        Try
            con.Open()
            If (strborrowerid = "") Then
                cmd = New SqlCommand("select * FROM tblPayments", con)
            Else
                cmd = New SqlCommand("SELECT * FROM tblPayments WHERE borrower_id LIKE '" & strborrowerid & "'", con)
            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtPayment"))
            con.Close()

            Dim rpt As New rptPayments
            rpt.Load(Application.StartupPath & "\Reports\rptPayments.rpt")
            rpt.SetDataSource(ds.Tables("dtPayment"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PDFPayment(strborrowerid As String)
        Try
            con.Open()
            If (strborrowerid = "") Then
                cmd = New SqlCommand("select * FROM tblPayments", con)
            Else
                cmd = New SqlCommand("SELECT * FROM tblPayments WHERE borrower_id LIKE '" & strborrowerid & "'", con)
            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtPayment"))
            con.Close()

            Dim rpt As New rptPayments
            rpt.Load(Application.StartupPath & "\Reports\rptPayments.rpt")
            rpt.SetDataSource(ds.Tables("dtPayment"))
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub BookMasterlistPDF(book_title As String)
        Try
            con.Open()
            If strMasterlistStatus = "Available" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Available' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Borrowed" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Borrowed' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Damaged" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Damaged' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "Lost" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' AND status='Lost' ORDER BY accession_no", con)
            ElseIf strMasterlistStatus = "All" Then
                cmd = New SqlCommand("SELECT accession_no, book_id, book_title, author, yr_published, publisher, category, book_price, status FROM tblBooks WHERE book_title LIKE '%" & book_title & "%' ORDER BY accession_no", con)
            End If
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtBookMasterlist"))
            con.Close()

            Dim rpt As New rptBookMasterlist
            rpt.Load(Application.StartupPath & "\Reports\rptBookMasterlist.rpt")
            rpt.SetDataSource(ds.Tables("dtBookMasterlist"))
            rpt.SetParameterValue("User", strFullName)
            CrystalReportViewer1.ReportSource = rpt

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)

            MessageBox.Show("PDF Successfully Generated. ", "Save As PDF", MessageBoxButtons.OK)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub printActivityLog(name As String, dateFrom As String, dateTo As String)
        Try
            con.Open()
            cmd = New SqlCommand("SELECT username, name, dateIn, timeIn, dateOut, timeOut FROM vw_activityLog WHERE dateOut IS NOT NULL AND timeOut IS NOT NULL AND name LIKE '%" & name & "%' AND dateIn BETWEEN '" & dateFrom & "' AND '" & dateTo & "' ORDER BY dateIn ", con)
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtActivityLog"))
            con.Close()

            Dim rpt As New rptActivityLog
            rpt.Load(Application.StartupPath & "\Reports\rptActivityLog.rpt")
            rpt.SetDataSource(ds.Tables("dtActivityLog"))
            rpt.SetParameterValue("User", strFullName)
            rpt.SetParameterValue("StartDate", strLogFrom)
            rpt.SetParameterValue("ToDate", strLogTo)
            CrystalReportViewer1.ReportSource = rpt
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ActivityLogPDF(name As String, dateFrom As String, dateTo As String)
        Try
            con.Open()
            cmd = New SqlCommand("SELECT username, name, dateIn, timeIn, dateOut, timeOut FROM vw_activityLog WHERE dateOut IS NOT NULL AND timeOut IS NOT NULL AND name LIKE '%" & name & "%' AND dateIn BETWEEN '" & dateFrom & "' AND '" & dateTo & "' ORDER BY dateIn ", con)
            da = New SqlDataAdapter(cmd)
            ds = New LibrarySystem
            ds.Clear()
            da.Fill(ds.Tables("dtActivityLog"))
            con.Close()

            Dim rpt As New rptActivityLog
            rpt.Load(Application.StartupPath & "\Reports\rptActivityLog.rpt")
            rpt.SetDataSource(ds.Tables("dtActivityLog"))
            rpt.SetParameterValue("User", strFullName)
            rpt.SetParameterValue("StartDate", dateFrom)
            rpt.SetParameterValue("ToDate", dateTo)
            CrystalReportViewer1.ReportSource = rpt

            rpt.PrintOptions.PrinterName = "Microsoft Print to PDF"
            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintToPrinter(1, False, 0, 0)

            MessageBox.Show("PDF Successfully Generated. ", "Save As PDF", MessageBoxButtons.OK)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class