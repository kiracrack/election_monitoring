Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Public Class frmStatusResultbyColor
    Private strgeneralqry As String = ""
    Private startqry As Boolean = False
    Private Sub frmStatusResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startqry = True
        loadArea()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim strarea = "" : Dim strMunicipal = "" : Dim strVillage = ""
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

        If ckMunicipal.Checked = False Then
            If txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                Exit Sub
            End If
            strMunicipal = " and muncode='" & muncode.Text & "'"
        Else
            strMunicipal = ""
            txtMunicipal.Properties.DataSource = Nothing
            txtMunicipal.Text = ""
            loadMunicipal()
        End If

        If ckVillage.Checked = False Then
            If txtVillage.Text = "" Then
                XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                Exit Sub
            End If
            strVillage = " and vilcode='" & vilcode.Text & "'"
        Else
            strVillage = ""
            txtVillage.Properties.DataSource = Nothing
            txtVillage.Text = ""
            loadVillage()
        End If

        strgeneralqry = strarea & strMunicipal & strVillage
        StatusPreview()
    End Sub
    Public Sub StatusPreview()
        If countrecord("tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode and deceased=0 group by tblvoters.colorcode") <> 0 Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            ChartControl1.Series.Clear()
            com.CommandText = "select count(*) as cnt,(select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'color',tblcolor.description from tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode  " & strgeneralqry & " and deceased=0 group by tblvoters.colorcode order by count(*) desc" : rst = com.ExecuteReader
            While rst.Read
                Dim series1 As New Series(rst("description").ToString & " - " & FormatNumber(rst("cnt"), 0), ViewType.Bar)
                series1.Points.Add(New SeriesPoint(rst("description").ToString, rst("cnt")))
                'series1.Points(0).Annotations.AddTextAnnotation(rst("description").ToString, rst("description").ToString)
                ChartControl1.Series.Add(series1)
                ' ChartControl1.PaletteName = "Grayscale"
                ChartControl1.Series(rst("description").ToString & " - " & FormatNumber(rst("cnt"), 0)).View.Color = Color.FromName(rst("color").ToString)
            End While
            rst.Close()
            SplashScreenManager.CloseForm()
        End If
    End Sub
    Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ChartControl1.CustomDrawSeriesPoint
        ChartControl1.Legend.FillStyle.FillMode = FillMode.Solid
        DirectCast(e.SeriesDrawOptions, BarDrawOptions).FillStyle.FillMode = FillMode.Solid
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
        loadMunicipal()
    End Sub

    Public Sub loadMunicipal()
        If startqry = False Then Exit Sub
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadVillage()
    End Sub

    Public Sub loadVillage()
        If startqry = False Then Exit Sub
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        txtArea.Properties.DataSource = Nothing
        txtArea.Text = ""
        areacode.Text = ""
        loadArea()
        ckArea.Checked = True

        txtMunicipal.Properties.DataSource = Nothing
        txtMunicipal.Text = ""
        muncode.Text = ""
        loadMunicipal()
        ckMunicipal.Checked = True

        txtVillage.Properties.DataSource = Nothing
        txtVillage.Text = ""
        vilcode.Text = ""
        loadVillage()
        ckVillage.Checked = True
        ChartControl1.Series.Clear()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'StatusPreview()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class