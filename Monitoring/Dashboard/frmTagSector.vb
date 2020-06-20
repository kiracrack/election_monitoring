Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTagSector
    Dim strCheckedCode As String
    Dim strCheckedName As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Public Sub LoadSector()
        Dim combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        com.CommandText = "select * from tblsector"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("sectorcode"), False)
            ls.Items.Item(rst("sectorcode")).Description = rst("sectorname").ToString
            ls.Items.Item(rst("sectorcode")).Value = rst("sectorcode").ToString
        End While
        rst.Close()

    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        strCheckedCode = "" : strCheckedName = ""
        If CheckEdit2.Checked = True Then
            selectedSectorCode = ""
            selectedSectorName = "None"
        Else
            If ls.CheckedItems.Count = 0 Then
                XtraMessageBox.Show("There is no selected Sector!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ls.Focus()
                Exit Sub
            End If
            For n = 0 To ls.CheckedItems.Count - 1
                strCheckedCode = strCheckedCode + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "|"
                strCheckedName = strCheckedName + ls.Items.Item(ls.CheckedItems.Item(n)).Description.ToString + ","
            Next

            selectedSectorCode = strCheckedCode.Remove(strCheckedCode.Length - 1, 1)
            selectedSectorName = strCheckedName.Remove(strCheckedName.Length - 1, 1)
        End If
       
        frmVotersEntries.ChangeSector(selectedSectorCode, selectedSectorName)
        Me.Close()
    End Sub

    Private Sub frmColorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadSector()
        For Each word In txtSectors.Text.Split(New Char() {","c})
            For n = 0 To ls.ItemCount - 1
                If ls.Items.Item(n).ToString = word Then
                    ls.Items.Item(n).CheckState = CheckState.Checked
                End If
            Next
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        For n = 0 To ls.ItemCount - 1
            If CheckEdit1.Checked = True Then
                ls.Items.Item(n).CheckState = CheckState.Checked
            Else
                ls.Items.Item(n).CheckState = CheckState.Unchecked
            End If
        Next
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            For n = 0 To ls.ItemCount - 1
                ls.Items.Item(n).CheckState = CheckState.Unchecked
                ls.Enabled = False
            Next
        Else
            ls.Enabled = True
        End If

    End Sub
End Class