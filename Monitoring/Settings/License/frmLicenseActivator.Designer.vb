<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicenseActivator
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSystemKey = New DevExpress.XtraEditors.TextEdit()
        Me.txtActivationCode = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSystemKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(403, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 206)
        Me.barDockControlBottom.Size = New System.Drawing.Size(403, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 206)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(403, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 206)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close Window"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(144, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl3.TabIndex = 466
        Me.LabelControl3.Text = "Enter System Serial Code"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdUpdate.Appearance.BackColor2 = System.Drawing.Color.Khaki
        Me.cmdUpdate.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdUpdate.Appearance.Options.UseBackColor = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(107, 52)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(189, 32)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Get Activation Key"
        '
        'txtSystemKey
        '
        Me.txtSystemKey.EditValue = ""
        Me.txtSystemKey.EnterMoveNextControl = True
        Me.txtSystemKey.Location = New System.Drawing.Point(16, 24)
        Me.txtSystemKey.Name = "txtSystemKey"
        Me.txtSystemKey.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.txtSystemKey.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtSystemKey.Properties.Appearance.Options.UseFont = True
        Me.txtSystemKey.Properties.Appearance.Options.UseForeColor = True
        Me.txtSystemKey.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSystemKey.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSystemKey.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtSystemKey.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSystemKey.Size = New System.Drawing.Size(370, 24)
        Me.txtSystemKey.TabIndex = 1
        '
        'txtActivationCode
        '
        Me.txtActivationCode.EditValue = ""
        Me.txtActivationCode.Location = New System.Drawing.Point(16, 92)
        Me.txtActivationCode.Name = "txtActivationCode"
        Me.txtActivationCode.Properties.ReadOnly = True
        Me.txtActivationCode.Size = New System.Drawing.Size(370, 104)
        Me.txtActivationCode.TabIndex = 471
        '
        'frmLicenseActivator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 206)
        Me.Controls.Add(Me.txtActivationCode)
        Me.Controls.Add(Me.txtSystemKey)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLicenseActivator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Activator"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSystemKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSystemKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtActivationCode As DevExpress.XtraEditors.MemoEdit
End Class
