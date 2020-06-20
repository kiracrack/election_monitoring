Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Public Class frmChangePass
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUserProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
    End Sub
     
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If txtpassword.Text = "" Then
            XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        ElseIf txtverify.Text = "" Then
            XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtverify.Focus()
            Exit Sub
        ElseIf txtpassword.Text <> txtverify.Text Then
            XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Text = ""
            txtverify.Text = ""
            txtpassword.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblaccounts set password='" & EncryptTripleDES(txtverify.Text) & "' where accountid='" & userid.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "(" & userid.Text & ") PASSWORD CHANGED")
            XtraMessageBox.Show("Password successfully changed", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class