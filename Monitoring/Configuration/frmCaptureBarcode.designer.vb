<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptureBarcode
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim QrCodeGenerator7 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim QrCodeGenerator8 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabClaimedCopy = New DevExpress.XtraTab.XtraTabPage()
        Me.claimedid = New DevExpress.XtraEditors.TextEdit()
        Me.txtCollector = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridCollectors = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.BarCodeControl1 = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtC_votersname = New DevExpress.XtraEditors.LabelControl()
        Me.txtCollectorsBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtC_Status = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.picC_Status = New DevExpress.XtraEditors.PictureEdit()
        Me.txtC_votersAddress = New DevExpress.XtraEditors.LabelControl()
        Me.txtC_recordNotFound = New DevExpress.XtraEditors.LabelControl()
        Me.txtCTitle = New DevExpress.XtraEditors.LabelControl()
        Me.tabWatchersCopy = New DevExpress.XtraTab.XtraTabPage()
        Me.watchersid = New DevExpress.XtraEditors.TextEdit()
        Me.txtWatchers = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridWatchersName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BarCodeControl2 = New DevExpress.XtraEditors.BarCodeControl()
        Me.txtw_fullname = New DevExpress.XtraEditors.LabelControl()
        Me.txtWatchersBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtw_status = New DevExpress.XtraEditors.LabelControl()
        Me.Em_watchers = New DevExpress.XtraGrid.GridControl()
        Me.gridWatchers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.picw_status = New DevExpress.XtraEditors.PictureEdit()
        Me.txtw_address = New DevExpress.XtraEditors.LabelControl()
        Me.txtw_recordnotfound = New DevExpress.XtraEditors.LabelControl()
        Me.txtw_title = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabClaimedCopy.SuspendLayout()
        CType(Me.claimedid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollector.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCollectors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollectorsBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWatchersCopy.SuspendLayout()
        CType(Me.watchersid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWatchers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridWatchersName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWatchersBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_watchers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridWatchers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picw_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(81, 213)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 15)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "SCAN QRCODE STUB"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabClaimedCopy
        Me.XtraTabControl1.Size = New System.Drawing.Size(836, 442)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabClaimedCopy, Me.tabWatchersCopy})
        '
        'tabClaimedCopy
        '
        Me.tabClaimedCopy.Controls.Add(Me.txtCTitle)
        Me.tabClaimedCopy.Controls.Add(Me.claimedid)
        Me.tabClaimedCopy.Controls.Add(Me.txtCollector)
        Me.tabClaimedCopy.Controls.Add(Me.LabelControl5)
        Me.tabClaimedCopy.Controls.Add(Me.BarCodeControl1)
        Me.tabClaimedCopy.Controls.Add(Me.txtC_votersname)
        Me.tabClaimedCopy.Controls.Add(Me.txtCollectorsBarcode)
        Me.tabClaimedCopy.Controls.Add(Me.LabelControl3)
        Me.tabClaimedCopy.Controls.Add(Me.txtC_Status)
        Me.tabClaimedCopy.Controls.Add(Me.Em)
        Me.tabClaimedCopy.Controls.Add(Me.picC_Status)
        Me.tabClaimedCopy.Controls.Add(Me.txtC_votersAddress)
        Me.tabClaimedCopy.Controls.Add(Me.txtC_recordNotFound)
        Me.tabClaimedCopy.Name = "tabClaimedCopy"
        Me.tabClaimedCopy.Size = New System.Drawing.Size(830, 410)
        Me.tabClaimedCopy.Text = "Claim's Stub Verification"
        '
        'claimedid
        '
        Me.claimedid.EnterMoveNextControl = True
        Me.claimedid.Location = New System.Drawing.Point(208, 364)
        Me.claimedid.Name = "claimedid"
        Me.claimedid.Properties.Appearance.Options.UseTextOptions = True
        Me.claimedid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.claimedid.Properties.ReadOnly = True
        Me.claimedid.Size = New System.Drawing.Size(54, 20)
        Me.claimedid.TabIndex = 630
        Me.claimedid.Visible = False
        '
        'txtCollector
        '
        Me.txtCollector.EditValue = ""
        Me.txtCollector.Location = New System.Drawing.Point(32, 180)
        Me.txtCollector.Name = "txtCollector"
        Me.txtCollector.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCollector.Properties.Appearance.Options.UseFont = True
        Me.txtCollector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCollector.Properties.DisplayMember = "Select"
        Me.txtCollector.Properties.NullText = ""
        Me.txtCollector.Properties.PopupView = Me.gridCollectors
        Me.txtCollector.Properties.ValueMember = "Code"
        Me.txtCollector.Size = New System.Drawing.Size(210, 26)
        Me.txtCollector.TabIndex = 628
        '
        'gridCollectors
        '
        Me.gridCollectors.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridCollectors.Name = "gridCollectors"
        Me.gridCollectors.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridCollectors.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(74, 164)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl5.TabIndex = 629
        Me.LabelControl5.Text = "Select Claimant Incharge"
        '
        'BarCodeControl1
        '
        Me.BarCodeControl1.AutoModule = True
        Me.BarCodeControl1.Location = New System.Drawing.Point(68, 24)
        Me.BarCodeControl1.Name = "BarCodeControl1"
        Me.BarCodeControl1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.BarCodeControl1.ShowText = False
        Me.BarCodeControl1.Size = New System.Drawing.Size(139, 129)
        QrCodeGenerator7.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.BarCodeControl1.Symbology = QrCodeGenerator7
        Me.BarCodeControl1.TabIndex = 598
        Me.BarCodeControl1.Text = "12345678"
        '
        'txtC_votersname
        '
        Me.txtC_votersname.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC_votersname.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtC_votersname.Appearance.Options.UseFont = True
        Me.txtC_votersname.Appearance.Options.UseForeColor = True
        Me.txtC_votersname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtC_votersname.Location = New System.Drawing.Point(346, 12)
        Me.txtC_votersname.Name = "txtC_votersname"
        Me.txtC_votersname.Size = New System.Drawing.Size(412, 19)
        Me.txtC_votersname.TabIndex = 592
        Me.txtC_votersname.Text = "WINTER S. BUGAHOD"
        Me.txtC_votersname.Visible = False
        '
        'txtCollectorsBarcode
        '
        Me.txtCollectorsBarcode.EditValue = ""
        Me.txtCollectorsBarcode.Enabled = False
        Me.txtCollectorsBarcode.EnterMoveNextControl = True
        Me.txtCollectorsBarcode.Location = New System.Drawing.Point(32, 230)
        Me.txtCollectorsBarcode.Name = "txtCollectorsBarcode"
        Me.txtCollectorsBarcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCollectorsBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtCollectorsBarcode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCollectorsBarcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCollectorsBarcode.Properties.UseSystemPasswordChar = True
        Me.txtCollectorsBarcode.Size = New System.Drawing.Size(210, 26)
        Me.txtCollectorsBarcode.TabIndex = 0
        '
        'txtC_Status
        '
        Me.txtC_Status.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC_Status.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtC_Status.Appearance.Options.UseFont = True
        Me.txtC_Status.Appearance.Options.UseForeColor = True
        Me.txtC_Status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtC_Status.Location = New System.Drawing.Point(346, 44)
        Me.txtC_Status.Name = "txtC_Status"
        Me.txtC_Status.Size = New System.Drawing.Size(412, 19)
        Me.txtC_Status.TabIndex = 597
        Me.txtC_Status.Text = "Status: Claimed"
        Me.txtC_Status.Visible = False
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(268, 77)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(562, 330)
        Me.Em.TabIndex = 594
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'picC_Status
        '
        Me.picC_Status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_error
        Me.picC_Status.Location = New System.Drawing.Point(268, 1)
        Me.picC_Status.Name = "picC_Status"
        Me.picC_Status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picC_Status.Properties.Appearance.Options.UseBackColor = True
        Me.picC_Status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picC_Status.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picC_Status.Size = New System.Drawing.Size(73, 70)
        Me.picC_Status.TabIndex = 593
        Me.picC_Status.Visible = False
        '
        'txtC_votersAddress
        '
        Me.txtC_votersAddress.Appearance.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.txtC_votersAddress.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtC_votersAddress.Appearance.Options.UseFont = True
        Me.txtC_votersAddress.Appearance.Options.UseForeColor = True
        Me.txtC_votersAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtC_votersAddress.Location = New System.Drawing.Point(346, 29)
        Me.txtC_votersAddress.Name = "txtC_votersAddress"
        Me.txtC_votersAddress.Size = New System.Drawing.Size(384, 19)
        Me.txtC_votersAddress.TabIndex = 595
        Me.txtC_votersAddress.Text = "Poblacion, Jose Dalman"
        Me.txtC_votersAddress.Visible = False
        '
        'txtC_recordNotFound
        '
        Me.txtC_recordNotFound.Appearance.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtC_recordNotFound.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtC_recordNotFound.Appearance.Options.UseFont = True
        Me.txtC_recordNotFound.Appearance.Options.UseForeColor = True
        Me.txtC_recordNotFound.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtC_recordNotFound.Location = New System.Drawing.Point(346, 22)
        Me.txtC_recordNotFound.Name = "txtC_recordNotFound"
        Me.txtC_recordNotFound.Size = New System.Drawing.Size(398, 34)
        Me.txtC_recordNotFound.TabIndex = 631
        Me.txtC_recordNotFound.Text = "RECORD NOT FOUND"
        Me.txtC_recordNotFound.Visible = False
        '
        'txtCTitle
        '
        Me.txtCTitle.Appearance.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtCTitle.Appearance.ForeColor = System.Drawing.Color.SlateGray
        Me.txtCTitle.Appearance.Options.UseFont = True
        Me.txtCTitle.Appearance.Options.UseForeColor = True
        Me.txtCTitle.Appearance.Options.UseTextOptions = True
        Me.txtCTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtCTitle.Location = New System.Drawing.Point(268, 22)
        Me.txtCTitle.Name = "txtCTitle"
        Me.txtCTitle.Size = New System.Drawing.Size(559, 34)
        Me.txtCTitle.TabIndex = 632
        Me.txtCTitle.Text = "SCAN QRCODE CLAIM'S STUB COPY TO START VERIFICATION"
        '
        'tabWatchersCopy
        '
        Me.tabWatchersCopy.Controls.Add(Me.txtw_title)
        Me.tabWatchersCopy.Controls.Add(Me.watchersid)
        Me.tabWatchersCopy.Controls.Add(Me.txtWatchers)
        Me.tabWatchersCopy.Controls.Add(Me.LabelControl1)
        Me.tabWatchersCopy.Controls.Add(Me.BarCodeControl2)
        Me.tabWatchersCopy.Controls.Add(Me.txtw_fullname)
        Me.tabWatchersCopy.Controls.Add(Me.txtWatchersBarcode)
        Me.tabWatchersCopy.Controls.Add(Me.LabelControl4)
        Me.tabWatchersCopy.Controls.Add(Me.txtw_status)
        Me.tabWatchersCopy.Controls.Add(Me.Em_watchers)
        Me.tabWatchersCopy.Controls.Add(Me.picw_status)
        Me.tabWatchersCopy.Controls.Add(Me.txtw_address)
        Me.tabWatchersCopy.Controls.Add(Me.txtw_recordnotfound)
        Me.tabWatchersCopy.Name = "tabWatchersCopy"
        Me.tabWatchersCopy.Size = New System.Drawing.Size(830, 410)
        Me.tabWatchersCopy.Text = "Watcher's Stub Verification"
        '
        'watchersid
        '
        Me.watchersid.EnterMoveNextControl = True
        Me.watchersid.Location = New System.Drawing.Point(208, 364)
        Me.watchersid.Name = "watchersid"
        Me.watchersid.Properties.Appearance.Options.UseTextOptions = True
        Me.watchersid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.watchersid.Properties.ReadOnly = True
        Me.watchersid.Size = New System.Drawing.Size(54, 20)
        Me.watchersid.TabIndex = 643
        Me.watchersid.Visible = False
        '
        'txtWatchers
        '
        Me.txtWatchers.EditValue = ""
        Me.txtWatchers.Location = New System.Drawing.Point(32, 180)
        Me.txtWatchers.Name = "txtWatchers"
        Me.txtWatchers.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtWatchers.Properties.Appearance.Options.UseFont = True
        Me.txtWatchers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtWatchers.Properties.DisplayMember = "Select"
        Me.txtWatchers.Properties.NullText = ""
        Me.txtWatchers.Properties.PopupView = Me.gridWatchersName
        Me.txtWatchers.Properties.ValueMember = "Code"
        Me.txtWatchers.Size = New System.Drawing.Size(210, 26)
        Me.txtWatchers.TabIndex = 641
        '
        'gridWatchersName
        '
        Me.gridWatchersName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridWatchersName.Name = "gridWatchersName"
        Me.gridWatchersName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridWatchersName.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(71, 164)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl1.TabIndex = 642
        Me.LabelControl1.Text = "Select Watcher's Incharge"
        '
        'BarCodeControl2
        '
        Me.BarCodeControl2.AutoModule = True
        Me.BarCodeControl2.Location = New System.Drawing.Point(68, 24)
        Me.BarCodeControl2.Name = "BarCodeControl2"
        Me.BarCodeControl2.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.BarCodeControl2.ShowText = False
        Me.BarCodeControl2.Size = New System.Drawing.Size(139, 129)
        QrCodeGenerator8.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
        Me.BarCodeControl2.Symbology = QrCodeGenerator8
        Me.BarCodeControl2.TabIndex = 640
        Me.BarCodeControl2.Text = "12345678"
        '
        'txtw_fullname
        '
        Me.txtw_fullname.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtw_fullname.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtw_fullname.Appearance.Options.UseFont = True
        Me.txtw_fullname.Appearance.Options.UseForeColor = True
        Me.txtw_fullname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtw_fullname.Location = New System.Drawing.Point(346, 12)
        Me.txtw_fullname.Name = "txtw_fullname"
        Me.txtw_fullname.Size = New System.Drawing.Size(412, 19)
        Me.txtw_fullname.TabIndex = 635
        Me.txtw_fullname.Text = "WINTER S. BUGAHOD"
        Me.txtw_fullname.Visible = False
        '
        'txtWatchersBarcode
        '
        Me.txtWatchersBarcode.EditValue = ""
        Me.txtWatchersBarcode.Enabled = False
        Me.txtWatchersBarcode.EnterMoveNextControl = True
        Me.txtWatchersBarcode.Location = New System.Drawing.Point(32, 230)
        Me.txtWatchersBarcode.Name = "txtWatchersBarcode"
        Me.txtWatchersBarcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtWatchersBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtWatchersBarcode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtWatchersBarcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtWatchersBarcode.Properties.UseSystemPasswordChar = True
        Me.txtWatchersBarcode.Size = New System.Drawing.Size(210, 26)
        Me.txtWatchersBarcode.TabIndex = 633
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(81, 213)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(113, 15)
        Me.LabelControl4.TabIndex = 634
        Me.LabelControl4.Text = "SCAN QRCODE STUB"
        '
        'txtw_status
        '
        Me.txtw_status.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtw_status.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtw_status.Appearance.Options.UseFont = True
        Me.txtw_status.Appearance.Options.UseForeColor = True
        Me.txtw_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtw_status.Location = New System.Drawing.Point(346, 44)
        Me.txtw_status.Name = "txtw_status"
        Me.txtw_status.Size = New System.Drawing.Size(412, 19)
        Me.txtw_status.TabIndex = 639
        Me.txtw_status.Text = "Status: Claimed"
        Me.txtw_status.Visible = False
        '
        'Em_watchers
        '
        Me.Em_watchers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em_watchers.Location = New System.Drawing.Point(268, 77)
        Me.Em_watchers.MainView = Me.gridWatchers
        Me.Em_watchers.Name = "Em_watchers"
        Me.Em_watchers.Size = New System.Drawing.Size(562, 330)
        Me.Em_watchers.TabIndex = 637
        Me.Em_watchers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridWatchers})
        '
        'gridWatchers
        '
        Me.gridWatchers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridWatchers.GridControl = Me.Em_watchers
        Me.gridWatchers.Name = "gridWatchers"
        Me.gridWatchers.OptionsBehavior.Editable = False
        Me.gridWatchers.OptionsSelection.MultiSelect = True
        Me.gridWatchers.OptionsSelection.UseIndicatorForSelection = False
        Me.gridWatchers.OptionsView.ColumnAutoWidth = False
        Me.gridWatchers.OptionsView.RowAutoHeight = True
        Me.gridWatchers.OptionsView.ShowGroupPanel = False
        '
        'picw_status
        '
        Me.picw_status.EditValue = Global.Monitoring.My.Resources.Resources.dialog_error
        Me.picw_status.Location = New System.Drawing.Point(268, 1)
        Me.picw_status.Name = "picw_status"
        Me.picw_status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picw_status.Properties.Appearance.Options.UseBackColor = True
        Me.picw_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picw_status.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.picw_status.Size = New System.Drawing.Size(73, 70)
        Me.picw_status.TabIndex = 636
        Me.picw_status.Visible = False
        '
        'txtw_address
        '
        Me.txtw_address.Appearance.Font = New System.Drawing.Font("Arial", 9.25!)
        Me.txtw_address.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtw_address.Appearance.Options.UseFont = True
        Me.txtw_address.Appearance.Options.UseForeColor = True
        Me.txtw_address.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtw_address.Location = New System.Drawing.Point(346, 29)
        Me.txtw_address.Name = "txtw_address"
        Me.txtw_address.Size = New System.Drawing.Size(384, 19)
        Me.txtw_address.TabIndex = 638
        Me.txtw_address.Text = "Poblacion, Jose Dalman"
        Me.txtw_address.Visible = False
        '
        'txtw_recordnotfound
        '
        Me.txtw_recordnotfound.Appearance.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtw_recordnotfound.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtw_recordnotfound.Appearance.Options.UseFont = True
        Me.txtw_recordnotfound.Appearance.Options.UseForeColor = True
        Me.txtw_recordnotfound.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtw_recordnotfound.Location = New System.Drawing.Point(346, 22)
        Me.txtw_recordnotfound.Name = "txtw_recordnotfound"
        Me.txtw_recordnotfound.Size = New System.Drawing.Size(398, 34)
        Me.txtw_recordnotfound.TabIndex = 644
        Me.txtw_recordnotfound.Text = "RECORD NOT FOUND"
        Me.txtw_recordnotfound.Visible = False
        '
        'txtw_title
        '
        Me.txtw_title.Appearance.Font = New System.Drawing.Font("Arial", 12.25!, System.Drawing.FontStyle.Bold)
        Me.txtw_title.Appearance.ForeColor = System.Drawing.Color.SlateGray
        Me.txtw_title.Appearance.Options.UseFont = True
        Me.txtw_title.Appearance.Options.UseForeColor = True
        Me.txtw_title.Appearance.Options.UseTextOptions = True
        Me.txtw_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtw_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtw_title.Location = New System.Drawing.Point(268, 22)
        Me.txtw_title.Name = "txtw_title"
        Me.txtw_title.Size = New System.Drawing.Size(559, 34)
        Me.txtw_title.TabIndex = 645
        Me.txtw_title.Text = "SCAN QRCODE WATCHER'S STUB COPY TO START VERIFICATION"
        '
        'frmCaptureBarcode
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 442)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.MinimumSize = New System.Drawing.Size(852, 481)
        Me.Name = "frmCaptureBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR Code Stub"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabClaimedCopy.ResumeLayout(False)
        Me.tabClaimedCopy.PerformLayout()
        CType(Me.claimedid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollector.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCollectors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollectorsBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWatchersCopy.ResumeLayout(False)
        Me.tabWatchersCopy.PerformLayout()
        CType(Me.watchersid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWatchers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridWatchersName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWatchersBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_watchers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridWatchers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picw_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabClaimedCopy As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabWatchersCopy As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtC_votersname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents picC_Status As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtC_votersAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtC_Status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarCodeControl1 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents txtCollector As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridCollectors As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents claimedid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtC_recordNotFound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCTitle As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCollectorsBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents watchersid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWatchers As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridWatchersName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarCodeControl2 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents txtw_fullname As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtWatchersBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtw_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em_watchers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridWatchers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents picw_status As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtw_address As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtw_recordnotfound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtw_title As DevExpress.XtraEditors.LabelControl
End Class
