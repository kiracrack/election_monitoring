Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Public Class frmArea
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select areacode, areacode as 'Code', areaname as 'Area Name' from tblarea", "tblarea", Em, GridView1, Me)
        GridView1.Columns("areacode").Visible = False
        GridView1.Columns("Code").Visible = False
        GridView1.Columns("Code").Width = 60
        XgridColAlign("Code", GridView1, Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Area Name!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            If countqry("tblarea", "areacode='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Area ID Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblarea set areacode='" & id.Text & "', areaname='" & txtdesc.Text & "'"
            com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblarea set areaname='" & txtdesc.Text & "' where  areacode='" & id.Text & "'"
            com.ExecuteNonQuery()
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Area successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = getareaid()
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblarea where areacode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("areaname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("areacode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("areacode").ToString
        mode.Text = "edit"
    End Sub


    Private Sub frmProductCat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearfields()
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(me)
        clearfields()
        filter()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("areacode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("areacode", "areacode", "tblarea", GridView1, Me)
        End If
        id.Text = getareaid()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub

    Private Sub UseDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseDefaultToolStripMenuItem.Click
        com.CommandText = ""
    End Sub
End Class