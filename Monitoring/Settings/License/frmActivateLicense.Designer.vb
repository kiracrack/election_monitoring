﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivateLicense
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
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSystemKey = New DevExpress.XtraEditors.TextEdit()
        Me.txtActivationCode = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtSystemKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(107, 143)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(189, 32)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Verify and Activate System"
        '
        'txtSystemKey
        '
        Me.txtSystemKey.EditValue = ""
        Me.txtSystemKey.EnterMoveNextControl = True
        Me.txtSystemKey.Location = New System.Drawing.Point(16, 8)
        Me.txtSystemKey.Name = "txtSystemKey"
        Me.txtSystemKey.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtSystemKey.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSystemKey.Properties.Appearance.Options.UseFont = True
        Me.txtSystemKey.Properties.Appearance.Options.UseForeColor = True
        Me.txtSystemKey.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSystemKey.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSystemKey.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtSystemKey.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSystemKey.Properties.ReadOnly = True
        Me.txtSystemKey.Size = New System.Drawing.Size(370, 24)
        Me.txtSystemKey.TabIndex = 1
        '
        'txtActivationCode
        '
        Me.txtActivationCode.EditValue = ""
        Me.txtActivationCode.Location = New System.Drawing.Point(16, 52)
        Me.txtActivationCode.Name = "txtActivationCode"
        Me.txtActivationCode.Size = New System.Drawing.Size(370, 86)
        Me.txtActivationCode.TabIndex = 471
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(163, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 472
        Me.LabelControl1.Text = "Activation Key"
        '
        'frmActivateLicense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 183)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtActivationCode)
        Me.Controls.Add(Me.txtSystemKey)
        Me.Controls.Add(Me.cmdUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmActivateLicense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activate System Serial Code"
        CType(Me.txtSystemKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSystemKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationCode As DevExpress.XtraEditors.MemoEdit
End Class
