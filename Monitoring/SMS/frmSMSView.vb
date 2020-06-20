Imports DevExpress.XtraEditors
Imports System.IO
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSMSView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private WithEvents comm As GsmCommMain
    Private Delegate Sub SetTextCallback(ByVal text As String)

    Private Sub frmSMSView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtBoxSelect.SelectedIndex = 0
        DoThreadedStuff()
    End Sub
   
    Public Sub DoThreadedStuff()
        If txtBoxSelect.SelectedIndex = 0 Then
            If Me.InvokeRequired Then
                Me.Invoke(Sub() ViewSMsActive())
            Else
                ViewSMsActive()
            End If
        ElseIf txtBoxSelect.SelectedIndex = 1 Then
            If Me.InvokeRequired Then
                Me.Invoke(Sub() ViewSMsOutbox())
            Else
                ViewSMsOutbox()
            End If
        ElseIf txtBoxSelect.SelectedIndex = 2 Then
            If Me.InvokeRequired Then
                Me.Invoke(Sub() ViewSMsDeleted())
            Else
                ViewSMsDeleted()
            End If
        End If
        
    End Sub
    Public Function ViewSMsActive()
        LoadXgrid("select  id, sender as Number, if(sendername='',sender,sendername) as 'Sender', if(message like '%é@ø%',mid(message,8, CHAR_LENGTH(message)-8),message) as 'Message', smsdatetime as 'Date',area as 'District',city as 'City/Municipal', Barangay, Precinct, isread  from tblsmsinbox where deleted=0 order by smsdatetime desc", "tblsmsinbox", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("isread").Visible = False
        GridView1.Columns("Number").Visible = False
        GridView1.Columns("Message").Width = 300
        XgridColAlign("Precinct", GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Function
    Public Function ViewSMsOutbox()
        LoadXgrid("select  id, recipient as Number,  if(recipientname='',recipient,recipientname) as 'Recipient', Message, smsdatetime as 'Date',area as 'District',city as 'City/Municipal', Barangay,  Precinct, (select fullname from tblaccounts where accountid =tblsmsoutbox.senderid) as 'Sent By' from tblsmsoutbox order by smsdatetime desc", "tblsmsoutbox", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("Number").Visible = False
        GridView1.Columns("Message").Width = 300
        XgridColAlign("Precinct", GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Function
    Public Function ViewSMsDeleted()
        LoadXgrid("select  id, sender as Number,  if(sendername='',sender,sendername) as 'Sender', if(message like '%é@ø%',mid(message,8, CHAR_LENGTH(message)-8),message) as 'Message', smsdatetime as 'Date',area as 'District',city as 'City/Municipal', Barangay,  Precinct, isread,deletedby as 'Deleted By', datedeleted as 'Date Deleted'  from tblsmsinbox where deleted=1 order by smsdatetime desc", "tblsmsinbox", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("isread").Visible = False
        GridView1.Columns("Number").Visible = False
        GridView1.Columns("Message").Width = 300
        XgridColAlign("Precinct", GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Function
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        On Error Resume Next
        Dim View As GridView = sender
        If txtBoxSelect.SelectedIndex = 0 Then
            If CBool(View.GetRowCellDisplayText(e.RowHandle, View.Columns("isread")).ToString) = False Then
                e.Appearance.BackColor = Color.LemonChiffon
                e.Appearance.ForeColor = Color.Black
                e.Appearance.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
            End If
        End If
    End Sub
  
    Private Sub ShowException(ByVal ex As Exception)
        MsgBox("Error: " + ex.Message + " (" + ex.GetType().ToString() + ")")
    End Sub

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Sender") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently remove this message? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "update tblsmsinbox set deleted=1,deletedby='" & globalfullname & "',datedeleted=current_timestamp where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "DELETE SMS")
            Next
            DoThreadedStuff()
            MainMonitoring.ShowPendingSms()
        End If
    End Sub

    Private Sub MarkAsReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsReadToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Sender") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "isread") = "0" Then
                com.CommandText = "update tblsmsinbox set isread=1 where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE SMS AS READ")
            End If
        Next
        DoThreadedStuff()
        MainMonitoring.ShowPendingSms()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        DoThreadedStuff()
    End Sub
     
 
    Private Sub txtBoxSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBoxSelect.SelectedIndexChanged
        DoThreadedStuff()
    End Sub

    Private Sub cmdOnholdTransaction_Click(sender As Object, e As EventArgs) Handles cmdOnholdTransaction.Click
        frmSMSTemplate.ShowDialog(Me)
    End Sub

    Private Sub cmdClosedAccount_Click(sender As Object, e As EventArgs) Handles cmdClosedAccount.Click
        frmSMSNewMessage.Show(Me)
    End Sub

    Private Sub ReplyToSenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplyToSenderToolStripMenuItem.Click
        frmSMSNewMessage.Text = GridView1.GetFocusedRowCellValue("Sender").ToString
        frmSMSNewMessage.txtCellular.Text = GridView1.GetFocusedRowCellValue("Number").ToString
        frmSMSNewMessage.Show(Me)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmSMSGroup.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmSMSGroupMessage.Show(Me)
    End Sub

    Private Sub AssignLeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignLeadersToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("isread").ToString = "0" Then
            com.CommandText = "update tblsmsinbox set isread=1 where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE SMS AS READ")
            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "isread", "1")
        End If
        MainMonitoring.ShowPendingSms()
        frmSMSViewMessage.Text = GridView1.GetFocusedRowCellValue("Sender").ToString
        frmSMSViewMessage.txtsmsContent.Text = GridView1.GetFocusedRowCellValue("Message").ToString
        frmSMSViewMessage.txtCellular.Text = GridView1.GetFocusedRowCellValue("Number").ToString
        frmSMSViewMessage.Show(Me)
    End Sub

    Private Sub Em_DoubleClick(sender As Object, e As EventArgs) Handles Em.DoubleClick
        AssignLeadersToolStripMenuItem.PerformClick()
    End Sub

    Private Sub RegisterNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNumberToolStripMenuItem.Click
        frmSMSRegisterNumber.txtMobileNumber.Text = GridView1.GetFocusedRowCellValue("Number").ToString
        frmSMSRegisterNumber.Show(Me)
    End Sub
End Class