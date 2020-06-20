Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen

Public Class frmReports_Work
     

    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text
        loadArea()
        LoadWorkCompany()
        txtDateWorkFrom.EditValue = Now
        txtDateWorkTo.EditValue = Now

        If RadioGroup1.SelectedIndex = 0 Then
            filterAdvance()
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            filterAll()
        End If
        DockPanel2.MinimumSize = New Size(990, 182)
        DockPanel2.MaximumSize = New Size(990, 182)

        txtArea.Enabled = True
        txtMunicipal.Enabled = True
        txtVillage.Enabled = True
        CheckEdit1.Enabled = True

        ViewGridtype(GridView1)
    End Sub
    Public Sub LoadWorkCompany()
        LoadToComboBox("companyname", "tblwork", txtCompany, True)
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
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub

    Public Sub filterAdvance()
        If txtQuery.Text = "" And txtCompany.Text <> "" Then
            MsgBox("No record found", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        LoadXgrid("select areacode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address,contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',tblvoters.sector,',?')) end as 'Sectors' , " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader,Deceased, " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch' " _
                                    + " from tblvoters where  deceased=0 and " _
                                    + " areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode like '%" & vilcode.Text & "' " & txtQuery.Text & "  order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        ' GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit


        GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = False
        GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = False
        'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = False
        'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = False
        'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = False

        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

    End Sub

    Public Sub filterAll()
        If txtQuery.Text = "" And txtCompany.Text <> "" Then
            MsgBox("No record found", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        LoadXgrid("select areacode,muncode,vilcode,leaderid, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',Address,contactnumber as 'Contact Number', bdate as 'Birth Date', Sex, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " vtype as 'V-Type'," _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader,Deceased, " _
                                    + " (select fullname from tblaccounts where accountid=tblvoters.editedby) as 'Last Touch' " _
                                    + " from tblvoters where deceased=0 " & txtQuery.Text & " order by fullname asc", "tblvoters", Em, GridView1, Me)

        ' GridView1.Columns("Area/District").Group()

        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("vilcode").Visible = False
        GridView1.Columns("leaderid").Visible = False
        ' GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("isleader").Visible = False


        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", GridView1, DevExpress.Utils.HorzAlignment.Center)

        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        GridView1.Columns("V-Type").Width = 50
        GridView1.Columns("Address").Width = 300
        GridView1.Columns("Address").ColumnEdit = MemoEdit

     
        GridView1.Columns("No.").VisibleIndex = 0 : GridView1.Columns("No.").Visible = False
        GridView1.Columns("Voters ID").VisibleIndex = 1 : GridView1.Columns("Voters ID").Visible = False
        'GridView1.Columns("Area/District").VisibleIndex = 7 : GridView1.Columns("Area/District").Visible = False
        'GridView1.Columns("Municipal/City").VisibleIndex = 8 : GridView1.Columns("Municipal/City").Visible = False
        'GridView1.Columns("Village/Barangay").VisibleIndex = 9 : GridView1.Columns("Village/Barangay").Visible = False
       
        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Voters {0:N0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True

        SplashScreenManager.CloseForm()
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
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        frmEntryInfo.Show()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
    End Sub


    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub


    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 0 Then
            txtArea.Enabled = True
            txtMunicipal.Enabled = True
            txtVillage.Enabled = True
            CheckEdit1.Enabled = True

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
            txtVillage.Enabled = False
            CheckEdit1.Enabled = False
        End If
    End Sub

    Private Sub cmdFilter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        If txtCompany.Text = "" Then
            XtraMessageBox.Show("Please select company.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCompany.Focus()
            Exit Sub
        End If
        If RadioGroup1.SelectedIndex = 0 Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                Exit Sub
            ElseIf txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            ElseIf txtVillage.Text = "" And CheckEdit1.Checked = False Then
                XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            filterAdvance()

        ElseIf RadioGroup1.SelectedIndex = 1 Then
            Dim cntall As Integer = countrecord("tblvoters")
            If cntall > 20000 Then
                If XtraMessageBox.Show("Viewing large data may take a while, depending on the amount of data. " & Environment.NewLine & "Are you sure you want to continue? Viewing Total Records - " & Format(cntall, "N0"), compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    filterAll()
                End If
            Else
                filterAll()
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtVillage.Enabled = False
            txtVillage.Properties.DataSource = Nothing
            txtVillage.Text = ""
            vilcode.Text = ""
            loadVillage()
        Else
            txtVillage.Enabled = True
        End If
    End Sub

    Private Sub txtCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCompany.SelectedIndexChanged
        If txtCompany.Text <> "" Then
            FilterWork()
        End If
    End Sub
    Public Sub FilterWork()
        Dim productquery As String = ""
        com.CommandText = "select votersid from tblwork where companyname='" & rchar(txtCompany.Text) & "' and " & If(CheckEdit2.Checked = True, "iscurrent=1", " (('" & ConvertDate(txtDateWorkFrom.EditValue) & "' between datefrom and dateto) or ('" & ConvertDate(txtDateWorkTo.EditValue) & "' between datefrom and dateto))") : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("votersid").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            txtQuery.Text = " and votersid in(" & productquery & ")"
        Else
            txtQuery.Text = ""
        End If
    End Sub
   
    Private Sub txtDateWorkFrom_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateWorkFrom.EditValueChanged
        If txtCompany.Text <> "" Then
            FilterWork()
        End If
    End Sub
    
    Private Sub txtDateWorkTo_EditValueChanged(sender As Object, e As EventArgs) Handles txtDateWorkTo.EditValueChanged
        If txtCompany.Text <> "" Then
            FilterWork()
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            txtDateWorkFrom.Enabled = False
            txtDateWorkTo.Enabled = False
        Else
            txtDateWorkFrom.Enabled = True
            txtDateWorkTo.Enabled = True
        End If
        FilterWork()
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
        SplashScreenManager.CloseForm()
    End Sub
End Class