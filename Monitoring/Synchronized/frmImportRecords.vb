Imports System.IO
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class frmImportRecords
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmEditedEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
    End Sub
    Public Function ReadFile(ByVal path As String)
        Dim sr As StreamReader = File.OpenText(path)
        Dim input As String
        input = sr.ReadLine()
        txtsqlQuery.Text = ""
        Dim c As Integer
        While Not input Is Nothing
            If countqry("settings.tblactionhistory", "encripteddata='" & input & "'") Then
                XtraMessageBox.Show("Failed importing data! file is already expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                startAsyncButton.Text = "Confirm Update"
                startAsyncButton.Enabled = False
                ' Me.Close()
                Return False
            Else
                startAsyncButton.Enabled = True
            End If
            txtdata.Text = input
            txtsqlQuery.Text = DecryptTripleDES(input)
            input = sr.ReadLine()
        End While
        sr.Close()
        If txtsqlQuery.Text = "False" Then
            startAsyncButton.Enabled = False
        Else
            startAsyncButton.Text = "Confirm Update " & (txtsqlQuery.Lines.Count - 1) & " Total Queries Found"
            startAsyncButton.Enabled = True
        End If
        Return 0
    End Function

    Private Sub startAsyncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startAsyncButton.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = txtsqlQuery.Lines.Count - 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For I = 0 To txtsqlQuery.Lines.Count - 1
                If txtsqlQuery.Lines(I) <> "" Then
                    com.CommandText = txtsqlQuery.Lines(I) : com.ExecuteNonQuery()
                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                End If
            Next
            com.CommandText = "insert into settings.tblactionhistory set daterecord=current_timestamp, encripteddata='" & txtdata.Text & "', remarks='" & ((txtsqlQuery.Lines.Count - 1) / 2) & " Total Rows Imported',trnby='" & globalfullname & "',trntype=0" : com.ExecuteNonQuery()
            txtsqlQuery.Text = ""
            txtdata.Text = ""
            startAsyncButton.Enabled = False
            startAsyncButton.Text = "Confirm Update"
            ProgressBarControl1.Position = 0
            XtraMessageBox.Show("Records Successfully Updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class