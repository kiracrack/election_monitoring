Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraSplashScreen

Public Class frmStatusResultbyArea
    Private strgeneralqry As String = ""
    Private startqry As Boolean = False
    Private Sub frmStatusResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startqry = True
        loadArea()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim strarea = ""
        If ckArea.Checked = False Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                Exit Sub
            End If
            strarea = " where areacode='" & areacode.Text & "' "
        Else
            strarea = ""
            txtArea.Properties.DataSource = Nothing
            txtArea.Text = ""
            loadArea()
        End If
        strgeneralqry = strarea
        StatusPreview()
    End Sub
    Public Sub StatusPreview()
        For i As Integer = (XtraScrollableControl1.Controls.Count - 1) To 0 Step -1
            Dim ctrl As Control = XtraScrollableControl1.Controls(i)
            XtraScrollableControl1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next i

        If countrecord("tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode group by tblvoters.colorcode") <> 0 Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            dst = New DataSet
            msda = New MySqlDataAdapter("Select * from tblarea " & strgeneralqry & " order by areacode desc ", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    Dim BarChart As New ChartControl()
                    com.CommandText = "select count(*) as cnt,(select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'color',tblcolor.description from tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode where tblvoters.areacode='" & .Rows(cnt)("areacode").ToString() & "' and deceased=0 group by tblvoters.colorcode order by count(*) desc" : rst = com.ExecuteReader
                    While rst.Read
                        Dim series1 As New Series(rst("description").ToString, ViewType.Bar)
                        series1.Points.Add(New SeriesPoint(rst("description").ToString, rst("cnt")))

                        BarChart.Series.AddRange(New Series() {series1})

                        ''series1.Points(0).Annotations.AddTextAnnotation(rst("description").ToString, rst("description").ToString)
                        'BarChart.Series.Add(series1)
                        '' ChartControl1.PaletteName = "Grayscale"
                        BarChart.Series(rst("description").ToString).View.Color = Color.FromName(rst("color").ToString)


                        BarChart.Size = New Size(700, 200)
                        BarChart.Dock = DockStyle.Left
                        BarChart.Legend.FillStyle.FillMode = FillMode.Solid
                        Dim view As SideBySideBarSeriesView = CType(BarChart.Series(rst("description").ToString).View, SideBySideBarSeriesView)
                        view.FillStyle.FillMode = FillMode.Solid
                    End While
                    rst.Close()
                    If countqry("tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode", "tblvoters.areacode='" & .Rows(cnt)("areacode").ToString() & "' and deceased=0 group by tblvoters.colorcode order by count(*) desc") <> 0 Then
                        Dim chartTitle1 As New ChartTitle()
                        chartTitle1.Text = .Rows(cnt)("areaname").ToString()
                        BarChart.Titles.Add(chartTitle1)
                        BarChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
                        BarChart.EndInit()
                        XtraScrollableControl1.Controls.Add(BarChart)
                    End If
                End With
            Next
            SplashScreenManager.CloseForm()
        End If
    End Sub
    Public Sub loadArea()
        If startqry = False Then Exit Sub
        LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtArea.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtArea.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtArea.Text = txtArea.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        txtArea.Properties.DataSource = Nothing
        txtArea.Text = ""
        areacode.Text = ""
        loadArea()
        ckArea.Checked = True
        'For Each ctrl As Control In XtraScrollableControl1.Controls
        '    XtraScrollableControl1.Controls.Remove(ctrl)
        'Next
        For i As Integer = (XtraScrollableControl1.Controls.Count - 1) To 0 Step -1
            Dim ctrl As Control = XtraScrollableControl1.Controls(i)
            XtraScrollableControl1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next i
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' StatusPreview()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class