Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class frmLeadersInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmLeadersInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadLeader()
        loadArea()
        loadMunicipal()
        loadVillage()
    End Sub
    Public Sub loadLeader()
        If mode.Text = "edit" Then
            LoadXgridLookupSearch("SELECT votersid as 'Voters ID', precinct as 'Precinct No.', fullname as 'Select Leader' from tblvoters where votersid='" & votersid.Text & "'", "tblvoters", txtLeaders, gridLeader, Me)
            gridLeader.Columns("Voters ID").Width = 100
        Else
            LoadXgridLookupSearch("SELECT votersid as 'Voters ID',precinct as 'Precinct No.', fullname as 'Select Leader' from tblvoters where isleader=0 order by fullname asc ", "tblvoters", txtLeaders, gridLeader, Me)
            gridLeader.Columns("Voters ID").Width = 100
        End If
        gridLeader.Columns("Voters ID").Visible = False
        gridLeader.Columns("Precinct No.").Width = 70
        XgridColAlign("Precinct No.", gridLeader, DevExpress.Utils.HorzAlignment.Center)

    End Sub
    Private Sub txtLeaders_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLeaders.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtLeaders.Properties.View.FocusedRowHandle.ToString)
        votersid.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Voters ID").ToString()
        txtLeaders.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Select Leader").ToString()
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
    End Sub

    Public Sub LoadPrecinct()
        LoadToComboBox("precinct", "tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "'", txtprecintno, True)
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("Please select from voters list.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLeaders.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
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
        ElseIf txtprecintno.Text = "" Then
            XtraMessageBox.Show("Please select Precinct No.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprecintno.Focus()
            Exit Sub
        End If
        Try
            RemoveSpecialChar(PanelControl1)
            If mode.Text <> "edit" Then
                com.CommandText = "DELETE FROM tblleaders where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVE FROM LEADER LIST")
                Dim colorcode As String = qrysingledata1("colorcode", "colorcode", "tblvoters where votersid='" & votersid.Text & "'")
                Dim getid As String = createTRNID("L") & "-" & globaluserid
                com.CommandText = "insert into tblleaders set leadersid='" & getid & "',votersid='" & votersid.Text & "', " _
                                                + " leadername='" & txtLeaders.Text & "', " _
                                                + " areacode='" & areacode.Text & "', " _
                                                + " muncode='" & muncode.Text & "', " _
                                                + " vilcode='" & vilcode.Text & "', " _
                                                + " precinct='" & txtprecintno.Text & "', " _
                                                + " dateentry=current_timestamp, " _
                                                + " entryby='" & globaluserid & "', " _
                                                + " remarks='" & txtRemarks.Text & "', " _
                                                + " isedited=1, " _
                                                + " editedby='" & globaluserid & "', colorcode='" & colorcode & "'"

                com.ExecuteNonQuery() : LogQuery(Me.Text, com.CommandText.ToString, "LEADER ADDED")
                com.CommandText = "update tblvoters set isleader=1 where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "ASSIGNED AS A LEADER")

                XtraMessageBox.Show("Leader " & txtLeaders.Text & " Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                gridLeader.DeleteSelectedRows()
                txtLeaders.Text = ""
                ' txtLeaders.Text = Nothing
                'ClearFields()
            Else
                If countqry("tblleaders", "votersid='" & votersid.Text & "'") <> 0 Then
                    If XtraMessageBox.Show(txtLeaders.Text & " currently already assigned as a leader! do you want to replace existing record?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        com.CommandText = "update tblleaders set votersid='" & votersid.Text & "', " _
                                              + " leadername='" & txtLeaders.Text & "', " _
                                              + " areacode='" & areacode.Text & "', " _
                                              + " muncode='" & muncode.Text & "', " _
                                              + " vilcode='" & vilcode.Text & "', " _
                                              + " precinct='" & txtprecintno.Text & "', " _
                                              + " editedby='" & globaluserid & "', " _
                                              + " remarks='" & txtRemarks.Text & "', " _
                                              + " isedited=1,editedby='" & globaluserid & "' " _
                                              + " where leadersid='" & id.Text & "'"
                        com.ExecuteNonQuery() : LogQuery(Me.Text, com.CommandText.ToString, "LEADER UPDATED")

                        com.CommandText = "update tblvoters set isleader=1 where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "ASSIGNED AS A LEADER")

                        XtraMessageBox.Show("Leader " & txtLeaders.Text & " Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' ClearFields()
                    End If
                End If
            End If
            com.CommandText = "update tblvoters set isedited=1,editedby='" & globaluserid & "' where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        Dim leader As String = "" : Dim area As String = "" : Dim municipal As String = "" : Dim village As String = ""
        Try
            com.CommandText = "select *,(select fullname from tblvoters where votersid = tblleaders.votersid) as 'leader', " _
                                    + " (select areaname from tblarea where areacode = tblleaders.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblleaders.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblleaders.vilcode) as 'village' " _
                                    + "  from tblleaders where leadersid='" & id.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                votersid.Text = rst("votersid").ToString
                leader = rst("leader").ToString
                areacode.Text = rst("areacode").ToString
                area = rst("area").ToString
                muncode.Text = rst("muncode").ToString
                municipal = rst("municipal").ToString
                vilcode.Text = rst("vilcode").ToString
                village = rst("village").ToString
                txtprecintno.Text = rst("precinct").ToString
                txtRemarks.Text = rst("remarks").ToString
            End While
            rst.Close()

            txtLeaders.Text = leader
            txtArea.Text = area
            txtMunicipal.Text = municipal
            txtVillage.Text = village

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ClearFields()
        txtLeaders.Text = ""
        votersid.Text = ""
        mode.Text = ""
        newmode.Text = ""
        id.Text = ""
        newvotersid.Text = ""

        loadLeader()
    End Sub


    Private Sub newmode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newmode.EditValueChanged
        If newmode.Text = "" Then Exit Sub
        Dim leader As String = "" : Dim area As String = "" : Dim municipal As String = "" : Dim village As String = ""
        Try
            com.CommandText = "select *,(select fullname from tblvoters where votersid = tblvoters.votersid) as 'leader', " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.villcode) as 'village' " _
                                    + "  from tblvoters where votersid='" & newvotersid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                votersid.Text = rst("votersid").ToString
                leader = rst("leader").ToString
                areacode.Text = rst("areacode").ToString
                area = rst("area").ToString
                muncode.Text = rst("muncode").ToString
                municipal = rst("municipal").ToString
                vilcode.Text = rst("vilcode").ToString
                village = rst("village").ToString
                txtprecintno.Text = rst("precinct").ToString
            End While
            rst.Close()

            txtLeaders.Text = leader
            txtArea.Text = area
            txtMunicipal.Text = municipal
            txtVillage.Text = village

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub


End Class