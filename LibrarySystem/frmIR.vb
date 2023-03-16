Imports System.Data.SqlClient
Imports System.Text

Public Class frmIR
    Dim exist_borrowerid, exist_accessionid As Boolean
    Dim intMaxDay As Integer
    Dim dblFine As Double
    Dim intMaxBook As Integer
    Dim errBorrow As New StringBuilder()

    Private Sub frmIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current settings for borrow limit, fine and max date and fine
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblSettings", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                intMaxDay = CInt(dr.Item("days_allowed"))
                intMaxBook = CInt(dr.Item("books_allowed"))
                dblFine = CDbl(Format(dr.Item("penalty"), "#,##0.00"))
                lblDaysAllowed.Text = intMaxDay.ToString
                lblBooksAllowed.Text = intMaxBook.ToString
                lblPenalty.Text = CDec(dr.Item("penalty")).ToString("N2")
            End If
            dr.Close()
            con.Close()
            showissuerecord()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try

        dtpDueDate.CustomFormat = "dd/MMM/yyyy"
        dtpDueDate.MaxDate = dtpDueDate.Value.AddDays(intMaxDay)
        dtpDueDate.MinDate = Date.Today.AddDays(1)
    End Sub
    Private Sub btnCloseIR_Click(sender As Object, e As EventArgs) Handles btnCloseIR.Click 'close the window
        Me.Close()
    End Sub

    Private Sub MskBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles mskBorrowerID.TextChanged 'search for borrower details
        Try
            Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
            con.Open()
            cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) as name, program, email, gender, status, contact FROM tblBorrowers WHERE borrower_id LIKE '" & strborrowerid & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lblName.Text = dr.Item("name").ToString
                    lblProgram.Text = dr.Item("program").ToString
                    lblEmail.Text = dr.Item("email").ToString
                    lblBorrowerStatus.Text = dr.Item("status").ToString
                    lblGender.Text = dr.Item("Gender").ToString
                    lblContact.Text = dr.Item("contact").ToString
                    tooltipError.Hide(mskBorrowerID)
                    exist_borrowerid = True
                End While
                dr.Close()
            Else
                lblName.Text = ""
                lblProgram.Text = ""
                lblEmail.Text = ""
                lblBorrowerStatus.Text = ""
                lblContact.Text = ""
                tooltipError.Show("The borrower ID does not exists in the database", mskBorrowerID)
                exist_borrowerid = False
            End If
            con.Close()
            showissuerecord()
        Catch ex As Exception
            dr.Close()
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtAccessionID_TextChanged(sender As Object, e As EventArgs) Handles txtAccessionID.TextChanged 'search for book details'
        Try
            Dim strAccessionNo As String = txtAccessionID.Text.Trim().ToUpper
            con.Open()
            cmd = New SqlCommand("SELECT book_id, accession_no, category, book_title, author, yr_published AS year, publisher, book_price, status FROM tblBooks WHERE accession_no LIKE '" & strAccessionNo & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lblBookID.Text = dr.Item("book_id").ToString
                    lblBookTitle.Text = dr.Item("book_title").ToString
                    lblAuthor.Text = dr.Item("author").ToString
                    lblBookPrice.Text = dr.Item("book_price").ToString
                    lblCategory.Text = dr.Item("category").ToString
                    lblBookStatus.Text = dr.Item("status").ToString
                    tooltipError.Hide(txtAccessionID)
                    exist_accessionid = True
                End While
                dr.Close()
                con.Close()
                showissuerecord()
            ElseIf txtAccessionID.Text.Length() <> 9 Then
                lblBookID.Text = ""
                lblBookTitle.Text = ""
                lblAuthor.Text = ""
                lblBookPrice.Text = ""
                lblCategory.Text = ""
                lblBookStatus.Text = ""
                tooltipError.Show("The Accession Number does not exists in the database.", txtAccessionID)
                exist_accessionid = False
            Else
                tooltipError.Show("The Accession Number does not exists in the database.", txtAccessionID)
                exist_accessionid = False
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try
    End Sub

    Sub clearall()
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblAuthor.Text = ""
        lblBookPrice.Text = ""
        lblCategory.Text = ""
        lblBookStatus.Text = ""
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblAuthor.Text = ""
        lblBookPrice.Text = ""
        lblBookStatus.Text = ""
        mskBorrowerID.Text = ""
        showissuerecord()
    End Sub


    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click 'verify, validate and update the issue records of borrowed books'
        Dim intIssueID As Integer = 1
        Try
            If (exist_accessionid = True) And (exist_borrowerid = True) Then 'check if the accessionid and borrower id exists.
                If (checkvalidity()) Then 'check number of book borrowed
                    con.Open()
                    cmd = New SqlCommand("SELECT * FROM tblIssue", con)
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            intIssueID += 1
                        End While
                    Else
                        intIssueID = 1
                        dr.Close()
                    End If
                    dr.Close()
                    con.Close()
                    issuebook(intIssueID)
                Else
                    MessageBox.Show(errBorrow.ToString)
                End If

            ElseIf (exist_borrowerid = False) Then
                tooltipError.Show("Please Enter a valid ID", mskBorrowerID)
                mskBorrowerID.Focus()
            ElseIf (exist_accessionid = False) Then
                tooltipError.Show("Please Enter a valid ID", txtAccessionID)
                txtAccessionID.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try

    End Sub

    Private Function checkvalidity() As Boolean 'check validity of current book'
        Dim intCount As Integer = 0
        Dim boolUnavailable As Boolean = True
        errBorrow.Clear()
        con.Open()
        'get borrowed book count of borrower'
        cmd = New SqlCommand("SELECT * FROM tblIssue WHERE status = 'Borrowed'  AND borrower_ID = '" & mskBorrowerID.Text.ToUpper & "'", con)
        dr = cmd.ExecuteReader
        While dr.Read
            intCount += 1
        End While
        dr.Close()
        con.Close()
        'check the validity of the borrower and book.
        If (lblBookStatus.Text = "Borrowed" Or lblBookStatus.Text = "Damaged" Or lblBookStatus.Text = "Lost") Then
            con.Open()
            errBorrow.Append("the book is currently " & lblBookStatus.Text)
            dr.Close()
            con.Close()
            Return False
        ElseIf (lblBorrowerStatus.Text = "Deactivated") Then
            errBorrow.Append("The Borrower ID is currently inactive")
            Return False
        ElseIf (intCount < intMaxBook) Then
            Return True
        Else
            errBorrow.Append("The current book limit has been reached" & vbNewLine &
                            "Please Return previous book before borrowing another book.")
            Return False
        End If

    End Function

    Sub issuebook(intIssueID As Integer)
        Dim todate As Date = Date.Today
        Dim duedate As Date = dtpDueDate.Value

        con.Open()
        cmd = New SqlCommand("INSERT INTO tblIssue VALUES(@issue_ID, @Book_ID, @Book_Title, @Borrowed_Date, @Due_Date, @Status, @Price, @Borrower_ID, @Accession_ID)", con)
        With cmd
            .Parameters.AddWithValue("@issue_ID", "IS" + intIssueID.ToString("D6"))
            .Parameters.AddWithValue("@Book_ID", lblBookID.Text)
            .Parameters.AddWithValue("@Book_Title", lblBookTitle.Text)
            .Parameters.AddWithValue("@Borrowed_Date", todate.ToString("dd/MMM/yyyy"))
            .Parameters.AddWithValue("@Due_Date", duedate.ToString("dd/MMM/yyyy"))
            .Parameters.AddWithValue("@Status", "Borrowed")
            .Parameters.AddWithValue("@Price", lblBookPrice.Text)
            .Parameters.AddWithValue("@Borrower_ID", mskBorrowerID.Text.ToUpper)
            .Parameters.AddWithValue("@Accession_ID", txtAccessionID.Text.ToUpper)
            .ExecuteNonQuery()
        End With
        con.Close()
        showissuerecord()
        con.Open()
        MessageBox.Show("The book has been succesfully borrowed For " & DateDiff(DateInterval.Day, todate, duedate) & " days.", "Success!", MessageBoxButtons.OK)
        'update the status of the book in book table.
        cmd = New SqlCommand("UPDATE tblBooks SET status = 'Borrowed' WHERE accession_no = '" & txtAccessionID.Text.ToUpper & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
        lblBookStatus.Text = "Borrowed"
    End Sub

    Sub showissuerecord()
        dgvIssueReturn.Rows.Clear()
        Dim i As Integer = 0
        Dim str_id As String = mskBorrowerID.Text.ToUpper
        con.Open()
        If (exist_borrowerid) Then
            cmd = New SqlCommand("Select * FROM tblIssue WHERE borrower_ID Like '" & str_id & "'" & "ORDER BY Borrowed_date DESC", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgvIssueReturn.Rows.Add(i, dr.Item("Issue_ID").ToString, dr.Item("Book_ID").ToString, dr.Item("Book_Title").ToString, dr.Item("Borrowed_Date").ToString, dr.Item("Due_Date").ToString, dr.Item("Status").ToString, dr.Item("Price").ToString, dr.Item("accession_ID").ToString, dr.Item("Borrower_ID"))
            End While
            dr.Close()
        Else
            cmd = New SqlCommand("Select * FROM tblIssue ORDER BY Borrowed_date DESC", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                dgvIssueReturn.Rows.Add(i, dr.Item("Issue_ID").ToString, dr.Item("Book_ID").ToString, dr.Item("Book_Title").ToString, dr.Item("Borrowed_Date").ToString, dr.Item("Due_Date").ToString, dr.Item("Status").ToString, dr.Item("Price").ToString, dr.Item("accession_ID").ToString, dr.Item("Borrower_ID"))
            End While
        End If
        con.Close()

    End Sub

    Private Sub dgvIssueReturn_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIssueReturn.CellContentDoubleClick
        Dim strStatus As String = dgvIssueReturn.CurrentRow.Cells(6).Value.ToString
        If (strStatus = "Borrowed") Then
            strIssueID = dgvIssueReturn.CurrentRow.Cells(1).Value.ToString 'store the books issue id to be returned'
            With frmReturnbook
                .txtIssueID.Enabled = False
                .ShowDialog()
            End With
            txtAccessionID.Text = dgvIssueReturn.CurrentRow.Cells(8).Value.ToString
            showissuerecord()
            lblBookStatus.Text = strBookStatus
        Else
            MessageBox.Show("Cannot Return Book." & vbNewLine & "The book has already been returned, lost or damaged.")
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mskBorrowerID.Text = ""
        lblName.Text = ""
        lblProgram.Text = ""
        lblEmail.Text = ""
        lblBorrowerStatus.Text = ""
        lblContact.Text = ""
        txtAccessionID.Text = ""
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblAuthor.Text = ""
        lblBookPrice.Text = ""
        lblCategory.Text = ""
        lblBookStatus.Text = ""
    End Sub

    'show borrower
    Private Sub llkBorrower_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llkBorrower.LinkClicked
        frmIssueBrowseBorrowers.ShowDialog()
    End Sub
    'show books
    Private Sub llkBookBrowser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llkBookBrowser.LinkClicked
        frmIssueBrowseBooks.ShowDialog()
    End Sub
End Class