Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Public Class frmUploadSystemUpdate
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
  
    Private Sub frmUploadSystemUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtUrl.Text = GlobalDownloadDefaultLocation
        txtDetails.Text = "Monitoring System v" & fversion
        txtVersion.Text = fversion
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
       If txtDetails.Text = "" Then
            MessageBox.Show("Please enter valid details!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDetails.Focus()
            Exit Sub
        ElseIf txtFeatures.Text = "" Then
            MessageBox.Show("Please enter update features!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFeatures.Focus()
            Exit Sub
        ElseIf txtVersion.Text = "" Then
            MessageBox.Show("Please enter update version!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVersion.Focus()
            Exit Sub
        ElseIf txtUrl.Text = "" Then
            MessageBox.Show("Please enter url!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUrl.Focus()
            Exit Sub
        End If
        com.CommandText = "update tblclientsystemupdate set active=0" : com.ExecuteNonQuery()
        com.CommandText = "insert into tblclientsystemupdate set details='" & rchar(txtDetails.Text) & "', version='" & txtVersion.Text & "', downloadurl='" & rchar(txtUrl.Text) & "', features='" & rchar(txtFeatures.Text) & "', password='none', active=1, server=1" : com.ExecuteNonQuery()
        MessageBox.Show("New Version successfully posted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class