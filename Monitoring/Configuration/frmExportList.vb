Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmExportList
    Private strCheckedCode As String
    Private selectedClustercode As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub loadArea()
        LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtArea.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtArea.Properties.View.GetFocusedRowCellValue("Code").ToString()
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        loadMunicipal()
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode = '" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        If muncode.Text <> "" Then
            loadvil()
        End If
    End Sub


    Public Sub loadvil()
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        LoadPrecinct()
    End Sub
    Public Sub LoadPrecinct()
        Dim combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        com.CommandText = "select distinct(precinct) from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("precinct"), False)
            ls.Items.Item(rst("precinct")).Description = rst("precinct").ToString
            ls.Items.Item(rst("precinct")).Value = rst("precinct").ToString
        End While
        rst.Close()

    End Sub
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        CreateBatchCode()
        loadArea()
        loadDefaultSelection()
    End Sub
    Public Sub CreateBatchCode()
        batchcode.Text = getdateid()
    End Sub
    Public Sub loadDefaultSelection()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblaccounts where accountid='" & globaluserid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                areacode.Text = .Rows(cnt)("areacode").ToString
                txtArea.EditValue = .Rows(cnt)("areacode").ToString
                muncode.Text = .Rows(cnt)("muncode").ToString
                txtMunicipal.EditValue = .Rows(cnt)("muncode").ToString
                vilcode.Text = .Rows(cnt)("brgycode").ToString
                txtVillage.EditValue = .Rows(cnt)("brgycode").ToString
            End With
        Next
    End Sub
    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" And CheckBox1.Checked = False Then
            XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub
        End If
        If ls.CheckedItems.Count = 0 And CheckBox1.Checked = False Then
            XtraMessageBox.Show("There is no selected Sector!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ls.Focus()
            Exit Sub
        End If

        If CheckBox1.Checked = False Then
            strCheckedCode = ""
            For n = 0 To ls.CheckedItems.Count - 1
                strCheckedCode = strCheckedCode + " precinct = '" + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
            Next
            selectedClustercode = strCheckedCode.Remove(strCheckedCode.Length - 3, 3)
        End If

        Dim totalrecords As Integer = countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & If(CheckBox1.Checked = False, " and vilcode='" & vilcode.Text & "' and (" & selectedClustercode & ")", ""))
        Dim xstring As String = ""
        Dim MyInput As String = ""
        Dim detailsFile As StreamWriter = Nothing
      
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
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
                ProgressBarControl1.Properties.Maximum = Val(totalrecords)
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & If(CheckBox1.Checked = False, " and vilcode='" & vilcode.Text & "' and (" & selectedClustercode & ")", ""), conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        'Dim qrytask As String = "insert into tblvoters set precinct='" & rchar(.Rows(cnt)("precinct").ToString()) & "',votersno='" & rchar(.Rows(cnt)("votersno").ToString()) & "',fullname='" & rchar(.Rows(cnt)("fullname").ToString()) & "',address='" & rchar(.Rows(cnt)("address").ToString()) & "',areacode='" & rchar(.Rows(cnt)("areacode").ToString()) & "',muncode='" & rchar(.Rows(cnt)("muncode").ToString()) & "',vilcode='" & rchar(.Rows(cnt)("vilcode").ToString()) & "',colorcode='C10001';"
                        xstring += "insert into tblvoters set precinct='" & rchar(.Rows(cnt)("precinct").ToString()) & "',votersno='" & rchar(.Rows(cnt)("votersno").ToString()) & "',fullname='" & rchar(.Rows(cnt)("fullname").ToString()) & "',address='" & rchar(.Rows(cnt)("address").ToString()) & "',areacode='" & rchar(.Rows(cnt)("areacode").ToString()) & "',muncode='" & rchar(.Rows(cnt)("muncode").ToString()) & "',vilcode='" & rchar(.Rows(cnt)("vilcode").ToString()) & "',colorcode='C10001';" & Environment.NewLine
                        'xstring += "insert into settings.tblactionbackuplogs set dateperformed=current_timestamp, " _
                        '                           + " editedtype='export', " _
                        '                           + " querytask='" & rchar(qrytask) & "', " _
                        '                           + " remarks ='Export List', " _
                        '                           + " status=0, " _
                        '                           + " performedby='105', " _
                        '                           + " batchcode='" & batchcode.Text & "';" & Environment.NewLine

                    End With
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                Next
                detailsFile.WriteLine(EncryptTripleDES(xstring))
                detailsFile.Close()
                getBatchCode()
                XtraMessageBox.Show("Records Successfully Exported!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBarControl1.Position = 0
            End If
        End If
    End Sub

    Private Sub ls_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ls.ItemCheck
        CountTotal()
    End Sub

    Private Sub ls_ItemChecking(sender As Object, e As ItemCheckingEventArgs) Handles ls.ItemChecking
        CountTotal()
    End Sub

    Public Sub CountTotal()
        strCheckedCode = ""
        If ls.CheckedItems.Count = 0 Then
            txtTotal.Text = "Total Export 0"
        Else
            For n = 0 To ls.CheckedItems.Count - 1
                strCheckedCode = strCheckedCode + " precinct = '" + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
            Next
            selectedClustercode = strCheckedCode.Remove(strCheckedCode.Length - 3, 3)
            txtTotal.Text = "Total Export " & FormatNumber(countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and (" & selectedClustercode & ")"), 0)
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtVillage.Enabled = False
            ls.Enabled = False
        Else
            txtVillage.Enabled = True
            ls.Enabled = True
        End If
    End Sub
End Class