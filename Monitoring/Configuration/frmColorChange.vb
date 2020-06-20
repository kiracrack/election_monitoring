Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmColorChange
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Public Sub loadColor()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from tblcolor", "tblcolor", txtcolor, gridcolor, Me)
        gridcolor.Columns("colorcode").Visible = False
        gridcolor.Columns("colorname").Visible = False
        gridcolor.Columns("Color").Width = 40
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridcolor.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Private Sub txtcolor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolor.Properties.View.FocusedRowHandle.ToString)
        colorcode.Text = txtcolor.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        colorname.Text = txtcolor.Properties.View.GetFocusedRowCellValue("colorname").ToString()
        txtcolor.Text = txtcolor.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If txtcolor.Text = "" Then
            XtraMessageBox.Show("There is no color selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcolor.Focus()
            Exit Sub
        End If
        selectedColorCode = colorcode.Text
        selectedColorname = colorname.Text
        If mode.Text = "voters" Then
            frmVotersEntries.ChangeColor(selectedColorCode, selectedColorname)
        ElseIf mode.Text = "leader" Then
            frmLeaders.ChangeColor(selectedColorCode, selectedColorname)
        ElseIf mode.Text = "leaderinfo" Then
            frmLeaderInformation.ChangeColor(selectedColorCode, selectedColorname)
        ElseIf mode.Text = "subleaderinfo" Then
            frmSubMemberInfo.ChangeColor(selectedColorCode, selectedColorname)
        Else
            frmLeaderInformation.ChangeColor(selectedColorCode, selectedColorname)
        End If
        Me.Close()
    End Sub

    Private Sub frmColorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadColor()
        colorcode.Text = selectedColorCode
        colorname.Text = selectedColorname
    End Sub
End Class