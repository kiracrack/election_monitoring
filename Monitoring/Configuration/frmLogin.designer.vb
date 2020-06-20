<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.cmdlogin = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdlogin
        '
        Me.cmdlogin.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.cmdlogin.Appearance.Options.UseFont = True
        Me.cmdlogin.Location = New System.Drawing.Point(277, 183)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(124, 26)
        Me.cmdlogin.TabIndex = 375
        Me.cmdlogin.Text = "Enter"
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = "Password"
        Me.txtpassword.Location = New System.Drawing.Point(277, 156)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 7.25!)
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(200, 24)
        Me.txtpassword.TabIndex = 374
        '
        'txtusername
        '
        Me.txtusername.EditValue = "Username"
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(277, 131)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Properties.Appearance.Options.UseFont = True
        Me.txtusername.Properties.Appearance.Options.UseForeColor = True
        Me.txtusername.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtusername.Size = New System.Drawing.Size(200, 22)
        Me.txtusername.TabIndex = 373
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label1.Location = New System.Drawing.Point(209, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 377
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label2.Location = New System.Drawing.Point(212, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.Label3.Location = New System.Drawing.Point(274, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 15)
        Me.Label3.TabIndex = 379
        Me.Label3.Text = "Login security confirmation."
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtpassword)
        Me.PanelControl1.Controls.Add(Me.cmdlogin)
        Me.PanelControl1.Controls.Add(Me.txtusername)
        Me.PanelControl1.Location = New System.Drawing.Point(-5, -1)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(579, 293)
        Me.PanelControl1.TabIndex = 381
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(86, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(432, 17)
        Me.Label5.TabIndex = 383
        Me.Label5.Text = "Database management monitoring system for election and organization "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.Label4.Location = New System.Drawing.Point(149, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 23)
        Me.Label4.TabIndex = 382
        Me.Label4.Text = "Election Monitoring System"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(404, 183)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(73, 26)
        Me.SimpleButton1.TabIndex = 381
        Me.SimpleButton1.Text = "Close"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Monitoring.My.Resources.Resources.System_Security_Reader_2_Icon_128
        Me.PictureBox1.Location = New System.Drawing.Point(72, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 127)
        Me.PictureBox1.TabIndex = 380
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.cmdlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 289)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Protected WithEvents cmdlogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Protected WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
