Public Class frmCustomReportDesigner
    Private Sub frm_show_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        If int_report = 1 Then
            'chạy report đơn
            If strPrintFront = True Then
                Dim rpt As New rptCustomFrontTemplate
                DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                rpt.BindData()
                rpt.CreateDocument()
            Else
                Dim rpt As New rptCustomBackTemplate
                DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                rpt.BindData()
                rpt.CreateDocument()
            End If

        ElseIf int_report = 2 Then
            'chạy Subreport
            Dim rpt As New rptCustomPanelView
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.DataSource = dsreport
            rpt.BindData()
            rpt.CreateDocument()
        End If

    End Sub

End Class