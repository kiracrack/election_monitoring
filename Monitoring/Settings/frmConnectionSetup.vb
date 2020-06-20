Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmConnectionSetup
    Private Sub frmConnectionSetup_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() 
        clientserver = ""
        clientuser = ""
        clientpass = ""
        clientdatabase = ""
        connclient.Close()
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtServerhost.Text = "" Then
            MessageBox.Show("Please enter Server host!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerhost.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        clientserver = txtServerhost.Text
        clientport = txtPort.Text
        clientuser = txtusername.Text
        clientpass = txtpassword.Text
        clientdatabase = txtDatabase.Text
        OpenClientServer()
        If connclient.State <> 0 Then
            Try
                If System.IO.File.Exists(file_conn) = True Then
                    System.IO.File.Delete(file_conn)
                End If
                Dim detailsFile As StreamWriter = Nothing
                detailsFile = New StreamWriter(file_conn, True)
                detailsFile.WriteLine(EncryptTripleDES(txtServerhost.Text & "," & txtPort.Text & "," & txtusername.Text & "," & txtpassword.Text & "," & txtDatabase.Text))
                detailsFile.Close()

                MessageBox.Show("System successfully activated", "Katipunan Bank Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End
            Catch errMYSQL As MySqlException
                MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                                & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Catch errMS As Exception
                MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        End
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

    End Sub
End Class