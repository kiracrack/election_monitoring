<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadSystemUpdate
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
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.Details = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDetails = New DevExpress.XtraEditors.TextEdit()
        Me.txtFeatures = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVersion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUrl = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(442, 0)
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 264)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(442, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 264)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(442, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 264)
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(45, 47)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl16.TabIndex = 440
        Me.LabelControl16.Text = "Features"
        '
        'Details
        '
        Me.Details.Location = New System.Drawing.Point(54, 24)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(35, 13)
        Me.Details.TabIndex = 441
        Me.Details.Text = "Details"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(288, 222)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(142, 28)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "Upload Update"
        '
        'txtDetails
        '
        Me.txtDetails.EditValue = ""
        Me.txtDetails.Location = New System.Drawing.Point(95, 21)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(336, 20)
        Me.txtDetails.TabIndex = 0
        '
        'txtFeatures
        '
        Me.txtFeatures.Location = New System.Drawing.Point(95, 45)
        Me.txtFeatures.Name = "txtFeatures"
        Me.txtFeatures.Size = New System.Drawing.Size(336, 127)
        Me.txtFeatures.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 178)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 464
        Me.LabelControl1.Text = "Version"
        '
        'txtVersion
        '
        Me.txtVersion.EditValue = ""
        Me.txtVersion.Location = New System.Drawing.Point(95, 175)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(106, 20)
        Me.txtVersion.TabIndex = 463
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 201)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 466
        Me.LabelControl2.Text = "Download URL"
        '
        'txtUrl
        '
        Me.txtUrl.EditValue = "http://"
        Me.txtUrl.Location = New System.Drawing.Point(95, 198)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(336, 20)
        Me.txtUrl.TabIndex = 465
        '
        'frmUploadSystemUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 264)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.Details)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtFeatures)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUploadSystemUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New system update version"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeatures.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Details As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDetails As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFeatures As DevExpress.XtraEditors.MemoEdit
End Class
