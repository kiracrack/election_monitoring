Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient

Public Class frmClusterized
    Private strCheckedCode As String
    Private strCheckedName As String
    Private strUnCheckedCode As String
    Private strUnCheckedName As String

    Private selectedClustercode As String
    Private selectedClusterName As String
    Private UnselectedClustercode As String
    Private UnselectedClusterName As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select id,areacode,muncode,vilcode, " _
                  + " (select areaname from tblarea where areacode = tblcluster.areacode) as 'Area/District', " _
                  + " (select munname from tblmunicipality where muncode=tblcluster.muncode) as 'Municipal/City', " _
                  + " (select villname from tblvillage where villcode=tblcluster.vilcode) as 'Village/Barangay', " _
                  + " Precincts,concat('CLUSTER ', clusterid) as 'Cluster', clusterid from tblcluster where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' ", "tblcluster", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("clusterid").Visible = False
        XgridColAlign("Cluster", GridView1, Utils.HorzAlignment.Center)
        GridView1.Columns("Precincts").ColumnEdit = MemoEdit
        GridView1.Columns("Precincts").Width = 270
    End Sub

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
        filter()
    End Sub
    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        loadArea()
        loadDefaultSelection()
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
        ElseIf txtVillage.Text = "" Then
            XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub
        ElseIf txtclusterno.Text = "" Then
            XtraMessageBox.Show("Please Select Cluster Number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtclusterno.Focus()
            Exit Sub
        End If
        If ls.CheckedItems.Count = 0 Then
            XtraMessageBox.Show("There is no selected Sector!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ls.Focus()
            Exit Sub
        End If
        strCheckedCode = "" : strCheckedName = "" : strUnCheckedCode = "" : strUnCheckedName = ""
        ' CHECKED
        For n = 0 To ls.CheckedItems.Count - 1
            strCheckedCode = strCheckedCode + " precinct = '" + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
            strCheckedName = strCheckedName + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & ","
        Next
        'UNCHECKED
        If mode.Text = "edit" Then
            For n = 0 To ls.ItemCount - 1
                If ls.Items.Item(n).CheckState = CheckState.Unchecked Then
                    strUnCheckedCode = strUnCheckedCode + " precinct = '" + ls.Items.Item(n).Value.ToString + "' or "
                    strUnCheckedName = strUnCheckedName + ls.Items.Item(n).Value.ToString & ","
                End If
            Next
            If strUnCheckedCode <> "" Then
                UnselectedClustercode = strUnCheckedCode.Remove(strUnCheckedCode.Length - 3, 3)
                UnselectedClusterName = strUnCheckedName.Remove(strUnCheckedName.Length - 1, 1)
            End If


        End If

        selectedClustercode = strCheckedCode.Remove(strCheckedCode.Length - 3, 3)
        selectedClusterName = strCheckedName.Remove(strCheckedName.Length - 1, 1)



        If mode.Text = "edit" Then
            If UnselectedClustercode <> "" Then
                com.CommandText = "update tblvoters set cluster=0,isedited=1,editedby='" & globaluserid & "' where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and (" & UnselectedClustercode & ")" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER UPDATED")

            End If
            com.CommandText = "update tblvoters set cluster=" & txtclusterno.Text & ",isedited=1,editedby='" & globaluserid & "' where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and (" & selectedClustercode & ")" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER UPDATED")

            com.CommandText = "update tblcluster set clusterid=" & txtclusterno.Text & ",areacode='" & areacode.Text & "', muncode='" & muncode.Text & "', vilcode='" & vilcode.Text & "', precincts='" & selectedClusterName & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER UPDATED")

        Else
            If selectedClustercode <> "" Then
                com.CommandText = "update tblvoters set cluster=" & txtclusterno.Text & " where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and (" & selectedClustercode & ")" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER UPDATED")
            End If
            com.CommandText = "insert into tblcluster set clusterid=" & txtclusterno.Text & ",areacode='" & areacode.Text & "', muncode='" & muncode.Text & "', vilcode='" & vilcode.Text & "', precincts='" & selectedClusterName & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER ADDED")
        End If

        filter()
        LoadPrecinct()
        XtraMessageBox.Show("Precinct successfully Clusterized", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim area As String = "" : Dim municipal As String = "" : Dim village As String = "" : Dim Precincts As String = ""
        com.CommandText = "select *,(select areaname from tblarea where areacode = tblcluster.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblcluster.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblcluster.vilcode) as 'village' from tblcluster where id='" & id.Text & "'"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            areacode.Text = rst("areacode").ToString
            area = rst("area").ToString
            muncode.Text = rst("muncode").ToString
            municipal = rst("municipal").ToString
            vilcode.Text = rst("vilcode").ToString
            village = rst("village").ToString
            Precincts = rst("precincts").ToString
            txtclusterno.Text = rst("clusterid").ToString
        End While
        rst.Close()

        txtArea.Text = area
        txtMunicipal.Text = municipal
        txtVillage.Text = village

        LoadPrecinct()

        Dim words As String() = Precincts.Split(New Char() {","c})
        Dim word As String
        For Each word In words
            ls.Items.Add(word, False)
            ls.Items.Item(word).Description = word
            ls.Items.Item(word).Value = word
            ls.Items.Item(word).CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        mode.Text = "edit"
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblvoters set cluster=0,isedited=1,editedby='" & globaluserid & "' where areacode='" & GridView1.GetFocusedRowCellValue("areacode").ToString & "' and muncode='" & GridView1.GetFocusedRowCellValue("muncode").ToString & "' and vilcode='" & GridView1.GetFocusedRowCellValue("vilcode").ToString & "' and precinct REGEXP ',?" & GridView1.GetFocusedRowCellValue("Precincts").ToString.Replace(",", "|") & ",?'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CLUSTER UPDATED")

            DeleteRow("id", "id", "tblcluster", GridView1, Me)

        End If
        LoadPrecinct()
        id.Text = getareaid()
    End Sub

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    strCheckedCode = "" : strCheckedName = "" : strUnCheckedCode = "" : strUnCheckedName = ""
    '    For n = 0 To ls.CheckedItems.Count - 1
    '        strCheckedName = strCheckedName + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & ","
    '    Next
    '    selectedClusterName = strCheckedName.Remove(strCheckedName.Length - 1, 1)
    '    MsgBox(selectedClusterName)

    '    For n = 0 To ls.ItemCount - ls.CheckedItems.Count
    '        If ls.Items.Item(n).CheckState = CheckState.Unchecked Then
    '            strUnCheckedName = strUnCheckedName + ls.Items.Item(n).Value.ToString & ","
    '        End If
    '    Next
    '    UnselectedClusterName = strUnCheckedName.Remove(strUnCheckedName.Length - 1, 1)
    '    MsgBox(UnselectedClusterName)
    'End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        mode.Text = ""
        id.Text = ""
        LoadPrecinct()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        printreport()
    End Sub
    Public Sub printreport()
        Dim report As New rptOtherReport()
        'report.MasterReport.Margins.
        report.txttitle.Text = Me.Text
        'report.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
End Class