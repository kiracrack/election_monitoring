<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColorChange
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
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdClose = New DevExpress.XtraBars.BarButtonItem()
        Me.colorcode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcolor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridcolor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.colorname = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcolor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveItemToolStripMenuItem, Me.SetAsDefaultToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(165, 98)
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
        'SetAsDefaultToolStripMenuItem
        '
        Me.SetAsDefaultToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._099
        Me.SetAsDefaultToolStripMenuItem.Name = "SetAsDefaultToolStripMenuItem"
        Me.SetAsDefaultToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SetAsDefaultToolStripMenuItem.Text = "Set as Default"
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
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdClose})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(302, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 91)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(302, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 91)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(302, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 91)
        '
        'cmdClose
        '
        Me.cmdClose.Caption = "Close Window"
        Me.cmdClose.Id = 0
        Me.cmdClose.Name = "cmdClose"
        '
        'colorcode
        '
        Me.colorcode.Location = New System.Drawing.Point(295, 32)
        Me.colorcode.Name = "colorcode"
        Me.colorcode.Size = New System.Drawing.Size(51, 13)
        Me.colorcode.TabIndex = 573
        Me.colorcode.Text = "colorcode"
        Me.colorcode.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(11, 32)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl14.TabIndex = 572
        Me.LabelControl14.Text = "Select Color"
        '
        'txtcolor
        '
        Me.txtcolor.EditValue = ""
        Me.txtcolor.Location = New System.Drawing.Point(79, 29)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcolor.Properties.DisplayMember = "Description"
        Me.txtcolor.Properties.NullText = ""
        Me.txtcolor.Properties.PopupView = Me.gridcolor
        Me.txtcolor.Properties.ValueMember = "Description"
        Me.txtcolor.Size = New System.Drawing.Size(196, 20)
        Me.txtcolor.TabIndex = 570
        '
        'gridcolor
        '
        Me.gridcolor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridcolor.Name = "gridcolor"
        Me.gridcolor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridcolor.OptionsView.ShowGroupPanel = False
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(170, 54)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(105, 26)
        Me.cmdaction.TabIndex = 571
        Me.cmdaction.Text = "&Confirm"
        '
        'colorname
        '
        Me.colorname.Location = New System.Drawing.Point(16, 68)
        Me.colorname.Name = "colorname"
        Me.colorname.Size = New System.Drawing.Size(54, 13)
        Me.colorname.TabIndex = 578
        Me.colorname.Text = "colorname"
        Me.colorname.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 7.75!, System.Drawing.FontStyle.Italic)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(79, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(196, 12)
        Me.LabelControl1.TabIndex = 583
        Me.LabelControl1.Text = "Tip: Use Ctrl + C to shortcut Change Color"
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(36, 60)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(100, 22)
        Me.mode.TabIndex = 588
        Me.mode.Visible = False
        '
        'frmColorChange
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 91)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.colorcode)
        Me.Controls.Add(Me.colorname)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmColorChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Change"
        Me.TopMost = True
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcolor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcolor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents cmdClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SetAsDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcolor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridcolor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colorname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As System.Windows.Forms.TextBox
End Class
