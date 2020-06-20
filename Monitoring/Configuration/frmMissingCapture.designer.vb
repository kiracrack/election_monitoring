<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMissingCapture
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
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.vilcode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecinct = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckallPrecinct = New DevExpress.XtraEditors.CheckEdit()
        Me.txtresult = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVillage = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVillage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ckrandom = New DevExpress.XtraEditors.CheckEdit()
        Me.ckAllBrgy = New DevExpress.XtraEditors.CheckEdit()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecinct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckallPrecinct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtresult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckrandom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAllBrgy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(472, 69)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 548
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 547
        Me.LabelControl4.Text = "Select Municipal"
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(472, 46)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 546
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(35, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 545
        Me.LabelControl3.Text = "Select Area"
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.EnterMoveNextControl = True
        Me.txtMunicipal.Location = New System.Drawing.Point(97, 77)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(361, 20)
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
        Me.txtArea.Location = New System.Drawing.Point(97, 53)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Select List"
        Me.txtArea.Size = New System.Drawing.Size(361, 20)
        Me.txtArea.TabIndex = 0
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(329, 159)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(130, 30)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Filter"
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
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
        Me.BarButtonItem1.Caption = "Clear Filter"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(470, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 496)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(470, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 476)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(470, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 476)
        '
        'vilcode
        '
        Me.vilcode.Location = New System.Drawing.Point(472, 91)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Size = New System.Drawing.Size(36, 13)
        Me.vilcode.TabIndex = 549
        Me.vilcode.Text = "vilcode"
        Me.vilcode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.Location = New System.Drawing.Point(51, 128)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 551
        Me.LabelControl2.Text = "Precinct"
        '
        'txtPrecinct
        '
        Me.txtPrecinct.EditValue = ""
        Me.txtPrecinct.Location = New System.Drawing.Point(97, 125)
        Me.txtPrecinct.Name = "txtPrecinct"
        Me.txtPrecinct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPrecinct.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecinct.Properties.PopupSizeable = True
        Me.txtPrecinct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtPrecinct.Size = New System.Drawing.Size(278, 20)
        Me.txtPrecinct.TabIndex = 3
        '
        'ckallPrecinct
        '
        Me.ckallPrecinct.Location = New System.Drawing.Point(381, 126)
        Me.ckallPrecinct.MenuManager = Me.BarManager1
        Me.ckallPrecinct.Name = "ckallPrecinct"
        Me.ckallPrecinct.Properties.Caption = "All Precinct"
        Me.ckallPrecinct.Size = New System.Drawing.Size(80, 19)
        Me.ckallPrecinct.TabIndex = 4
        '
        'txtresult
        '
        Me.txtresult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtresult.EditValue = ""
        Me.txtresult.Location = New System.Drawing.Point(12, 198)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtresult.Size = New System.Drawing.Size(446, 286)
        Me.txtresult.TabIndex = 553
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl5.Location = New System.Drawing.Point(12, 179)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl5.TabIndex = 554
        Me.LabelControl5.Text = "Result Query"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 560
        Me.LabelControl1.Text = "Select Village"
        '
        'txtVillage
        '
        Me.txtVillage.EditValue = ""
        Me.txtVillage.EnterMoveNextControl = True
        Me.txtVillage.Location = New System.Drawing.Point(97, 101)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVillage.Properties.DisplayMember = "Select List"
        Me.txtVillage.Properties.NullText = ""
        Me.txtVillage.Properties.PopupView = Me.gridVillage
        Me.txtVillage.Properties.ValueMember = "Select List"
        Me.txtVillage.Size = New System.Drawing.Size(278, 20)
        Me.txtVillage.TabIndex = 2
        '
        'gridVillage
        '
        Me.gridVillage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVillage.Name = "gridVillage"
        Me.gridVillage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVillage.OptionsView.ShowGroupPanel = False
        '
        'ckrandom
        '
        Me.ckrandom.Location = New System.Drawing.Point(95, 28)
        Me.ckrandom.MenuManager = Me.BarManager1
        Me.ckrandom.Name = "ckrandom"
        Me.ckrandom.Properties.Caption = "Random Precinct Filter (use for small population only like municipality)"
        Me.ckrandom.Size = New System.Drawing.Size(366, 19)
        Me.ckrandom.TabIndex = 565
        '
        'ckAllBrgy
        '
        Me.ckAllBrgy.Location = New System.Drawing.Point(381, 103)
        Me.ckAllBrgy.MenuManager = Me.BarManager1
        Me.ckAllBrgy.Name = "ckAllBrgy"
        Me.ckAllBrgy.Properties.Caption = "All Village"
        Me.ckAllBrgy.Size = New System.Drawing.Size(80, 19)
        Me.ckAllBrgy.TabIndex = 570
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'frmMissingCapture
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 496)
        Me.Controls.Add(Me.ckAllBrgy)
        Me.Controls.Add(Me.ckrandom)
        Me.Controls.Add(Me.txtVillage)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ckallPrecinct)
        Me.Controls.Add(Me.vilcode)
        Me.Controls.Add(Me.txtPrecinct)
        Me.Controls.Add(Me.muncode)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.areacode)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.txtMunicipal)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(486, 534)
        Me.Name = "frmMissingCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Missing Capture"
        Me.TopMost = True
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecinct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckallPrecinct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtresult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckrandom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAllBrgy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckallPrecinct As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vilcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecinct As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtresult As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVillage As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVillage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ckrandom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckAllBrgy As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
