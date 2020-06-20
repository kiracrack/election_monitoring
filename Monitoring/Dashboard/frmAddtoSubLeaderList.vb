Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class frmAddtoSubLeaderList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = Keys.Insert Then
            MakeLeaderToolStripMenuItem.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmVotersList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        filter()
    End Sub

    Private Sub frmVotersList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ClearFields()
    End Sub

    Private Sub frmListingVoters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filter()
        ViewGridtype(GridView1)
    End Sub

    Public Sub filter()
        LoadXgrid("select  votersid ,precinct as 'Precinct No.',if(Cluster=0,'NONE',cluster) as 'Cluster', Fullname as 'Voter''s',bdate as 'Birtdate', Sex, Address, " _
                                    + " (select areaname from tblarea where areacode = tblvoters.areacode) as 'Area/District', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'Municipal/City', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'Village/Barangay', " _
                                    + " dateentry as 'Date Entry', " _
                                    + " (select colorname from tblcolor where colorcode = tblvoters.colorcode) as 'colorcode', " _
                                    + " '' as 'Color' from tblvoters where " _
                                    + " areacode='" & areacode.Text & "' and " _
                                    + " muncode='" & muncode.Text & "' and " _
                                    + " vilcode='" & vilcode.Text & "' and " _
                                    + " votersid <> '" & votersid.Text & "' and leaderid<>  '" & votersid.Text & "' and leaderid = '0' and subleaderid = '0' and isleader =  0 and deceased=0 order by fullname asc", "tblvoters", Em, GridView1, Me)

        GridView1.Columns("colorcode").Visible = False
        GridView1.Columns("votersid").Visible = False
        GridView1.Columns("Color").Width = 40
        GridView1.Columns("Precinct No.").Width = 70
        XgridColAlign("Precinct No.", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Birtdate", GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Cluster", GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.Columns("Voter's").SummaryItem.SummaryType = SummaryItemType.Count
        GridView1.Columns("Voter's").SummaryItem.DisplayFormat = "Total Remaining Voters {0}"
        GridView1.Columns("Voter's").SummaryItem.Tag = 1
        CType(GridView1.Columns("Voter's").View, GridView).OptionsView.ShowFooter = True
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorcode"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub
    Public Sub ClearFields()
        votersid.Text = ""
        areacode.Text = ""
        muncode.Text = ""
        vilcode.Text = ""
        txtprecinctno.Text = ""
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridView1.ShowFindPanel()
    End Sub

    Private Sub MakeLeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeLeaderToolStripMenuItem.Click
        Try
            If GridView1.GetFocusedRowCellValue("votersid").ToString = "" Then
                XtraMessageBox.Show("There is no item selected! make sure, the selection is on the list", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            'If XtraMessageBox.Show("Are you sure you want to continue? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Row As DataRow : Dim Rows() As DataRow : Dim I As Integer : Dim toUpdate As String = ""
            ReDim Rows(GridView1.SelectedRowsCount - 1)

            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount + 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0

            Dim colorleader As String = ""
            For I = 0 To GridView1.SelectedRowsCount - 1
                Rows(I) = GridView1.GetDataRow(GridView1.GetSelectedRows(I))
                toUpdate = GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "votersid")
                If globalautocolorleadersmember = True Then
                    com.CommandText = "update tblvoters set leaderid='" & votersid.Text & "', subleaderid='" & subleaderid.Text & "', colorcode='" & colorcode.Text & "', isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                Else
                    com.CommandText = "update tblvoters set leaderid='" & votersid.Text & "', subleaderid='" & subleaderid.Text & "', colorcode='" & globaldefcolorMember & "', isedited=1,editedby='" & globaluserid & "' where votersid='" & toUpdate & "'" : com.ExecuteNonQuery()
                End If
                LogQuery(Me.Text, com.CommandText.ToString, "ASSIGNED TO A LEADER AND COLOR CHANGED")

                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            For Each Row In Rows
                Row.Delete()
            Next

            com.CommandText = "update tblleaders set totalmember = (select count(*) from tblvoters where tblvoters.leaderid= tblleaders.votersid), isedited=1,editedby='" & globaluserid & "' where votersid='" & votersid.Text & "';" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE TOTAL MEMBER OF A LEADER")
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
            frmLeaderInformation.filter()
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
End Class