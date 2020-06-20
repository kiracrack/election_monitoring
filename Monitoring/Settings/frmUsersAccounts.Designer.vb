<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersAccounts
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
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTeam = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtfullname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtuserid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdesignation = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.accsysid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtverify = New DevExpress.XtraEditors.TextEdit()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdChangepass = New DevExpress.XtraBars.BarButtonItem()
        Me.areacode = New DevExpress.XtraEditors.TextEdit()
        Me.muncode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTeam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuserid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accsysid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.areacode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.muncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 20)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.XtraScrollableControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(998, 555)
        Me.SplitContainerControl1.SplitterPosition = 323
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.muncode)
        Me.XtraScrollableControl1.Controls.Add(Me.areacode)
        Me.XtraScrollableControl1.Controls.Add(Me.txtArea)
        Me.XtraScrollableControl1.Controls.Add(Me.txtMunicipal)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl3)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl4)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTeam)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl2)
        Me.XtraScrollableControl1.Controls.Add(Me.SimpleButton1)
        Me.XtraScrollableControl1.Controls.Add(Me.txtfullname)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.txtuserid)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl16)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl17)
        Me.XtraScrollableControl1.Controls.Add(Me.txtdesignation)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl18)
        Me.XtraScrollableControl1.Controls.Add(Me.txtusername)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl19)
        Me.XtraScrollableControl1.Controls.Add(Me.accsysid)
        Me.XtraScrollableControl1.Controls.Add(Me.mode)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl11)
        Me.XtraScrollableControl1.Controls.Add(Me.txtpassword)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl29)
        Me.XtraScrollableControl1.Controls.Add(Me.txtverify)
        Me.XtraScrollableControl1.Controls.Add(Me.CheckBox1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(323, 555)
        Me.XtraScrollableControl1.TabIndex = 2
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(99, 225)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Properties.Appearance.Options.UseFont = True
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Code"
        Me.txtArea.Size = New System.Drawing.Size(191, 24)
        Me.txtArea.TabIndex = 629
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Enabled = False
        Me.txtMunicipal.Location = New System.Drawing.Point(99, 252)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipal.Properties.Appearance.Options.UseFont = True
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Code"
        Me.txtMunicipal.Size = New System.Drawing.Size(191, 24)
        Me.txtMunicipal.TabIndex = 630
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(65, 228)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 17)
        Me.LabelControl3.TabIndex = 631
        Me.LabelControl3.Text = "Area"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(36, 255)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl4.TabIndex = 632
        Me.LabelControl4.Text = "Municipal"
        '
        'txtTeam
        '
        Me.txtTeam.AllowDrop = True
        Me.txtTeam.EditValue = ""
        Me.txtTeam.EnterMoveNextControl = True
        Me.txtTeam.Location = New System.Drawing.Point(99, 172)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Properties.Appearance.Options.UseFont = True
        Me.txtTeam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTeam.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTeam.Properties.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H"})
        Me.txtTeam.Properties.MaxLength = 3
        Me.txtTeam.Properties.NullText = "UNIT CODE"
        Me.txtTeam.Properties.PopupSizeable = True
        Me.txtTeam.Properties.ValidateOnEnterKey = True
        Me.txtTeam.Size = New System.Drawing.Size(121, 24)
        Me.txtTeam.TabIndex = 611
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(60, 175)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 17)
        Me.LabelControl2.TabIndex = 610
        Me.LabelControl2.Text = "Team"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(99, 280)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 33)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Save Account"
        '
        'txtfullname
        '
        Me.txtfullname.EnterMoveNextControl = True
        Me.txtfullname.Location = New System.Drawing.Point(99, 37)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Properties.Appearance.Options.UseFont = True
        Me.txtfullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfullname.Size = New System.Drawing.Size(191, 24)
        Me.txtfullname.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(127, 528)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl1.TabIndex = 609
        '
        'txtuserid
        '
        Me.txtuserid.EnterMoveNextControl = True
        Me.txtuserid.Location = New System.Drawing.Point(99, 10)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Properties.Appearance.Options.UseFont = True
        Me.txtuserid.Properties.Appearance.Options.UseTextOptions = True
        Me.txtuserid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtuserid.Properties.ReadOnly = True
        Me.txtuserid.Size = New System.Drawing.Size(121, 24)
        Me.txtuserid.TabIndex = 381
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(33, 94)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(59, 17)
        Me.LabelControl16.TabIndex = 368
        Me.LabelControl16.Text = "Username"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(41, 41)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl17.TabIndex = 370
        Me.LabelControl17.Text = "Fullname"
        '
        'txtdesignation
        '
        Me.txtdesignation.AllowDrop = True
        Me.txtdesignation.EditValue = ""
        Me.txtdesignation.EnterMoveNextControl = True
        Me.txtdesignation.Location = New System.Drawing.Point(99, 64)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesignation.Properties.Appearance.Options.UseFont = True
        Me.txtdesignation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdesignation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesignation.Properties.PopupSizeable = True
        Me.txtdesignation.Properties.ValidateOnEnterKey = True
        Me.txtdesignation.Size = New System.Drawing.Size(191, 24)
        Me.txtdesignation.TabIndex = 2
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(36, 121)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl18.TabIndex = 372
        Me.LabelControl18.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(99, 91)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Properties.Appearance.Options.UseFont = True
        Me.txtusername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Size = New System.Drawing.Size(191, 24)
        Me.txtusername.TabIndex = 4
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(59, 148)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(33, 17)
        Me.LabelControl19.TabIndex = 374
        Me.LabelControl19.Text = "Verify"
        '
        'accsysid
        '
        Me.accsysid.EnterMoveNextControl = True
        Me.accsysid.Location = New System.Drawing.Point(146, 464)
        Me.accsysid.Name = "accsysid"
        Me.accsysid.Properties.Appearance.Options.UseTextOptions = True
        Me.accsysid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.accsysid.Properties.ReadOnly = True
        Me.accsysid.Size = New System.Drawing.Size(54, 20)
        Me.accsysid.TabIndex = 608
        Me.accsysid.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(86, 464)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(54, 20)
        Me.mode.TabIndex = 383
        Me.mode.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(23, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl11.TabIndex = 376
        Me.LabelControl11.Text = "Designation"
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = ""
        Me.txtpassword.EnterMoveNextControl = True
        Me.txtpassword.Location = New System.Drawing.Point(99, 118)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.UseSystemPasswordChar = True
        Me.txtpassword.Size = New System.Drawing.Size(191, 24)
        Me.txtpassword.TabIndex = 5
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Location = New System.Drawing.Point(49, 13)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(43, 17)
        Me.LabelControl29.TabIndex = 382
        Me.LabelControl29.Text = "User ID"
        '
        'txtverify
        '
        Me.txtverify.EditValue = ""
        Me.txtverify.EnterMoveNextControl = True
        Me.txtverify.Location = New System.Drawing.Point(99, 145)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtverify.Properties.Appearance.Options.UseFont = True
        Me.txtverify.Properties.UseSystemPasswordChar = True
        Me.txtverify.Size = New System.Drawing.Size(191, 24)
        Me.txtverify.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(99, 201)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 21)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Full Record Access "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(670, 555)
        Me.Em.TabIndex = 1
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator3, Me.RefreshToolStripMenuItem1})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(169, 98)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__pencil
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditToolStripMenuItem.Text = "Edit Account"
        '
        'RemoveItemToolStripMenuItem
        '
        Me.RemoveItemToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__minus1
        Me.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem"
        Me.RemoveItemToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RemoveItemToolStripMenuItem.Text = "Remove User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.lock__pencil
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = Global.Monitoring.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh Account"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.cmdChangepass, Me.cmdSave, Me.BarButtonItem4})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
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
        'cmdSave
        '
        Me.cmdSave.Caption = "Confirm && Save"
        Me.cmdSave.Id = 2
        Me.cmdSave.Name = "cmdSave"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Cancel"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(998, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 575)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(998, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(998, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 555)
        '
        'cmdChangepass
        '
        Me.cmdChangepass.Caption = "Change Password"
        Me.cmdChangepass.Enabled = False
        Me.cmdChangepass.Id = 1
        Me.cmdChangepass.Name = "cmdChangepass"
        '
        'areacode
        '
        Me.areacode.EnterMoveNextControl = True
        Me.areacode.Location = New System.Drawing.Point(86, 438)
        Me.areacode.Name = "areacode"
        Me.areacode.Properties.Appearance.Options.UseTextOptions = True
        Me.areacode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.areacode.Properties.ReadOnly = True
        Me.areacode.Size = New System.Drawing.Size(54, 20)
        Me.areacode.TabIndex = 633
        Me.areacode.Visible = False
        '
        'muncode
        '
        Me.muncode.EnterMoveNextControl = True
        Me.muncode.Location = New System.Drawing.Point(146, 438)
        Me.muncode.Name = "muncode"
        Me.muncode.Properties.Appearance.Options.UseTextOptions = True
        Me.muncode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.muncode.Properties.ReadOnly = True
        Me.muncode.Size = New System.Drawing.Size(54, 20)
        Me.muncode.TabIndex = 634
        Me.muncode.Visible = False
        '
        'frmUsersAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 575)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmUsersAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users Accounts"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTeam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuserid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accsysid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.areacode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.muncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents accsysid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuserid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtverify As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtfullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdesignation As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdChangepass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTeam As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents muncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents areacode As DevExpress.XtraEditors.TextEdit
End Class
