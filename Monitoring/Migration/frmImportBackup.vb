Imports DevExpress.XtraEditors
Imports System.IO

Public Class frmImportBackup
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmCaptureBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadArea()
    End Sub
    Public Sub loadArea()
        LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtArea.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtArea.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtArea.Text = txtArea.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadMunicipal()
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
    End Sub
    Private Sub txtpath_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtpath.ButtonClick
        'Declare a OpenFileDialog object
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Sql files (*.sql)|*.sql|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                'Read the contents of the file
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'Display the file contents in the TextBox
                txtpath.Text = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try

        End If

        'Clean up
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Sub cmdCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        On Error Resume Next
        If txtpath.Text = "" Then
            XtraMessageBox.Show("Please select backupfile.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpath.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to save backup Database?" & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If txtpath.Text <> "" Then
                Dim linesList As New List(Of String)(File.ReadAllLines(txtpath.Text))

                'Remove the line to delete, e.g.
                'If linesList.IndexOf("CREATE DATABASE /*!32312 IF NOT EXISTS*/ `" & sqldatabase & "` /*!40100 DEFAULT CHARACTER SET latin1 */;") = 0 Then
                '    XtraMessageBox.Show("Invalid file backup! please select valid backup file", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If
                linesList.RemoveAt(linesList.IndexOf("CREATE DATABASE IF NOT EXISTS monitoring;"))
                linesList.RemoveAt(linesList.IndexOf("CREATE DATABASE IF NOT EXISTS `" & sqldatabase & "`;"))
                linesList.RemoveAt(linesList.IndexOf("CREATE DATABASE /*!32312 IF NOT EXISTS*/ `" & sqldatabase & "` /*!40100 DEFAULT CHARACTER SET latin1 */;"))
                linesList.RemoveAt(linesList.IndexOf("USE `" & sqldatabase & "`;"))
                linesList.RemoveAt(linesList.IndexOf("USE monitoring;"))

                File.WriteAllLines(txtpath.Text, linesList.ToArray())

                Dim process As System.Diagnostics.Process
                Dim processStartInfo As System.Diagnostics.ProcessStartInfo
                processStartInfo = New System.Diagnostics.ProcessStartInfo
                processStartInfo.FileName = "cmd.exe"
                'If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                '    processStartInfo.Verb = "runas"
                'Else
                '    ' No need to prompt to run as admin
                'End If
                com.CommandText = "create database IF NOT EXISTS `db_" & LCase(remDataChar(txtMunicipal.Text)) & "`;" : com.ExecuteNonQuery()
                processStartInfo.Arguments = "/C mysql -h localhost -uroot -p12sysadmin34 db_" & LCase(remDataChar(txtMunicipal.Text)) & " < """ & txtpath.Text & """"
                ' MsgBox("/C mysql -h localhost -uroot -p12sysadmin34 < """ & sqlpath & """")
                processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                processStartInfo.UseShellExecute = True
                process = System.Diagnostics.Process.Start(processStartInfo)
                'System.Threading.Thread.Sleep()
                process.WaitForExit()
                If process.HasExited Then
                    com.CommandText = "insert into settings.tblmigratehistory set dateimport=current_timestamp, areacode='" & areacode.Text & "', muncode='" & muncode.Text & "',databasename='db_" & LCase(remDataChar(txtMunicipal.Text)) & "', importby='" & globalfullname & "'" : com.ExecuteNonQuery()
                    XtraMessageBox.Show("Backup database successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Public Function remDataChar(ByVal txt As String)
        Dim removechar As Char() = "/\.: ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim str As String = txt
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString()
    End Function

    Private Sub txtpath_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpath.EditValueChanged

    End Sub
End Class