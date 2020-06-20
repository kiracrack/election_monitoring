Public Class rptCustomPanelView

    'ham nay de luu lai manv khi sub chay
    Public Sub BindData()
        lbl_manv.DataBindings.Add("Text", DataSource, "votersid")
    End Sub

    'hàm này chính là hàm gọi report đơn
    Private Sub XrSubreport1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        strMaNV = lbl_manv.Text
        If strPrintFront = True Then
            Dim rpt As New rptCustomFrontTemplate
            rpt.BindData()
            XrSubreport1.ReportSource = rpt
        Else
            Dim rpt As New rptCustomBackTemplate
            rpt.BindData()
            XrSubreport1.ReportSource = rpt
        End If
       
    End Sub

End Class