Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSMSTemplate
    
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
        LoadXgrid("select id, Title from tblsmstemplate", "tblsmstemplate", Em, GridView1, Me)
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
        com.CommandText = "select * from tblsmstemplate where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtTitle.Text = rst("title").ToString
            txtBody.Text = rst("body").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        If txtTitle.Text = "" Then
            XtraMessageBox.Show("Please enter proper title..", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitle.Focus()
            Exit Sub
        ElseIf txtBody.Text = "" Then
            XtraMessageBox.Show("Please enter template body content", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBody.Focus()
            Exit Sub
        End If
        If trnid.Text = "" Then
            Dim getid As String = createTRNID("T") & "-" & globaluserid
            com.CommandText = "insert into tblsmstemplate set id='" & getid & "', title='" & rchar(txtTitle.Text) & "', body='" & rchar(txtBody.Text) & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED SMS TEMPLATE")
        Else
            com.CommandText = "update tblsmstemplate set title='" & rchar(txtTitle.Text) & "', body='" & rchar(txtBody.Text) & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE SMS TEMPLATE")
        End If
        trnid.Text = "" : txtTitle.Text = "" : txtBody.Text = ""
        filter()
        XtraMessageBox.Show("Template successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtBody_EditValueChanged(sender As Object, e As EventArgs) Handles txtBody.EditValueChanged
        txtsmslimit.Text = 250 - Val(txtBody.Text.Length)
    End Sub
End Class