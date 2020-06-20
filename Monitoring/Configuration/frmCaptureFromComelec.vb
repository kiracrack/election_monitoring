Imports DevExpress.XtraEditors
Imports DevExpress
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Skins
Imports DevExpress.XtraReports.UI
Imports System.Xml
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel
Imports DevExpress.XtraEditors.Controls
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCaptureFromComelec
    Private errorcount As Integer = 0
    Private captureError As Boolean = False
    Private ErrPage As Integer = 0
    Private ErrRow As Integer = 0
    Private currentcapture As Integer = 0
    Private totalcapture As Integer = 0
    Private DataBook As Workbook
    Private DataSheet As Worksheet
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Shift + Keys.Delete Then
            RemoveItemToolStripMenuItem.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim xmlFile As XmlReader
    '    xmlFile = XmlReader.Create("Product.xml", New XmlReaderSettings())
    '    Dim ds As New DataSet
    '    ds.ReadXml(xmlFile)
    '    Dim i As Integer
    '    For i = 0 To ds.Tables(0).Rows.Count - 1
    '        MsgBox(ds.Tables(0).Rows(i).Item(1))
    '    Next
    'End Sub

    Public Sub filter()
        Dim filters As String = ""
        If ck_filterbrgy.Checked = True Then
            filters = TextEdit1.Text
        Else
            filters = ""
        End If
        LoadXgrid("select id, votersno as 'No.', votersid as 'Voters ID', precinct as 'Precinct No.', fullname as 'Fullname', address as 'Address', sex as 'Sex',vtype as 'VType', bdate as 'Birth Date' from tbldatacaptures where isuploaded=1 and captureby='" & globaluserid & "'" & filters, "tbldatacaptures", Em, GridView1, Me)
        GridView1.Columns("id").Visible = False
        XgridColAlign("No.", GridView1, Utils.HorzAlignment.Center)
        XgridColAlign("Precinct No.", GridView1, Utils.HorzAlignment.Center)
        XgridColAlign("Sex", GridView1, Utils.HorzAlignment.Center)
        XgridColAlign("VType", GridView1, Utils.HorzAlignment.Center)
        If GridView1.RowCount = 0 Then
            AddRowXgrid(GridView1)
        End If
        GridView1.Columns("Fullname").SummaryItem.SummaryType = Data.SummaryItemType.Count
        GridView1.Columns("Fullname").SummaryItem.DisplayFormat = "Total Captured Voters {0:N0}"
        GridView1.Columns("Fullname").SummaryItem.Tag = 1
        CType(GridView1.Columns("Fullname").View, GridView).OptionsView.ShowFooter = True
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
        txtArea.Text = txtArea.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadMunicipal()
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
        txtMunicipal.Text = txtMunicipal.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        loadVillage()
    End Sub

    Public Sub loadVillage()
        LoadXgridLookupSearch("SELECT villcode as 'Code', villname as 'Select List'  from tblvillage where areacode='" & areacode.Text & "' and muncode='" & muncode.Text & "' order by villname asc ", "tblvillage", txtVillage, gridVillage, Me)
        XgridColAlign("Code", gridVillage, DevExpress.Utils.HorzAlignment.Center)
        gridVillage.Columns("Code").Visible = False
    End Sub
    Private Sub txtVillage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVillage.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtVillage.Properties.View.FocusedRowHandle.ToString)
        vilcode.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Code").ToString()
        txtVillage.Text = txtVillage.Properties.View.GetFocusedRowCellValue("Select List").ToString()
        ' If CheckEdit1.Checked = True Then
        TextEdit1.Text = "and address like '%" & txtVillage.Text & "%'"
        filter()
        'End If
    End Sub

    Private Sub frmProductCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins()
        SetIcon(Me)
        reportcount(Me.Name.ToString)
        filter()
        loadArea()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        If globalpermission = 0 Then
            ck_advance.Enabled = True
        Else
            ck_advance.Enabled = False
            ck_advance.CheckState = CheckState.Unchecked
        End If
        If GridView1.RowCount = 0 Then
            AddRowXgrid(GridView1)
        End If
        If singleuse = "1" Then
            cmdArea.Visibility = XtraBars.BarItemVisibility.Never
            cmdMunicipal.Visibility = XtraBars.BarItemVisibility.Never
        Else
            cmdArea.Visibility = XtraBars.BarItemVisibility.Always
            cmdMunicipal.Visibility = XtraBars.BarItemVisibility.Always
        End If
        BarButtonItem5.Caption = "Clean Temporary Captured (" & countqry("tbldatacaptures", "isuploaded=0") & ")"
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Function Parser(ByVal str As String) As Boolean
        Try
            Double.Parse(str)
            Return True
        Catch fe As FormatException
            Return False
        End Try
    End Function

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'Declare a OpenFileDialog object
        Dim objOpenFileDialog As New OpenFileDialog
        'Set the Open dialog properties
        With objOpenFileDialog
            .Filter = "Excell files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
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
                txtpath.Text = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try

        End If

        'Clean up
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub
    Public Sub ClearFields()
        cmdCapture.Text = "Capture"
        cmdCapture.Enabled = True
        SplitContainerControl1.Focus()
        GridView1.Focus()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCapture.Click
        If txtpath.Text = "" Then
            XtraMessageBox.Show("Please Import Excel File.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpath.Focus()
            Exit Sub
        End If
        If countqry("tbldatacaptures", "isuploaded=1") <> 0 Then
            If XtraMessageBox.Show("There are existing captured data cunrrently not loaded to database. Are you sure you want to continue add capture?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                GridView1.MoveLast()
                AddRowXgrid(GridView1)
                If ReadInfoVoters() = True Then
                    StartCapture()
                End If
            End If
        Else
            If ReadInfoVoters() = True Then
                StartCapture()
            End If
        End If

    End Sub

    Public Sub StartCapture()
        Shell("taskkill /IM excel* ")
        Dim start As Boolean = True
        Dim idtrue As Boolean = True
        Dim cntrow1 As Integer = Val(txtrow1.Text)
        Dim cntrow2 As Integer = Val(txtrow2.Text)
        Dim cntsheet1 As Integer = Val(sheet1.Text)
        Dim cntsheet2 As Integer = Val(sheet2.Text)
        Dim rowCurrent As Integer = 1
        Dim rowCount As Integer = 0
        Dim cntrowcount As Integer = 0
        Dim Cell As Range
        Dim FieldData As New Object
        'DataBook = New Workbook
        'DataSheet = New Worksheet

        FieldData = CreateObject("Excel.Application")



        Dim array() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"}
        ' Dim ColGridArray() As String = {"Fullname", "Address1", "Sex", "ID", "Address2", "Birth Date"}
        'Cell = DataSheet.Range("A1")
        Dim cnt As Integer = 0
        If captureError = True Then
            cntsheet1 = ErrPage
            cntrow1 = ErrRow
            cntrowcount = currentcapture
            captureError = False
            AddRowXgrid(GridView1)
        End If
        For k = cntsheet1 To cntsheet2
            Try
                DataBook = FieldData.Workbooks.Open(txtpath.Text, , False)
                If DataBook.Worksheets.Item(k).name = "Page " & k Then
                    DataSheet = DataBook.Worksheets("Page " & k)
                Else
                    k = k + 1
                    DataSheet = DataBook.Worksheets("Page " & k)
                End If
                'DataSheet = DataBook.Worksheets("Page " & k)
                For R = cntrow1 To cntrow2
                    Try
                        For Each valueArr As String In array
                            For Each Cell In DataSheet.Range(valueArr & R)

                                Dim value_x As String = ""
                                value_x = System.Convert.ToString(Cell.Cells.Value2)

                                If (valueArr & R) = txtStartCol.Text & R And value_x <> "" Then
                                    'If rowCurrent = rschar(value_x) Then
                                    If start = True Then
                                        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No.").ToString = "" Then
                                            start = False
                                        Else
                                            AddRowXgrid(GridView1)
                                        End If
                                    Else
                                        com.CommandText = "insert into tbldatacaptures set votersid='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Voters ID").ToString) & "', " _
                                                   + " votersno='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No.").ToString) & "', " _
                                                   + " precinct='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.").ToString) & "', " _
                                                   + " fullname='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Fullname").ToString) & "', " _
                                                   + " address='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Address").ToString) & "', " _
                                                   + " bdate='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Birth Date").ToString) & "', " _
                                                   + " sex='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Sex").ToString) & "', " _
                                                   + " vtype='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VType").ToString) & "', " _
                                                   + " capturedate=current_timestamp, " _
                                                   + " captureby='" & globaluserid & "'" : com.ExecuteNonQuery()
                                        AddRowXgrid(GridView1)
                                    End If
                                    idtrue = True
                                    'End If
                                    cnt = 0
                                    rowCount = 0
                                    rowCurrent = rschar(value_x) + 1
                                    cntrowcount = cntrowcount + 1
                                End If
                                If value_x <> "" Then
                                    If cnt = 0 Then
                                        'If remallchar(value_x) = 0 Then
                                        If IsNumeric(value_x) = True Then
                                            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "No.", value_x)
                                        End If
                                        cmdCapture.Enabled = False
                                        cmdCapture.Text = "Capturing " & cntrowcount & "/" & totalcapture & " at Page " & k
                                        MainMonitoring.Text = "Capturing " & cntrowcount & "/" & totalcapture & " at Page " & k
                                        'cnt = -1
                                        'End If
                                    ElseIf cnt = 1 Then
                                        Dim words As String() = getnameandid(value_x).Split(New Char() {":"c})

                                        ' Use For Each loop over words and display them
                                        Dim word As String
                                        Dim cntwords As Integer = 0
                                        For Each word In words
                                            If cntwords = 0 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Voters ID", word)

                                            ElseIf cntwords = 1 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Fullname", word)

                                            ElseIf cntwords = 2 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.", word)

                                            End If
                                            cntwords = cntwords + 1
                                        Next
                                        errorcount = 0
                                    ElseIf cnt = 2 Then
                                        GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Address", value_x)
                                        errorcount = 0
                                    ElseIf cnt = 3 Then
                                        Dim add As String = ""
                                        If remallchar(Cell.Value) = 0 Then
                                            If value_x.Length = 1 Or value_x.Length = 3 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "VType", value_x)
                                            Else
                                                add = GridView1.GetFocusedRowCellValue("Address").ToString
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Address", add & " " & value_x)
                                                cnt = 2
                                            End If
                                        Else
                                            If value_x.Length = 1 Or value_x.Length = 3 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "VType", value_x)
                                                cnt = 3
                                            ElseIf value_x.Length = 6 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.", value_x.Remove(5, 1))
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "VType", value_x.Remove(0, 5))
                                                cnt = 3
                                            ElseIf value_x.Length = 8 Then
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.", value_x.Remove(5, 3))
                                                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "VType", value_x.Remove(0, 5))
                                                cnt = 3
                                            Else
                                                If remallchar(UCase(value_x)) <> 0 Then
                                                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Sex", value_x.Remove(0, value_x.Length - 1))
                                                    GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Birth Date", value_x.Remove(value_x.Length - 1, 1))
                                                End If
                                            End If
                                        End If
                                        errorcount = 0
                                    ElseIf cnt = 4 Then
                                        If remallchar(UCase(value_x)) <> 0 Then
                                            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Sex", value_x.Remove(0, value_x.Length - 1))
                                            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Birth Date", value_x.Remove(value_x.Length - 1, 1))
                                        End If
                                        errorcount = 0
                                    End If

                                    cnt = cnt + 1
                                End If
                                GridView1.BestFitColumns()
                            Next Cell
                        Next
                        If cntrowcount = totalcapture Then
                            Exit For
                        End If
                        'rowCount = rowCount + 1
                        'SplitContainerControl1.Focus()
                        'GridView1.Focus()
                    Catch ex As Exception
                        errorcount = errorcount + 1
                        ClearFields()
                        SplitContainerControl1.Focus()
                        GridView1.Focus()

                        If ckerror.Checked = True Then
                            If errorcount < 3 Then
                                PrintError()
                                ErrPage = k
                                ErrRow = R + 1
                                currentcapture = cntrowcount - 1
                                captureError = True
                                StartCapture()
                                Exit Sub
                            Else
                                If XtraMessageBox.Show("Invalid data arangement please review Page " & k & " at Row " & R & vbCrLf _
                                                                           & "Message:" & ex.Message & vbCrLf _
                                                                           & "Try again? ", _
                                                                            "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                                    errorcount = 0
                                    PrintError()
                                    ErrPage = k
                                    ErrRow = R
                                    currentcapture = cntrowcount - 1
                                    captureError = True
                                    StartCapture()
                                    Exit Sub
                                Else
                                    Exit Sub
                                End If
                            End If
                        Else
                            If XtraMessageBox.Show("Invalid data arangement please review Page " & k & " at Row " & R & vbCrLf _
                                            & "Message:" & ex.Message & vbCrLf _
                                            & "Try again? ", _
                                             "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                                errorcount = 0
                                PrintError()
                                ErrPage = k
                                ErrRow = R
                                currentcapture = cntrowcount - 1
                                captureError = True
                                StartCapture()
                                Exit Sub
                            Else
                                Exit Sub
                            End If
                        End If
                    End Try
                    cntrow1 = Val(txtrow1.Text)
                Next R
            Catch ex As Exception
                errorcount = errorcount + 1
                ClearFields()
                SplitContainerControl1.Focus()
                GridView1.Focus()
                If ckerror.Checked = True Then
                    If errorcount < 3 Then
                        PrintError()
                        ErrPage = k
                        currentcapture = cntrowcount
                        captureError = True
                        StartCapture()
                        Exit Sub
                    Else
                        If XtraMessageBox.Show("Invalid data arangement please review Page " & k & vbCrLf _
                                          & "Message:" & ex.Message & vbCrLf _
                                          & "Try again? ", _
                                           "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                            errorcount = 0
                            PrintError()
                            ErrPage = k
                            currentcapture = cntrowcount
                            captureError = True
                            StartCapture()
                            Exit Sub
                        Else
                            Exit Sub
                        End If
                    End If
                Else
                    If XtraMessageBox.Show("Invalid data arangement please review Page " & k & vbCrLf _
                                          & "Message:" & ex.Message & vbCrLf _
                                          & "Try again? ", _
                                           "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                        errorcount = 0
                        PrintError()
                        ErrPage = k
                        currentcapture = cntrowcount
                        captureError = True
                        StartCapture()
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End Try
            cntsheet1 = Val(sheet1.Text)
        Next k
        com.CommandText = "insert into tbldatacaptures set votersid='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Voters ID").ToString) & "', " _
                                                  + " votersno='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No.").ToString) & "', " _
                                                  + " precinct='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Precinct No.").ToString) & "', " _
                                                  + " fullname='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Fullname").ToString) & "', " _
                                                  + " address='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Address").ToString) & "', " _
                                                  + " bdate='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Birth Date").ToString) & "', " _
                                                  + " sex='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Sex").ToString) & "', " _
                                                  + " vtype='" & rchar(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "VType").ToString) & "', " _
                                                  + " capturedate=current_timestamp, " _
                                                  + " captureby='" & globaluserid & "'" : com.ExecuteNonQuery()
        ClearFields()
        DataBook.Close()
        SplitContainerControl1.Focus()
        filter()
        GridView1.Focus()
        GridView1.MoveLast()
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Voters ID").ToString = "" Then
            GridView1.DeleteSelectedRows()
        End If
        MainMonitoring.loadStatus()
        XtraMessageBox.Show("Voters Successfully Captured", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
        Return
    End Sub

    'Public Sub InsertData()
    '    com.CommandText = "insert into tbldatacaptures set votersid='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Voters ID") & "', " _
    '                                           + " votersno='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "No.") & "', " _
    '                                           + " precinct='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Precinct No.") & "', " _
    '                                           + " fullname='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Fullname") & "', " _
    '                                           + " address='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Address") & "', " _
    '                                           + " bdate='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Birth Date") & "', " _
    '                                           + " sex='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "Sex") & "', " _
    '                                           + " vtype='" & GridView1.GetRowCellValue(GridView1.IsLastRow - 1, "VType") & "', " _
    '                                           + " capturedate=current_timestamp, " _
    '                                           + " captureby='" & globaluserid & "'" : com.ExecuteNonQuery()
    'End Sub
    Public Function ReadInfoVoters() As Boolean
        Dim start As Boolean = True
        Dim idtrue As Boolean = True
        Dim strinfo As String = ""
        Dim strinfo2 As String = ""
        Dim cntrow1 As Integer = Val(txtrow1.Text)
        Dim cntrow2 As Integer = Val(txtrow2.Text)

        Dim cntsheet1 As Integer = Val(sheet1.Text)
        Dim cntsheet2 As Integer = Val(sheet2.Text)
        Dim rowCurrent As Integer = 1
        Dim rowCount As Integer = 0

        Dim Cell As Range
        Dim FieldData As New Object
        FieldData = CreateObject("Excel.Application")
        Dim InfoSheet As Worksheet
        Dim DataSheet As Worksheet
        Dim DataBook As Workbook
        DataBook = FieldData.Workbooks.Open(txtpath.Text, , False)
        InfoSheet = DataBook.Worksheets("Page " & sheet1.Text)
        For j = 1 To 8
            For Each Cell In InfoSheet.Range(txtColTitle.Text & j)
                Dim value_x As String = ""
                value_x = System.Convert.ToString(Cell.Cells.Value2)
                strinfo = strinfo + Environment.NewLine + value_x
            Next
        Next j

        Dim cnt As Integer = 0
        For k = cntsheet1 To cntsheet2
            DataSheet = DataBook.Worksheets("Page " & k)
            For I = cntrow1 To cntrow2
                Try
                    For Each Cell In DataSheet.Range(txtStartCol.Text & I)
                        Dim value_x As String = ""
                        value_x = System.Convert.ToString(Cell.Cells.Value2)
                        If value_x <> "" Then
                            rowCurrent = rschar(value_x)
                            cnt = 0
                            rowCount = rowCount + 1
                        End If
                        If cntrow1 = cntrow2 - 1 Then
                            If XtraMessageBox.Show(strinfo + Environment.NewLine + Environment.NewLine + "Total numbers of voters " & rowCount & ". Continue capture?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                lblinfo.Text = strinfo + Environment.NewLine + Environment.NewLine + "Total numbers of voters " & rowCount
                                totalcapture = rowCount
                                errorcount = 0
                                Return True
                            Else
                                Return False
                            End If
                        Else
                            If cnt >= 2 And k = cntsheet2 Then
                                If XtraMessageBox.Show(strinfo + Environment.NewLine + Environment.NewLine + "Total numbers of voters " & rowCount & ". Continue capture?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                                    lblinfo.Text = strinfo + Environment.NewLine + Environment.NewLine + "Total numbers of voters " & rowCount
                                    totalcapture = rowCount
                                    errorcount = 0
                                    Return True
                                Else
                                    Return False
                                End If
                            End If
                        End If


                    Next Cell
                    cnt = cnt + 1
                Catch ex As Exception
                    ClearFields()
                    XtraMessageBox.Show("Invalid data arangement please review Page " & k & " at Row " & I & vbCrLf _
                                         & "Message:" & ex.Message, _
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PrintError()
                    Return False
                End Try
            Next I
            cnt = 0
        Next k
        DataBook.Close()
        Return False
    End Function

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdArea.ItemClick
        frmArea.Show()
        loadArea()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMunicipal.ItemClick
        frmMunicipality.Show()
        loadMunicipal()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmVillage.Show()
        loadVillage()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" Then
            XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
            Em.Enabled = False
            If ck_loadSelected.Checked = True Then
                If GridView1.SelectedRowsCount = 0 Then
                    XtraMessageBox.Show("There is no selected rows!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Em.Focus()
                    Exit Sub
                End If
                LoadCheckedtoDatabase()
            Else
                LoadtoDatabase()
            End If

        End If
    End Sub
    Public Sub LoadCheckedtoDatabase()
        Dim Rows() As DataRow : Dim toUpdate As String = ""
        ReDim Rows(GridView1.SelectedRowsCount - 1)
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Both
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.SelectedRowsCount
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0
        For X = 0 To GridView1.SelectedRowsCount - 1
            Rows(X) = GridView1.GetDataRow(GridView1.GetSelectedRows(X))
            com.CommandText = "insert into tblvoters set votersid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Voters ID").ToString() & "', " _
                                                     + " precinct='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Precinct No.").ToString() & "', " _
                                                     + " votersno='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "No.").ToString() & "', " _
                                                     + " fullname='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Fullname").ToString().Replace("'", "") & "', " _
                                                     + " address='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Address").ToString().Replace("'", "''") & "', " _
                                                     + " bdate='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Birth Date").ToString() & "', " _
                                                     + " sex='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "Sex").ToString() & "', " _
                                                     + " vtype='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "VType").ToString() & "', " _
                                                     + " areacode='" & areacode.Text & "', " _
                                                     + " muncode='" & muncode.Text & "', " _
                                                     + " vilcode='" & vilcode.Text & "', " _
                                                     + " colorcode='" & globaldefcolor & "', " _
                                                     + " dateentry=current_timestamp, " _
                                                     + " entryby='" & globaluserid & "'" : com.ExecuteNonQuery()

            com.CommandText = "update  tbldatacaptures set isuploaded=0 where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(X), "id").ToString() & "'" : com.ExecuteNonQuery()
            ProgressBarControl1.PerformStep()
            ProgressBarControl1.Update()
        Next
        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Em.Enabled = True
        filter()
        XtraMessageBox.Show("Selected Voters successfully Loaded to database!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub LoadtoDatabase()
        'LoadXgrid("select '' as 'No.', '' as 'Voters ID', '' as 'Fullname', '' as 'Address', '' as 'Sex','' as 'VType', '' as 'Birth Date'", "tblvoters", Em, GridView1, Me)
        ProgressBarControl1.Properties.Step = 1
        ProgressBarControl1.Properties.PercentView = True
        ProgressBarControl1.Properties.Maximum = GridView1.RowCount + 1
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.Position = 0

        For X = 0 To GridView1.RowCount - 1
            Try
                If ckDelete.Checked = True Then
                    com.CommandText = "delete from tblvoters where votersid='" & GridView1.GetRowCellValue(X, "Voters ID").ToString() & "' and fullname='" & GridView1.GetRowCellValue(X, "Fullname").ToString().Replace("'", "") & "'" : com.ExecuteNonQuery()
                End If

                'MsgBox(GridView1.GetRowCellValue(X, "Voters ID").ToString())

                com.CommandText = "insert into tblvoters set votersid='" & GridView1.GetRowCellValue(X, "Voters ID").ToString() & "', " _
                                                    + " precinct='" & GridView1.GetRowCellValue(X, "Precinct No.").ToString() & "', " _
                                                    + " votersno='" & GridView1.GetRowCellValue(X, "No.").ToString() & "', " _
                                                    + " fullname='" & GridView1.GetRowCellValue(X, "Fullname").ToString().Replace("'", "") & "', " _
                                                    + " address='" & GridView1.GetRowCellValue(X, "Address").ToString().Replace("'", "''") & "', " _
                                                    + " bdate='" & GridView1.GetRowCellValue(X, "Birth Date").ToString() & "', " _
                                                    + " sex='" & GridView1.GetRowCellValue(X, "Sex").ToString() & "', " _
                                                    + " vtype='" & GridView1.GetRowCellValue(X, "VType").ToString() & "', " _
                                                    + " areacode='" & areacode.Text & "', " _
                                                    + " muncode='" & muncode.Text & "', " _
                                                    + " vilcode='" & vilcode.Text & "', " _
                                                    + " colorcode='" & globaldefcolor & "', " _
                                                    + " dateentry=current_timestamp, " _
                                                    + " entryby='" & globaluserid & "'" : com.ExecuteNonQuery()

                com.CommandText = "update  tbldatacaptures set isuploaded=0 where id='" & GridView1.GetRowCellValue(X, "id").ToString() & "'" : com.ExecuteNonQuery()
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Catch ex As Exception
                ClearFields()
                XtraMessageBox.Show("Error Found at row " & X & vbCrLf _
                                     & "Message:" & ex.Message, _
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PrintError()
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
                SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
                Em.Enabled = True
                filter()
                Exit Sub
            End Try
        Next X

        ProgressBarControl1.PerformStep()
        ProgressBarControl1.Update()
        SplitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
        Em.Enabled = True
        filter()
        XtraMessageBox.Show("Voters successfully Loaded to database!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RemoveItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemToolStripMenuItem.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove this item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If GridView1.GetFocusedRowCellValue("id").ToString = "" Then
                GridView1.DeleteSelectedRows()
            Else
                DeleteRow("id", "id", "tbldatacaptures", GridView1, Me)
                GridView1.DeleteSelectedRows()
            End If
        End If
        If GridView1.RowCount = 0 Then
            AddRowXgrid(GridView1)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Function getnameandid(ByVal data As String)
        Dim finalstr As String = ""
        Dim strdataname As String = checkNameFormat(data)
        Dim strdataother As String = ""
        Dim strdataid As String = ""
        Dim strother As String = ""
        Dim strname As String = ""
        Dim splitname As String() = strdataname.Split(New Char() {","c})

        ' Use For Each loop over words and display them
        Dim nameword As String = ""
        Dim idword As String = ""

        Dim ncount As Integer = 0
        For Each nameword In splitname
            If ncount = 0 Then
                strname = strname + nameword

            ElseIf ncount = 2 Then
                strname = strname + nameword

            Else
                strdataother = nameword
            End If
            ncount = ncount + 1
        Next

        Dim splitother As String() = strdataother.Split(New Char() {"-"c})
        Dim idcount As Integer = 0
        Dim percinct As String = ""
        For Each idword In splitother
            If idcount = 1 Then
                percinct = idword.ToString
            ElseIf idcount = 2 Then
                strother = idword.Remove(0, 8)

            ElseIf idcount = 3 Then
                strother = strother + "-" + idword

            End If
            idcount = idcount + 1
        Next


        If strother = "" Then
            finalstr = OtherNameID(data)
        Else
            Dim finalid As String = strdataother.Replace(remallnumbers(strother), "")
            'SPLIT FOR PRECINCT
            Dim splitprecinct As String() = strdataother.Split(New Char() {"-"c})
            Dim precount As Integer = 0
            Dim prestr As String = ""
            Dim secondname As String = ""
            Dim forndname As String = ""
            Dim forperc As String = ""
            For Each prestr In splitprecinct
                If precount = 0 Then
                    secondname = remallnumbers(prestr.ToString)
                End If
                precount = precount + 1
            Next
            'END SPLIT FOR PRECINCT

            If secondname <> "" Then
                forndname = " " + secondname
                forperc = finalid.Replace(secondname, "")
            Else
                forndname = ""
                forperc = finalid
            End If

            Dim finalname As String = strname + ", " + remallnumbers(strother) + forndname
            finalstr = forperc + ":" + finalname + ":" + percinct
        End If

        Return finalstr
    End Function

    Public Function OtherNameID(ByVal data As String)
        Dim strdataname As String = data
        Dim strdataother As String = ""
        Dim strdataid As String = ""
        Dim strother As String = ""
        Dim strname As String = ""
        Dim finalstr As String = ""

        Dim splitname As String() = strdataname.Split(New Char() {","c})

        ' Use For Each loop over words and display them
        Dim nameword As String = ""
        Dim idword As String = ""

        Dim ncount As Integer = 0
        For Each nameword In splitname
            If ncount = 1 Then
                strname = nameword
            ElseIf ncount = 2 Then
                strdataother = nameword
            Else
                strname = strname + nameword
            End If
            ncount = ncount + 1
        Next

        'MsgBox(strname + "  " + strdataother)

        Dim splitother As String() = strdataother.Split(New Char() {"-"c})
        Dim strk As String = ""
        Dim strk2 As String = ""
        Dim idcount As Integer = 0
        Dim percinct As String = ""

        For Each idword In splitother
            If idcount = 0 Then
                strname = strname
                strk = remallnumbers(idword)
            ElseIf idcount = 1 Then
                percinct = idword.ToString

            ElseIf idcount = 2 Then
                strother = idword.Remove(0, 8)
            End If
            idcount = idcount + 1
        Next
        'MsgBox(strdataother + " " + strother)
        strk2 = strdataother.Replace(remallnumbers(strother), "")

        Dim finalname As String = strk + " " + remallnumbers(strother) + ", " + remallnumbers(strname)
        Dim finalid As String = strk2.Replace(strk, "")
        finalstr = finalid + ":" + finalname + ":" + percinct
        Return finalstr
    End Function

    Public Function checkNameFormat(ByVal data As String)
        Dim asasas As String = ""
        Dim torep As String = ""
        Dim finalstr As String = ""
        Dim starcname As String = data
        Dim split_cname As String() = starcname.Split(New Char() {","c}, 1)
        For Each cname_word In split_cname
            If remallchar(cname_word) > 0 Then

                Dim splitother As String() = cname_word.Split(New Char() {"-"c})
                Dim idcount As Integer = 0
                For Each idword In splitother
                    If idcount = 0 Then
                        torep = remallnumbers(idword)

                    ElseIf idcount = 2 Then
                        asasas = idword.Remove(0, 8)
                        Exit For
                    End If
                    idcount = idcount + 1
                Next
                Dim k As String = strSplit(remallnumbers(asasas), ",", 0)
                finalstr = starcname.Replace(k & ", ", "")
                finalstr = finalstr.Replace(torep, torep & " " & k & ",")
            Else
                finalstr = data
            End If
        Next
        Return finalstr
    End Function
    Public Function strSplit(ByVal str As String, ByVal chartosplit As String, ByVal intindex As Integer)
        Dim strs As String = ""
        Dim ch As String = chartosplit
        Dim cnt As Integer = 0
        Dim splitname As String() = str.Split(New Char() {","c})
        For Each nameword In splitname
            If cnt = intindex Then
                strs = nameword
            End If
            cnt = cnt + 1
        Next
        Return strs
    End Function

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "delete from tbldatacaptures where isuploaded=0" : com.ExecuteNonQuery()
            BarButtonItem5.Caption = "Clean Temporary Captured (" & countqry("tbldatacaptures", "isuploaded=0") & ")"
            XtraMessageBox.Show("Data successfully removed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        BarButtonItem5.Caption = "Clean Temporary Captured (" & countqry("tbldatacaptures", "isuploaded=0") & ")"
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        DockPanel2.Hide()
        filter()
    End Sub

    Private Sub ck_advance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_advance.CheckedChanged
        If ck_advance.Checked = True Then
            If txtArea.Text = "" Then
                XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtArea.Focus()
                ck_advance.CheckState = CheckState.Unchecked
                Exit Sub
            ElseIf txtMunicipal.Text = "" Then
                XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMunicipal.Focus()
                ck_advance.CheckState = CheckState.Unchecked
                Exit Sub
            ElseIf txtVillage.Text = "" Then
                XtraMessageBox.Show("Please select barangay.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVillage.Focus()
                ck_advance.CheckState = CheckState.Unchecked
                Exit Sub
            End If
        End If
        If ck_advance.Checked = True Then
            DockPanel2.Show()
        Else
            DockPanel2.Hide()
            ck_loadSelected.CheckState = CheckState.Unchecked
            ck_filterbrgy.CheckState = CheckState.Unchecked
        End If
    End Sub
End Class