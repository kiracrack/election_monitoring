<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSView
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
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AssignLeadersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplyToSenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsReadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBoxSelect = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClosedAccount = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnholdTransaction = New System.Windows.Forms.ToolStripButton()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 32)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(1051, 503)
        Me.Em.TabIndex = 326
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignLeadersToolStripMenuItem, Me.ReplyToSenderToolStripMenuItem, Me.RemoveSelectedToolStripMenuItem, Me.MarkAsReadToolStripMenuItem, Me.RegisterNumberToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(164, 142)
        '
        'AssignLeadersToolStripMenuItem
        '
        Me.AssignLeadersToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.mail_open
        Me.AssignLeadersToolStripMenuItem.Name = "AssignLeadersToolStripMenuItem"
        Me.AssignLeadersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AssignLeadersToolStripMenuItem.Text = "Open Message"
        '
        'ReplyToSenderToolStripMenuItem
        '
        Me.ReplyToSenderToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.mail_reply
        Me.ReplyToSenderToolStripMenuItem.Name = "ReplyToSenderToolStripMenuItem"
        Me.ReplyToSenderToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ReplyToSenderToolStripMenuItem.Text = "Reply to Sender"
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.mail__minus
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Delete Message"
        '
        'MarkAsReadToolStripMenuItem
        '
        Me.MarkAsReadToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.mails_stack
        Me.MarkAsReadToolStripMenuItem.Name = "MarkAsReadToolStripMenuItem"
        Me.MarkAsReadToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MarkAsReadToolStripMenuItem.Text = "Mark As Read"
        '
        'RegisterNumberToolStripMenuItem
        '
        Me.RegisterNumberToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.user__plus1
        Me.RegisterNumberToolStripMenuItem.Name = "RegisterNumberToolStripMenuItem"
        Me.RegisterNumberToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RegisterNumberToolStripMenuItem.Text = "Register Number"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources.arrow_continue_090_left
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh List"
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.Monitoring.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator5, Me.txtBoxSelect, Me.ToolStripSeparator4, Me.cmdClosedAccount, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator6, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.cmdOnholdTransaction})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1051, 32)
        Me.ToolStrip3.TabIndex = 331
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Monitoring.My.Resources.Resources.cross
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(45, 25)
        Me.ToolStripButton1.Text = "Exit"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 28)
        '
        'txtBoxSelect
        '
        Me.txtBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBoxSelect.Items.AddRange(New Object() {"INBOX", "SENT ITEMS", "DELETED"})
        Me.txtBoxSelect.Name = "txtBoxSelect"
        Me.txtBoxSelect.Size = New System.Drawing.Size(150, 28)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'cmdClosedAccount
        '
        Me.cmdClosedAccount.ForeColor = System.Drawing.Color.White
        Me.cmdClosedAccount.Image = Global.Monitoring.My.Resources.Resources.mail__arrow
        Me.cmdClosedAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClosedAccount.Name = "cmdClosedAccount"
        Me.cmdClosedAccount.Size = New System.Drawing.Size(100, 25)
        Me.cmdClosedAccount.Text = "New Message"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.Monitoring.My.Resources.Resources.mails
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 25)
        Me.ToolStripButton2.Text = "Group Message"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = Global.Monitoring.My.Resources.Resources.users
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(105, 25)
        Me.ToolStripButton4.Text = "Group Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'cmdOnholdTransaction
        '
        Me.cmdOnholdTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdOnholdTransaction.Image = Global.Monitoring.My.Resources.Resources.mail_open_image
        Me.cmdOnholdTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOnholdTransaction.Name = "cmdOnholdTransaction"
        Me.cmdOnholdTransaction.Size = New System.Drawing.Size(125, 25)
        Me.cmdOnholdTransaction.Text = "Message Template"
        '
        'frmSMSView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 535)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Name = "frmSMSView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS View List"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClosedAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdOnholdTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AssignLeadersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplyToSenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAsReadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBoxSelect As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RegisterNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
