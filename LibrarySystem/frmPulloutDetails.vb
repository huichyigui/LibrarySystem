Imports System.Data.SqlClient
Public Class frmPulloutDetails
    Sub bindBook()
        Try
            dgvBook.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblBooks WHERE status <> 'Damaged' AND status <> 'Lost' AND book_title LIKE '%" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvBook.Rows.Add(intNo, dr.Item("book_id").ToString, dr.Item("accession_no").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("category").ToString, dr.Item("yr_published").ToString, dr.Item("publisher").ToString, dr.Item("book_price").ToString)
                dgvBook.ClearSelection()
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub bindStudent()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblBorrowers WHERE borrower_id LIKE '" & txtBorrowerID.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblFName.Invoke(Sub() lblFName.Text = dr.Item("fname").ToString)
                lblLName.Invoke(Sub() lblLName.Text = dr.Item("lname").ToString)
                lblEmail.Invoke(Sub() lblEmail.Text = dr.Item("email").ToString)
                lblContact.Invoke(Sub() lblContact.Text = dr.Item("contact").ToString)
                lblProgram.Invoke(Sub() lblProgram.Text = dr.Item("program").ToString)
            Else
                lblFName.Invoke(Sub() lblFName.Text = "")
                lblLName.Invoke(Sub() lblLName.Text = "")
                lblEmail.Invoke(Sub() lblEmail.Text = "")
                lblContact.Invoke(Sub() lblContact.Text = "")
                lblProgram.Invoke(Sub() lblProgram.Text = "")
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ResetForm()
        lblBookID.Text = ""
        lblAccessionNo.Text = ""
        lblBookTitle.Text = ""
        lblCategory.Text = ""
        lblAuthor.Text = ""
        lblPublisher.Text = ""
        lblYearPublished.Text = ""
        lblBookPrice.Text = ""
        txtBorrowerID.Clear()
        lblFName.Text = ""
        lblLName.Text = ""
        lblEmail.Text = ""
        lblContact.Text = ""
        lblProgram.Text = ""
        cboAction.SelectedIndex = -1
        txtRemarks.Clear()
        txtSearch.Select()
    End Sub
    Private Sub cboAction_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAction.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bindBook()
    End Sub

    Private Sub dgvBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBook.CellContentClick
        Try
            Dim colName As String = dgvBook.Columns(e.ColumnIndex).Name
            If colName = "colSelect" Then
                lblBookID.Text = dgvBook.Rows(e.RowIndex).Cells(1).Value.ToString()
                lblAccessionNo.Text = dgvBook.Rows(e.RowIndex).Cells(2).Value.ToString()
                lblBookTitle.Text = dgvBook.Rows(e.RowIndex).Cells(3).Value.ToString()
                lblAuthor.Text = dgvBook.Rows(e.RowIndex).Cells(4).Value.ToString()
                lblCategory.Text = dgvBook.Rows(e.RowIndex).Cells(5).Value.ToString()
                lblYearPublished.Text = dgvBook.Rows(e.RowIndex).Cells(6).Value.ToString()
                lblPublisher.Text = dgvBook.Rows(e.RowIndex).Cells(7).Value.ToString()
                lblBookPrice.Text = dgvBook.Rows(e.RowIndex).Cells(8).Value.ToString()
                txtBorrowerID.Select()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowerID.TextChanged
        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        bindStudent()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
    End Sub

    Private Sub btnPullout_Click(sender As Object, e As EventArgs) Handles btnPullout.Click
        Try
            Dim strRemarks As String = txtRemarks.Text
            Dim strMsg1 As String = "Book Title: " & lblBookTitle.Text &
                Environment.NewLine & "Book ID: " & lblBookID.Text &
                Environment.NewLine & "Accession No: " & lblAccessionNo.Text &
                Environment.NewLine & "Author: " & lblAuthor.Text &
                Environment.NewLine & "Book Price (RM): " & lblBookPrice.Text &
                Environment.NewLine & "Are You Sure You Want To Pullout This Book?"
            Dim strMsg2 As String = "Book Title: " & lblBookTitle.Text &
                Environment.NewLine & "Book ID: " & lblBookID.Text &
                Environment.NewLine & "Accession No: " & lblAccessionNo.Text &
                Environment.NewLine & "Author: " & lblAuthor.Text &
                Environment.NewLine & "Book Price (RM): " & lblBookPrice.Text &
                Environment.NewLine & "The book has been pulled out."
            If isEmpty(txtBorrowerID.Text) = True Then Return
            If isEmpty(cboAction.Text) = True Then Return
            If txtRemarks.Text = "" Then
                strRemarks = "N/A"
            End If
            If MessageBox.Show(strMsg1, "Confirm Pullout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("INSERT INTO tblPullout (accession_no, borrower_id, action, remarks, date, pullout_by) VALUES (@accession_no, @borrower_id, @action, @remarks, @date, @pullout_by)", con)
                With cmd
                    .Parameters.AddWithValue("@accession_no", lblAccessionNo.Text)
                    .Parameters.AddWithValue("@borrower_id", txtBorrowerID.Text)
                    .Parameters.AddWithValue("@action", cboAction.Text)
                    .Parameters.AddWithValue("@remarks", Trim(strRemarks))
                    .Parameters.AddWithValue("@date", Now.ToString)
                    .Parameters.AddWithValue("@pullout_by", strFullName)
                    .ExecuteNonQuery()
                End With
                con.Close()

                UpdateRecord("UPDATE tblBooks SET status = '" & cboAction.Text & "' WHERE accession_no LIKE '" & lblAccessionNo.Text & "'")
                MessageBox.Show(strMsg2)

                frmPulloutBook.bindPullout()
                frmDashboard.loadDashboard()
                ResetForm()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtBorrowerID_Enter(sender As Object, e As EventArgs) Handles txtBorrowerID.Enter
        If lblAuthor.Text = "" Then
            MessageBox.Show("Please choose a book copies before enter this field!", "Choose Book Copies", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ResetForm()
        End If
    End Sub
End Class