<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSGroupMessage
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
        Me.btnSendSMS = New DevExpress.XtraEditors.SimpleButton()
        Me.ls = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTemplate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridTemplate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtGroup = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Enabled = False
        Me.btnSendSMS.Location = New System.Drawing.Point(211, 367)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(323, 35)
        Me.btnSendSMS.TabIndex = 571
        Me.btnSendSMS.Text = "&Confirm Send"
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.ContextMenuStrip = Me.gridmenustrip
        Me.ls.HotTrackItems = True
        Me.ls.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ls.Location = New System.Drawing.Point(6, 52)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(199, 310)
        Me.ls.TabIndex = 618
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(182, 54)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__minus
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove from group"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh List"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(211, 8)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl15.TabIndex = 622
        Me.LabelControl15.Text = "Select from SMS Template"
        '
        'txtMessage
        '
        Me.txtMessage.EditValue = ""
        Me.txtMessage.Location = New System.Drawing.Point(211, 50)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(323, 312)
        Me.txtMessage.TabIndex = 623
        '
        'txtTemplate
        '
        Me.txtTemplate.EditValue = ""
        Me.txtTemplate.Location = New System.Drawing.Point(211, 27)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTemplate.Properties.DisplayMember = "Template"
        Me.txtTemplate.Properties.NullText = ""
        Me.txtTemplate.Properties.PopupView = Me.gridTemplate
        Me.txtTemplate.Properties.ValueMember = "Template"
        Me.txtTemplate.Size = New System.Drawing.Size(323, 20)
        Me.txtTemplate.TabIndex = 624
        '
        'gridTemplate
        '
        Me.gridTemplate.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridTemplate.Name = "gridTemplate"
        Me.gridTemplate.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridTemplate.OptionsView.ShowGroupPanel = False
        '
        'txtGroup
        '
        Me.txtGroup.EditValue = ""
        Me.txtGroup.Location = New System.Drawing.Point(6, 27)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGroup.Properties.DisplayMember = "Group"
        Me.txtGroup.Properties.NullText = ""
        Me.txtGroup.Properties.PopupView = Me.gridGroup
        Me.txtGroup.Properties.ValueMember = "Group"
        Me.txtGroup.Size = New System.Drawing.Size(199, 20)
        Me.txtGroup.TabIndex = 625
        '
        'gridGroup
        '
        Me.gridGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridGroup.Name = "gridGroup"
        Me.gridGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridGroup.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl1.TabIndex = 626
        Me.LabelControl1.Text = "Select from group settings"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(7, 365)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Select All"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 627
        '
        'frmSMSGroupMessage
        '
        Me.AcceptButton = Me.btnSendSMS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 407)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.btnSendSMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSGroupMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Message"
        Me.TopMost = True
        CType(Me.ls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendSMS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ls As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTemplate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridTemplate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGroup As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
