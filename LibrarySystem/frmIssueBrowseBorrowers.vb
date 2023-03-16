Public Class frmIssueBrowseBorrowers
    Private Sub frmIssueBrowseBorrowersLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBorrowersList.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("SELECT borrower_id,  (fname + ' ' + lname) AS Name FROM tblBorrowers WHERE status ='Active'", con)
        dr = cmd.ExecuteReader
        While dr.Read
            dgvBorrowersList.Rows.Add(dr.Item("Borrower_ID"), dr.Item("Name"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgvFine_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowersList.CellContentDoubleClick
        frmIR.mskBorrowerID.Text = dgvBorrowersList.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class