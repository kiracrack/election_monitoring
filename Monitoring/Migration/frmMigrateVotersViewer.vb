Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls

Public Class frmMigrateVotersViewer
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.W Then
            Me.Close()
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
        loadMunicipal()
        ViewGridtype(GridView1)

        If RadioGroup1.SelectedIndex = 0 Then
            filterByName()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAll()
        End If
        DockPanel2.MinimumSize = New Size(990, 182)
        DockPanel2.MaximumSize = New Size(990, 182)
        FormatGrid()
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT distinct((select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode)) as 'Select List', databasename  from settings.tblmigratehistory order by (select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode) asc ", "settings.tblmigratehistory", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("databasename", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("databasename").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        databasename.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("databasename").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadVillage()
    End Sub

    Public Sub loadVillage()
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from " & databasename.Text & ".tblvillage order by villname asc ", "" & databasename.Text & ".tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub

    Public Sub filterbyname()
        If txtFilterName.Text = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        LoadXgrid("select id,areacode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.', Fullname as 'Voter''s',Address, bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from " & databasename.Text & ".tblarea where areacode = " & databasename.Text & ".tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from " & databasename.Text & ".tblmunicipality where muncode=" & databasename.Text & ".tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from " & databasename.Text & ".tblvillage where villcode=" & databasename.Text & ".tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " (select colorname from " & databasename.Text & ".tblcolor where colorcode = " & databasename.Text & ".tblvoters.colorcode) as 'Color',isleader " _
                                    + " from " & databasename.Text & ".tblvoters where " _
                                    + " Fullname like '%" & txtFilterName.Text & "%' order by fullname asc", "" & databasename.Text & ".tblvoters", Em, GridView1, Me)

        GridView1.Columns("id").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        ' GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit


        If checkDetailed.Checked = True Then
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = True
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = True
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = True
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = True
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = True
        Else
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = False
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = False
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = False
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = False
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = False
        End If

        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub filterAdvance()
        Me.Cursor = Cursors.WaitCursor
        LoadXgrid("select id,areacode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.', Fullname as 'Voter''s',Address, bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from " & databasename.Text & ".tblarea where areacode = " & databasename.Text & ".tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from " & databasename.Text & ".tblmunicipality where muncode=" & databasename.Text & ".tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from " & databasename.Text & ".tblvillage where villcode=" & databasename.Text & ".tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " (select colorname from " & databasename.Text & ".tblcolor where colorcode = " & databasename.Text & ".tblvoters.colorcode) as 'Color',isleader " _
                                    + " from " & databasename.Text & ".tblvoters where " _
                                    + " vilcode like '%" & vilcode.Text & "'  order by fullname asc", "" & databasename.Text & ".tblvoters", Em, GridView1, Me)

        GridView1.Columns("id").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        ' GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit

        If checkDetailed.Checked = True Then
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = True
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = True
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = True
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = True
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = True
        Else
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = False
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = False
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = False
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = False
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = False
        End If

        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        Me.Cursor = Cursors.Default
    End Sub
    Public Sub filterAll()
        Me.Cursor = Cursors.WaitCursor
        LoadXgrid("select id,areacode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.', Fullname as 'Voter''s',Address, bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from " & databasename.text & ".tblarea where areacode = " & databasename.text & ".tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from " & databasename.text & ".tblmunicipality where muncode=" & databasename.text & ".tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from " & databasename.text & ".tblvillage where villcode=" & databasename.text & ".tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " (select colorname from " & databasename.text & ".tblcolor where colorcode = " & databasename.text & ".tblvoters.colorcode) as 'Color',isleader " _
                                    + " from " & databasename.text & ".tblvoters order by fullname asc", "" & databasename.text & ".tblvoters", Em, GridView1, Me)

        GridView1.Columns("id").Visible = False
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        ' GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit

        If checkDetailed.Checked = True Then
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = True
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = True
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = True
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = True
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = True
        Else
            GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = False
            GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = False
            'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = False
            'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = False
            'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = False
        End If

        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        Dim isleader As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("isleader"))
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Color"))
            e.Appearance.BackColor = Color.FromName(colorname)
            e.Appearance.ForeColor = Color.FromName(colorname)
        End If
        If e.Column.FieldName <> "Color" Then
            If isleader = "1" Then
                e.Appearance.BackColor = Color.LemonChiffon
                e.Appearance.ForeColor = Color.Black
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


    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtFilterName.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select fullname from " & databasename.text & ".tblvoters where fullname like '%" & txtFilterName.Text & "%' order by fullname asc limit 20"
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

    Private Sub txtSearch_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilterName.EditValueChanged
        If txtMunicipal.Text = "" Then Exit Sub
        ComboBoxFilter(txtFilterName.Text, True)
    End Sub

    Private Sub txtFilterName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFilterName.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select Municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            End If
            filterbyname()
            DockPanel2.HideSliding()
        End If
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
            txtVillage.Enabled = False
            txtFilterName.Enabled = True

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            txtVillage.Enabled = True
            txtFilterName.Enabled = False


        ElseIf RadioGroup1.SelectedIndex = 2 Then
            txtVillage.Enabled = False
            txtFilterName.Enabled = False

        End If
    End Sub

    Private Sub cmdFilter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        If txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select Municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        End If
        If RadioGroup1.SelectedIndex = 0 Then
            If txtFilterName.Text = "" Then
                XtraMessageBox.Show("Please enter voters name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFilterName.Focus()
                Exit Sub
            End If
            filterbyname()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            If txtVillage.Text = "" Then
                XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            filterAdvance()
        ElseIf RadioGroup1.SelectedIndex = 2 Then
        Dim cntall As Integer = countrecord("" & databasename.Text & ".tblvoters")
        If cntall > 20000 Then
            If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & Format(cntall, "N0"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                filterAll()
            End If
        Else
            filterAll()
        End If
        End If
    End Sub


End Class