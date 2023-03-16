Imports System.Data.SqlClient
Public Class frmReturnbook
    Private Sub frmReturnbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIssueID.Text = strIssueID
        With cboStatus.Items
            .Clear()
            .Add("Normal")
            .Add("Damaged")
            .Add("Lost")
        End With
        cboStatus.Text = cboStatus.Items(0).ToString
    End Sub

    Private Sub txtIssueID_TextChanged(sender As Object, e As EventArgs) Handles txtIssueID.TextChanged 'search for book details'
        Try
            Dim strIssueNo As String = txtIssueID.Text.Trim().ToUpper
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblIssue WHERE Issue_ID = '" & strIssueID & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lblBookTitle.Text = dr.Item("book_title").ToString
                    dtpDueDate.Value = Convert.ToDateTime(dr.Item("Due_Date").ToString)
                    lblAccessionNo.Text = dr.Item("Accession_ID").ToString
                    lblBookPrice.Text = dr.Item("Price").ToString
                    lblBorrowerID.Text = dr.Item("Borrower_ID").ToString
                    cboStatus.SelectedValue = 1
                End While
                dr.Close()
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim strAccessionID = lblAccessionNo.Text.Trim().ToUpper
        Dim duedate As Date = dtpDueDate.Value
        Dim overdue As Decimal
        Dim decFine As Decimal
        Try
            Dim strIssueStatus As String = cboStatus.SelectedItem.ToString().Trim()
            strBookStatus = cboStatus.SelectedItem.ToString.Trim()

            If cboStatus.SelectedItem.ToString = "Normal" Then
                strIssueStatus = "Returned"
                strBookStatus = "Available"
            End If

            con.Open()
            'update status of borrowed book on issue table'
            cmd = New SqlCommand("UPDATE tblIssue SET status = '" & strIssueStatus & "' WHERE Issue_ID = '" & txtIssueID.Text.ToUpper & "' AND  Accession_ID = '" & strAccessionID & "'", con)
            cmd.ExecuteNonQuery()

            'update status of book in the books table'
            cmd = New SqlCommand("UPDATE tblBooks SET status = '" & strBookStatus & "' WHERE accession_no = '" & strAccessionID & "'", con)
            cmd.ExecuteNonQuery()

            'fine calculation
            cmd = New SqlCommand("SELECT Fine FROM tblBorrowers WHERE borrower_id = '" & lblBorrowerID.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                decFine = CDec(dr.Item("Fine"))
            End While
            dr.Close()

            'lost fine'
            If strIssueStatus = "Lost" Then
                MessageBox.Show("The book is lost, please proceed to payment to pay for the fine")
                decFine += CDec(lblBookPrice.Text)
                Me.Close()

                'damaged fine'
            ElseIf strIssueStatus = "Damaged" Then
                MessageBox.Show("The book is damaged, please proceed to payment to pay for the fine")
                decFine += CDec(lblBookPrice.Text) / 2

                'overdue fine'
            ElseIf duedate < Today.Date Then
                overdue = CDec(Today.Date.Subtract(duedate).TotalDays)
                decFine += CDec(overdue * 0.2)
                MessageBox.Show("Book is overdue, please proceed to payment to pay for the fine")

                'no fine'
            ElseIf strIssueStatus = "Returned" Then
                MessageBox.Show("Book Sucessfully Returned")
            End If

            cmd = New SqlCommand("UPDATE tblborrowers SET fine = '" & decFine & "' WHERE borrower_id = '" & lblBorrowerID.Text.ToUpper & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        con.Close()
        Me.Close()
    End Sub

End Class