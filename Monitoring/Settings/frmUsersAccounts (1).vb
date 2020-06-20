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
        txtunitcodeaccount.Text = Nothing
        txtuserid.Text = getuserid()
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        LoadToComboBox("unitcode", "tblaccounts", txtunitcodeaccount, True) : txtunitcodeaccount.SelectedIndex = -1
        filteruser()
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
        LoadXgrid("Select accountid as 'Account ID',unitcode as 'Unit Code', " _
                                    + " username as 'Username'," _
                                    + " fullname as 'Fullname', " _
                                    + " datereg as 'Registered',Team " _
                                    + " from tblaccounts " _
                                    + " order by fullname asc", "tblaccounts", Em, GridView1, Me)

        If globalpermission = 1 Or globalpermission = 0 Then
            GridView1.Columns("Unit Code").Visible = True
        Else
            GridView1.Columns("Unit Code").Visible = False
        End If
      
        XgridColAlign("Account ID", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Unit Code", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Team", GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.ItemClick
        If txtunitcodeaccount.Text = "" Or txtunitcodeaccount.Text = "UNIT CODE" Then
            XtraMessageBox.Show("Please select unit code! ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtunitcodeaccount.Focus()
            Exit Sub
        ElseIf txtfullname.Text = "" Then
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
                                 + " unitcode = '" & txtunitcodeaccount.Text & "', " _
                                 + If(txtverify.Text <> "", EncryptTripleDES(txtverify.Text), "") _
                                 + " permission = '2',team='" & txtTeam.Text & "' where accountid='" & txtuserid.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE USER ACCOUNT OF " & txtfullname.Text)
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
                                                + " unitcode = '" & txtunitcodeaccount.Text & "', " _
                                                + " username='" & txtusername.Text & "', " _
                                                + " password='" & EncryptTripleDES(txtverify.Text) & "', " _
                                                + " permission = '2', datereg=current_timestamp,team='" & txtTeam.Text & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "ADDED NEW ACCOUNT OF " & txtfullname.Text)
            End If
        End If

        loadglobaluser()
        filteruser()
        clearaccount()
        XtraMessageBox.Show("User successfully save", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub clearaccount()
        txtfullname.Text = ""
        txtusername.Text = ""

        txtpassword.Text = ""
        txtverify.Text = ""
        LoadToComboBox("designation", "tblaccounts", txtdesignation, True) : txtdesignation.SelectedIndex = -1
        LoadToComboBox("unitcode", "tblaccounts", txtunitcodeaccount, True) : txtunitcodeaccount.SelectedIndex = -1
        accsysid.Text = ""

        txtuserid.Text = getuserid()
        mode.Text = ""
    
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If globalpermission <> 1 And globalpermission <> 0 And globaluserid <> gridid Then
            XtraMessageBox.Show("You have no permission to do this action! please contact your administrative control", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
   
        com.CommandText = "select * from tblaccounts where accountid='" & gridid & "'" : rst = com.ExecuteReader
        While rst.Read
            txtuserid.Text = rst("accountid").ToString
            txtfullname.Text = rst("fullname").ToString
            txtdesignation.Text = rst("designation").ToString
            txtusername.Text = rst("username").ToString
            txtunitcodeaccount.Text = rst("unitcode").ToString
            txtTeam.Text = rst("team").ToString
        End While
        rst.Close()
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
        If globalpermission <> 1 And globalpermission <> 0 Then
            XtraMessageBox.Show("You have no permission to do this action! please contact your administrative control", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf globaluserid = gridid Then
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
End Class