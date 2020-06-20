<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDepedDesigner
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.txtFullname = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtArea = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtMunicipality = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBarangay = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtComelectid = New DevExpress.XtraReports.UI.XRLabel()
        Me.barcode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.txtPrecint = New DevExpress.XtraReports.UI.XRLabel()
        Me.imgPicture = New DevExpress.XtraReports.UI.XRPictureBox()
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
        Me.Detail.HeightF = 214.0!
        Me.Detail.Name = "Detail"
        Me.Detail.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtFullname, Me.txtTitle, Me.txtArea, Me.txtMunicipality, Me.txtBarangay, Me.txtComelectid, Me.barcode, Me.txtPrecint, Me.imgPicture, Me.logo})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Impact", 10.15!)
        Me.txtFullname.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtFullname.KeepTogether = True
        Me.txtFullname.LocationFloat = New DevExpress.Utils.PointFloat(96.25671!, 61.08334!)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtFullname.SizeF = New System.Drawing.SizeF(214.3463!, 17.52776!)
        Me.txtFullname.StylePriority.UseFont = False
        Me.txtFullname.StylePriority.UseForeColor = False
        Me.txtFullname.StylePriority.UseTextAlignment = False
        Me.txtFullname.Text = "BUGAHOD, WINTER S."
        Me.txtFullname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Impact", 7.25!)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTitle.KeepTogether = True
        Me.txtTitle.LocationFloat = New DevExpress.Utils.PointFloat(96.25671!, 77.61108!)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle.SizeF = New System.Drawing.SizeF(214.3463!, 12.49001!)
        Me.txtTitle.StylePriority.UseFont = False
        Me.txtTitle.StylePriority.UseForeColor = False
        Me.txtTitle.StylePriority.UseTextAlignment = False
        Me.txtTitle.Text = "MUNICIPAL COORDINATOR"
        Me.txtTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.txtArea.CanGrow = False
        Me.txtArea.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.75!)
        Me.txtArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtArea.KeepTogether = True
        Me.txtArea.LocationFloat = New DevExpress.Utils.PointFloat(96.25671!, 91.1184!)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtArea.SizeF = New System.Drawing.SizeF(214.35!, 10.02!)
        Me.txtArea.StylePriority.UseFont = False
        Me.txtArea.StylePriority.UseForeColor = False
        Me.txtArea.StylePriority.UseTextAlignment = False
        Me.txtArea.Text = "2ND DISTRICT"
        Me.txtArea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtMunicipality
        '
        Me.txtMunicipality.CanGrow = False
        Me.txtMunicipality.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.75!)
        Me.txtMunicipality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMunicipality.KeepTogether = True
        Me.txtMunicipality.LocationFloat = New DevExpress.Utils.PointFloat(96.25671!, 102.1358!)
        Me.txtMunicipality.Name = "txtMunicipality"
        Me.txtMunicipality.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtMunicipality.SizeF = New System.Drawing.SizeF(214.35!, 10.02!)
        Me.txtMunicipality.StylePriority.UseFont = False
        Me.txtMunicipality.StylePriority.UseForeColor = False
        Me.txtMunicipality.StylePriority.UseTextAlignment = False
        Me.txtMunicipality.Text = "LEON B. POSTIGO"
        Me.txtMunicipality.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtBarangay
        '
        Me.txtBarangay.CanGrow = False
        Me.txtBarangay.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.75!)
        Me.txtBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarangay.KeepTogether = True
        Me.txtBarangay.LocationFloat = New DevExpress.Utils.PointFloat(96.2566!, 113.1531!)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBarangay.SizeF = New System.Drawing.SizeF(214.35!, 10.02!)
        Me.txtBarangay.StylePriority.UseFont = False
        Me.txtBarangay.StylePriority.UseForeColor = False
        Me.txtBarangay.StylePriority.UseTextAlignment = False
        Me.txtBarangay.Text = "STA. ISABLE"
        Me.txtBarangay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtComelectid
        '
        Me.txtComelectid.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 7.75!)
        Me.txtComelectid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtComelectid.KeepTogether = True
        Me.txtComelectid.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 191.129!)
        Me.txtComelectid.Name = "txtComelectid"
        Me.txtComelectid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtComelectid.SizeF = New System.Drawing.SizeF(215.6695!, 13.01733!)
        Me.txtComelectid.StylePriority.UseFont = False
        Me.txtComelectid.StylePriority.UseForeColor = False
        Me.txtComelectid.StylePriority.UseTextAlignment = False
        Me.txtComelectid.Text = "7202-216C-60490C8R100"
        Me.txtComelectid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'barcode
        '
        Me.barcode.AutoModule = True
        Me.barcode.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 159.6741!)
        Me.barcode.Name = "barcode"
        Me.barcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.barcode.ShowText = False
        Me.barcode.SizeF = New System.Drawing.SizeF(215.6695!, 31.45491!)
        Me.barcode.StylePriority.UseTextAlignment = False
        Me.barcode.Symbology = Code128Generator1
        Me.barcode.Text = "123456"
        Me.barcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txtPrecint
        '
        Me.txtPrecint.CanGrow = False
        Me.txtPrecint.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 6.75!)
        Me.txtPrecint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrecint.KeepTogether = True
        Me.txtPrecint.LocationFloat = New DevExpress.Utils.PointFloat(96.2566!, 124.1705!)
        Me.txtPrecint.Name = "txtPrecint"
        Me.txtPrecint.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPrecint.SizeF = New System.Drawing.SizeF(214.35!, 10.02!)
        Me.txtPrecint.StylePriority.UseFont = False
        Me.txtPrecint.StylePriority.UseForeColor = False
        Me.txtPrecint.StylePriority.UseTextAlignment = False
        Me.txtPrecint.Text = "002112"
        Me.txtPrecint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'imgPicture
        '
        Me.imgPicture.BorderColor = System.Drawing.Color.Gray
        Me.imgPicture.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.imgPicture.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopCenter
        Me.imgPicture.LocationFloat = New DevExpress.Utils.PointFloat(9.000001!, 60.08333!)
        Me.imgPicture.Name = "imgPicture"
        Me.imgPicture.SizeF = New System.Drawing.SizeF(84.2567!, 88.38598!)
        Me.imgPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.imgPicture.StylePriority.UseBorderColor = False
        Me.imgPicture.StylePriority.UseBorders = False
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
        'rptDepedDesigner
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.Detail, Me.BottomMargin})
        Me.DisplayName = "Inventory Sticker"
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Margins = New System.Drawing.Printing.Margins(12, 12, 12, 12)
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
    Friend WithEvents txtTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtArea As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtMunicipality As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBarangay As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtComelectid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents barcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents txtPrecint As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents imgPicture As DevExpress.XtraReports.UI.XRPictureBox
End Class
