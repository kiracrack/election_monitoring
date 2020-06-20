Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmSystemOwnerConfirmation
    Private Sub frmBackuptool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
  
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar() = Chr(13) Then
            If EncryptTripleDES(txtpassword.Text) = "MLth/jjnhYzQMNY17/DpUQ==" Then
                frmLicenseActivator.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid system password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
End Class