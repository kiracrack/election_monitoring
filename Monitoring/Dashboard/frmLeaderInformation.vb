Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraReports.UI

Public Class frmLeaderInformation
    Public BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.F1) Then
            cmdAdd.PerformClick()

        ElseIf keyData = Keys.Control + Keys.C Then
            If selectedColorCode = "" Then
                If XtraMessageBox.Show("Default color currently not selected! Do you want to select color? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmColorChange.Show()
                End If
            End If
            ChangeColor(selectedColorCode, selectedColorname)
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAssignLeader_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If My.Application.OpenForms Is frmLeaders Then
            If frmLeaders.GridView1.GetFocusedRowCellValue("Voters ID").ToString() = votersid.Text Then
                frmLeaders.GridView1.SetRowCellValue(frmLeaders.GridView1.FocusedRowHandle, "Total Voters", GridView1.RowCount)
            Else
                frmLeaders.GridView1.SetRowCellValue(frmLeaders.GridView1.FocusedRowHandle, "Total Voters", countqry("tblvoters", "leaderid='" & leaderoldid.Text & "'"))
            End If
            ClearFields()
        End If
    End Sub

    Private Sub frmAssignLeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        filter()
        ViewGridtype(GridView1)

    End Sub

    Public Sub viewinfo()
        If id.Text = "" Then Exit Sub
        Dim leader As String = "" : Dim area As String = "" : Dim municipal As String = "" : Dim village As String = ""
        Try
            com.CommandText = "select *,(select fullname from tblvoters where votersid = tblleaders.votersid) as 'leader', " _
                                    + " (select areaname from tblarea where areacode = tblleaders.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblleaders.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblleaders.vilcode) as 'village' " _
                                    + " from tblleaders where leadersid='" & id.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                votersid.Text = rst("votersid").ToString
                leader = rst("leader").ToString
                areacode.Text = rst("areacode").ToString
                area = rst("area").ToString
                muncode.Text = rst("muncode").ToString
                municipal = rst("municipal").ToString
                vilcode.Text = rst("vilcode").ToString
                village = rst("village").ToString
                txtprecintno.Text = rst("precinct").ToString
                leadercolor.Text = rst("colorcode").ToString
            End While
            rst.Close()

            txtLeaders.Text = leader
            txtArea.Text = area
            txtMunicipal.Text = municipal
            txtVillage.Text = village

            filter()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub filter()
        dst.EnforceConstraints = False
        dst.Relations.Clear() : Em.LevelTree.Nodes.Clear()
        dst.Clear()
        LoadXgrid("select votersid as 'Voters ID','' as 'No.', cast(votersid as char(50)) as subleaderid, Fullname as 'Group Member', precinct as 'Precinct No.', votersno as 'Listing No.', if(Cluster=0,'NONE',cluster) as 'Cluster', " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'colorcode', " _
                                    + " '' as 'Color' " _
                                    + "  from tblvoters where leaderid='" & votersid.Text & "' and subleaderid='0' " _
                                    + " order by fullname asc", "tblvoters", Em, GridView1, Me)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblvoters")

        GridView1.Columns("Voters ID").Visible = False
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("subleaderid").Visible = False
        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Listing No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Group Member").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Group Member").SummaryItem.DisplayFormat = "Total Assigned {0}"
        GridView1.Columns("Group Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Group Member").View, GridView).OptionsView.ShowFooter = True

        com.CommandText = "DROP Temporary table if exists tmpsubmember;" : com.ExecuteNonQuery()
        com.CommandText = "create Temporary table tmpsubmember select * from tblvoters as b where leaderid='" & votersid.Text & "' " : com.ExecuteNonQuery()
        msda = New MySqlDataAdapter("select subleaderid, Fullname as 'Household Member', precinct as 'Precinct No.', votersno as 'Listing No.', if(Cluster=0,'NONE',cluster) as 'Cluster' " _
                                    + "   from tmpsubmember  where leaderid='" & votersid.Text & "' order by fullname asc", conn)
        msda.Fill(dst, "tmpsubmember")

        BandgridView = New GridView(Em)

        Dim keyColumn As DataColumn = dst.Tables("tblvoters").Columns("subleaderid")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tmpsubmember").Columns("subleaderid")

        dst.Relations.Add("HouseholdMember", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("HouseholdMember", BandgridView)

        Em.DataSource = dst.Tables("tblvoters")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tmpsubmember"))
        BandgridView.BestFitColumns()
        BandgridView.OptionsView.ColumnAutoWidth = False
        BandgridView.OptionsView.RowAutoHeight = False
        BandgridView.OptionsCustomization.AllowGroup = False
        BandgridView.OptionsView.ShowGroupPanel = False
        BandgridView.OptionsBehavior.Editable = False


        'BandgridView.Columns("colorcode").Visible = False
        BandgridView.Columns("subleaderid").Visible = False

        GridView1.Columns("Precinct No.").Width = 70
        'XgridColAlign("No.", BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Listing No.", BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", BandgridView, DevExpress.Utils.HorzAlignment.Center)
        BandgridView.BestFitColumns()
       
        NoSequence()
    End Sub
    Public Sub NoSequence()
        Dim cnt As Integer = 1
        For I = 0 To GridView1.DataRowCount - 1
            GridView1.SetRowCellValue(I, "No.", cnt & ".")
            cnt = cnt + 1
        Next I
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
      
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorcode"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
 
  
    Public Sub ClearFields()
        txtLeaders.Text = ""
        txtArea.Text = ""
        txtMunicipal.Text = ""
        txtVillage.Text = ""
        txtprecintno.Text = ""
        votersid.Text = ""
        areacode.Text = ""
        muncode.Text = ""
        vilcode.Text = ""
        id.Text = ""
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub MakeLeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeLeaderToolStripMenuItem.Click
        Try
            If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
                ReDim Rows(GridView1.SelectedRowsCount - 1)
                For I = 0 To GridView1.SelectedRowsCount - 1
                    Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                    toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
                    com.CommandText = "update tblvoters set leaderid='0' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "REMOVED FROM LEADER LIST")
                    If qrysingledata("colorcode", "colorcode", "where votersid='" & toUpdate & "'", "tblvoters") <> globaldefcolor Then
                        If XtraMessageBox.Show("Voter's " & qrysingledata("fullname", "fullname", "where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'", "tblvoters") & "'S currently tagged color as " & qrysingledata("description", "description", "where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'", "tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode") & "!, do you want to change by default color as " & globaldefcolordesc & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                            com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED DUE TO REMOVING FROM LEADER LIST")
                        End If
                    End If
                Next
                com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & votersid.Text & "';" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")
                For Each Row In Rows
                    Row.Delete()
                Next
                filter()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeLeader.ItemClick
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select leader!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmChangeLeader.id.Text = id.Text
        frmChangeLeader.txtcurrentLeader.Text = txtLeaders.Text

        frmChangeLeader.currentid.Text = votersid.Text
        frmChangeLeader.areacode.Text = areacode.Text
        frmChangeLeader.muncode.Text = muncode.Text
        frmChangeLeader.vilcode.Text = vilcode.Text

        frmChangeLeader.txtArea.Text = txtArea.Text
        frmChangeLeader.txtMunicipal.Text = txtMunicipal.Text
        frmChangeLeader.txtVillage.Text = txtVillage.Text
        frmChangeLeader.txtprecintno.Text = txtprecintno.Text
        leaderoldid.Text = votersid.Text
        frmChangeLeader.Show()
    End Sub
    Private Sub TransferLeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferLeaderToolStripMenuItem.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select leader!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        frmTransferVoters.oldLeaderId.Text = votersid.Text
        frmTransferVoters.areacode.Text = areacode.Text
        frmTransferVoters.muncode.Text = muncode.Text
        frmTransferVoters.vilcode.Text = vilcode.Text
        frmTransferVoters.Show()
    End Sub

    Private Sub id_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.EditValueChanged
        viewinfo()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ClearFields()
        filter()
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        GenerateLeaderList()
    End Sub

    Public Sub GenerateLeaderList()
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\leader_report.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblleaders where votersid='" & votersid.Text & "' order by leadername asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                PageHeader = "" : TableHeader = "" : TableRow = "" : TableFooter = "" : pageFooter = ""
                PageHeader = " <p><strong>" & compname & "</strong></br> " _
                            + "  " & compadd & "</p>" _
                            + " <h3>" & txtArea.Text & "</h3> "

                PageHeader += " <p align='left'>Group Leader: " & .Rows(cnt)("leadername").ToString() & "</br> " _
                            + "  Municipality: " & txtMunicipal.Text & "<span style='float: Right'>Date: " & Now() & "</span></br> " _
                            + " Barangay: " & txtVillage.Text & "<span style='float: Right'>Total Member: " & .Rows(cnt)("totalmember").ToString() & "</span></p>"

                TableHeader = " <table border='1'> " _
                           + "  <tr> " _
                           + "       <th align='Center'>No.</th>" _
                           + "       <th align='left'>Name</th>" _
                           + "       <th align='center'>Precinct</th>" _
                           + "       <th align='center'>Listing No.</th>" _
                           + "       <th align='center'>Cluster</th>" _
                           + "       <th align='center'>Birth Date</th>" _
                           + "       <th>Signature</th>" _
                           + "  </tr> "
                Dim nt As Integer = 1

                dst2 = New DataSet
                msda2 = New MySqlDataAdapter("select * from tblvoters where leaderid='" & .Rows(cnt)("votersid").ToString() & "'  and subleaderid='0' order by fullname asc", conn)
                msda2.Fill(dst2, 0)
                For mtc = 0 To dst2.Tables(0).Rows.Count - 1
                    With (dst2.Tables(0))
                        Dim bold As String = "<tr >" : Dim subleader As Boolean = False
                        If countqry("tblvoters", "subleaderid='" & .Rows(mtc)("votersid").ToString & "' and subleaderid<>'0'") > 0 Then
                            subleader = True
                            bold = "<tr style='font-weight:bold'>"
                        End If
                        TableRow += bold & " " _
                                 + " <td align='center'>" & nt & "</td> " _
                                 + " <td align='left'>" & .Rows(mtc)("fullname").ToString & "</td> " _
                                 + " <td align='center'>" & .Rows(mtc)("precinct").ToString & "</td> " _
                                 + " <td align='center'>" & .Rows(mtc)("votersno").ToString & "</td> " _
                                 + " <td align='center'>" & StrConv(.Rows(mtc)("cluster").ToString, vbProperCase) & "</td> " _
                                 + " <td align='center'>" & .Rows(mtc)("bdate").ToString & "</td> " _
                                 + " <td align='right'>            </td> " _
                           + " </tr> " & Chr(13)
                        If subleader = True Then
                            com.CommandText = "select * from tblvoters where subleaderid='" & .Rows(mtc)("votersid").ToString & "' order by fullname asc" : rst = com.ExecuteReader
                            While rst.Read
                                TableRow += "<tr > " _
                                                + " <td align='center'> </td> " _
                                                + " <td align='left'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; - " & rst("fullname").ToString & "</td> " _
                                                + " <td align='center'>" & rst("precinct").ToString & "</td> " _
                                                + " <td align='center'>" & rst("votersno").ToString & "</td> " _
                                                + " <td align='center'>" & StrConv(rst("cluster").ToString, vbProperCase) & "</td> " _
                                                + " <td align='center'>" & rst("bdate").ToString & "</td> " _
                                                + " <td align='right'>            </td> " _
                                          + " </tr> " & Chr(13)
                            End While
                            rst.Close()
                        End If

                        nt = nt + 1
                    End With
                Next
               
                TableFooter = "</table>"
                pageFooter = "<footer></footer>"

                If TableRow <> "" Then
                    FinalReport += PageHeader + TableHeader + TableRow + TableFooter + pageFooter
                End If
            End With
        Next

                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", FinalReport), False)
                PrintLXReceipt(SaveLocation.Replace("\", "/"), Me)
    End Sub


    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd.ItemClick
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select leader!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmAddtoLeaderList.votersid.Text = votersid.Text
        frmAddtoLeaderList.areacode.Text = areacode.Text
        frmAddtoLeaderList.muncode.Text = muncode.Text
        frmAddtoLeaderList.vilcode.Text = vilcode.Text
        frmAddtoLeaderList.txtprecinctno.Text = txtprecintno.Text
        frmAddtoLeaderList.colorcode.Text = leadercolor.Text
        frmAddtoLeaderList.Show()
        frmAddtoLeaderList.WindowState = FormWindowState.Normal
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
            com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED")

            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "colorcode", colorname)
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Return 0
    End Function

    Private Sub ChangeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmColorChange.mode.Text = "leaderinfo"
        frmColorChange.Show()
    End Sub
    Public Function VotersTransfer(ByVal newleader As String, ByVal colorcode As String)
        Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        For I = 0 To GridView1.SelectedRowsCount - 1
            Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
            com.CommandText = "update tblvoters set leaderid='" & newleader & "',colorcode='" & colorcode & "', isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "VOTER TRANSFERED TO NEW LEADER")
        Next
        com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & votersid.Text & "';" : com.ExecuteNonQuery()
        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")

        com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & newleader & "';" : com.ExecuteNonQuery()
        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")
        filter()
        Return 0
    End Function

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'GenerateCoupon("select *,password(sha(votersid)) as hashcode,md5(votersid) as hashmd5, " _
        '                            + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipality', " _
        '                            + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay' from tblvoters where leaderid='" & votersid.Text & "' or votersid='" & votersid.Text & "'", Me)
    End Sub

    
   
    Private Sub AddHouseholdMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddHouseholdMemberToolStripMenuItem.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select leader!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmAddtoSubLeaderList.votersid.Text = votersid.Text
        frmAddtoSubLeaderList.subleaderid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmAddtoSubLeaderList.areacode.Text = areacode.Text
        frmAddtoSubLeaderList.muncode.Text = muncode.Text
        frmAddtoSubLeaderList.vilcode.Text = vilcode.Text
        frmAddtoSubLeaderList.txtprecinctno.Text = txtprecintno.Text
        frmAddtoSubLeaderList.colorcode.Text = leadercolor.Text
        frmAddtoSubLeaderList.Show()
        frmAddtoSubLeaderList.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ViewListMemberListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewListMemberListToolStripMenuItem.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select leader!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmSubMemberInfo.leaderid.Text = votersid.Text
        frmSubMemberInfo.subleaderid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmSubMemberInfo.areacode.Text = areacode.Text
        frmSubMemberInfo.muncode.Text = muncode.Text
        frmSubMemberInfo.vilcode.Text = vilcode.Text
        frmSubMemberInfo.txtprecintno.Text = txtprecintno.Text
        frmSubMemberInfo.colorcode.Text = leadercolor.Text
        frmSubMemberInfo.Show()
        frmSubMemberInfo.WindowState = FormWindowState.Normal
    End Sub
End Class