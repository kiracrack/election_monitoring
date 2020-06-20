<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
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
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtverify = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.userid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(326, 0)
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 99)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(326, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 99)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(326, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 99)
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(33, 37)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl19.TabIndex = 443
        Me.LabelControl19.Text = "Verify Password"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(39, 14)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl18.TabIndex = 442
        Me.LabelControl18.Text = "New Password"
        '
        'txtverify
        '
        Me.txtverify.EditValue = ""
        Me.txtverify.EnterMoveNextControl = True
        Me.txtverify.Location = New System.Drawing.Point(123, 35)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtverify.Properties.Appearance.Options.UseFont = True
        Me.txtverify.Properties.AutoHeight = False
        Me.txtverify.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtverify.Size = New System.Drawing.Size(164, 20)
        Me.txtverify.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(123, 58)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(164, 28)
        Me.SimpleButton4.TabIndex = 438
        Me.SimpleButton4.Text = "Save"
        '
        'txtpassword
        '
        Me.txtpassword.EditValue = ""
        Me.txtpassword.EnterMoveNextControl = True
        Me.txtpassword.Location = New System.Drawing.Point(123, 12)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Wingdings", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.AutoHeight = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(164, 20)
        Me.txtpassword.TabIndex = 0
        '
        'userid
        '
        Me.userid.EditValue = ""
        Me.userid.EnterMoveNextControl = True
        Me.userid.Location = New System.Drawing.Point(12, 67)
        Me.userid.Name = "userid"
        Me.userid.Properties.AutoHeight = False
        Me.userid.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.userid.Properties.ReadOnly = True
        Me.userid.Size = New System.Drawing.Size(48, 20)
        Me.userid.TabIndex = 463
        Me.userid.Visible = False
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 99)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtverify.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtverify As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents userid As DevExpress.XtraEditors.TextEdit
End Class
