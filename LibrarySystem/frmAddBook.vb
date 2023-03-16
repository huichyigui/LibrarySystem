Imports ThoughtWorks.QRCode.Codec
Imports System.Data.SqlClient
Public Class frmAddBook
    Dim strAccessionNo As String
    Sub Auto_ID()
        Dim strID As String
        Dim intNo As Integer
        con.Open()
        cmd = New SqlCommand("SELECT MAX(SUBSTRING(book_id,3,LEN(book_id))) AS book_id FROM tblBooks", con)
        strID = cmd.ExecuteScalar.ToString()
        If String.IsNullOrEmpty(strID) Then
            strID = "BK0000001"
        Else
            strID.Substring(3)
            Int32.TryParse(strID, intNo)
            intNo = Integer.Parse(strID) + 1
            strID = "BK" + intNo.ToString("D7")
        End If
        txtBookID.Text = strID
        con.Close()
    End Sub

    Sub bindCategory()
        Try
            cboCategory.Items.Clear()
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblCategory", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboCategory.Items.Add(dr.Item("category").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
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
        Auto_ID()
        Auto_AccessionNo()
        cboCategory.SelectedIndex = -1
        cboCategory.Select()
        txtBookTitle.Clear()
        txtAuthor.Clear()
        nudYearPublished.Value = Now.Year
        txtPublisher.Clear()
        txtBookPrice.Clear()
    End Sub
    Private Sub cboCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtBookPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 58
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub txtBookID_TextChanged(sender As Object, e As EventArgs) Handles txtBookID.TextChanged
        QRCode(picQRCode, txtBookID.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If isEmpty(cboCategory.Text) = True Then Return
            If isEmpty(txtBookTitle.Text) = True Then Return
            If isEmpty(txtAuthor.Text) = True Then Return
            If isEmpty(nudYearPublished.Text) = True Then Return
            If isEmpty(txtPublisher.Text) = True Then Return
            If isEmpty(txtBookPrice.Text) = True Then Return

            If btnSave.Text = "&Save" Then
                If MessageBox.Show("Do you want to add this book?", "Add Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    con.Open()
                    cmd = New SqlCommand("INSERT INTO tblBooks (book_id, accession_no, category, book_title, author, yr_published, publisher, book_price) VALUES (@book_id, @accession_no, @category, @book_title, @author, @yr_published, @publisher, @book_price)", con)
                    With cmd
                        .Parameters.AddWithValue("@book_id", txtBookID.Text)
                        .Parameters.AddWithValue("@accession_no", strAccessionNo)
                        .Parameters.AddWithValue("@category", cboCategory.Text)
                        .Parameters.AddWithValue("@book_title", Trim(txtBookTitle.Text))
                        .Parameters.AddWithValue("@author", Trim(txtAuthor.Text))
                        .Parameters.AddWithValue("@yr_published", nudYearPublished.Text)
                        .Parameters.AddWithValue("@publisher", Trim(txtPublisher.Text))
                        .Parameters.AddWithValue("@book_price", CDec(txtBookPrice.Text))
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MessageBox.Show("New book [" & txtBookTitle.Text & "] has been added")
                    ResetForm()
                    frmBookEntry.bindBook()
                End If
            ElseIf btnSave.Text = "&Update" Then
                If MessageBox.Show("Do you want to update this book?", "Update Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    con.Open()
                    cmd = New SqlCommand("UPDATE tblBooks SET category=@category, book_title=@book_title, author=@author, yr_published=@yr_published, publisher=@publisher, book_price=@book_price WHERE book_id LIKE '" & txtBookID.Text & "'", con)
                    With cmd
                        .Parameters.AddWithValue("@category", cboCategory.Text)
                        .Parameters.AddWithValue("@book_title", Trim(txtBookTitle.Text))
                        .Parameters.AddWithValue("@author", Trim(txtAuthor.Text))
                        .Parameters.AddWithValue("@yr_published", nudYearPublished.Text)
                        .Parameters.AddWithValue("@publisher", Trim(txtPublisher.Text))
                        .Parameters.AddWithValue("@book_price", CDec(txtBookPrice.Text))
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    MessageBox.Show(txtBookID.Text & Environment.NewLine &
                                        "Book [" & txtBookTitle.Text & "] has been updated")
                    frmBookEntry.bindBook()
                    frmDashboard.loadDashboard()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "&Clear" Then
            ResetForm()
        ElseIf btnClear.Text = "&Close" Then
            Me.Close()
        End If
    End Sub

End Class