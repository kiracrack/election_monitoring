<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeStubReports
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
        Me.components = New System.ComponentModel.Container()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDifference = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtWatcher = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtClaim = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabClaimsCopy = New DevExpress.XtraTab.XtraTabPage()
        Me.tabWatchersCopy = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_watcher = New DevExpress.XtraGrid.GridControl()
        Me.gridWatcher = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabUnComplete = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Uncomplete = New DevExpress.XtraGrid.GridControl()
        Me.grid_uncomplete = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabCompleted = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Completed = New DevExpress.XtraGrid.GridControl()
        Me.grid_completed = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabClaimsCopy.SuspendLayout()
        Me.tabWatchersCopy.SuspendLayout()
        CType(Me.Em_watcher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUnComplete.SuspendLayout()
        CType(Me.Em_Uncomplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_uncomplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCompleted.SuspendLayout()
        CType(Me.Em_Completed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_completed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1082, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 575)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1082, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 555)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1082, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 555)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2})
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel2.FloatVertical = True
        Me.DockPanel2.ID = New System.Guid("82a81110-f37f-447d-9ce2-1c559d60453c")
        Me.DockPanel2.Location = New System.Drawing.Point(332, 22)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 188)
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.SavedSizeFactor = 1.0R
        Me.DockPanel2.Size = New System.Drawing.Size(706, 188)
        Me.DockPanel2.Text = "Filters"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(698, 161)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1076, 368)
        Me.Em.TabIndex = 325
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayFormatToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(154, 76)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "Display Format"
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
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ProgressBarControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1082, 555)
        Me.SplitContainerControl1.SplitterPosition = 18
        Me.SplitContainerControl1.TabIndex = 331
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1082, 555)
        Me.SplitContainerControl2.SplitterPosition = 150
        Me.SplitContainerControl2.TabIndex = 603
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(754, 75)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(181, 57)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Refresh Numbers"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(754, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(181, 57)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Scan QR Code Stub"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.txtDifference)
        Me.GroupControl3.Location = New System.Drawing.Point(512, 13)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(238, 119)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Difference"
        '
        'txtDifference
        '
        Me.txtDifference.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 41.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifference.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtDifference.Appearance.Options.UseFont = True
        Me.txtDifference.Appearance.Options.UseForeColor = True
        Me.txtDifference.Appearance.Options.UseTextOptions = True
        Me.txtDifference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDifference.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtDifference.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDifference.Location = New System.Drawing.Point(2, 28)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.Size = New System.Drawing.Size(234, 89)
        Me.txtDifference.TabIndex = 1
        Me.txtDifference.Text = "100,000"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txtWatcher)
        Me.GroupControl2.Location = New System.Drawing.Point(268, 13)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(238, 119)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Total Watcher's Copy"
        '
        'txtWatcher
        '
        Me.txtWatcher.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 41.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWatcher.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWatcher.Appearance.Options.UseFont = True
        Me.txtWatcher.Appearance.Options.UseForeColor = True
        Me.txtWatcher.Appearance.Options.UseTextOptions = True
        Me.txtWatcher.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtWatcher.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtWatcher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWatcher.Location = New System.Drawing.Point(2, 28)
        Me.txtWatcher.Name = "txtWatcher"
        Me.txtWatcher.Size = New System.Drawing.Size(234, 89)
        Me.txtWatcher.TabIndex = 1
        Me.txtWatcher.Text = "100,000"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txtClaim)
        Me.GroupControl1.Location = New System.Drawing.Point(24, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(238, 119)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Total Claim's Copy"
        '
        'txtClaim
        '
        Me.txtClaim.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 41.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaim.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtClaim.Appearance.Options.UseFont = True
        Me.txtClaim.Appearance.Options.UseForeColor = True
        Me.txtClaim.Appearance.Options.UseTextOptions = True
        Me.txtClaim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtClaim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtClaim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClaim.Location = New System.Drawing.Point(2, 28)
        Me.txtClaim.Name = "txtClaim"
        Me.txtClaim.Size = New System.Drawing.Size(234, 89)
        Me.txtClaim.TabIndex = 0
        Me.txtClaim.Text = "100,000"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabClaimsCopy
        Me.XtraTabControl1.Size = New System.Drawing.Size(1082, 400)
        Me.XtraTabControl1.TabIndex = 326
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabClaimsCopy, Me.tabWatchersCopy, Me.tabUnComplete, Me.tabCompleted})
        '
        'tabClaimsCopy
        '
        Me.tabClaimsCopy.Controls.Add(Me.Em)
        Me.tabClaimsCopy.Name = "tabClaimsCopy"
        Me.tabClaimsCopy.Size = New System.Drawing.Size(1076, 368)
        Me.tabClaimsCopy.Text = "Claim's Verification Report"
        '
        'tabWatchersCopy
        '
        Me.tabWatchersCopy.Controls.Add(Me.Em_watcher)
        Me.tabWatchersCopy.Name = "tabWatchersCopy"
        Me.tabWatchersCopy.Size = New System.Drawing.Size(1076, 368)
        Me.tabWatchersCopy.Text = "Watcher's Verification Report"
        '
        'Em_watcher
        '
        Me.Em_watcher.ContextMenuStrip = Me.gridmenustrip
        Me.Em_watcher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_watcher.Location = New System.Drawing.Point(0, 0)
        Me.Em_watcher.MainView = Me.gridWatcher
        Me.Em_watcher.Name = "Em_watcher"
        Me.Em_watcher.Size = New System.Drawing.Size(1076, 368)
        Me.Em_watcher.TabIndex = 326
        Me.Em_watcher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridWatcher})
        '
        'gridWatcher
        '
        Me.gridWatcher.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridWatcher.GridControl = Me.Em_watcher
        Me.gridWatcher.Name = "gridWatcher"
        Me.gridWatcher.OptionsBehavior.Editable = False
        Me.gridWatcher.OptionsSelection.MultiSelect = True
        Me.gridWatcher.OptionsSelection.UseIndicatorForSelection = False
        Me.gridWatcher.OptionsView.ColumnAutoWidth = False
        Me.gridWatcher.OptionsView.RowAutoHeight = True
        '
        'tabUnComplete
        '
        Me.tabUnComplete.Controls.Add(Me.Em_Uncomplete)
        Me.tabUnComplete.Name = "tabUnComplete"
        Me.tabUnComplete.Size = New System.Drawing.Size(1076, 368)
        Me.tabUnComplete.Text = "Uncomplete Verification Report"
        '
        'Em_Uncomplete
        '
        Me.Em_Uncomplete.ContextMenuStrip = Me.gridmenustrip
        Me.Em_Uncomplete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Uncomplete.Location = New System.Drawing.Point(0, 0)
        Me.Em_Uncomplete.MainView = Me.grid_uncomplete
        Me.Em_Uncomplete.Name = "Em_Uncomplete"
        Me.Em_Uncomplete.Size = New System.Drawing.Size(1076, 368)
        Me.Em_Uncomplete.TabIndex = 327
        Me.Em_Uncomplete.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_uncomplete})
        '
        'grid_uncomplete
        '
        Me.grid_uncomplete.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_uncomplete.GridControl = Me.Em_Uncomplete
        Me.grid_uncomplete.Name = "grid_uncomplete"
        Me.grid_uncomplete.OptionsBehavior.Editable = False
        Me.grid_uncomplete.OptionsSelection.MultiSelect = True
        Me.grid_uncomplete.OptionsSelection.UseIndicatorForSelection = False
        Me.grid_uncomplete.OptionsView.ColumnAutoWidth = False
        Me.grid_uncomplete.OptionsView.RowAutoHeight = True
        '
        'tabCompleted
        '
        Me.tabCompleted.Controls.Add(Me.Em_Completed)
        Me.tabCompleted.Name = "tabCompleted"
        Me.tabCompleted.Size = New System.Drawing.Size(1076, 368)
        Me.tabCompleted.Text = "Completed Verification Report"
        '
        'Em_Completed
        '
        Me.Em_Completed.ContextMenuStrip = Me.gridmenustrip
        Me.Em_Completed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Completed.Location = New System.Drawing.Point(0, 0)
        Me.Em_Completed.MainView = Me.grid_completed
        Me.Em_Completed.Name = "Em_Completed"
        Me.Em_Completed.Size = New System.Drawing.Size(1076, 368)
        Me.Em_Completed.TabIndex = 326
        Me.Em_Completed.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_completed})
        '
        'grid_completed
        '
        Me.grid_completed.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid_completed.GridControl = Me.Em_Completed
        Me.grid_completed.Name = "grid_completed"
        Me.grid_completed.OptionsBehavior.Editable = False
        Me.grid_completed.OptionsSelection.MultiSelect = True
        Me.grid_completed.OptionsSelection.UseIndicatorForSelection = False
        Me.grid_completed.OptionsView.ColumnAutoWidth = False
        Me.grid_completed.OptionsView.RowAutoHeight = True
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBarControl1.TabIndex = 3
        '
        'frmQRCodeStubReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 575)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmQRCodeStubReports"
        Me.Text = "QRCode Stub Reports"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabClaimsCopy.ResumeLayout(False)
        Me.tabWatchersCopy.ResumeLayout(False)
        CType(Me.Em_watcher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUnComplete.ResumeLayout(False)
        CType(Me.Em_Uncomplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_uncomplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCompleted.ResumeLayout(False)
        CType(Me.Em_Completed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_completed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtWatcher As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClaim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDifference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabClaimsCopy As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabWatchersCopy As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabUnComplete As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_watcher As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridWatcher As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_Uncomplete As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_uncomplete As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabCompleted As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_Completed As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_completed As DevExpress.XtraGrid.Views.Grid.GridView
End Class
