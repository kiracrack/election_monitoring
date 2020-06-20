Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraReports.UI

Public Class frmSubMemberInfo
    Public BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        ElseIf keyData = Keys.Control + Keys.C Then
            If selectedColorCode = "" Then
                If XtraMessageBox.Show("Default color currently not selected! Do you want to select color? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmColorChange.Show()
                End If
            End If
            ChangeColor(selectedColorCode, selectedColorname)
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSubMemberInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSubMemberInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        filter()
        ViewGridtype(GridView1)
    End Sub

    Public Sub filter()
        
        LoadXgrid("select votersid as 'Voters ID','' as 'No.', precinct as 'Precinct No.', votersno as 'Listing No.', if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Household Member', " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'colorcode', " _
                                    + " '' as 'Color' " _
                                    + "  from tblvoters where leaderid='" & leaderid.Text & "' and subleaderid='" & subleaderid.Text & "' " _
                                    + " order by fullname asc", "tblvoters", Em, GridView1, Me)
        

        GridView1.Columns("Voters ID").Visible = False
        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("No.").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        XgridColAlign("No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Listing No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Household Member").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Household Member").SummaryItem.DisplayFormat = "Total Assigned {0}"
        GridView1.Columns("Household Member").SummaryItem.Tag = 1
        CType(GridView1.Columns("Household Member").View, GridView).OptionsView.ShowFooter = True

        NoSequence()
    End Sub
    Public Sub NoSequence()
        Dim cnt As Integer = 1
        For I = 0 To GridView1.DataRowCount - 1
            GridView1.SetRowCellValue(I, "No.", cnt & ".")
            cnt = cnt + 1
        Next I
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender

        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorcode"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub MakeLeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeLeaderToolStripMenuItem.Click
        Try
            If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
                ReDim Rows(GridView1.SelectedRowsCount - 1)
                For I = 0 To GridView1.SelectedRowsCount - 1
                    Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                    toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
                    com.CommandText = "update tblvoters set leaderid='0', subleaderid='0' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "REMOVED FROM LEADER LIST")
                    If qrysingledata("colorcode", "colorcode", "where votersid='" & toUpdate & "'", "tblvoters") <> globaldefcolor Then
                        If XtraMessageBox.Show("Voter's " & qrysingledata("fullname", "fullname", "where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'", "tblvoters") & "'S currently tagged color as " & qrysingledata("description", "description", "where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'", "tblvoters inner join tblcolor on tblvoters.colorcode=tblcolor.colorcode") & "!, do you want to change by default color as " & globaldefcolordesc & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                            com.CommandText = "update tblvoters set colorcode='" & globaldefcolor & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID") & "'" : com.ExecuteNonQuery()
                            LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED DUE TO REMOVING FROM LEADER LIST")
                        End If
                    End If
                Next
                com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid) where votersid='" & leaderid.Text & "';" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")
                For Each Row In Rows
                    Row.Delete()
                Next
                filter()
                frmLeaderInformation.filter()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
          
    Public Function ChangeColor(ByVal color As String, ByVal colorname As String)
        Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)

        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0

        For I = 0 To GridView1.SelectedRowsCount - 1
            Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
            toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Voters ID")
            com.CommandText = "update tblvoters set colorcode='" & color & "',isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "COLOR CHANGED")

            GridView1.SetRowCellValue(GridView1.GetSelectedRows(I), "colorcode", colorname)
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Return 0
    End Function

    Private Sub ChangeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeColorToolStripMenuItem.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmColorChange.mode.Text = "subleaderinfo"
        frmColorChange.Show()
    End Sub
     
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If GridView1.GetFocusedRowCellValue("Voters ID").ToString = "" Then
            XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmEntryInfo.votersid.Text = GridView1.GetFocusedRowCellValue("Voters ID").ToString
        frmEntryInfo.mode.Text = "edit"
        frmEntryInfo.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        GenerateCoupon()
    End Sub

    Public Sub GenerateCoupon()
        Dim FinalReport As String = "" : Dim PageHeader As String = "" : Dim TableHeader As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim pageFooter As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Template\coupon.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Reports\coupon-" & globaluserid & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblvoters where leaderid='" & leaderid.Text & "' or votersid='" & leaderid.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                TableRow += "<div align='center' style='width:700px; margin: auto; border-bottom: 2px dotted #000; padding: 20px; display: block;'>" _
                                + " <div align='center' style='width:550px; margin: auto;'> " _
                                  + " <p align='left'><font style='font-size: 25px;'>" & .Rows(cnt)("fullname").ToString() & "</font> <span style='float: right;'>Precinct: <b>" & .Rows(cnt)("precinct").ToString() & "</b><br/>Cluster: <b>" & .Rows(cnt)("cluster").ToString() & "</b><br/>Listing No. <b>" & .Rows(cnt)("votersno").ToString() & "</b></span><br/><b>" & .Rows(cnt)("comelecid").ToString() & "</b><br/>" & .Rows(cnt)("address").ToString() & "</p> " _
                                  + " </div> " _
                                  + " </div>" & Chr(13)
            End With
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[start_report]", TableRow), False)
        PrintLXReceipt(SaveLocation.Replace("\", "/"), Me)
    End Sub

    Private Sub cmdAddMember_Click(sender As Object, e As EventArgs) Handles cmdAddMember.Click
        frmAddtoSubLeaderList.votersid.Text = leaderid.Text
        frmAddtoSubLeaderList.subleaderid.Text = subleaderid.Text
        frmAddtoSubLeaderList.areacode.Text = areacode.Text
        frmAddtoSubLeaderList.muncode.Text = muncode.Text
        frmAddtoSubLeaderList.vilcode.Text = vilcode.Text
        frmAddtoSubLeaderList.txtprecinctno.Text = txtprecintno.Text
        frmAddtoSubLeaderList.colorcode.Text = subleaderid.Text
        frmAddtoSubLeaderList.Show()
        frmAddtoSubLeaderList.WindowState = FormWindowState.Normal
    End Sub
 
End Class