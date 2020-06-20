Imports DevExpress.XtraEditors

Public Class frmSynchronizedHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmImportedList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("select id,encripteddata,date_format(daterecord,'%Y-%m-%d %r') as 'Date Record', Remarks,case when trntype=1 then 'Auto Backup' when trntype=2 then 'Manual Backup' end as 'Action Type', trnby as 'Modified By',restorenum as 'Restored' from settings.tblactionhistory where (trntype=1 OR trntype=2) order by daterecord desc", "settings.tblactionhistory", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        GridView1.Columns("encripteddata").Visible = False
        XgridColAlign("Restored", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Date Record").Width = 160
        GridView1.Columns("Remarks").Width = 200
        GridView1.Columns("Modified By").Width = 140
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to continue restore backup edited Records? " & Environment.NewLine & Environment.NewLine & "Note: pending edited records on the list will be deleted due to restoration of backup.", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from settings.tblactionquerylogs" : com.ExecuteNonQuery()
            com.CommandText = "insert into settings.tblactionquerylogs (dateperformed,editedtype,querytask,remarks,status,performedby,img) select dateperformed,editedtype,querytask,remarks,status,performedby,img from settings.tblactionbackuplogs where batchcode='" & GridView1.GetFocusedRowCellValue("encripteddata").ToString & "' order by dateperformed asc" : com.ExecuteNonQuery()
            com.CommandText = "update settings.tblactionhistory set restorenum=restorenum+1 where id='" & GridView1.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            filter()
            XtraMessageBox.Show("Records Successfully Retored!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class