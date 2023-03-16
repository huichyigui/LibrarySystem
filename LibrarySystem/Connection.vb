Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode.Codec
Module Connection
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public found As Boolean = False
    Public strFullName As String
    Public strUsername As String
    Public strPassword As String
    Public strRole As String
    Public strEmail As String
    Public strupdateborrowid As String
    Public strDateIn As String
    Public strTimeIn As String
    Public strLogFrom As String
    Public strLogTo As String
    Public strReturnAccessionID As String
    Public strIssueID As String
    Public strBookStatus As String
    Dim issueEndDate As String
    Dim issueStartDate As String

    Sub opencon()
        'con.ConnectionString = "REPLACE WITH YOUR SSMS LINK"
        con.ConnectionString = "Data Source=desktop-nhrg1ps\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True"
    End Sub

    Sub autoComplete(id As TextBox, sql As String, table As String)
        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, table)
            con.Close()
            Dim col As New AutoCompleteStringCollection
            For i = 0 To ds.Tables(table).Rows.Count - 1
                col.Add(ds.Tables(table).Rows(i)(0).ToString)
            Next
            id.AutoCompleteSource = AutoCompleteSource.CustomSource
            id.AutoCompleteCustomSource = col
            id.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub UpdateRecord(sql As String)
        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function isEmpty(text As Object) As Boolean
        If text Is String.Empty Then
            MessageBox.Show("Missing Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        Else
            Return False
        End If
    End Function

    Function QRCode(picQRCode As PictureBox, strBookID As String) As Image
        Dim qrCodeEncoder As New QRCodeEncoder

        Dim strType As String = "byte"
        If strType = "byte" Then
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        End If

        qrCodeEncoder.QRCodeVersion = 7
        qrCodeEncoder.QRCodeScale = 5
        qrCodeEncoder.QRCodeForegroundColor = Color.Black

        Dim errorCorrect As String = "M"
        If errorCorrect = "M" Then
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
        End If

        Dim imgQR As Image = qrCodeEncoder.Encode(strBookID)
        picQRCode.Image = imgQR
        Return picQRCode.Image
    End Function

    ' Convert borrower's user picture to string for passing to SQL database
    Function ImagetoBase64(ByVal image As Image, format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New System.IO.MemoryStream
        image.Save(ms, format)
        Dim arrImage() As Byte = ms.ToArray

        Dim Base64String As String = Convert.ToBase64String(arrImage)
        Return Base64String
    End Function

    ' Convert borrower's user picture from string to picture to display on the form
    Function Base64toImage(ByVal base64string As String) As Image
        Dim arrImage() As Byte = Convert.FromBase64String(base64string)
        Dim ms As New System.IO.MemoryStream(arrImage, 0, arrImage.Length)

        ms.Write(arrImage, 0, arrImage.Length)
        Dim ConvertedImage As Image = Image.FromStream(ms, True)
        Return ConvertedImage
    End Function
End Module
