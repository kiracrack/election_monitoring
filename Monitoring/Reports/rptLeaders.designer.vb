<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLeaders
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
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtmunicipal = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtPrecinctNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtVillage = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtLeader = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtArea = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 12.5!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.cnumber, Me.caddress, Me.cname})
        Me.TopMargin.HeightF = 98.7083!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'cnumber
        '
        Me.cnumber.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.cnumber.KeepTogether = True
        Me.cnumber.LocationFloat = New DevExpress.Utils.PointFloat(49.29153!, 71.70831!)
        Me.cnumber.Name = "cnumber"
        Me.cnumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cnumber.SizeF = New System.Drawing.SizeF(629.4166!, 19.79166!)
        Me.cnumber.StylePriority.UseFont = False
        Me.cnumber.StylePriority.UseTextAlignment = False
        Me.cnumber.Text = "cnumber"
        Me.cnumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'caddress
        '
        Me.caddress.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.caddress.KeepTogether = True
        Me.caddress.LocationFloat = New DevExpress.Utils.PointFloat(49.29166!, 52.95834!)
        Me.caddress.Name = "caddress"
        Me.caddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.caddress.SizeF = New System.Drawing.SizeF(629.4165!, 18.75!)
        Me.caddress.StylePriority.UseFont = False
        Me.caddress.StylePriority.UseTextAlignment = False
        Me.caddress.Text = "cadd"
        Me.caddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cname
        '
        Me.cname.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.KeepTogether = True
        Me.cname.LocationFloat = New DevExpress.Utils.PointFloat(49.29166!, 31.08334!)
        Me.cname.Name = "cname"
        Me.cname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.cname.SizeF = New System.Drawing.SizeF(629.4165!, 21.875!)
        Me.cname.StylePriority.UseFont = False
        Me.cname.StylePriority.UseTextAlignment = False
        Me.cname.Text = "cname"
        Me.cname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel11, Me.txtmunicipal, Me.txtPrecinctNo, Me.txtVillage, Me.XrLabel3, Me.XrLabel9, Me.txtLeader, Me.XrLabel8, Me.txtArea})
        Me.ReportHeader.HeightF = 113.5417!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 86.49998!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(157.71!, 15.62!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "PRECINCT NO.:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 45.99998!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(157.71!, 15.62!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "MUNICIPAL:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtmunicipal
        '
        Me.txtmunicipal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmunicipal.LocationFloat = New DevExpress.Utils.PointFloat(164.7085!, 45.99998!)
        Me.txtmunicipal.Name = "txtmunicipal"
        Me.txtmunicipal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtmunicipal.SizeF = New System.Drawing.SizeF(546.2916!, 15.62501!)
        Me.txtmunicipal.StylePriority.UseFont = False
        Me.txtmunicipal.StylePriority.UseTextAlignment = False
        Me.txtmunicipal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtPrecinctNo
        '
        Me.txtPrecinctNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecinctNo.LocationFloat = New DevExpress.Utils.PointFloat(164.7085!, 86.49998!)
        Me.txtPrecinctNo.Name = "txtPrecinctNo"
        Me.txtPrecinctNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPrecinctNo.SizeF = New System.Drawing.SizeF(546.2916!, 15.625!)
        Me.txtPrecinctNo.StylePriority.UseFont = False
        Me.txtPrecinctNo.StylePriority.UseTextAlignment = False
        Me.txtPrecinctNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtVillage
        '
        Me.txtVillage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage.LocationFloat = New DevExpress.Utils.PointFloat(164.7085!, 66.50001!)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtVillage.SizeF = New System.Drawing.SizeF(546.2916!, 15.62501!)
        Me.txtVillage.StylePriority.UseFont = False
        Me.txtVillage.StylePriority.UseTextAlignment = False
        Me.txtVillage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 66.50001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(157.71!, 15.62!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "BARANGAY:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 27.5!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(157.71!, 15.62!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "AREA / DISTRICT:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtLeader
        '
        Me.txtLeader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeader.LocationFloat = New DevExpress.Utils.PointFloat(164.7085!, 7.499992!)
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtLeader.SizeF = New System.Drawing.SizeF(546.2916!, 15.625!)
        Me.txtLeader.StylePriority.UseFont = False
        Me.txtLeader.StylePriority.UseTextAlignment = False
        Me.txtLeader.Text = "SAMPLE TEXT"
        Me.txtLeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.499992!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(157.71!, 15.62!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "HOUSEHOLD LEADER:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.LocationFloat = New DevExpress.Utils.PointFloat(164.7085!, 27.5!)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtArea.SizeF = New System.Drawing.SizeF(546.2916!, 15.625!)
        Me.txtArea.StylePriority.UseFont = False
        Me.txtArea.StylePriority.UseTextAlignment = False
        Me.txtArea.Text = "SAMPLE TEXT"
        Me.txtArea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptLeaders
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.Margins = New System.Drawing.Printing.Margins(59, 65, 99, 100)
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
    Friend WithEvents txtPrecinctNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtVillage As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtLeader As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtArea As DevExpress.XtraReports.UI.XRLabel
End Class
