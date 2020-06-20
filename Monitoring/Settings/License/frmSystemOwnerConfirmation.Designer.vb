<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemOwnerConfirmation
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
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = "Password"
        Me.txtpassword.Location = New System.Drawing.Point(41, 31)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.Appearance.Options.UseTextOptions = True
        Me.txtpassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(234, 24)
        Me.txtpassword.TabIndex = 0
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(49, 15)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(218, 13)
        Me.LabelControl17.TabIndex = 376
        Me.LabelControl17.Text = "Only system owner allowed to enter this area"
        '
        'frmSystemOwnerConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 73)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txtpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSystemOwnerConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System owner confirmation"
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
End Class
