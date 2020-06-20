Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSMSGroup

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSMSTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcon(Me)
        filter()
    End Sub
    Public Sub filter()
        LoadXgrid("select id, groupname as 'SMS Group' from tblsmsgroupname", "tblsmsgroupname", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
    End Sub

    Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
        trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        showInfo()
    End Sub

    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click
        trnid.Text = GridView1.GetFocusedRowCellValue("id").ToString
        showInfo()
    End Sub
    Public Sub showInfo()
        com.CommandText = "select * from tblsmsgroupname where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtTitle.Text = rst("groupname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtTitle.Text = "" Then
            XtraMessageBox.Show("Please enter proper group name..", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitle.Focus()
            Exit Sub
        
        End If
        If trnid.Text = "" Then
            Dim getid As String = createTRNID("G") & "-" & globaluserid
            com.CommandText = "insert into tblsmsgroupname set id='" & getid & "', groupname='" & rchar(txtTitle.Text) & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED SMS GROUP")
        Else
            com.CommandText = "update tblsmsgroupname set groupname='" & rchar(txtTitle.Text) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE SMS GROUP")
        End If
        trnid.Text = "" : txtTitle.Text = ""
        filter()
        XtraMessageBox.Show("Group successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

   
End Class