<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguration
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
        Me.leadercode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcolorleader = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.leadercolor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.membercode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcolormember = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.membercolor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.ckAutoColorChange = New DevExpress.XtraEditors.CheckEdit()
        Me.ckMultipleSelectIDPrint = New DevExpress.XtraEditors.CheckEdit()
        Me.ckShowIDPrintPreview = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtcolorleader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leadercolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcolormember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.membercolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckAutoColorChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckMultipleSelectIDPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckShowIDPrintPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leadercode
        '
        Me.leadercode.Location = New System.Drawing.Point(422, 23)
        Me.leadercode.Name = "leadercode"
        Me.leadercode.Size = New System.Drawing.Size(57, 13)
        Me.leadercode.TabIndex = 576
        Me.leadercode.Text = "leadercode"
        Me.leadercode.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(23, 23)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl14.TabIndex = 575
        Me.LabelControl14.Text = "Default Color for Leaders"
        '
        'txtcolorleader
        '
        Me.txtcolorleader.EditValue = ""
        Me.txtcolorleader.Location = New System.Drawing.Point(159, 20)
        Me.txtcolorleader.Name = "txtcolorleader"
        Me.txtcolorleader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcolorleader.Properties.DisplayMember = "Description"
        Me.txtcolorleader.Properties.NullText = ""
        Me.txtcolorleader.Properties.PopupView = Me.leadercolor
        Me.txtcolorleader.Properties.ValueMember = "Description"
        Me.txtcolorleader.Size = New System.Drawing.Size(258, 20)
        Me.txtcolorleader.TabIndex = 574
        '
        'leadercolor
        '
        Me.leadercolor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.leadercolor.Name = "leadercolor"
        Me.leadercolor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.leadercolor.OptionsView.ShowGroupPanel = False
        '
        'membercode
        '
        Me.membercode.Location = New System.Drawing.Point(422, 49)
        Me.membercode.Name = "membercode"
        Me.membercode.Size = New System.Drawing.Size(66, 13)
        Me.membercode.TabIndex = 579
        Me.membercode.Text = "membercode"
        Me.membercode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl2.TabIndex = 578
        Me.LabelControl2.Text = "Default Color for Members"
        '
        'txtcolormember
        '
        Me.txtcolormember.EditValue = ""
        Me.txtcolormember.Location = New System.Drawing.Point(159, 46)
        Me.txtcolormember.Name = "txtcolormember"
        Me.txtcolormember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtcolormember.Properties.DisplayMember = "Description"
        Me.txtcolormember.Properties.NullText = ""
        Me.txtcolormember.Properties.PopupView = Me.membercolor
        Me.txtcolormember.Properties.ValueMember = "Description"
        Me.txtcolormember.Size = New System.Drawing.Size(258, 20)
        Me.txtcolormember.TabIndex = 577
        '
        'membercolor
        '
        Me.membercolor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.membercolor.Name = "membercolor"
        Me.membercolor.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.membercolor.OptionsView.ShowGroupPanel = False
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(159, 175)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(144, 26)
        Me.cmdaction.TabIndex = 580
        Me.cmdaction.Text = "&Save"
        '
        'ckAutoColorChange
        '
        Me.ckAutoColorChange.Location = New System.Drawing.Point(159, 73)
        Me.ckAutoColorChange.Name = "ckAutoColorChange"
        Me.ckAutoColorChange.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckAutoColorChange.Properties.Appearance.Options.UseFont = True
        Me.ckAutoColorChange.Properties.Appearance.Options.UseTextOptions = True
        Me.ckAutoColorChange.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ckAutoColorChange.Properties.Caption = "Auto color change all member when leader's color changed"
        Me.ckAutoColorChange.Size = New System.Drawing.Size(248, 32)
        Me.ckAutoColorChange.TabIndex = 620
        '
        'ckMultipleSelectIDPrint
        '
        Me.ckMultipleSelectIDPrint.Location = New System.Drawing.Point(159, 110)
        Me.ckMultipleSelectIDPrint.Name = "ckMultipleSelectIDPrint"
        Me.ckMultipleSelectIDPrint.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckMultipleSelectIDPrint.Properties.Appearance.Options.UseFont = True
        Me.ckMultipleSelectIDPrint.Properties.Appearance.Options.UseTextOptions = True
        Me.ckMultipleSelectIDPrint.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ckMultipleSelectIDPrint.Properties.Caption = "Multiple Select Voters ID Print (ID Print Preview will Disable)"
        Me.ckMultipleSelectIDPrint.Size = New System.Drawing.Size(248, 32)
        Me.ckMultipleSelectIDPrint.TabIndex = 621
        '
        'ckShowIDPrintPreview
        '
        Me.ckShowIDPrintPreview.Location = New System.Drawing.Point(159, 148)
        Me.ckShowIDPrintPreview.Name = "ckShowIDPrintPreview"
        Me.ckShowIDPrintPreview.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.ckShowIDPrintPreview.Properties.Appearance.Options.UseFont = True
        Me.ckShowIDPrintPreview.Properties.Appearance.Options.UseTextOptions = True
        Me.ckShowIDPrintPreview.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ckShowIDPrintPreview.Properties.Caption = "Show ID Print Preview"
        Me.ckShowIDPrintPreview.Size = New System.Drawing.Size(248, 19)
        Me.ckShowIDPrintPreview.TabIndex = 622
        '
        'frmConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 212)
        Me.Controls.Add(Me.ckShowIDPrintPreview)
        Me.Controls.Add(Me.ckMultipleSelectIDPrint)
        Me.Controls.Add(Me.ckAutoColorChange)
        Me.Controls.Add(Me.cmdaction)
        Me.Controls.Add(Me.membercode)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtcolormember)
        Me.Controls.Add(Me.leadercode)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtcolorleader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Configuration"
        CType(Me.txtcolorleader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leadercolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcolormember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.membercolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckAutoColorChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckMultipleSelectIDPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckShowIDPrintPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leadercode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcolorleader As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents leadercolor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents membercode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcolormember As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents membercolor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckAutoColorChange As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckMultipleSelectIDPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckShowIDPrintPreview As DevExpress.XtraEditors.CheckEdit
End Class
