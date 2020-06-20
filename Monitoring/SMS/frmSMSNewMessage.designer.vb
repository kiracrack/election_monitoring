<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSNewMessage
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
        Me.txtCellular = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTemplate = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridTemplate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPick = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtCellular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Enabled = False
        Me.btnSendSMS.Location = New System.Drawing.Point(306, 140)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(127, 31)
        Me.btnSendSMS.TabIndex = 571
        Me.btnSendSMS.Text = "&Confirm Send"
        '
        'txtCellular
        '
        Me.txtCellular.EditValue = ""
        Me.txtCellular.Location = New System.Drawing.Point(12, 23)
        Me.txtCellular.Name = "txtCellular"
        Me.txtCellular.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCellular.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtCellular.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtCellular.Size = New System.Drawing.Size(274, 20)
        Me.txtCellular.TabIndex = 0
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(14, 145)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl15.TabIndex = 622
        Me.LabelControl15.Text = "SMS Template"
        '
        'txtMessage
        '
        Me.txtMessage.EditValue = ""
        Me.txtMessage.Location = New System.Drawing.Point(12, 47)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(421, 88)
        Me.txtMessage.TabIndex = 1
        '
        'txtTemplate
        '
        Me.txtTemplate.EditValue = ""
        Me.txtTemplate.Location = New System.Drawing.Point(87, 143)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTemplate.Properties.DisplayMember = "Template"
        Me.txtTemplate.Properties.NullText = ""
        Me.txtTemplate.Properties.PopupView = Me.gridTemplate
        Me.txtTemplate.Properties.ValueMember = "Template"
        Me.txtTemplate.Size = New System.Drawing.Size(161, 20)
        Me.txtTemplate.TabIndex = 624
        '
        'gridTemplate
        '
        Me.gridTemplate.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridTemplate.Name = "gridTemplate"
        Me.gridTemplate.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridTemplate.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(231, 13)
        Me.LabelControl1.TabIndex = 625
        Me.LabelControl1.Text = "Enter contact number or pick from voter's list"
        '
        'cmdPick
        '
        Me.cmdPick.ImageOptions.Image = Global.Monitoring.My.Resources.Resources.mail__plus
        Me.cmdPick.Location = New System.Drawing.Point(289, 22)
        Me.cmdPick.Name = "cmdPick"
        Me.cmdPick.Size = New System.Drawing.Size(24, 20)
        Me.cmdPick.TabIndex = 620
        '
        'frmSMSNewMessage
        '
        Me.AcceptButton = Me.btnSendSMS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 184)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.cmdPick)
        Me.Controls.Add(Me.txtCellular)
        Me.Controls.Add(Me.btnSendSMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSNewMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Message"
        Me.TopMost = True
        CType(Me.txtCellular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemplate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendSMS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCellular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdPick As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTemplate As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridTemplate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
