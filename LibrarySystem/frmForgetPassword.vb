Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class frmForgetPassword
    Private strCode As String
    Public Shared toUser As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim EmailMessage As New MailMessage()
        Try
            If isEmpty(txtUsername.Text) = True Then Return
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblUser WHERE username LIKE '" & txtUsername.Text.Trim & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                strFullName = dr.Item("name").ToString
                strUsername = dr.Item("username").ToString
                strPassword = dr.Item("password").ToString
                strEmail = dr.Item("email").ToString
                strRole = dr.Item("role").ToString
                found = True
            End If
            dr.Close()
            con.Close()
            If found = True Then
                Dim rand As Random = New Random()
                strCode = (rand.Next(999999)).ToString()
                toUser = txtUsername.Text
                EmailMessage.From = New MailAddress("xyz11587@gmail.com")
                EmailMessage.To.Add(strEmail)
                EmailMessage.Subject = "Mini Oasis: Password Recovery"
                EmailMessage.Body = "Hello " & strUsername & ", " & vbCrLf &
                    "Forget your password?" & vbCrLf & vbCrLf &
                    "We received a request to recover the password for you account." & vbCrLf &
                    "Your Username: " & strUsername & vbCrLf &
                    "Your Verification Code: " & strCode & vbCrLf & vbCrLf &
                    "Regard, " & vbCrLf &
                    "Mini Oasis Team"
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("xyz11587@gmail.com", "abcxyz11587")
                SMTP.Send(EmailMessage)
                Dim strMsg As String = "We sent a verification email to " & strEmail & ". Please verify your email and enter the verification code in the [Enter Verification Code] field."
                MessageBox.Show(strMsg, "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCode.Focus()
            Else
                Dim strMessage As String = "Sorry, this does not match our records. Check your spelling and try again."

                MessageBox.Show(strMessage, "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With txtUsername
                    .Select()
                    .SelectAll()
                End With
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If (txtCode.Text.Equals(strCode)) Then
            toUser = txtUsername.Text
            frmResetPassword.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid verification code. Please try again.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            With txtCode
                .Select()
                .SelectAll()
            End With
        End If
    End Sub

    Private Sub llbResendCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbResendCode.LinkClicked
        btnSubmit_Click(Nothing, Nothing)
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter your username before enter the code", "Enter Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class