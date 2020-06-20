Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmClusteredListing
    Private strgeneralqry As String = ""
    Private strColorQuery As String = ""
    Private startqry As Boolean = False
    Private strCheckedCode As String = ""
    Private strCheckedName As String = ""
    Private strClusterqry As String = ""
    Private selectedClusterCode As String = ""
    Private selectedClusterName As String = ""
    Private Sub frmStatusResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startqry = True
        loadArea()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim strarea = "" : Dim strMunicipal = "" : Dim strVillage = ""
        strCheckedCode = ""
        strCheckedName = ""
        strClusterqry = ""
        selectedClusterCode = ""
        selectedClusterName = ""

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

        End If
        If ls.CheckedItems.Count = 0 Then
            XtraMessageBox.Show("There is no selected Cluster!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ls.Focus()
            Exit Sub
        End If
        For n = 0 To ls.CheckedItems.Count - 1
            strCheckedCode = strCheckedCode + "cluster = " + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + " or "
            strCheckedName = strCheckedName + ls.Items.Item(ls.CheckedItems.Item(n)).Description + ", "
        Next

        strgeneralqry = strarea & strMunicipal & strVillage
        selectedSectorCode = strCheckedCode.Remove(strCheckedCode.Length - 3, 3)
        selectedClusterName = strCheckedName.Remove(strCheckedName.Length - 2, 2)
        StatusPreview()
    End Sub

    

    Public Sub StatusPreview()
        'Dim cntall As Integer = countqry("tblvoters", strgeneralqry.Replace("where", "") & strColorQuery.Replace("where", ""))
        'If cntall > 10000 Then
        '    If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & Format(cntall, "N0"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        '    Else
        '        Exit Sub
        '    End If
        'End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select '' as 'No.',(select colorname from tblcolor where colorcode = tblvoters.colorcode)  as colorcode, votersid as 'Voters ID', comelecid as 'Comelec ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address,contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',tblvoters.sector,',?')) end as 'Sectors' , " _
                                    + " case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID',  " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch', " _
                                    + "  concat('Cluster ', cluster) as 'Clusters','' as 'Color' from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and " _
                                    + " (" & selectedSectorCode & ") and deceased=0 order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("No.").Visible = False
        GridView1.Columns("colorcode").Visible = False
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
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
        SplashScreenManager.CloseForm()
        'GridView1.MoveLast()
        'ProgressBarControl1.PerformStep()
        'ProgressBarControl1.Update()
        'SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorcode"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Public Sub loadArea()
        If startqry = False Then Exit Sub
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
        If startqry = False Then Exit Sub
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
        If startqry = False Then Exit Sub
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadcluster()
    End Sub
    Public Sub loadcluster()
        com.CommandText = "select concat('CLUSTER ', clusterid) as cl,clusterid from tblcluster where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("cl"), False)
            ls.Items.Item(rst("cl")).Description = rst("cl").ToString
            ls.Items.Item(rst("cl")).Value = rst("clusterid").ToString
        End While
        rst.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        txtArea.Properties.DataSource = Nothing
        txtArea.Text = ""
        areacode.Text = ""
        loadArea()


        txtMunicipal.Properties.DataSource = Nothing
        txtMunicipal.Text = ""
        muncode.Text = ""
        loadMunicipal()


        txtVillage.Properties.DataSource = Nothing
        txtVillage.Text = ""
        vilcode.Text = ""
        loadVillage()

    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        printreport()
    End Sub
    Public Sub printreport()
        Dim report As New rptOtherReport()
        report.txttitle.Text = txtArea.Text & ": " & txtVillage.Text & ", " & txtMunicipal.Text
       
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        NoSequence(GridView1, Me)
    End Sub
End Class