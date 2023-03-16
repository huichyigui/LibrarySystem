Imports System.Data.SqlClient
Public Class frmMaintenance
    Dim strCategoryID As String
    Dim strProgram As String

    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCategorySave_Click(sender As Object, e As EventArgs) Handles btnCategorySave.Click
        Try
            If isEmpty(txtCategory.Text) = True Then Return
            If MessageBox.Show("Do you want to save this category", "Save Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("INSERT INTO tblCategory VALUES (@category)", con)
                cmd.Parameters.AddWithValue("@category", Trim(txtCategory.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Category has been saved")
                txtCategory.Clear()
                txtCategory.Select()
                bindCategory()
                frmDashboard.loadDashboard()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    Sub bindCategory()
        Try
            dgvCategory.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblCategory", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvCategory.Rows.Add(intNo, dr.Item("category").ToString)
                dgvCategory.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Sub bindProgram()
        Try
            dgvProgram.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblProgram", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvProgram.Rows.Add(intNo, dr.Item("Program").ToString, dr.Item("Description").ToString)
                dgvProgram.ClearSelection()
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Sub bindSettings()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT * FROM tblSettings", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtDaysAllowed.Text = dr.Item("days_allowed").ToString()
                txtBooksAllowed.Text = dr.Item("books_allowed").ToString()
                txtPenalty.Text = Format(dr.Item("penalty"), "#,##0.00").ToString()
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick
        Try
            Dim colName As String = dgvCategory.Columns(e.ColumnIndex).Name
            If colName = "colEditCategory" Then
                btnCategorySave.Enabled = False
                btnCategoryUpdate.Enabled = True
                txtCategory.Text = dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString()
                strCategoryID = dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString()
            ElseIf colName = "ColDeleteCategory" Then
                If MessageBox.Show("Delete this record?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    con.Open()
                    cmd = New SqlCommand("DELETE FROM tblCategory WHERE category Like '" & dgvCategory.Rows(e.RowIndex).Cells(1).Value.ToString() & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Category has been deleted")
                    btnCategoryCancel.PerformClick()
                    bindCategory()
                    frmDashboard.loadDashboard()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnCategoryCancel_Click(sender As Object, e As EventArgs) Handles btnCategoryCancel.Click
        txtCategory.Clear()
        txtCategory.Select()
        btnCategorySave.Enabled = True
        btnCategoryUpdate.Enabled = False
    End Sub

    Private Sub btnCategoryUpdate_Click(sender As Object, e As EventArgs) Handles btnCategoryUpdate.Click
        Try
            If isEmpty(txtCategory.Text) = True Then Return
            If MessageBox.Show("Do you want to update?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("UPDATE tblCategory SET category = @category WHERE category LIKE '" & strCategoryID & "'", con)
                cmd.Parameters.AddWithValue("@category", Trim(txtCategory.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Category has been updated")
                txtCategory.Clear()
                txtCategory.Select()
                btnCategoryCancel.PerformClick()
                bindCategory()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnProgramSave_Click(sender As Object, e As EventArgs) Handles btnProgramSave.Click
        Try
            If isEmpty(txtProgram.Text) = True Then Return
            If MessageBox.Show("Do you want to save this program", "Save Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("INSERT INTO tblProgram VALUES (@program, @description)", con)
                cmd.Parameters.AddWithValue("@program", Trim(txtProgram.Text))
                cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Program has been saved")
                txtProgram.Clear()
                txtDescription.Clear()
                txtProgram.Select()
                bindProgram()
                frmDashboard.loadDashboard()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnProgramCancel_Click(sender As Object, e As EventArgs) Handles btnProgramCancel.Click
        txtProgram.Clear()
        txtDescription.Clear()
        txtProgram.Select()
        btnProgramSave.Enabled = True
        btnProgramUpdate.Enabled = False
    End Sub

    Private Sub dgvProgram_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgram.CellContentClick
        Try
            Dim colName As String = dgvProgram.Columns(e.ColumnIndex).Name
            If colName = "colEditProgram" Then
                btnProgramSave.Enabled = False
                btnProgramUpdate.Enabled = True
                txtProgram.Text = dgvProgram.Rows(e.RowIndex).Cells(1).Value.ToString()
                txtDescription.Text = dgvProgram.Rows(e.RowIndex).Cells(2).Value.ToString()
                strProgram = dgvProgram.Rows(e.RowIndex).Cells(1).Value.ToString()
            ElseIf colName = "colDeleteProgram" Then
                If MessageBox.Show("Delete this record?", "Delete Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    con.Open()
                    cmd = New SqlCommand("DELETE FROM tblProgram WHERE program LIKE '" & dgvProgram.Rows(e.RowIndex).Cells(1).Value.ToString() & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Program has been deleted")
                    btnProgramCancel.PerformClick()
                    bindProgram()
                    frmDashboard.loadDashboard()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnProgramUpdate_Click(sender As Object, e As EventArgs) Handles btnProgramUpdate.Click
        Try
            If isEmpty(txtProgram.Text) = True Then Return
            If isEmpty(txtDescription.Text) = True Then Return
            If MessageBox.Show("Do you want to update?", "Update Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("UPDATE tblProgram SET program = @program, description = @description WHERE program LIKE '" & strProgram & "'", con)
                cmd.Parameters.AddWithValue("@program", Trim(txtProgram.Text))
                cmd.Parameters.AddWithValue("@description", txtDescription.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Program has been updated")
                txtProgram.Clear()
                txtProgram.Select()
                btnProgramCancel.PerformClick()
                bindProgram()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
        Try
            If isEmpty(txtDaysAllowed.Text) = True Then Return
            If isEmpty(txtBooksAllowed.Text) = True Then Return
            If isEmpty(txtPenalty.Text) = True Then Return
            If MessageBox.Show("Do you want to update settings", "Update Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                con.Open()
                cmd = New SqlCommand("UPDATE tblSettings SET days_allowed = @days_allowed, books_allowed = @books_allowed, penalty = @penalty", con)
                cmd.Parameters.AddWithValue("@days_allowed", CInt(txtDaysAllowed.Text))
                cmd.Parameters.AddWithValue("@books_allowed", CInt(txtBooksAllowed.Text))
                cmd.Parameters.AddWithValue("@penalty", CDbl(txtPenalty.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Setting has been updated")
                bindSettings()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub btnSettingsCancel_Click(sender As Object, e As EventArgs) Handles btnSettingsCancel.Click
        txtDaysAllowed.Clear()
        txtBooksAllowed.Clear()
        txtPenalty.Clear()
        txtDaysAllowed.Select()
    End Sub

    Private Sub txtDaysAllowed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPenalty.KeyPress, txtDaysAllowed.KeyPress, txtBooksAllowed.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class