Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Module encription
    Public Function encriptdata(ByRef usr As String)

        Dim pass As String = usr
        Dim byteArraypass() As Byte
        Dim hexpass As System.Text.StringBuilder = New System.Text.StringBuilder
        byteArraypass = System.Text.ASCIIEncoding.ASCII.GetBytes(pass)

        For i As Integer = 0 To byteArraypass.Length - 1
            hexpass.Append(byteArraypass(i).ToString("x"))
        Next
        'encriptpass = hexpass.ToString

        Return hexpass.ToString
    End Function
End Module
