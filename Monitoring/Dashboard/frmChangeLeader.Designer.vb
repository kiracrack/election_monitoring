<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeLeader
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
        Me.txtLeaders = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridLeader = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.votersid = New DevExpress.XtraEditors.LabelControl()
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtcurrentLeader = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.currentid = New DevExpress.XtraEditors.LabelControl()
        Me.areacode = New DevExpress.XtraEditors.LabelControl()
        Me.muncode = New DevExpress.XtraEditors.LabelControl()
        Me.vilcode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVillage = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVillage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMunicipal = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridMunicipal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtArea = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridArea = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtprecintno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcurrentLeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLeaders
        '
        Me.txtLeaders.EditValue = ""
        Me.txtLeaders.Location = New System.Drawing.Point(109, 245)
        Me.txtLeaders.Name = "txtLeaders"
        Me.txtLeaders.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaders.Properties.Appearance.Options.UseFont = True
        Me.txtLeaders.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLeaders.Properties.DisplayMember = "Select Leader"
        Me.txtLeaders.Properties.NullText = ""
        Me.txtLeaders.Properties.PopupView = Me.gridLeader
        Me.txtLeaders.Properties.ValueMember = "Select Leader"
        Me.txtLeaders.Size = New System.Drawing.Size(299, 20)
        Me.txtLeaders.TabIndex = 568
        '
        'gridLeader
        '
        Me.gridLeader.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridLeader.Name = "gridLeader"
        Me.gridLeader.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridLeader.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(47, 248)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 567
        Me.LabelControl5.Text = "Change to"
        '
        'votersid
        '
        Me.votersid.Location = New System.Drawing.Point(413, 248)
        Me.votersid.Name = "votersid"
        Me.votersid.Size = New System.Drawing.Size(41, 13)
        Me.votersid.TabIndex = 569
        Me.votersid.Text = "votersid"
        Me.votersid.Visible = False
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(153, 271)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(105, 30)
        Me.cmdadd.TabIndex = 570
        Me.cmdadd.Text = "&Confirm"
        '
        'txtcurrentLeader
        '
        Me.txtcurrentLeader.EditValue = ""
        Me.txtcurrentLeader.Location = New System.Drawing.Point(109, 76)
        Me.txtcurrentLeader.Name = "txtcurrentLeader"
        Me.txtcurrentLeader.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrentLeader.Properties.Appearance.Options.UseFont = True
        Me.txtcurrentLeader.Properties.Appearance.Options.UseTextOptions = True
        Me.txtcurrentLeader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtcurrentLeader.Properties.ReadOnly = True
        Me.txtcurrentLeader.Size = New System.Drawing.Size(298, 20)
        Me.txtcurrentLeader.TabIndex = 571
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 572
        Me.LabelControl1.Text = "Current Leader"
        '
        'currentid
        '
        Me.currentid.Location = New System.Drawing.Point(414, 79)
        Me.currentid.Name = "currentid"
        Me.currentid.Size = New System.Drawing.Size(47, 13)
        Me.currentid.TabIndex = 573
        Me.currentid.Text = "currentid"
        Me.currentid.Visible = False
        '
        'areacode
        '
        Me.areacode.Location = New System.Drawing.Point(414, 103)
        Me.areacode.Name = "areacode"
        Me.areacode.Size = New System.Drawing.Size(47, 13)
        Me.areacode.TabIndex = 574
        Me.areacode.Text = "areacode"
        Me.areacode.Visible = False
        '
        'muncode
        '
        Me.muncode.Location = New System.Drawing.Point(414, 127)
        Me.muncode.Name = "muncode"
        Me.muncode.Size = New System.Drawing.Size(48, 13)
        Me.muncode.TabIndex = 575
        Me.muncode.Text = "muncode"
        Me.muncode.Visible = False
        '
        'vilcode
        '
        Me.vilcode.Location = New System.Drawing.Point(414, 149)
        Me.vilcode.Name = "vilcode"
        Me.vilcode.Size = New System.Drawing.Size(36, 13)
        Me.vilcode.TabIndex = 576
        Me.vilcode.Text = "vilcode"
        Me.vilcode.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(33, 149)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 584
        Me.LabelControl2.Text = "Select Village"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(17, 127)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl4.TabIndex = 583
        Me.LabelControl4.Text = "Select Municipal"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(45, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 582
        Me.LabelControl3.Text = "Select Area"
        '
        'txtVillage
        '
        Me.txtVillage.EditValue = ""
        Me.txtVillage.Location = New System.Drawing.Point(109, 146)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVillage.Properties.DisplayMember = "Select List"
        Me.txtVillage.Properties.NullText = ""
        Me.txtVillage.Properties.PopupView = Me.gridVillage
        Me.txtVillage.Properties.ValueMember = "Select List"
        Me.txtVillage.Size = New System.Drawing.Size(298, 20)
        Me.txtVillage.TabIndex = 580
        '
        'gridVillage
        '
        Me.gridVillage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVillage.Name = "gridVillage"
        Me.gridVillage.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVillage.OptionsView.ShowGroupPanel = False
        '
        'txtMunicipal
        '
        Me.txtMunicipal.EditValue = ""
        Me.txtMunicipal.Location = New System.Drawing.Point(109, 123)
        Me.txtMunicipal.Name = "txtMunicipal"
        Me.txtMunicipal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMunicipal.Properties.DisplayMember = "Select List"
        Me.txtMunicipal.Properties.NullText = ""
        Me.txtMunicipal.Properties.PopupView = Me.gridMunicipal
        Me.txtMunicipal.Properties.ValueMember = "Select List"
        Me.txtMunicipal.Size = New System.Drawing.Size(298, 20)
        Me.txtMunicipal.TabIndex = 579
        '
        'gridMunicipal
        '
        Me.gridMunicipal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridMunicipal.Name = "gridMunicipal"
        Me.gridMunicipal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridMunicipal.OptionsView.ShowGroupPanel = False
        '
        'txtArea
        '
        Me.txtArea.EditValue = ""
        Me.txtArea.Location = New System.Drawing.Point(109, 100)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtArea.Properties.DisplayMember = "Select List"
        Me.txtArea.Properties.NullText = ""
        Me.txtArea.Properties.PopupView = Me.gridArea
        Me.txtArea.Properties.ValueMember = "Select List"
        Me.txtArea.Size = New System.Drawing.Size(298, 20)
        Me.txtArea.TabIndex = 578
        '
        'gridArea
        '
        Me.gridArea.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridArea.Name = "gridArea"
        Me.gridArea.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridArea.OptionsView.ShowGroupPanel = False
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(19, 295)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 13)
        Me.id.TabIndex = 586
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(95, 47)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(201, 13)
        Me.LabelControl8.TabIndex = 590
        Me.LabelControl8.Text = "This form allow's user to change leader"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(95, 25)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(194, 19)
        Me.LabelControl9.TabIndex = 589
        Me.LabelControl9.Text = "Change Leader Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Silver
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(96, 53)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(298, 13)
        Me.LabelControl10.TabIndex = 588
        Me.LabelControl10.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(58, 195)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl6.TabIndex = 592
        Me.LabelControl6.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.EditValue = ""
        Me.txtRemarks.Location = New System.Drawing.Point(109, 192)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(298, 49)
        Me.txtRemarks.TabIndex = 591
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(264, 271)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(105, 30)
        Me.SimpleButton1.TabIndex = 593
        Me.SimpleButton1.Text = "C&ancel"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(40, 172)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl7.TabIndex = 595
        Me.LabelControl7.Text = "Precinct No."
        '
        'txtprecintno
        '
        Me.txtprecintno.EditValue = ""
        Me.txtprecintno.Location = New System.Drawing.Point(109, 169)
        Me.txtprecintno.Name = "txtprecintno"
        Me.txtprecintno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtprecintno.Properties.PopupSizeable = True
        Me.txtprecintno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtprecintno.Size = New System.Drawing.Size(120, 20)
        Me.txtprecintno.TabIndex = 594
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.ContentImage = Global.Monitoring.My.Resources.Resources.User_group
        Me.PanelControl2.Location = New System.Drawing.Point(23, 16)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(66, 61)
        Me.PanelControl2.TabIndex = 587
        '
        'frmChangeLeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 313)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtVillage)
        Me.Controls.Add(Me.txtMunicipal)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.areacode)
        Me.Controls.Add(Me.muncode)
        Me.Controls.Add(Me.vilcode)
        Me.Controls.Add(Me.currentid)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.votersid)
        Me.Controls.Add(Me.txtLeaders)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtcurrentLeader)
        Me.Controls.Add(Me.txtprecintno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmChangeLeader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Leader"
        CType(Me.txtLeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcurrentLeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVillage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVillage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMunicipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecintno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLeaders As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridLeader As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents votersid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcurrentLeader As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents currentid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents areacode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents muncode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vilcode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVillage As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVillage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMunicipal As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridMunicipal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtArea As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridArea As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtprecintno As DevExpress.XtraEditors.ComboBoxEdit
End Class
