<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptID
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptID))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.txtFullname = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBirthDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtArea = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtMunicipality = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBarangay = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtComelectid = New DevExpress.XtraReports.UI.XRLabel()
        Me.barcode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.votersImage = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.txtPrecint = New DevExpress.XtraReports.UI.XRLabel()
        Me.logo = New DevExpress.XtraReports.UI.XRPictureBox()
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
        Me.TopMargin.BorderWidth = 0.0!
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.TopMargin.HeightF = 368.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBorderWidth = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtFullname, Me.txtTitle, Me.txtBirthDate, Me.txtArea, Me.txtMunicipality, Me.txtBarangay, Me.txtComelectid, Me.barcode, Me.votersImage, Me.txtPrecint, Me.logo})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(368.5724!, 40.89228!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(339.0!, 213.0!)
        '
        'txtFullname
        '
        Me.txtFullname.Font = New System.Drawing.Font("Impact", 10.15!)
        Me.txtFullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFullname.KeepTogether = True
        Me.txtFullname.LocationFloat = New DevExpress.Utils.PointFloat(92.01387!, 57.08333!)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtFullname.SizeF = New System.Drawing.SizeF(241.1336!, 17.52776!)
        Me.txtFullname.StylePriority.UseFont = False
        Me.txtFullname.StylePriority.UseForeColor = False
        Me.txtFullname.StylePriority.UseTextAlignment = False
        Me.txtFullname.Text = "BUGAHOD, WINTER S."
        Me.txtFullname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Impact", 7.25!)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTitle.KeepTogether = True
        Me.txtTitle.LocationFloat = New DevExpress.Utils.PointFloat(92.01388!, 73.61109!)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitle.SizeF = New System.Drawing.SizeF(199.83!, 12.49!)
        Me.txtTitle.StylePriority.UseFont = False
        Me.txtTitle.StylePriority.UseForeColor = False
        Me.txtTitle.StylePriority.UseTextAlignment = False
        Me.txtTitle.Text = "MUNICIPAL COORDINATOR"
        Me.txtTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtBirthDate
        '
        Me.txtBirthDate.CanGrow = False
        Me.txtBirthDate.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBirthDate.KeepTogether = True
        Me.txtBirthDate.LocationFloat = New DevExpress.Utils.PointFloat(214.0417!, 89.10065!)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBirthDate.SizeF = New System.Drawing.SizeF(114.106!, 13.01736!)
        Me.txtBirthDate.StylePriority.UseFont = False
        Me.txtBirthDate.StylePriority.UseForeColor = False
        Me.txtBirthDate.StylePriority.UseTextAlignment = False
        Me.txtBirthDate.Text = "1/30/2013"
        Me.txtBirthDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.txtArea.CanGrow = False
        Me.txtArea.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.txtArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtArea.KeepTogether = True
        Me.txtArea.LocationFloat = New DevExpress.Utils.PointFloat(214.0417!, 102.118!)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtArea.SizeF = New System.Drawing.SizeF(114.1059!, 13.01736!)
        Me.txtArea.StylePriority.UseFont = False
        Me.txtArea.StylePriority.UseForeColor = False
        Me.txtArea.StylePriority.UseTextAlignment = False
        Me.txtArea.Text = "2ND DISTRICT"
        Me.txtArea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtMunicipality
        '
        Me.txtMunicipality.CanGrow = False
        Me.txtMunicipality.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.txtMunicipality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMunicipality.KeepTogether = True
        Me.txtMunicipality.LocationFloat = New DevExpress.Utils.PointFloat(214.0417!, 115.1354!)
        Me.txtMunicipality.Name = "txtMunicipality"
        Me.txtMunicipality.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtMunicipality.SizeF = New System.Drawing.SizeF(114.1059!, 13.01736!)
        Me.txtMunicipality.StylePriority.UseFont = False
        Me.txtMunicipality.StylePriority.UseForeColor = False
        Me.txtMunicipality.StylePriority.UseTextAlignment = False
        Me.txtMunicipality.Text = "LEON B. POSTIGO"
        Me.txtMunicipality.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtBarangay
        '
        Me.txtBarangay.CanGrow = False
        Me.txtBarangay.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.txtBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBarangay.KeepTogether = True
        Me.txtBarangay.LocationFloat = New DevExpress.Utils.PointFloat(214.0416!, 128.1527!)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBarangay.SizeF = New System.Drawing.SizeF(114.1059!, 13.01737!)
        Me.txtBarangay.StylePriority.UseFont = False
        Me.txtBarangay.StylePriority.UseForeColor = False
        Me.txtBarangay.StylePriority.UseTextAlignment = False
        Me.txtBarangay.Text = "STA. ISABLE"
        Me.txtBarangay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txtComelectid
        '
        Me.txtComelectid.Font = New System.Drawing.Font("Arial", 7.75!)
        Me.txtComelectid.ForeColor = System.Drawing.Color.Yellow
        Me.txtComelectid.KeepTogether = True
        Me.txtComelectid.LocationFloat = New DevExpress.Utils.PointFloat(47.39645!, 193.1528!)
        Me.txtComelectid.Name = "txtComelectid"
        Me.txtComelectid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtComelectid.SizeF = New System.Drawing.SizeF(241.4438!, 13.01735!)
        Me.txtComelectid.StylePriority.UseFont = False
        Me.txtComelectid.StylePriority.UseForeColor = False
        Me.txtComelectid.StylePriority.UseTextAlignment = False
        Me.txtComelectid.Text = "7202-216C-60490C8R100"
        Me.txtComelectid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'barcode
        '
        Me.barcode.AutoModule = True
        Me.barcode.LocationFloat = New DevExpress.Utils.PointFloat(88.01387!, 158.6979!)
        Me.barcode.Name = "barcode"
        Me.barcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.barcode.ShowText = False
        Me.barcode.SizeF = New System.Drawing.SizeF(160.61!, 31.4549!)
        Me.barcode.StylePriority.UseTextAlignment = False
        Me.barcode.Symbology = Code128Generator1
        Me.barcode.Text = "123456"
        Me.barcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'votersImage
        '
        Me.votersImage.LocationFloat = New DevExpress.Utils.PointFloat(9.000001!, 62.59367!)
        Me.votersImage.Name = "votersImage"
        Me.votersImage.SizeF = New System.Drawing.SizeF(73.84!, 87.0!)
        Me.votersImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'txtPrecint
        '
        Me.txtPrecint.CanGrow = False
        Me.txtPrecint.Font = New System.Drawing.Font("Arial", 7.5!)
        Me.txtPrecint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecint.KeepTogether = True
        Me.txtPrecint.LocationFloat = New DevExpress.Utils.PointFloat(214.0416!, 142.1701!)
        Me.txtPrecint.Name = "txtPrecint"
        Me.txtPrecint.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtPrecint.SizeF = New System.Drawing.SizeF(114.1059!, 13.01736!)
        Me.txtPrecint.StylePriority.UseFont = False
        Me.txtPrecint.StylePriority.UseForeColor = False
        Me.txtPrecint.StylePriority.UseTextAlignment = False
        Me.txtPrecint.Text = "002112"
        Me.txtPrecint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'logo
        '
        Me.logo.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.000003814697!)
        Me.logo.Name = "logo"
        Me.logo.SizeF = New System.Drawing.SizeF(341.5179!, 216.2348!)
        '
        'rptID
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 368, 0)
        Me.ShowPreviewMarginLines = False
        Me.ShowPrintMarginsWarning = False
        Me.Version = "18.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents txtFullname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBirthDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtArea As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtMunicipality As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtBarangay As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtComelectid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents barcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents votersImage As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents txtPrecint As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents logo As DevExpress.XtraReports.UI.XRPictureBox
End Class
