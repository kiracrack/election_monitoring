Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports GsmComm.PduConverter
Imports System.IO
Imports GsmComm.GsmCommunication

Public Class frmSMSAddToGroup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmColorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadGroup()
    End Sub

    Public Sub LoadGroup()
        LoadXgridLookupSearch("SELECT id, groupname as 'Group'  from tblsmsgroupname", "tblsmsgroupname", txtGroup, gridGroup, Me)
        gridGroup.Columns("id").Visible = False
    End Sub
    Public Function AddtoList(ByVal itemcode As String)
        ls.Items.Clear()
        For Each word In itemcode.Split(New Char() {"|"c})
            Dim cnt As Integer = 0 : Dim strcode As String = "" : Dim strDescription As String = ""
            For Each item In word.Split(New Char() {":"c})
                If cnt = 0 Then
                    strcode = Trim(item)
                ElseIf cnt = 1 Then
                    strDescription = item
                End If
                cnt = cnt + 1
            Next
            ls.Items.Add(strcode, True)
            ls.Items.Item(strcode).Description = strDescription
            ls.Items.Item(strcode).Value = strcode
        Next
    End Function
    Private Sub txtTemplate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        On Error Resume Next
        trnid.Text = txtGroup.Properties.View.GetFocusedRowCellValue("id").ToString()
    End Sub

    Private Sub btnSendSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendSMS.Click
        Try
            For n = 0 To ls.CheckedItems.Count - 1
                If countqry("tblsmsgroupitem", "groupcode='" & trnid.Text & "' and mobilenumber='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "'") = 0 Then
                    com.CommandText = "insert into tblsmsgroupitem set groupcode='" & trnid.Text & "', mobilenumber='" & ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString & "', fullname='" & rchar(ls.Items.Item(ls.CheckedItems.Item(n)).Description) & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "ADD VOTERS TO SMS GROUP")
                End If
            Next
            XtraMessageBox.Show("Group successfully saved..", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show("Form: SMS Sending" & vbCrLf _
                              & "Message:" & ex.Message & vbCrLf, _
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ls_ItemCheck(sender As Object, e As Controls.ItemCheckEventArgs) Handles ls.ItemCheck
        If ls.CheckedItems.Count > 0 Then
            btnSendSMS.Enabled = True
        Else
            btnSendSMS.Enabled = False
        End If
    End Sub


    Private Sub ls_ItemChecking(sender As Object, e As Controls.ItemCheckingEventArgs) Handles ls.ItemChecking
        If ls.CheckedItems.Count > 0 Then
            btnSendSMS.Enabled = True
        Else
            btnSendSMS.Enabled = False
        End If
    End Sub

 
End Class