Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmMunicipality
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select muncode, muncode as 'Code',(select areaname from tblarea where areacode = tblMunicipality.areacode) as 'Area', munname as 'Municipality/City' from tblmunicipality", "tblmunicipality", Em, GridView1, Me)
        GridView1.Columns("Area").Group()
        GridView1.ExpandAllGroups()
        GridView1.Columns("muncode").Visible = False
        GridView1.Columns("Code").Visible = False
        GridView1.Columns("Code").Width = 90
        XgridColAlign("Code", GridView1, Utils.HorzAlignment.Center)

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
        id.Text = areacode.Text + "-" + getMunicipality(areacode.Text)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Municipality or CityName!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            If countqry("tblmunicipality", "munname='" & txtdesc.Text & "' and areacode='" & areacode.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Municipality/City Name Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblmunicipality set muncode='" & id.Text & "',areacode='" & areacode.Text & "', munname='" & txtdesc.Text & "'"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblmunicipality set munname='" & txtdesc.Text & "', areacode='" & areacode.Text & "' where  muncode='" & id.Text & "' and areacode='" & areacode.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        txtdesc.Focus()
        XtraMessageBox.Show("Municipality/City successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = areacode.Text + "-" + getMunicipality(areacode.Text)
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim str_areacode As String = ""
        com.CommandText = "select *,(select areaname from tblarea where areacode = tblMunicipality.areacode) as 'area' from tblMunicipality where muncode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("munname").ToString
            areacode.Text = rst("areacode").ToString
            str_areacode = rst("area").ToString
        End While
        txtArea.Text = str_areacode
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("muncode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("muncode").ToString
        mode.Text = "edit"
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
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
        If GridView1.GetFocusedRowCellValue("muncode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("muncode", "muncode", "tblmunicipality", GridView1, Me)
        End If
        id.Text = areacode.Text + "-" + getMunicipality(areacode.Text)
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

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        printreport()
    End Sub
End Class