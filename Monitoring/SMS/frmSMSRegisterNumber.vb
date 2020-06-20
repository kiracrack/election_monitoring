Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports GsmComm.PduConverter
Imports System.IO
Imports GsmComm.GsmCommunication
Imports DevExpress.XtraEditors.Controls

Public Class frmSMSRegisterNumber
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
            com.CommandText = "Select fullname from tblvoters where fullname like '" & rchar(txtSearch.Text) & "%' or votersid like '%" & rchar(txtSearch.Text) & "%'  order by fullname asc limit 100"
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
            If countqry("tblvoters", "fullname= '" & txtSearch.Text & "' or votersid = '" & rchar(txtSearch.Text) & "'") = 0 Then
                ComboBoxFilter(txtSearch.Text, True)
                txtSearch.ShowPopup()
                Exit Sub
            Else
                votersid.Text = qrysingledata1("votersid", "votersid", "tblvoters where fullname= '" & txtSearch.Text & "' or votersid = '" & rchar(txtSearch.Text) & "'")
            End If
        End If
    End Sub

    Private Sub votersid_EditValueChanged(sender As Object, e As EventArgs) Handles votersid.EditValueChanged
        If votersid.Text <> "" Then
            cmdConfirm.Enabled = True
        Else
            cmdConfirm.Enabled = False
        End If
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If countqry("tblvoters", "contactnumber='" & txtMobileNumber.Text & "'") > 0 Then
            XtraMessageBox.Show("Mobile number already registered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMobileNumber.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tblvoters set contactnumber='" & txtMobileNumber.Text & "' where votersid = '" & votersid.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "REGISTERED NEW NUMBER")
            Dim getFullname As String = "" : Dim getarea As String = "" : Dim getCity As String = "" : Dim getBarangay As String = "" : Dim getPrecinct As String = ""
            com.CommandText = "select *, (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                        + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                        + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay'  from tblvoters where votersid='" & votersid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                getFullname = rst("fullname").ToString
                getPrecinct = rst("precinct").ToString
                getarea = rst("area").ToString
                getCity = rst("municipal").ToString
                getBarangay = rst("barangay").ToString
            End While
            rst.Close()

            If countqry("tblsmsinbox", "sender='" & txtMobileNumber.Text & "' and sendername=''") > 0 Then
                com.CommandText = "update tblsmsinbox set sendername='" & rchar(getFullname) & "',area='" & rchar(getarea) & "',city='" & rchar(getCity) & "', barangay='" & rchar(getBarangay) & "', precinct='" & rchar(getPrecinct) & "', purok='' where sender='" & txtMobileNumber.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE UNREGISTER SMS LIST OF " & UCase(getFullname))
            End If
            frmSMSView.ViewSMsActive()
            XtraMessageBox.Show("Number successfully registered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

End Class