Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting ' Enable the forms to display charts
Public Class frmStatistics
    ' Load Borrowers's Status Pie Chart
    Sub LoadBorrowerStatusChart()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT status, COUNT(*) AS total FROM tblBorrowers GROUP BY status", con)
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet ' Reset the data set each time in case the user press the same combo boxes selection multiple times
            da.Fill(ds, "chart")
            con.Close()

            With ChartBorrowers
                .Visible = True
                .Series.Clear()
                .Series.Add("Series1")
            End With

            Dim series As Series = ChartBorrowers.Series("Series1")
            series = ChartBorrowers.Series("Series1")
            series.ChartType = SeriesChartType.Pie
            ChartBorrowers.DataSource = ds.Tables("chart")

            With ChartBorrowers
                .ChartAreas(0).Area3DStyle.Enable3D = True ' Enable 3D Style Pie Chart

                .Series(0).XValueMember = "status"
                .Series(0).YValueMembers = "total"
                .Series(0).IsValueShownAsLabel = True

                .Titles(0).Text = "Pie Chart of Borrower's Status" ' Chart Title Properties
                .Titles(0).Docking = Docking.Top
                .Titles(0).Font = New Font("Microsoft Sans Serif", 24, FontStyle.Bold)

                .Series(0).LegendText = "#VALX (#PERCENT)" ' Legends Properties
                .Legends(0).Title = "Legends"
                .Legends(0).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                .Legends(0).TitleSeparator = LegendSeparatorStyle.DotLine
            End With
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub loadActivityLog()
        Try
            dgvLogHistory.Rows.Clear()
            Dim intNo As Integer
            con.Open()
            cmd = New SqlCommand("SELECT * FROM vw_activityLog where name LIKE '%" & txtSearch.Text & "%' AND dateOut IS NOT NULL AND timeOut IS NOT NULL AND dateIn BETWEEN '" & dtpFromLog.Value.ToString("dd/MM/yyyy") & "' AND '" & dtpToLog.Value.ToString("dd/MM/yyyy") & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                intNo += 1
                dgvLogHistory.Rows.Add(intNo, dr.Item("username").ToString, dr.Item("name").ToString, dr.Item("dateIn").ToString, dr.Item("timeIn").ToString, dr.Item("dateOut").ToString, dr.Item("timeOut").ToString)
                dgvLogHistory.ClearSelection()
                lblCount.Text = dgvLogHistory.Rows.Count.ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ' Load Borrowers's Total Gender Pie Chart
    Sub LoadBorrowerGenderChart()
        Try
            con.Open()
            cmd = New SqlCommand("SELECT gender, COUNT(*) AS total FROM tblBorrowers GROUP BY gender ORDER BY gender DESC", con)
            da = New SqlDataAdapter(cmd)
            Dim ds As New DataSet ' Reset the data set each time in case the user press the same combo boxes multiple times
            da.Fill(ds, "chart")
            con.Close()

            With ChartBorrowers
                .Visible = True
                .Series.Clear()
                .Series.Add("Series1")
            End With

            Dim series As Series = ChartBorrowers.Series("Series1")
            series.ChartType = SeriesChartType.Pie
            ChartBorrowers.DataSource = ds.Tables("chart")

            With ChartBorrowers
                .ChartAreas(0).Area3DStyle.Enable3D = True ' Enable 3D Style Pie Chart

                .Series(0).XValueMember = "gender"
                .Series(0).YValueMembers = "total"
                .Series(0).IsValueShownAsLabel = True

                .Titles(0).Text = "Pie Chart of Borrower's Gender" ' Chart Title Properties
                .Titles(0).Docking = Docking.Top
                .Titles(0).Font = New Font("Microsoft Sans Serif", 24, FontStyle.Bold)

                .Series(0).LegendText = "#VALX (#PERCENT)" ' Legends Properties
                .Legends(0).Title = "Legends"
                .Legends(0).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                .Legends(0).TitleSeparator = LegendSeparatorStyle.DotLine
            End With
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Load different chart accordingly when different selected index
    Private Sub cboBorrowersStatistics_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowersStatistics.SelectedIndexChanged
        If cboBorrowersStatistics.SelectedIndex = 0 Then
            LoadBorrowerStatusChart()
        Else
            LoadBorrowerGenderChart()
        End If
    End Sub

    ' Clear combo boxes and the chart
    Private Sub btnClearBorrowerReport_Click(sender As Object, e As EventArgs) Handles btnClearBorrowerReport.Click
        cboBorrowersStatistics.SelectedIndex = -1
        ChartBorrowers.Series.Clear()
        ChartBorrowers.Visible = False
    End Sub
    Private Sub dtpFromLog_ValueChanged(sender As Object, e As EventArgs) Handles dtpToLog.ValueChanged, dtpFromLog.ValueChanged
        loadActivityLog()
    End Sub

    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFromLog.Format = DateTimePickerFormat.Custom
        dtpToLog.Format = DateTimePickerFormat.Custom
        dtpFromLog.CustomFormat = "dd/MM/yyyy"
        dtpToLog.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadActivityLog()
    End Sub

    Private Sub btnPrintActivityLog_Click(sender As Object, e As EventArgs) Handles btnPrintActivityLog.Click
        strLogFrom = dtpFromLog.Value.ToString("dd/MM/yyyy")
        strLogTo = dtpToLog.Value.ToString("dd/MM/yyyy")
        With frmPrint
            .TopLevel = False
            frmMain.MainPanel.Controls.Add(frmPrint)
            .printActivityLog(txtSearch.Text, strLogFrom, strLogTo)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnActivityLogPDF_Click(sender As Object, e As EventArgs) Handles btnActivityLogPDF.Click
        Try
            With frmPrint
                .TopLevel = False
                frmMain.MainPanel.Controls.Add(frmPrint)
                .ActivityLogPDF(txtSearch.Text, dtpFromLog.Value.ToString("dd/MM/yyyy"), dtpToLog.Value.ToString("dd/MM/yyyy"))
            End With
        Catch ex As Exception
            MessageBox.Show("Save Data Failed : " & ex.Message.ToString(),
            "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class