Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class frmReportGenerator
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + (Keys.W) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub LoadTemplate()

        LoadXgridLookupSearch("SELECT rptid,rptname as 'Report Template' from tblreporttemplate where status=1 order by rptname asc", "tblreporttemplate", txtReportTemplate, GridOffice, Me)
        GridOffice.Columns("rptid").Visible = False
    End Sub
    Private Sub txtReportTemplate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReportTemplate.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtReportTemplate.Properties.View.FocusedRowHandle.ToString)
        id.Text = txtReportTemplate.Properties.View.GetFocusedRowCellValue("rptid").ToString()
        txtReportTemplate.Text = txtReportTemplate.Properties.View.GetFocusedRowCellValue("Report Template").ToString()
    End Sub
    Public Sub filter()
        Dim strquery As String = ""
        Try
            com.CommandText = "select * from tblreporttemplate where rptid='" & id.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                strquery = rst("rptquery").ToString
            End While
            rst.Close()

            LoadXgrid(strquery, 0, Em, gridview1, Me)

            com.CommandText = "select * from tblreportconfig where rptid='" & id.Text & "' order by sortorder asc"
            rst = com.ExecuteReader
            While rst.Read

                If rst("colgroup") = True Then
                    gridview1.Columns(rst("colname").ToString).Group()
                    gridview1.ExpandAllGroups()
                End If

                If Val(rst("coltype").ToString) = 0 Then
                    gridview1.Columns(rst("colname").ToString).ColumnEdit = MemoEdit

                    If rst("alignment").ToString = "L" Then
                        XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Default)
                    ElseIf rst("alignment").ToString = "C" Then
                        XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    ElseIf rst("alignment").ToString = "R" Then
                        XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                ElseIf Val(rst("coltype").ToString) = 1 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColCurrency(rst("colname").ToString, gridview1)
                    XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Far)

                ElseIf Val(rst("coltype").ToString) = 2 Then
                    gridview1.Columns(rst("colname").ToString).Width = 120
                    XgridColNumber(rst("colname").ToString, gridview1)

                    If rst("alignment").ToString = "C" Then
                        XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Center)
                    Else
                        XgridColAlign(rst("colname").ToString, gridview1, DevExpress.Utils.HorzAlignment.Far)
                    End If

                End If

                If rst("colgrpsum") = True Then
                    Dim item As New GridGroupSummaryItem()
                    item.FieldName = rst("colname").ToString
                    item.SummaryType = DevExpress.Data.SummaryItemType.Count

                    Dim splitother As String() = rst("colgrpsumtext").ToString.Split(New Char() {","c})
                    For Each idword In splitother
                        Dim item1 As New GridGroupSummaryItem()
                        item1.FieldName = idword
                        If rst("colgrpsumtype").ToString = "SUM" Then
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
                            item1.DisplayFormat = "{0:n}"
                        Else
                            item1.SummaryType = DevExpress.Data.SummaryItemType.Count
                            item1.DisplayFormat = "{0:N0}"
                        End If
                        item1.ShowInGroupColumnFooter = gridview1.Columns(idword)
                        gridview1.GroupSummary.Add(item1)
                    Next
                End If

                If rst("colgensum") = True Then
                    If rst("colgensumtype").ToString = "SUM" Then
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Sum
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:n}"
                    Else
                        gridview1.Columns(rst("colname").ToString).SummaryItem.SummaryType = SummaryItemType.Count
                        gridview1.Columns(rst("colname").ToString).SummaryItem.DisplayFormat = rst("colgensumtext").ToString & " {0:N0}"
                    End If
                    gridview1.Columns(rst("colname").ToString).SummaryItem.Tag = 1
                    CType(gridview1.Columns(rst("colname").ToString).View, GridView).OptionsView.ShowFooter = True
                End If
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & strquery & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
    End Sub

    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        reportcount(Me.Name.ToString)
        txttitle.Text = reportTitle(Me.Name.ToString)
        txtCustom.Text = reportcustomtext(Me.Name.ToString)
        Me.Text = txttitle.Text


        ViewGridtype(gridview1)
        LoadTemplate()
    End Sub

    Public Sub printreport()
        com.CommandText = "update tblreportsetting set title='" & txttitle.Text & "', customtext='" & txtCustom.Text & "' where formname='" & Me.Name.ToString & "' " : com.ExecuteNonQuery()
        Dim report As New rptOtherReport()
        report.Landscape = rdoreintation.EditValue.ToString
        If txtpapertype.Text = "Letter" Then
            report.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Else
            report.PaperKind = System.Drawing.Printing.PaperKind.Legal
        End If
        'report.MasterReport.Margins.
        report.txttitle.Text = txtReportTemplate.Text

        report.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)

        report.Bands(BandKind.Detail).Controls.Add(CopyGridControl(Me.Em))
        report.ShowRibbonPreviewDialog()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        printreport()
    End Sub

   
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReportTemplate.EditValueChanged

    End Sub
    Private Sub LabelControl21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl21.Click

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtReportTemplate.Text = "" Then
            XtraMessageBox.Show("Please Select Report Template!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReportTemplate.Focus()
            Exit Sub
        End If
        filter()
    End Sub
End Class