<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProfile
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
        Me.components = New System.ComponentModel.Container()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txttheme = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtverify = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.txtdesignation = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtfullname = New DevExpress.XtraEditors.TextEdit()
        Me.ckChangePassword = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrentPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLeader = New DevExpress.XtraEditors.ColorEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMember = New DevExpress.XtraEditors.ColorEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttheme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdesignation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckChangePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(170, 411)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseTextOptions = True
        Me.mode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(54, 20)
        Me.mode.TabIndex = 405
        Me.mode.Visible = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(407, 0)
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 304)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(407, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 304)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(407, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 304)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(122, 85)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 447
        Me.LabelControl1.Text = "Theme"
        '
        'txttheme
        '
        Me.txttheme.AllowDrop = True
        Me.txttheme.EditValue = ""
        Me.txttheme.EnterMoveNextControl = True
        Me.txttheme.Location = New System.Drawing.Point(164, 82)
        Me.txttheme.Name = "txttheme"
        Me.txttheme.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txttheme.Properties.ImmediatePopup = True
        Me.txttheme.Properties.Items.AddRange(New Object() {"Seven", "Seven Classic" & Global.Microsoft.VisualBasic.ChrW(9), "VS 2010", "DevExpress Style", "DevExpress Dark Style", "Sharp", "Sharp Plus", "Foggy", "Darkroom", "High Contrast", "Springtime", "Pumpkin", "Summer", "Xmas(Blue)", "McSkin", "Valentine", "Dark Side", "Caramel", "Lilian", "Money Twins", "iMaginary", "Black", "Blue", "Blueprint", "Whiteprint", "The Asphalt World", "Coffee", "Glass Oceans", "Stardust", "Liquid Sky", "London Liquid Sky", "Office 2010 Blue", "Office 2010 Black", "Office 2010 Silver", "Office 2007 Blue", "Office 2007 Black", "Office 2007 Silver", "Office 2007 Pink", "Office 2007 Green"})
        Me.txttheme.Properties.PopupSizeable = True
        Me.txttheme.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txttheme.Properties.ValidateOnEnterKey = True
        Me.txttheme.Size = New System.Drawing.Size(227, 20)
        Me.txttheme.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(92, 40)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl11.TabIndex = 444
        Me.LabelControl11.Text = "Designation"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(126, 238)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl19.TabIndex = 443
        Me.LabelControl19.Text = "Verify"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(106, 215)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl18.TabIndex = 442
        Me.LabelControl18.Text = "Password"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(104, 62)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl16.TabIndex = 440
        Me.LabelControl16.Text = "Username"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(108, 16)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl17.TabIndex = 441
        Me.LabelControl17.Text = "Fullname"
        '
        'txtverify
        '
        Me.txtverify.EditValue = ""
        Me.txtverify.EnterMoveNextControl = True
        Me.txtverify.Location = New System.Drawing.Point(164, 235)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtverify.Properties.Appearance.Options.UseFont = True
        Me.txtverify.Properties.AutoHeight = False
        Me.txtverify.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtverify.Properties.ReadOnly = True
        Me.txtverify.Size = New System.Drawing.Size(164, 20)
        Me.txtverify.TabIndex = 6
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(164, 258)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(164, 28)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "Save"
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = ""
        Me.txtpassword.EnterMoveNextControl = True
        Me.txtpassword.Location = New System.Drawing.Point(164, 212)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Properties.ReadOnly = True
        Me.txtpassword.Size = New System.Drawing.Size(164, 20)
        Me.txtpassword.TabIndex = 5
        '
        'txtusername
        '
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(164, 59)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Size = New System.Drawing.Size(227, 20)
        Me.txtusername.TabIndex = 2
        '
        'txtdesignation
        '
        Me.txtdesignation.AllowDrop = True
        Me.txtdesignation.EditValue = ""
        Me.txtdesignation.EnterMoveNextControl = True
        Me.txtdesignation.Location = New System.Drawing.Point(164, 36)
        Me.txtdesignation.Name = "txtdesignation"
        Me.txtdesignation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtdesignation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesignation.Properties.ImmediatePopup = True
        Me.txtdesignation.Properties.PopupSizeable = True
        Me.txtdesignation.Properties.ValidateOnEnterKey = True
        Me.txtdesignation.Size = New System.Drawing.Size(227, 20)
        Me.txtdesignation.TabIndex = 1
        '
        'txtfullname
        '
        Me.txtfullname.Location = New System.Drawing.Point(164, 13)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfullname.Size = New System.Drawing.Size(227, 20)
        Me.txtfullname.TabIndex = 0
        '
        'ckChangePassword
        '
        Me.ckChangePassword.Location = New System.Drawing.Point(164, 168)
        Me.ckChangePassword.MenuManager = Me.BarManager1
        Me.ckChangePassword.Name = "ckChangePassword"
        Me.ckChangePassword.Properties.Caption = "Change Password"
        Me.ckChangePassword.Size = New System.Drawing.Size(147, 19)
        Me.ckChangePassword.TabIndex = 452
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(64, 192)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl2.TabIndex = 458
        Me.LabelControl2.Text = "Current Password"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.EditValue = ""
        Me.txtCurrentPassword.EnterMoveNextControl = True
        Me.txtCurrentPassword.Location = New System.Drawing.Point(164, 189)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtCurrentPassword.Properties.Appearance.Options.UseFont = True
        Me.txtCurrentPassword.Properties.AutoHeight = False
        Me.txtCurrentPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtCurrentPassword.Properties.ReadOnly = True
        Me.txtCurrentPassword.Size = New System.Drawing.Size(164, 20)
        Me.txtCurrentPassword.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 108)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl3.TabIndex = 464
        Me.LabelControl3.Text = "Default Leader Back Color"
        '
        'txtLeader
        '
        Me.txtLeader.EditValue = System.Drawing.Color.Empty
        Me.txtLeader.Location = New System.Drawing.Point(164, 105)
        Me.txtLeader.Name = "txtLeader"
        Me.txtLeader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLeader.Properties.ShowCustomColors = False
        Me.txtLeader.Properties.ShowSystemColors = False
        Me.txtLeader.Size = New System.Drawing.Size(227, 20)
        Me.txtLeader.TabIndex = 463
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 131)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl4.TabIndex = 466
        Me.LabelControl4.Text = "Default Member Font Color"
        '
        'txtMember
        '
        Me.txtMember.EditValue = System.Drawing.Color.Empty
        Me.txtMember.Location = New System.Drawing.Point(164, 128)
        Me.txtMember.Name = "txtMember"
        Me.txtMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMember.Properties.ShowCustomColors = False
        Me.txtMember.Properties.ShowSystemColors = False
        Me.txtMember.Size = New System.Drawing.Size(227, 20)
        Me.txtMember.TabIndex = 465
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 304)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtMember)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtLeader)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.ckChangePassword)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txttheme)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtdesignation)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account Profile"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttheme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdesignation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckChangePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttheme As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtverify As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdesignation As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtfullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ckChangePassword As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrentPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMember As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLeader As DevExpress.XtraEditors.ColorEdit
End Class
