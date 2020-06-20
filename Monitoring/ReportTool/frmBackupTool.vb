Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmBackupTool
    Dim UpdateVersion As String = "v13.3.9"
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call connect()

        If XtraMessageBox.Show("Are you sure continue backup data? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Dim MyInput As String = txtKey.Text
            Dim process As System.Diagnostics.Process
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo
            processStartInfo.FileName = "cmd.exe"

            'processStartInfo.Arguments = "mysqldump --opt --password=1234 --user=root --database monitoring -r D:\test.sql"
            If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                processStartInfo.Verb = "runas"
            Else
                ' No need to prompt to run as admin
            End If
            'Dim fbd As New System.Windows.Forms.FolderBrowserDialog
            'Dim selectedFolder As String
            'If fbd.ShowDialog() = DialogResult.OK Then
            If Not Directory.Exists("D:\Database\Monitoring") Then
                Directory.CreateDirectory("D:\Database\Monitoring")
            End If
            Try
                processStartInfo.Arguments = "/C mysqldump --opt --host " & sqlserver & " --password=" & sqlpass & " --user=" & sqluser & " --database " & sqldatabase & " -r  ""D:\Database\Monitoring\" & txtKey.Text & """"
                processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                processStartInfo.UseShellExecute = True
                process = System.Diagnostics.Process.Start(processStartInfo)
                'System.Threading.Thread.Sleep()
                process.WaitForExit()
                If process.HasExited Then
                    XtraMessageBox.Show("Database " & txtKey.Text & " Successfully Backed up!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch errMS As Exception
                XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
 _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'End If


        End If

    End Sub

    Private Sub frmdbUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect()
        loaddata()
    End Sub
    Public Sub loaddata()
        Try
            com.CommandText = "select * from settings.tblsettings"
            rst = com.ExecuteReader
            While rst.Read
                If Val(rst("isserver").ToString) = 0 Then
                    txtKey.Text = "Monitoring(CLIENT_BASE) - " & ConvertDateTime(Now).ToString.Replace(":", "") & ".sql"
                Else
                    txtKey.Text = "Monitoring(SERVER_BASE) - " & ConvertDateTime(Now).ToString.Replace(":", "") & ".sql"
                End If
            End While
            rst.Close()

        Catch errMYSQL As MySqlException
            Button1.Enabled = True
        Catch errMS As Exception
            Button1.Enabled = True
        End Try

    End Sub
End Class