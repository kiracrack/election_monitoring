<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSViewMessage
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
        Me.txtMessage = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsmsContent = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.txtCellular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsmsContent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Enabled = False
        Me.btnSendSMS.Location = New System.Drawing.Point(320, 187)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(113, 24)
        Me.btnSendSMS.TabIndex = 571
        Me.btnSendSMS.Text = "Confirm Send"
        '
        'txtCellular
        '
        Me.txtCellular.EditValue = ""
        Me.txtCellular.Location = New System.Drawing.Point(56, 6)
        Me.txtCellular.Name = "txtCellular"
        Me.txtCellular.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCellular.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtCellular.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtCellular.Properties.ReadOnly = True
        Me.txtCellular.Size = New System.Drawing.Size(229, 20)
        Me.txtCellular.TabIndex = 619
        '
        'txtMessage
        '
        Me.txtMessage.EditValue = ""
        Me.txtMessage.Location = New System.Drawing.Point(12, 123)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Properties.NullValuePrompt = "Reply message.."
        Me.txtMessage.Size = New System.Drawing.Size(421, 58)
        Me.txtMessage.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 625
        Me.LabelControl1.Text = "Sender:"
        '
        'txtsmsContent
        '
        Me.txtsmsContent.EditValue = ""
        Me.txtsmsContent.Location = New System.Drawing.Point(12, 31)
        Me.txtsmsContent.Name = "txtsmsContent"
        Me.txtsmsContent.Properties.ReadOnly = True
        Me.txtsmsContent.Size = New System.Drawing.Size(421, 88)
        Me.txtsmsContent.TabIndex = 626
        '
        'frmSMSViewMessage
        '
        Me.AcceptButton = Me.btnSendSMS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 220)
        Me.Controls.Add(Me.txtsmsContent)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtCellular)
        Me.Controls.Add(Me.btnSendSMS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSViewMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Message"
        Me.TopMost = True
        CType(Me.txtCellular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsmsContent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendSMS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCellular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMessage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsmsContent As DevExpress.XtraEditors.MemoEdit
End Class
