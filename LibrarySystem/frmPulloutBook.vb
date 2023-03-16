Imports System.Data.SqlClient
Public Class frmPulloutBook
    Sub bindPullout()
        Try
            dgvPullout.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM vw_Pullout WHERE book_title LIKE '%" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvPullout.Rows.Add(intNo, dr.Item("book_id").ToString, dr.Item("accession_no").ToString, dr.Item("book_title").ToString, dr.Item("book_price").ToString, dr.Item("category").ToString, dr.Item("fullname").ToString, dr.Item("program").ToString, Format(dr.Item("date"), "dd/MM/yyyy"), dr.Item("action").ToString, dr.Item("remarks").ToString, dr.Item("pullout_by").ToString)
                dgvPullout.ClearSelection()
                lblCount.Text = dgvPullout.Rows.Count.ToString
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

    Private Sub btnPullout_Click(sender As Object, e As EventArgs) Handles btnPullout.Click
        With frmPulloutDetails
            autoComplete(.txtBorrowerID, "SELECT borrower_id FROM tblBorrowers", "dtBorrowerID")
            .bindBook()
            .txtSearch.Select()
            .ShowDialog()
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bindPullout()
    End Sub
End Class