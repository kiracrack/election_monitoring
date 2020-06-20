<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserPerformance
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
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdWord = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPerformanceSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.tabTeamPerformance = New DevExpress.XtraTab.XtraTabPage()
        Me.tabGraphPerformance = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ckRealtime = New DevExpress.XtraEditors.CheckEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabPerformanceSummary.SuspendLayout()
        Me.tabGraphPerformance.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckRealtime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(812, 353)
        Me.Em.TabIndex = 327
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Monitoring.My.Resources.Resources._1271
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(267, 15)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl19.TabIndex = 331
        Me.LabelControl19.Text = "-"
        '
        'txtDateTo
        '
        Me.txtDateTo.EditValue = Nothing
        Me.txtDateTo.Location = New System.Drawing.Point(277, 12)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateTo.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateTo.Size = New System.Drawing.Size(187, 20)
        Me.txtDateTo.TabIndex = 329
        '
        'txtDateFrom
        '
        Me.txtDateFrom.EditValue = Nothing
        Me.txtDateFrom.Location = New System.Drawing.Point(74, 12)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateFrom.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtDateFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateFrom.Size = New System.Drawing.Size(187, 20)
        Me.txtDateFrom.TabIndex = 328
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(15, 15)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl33.TabIndex = 330
        Me.LabelControl33.Text = "Select Date"
        '
        'cmdWord
        '
        Me.cmdWord.ImageOptions.Image = Global.Monitoring.My.Resources.Resources.search__4_
        Me.cmdWord.Location = New System.Drawing.Point(467, 12)
        Me.cmdWord.Name = "cmdWord"
        Me.cmdWord.Size = New System.Drawing.Size(28, 22)
        Me.cmdWord.TabIndex = 332
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 59)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabPerformanceSummary
        Me.XtraTabControl1.Size = New System.Drawing.Size(818, 381)
        Me.XtraTabControl1.TabIndex = 333
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPerformanceSummary, Me.tabTeamPerformance, Me.tabGraphPerformance})
        '
        'tabPerformanceSummary
        '
        Me.tabPerformanceSummary.Controls.Add(Me.Em)
        Me.tabPerformanceSummary.Name = "tabPerformanceSummary"
        Me.tabPerformanceSummary.Size = New System.Drawing.Size(812, 353)
        Me.tabPerformanceSummary.Text = "Performance Summary"
        '
        'tabTeamPerformance
        '
        Me.tabTeamPerformance.Name = "tabTeamPerformance"
        Me.tabTeamPerformance.Size = New System.Drawing.Size(812, 353)
        Me.tabTeamPerformance.Text = "Team Performance"
        '
        'tabGraphPerformance
        '
        Me.tabGraphPerformance.Controls.Add(Me.ChartControl1)
        Me.tabGraphPerformance.Name = "tabGraphPerformance"
        Me.tabGraphPerformance.Size = New System.Drawing.Size(812, 353)
        Me.tabGraphPerformance.Text = "Team Graph Performance"
        '
        'ChartControl1
        '
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(812, 353)
        Me.ChartControl1.TabIndex = 0
        '
        'ckRealtime
        '
        Me.ckRealtime.Location = New System.Drawing.Point(74, 34)
        Me.ckRealtime.Name = "ckRealtime"
        Me.ckRealtime.Properties.Caption = "Realtime Update (Note: this will affect server performance)"
        Me.ckRealtime.Size = New System.Drawing.Size(316, 19)
        Me.ckRealtime.TabIndex = 334
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'frmUserPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 439)
        Me.Controls.Add(Me.ckRealtime)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdWord)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.LabelControl33)
        Me.Name = "frmUserPerformance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Performance"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabPerformanceSummary.ResumeLayout(False)
        Me.tabGraphPerformance.ResumeLayout(False)
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckRealtime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPerformanceSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTeamPerformance As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabGraphPerformance As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ckRealtime As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Timer1 As Timer
End Class
