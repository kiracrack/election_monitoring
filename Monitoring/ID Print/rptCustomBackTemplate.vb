Public Class rptCustomBackTemplate
    Public Sub BindData()
        If strMaNV = "" Then
            HideContent(False)
            logo.Image = Image.FromFile(Application.StartupPath.ToString & "\img\" & strFilename & "-back.jpg")
        Else
            HideContent(True)
            img = Nothing
            logo.Image = Image.FromFile(Application.StartupPath.ToString & "\img\" & strFilename & "-back.jpg")
            'txtTitle.Text = strTitle
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
                txtBarangay.Text = Trim(rst("Barangay").ToString)
                img = ConvertImageBinary("imgprofile")
            End While
            rst.Close()
 
        End If
    End Sub
    Public Sub HideContent(ByVal visible As Boolean)
        'txtTitle.Visible = visible
        'barcode.Visible = visible
        'txtComelectid.Visible = visible
        'txtPrecint.Visible = visible
        'txtFullname.Visible = visible
        'txtBirthDate.Visible = visible
        'txtArea.Visible = visible
        'txtMunicipality.Visible = visible
        'txtBarangay.Visible = visible
        'imgPicture.Visible = visible
    End Sub
End Class