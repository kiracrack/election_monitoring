<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuplicateManager
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
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdoreintation = New DevExpress.XtraEditors.RadioGroup()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCustom = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txttitle = New DevExpress.XtraEditors.TextEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.ls = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmddelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtCustom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose, Me.lblstatus})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdClose)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(895, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 544)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(895, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 524)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(895, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 524)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("71bb1809-9469-46e3-a0f5-c78c7c306499")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(238, 200)
        Me.DockPanel1.SavedSizeFactor = 0.0R
        Me.DockPanel1.Size = New System.Drawing.Size(238, 524)
        Me.DockPanel1.Text = "Report Settings"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl4)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl3)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.txttitle)
        Me.DockPanel1_Container.Controls.Add(Me.cmdPrint)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(229, 497)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdoreintation)
        Me.GroupControl4.Location = New System.Drawing.Point(9, 148)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(212, 75)
        Me.GroupControl4.TabIndex = 614
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
        Me.GroupControl3.Location = New System.Drawing.Point(9, 52)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(212, 90)
        Me.GroupControl3.TabIndex = 613
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
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 610
        Me.LabelControl2.Text = "Report Title"
        '
        'txttitle
        '
        Me.txttitle.EnterMoveNextControl = True
        Me.txttitle.Location = New System.Drawing.Point(9, 25)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(212, 20)
        Me.txttitle.TabIndex = 609
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(113, 229)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(106, 29)
        Me.cmdPrint.TabIndex = 611
        Me.cmdPrint.Text = "Print"
        '
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Location = New System.Drawing.Point(0, 119)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(651, 26)
        Me.cmdSearch.TabIndex = 532
        Me.cmdSearch.Text = "Execute Filter"
        '
        'ls
        '
        Me.ls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ls.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ls.Appearance.Options.UseFont = True
        Me.ls.CheckOnClick = True
        Me.ls.HorizontalScrollbar = True
        Me.ls.HotTrackItems = True
        Me.ls.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ls.Location = New System.Drawing.Point(0, 22)
        Me.ls.MultiColumn = True
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(651, 91)
        Me.ls.TabIndex = 616
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl4.TabIndex = 611
        Me.LabelControl4.Text = "Select Your Filter"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditSelectedToolStripMenuItem, Me.cmddelete, Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.DisplayFormatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 98)
        '
        'EditSelectedToolStripMenuItem
        '
        Me.EditSelectedToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.clipboard__pencil
        Me.EditSelectedToolStripMenuItem.Name = "EditSelectedToolStripMenuItem"
        Me.EditSelectedToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.EditSelectedToolStripMenuItem.Text = "Edit Information"
        '
        'cmddelete
        '
        Me.cmddelete.Image = Global.Monitoring.My.Resources.Resources.blog__minus
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(160, 22)
        Me.cmddelete.Text = "Delete Entry"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Monitoring.My.Resources.Resources._127
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "Refresh Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'DisplayFormatToolStripMenuItem
        '
        Me.DisplayFormatToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.edit
        Me.DisplayFormatToolStripMenuItem.Name = "DisplayFormatToolStripMenuItem"
        Me.DisplayFormatToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DisplayFormatToolStripMenuItem.Text = "Display Format"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(238, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ls)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdSearch)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ProgressBarControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(657, 524)
        Me.SplitContainerControl1.SplitterPosition = 17
        Me.SplitContainerControl1.TabIndex = 609
        Me.SplitContainerControl1.Text = "SplitContainerControl2"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(3, 155)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(651, 365)
        Me.Em.TabIndex = 325
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
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBarControl1.TabIndex = 2
        '
        'frmDuplicateManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 544)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDuplicateManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Manager"
        Me.TopMost = True
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lblstatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdoreintation As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCustom As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ls As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmddelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
End Class
