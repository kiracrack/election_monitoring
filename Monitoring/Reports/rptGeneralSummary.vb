﻿Public Class rptGeneralSummary
    Private Sub rptOtherReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        If Me.Landscape = True Then
            cname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            caddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            cnumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Else
            cname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            caddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            cnumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        End If

        cname.Text = compname
        'txtcomp.Text = compname
        caddress.Text = compadd
        cnumber.Text = compnumber


        'txtprename.Text = globalfullname
        'txtpredesg.Text = globaldesignation

    End Sub

End Class