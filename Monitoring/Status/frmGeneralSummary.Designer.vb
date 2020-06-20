<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralSummary
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
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdFilter = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtnoVoters = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoLeaders = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtassignLeader = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtunassignleader = New DevExpress.XtraEditors.TextEdit()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Bm = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Cm = New DevExpress.XtraGrid.GridControl()
        Me.gridcluster = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnoVoters.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoLeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtassignLeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtunassignleader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcluster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(30, 61)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 623
        Me.LabelControl4.Text = "Select Municipal"
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Location = New System.Drawing.Point(121, 58)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(354, 20)
        Me.txtMunicipal.TabIndex = 622
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(267, 182)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(208, 32)
        Me.cmdFilter.TabIndex = 621
        Me.cmdFilter.Text = "Filter Query"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl3.TabIndex = 620
        Me.LabelControl3.Text = "Select Area Location"
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.Location = New System.Drawing.Point(121, 34)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Select List"
        Me.txtArea.Size = New System.Drawing.Size(354, 20)
        Me.txtArea.TabIndex = 619
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True)})
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Summary"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Print Cluster Summary"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(915, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 605)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(915, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 585)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(915, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 585)
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(139, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(119, 13)
        Me.LabelControl7.TabIndex = 629
        Me.LabelControl7.Text = "Total Number of Voters"
        '
        'txtnoVoters
        '
        Me.txtnoVoters.EditValue = "0"
        Me.txtnoVoters.Location = New System.Drawing.Point(267, 84)
        Me.txtnoVoters.Name = "txtnoVoters"
        Me.txtnoVoters.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnoVoters.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnoVoters.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoVoters.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtnoVoters.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtnoVoters.Properties.ReadOnly = True
        Me.txtnoVoters.Size = New System.Drawing.Size(208, 20)
        Me.txtnoVoters.TabIndex = 628
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(147, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl1.TabIndex = 631
        Me.LabelControl1.Text = "Total Number Leaders"
        '
        'txtNoLeaders
        '
        Me.txtNoLeaders.EditValue = "0"
        Me.txtNoLeaders.Location = New System.Drawing.Point(267, 108)
        Me.txtNoLeaders.Name = "txtNoLeaders"
        Me.txtNoLeaders.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNoLeaders.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNoLeaders.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoLeaders.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtNoLeaders.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtNoLeaders.Properties.ReadOnly = True
        Me.txtNoLeaders.Size = New System.Drawing.Size(208, 20)
        Me.txtNoLeaders.TabIndex = 630
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 135)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(211, 13)
        Me.LabelControl2.TabIndex = 633
        Me.LabelControl2.Text = "Total Number of Voters Assigned Leaders"
        '
        'txtassignLeader
        '
        Me.txtassignLeader.EditValue = "0"
        Me.txtassignLeader.Location = New System.Drawing.Point(267, 132)
        Me.txtassignLeader.Name = "txtassignLeader"
        Me.txtassignLeader.Properties.Appearance.Options.UseTextOptions = True
        Me.txtassignLeader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtassignLeader.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtassignLeader.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtassignLeader.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtassignLeader.Properties.ReadOnly = True
        Me.txtassignLeader.Size = New System.Drawing.Size(208, 20)
        Me.txtassignLeader.TabIndex = 632
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(33, 159)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(225, 13)
        Me.LabelControl5.TabIndex = 635
        Me.LabelControl5.Text = "Total Number of Voters Unassigned Leaders"
        '
        'txtunassignleader
        '
        Me.txtunassignleader.EditValue = "0"
        Me.txtunassignleader.Location = New System.Drawing.Point(267, 156)
        Me.txtunassignleader.Name = "txtunassignleader"
        Me.txtunassignleader.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.txtunassignleader.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunassignleader.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtunassignleader.Properties.Appearance.Options.UseBackColor = True
        Me.txtunassignleader.Properties.Appearance.Options.UseFont = True
        Me.txtunassignleader.Properties.Appearance.Options.UseForeColor = True
        Me.txtunassignleader.Properties.Appearance.Options.UseTextOptions = True
        Me.txtunassignleader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtunassignleader.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtunassignleader.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtunassignleader.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtunassignleader.Properties.ReadOnly = True
        Me.txtunassignleader.Size = New System.Drawing.Size(208, 20)
        Me.txtunassignleader.TabIndex = 634
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(26, 91)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 642
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(26, 110)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 641
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(2, 20)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(461, 147)
        Me.Em.TabIndex = 647
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Bm
        '
        Me.Bm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bm.Location = New System.Drawing.Point(2, 20)
        Me.Bm.MainView = Me.GridView2
        Me.Bm.Name = "Bm"
        Me.Bm.Size = New System.Drawing.Size(461, 170)
        Me.Bm.TabIndex = 652
        Me.Bm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Bm
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Em)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 226)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(465, 169)
        Me.GroupControl1.TabIndex = 653
        Me.GroupControl1.Text = "Color Summary"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Bm)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 401)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(465, 192)
        Me.GroupControl2.TabIndex = 654
        Me.GroupControl2.Text = "Sector Summary"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Cm)
        Me.GroupControl3.Location = New System.Drawing.Point(485, 34)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(420, 559)
        Me.GroupControl3.TabIndex = 659
        Me.GroupControl3.Text = "Cluster"
        '
        'Cm
        '
        Me.Cm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cm.Location = New System.Drawing.Point(2, 20)
        Me.Cm.MainView = Me.gridcluster
        Me.Cm.Name = "Cm"
        Me.Cm.Size = New System.Drawing.Size(416, 537)
        Me.Cm.TabIndex = 647
        Me.Cm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridcluster})
        '
        'gridcluster
        '
        Me.gridcluster.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcluster.GridControl = Me.Cm
        Me.gridcluster.Name = "gridcluster"
        Me.gridcluster.OptionsBehavior.Editable = False
        Me.gridcluster.OptionsSelection.MultiSelect = True
        Me.gridcluster.OptionsSelection.UseIndicatorForSelection = False
        Me.gridcluster.OptionsView.RowAutoHeight = True
        Me.gridcluster.OptionsView.ShowGroupPanel = False
        '
        'frmGeneralSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 605)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.muncode)
        Me.Controls.Add(Me.areacode)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtunassignleader)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtassignLeader)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtNoLeaders)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtnoVoters)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtMunicipal)
        Me.Controls.Add(Me.cmdFilter)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGeneralSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Summary"
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnoVoters.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoLeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtassignLeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtunassignleader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcluster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtunassignleader As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtassignLeader As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoLeaders As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnoVoters As DevExpress.XtraEditors.TextEdit
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Bm As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Cm As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridcluster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
End Class
