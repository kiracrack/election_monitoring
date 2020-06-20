<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIDCategory
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtIDCategory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.filename = New System.Windows.Forms.TextBox()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtIDCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(38, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Print Front View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(148, 166)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(100, 22)
        Me.mode.TabIndex = 589
        Me.mode.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Button2.Location = New System.Drawing.Point(192, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 38)
        Me.Button2.TabIndex = 590
        Me.Button2.Text = "Print Back View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtIDCategory
        '
        Me.txtIDCategory.EditValue = ""
        Me.txtIDCategory.Location = New System.Drawing.Point(19, 12)
        Me.txtIDCategory.Name = "txtIDCategory"
        Me.txtIDCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtIDCategory.Properties.Appearance.Options.UseFont = True
        Me.txtIDCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIDCategory.Properties.DisplayMember = "Select List"
        Me.txtIDCategory.Properties.NullText = ""
        Me.txtIDCategory.Properties.PopupView = Me.gridArea
        Me.txtIDCategory.Properties.ValueMember = "Code"
        Me.txtIDCategory.Size = New System.Drawing.Size(340, 32)
        Me.txtIDCategory.TabIndex = 0
        '
        'gridArea
        '
        Me.gridArea.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.gridArea.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridArea.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.gridArea.Appearance.Row.Options.UseFont = True
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'filename
        '
        Me.filename.Location = New System.Drawing.Point(38, 166)
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(100, 22)
        Me.filename.TabIndex = 626
        Me.filename.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(267, 169)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "CheckEdit1"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 627
        '
        'frmIDCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 102)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.filename)
        Me.Controls.Add(Me.txtIDCategory)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIDCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select ID Template"
        CType(Me.txtIDCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mode As TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtIDCategory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents filename As System.Windows.Forms.TextBox
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
