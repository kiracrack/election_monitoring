Imports System.IO
Imports DevExpress.XtraSplashScreen

Public Class frmCheckUpdates
    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        checkServer()
    End Sub
    Public Sub checkServer()
        Dim fversion As Date = System.IO.File.GetLastWriteTime(My.Application.Info.DirectoryPath).ToShortDateString()
        If CheckConnServer() = True Then
            If countrecordserver("tblclientsystemupdate") > 0 Then
                comclient.CommandText = "select *, date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') as dt from tblclientsystemupdate where server=1 and active=1" : rstclient = comclient.ExecuteReader
                While rstclient.Read
                    If dversion < CDate(rstclient("dt").ToString) Then
                        lblTitle.Text = "New update available"
                        lblVersion.Text = "Update Version v" & Format(CDate(rstclient("dt").ToString), "yy.M.d")
                        txturl.Text = rstclient("downloadurl").ToString
                        txtversion.Text = rstclient("version").ToString
                        cmdDownload.Visible = True
                    Else
                        lblTitle.Text = "Your system is up to date"
                        lblVersion.Text = "Build Version v" & Format(dversion, "yy.M.d")
                        cmdDownload.Visible = False
                    End If
                End While
                rst.Close()
                If cmdDownload.Visible = False Then
                    lblTitle.Text = "Your system is up to date"
                    lblVersion.Text = "Build Version v" & Format(dversion, "yy.M.d")
                    cmdDownload.Visible = False
                End If
            End If
            lblTitle.ForeColor = DefaultForeColor
            cmdDownload.Text = "Download update"
            cmdDownload.Appearance.BackColor = Color.Green
            cmdDownload.Appearance.BackColor2 = Color.Green
        Else
            lblTitle.ForeColor = Color.Red
            lblTitle.Text = "Connot connect from server host"
            lblVersion.Text = "Your system Version v" & Format(dversion, "yy.M.d")
            cmdDownload.Text = "Retry"
            cmdDownload.Appearance.BackColor = Color.Red
            cmdDownload.Appearance.BackColor2 = Color.Red
        End If
    End Sub
    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        If cmdDownload.Text = "Retry" Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            checkServer()
            SplashScreenManager.CloseForm()
        Else
            Me.Hide()
            frmSystemDownloader.txtFileName.Text = txturl.Text
            frmSystemDownloader.txtversion.Text = txtversion.Text
            frmSystemDownloader.Show()
        End If

    End Sub
End Class