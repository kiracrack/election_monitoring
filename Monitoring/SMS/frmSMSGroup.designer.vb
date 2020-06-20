<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMSGroup
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaction
        '
        Me.cmdaction.Location = New System.Drawing.Point(9, 355)
        Me.cmdaction.Name = "cmdaction"
        Me.cmdaction.Size = New System.Drawing.Size(306, 35)
        Me.cmdaction.TabIndex = 571
        Me.cmdaction.Text = "Save Template"
        '
        'txtTitle
        '
        Me.txtTitle.EditValue = ""
        Me.txtTitle.Location = New System.Drawing.Point(9, 8)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitle.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.txtTitle.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.txtTitle.Properties.MaxLength = 50
        Me.txtTitle.Properties.NullValuePrompt = "Template Title"
        Me.txtTitle.Size = New System.Drawing.Size(306, 20)
        Me.txtTitle.TabIndex = 0
        '
        'Em
        '
        Me.Em.Location = New System.Drawing.Point(9, 32)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(306, 318)
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
        'trnid
        '
        Me.trnid.EditValue = ""
        Me.trnid.Location = New System.Drawing.Point(148, 197)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Properties.DisplayFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.EditFormat.FormatString = "MaskType = Numeric"
        Me.trnid.Properties.MaxLength = 50
        Me.trnid.Properties.NullValuePrompt = "Template Title"
        Me.trnid.Size = New System.Drawing.Size(42, 20)
        Me.trnid.TabIndex = 625
        Me.trnid.Visible = False
        '
        'frmSMSGroup
        '
        Me.AcceptButton = Me.cmdaction
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 394)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cmdaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSMSGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Template"
        Me.TopMost = True
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
End Class
