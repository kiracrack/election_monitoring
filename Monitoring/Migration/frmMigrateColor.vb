Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmMigrateColor
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMigrateColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadMunicipal()
        loadServerColor()
    End Sub
    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT distinct((select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode)) as 'Select List', databasename,areacode,muncode from settings.tblmigratehistory order by (select munname from tblmunicipality where muncode=settings.tblmigratehistory.muncode) asc ", "settings.tblmigratehistory", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("databasename", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("areacode").Visible = False
        gridMunicipal.Columns("muncode").Visible = False
        gridMunicipal.Columns("databasename").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("areacode").ToString()
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("muncode").ToString()
        databasename.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("databasename").ToString()
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        If databasename.Text <> "" Or databasename.Text <> "databasename" Then
            loadColorMunicipal()
            filter()
        End If
    End Sub
    Public Sub loadColorMunicipal()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from " & databasename.Text & ".tblcolor where colorcode not in (select clientcolorcode from settings.tblmigratecolor where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "')", "" & databasename.Text & ".tblcolor", txtcolorMunicipal, gridcolorMunicipal, Me)
        gridcolorMunicipal.Columns("colorcode").Visible = False
        gridcolorMunicipal.Columns("colorname").Visible = False
        gridcolorMunicipal.Columns("Color").Width = 40
    End Sub
    Private Sub gridcolorMunicipal_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridcolorMunicipal.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Private Sub txtcolorMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolorMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolorMunicipal.Properties.View.FocusedRowHandle.ToString)
        clientcolorcode.Text = txtcolorMunicipal.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        txtcolorMunicipal.Text = txtcolorMunicipal.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub
    Public Sub loadServerColor()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from tblcolor", "tblcolor", txtcolor, gridcolor, Me)
        gridcolor.Columns("colorcode").Visible = False
        gridcolor.Columns("colorname").Visible = False
        gridcolor.Columns("Color").Width = 40
    End Sub
    Private Sub gridcolor_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridcolor.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Private Sub txtcolor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolor.Properties.View.FocusedRowHandle.ToString)
        servercolorcode.Text = txtcolor.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        txtcolor.Text = txtcolor.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub
    Public Sub filter()
        If databasename.Text = "" Then Exit Sub
        LoadXgrid("Select id,clientcolorcode,'' as 'From Color',(select colorname from " & databasename.Text & ".tblcolor where colorcode=tblmigratecolor.clientcolorcode) as 'clientcolorname', (select description from " & databasename.Text & ".tblcolor where colorcode=tblmigratecolor.clientcolorcode) as 'From Description', " _
                      + " servercolorcode,'' as 'Migrated Color',(select colorname from tblcolor where colorcode=tblmigratecolor.servercolorcode) as 'servercolorname', (select description from tblcolor where colorcode=tblmigratecolor.servercolorcode) as 'Migrated Description' " _
                      + " from settings.tblmigratecolor where databasename='" & databasename.Text & "'", "settings.tblmigratecolor", Em, GridView1, Me)

        GridView1.Columns("id").Visible = False

        GridView1.Columns("clientcolorcode").Visible = False
        GridView1.Columns("servercolorcode").Visible = False

        GridView1.Columns("clientcolorname").Visible = False
        GridView1.Columns("servercolorname").Visible = False

        ' GridView1.Columns("defaults").Visible = False
        GridView1.Columns("From Color").Width = 90
        GridView1.Columns("Migrated Color").Width = 90
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "From Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("clientcolorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
        If e.Column.FieldName = "Migrated Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("servercolorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
      
    End Sub
    Private Sub cmdCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        If txtcolorMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select Color", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtcolorMunicipal.Focus()
            Exit Sub
        End If
        com.CommandText = "insert into settings.tblmigratecolor set areacode='" & areacode.Text & "', muncode='" & muncode.Text & "',databasename='" & databasename.Text & "', servercolorcode='" & servercolorcode.Text & "', clientcolorcode='" & clientcolorcode.Text & "'"
        com.ExecuteNonQuery()
        filter()
        loadColorMunicipal()
        'XtraMessageBox.Show("Color Migration successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("clientcolorcode") = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to permanently delete this item? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from settings.tblmigratecolor where id='" & GridView1.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
            GridView1.DeleteSelectedRows()
            loadColorMunicipal()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
End Class