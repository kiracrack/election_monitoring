Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmGeneralSummary
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmGeneralSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        loadArea()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
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

    End Sub
    Public Sub FilterSummary()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        Dim strColor As String = ""
        txtnoVoters.Text = Format(Val(countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and deceased=0")), "N0")
        txtNoLeaders.Text = Format(Val(countqry("tblleaders", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'")), "N0")
        txtassignLeader.Text = Format(Val(countqry("tblvoters", "leaderid<>'0' and areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and deceased=0")), "N0")
        txtunassignleader.Text = Format(Val(countqry("tblvoters", "leaderid='0' and areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and deceased=0")), "N0")
        LoadXgrid("SELECT (select description from tblcolor where colorcode= tblvoters.colorcode) as Category ,concat(FORMAT(CAST(count(*) AS CHAR(20)),0), ' Voters') as Total FROM `tblvoters` where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and deceased=0 group by colorcode;", "tblvoters", Em, GridView1, Me)
        GridView1.Columns("Category").Width = 300
        LoadXgrid("select sectorname as 'Sector Description', concat(FORMAT(CAST(count(*) AS CHAR(20)),0), ' Voters') as Total from tblvoters inner join tblsector on " _
                    + " tblsector.sectorcode REGEXP concat(',?',tblvoters.sector,',?') where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and sector<>'' and deceased=0 group by sectorname;", "tblvoters", Bm, GridView2, Me)
        GridView2.Columns("Sector Description").Width = 300

        LoadXgrid("select (select villname from tblvillage where villcode = tblvoters.vilcode) as 'Barangay', " _
                        + " concat('Cluster ', cluster) as 'Clusters', (select concat(CAST(count(distinct(a.precinct)) AS CHAR(20)),' Precincts') from tblvoters as a where a.cluster = tblvoters.cluster and a.vilcode = tblvoters.vilcode ) as 'Precincts', " _
                        + " count(*) as 'Total Voters' from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and cluster<>0 and deceased=0 group by vilcode,cluster;", "tblvoters", Cm, gridcluster, Me)
        gridcluster.Columns("Barangay").Group()
        gridcluster.ExpandAllGroups()
        gridcluster.Columns("Total Voters").Width = 120
        XgridColNumber("Total Voters", gridcluster)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select Municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        End If
        FilterSummary()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        printreport()
    End Sub
    Public Sub printreport()
        Dim report As New rptGeneralSummary()
        report.txtArea.Text = txtArea.Text
        report.txtmunicipal.Text = txtMunicipal.Text
        report.txtnovoters.Text = txtnoVoters.Text & " Voters"
        report.txtnoleaders.Text = txtNoLeaders.Text & " Voters"

        report.txtassigned.Text = txtassignLeader.Text & " Voters"
        report.txtunassigned.Text = txtunassignleader.Text & " Voters"
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.Bands(BandKind.ReportFooter).Controls.Add(CopyGridControl1(Me.Bm))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        printreportCluster()
    End Sub

    Public Sub printreportCluster()
        Dim report As New rptGeneralSummary()
        report.txtArea.Text = txtArea.Text
        report.txtmunicipal.Text = txtMunicipal.Text
        report.txtnovoters.Text = txtnoVoters.Text & " Voters"
        report.txtnoleaders.Text = txtNoLeaders.Text & " Voters"

        report.txtassigned.Text = txtassignLeader.Text & " Voters"
        report.txtunassigned.Text = txtunassignleader.Text & " Voters"
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Cm))
        report.ShowRibbonPreviewDialog()
    End Sub
End Class