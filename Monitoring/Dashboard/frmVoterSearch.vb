Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class frmVoterSearch
    Dim votersid As String = ""
    Dim votersname As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Control + Keys.C Then
            If selectedColorCode = "" Then
                If XtraMessageBox.Show("Default color currently not selected! Do you want to select color? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmColorChange.Show()
                End If
            End If
        ElseIf keyData = Keys.Control + Keys.E Then
            cmdEditInfo.PerformClick()

        ElseIf keyData = Keys.Control + Keys.L Then
            cmdViewLeaderInfo.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        ViewGridtype(GridView1)
        GridView1.RowHeight = 15
        GridView1.ColumnPanelRowHeight = 24
        GridView1.BorderStyle = BorderStyles.NoBorder
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsBehavior.[ReadOnly] = True

        GridView1.OptionsSelection.EnableAppearanceFocusedCell = True

        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsView.ShowAutoFilterRow = False
        GridView1.OptionsView.ShowIndicator = True
        GridView1.OptionsView.EnableAppearanceEvenRow = True
        GridView1.OptionsView.EnableAppearanceOddRow = True
        GridView1.OptionsView.ShowHorzLines = True
        GridView1.OptionsView.ShowVertLines = True
        GridView1.OptionsView.ShowViewCaption = True
        ClearGrid()
    End Sub

    Public Sub ClearGrid()
        Dim array() As String = {"Voters ID", "Precinct No.", "Fullname", "Address", "Cell Number", "Birth Date", "Sex", "Area/District", "Municipal/City", "Village/Barangay", "Cluster", "V-Type", "Leader's Name", "Color Category", "Is Leader", "Sector", "Note", "Current Work Company", "Issued ID", "Deceased"}
        LoadXgrid("select '' as 'Particular', '' as 'Details' ", "tblvoters", Em, GridView1, Me)

        For Each valueArr As String In array
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Particular", valueArr)
            AddRowXgrid(GridView1)
        Next
        GridView1.Columns("Details").ColumnEdit = MemoEdit
        GridView1.Columns("Particular").Width = 180
        GridView1.Columns("Details").Width = 280
        GridView1.MoveLast()

        If GridView1.GetFocusedRowCellValue("Particular").ToString = "" Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub
    Public Sub filter()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        Dim array() As String = Nothing
        votersid = "" : votersname = ""
        com.CommandText = "select a.*,date_format(datedeceased,'%M %d, %Y') as 'dtdeceased', (select areaname from tblarea where areacode = a.areacode) as 'area', " _
                           + " (select munname from tblmunicipality where muncode=a.muncode) as 'city', " _
                           + " (select villname from tblvillage where villcode=a.vilcode) as 'brgy', " _
                           + " (select colorname from tblcolor where colorcode = a.colorcode) as 'colorname', " _
                           + " case when leaderid = '0' then 'Unassigned' else (select fullname from tblvoters as b where b.votersid = a.leaderid) end as 'leader', " _
                           + " case when isleader=0 then 'No' when isleader=1 then 'Yes' end as isleaders,case when idprint=0 then 'NO ID' else 'YES' end as 'issueid', " _
                           + " case when sector is null then 'None' when sector = '' then 'None' else (select group_concat(sectorname) from tblsector where sectorcode REGEXP concat(',?',a.sector,',?')) end as 'Sectors', " _
                           + " (select companyname from tblwork where iscurrent=1 and votersid=a.votersid) as 'currentwork' from tblvoters as a where " _
                           + " a.Fullname = '" & rchar(txtSearch.Text) & "' or a.votersid = '" & rchar(txtSearch.Text) & "'  order by fullname asc "
        rst = com.ExecuteReader
        While rst.Read
            id.Text = rst("votersid").ToString
            array = {rst("votersid").ToString,
                                     rst("precinct").ToString,
                                     rst("fullname").ToString,
                                     rst("address").ToString,
                                     rst("contactnumber").ToString,
                                     rst("bdate").ToString,
                                     rst("sex").ToString,
                                     rst("area").ToString,
                                     rst("city").ToString,
                                     rst("brgy").ToString,
                                      If(Val(rst("cluster").ToString) > 0, "Cluster " & rst("cluster").ToString, "None"),
                                     rst("vtype").ToString,
                                     rst("leader").ToString,
                                     rst("colorname").ToString,
                                     rst("isleaders").ToString,
                                     rst("Sectors").ToString,
                                     rst("remarks").ToString,
                                     rst("currentwork").ToString,
                                     rst("issueid").ToString,
                                     If(rst("deceased") = True, rst("dtdeceased").ToString, "")}
            votersid = rst("votersid").ToString
            votersname = rst("fullname").ToString

            If CBool(rst("isleader")) = True Then
                cmdViewLeaderInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                cmdViewLeaderInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End While
        rst.Close()
        SplashScreenManager.CloseForm()
        If array.Count = 0 Then
            XtraMessageBox.Show("No Record Found!" & vbCrLf, _
                                         "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim cnt As Integer = 0
        For Each valueArr As String In array
            GridView1.SetRowCellValue(cnt, "Details", valueArr)
            cnt = cnt + 1
        Next
        GridView1.Columns("Particular").Width = 180
        GridView1.Columns("Details").Width = 280
        GridView1.MoveLast()
        If GridView1.GetFocusedRowCellValue("Particular").ToString = "" Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Details" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Details"))
            e.Appearance.BackColor = Color.FromName(colorname)
            ' e.Appearance.ForeColor = Color.FromName(colorname)
        End If
        If e.Column.FieldName = "Particular" Then
            e.Appearance.BackColor = Color.LemonChiffon
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font("Tahoma", 7.75!, System.Drawing.FontStyle.Bold)
        End If
    End Sub

    Public Sub printreport()
        Dim report As New rptOtherReport()
        report.txttitle.Text = "Voter's Information"
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtSearch.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select fullname from tblvoters where fullname like '" & rchar(txtSearch.Text) & "%' or votersid = '" & rchar(txtSearch.Text) & "' order by fullname asc limit 100"
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
    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSearch.Text = "" Or txtSearch.Text = "%" Then Exit Sub
            If countqry("tblvoters", "fullname= '" & txtSearch.Text & "' or votersid = '" & rchar(txtSearch.Text) & "'") = 0 Then
                ComboBoxFilter(txtSearch.Text, True)
                txtSearch.ShowPopup()
                Exit Sub
            Else
                filter()
            End If
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEditInfo.ItemClick
        If id.Text = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmEntryInfo.votersid.Text = id.Text
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdViewLeaderInfo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdViewLeaderInfo.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmLeaderInformation.id.Text = qrysingledata1("leadersid", "leadersid", "tblleaders where votersid='" & votersid & "'")
        frmLeaderInformation.txtLeaders.Text = votersname
        frmLeaderInformation.Show(Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        printreport()
    End Sub
End Class