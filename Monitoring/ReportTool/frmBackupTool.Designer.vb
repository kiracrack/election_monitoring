﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupTool
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtKey = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Confirm Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.EnterMoveNextControl = True
        Me.txtKey.Location = New System.Drawing.Point(42, 30)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKey.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKey.Properties.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(309, 20)
        Me.txtKey.TabIndex = 610
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(308, 13)
        Me.LabelControl1.TabIndex = 611
        Me.LabelControl1.Text = "Note: Backed up Default Location (D:\Database\Monitoring)"
        '
        'frmBackupTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 106)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackupTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Database Backup Tool"
        CType(Me.txtKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
