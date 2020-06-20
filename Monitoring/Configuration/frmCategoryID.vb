Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Public Class frmCategoryID
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select id, description as 'Category', idtemplate as 'FileName', Customized from tblidcategory", "tblidcategory", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColAlign("FileName", GridView1, Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            com.CommandText = "insert into tblidcategory set description='" & txtdesc.Text & "', idtemplate='" & txtFilename.Text & "',customized=" & CheckEdit1.CheckState & "" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CATEGORY ID ADDED")
        Else
            com.CommandText = "update tblidcategory set description='" & txtdesc.Text & "', idtemplate='" & txtFilename.Text & "',customized=" & CheckEdit1.CheckState & " where id='" & id.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "CATEGORY ID UPDATED")
        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Category successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblidcategory where id='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("description").ToString
            txtFilename.Text = rst("idtemplate").ToString
            CheckEdit1.Checked = rst("customized")
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
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
        If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("id", "id", "tblidcategory", GridView1, Me)
        End If
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub
End Class