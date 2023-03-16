Public Class frmMain
    'Sub CloseAll()
    '    My.Application.OpenForms.Cast(Of Form)() _
    '          .Except({Me}) _
    '          .ToList() _
    '          .ForEach(Sub(form) form.Close())
    'End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opencon()
        PanelBook.Visible = False
        Timer1.Enabled = True
        lblName.Text = strFullName
        lblRole.Text = strRole
    End Sub
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        If strRole = "Admin" Then
            With frmMaintenance
                .bindCategory()
                .bindProgram()
                .bindSettings()
                .ShowDialog()
            End With
        Else
            MessageBox.Show("Not enough access rights to perform this operation", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBookEntry_Click(sender As Object, e As EventArgs) Handles btnBookEntry.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmBookEntry" Then Return
        'Next
        'CloseAll()
        With frmBookEntry
            .TopLevel = False
            MainPanel.Controls.Add(frmBookEntry)
            .bindBook()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnBookAcquired_Click(sender As Object, e As EventArgs) Handles btnBookAcquired.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmBookAcquired" Then Return
        'Next
        'CloseAll()
        With frmBookAcquired
            .TopLevel = False
            MainPanel.Controls.Add(frmBookAcquired)
            .bindBooks()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmBorrowers" Then Return
        'Next
        'CloseAll()
        With frmBorrowers
            .TopLevel = False
            MainPanel.Controls.Add(frmBorrowers)
            .bindBorrower()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnIssuedReturn_Click(sender As Object, e As EventArgs) Handles btnIssuedReturn.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmIR" Then Return
        'Next
        'CloseAll()
        With frmIR
            .TopLevel = False
            MainPanel.Controls.Add(frmIR)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnPulloutBooks_Click(sender As Object, e As EventArgs) Handles btnPulloutBooks.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmPulloutBook" Then Return
        'Next
        'CloseAll()
        With frmPulloutBook
            .TopLevel = False
            MainPanel.Controls.Add(frmPulloutBook)
            .bindPullout()
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub btnStatistical_Click(sender As Object, e As EventArgs) Handles btnStatistical.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmStatistics" Then Return
        'Next
        'CloseAll()
        If strRole = "Admin" Then
            With frmStatistics
                .TopLevel = False
                MainPanel.Controls.Add(frmStatistics)
                .loadActivityLog()
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Not enough access rights to perform this operation", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, MyBase.Load
        With frmDashboard
            .TopLevel = False
            MainPanel.Controls.Add(frmDashboard)
            .loadDashboard()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim strDateOut As String = Date.Now.ToString("dd/MM/yyyy")
        Dim strTimeOut As String = Date.Now.ToString("hh:mm:ss tt")
        If MessageBox.Show("Do you sure you want to quit?", "Quit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateRecord("UPDATE tblActivityLog SET dateOut = '" & strDateOut & "', timeOut= '" & strTimeOut & "' WHERE username = '" & strUsername & "' AND dateIn = '" & strDateIn & "' AND timeIn = '" & strTimeIn & "'")
            Me.Close()
            frmLogin.Show()
        End If
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        With frmPayments
            .TopLevel = False
            MainPanel.Controls.Add(frmPayments)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'For Each f As Form In My.Application.OpenForms
        '    If f.Name = "frmReports" Then Return
        'Next
        'CloseAll()
        If strRole = "Admin" Then
            With frmReports
                .TopLevel = False
                MainPanel.Controls.Add(frmReports)
                .loadBookInventory()
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Not enough access rights to perform this operation", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        If PanelBook.Visible = False Then
            PanelBook.Visible = True
        Else
            PanelBook.Visible = False
        End If
    End Sub

End Class
