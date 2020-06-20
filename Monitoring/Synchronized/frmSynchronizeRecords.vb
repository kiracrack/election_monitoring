Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class frmSynchronizeRecords
    Private count As Integer = 0
    Private records As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub TestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadSettings()
        CreateBatchCode()
        If CheckConnServer() = True Then
            lblserver.Text = "Server Status: Connected"
            startAsyncButton.Enabled = True
            CheckStat()
        Else
            lblip.Text = "Server IP : " & clientserver
            lblserver.Text = "Server Status: Disconnected"
            tbltotalRecords.Text = "Total Records Ready to Upload : " & Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            records = Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            startAsyncButton.Enabled = False
        End If
        Filter()
        'GridView1.BorderStyle = BorderStyles.NoBorder
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsBehavior.[ReadOnly] = True

        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsView.ShowAutoFilterRow = False
        GridView1.OptionsView.ShowIndicator = False
        GridView1.OptionsView.EnableAppearanceEvenRow = True
        GridView1.OptionsView.EnableAppearanceOddRow = True
        GridView1.OptionsView.ShowHorzLines = True
        GridView1.OptionsView.ShowVertLines = False
        GridView1.OptionsView.ShowViewCaption = False
    End Sub
    Public Sub CreateBatchCode()
        batchcode.Text = getdateid()
    End Sub
    Public Sub Filter()
        LoadXgrid("select date_format(dateperformed, '%Y-%m-%d %r') as 'Date Performed', editedtype as 'Location Task',CONCAT(UCASE(SUBSTRING(`Remarks`, 1, 1)),LOWER(SUBSTRING(`Remarks`, 2))) as Remarks , querytask as 'Performed Queries' from settings.tblactionquerylogs where status=1 order by dateperformed asc", "settings.tblactionquerylogs", Em, GridView1, Me)
    End Sub
    Public Sub CheckStat()
        If clientserver = "" Then
            lblip.Text = "Server IP : NO IP SERVER"
            lbldate.Text = "Date Time Upload: " & Now.ToString
            tbltotalRecords.Text = "Total Records Ready to Upload : " & Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            records = Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            startAsyncButton.Enabled = False
        Else
            lblip.Text = "Server IP : " & clientserver
            lbldate.Text = "Date Time Upload: " & Now.ToString
            tbltotalRecords.Text = "Total Records Ready to Upload : " & Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            records = Format(Val(countqry("settings.tblactionquerylogs", "status=1")), "N0")
            startAsyncButton.Enabled = True
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim MyInput As String
        MyInput = InputBox("Client Server", Me.Text, clientserver, 100, 100)
        If MyInput Is "" Then Exit Sub
        com.CommandText = "update settings.tblsettings set clientserver='" & MyInput & "'" : com.ExecuteNonQuery()
        If XtraMessageBox.Show("Server updated! do you want to reconnect server? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            If CheckConnServer() = True Then
                lblserver.Text = "Server Status: Connected"
                startAsyncButton.Enabled = True
                CheckStat()
            Else
                lblserver.Text = "Server Status: Disconnected"
                lblip.Text = "Server IP : " & clientserver
                startAsyncButton.Enabled = False
            End If
        End If
    End Sub
    Private Sub startAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startAsyncButton.Click
        'simulate long running processes
        If Val(countqry("settings.tblactionquerylogs", "status=1")) = 0 Then
            XtraMessageBox.Show("No record to be upload", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & tbltotalRecords.Text, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            BackupFirst("Uploaded")
            Dim xstring As String = ""
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = Val(countqry("settings.tblactionquerylogs", "status=1"))
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            dst = New DataSet
            msda = New MySqlDataAdapter("select * from settings.tblactionquerylogs where status=1 order by id asc", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If .Rows(cnt)("editedtype").ToString() = "Image" Then
                        If .Rows(cnt)("img").ToString() <> "" Then
                            imgBytes = CType(.Rows(cnt)("img"), Byte())
                            stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                            img = Image.FromStream(stream)
                        End If

                        If Not img Is Nothing Then
                            Dim mstream As New System.IO.MemoryStream()
                            img.Save(mstream, System.Drawing.Imaging.ImageFormat.Gif)
                            arrImage = mstream.GetBuffer()
                            mstream.Close()

                            sql = .Rows(cnt)("querytask").ToString()
                            comclient.Parameters.Clear()
                            With comclient
                                .CommandText = sql
                                .Connection = connclient
                                .Parameters.AddWithValue("@file", arrImage)
                                .ExecuteNonQuery()
                            End With
                        End If

                    Else
                        If CountCharacter(.Rows(cnt)("querytask").ToString(), ";") = 0 Then
                            comclient.CommandText = .Rows(cnt)("querytask").ToString() & ";" : comclient.ExecuteNonQuery()
                        Else
                            comclient.CommandText = .Rows(cnt)("querytask").ToString() : comclient.ExecuteNonQuery()
                        End If
                    End If
                    comclient.CommandText = "insert into settings.tblactionquerylogs set dateperformed='" & ConvertDateTime(.Rows(cnt)("dateperformed").ToString()) & "',editedtype='" & rchar(.Rows(cnt)("editedtype").ToString()) & "',querytask='" & rchar(.Rows(cnt)("querytask").ToString()) & "',remarks='" & rchar(.Rows(cnt)("remarks").ToString()) & "',status=0,performedby='" & rchar(.Rows(cnt)("performedby").ToString()) & "'" : comclient.ExecuteNonQuery()
                    com.CommandText = "insert into settings.tblactionbackuplogs (dateperformed,editedtype,querytask,remarks,status,performedby,batchcode,img) select dateperformed,editedtype,querytask,remarks,0,performedby,'" & batchcode.Text & "',img from settings.tblactionquerylogs where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update settings.tblactionquerylogs set status=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            Filter()
            CheckStat()
            getBatchCode()
            XtraMessageBox.Show("Records Successfully uploaded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBarControl1.Position = 0
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim xstring As String = ""
        Dim MyInput As String = ""
        Dim detailsFile As StreamWriter = Nothing
        If Val(countqry("settings.tblactionquerylogs", "status=1")) = 0 Then
            XtraMessageBox.Show("No record to be upload", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Val(countqry("settings.tblactionquerylogs", "status=1 and editedtype='Image'")) > 0 Then
            XtraMessageBox.Show("Records contains image, and cannot be exported! please use upload data online", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & tbltotalRecords.Text, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            BackupFirst("Exported")
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Filter = "DAT files (*.DAT)|*.DAT|All files (*.*)|*.*"
            saveFileDialog1.FileName = "Exported " & GlobalDateTime.ToString.Replace(":", "") & ".DAT"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                    System.IO.File.Delete(saveFileDialog1.FileName)
                End If
                detailsFile = New StreamWriter(saveFileDialog1.FileName, True)
                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Maximum = Val(countqry("settings.tblactionquerylogs", "status=1"))
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from settings.tblactionquerylogs where status=1 order by id asc", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If CountCharacter(.Rows(cnt)("querytask").ToString(), ";") = 0 Then
                            xstring += .Rows(cnt)("querytask").ToString() & ";" & Environment.NewLine
                        Else
                            xstring += .Rows(cnt)("querytask").ToString() & "" & Environment.NewLine
                        End If
                        xstring += "insert into settings.tblactionbackuplogs set dateperformed='" & ConvertDateTime(.Rows(cnt)("dateperformed").ToString()) & "', " _
                                                   + " editedtype='" & rchar(.Rows(cnt)("editedtype").ToString()) & "', " _
                                                   + " querytask='" & rchar(.Rows(cnt)("querytask").ToString()) & "', " _
                                                   + " remarks ='" & rchar(.Rows(cnt)("remarks").ToString()) & "', " _
                                                   + " status=0, " _
                                                   + " performedby='" & rchar(.Rows(cnt)("performedby").ToString()) & "', " _
                                                   + " batchcode='" & batchcode.Text & "';" & Environment.NewLine

                        com.CommandText = "update settings.tblactionquerylogs set status=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    End With
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                Next
                detailsFile.WriteLine(EncryptTripleDES(xstring))
                detailsFile.Close()
                Filter()
                CheckStat()
                getBatchCode()
                XtraMessageBox.Show("Records Successfully Exported!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBarControl1.Position = 0
            End If
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If Val(countqry("settings.tblactionquerylogs", "status=1")) = 0 Then
            XtraMessageBox.Show("No record to be backup", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue Backup? " & tbltotalRecords.Text, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from settings.tblactionbackuplogs where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into settings.tblactionbackuplogs (dateperformed,editedtype,querytask,remarks,status,performedby,batchcode,img) select dateperformed,editedtype,querytask,remarks,status,performedby,'" & batchcode.Text & "',img from settings.tblactionquerylogs where status=1 order by dateperformed asc" : com.ExecuteNonQuery()
            com.CommandText = "insert into settings.tblactionhistory set daterecord=current_timestamp, encripteddata='" & batchcode.Text & "', remarks='" & Val(countqry("settings.tblactionquerylogs", "status=1")) & " Total Edited Rows Backup',trnby='" & globalfullname & "',trntype=2" : com.ExecuteNonQuery()
            getBatchCode()
            XtraMessageBox.Show("Records Successfully Backed up!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function BackupFirst(ByVal trntype As String)
        com.CommandText = "delete from settings.tblactionbackuplogs where batchcode='" & batchcode.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "insert into settings.tblactionbackuplogs (dateperformed,editedtype,querytask,remarks,status,performedby,batchcode,img) select dateperformed,editedtype,querytask,remarks,status,performedby,'" & batchcode.Text & "',img from settings.tblactionquerylogs where status=1 order by dateperformed asc" : com.ExecuteNonQuery()
        com.CommandText = "insert into settings.tblactionhistory set daterecord=current_timestamp, encripteddata='" & batchcode.Text & "', remarks='" & Val(countqry("settings.tblactionquerylogs", "status=1")) & " Total Edited Rows " & trntype & "',trnby='" & globalfullname & "',trntype=1" : com.ExecuteNonQuery()

        Return 0
    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class