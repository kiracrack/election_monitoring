Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports GsmComm.PduConverter
Imports System.IO
Imports GsmComm.GsmCommunication

Public Class frmSMSNewMessage
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Control) + Keys.N Then
            cmdPick.PerformClick()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmColorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadTemplate()
    End Sub

    Public Sub LoadTemplate()
        LoadXgridLookupSearch("SELECT id, Title as 'Template',body  from tblsmstemplate", "tblsmstemplate", txtTemplate, gridTemplate, Me)
        gridTemplate.Columns("id").Visible = False : gridTemplate.Columns("body").Visible = False
    End Sub
    Private Sub txtTemplate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemplate.EditValueChanged
        On Error Resume Next
        txtMessage.Text = txtTemplate.Properties.View.GetFocusedRowCellValue("body").ToString()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdPick.Click
        frmSMSPickupNumber.Show(Me)
    End Sub

    Private Sub btnSendSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendSMS.Click
        Try
            If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim cnt As Integer = 1
                For Each word In txtCellular.Text.Split(New Char() {","c})
                    If word <> "" Then
                        Dim pdu As SmsSubmitPdu = New SmsSubmitPdu(txtMessage.Text, Trim(word))
                        MainMonitoring.comm.SendMessage(pdu)
                        Dim getFullname As String = "" : Dim getarea As String = "" : Dim getCity As String = "" : Dim getBarangay As String = "" : Dim getPrecinct As String = ""
                        com.CommandText = "select *, (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay'  from tblvoters where contactnumber='" & Trim(word) & "' or replace(contactnumber,'+63','0')='" & Trim(word) & "'" : rst = com.ExecuteReader
                        While rst.Read
                            getFullname = rst("fullname").ToString
                            getPrecinct = rst("precinct").ToString
                            getarea = rst("area").ToString
                            getCity = rst("municipal").ToString
                            getBarangay = rst("barangay").ToString
                        End While
                        rst.Close()

                        Dim getid As String = createTRNID("O") & cnt.ToString & "-" & globaluserid
                        com.CommandText = "insert into tblsmsoutbox set id='" & getid & "',recipient='" & Trim(word) & "', recipientname='" & rchar(getFullname) & "', " _
                                                    + " area='" & rchar(getarea) & "', " _
                                                    + " city='" & rchar(getCity) & "', " _
                                                    + " barangay='" & rchar(getBarangay) & "', " _
                                                    + " precinct='" & rchar(getPrecinct) & "', " _
                                                    + " message='" & rchar(txtMessage.Text) & "', " _
                                                    + " smsdatetime=current_timestamp, " _
                                                    + " senderid='" & globaluserid & "', " _
                                                    + " groupsms=true " : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "SEND SMS")
                    End If
                    cnt = cnt + 1
                Next
                MainMonitoring.comm.DeleteMessages(DeleteScope.All, GetMessageStorage())
                XtraMessageBox.Show("Message successfully sent..", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Form: SMS Sending" & vbCrLf _
                              & "Message:" & ex.Message & vbCrLf, _
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
 

    Private Sub txtMessage_EditValueChanged(sender As Object, e As EventArgs) Handles txtMessage.EditValueChanged
        If txtCellular.Text <> "" And txtMessage.Text <> "" Then
            btnSendSMS.Enabled = True
        Else
            btnSendSMS.Enabled = False
        End If
    End Sub
End Class