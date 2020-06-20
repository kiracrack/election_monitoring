Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.Data
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen

Public Class frmSectorListing
    Private strgeneralqry As String = ""
    Private startqry As Boolean = False
    Private strCheckedCode As String = ""
    Private strCheckedName As String = ""
    Private strSectorqry As String = ""
    Private selectedSectorCode As String = ""
    Private selectedSectorName As String = ""

    Private Sub frmStatusResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startqry = True
        loadArea()
        LoadSector()
    End Sub

    Private Sub cmdFilterQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilterQuery.Click
        Dim strarea = "" : Dim strMunicipal = "" : Dim strVillage = "" : strCheckedCode = "" : strgeneralqry = ""
        If ckArea.Checked = False Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                Exit Sub
            End If
            strarea = " where areacode='" & areacode.Text & "' "
        Else
            strarea = ""
            txtArea.Properties.DataSource = Nothing
            txtArea.Text = ""
            loadArea()
        End If

        If ckMunicipal.Checked = False Then
            If txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            End If
            If strarea = "" Then
                strMunicipal = " where muncode='" & muncode.Text & "'"
            Else
                strMunicipal = " and muncode='" & muncode.Text & "'"
            End If

        Else
            strMunicipal = ""
            txtMunicipal.Properties.DataSource = Nothing
            txtMunicipal.Text = ""
            loadMunicipal()
        End If

        If ckVillage.Checked = False Then
            If txtVillage.Text = "" Then
                XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            If strarea = "" And strMunicipal = "" Then
                strVillage = " where vilcode='" & vilcode.Text & "'"
            Else
                strVillage = " and vilcode='" & vilcode.Text & "'"
            End If
        Else
            strVillage = ""
            txtVillage.Properties.DataSource = Nothing
            txtVillage.Text = ""
            loadVillage()
        End If

        If ls.CheckedItems.Count = 0 Then
            XtraMessageBox.Show("There is no selected Sector!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ls.Focus()
            Exit Sub
        End If
        For n = 0 To ls.CheckedItems.Count - 1
            strCheckedCode = strCheckedCode + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "|"
            strCheckedName = strCheckedName + ls.Items.Item(ls.CheckedItems.Item(n)).Description + ", "
        Next

        strgeneralqry = strarea & strMunicipal & strVillage
        selectedSectorCode = strCheckedCode.Remove(strCheckedCode.Length - 1, 1)
        selectedSectorName = strCheckedName.Remove(strCheckedName.Length - 2, 2)

        If strgeneralqry = "" Then
            strSectorqry = " where sector REGEXP ',?" & selectedSectorCode & ",?' and deceased=0"
        Else
            strSectorqry = " and sector REGEXP ',?" & selectedSectorCode & ",?' and deceased=0"
        End If

        If ckWebVersion.Checked = True Then
            GenerateLeaderList()
        Else
            StatusPreview()
        End If

    End Sub

    Public Sub GenerateLeaderList()
        Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\color_code_listing.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = countqry("tblvoters", strgeneralqry.ToString.Replace("where", "") & strSectorqry) + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        dst = New DataSet
        msda = New MySqlDataAdapter("select *, (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                                 + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                                 + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'brgy' from tblvoters " _
                                 + strgeneralqry & strSectorqry & "  group by areacode,muncode,vilcode order by fullname asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                PageHeader = "" : TableHeader = "" : TableRow = "" : TableFooter = "" : pageFooter = ""
                PageHeader = " <p><strong>" & compname & "</strong></br> " _
                            + "  " & compadd & "</p>" _
                            + " <h3>" & .Rows(cnt)("area").ToString() & "</h3> "

                PageHeader += " <p align='left'>Municipality: " & .Rows(cnt)("municipal").ToString() & "<span style='float: Right'>Date: " & Now() & "</span></br> " _
                            + " Barangay: " & .Rows(cnt)("brgy").ToString() & "</span></br> " _
                            + " Selected Sector: " & selectedSectorName & "</p>"

                TableHeader = " <table border='1'> " _
                           + "  <tr> " _
                           + "       <th align='Center'>No.</th>" _
                           + "       <th align='left'>Name</th>" _
                           + "       <th align='left'>Leader's Name</th>" _
                           + "       <th align='center'>Precinct</th>" _
                           + "       <th align='center'>Cluster</th>" _
                           + "       <th align='center'>Birth Date</th>" _
                           + "       <th width='130'>Signature</th>" _
                           + "  </tr> "
                Dim nt As Integer = 1
                com.CommandText = "select *,(select leadername from tblleaders where votersid =tblvoters.leaderid) as 'leader' from tblvoters where areacode='" & .Rows(cnt)("areacode").ToString() & "' and muncode='" & .Rows(cnt)("muncode").ToString() & "'  and vilcode='" & .Rows(cnt)("vilcode").ToString() & "' " & strSectorqry & " order by fullname asc" : rst = com.ExecuteReader
                While rst.Read
                    TableRow += "<tr > " _
                                   + " <td align='center'>" & nt & "</td> " _
                                   + " <td align='left'>" & rst("fullname").ToString & "</td> " _
                                   + " <td align='left'>" & rst("leader").ToString & "</td> " _
                                   + " <td align='center'>" & rst("precinct").ToString & "</td> " _
                                   + " <td align='center'>" & StrConv(rst("cluster").ToString, vbProperCase) & "</td> " _
                                   + " <td align='center'>" & rst("bdate").ToString & "</td> " _
                                   + " <td align='right'>                       </td> " _
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

    Public Sub LoadSector()
        Dim combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        com.CommandText = "select * from tblsector"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("sectorcode"), False)
            ls.Items.Item(rst("sectorcode")).Description = rst("sectorname").ToString
            ls.Items.Item(rst("sectorcode")).Value = rst("sectorcode").ToString
        End While
        rst.Close()
    End Sub
     
    Public Sub StatusPreview()
        Dim cntall As Integer = countqry("tblvoters", strgeneralqry.Replace("where", "") & strSectorqry.Replace("where", ""))
        If cntall > 10000 Then
            If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & Format(cntall, "N0"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Else
                Exit Sub
            End If
        End If

        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select '' as 'No.',(select colorname from tblcolor where colorcode = tblvoters.colorcode)  as colorcode, votersid as 'Voters ID', comelecid as 'Comelec ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address,contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',tblvoters.sector,',?')) end as 'Sectors' , " _
                                    + " case when idprint=0 then 'NO ID' else 'YES' end as 'Issued ID',  " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch', " _
                                    + " '' as 'Color' " _
                                    + " " & If(ckImagePreview.Checked = True, ",(select imgprofile from filedir.tblvotersimage where votersid = tblvoters.votersid) as 'Image' ", "") & " from tblvoters " _
                                    + strgeneralqry & strSectorqry & " order by fullname asc", "tblvoters", Em, GridView1, Me)


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
        ' GridView1.Columns("Address").ColumnEdit = MemoEdit
        GridView1.Columns("Sectors").Width = 300
        GridView1.Columns("Sectors").ColumnEdit = MemoEdit

        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
        SplashScreenManager.CloseForm()
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

    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        txtArea.Properties.DataSource = Nothing
        txtArea.Text = ""
        areacode.Text = ""
        loadArea()
        ckArea.Checked = True

        txtMunicipal.Properties.DataSource = Nothing
        txtMunicipal.Text = ""
        muncode.Text = ""
        loadMunicipal()
        ckMunicipal.Checked = True

        txtVillage.Properties.DataSource = Nothing
        txtVillage.Text = ""
        vilcode.Text = ""
        loadVillage()
        ckVillage.Checked = True
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    StatusPreview()
    'End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        printreport()
    End Sub
    Public Sub printreport()
        Dim report As New rptOtherReport()
        report.txttitle.Text = Me.Text
        
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        NoSequence(GridView1, Me)
    End Sub


    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("votersid").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("votersid").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        cmdFilterQuery.PerformClick()
    End Sub
End Class