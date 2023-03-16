Imports System.Data.SqlClient
Public Class frmResetPassword
    Dim strUser As String = frmForgetPassword.toUser
    Dim strNewPassword As String
    Dim strConfirmPassword As String
    Private Sub ResetForm()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
        txtNewPassword.Focus()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Try
            If isEmpty(txtNewPassword.Text) = True Then Return
            If isEmpty(txtConfirmPassword.Text) = True Then Return
            If txtNewPassword.Text = txtConfirmPassword.Text Then
                con.Open()
                cmd = New SqlCommand("UPDATE tblUser SET username=@username, password=@password WHERE username= '" & strUser & "'", con)
                cmd.Parameters.AddWithValue("@username", strUser)
                cmd.Parameters.AddWithValue("@password", txtNewPassword.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password Reset Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Me.Close()
            Else
                MessageBox.Show("Please make sure your password match.", "Password Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                With txtConfirmPassword
                    .Select()
                    .SelectAll()
                End With
            End If

        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtNewPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtNewPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub
End Class