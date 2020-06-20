<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSSettings
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComport = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ckEnableSMS = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtModemName = New DevExpress.XtraEditors.TextEdit()
        Me.txtStorage = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtComport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckEnableSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStorage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(179, 13)
        Me.LabelControl1.TabIndex = 626
        Me.LabelControl1.Text = "Please select modem port number.."
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(194, 13)
        Me.LabelControl2.TabIndex = 627
        Me.LabelControl2.Text = "To locate active GSM port please click "
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(210, 26)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.HyperlinkLabelControl1.TabIndex = 628
        Me.HyperlinkLabelControl1.Text = "Device Manager"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(346, 13)
        Me.LabelControl3.TabIndex = 629
        Me.LabelControl3.Text = "Expand Ports (COM && LPT) and look for PC UI Interface Port Number"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(27, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(283, 13)
        Me.LabelControl4.TabIndex = 630
        Me.LabelControl4.Text = "NOTE: Make you have inserted your GSM Mobile device"
        '
        'txtComport
        '
        Me.txtComport.EditValue = ""
        Me.txtComport.Enabled = False
        Me.txtComport.Location = New System.Drawing.Point(27, 100)
        Me.txtComport.Name = "txtComport"
        Me.txtComport.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.25!)
        Me.txtComport.Properties.Appearance.Options.UseFont = True
        Me.txtComport.Properties.Appearance.Options.UseTextOptions = True
        Me.txtComport.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.25!)
        Me.txtComport.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtComport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtComport.Properties.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20", "COM21"})
        Me.txtComport.Properties.PopupSizeable = True
        Me.txtComport.Size = New System.Drawing.Size(97, 30)
        Me.txtComport.TabIndex = 0
        '
        'ckEnableSMS
        '
        Me.ckEnableSMS.Location = New System.Drawing.Point(27, 79)
        Me.ckEnableSMS.Name = "ckEnableSMS"
        Me.ckEnableSMS.Properties.Caption = "Enable SMS"
        Me.ckEnableSMS.Size = New System.Drawing.Size(80, 19)
        Me.ckEnableSMS.TabIndex = 631
        '
        'cmdaction
        '
        Me.cmdaction.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdaction.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdaction.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdaction.Appearance.Options.UseBackColor = True
        Me.cmdaction.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdaction.Location = New System.Drawing.Point(27, 178)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(161, 30)
        Me.cmdaction.TabIndex = 632
        Me.cmdaction.Text = "Activate"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(27, 134)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(277, 13)
        Me.LabelControl5.TabIndex = 634
        Me.LabelControl5.Text = "Modem Name (Process name appear on task manager)"
        '
        'txtModemName
        '
        Me.txtModemName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtModemName.EditValue = ""
        Me.txtModemName.Location = New System.Drawing.Point(27, 150)
        Me.txtModemName.Name = "txtModemName"
        Me.txtModemName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtModemName.Properties.Appearance.Options.UseFont = True
        Me.txtModemName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModemName.Size = New System.Drawing.Size(295, 24)
        Me.txtModemName.TabIndex = 1
        '
        'txtStorage
        '
        Me.txtStorage.EditValue = ""
        Me.txtStorage.Enabled = False
        Me.txtStorage.Location = New System.Drawing.Point(126, 100)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.25!)
        Me.txtStorage.Properties.Appearance.Options.UseFont = True
        Me.txtStorage.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStorage.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 15.25!)
        Me.txtStorage.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtStorage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStorage.Properties.Items.AddRange(New Object() {"SIM", "PHONE"})
        Me.txtStorage.Properties.PopupSizeable = True
        Me.txtStorage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtStorage.Size = New System.Drawing.Size(196, 30)
        Me.txtStorage.TabIndex = 635
        '
        'frmSMSSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 222)
        Me.Controls.Add(Me.txtStorage)
        Me.Controls.Add(Me.txtModemName)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.ckEnableSMS)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.HyperlinkLabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtComport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSMSSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Settings"
        CType(Me.txtComport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckEnableSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStorage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComport As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckEnableSMS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModemName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStorage As DevExpress.XtraEditors.ComboBoxEdit
End Class
