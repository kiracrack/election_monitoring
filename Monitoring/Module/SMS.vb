Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Module SMS
    Public Function GetMessageStorage() As String
        Dim storage As String = String.Empty
        If GLobalSMSStorageType = "PHONE" Then
            storage = PhoneStorageType.Phone
        Else
            storage = PhoneStorageType.Sim
        End If

        If storage.Length = 0 Then
            Throw New ApplicationException("Unknown message storage.")
        Else
            Return storage
        End If
    End Function

    Public Function StatusToString(status As PhoneMessageStatus) As String
        ' Map a message status to a string
        Dim ret As String
        Select Case status
            Case PhoneMessageStatus.All
                ret = "All"
                Exit Select
            Case PhoneMessageStatus.ReceivedRead
                ret = "Read"
                Exit Select
            Case PhoneMessageStatus.ReceivedUnread
                ret = "Unread"
                Exit Select
            Case PhoneMessageStatus.StoredSent
                ret = "Sent"
                Exit Select
            Case PhoneMessageStatus.StoredUnsent
                ret = "Unsent"
                Exit Select
            Case Else
                ret = "Unknown (" & status.ToString() & ")"
                Exit Select
        End Select
        Return ret
    End Function

End Module
