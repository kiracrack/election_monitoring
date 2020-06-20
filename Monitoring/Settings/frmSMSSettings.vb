Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frmSMSSettings
    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim strSetup As String = ""
        If System.IO.File.Exists(file_smsport) = True Then
            ckEnableSMS.Checked = True
            Dim sr As StreamReader = File.OpenText(file_smsport)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 0 Then
                    txtComport.Text = word
                ElseIf cnt = 1 Then
                    txtModemName.Text = word
                ElseIf cnt = 2 Then
                    txtStorage.Text = word
                End If
                cnt = cnt + 1
            Next
        Else
            ckEnableSMS.Checked = False
        End If
    End Sub

    Private Sub ckEnableSMS_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableSMS.CheckedChanged
        If ckEnableSMS.Checked = True Then
            txtComport.Enabled = True
            txtModemName.Enabled = True
            txtStorage.Enabled = True
            cmdaction.Text = "Activate"
        Else
            txtComport.Enabled = False
            txtModemName.Enabled = False
            txtStorage.Enabled = False
            cmdaction.Text = "Save"
        End If
    End Sub

    Private Sub cmdaction_Click(sender As Object, e As EventArgs) Handles cmdaction.Click
        Try
            If txtComport.Text = "" And ckEnableSMS.Checked = True Then
                MsgBox("Please select Port Number", MsgBoxStyle.Exclamation)
                txtComport.Focus()
                Exit Sub
            ElseIf txtStorage.Text = "" And ckEnableSMS.Checked = True Then
                MsgBox("Please select Storage Type", MsgBoxStyle.Exclamation)
                txtStorage.Focus()
                Exit Sub
            End If
            If ckEnableSMS.Checked = True Then
                If System.IO.File.Exists(file_smsport) = True Then
                    System.IO.File.Delete(file_smsport)
                End If
                Dim detailsFile As StreamWriter = Nothing
                detailsFile = New StreamWriter(file_smsport, True)
                detailsFile.WriteLine(EncryptTripleDES(txtComport.Text & "," & txtModemName.Text & "," & txtStorage.Text))
                detailsFile.Close()
                If ckEnableSMS.Checked = True Then
                    LoadSMSFileSetup()
                    MainMonitoring.LoadSMSSetup()
                End If
                MessageBox.Show("your settings successfully activated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                If System.IO.File.Exists(file_smsport) = True Then
                    System.IO.File.Delete(file_smsport)
                End If
                GLobalSMSEnable = False
                MessageBox.Show("your settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        Process.Start("devmgmt.msc")
    End Sub
End Class