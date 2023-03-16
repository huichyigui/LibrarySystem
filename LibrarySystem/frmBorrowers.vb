Imports System.Data.SqlClient
Public Class frmBorrowers
    Sub bindBorrower()
        Try
            dgvBorrowers.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT borrower_id, (fname + ' ' + lname) AS fullname, program, DOB, gender, contact, email, status FROM tblBorrowers WHERE (fname + ' ' + lname) LIKE '%" & txtSearch.Text & "%' ORDER BY status, fullname", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvBorrowers.Rows.Add(intNo, dr.Item("borrower_id").ToString, dr.Item("fullname").ToString, dr.Item("program").ToString, dr.Item("DOB").ToString, dr.Item("gender").ToString, dr.Item("contact").ToString, dr.Item("email").ToString, dr.Item("status").ToString)
                dgvBorrowers.ClearSelection()
                lblCount.Text = dgvBorrowers.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBorrower.Click
        With frmAddBorrower
            .Text = "Create Borrower's Record"
            .BindProgram()
            .ShowDialog()
        End With
    End Sub

    Private Sub dgvBorrowers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowers.CellContentClick
        Try
            Dim strDate As String = dgvBorrowers.Rows(e.RowIndex).Cells(4).Value.ToString

            Dim colName As String = dgvBorrowers.Columns(e.ColumnIndex).Name
            If colName = "colEditBorrower" Then
                strupdateborrowid = dgvBorrowers.Rows(e.RowIndex).Cells(1).Value.ToString ' Save selected borrower id so it can pass to Addborrower's form and perform update 
                With frmAddBorrower
                    .Text = "Update Borrower"
                    .ShowDialog()
                End With
            ElseIf colName = "colDeleteBorrower" Then
                If MessageBox.Show("Are you SURE you want to delete?", "Delete Borrower?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    con.Open()
                    cmd = New SqlCommand("DELETE FROM tblBorrowers WHERE borrower_id LIKE '" & dgvBorrowers.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show(dgvBorrowers.Rows(e.RowIndex).Cells(1).Value.ToString & Environment.NewLine &
                                    "Borrower has been deleted.", "Successfully deleted")
                    bindBorrower()
                    frmDashboard.loadDashboard()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bindBorrower()
    End Sub
End Class