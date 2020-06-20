Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Module mySettings
    Public initialID As String = ""
    Public myID As String = ""
    Public globaldate As String
    Public rptsettings As String = ""
    Public dserver As String = ""
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public Spinedit As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Public colImageEdit As New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Public SelApprover As Boolean
    Public globaltheme As String = "DevExpress"
    Public rptOK As Boolean
    Public TargetFile As String
    Public ico As Icon
    Public globaldefcolor As String = ""
    Public globaldefcolordesc As String = ""
    Public capturecontinue As Boolean = False
    Public selectedColorname As String = ""
    Public selectedColorCode As String = ""
    Public selectedSectorCode As String = ""
    Public selectedSectorName As String = ""

    Public globaldefcolorleader As String = ""
    Public globaldefcolorMember As String = ""
    Public globalautocolorleadersmember As Boolean
    Public globalmultipleidprint As Boolean
    Public globalshowidprintpreview As Boolean
    Public globalSystemVersion As String = ""
    Public globalServerType As Integer
    Public Globalshowclientstatusresult As Boolean



#Region "USER ACCOUNT VARIABLES"
    Public globalfullname As String
    Public globaldesignation As String
    Public globalpermission As Integer
    Public globalofficeid As String
    Public globaloffice As String
    Public globaluserid As String
    Public globalpass As String
    Public globaluser As String
    Public globalsync As Boolean
    Public globalconnsync As Boolean
    Public globaldefaultleaderbackcolor As String
    Public globaldefaultforecolormember As String

    Public logtry As String
    Public globallogin As Boolean
    Public globalusersign As Image = Nothing

    Public globallevel As String
    Public globalfinalapp As String

    Public globalFullAccess As Boolean
    Public globalAccessAreacode As String
    Public globalAccessMuncode As String

    Public Sub loadglobaluser()
        globalusersign = Nothing
        Try
            com.CommandText = "SELECT * from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader()
            While rst.Read()
                globaluser = rst("username").ToString
                globalfullname = rst("fullname").ToString
                globaldesignation = rst("designation").ToString
                globalpermission = rst("permission").ToString
                globaltheme = rst("theme").ToString
                globalpass = rst("password").ToString
                globaldefaultleaderbackcolor = rst("defaultleaderbackcolor").ToString
                globaldefaultforecolormember = rst("defaultforecolormember").ToString
                globalFullAccess = CBool(rst("fullaccess"))
                globalAccessAreacode = rst("accessareacode").ToString
                globalAccessMuncode = rst("accessmuncode").ToString

                If rst("digitalsign").ToString <> "" Then
                    imgBytes = CType(rst("digitalsign"), Byte())
                    stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                    globalusersign = Image.FromStream(stream)
                End If
            End While
            rst.Close()
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
#End Region

#Region "COMPANY VARIABLES"
    Public compcode As String
    Public compname As String
    Public compadd As String
    Public compnumber As String
    Public compemail As String
    Public compwebsite As String
    Public complogo As Image = Nothing
    Public CompAproveName As String
    Public compApproveDesig As String
    Public compkb As String
    Public comInventoryName As String
    Public compofficeid As String
    Public compoffice As String
    Public compinitialcode As String
    Public compsyscode As String
    Public complogimg As Image = Nothing
    Public compapproversign As Image = Nothing
    Public complogwidth
    Public complogheight

#End Region

    Public GlobalDownloadDefaultLocation As String
    Public GLobalWebtypePrinter As Boolean
    Public Sub loadSettings()
        com.CommandText = "select * from settings.tblsettings"
        rst = com.ExecuteReader
        While rst.Read
            GLobalWebtypePrinter = rst("webtypeprinter")
            SystemServer = rst("isserver")
            clientserver = rst("clientserver").ToString
            singleuse = rst("singleuse").ToString
            GlobalDownloadDefaultLocation = rst("downloadurl").ToString
            Globalshowclientstatusresult = rst("showclientstatusresult")
        End While
        rst.Close()

        com.CommandText = "select * from tblcolor where defaults=1"
        rst = com.ExecuteReader
        While rst.Read
            globaldefcolor = rst("colorcode").ToString
            globaldefcolordesc = rst("description").ToString
        End While
        rst.Close()

        com.CommandText = "select * from tblconfiguration "
        rst = com.ExecuteReader
        While rst.Read
            globaldefcolorleader = rst("defleadercolor").ToString
            globaldefcolorMember = rst("defmembercolor").ToString
            globalautocolorleadersmember = rst("autocolorleadersmember")
            globalmultipleidprint = rst("multipleidprint")
            globalshowidprintpreview = rst("showidprintpreview")
        End While
        rst.Close()
       
    End Sub
    Public Function rschar(ByVal txt As String)
        Dim fint As Integer = 0
        Try
            Dim removechar As Char() = ". ".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            Dim str As String = txt
            For Each ch As Char In str
                If Array.IndexOf(removechar, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
            fint = Val(sb.ToString)
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
        Return fint
    End Function
    Public Function remallchar(ByVal txt As String)
        Dim fint As Double = 0
        Try
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ/-. ".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            Dim str As String = txt
            For Each ch As Char In str
                If Array.IndexOf(removechar, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
            fint = Val(sb.ToString)
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
        Return fint
    End Function
    Public Function remallnumbers(ByVal txt As String)
        Dim removechar As Char() = "0123456789".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim str As String = txt
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString()
    End Function
    Public Function getColorid()
        Dim strng = ""
        Try
            If CInt(countrecord("tblcolor")) = 0 Then
                strng = "C10001"
            Else
                com.CommandText = "select colorcode from tblcolor order by right(colorcode,5) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("colorcode").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "C" & Val(sb.ToString) + 1
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
        Return strng.ToString
    End Function
    Public Function getSectorid()
        Dim strng = ""
        Try
            If CInt(countrecord("tblsector")) = 0 Then
                strng = "SEC100001"
            Else
                com.CommandText = "select sectorcode from tblsector order by right(sectorcode,6) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("sectorcode").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "SEC" & Val(sb.ToString) + 1
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
        Return strng.ToString
    End Function

    Public Function getareaid()
        Dim strng = ""
        Try
            If CInt(countrecord("tblarea")) = 0 Then
                strng = "AR1001"
            Else
                com.CommandText = "select areacode from tblarea order by right(areacode,4) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("areacode").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "AR" & Val(sb.ToString) + 1
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
        Return strng.ToString
    End Function

    Public Function getMunicipality(ByVal areacode As String)
        Dim strng = ""
        Try
            If CInt(countqry("tblmunicipality", "areacode='" & areacode & "'")) = 0 Then
                strng = "MUN100001"
            Else
                com.CommandText = "select right(muncode,6) as muncode from tblmunicipality where areacode='" & areacode & "' order by right(muncode,6) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("muncode").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "MUN" & Val(sb.ToString) + 1
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
        Return strng.ToString
    End Function

    Public Function getVillageID(ByVal areacode As String, ByVal muncode As String)
        Dim strng = ""
        Try
            If CInt(countqry("tblvillage", "areacode='" & areacode & "' and muncode='" & muncode & "'")) = 0 Then
                strng = "BRGY10000001"
            Else
                com.CommandText = "select right(villcode,8) as  villcode from tblvillage where areacode='" & areacode & "' and muncode='" & muncode & "' order by right(villcode,8) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("villcode").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "BRGY" & Val(sb.ToString) + 1
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
        Return strng.ToString
    End Function

    Public Sub loadcompsettings()
        compapproversign = Nothing
        compapproversign = Nothing

        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing

        Dim imgBytes2 As Byte() = Nothing
        Dim stream2 As MemoryStream = Nothing
        Dim img2 As Image = Nothing
        Try
            com.CommandText = "select * from tblcompanysettings"
            rst = com.ExecuteReader
            While rst.Read
                compcode = rst("unitcode").ToString
                compname = rst("companyname").ToString
                compadd = rst("compadd").ToString
                compnumber = rst("telephone").ToString
                compemail = rst("email").ToString
                compwebsite = rst("website").ToString
                CompAproveName = rst("chiefoff").ToString
                compApproveDesig = rst("designation").ToString
                compkb = rst("kb").ToString
                compinitialcode = rst("initialcode").ToString

                If rst("logo").ToString <> "" Then
                    imgBytes = CType(rst("logo"), Byte())
                    stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                    img = Image.FromStream(stream)
                    complogo = img
                End If
                If rst("digitalsign").ToString <> "" Then
                    imgBytes2 = CType(rst("digitalsign"), Byte())
                    stream2 = New MemoryStream(imgBytes2, 0, imgBytes2.Length)
                    compapproversign = Image.FromStream(stream2)
                End If
            End While
            rst.Close()

            com.CommandText = "select * from settings.tblsettings"
            rst = com.ExecuteReader
            While rst.Read
                SystemServer = rst("isserver")
            End While
            rst.Close()

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

    Public Function getinitialID(ByVal s)
        Dim words As String() = s.Split(New Char() {" "c})

        ' Use For Each loop over words and display them
        Dim word As String
        initialID = ""
        For Each word In words
            If initialID.Length <= 2 Then
                initialID = initialID + word.Remove(1, word.Count - 1)
            End If
        Next
        initialID = StrConv(initialID, vbUpperCase)
        myID = StrConv(initialID, vbUpperCase)
        Return myID
    End Function

    Public Sub loadIcons()
        TargetFile = Application.StartupPath + "\ico.ico"
        ico = New Icon(TargetFile)
    End Sub
   Public Sub SetIcon(ByVal form As DevExpress.XtraEditors.XtraForm)
        Form.Icon = ico
    End Sub

#Region "IMAGE VARIABLES"
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
#End Region

#Region "COMPONENT TOOL VARIABLES"
    Public Row As DataRow : Public Rows() As DataRow : Public I As Integer : Public todelete As String
    Public combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public combogrid2 As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public PicEdit As New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
#End Region

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function

    Public Function createTRNID(ByVal init As String)
        Dim strs As Date
        Dim finalstr As String = ""

        com.CommandText = "select current_timestamp as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
            finalstr = strs.ToString("yyyy-MM-dd hh:mm:ss")
        End While
        rst.Close()

        Dim removechar As Char() = "/-:AMP ".ToCharArray()
        Dim sb As New System.Text.StringBuilder

        Dim str As String = finalstr
        Dim ch As Char
        For Each ch In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        finalstr = init + sb.Append(ch).ToString
        Return finalstr
    End Function

    Public Sub loadLoginAppearance()
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing
        Try
            If countrecord("tblappearance") = 0 Then
                complogwidth = "267"
                complogheight = "312"
            Else
                com.CommandText = "select * from tblappearance where form='frmLogin'"
                rst = com.ExecuteReader
                While rst.Read
                    complogwidth = rst("width").ToString
                    complogheight = rst("height").ToString

                    If complogwidth = "" Then
                        complogwidth = "267"
                        complogheight = "312"
                    End If

                    If rst("img").ToString <> "" Then
                        imgBytes = CType(rst("img"), Byte())
                        stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                        img = Image.FromStream(stream)
                        complogimg = img
                    End If
                End While
            End If
            rst.Close()
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


    Public Function GlobalTime()
        Dim a As String = ""
        Try
            com.CommandText = "SELECT current_time as currtime" : rst = com.ExecuteReader()
            While rst.Read
                a = rst("currtime").ToString
            End While
            rst.Close()
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
        Return a
    End Function

    Public Sub LoadGlobalDate()
        Dim dg As String = ""
        Try
            com.CommandText = "select current_date as trackdate"
            rst = com.ExecuteReader
            While rst.Read
                globaldate = ConvertDate(rst("trackdate").ToString)
            End While
            rst.Close()
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

    Public Function GlobalDateTime()
        Dim gdatetime As String = ""
        Try
            gdatetime = globaldate + " " + GlobalTime()
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
        Return gdatetime
    End Function

    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function

    Public Function ConvertDateTime(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd hh:mm:ss")
    End Function

    Public Function CC(ByVal m As String)
        Return m.Replace(",", "")
    End Function

    Public Function ProperDate(ByVal d As Date)
        Return d.ToString("MM/dd/yyyy")
    End Function

    Public Function strConvert(ByVal txt As String) As String
        Dim str As String
        str = StrConv(txt, vbProperCase)
        Return str
    End Function

    Public Function getdateid()
        Dim removechar As Char() = ":/AMPM- ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim str As String = GlobalDateTime()
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function

    Public Function getuserid()
        Dim userid = 0
        If CInt(countrecord("tblaccounts")) = 0 Then
            userid = 101
        Else
            com.CommandText = "select accountid from tblaccounts order by accountid desc limit 1" : rst = com.ExecuteReader()
            While rst.Read
                userid = Val(rst("accountid")) + 1
            End While
            rst.Close()
        End If
        Return userid.ToString
    End Function

    Public Function getuseridserver()
        Dim userid = 0
        If CInt(countrecordserver("general.tblaccounts")) = 0 Then
            userid = 101
        Else
            comclient.CommandText = "select accountid from general.tblaccounts order by accountid desc limit 1" : rstclient = comclient.ExecuteReader()
            While rstclient.Read
                userid = Val(rstclient("accountid")) + 1
            End While
            rstclient.Close()
        End If
        Return userid.ToString
    End Function

    Public Function getServerid()
        Dim strng = ""

        If CInt(countrecord("tblclientserver")) = 0 Then
            strng = "SR100001"
        Else
            com.CommandText = "select serverid from tblclientserver order by right(serverid,6) desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst("serverid").ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = "SR" & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function

    Public Function convertid(ByVal a As String)
        Dim removechar As Char() = ":/AMPM- ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim dt As DateTime
        dt = a.ToString

        Dim str As String = dt.ToString("yyyy-MM-dd")
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function getBatchCode()
        Dim batchcode As String = ""
        batchcode = compcode & getdateid().ToString & "-" & globaluserid
        Return batchcode.ToString
    End Function
    Public Function countrecordstat(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where status=1"
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function qrysingledata1(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function
    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond.Replace("where", "")
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function countrecordserver(ByVal tbl As String)
        Dim cnt As Integer = 0
        comclient.CommandText = "select count(*) as cnt from " & tbl & " "
        rstclient = comclient.ExecuteReader
        While rstclient.Read
            cnt = rstclient("cnt")
        End While
        rstclient.Close()
        Return cnt
    End Function
    Public Function countqryserver(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        comclient.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
        rstclient = comclient.ExecuteReader
        While rstclient.Read
            cnt = rstclient("cnt")
        End While
        rstclient.Close()
        Return cnt
    End Function

    Public Function LogQuery(ByVal editedtype As String, ByVal querytask As String, ByVal remarks As String)
        com.CommandText = "insert into settings.tblactionquerylogs set dateperformed=current_timestamp,  editedtype='" & rchar(editedtype) & "', querytask='" & rchar(querytask) & "', remarks='" & rchar(remarks) & "', performedby='" & globaluserid & "'" : com.ExecuteNonQuery()
        Return 0
    End Function


    Public Sub SaveDefaultOption(ByVal filteroption As Integer, ByVal areacode As String, ByVal muncode As String, ByVal vilcode As String)
        If filteroption = -1 Then
            com.CommandText = "update tblaccounts set areacode='" & areacode & "', muncode='" & muncode & "', brgycode='" & vilcode & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblaccounts set filteroption='" & filteroption & "', areacode='" & areacode & "', muncode='" & muncode & "', brgycode='" & vilcode & "' where accountid='" & globaluserid & "'" : com.ExecuteNonQuery()
        End If

    End Sub
End Module
