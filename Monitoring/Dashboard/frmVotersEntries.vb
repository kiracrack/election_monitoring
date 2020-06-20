Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmVotersEntries
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.C Then
            If selectedColorCode = "" Then
                If XtraMessageBox.Show("Default color currently not selected! Do you want to select color? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmColorChange.ShowDialog()
                Else
                    Return False
                End If
            End If
            ChangeColor(selectedColorCode, selectedColorname)
        ElseIf keyData = Keys.Control + Keys.T Then
            If selectedSectorCode = "" Then
                If XtraMessageBox.Show("Default sector currently not selected! Do you want to select sector? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmTagSector.ShowDialog()
                Else
                    Return False
                End If
            End If
            ChangeSector(selectedSectorCode, selectedSectorName)

        ElseIf keyData = Keys.Control + Keys.E Then
            cmdEdit.PerformClick()

        ElseIf keyData = Keys.Control + Keys.L Then
            cmdLeader.PerformClick()

        ElseIf keyData = Keys.F1 Then
            ChangeColorKey("F1")
        ElseIf keyData = Keys.F2 Then
            ChangeColorKey("F2")
        ElseIf keyData = Keys.F3 Then
            ChangeColorKey("F3")
        ElseIf keyData = Keys.F4 Then
            ChangeColorKey("F4")
        ElseIf keyData = Keys.F5 Then
            ChangeColorKey("F5")
        ElseIf keyData = Keys.F6 Then
            ChangeColorKey("F6")
        ElseIf keyData = Keys.F7 Then
            ChangeColorKey("F7")
        ElseIf keyData = Keys.F8 Then
            ChangeColorKey("F8")
        ElseIf keyData = Keys.F9 Then
            ChangeColorKey("F9")
        ElseIf keyData = Keys.F10 Then
            ChangeColorKey("F10")
        ElseIf keyData = Keys.F11 Then
            ChangeColorKey("F11")
        ElseIf keyData = Keys.F12 Then
            ChangeColorKey("F12")

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text
        loadArea()
        If LCase(globaluser) = "admin" Then
            cmddelete.Visible = True
        Else
            cmddelete.Visible = False
        End If

        If RadioGroup1.SelectedIndex = 0 Then
            filterbyname()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            filterAll()
        End If
        DockPanel2.MinimumSize = New Size(990, 182)
        DockPanel2.MaximumSize = New Size(990, 182)
        FormatGrid()
        ViewGridtype(GridView1)
        loadDefaultSelection()
    End Sub

    Public Sub loadDefaultSelection()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblaccounts where accountid='" & globaluserid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                RadioGroup1.SelectedIndex = .Rows(cnt)("filteroption")
                areacode.Text = .Rows(cnt)("areacode").ToString
                txtArea.EditValue = .Rows(cnt)("areacode").ToString
                muncode.Text = .Rows(cnt)("muncode").ToString
                txtMunicipal.EditValue = .Rows(cnt)("muncode").ToString
                vilcode.Text = .Rows(cnt)("brgycode").ToString
                txtVillage.EditValue = .Rows(cnt)("brgycode").ToString
            End With
        Next
    End Sub

    Public Sub loadArea()
        If globalFullAccess = True Then
            LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        Else
            LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea where areacode='" & globalAccessAreacode & "' order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        End If
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtArea.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtArea.Properties.View.GetFocusedRowCellValue("Code").ToString()
        loadMunicipal()

    End Sub

    Public Sub loadMunicipal()
        If globalFullAccess = True Then
            LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        Else
            LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' and muncode='" & globalAccessMuncode & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        End If
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
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

    End Sub

    Public Sub filterbyname()
        If txtFilterName.Text = "" Then Exit Sub
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select areacode,colorcode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', comelecid as 'Comelec ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address, " _
                                    + If(ckShowLeaderName.Checked = True, " (select leadername from tblleaders where votersid = tblvoters.leaderid) as 'Leader Name', ", "") _
                                    + " contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',tblvoters.sector,',?')) end as 'Sectors' , " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader,case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID', Deceased, " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch' " _
                                    + " from tblvoters where " _
                                    + " (Fullname like '" & txtFilterName.Text & "%' or votersid = '" & rchar(txtFilterName.Text) & "') " & If(ckLeaderOnly.Checked = True, " and isleader=1 ", "") & If(ckWithContactNumber.Checked = True, " and (contactnumber is not null and contactnumber<>'') ", "") & If(globalFullAccess = True, "", " and areacode='" & globalAccessAreacode & "' and muncode='" & globalAccessMuncode & "' ") & "  order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("No.").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Voters ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit
        GridView1.Columns("Sectors").Width = 300
        GridView1.Columns("Sectors").ColumnEdit = MemoEdit


        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & RadioGroup1.SelectedIndex.ToString & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Text & RadioGroup1.SelectedIndex.ToString)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub filterAdvance()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select areacode,colorcode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID',comelecid as 'Comelec ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address, " _
                                    + If(ckShowLeaderName.Checked = True, " (select leadername from tblleaders where votersid = tblvoters.leaderid) as 'Leader Name', ", "") _
                                    + " contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + If(ckShowLeaderName.Checked = True, " (select leadername from tblleaders where votersid = tblvoters.leaderid) as 'Leader Name', ", "") _
                                    + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',tblvoters.sector,',?')) end as 'Sectors' , " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader,case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID',Deceased, " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch' " _
                                    + " from tblvoters where " _
                                    + " areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode like '%" & vilcode.Text & "' " & If(ckLeaderOnly.Checked = True, " and isleader=1 ", "") & If(ckWithContactNumber.Checked = True, " and (contactnumber is not null and contactnumber<>'') ", "") & "  order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False

        XgridColAlign("Voters ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit


        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & RadioGroup1.SelectedIndex.ToString & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Text & RadioGroup1.SelectedIndex.ToString)

        SplashScreenManager.CloseForm()
    End Sub

    Public Sub filterAll()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select areacode,colorcode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID',comelecid as 'Comelec ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address, " _
                                    + If(ckShowLeaderName.Checked = True, " (select leadername from tblleaders where votersid = tblvoters.leaderid) as 'Leader Name', ", "") _
                                    + " contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + If(ckShowLeaderName.Checked = True, " (select leadername from tblleaders where votersid = tblvoters.leaderid) as 'Leader Name', ", "") _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader,case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID',Deceased, " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch' " _
                                    + " from tblvoters where votersid is not null " & If(ckLeaderOnly.Checked = True, " and isleader=1 ", "") & If(ckWithContactNumber.Checked = True, " and (contactnumber is not null and contactnumber<>'') ", "") & If(globalFullAccess = True, "", " and areacode='" & globalAccessAreacode & "' and muncode='" & globalAccessMuncode & "' ") & " order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("Area/District").Group()
        GridView1.Columns("No.").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False

        XgridColAlign("Voters ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit


        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & RadioGroup1.SelectedIndex.ToString & "' and gridview='" & GridView1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            GridView1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                GridView1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
        SaveFilterColumn(GridView1, Me.Text & RadioGroup1.SelectedIndex.ToString)

        SplashScreenManager.CloseForm()
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name & RadioGroup1.SelectedIndex.ToString, GridView1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name & RadioGroup1.SelectedIndex.ToString, GridView1)
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim isleader As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("isleader"))
        Dim leaderid As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("leaderid"))
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Color"))
            e.Appearance.BackColor = Color.FromName(colorname)
            e.Appearance.ForeColor = Color.FromName(colorname)
        End If
        If e.Column.FieldName <> "Color" Then
            If ckLeaderOnly.Checked = False Then
                If isleader = "1" Then
                    If globaldefaultleaderbackcolor <> "" Then
                        e.Appearance.BackColor = Color.FromName(globaldefaultleaderbackcolor)
                        e.Appearance.ForeColor = Color.Black
                    Else
                        e.Appearance.BackColor = Color.LemonChiffon
                        e.Appearance.ForeColor = Color.Black
                    End If

                ElseIf leaderid <> "0" Then
                    If globaldefaultforecolormember <> "" Then
                        e.Appearance.ForeColor = Color.FromName(globaldefaultforecolormember)
                    End If
                End If
            End If
        End If
        FormatGrid()
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
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmEntryInfo.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If RadioGroup1.SelectedIndex = 0 Then
            filterbyname()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            filterAll()
        End If
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub MakeLeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLeader.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("Multiple selection for assigning leader is not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf CBool(GridView1.GetFocusedRowCellValue("Deceased")) = True Then
            XtraMessageBox.Show("Deceased member not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        ElseIf GridView1.GetFocusedRowCellValue("leaderid").ToString <> "0" Then
            If XtraMessageBox.Show("This voters currently assigned to a leader!" & Environment.NewLine & Environment.NewLine & "Leader Name: " & qrysingledata1("leadername", "leadername", "tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("leaderid").ToString & "'") & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue this voters to make leader?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                Exit Sub
            End If
        End If
        If CBool(GridView1.GetFocusedRowCellValue("isleader")) = True Then
            If XtraMessageBox.Show(GridView1.GetFocusedRowCellValue("Voter's") & " currently assigned as a leader! Do you want to view leader information?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                frmLeaderInformation.id.Text = qrysingledata1("leadersid", "leadersid", "tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'")
                frmLeaderInformation.txtLeaders.Text = GridView1.GetFocusedRowCellValue("Voter's").ToString
                frmLeaderInformation.Show(Me)
            End If
        Else
            com.CommandText = "update tblvoters set leaderid='0' where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "REMOVED FROM A LEADER")

            com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & GridView1.GetFocusedRowCellValue("leaderid").ToString & "';" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")

            Dim getid As String = createTRNID("L") & "-" & globaluserid
            com.CommandText = "DELETE FROM tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "REMOVE FROM LEADER LIST")

            com.CommandText = "insert into tblleaders (leadersid,votersid,comelecid,leadername,birthdate,areacode,muncode,vilcode,precinct,dateentry,entryby,remarks,isedited,editedby,colorcode) " _
                                                      + " select '" & getid & "', votersid,comelecid,fullname,bdate,areacode,muncode,vilcode,precinct,current_timestamp," & globaluserid & ",remarks,1," & globaluserid & ",'" & globaldefcolorleader & "' from tblvoters where " _
                                                      + " votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED TO A LEADER LIST")

            com.CommandText = "update tblvoters set isleader=1,colorcode='" & globaldefcolorleader & "', isedited=1,editedby='" & globaluserid & "' where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE VOTER AS A LEADER AND COLOR CHANGED")

            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Color", qrysingledata("colorname", "colorname", "where colorcode='" & globaldefcolorleader & "'", "tblcolor"))
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "isleader", "1")

            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            frmLeaderInformation.id.Text = qrysingledata1("leadersid", "leadersid", "tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'")
            frmLeaderInformation.txtLeaders.Text = GridView1.GetFocusedRowCellValue("Voter's").ToString
            frmLeaderInformation.Show(Me)
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub ChangeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ' If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        frmColorChange.mode.Text = "voters"
        frmColorChange.Show()
        ' End If
    End Sub
    Public Function ChangeColor(ByVal color As String, ByVal colorname As String)
        Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")

            'same color cannot change
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "colorcode").ToString <> color Then
                com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED ON VOTERS LIST")
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Color", colorname)
            End If

            If CBool(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "isleader")) = True Then
                com.CommandText = "update tblleaders set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED ON LEADERS LIST")

                If globalautocolorleadersmember = True Then
                    If countqry("tblvoters", "leaderid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'") > 0 Then
                        com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where leaderid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "CHANGE MEMBER COLOR")
                    End If
                End If
            End If

            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Return 0
    End Function

    Public Function ChangeColorKey(ByVal keycode As String)
        Dim color As String = "" : Dim colorname As String = ""
        com.CommandText = "select * from tblcolor where shortcut='" & keycode & "'" : rst = com.ExecuteReader
        While rst.Read
            color = rst("colorcode").ToString
            colorname = rst("colorname").ToString
        End While
        rst.Close()
        If colorname <> "" Then
            Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
            ReDim Rows(GridView1.SelectedRowsCount - 1)
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")

                com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED ON VOTERS LIST")
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Color", colorname)

                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Else
            XtraMessageBox.Show("Shortcut key not found!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return 0
    End Function

    Public Function ChangeSector(ByVal sectorcode As String, ByVal sectorname As String)
        Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
            com.CommandText = "update tblvoters set sector='" & sectorcode & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE VOTER SECTOR")

            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Sectors", sectorname)
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Return 0
    End Function
    Private Sub EditSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtFilterName.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select fullname from tblvoters where (fullname like '" & txtFilterName.Text & "%' or votersid = '" & rchar(txtFilterName.Text) & "')  order by fullname asc limit 100"
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst("fullname"))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        End If
        Return Coll
    End Function

    'Private Sub txtSearch_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilterName.EditValueChanged
    '    ComboBoxFilter(txtFilterName.Text, True)
    'End Sub

    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtFilterName.Text = "" Or txtFilterName.Text = "%" Then Exit Sub
            If countqry("tblvoters", "(fullname= '" & txtFilterName.Text & "' or votersid = '" & rchar(txtFilterName.Text) & "')") = 0 Then
                ComboBoxFilter(txtFilterName.Text, True)
                txtFilterName.ShowPopup()
                Exit Sub
            Else
                filterbyname()
            End If
        End If
    End Sub
    'Private Sub txtFilterName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilterName.KeyDown
    '    If e.KeyData = Keys.Enter Then
    '        If txtFilterName.Text = "" Or txtFilterName.Text = "%" Then Exit Sub
    '        If countqry("tblvoters", "fullname= '" & txtFilterName.Text & "'") = 0 Then
    '            ComboBoxFilter(txtFilterName.Text, True)
    '            txtFilterName.ShowPopup()
    '            Exit Sub
    '        Else
    '            filterbyname()
    '        End If
    '    End If
    'End Sub


    Private Sub DeleteEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If GridView1.SelectedRowsCount - 1 > 1 Then
            XtraMessageBox.Show("Multi select not allowed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim getid As String = createTRNID("D") & "-" & globaluserid
            com.CommandText = "insert into tblvotersdeleted (votersid,precinct,votersno,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,colorcode,leaderid,status,dateentry,entryby,remarks,isleader,isedited,editedby) " _
                              + " select votersid,precinct,votersno,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,colorcode,leaderid,status,dateentry,entryby,remarks,isleader,isedited," & globaluserid & " from tblvoters where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED TO DELETED VOTER TABLE")

            com.CommandText = "delete from tblvoters where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "VOTER DELETED")

            GridView1.DeleteSelectedRows()
        End If

    End Sub

    Private Sub TagSectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagSectorToolStripMenuItem.Click
        Dim selected As String = ""
        For I = 0 To GridView1.SelectedRowsCount - 1
            If selected = "" Then
                selected = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Sectors")
            End If
            If selected <> GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Sectors") Then
                XtraMessageBox.Show("There are selected voters with difference sector! and cannot be proceed. Please select individual to continue", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If
        ' If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        frmTagSector.txtSectors.Text = selected
        frmTagSector.Show()
        ' End If
    End Sub

    Private Sub checkGridFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkGridFormat.CheckedChanged
        FormatGrid()
    End Sub
    Public Sub FormatGrid()
        If checkGridFormat.Checked = True Then
            GridView1.RowHeight = 15
            GridView1.ColumnPanelRowHeight = 24
            GridView1.BorderStyle = BorderStyles.NoBorder
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsBehavior.[ReadOnly] = True

            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowIndicator = False
            'GridView1.OptionsView.EnableAppearanceEvenRow = True
            'GridView1.OptionsView.EnableAppearanceOddRow = True
            GridView1.OptionsView.ShowHorzLines = True
            GridView1.OptionsView.ShowVertLines = False
            GridView1.OptionsView.ShowViewCaption = False
        Else
            GridView1.PaintStyleName = "Default"
        End If

    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
            txtVillage.Enabled = False
            CheckEdit1.Enabled = False
            txtFilterName.Enabled = True

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            txtArea.Enabled = True
            txtMunicipal.Enabled = True
            txtVillage.Enabled = True
            CheckEdit1.Enabled = True
            txtFilterName.Enabled = False


        ElseIf RadioGroup1.SelectedIndex = 2 Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
            txtVillage.Enabled = False
            CheckEdit1.Enabled = False
            txtFilterName.Enabled = False
        End If
    End Sub

    Private Sub cmdFilter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        If RadioGroup1.SelectedIndex = 0 Then
            If txtFilterName.Text = "" Then
                XtraMessageBox.Show("Please enter voters name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFilterName.Focus()
                Exit Sub
            End If
            filterbyname()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                Exit Sub
            ElseIf txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            ElseIf txtVillage.Text = "" And CheckEdit1.Checked = False Then
                XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            Dim cntall As Integer = countrecord("tblvoters" & If(globalFullAccess = True, "", " where areacode='" & globalAccessAreacode & "' and muncode='" & globalAccessMuncode & "' "))
            If cntall > 20000 Then
                If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & Format(cntall, "N0"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    filterAll()
                End If
            Else
                filterAll()
            End If
        End If
        SaveDefaultOption(RadioGroup1.SelectedIndex, areacode.Text, muncode.Text, vilcode.Text)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtVillage.Enabled = False
            txtVillage.Properties.DataSource = Nothing
            txtVillage.Text = ""
            vilcode.Text = ""
            loadVillage()
        Else
            txtVillage.Enabled = True
        End If
    End Sub

    Private Sub DisplaySequenceNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplaySequenceNoToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmUpdateVotersListing.txtTotalSelected.Text = GridView1.SelectedRowsCount - 1
        If frmUpdateVotersListing.Visible = True Then
            frmUpdateVotersListing.Focus()
        Else
            frmUpdateVotersListing.Show(Me)
        End If
    End Sub

    Private Sub AddToGroupSMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToGroupSMSToolStripMenuItem.Click
        Dim selected As String = ""
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Contact Number") = "" Then
                XtraMessageBox.Show(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voter's") & " has no contact number and cannot be add to a group", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                selected = selected + GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Contact Number") + ":" + GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voter's") + "|"
            End If
        Next
        If selected <> "" Then
            selected = selected.Remove(selected.Length - 1, 1)
            frmSMSAddToGroup.AddtoList(selected)
            frmSMSAddToGroup.Show(Me)
        End If
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        cmdEdit.PerformClick()
    End Sub



    Private Sub SendMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendMessageToolStripMenuItem.Click
        Dim selected As String
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Contact Number") = "" Then
                XtraMessageBox.Show(GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voter's") & " has no contact number and cannot be add to sms", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                selected = selected + GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Contact Number") + ","
            End If
        Next
        If selected <> "" Then
            selected = selected.Remove(selected.Length - 1, 1)
            frmSMSNewMessage.txtCellular.Text = selected
            frmSMSNewMessage.Show(Me)
        End If
    End Sub
    Private Sub PrintIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintIDToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.SelectedRowsCount > 1 And globalmultipleidprint = False Then
            XtraMessageBox.Show("Multiple print not allowed to activate please go to setting and check Mutiple print ID", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmIDCategory.mode.Text = "voters"
        frmIDCategory.Show(Me)
    End Sub
    Public Function PrintID(ByVal category As String, ByVal filename As String, ByVal customid As Boolean, ByVal frontview As Boolean)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        If GridView1.SelectedRowsCount > 1 Then
            Dim selected As String = ""
            For I = 0 To GridView1.SelectedRowsCount - 1
                selected += "votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID").ToString & "' or "

                com.CommandText = "update tblvoters set idprint=1 where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "PERFORMED ID PRINT FOR VOTERS")
                com.CommandText = "update tblleaders set idprint=1 where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "PERFORMED ID PRINT FOR LEADERS")
                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Issued ID", "YES")
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1

            msda = Nothing : dsreport = New DataSet
            msda = New MySqlDataAdapter("select * from tblvoters where (" & selected.Remove(selected.Length - 3, 3) & ")", conn)
            msda.Fill(dsreport, 0)

            int_report = 2 'chạy cái subreport
            strTitle = category
            strFilename = filename
            If customid = True Then
                strPrintFront = frontview
                Dim f As New frmCustomReportDesigner
                f.Show()
            Else
                Dim f As New frmReportDesigner
                f.Show()
            End If
        Else
            int_report = 1 'chạy report đơn
            strTitle = category
            strFilename = filename
            strMaNV = GridView1.GetFocusedRowCellValue("Voters ID").ToString
            If customid = True Then
                strPrintFront = frontview
                Dim f As New frmCustomReportDesigner
                f.Show()
            Else
                Dim f As New frmReportDesigner
                f.Show()
            End If
        End If

        Return 0
    End Function

    Private Sub TransferLeaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferLeaderToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("isleader")) = True Then
            XtraMessageBox.Show("Only member can assign to a leader", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("leaderid").ToString <> "0" Then
            If XtraMessageBox.Show("This voters currently assigned to a leader!" & Environment.NewLine & Environment.NewLine & "Leader Name: " & qrysingledata1("leadername", "leadername", "tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("leaderid").ToString & "'") & Environment.NewLine & Environment.NewLine & "Are you sure you want to transfer this voters to another leader?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Else
                Exit Sub
            End If
        End If
        com.CommandText = "select * from tblvoters where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID").ToString & "'" : rst = com.ExecuteReader
        While rst.Read
            frmTransferVoters.oldLeaderId.Text = rst("leaderid").ToString
            frmTransferVoters.areacode.Text = rst("areacode").ToString
            frmTransferVoters.muncode.Text = rst("muncode").ToString
            frmTransferVoters.vilcode.Text = rst("vilcode").ToString
        End While
        rst.Close()
        frmTransferVoters.mode.Text = "voters"
        frmTransferVoters.Show()
    End Sub

    Public Function VotersTransfer(ByVal newleader As String, ByVal oldleader As String, ByVal newcolorcode As String)
        Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        For I = 0 To GridView1.SelectedRowsCount - 1
            Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
            com.CommandText = "update tblvoters set leaderid='" & newleader & "',isedited=1,editedby='" & globaluserid & "',colorcode='" & newcolorcode & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "VOTER TRANSFERED TO NEW LEADER")
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Color", qrysingledata1("colorname", "colorname", "tblcolor where colorcode='" & newcolorcode & "'"))
        Next
        com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & oldleader & "';" : com.ExecuteNonQuery()
        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")

        com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & newleader & "';" : com.ExecuteNonQuery()
        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")
        Return 0
    End Function

    Private Sub RemoveFromLeaderListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFromLeaderListToolStripMenuItem.Click
        If CBool(GridView1.GetFocusedRowCellValue("isleader")) = False Then
            XtraMessageBox.Show("Only leader can remove from leader list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim totalmember As Integer = qrysingledata1("totalmember", "totalmember", "tblleaders where votersid='" & GridView1.GetFocusedRowCellValue("Voters ID").ToString & "'")
        If XtraMessageBox.Show("Are you sure you want to permanently remove this leader from leader list? " & Environment.NewLine & Environment.NewLine & "NOTE: This leader contains total of " & totalmember & " Members", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
            ReDim Rows(GridView1.SelectedRowsCount - 1)
            For I = 0 To GridView1.SelectedRowsCount - 1
                Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
                com.CommandText = "update tblvoters set isleader=0 where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVED FROM LEADER LIST")

                com.CommandText = "delete from tblleaders where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "DELETED")

                If qrysingledata("colorcode", "colorcode", "where votersid='" & toUpdate & "'", "tblvoters") <> globaldefcolor Then
                    If XtraMessageBox.Show("Leader " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Leaders Name") & "'S currently tagged color as " & qrysingledata("description", "description", "where votersid='" & toUpdate & "'", "tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode") & "!, do you want to change by default color as " & globaldefcolordesc & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED DUE TO REMOVING LEADER")

                        If totalmember > 0 Then
                            com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "' where leaderid='" & toUpdate & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "VOTERS COLOR CHANGED AS DEFAULT DUE TO REMOVING LEADER")

                            com.CommandText = "update tblvoters set leaderid='0' where leaderid='" & toUpdate & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "ASSIGNED VOTER AS NO LEADER DUE TO REMOVING LEADER")
                        End If
                    End If
                End If

                cmdFilter.PerformClick()
                XtraMessageBox.Show("Leader successfully removed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        End If
    End Sub

    Public Function UpdateVotersListingNo(ByVal beginNo As Integer)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        For I = 0 To GridView1.SelectedRowsCount - 1
            com.CommandText = "update tblvoters set votersno='" & beginNo & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE SEQUENCE NO")
            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "No.", beginNo)
            beginNo += 1
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Return 0
    End Function


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ReadFilterColumn(GridView1, Me.Text & RadioGroup1.SelectedIndex.ToString)
    End Sub
End Class