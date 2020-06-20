<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSTemplate
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
        Me.cmdaction = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBody = New DevExpress.XtraEditors.MemoEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtsmslimit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsmslimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(118, 452)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(274, 35)
        Me.cmdaction.TabIndex = 571
        Me.cmdaction.Text = "Save Template"
        '
        'txtTitle
        '
        Me.txtTitle.EditValue = ""
        Me.txtTitle.Location = New System.Drawing.Point(12, 27)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitle.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtTitle.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtTitle.Properties.MaxLength = 50
        Me.txtTitle.Properties.NullValuePrompt = "Template Title"
        Me.txtTitle.Size = New System.Drawing.Size(485, 20)
        Me.txtTitle.TabIndex = 0
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(12, 8)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl15.TabIndex = 622
        Me.LabelControl15.Text = "Create SMS Template"
        '
        'txtBody
        '
        Me.txtBody.EditValue = ""
        Me.txtBody.Location = New System.Drawing.Point(12, 50)
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Properties.MaxLength = 250
        Me.txtBody.Properties.NullValuePrompt = "Tempate Content"
        Me.txtBody.Size = New System.Drawing.Size(486, 50)
        Me.txtBody.TabIndex = 1
        '
        'Em
        '
        Me.Em.Location = New System.Drawing.Point(12, 129)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(486, 318)
        Me.Em.TabIndex = 624
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtsmslimit
        '
        Me.txtsmslimit.EditValue = "250"
        Me.txtsmslimit.Location = New System.Drawing.Point(426, 105)
        Me.txtsmslimit.Name = "txtsmslimit"
        Me.txtsmslimit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtsmslimit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtsmslimit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsmslimit.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtsmslimit.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtsmslimit.Properties.ReadOnly = True
        Me.txtsmslimit.Size = New System.Drawing.Size(72, 20)
        Me.txtsmslimit.TabIndex = 625
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(288, 108)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(131, 13)
        Me.LabelControl1.TabIndex = 626
        Me.LabelControl1.Text = "Limit number of character"
        '
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.Location = New System.Drawing.Point(223, 153)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.MaxLength = 50
        Me.trnid.Properties.NullValuePrompt = "Template Title"
        Me.trnid.Size = New System.Drawing.Size(53, 20)
        Me.trnid.TabIndex = 627
        Me.trnid.Visible = False
        '
        'frmSMSTemplate
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 493)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtsmslimit)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cmdaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Template"
        Me.TopMost = True
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsmslimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBody As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtsmslimit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
End Class
