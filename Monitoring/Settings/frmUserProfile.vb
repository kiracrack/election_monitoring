Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Public Class frmUserProfile
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUserProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True)
        LoadSkins()
        editProfile()
    End Sub
    Public Sub LoadSkins()
        Dim skins As New SkinContainerCollection
        skins = SkinManager.Default.Skins
        Dim I As Integer = 0
        txttheme.Properties.Items.Clear()
        For I = 0 To skins.Count - 1
            txttheme.Properties.Items.Add(skins(I).SkinName)
        Next
    End Sub

    Private Sub txttheme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttheme.SelectedIndexChanged
        UserLookAndFeel.Default.SetSkinStyle(txttheme.SelectedItem.ToString())
    End Sub

    Public Sub editProfile()
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing
        txtpassword.Properties.ReadOnly = True
        txtverify.Properties.ReadOnly = True
        Dim stroffice As String = ""
        com.CommandText = "select * from tblaccounts where accountid='" & globaluserid & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtdesignation.Text = rst("designation").ToString
            txtusername.Text = rst("username").ToString
            txttheme.Text = rst("theme").ToString
            txtLeader.Text = rst("defaultleaderbackcolor").ToString
            txtMember.Text = rst("defaultforecolormember").ToString
        End While
        rst.Close()
        mode.Text = "edit"
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If txtfullname.Text = "" Then
            XtraMessageBox.Show("Please enter fullname.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtdesignation.Text = "" Then
            XtraMessageBox.Show("Please select designation.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            XtraMessageBox.Show("Please enter username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub


        ElseIf txtCurrentPassword.Text = "" And ckChangePassword.Checked = True Then
            XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub

        ElseIf EncryptTripleDES(txtCurrentPassword.Text) <> globalpass And ckChangePassword.Checked = True Then
            XtraMessageBox.Show("Current password did not match on your database password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub

        ElseIf txtpassword.Text = "" And ckChangePassword.Checked = True Then
            XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        ElseIf txtverify.Text = "" And ckChangePassword.Checked = True Then
            XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtverify.Focus()
            Exit Sub
        ElseIf txtpassword.Text <> txtverify.Text And ckChangePassword.Checked = True Then
            XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Text = ""
            txtverify.Text = ""
            txtpassword.Focus()
            Exit Sub
        End If

        If XtraMessageBox.Show("Are you sure you want to update your account " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblaccounts set fullname = '" & txtfullname.Text & "', " _
                             + " designation='" & txtdesignation.Text & "', " _
                             + If(ckChangePassword.Checked = True, "password='" & EncryptTripleDES(txtverify.Text) & "',", "") _
                             + " theme='" & txttheme.Text & "', defaultleaderbackcolor='" & txtLeader.Text & "', defaultforecolormember='" & txtMember.Text & "'" _
                             + " where accountid='" & globaluserid & "' "
            com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE USER PROFILE")
            loadglobaluser()
            globaltheme = txttheme.Text
            MainMonitoring.InitSkins()
            MainMonitoring.loadStatus()
            XtraMessageBox.Show("User successfully updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
 
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub ckChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles ckChangePassword.CheckedChanged
        If ckChangePassword.Checked = True Then
            txtCurrentPassword.Properties.ReadOnly = False
            txtpassword.Properties.ReadOnly = False
            txtverify.Properties.ReadOnly = False
        Else
            txtCurrentPassword.Properties.ReadOnly = True
            txtpassword.Properties.ReadOnly = True
            txtverify.Properties.ReadOnly = True
        End If
    End Sub
End Class