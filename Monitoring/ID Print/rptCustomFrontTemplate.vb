Public Class rptCustomFrontTemplate
    Public Sub BindData()
        If strMaNV = "" Then
            HideContent(False)
            logo.Image = Image.FromFile(Application.StartupPath.ToString & "\img\" & strFilename & "-back.jpg")
        Else
            HideContent(True)
            img = Nothing
            logo.Image = Image.FromFile(Application.StartupPath.ToString & "\img\" & strFilename & "-front.jpg")
            txtTitle.Text = strTitle
            com.CommandText = "select *, (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area', " _
                                        + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal', " _
                                        + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Barangay', " _
                                        + " (select imgprofile from filedir.tblvotersimage where votersid = tblvoters.votersid) as imgprofile " _
                                        + " from tblvoters where votersid='" & strMaNV & "'" : rst = com.ExecuteReader
            While rst.Read
                'barcode.Text = Trim(rst("votersid").ToString)
                'txtComelectid.Text = Trim(rst("comelecid").ToString)
                'txtPrecint.Text = "Precinct: " & Trim(rst("precinct").ToString)
                txtFullname.Text = Trim(rst("fullname").ToString)
                'txtBirthDate.Text = "Birth Date: " & Trim(rst("bdate").ToString)
                'txtArea.Text = "District: " & Trim(rst("Area").ToString)
                'txtMunicipality.Text = If(LCase(rst("Municipal").ToString).Contains("city") = True, "City: ", "Municipality: ") & Trim(rst("Municipal").ToString)
                'txtBarangay.Text = "Barangay: " & Trim(rst("Barangay").ToString)
                img = ConvertImageBinary("imgprofile")
            End While
            rst.Close()

            If Not img Is Nothing Then
                Dim wd As Integer = 350
                Dim CropRect As New Rectangle((img.Width / 2) - (wd / 2), 0, wd, 350)
                Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
                Using grp = Graphics.FromImage(CropImage)
                    grp.DrawImage(img, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                    'CropImage.Save("C:\Users\Sysadmin\Pictures\test.jpg")
                End Using
                imgPicture.Image = CropImage
            Else
                imgPicture.Image = Nothing
            End If
        End If
    End Sub
    Public Sub HideContent(ByVal visible As Boolean)
        txtTitle.Visible = visible
        'barcode.Visible = visible
        'txtComelectid.Visible = visible
        'txtPrecint.Visible = visible
        'txtFullname.Visible = visible
        'txtBirthDate.Visible = visible
        'txtArea.Visible = visible
        'txtMunicipality.Visible = visible
        'txtBarangay.Visible = visible
        imgPicture.Visible = visible
    End Sub
End Class