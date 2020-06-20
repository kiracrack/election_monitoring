Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid
Imports DevExpress.XtraCharts

Public Class frmUserPerformance
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.Control + Keys.P Then
            printreport()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub printreport()
        Dim report As New rptOtherReport()
        report.txttitle.Text = Me.Text & " (" & txtDateFrom.Text & " - " & txtDateTo.Text & ")"
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub
    Private Sub frmUploadedLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtDateFrom.EditValue = Now
        txtDateTo.EditValue = Now
        TabPerformance()
    End Sub
    Public Sub TabPerformance()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterPerformnceSummary()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Em.Parent = XtraTabControl1.SelectedTabPage
            FilterPerformnceTeam()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            FilterPerformnceChart()
        End If
    End Sub
    Public Sub FilterPerformnceSummary()
        LoadXgrid("select (select fullname from tblaccounts where accountid = tblactionquerylogs.performedby) as 'User Account',concat(format(count(*),0), ' Total Encoded') as 'Performance'  from  `settings`.`tblactionquerylogs` where date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' group by performedby order by count(*) desc;", "settings.tblactionquerylogs", Em, GridView1, Me)
        GridView1.Columns("User Account").Width = 500
        GridView1.Columns("Performance").Width = 150
    End Sub

    Public Sub FilterPerformnceTeam()
        LoadXgrid("select Team,Fullname as 'User Account', count(*)  as 'Total Encoded'  from  `settings`.`tblactionquerylogs` INNER JOIN tblaccounts on tblactionquerylogs.performedby = tblaccounts.accountid where date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and team is not null and team<>'' group by performedby,team order by count(*) desc;", "settings.tblactionquerylogs", Em, GridView1, Me)
        GridView1.Columns("Team").Group()
        XgridColNumber("Total Encoded", GridView1)
        GridView1.ExpandAllGroups()
        GridView1.Columns("User Account").Width = 500
        GridView1.Columns("Total Encoded").Width = 150

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Total Encoded"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        item1.DisplayFormat = "{0:N0}"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Total Encoded")
        GridView1.GroupSummary.Clear()
        GridView1.GroupSummary.Add(item1)

        CType(GridView1.Columns("Total Encoded").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Public Sub FilterPerformnceChart()
        If countrecord("`settings`.`tblactionquerylogs` where date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "'") > 0 Then
            ' SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            ChartControl1.Series.Clear()
            com.CommandText = "select concat('Team ', Team) as 'teamresult', count(*)  as 'encoded'  from  `settings`.`tblactionquerylogs` INNER JOIN tblaccounts on tblactionquerylogs.performedby = tblaccounts.accountid where date_format(dateperformed,'%Y-%m-%d') between '" & ConvertDate(txtDateFrom.EditValue) & "' and '" & ConvertDate(txtDateTo.EditValue) & "' and team is not null and team<>'' group by team order by count(*) desc;" : rst = com.ExecuteReader
            While rst.Read
                Dim series1 As New Series(rst("teamresult").ToString, ViewType.Bar)
                series1.Points.Add(New SeriesPoint(rst("teamresult").ToString, rst("encoded")))
                'series1.Points(0).Annotations.AddTextAnnotation(rst("description").ToString, rst("description").ToString)
                ChartControl1.Series.Add(series1)
                ' ChartControl1.PaletteName = "Grayscale"
                ' ChartControl1.Series(rst("Team").ToString).View.Color = Color.FromName(rst("Team").ToString)
            End While
            rst.Close()
            '  SplashScreenManager.CloseForm()
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        TabPerformance()
    End Sub

    Private Sub cmdWord_Click(sender As Object, e As EventArgs) Handles cmdWord.Click
        TabPerformance()
    End Sub


    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TabPerformance()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ckRealtime.Checked = True Then
            TabPerformance()
        End If
    End Sub
End Class