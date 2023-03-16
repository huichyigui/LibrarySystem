Imports System.Data.SqlClient
Public Class frmBookEntry
    Sub bindBook()
        Try
            dgvBooks.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT book_id, book_title, category, author, yr_published, publisher, book_price, COUNT(book_id) AS copies FROM tblBooks WHERE status = 'Available' and book_title LIKE '%" & txtSearch.Text & "%' GROUP BY book_id, book_title, category, author, yr_published, publisher, book_price", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvBooks.Rows.Add(intNo, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("yr_published").ToString, dr.Item("publisher").ToString, dr.Item("copies").ToString, dr.Item("category").ToString, dr.Item("book_price").ToString)
                dgvBooks.ClearSelection()
                lblCount.Text = dgvBooks.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        With frmAddBook
            .Auto_ID()
            .Auto_AccessionNo()
            .bindCategory()
            .ShowDialog()
        End With
    End Sub

    Private Sub frmBookEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Select()
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick
        Try
            Dim colName As String = dgvBooks.Columns(e.ColumnIndex).Name
            If colName = "colEditBook" Then
                With frmAddBook
                    .Text = "Update Book"
                    .btnSave.Text = "&Update"
                    .Show()
                    .txtBookID.Text = dgvBooks.Rows(e.RowIndex).Cells(1).Value.ToString
                    .cboCategory.Text = dgvBooks.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtBookTitle.Text = dgvBooks.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAuthor.Text = dgvBooks.Rows(e.RowIndex).Cells(3).Value.ToString
                    .nudYearPublished.Text = dgvBooks.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtPublisher.Text = dgvBooks.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtBookPrice.Text = dgvBooks.Rows(e.RowIndex).Cells(8).Value.ToString
                    .btnClear.Text = "&Close"
                    .bindCategory()
                End With
            ElseIf colName = "colPrint" Then
                With frmPrint
                    .TopLevel = False
                    frmMain.MainPanel.Controls.Add(frmPrint)
                    .PrintQRCode(dgvBooks.Rows(e.RowIndex).Cells(1).Value.ToString)
                    .BringToFront()
                    .Show()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bindBook()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class