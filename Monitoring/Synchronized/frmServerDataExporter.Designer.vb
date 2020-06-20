<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerDataExporter
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
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.tbltotalRecords = New DevExpress.XtraEditors.LabelControl()
        Me.lbldate = New DevExpress.XtraEditors.LabelControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.batchcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtDateWorkTo = New DevExpress.XtraEditors.DateEdit()
        Me.txtDateWorkFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdadd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateWorkTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateWorkTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateWorkFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateWorkFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 436)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(739, 30)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'tbltotalRecords
        '
        Me.tbltotalRecords.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tbltotalRecords.Appearance.Options.UseFont = True
        Me.tbltotalRecords.Location = New System.Drawing.Point(63, 103)
        Me.tbltotalRecords.Name = "tbltotalRecords"
        Me.tbltotalRecords.Size = New System.Drawing.Size(206, 14)
        Me.tbltotalRecords.TabIndex = 3
        Me.tbltotalRecords.Text = "Total Records Ready to Upload :  N/A"
        '
        'lbldate
        '
        Me.lbldate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lbldate.Appearance.Options.UseFont = True
        Me.lbldate.Location = New System.Drawing.Point(63, 123)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(256, 14)
        Me.lbldate.TabIndex = 4
        Me.lbldate.Text = "Date Time Upload: February 14, 2013 3:00 PM"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem3})
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
        Me.barDockControlTop.Size = New System.Drawing.Size(764, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 512)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(764, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 492)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(764, 20)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 492)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Backup Edited Data"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(283, 472)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(188, 30)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Export"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.Location = New System.Drawing.Point(12, 147)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(740, 283)
        Me.Em.TabIndex = 326
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'batchcode
        '
        Me.batchcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.batchcode.EditValue = ""
        Me.batchcode.EnterMoveNextControl = True
        Me.batchcode.Location = New System.Drawing.Point(610, 193)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchcode.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.batchcode.Properties.Appearance.Options.UseFont = True
        Me.batchcode.Properties.Appearance.Options.UseForeColor = True
        Me.batchcode.Properties.Appearance.Options.UseTextOptions = True
        Me.batchcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.batchcode.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.batchcode.Size = New System.Drawing.Size(122, 24)
        Me.batchcode.TabIndex = 374
        Me.batchcode.Visible = False
        '
        'txtDateWorkTo
        '
        Me.txtDateWorkTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDateWorkTo.EditValue = Nothing
        Me.txtDateWorkTo.Location = New System.Drawing.Point(63, 77)
        Me.txtDateWorkTo.Name = "txtDateWorkTo"
        Me.txtDateWorkTo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDateWorkTo.Properties.Appearance.Options.UseFont = True
        Me.txtDateWorkTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateWorkTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateWorkTo.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.txtDateWorkTo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateWorkTo.Size = New System.Drawing.Size(208, 20)
        Me.txtDateWorkTo.TabIndex = 380
        '
        'txtDateWorkFrom
        '
        Me.txtDateWorkFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDateWorkFrom.EditValue = Nothing
        Me.txtDateWorkFrom.Location = New System.Drawing.Point(63, 55)
        Me.txtDateWorkFrom.Name = "txtDateWorkFrom"
        Me.txtDateWorkFrom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.txtDateWorkFrom.Properties.Appearance.Options.UseFont = True
        Me.txtDateWorkFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateWorkFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDateWorkFrom.Properties.Mask.EditMask = "yyyy-MM-dd"
        Me.txtDateWorkFrom.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDateWorkFrom.Size = New System.Drawing.Size(208, 20)
        Me.txtDateWorkFrom.TabIndex = 379
        '
        'LabelControl33
        '
        Me.LabelControl33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.LabelControl33.Appearance.Options.UseFont = True
        Me.LabelControl33.Location = New System.Drawing.Point(19, 34)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(155, 14)
        Me.LabelControl33.TabIndex = 381
        Me.LabelControl33.Text = "Please select date to export"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(30, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 14)
        Me.LabelControl1.TabIndex = 382
        Me.LabelControl1.Text = "From"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(42, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 14)
        Me.LabelControl2.TabIndex = 383
        Me.LabelControl2.Text = "To"
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(274, 55)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(82, 42)
        Me.cmdadd.TabIndex = 571
        Me.cmdadd.Text = "Show Records"
        '
        'frmServerDataExporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 512)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDateWorkTo)
        Me.Controls.Add(Me.txtDateWorkFrom)
        Me.Controls.Add(Me.LabelControl33)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.tbltotalRecords)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServerDataExporter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Server Records"
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.batchcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateWorkTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateWorkTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateWorkFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateWorkFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents tbltotalRecords As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbldate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents batchcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateWorkTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDateWorkFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdadd As DevExpress.XtraEditors.SimpleButton
End Class
