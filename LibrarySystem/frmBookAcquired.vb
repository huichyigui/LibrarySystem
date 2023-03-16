Imports System.Data.SqlClient
Public Class frmBookAcquired
    Dim strAccessionNo As String
    Dim strCategory As String
    Dim strYearPublished As String
    Dim strPublisher As String
    Dim strBookPrice As String
    Sub bindBooks()
        Try
            dgvBookAcquired.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT DISTINCT book_id, book_title, author, category, yr_published, publisher, book_price FROM tblBooks WHERE status = 'Available' AND book_title LIKE '%" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader()
            While dr.Read
                intNo += 1
                dgvBookAcquired.Rows.Add(intNo, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("category").ToString, dr.Item("yr_published").ToString, dr.Item("publisher").ToString, dr.Item("book_price").ToString)
                dgvBookAcquired.ClearSelection()
                lblCount.Text = dgvBookAcquired.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Auto_AccessionNo()
        Dim strID As String
        Dim intNo As Integer
        con.Open()
        cmd = New SqlCommand("SELECT MAX(SUBSTRING(accession_no,3,LEN(book_id))) AS accession_no FROM tblBooks", con)
        strID = cmd.ExecuteScalar.ToString()
        If String.IsNullOrEmpty(strID) Then
            strID = "AC0000001"
        Else
            strID.Substring(3)
            Int32.TryParse(strID, intNo)
            intNo = Integer.Parse(strID) + 1
            strID = "AC" + intNo.ToString("D7")
        End If
        strAccessionNo = strID
        con.Close()
    End Sub
    Sub ResetForm()
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblAuthor.Text = ""
        strCategory = Nothing
        strYearPublished = Nothing
        strPublisher = Nothing
        strBookPrice = Nothing
        nudCopies.Value = 0
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvBookAcquired_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookAcquired.CellContentClick
        Try
            Dim colName As String = dgvBookAcquired.Columns(e.ColumnIndex).Name
            If colName = "colSelect" Then
                lblBookID.Text = dgvBookAcquired.Rows(e.RowIndex).Cells(1).Value.ToString()
                lblBookTitle.Text = dgvBookAcquired.Rows(e.RowIndex).Cells(2).Value.ToString()
                lblAuthor.Text = dgvBookAcquired.Rows(e.RowIndex).Cells(3).Value.ToString()
                strCategory = dgvBookAcquired.Rows(e.RowIndex).Cells(4).Value.ToString()
                strYearPublished = dgvBookAcquired.Rows(e.RowIndex).Cells(5).Value.ToString()
                strPublisher = dgvBookAcquired.Rows(e.RowIndex).Cells(6).Value.ToString()
                strBookPrice = dgvBookAcquired.Rows(e.RowIndex).Cells(7).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bindBooks()
    End Sub

    Private Sub frmBookAcquired_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Select()
    End Sub

    Private Sub txtBookID_TextChanged(sender As Object, e As EventArgs)
        QRCode(picQRCode, lblBookID.Text)
    End Sub

    Private Sub btnAddCopies_Click(sender As Object, e As EventArgs) Handles btnAddCopies.Click
        Try
            If isEmpty(lblBookID.Text) = True Then Return
            If nudCopies.Value < 1 Then
                MessageBox.Show("Please enter valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If MessageBox.Show("Book ID: " & lblBookID.Text & Environment.NewLine &
                               "Book Title: " & lblBookTitle.Text & Environment.NewLine &
                               "Do you want to add copies of this book?", "Add Copies", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                For i As Integer = 1 To CInt(nudCopies.Value)
                    Auto_AccessionNo()
                    con.Open()
                    cmd = New SqlCommand("INSERT INTO tblBooks (book_id, accession_no, category, book_title, author, yr_published, publisher, book_price) VALUES (@book_id, @accession_no, @category, @book_title, @author, @yr_published, @publisher, @book_price)", con)
                    With cmd
                        .Parameters.AddWithValue("@book_id", lblBookID.Text)
                        .Parameters.AddWithValue("@accession_no", strAccessionNo)
                        .Parameters.AddWithValue("@category", strCategory)
                        .Parameters.AddWithValue("@book_title", Trim(lblBookTitle.Text))
                        .Parameters.AddWithValue("@author", Trim(lblAuthor.Text))
                        .Parameters.AddWithValue("@yr_published", strYearPublished)
                        .Parameters.AddWithValue("@publisher", strPublisher)
                        .Parameters.AddWithValue("@book_price", strBookPrice)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                Next
                MessageBox.Show("Book ID: " & lblBookID.Text & Environment.NewLine &
           "Book Title: " & lblBookTitle.Text & Environment.NewLine &
           "Book copies had been added")
                bindBooks()
                ResetForm()
                frmDashboard.loadDashboard()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
    End Sub

    Private Sub lblBookID_TextChanged(sender As Object, e As EventArgs) Handles lblBookID.TextChanged
        QRCode(picQRCode, lblBookID.Text)
    End Sub

End Class