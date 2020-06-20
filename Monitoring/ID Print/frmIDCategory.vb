Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmIDCategory

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function


    Private Sub frmIDCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadCategory()
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT id as 'Code', description as 'Select List',idtemplate,customized  from tblidcategory order by description asc ", "tblidcategory", txtIDCategory, gridArea, Me)
        XgridColAlign("Code", gridArea, DevExpress.Utils.HorzAlignment.Center)
        gridArea.Columns("Code").Visible = False
        gridArea.Columns("idtemplate").Visible = False
        gridArea.Columns("customized").Visible = False
    End Sub
    Private Sub txtArea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDCategory.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtIDCategory.Properties.View.FocusedRowHandle.ToString)
        filename.Text = txtIDCategory.Properties.View.GetFocusedRowCellValue("idtemplate").ToString()
        CheckEdit1.Checked = CBool(txtIDCategory.Properties.View.GetFocusedRowCellValue("customized").ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIDCategory.Text = "" Then
            XtraMessageBox.Show("Please select ID category", compname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIDCategory.Focus()
            Exit Sub
        End If

        If mode.Text = "voters" Then
            frmVotersEntries.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), True)
        ElseIf mode.Text = "leaders" Then
            frmLeaders.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), True)
        Else
            frmVotersEntries.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), True)
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckEdit1.Checked = True Then
            If mode.Text = "voters" Then
                frmVotersEntries.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), False)
            ElseIf mode.Text = "leaders" Then
                frmLeaders.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), False)
            Else
                frmVotersEntries.PrintID(txtIDCategory.Text, filename.Text, CBool(CheckEdit1.Checked), False)
            End If
        Else
            int_report = 1 'chạy report đơn
            strTitle = ""
            strMaNV = ""
            strFilename = filename.Text
            Dim f As New frmReportDesigner
            f.Show()
        End If
       
    End Sub
 
End Class