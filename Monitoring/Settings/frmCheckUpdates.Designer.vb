<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckUpdates
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
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl()
        Me.cmdDownload = New DevExpress.XtraEditors.SimpleButton()
        Me.txturl = New DevExpress.XtraEditors.TextEdit()
        Me.txtversion = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txturl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtversion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 15.25!)
        Me.lblTitle.Appearance.Options.UseFont = True
        Me.lblTitle.Appearance.Options.UseTextOptions = True
        Me.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitle.Location = New System.Drawing.Point(54, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(390, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "New update available"
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Appearance.Options.UseTextOptions = True
        Me.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVersion.Location = New System.Drawing.Point(103, 59)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(293, 19)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Build Version 13.2.5"
        '
        'cmdDownload
        '
        Me.cmdDownload.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdDownload.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdDownload.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdDownload.Appearance.Options.UseBackColor = True
        Me.cmdDownload.Appearance.Options.UseForeColor = True
        Me.cmdDownload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmdDownload.Location = New System.Drawing.Point(161, 84)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(176, 40)
        Me.cmdDownload.TabIndex = 2
        Me.cmdDownload.Text = "Download update"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(397, 1)
        Me.txturl.Name = "txturl"
        Me.txturl.Properties.ReadOnly = True
        Me.txturl.Size = New System.Drawing.Size(44, 20)
        Me.txturl.TabIndex = 559
        Me.txturl.Visible = False
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(444, 1)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Properties.ReadOnly = True
        Me.txtversion.Size = New System.Drawing.Size(44, 20)
        Me.txtversion.TabIndex = 558
        Me.txtversion.Visible = False
        '
        'frmCheckUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 152)
        Me.Controls.Add(Me.txturl)
        Me.Controls.Add(Me.txtversion)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckUpdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check system update.."
        CType(Me.txturl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtversion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdDownload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txturl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtversion As DevExpress.XtraEditors.TextEdit
End Class
