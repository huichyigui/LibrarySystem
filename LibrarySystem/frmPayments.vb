Imports System.Data.SqlClient
Public Class frmPayments
    Dim decFine As Decimal
    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Finelist()
        Load_History()
        With cboPayment.Items
            .Clear()
            .Add("Cash")
            .Add("Credit")
            .Add("Trade Book")
        End With
        cboPayment.Text = "Cash"
    End Sub

    Private Sub load_Finelist()
        Try
            dgvFine.Rows.Clear()
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblBorrowers WHERE Fine > 0", con)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvFine.Rows.Add(dr.Item("Borrower_ID").ToString, dr.Item("Fine").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub btnCloseIR_Click(sender As Object, e As EventArgs) Handles btnCloseIR.Click 'close the window
        Me.Close()
    End Sub

    Private Sub dgvFine_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFine.CellContentDoubleClick
        'select the borrower_id which would want to pay fine
        Dim strborrowerid As String = dgvFine.CurrentRow.Cells(0).Value.ToString
        mskBorrowerID.Text = strborrowerid
    End Sub

    Private Sub Load_History()
        dgvHistory.Rows.Clear()
        con.Open()
        cmd = New SqlCommand("SELECT * FROM tblPayments ORDER BY Payment_No", con)
        dr = cmd.ExecuteReader
        While dr.Read
            dgvHistory.Rows.Add(dr.Item("Payment_NO"), dr.Item("Borrower_ID"), dr.Item("Description"), dr.Item("Payment_mode"), dr.Item("Date"), dr.Item("Paid"))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim intPaymentNo As Integer
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Dim intpayment As Integer
        Dim todate As Date = Date.Today

        If validatechecked() Then
            Try
                con.Open()
                cmd = New SqlCommand("SELECT * FROM tblBorrowers WHERE borrower_id LIKE '" & strborrowerid & "'", con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    'check input of payment and deduct the fine
                    If Integer.TryParse(txtPayments.Text, intpayment) Then
                        If intpayment >= 0 Then
                            decFine -= CDec(txtPayments.Text)
                        Else
                            MessageBox.Show("Please enter a positive integer")
                            txtPayments.Focus()
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please enter a valid value")
                        txtPayments.Focus()
                        Exit Sub
                    End If
                    dr.Close()
                    con.Close()
                Else
                    MessageBox.Show("Borrower not found")
                    dr.Close()
                    con.Close()
                End If

                'calculate change
                If decFine < 0 Then
                    decFine = decFine * -1
                    lblChange.Text = decFine.ToString
                    decFine = 0
                    lblOutstanding.Text = decFine.ToString
                Else
                    lblChange.Text = "0.00"
                    lblOutstanding.Text = decFine.ToString
                End If


                'get no of records from the table to create new id
                con.Open()
                cmd = New SqlCommand("SELECT COUNT(Payment_NO) FROM tblPayments", con)
                intPaymentNo = CInt(cmd.ExecuteScalar())

                'save the payment to the database
                cmd = New SqlCommand("INSERT INTO tblPayments VALUES(@Payment_NO, @Borrower_ID, @Description, @Payment_mode, @Date, @Paid)", con)
                With cmd
                    .Parameters.AddWithValue("@Payment_NO", "P" + intPaymentNo.ToString("D6"))
                    .Parameters.AddWithValue("@Borrower_ID", mskBorrowerID.Text.ToUpper())
                    .Parameters.AddWithValue("@Description", txtDescription.Text.ToString)
                    .Parameters.AddWithValue("@Payment_mode", cboPayment.Text.ToString)
                    .Parameters.AddWithValue("@Date", todate.ToString("dd/MMM/yyyy"))
                    .Parameters.AddWithValue("@Paid", (CDec(txtPayments.Text) - CDec(lblChange.Text)).ToString)
                    .ExecuteNonQuery()
                End With

                'update the fine on the borrower database
                cmd = New SqlCommand("UPDATE tblBorrowers SET fine = '" & decFine & "' WHERE borrower_ID = '" & mskBorrowerID.Text.ToUpper() & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                con.Close()
                dr.Close()
            End Try

            load_Finelist() 'refresh the list
            Load_History() 'refresh the history 
        End If


    End Sub

    Function validatechecked() As Boolean
        If (mskBorrowerID.Text = "") Then
            tooltipError.Show("Please Enter a valid ID or select from the list on the left.", mskBorrowerID)
            mskBorrowerID.Focus()
            Return False
        ElseIf (txtPayments.Text = "") Then
            tooltipError.Show("Fill in the blank!", txtPayments)
            Return False
        ElseIf (CDec(lblOutstanding.Text) = 0) Then
            MessageBox.Show("There is no fine to be paid!")
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub mskBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles mskBorrowerID.TextChanged
        Dim strborrowerid As String = mskBorrowerID.Text.Trim().ToUpper
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblBorrowers WHERE borrower_ID ='" & strborrowerid & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lblOutstanding.Text = dr.Item("Fine").ToString
                    decFine = CDec(dr.Item("Fine"))
                End While
            Else
                lblOutstanding.Text = "0.00"
                decFine = 0
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            con.Close()
        End Try
    End Sub


End Class