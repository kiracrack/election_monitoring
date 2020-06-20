<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubMemberInfo
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
        Me.leaderid = New DevExpress.XtraEditors.TextEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeLeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.colorcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtprecintno = New DevExpress.XtraEditors.TextEdit()
        Me.muncode = New DevExpress.XtraEditors.TextEdit()
        Me.vilcode = New DevExpress.XtraEditors.TextEdit()
        Me.areacode = New DevExpress.XtraEditors.TextEdit()
        Me.subleaderid = New DevExpress.XtraEditors.TextEdit()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.leaderid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.colorcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.muncode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vilcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.areacode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subleaderid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leaderid
        '
        Me.leaderid.EditValue = ""
        Me.leaderid.Location = New System.Drawing.Point(319, 25)
        Me.leaderid.Name = "leaderid"
        Me.leaderid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.leaderid.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.leaderid.Properties.Appearance.Options.UseBackColor = True
        Me.leaderid.Properties.Appearance.Options.UseForeColor = True
        Me.leaderid.Properties.ReadOnly = True
        Me.leaderid.Size = New System.Drawing.Size(54, 20)
        Me.leaderid.TabIndex = 566
        Me.leaderid.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(631, 416)
        Me.Em.TabIndex = 564
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddMember, Me.ToolStripSeparator2, Me.ChangeColorToolStripMenuItem, Me.cmdEdit, Me.MakeLeaderToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(168, 148)
        '
        'cmdAddMember
        '
        Me.cmdAddMember.Image = Global.Monitoring.My.Resources.Resources.user__plus
        Me.cmdAddMember.Name = "cmdAddMember"
        Me.cmdAddMember.Size = New System.Drawing.Size(167, 22)
        Me.cmdAddMember.Text = "Add Sub Member"
        '
        'ChangeColorToolStripMenuItem
        '
        Me.ChangeColorToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._099
        Me.ChangeColorToolStripMenuItem.Name = "ChangeColorToolStripMenuItem"
        Me.ChangeColorToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ChangeColorToolStripMenuItem.Text = "Change Color"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.Monitoring.My.Resources.Resources.user__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Edit Information"
        '
        'MakeLeaderToolStripMenuItem
        '
        Me.MakeLeaderToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__minus
        Me.MakeLeaderToolStripMenuItem.Name = "MakeLeaderToolStripMenuItem"
        Me.MakeLeaderToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.MakeLeaderToolStripMenuItem.Text = "Remove Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._127
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.colorcode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtprecintno)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.muncode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.vilcode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.areacode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.subleaderid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.leaderid)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ProgressBarControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.SplitContainerControl1.Size = New System.Drawing.Size(631, 416)
        Me.SplitContainerControl1.SplitterPosition = 19
        Me.SplitContainerControl1.TabIndex = 576
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'colorcode
        '
        Me.colorcode.EditValue = ""
        Me.colorcode.Location = New System.Drawing.Point(319, 116)
        Me.colorcode.Name = "colorcode"
        Me.colorcode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colorcode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colorcode.Properties.Appearance.Options.UseBackColor = True
        Me.colorcode.Properties.Appearance.Options.UseForeColor = True
        Me.colorcode.Properties.ReadOnly = True
        Me.colorcode.Size = New System.Drawing.Size(54, 20)
        Me.colorcode.TabIndex = 576
        Me.colorcode.Visible = False
        '
        'txtprecintno
        '
        Me.txtprecintno.EditValue = ""
        Me.txtprecintno.Location = New System.Drawing.Point(379, 99)
        Me.txtprecintno.Name = "txtprecintno"
        Me.txtprecintno.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtprecintno.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtprecintno.Properties.Appearance.Options.UseBackColor = True
        Me.txtprecintno.Properties.Appearance.Options.UseForeColor = True
        Me.txtprecintno.Properties.ReadOnly = True
        Me.txtprecintno.Size = New System.Drawing.Size(54, 20)
        Me.txtprecintno.TabIndex = 575
        Me.txtprecintno.Visible = False
        '
        'muncode
        '
        Me.muncode.EditValue = ""
        Me.muncode.Location = New System.Drawing.Point(319, 90)
        Me.muncode.Name = "muncode"
        Me.muncode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.muncode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.muncode.Properties.Appearance.Options.UseBackColor = True
        Me.muncode.Properties.Appearance.Options.UseForeColor = True
        Me.muncode.Properties.ReadOnly = True
        Me.muncode.Size = New System.Drawing.Size(54, 20)
        Me.muncode.TabIndex = 574
        Me.muncode.Visible = False
        '
        'vilcode
        '
        Me.vilcode.EditValue = ""
        Me.vilcode.Location = New System.Drawing.Point(379, 64)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.vilcode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vilcode.Properties.Appearance.Options.UseBackColor = True
        Me.vilcode.Properties.Appearance.Options.UseForeColor = True
        Me.vilcode.Properties.ReadOnly = True
        Me.vilcode.Size = New System.Drawing.Size(54, 20)
        Me.vilcode.TabIndex = 573
        Me.vilcode.Visible = False
        '
        'areacode
        '
        Me.areacode.EditValue = ""
        Me.areacode.Location = New System.Drawing.Point(319, 64)
        Me.areacode.Name = "areacode"
        Me.areacode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.areacode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.areacode.Properties.Appearance.Options.UseBackColor = True
        Me.areacode.Properties.Appearance.Options.UseForeColor = True
        Me.areacode.Properties.ReadOnly = True
        Me.areacode.Size = New System.Drawing.Size(54, 20)
        Me.areacode.TabIndex = 572
        Me.areacode.Visible = False
        '
        'subleaderid
        '
        Me.subleaderid.EditValue = ""
        Me.subleaderid.Location = New System.Drawing.Point(379, 25)
        Me.subleaderid.Name = "subleaderid"
        Me.subleaderid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.subleaderid.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.subleaderid.Properties.Appearance.Options.UseBackColor = True
        Me.subleaderid.Properties.Appearance.Options.UseForeColor = True
        Me.subleaderid.Properties.ReadOnly = True
        Me.subleaderid.Size = New System.Drawing.Size(54, 20)
        Me.subleaderid.TabIndex = 571
        Me.subleaderid.Visible = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(0, 0)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(164, 6)
        '
        'frmSubMemberInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 416)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSubMemberInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member List"
        CType(Me.leaderid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.colorcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.muncode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vilcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.areacode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subleaderid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents leaderid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MakeLeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents subleaderid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAddMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents muncode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vilcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents areacode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtprecintno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colorcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
