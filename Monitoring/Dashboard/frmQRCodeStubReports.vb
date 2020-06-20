Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.Utils
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmQRCodeStubReports
    Private sel As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmQRCodeStubReports_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadDatabaseReport()
        LoadStubsReport()
    End Sub
    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        LoadStubsReport()
        LoadClaimsCopy()
    End Sub

    Public Sub LoadStubsReport()
        Dim TotalClaim As Double = countqry("tblvoters", "stubclaimed=1")
        Dim TotalWacher As Double = countqry("tblvoters", "watchersclaimed=1")
        txtClaim.Text = FormatNumber(TotalClaim, 0)
        txtWatcher.Text = FormatNumber(TotalWacher, 0)
        txtDifference.Text = FormatNumber(TotalClaim - TotalWacher, 0)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        LoadStubsReport()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If frmCaptureBarcode.Visible = True Then
            frmCaptureBarcode.Focus()
        Else
            frmCaptureBarcode.Show(Me)
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        LoadDatabaseReport()
    End Sub

    Public Sub LoadDatabaseReport()
        If XtraTabControl1.SelectedTabPage Is tabClaimsCopy Then
            LoadClaimsCopy()
        ElseIf XtraTabControl1.SelectedTabPage Is tabWatchersCopy Then
            LoadWatchersCopy()
        ElseIf XtraTabControl1.SelectedTabPage Is tabUnComplete Then
            LoadUncomplete()
        ElseIf XtraTabControl1.SelectedTabPage Is tabCompleted Then
            LoadCompleted()
        End If
    End Sub
    Public Sub LoadClaimsCopy()
        LoadXgrid("select (select fullname from tblvoters where votersid=tblstubclaimedcopy.votersid) as 'Fullname', " _
                  + " (select precinct from tblvoters where votersid=tblstubclaimedcopy.votersid) as 'Precinct', " _
                  + " (select (select villname from tblvillage where villcode=tblvoters.vilcode) from tblvoters where votersid=tblstubclaimedcopy.votersid) as 'Barangay', " _
                  + " (select (select munname from tblmunicipality where muncode=tblvoters.muncode) from tblvoters where votersid=tblstubclaimedcopy.votersid) as 'Municipality', " _
                  + " (select fullname from tblaccounts where accountid=tblstubclaimedcopy.claimedid) as 'Claimant Incharge',date_format(datetrn,'%Y-%m-%d') as 'Date Verified', date_format(datetrn,'%r') as 'Time Verified', " _
                  + " (select fullname from tblaccounts where accountid=tblstubclaimedcopy.trnby) as 'Verified By' from tblstubclaimedcopy ", "tblstubclaimedcopy", Em, GridView1, Me)
        XgridColAlign("Precinct", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Date Verified", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Time Verified", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Claimant Incharge", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Verified By", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("Fullname").Summary.Clear()
        GridView1.Columns("Fullname").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Fullname", "Total Voters {0:n0}")
        CType(GridView1.Columns("Fullname").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Public Sub LoadWatchersCopy()
        LoadXgrid("select (select fullname from tblvoters where votersid=tblstubwatcherscopy.votersid) as 'Fullname', " _
                  + " (select precinct from tblvoters where votersid=tblstubwatcherscopy.votersid) as 'Precinct', " _
                  + " (select (select villname from tblvillage where villcode=tblvoters.vilcode) from tblvoters where votersid=tblstubwatcherscopy.votersid) as 'Barangay', " _
                  + " (select (select munname from tblmunicipality where muncode=tblvoters.muncode) from tblvoters where votersid=tblstubwatcherscopy.votersid) as 'Municipality', " _
                  + " (select fullname from tblaccounts where accountid=tblstubwatcherscopy.watcherid) as 'Watcher Incharge',date_format(datetrn,'%Y-%m-%d') as 'Date Verified', date_format(datetrn,'%r') as 'Time Verified', " _
                  + " (select fullname from tblaccounts where accountid=tblstubwatcherscopy.trnby) as 'Verified By' from tblstubwatcherscopy ", "tblstubwatcherscopy", Em_watcher, gridWatcher, Me)
        XgridColAlign("Precinct", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Date Verified", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Time Verified", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Watcher Incharge", gridWatcher, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Verified By", gridWatcher, DevExpress.Utils.HorzAlignment.Center)

        gridWatcher.Columns("Fullname").Summary.Clear()
        gridWatcher.Columns("Fullname").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Fullname", "Total Voters {0:n0}")
        CType(gridWatcher.Columns("Fullname").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Public Sub LoadUncomplete()
        LoadXgrid("select Fullname, Precinct, " _
                  + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Barangay', " _
                  + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipality', " _
                  + " if(stubclaimed=1,'YES','') as 'Claim Verified', if(watchersclaimed=1,'YES','') as 'Watcher Verified' from tblvoters where (stubclaimed=1 and watchersclaimed=0) or  (stubclaimed=0 and watchersclaimed=1) ", "tblvoters", Em_Uncomplete, grid_uncomplete, Me)
        XgridColAlign("Precinct", grid_uncomplete, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", grid_uncomplete, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", grid_uncomplete, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Claim Verified", grid_uncomplete, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Watcher Verified", grid_uncomplete, DevExpress.Utils.HorzAlignment.Center)

        grid_uncomplete.Columns("Fullname").Summary.Clear()
        grid_uncomplete.Columns("Fullname").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Fullname", "Total Voters {0:n0}")
        CType(grid_uncomplete.Columns("Fullname").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Public Sub LoadCompleted()
        LoadXgrid("select Fullname, Precinct, " _
                  + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Barangay', " _
                  + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipality', " _
                  + " if(stubclaimed=1,'YES','') as 'Claim Verified', if(watchersclaimed=1,'YES','') as 'Watcher Verified' from tblvoters where stubclaimed=1 and watchersclaimed=1", "tblvoters", Em_Completed, grid_completed, Me)
        XgridColAlign("Precinct", grid_completed, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", grid_completed, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", grid_completed, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Claim Verified", grid_completed, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Watcher Verified", grid_completed, DevExpress.Utils.HorzAlignment.Center)

        grid_completed.Columns("Fullname").Summary.Clear()
        grid_completed.Columns("Fullname").Summary.Add(DevExpress.Data.SummaryItemType.Count, "Fullname", "Total Voters {0:n0}")
        CType(grid_completed.Columns("Fullname").View, GridView).OptionsView.ShowFooter = True
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadDatabaseReport()
    End Sub
End Class