Public Class frmIssueBrowseBooks
    Private Sub frmIssueBrowseBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBookList.Rows.Clear()
        con.Open()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tblBooks WHERE status ='Available'", con)
        dr = cmd.ExecuteReader
        While dr.Read
            dgvBookList.Rows.Add(dr.Item("Book_ID"), dr.Item("Accession_NO"), dr.Item("book_title"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Close()
    End Sub

    Private Sub dgvBookList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookList.CellContentDoubleClick
        frmIR.txtAccessionID.Text = dgvBookList.CurrentRow.Cells(1).Value.ToString
        Me.Close()
    End Sub
End Class