Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class frmServerDataExporter
    Private count As Integer = 0

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

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        CheckStat()
    End Sub
    Public Sub CreateBatchCode()
        batchcode.Text = getdateid()
    End Sub
   
    Public Sub CheckStat()
        lbldate.Text = "Date Time Upload: " & Now.ToString
        tbltotalRecords.Text = "Total Records Ready to Export : " & Format(Val(countqry("settings.tblactionquerylogs", "date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateWorkFrom.EditValue) & "' and '" & ConvertDate(txtDateWorkTo.EditValue) & "' and editedtype<>'Image' and editedtype<>'Color Code Category' and editedtype<>'Users Accounts' and editedtype<>'Voter''s Sector'")), "N0")
        Filter()
    End Sub
    Public Sub Filter()
        LoadXgrid("select date_format(dateperformed, '%Y-%m-%d %r') as 'Date Performed', editedtype as 'Location Task',CONCAT(UCASE(SUBSTRING(`Remarks`, 1, 1)),LOWER(SUBSTRING(`Remarks`, 2))) as Remarks , querytask as 'Performed Queries' from settings.tblactionquerylogs where date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateWorkFrom.EditValue) & "' and '" & ConvertDate(txtDateWorkTo.EditValue) & "' and editedtype<>'Image' and editedtype<>'Color Code Category' and editedtype<>'Users Accounts' and editedtype<>'Voter''s Sector' order by id asc", "settings.tblactionquerylogs", Em, GridView1, Me)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim xstring As String = ""
        Dim MyInput As String = ""
        Dim detailsFile As StreamWriter = Nothing
        If Val(countqry("settings.tblactionquerylogs", " date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateWorkFrom.EditValue) & "' and '" & ConvertDate(txtDateWorkTo.EditValue) & "' and editedtype<>'Image' and editedtype<>'Color Code Category' and editedtype<>'Users Accounts' and editedtype<>'Voter''s Sector'")) = 0 Then
            XtraMessageBox.Show("No record to be upload", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                ProgressBarControl1.Properties.Maximum = Val(countqry("settings.tblactionquerylogs", " date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateWorkFrom.EditValue) & "' and '" & ConvertDate(txtDateWorkTo.EditValue) & "' and editedtype<>'Image' and editedtype<>'Color Code Category' and editedtype<>'Users Accounts' and editedtype<>'Voter''s Sector'"))
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from settings.tblactionquerylogs where  date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateWorkFrom.EditValue) & "' and '" & ConvertDate(txtDateWorkTo.EditValue) & "' and editedtype<>'Image' and editedtype<>'Color Code Category' and editedtype<>'Users Accounts' and editedtype<>'Voter''s Sector' order by id asc", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If CountCharacter(.Rows(cnt)("querytask").ToString(), ";") = 0 Then
                            xstring += .Rows(cnt)("querytask").ToString() & ";" & Environment.NewLine
                        Else
                            xstring += .Rows(cnt)("querytask").ToString() & "" & Environment.NewLine
                        End If
                        'xstring += "insert into settings.tblactionbackuplogs set dateperformed='" & ConvertDateTime(.Rows(cnt)("dateperformed").ToString()) & "', " _
                        '                           + " editedtype='" & rchar(.Rows(cnt)("editedtype").ToString()) & "', " _
                        '                           + " querytask='" & rchar(.Rows(cnt)("querytask").ToString()) & "', " _
                        '                           + " remarks ='" & rchar(.Rows(cnt)("remarks").ToString()) & "', " _
                        '                           + " status=0, " _
                        '                           + " performedby='" & rchar(.Rows(cnt)("performedby").ToString()) & "', " _
                        '                           + " batchcode='" & batchcode.Text & "';" & Environment.NewLine

                        'com.CommandText = "update settings.tblactionquerylogs set status=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
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
                Me.Close()
            End If
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