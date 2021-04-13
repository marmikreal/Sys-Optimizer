'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyright (C) 2012-2013 A-Soft. All Rights Reserved.                     #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################
Imports System.IO
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Management

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
Public Class ClsWMI
    Private objOperSys As ManagementObjectSearcher
    Private objMgmt As ManagementObject
    Private m_WindowsFolder As String

    Public Sub New()
        objOperSys = New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")

        For Each Me.objMgmt In objOperSys.Get

            m_WindowsFolder = objMgmt("SystemDrive")

        Next
       
    End Sub
    Public ReadOnly Property WindowsFolder()
        Get
            WindowsFolder = m_WindowsFolder
        End Get
    End Property
End Class
Public Class SpecialFoldersandDrives
    Public Shared crashbox As Boolean
    Public Shared crashmessage As String
    Public Shared Function OsInstalledDrive()
        Dim dlsWMI As New ClsWMI
        With dlsWMI
            Try
                Return .WindowsFolder
            Catch ex As Exception
                crashbox = True
                crashmessage = "The Error Occurred at : " & ex.ToString
                Return Nothing
            End Try
        End With
    End Function
End Class
Public Class Cache
    Public Shared Function GetWindowsFolder()
        Dim dlsWMI As New ClsWMI
        With dlsWMI
            MsgBox(.WindowsFolder)
        End With
        Return Nothing
    End Function
    Public Shared Function GetIECookies()
        Dim cookiesfolder As String
        Dim cookesxpfolder As String
        'C:\Users\Aravindh\AppData\Roaming\Microsoft\Windows\Cookies\Low
        'C:\DocumentsAndSettings\Aravindh\Cookies
        cookiesfolder = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Microsoft\Windows\Cookies\Low"
        cookesxpfolder = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Cookies"
        Dim cookiesfolderex = IO.Directory.Exists(cookiesfolder)
        Dim cookiesfolderxpex = IO.Directory.Exists(cookesxpfolder)
        If Functiod.CheckOS.CheckUsingVersionNumber = "7" And cookiesfolderex = True Then
            Return cookiesfolder
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "xp" And cookiesfolderxpex = True Then
            Return cookesxpfolder
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetIEFilesContentIE5()
        'C:\Users\Aravindh\AppData\Local\Microsoft\Windows\Temporary Internet Files
        Dim iecontentie5 As String
        iecontentie5 = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Windows\Temporary Internet Files"
        Dim iecontentie5ex As Boolean
        iecontentie5ex = IO.Directory.Exists(iecontentie5)
        If iecontentie5ex = True Then
            Return iecontentie5
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function GetIEDtBses()
        Dim iecompact As String
        'C:\Users\Aravindh\AppData\Roaming\Microsoft\Windows\IECompatCache
        iecompact = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Microsoft\Windows\IECompatCache"
        Dim iecompactex As Boolean
        iecompactex = IO.Directory.Exists(iecompact)
        If iecompactex = True Then
            Return iecompact
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function GetIEFeedsCache()
        'C:\Users\Aravindh\AppData\Local\Microsoft\Feeds Cache
        Dim feedscache As String
        feedscache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Feeds Cache"
        Dim feedcacheex As Boolean
        feedcacheex = IO.Directory.Exists(feedscache)
        If feedcacheex = True Then
            Return feedscache
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function GetIEFiles()
        Dim IEFilesFolder As String
        Dim IEFilesXPFolder As String
        IEFilesFolder = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Windows\Temporary Internet Files\Low"
        IEFilesXPFolder = SpecialFoldersandDrives.OsInstalledDrive & "Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Temporary Internet Files"
        Dim IEFilesFolderEx = IO.Directory.Exists(IEFilesFolder)
        Dim IEFilesXPFolderEx = IO.Directory.Exists(IEFilesXPFolder)
        If Functiod.CheckOS.CheckUsingVersionNumber = "vista" Or Functiod.CheckOS.CheckUsingVersionNumber = "7" And IEFilesFolderEx = True Then
            Return IEFilesFolder
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "xp" And IEFilesXPFolderEx = True Then
            Return IEFilesXPFolder
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function getInernetFiles() As String
        ' MsgBox(Functiod.CheckOS.CheckUsingVersionNumber())
        Dim infilesfolder As String

        infilesfolder = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Windows\Temporary Internet Files\Low\Content.IE5"
        Dim infilesxpfolder = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Temporary Internet Files"
        Dim infolex = IO.Directory.Exists(infilesfolder)
        Dim infilesxpfolex = IO.Directory.Exists(infilesxpfolder)
        If Functiod.CheckOS.CheckUsingVersionNumber = "vista" Or Functiod.CheckOS.CheckUsingVersionNumber = "7" And infolex = True Then
            Return infilesfolder
            'On Error Resume Next
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "xp" And infilesxpfolex = True Then
            Return infilesxpfolder
            'On Error Resume Next
        Else
            Return Nothing
            'On Error Resume Next
        End If
        On Error Resume Next


    End Function
    Public Shared Function GetTempFilesWindows()
        Dim tempfol As String
        tempfol = SpecialFoldersandDrives.OsInstalledDrive & "\Windows\Temp"
        Dim tempfolex = IO.Directory.Exists(tempfol)
        If tempfolex = True Then
            Return tempfol
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetChromeCache() As String
        Dim ChromeCache As String
        ChromeCache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome\User Data\"
        Dim chromexpcache As String
        chromexpcache = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Google\Chrome\User Data\Default\Cache"
        Dim cacheexe = IO.Directory.Exists(ChromeCache)
        Dim cachexpexe = IO.Directory.Exists(chromexpcache)
        If cacheexe = True Then
            Return ChromeCache
        ElseIf cachexpexe = True Then
            Return chromexpcache
        Else
            Return Nothing
        End If
        Return Nothing
    End Function
    Public Shared Function GetCanaryCache()
        'C:\Users\Aravindh\AppData\Local\Google\Chrome SxS\User Data\Default\Cache
        Dim canarycache As String
        canarycache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome SxS\User Data"
        Dim canarycacheex As Boolean
        canarycacheex = IO.Directory.Exists(canarycache)
        If canarycacheex = True Then
            'For Each canarycache2 In Directory.GetDirectories(canarycache)
            'MsgBox(canarycache2)
            Return canarycache
            '  Next
        Else
            Return Nothing
        End If
        Return Nothing
    End Function
    Public Shared Function GetChromeMediaCache() As String
        'C:\Users\Aravindh\AppData\Local\Google\Chrome\User Data\Default
        Dim chromemediacac As String
        chromemediacac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome\User Data\"
        Dim chromemediacacex As Boolean
        chromemediacacex = IO.Directory.Exists(chromemediacac)
        If chromemediacacex = True Then
            'For Each canarycache2 In Directory.GetDirectories(chromemediacac)
            'If Directory.Exists(canarycache2 & "\Media Cache") = True Then
            Return chromemediacac
        
        ' Next
        Else
        Return Nothing
        End If
        'Return Nothing
    End Function
    Public Shared Function GetCanaryMediaCache()
        Dim canarymediacache As String
        canarymediacache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome SxS\User Data\"
        Dim canarymediacacheex As Boolean
        canarymediacacheex = IO.Directory.Exists(canarymediacache)
        If canarymediacacheex = True Then
            ' For Each canarymediacachefiles In Directory.GetDirectories(canarymediacache)
            'If Directory.Exists(canarymediacachefiles & "\Media Cache") = True Then
            Return canarymediacache
            'Else
            'Return Nothing
            'End If
            ' Next
        Else
            Return Nothing
        End If
        'Return Nothing
    End Function
    Public Shared Function GetChromeothers() As String
        Dim chromeothers As String
        chromeothers = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome\User Data\"
        ' Dim chromexpothers As String
        ' chromexpothers = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Google\Chrome\User Data\Default"
        Dim otherexe = IO.Directory.Exists(chromeothers)
        ' Dim otherxpexe = IO.Directory.Exists(chromexpothers)
        If otherexe = True Then
            'For Each foldinfold In Directory.GetDirectories(chromeothers)
            'If Directory.Exists(foldinfold) = True Then
            'MsgBox(foldinfold)
            Return chromeothers
            'End If
            ' Next
            'ElseIf otherxpexe = True Then
            ' Return chromexpothers
        Else
            Return Nothing
        End If
        ' Return Nothing
    End Function
    Public Shared Function GetCanaryOthers()
        Dim canaryothers As String
        canaryothers = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Google\Chrome SxS\User Data\"
        Dim canaryothersex As Boolean
        canaryothersex = IO.Directory.Exists(canaryothers)
        If canaryothersex = True Then
            'For Each foldinfold In Directory.GetDirectories(canaryothers)
            Return canaryothers
            ' Next
        Else
            Return Nothing
        End If
        Return Nothing
    End Function
    
    Public Shared Function GetSafariCache()
        Dim safricache7 = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Apple Computer\Safari\"
        Dim safricachexp = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Apple Computer\Safari"
        Dim safricache7ex = IO.Directory.Exists(safricache7)
        Dim safricachexpex = IO.Directory.Exists(safricachexp)
        If safricache7ex = True Then
            Return safricache7
        ElseIf safricachexpex = True Then
            Return safricachexp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetSafariHistory()
        Dim safarihis As String
        safarihis = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Apple Computer\Safari\History"
        Dim safarixphis
        safarixphis = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Apple Computer\Safari\History"
        Dim safariexhis = IO.Directory.Exists(safarihis)
        Dim safariexxphis = IO.Directory.Exists(safarixphis)
        If safariexhis = True Then
            Return safarihis
        ElseIf safariexxphis = True Then
            Return safarixphis
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetSafariWebpagePreviews()
        Dim safariweb As String
        safariweb = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Apple Computer\Safari\Webpage Previews"
        Dim safarixpweb As String
        safarixpweb = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Apple Computer\Safari\Webpage Previews"
        Dim safariexcache = IO.Directory.Exists(safariweb)
        Dim safariexxpcache = IO.Directory.Exists(safarixpweb)
        If safariexcache = True Then
            Return safariweb
        ElseIf safariexxpcache = True Then
            Return safarixpweb
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetSafariOthers()
        Dim safariOthers As String
        'xp = C:\Documents and Settings\Arvin Soft Test\Application Data\Apple Computer\Safari
        '7 = C:\Users\Aravindh\AppData\Roaming\Apple Computer\Safari
        safariOthers = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Apple Computer\Safari"
        Dim safariOthersxp As String
        'safariOthersxp = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "Application Data\Apple Computer\Safari"
        safariOthersxp = "C:\Documents and Settings\Arvin Soft Test\Application Data\Apple Computer\Safari"
        Dim SafariOthersex As Boolean
        Dim SafariOthersxpex As Boolean
        SafariOthersex = IO.Directory.Exists(safariOthers)
        SafariOthersxpex = IO.Directory.Exists(safariOthersxp)
        If SafariOthersex = True Then
            Return safariOthers
            'ElseIf SafariOthersxpex = True Then
            '    Return safariOthersxp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetFirefoxCache() As String
        Dim fireCache As String
        'C:\Users\Aravindh\AppData\Local\Mozilla\Firefox\Profiles\jftl47mb.default-1370183395194\thumbnails
        fireCache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Mozilla\Firefox\Profiles"
        Dim firexpcache As String
        firexpcache = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Mozilla\Firefox\Profiles"
        Dim cacheexe = IO.Directory.Exists(fireCache)
        Dim cachexpexe = IO.Directory.Exists(firexpcache)
        If cacheexe = True Then
            Return fireCache
        ElseIf cachexpexe = True Then
            Return firexpcache
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetThunderbirdSes() As String
        'C:\Users\Aravindh\AppData\Roaming\Thunderbird\Profiles\gkx5gs6l.default
        Dim thunderses As String
        thunderses = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Thunderbird\Profiles"
        Dim thundersesex As Boolean
        thundersesex = IO.Directory.Exists(thunderses)
        If thundersesex = True Then
            Return thunderses
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetThunderbirdCache()
        'C:\Users\Aravindh\AppData\Local\Thunderbird\Profiles\gkx5gs6l.default\Cache
        Dim thundercache As String
        thundercache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Thunderbird\Profiles"
        Dim thundercacheex As Boolean
        thundercacheex = IO.Directory.Exists(thundercache)
        If thundercacheex = True Then
            Return thundercache
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetFirefoxMiscl() As String
        Dim fireMis As String
        'C:\Users\Aravindh\AppData\Roaming\Mozilla\Firefox\Profiles
        fireMis = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Mozilla\Firefox\Profiles"
        Dim firexpmis As String
        'C:\Documents and Settings\Arvin Soft Test\Application Data\Mozilla\Firefox\Profiles\x2ep7j9v.default
        firexpmis = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Application Data\Mozilla\Firefox\Profiles"
        Dim firemisex = IO.Directory.Exists(fireMis)
        Dim firemisxpex = IO.Directory.Exists(firexpmis)
        If firemisex = True Then
            Return fireMis
        ElseIf firemisxpex = True Then
            'MsgBox("true")
            Return firexpmis

        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetFirefoxJumpLst() As String
        Dim firejmp As String
        firejmp = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Mozilla\Firefox\Profiles"
        Dim firejmpex = IO.Directory.Exists(firejmp)
        If firejmpex = True Then
            Return firejmp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaCache() As String
        Dim operacache As String
        Dim operaxpcache As String
        'C:\Users\Aravindh\AppData\Local\Opera\Opera\cache
        operacache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Opera\Opera\cache"
        operaxpcache = SpecialFoldersandDrives.OsInstalledDrive & "\Documents And Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\opera\opera\cache"
        Dim operacacex As Boolean
        operacacex = IO.Directory.Exists(operacache)
        Dim operaxpcacex = IO.Directory.Exists(operaxpcache)
        If operacacex = True Then
            Return operacache
        ElseIf operaxpcacex = True Then
            Return operaxpcache
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableCacheNew() As String
        Dim operacache As String
        operacache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Opera Software\Opera Stable\Cache"
        Dim operacacheex As Boolean
        operacacheex = IO.Directory.Exists(operacache)
        If operacacheex = True Then
            Return operacache
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableStandardNew()
        Dim operastd As String
        operastd = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Opera Software\Opera Stable"
        Dim operastdex As Boolean
        operastdex = IO.Directory.Exists(operastd)
        If operastdex = True Then
            Return operastd
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableOthersNew()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable
        Dim operaothers As String
        operaothers = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable"
        Dim operaothersex As Boolean
        operaothersex = IO.Directory.Exists(operaothers)
        If operaothersex = True Then
            Return operaothers
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableJumpListIconsNew()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable\Jump List Icons
        Dim operajmplst As String
        operajmplst = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable\Jump List Icons"
        Dim Operajmplstex As Boolean
        Operajmplstex = IO.Directory.Exists(operajmplst)
        If Operajmplstex = True Then
            Return operajmplst
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableJumpListIconsOldNew()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable\Jump List IconsOld
        Dim operajmplstold As String
        operajmplstold = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable\Jump List IconsOld"
        Dim operajmplstoldex As Boolean
        operajmplstoldex = IO.Directory.Exists(operajmplstold)
        If operajmplstoldex = True Then
            Return operajmplstold
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableLocalStorageNew()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable\Local Storage
        Dim operaLocalStorage As String
        operaLocalStorage = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable\Local Storage"
        Dim operaLocalStorageEx As Boolean
        operaLocalStorageEx = IO.Directory.Exists(operaLocalStorage)
        If operaLocalStorageEx = True Then
            Return operaLocalStorage
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStableGPUCacheNew()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable\GPUCache
        Dim operaGPUCac As String
        operaGPUCac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable\GPUCache"
        Dim operGPUCacex As Boolean
        operGPUCacex = IO.Directory.Exists(operaGPUCac)
        If operGPUCacex = True Then
            Return operaGPUCac
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaRoamStandard()
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera Software\Opera Stable
        Dim operaStd As String
        operaStd = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera Software\Opera Stable"
        Dim operastdex As Boolean
        operastdex = IO.Directory.Exists(operaStd)
        If operastdex = True Then
            Return operaStd
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaStandard()
        '7 = C:\Users\Aravindh\AppData\Local\Opera\Opera\
        'xp = C:\Documents and Settings\Arvin Soft Test\Local Settings\Application Data\Opera\Opera
        'C:\Users\Aravindh\AppData\Local\Opera\Opera\icons
        'C:\Users\Aravindh\AppData\Local\Opera\Opera\temporary_downloads
        Dim operaStd As String
        Dim operaxpstd As String
        operaStd = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.Computer.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Opera\Opera"
        operaxpstd = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Local Settings\Application Data\Opera\Opera"
        Dim operastdex As Boolean
        Dim operaxpstdex As Boolean
        operastdex = IO.Directory.Exists(operaStd)
        operaxpstdex = IO.Directory.Exists(operaxpstd)
        If operastdex = True Then
            Return operaStd
        ElseIf operaxpstdex = True Then
            Return operaxpstd
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOperaOthers() As String
        '7 = C:\Users\Aravindh\AppData\Roaming\Opera\Opera
        'xp = C:\Documents and Settings\Arvin Soft Test\Application Data\Opera\Opera
        Dim operaothers As String
        Dim operaxpothers As String
        operaothers = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Opera\Opera"
        operaxpothers = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Application Data\Opera\Opera"
        Dim operaothersex As Boolean
        Dim operaxpothersex As Boolean
        operaothersex = IO.Directory.Exists(operaothers)
        operaxpothersex = IO.Directory.Exists(operaxpothers)
        If operaothersex = True Then
            Return operaothers
        ElseIf operaxpothersex = True Then
            Return operaxpothers
        Else
            Return Nothing
        End If
    End Function
End Class
Public Class windowsfolders
    Public Shared Function WindowsRecent()
        Dim Rec As String
        Dim Recxp As String
        'C:\Users\Aravindh\AppData\Roaming\Microsoft\Windows\Recent
        'C:\Documents and Settings\Arvin Soft Test\Recent
        Rec = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Microsoft\Windows\Recent"
        Recxp = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Recent"
        Dim Recex As Boolean
        Dim Recxpex As Boolean
        Recxpex = IO.Directory.Exists(Recxp)
        Recex = IO.Directory.Exists(Rec)
        If Recex = True Then
            Return Rec
        ElseIf Recxpex = True Then
            Return Recxp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetOldPrefetchData()
        Dim prefetchsev As String
        prefetchsev = SpecialFoldersandDrives.OsInstalledDrive & "\Windows\Prefetch"
        Return prefetchsev
    End Function
End Class
Public Class WindowsItems
    Public Shared Function GetWindowsLog()
        Dim logfold As String
        Dim logfoldxp As String
        logfold = SpecialFoldersandDrives.OsInstalledDrive & "\Windows\Logs"
        logfoldxp = SpecialFoldersandDrives.OsInstalledDrive & "\WINDOWS\system32\wbem\Logs"
        Dim logfoldex = IO.Directory.Exists(logfold)
        Dim logfoldxpex = IO.Directory.Exists(logfoldxp)
        If logfoldex = True Then
            Return logfold
        ElseIf logfoldxpex = True Then
            Return logfoldxp
        Else
            Return Nothing
        End If
        'C:\Windows\Logs\CBS
        'C:\WINDOWS\system32\wbem\Logs

    End Function
    Public Shared Function WindowsErrorReporting()
        'C:\ProgramData\Microsoft\Windows\WER
        Dim WER As String
        WER = SpecialFoldersandDrives.OsInstalledDrive & "\ProgramData\Microsoft\Windows\WER"
        Dim WERex As Boolean
        WERex = IO.Directory.Exists(WER)
        If WERex = True Then
            Return WER
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function WindowsErrorReporting2()
        'C:\Users\Aravindh\AppData\Local\Microsoft\Windows\WER\ReportQueue\NonCritical_devenv.exe_1bc04e2d453133bd90ca7c8270cfb6ed2b3493e8_cab_10ed7233
        Dim werfol As String
        werfol = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Windows\WER"
        Dim werfolex As Boolean
        werfolex = IO.Directory.Exists(werfol)
        If werfolex = True Then
            Return werfol
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function WindowsMediaPlayerArtCac()
        'C:\Users\Aravindh\AppData\Local\Microsoft\Media Player\Art Cache\LocalMLS
        Dim artcac As String
        artcac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Media Player\Art Cache\LocalMLS"
        Dim artcacex As Boolean
        artcacex = IO.Directory.Exists(artcac)
        If artcacex = True Then
            Return artcac
        Else
            Return Nothing
        End If
    End Function
    'Public Shared Function WindowsMediaPlayerCache()
    '    'C:\Users\Aravindh\AppData\Local\Microsoft\Media Player\Cache1314870
    '    Dim wmpcac As String
    '    wmpcac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Media Player\"
    '    For Each foldinfold In Directory.GetDirectories(wmpcac)
    '        If foldinfold = wmpcac & "Cache" Then
    '            MsgBox("true")
    '        End If
    '        'MsgBox(foldinfold.StartsWith("Cache"))
    '        'If IO.Path.GetDirectoryName(foldinfold).ToString.StartsWith("Cache") Then
    '        '    MsgBox("True")
    '        '    'If Directory.Exists(foldinfold) = True Then
    '        '    '    MsgBox("true")
    '        '    '    Return foldinfold
    '        '    '    'Else
    '        '    '    MsgBox("false")
    '        '    '    Return Nothing
    '        '    'End If
    '        'Else
    '        ''Return Nothing
    '        'End If
    '    Next
    '    Return Nothing
    'End Function
    Public Shared Function WEThumbCache()
        'C:\Users\Aravindh\AppData\Local\Microsoft\Windows\Explorer
        Dim thumbcache As String
        thumbcache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Microsoft\Windows\Explorer"
        Dim thumbcacheex As Boolean
        thumbcacheex = IO.Directory.Exists(thumbcache)
        If thumbcacheex = True Then
            Return thumbcache
        Else
            Return Nothing
        End If
    End Function
End Class
Public Class SoftCache
    Public Shared Function freemake()
        Dim freemakecac As String
        Dim freemakecacex As String
        'C:\ProgramData\Freemake\FreemakeVideoConverter
        freemakecac = SpecialFoldersandDrives.OsInstalledDrive & "\ProgramData\Freemake\FreemakeVideoConverter"
        freemakecacex = IO.Directory.Exists(freemakecac)
        If freemakecacex = True Then
            Return freemakecac
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function FlashCache()
        'C:\Users\Aravindh\AppData\Roaming\Macromedia\Flash Player\macromedia.com\support\flashplayer\sys
        Dim flashcac As String
        flashcac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Macromedia\Flash Player\macromedia.com\support\flashplayer\sys"
        Dim flashcacex As Boolean
        flashcacex = IO.Directory.Exists(flashcac)
        If flashcacex = True Then
            Return flashcac
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function FlashCacheOthers()
        'C:\Users\Aravindh\AppData\Roaming\Macromedia\Flash Player\#SharedObjects
        Dim flashCacOth As String
        flashCacOth = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Macromedia\Flash Player\#SharedObjects"
        Dim flashcacothex As Boolean
        flashcacothex = IO.Directory.Exists(flashCacOth)
        If flashcacothex = True Then
            Return flashCacOth
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function UTrrntOldFls()
        Dim utrr As String
        Dim utrrxp As String
        utrr = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\uTorrent"
        'c:\DocumentsandSettings\Arvin Soft Test\ApplicationData\Utorrent
        utrrxp = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Application Data\uTorrent"
        Dim utrrxpex As Boolean
        Dim utrrex As Boolean
        utrrex = IO.Directory.Exists(utrr)
        utrrxpex = IO.Directory.Exists(utrrxp)
        If utrrex = True Then
            Return utrr
        ElseIf utrrxpex = True Then
            Return utrrxp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function OfficeRecent()
        'C:\Users\Aravindh\AppData\Roaming\Microsoft\Office\Recent
        Dim offrec As String
        offrec = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Microsoft\Office\Recent"
        Dim offrecex As Boolean
        offrecex = IO.Directory.Exists(offrec)
        If offrecex = True Then
            Return offrec
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function NotepadplusplusSes()
        'C:\Users\Aravindh\AppData\Roaming\Notepad++
        'C:\Documents and Settings\Arvin Soft Test\Application Data\Notepad++
        Dim notepadPluPlu As String
        Dim notepadPluPluxp As String
        notepadPluPlu = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\Notepad++"
        notepadPluPluxp = SpecialFoldersandDrives.OsInstalledDrive & "\Documents and Settings" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\Application Data\Notepad++"
        Dim notepadplupluex As Boolean
        Dim notepadplupluxpex As Boolean
        notepadplupluxpex = IO.Directory.Exists(notepadPluPluxp)
        notepadplupluex = IO.Directory.Exists(notepadPluPlu)
        If notepadplupluex = True Then
            Return notepadPluPlu
        ElseIf notepadplupluxpex = True Then
            Return notepadPluPluxp
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function EvernoteLogs()
        'C:\Users\Aravindh\AppData\Local\Evernote\Evernote\Logs
        Dim evernotelgs As String
        evernotelgs = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Evernote\Evernote\Logs"
        Dim evernotelogsex As Boolean
        evernotelogsex = IO.Directory.Exists(evernotelgs)
        If evernotelogsex = True Then
            Return evernotelgs
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetIDM()
        'C:\Users\Aravindh\AppData\Roaming\IDM
        Dim IDM As String
        IDM = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\IDM"
        Dim IDMex As Boolean
        IDMex = IO.Directory.Exists(IDM)
        If IDMex = True Then
            Return IDM
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetAdobeSearch()
        'C:\Users\Aravindh\AppData\LocalLow\Adobe\Acrobat\11.0\Search
        Dim AdbSrc As String
        AdbSrc = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\LocalLow\Adobe\Acrobat\11.0\Search"
        Dim AdbSrcex As Boolean
        AdbSrcex = IO.Directory.Exists(AdbSrc)
        If AdbSrcex = True Then
            Return AdbSrc
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetAdobeCache()
        'C:\Users\Aravindh\AppData\Local\Adobe\Acrobat\11.0\Cache
        Dim AdbCac As String
        AdbCac = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Adobe\Acrobat\11.0\Cache"
        Dim AdbCacex As Boolean
        AdbCacex = IO.Directory.Exists(AdbCac)
        If AdbCacex = True Then
            Return AdbCac
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetAxcilIconWork()
        'C:\Users\Aravindh\AppData\Local\Axialis\Temporary Preview Files
        Dim axiconwork As String
        axiconwork = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Axialis\Temporary Preview Files"
        Dim axiconworkex As Boolean
        axiconworkex = IO.Directory.Exists(axiconwork)
        If axiconworkex = True Then
            Return axiconwork
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetQuickTime()
        'C:\Users\Aravindh\AppData\Local\Apple Computer\QuickTime
        Dim quick As String
        quick = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Local\Apple Computer\QuickTime"
        Dim quickex As Boolean
        quickex = IO.Directory.Exists(quick)
        If quickex = True Then
            Return quick
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetVLCMediaPlayerArtCache()
        Dim vlcartcache
        vlcartcache = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\Roaming\vlc\art"
        Dim vlcartcacheex As Boolean
        vlcartcacheex = Directory.Exists(vlcartcache)
        If vlcartcacheex = True Then
            Return vlcartcache
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function GetQuickTimeLocalLow()
        Dim quicklow
        quicklow = SpecialFoldersandDrives.OsInstalledDrive & "\Users" & My.User.Name.Remove(0, My.Computer.Name.Length) & "\AppData\LocalLow\Apple Computer\QuickTime\downloads"
        Dim quicklowex As Boolean
        quicklowex = IO.Directory.Exists(quicklow)
        If quicklowex = True Then
            Return quicklow
        Else
            Return Nothing
        End If
    End Function
End Class

'C:\Users\Aravindh\AppData\Roaming\uTorrent
Public Class cpinfo

    Enum cpuType As UInt16

        x86 = 0
        Mips = 1
        Alpha = 2
        Powerpc = 3
        IA64 = 6 'Intel_Itanium_
        x64 = 9 'AMD64 or Intel64 (Which is really AMD64 anyways).

    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SYSTEM_INFO
        Public wProcessorArchitecture As cpuType
        Public wReserved As UInt16
        Public dwPageSize As UInt32
        Public lpMinimumApplicationAddress As IntPtr
        Public lpMaximumApplicationAddress As IntPtr
        Public dwActiveProcessorMask As UIntPtr
        Public dwNumberOfProcessors As UInt32
        Public dwProcessorType As UInt32
        Public dwAllocationGranularity As UInt32
        Public wProcessorLevel As UInt16
        Public wProcessorRevision As UInt16
    End Structure

    '
    'The API call for using the GetSystemInfo method.
    Private Declare Auto Sub GetSystemInfo Lib "kernel32.dll" (ByRef lpSystemInfo As  _
        SYSTEM_INFO)
    '
    'The api call to get the native mode of the os.
    Private Declare Sub GetNativeSystemInfo Lib "kernel32" (ByRef lpSystemInfo As SYSTEM_INFO)
    Public Shared crashmessagebitness As String
    Public Shared apionSysbitness As Boolean
    Public Shared Function getOsBitness()
        Try
            '
            'I will only care about the first item from this structure.
            Dim sysInfo As SYSTEM_INFO

            GetNativeSystemInfo(sysInfo)
            'MsgBox(sysInfo.wProcessorArchitecture.ToString)
            Dim type = sysInfo.wProcessorArchitecture.ToString
            If type = "x86" Then
                Return "32"
            ElseIf type = "x64" Then
                Return "64"
            Else
                Return "Unknown"
            End If

        Catch exc As Exception
            apionSysbitness = True
            crashmessagebitness = exc.Message
            'MessageBox.Show(exc.Message, "  We have a SysInfo API problem...", MessageBoxButtons.OK)

            Return "Unknown"
        End Try
    End Function
    
End Class
Public Class DialogBoxes
    Public Shared Function yesno(ByVal sStr As String, ByVal sTitle As String, ByVal sVal As String)
        Dim sRet
        If sVal = "FUNCTOID_MESSAGEICON_INFORMATION" Then
            sRet = MsgBox(sStr, vbYesNo + MsgBoxStyle.Information, sTitle)
            Return sRet
        ElseIf sVal = "FUNCTOID_MESSAGEICON_QUESTION" Then
            sRet = MsgBox(sStr, vbYesNo + MsgBoxStyle.Question, sTitle)
            Return sRet
        ElseIf sVal = "FUNCTOID_MESSAGE_ICON_EXCLAMATION" Then
            sRet = MsgBox(sStr, vbYesNo + MsgBoxStyle.Exclamation, sTitle)
            Return sRet
        ElseIf sVal = "FUNCTOID_MESSAGE_ICONCRITICAL" Then
            sRet = MsgBox(sStr, vbYesNo + MsgBoxStyle.Critical, sTitle)
            Return sRet
        Else
            MsgBox("Sorry DLL error Contact your product Manufacturer", vbOKOnly + MsgBoxStyle.Critical, "Error")
        End If
        Return Nothing
    End Function
    Public Shared Function okonly(ByVal sStr As String, ByVal sTitle As String, ByVal sVal As String)
        Return Nothing
    End Function
End Class
'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyleft (C) 2012-2013 A-Soft. All Rights Reserved.                      #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyleft (C) 2010-2013 Arvin Soft. All Rights Reserved.                      #
'##############################################################################################