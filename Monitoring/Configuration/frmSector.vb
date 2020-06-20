Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Public Class frmSector
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Public Sub filter()
        LoadXgrid("Select sectorcode, sectorcode as 'Code', sectorname as 'Sector Description' from tblsector", "tblsector", Em, GridView1, Me)
        GridView1.Columns("sectorcode").Visible = False
        GridView1.Columns("Code").Visible = False
        GridView1.Columns("Code").Width = 60
        XgridColAlign("Code", GridView1, Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If txtdesc.Text = "" Then
            XtraMessageBox.Show("Please provide Sector Description!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesc.Focus()
            Exit Sub
        End If
        RemoveSpecialChar(PanelControl1)
        If mode.Text <> "edit" Then
            If countqry("tblsector", "sectorcode='" & id.Text & "'") <> 0 Then
                XtraMessageBox.Show("Duplicate Sector ID Please use unique one!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                id.Focus()
                Exit Sub
            End If
            com.CommandText = "insert into tblsector set sectorcode='" & id.Text & "', sectorname='" & txtdesc.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "SECTOR ADDED")
        Else
            com.CommandText = "update tblsector set sectorname='" & txtdesc.Text & "' where  sectorcode='" & id.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "SECTOR UPDATED")

        End If
        clearfields()
        filter()
        XtraMessageBox.Show("Area successfully save!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub clearfields()
        id.Text = createTRNID("S") & "-" & globaluserid
        txtdesc.Text = ""
        mode.Text = ""
    End Sub

    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        com.CommandText = "select * from tblsector where sectorcode='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtdesc.Text = rst("sectorname").ToString
        End While
        rst.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("sectorcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mode.Text = ""
        id.Text = GridView1.GetFocusedRowCellValue("sectorcode").ToString
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
        If GridView1.GetFocusedRowCellValue("sectorcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            DeleteRow("sectorcode", "sectorcode", "tblsector", GridView1, Me)
        End If
        id.Text = getareaid()
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        clearfields()
    End Sub
End Class