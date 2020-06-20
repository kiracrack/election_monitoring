<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferVoters
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
        Me.txtLeaders = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridLeader = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.votersid = New DevExpress.XtraEditors.LabelControl()
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.vilcode = New DevExpress.XtraEditors.LabelControl()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.oldLeaderId = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.colorcode = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLeaders
        '
        Me.txtLeaders.EditValue = ""
        Me.txtLeaders.Location = New System.Drawing.Point(96, 72)
        Me.txtLeaders.Name = "txtLeaders"
        Me.txtLeaders.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaders.Properties.Appearance.Options.UseFont = True
        Me.txtLeaders.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLeaders.Properties.DisplayMember = "Select Leader"
        Me.txtLeaders.Properties.NullText = ""
        Me.txtLeaders.Properties.PopupView = Me.gridLeader
        Me.txtLeaders.Properties.ValueMember = "Select Leader"
        Me.txtLeaders.Size = New System.Drawing.Size(299, 20)
        Me.txtLeaders.TabIndex = 0
        '
        'gridLeader
        '
        Me.gridLeader.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLeader.Name = "gridLeader"
        Me.gridLeader.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLeader.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(33, 75)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 567
        Me.LabelControl5.Text = "Transfer to"
        '
        'votersid
        '
        Me.votersid.Location = New System.Drawing.Point(400, 75)
        Me.votersid.Name = "votersid"
        Me.votersid.Size = New System.Drawing.Size(41, 13)
        Me.votersid.TabIndex = 569
        Me.votersid.Text = "votersid"
        Me.votersid.Visible = False
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(140, 101)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(105, 30)
        Me.cmdadd.TabIndex = 1
        Me.cmdadd.Text = "&Confirm"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(95, 47)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(340, 13)
        Me.LabelControl8.TabIndex = 590
        Me.LabelControl8.Text = "This form allow's user to transfer selected voters to another leader"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(95, 25)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(198, 19)
        Me.LabelControl9.TabIndex = 589
        Me.LabelControl9.Text = "Transfer Voters Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(96, 53)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(298, 13)
        Me.LabelControl10.TabIndex = 588
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(251, 98)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(105, 30)
        Me.SimpleButton1.TabIndex = 593
        Me.SimpleButton1.Text = "C&ancel"
        '
        'vilcode
        '
        Me.vilcode.Location = New System.Drawing.Point(350, 341)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Size = New System.Drawing.Size(36, 13)
        Me.vilcode.TabIndex = 576
        Me.vilcode.Text = "vilcode"
        Me.vilcode.Visible = False
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(350, 319)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 575
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(350, 295)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 574
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'oldLeaderId
        '
        Me.oldLeaderId.Location = New System.Drawing.Point(350, 271)
        Me.oldLeaderId.Name = "oldLeaderId"
        Me.oldLeaderId.Size = New System.Drawing.Size(47, 13)
        Me.oldLeaderId.TabIndex = 573
        Me.oldLeaderId.Text = "currentid"
        Me.oldLeaderId.Visible = False
        '
        'mode
        '
        Me.mode.EditValue = ""
        Me.mode.Location = New System.Drawing.Point(202, 195)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mode.Properties.Appearance.Options.UseBackColor = True
        Me.mode.Properties.Appearance.Options.UseForeColor = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(54, 20)
        Me.mode.TabIndex = 594
        Me.mode.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.ContentImage = Global.Monitoring.My.Resources.Resources.system_switch_user_2
        Me.PanelControl2.Location = New System.Drawing.Point(23, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl2.TabIndex = 587
        '
        'colorcode
        '
        Me.colorcode.Location = New System.Drawing.Point(373, 118)
        Me.colorcode.Name = "colorcode"
        Me.colorcode.Size = New System.Drawing.Size(51, 13)
        Me.colorcode.TabIndex = 595
        Me.colorcode.Text = "colorcode"
        Me.colorcode.Visible = False
        '
        'frmTransferVoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 143)
        Me.Controls.Add(Me.colorcode)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.areacode)
        Me.Controls.Add(Me.muncode)
        Me.Controls.Add(Me.vilcode)
        Me.Controls.Add(Me.oldLeaderId)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.votersid)
        Me.Controls.Add(Me.txtLeaders)
        Me.Controls.Add(Me.LabelControl5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransferVoters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Voters"
        Me.TopMost = True
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLeaders As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridLeader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents votersid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents vilcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents oldLeaderId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colorcode As DevExpress.XtraEditors.LabelControl
End Class
