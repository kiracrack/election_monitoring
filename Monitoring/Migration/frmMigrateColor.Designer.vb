<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMigrateColor
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
        Me.cmdCapture = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcolorMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcolorMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clientcolorcode = New DevExpress.XtraEditors.LabelControl()
        Me.servercolorcode = New DevExpress.XtraEditors.LabelControl()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.databasename = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcolor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcolor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtcolorMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcolorMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcolor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCapture
        '
        Me.cmdCapture.Location = New System.Drawing.Point(98, 85)
        Me.cmdCapture.Name = "cmdCapture"
        Me.cmdCapture.Size = New System.Drawing.Size(196, 27)
        Me.cmdCapture.TabIndex = 651
        Me.cmdCapture.Text = "Confirm Save"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(30, 41)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl14.TabIndex = 653
        Me.LabelControl14.Text = "Select Color"
        '
        'txtcolorMunicipal
        '
        Me.txtcolorMunicipal.EditValue = ""
        Me.txtcolorMunicipal.Location = New System.Drawing.Point(98, 38)
        Me.txtcolorMunicipal.Name = "txtcolorMunicipal"
        Me.txtcolorMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcolorMunicipal.Properties.DisplayMember = "Description"
        Me.txtcolorMunicipal.Properties.NullText = ""
        Me.txtcolorMunicipal.Properties.PopupView = Me.gridcolorMunicipal
        Me.txtcolorMunicipal.Properties.ValueMember = "Description"
        Me.txtcolorMunicipal.Size = New System.Drawing.Size(196, 20)
        Me.txtcolorMunicipal.TabIndex = 652
        '
        'gridcolorMunicipal
        '
        Me.gridcolorMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcolorMunicipal.Name = "gridcolorMunicipal"
        Me.gridcolorMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcolorMunicipal.OptionsView.ShowGroupPanel = False
        '
        'clientcolorcode
        '
        Me.clientcolorcode.Location = New System.Drawing.Point(300, 40)
        Me.clientcolorcode.Name = "clientcolorcode"
        Me.clientcolorcode.Size = New System.Drawing.Size(79, 13)
        Me.clientcolorcode.TabIndex = 656
        Me.clientcolorcode.Text = "clientcolorcode"
        Me.clientcolorcode.Visible = False
        '
        'servercolorcode
        '
        Me.servercolorcode.Location = New System.Drawing.Point(300, 64)
        Me.servercolorcode.Name = "servercolorcode"
        Me.servercolorcode.Size = New System.Drawing.Size(79, 13)
        Me.servercolorcode.TabIndex = 657
        Me.servercolorcode.Text = "clientcolorcode"
        Me.servercolorcode.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Location = New System.Drawing.Point(5, 125)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(630, 242)
        Me.Em.TabIndex = 658
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveItemToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 54)
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
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._127
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Location = New System.Drawing.Point(98, 14)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(304, 20)
        Me.txtMunicipal.TabIndex = 659
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 660
        Me.LabelControl4.Text = "Select Municipal"
        '
        'databasename
        '
        Me.databasename.Location = New System.Drawing.Point(379, 42)
        Me.databasename.Name = "databasename"
        Me.databasename.Size = New System.Drawing.Size(75, 13)
        Me.databasename.TabIndex = 661
        Me.databasename.Text = "databasename"
        Me.databasename.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 663
        Me.LabelControl1.Text = "Migrate as"
        '
        'txtcolor
        '
        Me.txtcolor.EditValue = ""
        Me.txtcolor.Location = New System.Drawing.Point(98, 61)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcolor.Properties.DisplayMember = "Description"
        Me.txtcolor.Properties.NullText = ""
        Me.txtcolor.Properties.PopupView = Me.gridcolor
        Me.txtcolor.Properties.ValueMember = "Description"
        Me.txtcolor.Size = New System.Drawing.Size(196, 20)
        Me.txtcolor.TabIndex = 662
        '
        'gridcolor
        '
        Me.gridcolor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcolor.Name = "gridcolor"
        Me.gridcolor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcolor.OptionsView.ShowGroupPanel = False
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(512, 41)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 665
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(461, 41)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 664
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(569, 92)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 20)
        Me.mode.TabIndex = 666
        Me.mode.Visible = False
        '
        'frmMigrateColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 372)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.muncode)
        Me.Controls.Add(Me.areacode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.txtMunicipal)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.databasename)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.servercolorcode)
        Me.Controls.Add(Me.clientcolorcode)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtcolorMunicipal)
        Me.Controls.Add(Me.cmdCapture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMigrateColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Migration Tool"
        CType(Me.txtcolorMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcolorMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcolor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCapture As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcolorMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcolorMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clientcolorcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents servercolorcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents databasename As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcolor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcolor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
