Imports System.Data.SqlClient
Public Class frmDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("dddd, yyyy-MM-dd")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Sub loadDashboard()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT COUNT(borrower_id) FROM tblBorrowers", con)
            lblBorrowerCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(program) FROM tblProgram", con)
            lblProgramCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(DISTINCT book_id) FROM tblBooks", con)
            lblBooksCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(accession_no) FROM tblBooks", con)
            lblCopiesCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(accession_no) FROM tblBooks WHERE status='Borrowed'", con)
            lblBorrowedCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(accession_no) FROM tblBooks WHERE status='Returned'", con)
            lblReturnedCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(category) FROM tblCategory", con)
            lblCategoryCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(accession_no) FROM tblBooks WHERE status='Damaged'", con)
            lblDamagedCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(accession_no) FROM tblBooks WHERE status='Lost'", con)
            lblLostCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(issue_ID) FROM tblIssue WHERE Due_Date < '" & Date.Today.ToString("dd/MMM/yyyy") & "' AND Status = 'Borrowed'", con)
            lblOverdueCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT COUNT(Borrower_ID) FROM tblBorrowers WHERE fine > 0 ", con)
            lblUnpaidFineCount.Text = cmd.ExecuteScalar.ToString
            con.Close()

            con.Open()
            cmd = New SqlCommand("SELECT SUM(Fine) FROM tblBorrowers", con)
            lblTotalFine.Text = cmd.ExecuteScalar.ToString
            con.Close()

        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class