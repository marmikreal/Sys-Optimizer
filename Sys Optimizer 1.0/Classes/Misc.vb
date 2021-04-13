Imports System.Management
Imports System.IO
Imports System.Xml
Imports Functiod
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class Misc
    Public Class plsWMI
        Private objPro As ManagementObjectSearcher
        Private objMgmt As ManagementObject

        Private m_ProNm As String
        Public Sub New()
            objPro = New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
            For Each Me.objMgmt In objPro.Get
                m_ProNm = objMgmt("name")
            Next
        End Sub
        Public ReadOnly Property ProName
            Get
                ProName = m_ProNm
            End Get
        End Property
    End Class
    Public Shared Function CheckUsingVersionNumber()
        Dim osver = System.Environment.OSVersion.Version.ToString
        Dim osname As String
        If osver >= "6.2.9200" Then
            osname = "8"
        ElseIf osver >= "6.1.7600" Then
            osname = "7"
        ElseIf osver >= "6.0" Then
            osname = "vista"
        ElseIf osver >= "5.1" Then
            osname = "xp"
        Else
            osname = Nothing
        End If
        'MsgBox(osname)
        Return osname
    End Function
    Public Shared Function GraphicCardd(ByVal lblGraphicCrd As Label)
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Availability") = 3 Then
                    '    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    '    CmboGraphicCrd.Text = queryObj("Caption")
                    'Else
                    '    CmboGraphicCrd.Items.Add(queryObj("Caption"))
                    lblGraphicCrd.Text = queryObj("Caption")
                    'CmboGraphicCrd.Text = queryObj("Caption")
                    'Else
                    '    lblGraphicCrd.Text = "Graphics : " & queryObj("Caption")
                End If
            Next
        Catch ex As Exception
            Analyse.errormessage = "This is not meant to be a software crash" & vbNewLine & "Error Occurred at RetrOGrpCrdNm ( 898 or 009 )" & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Return Nothing
    End Function
    Public Shared Function GetProcessorInformation()
        Try
            Dim dlsWMI As New plsWMI

            With dlsWMI

                Dim named As String
                named = .ProName
                named = named.Replace("(", "")
                named = named.Replace(")", "")
                named = named.Replace("R", "")
                named = named.Replace("TM", "")
                named = named.Replace("CPU", "")
                named = named.Replace("  ", "")
                'named = named.Replace("@", "-")
                Return named
            End With
        Catch ex As Exception
            Return "Error  Occurred"
        End Try
    End Function
    Public Class glsWMI
        Private objBat As ManagementObjectSearcher
        Private objMgmt As ManagementObject
        Private m_BatManu As String
        Private m_BatCap As String
        Private m_BatStatus As String
        Private m_BatTyp As String
        Private m_BatLvl As String
        Private m_EstiRnTm As String
        Private m_BatAvl As String
        Public Sub New()
            objBat = New ManagementObjectSearcher("SELECT * FROM Win32_Battery")
            For Each Me.objMgmt In objBat.Get
                m_BatAvl = objMgmt("Availability")
                m_BatManu = objMgmt("DeviceID")
                m_BatCap = objMgmt("caption")
                m_BatStatus = objMgmt("batterystatus")
                m_BatTyp = objMgmt("chemistry")
                m_BatLvl = objMgmt("estimatedchargeremaining")
                m_EstiRnTm = objMgmt("estimatedruntime")
            Next
        End Sub
        Public ReadOnly Property GetBatAvl()
            Get
                GetBatAvl = m_BatAvl
            End Get
        End Property
        Public ReadOnly Property EstimatedRunTime()
            Get
                EstimatedRunTime = m_EstiRnTm
            End Get
        End Property
        Public ReadOnly Property GetBatLvl()
            Get
                GetBatLvl = m_BatLvl
            End Get
        End Property
        Public ReadOnly Property GetBatType()
            Get
                GetBatType = m_BatTyp
            End Get
        End Property
        Public ReadOnly Property GetBatStatus()
            Get
                GetBatStatus = m_BatStatus
            End Get
        End Property
        Public ReadOnly Property GetBatCapt()
            Get
                GetBatCapt = m_BatCap
            End Get
        End Property
        Public ReadOnly Property GetBatManu()
            Get
                GetBatManu = m_BatManu
            End Get
        End Property
    End Class
    
    Public Shared Function LoadPlugins(ByVal lstPlugins As ListView, ByVal imgPlugins As ImageList)
        Try
            For Each filinfold In Directory.GetFiles(Application.StartupPath & "\Plugins")
                If IO.Path.GetExtension(filinfold) = ".xml" Then
                    Dim dls As XmlReader = New XmlTextReader(filinfold)
                    If File.Exists(filinfold) = True Then
                        While (dls.Read())
                            Dim typ = dls.NodeType
                            If typ = XmlNodeType.Element Then
                                If dls.Name = "pluginnameexe" Then
                                    If Directory.Exists(Application.StartupPath & "\Plugins\PluginWorkParam") = False Then
                                        Directory.CreateDirectory(Application.StartupPath & "\Plugins\PluginWorkParam")
                                        If File.Exists(Application.StartupPath & "\Plugins\PluginWorkParam\" & IO.Path.GetFileName(filinfold)) = False Then
                                            File.Copy(filinfold, Application.StartupPath & "\Plugins\PluginWorkParam\" & IO.Path.GetFileName(filinfold))
                                        End If
                                    Else
                                        If File.Exists(Application.StartupPath & "\Plugins\PluginWorkParam\" & IO.Path.GetFileName(filinfold)) = False Then
                                            File.Copy(filinfold, Application.StartupPath & "\Plugins\PluginWorkParam\" & IO.Path.GetFileName(filinfold))
                                        End If
                                    End If

                                End If
                            End If
                        End While
                        dls.Close()
                    End If
                End If
            Next
            Dim ic As String = ""
            Dim count As Integer = 0
            Dim ount As Integer = 0
            Dim unt As Integer = 0
            Dim filpt
            Dim stat As String = ""
            Dim xlswmi As New glsWMI
            With xlswmi
                If Directory.Exists(Application.StartupPath & "\Plugins") = True Then
                    For Each filinfold In Directory.GetFiles(Application.StartupPath & "\Plugins")
                        filpt = filinfold
                        If IO.Path.GetExtension(filinfold) = ".xml" Then
                            Dim nme = IO.Path.GetFileName(filinfold)
                            If nme.StartsWith("Battery") = False Then
                                'MsgBox(filinfold)
                                Dim dls As XmlReader = New XmlTextReader(filinfold)
                                If File.Exists(filinfold) = True Then
                                    While (dls.Read())
                                        Dim typ = dls.NodeType
                                        If typ = XmlNodeType.Element Then
                                            If dls.Name = "pluginnameexe" Then
                                                'Dim filpath = dls.ReadInnerXml.ToString
                                                'MsgBox("exe " & Application.StartupPath & "\Plugins\" & filpath)
                                                'MsgBox(Icon.ExtractAssociatedIcon())
                                                'MsgBox("filinfold " & filpt)
                                                'MsgBox("filpath " & filpath)

                                                'MsgBox(ImageList1.Images.Count)
                                                'ic = (Application.StartupPath & "\Plugins\" & filpath)
                                                Dim nm = IO.Path.GetFileNameWithoutExtension(filinfold) & ".png"
                                                'MsgBox(filinfold.Remove(filinfold.Length - IO.Path.GetFileName(filinfold).Length, IO.Path.GetFileName(filinfold).Length) & nm)
                                                Dim nams = filinfold.Remove(filinfold.Length - IO.Path.GetFileName(filinfold).Length, IO.Path.GetFileName(filinfold).Length) & nm
                                                If File.Exists(nams) = True Then
                                                    'Dim img As System.Drawing.Image.FromFile(nams)
                                                    imgPlugins.Images.Add(Image.FromFile(nams))
                                                Else
                                                    imgPlugins.Images.Add(My.Resources._1371432167_window_list)
                                                    MsgBox(IO.Path.GetFileNameWithoutExtension(nams) & " has no valid icon to load")
                                                End If
                                                Dim proc = dls.ReadInnerXml.ToString
                                                'MsgBox(Application.StartupPath & "\Plugins\core" & proc)
                                                If File.Exists(Application.StartupPath & "\Plugins\core" & proc) = True Then
                                                    Process.Start(Application.StartupPath & "\Plugins\core" & proc)
                                                    'MsgBox(proc & " Plugin Installed Properly")
                                                    stat = "0"
                                                Else
                                                    ' MsgBox(proc & " Sorry Plugin error please reinstall the plugin")
                                                    stat = "1"
                                                End If
                                                lstPlugins.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold), count)
                                                'lstPlugins.Items(count).SubItems.Add(proc)


                                                'MsgBox(filinfold)
                                                'MsgBox(count)
                                                'ListView1.Items(count).SubItems.Add(stat)
                                                count += 1
                                            End If
                                            'If dls.Name = "desc" Then
                                            '    ListView1.Items(unt).SubItems.Add(dls.ReadInnerXml.ToString)
                                            '    unt += 1
                                            'End If
                                            If dls.Name = "ver" Then
                                                lstPlugins.Items(ount).SubItems.Add("Version : " & dls.ReadInnerXml.ToString)

                                                'If stat = "0" Then
                                                '    lstPlugins.Items(ount).SubItems.Add("Plugin Installed Correctly")
                                                'Else
                                                '    lstPlugins.Items(ount).SubItems.Add("Plugin Not installed correctly")
                                                '    'MsgBox("In " & filinfold)
                                                'End If
                                                ount += 1
                                            End If

                                        End If
                                    End While
                                    dls.Close()
                                    ' MsgBox(filinfold)

                                End If
                                'ImageList1.Images.Add(Icon.ExtractAssociatedIcon(ic))
                            ElseIf .GetBatAvl <> "" Then
                                ' ListView1.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold))
                                Dim dlx As XmlReader = New XmlTextReader(filinfold)
                                If File.Exists(filinfold) = True Then
                                    While (dlx.Read())
                                        Dim typ = dlx.NodeType
                                        If typ = XmlNodeType.Element Then
                                            If dlx.Name = "pluginnameexe" Then
                                                'Dim filpath = dls.ReadInnerXml.ToString
                                                'MsgBox("exe " & Application.StartupPath & "\Plugins\" & filpath)
                                                'MsgBox(Icon.ExtractAssociatedIcon())
                                                'MsgBox("filinfold " & filpt)
                                                'MsgBox("filpath " & filpath)

                                                'MsgBox(ImageList1.Images.Count)
                                                'ic = (Application.StartupPath & "\Plugins\" & filpath)
                                                Dim nm = IO.Path.GetFileNameWithoutExtension(filinfold) & ".png"
                                                'MsgBox(filinfold.Remove(filinfold.Length - IO.Path.GetFileName(filinfold).Length, IO.Path.GetFileName(filinfold).Length) & nm)
                                                Dim nams = filinfold.Remove(filinfold.Length - IO.Path.GetFileName(filinfold).Length, IO.Path.GetFileName(filinfold).Length) & nm
                                                If File.Exists(nams) = True Then
                                                    'Dim img As System.Drawing.Image.FromFile(nams)
                                                    imgPlugins.Images.Add(Image.FromFile(nams))
                                                Else
                                                    imgPlugins.Images.Add(My.Resources._1371432167_window_list)
                                                    MsgBox(nams & " has no valid icon to load")
                                                End If
                                                Dim proc = dlx.ReadInnerXml.ToString
                                                'MsgBox(Application.StartupPath & "\Plugins\core" & proc)
                                                If File.Exists(Application.StartupPath & "\Plugins\core" & proc) = True Then
                                                    Process.Start(Application.StartupPath & "\Plugins\core" & proc)
                                                    'MsgBox(proc & " Plugin Installed Properly")
                                                    stat = "0"
                                                Else
                                                    ' MsgBox(proc & " Sorry5 Plugin error please reinstall the plugin")
                                                    stat = "1"
                                                End If
                                                lstPlugins.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold), count)
                                                'lstPlugins.Items(count).SubItems.Add(proc)


                                                'MsgBox(filinfold)
                                                'MsgBox(count)
                                                'ListView1.Items(count).SubItems.Add(stat)
                                                count += 1
                                            End If
                                            'If dls.Name = "desc" Then
                                            '    ListView1.Items(unt).SubItems.Add(dls.ReadInnerXml.ToString)
                                            '    unt += 1
                                            'End If
                                            If dlx.Name = "ver" Then
                                                lstPlugins.Items(ount).SubItems.Add("Version : " & dlx.ReadInnerXml.ToString)

                                                'If stat = "0" Then
                                                '    lstPlugins.Items(ount).SubItems.Add("Plugin Installed Correctly")
                                                'Else
                                                '    lstPlugins.Items(ount).SubItems.Add("Plugin Not installed correctly")
                                                '    'MsgBox("In " & filinfold)
                                                'End If
                                                ount += 1
                                            End If

                                        End If
                                    End While
                                    dlx.Close()
                                End If

                                'MsgBox(filinfold)
                            End If
                        End If '
                    Next
                Else
                    Directory.CreateDirectory(Application.StartupPath & "\Plugins")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    Public Shared Function UnZip(ByVal path As String)
        Dim sc As New Shell32.Shell()
        ''UPDATE !!
        'Create directory in which you will unzip your files .
        'IO.Directory.CreateDirectory(Application.StartupPath & "\Plugins")
        'Declare the folder where the files will be extracted
        Dim output As Shell32.Folder = sc.NameSpace(Application.StartupPath & "\Plugins")
        'Declare your input zip file as folder  .
        Dim input As Shell32.Folder = sc.NameSpace(path)
        'Extract the files from the zip file using the CopyHere command .
        output.CopyHere(input.Items, 4)
        Return Nothing
    End Function
    Delegate Sub AddListItem_Delegate(ByVal [Label] As ListView, ByVal icn As Integer, ByVal [text] As String)
    Public Shared Sub AddListItem(ByVal [ListView] As ListView, ByVal icn As Integer, ByVal [text] As String, Optional ByVal [text2] As String = "")
        If [ListView].InvokeRequired Then
            Dim MyDelegate As New AddListItem_Delegate(AddressOf AddListItem)
            ListView.Invoke(MyDelegate, New Object() {[ListView], [icn], [text]})
        Else
            ListView.Items.Add([text], [icn])
        End If
    End Sub
    Delegate Sub AddListSubItem_Delegate(ByVal [Label] As ListView, ByVal [count] As Integer, ByVal [text] As String)
    Public Shared Sub AddListSubItem(ByVal [ListView] As ListView, ByVal [count] As Integer, ByVal [text] As String, Optional ByVal [text2] As String = "")
        If [ListView].InvokeRequired Then
            Dim MyDelegate As New AddListSubItem_Delegate(AddressOf AddListSubItem)
            ListView.Invoke(MyDelegate, New Object() {[ListView], [count], [text]})
        Else
            ListView.Items(count).SubItems.Add([text])
        End If
    End Sub
    Public Shared Function GetHardInfo(ByVal listview1)
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            'lstHrdDev.Items.Clear()
            'For i = 0 To 0
            Dim hrdsize As String
            Dim usasize As String
            Dim count = 0
            For Each queryObj As ManagementObject In searcher.Get
                ' Dim ids As New ListViewItem
                If queryObj("interfacetype") = "IDE" Then
                    ' ids.Text = queryObj("Caption").ToString
                    Dim gbtb
                    gbtb = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0)
                    If gbtb < 1000 Then
                        hrdsize = gbtb & " GB"
                    ElseIf gbtb >= 1000 Then
                        hrdsize = Math.Round(gbtb / 1000, 2) & " TB"
                    Else
                        hrdsize = gbtb & " GB"
                    End If
                    '  ids.SubItems.Add(actsize & " (" & usasize & ")")
                    'storagenm = queryObj("caption")
                    Dim storagesp = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " Gb"
                    AddListItem(listview1, 0, queryObj("Caption"))
                    AddListSubItem(listview1, count, hrdsize)
                End If
                count += 1
                'count += 1
                Dim fint As Integer = 0
                Const TEMPERATURE_ATTRIBUTE As Byte = 194
                Dim searcherd As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData")
                'loop through all the hard disks
                For Each queryObjd As ManagementObject In searcherd.[Get]()
                    Dim arrVendorSpecific As Byte() = DirectCast(queryObjd.GetPropertyValue("VendorSpecific"), Byte())
                    'Find the temperature attribute
                    Dim tempIndex As Integer = Array.IndexOf(arrVendorSpecific, TEMPERATURE_ATTRIBUTE)
                    ' MsgBox(arrVendorSpecific(tempIndex + 5) & "ºC")
                    If arrVendorSpecific(tempIndex + 5) <> 0 Then
                        'ids.SubItems.Add(arrVendorSpecific(tempIndex + 5) & ".0 º C")
                        ' AddListSubItem(listview1, count, arrVendorSpecific(tempIndex + 5) & ".0 º C")
                    Else
                        ' ids.SubItems.Add("No data")
                        'AddListSubItem(listview1, count, "No Data")
                    End If

                    'ids.SubItems.Add(arrVendorSpecific(tempIndex + 5) & ".0 º C")
                    'storagetemp = arrVendorSpecific(tempIndex + 5) & ".0 º C"

                    'ount += 1
                    'dount += 1
                Next
                'AddListViewItem(ids)
                ' Exit For

            Next
        Catch ex As Exception
            'Motherboard.ereror = ex.ToString
            'CrashBox.ShowDialog()
        End Try
        Return Nothing
    End Function
    Public Shared Function GetHrdInfo(ByVal treevie As TreeView)
        Const TEMPERATURE_ATTRIBUTE As Byte = 194
        Dim hrdsize As String
        Dim usasize As String
        Dim ount As Integer = 0
        Dim dount As Integer = 0
        Dim count As Integer = 0
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")
            'lstHrdDev.Items.Clear()
            For Each queryObj As ManagementObject In searcher.Get

                If queryObj("interfacetype") = "IDE" Then

                    Dim gbtb
                    gbtb = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0)
                    If gbtb < 1000 Then
                        hrdsize = gbtb & " GB"
                    ElseIf gbtb >= 1000 Then
                        hrdsize = Math.Round(gbtb / 1000, 2) & " TB"
                    Else
                        hrdsize = gbtb & " GB"
                    End If
                    'hrdsize = Math.Round(queryObj("size") / 1024 / 1024 / 1024 * 1024 * 1024 * 1024 / 1000 / 1000 / 1000, 0) & " GB"
                    usasize = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " GB"
                    treevie.Nodes.Add(queryObj("Caption").ToString.Replace("ATA Device", ""))
                    treevie.Nodes(count).Nodes.Add("Size : " & hrdsize)
                    'lstHrdDev.Items(count).SubItems.Add(actsize & " (" & usasize & ")")
                    'storagenm = queryObj("caption")
                    'storagesp = Math.Round(queryObj("size") / 1024 / 1024 / 1024, 0) & " Gb"
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData")
            'loop through all the hard disks
            For Each queryObj As ManagementObject In searcher.[Get]()
                Dim arrVendorSpecific As Byte() = DirectCast(queryObj.GetPropertyValue("VendorSpecific"), Byte())
                'Find the temperature attribute
                Dim tempIndex As Integer = Array.IndexOf(arrVendorSpecific, TEMPERATURE_ATTRIBUTE)
                ' MsgBox(arrVendorSpecific(tempIndex + 5) & "ºC")
                If arrVendorSpecific(tempIndex + 5) <> 0 Then
                    treevie.Nodes(count).Nodes.Add("Temp : " & arrVendorSpecific(tempIndex + 5) & ".0 º C")
                Else
                    treevie.Nodes(count).Nodes.Add("Temp : No data found")
                End If
                'storagetemp = arrVendorSpecific(tempIndex + 5) & ".0 º C"
                count += 1
            Next
        Catch err As ManagementException
            'MsgBox("An error occurred while querying for WMI data: " + err.Message)
        End Try
        treevie.ExpandAll()
        Return Nothing

    End Function
    Public Shared Function IsConnectionAvailable()
        'To Check whether The Computer is connected to the internet or not
        Dim objURL As New System.Uri("http://www.google.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objURL)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return "Connected"

        Catch ex As Exception
            objResp = Nothing
            objWebReq = Nothing
            Return "Not Connected"
        End Try
    End Function
    Public Shared Function GetUpdateInformation(ByVal nm As Label, ByVal currver As Label, ByVal latver As Label, ByVal down86 As Label, ByVal down64 As Label, ByVal softwebid As Label, ByVal compwebid As Label)
        Try
            'If IsConnectionAvailable() = "Connected" Then
            If cpinfo.getOsBitness = "32" Then
                down86.Visible = True
                down64.Visible = False
            ElseIf cpinfo.getOsBitness = "64" Then
                down64.Visible = True
                down86.Visible = False
            Else
                down86.Visible = False
                down64.Visible = False
            End If
            Dim locd = SpecialFoldersandDrives.OsInstalledDrive
            Dim updt
            Try
                Dim fileecx
                fileecx = File.Exists("Update Sys Information.xml")
                If fileecx = True Then
                    File.Delete("Update Sys Information.xml")
                End If
            Catch ex As Exception
            End Try
            My.Computer.Network.DownloadFile("http://arvivesolutions.weebly.com/uploads/4/6/0/9/4609554/update_sys_optimizer.xml", "Update Sys Information.xml")
            Dim dls As XmlReader = New XmlTextReader("Update Sys Information.xml")
            If File.Exists("Update Sys Information.xml") = True Then
                While (dls.Read())
                    Dim typ = dls.NodeType

                    If typ = XmlNodeType.Element Then

                        If dls.Name = "VersToUpdt" Then
                            updt = dls.ReadInnerXml.ToString
                            'MsgBox(updt)

                            'File = Update Sys Information in c://windows//temp

                            'Dim updt = My.Computer.FileSystem.ReadAllText("update0_6.txt")
                            'MsgBox(updt)
                            If updt > "2.1" Then

                                If dls.Name = "Name" Then
                                    nm.Text = dls.ReadInnerXml.ToString
                                End If
                                If dls.Name = "CurrVers" Then
                                    currver.Text = dls.ReadInnerXml.ToString
                                End If
                                latver.Text = updt
                                If dls.Name = "Down86" Then
                                    down86.Text = dls.ReadInnerXml.ToString
                                End If
                                If dls.Name = "Down64" Then
                                    down64.Text = dls.ReadInnerXml.ToString
                                End If
                                If dls.Name = "SoftWEBID" Then
                                    softwebid.Text = dls.ReadInnerXml.ToString
                                End If
                                If dls.Name = "CompWEBID" Then
                                    compwebid.Text = dls.ReadInnerXml.ToString
                                End If
                            Else
                                MsgBox("Version Upto Date")
                                dls.Close()
                            End If
                        End If

                    End If
                End While
                dls.Close()
            Else
            End If
            'Try
            '    File.Delete("Update Sys Information.xml")
            'Catch ex As Exception

            'End Try
            'Else
            ' MsgBox("Error Connecting Server")
            ' End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    'Public Shared Function PerkDisplay(ByVal lbldatedis As Label, ByVal lblserial As Label)
    '    Dim serial = ""
    '    Dim expirydate = ""
    '    If File.Exists(Application.StartupPath & "\serial.xml") = True Then
    '        Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\serial.xml")
    '        While (dls.Read)
    '            Dim typ = dls.NodeType
    '            If typ = XmlNodeType.Element Then
    '                If dls.Name = "serial" Then
    '                    serial = dls.ReadInnerXml.ToString
    '                End If
    '                If dls.Name = "expdate" Then
    '                    expirydate = dls.ReadInnerXml.ToString
    '                End If
    '            End If
    '        End While
    '        dls.Close()
    '        lblserial.Text = "Serial : " & serial
    '        lbldatedis.Text = "Expiry Date : " & expirydate
    '    Else
    '        MsgBox("Serial file not valid")
    '    End If
    '    Return Nothing
    'End Function
    'Public Shared Function perk()
    '    Dim serial = ""
    '    Dim dateformated = ""
    '    If File.Exists(Application.StartupPath & "\serial.xml") = True And File.Exists(Functiod.SpecialFoldersandDrives.OsInstalledDrive & "\Windows\serial.xml") = True Then
    '        Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\serial.xml")
    '        While (dls.Read)
    '            Dim typ = dls.NodeType
    '            If typ = XmlNodeType.Element Then
    '                If dls.Name = "serial" Then
    '                    serial = dls.ReadInnerXml.ToString
    '                End If
    '                If dls.Name = "expdateformated" Then
    '                    dateformated = dls.ReadInnerXml.ToString
    '                End If

    '            End If
    '        End While
    '        dls.Close()
    '        If serial <> "aXb2-300234HJ-23eN-2d0A" And serial <> "Trial-300234HJ-23eN-Trial" Or dateformated = My.Computer.Clock.LocalTime.Day & My.Computer.Clock.LocalTime.Month & My.Computer.Clock.LocalTime.Year Then
    '            MsgBox("Program expired please renew license")
    '            SerialCheck.ShowDialog()
    '            'dls.Close()
    '        End If
    '        ' dls.Close()
    '    Else
    '        SerialCheck.ShowDialog()
    '    End If
    '    Return Nothing
    'End Function
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure
    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    Public Shared Function munch3(ByVal forms As Form)
        main.BackColor = Color.DimGray
        'main.panCleanerBttn.BackColor = Color.DimGray
        'main.bttnScanFiles.FlatAppearance.BorderColor = Color.DimGray
        'main.bttnCleanAllFiles.FlatAppearance.BorderColor = Color.DimGray
        'main.bttnScanFiles.ForeColor = Color.White
        'main.bttnCleanAllFiles.ForeColor = Color.White
        'main.bttnScanFiles.BackColor = Color.DimGray
        'main.bttnCleanAllFiles.BackColor = Color.DimGray
        'main.panNav.BackColor = Color.Gray
        'main.TreeView1.BackColor = Color.DimGray
        main.RTBMesages.BackColor = Color.DimGray
        main.panSplitCont.BackColor = Color.DimGray
        'main.panIntFlsDet.BackColor = Color.DimGray
        'main.panOthFlsDet.BackColor = Color.DimGray
        main.lblTmRem.ForeColor = Color.White
        'main.lblIntFlsSize.ForeColor = Color.White
        'main.lblOthFlsSiz.ForeColor = Color.White
        main.lblCurrTm.ForeColor = Color.White
        main.lblTm.ForeColor = Color.White
        main.lblLabelSection.ForeColor = Color.White
        main.lblRamCap.ForeColor = Color.White
        main.lblRAMCapandUsg.ForeColor = Color.White
        main.lblGraphics.ForeColor = Color.White
        'main.TreeView1.ForeColor = Color.White
        main.RTBMesages.ForeColor = Color.White
        main.lblLabelSysStat.ForeColor = Color.White
        ' main.TreeView1.BackColor = Color.DimGray
        main.RTBMesages.BackColor = Color.DimGray
        main.panSplitCont.BackColor = Color.DimGray
        main.lblBatPer.ForeColor = Color.White
        Return Nothing
    End Function
    Public Shared Function munch4()
        main.BackColor = Color.DarkGray
        'main.panCleanerBttn.BackColor = Color.DarkGray
        'main.bttnScanFiles.FlatAppearance.BorderColor = Color.DarkGray
        'main.bttnCleanAllFiles.FlatAppearance.BorderColor = Color.DarkGray
        'main.bttnScanFiles.ForeColor = Color.Black
        'main.bttnCleanAllFiles.ForeColor = Color.Black
        'main.bttnScanFiles.BackColor = Color.DarkGray
        'main.bttnCleanAllFiles.BackColor = Color.DarkGray
        'main.panIntFlsDet.BackColor = Color.DarkGray
        'main.panOthFlsDet.BackColor = Color.DarkGray
        main.lblTmRem.ForeColor = Color.Black
        main.lblIntFlsSize.ForeColor = Color.Black
        main.lblOthFlsSiz.ForeColor = Color.Black
        main.panSplitCont.BackColor = Color.DarkGray
        'main.panNav.BackColor = Color.Silver
        'main.TreeView1.BackColor = Color.DarkGray
        main.RTBMesages.BackColor = Color.DarkGray
        main.lblCurrTm.ForeColor = Color.Black
        main.lblTm.ForeColor = Color.Black
        main.lblLabelSection.ForeColor = Color.Black
        main.lblRamCap.ForeColor = Color.Black
        main.lblRAMCapandUsg.ForeColor = Color.Black
        main.lblGraphics.ForeColor = Color.Black

        '   main.TreeView1.ForeColor = Color.Black
        main.RTBMesages.ForeColor = Color.Black
        main.lblLabelSysStat.ForeColor = Color.Black
        main.lblBatPer.ForeColor = Color.Black
        Return Nothing
    End Function
    Public Shared Function munch2()
        main.BackColor = Color.Gainsboro
        'main.panCleanerBttn.BackColor = Color.Gainsboro
        'main.bttnScanFiles.FlatAppearance.BorderColor = Color.Gainsboro
        'main.bttnCleanAllFiles.FlatAppearance.BorderColor = Color.Gainsboro
        'main.bttnScanFiles.ForeColor = Color.Black
        'main.bttnCleanAllFiles.ForeColor = Color.Black
        'main.bttnScanFiles.BackColor = Color.Gainsboro
        'main.bttnCleanAllFiles.BackColor = Color.Gainsboro
        main.panSplitCont.BackColor = Color.Gainsboro
        'main.panNav.BackColor = Color.WhiteSmoke
        'main.TreeView1.BackColor = Color.Gainsboro
        main.RTBMesages.BackColor = Color.Gainsboro
        'main.panIntFlsDet.BackColor = Color.Gainsboro
        'main.panOthFlsDet.BackColor = Color.Gainsboro
        main.lblTmRem.ForeColor = Color.Black
        main.lblIntFlsSize.ForeColor = Color.Black
        main.lblOthFlsSiz.ForeColor = Color.Black
        main.lblCurrTm.ForeColor = Color.Black
        main.lblTm.ForeColor = Color.Black
        main.lblLabelSection.ForeColor = Color.Black
        main.lblRamCap.ForeColor = Color.Black
        main.lblRAMCapandUsg.ForeColor = Color.Black
        main.lblGraphics.ForeColor = Color.Black

        ' main.TreeView1.ForeColor = Color.Black
        main.RTBMesages.ForeColor = Color.Black
        main.lblLabelSysStat.ForeColor = Color.Black
        main.lblBatPer.ForeColor = Color.Black
        Return Nothing
    End Function
    Public Shared Function munch5()
        main.BackColor = Color.LightSteelBlue
        'main.panCleanerBttn.BackColor = Color.LightSteelBlue
        'main.bttnScanFiles.FlatAppearance.BorderColor = Color.LightSteelBlue
        'main.bttnCleanAllFiles.FlatAppearance.BorderColor = Color.LightSteelBlue
        'main.bttnScanFiles.ForeColor = Color.Black
        'main.bttnCleanAllFiles.ForeColor = Color.Black
        'main.bttnScanFiles.BackColor = Color.LightSteelBlue
        'main.bttnCleanAllFiles.BackColor = Color.LightSteelBlue
        main.panSplitCont.BackColor = Color.LightSteelBlue
        'main.panNav.BackColor = Color.AliceBlue
        ' main.TreeView1.BackColor = Color.LightSteelBlue
        main.RTBMesages.BackColor = Color.LightSteelBlue
        'main.panIntFlsDet.BackColor = Color.LightSteelBlue
        ' main.panOthFlsDet.BackColor = Color.LightSteelBlue
        main.lblTmRem.ForeColor = Color.Black
        main.lblIntFlsSize.ForeColor = Color.Black
        main.lblOthFlsSiz.ForeColor = Color.Black
        main.lblCurrTm.ForeColor = Color.Black
        main.lblTm.ForeColor = Color.Black
        main.lblLabelSection.ForeColor = Color.Black
        main.lblRamCap.ForeColor = Color.Black
        main.lblRAMCapandUsg.ForeColor = Color.Black
        main.lblGraphics.ForeColor = Color.Black

        ' main.TreeView1.ForeColor = Color.Black
        main.RTBMesages.ForeColor = Color.Black
        main.lblLabelSysStat.ForeColor = Color.Black
        main.lblBatPer.ForeColor = Color.Black
        Return Nothing
    End Function
    Public Shared Function SetInterface(ByVal frm As Form)
        Try
            Dim startwidth = ""
            Dim minwidth = ""
            Dim startheight = ""
            Dim minheight = ""
            Dim title = ""
            Dim maxbut = ""
            Dim minbut = ""
            Dim ctrlbx = ""
            Dim startpos = ""
            Dim borstyle = ""
            Dim showintaskbar = ""
            Dim opac = ""
            Dim showicn = ""
            Dim tpmst = ""
            Dim tmrstrt = ""
            Dim sls = ""
            Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\Plugins\InterfaceSettings.xml")
            If File.Exists(Application.StartupPath & "\Plugins\InterfaceSettings.xml") = True Then
                ' MsgBox("set")
                While (dls.Read())
                    Dim typ = dls.NodeType
                    If typ = XmlNodeType.Element Then
                        If dls.Name = "sysoptimizer" Then
                            sls = "1"
                        Else
                            sls = "0"

                        End If
                        If dls.Name = "startwidth" Then
                            startwidth = dls.ReadInnerXml.ToString
                            'MsgBox(startwidth)
                        End If
                        If dls.Name = "minwidth" Then
                            minwidth = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "startheight" Then
                            startheight = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "minheight" Then
                            minheight = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "title" Then
                            title = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "maxbut" Then
                            maxbut = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "minbut" Then
                            minbut = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "ctrlbx" Then
                            ctrlbx = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "startpos" Then
                            startpos = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "borstyle" Then
                            borstyle = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "showintaskbr" Then
                            showintaskbar = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "opac" Then
                            opac = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "showicn" Then
                            showicn = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "tpmst" Then
                            tpmst = dls.ReadInnerXml.ToString
                        End If
                        If dls.Name = "tmrstrt" Then
                            tmrstrt = dls.ReadInnerXml.ToString
                        End If

                    End If

                End While
                'frm.Width = startwidth
                'frm.Height = startheight
                'frm.MinimumSize = New Size(minwidth, minheight)
                frm.Text = title
                If maxbut = "0" Then
                    frm.MaximizeBox = False
                Else
                    frm.MaximizeBox = True
                End If
                If minbut = "0" Then
                    frm.MinimizeBox = False
                Else
                    frm.MinimizeBox = True
                End If
                If ctrlbx = "0" Then
                    frm.ControlBox = False
                Else
                    frm.ControlBox = True
                End If
                If startpos = "0" Then
                    frm.StartPosition = FormStartPosition.Manual
                ElseIf startpos = "1" Then
                    frm.StartPosition = FormStartPosition.CenterScreen
                ElseIf startpos = "2" Then
                    frm.StartPosition = FormStartPosition.WindowsDefaultBounds
                Else
                    frm.StartPosition = FormStartPosition.CenterScreen
                End If
                If borstyle = "0" Then
                    frm.FormBorderStyle = FormBorderStyle.None
                ElseIf borstyle = "1" Then
                    'frm.FormBorderStyle = FormBorderStyle.Sizable
                ElseIf borstyle = "2" Then
                    frm.FormBorderStyle = FormBorderStyle.FixedSingle
                Else
                    frm.FormBorderStyle = FormBorderStyle.Sizable
                End If
                If showintaskbar = "0" Then
                    frm.ShowInTaskbar = False
                    'MsgBox("Exe")
                Else
                    'MsgBox("tru")
                    frm.ShowInTaskbar = True
                End If
                If showicn = "0" Then
                    frm.ShowIcon = False
                Else
                    frm.ShowIcon = True
                End If
                'If tpmst = "0" Then
                '    frm.TopMost = False
                'Else
                '    frm.TopMost = True
                'End If
                'frm.Opacity = opac
            Else
                MsgBox("Sorry InterfaceSettings.xml not found please reinstall or repair the program to fix it", MsgBoxStyle.Critical + vbOKOnly, "Error")
                End
            End If
            Return Nothing
            dls.Close()
        Catch ex As Exception
            MsgBox("The Interfacesettings.xml is corrupted please reinstall or repair the program to fix it", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End
        End Try

    End Function
    Public Class clsWMID
        Public Class glsWMI
            Private objBat As ManagementObjectSearcher
            Private objMgmt As ManagementObject
            Private m_BatManu As String
            Private m_BatCap As String
            Private m_BatStatus As String
            Private m_BatTyp As String
            Private m_BatLvl As String
            Private m_EstiRnTm As String
            Private m_BatAvl As String
            Public Sub New()
                objBat = New ManagementObjectSearcher("SELECT * FROM Win32_Battery")
                For Each Me.objMgmt In objBat.Get
                    m_BatAvl = objMgmt("Availability")
                    m_BatManu = objMgmt("DeviceID")
                    m_BatCap = objMgmt("caption")
                    m_BatStatus = objMgmt("batterystatus")
                    m_BatTyp = objMgmt("chemistry")
                    m_BatLvl = objMgmt("estimatedchargeremaining")
                    m_EstiRnTm = objMgmt("estimatedruntime")
                Next
            End Sub
            Public ReadOnly Property GetBatAvl()
                Get
                    GetBatAvl = m_BatAvl
                End Get
            End Property
            Public ReadOnly Property EstimatedRunTime()
                Get
                    EstimatedRunTime = m_EstiRnTm
                End Get
            End Property
            Public ReadOnly Property GetBatLvl()
                Get
                    GetBatLvl = m_BatLvl
                End Get
            End Property
            Public ReadOnly Property GetBatType()
                Get
                    GetBatType = m_BatTyp
                End Get
            End Property
            Public ReadOnly Property GetBatStatus()
                Get
                    GetBatStatus = m_BatStatus
                End Get
            End Property
            Public ReadOnly Property GetBatCapt()
                Get
                    GetBatCapt = m_BatCap
                End Get
            End Property
            Public ReadOnly Property GetBatManu()
                Get
                    GetBatManu = m_BatManu
                End Get
            End Property
        End Class
        Public Class batInfo
            Public Shared Function BatteryStatusMessage()
                'Dim batterystatus As String
                Dim DLSWMI As New glsWMI
                With DLSWMI
                    Select Case .GetBatStatus
                        Case 1
                            Return "On Battery"
                        Case 2
                            Return "Charging"
                        Case 3
                            Return "Fully Charged"
                        Case 4
                            Return "Low"
                        Case 5
                            Return "Critical"
                        Case 6
                            Return "Charging"
                        Case 7
                            Return "Charging and high"
                        Case 8
                            Return "Charging and low"
                        Case 9
                            Return "Changing and critical"
                        Case 10
                            Return "Undefined"
                        Case 11
                            Return "Partially Charged"
                        Case Else
                            Return "Battery Status Cannot be determined"
                    End Select
                End With
            End Function
            Public Shared Function GetBatteryType()
                Dim DLSWMI As New glsWMI
                With DLSWMI
                    Select Case .GetBatType
                        Case 1
                            Return "Other"
                        Case 2
                            Return "Unknown"
                        Case 3
                            Return "Lead Acid"
                        Case 4
                            Return "Nickel Cadmium"
                        Case 5
                            Return "Nickel Metal Hydride"
                        Case 6
                            Return "Lithium-ion"
                        Case 7
                            Return "Zinc Air"
                        Case 8
                            Return "Lithium Polymer"
                        Case Else
                            Return "Sorry Battery Type Cannot be determined"
                    End Select
                End With
            End Function
            Public Shared Function ifBatAvl()
                Dim xlxWMI As New glsWMI
                With xlxWMI
                    Return .GetBatAvl
                End With
            End Function
            Public Shared Function BatteryInfo()
                Dim GLXWMI As New glsWMI
                With GLXWMI
                    If BatteryStatusMessage() = "On Battery" Then
                        Dim min = .EstimatedRunTime Mod 60
                        If .EstimatedRunTime < 60 Then
                            Return .EstimatedRunTime & " min"
                        Else
                            Return Math.Round(.EstimatedRunTime / 60, 0) & " hr and " & min & " min"
                        End If
                    Else
                        Return "Charging"
                    End If
                End With
                Return Nothing
            End Function
        End Class
    End Class
    Public Shared nm As String
    Public Shared currver As String
    Public Shared latver As String
    Public Shared down86 As String
    Public Shared down64 As String
    Public Shared softwebid As String
    Public Shared compwebid As String
    Public Shared Function GetUpdateInformationThreadSafe(ByVal URL As String)
        Try
            If IsConnectionAvailable() = "Connected" Then

                Dim locd = SpecialFoldersandDrives.OsInstalledDrive
                Dim updt
                Try
                    Dim fileecx
                    fileecx = File.Exists("Update Sys Optimizer.xml")
                    If fileecx = True Then
                        File.Delete("Update Sys Optimizer.xml")
                    End If
                Catch ex As Exception
                End Try
                My.Computer.Network.DownloadFile(URL, "Update Sys Optimizer.xml")
                Dim dls As XmlReader = New XmlTextReader("Update Sys Optimizer.xml")
                If File.Exists("Update Sys Optimizer.xml") = True Then
                    While (dls.Read())
                        Dim typ = dls.NodeType

                        If typ = XmlNodeType.Element Then

                            If dls.Name = "VersToUpdt" Then
                                updt = dls.ReadInnerXml.ToString
                                'MsgBox(updt)

                                'File = Update Sys Information in c://windows//temp

                                'Dim updt = My.Computer.FileSystem.ReadAllText("update0_6.txt")
                                'MsgBox(updt)
                                If updt > "2.1" Then

                                    If dls.Name = "Name" Then
                                        'nm.Text = dls.ReadInnerXml.ToString
                                        nm = dls.ReadInnerXml.ToString
                                    End If
                                    If dls.Name = "CurrVers" Then
                                        currver = dls.ReadInnerXml.ToString
                                        currver = "2.1"
                                    End If
                                    latver = updt
                                    ' latver.Text = updt
                                    If dls.Name = "Down86" Then
                                        'down86.Text = dls.ReadInnerXml.ToString
                                        down86 = dls.ReadInnerXml.ToString
                                    End If
                                    If dls.Name = "Down64" Then
                                        'down64.Text = dls.ReadInnerXml.ToString
                                        down64 = dls.ReadInnerXml.ToString
                                    End If
                                    If dls.Name = "SoftWEBID" Then
                                        'softwebid.Text = dls.ReadInnerXml.ToString
                                        softwebid = dls.ReadInnerXml.ToString
                                    End If
                                    If dls.Name = "CompWEBID" Then
                                        'compwebid.Text = dls.ReadInnerXml.ToString
                                        compwebid = dls.ReadInnerXml.ToString
                                    End If

                                Else
                                    'MsgBox("Version Upto Date")
                                    nm = "Version Up to date"
                                    dls.Close()
                                End If
                            End If

                        End If
                    End While
                    dls.Close()
                    Try
                        Dim fileecx
                        fileecx = File.Exists("Update Sys Optimizer.xml")
                        If fileecx = True Then
                            File.Delete("Update Sys Optimizer.xml")
                        End If
                    Catch ex As Exception
                    End Try
                Else
                End If
                'Try
                '    File.Delete("Update Sys Information.xml")
                'Catch ex As Exception

                'End Try
            Else
                'MsgBox("Error Connecting Server", vbOKOnly + MsgBoxStyle.Critical, "Error")
                nm = "Error Connecting Server"
                currver = "Error Connecting Server"
                latver = "Error Connecting Server"
                down86 = "Error Connecting Server"
                down64 = "Error Connecting Server"
                softwebid = "Error Connecting Server"
                compwebid = "Error Connecting Server"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function


    Public Class CheckOS
        Public Shared Function CheckUsingVersionNumber()
            Dim osver = System.Environment.OSVersion.Version.ToString
            Dim osname As String
            If osver >= "6.2.9200" Then
                osname = "8"
            ElseIf osver >= "6.1.7600" Then
                osname = "7"
            ElseIf osver >= "6.0" Then
                osname = "vista"
            ElseIf osver >= "5.1" Then
                osname = "xp"
            Else
                osname = Nothing
            End If
            'MsgBox(osname)
            Return osname
        End Function
    End Class
    Public Shared Function getPowerPlans(ByVal lblpowerpl As Label)
        Dim count = 0
        Try
            Using power As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User\PowerSchemes")
                For Each dsd As String In power.GetSubKeyNames()
                    Using key As RegistryKey = power.OpenSubKey(dsd)
                        Dim name = key.GetValue("FriendlyName")
                        MsgBox(name)
                        If name.ToString.StartsWith("@") = True Then
                            Dim atrem = name.ToString.Remove(0, name.ToString.IndexOf(","))
                            Dim trims = atrem.Remove(0, 5)
                            Return trims
                            MsgBox(trims)
                            lblpowerpl.Text = dsd
                            count += 1
                        ElseIf name.ToString = "" Then
                            Return Nothing
                            lblpowerpl.Text = dsd
                        Else
                            Return name
                            lblpowerpl.Text = dsd
                            count += 1
                        End If
                    End Using
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
        Public Shared Function getPowerPlnDescription(ByVal lstPower As ListView, ByVal RTBMes As RichTextBox)
            Dim I As Integer
            For I = 0 To lstPower.SelectedItems.Count - 1
                Dim path As String = (lstPower.SelectedItems(I).Text)
                Try
                    Dim count = 0
                    Using power As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User\PowerSchemes")
                        For Each dsd As String In power.GetSubKeyNames()
                            Using key As RegistryKey = power.OpenSubKey(dsd)
                                Dim named = dsd
                                If path = named Then
                                    Dim name = key.GetValue("Description")
                                    If name.ToString.StartsWith("@") = True Then
                                        Dim atrem = name.ToString.Remove(0, name.ToString.IndexOf(","))
                                        Dim trims = atrem.Remove(0, 5)
                                        RTBMes.Text = trims
                                    Else
                                        If name = "" Then
                                            RTBMes.Text = "No Description"
                                        Else
                                            RTBMes.Text = name
                                        End If
                                    End If
                                End If
                                'MsgBox("name" & name)
                                'Dim redefined = name.ToString.Replace("@", "")
                                'Dim flnm = IO.Path.GetPathRoot(redefined)
                                'MsgBox(flnm)
                            End Using
                        Next
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next
            Return Nothing
        End Function
    Public Shared Function GetActivePowerPln(ByVal lblregKey As Label)
        Try
            Dim name As String = "Not Found"
            Dim nameonall As String = "Not Found"
            Dim namefriend As String = "Not Found"
            Using power As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User")
                For Each dsd As String In power.GetSubKeyNames()
                    If dsd = "PowerSchemes" Then
                        Using key As RegistryKey = power.OpenSubKey(dsd)
                            name = key.GetValue("ActivePowerScheme")
                            'MsgBox(name)
                            Using powersch As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User\PowerSchemes")
                                For Each dsdd As String In powersch.GetSubKeyNames()
                                    Using keys As RegistryKey = powersch.OpenSubKey(dsdd)
                                        nameonall = dsdd
                                        Dim named = keys.GetValue("FriendlyName")
                                        If named.ToString.StartsWith("@") = True Then
                                            Dim atrem = named.ToString.Remove(0, named.ToString.IndexOf(","))
                                            Dim trims = atrem.Remove(0, 5)
                                            namefriend = trims
                                            'MsgBox(trims)
                                            'MsgBox(nameonall)
                                            If name = nameonall Then
                                                'MsgBox(name)
                                                'MsgBox(namefriend)
                                                lblregKey.Text = dsdd.ToString
                                                Return namefriend

                                            End If
                                        Else
                                            namefriend = named
                                            If name = nameonall Then
                                                'MsgBox(namefriend)
                                                'MsgBox(dsdd)
                                                Return namefriend

                                            End If
                                        End If
                                    End Using
                                Next
                            End Using
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
    Public Shared Function GetActivePowerPlnOnlRet()
        Try
            Dim name As String = "Not Found"
            Dim nameonall As String = "Not Found"
            Dim namefriend As String = "Not Found"
            Using power As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User")
                For Each dsd As String In power.GetSubKeyNames()
                    If dsd = "PowerSchemes" Then
                        Using key As RegistryKey = power.OpenSubKey(dsd)
                            name = key.GetValue("ActivePowerScheme")
                            'MsgBox(name)
                            Using powersch As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Power\User\PowerSchemes")
                                For Each dsdd As String In powersch.GetSubKeyNames()
                                    Using keys As RegistryKey = powersch.OpenSubKey(dsdd)
                                        nameonall = dsdd
                                        Dim named = keys.GetValue("FriendlyName")
                                        If named.ToString.StartsWith("@") = True Then
                                            Dim atrem = named.ToString.Remove(0, named.ToString.IndexOf(","))
                                            Dim trims = atrem.Remove(0, 5)
                                            namefriend = trims
                                            'MsgBox(trims)
                                            'MsgBox(nameonall)
                                            If name = nameonall Then
                                                'MsgBox(name)
                                                'MsgBox(namefriend)
                                                Return namefriend

                                            End If
                                        Else
                                            namefriend = named
                                            If name = nameonall Then
                                                'MsgBox(namefriend)
                                                'MsgBox(dsdd)
                                                Return namefriend

                                            End If
                                        End If
                                    End Using
                                Next
                            End Using
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
    Public Shared Function checkandactihighperform()

        Dim name As String = "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c"
        Dim path As String = name
        If path <> "" Then
            Try
                Shell("powercfg -setactive " & path)
                'MsgBox("success")
            Catch ex As Exception
                MsgBox(ex)
            End Try
            Threading.Thread.Sleep(100)
            Misc.GetActivePowerPln(main.lblPowerPlnRgCde)
        Else
            MsgBox("Please select a power plan to change")
        End If
        Return Nothing
    End Function
    'a1841308-3541-4fab-bc81-f71556f20b4a
    Public Shared Function checkandactipowersaver()
        Dim name As String = "a1841308-3541-4fab-bc81-f71556f20b4a"
        Dim path As String = name
        If path <> "" Then
            Try
                Shell("powercfg -setactive " & path)
            Catch ex As Exception
                MsgBox(ex)
            End Try
            Threading.Thread.Sleep(100)
            Misc.GetActivePowerPln(main.lblPowerPlnRgCde)
        Else
            MsgBox("Please select a power plan to change")
        End If
    End Function
    Public Shared Function ActivatePowerPln(ByVal strRegKy As String)
        Dim path As String = strRegKy
            If path <> "" Then
                Try
                    Shell("powercfg -setactive " & path)
                    'MsgBox("success")
                Catch ex As Exception
                    MsgBox(ex)
                End Try
                Threading.Thread.Sleep(100)
                Misc.GetActivePowerPln(main.lblPowerPlnRgCde)
            Else
                MsgBox("Please select a power plan to change")
            End If
        Return Nothing
    End Function
    End Class
