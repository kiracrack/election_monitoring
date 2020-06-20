Imports DevExpress.XtraEditors

Public Class frmChangeLeader
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
	 If txtLeaders.Text = "" Then
            XtraMessageBox.Show("please Select new Leader to change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLeaders.Focus()
            Exit Sub
    elseIf countqry("tblvoters", "leaderid='" & votersid.Text & "'") <> 0 Then
            XtraMessageBox.Show("This leader is currently assigned to a group, please select another leader or remove existing assigned voter's on this leader! and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLeaders.Focus()
            Exit Sub
    End If
        If XtraMessageBox.Show("Please confirm! are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblvoters set leaderid='" & votersid.Text & "' where leaderid='" & currentid.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "LEADER CHANGED")

            frmLeaderInformation.votersid.Text = votersid.Text
            frmLeaderInformation.txtLeaders.Text = txtLeaders.Text
            XtraMessageBox.Show("Leader successfully changed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            ClearFields()
        End If
    End Sub
    Public Sub ClearFields()
        txtcurrentLeader.Text = ""
        currentid.Text = ""
        txtLeaders.Text = ""
        txtArea.Text = ""
        txtMunicipal.Text = ""
        txtVillage.Text = ""
        txtprecintno.Text = ""

        votersid.Text = ""
        areacode.Text = ""
        muncode.Text = ""
        vilcode.Text = ""
        id.Text = ""

        loadLeader()
        loadArea()
        loadMunicipal()
        loadVillage()
    End Sub
    Private Sub frmChangeLeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadLeader()
        loadArea()
    End Sub
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
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        LoadPrecinct()
        loadLeader()
    End Sub
    Public Sub LoadPrecinct()
        LoadToComboBox("precinct", "tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'", txtprecintno, True)
    End Sub
    Public Sub loadLeader()
        LoadXgridLookupSearch("SELECT votersid as 'Voters ID', " _
                                    + " fullname as 'Select Leader' " _
                                    + " from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and votersid<>'" & currentid.Text & "' and isleader=1  order by fullname asc ", "tblvoters", txtLeaders, gridLeader, Me)

        gridLeader.Columns("Voters ID").Visible = False
    End Sub
    Private Sub txtLeaders_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLeaders.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtLeaders.Properties.View.FocusedRowHandle.ToString)
        votersid.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Voters ID").ToString()
        txtLeaders.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Select Leader").ToString()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class