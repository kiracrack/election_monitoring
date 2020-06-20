Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Module reports
    Public openform As DevExpress.XtraEditors.XtraForm
    Public Function CopyGridControl(ByVal grid As GridControl) As WinControlContainer

        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 0)
        winContainer.Size = New Size(200, 100)

        ' Set the grid as a wrapped object.
        winContainer.WinControl = grid
        Return winContainer
    End Function
    Public Function CopyGridControl1(ByVal grid As GridControl) As WinControlContainer

        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 30)
        winContainer.Size = New Size(200, 100)

        ' Set the grid as a wrapped object.
        winContainer.WinControl = grid
        Return winContainer
    End Function
    Public Function reportTitle(ByVal a As String)
        Dim rptitle As String = ""
        com.CommandText = "select * from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            rptitle = rst("title").ToString
        End While
        rst.Close()
        Return rptitle
    End Function
    Public Function reportcustomtext(ByVal a As String)
        Dim rpcustom As String = ""
        com.CommandText = "select * from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            rpcustom = rst("customtext").ToString
        End While
        rst.Close()
        Return rpcustom
    End Function

    Public Function reportcount(ByVal a As String)
        Dim cnt As String = 0
        com.CommandText = "select count(*) as cnt from tblreportsetting where formname='" & a & "' "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        If cnt = 0 Then
            com.CommandText = "insert into tblreportsetting set formname='" & a & "' "
            com.ExecuteNonQuery()
        End If
        Return 0
    End Function
    Public Sub TitleOrient(ByVal txtbox As DevExpress.XtraReports.UI.XRLabel, ByVal orient As String)
        If orient = "True" Then
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Else
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        End If
    End Sub

    Public Function getReportTemplateID()
        Dim strng = ""
        Try
            If CInt(countrecord("tblreporttemplate")) = 0 Then
                strng = "RPT100001"
            Else
                com.CommandText = "select rptid from tblreporttemplate order by right(rptid,6) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("rptid").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "RPT" & Val(sb.ToString) + 1
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
        Return strng.ToString
    End Function

    Public Sub GenerateCoupon(ByVal query As String, ByVal form As XtraForm)
        Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\coupon.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\coupon-" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        dst = New DataSet
        msda = New MySqlDataAdapter(query, conn)
        msda.Fill(dst, 0)
        Dim cntgroup As Integer = 0
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                Dim picbox As PictureBox = New PictureBox
                TableRow += "<td><div class='mainarea'>" & Chr(13) _
                          + " <div align='center' class='leftcode'><img id='" & .Rows(cnt)("votersid").ToString() & "' class='img' src='" & Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg" & "'><br/>" & .Rows(cnt)("fullname").ToString() & "</div>  " & Chr(13) _
                          + " <div class='centercode'><p align='left'><font style='font-size: 12px;'>" & .Rows(cnt)("fullname").ToString() & "</font><br/>" & StrConv(.Rows(cnt)("barangay").ToString, vbProperCase) & ", " & StrConv(.Rows(cnt)("municipality").ToString, vbProperCase) & "<br/>Precinct: <b>" & .Rows(cnt)("precinct").ToString() & "</b><br/>Listing No. <b>" & .Rows(cnt)("votersno").ToString() & "</b></p></div> " & Chr(13) _
                          + " <div align='center' class='rightcode'><img align='center' id='" & .Rows(cnt)("votersid").ToString() & "' class='img' src='" & Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg" & "'><br/>" & .Rows(cnt)("fullname").ToString() & "</div> " & Chr(13) _
                          + "</div></td>" & Chr(13)
                cntgroup = cntgroup + 1

                If cntgroup > 2 Then
                    TableHeader += "<tr>" & Chr(13) & TableRow & "</tr>" & Chr(13)
                    cntgroup = 0
                    TableRow = ""
                Else
                    If cnt = dst.Tables(0).Rows.Count - 1 Then
                        TableHeader += "<tr>" & Chr(13) & TableRow & "</tr>" & Chr(13)
                    End If
                End If


                picbox.Image = ConvertQRCodeImage(.Rows(cnt)("votersid").ToString())
                If System.IO.Directory.Exists(Application.StartupPath.ToString & "\Reports\QRcode\") = False Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Reports\QRcode\")
                End If
                If System.IO.File.Exists(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg") = True Then
                    System.IO.File.Delete(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg")
                End If
                picbox.Image.Save(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                com.CommandText = "update tblvoters set stubprinted=1 where votersid='" & .Rows(cnt)("votersid").ToString() & "' " : com.ExecuteNonQuery()
            End With
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", TableHeader), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
        frmColorCodeListing.StatusPreview()
    End Sub

    Public Sub GenerateCouponAssistance(ByVal query As String, ByVal form As XtraForm)
        Dim duplicate As String = "" : Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\quarantine.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\quarantine-" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        dst = New DataSet
        msda = New MySqlDataAdapter(query, conn)
        msda.Fill(dst, 0)
        Dim cntgroup As Integer = 0
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                Dim picbox As PictureBox = New PictureBox
                TableRow += "<td><div id='mainarea'>" & Chr(13) _
                          + " <img src='pass.jpg'>" & Chr(13) _
                          + " <div class='qrcode'><img src='QRcode/" & .Rows(cnt)("votersid").ToString() & ".jpg" & "' style='width: 6vw;'></div> " & Chr(13) _
                          + " <div class='textarea'> " & Chr(13) _
                          + " <div class='fullname'>" & .Rows(cnt)("fullname").ToString() & "</div> " & Chr(13) _
                          + " <div class='barangay'>BARANGAY " & StrConv(.Rows(cnt)("barangay").ToString, vbUpperCase) & "<br/><span>" & StrConv(.Rows(cnt)("barangay").ToString, vbProperCase) & ", " & StrConv(.Rows(cnt)("municipality").ToString, vbProperCase) & ", Zamboanga del Norte</span></div> " & Chr(13) _
                          + "</div>" & Chr(13) _
                          + "</div></td>" & Chr(13)

                'TableRow += "<td><div class='mainarea'>" & Chr(13) _
                '          + " <div align='center' class='leftcode'><img id='" & .Rows(cnt)("votersid").ToString() & "' class='img' src='" & Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg" & "'><br/>" & .Rows(cnt)("fullname").ToString() & "</div>  " & Chr(13) _
                '          + " <div class='centercode'><p align='left'><font style='font-size: 12px;'>" & .Rows(cnt)("fullname").ToString() & "</font><br/>" & StrConv(.Rows(cnt)("barangay").ToString, vbProperCase) & ", " & StrConv(.Rows(cnt)("municipality").ToString, vbProperCase) & "<br/>Precinct: <b>" & .Rows(cnt)("precinct").ToString() & "</b><br/>Listing No. <b>" & .Rows(cnt)("votersno").ToString() & "</b></p></div> " & Chr(13) _
                '          + " <div align='center' class='rightcode'><img align='center' id='" & .Rows(cnt)("votersid").ToString() & "' class='img' src='" & Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg" & "'><br/>" & .Rows(cnt)("fullname").ToString() & "</div> " & Chr(13) _
                '          + "</div></td>" & Chr(13)

                cntgroup = cntgroup + 1

                If cntgroup > 2 Then
                    TableHeader += "<tr>" & Chr(13) & TableRow & "</tr>" & Chr(13)
                    duplicate = "<tr>" & Chr(13) & TableRow & "</tr>" & Chr(13)
                    cntgroup = 0
                    TableRow = ""
                    TableHeader += duplicate
                Else
                    'If cnt = dst.Tables(0).Rows.Count - 1 Then
                    '    TableHeader += "<tr>" & Chr(13) & TableRow & "</tr>" & Chr(13)
                    'End If

                End If


                picbox.Image = ConvertQRCodeImage(.Rows(cnt)("votersid").ToString())
                If System.IO.Directory.Exists(Application.StartupPath.ToString & "\Reports\QRcode\") = False Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Reports\QRcode\")
                End If
                If System.IO.File.Exists(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg") = True Then
                    System.IO.File.Delete(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg")
                End If
                picbox.Image.Save(Application.StartupPath.ToString & "\Reports\QRcode\" & .Rows(cnt)("votersid").ToString() & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                com.CommandText = "update tblvoters set couponassistance=1 where votersid='" & .Rows(cnt)("votersid").ToString() & "' " : com.ExecuteNonQuery()
            End With
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", TableHeader), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), form)
        frmColorCodeListing.StatusPreview()
    End Sub
End Module
