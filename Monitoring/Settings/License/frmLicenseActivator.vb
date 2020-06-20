Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmLicenseActivator

    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtSystemKey.Text = "" Then
            MessageBox.Show("Please enter system serial code!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSystemKey.Focus()
            Exit Sub
        End If

        Try
            txtActivationCode.Text = EncryptTripleDES(txtSystemKey.Text)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        End
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

    End Sub
End Class