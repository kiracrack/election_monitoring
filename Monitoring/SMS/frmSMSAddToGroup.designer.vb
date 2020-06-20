<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSAddToGroup
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
        Me.btnSendSMS = New DevExpress.XtraEditors.SimpleButton()
        Me.ls = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.txtGroup = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.ls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Enabled = False
        Me.btnSendSMS.Location = New System.Drawing.Point(81, 348)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(187, 35)
        Me.btnSendSMS.TabIndex = 571
        Me.btnSendSMS.Text = "Save Group"
        '
        'ls
        '
        Me.ls.CheckOnClick = True
        Me.ls.HotTrackItems = True
        Me.ls.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
        Me.ls.Location = New System.Drawing.Point(8, 33)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(367, 310)
        Me.ls.TabIndex = 618
        '
        'txtGroup
        '
        Me.txtGroup.EditValue = ""
        Me.txtGroup.Location = New System.Drawing.Point(8, 9)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtGroup.Properties.DisplayMember = "Group"
        Me.txtGroup.Properties.NullText = ""
        Me.txtGroup.Properties.PopupView = Me.gridGroup
        Me.txtGroup.Properties.ValueMember = "Group"
        Me.txtGroup.Size = New System.Drawing.Size(273, 20)
        Me.txtGroup.TabIndex = 625
        '
        'gridGroup
        '
        Me.gridGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridGroup.Name = "gridGroup"
        Me.gridGroup.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridGroup.OptionsView.ShowGroupPanel = False
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.Location = New System.Drawing.Point(317, 322)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.MaxLength = 50
        Me.trnid.Properties.NullValuePrompt = "Template Title"
        Me.trnid.Size = New System.Drawing.Size(58, 20)
        Me.trnid.TabIndex = 626
        Me.trnid.Visible = False
        '
        'frmSMSAddToGroup
        '
        Me.AcceptButton = Me.btnSendSMS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 392)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.btnSendSMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSAddToGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Message"
        Me.TopMost = True
        CType(Me.ls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSendSMS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ls As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txtGroup As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
End Class
