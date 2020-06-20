<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptGeneralSummary
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.cnumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.caddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.cname = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.txtunassigned = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtassigned = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtmunicipal = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtnoleaders = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtnovoters = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtArea = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cnumber, Me.caddress, Me.cname})
        Me.TopMargin.HeightF = 87.24996!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cnumber
        '
        Me.cnumber.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.cnumber.KeepTogether = True
        Me.cnumber.LocationFloat = New DevExpress.Utils.PointFloat(91.20821!, 56.62497!)
        Me.cnumber.Name = "cnumber"
        Me.cnumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cnumber.SizeF = New System.Drawing.SizeF(536.5419!, 19.79166!)
        Me.cnumber.StylePriority.UseFont = False
        Me.cnumber.StylePriority.UseTextAlignment = False
        Me.cnumber.Text = "cnumber"
        Me.cnumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'caddress
        '
        Me.caddress.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.caddress.KeepTogether = True
        Me.caddress.LocationFloat = New DevExpress.Utils.PointFloat(91.20834!, 37.87501!)
        Me.caddress.Name = "caddress"
        Me.caddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.caddress.SizeF = New System.Drawing.SizeF(536.5418!, 18.75!)
        Me.caddress.StylePriority.UseFont = False
        Me.caddress.StylePriority.UseTextAlignment = False
        Me.caddress.Text = "cadd"
        Me.caddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cname
        '
        Me.cname.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.KeepTogether = True
        Me.cname.LocationFloat = New DevExpress.Utils.PointFloat(91.20834!, 16.00001!)
        Me.cname.Name = "cname"
        Me.cname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cname.SizeF = New System.Drawing.SizeF(536.5418!, 21.875!)
        Me.cname.StylePriority.UseFont = False
        Me.cname.StylePriority.UseTextAlignment = False
        Me.cname.Text = "cname"
        Me.cname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(625.9999!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 17.79167!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtunassigned, Me.XrLabel12, Me.XrLabel6, Me.txtassigned, Me.XrLabel10, Me.XrLabel11, Me.txtmunicipal, Me.txtnoleaders, Me.txtnovoters, Me.XrLabel3, Me.XrLabel9, Me.txtArea})
        Me.ReportHeader.HeightF = 145.8333!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'txtunassigned
        '
        Me.txtunassigned.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunassigned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtunassigned.LocationFloat = New DevExpress.Utils.PointFloat(324.2914!, 122.7499!)
        Me.txtunassigned.Name = "txtunassigned"
        Me.txtunassigned.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtunassigned.SizeF = New System.Drawing.SizeF(162.7501!, 15.625!)
        Me.txtunassigned.StylePriority.UseFont = False
        Me.txtunassigned.StylePriority.UseForeColor = False
        Me.txtunassigned.StylePriority.UseTextAlignment = False
        Me.txtunassigned.Text = "0.00"
        Me.txtunassigned.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(16.66667!, 122.7499!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(306.458!, 15.625!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Total Number of Voters Unassigned Leaders:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(24.58309!, 103.1249!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(299.1663!, 15.625!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Total Number of Voters Assigned Leaders:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtassigned
        '
        Me.txtassigned.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtassigned.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtassigned.LocationFloat = New DevExpress.Utils.PointFloat(324.2912!, 103.1249!)
        Me.txtassigned.Name = "txtassigned"
        Me.txtassigned.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtassigned.SizeF = New System.Drawing.SizeF(162.7501!, 15.62502!)
        Me.txtassigned.StylePriority.UseFont = False
        Me.txtassigned.StylePriority.UseForeColor = False
        Me.txtassigned.StylePriority.UseTextAlignment = False
        Me.txtassigned.Text = "0.00"
        Me.txtassigned.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(17.29155!, 74.45834!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(306.458!, 15.625!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Total Number of Leaders:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(154.6245!, 28.49998!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(169.125!, 15.625!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "City/Municipal:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtmunicipal
        '
        Me.txtmunicipal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.txtmunicipal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmunicipal.LocationFloat = New DevExpress.Utils.PointFloat(324.2914!, 28.49998!)
        Me.txtmunicipal.Name = "txtmunicipal"
        Me.txtmunicipal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtmunicipal.SizeF = New System.Drawing.SizeF(264.6669!, 15.62501!)
        Me.txtmunicipal.StylePriority.UseFont = False
        Me.txtmunicipal.StylePriority.UseForeColor = False
        Me.txtmunicipal.StylePriority.UseTextAlignment = False
        Me.txtmunicipal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtnoleaders
        '
        Me.txtnoleaders.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoleaders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnoleaders.LocationFloat = New DevExpress.Utils.PointFloat(324.2914!, 74.45825!)
        Me.txtnoleaders.Name = "txtnoleaders"
        Me.txtnoleaders.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtnoleaders.SizeF = New System.Drawing.SizeF(162.7501!, 15.625!)
        Me.txtnoleaders.StylePriority.UseFont = False
        Me.txtnoleaders.StylePriority.UseForeColor = False
        Me.txtnoleaders.StylePriority.UseTextAlignment = False
        Me.txtnoleaders.Text = "0.00"
        Me.txtnoleaders.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtnovoters
        '
        Me.txtnovoters.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnovoters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnovoters.LocationFloat = New DevExpress.Utils.PointFloat(324.2914!, 54.4583!)
        Me.txtnovoters.Name = "txtnovoters"
        Me.txtnovoters.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtnovoters.SizeF = New System.Drawing.SizeF(162.7501!, 15.62502!)
        Me.txtnovoters.StylePriority.UseFont = False
        Me.txtnovoters.StylePriority.UseForeColor = False
        Me.txtnovoters.StylePriority.UseTextAlignment = False
        Me.txtnovoters.Text = "0.00"
        Me.txtnovoters.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(23.95836!, 54.45833!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(299.1663!, 15.625!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Total Number of Voters:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(156.9161!, 10.00001!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(166.8333!, 15.625!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Area/District:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.txtArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtArea.LocationFloat = New DevExpress.Utils.PointFloat(324.2914!, 10.00001!)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtArea.SizeF = New System.Drawing.SizeF(264.6669!, 15.625!)
        Me.txtArea.StylePriority.UseFont = False
        Me.txtArea.StylePriority.UseForeColor = False
        Me.txtArea.StylePriority.UseTextAlignment = False
        Me.txtArea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 26.04167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'rptGeneralSummary
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(59, 65, 87, 100)
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents cnumber As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents caddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtmunicipal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtnoleaders As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtnovoters As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtArea As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtunassigned As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtassigned As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
