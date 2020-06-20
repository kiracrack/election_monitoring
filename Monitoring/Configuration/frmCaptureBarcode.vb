Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmCaptureBarcode

    Private Sub frmCaptureBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        com.CommandText = "DROP TEMPORARY TABLE IF EXISTS `tblcollectorstublogs`;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE `tblcollectorstublogs` (  `votersid` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  PRIMARY KEY (`votersid`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()

        com.CommandText = "DROP TEMPORARY TABLE IF EXISTS `tblwatcherstublogs`;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE `tblwatcherstublogs` (  `votersid` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  PRIMARY KEY (`votersid`)) ENGINE = InnoDB;" : com.ExecuteNonQuery()

        LoadCollectors()
        LoadWatchers()

        LoadCollectorsCopy()
        LoadWatchersCopy()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is tabClaimedCopy Then
            LoadCollectorsCopy()
        Else
            LoadWatchersCopy()
        End If
    End Sub

#Region "CLIMANT COPY"
    Public Sub LoadCollectorsCopy()
        LoadXgrid("select (select fullname from tblvoters where votersid=tblcollectorstublogs.votersid) as 'Fullname',(select precinct from tblvoters where votersid=tblcollectorstublogs.votersid) as 'Precinct', " _
                  + " (select (select villname from tblvillage where villcode=tblvoters.vilcode) from tblvoters where votersid=tblcollectorstublogs.votersid) as 'Barangay', " _
                  + " (select (select munname from tblmunicipality where muncode=tblvoters.muncode) from tblvoters where votersid=tblcollectorstublogs.votersid) as 'Municipality' from tblcollectorstublogs ", "tblcollectorstublogs", Em, GridView1, Me)
        XgridColAlign("Precinct", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.MoveLast()
    End Sub

    Public Sub LoadCollectors()
        LoadXgridLookupSearch("SELECT accountid as 'Code', fullname as 'Select'  from tblaccounts order by fullname asc ", "tblaccounts", txtCollector, gridCollectors, Me)
        XgridColAlign("Code", gridCollectors, DevExpress.Utils.HorzAlignment.Center)
        gridCollectors.Columns("Code").Visible = False
    End Sub
    Private Sub txtCollector_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCollector.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtCollector.Properties.View.FocusedRowHandle.ToString)
        claimedid.Text = txtCollector.Properties.View.GetFocusedRowCellValue("Code").ToString()
        If claimedid.Text = "" Then
            txtCollectorsBarcode.Enabled = False
        Else
            txtCollectorsBarcode.Enabled = True
        End If
        txtCollectorsBarcode.Focus()
    End Sub

    Private Sub txtCollectorsBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCollectorsBarcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            txtCTitle.Visible = False
            If countqry("tblvoters", "votersid='" & txtCollectorsBarcode.Text & "'") = 0 Then
                picC_Status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_error
                txtC_recordNotFound.Visible = True
                txtC_votersname.Visible = False
                txtC_Status.Visible = False
                txtC_votersAddress.Visible = False
            Else
                txtC_recordNotFound.Visible = False
                picC_Status.Visible = True
                txtC_votersname.Visible = True
                txtC_Status.Visible = True
                txtC_votersAddress.Visible = True

                dst = New DataSet
                msda = New MySqlDataAdapter("select *,(select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal'," _
                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay', " _
                    + " (select fullname from tblaccounts where accountid=tblvoters.stubclaimedby) as 'claimedby' from tblvoters where votersid='" & txtCollectorsBarcode.Text & "'", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If CBool(.Rows(cnt)("stubclaimed")) = False Then
                            txtC_votersname.Text = .Rows(cnt)("fullname").ToString
                            txtC_votersAddress.Text = .Rows(cnt)("barangay").ToString & ", " & .Rows(cnt)("municipal").ToString
                            txtC_Status.Text = "Status: Claimed"

                            picC_Status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_yes
                            txtC_votersname.ForeColor = Color.Green
                            txtC_votersAddress.ForeColor = Color.Green
                            txtC_Status.ForeColor = Color.Green

                            com.CommandText = "insert into tblcollectorstublogs set votersid='" & .Rows(cnt)("votersid").ToString & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "SCANNED CLAIMED STUB")

                            com.CommandText = "update tblvoters set stubclaimed=1, stubclaimedby='" & claimedid.Text & "' where votersid='" & txtCollectorsBarcode.Text & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE CLAIMED STUB")

                            com.CommandText = "insert into tblstubclaimedcopy set votersid='" & .Rows(cnt)("votersid").ToString & "',claimedid='" & claimedid.Text & "',trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "RECORD CLAIMED STUB")

                            LoadCollectorsCopy()
                        Else
                            txtC_votersname.Text = .Rows(cnt)("fullname").ToString
                            txtC_votersAddress.Text = .Rows(cnt)("barangay").ToString & ", " & .Rows(cnt)("municipal").ToString
                            txtC_Status.Text = "Status: Claimed by " & .Rows(cnt)("claimedby").ToString

                            picC_Status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_close
                            txtC_votersname.ForeColor = Color.Red
                            txtC_votersAddress.ForeColor = Color.Red
                            txtC_Status.ForeColor = Color.Red
                        End If
                        BarCodeControl1.Text = txtCollectorsBarcode.Text
                    End With
                Next
            End If
            txtCollectorsBarcode.Focus()
            txtCollectorsBarcode.SelectAll()
        Else
            InputNumberOnly(txtCollectorsBarcode, e)
        End If
    End Sub
#End Region

#Region "WATCHERS COPY"
    Public Sub LoadWatchersCopy()
        LoadXgrid("select (select fullname from tblvoters where votersid=tblwatcherstublogs.votersid) as 'Fullname',(select precinct from tblvoters where votersid=tblwatcherstublogs.votersid) as 'Precinct', " _
                  + " (select (select villname from tblvillage where villcode=tblvoters.vilcode) from tblvoters where votersid=tblwatcherstublogs.votersid) as 'Barangay', " _
                  + " (select (select munname from tblmunicipality where muncode=tblvoters.muncode) from tblvoters where votersid=tblwatcherstublogs.votersid) as 'Municipality' from tblwatcherstublogs ", "tblwatcherstublogs", Em_watchers, gridWatchers, Me)
        XgridColAlign("Precinct", gridWatchers, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Barangay", gridWatchers, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipality", gridWatchers, DevExpress.Utils.HorzAlignment.Center)
        gridWatchers.MoveLast()
    End Sub

    Public Sub LoadWatchers()
        LoadXgridLookupSearch("SELECT accountid as 'Code', fullname as 'Select'  from tblaccounts order by fullname asc ", "tblaccounts", txtWatchers, gridWatchersName, Me)
        XgridColAlign("Code", gridWatchersName, DevExpress.Utils.HorzAlignment.Center)
        gridWatchersName.Columns("Code").Visible = False
    End Sub
    Private Sub txtWatchers_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWatchers.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtWatchers.Properties.View.FocusedRowHandle.ToString)
        watchersid.Text = txtWatchers.Properties.View.GetFocusedRowCellValue("Code").ToString()
        If watchersid.Text = "" Then
            txtWatchersBarcode.Enabled = False
        Else
            txtWatchersBarcode.Enabled = True
        End If
        txtWatchersBarcode.Focus()
    End Sub

    Private Sub txtWatchersBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWatchersBarcode.KeyPress
        If e.KeyChar() = Chr(13) Then
            txtw_title.Visible = False
            If countqry("tblvoters", "votersid='" & txtWatchersBarcode.Text & "'") = 0 Then
                picw_status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_error
                txtw_recordnotfound.Visible = True
                txtw_fullname.Visible = False
                txtw_status.Visible = False
                txtw_address.Visible = False
            Else
                txtw_recordnotfound.Visible = False
                picw_status.Visible = True
                txtw_fullname.Visible = True
                txtw_status.Visible = True
                txtw_address.Visible = True

                dst = New DataSet
                msda = New MySqlDataAdapter("select *,(select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal'," _
                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay', " _
                    + " (select fullname from tblaccounts where accountid=tblvoters.watchersclaimedby) as 'claimedby' from tblvoters where votersid='" & txtWatchersBarcode.Text & "'", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If CBool(.Rows(cnt)("watchersclaimed")) = False Then
                            txtw_fullname.Text = .Rows(cnt)("fullname").ToString
                            txtw_address.Text = .Rows(cnt)("barangay").ToString & ", " & .Rows(cnt)("municipal").ToString
                            txtw_status.Text = "Status: Verified"

                            picw_status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_yes
                            txtw_fullname.ForeColor = Color.Green
                            txtw_address.ForeColor = Color.Green
                            txtw_status.ForeColor = Color.Green

                            com.CommandText = "insert into tblwatcherstublogs set votersid='" & .Rows(cnt)("votersid").ToString & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "SCANNED WATCHERS STUB")

                            com.CommandText = "update tblvoters set watchersclaimed=1, watchersclaimedby='" & watchersid.Text & "' where votersid='" & txtWatchersBarcode.Text & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE WATCHERS STUB")

                            com.CommandText = "insert into tblstubwatcherscopy set votersid='" & .Rows(cnt)("votersid").ToString & "',watcherid='" & watchersid.Text & "',trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "RECORD WATCHERS STUB")

                            LoadWatchersCopy()
                        Else
                            txtw_fullname.Text = .Rows(cnt)("fullname").ToString
                            txtw_address.Text = .Rows(cnt)("barangay").ToString & ", " & .Rows(cnt)("municipal").ToString
                            txtw_status.Text = "Status: Watchers Verified by " & .Rows(cnt)("claimedby").ToString

                            picw_status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_close
                            txtw_fullname.ForeColor = Color.Red
                            txtw_address.ForeColor = Color.Red
                            txtw_status.ForeColor = Color.Red
                        End If
                        BarCodeControl1.Text = txtWatchersBarcode.Text
                    End With
                Next
            End If
            txtWatchersBarcode.Focus()
            txtWatchersBarcode.SelectAll()
        Else
            InputNumberOnly(txtWatchersBarcode, e)
        End If
    End Sub
#End Region


End Class