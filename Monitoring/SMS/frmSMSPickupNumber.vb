Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports GsmComm.PduConverter
Imports System.IO
Imports GsmComm.GsmCommunication
Imports DevExpress.XtraEditors.Controls

Public Class frmSMSPickupNumber
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmColorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)

    End Sub
    Public Function ComboBoxFilter(ByVal filter As String, ByVal mode As Boolean)
        Dim Coll As ComboBoxItemCollection = txtSearch.Properties.Items
        If mode = True Then
            Coll.Clear()
            com.CommandText = "Select fullname from tblvoters where fullname like '" & rchar(txtSearch.Text) & "%' or votersid like '" & rchar(txtSearch.Text) & "'  and contactnumber<>'' order by fullname asc limit 100"
            rst = com.ExecuteReader
            Coll.BeginUpdate()
            Try
                While rst.Read
                    Coll.Add(rst("fullname"))
                End While
                rst.Close()
            Finally
                Coll.EndUpdate()
            End Try
        End If
        Return Coll
    End Function
    Private Sub txtFilterName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSearch.Text = "" Or txtSearch.Text = "%" Then Exit Sub
            If countqry("tblvoters", "fullname= '" & txtSearch.Text & "' or votersid = '" & rchar(txtSearch.Text) & "' and contactnumber<>''") = 0 Then
                ComboBoxFilter(txtSearch.Text, True)
                txtSearch.ShowPopup()
                Exit Sub
            Else
                txtMobileNumber.Text = qrysingledata1("contactnumber", "contactnumber", "tblvoters where fullname= '" & txtSearch.Text & "' or votersid = '" & rchar(txtSearch.Text) & "' and contactnumber<>''")
            End If
        End If
    End Sub
 
    Private Sub txtMobileNumber_EditValueChanged(sender As Object, e As EventArgs) Handles txtMobileNumber.EditValueChanged
        If txtMobileNumber.Text <> "" Then
            cmdConfirm.Enabled = True
        Else
            cmdConfirm.Enabled = False
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        frmSMSNewMessage.txtCellular.Text = txtMobileNumber.Text
        Me.Close()
    End Sub
End Class