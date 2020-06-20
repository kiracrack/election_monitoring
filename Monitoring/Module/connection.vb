Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Threading

Module Connection
    Public conn As New MySqlConnection 'for MySQLDatabase Connection
    Public msda As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dst As New DataSet 'miniature of your table - cache table to client

    Public msda2 As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dst2 As New DataSet 'miniature of your table - cache table to client

    Public com As New MySqlCommand
    Public rst As MySqlDataReader
    Public cb As MySqlCommandBuilder

    Public GLobalSMSPort As String
    Public GLobalSMSModemName As String
    Public GLobalSMSStorageType As String
    Public GLobalSMSEnable As Boolean

    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String
    Public sqljoinbase As String
    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"
    Public file_license As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".lic"
    Public file_smsport As String = Application.StartupPath.ToString & "\sms.port"
    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader
    Public ConnectedServer As Boolean = False

    Public clientserver As String
    Public clientuser As String
    Public clientpass As String
    Public clientport As String
    Public clientdatabase As String

    Public SystemServer As Integer
    Public singleuse As String = ""


    Public Sub connect()
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlserver = word
            ElseIf cnt = 1 Then
                sqlport = word
            ElseIf cnt = 2 Then
                sqluser = word
            ElseIf cnt = 3 Then
                sqlpass = word
            ElseIf cnt = 4 Then
                sqldatabase = word
            ElseIf cnt = 5 Then
                sqljoinbase = word
            End If
            cnt = cnt + 1
        Next
        Try
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & " ; password=" & sqlpass & " ; database=" & sqldatabase & " ; Allow Zero Datetime=True ; Connection Timeout=28800 ; allow user variables=true"
            'conString = "server=" & sqlserver & ";  Port=" & sqlport & "; user=" & sqluser & " ; password=" & sqlpass & "; database=" & sqldatabase & "; Allow Zero Datetime=True ; Connection Timeout=28800"
            com.CommandTimeout = 28800
            com.Connection = conn
            conn.Open()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        End Try
    End Sub
    Public Sub Changeserver()
        Try
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=10; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 0
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            Exit Sub
        End Try
    End Sub

    Public Function CheckConnServer() As Boolean
        Try
            com.CommandText = "select * from settings.tblsettings"
            rst = com.ExecuteReader
            While rst.Read
                clientserver = rst("clientserver").ToString
                clientuser = rst("clientuser").ToString
                clientpass = rst("clientpass").ToString
                clientdatabase = sqldatabase
            End While
            rst.Close()
            connclient = New MySql.Data.MySqlClient.MySqlConnection
            connclient.ConnectionString = "server=" & clientserver & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=60; Allow Zero Datetime=True; allow user variables=true"
            connclient.Open()
            comclient.Connection = connclient
            CheckConnServer = True
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            CheckConnServer = False
            Exit Function
        Catch errMS As Exception
            XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
            CheckConnServer = False
            Exit Function
        End Try
        Return CheckConnServer
    End Function
    Public constatus As Boolean = False
    Public Sub OpenClientServer()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            Try
                If globalconnsync = False Then
                    My.Application.OpenForms.Item(i).Cursor = Cursors.WaitCursor
                End If
                connclient = New MySql.Data.MySqlClient.MySqlConnection
                connclient.ConnectionString = "server=" & clientserver & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=10; Allow Zero Datetime=True; allow user variables=true"
                connclient.Open()
                constatus = True
                comclient.Connection = connclient
            Catch errMYSQL As MySqlException
                XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                                 & "Message:" & errMYSQL.Message & vbCrLf, _
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PrintError()
                constatus = False
                My.Application.OpenForms.Item(i).Cursor = Cursors.Default
                Exit For
                Exit Sub
            Catch errMS As Exception
                XtraMessageBox.Show("Form: Connection Server" & vbCrLf _
                                 & "Message:" & errMS.Message & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PrintError()
                constatus = False
                My.Application.OpenForms.Item(i).Cursor = Cursors.Default
                Exit For
                Exit Sub
            End Try
            If globalconnsync = False Then
                My.Application.OpenForms.Item(i).Cursor = Cursors.Default
            End If
            Exit For
        Next i
    End Sub

    Public Sub LoadSMSFileSetup()
        Dim strSetup As String = ""
        If System.IO.File.Exists(file_smsport) = True Then
            GLobalSMSEnable = True
            Dim sr As StreamReader = File.OpenText(file_smsport)
            Dim br As String = sr.ReadLine() : sr.Close()
            strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
            For Each word In strSetup.Split(New Char() {","c})
                If cnt = 0 Then
                    GLobalSMSPort = word
                ElseIf cnt = 1 Then
                    GLobalSMSModemName = word
                ElseIf cnt = 2 Then
                    GLobalSMSStorageType = word
                End If
                cnt = cnt + 1
            Next
        Else
            GLobalSMSEnable = False
        End If
    End Sub
End Module
