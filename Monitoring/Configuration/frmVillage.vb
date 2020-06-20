Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmVillage
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        If areacode.Text = "AREACODE" Or areacode.Text = "" Then Exit Sub
        If muncode.Text <> "CITYCODE" Then
            LoadXgrid("Select villcode, villcode as 'Code', " _
                                   + " (select munname from tblmunicipality where muncode=tblvillage.muncode) as 'Municipal/City', villname as 'Village/Barangay' from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'", "tblvillage", Em, GridView1, Me)
        Else
            LoadXgrid("Select villcode, villcode as 'Code', " _
                                   + " (select munname from tblmunicipality where muncode=tblvillage.muncode) as 'Municipal/City', villname as 'Village/Barangay' from tblvillage where areacode='" & areacode.Text & "'", "tblvillage", Em, GridView1, Me)

        End If

        ' GridView1.Columns("Area/District").Group()
        GridView1.Columns("Municipal/City").Group()
        GridView1.ExpandAllGroups()
        GridView1.Columns("villcode").Visible = False
        GridView1.Columns("Code").Visible = False
        XgridColAlign("Code", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Code").Width = 100

        Dim item As New GridGroupSummaryItem()
        item.FieldName = "Municipal/City"
        item.SummaryType = DevExpress.Data.SummaryItemType.Count

        Dim item1 As New GridGroupSummaryItem()
        item1.FieldName = "Village/Barangay"
        item1.SummaryType = DevExpress.Data.SummaryItemType.Count
        item1.DisplayFormat = "Number of Barangay {0:N0}"
        item1.ShowInGroupColumnFooter = GridView1.Columns("Village/Barangay")
        GridView1.GroupSummary.Add(item1)

        GridView1.Columns("Village/Barangay").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Village/Barangay").SummaryItem.DisplayFormat = " Total Barangay of " & StrConv(txtArea.Text, vbProperCase) & " {0:N0}"
        GridView1.Columns("Village/Barangay").SummaryItem.Tag = 1
        CType(GridView1.Columns("Village/Barangay").View, GridView).OptionsView.ShowFooter = True
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
        filter()
        loadMunicipal()
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode = '" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        id.Text = muncode.Text + "-" + getVillageID(areacode.Text, muncode.Text)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Village/Barangay Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            If countqry("tblvillage", "villcode='" & id.Text & "' and areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'") <> 0 Or countqry("tblvillage", "villcode='" & id.Text & "' and areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and villname='" & txtdesc.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Village/Barangay Name Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblvillage set villcode='" & id.Text & "',areacode='" & areacode.Text & "',muncode='" & muncode.Text & "', villname='" & txtdesc.Text & "'"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblvillage set villname='" & txtdesc.Text & "',areacode='" & areacode.Text & "',muncode='" & muncode.Text & "'  where villcode='" & id.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        txtdesc.Focus()
        ' XtraMessageBox.Show("Village/Barangay successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = muncode.Text + "-" + getVillageID(areacode.Text, muncode.Text)
        txtdesc.Text = ""
        mode.Text = ""
    End Sub
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim area As String = "" : Dim municipal As String = ""
        com.CommandText = "select *, (select areaname from tblarea where areacode = tblvillage.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblvillage.muncode) as 'municipal' from tblvillage where villcode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("villname").ToString
            areacode.Text = rst("areacode").ToString
            area = rst("area").ToString
            muncode.Text = rst("muncode").ToString
            municipal = rst("municipal").ToString
        End While
        rst.Close()

        txtArea.Text = area
        txtMunicipal.Text = municipal
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("villcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("villcode").ToString
        mode.Text = "edit"
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(me)
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text

        clearfields()
        filter()
        loadArea()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("villcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("villcode", "villcode", "tblvillage", GridView1, Me)
        End If
        id.Text = muncode.Text + "-" + getVillageID(areacode.Text, muncode.Text)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.ShowFindPanel()
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        rptsettings = ""
        filter()
    End Sub
End Class