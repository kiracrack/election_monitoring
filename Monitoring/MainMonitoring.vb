Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.RibbonGalleryBarItem
Imports DevExpress.XtraCharts
Imports System.IO
Imports GsmComm.GsmCommunication
Imports GsmComm.PduConverter
Imports DevExpress.XtraSplashScreen

Public Class MainMonitoring
    Public WithEvents comm As GsmCommMain
    Public Delegate Sub SetTextCallback(ByVal text As String)
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.OfficeSkins.Register()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(globaltheme)
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.F12 Then
            If LCase(globaluser) = "admin" Then
                frmUploadSystemUpdate.ShowDialog()
            End If
        ElseIf keyData = (Keys.F3) Then
            cmdVoterSearch.PerformClick()

        ElseIf keyData = (Keys.Control) + Keys.Shift + Keys.F12 Then
            frmSystemOwnerConfirmation.Show(Me)

        End If
        Return ProcessCmdKey
    End Function
    Private Sub MainMonitoring_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If GLobalSMSEnable = True Then
            If Not comm Is Nothing Then
                If comm.IsConnected = True Then
                    comm.Close()
                End If
            End If
        End If
    End Sub
    Private Sub MBAIMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If autoUpdateClose = False Then
            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i
            If XtraMessageBox.Show("Are you sure you want to logoff your account " & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "update tbllogin set outtime=current_timestamp where userid='" & globaluserid & "'" : com.ExecuteNonQuery()
                frmLogin.Show()
                userexit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub XtraForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connect() : loadStatus() : SetIcon(Me)
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinPopupMenu(skining)

        FilterSecurity()
        If LCase(globaluser) = "admin" Then
            cmdExportServer.Visibility = BarItemVisibility.Always
            cmdExportList.Visibility = BarItemVisibility.Always
        Else
            cmdExportServer.Visibility = BarItemVisibility.Never
            cmdExportList.Visibility = BarItemVisibility.Never
        End If

        BarButtonItem4.Caption = "Edited Records (" & Val(countqry("settings.tblactionquerylogs", "status=1")) & ")"
        txtlocal.Caption = "Local IP : " & sqlserver
        txtserver.Caption = "Server IP : " & clientserver

        LoadSMSSetup()
        ShowPendingSms()
    End Sub
    Public Sub LoadSMSSetup()
        If GLobalSMSEnable = True Then
            Dim p = Process.GetProcessesByName(GLobalSMSModemName)
            If p.Count > 0 Then
                Shell("taskkill /IM """ & GLobalSMSModemName & """* /f")
            End If
            comm = New GsmCommMain(GLobalSMSPort)
            comm.Open()
            If comm.IsConnected = True Then
                comm.EnableMessageNotifications()
            Else
                comm = Nothing
            End If
        End If
    End Sub

    Public Sub ShowPendingSms()
        If countqry("tblsmsinbox", "isread=0 and deleted=0") > 0 Then
            cmdUnreadSms.Visibility = BarItemVisibility.Always
            cmdUnreadSms.Caption = "New Unread Message (" & countqry("tblsmsinbox", "isread=0 and deleted=0") & ")"
        Else
            cmdUnreadSms.Visibility = BarItemVisibility.Never
        End If
    End Sub
    Public Sub FilterSecurity()
        If SystemServer = 0 Then
            'cmdNewVoters.Visibility = BarItemVisibility.Never
            cmdImportUpdate.Visibility = BarItemVisibility.Never
            RibbonPageGroup2.Visible = False


            If Globalshowclientstatusresult = True Then
                page_status.Visible = True
            Else
                page_status.Visible = False
            End If

            BarButtonItem8.Visibility = BarItemVisibility.Never
            RibbonPageGroup6.Visible = True
            BarButtonItem4.Visibility = BarItemVisibility.Always
            If LCase(globaluser) = "admin" Then
                page_configuration.Visible = True
            Else
                page_configuration.Visible = False
            End If
        Else
            cmdImportUpdate.Visibility = BarItemVisibility.Always
            BarButtonItem8.Visibility = BarItemVisibility.Always
            'cmdNewVoters.Visibility = BarItemVisibility.Always
            RibbonPageGroup2.Visible = True
            page_configuration.Visible = True
            page_status.Visible = True
            RibbonPageGroup6.Visible = False
            BarButtonItem4.Visibility = BarItemVisibility.Never
            If singleuse = "1" Then
                cmdArea.Visibility = BarItemVisibility.Never
                cmdMunicipal.Visibility = BarItemVisibility.Never
            Else
                cmdArea.Visibility = BarItemVisibility.Always
                cmdMunicipal.Visibility = BarItemVisibility.Always
            End If
        End If
        If globalServerType = 0 Then
            page_migration.Visible = False
        Else
            page_migration.Visible = True
        End If

    End Sub
    Public Sub loadStatus()
        Me.Text = compname + " Monitoring System " + " - Login as " & UCase(globaluser) & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdArea.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmArea.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMunicipal.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmMunicipality.MdiParent = Me
        frmMunicipality.Show()
        frmMunicipality.Focus()
        frmMunicipality.filter()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmVillage.MdiParent = Me
        frmVillage.Show()
        frmVillage.Focus()
        frmVillage.filter()
        SplashScreenManager.CloseForm()

    End Sub


    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmLeaders.MdiParent = Me
        frmLeaders.Show()
        frmLeaders.Focus()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmColor.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmVotersEntries.Show(Me)
        frmVotersEntries.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmLeaderAssigned.MdiParent = Me
        frmLeaderAssigned.Show()
        frmLeaderAssigned.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmCompanySettings.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmAppearance.Show()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUserProfile.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUsersAccounts.MdiParent = Me
        frmUsersAccounts.Show()
        frmUsersAccounts.Focus()
        frmUsersAccounts.filteruser()
        SplashScreenManager.CloseForm()
    End Sub


    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewLeader.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmLeadersInfo.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStatusResultbyColor.MdiParent = Me
        frmStatusResultbyColor.Show()
        frmStatusResultbyColor.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStatusResultbyArea.MdiParent = Me
        frmStatusResultbyArea.Show()
        frmStatusResultbyArea.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStatusResultbyMunicipal.MdiParent = Me
        frmStatusResultbyMunicipal.Show()
        frmStatusResultbyMunicipal.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmStatusResultbyvillage.MdiParent = Me
        frmStatusResultbyvillage.Show()
        frmStatusResultbyvillage.Focus()
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUpdateDatabase.Show()
        SplashScreenManager.CloseForm()
    End Sub

   
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSynchronizeRecords.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtdt.Caption = Now.ToLongDateString & " " & Now.ToLongTimeString & " - Login as " & StrConv(globaluser, vbProperCase) & "@" & StrConv(globalfullname, vbProperCase)

    End Sub

    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'Dim FILE_NAME As String = "%windir%\system32\mysql.exe"
        'If Not File.Exists(FILE_NAME) Then
        '    XtraMessageBox.Show("Mysql.exe file does not exist! please copy manualy the file to system32 folder" & Environment.NewLine & Environment.NewLine & "OS x86: Mysql.exe can found at %Program Files%\MySQL\MySQL Server 5.5\bin\mysql.exe" & Environment.NewLine & "OS x64: Mysql.exe can found at %Program Files(x86)%\MySQL\MySQL Server 5.5\bin\mysql.exe", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        Dim sqlpath As String = ""
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Backup files sql (*.sql)|*.sql|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                'Read the contents of the file
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'Display the file contents in the TextBox
                sqlpath = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
            If XtraMessageBox.Show("Are you sure you want to Restore Database?" & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If sqlpath <> "" Then
                    Dim process As System.Diagnostics.Process
                    Dim processStartInfo As System.Diagnostics.ProcessStartInfo
                    processStartInfo = New System.Diagnostics.ProcessStartInfo
                    processStartInfo.FileName = "cmd.exe"
                    'If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
                    '    processStartInfo.Verb = "runas"
                    'Else
                    '    ' No need to prompt to run as admin
                    'End If
                    processStartInfo.Arguments = "/C mysql -h localhost -uroot -p" & sqlpass & " < """ & sqlpath & """"
                    ' MsgBox("/C mysql -h localhost -uroot -p12sysadmin34 < """ & sqlpath & """")
                    processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    processStartInfo.UseShellExecute = True
                    process = System.Diagnostics.Process.Start(processStartInfo)
                    'System.Threading.Thread.Sleep()
                    process.WaitForExit()
                    If process.HasExited Then
                        XtraMessageBox.Show("Your database successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        'If XtraMessageBox.Show("Are you sure you want to clear edited Records?" & Environment.NewLine & Environment.NewLine & "Note: All progress will be lost.", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        '    com.CommandText = "delete from settings.tblactionquerylogs" : com.ExecuteNonQuery()
        '    BarButtonItem4.Caption = "Clear Edited Records (" & Val(countqry("settings.tblactionquerylogs", "status=1")) & ")"
        '    XtraMessageBox.Show("Successfully Cleared!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub BarButtonItem8_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmBackupTool.ShowDialog()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNewVoters.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmEntryInfo.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem9_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdVoterSearch.ItemClick
        'XtraMessageBox.Show("Improvement of this function has not yet done, please wait for the new update covered to this menu soon to be posted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmVotersInformation.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        BarButtonItem4.Caption = "Total Encoded Records (" & Val(countqry("settings.tblactionquerylogs", "status=1")) & ")"
        ShowPendingSms()
    End Sub

    Private Sub BarButtonItem23_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmColorSummary.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmGeneralSummary.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmColorCodeListing.MdiParent = Me
        frmColorCodeListing.Show()
        frmColorCodeListing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
      frmSector.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSectorListing.MdiParent = Me
        frmSectorListing.Show()
        frmSectorListing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
       frmAbout.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmClusterized.MdiParent = Me
        frmClusterized.Show()
        frmClusterized.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReportGenerator.MdiParent = Me
        frmReportGenerator.Show()
        frmReportGenerator.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReportDeveloper.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmClusteredListing.MdiParent = Me
        frmClusteredListing.Show()
        frmClusteredListing.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmDuplicateManager.MdiParent = Me
        frmDuplicateManager.Show()
        frmDuplicateManager.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdImportUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImportUpdate.ItemClick
        Dim sqlpath As String = ""
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Exported File (*.DAT)|*.DAT|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                'Read the contents of the file
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'Display the file contents in the TextBox
                sqlpath = objOpenFileDialog.FileName

            Catch fileException As Exception
                Throw fileException
            End Try

            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
            If XtraMessageBox.Show("Are you sure you want to import edited Records?" & globaluser & "@" & globalfullname & " on " & globaldate & " - " & GlobalTime() & ") ?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If sqlpath <> "" Then
                    frmImportRecords.ReadFile(sqlpath)
                    frmImportRecords.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
       frmSynchronizedHistory.ShowDialog()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUploadedHistory.ShowDialog()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmConfiguration.ShowDialog()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem45_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmImportBackup.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem47_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmMigrateVotersViewer.MdiParent = Me
        frmMigrateVotersViewer.Show()
        frmMigrateVotersViewer.Focus()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
      frmMigrateColor.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub BarButtonItem48_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmMigrateData.Show()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdSms_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSms.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSMSView.Show()
        SplashScreenManager.CloseForm()
    End Sub

#Region "SMS"
    Private Sub comm_MessageReceived(ByVal sender As Object, ByVal e As MessageReceivedEventArgs) Handles comm.MessageReceived
        Dim obj As IMessageIndicationObject = e.IndicationObject
        Try
            If TypeOf obj Is MemoryLocation Then
                Dim loc As MemoryLocation = CType(obj, MemoryLocation)
                CheckSMS()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CheckSMS()
        Dim storage As String = GetMessageStorage()
        Dim messages As DecodedShortMessage() = comm.ReadMessages(PhoneMessageStatus.All, storage)
        Dim cnt As Integer = 1
        For Each message As DecodedShortMessage In messages
            If TypeOf message.Data Is SmsDeliverPdu Then
                Dim data As SmsDeliverPdu = CType(message.Data, SmsDeliverPdu)
                If countqry("tblsmsinbox", "smsdatetime='" & ConvertDateTime(data.SCTimestamp.ToString()) & "' and sender='" & data.OriginatingAddress & "' and message='" & rchar(data.UserDataText) & "'") = 0 Then
                    Dim getFullname As String = "" : Dim getarea As String = "" : Dim getCity As String = "" : Dim getBarangay As String = "" : Dim getPrecinct As String = ""
                    com.CommandText = "select *, (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                                + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                                + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'barangay'  from tblvoters where contactnumber='" & data.OriginatingAddress & "' or replace(contactnumber,'+63','0')='" & data.OriginatingAddress & "'" : rst = com.ExecuteReader
                    While rst.Read
                        getFullname = rst("fullname").ToString
                        getPrecinct = rst("precinct").ToString
                        getarea = rst("area").ToString
                        getCity = rst("municipal").ToString
                        getBarangay = rst("barangay").ToString
                    End While
                    rst.Close()

                    Dim getid As String = createTRNID("I") & cnt & "-" & globaluserid
                    com.CommandText = "insert into tblsmsinbox set id='" & getid & "', sender='" & data.OriginatingAddress & "', " _
                                                + " sendername='" & getFullname & "', " _
                                                + " area='" & rchar(getarea) & "', " _
                                                + " city='" & rchar(getCity) & "', " _
                                                + " barangay='" & rchar(getBarangay) & "', " _
                                                + " precinct='" & rchar(getPrecinct) & "', " _
                                                + " message='" & rchar(data.UserDataText) & "', " _
                                                + " smsdatetime=current_timestamp" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "NEW SMS FROM " & If(getFullname = "", data.OriginatingAddress, UCase(getFullname)))
                End If
            End If
            cnt = cnt + 1
        Next
        Me.DoThreadedStuff()
    End Sub

    Public Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowUnreadSms())
        Else
            ShowUnreadSms()
        End If
    End Sub
    Public Sub ShowUnreadSms()
        Dim unreadsms As Integer = 0
        unreadsms = countqry("tblsmsinbox", "isread=0 and deleted=0")
        If unreadsms > 0 Then
            cmdUnreadSms.Visibility = BarItemVisibility.Always
            cmdUnreadSms.Caption = "New Unread Message (" & unreadsms & ")"
        Else
            cmdUnreadSms.Visibility = BarItemVisibility.Never
        End If
        My.Computer.Audio.Play(Application.StartupPath.ToString & "\notify.wav", AudioPlayMode.Background)
        comm.DeleteMessages(DeleteScope.All, GetMessageStorage())
        frmSMSView.ViewSMsActive()
    End Sub
    Private Sub cmdUnreadSms_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdUnreadSms.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSMSView.Show()
        SplashScreenManager.CloseForm()

    End Sub
#End Region

    Private Sub BarButtonItem50_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmUserProfile.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem37_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmCheckUpdates.Show()
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub BarButtonItem9_ItemClick_2(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmSMSSettings.Show(Me)
        SplashScreenManager.CloseForm()

    End Sub

    Private Sub cmdPerformance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdPerformance.ItemClick
        frmUserPerformance.ShowDialog()
    End Sub

    Private Sub cmdWorkReport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdWorkReport.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        frmReports_Work.Show(Me)
        frmReports_Work.Focus()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdExportServer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdExportServer.ItemClick
        If XtraMessageBox.Show("Are you sure you want to export edited server records? " & Environment.NewLine & Environment.NewLine & "NOTE: Please be careful while using this tool. This will cause to unaccurate listing to the imported server if you do export repetitively.", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            frmServerDataExporter.Show(Me)
        End If
    End Sub

  
    Private Sub cmdIDCategory_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdIDCategory.ItemClick
        If frmCategoryID.Visible = True Then
            frmCategoryID.Focus()
        Else
            frmCategoryID.Show(Me)
        End If
    End Sub

    Private Sub cmdQRcodeScanning_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdQRcodeScanning.ItemClick
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        If frmQRCodeStubReports.Visible = True Then
            frmQRCodeStubReports.Focus()
        Else
            frmQRCodeStubReports.Show(Me)
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub cmdExportList_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdExportList.ItemClick
        frmExportList.Show(Me)
    End Sub
End Class