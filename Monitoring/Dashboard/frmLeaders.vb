Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen
Imports System.IO

Public Class frmLeaders
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()

        ElseIf keyData = Keys.Control + Keys.C Then
            If selectedColorCode = "" Then
                If XtraMessageBox.Show("Default color currently not selected! Do you want to select color? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmColorChange.ShowDialog()
                Else
                    Return False
                End If
            End If
            ChangeColor(selectedColorCode, selectedColorname)
        
        ElseIf keyData = Keys.Control + Keys.E Then
            EditSelectedToolStripMenuItem.PerformClick()

        ElseIf keyData = Keys.Control + Keys.I Then
            AssignLeadersToolStripMenuItem.PerformClick()

        ElseIf keyData = Keys.Delete Then
            RemoveSelectedToolStripMenuItem.PerformClick()

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
        ClearGrid()
        loadArea()
        ViewGridtype(GridView1)

        If RadioGroup1.SelectedIndex = 0 Then
            filterByName()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            FilterAll()
        End If
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
    Public Sub ClearGrid()
        LoadXgrid("select '' as 'No.','' as 'leadersid', " _
                                    + " '' as 'Voters ID', " _
                                    + " '' as 'Precinct No.', " _
                                    + " '' as 'Leaders Name', " _
                                    + " '' as 'Birthdate', " _
                                    + " '' as 'Area/District', " _
                                    + " '' as 'Municipal/City', " _
                                    + " '' as 'Village/Barangay', " _
                                    + " '' as 'Total Member', " _
                                    + " '' as 'Color', " _
                                    + " '' as 'Last Touch' " _
                                    + " from tblleaders where votersid = ''", "tblleaders", Em, GridView1, Me)
        GridView1.Columns("No.").Visible = False
        GridView1.Columns("leadersid").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        XgridColAlign("Total Member", GridView1, HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Birthdate", GridView1, HorzAlignment.Center)
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Leaders Name").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Leaders Name").SummaryItem.DisplayFormat = "Total Leaders {0}"
        GridView1.Columns("Leaders Name").SummaryItem.Tag = 1
        CType(GridView1.Columns("Leaders Name").View, GridView).OptionsView.ShowFooter = True

        GridView1.Columns("Total Member").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Member").SummaryItem.DisplayFormat = "Total {0}"
        GridView1.Columns("Total Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Member").View, GridView).OptionsView.ShowFooter = True
        'GridView1.Columns("Total Member").Summary.View.AppearancePrint
        GridView1.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Near

    End Sub

    Public Sub filterByName()
        If txtFilterName.Text = "" Then Exit Sub
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select '' as 'No.',colorcode, tblleaders.leadersid,votersid as 'Voters ID',precinct as 'Precinct No.', " _
                                    + " leadername as 'Leaders Name', " _
                                    + " Birthdate, " _
                                    + " (select areaname from tblarea where areacode = tblleaders.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblleaders.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblleaders.vilcode) as 'Village/Barangay', " _
                                    + " totalmember as 'Total Member', " _
                                    + " (select colorname from tblcolor where colorcode = tblleaders.colorcode) as 'Color',case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID', " _
                                    + " (select fullname from tblaccounts where accountid=tblleaders.editedby) as 'Last Touch' " _
                                    + " " & If(ckPictureStatus.Checked = True, ",case when (select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid limit 1) Is Not null then 'YES' else 'NO PICTURE' end as 'Picture' ", "") _
                                    + " " & If(ckImagePreview.Checked = True, ",(select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid) as 'Image' ", "") _
                                    + " from tblleaders where leadername like '%" & txtFilterName.Text & "%'  or votersid = '" & rchar(txtFilterName.Text) & "' " & If(globalFullAccess = True, "", " and areacode='" & globalAccessAreacode & "' and muncode='" & globalAccessMuncode & "' ") & " order by leadername desc", "tblleaders", Em, GridView1, Me)
        GridView1.Columns("No.").Visible = False
        GridView1.Columns("leadersid").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        GridView1.Columns("colorcode").Visible = False

        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Birthdate", GridView1, HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Leaders Name").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Leaders Name").SummaryItem.DisplayFormat = "Total Leaders {0}"
        GridView1.Columns("Leaders Name").SummaryItem.Tag = 1
        CType(GridView1.Columns("Leaders Name").View, GridView).OptionsView.ShowFooter = True


        XgridColAlign("Total Member", GridView1, HorzAlignment.Center)
        GridView1.Columns("Total Member").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Member").SummaryItem.DisplayFormat = "Total {0}"
        GridView1.Columns("Total Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Member").View, GridView).OptionsView.ShowFooter = True
        GridView1.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Near
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Color"))
            e.Appearance.BackColor = Color.FromName(colorname)
            e.Appearance.ForeColor = Color.FromName(colorname)
        End If
    End Sub

    Public Sub filterAdvance()
        Dim strCount As String = ""
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select  '' as 'No.',colorcode,leadersid,votersid as 'Voters ID',precinct as 'Precinct No.', " _
                                    + " leadername as 'Leaders Name', " _
                                    + " Birthdate, " _
                                    + " (select areaname from tblarea where areacode = tblleaders.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblleaders.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblleaders.vilcode) as 'Village/Barangay', " _
                                    + " totalmember as 'Total Member', " _
                                    + " (select colorname from tblcolor where colorcode = tblleaders.colorcode) as 'Color',case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID', " _
                                    + " (select fullname from tblaccounts where accountid=tblleaders.editedby) as 'Last Touch' " _
                                    + " " & If(ckPictureStatus.Checked = True, ",case when (select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid limit 1) Is Not null then 'YES' else 'NO PICTURE' end as 'Picture' ", "") _
                                    + " " & If(ckImagePreview.Checked = True, ",(select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid) as 'Image' ", "") _
                                    + " from tblleaders where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode like '%" & vilcode.Text & "'  order by leadername asc", "tblleaders", Em, GridView1, Me)
        GridView1.Columns("No.").Visible = False
        GridView1.Columns("leadersid").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        GridView1.Columns("colorcode").Visible = False

        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Birthdate", GridView1, HorzAlignment.Center)
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Leaders Name").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Leaders Name").SummaryItem.DisplayFormat = "Total Leaders {0}"
        GridView1.Columns("Leaders Name").SummaryItem.Tag = 1
        CType(GridView1.Columns("Leaders Name").View, GridView).OptionsView.ShowFooter = True

        XgridColAlign("Total Member", GridView1, HorzAlignment.Center)
        GridView1.Columns("Total Member").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Member").SummaryItem.DisplayFormat = "Total {0}"
        GridView1.Columns("Total Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Member").View, GridView).OptionsView.ShowFooter = True
        GridView1.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Near
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub FilterAll()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select  '' as 'No.',colorcode,leadersid,votersid as 'Voters ID',precinct as 'Precinct No.', " _
                                    + " leadername  as 'Leaders Name', " _
                                    + " Birthdate, " _
                                    + " (select areaname from tblarea where areacode = tblleaders.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblleaders.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblleaders.vilcode) as 'Village/Barangay', " _
                                    + " totalmember as 'Total Member', " _
                                    + " (select colorname from tblcolor where colorcode = tblleaders.colorcode) as 'Color',case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID', " _
                                    + " (select fullname from tblaccounts where accountid=tblleaders.editedby) as 'Last Touch' " _
                                    + " " & If(ckPictureStatus.Checked = True, ",case when (select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid limit 1) Is Not null then 'YES' else 'NO PICTURE' end as 'Picture' ", "") _
                                    + " " & If(ckImagePreview.Checked = True, ",(select imgprofile from filedir.tblvotersimage where votersid = tblleaders.votersid) as 'Image' ", "") _
                                    + " " & If(globalFullAccess = True, "", " and areacode='" & globalAccessAreacode & "' and muncode='" & globalAccessMuncode & "' ") _
                                    + " from tblleaders order by leadername asc", "tblleaders", Em, GridView1, Me)
        GridView1.Columns("No.").Visible = False
        GridView1.Columns("leadersid").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        GridView1.Columns("colorcode").Visible = False

        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Birthdate", GridView1, HorzAlignment.Center)
        XgridColAlign("Issued ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Leaders Name").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Leaders Name").SummaryItem.DisplayFormat = "Total Leaders {0}"
        GridView1.Columns("Leaders Name").SummaryItem.Tag = 1
        CType(GridView1.Columns("Leaders Name").View, GridView).OptionsView.ShowFooter = True

        XgridColAlign("Total Member", GridView1, HorzAlignment.Center)
        GridView1.Columns("Total Member").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total Member").SummaryItem.DisplayFormat = "Total {0}"
        GridView1.Columns("Total Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total Member").View, GridView).OptionsView.ShowFooter = True
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub
    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()
        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString

        If RadioGroup1.SelectedIndex = 1 Then
            report.txttitle.Text = txttitle.Text & " - " & txtVillage.Text & ", " & txtMunicipal.Text
        Else
            report.txttitle.Text = txttitle.Text
        End If
        report.txttitle.Text = txttitle.Text

        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If RadioGroup1.SelectedIndex = 0 Then
            filterByName()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            FilterAll()
        End If
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
    End Sub

    Private Sub menuClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuClose.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNew.ItemClick
        frmLeadersInfo.Show()
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelectedToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove this item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
            ReDim Rows(GridView1.SelectedRowsCount - 1)
            For I = 0 To GridView1.SelectedRowsCount - 1
                Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
                com.CommandText = "update tblvoters set isleader=0 where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVED FROM LEADER LIST")

                If qrysingledata("colorcode", "colorcode", "where votersid='" & toUpdate & "'", "tblvoters") <> globaldefcolor Then
                    If XtraMessageBox.Show("Leader " & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Leaders Name") & "'S currently tagged color as " & qrysingledata("description", "description", "where votersid='" & toUpdate & "'", "tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode") & "!, do you want to change by default color as " & globaldefcolordesc & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                        com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED DUE TO REMOVING LEADER")

                        com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "' where leaderid='" & toUpdate & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "VOTERS COLOR CHANGED AS DEFAULT DUE TO REMOVING LEADER")
                    End If
                End If

                com.CommandText = "update tblvoters set leaderid='0' where leaderid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "ASSIGNED VOTER AS NO LEADER DUE TO REMOVING LEADER")
            Next
            DeleteRow("leadersid", "leadersid", "tblleaders", GridView1, Me)
        End If
    End Sub

    Private Sub AssignLeadersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignLeadersToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("Multiple select viewing leader information is not applicable. please select one leader only!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmLeaderInformation.id.Text = GridView1.GetFocusedRowCellValue("leadersid").ToString
        frmLeaderInformation.txtLeaders.Text = GridView1.GetFocusedRowCellValue("Leaders Name").ToString
        frmLeaderInformation.Show()
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

    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtFilterName.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select leadername from tblleaders where (leadername like '" & txtFilterName.Text & "%' or votersid = '" & rchar(txtFilterName.Text) & "') order by leadername asc limit 100"
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst("leadername"))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        End If
        Return Coll
    End Function

    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtFilterName.Text = "" Or txtFilterName.Text = "%" Then Exit Sub
            If countqry("tblleaders", "(leadername= '" & txtFilterName.Text & "' or votersid = '" & rchar(txtFilterName.Text) & "')") = 0 Then
                ComboBoxFilter(txtFilterName.Text, True)
                txtFilterName.ShowPopup()
                Exit Sub
            Else
                filterByName()
            End If
        End If
    End Sub



    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        If RadioGroup1.SelectedIndex = 0 Then
            If txtFilterName.Text = "" Then
                XtraMessageBox.Show("Please enter voters name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFilterName.Focus()
                Exit Sub
            End If
            filterByName()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                Exit Sub
            ElseIf txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            ElseIf txtVillage.Text = "" And CheckEdit2.Checked = False Then
                XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 2 Then
            If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                FilterAll()
            End If

        End If

    End Sub


    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
            txtVillage.Enabled = False
            txtFilterName.Enabled = True
            CheckEdit2.Enabled = False

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            txtArea.Enabled = True
            txtMunicipal.Enabled = True
            txtVillage.Enabled = True
            txtFilterName.Enabled = False
            CheckEdit2.Enabled = True


        ElseIf RadioGroup1.SelectedIndex = 2 Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
            txtVillage.Enabled = False
            txtFilterName.Enabled = False
            CheckEdit2.Enabled = False

        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
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
        NoSequence(GridView1, Me)
    End Sub

    Private Sub PrintIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintIDToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.SelectedRowsCount > 1 And globalmultipleidprint = False Then
            XtraMessageBox.Show("Multiple print not allowed to activate please go to setting and check Mutiple print ID", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmIDCategory.mode.Text = "leaders"
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


    Public Function PrintCustomID(ByVal category As String, ByVal filename As String)
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
            Dim f As New frmReportDesigner
            f.Show()
        Else
            int_report = 1 'chạy report đơn
            strTitle = category
            strFilename = filename
            strMaNV = GridView1.GetFocusedRowCellValue("Voters ID").ToString
            Dim f As New frmReportDesigner
            f.Show()
        End If

        Return 0
    End Function

    Private Sub ChangeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ' If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        frmColorChange.mode.Text = "leader"
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

            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "colorcode").ToString <> color Then
                com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED ON VOTERS LIST")

                com.CommandText = "update tblleaders set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED ON VOTERS LIST")

                GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "Color", colorname)
            End If

            If globalautocolorleadersmember = True Then
                If countqry("tblvoters", "leaderid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'") > 0 Then
                    com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where leaderid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "CHANGE MEMBER COLOR")
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

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        AssignLeadersToolStripMenuItem.PerformClick()
    End Sub

    Private Sub DeleteImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteImageToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue? NOTE: There is NO UNDO FOR THIS FUNCTION!", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
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

                com.CommandText = "delete from filedir.tblvotersimage where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVED LEADER IMAGE")

                com.CommandText = "update tblleaders set isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "RECORD LAST TOUCH ON REMOVING LEADER IMAGE")

                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
            RefreshToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GenerateLeaderList()
    End Sub
    Public Sub GenerateLeaderList()
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\leader_report.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\leader_" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = countqry("tblleaders", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & If(CheckEdit2.Checked = True, "", " and vilcode='" & vilcode.Text & "'") & " ") + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        dst = New DataSet
        msda = New MySqlDataAdapter("select *,(select villname from tblvillage where villcode=tblleaders.vilcode) as 'barangay' from tblleaders where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & If(CheckEdit2.Checked = True, "", " and vilcode='" & vilcode.Text & "'") & " group by vilcode", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                PageHeader = "" : TableHeader = "" : TableRow = "" : TableFooter = "" : pageFooter = ""
                PageHeader = " <p><strong>" & compname & "</strong></br> " _
                            + "  " & compadd & "</p>" _
                            + " <h3>LEADERS REPORT</h3> "

                PageHeader += " <p align='left'>Area: " & txtArea.Text & " <span style='float: Right'>Date: " & Now() & "</span></br> " _
                            + " Municipality: " & txtMunicipal.Text & "</br> " _
                            + " Barangay: " & .Rows(cnt)("barangay").ToString() & "</p>"

                TableHeader = " <table border='1'> " _
                           + "  <tr> " _
                           + "       <th align='Center'>No.</th>" _
                           + "       <th align='left'>Name</th>" _
                           + "       <th align='center'>Precinct</th>" _
                           + "       <th align='center'>Birth Date</th>" _
                           + "       <th align='center'>Total Members</th>" _
                           + "       <th>Signature</th>" _
                           + "  </tr> "
                Dim nt As Integer = 1
                com.CommandText = "select * from tblleaders where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & .Rows(cnt)("vilcode").ToString() & "' order by leadername asc" : rst = com.ExecuteReader
                While rst.Read
                    TableRow += "<tr > " _
                                   + " <td align='center'>" & nt & "</td> " _
                                   + " <td align='left'>" & rst("leadername").ToString & "</td> " _
                                   + " <td align='center'>" & rst("precinct").ToString & "</td> " _
                                   + " <td align='center'>" & rst("birthdate").ToString & "</td> " _
                                   + " <td align='center'>" & rst("totalmember").ToString & "</td> " _
                                   + " <td align='right'>            </td> " _
                             + " </tr> " & Chr(13)
                    nt = nt + 1
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                End While
                rst.Close()
                TableFooter = "</table>"
                pageFooter = "<footer></footer>"

                If TableRow <> "" Then
                    FinalReport += PageHeader + TableHeader + TableRow + TableFooter + pageFooter
                End If
            End With
        Next

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", FinalReport), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), Me)
    End Sub

     
End Class