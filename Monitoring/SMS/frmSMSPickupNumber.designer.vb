<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSPickupNumber
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
        Me.cmdConfirm = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSearch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMobileNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobileNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Enabled = False
        Me.cmdConfirm.Location = New System.Drawing.Point(239, 65)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(117, 36)
        Me.cmdConfirm.TabIndex = 571
        Me.cmdConfirm.Text = "&Confirm"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.AutoComplete = False
        Me.txtSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSearch.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Properties.ImmediatePopup = True
        Me.txtSearch.Properties.PopupSizeable = True
        Me.txtSearch.Properties.ValidateOnEnterKey = True
        Me.txtSearch.Size = New System.Drawing.Size(344, 24)
        Me.txtSearch.TabIndex = 0
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.EditValue = ""
        Me.txtMobileNumber.Location = New System.Drawing.Point(177, 39)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtMobileNumber.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtMobileNumber.Properties.ReadOnly = True
        Me.txtMobileNumber.Size = New System.Drawing.Size(179, 20)
        Me.txtMobileNumber.TabIndex = 620
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(90, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 627
        Me.LabelControl1.Text = "Mobile Number"
        '
        'frmSMSPickupNumber
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 112)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSPickupNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search from voters list with mobile number"
        Me.TopMost = True
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobileNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearch As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMobileNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
