Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmLeaderPerformance
    Private strColor As String = ""
    Private strColorDes As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.W Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        ClearGrid()
        loadArea()
        ViewGridtype(GridView1)

    End Sub

    Public Sub ClearGrid()
        strColor = ""
        strColorDes = ""
        com.CommandText = "select distinct(description) from tblcolor inner join tblvoters on tblcolor.colorcode = tblvoters.colorcode order by tblcolor.colorcode asc" : rst = com.ExecuteReader()
        While rst.Read
            strColor = strColor & ", '' as '" & rst("description").ToString & "'"
            strColorDes = strColorDes & rst("description").ToString & ":"
        End While
        rst.Close()
        If strColorDes <> "" Then
            strColorDes = strColorDes.Remove(strColorDes.Length - 1, 1)
        End If
        LoadXgrid("select '' as id, '' as 'Leader', '' as 'Village/Barangay' " & strColor & ",'' as 'Total' from tblvoters where votersid = '0'", "tblvoters", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
    End Sub


    Public Sub filterAdvance()
        ClearGrid()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        Dim currVilcode As String = ""
        Dim numAccount As Integer = 0
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = Val(qrysingledata("cnt", " count(distinct(leaderid)) as cnt", "on tblleaders.votersid = tblvoters.leaderid where tblvoters.areacode='" & areacode.Text & "' and tblvoters.muncode='" & muncode.Text & "'", "tblleaders inner join tblvoters")) + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        dst = New DataSet
        msda = New MySqlDataAdapter("select vilcode,leaderid,(select description from tblcolor where colorcode= tblvoters.colorcode) as Color, count(*) as total from tblvoters where leaderid<>'0' and areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' group by vilcode,leaderid,colorcode  order by leaderid,total;", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If currVilcode <> .Rows(cnt)("leaderid").ToString() Then
                    numAccount = 0
                    AddRowXgrid(GridView1)
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "id", qrysingledata("leadersid", "leadersid", "where votersid='" & .Rows(cnt)("leaderid").ToString() & "'", "tblleaders"))
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Village/Barangay", qrysingledata("villname", "villname", "where villcode='" & .Rows(cnt)("vilcode").ToString() & "'", "tblvillage"))
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Leader", qrysingledata("fullname", "fullname", "where votersid='" & .Rows(cnt)("leaderid").ToString() & "'", "tblvoters"))

                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, .Rows(cnt)("Color").ToString(), Format(Val(.Rows(cnt)("total").ToString()), "N0"))
                    numAccount = Val(.Rows(cnt)("total").ToString())
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Total", Format(numAccount, "N0"))

                Else
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, .Rows(cnt)("Color").ToString(), Format(Val(.Rows(cnt)("total").ToString()), "N0"))
                    numAccount = Val(numAccount) + Val(.Rows(cnt)("total").ToString())
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Total", Format(numAccount, "N0"))
                End If
                currVilcode = .Rows(cnt)("leaderid").ToString()
            End With
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        GridView1.BestFitColumns()
        Dim words As String() = strColorDes.Split(New Char() {":"c})
        Dim word As String
        Dim firstCol As String = ""
        Dim ant As Integer = 0
        For Each word In words
            If ant = 0 Then
                firstCol = word
            End If
            XgridColAlign(word, GridView1, HorzAlignment.Center)
            GridView1.Columns(word).Width = 90
            GridView1.Columns(word).SummaryItem.SummaryType = SummaryItemType.Sum
            GridView1.Columns(word).SummaryItem.DisplayFormat = "{0:N0}"
            GridView1.Columns(word).SummaryItem.Tag = 1
            CType(GridView1.Columns(word).View, GridView).OptionsView.ShowFooter = True
            ant = ant + 1
        Next

        XgridColAlign("Total", GridView1, HorzAlignment.Center)
        GridView1.Columns("Total").Width = 90
        GridView1.Columns("Total").SummaryItem.SummaryType = SummaryItemType.Sum
        GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:N0}"
        GridView1.Columns("Total").SummaryItem.Tag = 1
        CType(GridView1.Columns("Total").View, GridView).OptionsView.ShowFooter = True

        GridView1.ActiveFilterString = "[" & firstCol & "] Is Not Null"
        GridView1.MoveLast()
        ' GridView1.Columns("Municipal/City").Group()
        ' GridView1.ExpandAllGroups()

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub printreport()
        Dim report As New rptOtherReport()
        report.txttitle.Text = Me.Text & " of " & txtMunicipal.Text & ", " & txtArea.Text
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub menuClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles menuClose.ItemClick
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
        filterAdvance()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        printreport()
    End Sub

    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AssignLeadersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignLeadersToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Leader") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf GridView1.SelectedRowsCount > 1 Then
            XtraMessageBox.Show("Multiple select viewing leader information is not applicable. please select one leader only!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmLeaderInformation.id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmLeaderInformation.txtLeaders.Text = GridView1.GetFocusedRowCellValue("Leader").ToString
        frmLeaderInformation.Show()
    End Sub

End Class