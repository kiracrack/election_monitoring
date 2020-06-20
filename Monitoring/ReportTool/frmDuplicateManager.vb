Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmDuplicateManager
    Private printStr As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    'Public Sub loadTables()
    '    LoadXgridLookupSearch("show tables from pcbr3", 0, from_table, gridtables, Me)
    '    from_table.Properties.DisplayMember = "Tables_in_pcbr3"
    '    from_table.Properties.ValueMember = "Tables_in_pcbr3"
    'End Sub
    'Private Sub from_table_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles from_table.EditValueChanged
    '    On Error Resume Next
    '    Dim iCurrentRow As Integer = CInt(from_table.Properties.View.FocusedRowHandle.ToString)
    '    from_table.Text = from_table.Properties.View.GetFocusedRowCellValue("Tables_in_pcbr3").ToString
    'End Sub
   
    Public Sub FilterFields()
        com.CommandText = "show fields from tblvoters"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("Field"), False)
            ls.Items.Item(rst("Field")).Description = rst("Field").ToString
            ls.Items.Item(rst("Field")).Value = rst("Field").ToString
        End While
        rst.Close()

    End Sub
    Public Sub filter()
        If ls.CheckedItemsCount = 0 Then
            XtraMessageBox.Show("there's no selected item!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim strqry As String = ""
        Dim strfield As String = ""
        Dim strgroupby As String = ""
        Dim strChecked As String = ""
        For n = 0 To ls.CheckedItems.Count - 1
            strChecked = strChecked + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + ","
        Next

            strChecked = strChecked.Remove(strChecked.Count - 1, 1)
            Dim words As String() = strChecked.Split(New Char() {","c})
            ' Use For Each loop over words and display them
            Dim word As String
            Dim cnt = 1
            For Each word In words

                If cnt = 1 Then
                    strgroupby = "tblvoters." & word.Replace(" ", "")
                End If
                If words.Count = cnt Then
                    strqry = strqry & "tblvoters." & word.Replace(" ", "") & " = dup." & word.Replace(" ", "")
                    strfield = strfield & "tblvoters." & word.Replace(" ", "")
                Else
                    strqry = strqry & "tblvoters." & word.Replace(" ", "") & " = dup." & word.Replace(" ", "") & " and "
                    strfield = strfield & "tblvoters." & word.Replace(" ", "") & ","
                End If
                cnt = cnt + 1
            Next
            printStr = strfield
            Me.Cursor = Cursors.WaitCursor
        LoadXgrid("SELECT tblvoters.id, tblvoters.votersno as 'No.', tblvoters.votersid as 'Voters ID', tblvoters.precinct as 'Precinct No.', tblvoters.Fullname as 'Voter''s',tblvoters.Address, tblvoters.bdate as 'Birth Date', tblvoters.Sex, " _
                            + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                            + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                            + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                            + " tblvoters.vtype as 'V-Type', " _
                            + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'Color',isleader " _
                            + " FROM " & "tblvoters " _
                  + " INNER JOIN (SELECT " & strfield & " FROM " & "tblvoters " _
                  + " GROUP BY " & strfield & " HAVING count(" & strgroupby & ") > 1) dup ON " & strqry & " order by " & strgroupby & " asc", "tblvoters", Em, GridView1, Me)
        gridview1.Columns("id").Visible = False
        GridView1.Columns("isleader").Visible = False
        XgridColAlign("Precinct No.", gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("No.", gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", gridview1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("V-Type", gridview1, DevExpress.Utils.HorzAlignment.Center)

        gridview1.Columns("No.").Width = 40
        gridview1.Columns("Precinct No.").Width = 70
        gridview1.Columns("V-Type").Width = 50
        gridview1.Columns("Address").Width = 300
        gridview1.Columns("Address").ColumnEdit = MemoEdit

        gridview1.Columns("Voter's").Width = 230
        gridview1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        gridview1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Row(s) {0}"
        gridview1.Columns("Voter's").SummaryItem.Tag = 1
        CType(gridview1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
        Me.Cursor = Cursors.Default
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
    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text
        ViewGridtype(gridview1)
        FilterFields()

        If globalpermission = 0 Then
            Em.ContextMenuStrip = ContextMenuStrip1
        Else
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()
        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString
        report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        report.txttitle.Text = txttitle.Text & " - Query by " & printStr.Replace("tblvoters.", "")
         
        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()

    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        filter()
    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        filter()
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelectedToolStripMenuItem.Click
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

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
                toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id")
                com.CommandText = "insert into tblvotersdeleted (votersid,precinct,votersno,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,colorcode,leaderid,status,dateentry,entryby,remarks,isleader,isedited,editedby) " _
                              + " select votersid,precinct,votersno,fullname,address,bdate,sex,vtype,areacode,muncode,vilcode,colorcode,leaderid,status,dateentry,entryby,remarks,isleader,isedited," & globaluserid & " from tblvoters where id='" & toUpdate & "'" : com.ExecuteNonQuery()

                com.CommandText = "delete from tblvoters where id='" & toUpdate & "'" : com.ExecuteNonQuery()
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            GridView1.DeleteSelectedRows()
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1

        End If


    End Sub
End Class