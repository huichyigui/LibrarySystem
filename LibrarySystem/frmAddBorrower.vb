Imports System.Data.SqlClient ' To communicate with SQL server
Imports System.Globalization
Imports System.Text ' For string builder
Imports System.Text.RegularExpressions ' For some input validation regex
Public Class frmAddBorrower
    ' To record down last modified date for reference purposes
    Public strLastModifiedDate As String = Date.Now.ToString("dd/MM/yyyy")

    Private Sub frmAddBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerBorrower.Enabled = True

        ' If user clicked update button, this UpdateBorrower() sub-modules will load and retrive existing user profile from database
        If Me.Text = "Update Borrower" Then
            UpdateBorrower()
        Else
            ResetForm()
            btnClear.Enabled = True
        End If
    End Sub

    ' Clear borrower's form 
    Sub ResetForm()
        mskBorrowerID.Select()
        mskBorrowerID.Clear()
        mskBorrowerID.Enabled = True
        txtFName.Clear()
        txtLName.Clear()
        dtpDOB.ResetText()
        cboGender.SelectedIndex = -1
        mskContact.Clear()
        txtEmail.Clear()
        cboProgram.SelectedIndex = -1
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        PictureBox1.Image = PictureBox1.InitialImage
        txtRemark.Text = "If Applicable"
        cboStatus.Text = "Active"
        dtpDateJoined.ResetText()
        lblLastModifiedDate.Text = ""
    End Sub

    ' Retrieve latest programmes naming from Program List 
    Sub BindProgram()
        Try
            cboProgram.Items.Clear()
            con.Open()
            cmd = New SqlCommand("SELECT program FROM tblProgram", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboProgram.Items.Add(dr.Item("program").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Retrieve records based on borrower ID if user clicked update button
    Sub UpdateBorrower()
        Try
            mskBorrowerID.Enabled = False
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            btnClear.Enabled = False
            btnCancel.Text = "&Close"
            mskBorrowerID.Text = strupdateborrowid

            con.Open()
            cmd = New SqlCommand("SELECT fname, lname, program, DOB, gender, contact, email, status, remark, image, datejoined, lastmodifieddate FROM tblBorrowers WHERE borrower_id LIKE '" & mskBorrowerID.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtFName.Text = dr.Item("fname").ToString
                txtLName.Text = dr.Item("lname").ToString
                dtpDOB.Value = DateTime.ParseExact(dr.Item("DOB").ToString, "dd/mm/yyyy", CultureInfo.InvariantCulture)
                cboGender.Text = dr.Item("gender").ToString
                mskContact.Text = dr.Item("contact").ToString
                txtEmail.Text = dr.Item("email").ToString
                cboProgram.Text = dr.Item("program").ToString
                cboStatus.Text = dr.Item("status").ToString
                dtpDateJoined.Value = DateTime.ParseExact(dr.Item("datejoined").ToString, "dd/mm/yyyy", CultureInfo.InvariantCulture)
                txtEmail.Text = dr.Item("email").ToString
                txtRemark.Text = dr.Item("remark").ToString
                lblLastModifiedDate.Text = ("Last Modified Date: " & dr.Item("lastmodifieddate").ToString)
                If dr.Item("image").ToString = "" Then ' If profile image unavailable, then load picturebox's default image
                    PictureBox1.Image = PictureBox1.InitialImage
                Else
                    PictureBox1.Image = Base64toImage(CStr(dr.Item("image")))
                End If
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure you want to cancel?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ResetForm()
            Me.Text = "" ' Clear the form name so updateborrower() module wont cause bug
            mskBorrowerID.Enabled = True ' Reenable borrower id box 
            Me.Close()
        End If
    End Sub

    Private Sub cboProgram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProgram.KeyPress, cboGender.KeyPress
        e.Handled = True
    End Sub

    ' Provide Hint for Remark Column
    Private Sub txtRemark_Click(sender As Object, e As EventArgs) Handles txtRemark.Click
        If txtRemark.Text = "If Applicable" Then
            txtRemark.Text = ""
        End If
    End Sub
    Private Sub txtRemark_Leave(sender As Object, e As EventArgs) Handles txtRemark.Leave
        If txtRemark.Text = "" Then
            txtRemark.Text = "If Applicable"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    ' Clear all input text box if user clicked clear all context menu
    Private Sub mnuClearAll_Click(sender As Object, e As EventArgs) Handles mnuClearAll.Click
        ResetForm()
    End Sub

    ' Upload image Function
    Private Sub btnSelectPicture_Click(sender As Object, e As EventArgs) Handles btnSelectPicture.Click
        Try
            Dim MyPicture As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            With OpenFileDialog1
                .Filter = "Jpg, Jpeg Image|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp|" & "All files (*.*)|*.*"
                .FileName = ""
                .Title = "Choose a picture"
                .AddExtension = True
                .FilterIndex = 1
                .Multiselect = False
                .InitialDirectory = MyPicture
                .RestoreDirectory = True

                If (.ShowDialog = DialogResult.OK) Then
                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                Else
                    Return
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Save Borrower's Records to SQL Server
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strLastModifiedDate As String = Date.Now.ToString("dd/MM/yyyy")

        Try
            ' Check Missing Input Fields and perform some input validation like Email and First Name
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim nameregex As Regex = New Regex("^[a-zA-Z ]+$")
            Dim emailregex As Regex = New Regex("^[a-zA-Z0-9\w.]+[@]+[a-zA-Z0-9\w]+[.]+[a-zA-Z0-9\w]*$")
            Dim blnemailvalid As Boolean = emailregex.IsMatch(txtEmail.Text.Trim)
            Dim blnfnamevalid As Boolean = nameregex.IsMatch(txtFName.Text.Trim)
            Dim blnlnamevalid As Boolean = nameregex.IsMatch(txtLName.Text.Trim)
            Dim strContact As String = mskContact.Text.Replace(" ", "0")  ' Replace mskContact's blank string with 0 so it can validate successfully

            If mskBorrowerID.Text = "" Then
                err.AppendLine("- Please enter [Borrower's ID]")
                ctr = If(ctr, mskBorrowerID)
            End If

            If txtFName.Text = "" Then
                err.AppendLine("- Please enter [First Name]")
                ctr = If(ctr, txtFName)
            ElseIf Not blnfnamevalid Then
                err.AppendLine("- Please enter [First Name] without digits or symbols.")
                ctr = If(ctr, txtFName)
            End If

            If txtLName.Text = "" Then
                err.AppendLine("- Please enter [Last Name]")
                ctr = If(ctr, txtLName)
            ElseIf Not blnlnamevalid Then
                err.AppendLine("- Please enter [Last Name] without digits or symbols.")
                ctr = If(ctr, txtLName)
            End If

            If cboGender.Text = "" Then
                err.AppendLine("- Please enter [Gender]")
                ctr = If(ctr, cboGender)
            End If

            If txtEmail.Text = "" Then
                err.AppendLine("- Please enter [Email]")
                ctr = If(ctr, txtEmail)
            ElseIf Not blnemailvalid Then
                err.AppendLine("- Please enter [Email] correctly such as testing@gmail.com.")
                ctr = If(ctr, txtEmail)
            End If

            If strContact.Contains("000") Then
                err.AppendLine("- Please enter [Contact Number]")
                ctr = If(ctr, mskContact)
            End If

            If cboProgram.Text = "" Then
                err.AppendLine("- Please enter [Program]")
                ctr = If(ctr, cboProgram)
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Missing Input Fields")
                ctr.Focus()
                con.Close()
                Return
            End If

            ' Check duplicate record if any
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblBorrowers WHERE borrower_id = '" & mskBorrowerID.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Borrower's Record Already Exist", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End If

            If MessageBox.Show("Do you want to add this record?", "Add Borrower Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO tblBorrowers VALUES (@borrower_id, @fname, @lname, @program, @DOB, @gender, @contact, @email, @status, @Fine, @remark, @image, @datejoined, @lastmodifieddate)", con)
                With cmd
                    .Parameters.AddWithValue("@borrower_id", mskBorrowerID.Text.ToUpper)
                    .Parameters.AddWithValue("@fname", Trim(txtFName.Text))
                    .Parameters.AddWithValue("@lname", Trim(txtLName.Text))
                    .Parameters.AddWithValue("@program", cboProgram.Text)
                    .Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@gender", cboGender.Text)
                    .Parameters.AddWithValue("@contact", mskContact.Text)
                    .Parameters.AddWithValue("@email", txtEmail.Text)
                    .Parameters.AddWithValue("@status", cboStatus.Text)
                    .Parameters.AddWithValue("@datejoined", dtpDateJoined.Value.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@remark", Trim(txtRemark.Text))
                    .Parameters.AddWithValue("@lastmodifieddate", strLastModifiedDate)
                    .Parameters.AddWithValue("@image", ImagetoBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg))
                    .Parameters.AddWithValue("@Fine", 0)
                    .ExecuteNonQuery()
                End With
                con.Close()
                MessageBox.Show("New Borrower's record has been added")
                ResetForm()
                frmBorrowers.bindBorrower()
                frmDashboard.loadDashboard()
            Else
                con.Close()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
             "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    ' Update Borrower's Records to SQL Server when Update button is clicked
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Check Missing Input Fields and perform some input validation like Email and First Name
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim nameregex As Regex = New Regex("^[a-zA-Z ]+$")
            Dim emailregex As Regex = New Regex("^[a-zA-Z0-9\w.]+[@]+[a-zA-Z0-9\w]+[.]+[a-zA-Z0-9\w]*$")
            Dim blnemailvalid As Boolean = emailregex.IsMatch(txtEmail.Text.Trim)
            Dim blnfnamevalid As Boolean = nameregex.IsMatch(txtFName.Text.Trim)
            Dim blnlnamevalid As Boolean = nameregex.IsMatch(txtLName.Text.Trim)
            Dim strContact As String = mskContact.Text.Replace(" ", "0")  ' Replace mskContact's blank string with 0 so it can validate successfully

            If mskBorrowerID.Text = "" Then
                err.AppendLine("- Please enter [Borrower's ID]")
                ctr = If(ctr, mskBorrowerID)
            End If

            If txtFName.Text = "" Then
                err.AppendLine("- Please enter [First Name]")
                ctr = If(ctr, txtFName)
            ElseIf Not blnfnamevalid Then
                err.AppendLine("- Please enter [First Name] without digits or symbols.")
                ctr = If(ctr, txtFName)
            End If

            If txtLName.Text = "" Then
                err.AppendLine("- Please enter [Last Name]")
                ctr = If(ctr, txtLName)
            ElseIf Not blnlnamevalid Then
                err.AppendLine("- Please enter [Last Name] without digits or symbols.")
                ctr = If(ctr, txtLName)
            End If

            If cboGender.Text = "" Then
                err.AppendLine("- Please enter [Gender]")
                ctr = If(ctr, cboGender)
            End If

            If txtEmail.Text = "" Then
                err.AppendLine("- Please enter [Email]")
                ctr = If(ctr, txtEmail)
            ElseIf Not blnemailvalid Then
                err.AppendLine("- Please enter [Email] correctly such as testing@gmail.com.")
                ctr = If(ctr, txtEmail)
            End If

            If strContact.Contains("000") Then
                err.AppendLine("- Please enter [Contact Number]")
                ctr = If(ctr, mskContact)
            End If

            If cboProgram.Text = "" Then
                err.AppendLine("- Please enter [Program]")
                ctr = If(ctr, cboProgram)
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Missing Input Fields")
                ctr.Focus()
                con.Close()
                Return
            End If

            If MessageBox.Show("Do you want to update this borrower?", "Update Borrower", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("UPDATE tblBorrowers SET fname = @fname, lname = @lname, program = @program, DOB = @DOB, gender = @gender, contact = @contact, email = @email, status = @status, remark = @remark, image = @image, datejoined = @datejoined,  lastmodifieddate = @lastmodifieddate WHERE borrower_id = '" & mskBorrowerID.Text & "'", con)
                With cmd
                    .Parameters.AddWithValue("@fname", txtFName.Text)
                    .Parameters.AddWithValue("@lname", txtLName.Text)
                    .Parameters.AddWithValue("@program", cboProgram.Text)
                    .Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@gender", cboGender.Text)
                    .Parameters.AddWithValue("@contact", mskContact.Text)
                    .Parameters.AddWithValue("@email", txtEmail.Text)
                    .Parameters.AddWithValue("@status", cboStatus.Text)
                    .Parameters.AddWithValue("@datejoined", dtpDateJoined.Value.ToString("dd/MM/yyyy"))
                    .Parameters.AddWithValue("@remark", Trim(txtRemark.Text))
                    .Parameters.AddWithValue("@lastmodifieddate", strLastModifiedDate)
                    .Parameters.AddWithValue("@image", ImagetoBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg))
                    .ExecuteNonQuery()
                End With
                con.Close()
                MessageBox.Show(mskBorrowerID.Text & Environment.NewLine & "Borrower's Info has been updated")
                frmBorrowers.bindBorrower()
                Me.Close()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class