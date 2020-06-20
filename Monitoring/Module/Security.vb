Imports System.Security.Cryptography
Imports System.IO

Module security
    Public GlobalSystemActivated As Boolean

    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " & _
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = _
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function

    Public Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = _
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers = _
            serial_numbers.Substring(2)

        Return serial_numbers
    End Function

    '0 - Super User
    '1 - fullcontrol
    '2 - approver
    '3 - Purchaser
    '4 - read only 


    Public Sub userexit()
        globallogin = False
        globalfullname = ""
        globaldesignation = ""
        globalpermission = 0
        globaluserid = ""
        globalfullname = ""
        globalpass = ""
        globaluser = ""
        conn.Close()
    End Sub


    Const sKey As String = "kira"

    Public Function EncryptTripleDES(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))

    End Function

    Public Function DecryptTripleDES(ByVal sOut As String) As String
        Try
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Message: Invalid encripted data!" & vbCrLf, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End Try
    End Function

    Public Function verifyLicense()
        If System.IO.File.Exists(file_license) = True Then
            Dim sr As StreamReader = File.OpenText(file_license)
            Dim br As String = sr.ReadLine() : sr.Close()
            If br = EncryptTripleDES(CpuId) Then
                GlobalSystemActivated = True
            Else
                GlobalSystemActivated = False
            End If
        Else
            GlobalSystemActivated = False
        End If
        Return GlobalSystemActivated
    End Function
End Module
