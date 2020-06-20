<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSetup
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
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtusername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServerhost = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatabase = New DevExpress.XtraEditors.TextEdit()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPort = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerhost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = "Password"
        Me.txtpassword.Location = New System.Drawing.Point(116, 75)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtpassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(234, 24)
        Me.txtpassword.TabIndex = 3
        '
        'txtusername
        '
        Me.txtusername.EditValue = "Username"
        Me.txtusername.EnterMoveNextControl = True
        Me.txtusername.Location = New System.Drawing.Point(116, 52)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Properties.Appearance.Options.UseForeColor = True
        Me.txtusername.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtusername.Size = New System.Drawing.Size(234, 20)
        Me.txtusername.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(59, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 458
        Me.LabelControl1.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 459
        Me.LabelControl2.Text = "Username"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(33, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 460
        Me.LabelControl4.Text = "Database Host"
        '
        'txtServerhost
        '
        Me.txtServerhost.EditValue = "localhost"
        Me.txtServerhost.EnterMoveNextControl = True
        Me.txtServerhost.Location = New System.Drawing.Point(116, 29)
        Me.txtServerhost.Name = "txtServerhost"
        Me.txtServerhost.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtServerhost.Properties.Appearance.Options.UseForeColor = True
        Me.txtServerhost.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtServerhost.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtServerhost.Size = New System.Drawing.Size(173, 20)
        Me.txtServerhost.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(367, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 169)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(367, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 149)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(367, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 149)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(60, 105)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 466
        Me.LabelControl3.Text = "Database"
        '
        'txtDatabase
        '
        Me.txtDatabase.EditValue = "Database"
        Me.txtDatabase.EnterMoveNextControl = True
        Me.txtDatabase.Location = New System.Drawing.Point(116, 102)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtDatabase.Properties.Appearance.Options.UseForeColor = True
        Me.txtDatabase.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtDatabase.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtDatabase.Size = New System.Drawing.Size(234, 20)
        Me.txtDatabase.TabIndex = 4
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(200, 128)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(150, 32)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Save and Activate"
        '
        'txtPort
        '
        Me.txtPort.EditValue = "Port"
        Me.txtPort.EnterMoveNextControl = True
        Me.txtPort.Location = New System.Drawing.Point(291, 29)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtPort.Properties.Appearance.Options.UseForeColor = True
        Me.txtPort.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPort.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPort.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtPort.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtPort.Size = New System.Drawing.Size(59, 20)
        Me.txtPort.TabIndex = 1
        '
        'frmConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 169)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServerhost)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConnectionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Setup"
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerhost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServerhost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPort As DevExpress.XtraEditors.TextEdit
End Class
