<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportGenerator
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtpapertype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.rdoreintation = New DevExpress.XtraEditors.RadioGroup()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCustom = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txttitle = New DevExpress.XtraEditors.TextEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.lblstatus = New DevExpress.XtraBars.BarButtonItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReportTemplate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridOffice = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtquery = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txtpapertype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtCustom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtReportTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.txtpapertype)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl4)
        Me.DockPanel1_Container.Controls.Add(Me.CheckEdit1)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl3)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.txttitle)
        Me.DockPanel1_Container.Controls.Add(Me.cmdPrint)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(229, 497)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 257)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 626
        Me.LabelControl1.Text = "Paper Size"
        '
        'txtpapertype
        '
        Me.txtpapertype.EditValue = "Letter"
        Me.txtpapertype.Location = New System.Drawing.Point(69, 254)
        Me.txtpapertype.MenuManager = Me.BarManager1
        Me.txtpapertype.Name = "txtpapertype"
        Me.txtpapertype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtpapertype.Properties.Items.AddRange(New Object() {"Letter", "Legal"})
        Me.txtpapertype.Size = New System.Drawing.Size(150, 20)
        Me.txtpapertype.TabIndex = 612
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.rdoreintation)
        Me.GroupControl4.Location = New System.Drawing.Point(9, 173)
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
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(10, 148)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Enable Formating View"
        Me.CheckEdit1.Size = New System.Drawing.Size(209, 19)
        Me.CheckEdit1.TabIndex = 9
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
        Me.cmdPrint.Location = New System.Drawing.Point(69, 280)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(150, 29)
        Me.cmdPrint.TabIndex = 611
        Me.cmdPrint.Text = "Print Report"
        '
        'lblstatus
        '
        Me.lblstatus.Caption = "Ready"
        Me.lblstatus.Id = 5
        Me.lblstatus.Name = "lblstatus"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(657, 479)
        Me.Em.TabIndex = 3
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview1})
        '
        'gridview1
        '
        Me.gridview1.GridControl = Me.Em
        Me.gridview1.Name = "gridview1"
        Me.gridview1.OptionsBehavior.Editable = False
        Me.gridview1.OptionsView.ColumnAutoWidth = False
        Me.gridview1.OptionsView.RowAutoHeight = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(238, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtReportTemplate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl21)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtquery)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(657, 524)
        Me.SplitContainerControl1.SplitterPosition = 40
        Me.SplitContainerControl1.TabIndex = 9
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(495, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(124, 24)
        Me.SimpleButton1.TabIndex = 626
        Me.SimpleButton1.Text = "Generate"
        '
        'txtReportTemplate
        '
        Me.txtReportTemplate.EditValue = ""
        Me.txtReportTemplate.EnterMoveNextControl = True
        Me.txtReportTemplate.Location = New System.Drawing.Point(157, 10)
        Me.txtReportTemplate.Name = "txtReportTemplate"
        Me.txtReportTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReportTemplate.Properties.DisplayMember = "Report Template"
        Me.txtReportTemplate.Properties.NullText = ""
        Me.txtReportTemplate.Properties.PopupView = Me.GridOffice
        Me.txtReportTemplate.Properties.ValueMember = "Report Template"
        Me.txtReportTemplate.Size = New System.Drawing.Size(332, 20)
        Me.txtReportTemplate.TabIndex = 624
        '
        'GridOffice
        '
        Me.GridOffice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridOffice.Name = "GridOffice"
        Me.GridOffice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridOffice.OptionsView.ShowGroupPanel = False
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(17, 13)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl21.TabIndex = 625
        Me.LabelControl21.Text = "Select Report Template"
        '
        'txtquery
        '
        Me.txtquery.EnterMoveNextControl = True
        Me.txtquery.Location = New System.Drawing.Point(528, 14)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.Size = New System.Drawing.Size(51, 20)
        Me.txtquery.TabIndex = 611
        Me.txtquery.Visible = False
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(585, 14)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(51, 20)
        Me.id.TabIndex = 610
        Me.id.Visible = False
        '
        'frmReportGenerator
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
        Me.Name = "frmReportGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Generator"
        Me.TopMost = True
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.txtpapertype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.rdoreintation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txtCustom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtReportTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rdoreintation As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCustom As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtReportTemplate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridOffice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtquery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpapertype As DevExpress.XtraEditors.ComboBoxEdit
End Class
