Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils
Imports System.IO
Imports System.Drawing.Imaging
Imports DevExpress.XtraSplashScreen
Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid

Module Libraries
    Public bmpScreenShot As Bitmap
    Public gfxScreenshot As Graphics
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Return value.Count(Function(c As Char) c = ch)
    End Function
    Public Function CloseOpenForm(ByVal form As DevExpress.XtraEditors.XtraForm)
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot MainMonitoring And My.Application.OpenForms.Item(i) IsNot frmLogin And My.Application.OpenForms.Item(i) IsNot form Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        Return 0
    End Function
    Public Function LoadToComboBox(ByVal fld As String, ByVal tbl As String, ByVal combo As DevExpress.XtraEditors.ComboBoxEdit, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = combo.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select distinct(" & fld & ") from " & tbl & " order by " & fld & " DESC"
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst(fld))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        End If
        Return Coll
    End Function
    Public Function NoSequence(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Dim cnt As Integer = 1
        Dim exisCol As Boolean = False
        Dim colname As New DevExpress.XtraGrid.Columns.GridColumn
        colname.Name = "colNo."
        colname.FieldName = "No."
        colname.UnboundType = DevExpress.Data.UnboundColumnType.String
        For I = 0 To xgrid.Columns.Count - 1
            If xgrid.Columns.Item(I).Name = "colNo." Then
                exisCol = True
            End If
        Next

        If exisCol = False Then
            xgrid.Columns.Add(colname)
            colname.VisibleIndex = 0 : colname.Visible = True
            colname.FilterMode = ColumnFilterMode.DisplayText
        Else
            xgrid.Columns("No.").VisibleIndex = 0 : xgrid.Columns("No.").Visible = True
        End If
       
        myform.Cursor = Cursors.WaitCursor
        For I = 0 To xgrid.DataRowCount - 1
            xgrid.SetRowCellValue(I, "No.", cnt)
            cnt = cnt + 1
        Next I

        myform.Cursor = Cursors.Default
        Return 0
    End Function
    Public Function LoadXgrid(ByVal qry As String, ByVal tbl As String, ByVal Em As DevExpress.XtraGrid.GridControl, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim dst = New DataSet : dst.Clear()
            msda = New MySqlDataAdapter(qry, conn)
            msda.Fill(dst, tbl)
            Em.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Em.ForceInitialize()
            xgrid.BestFitColumns()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            'Catch errMS As Exception
            '    XtraMessageBox.Show("Form:" & myform.Name & vbCrLf _
            '                     & "Module:" & "form_load" & vbCrLf _
            '                     & "Message:" & errMS.Message & vbCrLf _
            '                     & "Details:" & errMS.StackTrace, _
            '                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function LoadXgridLookupEdit(ByVal qry As String, ByVal tbl As String, ByVal Xglue As DevExpress.XtraEditors.GridLookUpEdit, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim dst As New DataSet : dst.Clear()
            msda = New MySql.Data.MySqlClient.MySqlDataAdapter(qry, conn)
            msda.Fill(dst, tbl)
            Xglue.Properties.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Xglue.Properties.View.BestFitColumns()
            Xglue.ForceInitialize()
            xgrid.BestFitColumns()

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
        Return 0
    End Function
    Public Function LoadXgridLookupSearch(ByVal qry As String, ByVal tbl As String, ByVal Xglue As DevExpress.XtraEditors.SearchLookUpEdit, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim dst As New DataSet : dst.Clear()
            msda = New MySql.Data.MySqlClient.MySqlDataAdapter(qry, conn)
            msda.Fill(dst, tbl)
            Xglue.Properties.DataSource = dst.Tables(tbl)
            xgrid.PopulateColumns(dst.Tables(tbl))
            Xglue.Properties.View.BestFitColumns()
            Xglue.ForceInitialize()
            If xgrid.RowCount <> 0 Then
                xgrid.BestFitColumns()
            End If


        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            'Catch errMS As Exception
            '    XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
            '                     & "Message:" & errMS.Message & vbCrLf, _
            '                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    PrintError()
        End Try
        Return 0
    End Function
    Public Function LoadXgridLookupSearchServer(ByVal qry As String, ByVal tbl As String, ByVal Xglue As DevExpress.XtraEditors.SearchLookUpEdit, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim dstclient As New DataSet : dstclient.Clear()
            msdaclient = New MySql.Data.MySqlClient.MySqlDataAdapter(qry, connclient)
            msdaclient.Fill(dstclient, tbl)
            Xglue.Properties.DataSource = dstclient.Tables(tbl)
            xgrid.PopulateColumns(dstclient.Tables(tbl))
            Xglue.Properties.View.BestFitColumns()
            Xglue.ForceInitialize()
            xgrid.BestFitColumns()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        'Catch errMS As Exception
        '    XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
        '                     & "Message:" & errMS.Message & vbCrLf, _
        '                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    PrintError()
        End Try
        Return 0
    End Function
    Public Function XgridColCurrency(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            xgrid.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
            xgrid.Columns(i).DisplayFormat.FormatString = "n"
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
        Return 0
    End Function
    Public Function XgridColNumber(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            xgrid.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
            xgrid.Columns(i).DisplayFormat.FormatString = "N0"
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
        Return 0
    End Function
    Public Function XgridColAlign(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal algn As DevExpress.Utils.HorzAlignment)
        Try
            xgrid.Columns(i).AppearanceCell.TextOptions.HAlignment = algn
            xgrid.Columns(i).AppearanceHeader.TextOptions.HAlignment = algn
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
        Return 0
    End Function
    Public Function XgridColWidth(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal size As Integer)
        Try
            xgrid.Columns(i).Width = size
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
        Return 0
    End Function
    Public Sub RemoveSpecialChar(ByVal panel As DevExpress.XtraEditors.PanelControl)
        Dim Ctl As Control
        Try
            For Each Ctl In panel.Controls
                If TypeOf Ctl Is DevExpress.XtraEditors.TextEdit Or TypeOf Ctl Is DevExpress.XtraEditors.ComboBoxEdit Or TypeOf Ctl Is DevExpress.XtraEditors.MemoEdit Then
                    Ctl.Text = Ctl.Text.Replace("'", "''")
                    Ctl.Text = Ctl.Text.Replace("\", "\\")
                End If
            Next Ctl
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
    End Sub
     Public Function CheckSelectedRow(ByVal col As String, ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean
        Try
            If Xgrid.GetFocusedRowCellValue(col) = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckSelectedRow = False
            Else
                CheckSelectedRow = True
            End If
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
    End Function
    Public Function DeleteRow(ByVal col As String, ByVal fld As String, ByVal tbl As String, ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim todelete As String = ""
            ReDim Rows(Xgrid.SelectedRowsCount - 1)
            For I = 0 To Xgrid.SelectedRowsCount - 1
                Rows(I) = Xgrid.GetDataRow(Xgrid.GetSelectedRows(I))
                todelete = Xgrid.GetRowCellValue(Xgrid.GetSelectedRows(I), col)
                com.CommandText = "DELETE from " & tbl & " where " & fld & "='" & todelete & "'" : com.ExecuteNonQuery()
                LogQuery(myform.Text, com.CommandText.ToString, "DELETED")
            Next
            For Each Row In Rows
                Row.Delete()
            Next
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
        Return 0
    End Function
    Public Function ResizeImage(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal imgsize As Integer, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If Not img.Image Is Nothing Then
                Dim Original As New Bitmap(img.Image)
                img.Image = Original

                Dim m As Int32 = imgsize
                Dim n As Int32 = m * Original.Height / Original.Width

                Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
                Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

                Dim g As Graphics = Graphics.FromImage(Thumb)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

                g.DrawImage(Original, New Rectangle(0, 0, m, n))
                img.Image = Thumb
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
        Return 0
    End Function

    Public Function UpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        arrImage = Nothing
        Try
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Gif)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If
            If countqry("filedir.tblvotersimage", qry) = 0 Then
                sql = "insert into " & tbl & " set " & qry & ",  " & fld & " = @file"
            Else
                sql = "Update " & tbl & " set " & fld & " = @file where " & qry
            End If
          
            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()


            Dim qryTask As String = sqlcmd.CommandText.ToString
            Dim qryStr As String = "INSERT into `settings`.`tblactionquerylogs` set dateperformed=current_timestamp, editedtype='Image', querytask='" & rchar(qryTask) & "', remarks='UPDATE IMAGE', status=1,performedby='" & globaluserid & "', img=@file "
            With com
                .CommandText = qryStr
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            com.Parameters.Clear()

            ' com.CommandText = qryStr : com.ExecuteNonQuery()
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
        Return 0
    End Function
    Public Function UpdateIcon(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        arrImage = Nothing
        Try
            If Not Ximg.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Icon)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            sql = "Update " & tbl & " set " & fld & " = @file where " & qry

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

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
        Return 0
    End Function
    Public Function ShowImage(ByVal fld As String, ByVal Ximg As DevExpress.XtraEditors.PictureEdit, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                Ximg.Image = img
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
        Return 0
    End Function

    Public Function UpdateReportTitle(ByVal Title As String, ByVal customText As String, ByVal myform As DevExpress.XtraEditors.XtraForm)
        Try
            If countqry("tblreportsetting", "formname='" & myform.Name.ToString & "'") = 0 Then
                com.CommandText = "insert into tblreportsetting set title='" & Title & "', customtext='" & customText & "' where formname='" & myform.Name.ToString & "' " : com.ExecuteNonQuery()
                LogQuery("Report Title", com.CommandText.ToString, "ADD NEW REPORT TITLE")
            Else
                com.CommandText = "update tblreportsetting set title='" & Title & "', customtext='" & customText & "' where formname='" & myform.Name.ToString & "' " : com.ExecuteNonQuery()
                LogQuery("Report Title", com.CommandText.ToString, "UPDATE REPORT TITLE")
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
        Return 0
    End Function
    Public Sub AddRowXgrid(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim currentRow As Integer
        Try
            currentRow = View.FocusedRowHandle
            If currentRow < 0 Then
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow)
            End If
            View.AddNewRow()
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
    End Sub
    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal qry As String, ByVal tbl As String)
        Dim def As String = ""

        If countrecord(tbl) = 0 Then
            def = ""
        Else
            com.CommandText = "select " & fqry & " from " & tbl & " " & qry : rst = com.ExecuteReader
            While rst.Read
                def = rst(field).ToString
            End While
            rst.Close()
        End If

        Return def
    End Function
    Public Function qrysingledataServer(ByVal field As String, ByVal fqry As String, ByVal qry As String, ByVal tbl As String)
        Dim def As String = ""
        Try
            If countrecordserver(tbl) = 0 Then
                def = ""
            Else
                comclient.CommandText = "select " & fqry & " from " & tbl & " " & qry : rstclient = comclient.ExecuteReader
                While rstclient.Read
                    def = rstclient(field).ToString
                End While
                rstclient.Close()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
        Return def
    End Function

    Public Sub ViewGridtype(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        If GLobalWebtypePrinter = True Then
            xgrid.PaintStyleName = "Web"
            xgrid.Appearance.FooterPanel.BackColor = Color.White
            xgrid.Appearance.FooterPanel.BackColor2 = Color.White

            xgrid.Appearance.GroupFooter.BackColor = Color.White
            xgrid.Appearance.GroupFooter.BackColor2 = Color.White

            xgrid.Appearance.FooterPanel.BorderColor = Color.LightGray
            xgrid.BestFitColumns()
            'xgrid.Appearance.GroupPanel.BorderColor = Color.LightGray
        Else
            xgrid.PaintStyleName = "Default"
            xgrid.BestFitColumns()
        End If
    End Sub
    Public Sub PrintError()
        'bmpScreenShot = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb)
        'gfxScreenshot = Graphics.FromImage(bmpScreenShot)
        'gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
        'bmpScreenShot.Save(Application.StartupPath & "\Errors\" & createTRNID("ERR") & ".png", ImageFormat.Png)
    End Sub
    Public Sub PrintLXReceipt(ByVal location As String, ByVal form As DevExpress.XtraEditors.XtraForm)
        Dim printProcess As New ProcessStartInfo()
        printProcess.FileName = location
        Try
            Process.Start(printProcess)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReadFilterColumn(ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal filterName As String)
        Dim colname As String = ""
        For I = 0 To Xgrid.Columns.Count - 1
            colname += Xgrid.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(Xgrid, filterName)
        frmColumnFilter.ShowDialog()
        SaveFilterColumn(Xgrid, filterName)
    End Sub

    Public Sub SaveFilterColumn(ByVal Xgrid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal filterName As String)
        Dim file_conn As String = Application.StartupPath.ToString & "\_config\" & filterName
        If System.IO.File.Exists(file_conn) = True Then
            Dim sr As StreamReader = File.OpenText(file_conn)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                Dim cnt As Integer = 0

                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    If strresult = 0 Then
                        Xgrid.Columns(cnt).Visible = True
                    Else
                        Xgrid.Columns(cnt).Visible = False
                    End If
                    cnt = cnt + 1
                Next

                sr.Close()
            Catch errMS As Exception
                XtraMessageBox.Show("Message: Invalid column filter format! Please update your columns" & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sr.Close()
            End Try
        End If
    End Sub

    Public Function ConvertImageBinary(ByVal fld As String)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)

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
        Return img
    End Function

    Public Function ConvertQRCodeImage(ByVal value As String)
        Dim imagecode As Image = Nothing
        Dim barcode As New BarCodeControl
        Try
            Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            barcode.Module = 10.0R
            barcode.Name = "BarCodeControl1"
            barcode.ShowText = False
            barcode.Size = New System.Drawing.Size(232, 233)
            QrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1

            barcode.Symbology = QrCodeGenerator1
            barcode.TabIndex = 572
            barcode.Text = value
            imagecode = barcode.ExportToImage

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return imagecode
    End Function

    Public Function InputNumberOnly(ByVal textbox As TextEdit, e As KeyPressEventArgs)
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = textbox.Text
            Dim selectionStart = textbox.SelectionStart
            Dim selectionLength = textbox.SelectionLength
            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Function

    Public Sub UpdateGridColumnSetting(ByVal formname As String, ByVal gv As GridView)
        com.CommandText = "delete from tblcolumnindex where form='" & formname & "' and gridview='" & gv.Name & "'" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into tblcolumnindex set form='" & formname & "', gridview='" & gv.Name & "', columnname='" & rchar(gv.Columns(I).FieldName) & "',columnwidth='" & gv.Columns(I).Width & "', colindex='" & gv.Columns(I).VisibleIndex & "'" : com.ExecuteNonQuery()
            End If
        Next
    End Sub

End Module
