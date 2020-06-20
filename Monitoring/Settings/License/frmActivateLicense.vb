Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmActivateLicense
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F12) Then

            txtActivationCode.Text = EncryptTripleDES(txtSystemKey.Text)
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtSystemKey.Text = CpuId()
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtActivationCode.Text = "" Then
            MessageBox.Show("Please enter activation key!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtActivationCode.Focus()
            Exit Sub
        ElseIf txtActivationCode.Text <> EncryptTripleDES(txtSystemKey.Text) Then
            MessageBox.Show("Please enter valid activation key!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtActivationCode.Focus()
            Exit Sub
        End If

        Try
            If System.IO.File.Exists(file_license) = True Then
                System.IO.File.Delete(file_license)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(file_license, True)
            detailsFile.WriteLine(txtActivationCode.Text)
            detailsFile.Close()

            Dim Download_location As String = Application.StartupPath.ToString & "\UpdateVersion\"
            If (System.IO.Directory.Exists(Download_location)) Then
                My.Computer.FileSystem.DeleteDirectory(Download_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            verifyLicense()
            MessageBox.Show("System successfully activated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        End
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

    End Sub
End Class