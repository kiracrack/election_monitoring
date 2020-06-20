Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI

Public Class frmMissingCapture
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub loadArea()
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
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode = '" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        If muncode.Text <> "" Then
            loadvil()
        End If
    End Sub


    Public Sub loadvil()
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        txtPrecinct.SelectedIndex = -1
        LoadToComboBox("precinct", "tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'", txtPrecinct, True)
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        loadArea()
    End Sub
    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckallPrecinct.CheckedChanged
        If ckallPrecinct.Checked = True Then
            txtPrecinct.Enabled = False
            txtPrecinct.SelectedIndex = -1
        Else
            txtPrecinct.Enabled = True
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ckrandom.Checked = True Then
            filterMunicipal()
        Else
            filterCity()
        End If
    End Sub

    Public Sub filterMunicipal()
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" And ckAllBrgy.Checked = False Then
            XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub
        ElseIf txtPrecinct.Text = "" And ckallPrecinct.Checked = False Then
            XtraMessageBox.Show("Please enter Precinct Number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrecinct.Focus()
            Exit Sub
        End If
        Dim startrow As Integer = 1
        Dim currow As Integer = 1
        Dim currprecinct As String = ""
        Dim currVillage As String = ""
        Dim cntrow As Integer = 0
        Dim duprow As Integer = 0
        txtresult.Text = ""

        Dim strbrgy As String = ""
        Dim qrybrgy As String = ""


        If ckAllBrgy.Checked = True Then
            strbrgy = "vilcode,"
            qrybrgy = ""
        Else
            strbrgy = ""
            qrybrgy = " and vilcode='" & vilcode.Text & "'"
        End If

        Dim ttlrecord As Integer = countqry("tblvoters", " areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & qrybrgy)
        com.CommandText = "select *,(select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village' from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' " & qrybrgy & " order by " & strbrgy & "votersno asc"
        rst = com.ExecuteReader
        Dim i As Integer = 0
        While rst.Read
            If ckAllBrgy.Checked = True Then
                If currVillage <> rst("vilcode").ToString Then
                    currow = 1
                    cntrow = 0
                End If
            End If

            For currow = startrow To ttlrecord
                If currow <> Val(rst("votersno").ToString) Then
                    txtresult.Text += rst("Village").ToString & " Precinct " & rst("precinct").ToString & " - Missing Capture No. " & currow.ToString & Environment.NewLine
                    cntrow = cntrow + 1
                    startrow = startrow + 1
                    'Exit For
                Else
                    startrow = startrow + 1
                    ''currow = currow + 1
                    Exit For
                End If
                'If currow = Val(rst("votersno").ToString) Then
                '    txtresult.Text += "Precinct " & rst("precinct").ToString & " - Duplicate sequence Capture No. " & duprow.ToString & Environment.NewLine
                '    'currow = currow - 2
                '    Exit For
                'End If
                'startrow = startrow + 1
                ' ''currow = currow + 1
                'currprecinct = rst("precinct").ToString
                'Exit For
            Next
            currprecinct = rst("precinct").ToString
            currVillage = rst("vilcode").ToString
            i = i + 1
        End While
        rst.Close()
        If cntrow = 0 Then
            txtresult.Text = "No capture missing found"
        End If
    End Sub

    Public Sub filterCity()
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" Then
            XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub
        ElseIf txtPrecinct.Text = "" And ckallPrecinct.Checked = False Then
            XtraMessageBox.Show("Please enter Precinct Number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrecinct.Focus()
            Exit Sub
        End If
        txtresult.Text = ""
        Dim currow As Integer = 1
        Dim currprecinct As String = ""
        Dim cntrow As Integer = 0
        Dim strgroup As String = ""
        Dim qryprecint As String = ""


        If ckallPrecinct.Checked = True Then
            strgroup = "precinct,"
            qryprecint = ""
        Else
            strgroup = ""
            qryprecint = " and precinct='" & txtPrecinct.Text & "'"
        End If

        com.CommandText = "select * from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' " & qryprecint & " order by " & strgroup & "votersno asc"
        rst = com.ExecuteReader
        While rst.Read
            If ckallPrecinct.Checked = True Then
                If currprecinct <> rst("precinct").ToString Then
                    currow = 1
                    cntrow = 0
                End If
            End If
            If currow <> Val(rst("votersno").ToString) Then
                txtresult.Text += "Precinct " & rst("precinct").ToString & " - Missing Capture No. " & currow.ToString & Environment.NewLine
                currow = currow + 1
                cntrow = cntrow + 1
            End If
            currow = currow + 1
            currprecinct = rst("precinct").ToString
        End While
        rst.Close()
        If cntrow = 0 Then
            txtresult.Text = "No capture missing found"
        End If
    End Sub

    Private Sub ckrandom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckrandom.CheckedChanged
        If ckrandom.Checked = True Then
            ckallPrecinct.Checked = True
            ckallPrecinct.Enabled = False
        Else
            ckallPrecinct.Checked = True
            ckallPrecinct.Enabled = True
        End If
    End Sub

    Private Sub ckAllBrgy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckAllBrgy.CheckedChanged
        If ckAllBrgy.Checked = True Then
            txtVillage.Enabled = False
            txtVillage.Properties.DataSource = Nothing
            txtVillage.Text = ""
            vilcode.Text = ""
            loadvil()
        Else
            txtVillage.Enabled = True
        End If
    End Sub

    Public Sub Synchronized()
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        txtresult.Text += e.ProgressPercentage.ToString
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
       
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object,
                                            ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As System.ComponentModel.BackgroundWorker = DirectCast(sender, System.ComponentModel.BackgroundWorker)
        'Raise the ProgressChanged event in the UI thread.

        Threading.Thread.Sleep(250)
    End Sub
End Class