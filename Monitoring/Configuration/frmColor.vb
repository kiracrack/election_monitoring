Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmColor
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select colorcode,colorname,'' as 'Color', Description,defaults,Shortcut from tblcolor", "tblcolor", Em, GridView1, Me)
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("colorname").Visible = False
        GridView1.Columns("defaults").Visible = False
        GridView1.Columns("Color").Width = 40
        XgridColAlign("Shortcut", GridView1, Utils.HorzAlignment.Center)
    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
        If e.Column.FieldName <> "Color" Then
            Dim defaults As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("defaults").ToString)
            If defaults = "1" Then
                e.Appearance.BackColor = Color.LemonChiffon
                e.Appearance.ForeColor = Color.Black
            End If

        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            If countqry("tblcolor", "colorcode='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate color code please select unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblcolor set colorcode='" & id.Text & "', description='" & txtdesc.Text & "',colorname='" & txtcolor.Text & "', shortcut='" & txtShortcode.Text & "'"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblcolor set description='" & txtdesc.Text & "',colorname='" & txtcolor.Text & "', shortcut='" & txtShortcode.Text & "' where colorcode='" & id.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Color successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getColorid()
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcolor where colorcode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
            txtShortcode.Text = rst("shortcut").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("colorcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("colorcode").ToString
        txtcolor.Text = GridView1.GetFocusedRowCellValue("colorname").ToString
        mode.Text = "edit"
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        clearfields()
        filter()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("colorcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("colorcode", "colorcode", "tblcolor", GridView1, Me)
        End If
        id.Text = getareaid()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub SetAsDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAsDefaultToolStripMenuItem.Click
        com.CommandText = "update tblcolor set defaults=0" : com.ExecuteNonQuery()
        com.CommandText = "update tblcolor set defaults=1 where colorcode='" & GridView1.GetFocusedRowCellValue("colorcode").ToString & "' " : com.ExecuteNonQuery()
        filter()
        loadSettings()
    End Sub

End Class