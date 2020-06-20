Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Public Class frmUsersAccounts
    Private gridsel As String = ""
    Private gridid As String = ""

    Private Sub frmUsersAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        txtuserid.Text = getuserid()
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        filteruser()
        loadArea()
    End Sub


    Public Sub loadArea()
        LoadXgridLookupSearch("SELECT areacode as 'Code', areaname as 'Select List'  from tblarea order by areaname asc ", "tblarea", txtArea, gridArea, Me)
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArea.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtArea.Properties.View.FocusedRowHandle.ToString)
        areacode.Text = txtArea.Properties.View.GetFocusedRowCellValue("Code").ToString()
        If areacode.Text <> "" Then
            loadMunicipal()
        End If
    End Sub

    Public Sub loadMunicipal()
        LoadXgridLookupSearch("SELECT muncode as 'Code', munname as 'Select List'  from tblmunicipality where areacode='" & areacode.Text & "' order by munname asc ", "tblmunicipality", txtMunicipal, gridMunicipal, Me)
        XgridColAlign("Code", gridMunicipal, DevExpress.Utils.HorzAlignment.Center)
        gridMunicipal.Columns("Code").Visible = False
    End Sub
    Private Sub txtMunicipal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipal.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtMunicipal.Properties.View.FocusedRowHandle.ToString)
        muncode.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Code").ToString()
       
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
  
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangepass.ItemClick
        If globalpermission <> 1 And globalpermission <> 0 And globaluserid <> gridid Then
            XtraMessageBox.Show("You have no permission to do this action! please contact your administrative control", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If mode.Text <> "edit" Then
            XtraMessageBox.Show("Please select user to continue process!", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        txtpassword.Properties.ReadOnly = False
        txtverify.Properties.ReadOnly = False
    End Sub
    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        filteruser()
        clearaccount()
    End Sub

    Public Sub filteruser()
        LoadXgrid("Select accountid as 'Account ID',  " _
                                    + " username as 'Username'," _
                                    + " fullname as 'Fullname', " _
                                    + " datereg as 'Registered',Team, FullAccess,   " _
                                    + " (select areaname from tblarea where areacode = tblaccounts.accessareacode) as 'Area', " _
                                    + " (select munname from tblmunicipality where muncode=tblaccounts.accessmuncode) as 'Municipal' " _
                                    + " from tblaccounts " _
                                    + " order by fullname asc", "tblaccounts", Em, GridView1, Me)

       
        XgridColAlign("Account ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Area", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Municipal", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Team", GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.ItemClick
        If txtfullname.Text = "" Then
            XtraMessageBox.Show("Please enter fullname.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtdesignation.Text = "" Then
            XtraMessageBox.Show("Please select designation.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtdesignation.Focus()
            Exit Sub
        ElseIf txtusername.Text = "" Then
            XtraMessageBox.Show("Please enter username!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf CheckBox1.Checked = False And (txtArea.Text = "" Or txtMunicipal.Text = "") Then
            XtraMessageBox.Show("Please select access area!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "fullname = '" & txtfullname.Text & "'") <> 0 And mode.Text = "" Then
            XtraMessageBox.Show("Account name already exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            If txtverify.Text = "" And txtpassword.Text <> "" Then
                XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtverify.Focus()
                Exit Sub
            ElseIf txtpassword.Text <> txtverify.Text Then
                XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Text = ""
                txtverify.Text = ""
                txtpassword.Focus()
                Exit Sub
            End If

            If XtraMessageBox.Show("Are you sure you want update user account of " & txtfullname.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tblaccounts set fullname = '" & txtfullname.Text & "', " _
                                 + " designation='" & txtdesignation.Text & "', " _
                                 + If(txtverify.Text <> "", "password='" & EncryptTripleDES(txtverify.Text) & "',", "") _
                                 + " permission = '2',team='" & txtTeam.Text & "',fullaccess=" & CheckBox1.CheckState & ", accessareacode='" & If(CheckBox1.Checked = True, "", areacode.Text) & "', accessmuncode='" & If(CheckBox1.Checked = True, "", muncode.Text) & "' where accountid='" & txtuserid.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE USER ACCOUNT OF " & txtfullname.Text)
                loadglobaluser()
                filteruser()
                clearaccount()
                XtraMessageBox.Show("User successfully save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            If txtpassword.Text = "" Then
                XtraMessageBox.Show("Please enter password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Focus()
                Exit Sub
            ElseIf txtverify.Text = "" Then
                XtraMessageBox.Show("Please enter verify password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtverify.Focus()
                Exit Sub
            ElseIf txtpassword.Text <> txtverify.Text Then
                XtraMessageBox.Show("Password did not match! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpassword.Text = ""
                txtverify.Text = ""
                txtpassword.Focus()
                Exit Sub
            End If

            If XtraMessageBox.Show("Are you sure you want create user account of " & txtfullname.Text & " ? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "insert into tblaccounts set accountid='" & txtuserid.Text & "', fullname = '" & txtfullname.Text & "', " _
                                                + " designation='" & txtdesignation.Text & "', " _
                                                + " username='" & txtusername.Text & "', " _
                                                + " password='" & EncryptTripleDES(txtverify.Text) & "', " _
                                                + " permission = '2', datereg=current_timestamp,team='" & txtTeam.Text & "',fullaccess=" & CheckBox1.CheckState & ", accessareacode='" & If(CheckBox1.Checked = True, "", areacode.Text) & "', accessmuncode='" & If(CheckBox1.Checked = True, "", muncode.Text) & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "ADDED NEW ACCOUNT OF " & txtfullname.Text)
                loadglobaluser()
                filteruser()
                clearaccount()
                XtraMessageBox.Show("User successfully save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

      
    End Sub
    Public Sub clearaccount()
        txtfullname.Text = ""
        txtusername.Text = ""

        txtpassword.Text = ""
        txtverify.Text = ""
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        accsysid.Text = ""

        txtuserid.Text = getuserid()
        mode.Text = ""
    
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblaccounts where accountid='" & gridid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtuserid.Text = .Rows(cnt)("accountid").ToString
                txtfullname.Text = .Rows(cnt)("fullname").ToString
                txtdesignation.Text = .Rows(cnt)("designation").ToString
                txtusername.Text = .Rows(cnt)("username").ToString
                txtTeam.Text = .Rows(cnt)("team").ToString
                CheckBox1.Checked = .Rows(cnt)("fullaccess")
                txtArea.EditValue = .Rows(cnt)("accessareacode").ToString
                areacode.Text = .Rows(cnt)("accessareacode").ToString
                loadMunicipal()
                txtMunicipal.EditValue = .Rows(cnt)("accessmuncode").ToString
                muncode.Text = .Rows(cnt)("accessmuncode").ToString
            End With
        Next
      
        mode.Text = "edit"
        cmdChangepass.Enabled = True
    End Sub

  
    Public Sub getcolidpack()
        On Error Resume Next
        Dim Rows() As DataRow : Dim I As Integer
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        For I = 0 To GridView1.SelectedRowsCount - 1
            gridid = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Account ID")
        Next
    End Sub

    Private Sub packgrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
        getcolidpack()
    End Sub

    Private Sub packgrid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
        getcolidpack()
    End Sub
    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If globaluserid = gridid Then
            XtraMessageBox.Show("User is currently in use! cannot delete", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        DeleteRow("Account ID", "accountid", "tblaccounts", GridView1, Me)
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        clearaccount()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cmdSave.PerformClick()
    End Sub
  
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePass.userid.Text = gridid
        frmChangePass.Show(Me)
    End Sub
 

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtArea.Enabled = False
            txtMunicipal.Enabled = False
        Else
            txtArea.Enabled = True
            txtMunicipal.Enabled = True
        End If
    End Sub
End Class