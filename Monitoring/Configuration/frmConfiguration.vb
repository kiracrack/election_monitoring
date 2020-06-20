Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmConfiguration

    Private Sub frmConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)

        com.CommandText = "select *,(select description from tblcolor where colorcode = tblconfiguration.defleadercolor) as leadercolor," _
                                + " (select description from tblcolor where colorcode = tblconfiguration.defmembercolor) as membercolor from tblconfiguration"
        rst = com.ExecuteReader
        While rst.Read
            leadercode.Text = rst("defleadercolor").ToString
            txtcolorleader.Text = rst("leadercolor").ToString

            membercode.Text = rst("defmembercolor").ToString
            txtcolormember.Text = rst("membercolor").ToString

            ckAutoColorChange.Checked = rst("autocolorleadersmember")
            ckMultipleSelectIDPrint.Checked = rst("multipleidprint")
            ckShowIDPrintPreview.Checked = rst("showidprintpreview")
        End While
        rst.Close()

        loadColorLeader()
        loadColorMemeber()
    End Sub
    Public Sub loadColorLeader()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from tblcolor", "tblcolor", txtcolorleader, leadercolor, Me)
        leadercolor.Columns("colorcode").Visible = False
        leadercolor.Columns("colorname").Visible = False
        leadercolor.Columns("Color").Width = 40
    End Sub
    Private Sub GridView1Leader_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles leadercolor.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Public Sub loadColorMemeber()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from tblcolor", "tblcolor", txtcolormember, membercolor, Me)
        membercolor.Columns("colorcode").Visible = False
        membercolor.Columns("colorname").Visible = False
        membercolor.Columns("Color").Width = 40
    End Sub
    Private Sub GridView1Member_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles membercolor.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Private Sub txtcolorleader_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolorleader.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolorleader.Properties.View.FocusedRowHandle.ToString)
        leadercode.Text = txtcolorleader.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        txtcolorleader.Text = txtcolorleader.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub

    Private Sub txtcolorMember_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolormember.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolormember.Properties.View.FocusedRowHandle.ToString)
        membercode.Text = txtcolormember.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        txtcolormember.Text = txtcolormember.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub

    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If countrecord("tblconfiguration") = 0 Then
            com.CommandText = "insert into tblconfiguration set defleadercolor='" & leadercode.Text & "', defmembercolor='" & membercode.Text & "',autocolorleadersmember='" & ckAutoColorChange.CheckState & "', multipleidprint='" & ckMultipleSelectIDPrint.CheckState & "',showidprintpreview='" & ckShowIDPrintPreview.CheckState & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblconfiguration set defleadercolor='" & leadercode.Text & "', defmembercolor='" & membercode.Text & "',autocolorleadersmember='" & ckAutoColorChange.CheckState & "', multipleidprint='" & ckMultipleSelectIDPrint.CheckState & "',showidprintpreview='" & ckShowIDPrintPreview.CheckState & "'" : com.ExecuteNonQuery()
        End If
        loadSettings()
        XtraMessageBox.Show("Configuration Successfully Saved", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ckMultipleSelectIDPrint_CheckedChanged(sender As Object, e As EventArgs) Handles ckMultipleSelectIDPrint.CheckedChanged
        If ckMultipleSelectIDPrint.Checked = True Then
            ckShowIDPrintPreview.Checked = False
            ckShowIDPrintPreview.Enabled = False
        Else
            ckShowIDPrintPreview.Enabled = True
        End If
    End Sub
End Class