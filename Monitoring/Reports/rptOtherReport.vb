Public Class rptOtherReport
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

        If txtfrom.Text = "" And txtto.Text = "" Then
            XrLabel7.Visible = False
            XrLabel3.Visible = False
            XrLabel6.Visible = False
            txtfrom.Visible = False
            txtto.Visible = False
        Else
            XrLabel7.Visible = True
            XrLabel3.Visible = True
            XrLabel6.Visible = True
            txtfrom.Visible = True
            txtto.Visible = True
        End If
        txtdate.Text = "Date: " + Format(Now)
        cname.Text = compname

        caddress.Text = compadd
        cnumber.Text = compnumber
       
        
        If txtfrom.Visible = False Then
            GroupHeader1.Visible = False
        Else
            GroupHeader1.Visible = True
        End If

    End Sub

End Class