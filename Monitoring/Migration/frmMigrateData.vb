Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports DevExpress.XtraEditors.Controls

Public Class frmMigrateData
    Private count As Integer = 0
    Private records As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub TestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadMunicipal()
    End Sub
    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT distinct((select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode)) as 'Select List', databasename,areacode,muncode from settings.tblmigratehistory order by (select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode) asc ", "settings.tblmigratehistory", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("databasename", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("areacode").Visible = False
        gridMunicipal.Columns("muncode").Visible = False
        gridMunicipal.Columns("databasename").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("areacode").ToString()
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("muncode").ToString()
        databasename.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("databasename").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        CheckStat()
    End Sub

    Public Sub CheckStat()
        lbldate.Text = "Date Time Migration: " & Now.ToString
        tbltotalRecords.Text = "Total Records Ready to Migrate : " & Format(Val(countrecord(databasename.Text & ".tblvoters")), "N0")
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim newvillageid As Boolean = False
        Dim getvillageid As String = qrysingledata("villcode", "villcode", "limit 1", databasename.Text & ".tblvillage")
        Dim getcountexistingdata As String = qrysingledata("cnt", "count(*) as cnt", "where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'", "tblvoters")
        If txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select Color", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        End If
        'Try
        If XtraMessageBox.Show("Are you sure to continue data migration of " & txtMunicipal.Text & "?" & Environment.NewLine & Environment.NewLine _
                                    + "Total existing Records : " & Format(Val(qrysingledata("cnt", "count(*) as cnt", "where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'", "tblvoters")), "N0") & Environment.NewLine _
                                    + tbltotalRecords.Text, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = Val(countrecord(databasename.Text & ".tblvoters"))
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0

            If getvillageid.Length < 13 Then
                com.CommandText = "delete from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO tblvillage (villcode,areacode,muncode,villname,status) " _
                                            + " select concat('" & muncode.Text & "-',villcode),'" & areacode.Text & "', '" & muncode.Text & "',villname,status from " & databasename.Text & ".tblvillage" : com.ExecuteNonQuery()
            Else
                com.CommandText = "delete from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO tblvillage (villcode,areacode,muncode,villname,status) " _
                                            + " select villcode,'" & areacode.Text & "', '" & muncode.Text & "',villname,status from " & databasename.Text & ".tblvillage" : com.ExecuteNonQuery()
            End If
            com.CommandText = "delete from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "'" : com.ExecuteNonQuery()
            dst = New DataSet
            msda = New MySqlDataAdapter("select * from " & databasename.Text & ".tblvoters", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    Dim villageid As String = ""
                    Dim getcolorcode As String = ""
                    If getvillageid.Length < 13 Then
                        villageid = muncode.Text & "-" & .Rows(cnt)("vilcode").ToString()
                    Else
                        villageid = .Rows(cnt)("vilcode").ToString()
                    End If
                    getcolorcode = qrysingledata("servercolorcode", "servercolorcode", "where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and clientcolorcode='" & .Rows(cnt)("colorcode").ToString() & "'", "settings.tblmigratecolor")
                    com.CommandText = "INSERT INTO tblvoters set  " _
                                         + " votersid='" & rchar(.Rows(cnt)("votersid").ToString()) & "', " _
                                         + " precinct='" & rchar(.Rows(cnt)("precinct").ToString()) & "', " _
                                         + " votersno='" & rchar(.Rows(cnt)("votersno").ToString()) & "', " _
                                         + " fullname='" & rchar(.Rows(cnt)("fullname").ToString()) & "', " _
                                         + " address='" & rchar(.Rows(cnt)("address").ToString()) & "', " _
                                         + " bdate='" & rchar(.Rows(cnt)("bdate").ToString()) & "', " _
                                         + " sex='" & rchar(.Rows(cnt)("sex").ToString()) & "', " _
                                         + " vtype='" & rchar(.Rows(cnt)("vtype").ToString()) & "', " _
                                         + " areacode='" & areacode.Text & "', " _
                                         + " muncode='" & muncode.Text & "', " _
                                         + " vilcode='" & villageid & "', " _
                                         + " cluster='" & .Rows(cnt)("cluster").ToString() & "', " _
                                         + " colorcode='" & getcolorcode & "', " _
                                         + " sector='" & .Rows(cnt)("sector").ToString() & "', " _
                                         + " leaderid='" & .Rows(cnt)("leaderid").ToString() & "', " _
                                         + " status='" & .Rows(cnt)("status").ToString() & "', " _
                                         + " dateentry='" & ConvertDateTime(.Rows(cnt)("dateentry").ToString()) & "', " _
                                         + " entryby='" & .Rows(cnt)("entryby").ToString() & "', " _
                                         + " remarks='" & rchar(.Rows(cnt)("remarks").ToString()) & "', " _
                                         + " isleader='" & .Rows(cnt)("isleader").ToString() & "', " _
                                         + " isedited=1, " _
                                         + " editedby='" & globaluserid & "';" : com.ExecuteNonQuery()
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            XtraMessageBox.Show("Records Successfully uploaded!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProgressBarControl1.Position = 0
        End If
        'Catch errMS As Exception
        '    XtraMessageBox.Show(com.CommandText.ToString & Environment.NewLine & Environment.NewLine _
        '                            + "Error: " & errMS.Message, "System Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    If errMS.Message = "Column 'cluster' does not belong to table 0." Then
        '        com.CommandText = "ALTER TABLE `" & databasename.Text & "`.`tblvoters` ADD COLUMN `cluster` INTEGER(11) UNSIGNED NOT NULL DEFAULT 0 AFTER `vilcode`;" : com.ExecuteNonQuery()
        '        XtraMessageBox.Show("System found error ""CLUSTER"" during migration. the selected municipal is now updating database. please click OK ang Migrate again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        '    If errMS.Message = "Column 'sector' does not belong to table 0." Then
        '        com.CommandText = "ALTER TABLE `" & databasename.Text & "`.`tblvoters` ADD COLUMN `sector` TEXT DEFAULT NULL AFTER `colorcode`;" : com.ExecuteNonQuery()
        '        XtraMessageBox.Show("System found error ""SECTOR"" during migration. the selected municipal is now updating database. please click OK ang Migrate again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        'End Try

    End Sub
End Class