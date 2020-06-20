Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.XtraEditors.Camera
Imports DevExpress.XtraEditors.Controls

Public Class frmEntryInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmEntryInfo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If txtArea.Text = "" Then
            loadArea()
        ElseIf txtMunicipal.Text = "" Then
            loadMunicipal()
        ElseIf txtVillage.Text = "" Then
            loadVillage()
        End If
    End Sub
    Private Sub frmLeadersInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        loadArea()
        loadMunicipal()
        loadVillage()
        loadColor()

        If mode.Text <> "edit" Then
            txtbdate.Text = "__/__/____"
            LoadToComboBox("precinct", "tblvoters", txtprecintno, True)
            LoadSector()
            txtDateDeceased.EditValue = Now
        End If

        LoadFamilyMember()
        loadFamilyRelationship()

        txtEducSchoolPeriod.EditValue = Now
        loadSchoolName()
        loadSchoolAddress()
        LoadEducation()

        LoadWork()
        loadWorkCompany()
        loadWorkAddress()
        loadWorkPosition()
        LoadWorkStatus()
        txtDateWorkFrom.EditValue = Now
        txtDateWorkTo.EditValue = Now
        If mode.Text <> "edit" Then
            loadDefaultSelection()
        End If
    End Sub

    Public Sub loadDefaultSelection()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblaccounts where accountid='" & globaluserid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                areacode.Text = .Rows(cnt)("areacode").ToString
                txtArea.EditValue = .Rows(cnt)("areacode").ToString
                muncode.Text = .Rows(cnt)("muncode").ToString
                txtMunicipal.EditValue = .Rows(cnt)("muncode").ToString
                vilcode.Text = .Rows(cnt)("brgycode").ToString
                txtVillage.EditValue = .Rows(cnt)("brgycode").ToString
            End With
        Next
    End Sub

    Public Sub LoadSector()
        com.CommandText = "select * from tblsector"
        rst = com.ExecuteReader
        ls.Items.Clear()
        While rst.Read
            ls.Items.Add(rst("sectorcode"), False)
            ls.Items.Item(rst("sectorcode")).Description = rst("sectorname").ToString
            ls.Items.Item(rst("sectorcode")).Value = rst("sectorcode").ToString
        End While
        rst.Close()
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

    End Sub

    Public Sub loadColor()
        LoadXgridLookupSearch("Select colorcode,colorname,'' as 'Color', Description from tblcolor", "tblcolor", txtcolor, gridcolor, Me)
        gridcolor.Columns("colorcode").Visible = False
        gridcolor.Columns("colorname").Visible = False
        gridcolor.Columns("Color").Width = 40
    End Sub
    Private Sub GridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridcolor.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Color" Then
            Dim colorname As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("colorname"))
            e.Appearance.BackColor = Color.FromName(colorname)
        End If
    End Sub
    Private Sub txtcolor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolor.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtcolor.Properties.View.FocusedRowHandle.ToString)
        colorcode.Text = txtcolor.Properties.View.GetFocusedRowCellValue("colorcode").ToString()
        txtcolor.Text = txtcolor.Properties.View.GetFocusedRowCellValue("Description").ToString()
    End Sub
    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If txtno.Text = "" Then
            XtraMessageBox.Show("Please enter Listing No.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtno.Focus()
            Exit Sub
        
        ElseIf txtfullname.Text = "" Then
            XtraMessageBox.Show("Please enter Fullname", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtfullname.Focus()
            Exit Sub
        ElseIf txtbdate.Text = "__/__/____" Then
            XtraMessageBox.Show("Please recheck birthdate", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtbdate.Focus()
            Exit Sub
        ElseIf txtsex.Text = "" Then
            XtraMessageBox.Show("Please select Sex.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtsex.Focus()
            Exit Sub
        ElseIf txtCellular.Text.Length <> 13 And txtCellular.Text <> "" Then
            XtraMessageBox.Show("Invalid cellular number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCellular.Focus()
            Exit Sub
        ElseIf txtprecintno.Text = "" Then
            XtraMessageBox.Show("Please enter Precint Number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtprecintno.Focus()
            Exit Sub
        ElseIf txtArea.Text = "" Then
            XtraMessageBox.Show("Please select Area.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtArea.Focus()
            Exit Sub
        ElseIf txtMunicipal.Text = "" Then
            XtraMessageBox.Show("Please select municipal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMunicipal.Focus()
            Exit Sub
        ElseIf txtVillage.Text = "" Then
            XtraMessageBox.Show("Please select Village.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVillage.Focus()
            Exit Sub

        End If
        If globaldefcolor = "" Then
            If txtcolor.Text = "" Then
                XtraMessageBox.Show("Please select Color! or please assign default color at color configuration, then you can leave this as blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtcolor.Focus()
                Exit Sub
            End If
        End If
        Try
            Dim tempColor As String = ""
            If colorcode.Text = "" Then
                tempColor = globaldefcolor
            Else
                tempColor = colorcode.Text
            End If
            SaveDefaultOption(-1, areacode.Text, muncode.Text, vilcode.Text)
            If mode.Text = "edit" Then
                If XtraMessageBox.Show(txtfullname.Text & " already exist! do you want to replace existing record?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    com.CommandText = "update tblvoters set votersno='" & txtno.Text & "', " _
                                            + " comelecid='" & comelecid.Text & "', " _
                                            + " precinct='" & txtprecintno.Text & "', " _
                                            + " cluster='" & If(txtCluster.Text = "", "0", txtCluster.Text) & "', " _
                                            + " fullname='" & rchar(txtfullname.Text) & "', " _
                                            + If(txtbdate.Text <> "", " bdate='" & CDate(txtbdate.EditValue).ToString("MM/dd/yyyy") & "', ", "") _
                                            + " sex='" & txtsex.Text & "', " _
                                            + " vtype='" & txtvtype.Text & "', " _
                                            + " address='" & txtfulladdress.Text & "', " _
                                            + " contactnumber='" & txtCellular.Text & "', " _
                                            + " areacode='" & areacode.Text & "', " _
                                            + " muncode='" & muncode.Text & "', " _
                                            + " vilcode='" & vilcode.Text & "', " _
                                            + " colorcode='" & tempColor & "', " _
                                            + " editedby='" & globaluserid & "', " _
                                            + " remarks='" & txtRemarks.Text & "', " _
                                            + " deceased='" & ckDeceased.CheckState & "' " _
                                            + If(ckDeceased.Checked = True, ", datedeceased='" & ConvertDate(txtDateDeceased.Text) & "'", "") _
                                            + " where votersid='" & votersid.Text & "'"
                    com.ExecuteNonQuery() : LogQuery(Me.Text, com.CommandText.ToString, "UPDATE VOTERS INFORMATION")

                    If countqry("tblleaders", "votersid='" & votersid.Text & "'") > 0 Then
                        com.CommandText = "UPDATE tblleaders set leadername='" & (txtfullname.Text) & "', birthdate='" & CDate(txtbdate.EditValue).ToString("MM/dd/yyyy") & "',precinct='" & txtprecintno.Text & "' where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE LEADER INFO")
                    End If

                    If ckImageUpdate.Checked = True Then
                        UpdateImage("votersid='" & votersid.Text & "'", "imgprofile", "filedir.tblvotersimage", imgProfilePic, Me)
                    End If

                    If countqry("tblsmsinbox", "sender='" & txtCellular.Text & "'") > 0 Then
                        com.CommandText = "update tblsmsinbox set sendername='" & rchar(txtfullname.Text) & "',area='" & rchar(txtArea.Text) & "',city='" & rchar(txtMunicipal.Text) & "', barangay='" & rchar(txtVillage.Text) & "',purok='', precinct='" & rchar(txtprecintno.Text) & "' where sender='" & txtCellular.Text & "'" : com.ExecuteNonQuery()
                        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE UNREGISTER SMS LIST OF " & UCase(txtfullname.Text))
                    End If
                    ClearFields() : ckImageUpdate.Checked = False
                    XtraMessageBox.Show("Voters " & txtfullname.Text & " Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    comelecid.Focus()
                End If
            Else
                Dim getnewvotersid As String = ""
                com.CommandText = "insert into tblvoters set votersno='" & txtno.Text & "', " _
                                                               + " comelecid='" & comelecid.Text & "' , " _
                                                               + " precinct='" & txtprecintno.Text & "', " _
                                                               + " cluster='" & If(txtCluster.Text = "", "0", txtCluster.Text) & "', " _
                                                               + " fullname='" & rchar(txtfullname.Text) & "', " _
                                                               + If(txtbdate.Text <> "", " bdate='" & CDate(txtbdate.EditValue).ToString("MM/dd/yyyy") & "', ", "") _
                                                               + " sex='" & txtsex.Text & "', " _
                                                               + " vtype='" & txtvtype.Text & "', " _
                                                               + " address='" & txtfulladdress.Text & "', " _
                                                               + " contactnumber='" & txtCellular.Text & "', " _
                                                               + " areacode='" & areacode.Text & "', " _
                                                               + " muncode='" & muncode.Text & "', " _
                                                               + " vilcode='" & vilcode.Text & "', " _
                                                               + " colorcode='" & tempColor & "', " _
                                                               + " editedby='" & globaluserid & "', " _
                                                               + " remarks='" & txtRemarks.Text & "', " _
                                                               + " deceased='" & ckDeceased.CheckState & "' " _
                                                               + If(ckDeceased.Checked = True, ", datedeceased='" & ConvertDate(txtDateDeceased.Text) & "'", "")

                com.ExecuteNonQuery() : LogQuery(Me.Text, com.CommandText.ToString, "NEW VOTERS INFORMATION ADDED")

                If countqry("tblleaders", "votersid='" & votersid.Text & "'") > 0 Then
                    com.CommandText = "UPDATE tblleaders set leadername='" & rchar(txtfullname.Text) & "', birthdate='" & CDate(txtbdate.EditValue).ToString("MM/dd/yyyy") & "',precinct='" & txtprecintno.Text & "' where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "UPDATE LEADER INFO")
                End If

                If ckImageUpdate.Checked = True Then
                    Dim vid As String = ""
                    If votersid.Text = "" Then
                        vid = qrysingledata("votersid", "votersid", "tblvoters where votersno='" & txtno.Text & "' and comelecid='" & comelecid.Text & "' and precinct='" & txtprecintno.Text & "' and cluster='" & txtCluster.Text & "' and fullname='" & rchar(txtfullname.Text) & "' and editedby='" & globaluserid & "'", "tblvoters")
                    Else
                        vid = votersid.Text
                    End If
                    UpdateImage("votersid='" & vid & "'", "imgprofile", "filedir.tblvotersimage", imgProfilePic, Me)
                End If

                If countqry("tblsmsinbox", "sender='" & txtCellular.Text & "' and sendername=''") > 0 Then
                    com.CommandText = "update tblsmsinbox set sendername='" & rchar(txtfullname.Text) & "',area='" & rchar(txtArea.Text) & "',city='" & rchar(txtMunicipal.Text) & "', barangay='" & rchar(txtVillage.Text) & "',purok='',precinct='" & rchar(txtprecintno.Text) & "' where sender='" & txtCellular.Text & "'" : com.ExecuteNonQuery()
                    LogQuery(Me.Text, com.CommandText.ToString, "UPDATE UNREGISTER SMS LIST OF " & UCase(txtfullname.Text))
                End If

                ClearFields() : ckImageUpdate.Checked = False
                XtraMessageBox.Show("Voters " & txtfullname.Text & " Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                comelecid.Focus()
            End If
            LoadSector()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mode.EditValueChanged
        If mode.Text = "" Then Exit Sub
        LoadSector()
        Dim leader As String = "" : Dim area As String = "" : Dim municipal As String = "" : Dim village As String = "" : Dim color As String = "" : Dim Sectors As String = "" : Dim strcolorcode As String = ""
        Try
            com.CommandText = "select *,str_to_date(bdate, '%m/%d/%Y') as 'birthdate', mid(contactnumber,1,CHAR_LENGTH(contactnumber)) as contact, (select areaname from tblarea where areacode = tblvoters.areacode) as 'area', " _
                                    + " (select munname from tblmunicipality where muncode=tblvoters.muncode) as 'municipal', " _
                                    + " (select villname from tblvillage where villcode=tblvoters.vilcode) as 'village', " _
                                    + " (select description from tblcolor where colorcode=tblvoters.colorcode) as 'Color', " _
                                    + " (select leadername from tblleaders where votersid=tblvoters.leaderid)  as 'leadername', " _
                                    + " (select b.fullname from tblvoters as b where votersid=tblvoters.subleaderid)  as 'subleadername' " _
                                    + "  from tblvoters where votersid='" & votersid.Text & "'"
            rst = com.ExecuteReader
            While rst.Read
                txtno.Text = rst("votersno").ToString
                comelecid.Text = rst("comelecid").ToString
                txtprecintno.Text = rst("precinct").ToString
                txtfullname.Text = rst("fullname").ToString
                ' MsgBox(rst("birthdate").ToString)
                txtbdate.EditValue = rst("birthdate").ToString
                txtCluster.Text = rst("cluster").ToString
                'txtbdate.Text = txtbdate.EditValue
                txtsex.Text = rst("sex").ToString
                txtCellular.Text = rst("contact").ToString
                txtvtype.Text = rst("vtype").ToString
                txtfulladdress.Text = rst("address").ToString
                txtRemarks.Text = rst("remarks").ToString
                areacode.Text = rst("areacode").ToString
                muncode.Text = rst("muncode").ToString
                vilcode.Text = rst("vilcode").ToString

                strcolorcode = rst("colorcode").ToString
                color = rst("color").ToString
                ckDeceased.Checked = rst("deceased")
                txtLeader.Text = rst("leadername").ToString
                txtSubLeader.Text = rst("subleadername").ToString
                If CBool(rst("deceased")) = True Then
                    txtDateDeceased.EditValue = rst("datedeceased").ToString
                End If
                For Each strresult In rst("sector").ToString.Split(New Char() {"|"c})
                    For I = 0 To ls.Items.Count - 1
                        If ls.Items.Item(I).Value.ToString = strresult Then
                            ls.Items.Item(strresult).CheckState = CheckState.Checked
                        End If
                    Next
                Next
            End While
            rst.Close()
            imgProfilePic.Image = Nothing
            com.CommandText = "select * from filedir.tblvotersimage where votersid='" & votersid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                If rst("imgprofile").ToString <> "" Then
                    imgBytes = CType(rst("imgprofile"), Byte())
                    'Read the byte array into a MemoryStream
                    stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                    'Create the new Image from the stream
                    img = Image.FromStream(stream)
                    'Now add the image to the table
                    imgProfilePic.Image = img
                End If
            End While

            rst.Close()

            txtArea.EditValue = areacode.Text
            txtMunicipal.EditValue = muncode.Text
            txtVillage.EditValue = vilcode.Text

            txtcolor.Text = color
            colorcode.Text = strcolorcode

            'txtBarcode.Text = votersid.Text
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ClearFields()
        txtno.Text = Val(txtno.Text) + 1
        votersid.text = ""
        votersid.Text = ""
        txtfullname.Text = ""
        txtbdate.Text = "__/__/____"
        txtsex.SelectedIndex = -1
        imgProfilePic.Image = Nothing
        'txtArea.Text = ""
        'txtMunicipal.Text = ""
        'txtVillage.Text = ""
        'txtGroup.Text = ""

        'areacode.Text = ""
        'muncode.Text = ""
        'vilcode.Text = ""
        'groupcode.Text = ""
        'colorcode.Text = ""

        mode.Text = ""
    End Sub

    Private Sub frmLeadersInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ClearFields()
    End Sub

    Private Sub imgProfilePic_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles imgProfilePic.Validating
        resizesignature()
    End Sub
    Public Sub resizesignature()

        If imgProfilePic.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(imgProfilePic.Image)
        imgProfilePic.Image = Original

        Dim m As Int32 = 350
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        imgProfilePic.Image = Thumb
        ckImageUpdate.Checked = True
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim strCheckedCode = ""
        If ls.CheckedItems.Count > 0 Then
            For n = 0 To ls.CheckedItems.Count - 1
                strCheckedCode = strCheckedCode + ls.Items.Item(ls.CheckedItems.Item(n)).Value.ToString + "|"
            Next
            selectedSectorCode = strCheckedCode.Remove(strCheckedCode.Length - 1, 1)
            com.CommandText = "update tblvoters set sector='" & selectedSectorCode & "' where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblvoters set sector='' where votersid='" & votersid.Text & "'" : com.ExecuteNonQuery()
        End If
        LogQuery(Me.Text, com.CommandText.ToString, "UPDATE VOTER SECTOR")
        XtraMessageBox.Show("Sector successfully saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


#Region "FAMILY MEMBER"
    Public Sub LoadFamilyMember()
        LoadXgrid("select id, Fullname, Relationship from tblfamilymember where votersid='" & votersid.Text & "'", "tblfamilymember", gridFamily, g_Family, Me)
        g_Family.Columns("id").Visible = False
    End Sub
    Public Sub loadFamilyRelationship()
        LoadToComboBox("relationship", "tblfamilymember", txtFamilyRelationship, True)
    End Sub
    Public Sub ShowFamilyInfo()
        com.CommandText = "select * from tblfamilymember where id ='" & id_family.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtFamilyMember.Text = rst("fullname").ToString
            txtFamilyRelationship.Text = rst("relationship").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdFamilySave_Click(sender As Object, e As EventArgs) Handles cmdFamilySave.Click
        If txtFamilyMember.Text = "" Then
            XtraMessageBox.Show("Please select or enter family member fullname", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFamilyMember.Focus()
            Exit Sub
        ElseIf txtFamilyRelationship.Text = "" Then
            XtraMessageBox.Show("Please select or enter family relationship", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            comelecid.Focus()
            Exit Sub
        ElseIf countqry("tblfamilymember", "fullname='" & rchar(txtFamilyMember.Text) & "' and votersid='" & votersid.text & "'") > 0 And mode_family.Text <> "edit" Then
            XtraMessageBox.Show("Family member is already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFamilyMember.Focus()
            Exit Sub
        End If
        If mode_family.Text = "edit" Then
            com.CommandText = "UPDATE tblfamilymember set votersid='" & votersid.text & "', fullname='" & rchar(txtFamilyMember.Text) & "', relationship='" & rchar(txtFamilyRelationship.Text) & "' where id='" & id_family.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE FAMILY MEMBER")
        Else
            Dim getid As String = createTRNID("F") & "-" & globaluserid
            com.CommandText = "insert into tblfamilymember set id='" & getid & "', votersid='" & votersid.text & "', fullname='" & rchar(txtFamilyMember.Text) & "', relationship='" & rchar(txtFamilyRelationship.Text) & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED FAMILY MEMBER")
        End If
        LoadFamilyMember()
        txtFamilyMember.SelectedIndex = -1
        txtFamilyRelationship.SelectedIndex = -1
        loadFamilyRelationship()
        mode_family.Text = ""
        id_family.Text = ""
        txtFamilyMember.Focus()
        XtraMessageBox.Show("Family member successfuly saved!", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function SuggestVotersName()
        Dim Coll As ComboBoxItemCollection = txtFamilyMember.Properties.Items
        Coll.Clear()
        com.CommandText = "Select fullname from tblvoters where fullname like '%" & rchar(txtFamilyMember.Text) & "%' or votersid like '%" & rchar(txtFamilyMember.Text) & "%' order by fullname asc limit 100"
        rst = com.ExecuteReader
        Coll.BeginUpdate()
        Try
            While rst.Read
                Coll.Add(rst("fullname"))
            End While
            rst.Close()
        Finally
            Coll.EndUpdate()
        End Try
        Return Coll
    End Function

    Private Sub txtFamilyMember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFamilyMember.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtFamilyMember.Text = "" Or txtFamilyMember.Text = "%" Then Exit Sub
            If countqry("tblvoters", "fullname= '" & txtFamilyMember.Text & "' or votersid = '" & rchar(txtFamilyMember.Text) & "'") = 0 Then
                SuggestVotersName()
                txtFamilyMember.ShowPopup()
                Exit Sub
            End If
        End If
    End Sub

#End Region

#Region "EDUCATION"
    Public Sub LoadEducation()
        LoadXgrid("select id, schoolname as 'School Name',schooladdress as 'School Address',  date_format(dateattended,'%Y-%m-%d') as 'Date Attended', iscurrent as 'Current School' from tbleducation where votersid='" & votersid.text & "'", "tbleducation", gridEducation, g_education, Me)
        g_education.Columns("id").Visible = False
        XgridColAlign("Date Attended", g_education, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Public Sub loadSchoolName()
        LoadToComboBox("schoolname", "tbleducation", txtEducSchoolName, True)
    End Sub
    Public Sub loadSchoolAddress()
        LoadToComboBox("schooladdress", "tbleducation", txtEducSchoolAddress, True)
    End Sub
    Public Sub ShowEducationInfo()
        com.CommandText = "select * from tbleducation where id ='" & id_education.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtEducSchoolName.Text = rst("schoolname").ToString
            txtEducSchoolAddress.Text = rst("schooladdress").ToString
            txtEducSchoolPeriod.Text = rst("dateattended").ToString
            ckCurrentEducation.Checked = rst("iscurrent")
        End While
        rst.Close()
    End Sub
    Private Sub cmdEducation_Click(sender As Object, e As EventArgs) Handles cmdEducation.Click
        If txtEducSchoolName.Text = "" Then
            XtraMessageBox.Show("Please select or enter school name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEducSchoolName.Focus()
            Exit Sub
        ElseIf txtEducSchoolAddress.Text = "" Then
            XtraMessageBox.Show("Please select or enter school address", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEducSchoolAddress.Focus()
            Exit Sub
        End If
        If mode_education.Text = "edit" Then
            com.CommandText = "UPDATE tbleducation set votersid='" & votersid.text & "', schoolname='" & rchar(txtEducSchoolName.Text) & "', schooladdress='" & rchar(txtEducSchoolAddress.Text) & "' " & If(txtEducSchoolPeriod.Text <> "", ",dateattended='" & ConvertDate(txtEducSchoolPeriod.Text) & "'", "") & ",iscurrent=" & ckCurrentEducation.CheckState & " where id='" & id_education.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE EDUCATION")
        Else
            Dim getid As String = createTRNID("E") & "-" & globaluserid
            com.CommandText = "INSERT into tbleducation set id='" & getid & "', votersid='" & votersid.text & "', schoolname='" & rchar(txtEducSchoolName.Text) & "', schooladdress='" & rchar(txtEducSchoolAddress.Text) & "' " & If(txtEducSchoolPeriod.Text <> "", ",dateattended='" & ConvertDate(txtEducSchoolPeriod.Text) & "'", "") & ",iscurrent=" & ckCurrentEducation.CheckState & "" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED EDUCATION")
        End If
        loadSchoolName()
        loadSchoolAddress()
        txtEducSchoolName.SelectedIndex = -1
        txtEducSchoolAddress.SelectedIndex = -1
        ckCurrentEducation.Checked = False
        LoadEducation()
        mode_education.Text = ""
        id_education.Text = ""
        txtEducSchoolName.Focus()
        XtraMessageBox.Show("Education successfuly saved!", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "WORK"
    Public Sub LoadWork()
        LoadXgrid("select id, companyname as 'Company Name',companyaddress as 'Company Address',Position, date_format(datefrom,'%Y-%m-%d') as 'Date From',if(iscurrent=1,'-', date_format(dateto,'%Y-%m-%d')) as 'Date To', iscurrent as 'Current Company',workstatus as 'Status' from tblwork where votersid='" & votersid.text & "'", "tblwork", gridWork, g_work, Me)
        g_work.Columns("id").Visible = False
        XgridColAlign("Date From", g_work, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Date To", g_work, DevExpress.Utils.HorzAlignment.Center)
        XgridColAlign("Status", g_work, DevExpress.Utils.HorzAlignment.Center)
    End Sub
    Public Sub loadWorkCompany()
        LoadToComboBox("companyname", "tblwork", txtWorkCompanyName, True)
    End Sub
    Public Sub loadWorkAddress()
        LoadToComboBox("companyaddress", "tblwork", txtWorkCompanyAddress, True)
    End Sub
    Public Sub loadWorkPosition()
        LoadToComboBox("position", "tblwork", txtWorkPosition, True)
    End Sub
    Public Sub LoadWorkStatus()
        LoadToComboBox("workstatus", "tblwork", txtWorkStatus, True)
    End Sub
    Public Sub ShowWorkInfo()
        com.CommandText = "select * from tblwork where id ='" & id_work.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtWorkCompanyName.Text = rst("companyname").ToString
            txtWorkCompanyAddress.Text = rst("companyaddress").ToString
            txtWorkPosition.Text = rst("position").ToString
            txtDateWorkFrom.Text = rst("datefrom").ToString
            txtDateWorkTo.Text = rst("dateto").ToString
            ckCurrentWork.Checked = rst("iscurrent")
        End While
        rst.Close()
    End Sub
    Private Sub cmdWord_Click(sender As Object, e As EventArgs) Handles cmdWord.Click
        If txtWorkCompanyName.Text = "" Then
            XtraMessageBox.Show("Please select or enter company name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtWorkCompanyName.Focus()
            Exit Sub
        ElseIf txtWorkCompanyAddress.Text = "" Then
            XtraMessageBox.Show("Please select or enter company address", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtWorkCompanyAddress.Focus()
            Exit Sub
        ElseIf txtWorkPosition.Text = "" Then
            XtraMessageBox.Show("Please select or enter Position", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtWorkPosition.Focus()
            Exit Sub
        ElseIf txtWorkStatus.Text = "" Then
            XtraMessageBox.Show("Please select or enter work status", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtWorkStatus.Focus()
            Exit Sub
        End If
        If mode_work.Text = "edit" Then
            com.CommandText = "UPDATE tblwork set votersid='" & votersid.text & "', companyname='" & rchar(txtWorkCompanyName.Text) & "', companyaddress='" & rchar(txtWorkCompanyAddress.Text) & "', position='" & rchar(txtWorkPosition.Text) & "' " & If(txtDateWorkFrom.Text <> "", ",datefrom='" & ConvertDate(txtDateWorkFrom.Text) & "'", "") & "" & If(txtDateWorkTo.Text <> "", ",dateto='" & ConvertDate(txtDateWorkTo.Text) & "'", "") & ",iscurrent=" & ckCurrentWork.CheckState & ",workstatus='" & rchar(txtWorkStatus.Text) & "' where id='" & id_work.Text & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "UPDATE WORK HISTORY")
        Else
            Dim getid As String = createTRNID("W") & "-" & globaluserid
            com.CommandText = "INSERT INTO tblwork set id='" & getid & "',votersid='" & votersid.text & "', companyname='" & rchar(txtWorkCompanyName.Text) & "', companyaddress='" & rchar(txtWorkCompanyAddress.Text) & "', position='" & rchar(txtWorkPosition.Text) & "' " & If(txtDateWorkFrom.Text <> "", ",datefrom='" & ConvertDate(txtDateWorkFrom.Text) & "'", "") & "" & If(txtDateWorkTo.Text <> "", ",dateto='" & ConvertDate(txtDateWorkTo.Text) & "'", "") & ",iscurrent=" & ckCurrentWork.CheckState & ",workstatus='" & rchar(txtWorkStatus.Text) & "'" : com.ExecuteNonQuery()
            LogQuery(Me.Text, com.CommandText.ToString, "ADDED WORK HISTORY")
        End If
        loadWorkCompany()
        loadWorkAddress()
        loadWorkPosition()
        LoadWorkStatus()
        'txtWorkCompanyName.SelectedIndex = -1
        'txtWorkCompanyAddress.SelectedIndex = -1
        'txtWorkPosition.SelectedIndex = -1
        'ckCurrentWork.Checked = False
        LoadWork()
        mode_work.Text = ""
        id_work.Text = ""
        txtWorkCompanyName.Focus()
        XtraMessageBox.Show("Work History successfuly saved!", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ckCurrentWork_CheckedChanged(sender As Object, e As EventArgs) Handles ckCurrentWork.CheckedChanged
        If ckCurrentWork.Checked = True Then
            txtDateWorkTo.Enabled = False
        Else
            txtDateWorkTo.Enabled = True
        End If
    End Sub
#End Region

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If XtraTabControl1.SelectedTabPage Is tabFamily Then
            mode_family.Text = "edit"
            id_family.Text = g_Family.GetFocusedRowCellValue("id").ToString
            ShowFamilyInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
            mode_education.Text = "edit"
            id_education.Text = g_education.GetFocusedRowCellValue("id").ToString
            ShowEducationInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabWork Then
            mode_work.Text = "edit"
            id_work.Text = g_work.GetFocusedRowCellValue("id").ToString
            ShowWorkInfo()

        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If XtraTabControl1.SelectedTabPage Is tabFamily Then
                com.CommandText = "delete from tblfamilymember where id='" & g_Family.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVE FAMILY MEMBER")
                LoadFamilyMember()

            ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
                com.CommandText = "delete from tbleducation where id='" & g_education.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVE EDUCATION")
                LoadEducation()

            ElseIf XtraTabControl1.SelectedTabPage Is tabWork Then
                com.CommandText = "delete from tblwork where id='" & g_work.GetFocusedRowCellValue("id") & "'" : com.ExecuteNonQuery()
                LogQuery(Me.Text, com.CommandText.ToString, "REMOVE WORK HISTORY")
                LoadWork()

            End If

         
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        If XtraTabControl1.SelectedTabPage Is tabFamily Then
            ShowFamilyInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabEducation Then
            ShowEducationInfo()

        ElseIf XtraTabControl1.SelectedTabPage Is tabWork Then
            LoadWork()
        End If
    End Sub

    Private Sub imgProfilePic_Properties_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles imgProfilePic.Properties.Validating
        ckImageUpdate.Checked = True
    End Sub
End Class