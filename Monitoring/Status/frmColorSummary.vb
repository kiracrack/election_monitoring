Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient

Public Class frmColorSummary
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
        LoadXgrid("select '' as 'Municipal/City', '' as 'Barangay' " & strColor & " from tblvoters where votersid = '0'", "tblvoters", Em, GridView1, Me)
    End Sub


    Public Sub filterAdvance()
        ClearGrid()
        Me.Cursor = Cursors.WaitCursor
        Dim currVilcode As String = ""
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = Val(qrysingledata("cnt", " count(distinct(vilcode)) as cnt ", "where areacode='" & areacode.Text & "' " & If(CheckEdit1.Checked = True, "", " and muncode='" & muncode.Text & "'") & " and deceased=0", "tblvoters")) + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        Dim querytype As String = ""
        If RadioGroup1.SelectedIndex = 0 Then
            querytype = "and isleader=1"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            querytype = "and isleader=0"
        Else
            querytype = ""
        End If

        dst = New DataSet
        msda = New MySqlDataAdapter("SELECT vilcode,muncode, vilcode, " _
                                    + " (select description from tblcolor where colorcode = tblvoters.colorcode) as Color, count(*) as total FROM `tblvoters` where areacode='" & areacode.Text & "' " & If(CheckEdit1.Checked = True, "", " and muncode='" & muncode.Text & "'") & " and deceased=0 " & querytype & " group by vilcode,colorcode", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If currVilcode <> .Rows(cnt)("vilcode").ToString() Then
                    AddRowXgrid(GridView1)
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Municipal/City", qrysingledata("munname", "munname", "where muncode='" & .Rows(cnt)("muncode").ToString() & "'", "tblmunicipality"))
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Barangay", qrysingledata("villname", "villname", "where villcode='" & .Rows(cnt)("vilcode").ToString() & "'", "tblvillage"))
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, .Rows(cnt)("Color").ToString(), Format(Val(.Rows(cnt)("total").ToString()), "N0"))
                Else
                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, .Rows(cnt)("Color").ToString(), Format(Val(.Rows(cnt)("total").ToString()), "N0"))
                End If
                currVilcode = .Rows(cnt)("vilcode").ToString()
            End With
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        GridView1.BestFitColumns()
        Dim words As String() = strColorDes.Split(New Char() {":"c})
        Dim word As String
        For Each word In words
            XgridColAlign(word, GridView1, HorzAlignment.Center)
            GridView1.Columns(word).Width = 90
            GridView1.Columns(word).SummaryItem.SummaryType = SummaryItemType.Sum
            GridView1.Columns(word).SummaryItem.DisplayFormat = "Total {0:N0}"
            GridView1.Columns(word).SummaryItem.Tag = 1
            CType(GridView1.Columns(word).View, GridView).OptionsView.ShowFooter = True
        Next

        GridView1.MoveLast()
        GridView1.Columns("Municipal/City").Group()
        GridView1.ExpandAllGroups()

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub printreport()
        Dim querytype As String = ""
        If RadioGroup1.SelectedIndex = 0 Then
            querytype = " (Leader)"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            querytype = " (Member)"
        Else
            querytype = ""
        End If
        Dim report As New rptOtherReport()
        report.txttitle.Text = Me.Text & " of " & txtArea.Text & querytype
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub


    Private Sub DisplayFormatToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGridFormat.formatGrid(GridView1)
        frmGridFormat.Show()
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
        End If
        filterAdvance()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        printreport()
    End Sub
 
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtMunicipal.Enabled = False
        Else
            txtMunicipal.Enabled = True
        End If
    End Sub
End Class