Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Net
Imports DevExpress.LookAndFeel
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.XtraMessageBoxForm
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraSplashScreen

Public Class frmLogin
    Public Sub New()
        InitializeComponent()
        InitSkins()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.OfficeSkins.Register()
      
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            End
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot MainMonitoring Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
    End Sub
    Public Sub checklog()
        Try
            Call connect()
            conn = New MySqlConnection
            com.CommandText = "SELECT * from tblaccounts where username='" & rchar(Trim(txtusername.Text)) & "' and password='" & EncryptTripleDES(txtpassword.Text) & "'" : rst = com.ExecuteReader()
            While rst.Read()
                If rst.GetSchemaTable.Rows.Count <> 0 Then
                    globallogin = True
                    globaluserid = rst("accountid")
                Else
                    globallogin = False
                End If
            End While
            rst.Close()

            If globallogin = True Then
                loadglobaluser()
                loadcompsettings()
                set_login()
            ElseIf globallogin = False Then
                XtraMessageBox.Show("Invalid Username or Password..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpassword.Focus()
                txtpassword.Text = ""
                rst.Close()
            End If

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub set_login()
        com.CommandText = "insert into tbllogin set userid = '" & globaluserid & "',intime=current_timestamp" : com.ExecuteNonQuery()
        Me.Hide()
        txtusername.Text = "Username"
        txtpassword.Text = "password"
        txtusername.Focus()
        MainMonitoring.Show()
    End Sub

    Public Sub clearlog()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        If txtusername.Text = "" Then
            XtraMessageBox.Show("Username field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            XtraMessageBox.Show("Password field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        checklog()
    End Sub

  
    Private Sub frmLogin_Activated1(sender As Object, e As EventArgs) Handles Me.Activated
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style")
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If System.IO.File.Exists(file_conn) = False Then
                frmConnectionSetup.ShowDialog()
                Me.Close()
            End If
            Call connect()
            loadcompsettings()
            loadIcons()
            SetIcon(Me)
            If verifyLicense() = False And SystemServer = 1 Then
                If XtraMessageBox.Show("System unit not registered! this is preventing copyright violations against system owner. " & Environment.NewLine & "if you want to register this system unit please click ok to continue.", "Error System License Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                    frmActivateLicense.ShowDialog()
                End If
                End
            Else
                If CBool(qrysingledata1("isserver", "isserver", "settings.tblsettings")) = True Then
                    UpdateNotifiers()
                End If
                LoadSMSFileSetup()
                Me.Cursor = Cursors.WaitCursor
                SystemUpdateChecker()
                Me.Cursor = Cursors.Default
                LoadGlobalDate()
                loadSettings()
                'loadLoginAppearance()
                'SetApp()
                UpdateEngine2()
                Me.Text = compname
            End If
            If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Reports")) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Reports")
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateEngine2()
        If globalServerType = 1 Then
            com.CommandText = "CREATE TABLE IF NOT EXISTS `settings`.`tblmigratehistory` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `datecapture` datetime NOT NULL,  `areacode` varchar(50) NOT NULL,  `muncode` varchar(50) NOT NULL,  `databasename` varchar(50) NOT NULL,  `captureby` text,  PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
            com.CommandText = "CREATE TABLE IF NOT EXISTS `settings`.`tblmigratecolor` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `areacode` varchar(50) NOT NULL,  `muncode` varchar(50) NOT NULL,   `databasename` varchar(50) NOT NULL, `servercolorcode` varchar(50) NOT NULL,  `clientcolorcode` varchar(50) NOT NULL,  PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery()
        End If
    End Sub

    Private Sub frmLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PanelControl1.Top = ((Me.Height - 30) / 2) - (PanelControl1.Height / 2)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        End
    End Sub
End Class