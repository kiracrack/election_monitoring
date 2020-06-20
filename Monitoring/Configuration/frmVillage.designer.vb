<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVillage
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.id = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdesc = New DevExpress.XtraEditors.MemoEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerLeft = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdoreintation = New DevExpress.XtraEditors.RadioGroup()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCustom = New DevExpress.XtraEditors.MemoEdit()
        Me.txttitle = New DevExpress.XtraEditors.TextEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerLeft.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtCustom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(19, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.mode)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(889, 662)
        Me.SplitContainerControl1.SplitterPosition = 398
        Me.SplitContainerControl1.TabIndex = 11
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.muncode)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.areacode)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtMunicipal)
        Me.PanelControl1.Controls.Add(Me.txtArea)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.cmdSave)
        Me.PanelControl1.Controls.Add(Me.id)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtdesc)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(398, 662)
        Me.PanelControl1.TabIndex = 391
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(378, 77)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(50, 13)
        Me.muncode.TabIndex = 548
        Me.muncode.Text = "CITYCODE"
        Me.muncode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(15, 75)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 547
        Me.LabelControl4.Text = "Select Municipal"
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(378, 55)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(57, 13)
        Me.areacode.TabIndex = 546
        Me.areacode.Text = "AREACODE"
        Me.areacode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(43, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 545
        Me.LabelControl3.Text = "Select Area"
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.EnterMoveNextControl = True
        Me.txtMunicipal.Location = New System.Drawing.Point(106, 71)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(268, 20)
        Me.txtMunicipal.TabIndex = 1
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.EnterMoveNextControl = True
        Me.txtArea.Location = New System.Drawing.Point(106, 48)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Select List"
        Me.txtArea.Size = New System.Drawing.Size(268, 20)
        Me.txtArea.TabIndex = 0
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(34, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 37)
        Me.LabelControl1.TabIndex = 390
        Me.LabelControl1.Text = "Village or Barangay"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(258, 135)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(116, 30)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(106, 25)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseTextOptions = True
        Me.id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.id.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.id.Properties.Mask.BeepOnError = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(268, 20)
        Me.id.TabIndex = 386
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(72, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl6.TabIndex = 389
        Me.LabelControl6.Text = "Code"
        '
        'txtdesc
        '
        Me.txtdesc.EditValue = ""
        Me.txtdesc.Location = New System.Drawing.Point(106, 95)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Size = New System.Drawing.Size(268, 35)
        Me.txtdesc.TabIndex = 2
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(246, 8)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 388
        Me.mode.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(486, 662)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 76)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.clipboard__pencil
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EditToolStripMenuItem.Text = "Edit Selected"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.clipboard__minus
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._1271
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.Name = "cmdClose"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Clear Fields"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(908, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 682)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(908, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 662)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(908, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 662)
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerLeft})
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'hideContainerLeft
        '
        Me.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerLeft.Controls.Add(Me.DockPanel1)
        Me.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.hideContainerLeft.Location = New System.Drawing.Point(0, 20)
        Me.hideContainerLeft.Name = "hideContainerLeft"
        Me.hideContainerLeft.Size = New System.Drawing.Size(19, 662)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("e6f2940f-fc28-431a-a2ce-34380f0460df")
        Me.DockPanel1.Location = New System.Drawing.Point(19, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(233, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.SavedSizeFactor = 1.0R
        Me.DockPanel1.Size = New System.Drawing.Size(233, 662)
        Me.DockPanel1.Text = "Report Settings"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl4)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl3)
        Me.DockPanel1_Container.Controls.Add(Me.txttitle)
        Me.DockPanel1_Container.Controls.Add(Me.cmdPrint)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel1_Container.Controls.Add(Me.SimpleButton1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(224, 635)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdoreintation)
        Me.GroupControl4.Location = New System.Drawing.Point(7, 147)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(212, 75)
        Me.GroupControl4.TabIndex = 603
        Me.GroupControl4.Text = "Orientation"
        '
        'rdoreintation
        '
        Me.rdoreintation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoreintation.EditValue = False
        Me.rdoreintation.Location = New System.Drawing.Point(2, 20)
        Me.rdoreintation.Name = "rdoreintation"
        Me.rdoreintation.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Portrait"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Landscape")})
        Me.rdoreintation.Size = New System.Drawing.Size(208, 53)
        Me.rdoreintation.TabIndex = 391
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtCustom)
        Me.GroupControl3.Location = New System.Drawing.Point(7, 51)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(212, 90)
        Me.GroupControl3.TabIndex = 602
        Me.GroupControl3.Text = "Custom Text"
        '
        'txtCustom
        '
        Me.txtCustom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustom.Location = New System.Drawing.Point(2, 20)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(208, 68)
        Me.txtCustom.TabIndex = 379
        '
        'txttitle
        '
        Me.txttitle.EnterMoveNextControl = True
        Me.txttitle.Location = New System.Drawing.Point(7, 24)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(210, 20)
        Me.txttitle.TabIndex = 598
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(67, 229)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(73, 29)
        Me.cmdPrint.TabIndex = 600
        Me.cmdPrint.Text = "Print"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(10, 5)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl7.TabIndex = 599
        Me.LabelControl7.Text = "Report Title"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(146, 229)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(71, 29)
        Me.SimpleButton1.TabIndex = 601
        Me.SimpleButton1.Text = "Cancel"
        '
        'frmVillage
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 682)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.hideContainerLeft)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVillage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Village or Barangay"
        Me.TopMost = True
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerLeft.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtCustom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtdesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdoreintation As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCustom As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txttitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents hideContainerLeft As DevExpress.XtraBars.Docking.AutoHideContainer
End Class
