Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.Utils
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmLeaderAssigned
    Private sel As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
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
        loadArea()
        sel = True
        ViewGridtype(GridView1)
        loadDefaultSelection()
    End Sub

    Public Sub loadDefaultSelection()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblaccounts where accountid='" & globaluserid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
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
        loadLeader()

    End Sub

    Public Sub loadLeader()
        If sel = False Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        LoadXgridLookupSearch("SELECT leadersid, votersid as 'Voters ID', leadername as 'Select List'  from tblleaders  where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' order by leadername asc ", "tblleaders", txtLeaders, gridLeader, Me)
        gridLeader.Columns("leadersid").Visible = False
        gridLeader.Columns("Voters ID").Visible = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtLeaders_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLeaders.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtLeaders.Properties.View.FocusedRowHandle.ToString)
        id.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("leadersid").ToString()
        votersid.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Voters ID").ToString()
        txtLeaders.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub
    Public Sub ClearGrid()
        LoadXgrid("select '' as 'Voters ID', '' as 'No.', '' as 'Precinct No.', '' as 'Cluster', '' as 'Voter''s', " _
                                       + " '' as Leader, " _
                                       + " '' as 'Area/District', " _
                                       + " '' as 'Municipal/City', " _
                                       + " '' as 'Village/Barangay', " _
                                       + " '' as 'colorcode', " _
                                       + " '' as 'Color', " _
                                       + " '' as 'Signature'," _
                                       + " '' as 'precinct_voters', " _
                                       + " '' as 'precinct_leaders' " _
                                       + " from tblleaders where votersid='0' ", "tblleaders", Em, GridView1, Me)
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("precinct_voters").Visible = False
        GridView1.Columns("precinct_leaders").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, HorzAlignment.Center)
        GridView1.Columns("No.").Width = 70
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Signature").Width = 180
        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Assigned {0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
    End Sub
    Public Sub filter()
        Dim qryLeader = ""
        If ckLeaders.Checked = True Then
            If countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid<>'0'") = 0 Then
                XtraMessageBox.Show("There is no item with selected query!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid<>'0'"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                ClearGrid()
                SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Maximum = countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid<>'0'") + 1
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid<>'0'", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        AddRowXgrid(GridView1)
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Voters ID", .Rows(cnt)("votersid").ToString())
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.", .Rows(cnt)("precinct").ToString())
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Cluster", .Rows(cnt)("cluster").ToString())
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Voter's", .Rows(cnt)("fullname").ToString())
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Leader", qrysingledata("leadername", "leadername", "where votersid='" & .Rows(cnt)("leaderid").ToString() & "'", "tblleaders"))
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Area/District", qrysingledata("areaname", "areaname", "where areacode='" & .Rows(cnt)("areacode").ToString() & "'", "tblarea"))
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Municipal/City", qrysingledata("munname", "munname", "where muncode='" & .Rows(cnt)("muncode").ToString() & "'", "tblmunicipality"))
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Village/Barangay", qrysingledata("villname", "villname", "where villcode='" & .Rows(cnt)("vilcode").ToString() & "'", "tblvillage"))
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "colorcode", qrysingledata("colorname", "colorname", "where colorcode='" & .Rows(cnt)("colorcode").ToString() & "'", "tblcolor"))
                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Color", qrysingledata("colorname", "colorname", "where colorcode='" & .Rows(cnt)("colorcode").ToString() & "'", "tblcolor"))
                    End With
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                Next
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
                SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
            End If

        Else
            If countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid='" & votersid.Text & "'") = 0 Then
                XtraMessageBox.Show("There is no item with selected query!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            LoadXgrid("select votersid as 'Voters ID', '' as 'No.', precinct as 'Precinct No.',Cluster, Fullname as 'Voter''s', " _
                                        + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                        + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                        + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                        + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'colorcode', " _
                                        + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color', '' as 'Signature' from  tblvoters where leaderid='" & votersid.Text & "' order by fullname asc", "tblvoters", Em, GridView1, Me)
            SplashScreenManager.CloseForm()
        End If
        GridView1.MoveLast()
        'GridView1.Columns("Leader").Group()
        GridView1.ExpandAllGroups()
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("Voters ID").Visible = False
        XgridColAlign("No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, HorzAlignment.Center)
        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Assigned Members {0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
        GridView1.BestFitColumns()
        GridView1.Columns("No.").Width = 70
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("Signature").Width = 180
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
            e.Appearance.ForeColor = Color.FromName(colorname)
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        rptsettings = ""
        filter()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub
    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text.Replace("'", "''") & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()

        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString
        report.txttitle.Text = txttitle.Text & If(txtLeaders.Text <> "", " (" & txtLeaders.Text & ")", "")
         
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayFormatToolStripMenuItem.Click
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
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
        ElseIf txtLeaders.Text = "" Then
            If ckLeaders.Checked = False Then
                XtraMessageBox.Show("Please select Leaders.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLeaders.Focus()
                Exit Sub
            End If
        End If
        SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
        filter()
    End Sub

    Private Sub ckLeaders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckLeaders.CheckedChanged
        If ckLeaders.Checked = True Then
            txtLeaders.Enabled = False
            SimpleButton3.Enabled = False
        Else
            txtLeaders.Enabled = True
            SimpleButton3.Enabled = True
        End If
    End Sub


    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select Leaders.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLeaders.Focus()
            Exit Sub
        End If
        frmLeaderInformation.txtLeaders.Text = txtLeaders.Text
        frmLeaderInformation.id.Text = id.Text
        frmLeaderInformation.Show()
    End Sub

    Private Sub txtPrecinctNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadLeader()
    End Sub

    Private Sub cmdPrintWebVersion_Click(sender As Object, e As EventArgs) Handles cmdPrintWebVersion.Click
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
        ElseIf txtLeaders.Text = "" Then
            If ckLeaders.Checked = False Then
                XtraMessageBox.Show("Please select Leaders.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtLeaders.Focus()
                Exit Sub
            End If
        End If
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
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = countqry("tblvoters", "areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and leaderid<>'0'") + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblleaders where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' " & If(ckLeaders.Checked = True, "", "and votersid='" & votersid.Text & "' ") & " order by leadername asc", conn)
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

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", FinalReport), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), Me)
    End Sub
 
End Class