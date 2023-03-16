Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub ResetForm()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Select()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            strDateIn = Date.Now.ToString("dd/MM/yyyy")
            strTimeIn = Date.Now.ToString("hh:mm:ss tt")
            If isEmpty(txtUsername.Text) = True Then Return
            If isEmpty(txtPassword.Text) = True Then Return
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblUser WHERE username = '" & txtUsername.Text.Trim & "' AND password = '" & txtPassword.Text & "'", con)
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
                con.Open()
                cmd = New SqlCommand("INSERT INTO tblActivityLog (username, dateIn, timeIn) VALUES (@username, @dateIn, @timeIn)", con)
                With cmd
                    .Parameters.AddWithValue("@username", strUsername)
                    .Parameters.AddWithValue("@dateIn", strDateIn)
                    .Parameters.AddWithValue("@timeIn", strTimeIn)
                    .ExecuteNonQuery()
                End With
                con.Close()
                MessageBox.Show("Welcome, " & strFullName, "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm()
                Me.Hide()
                frmMain.Show()
            Else
                MessageBox.Show("Invalid Username or Password. Try again or click Forgot Password to reset it.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        ResetForm()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub llbPasswordRecovery_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbPasswordRecovery.LinkClicked
        frmForgetPassword.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class