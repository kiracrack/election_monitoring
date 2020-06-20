Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls

Public Class frmCaptureFromCommelecNew
    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text
        loadArea()

        ViewGridtype(GridView1)
        showMasterListTables()
    End Sub

    Public Sub showMasterListTables()
        txtMasterDistrict.Properties.Items.Clear()
        com.CommandText = "show tables from masterlist" : rst = com.ExecuteReader
        While rst.Read
            txtMasterDistrict.Properties.Items.Add(rst("Tables_in_masterlist"))
        End While
        rst.Close()
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
        txtArea.Text = txtArea.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadMunicipal()
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadVillage()
    End Sub

    Public Sub loadVillage()
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub

    Public Sub ShowMAsterlist()
        If txtMasterBarangay.Text = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim precinct As String = ""
        For n = 0 To ls.CheckedItems.Count - 1
            precinct = precinct + "precinct='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
        Next

        If precinct.Length > 0 Then
            precinct = precinct.Remove(precinct.Length - 3, 3)
        End If
        LoadXgrid("select * from masterlist." & txtMasterDistrict.Text & " where " _
                                    + " municipality='" & txtMasterMunicipal.Text & "' and address like '%" & txtMasterBarangay.Text & "%' and (" & precinct & ")", "masterlist." & txtMasterDistrict.Text & "", Em, GridView1, Me)

        GridView1.Columns("fullname").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("fullname").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("fullname").SummaryItem.Tag = 1
        CType(GridView1.Columns("fullname").View, GridView).OptionsView.ShowFooter = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub
    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()

        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString
        report.txttitle.Text = txttitle.Text
         
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
     

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub txtMasterDistrict_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtMasterDistrict.SelectedValueChanged
        LoadToComboBox("municipality", "masterlist." & txtMasterDistrict.Text, txtMasterMunicipal, True)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowMAsterlist()
    End Sub

    Private Sub cmdFilter_Click(sender As Object, e As EventArgs) Handles cmdFilter.Click
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" Then
            XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub

        End If
        If countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'") > 0 Then
            If XtraMessageBox.Show("Existing data found! Are you sure you want to overwrite existing data? configure voters setting will be resetted!", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                com.CommandText = "delete from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'" : com.ExecuteNonQuery()
                Dim precinct As String = ""
                For n = 0 To ls.CheckedItems.Count - 1
                    precinct = precinct + "precinct='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
                Next

                If precinct.Length > 0 Then
                    precinct = precinct.Remove(precinct.Length - 3, 3)
                End If

                com.CommandText = "insert into tblvoters (comelecid,precinct,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,entryby) " _
                            + " select votersid,precinct,fullname,address,birthdate,sex,vtype,'" & areacode.Text & "','" & muncode.Text & "','" & vilcode.Text & "','" & globaluserid & "' from masterlist." & txtMasterDistrict.Text & " where " _
                                        + " municipality='" & txtMasterMunicipal.Text & "' and address like '%" & txtMasterBarangay.Text & "%' and (" & precinct & ")" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Data successfully migrated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If XtraMessageBox.Show("Are you sure to continue data migration to " & txtMunicipal.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim precinct As String = ""
                For n = 0 To ls.CheckedItems.Count - 1
                    precinct = precinct + "precinct='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "' or "
                Next

                If precinct.Length > 0 Then
                    precinct = precinct.Remove(precinct.Length - 3, 3)
                End If

                com.CommandText = "insert into tblvoters (comelecid,precinct,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,entryby) " _
                                + " select votersid,precinct,fullname,address,birthdate,sex,vtype,'" & areacode.Text & "','" & muncode.Text & "','" & vilcode.Text & "','" & globaluserid & "' from masterlist." & txtMasterDistrict.Text & " where " _
                                            + " municipality='" & txtMasterMunicipal.Text & "' and address like '%" & txtMasterBarangay.Text & "%' and (" & precinct & ")" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Data successfully migrated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadPrecinct()
    End Sub
    Public Sub LoadPrecinct()
      
        Dim combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        com.CommandText = "select distinct(precinct) as 'pre' from masterlist." & txtMasterDistrict.Text & " where " _
                                    + " municipality='" & txtMasterMunicipal.Text & "' and address like '%" & txtMasterBarangay.Text & "%'"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("pre"), False)
            ls.Items.Item(rst("pre")).Description = rst("pre").ToString
            ls.Items.Item(rst("pre")).Value = rst("pre").ToString
        End While
        rst.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For n = 0 To ls.ItemCount - 1
            If CheckEdit1.Checked = True Then
                ls.Items.Item(n).CheckState = CheckState.Checked
            Else
                ls.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
    End Sub
End Class