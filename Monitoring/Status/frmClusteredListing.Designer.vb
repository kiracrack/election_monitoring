<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClusteredListing
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.panelOverall = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.ls = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVillage = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVillage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vilcode = New DevExpress.XtraEditors.LabelControl()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOverall.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelOverall})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Clear Filter"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print Report"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Display Sequence No."
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(911, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 575)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(911, 23)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(911, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 555)
        '
        'panelOverall
        '
        Me.panelOverall.Controls.Add(Me.DockPanel1_Container)
        Me.panelOverall.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.panelOverall.ID = New System.Guid("8346d6bf-13ea-41f4-bd32-62fa9c37a97c")
        Me.panelOverall.Location = New System.Drawing.Point(0, 20)
        Me.panelOverall.Name = "panelOverall"
        Me.panelOverall.OriginalSize = New System.Drawing.Size(263, 200)
        Me.panelOverall.SavedSizeFactor = 0.0R
        Me.panelOverall.Size = New System.Drawing.Size(263, 555)
        Me.panelOverall.Text = "Status Query  by Color"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.ls)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl14)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.txtVillage)
        Me.DockPanel1_Container.Controls.Add(Me.SimpleButton1)
        Me.DockPanel1_Container.Controls.Add(Me.txtMunicipal)
        Me.DockPanel1_Container.Controls.Add(Me.vilcode)
        Me.DockPanel1_Container.Controls.Add(Me.txtArea)
        Me.DockPanel1_Container.Controls.Add(Me.muncode)
        Me.DockPanel1_Container.Controls.Add(Me.areacode)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(254, 528)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.HotTrackItems = True
        Me.ls.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ls.Location = New System.Drawing.Point(15, 148)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(229, 176)
        Me.ls.TabIndex = 668
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 90)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl1.TabIndex = 671
        Me.LabelControl1.Text = "Select Village/Brgy"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(17, 48)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 670
        Me.LabelControl4.Text = "Select Municipal"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(19, 132)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl14.TabIndex = 656
        Me.LabelControl14.Text = "Select Clusters"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 669
        Me.LabelControl3.Text = "Select Area"
        '
        'txtVillage
        '
        Me.txtVillage.EditValue = ""
        Me.txtVillage.Location = New System.Drawing.Point(15, 106)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVillage.Properties.DisplayMember = "Select List"
        Me.txtVillage.Properties.NullText = ""
        Me.txtVillage.Properties.PopupView = Me.gridVillage
        Me.txtVillage.Properties.ValueMember = "Select List"
        Me.txtVillage.Size = New System.Drawing.Size(229, 20)
        Me.txtVillage.TabIndex = 668
        '
        'gridVillage
        '
        Me.gridVillage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVillage.Name = "gridVillage"
        Me.gridVillage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVillage.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(15, 328)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(229, 29)
        Me.SimpleButton1.TabIndex = 615
        Me.SimpleButton1.Text = "Filter Query"
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Location = New System.Drawing.Point(15, 64)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(229, 20)
        Me.txtMunicipal.TabIndex = 667
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'vilcode
        '
        Me.vilcode.Location = New System.Drawing.Point(114, 387)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Size = New System.Drawing.Size(36, 13)
        Me.vilcode.TabIndex = 566
        Me.vilcode.Text = "vilcode"
        Me.vilcode.Visible = False
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.Location = New System.Drawing.Point(15, 23)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Select List"
        Me.txtArea.Size = New System.Drawing.Size(229, 20)
        Me.txtArea.TabIndex = 666
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(66, 387)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 565
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(15, 387)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 564
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(648, 555)
        Me.Em.TabIndex = 654
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(263, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ProgressBarControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(648, 555)
        Me.SplitContainerControl1.SplitterPosition = 21
        Me.SplitContainerControl1.TabIndex = 660
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBarControl1.TabIndex = 4
        '
        'frmClusteredListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 598)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.panelOverall)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmClusteredListing"
        Me.Text = "Clustered Voters Listing"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOverall.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents panelOverall As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vilcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVillage As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVillage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ls As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
End Class
