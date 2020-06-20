<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCustomBackTemplate
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
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.txtFullname = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBarangay = New DevExpress.XtraReports.UI.XRLabel()
        Me.logo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.Detail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Detail.HeightF = 215.8045!
        Me.Detail.Name = "Detail"
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtFullname, Me.txtBarangay, Me.logo})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0.0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        '
        'txtFullname
        '
        Me.txtFullname.CanGrow = False
        Me.txtFullname.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFullname.ForeColor = System.Drawing.Color.Black
        Me.txtFullname.KeepTogether = True
        Me.txtFullname.LocationFloat = New DevExpress.Utils.PointFloat(19.33683!, 43.86539!)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtFullname.SizeF = New System.Drawing.SizeF(220.2277!, 12.92196!)
        Me.txtFullname.StylePriority.UseFont = False
        Me.txtFullname.StylePriority.UseForeColor = False
        Me.txtFullname.StylePriority.UseTextAlignment = False
        Me.txtFullname.Text = "BUGAHOD, WINTER S."
        Me.txtFullname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtBarangay
        '
        Me.txtBarangay.CanGrow = False
        Me.txtBarangay.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.75!)
        Me.txtBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarangay.KeepTogether = True
        Me.txtBarangay.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 57.78735!)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBarangay.SizeF = New System.Drawing.SizeF(108.4489!, 8.0!)
        Me.txtBarangay.StylePriority.UseFont = False
        Me.txtBarangay.StylePriority.UseForeColor = False
        Me.txtBarangay.StylePriority.UseTextAlignment = False
        Me.txtBarangay.Text = "STA. ISABLE"
        Me.txtBarangay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'logo
        '
        Me.logo.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 12.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'rptCustomBackTemplate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
        Me.DisplayName = "Inventory Sticker"
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Margins = New System.Drawing.Printing.Margins(12, 11, 12, 12)
        Me.PageHeight = 238
        Me.PageWidth = 364
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "62mm x 29mm"
        Me.PrinterName = "Brother QL-720NW"
        Me.ShowPrintMarginsWarning = False
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents txtFullname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBarangay As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
End Class
