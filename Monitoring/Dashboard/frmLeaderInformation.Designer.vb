<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeaderInformation
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdChangeLeader = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.txtprecintno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVillage = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMunicipal = New DevExpress.XtraEditors.TextEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLeaders = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.votersid = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.vilcode = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HouseholdManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHouseholdMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListMemberListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferLeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeLeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.leaderoldid = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.leadercolor = New DevExpress.XtraEditors.TextEdit()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leaderoldid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.leadercolor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdAdd, Me.cmdChangeLeader, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdAdd, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdChangeLeader, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Done && Close"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Print Leader's Profile"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print Voter's Stub"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'cmdAdd
        '
        Me.cmdAdd.Caption = "Add Group Member"
        Me.cmdAdd.Id = 1
        Me.cmdAdd.Name = "cmdAdd"
        '
        'cmdChangeLeader
        '
        Me.cmdChangeLeader.Caption = "Change Leader"
        Me.cmdChangeLeader.Id = 2
        Me.cmdChangeLeader.Name = "cmdChangeLeader"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Clear"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(681, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 630)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(681, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 610)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(681, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 610)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel1.ID = New System.Guid("a2f3d2b3-12a4-4c36-b586-f5d7071998b8")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 121)
        Me.DockPanel1.SavedSizeFactor = 0R
        Me.DockPanel1.Size = New System.Drawing.Size(681, 121)
        Me.DockPanel1.Text = "Leader Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.txtprecintno)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.txtVillage)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.txtMunicipal)
        Me.DockPanel1_Container.Controls.Add(Me.txtArea)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.txtLeaders)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(673, 93)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'txtprecintno
        '
        Me.txtprecintno.EditValue = ""
        Me.txtprecintno.Location = New System.Drawing.Point(371, 59)
        Me.txtprecintno.Name = "txtprecintno"
        Me.txtprecintno.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprecintno.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprecintno.Properties.Appearance.Options.UseBackColor = True
        Me.txtprecintno.Properties.Appearance.Options.UseForeColor = True
        Me.txtprecintno.Properties.Appearance.Options.UseTextOptions = True
        Me.txtprecintno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtprecintno.Properties.ReadOnly = True
        Me.txtprecintno.Size = New System.Drawing.Size(144, 20)
        Me.txtprecintno.TabIndex = 570
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(303, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 571
        Me.LabelControl2.Text = "Precinct No."
        '
        'txtVillage
        '
        Me.txtVillage.EditValue = ""
        Me.txtVillage.Location = New System.Drawing.Point(371, 36)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVillage.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVillage.Properties.Appearance.Options.UseBackColor = True
        Me.txtVillage.Properties.Appearance.Options.UseForeColor = True
        Me.txtVillage.Properties.ReadOnly = True
        Me.txtVillage.Size = New System.Drawing.Size(144, 20)
        Me.txtVillage.TabIndex = 552
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(329, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 560
        Me.LabelControl1.Text = "Village"
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Location = New System.Drawing.Point(124, 59)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMunicipal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMunicipal.Properties.Appearance.Options.UseBackColor = True
        Me.txtMunicipal.Properties.Appearance.Options.UseForeColor = True
        Me.txtMunicipal.Properties.ReadOnly = True
        Me.txtMunicipal.Size = New System.Drawing.Size(152, 20)
        Me.txtMunicipal.TabIndex = 551
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.Location = New System.Drawing.Point(124, 36)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtArea.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtArea.Properties.Appearance.Options.UseBackColor = True
        Me.txtArea.Properties.Appearance.Options.UseForeColor = True
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(152, 20)
        Me.txtArea.TabIndex = 550
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(67, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl4.TabIndex = 558
        Me.LabelControl4.Text = "Municipal"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(48, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl5.TabIndex = 554
        Me.LabelControl5.Text = "Group Leader"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(95, 39)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 556
        Me.LabelControl3.Text = "Area"
        '
        'txtLeaders
        '
        Me.txtLeaders.EditValue = ""
        Me.txtLeaders.Location = New System.Drawing.Point(124, 12)
        Me.txtLeaders.Name = "txtLeaders"
        Me.txtLeaders.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaders.Properties.Appearance.Options.UseFont = True
        Me.txtLeaders.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLeaders.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtLeaders.Properties.ReadOnly = True
        Me.txtLeaders.Size = New System.Drawing.Size(391, 20)
        Me.txtLeaders.TabIndex = 566
        '
        'id
        '
        Me.id.EditValue = ""
        Me.id.Location = New System.Drawing.Point(20, 25)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.id.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.Properties.Appearance.Options.UseBackColor = True
        Me.id.Properties.Appearance.Options.UseForeColor = True
        Me.id.Properties.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(54, 20)
        Me.id.TabIndex = 566
        Me.id.Visible = False
        '
        'votersid
        '
        Me.votersid.Location = New System.Drawing.Point(117, 28)
        Me.votersid.Name = "votersid"
        Me.votersid.Size = New System.Drawing.Size(41, 13)
        Me.votersid.TabIndex = 555
        Me.votersid.Text = "votersid"
        Me.votersid.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(162, 28)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 557
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(252, 27)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 559
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'vilcode
        '
        Me.vilcode.Location = New System.Drawing.Point(213, 28)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Size = New System.Drawing.Size(36, 13)
        Me.vilcode.TabIndex = 561
        Me.vilcode.Text = "vilcode"
        Me.vilcode.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(681, 489)
        Me.Em.TabIndex = 564
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeColorToolStripMenuItem, Me.HouseholdManagementToolStripMenuItem, Me.cmdEdit, Me.TransferLeaderToolStripMenuItem, Me.MakeLeaderToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 142)
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._099
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'HouseholdManagementToolStripMenuItem
        '
        Me.HouseholdManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddHouseholdMemberToolStripMenuItem, Me.ViewListMemberListToolStripMenuItem})
        Me.HouseholdManagementToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user_share
        Me.HouseholdManagementToolStripMenuItem.Name = "HouseholdManagementToolStripMenuItem"
        Me.HouseholdManagementToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HouseholdManagementToolStripMenuItem.Text = "Household"
        '
        'AddHouseholdMemberToolStripMenuItem
        '
        Me.AddHouseholdMemberToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__plus
        Me.AddHouseholdMemberToolStripMenuItem.Name = "AddHouseholdMemberToolStripMenuItem"
        Me.AddHouseholdMemberToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddHouseholdMemberToolStripMenuItem.Text = "Add Member"
        '
        'ViewListMemberListToolStripMenuItem
        '
        Me.ViewListMemberListToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.notebook__arrow
        Me.ViewListMemberListToolStripMenuItem.Name = "ViewListMemberListToolStripMenuItem"
        Me.ViewListMemberListToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ViewListMemberListToolStripMenuItem.Text = "View List Member List"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Monitoring.My.Resources.Resources.user__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(164, 22)
        Me.cmdEdit.Text = "Edit Information"
        '
        'TransferLeaderToolStripMenuItem
        '
        Me.TransferLeaderToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__arrow
        Me.TransferLeaderToolStripMenuItem.Name = "TransferLeaderToolStripMenuItem"
        Me.TransferLeaderToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TransferLeaderToolStripMenuItem.Text = "Transfer Voters"
        '
        'MakeLeaderToolStripMenuItem
        '
        Me.MakeLeaderToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__minus
        Me.MakeLeaderToolStripMenuItem.Name = "MakeLeaderToolStripMenuItem"
        Me.MakeLeaderToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MakeLeaderToolStripMenuItem.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._127
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'leaderoldid
        '
        Me.leaderoldid.EditValue = ""
        Me.leaderoldid.Location = New System.Drawing.Point(319, 25)
        Me.leaderoldid.Name = "leaderoldid"
        Me.leaderoldid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.leaderoldid.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.leaderoldid.Properties.Appearance.Options.UseBackColor = True
        Me.leaderoldid.Properties.Appearance.Options.UseForeColor = True
        Me.leaderoldid.Properties.ReadOnly = True
        Me.leaderoldid.Size = New System.Drawing.Size(54, 20)
        Me.leaderoldid.TabIndex = 570
        Me.leaderoldid.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 141)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.leadercolor)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.id)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.leaderoldid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.vilcode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.areacode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.muncode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.votersid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ProgressBarControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(681, 489)
        Me.SplitContainerControl1.SplitterPosition = 19
        Me.SplitContainerControl1.TabIndex = 576
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'leadercolor
        '
        Me.leadercolor.EditValue = ""
        Me.leadercolor.Location = New System.Drawing.Point(379, 25)
        Me.leadercolor.Name = "leadercolor"
        Me.leadercolor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.leadercolor.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.leadercolor.Properties.Appearance.Options.UseBackColor = True
        Me.leadercolor.Properties.Appearance.Options.UseForeColor = True
        Me.leadercolor.Properties.ReadOnly = True
        Me.leadercolor.Size = New System.Drawing.Size(54, 20)
        Me.leadercolor.TabIndex = 571
        Me.leadercolor.Visible = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.MenuManager = Me.BarManager1
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'frmLeaderInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 630)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLeaderInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leader's Information"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leaderoldid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.leadercolor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents txtVillage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents votersid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vilcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MakeLeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdChangeLeader As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtprecintno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLeaders As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChangeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents leaderoldid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TransferLeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents leadercolor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents HouseholdManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHouseholdMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewListMemberListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
