Imports DevExpress.XtraEditors

Public Class frmTransferVoters
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If txtLeaders.Text = "" Then
            XtraMessageBox.Show("please Select new Leader to change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLeaders.Focus()
            Exit Sub
        End If
        If mode.Text = "voters" Then
            frmVotersEntries.VotersTransfer(votersid.Text, oldLeaderId.Text, colorcode.Text)
        Else
            frmLeaderInformation.VotersTransfer(votersid.Text, colorcode.Text)
        End If

        XtraMessageBox.Show("Voters successfully transfered!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Public Sub ClearFields()
        txtLeaders.Text = ""
        votersid.Text = ""
        mode.Text = ""
        loadLeader()
    End Sub
    Private Sub frmChangeLeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadLeader()
    End Sub

    Public Sub loadLeader()
        LoadXgridLookupSearch("SELECT colorcode,votersid as 'Voters ID', " _
                                    + " fullname as 'Select Leader' " _
                                    + " from tblvoters where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' and vilcode='" & vilcode.Text & "' and votersid<>'" & oldLeaderId.Text & "' and isleader=1 order by fullname asc ", "tblvoters", txtLeaders, gridLeader, Me)
        gridLeader.Columns("colorcode").Visible = False
        gridLeader.Columns("Voters ID").Visible = False
    End Sub
    Private Sub txtLeaders_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLeaders.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtLeaders.Properties.View.FocusedRowHandle.ToString)
        votersid.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Voters ID").ToString()
        txtLeaders.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("Select Leader").ToString()
        colorcode.Text = txtLeaders.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

End Class