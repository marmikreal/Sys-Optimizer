Imports System.Xml
Imports System.IO
Imports Functiod.Cache
Imports Functiod
Public Class InternetFiles
    '############################################################################################################
    '#          Analyse function to retrieve the temp files from the computer using the functiod.dll            #
    '#                    Copyright (C) 2010 - 2013 Arvin Soft. All Rights Reserved.                            #
    '#                   Copyright (C) 2010-2013 Arvive Systems. All Rights Reserved.                           #
    '#                Copyright (C) 2012-2013 Arvive Software Solutions. All Rights Reserved.                   #
    '#                     Copyright (C) 2014 Citrus Labs India. All Rights Reserved.                           #
    '############################################################################################################
    '********************************************************************************************************************
    '*     Analyse class retrieve files from the temp folder using libRetrieve.vb from Funtiod.dll and perform          *
    '*                           the scan for item command in the main program                                          *
    '*              Please don't modify the code below if you don't know what you are doing                             *
    '*                         Product of Arvive Software Solutions for Arvin Soft                                      *
    '*                         Product of Citrus Labs India and Citrus Software Development Group                       *
    '********************************************************************************************************************
    ' Thanks to Manuel Alves of stackoverflow.com for providing the code below
    ' Thanks for making sys optimizer a best software Manuel Alves'
    ' The Function FileInUse is provided by Manuel Alves'
    Public Shared sizedother As Integer = 0
    Public Shared errormessage As String
    Public Shared Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function
    ' Thanks to Manuel Alves of stackoverflow.com for providing the code Above
    ' Thanks for making sys optimizer a best software Manuel Alves'
    ' The Function FileInUse is provided by Manuel Alves'
    Delegate Sub AddListItem_Delegate(ByVal [Label] As ListView, ByVal icn As Integer, ByVal [text] As String)
    Private Sub AddListItem(ByVal [ListView] As ListView, ByVal icn As Integer, ByVal [text] As String, Optional ByVal [text2] As String = "")
        If [ListView].InvokeRequired Then
            Dim MyDelegate As New AddListItem_Delegate(AddressOf AddListItem)
            Me.Invoke(MyDelegate, New Object() {[ListView], [icn], [text]})
        Else
            ListView.Items.Add([text], [icn])
        End If
    End Sub
    Delegate Sub AddListSubItem_Delegate(ByVal [Label] As ListView, ByVal [count] As Integer, ByVal [text] As String)
    Private Sub AddListSubItem(ByVal [ListView] As ListView, ByVal [count] As Integer, ByVal [text] As String, Optional ByVal [text2] As String = "")
        If [ListView].InvokeRequired Then
            Dim MyDelegate As New AddListSubItem_Delegate(AddressOf AddListSubItem)
            Me.Invoke(MyDelegate, New Object() {[ListView], [count], [text]})
        Else
            ListView.Items(count).SubItems.Add([text])
        End If
    End Sub
    Public count As Integer = 0
    Public countIE As Integer = 0
    Public countFF As Integer = 0
    Public countChrom As Integer = 0
    Public countOper As Integer = 0
    Public countSafar As Integer = 0
    Public countThunder As Integer = 0
    Public countTemp As Integer = 0
    Public countLog As Integer = 0
    Public ount As Integer = 0
    Public sized As Integer = 0
    Public Function InternetFiles()
        If Functiod.Cache.getInernetFiles <> "" Then
            For Each folded In Directory.GetDirectories(Functiod.Cache.getInernetFiles)
                For Each filed In Directory.GetFiles(folded)
                    If FileInUse(filed) = False Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filed)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'Dim sed
                        'If sSize > 1024 Then
                        '    sed = Math.Round(sinfo.Length / 1024 / 1024, 2) & " MB"
                        '    'MsgBox("exe")
                        'Else
                        '    sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                        '    'MsgBox("exe1")
                        'End If
                        'List.Items.Add(filed, 0)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowIE, 0, filed)
                        Else
                            AddListItem(lstBrowIE, 0, IO.Path.GetFileName(filed))
                        End If
                        AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                        'List.Items(count).SubItems.Add("File")
                        'List.Items(countIE).SubItems.Add(sSize & " KB")
                        countIE += 1
                        sized += sSize
                        'MsgBox(sized)
                        On Error Resume Next
                    End If
                Next
                For Each fod In Directory.GetDirectories(folded)
                    For Each fileinfod In Directory.GetFiles(fod)
                        If FileInUse(fileinfod) = False Then
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfod)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            'Dim sed
                            'If sSize > 1024 Then
                            '    sed = Math.Round(sinfo.Length / 1024 / 1024, 2) & " MB"
                            '    'MsgBox("exe")
                            'Else
                            '    sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                            '    'MsgBox("exe1")
                            'End If
                            'List.Items.Add(fileinfod, 0)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowIE, 0, fileinfod)
                            Else
                                AddListItem(lstBrowIE, 0, IO.Path.GetFileName(fileinfod))
                            End If
                            AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                            'List.Items(count).SubItems.Add("File")
                            'List.Items(countIE).SubItems.Add(sSize & " KB")
                            countIE += 1
                            sized += sSize
                            ' MsgBox(fod & sized)
                        End If
                        On Error Resume Next
                    Next
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function IEDtBs()
        For Each fil In Directory.GetFiles(Functiod.Cache.GetIEDtBses)
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowIE, 0, fil)
            Else
                AddListItem(lstBrowIE, 0, IO.Path.GetFileName(fil))
            End If
            AddListSubItem(lstBrowIE, countIE, sSize & " KB")
            'List.Items.Add(fil, 0)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countIE).SubItems.Add(sSize & " KB")
            countIE += 1
            sized += sSize
        Next
        For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEDtBses)
            For Each fil In Directory.GetFiles(fold)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(fil, 0)
                ''List.Items(count).SubItems.Add("File")

                'List.Items(countIE).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowIE, 0, fil)
                Else
                    AddListItem(lstBrowIE, 0, IO.Path.GetFileName(fil))
                End If
                AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                countIE += 1
                sized += sSize
            Next
        Next
        Return Nothing
    End Function

    Public Function IEFeedsCache()
        If Functiod.Cache.GetIEFeedsCache <> "" Then
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFeedsCache)
                For Each fil In Directory.GetFiles(fold)
                    If IO.Path.GetExtension(fil) <> ".ini" Then
                        'List.Items.Add(fil, 0)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(count).SubItems.Add("File")
                        'List.Items(countIE).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowIE, 0, fil)
                        Else
                            AddListItem(lstBrowIE, 0, IO.Path.GetFileName(fil))
                        End If
                        AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                        countIE += 1
                        sized += sSize
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function GetContentIE5()
        If Functiod.Cache.GetIEFilesContentIE5 <> "" Then
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFilesContentIE5)
                For Each Fls In Directory.GetFiles(fold)
                    If FileInUse(Fls) = False Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(Fls)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(Fls, 0)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countIE).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowIE, 0, Fls)
                        Else
                            AddListItem(lstBrowIE, 0, IO.Path.GetFileName(Fls))
                        End If
                        AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                        countIE += 1
                        sized += sSize
                    End If
                Next
            Next
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFilesContentIE5)
                For Each foldinfold In Directory.GetDirectories(fold)
                    For Each fls In Directory.GetFiles(foldinfold)
                        If FileInUse(fls) = False Then
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fls)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            'List.Items.Add(fls, 0)
                            ''List.Items(count).SubItems.Add("File")
                            'List.Items(countIE).SubItems.Add(sSize & " KB")
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowIE, 0, fls)
                            Else
                                AddListItem(lstBrowIE, 0, IO.Path.GetFileName(fls))
                            End If
                            AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                            countIE += 1
                            sized += sSize
                        End If
                    Next
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function GetContentIE5ex()
        If Functiod.Cache.GetIEFilesContentIE5 <> "" Then
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetIEFilesContentIE5)
                If FileInUse(filinfold) = False Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(filinfold, 0)
                    'List.Items(countIE).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowIE, 0, filinfold)
                    Else
                        AddListItem(lstBrowIE, 0, IO.Path.GetFileName(filinfold))
                    End If
                    AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                    countIE += 1
                    sized += sSize
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Function InternetExFiles()
        If Functiod.Cache.GetIEFiles <> "" Then
            'MsgBox("true")
            For Each files In Directory.GetFiles(Functiod.Cache.GetIEFiles)
                If FileInUse(files) = False Then
                    '   MsgBox(files)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(files)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(files, 0)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countIE).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowIE, 0, files)
                    Else
                        AddListItem(lstBrowIE, 0, IO.Path.GetFileName(files))
                    End If
                    AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                    countIE += 1
                    sized += sSize
                End If
                    ' MsgBox("Internet Ex Files " & Functiod.Cache.GetIEFiles & sized)
            Next
        End If
        Return Nothing
    End Function

    Public Function GetIECookies()
        If Functiod.Cache.GetIECookies <> "" Then
            For Each Fileunfol In Directory.GetFiles(Functiod.Cache.GetIECookies)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(Fileunfol)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(Fileunfol, 0)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countIE).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowIE, 0, Fileunfol)
                Else
                    AddListItem(lstBrowIE, 0, IO.Path.GetFileName(Fileunfol))
                End If
                AddListSubItem(lstBrowIE, countIE, sSize & " KB")
                countIE += 1
                sized += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function OperaStableCacheNew()
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableCacheNew)
            Dim spath
            spath = filinfold
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
            On Error Resume Next
        Next
    End Function
    Public Function OperaStableGPUCachNew()
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableGPUCacheNew)
            Dim spath
            spath = filinfold
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
            On Error Resume Next
        Next
    End Function
    Public Function OperaStableJumpListIconsNew()
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableJumpListIconsNew)
            Dim spath
            spath = filinfold
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
            On Error Resume Next
        Next
    End Function
    Public Function OperaStableJumpListIconOldNew()
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableJumpListIconsOldNew)
            Dim spath
            spath = filinfold
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
            On Error Resume Next
        Next
    End Function
    Public Function OperaStableLocalStorageNew()
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableLocalStorageNew)
            Dim spath
            spath = filinfold
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
            On Error Resume Next
        Next
    End Function

    Public Function OperaCache()
        For Each fold In Directory.GetDirectories(Functiod.Cache.GetOperaCache)
            For Each fileinfold In Directory.GetFiles(fold)
                Dim spath
                spath = fileinfold
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(spath)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(fileinfold, 1)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countOper).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowOper, 1, fileinfold)
                Else
                    AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fileinfold))
                End If
                AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                countOper += 1
                sized += sSize
                On Error Resume Next
            Next
        Next
        For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaCache)
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
            Dim ssize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items.Add(filinfold, 1)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countOper).SubItems.Add(ssize & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, filinfold)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
            End If
            AddListSubItem(lstBrowOper, countOper, ssize & " KB")
            countOper += 1
            sized += ssize
        Next
        For Each fold In Directory.GetDirectories(Functiod.Cache.GetOperaCache)
            For Each fol In Directory.GetDirectories(fold)
                For Each fileinfold In Directory.GetFiles(fol)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(fileinfold, 1)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countOper).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowOper, 1, fileinfold)
                    Else
                        AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fileinfold))
                    End If
                    AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                    countOper += 1
                    sized += sSize
                Next
            Next

        Next
        Return Nothing
    End Function
    Public Function Operasessions()
        If Cache.GetOperaOthers <> "" Then
            For Each fileinfol In Directory.GetFiles(Functiod.Cache.GetOperaOthers & "\Sessions")
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfol)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(fileinfol, 1)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countOper).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowOper, 1, fileinfol)
                Else
                    AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fileinfol))
                End If
                AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                countOper += 1
                sized += sSize
            Next
        End If
        Return Nothing
    End Function

    Public Function OperaCacheVps()
        If Cache.GetOperaStandard <> "" Then
            For Each fol In Directory.GetDirectories(Cache.GetOperaStandard & "\vps")
                For Each filinfold In Directory.GetFiles(fol)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(filinfold, 1)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countOper).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowOper, 1, filinfold)
                    Else
                        AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
                    End If
                    AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                    countOper += 1
                    sized += sSize
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function OperaOpCache()
        If Cache.GetOperaStandard <> "" Then
            Dim OpCache As String
            OpCache = Cache.GetOperaStandard & "\opcache"
            For Each fold In Directory.GetDirectories(OpCache)
                For Each finfold In Directory.GetFiles(fold)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(finfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(finfold, 1)
                    '' List.Items(count).SubItems.Add("File")
                    'List.Items(countOper).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowOper, 1, finfold)
                    Else
                        AddListItem(lstBrowOper, 1, IO.Path.GetFileName(finfold))
                    End If
                    AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                    countOper += 1
                    sized += sSize
                Next
            Next
            For Each fil In Directory.GetFiles(OpCache)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(fil, 1)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countOper).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowOper, 1, fil)
                Else
                    AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fil))
                End If
                AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                countOper += 1
                sized += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function OperaIconCache()
        If Cache.GetOperaStandard <> "" Then
            Dim OpIconCache As String
            OpIconCache = Cache.GetOperaStandard & "\icons\cache"
            Dim opIconCacheex As Boolean = Directory.Exists(OpIconCache)
            If opIconCacheex = True Then
                For Each fold In Directory.GetDirectories(OpIconCache)
                    For Each filinfold In Directory.GetFiles(fold)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 1)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countOper).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowOper, 1, filinfold)
                        Else
                            AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
                        End If

                        AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                        countOper += 1
                        sized += sSize
                    Next
                Next
                For Each fil In Directory.GetFiles(OpIconCache)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(fil, 1)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countOper).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowOper, 1, fil)
                    Else
                        AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fil))
                    End If
                    AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                    countOper += 1
                    sized += sSize
                Next
            End If
        End If
        If Cache.GetOperaStandard <> "" Then
            Dim OpIconFol As String
            OpIconFol = Cache.GetOperaStandard & "\icons"
            Dim opIconFolex As Boolean
            opIconFolex = Directory.Exists(OpIconFol)
            If opIconFolex = True Then
                For Each filinfold In Directory.GetFiles(OpIconFol)
                    If IO.Path.GetExtension(filinfold) = ".idx" Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 1)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countOper).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowOper, 1, filinfold)
                        Else
                            AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                        countOper += 1
                        sized += sSize
                    End If
                    If IO.Path.GetExtension(filinfold) = ".png" Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 1)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countOper).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowOper, 1, filinfold)
                        Else
                            AddListItem(lstBrowOper, 1, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                        countOper += 1
                        sized += sSize
                    End If
                Next
            End If
        End If

        Return Nothing
    End Function
    Public Function OperaTemp_Down()
        'temporary_downloads
        Dim opTempDown As String
        opTempDown = Cache.GetOperaStandard & "\temporary_downloads"
        Dim opTempDownex As Boolean
        opTempDownex = Directory.Exists(opTempDown)
        If opTempDownex = True Then
            For Each fileinfold In Directory.GetFiles(opTempDown)
                If IO.Path.GetExtension(fileinfold) = ".exe" Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(fileinfold, 1)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countOper).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowOper, 1, fileinfold)
                    Else
                        AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fileinfold))
                    End If
                    AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                    countOper += 1
                    sized += sSize
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Function OperaJmpLstIcnCache()
        'jumplist_icon_cache
        Dim opJmpLstIconCache As String
        opJmpLstIconCache = Cache.GetOperaStandard & "\jumplist_icon_cache"
        Dim opJmpLstIconCacheex As Boolean
        opJmpLstIconCacheex = IO.Directory.Exists(opJmpLstIconCache)
        If opJmpLstIconCacheex = True Then
            For Each fil In Directory.GetFiles(opJmpLstIconCache)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(fil, 1)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countOper).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowOper, 1, fil)
                Else
                    AddListItem(lstBrowOper, 1, IO.Path.GetFileName(fil))
                End If
                AddListSubItem(lstBrowOper, countOper, sSize & " KB")
                countOper += 1
                sized += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function OperaTypedHstry()
        Dim OperaTypedHstryfl As String
        OperaTypedHstryfl = Cache.GetOperaOthers & "\typed_history.xml"
        Dim OperaTypedHstryflex As Boolean
        OperaTypedHstryflex = File.Exists(OperaTypedHstryfl)
        If OperaTypedHstryflex = True Then
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(OperaTypedHstryfl)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items.Add(OperaTypedHstryfl, 1)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countOper).SubItems.Add(sSize & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, OperaTypedHstryfl)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(OperaTypedHstryfl))
            End If
            AddListSubItem(lstBrowOper, countOper, sSize & " KB")
            countOper += 1
            sized += sSize
        End If
        Return Nothing
    End Function
    Public Shared Function GetFileSize(ByVal FilName As String)
        Dim sinfo = My.Computer.FileSystem.GetFileInfo(FilName)
        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
        Return sSize
    End Function
    Public Function OperaOthers()
        Dim operadownloads As String
        operadownloads = Cache.GetOperaOthers & "\Download.dat"
        If File.Exists(operadownloads) = True Then
            'List.Items.Add(operadownloads, 1)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countOper).SubItems.Add(GetFileSize(operadownloads) & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, operadownloads)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(operadownloads))
            End If
            AddListSubItem(lstBrowOper, countOper, GetFileSize(operadownloads) & " KB")
            countOper += 1
            sized += GetFileSize(operadownloads)
        End If
        Dim operaglobalhis As String
        operaglobalhis = Cache.GetOperaOthers & "\global_history.dat"
        If File.Exists(operaglobalhis) = True Then
            'List.Items.Add(operaglobalhis, 1)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countOper).SubItems.Add(GetFileSize(operaglobalhis) & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, operaglobalhis)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(operaglobalhis))
            End If
            AddListSubItem(lstBrowOper, countOper, GetFileSize(operaglobalhis) & " KB")
            countOper += 1
            sized += GetFileSize(operaglobalhis)
        End If
        Dim vlink As String
        vlink = Cache.GetOperaOthers & "\vlink4.dat"
        If File.Exists(vlink) = True Then
            'List.Items.Add(vlink, 1)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countOper).SubItems.Add(GetFileSize(vlink) & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowOper, 1, vlink)
            Else
                AddListItem(lstBrowOper, 1, IO.Path.GetFileName(vlink))
            End If
            AddListSubItem(lstBrowOper, countOper, GetFileSize(vlink) & " KB")
            countOper += 1
            sized += GetFileSize(vlink)
        End If
        Return Nothing
    End Function
    Public Function ThunderbirdCache()
        For Each Cached In Directory.GetDirectories(Functiod.Cache.GetThunderbirdCache)
            Dim deis
            deis = Directory.Exists(Cached & "\Cache")
            If deis = True Then
                For Each fold In Directory.GetDirectories(Cached & "\Cache")
                    For Each foldinfold In Directory.GetDirectories(fold)
                        For Each fileinfold In Directory.GetFiles(foldinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            'List.Items.Add(fileinfold, 3)
                            ''List.Items(count).SubItems.Add("File")
                            'List.Items(countThunder).SubItems.Add(sSize & " KB")
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowThunder, 3, fileinfold)
                            Else
                                AddListItem(lstBrowThunder, 3, IO.Path.GetFileName(fileinfold))
                            End If
                            AddListSubItem(lstBrowThunder, countThunder, sSize & " KB")
                            countThunder += 1
                            sized += sSize
                        Next
                    Next
                Next
                For Each files In Directory.GetFiles(Cached & "\Cache")
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(files)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(files, 3)
                    '' List.Items(count).SubItems.Add("File")
                    'List.Items(countThunder).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowThunder, 3, files)
                    Else
                        AddListItem(lstBrowThunder, 3, IO.Path.GetFileName(files))
                    End If
                    AddListSubItem(lstBrowThunder, countThunder, sSize & " KB")
                    countThunder += 1
                    sized += sSize
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Function GetThunderbirdSes()
        For Each cacdir In Directory.GetDirectories(Functiod.Cache.GetThunderbirdSes)
            Dim name As String = cacdir & "\Session.json"
            If File.Exists(name) = True Then
                'List.Items.Add(name, 3)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(name)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(count).SubItems.Add("File")
                'List.Items(countThunder).SubItems.Add(sSize & " Kb")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowThunder, 3, name)
                Else
                    AddListItem(lstBrowThunder, 3, IO.Path.GetFileName(name))
                End If
                AddListSubItem(lstBrowThunder, countThunder, sSize & " KB")
                countThunder += 1
                sized += sSize
            End If
        Next
        Return Nothing
    End Function
    Public Function FirefoxCache()
        Try
            For Each cache In Directory.GetDirectories(Functiod.Cache.GetFirefoxCache)
                Dim sexis
                If Directory.Exists(cache & "\Cache") = True Then
                    cache = cache & "\Cache"
                ElseIf Directory.Exists(cache & "\Cache2") = True Then
                    cache = cache & "\Cache2"
                End If
                sexis = Directory.Exists(cache)
                If sexis = True Then
                    For Each folder In Directory.GetDirectories(cache)
                        For Each foldinfold In Directory.GetDirectories(folder)
                            For Each foldin In Directory.GetFiles(foldinfold)
                                Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldin)
                                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                'List.Items.Add(foldin, 2)
                                ''List.Items(count).SubItems.Add("File")
                                'List.Items(countFF).SubItems.Add(sSize & " KB")
                                If My.Settings.disas = "0" Then
                                    AddListItem(lstBrowFF, 2, foldin)
                                Else
                                    AddListItem(lstBrowFF, 2, IO.Path.GetFileName(foldin))
                                End If
                                AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                                'MsgBox("hello")
                                countFF += 1
                                sized += sSize
                            Next
                        Next
                    Next
                    For Each foldinfold In Directory.GetDirectories(cache)
                        For Each filinfold In Directory.GetFiles(foldinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowFF, 2, filinfold)
                            Else
                                AddListItem(lstBrowFF, 2, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                            'MsgBox("en")
                            countFF += 1
                            sized += sSize
                        Next
                    Next
                    For Each files In Directory.GetFiles(cache)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(files)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(files, 2)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countFF).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowFF, 2, files)
                        Else
                            AddListItem(lstBrowFF, 2, IO.Path.GetFileName(files))
                        End If
                        AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                        countFF += 1
                        sized += sSize
                        ' On Error Resume Next
                    Next
                    'For Each folder In Directory.GetDirectories(cache & "\Cache")
                    '    List.Items.Add(folder)
                    '    On Error Resume Next
                    'Next
                    For Each filess In Directory.GetFiles(cache)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filess)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filess, 2)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countFF).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowFF, 2, filess)
                        Else
                            AddListItem(lstBrowFF, 2, IO.Path.GetFileName(filess))
                        End If
                        AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                        countFF += 1
                        sized += sSize
                        ' On Error Resume Next
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    Public Function FirefoxWebThumb()
        For Each cache In Directory.GetDirectories(Functiod.Cache.GetFirefoxCache)
            'C:\Users\Aravindh\AppData\Local\Mozilla\Firefox\Profiles\jftl47mb.default-1370183395194\thumbnails
            Dim sexis
            sexis = cache & "\thumbnails"
            If Directory.Exists(sexis) = True Then
                For Each fileinfold In Directory.GetFiles(sexis)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(fileinfold, 2)
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, fileinfold)
                    Else
                        AddListItem(lstBrowFF, 2, IO.Path.GetFileName(fileinfold))
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Function FirefoxMiscillaneous()
        If Functiod.Cache.GetFirefoxMiscl <> "" Then
            For Each Direct In Directory.GetDirectories(Functiod.Cache.GetFirefoxMiscl)
                If File.Exists(Direct & "\downloads.sqlite") = True Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Direct & "\downloads.sqlite")
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(Direct & "\downloads.sqlite", 2)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, Direct & "\downloads.sqlite")
                    Else
                        AddListItem(lstBrowFF, 2, "downloads.sqlite")
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                End If
                If File.Exists(Direct & "\sessionstore.js") = True Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Direct & "\sessionstore.js")
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(Direct & "\sessionstore.js", 2)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, Direct & "\sessionstore.js")
                    Else
                        AddListItem(lstBrowFF, 2, "sessionstore.js")
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                End If
                If File.Exists(Direct & "\sessionstore.bak") = True Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Direct & "\sessionstore.bak")
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(Direct & "\sessionstore.bak", 2)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, Direct & "\sessionstore.bak")
                    Else
                        AddListItem(lstBrowFF, 2, "sessionstore.bak")
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                End If
                'content-prefs.sqlite
                If File.Exists(Direct & "\content-prefs.sqlite") = True Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Direct & "\content-prefs.sqlite")
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(Direct & "\content-prefs.sqlite", 2)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, Direct & "\content-prefs.sqlite")
                    Else
                        AddListItem(lstBrowFF, 2, "content-prefs.sqlite")
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                End If
                If File.Exists(Direct & "\places.sqlite") = True Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Direct & "\places.sqlite")
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(Direct & "\places.sqlite", 2)
                    ''List.Items(count).SubItems.Add("File")
                    'List.Items(countFF).SubItems.Add(sSize & " KB")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstBrowFF, 2, Direct & "\places.sqlite")
                    Else
                        AddListItem(lstBrowFF, 2, "places.sqlite")
                    End If
                    AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                    countFF += 1
                    sized += sSize
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Function FirefoxJmpLstIcons()
        If Functiod.Cache.GetFirefoxJumpLst <> "" Then
            For Each cached In Directory.GetDirectories(Functiod.Cache.GetFirefoxJumpLst)
                Dim sexis
                sexis = IO.Directory.Exists(cached & "\jumpListCache")
                If sexis = True Then
                    'MsgBox("exisits")
                    For Each fileinfold In Directory.GetFiles(cached & "\jumpListCache")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(fileinfold, 2)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countFF).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowFF, 2, fileinfold)
                        Else
                            AddListItem(lstBrowFF, 2, IO.Path.GetFileName(fileinfold))
                        End If
                        AddListSubItem(lstBrowFF, countFF, sSize & " KB")
                        countFF += 1
                        sized += sSize
                    Next
                End If
            Next

        End If
        Return Nothing
    End Function
    Public Function ChromeCache()
        If Directory.Exists(Functiod.Cache.GetChromeCache) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeCache)
                'MsgBox(" asdfasdf " & foldinfold)
                'For Each foldinfold1 In Directory.GetDirectories(foldinfold)
                'MsgBox(foldinfold1)
                If Directory.Exists(foldinfold & "\Cache") = True Then
                    For Each filinfold In Directory.GetFiles(foldinfold & "\Cache")
                        'If Directory.Exists(foldinfold & "\Cache") Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 4)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, filinfold)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")

                        countChrom += 1
                        sized += sSize
                        On Error Resume Next
                        'End If
                    Next
                End If
                'Next
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryCache()
        If Directory.Exists(Functiod.Cache.GetCanaryCache) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryCache)
                If Directory.Exists(foldinfold & "\Cache") = True Then
                    For Each canary In Directory.GetFiles(foldinfold & "\Cache")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(canary)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(canary, 4)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, canary)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(canary))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryGPUCache()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each filinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each fold In Directory.GetDirectories(filinfold)
                    If IO.Path.GetFileNameWithoutExtension(fold) = "GPUCache" Then
                        ' MsgBox("e")
                        For Each fil In Directory.GetFiles(fold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, fil)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fil))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function ChromeGPUCache()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each filinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each fold In Directory.GetDirectories(filinfold)
                    If IO.Path.GetFileNameWithoutExtension(fold) = "GPUCache" Then
                        For Each fil In Directory.GetFiles(fold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, fil)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fil))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function ChromeLocalStore()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "Local Storage" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, filinfold)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function ChromeJumplisticons()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "JumpListIcons" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, filinfold)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryJumplisticons()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "JumpListIcons" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, filinfold)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryLocalStore()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "Local Storage" Then
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, filinfold)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                            countChrom += 1
                            sized += sSize
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function ChromeMediaCache()
        If Directory.Exists(Functiod.Cache.GetChromeMediaCache) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeMediaCache)
                If Directory.Exists(foldinfold & "\Media Cache") = True Then
                    For Each filinfold In Directory.GetFiles(foldinfold & "\Media Cache")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 4)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, filinfold)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                        On Error Resume Next
                    Next
                End If
            Next
        End If
    End Function
    Public Function CanaryMediaCache()
        If Directory.Exists(Functiod.Cache.GetCanaryMediaCache) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryMediaCache)
                If Directory.Exists(foldinfold & "\Media Cache") = True Then
                    For Each filinfold In Directory.GetFiles(foldinfold & "\Media Cache")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(filinfold, 4)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, filinfold)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryJournalFiles()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    If filinfold.EndsWith("journal") = True Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, filinfold)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function CanaryOthers()
        Try
            If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
                For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                    Dim month As String
                    month = My.Computer.Clock.LocalTime.Month
                    If month < 10 Then
                        month = "0" & month
                    End If
                    Dim hist = File.Exists(foldinfold & "\History")
                    Dim archist = File.Exists(foldinfold & "\Archived History")
                    Dim vislnks = File.Exists(foldinfold & "\Visited Links")
                    Dim currenttab = File.Exists(foldinfold & "\Current Tabs")
                    Dim lasttab = File.Exists(foldinfold & "\Last Tabs")
                    Dim currentses = File.Exists(foldinfold & "\Current Session")
                    Dim lasses = File.Exists(foldinfold & "\Last Session")
                    If lasses = True Then
                        'List.Items.Add(foldinfold & "\Last Session", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Last Session")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Last Session")
                        Else
                            AddListItem(lstBrowChrom, 4, "Last Session")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If currentses = True Then
                        'List.Items.Add(foldinfold & "\Current Session", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Current Session")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Current Session")
                        Else
                            AddListItem(lstBrowChrom, 4, "Current Session")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If archist = True Then
                        'List.Items.Add(foldinfold & "\Archived History", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Archived History")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Archived History")
                        Else
                            AddListItem(lstBrowChrom, 4, "Archived History")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If vislnks = True Then
                        'List.Items.Add(foldinfold & "\Visited Links", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Visited Links")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Visited Links")
                        Else
                            AddListItem(lstBrowChrom, 4, "Visited Links")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If currenttab = True Then
                        'List.Items.Add(foldinfold & "\Current Tabs", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Current Tabs")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Current Tabs")
                        Else
                            AddListItem(lstBrowChrom, 4, "Current Tabs")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If lasttab = True Then
                        'List.Items.Add(foldinfold & "\Last Tabs", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Last Tabs")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Last Tabs")
                        Else
                            AddListItem(lstBrowChrom, 4, "Last Tabs")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If hist = True Then
                        'List.Items.Add(foldinfold & "\History", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\History")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\History")
                        Else
                            AddListItem(lstBrowChrom, 4, "History")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    For Each fls In Directory.GetFiles(foldinfold)
                        'MsgBox(fls)
                        Dim nm = IO.Path.GetFileName(fls)
                        If nm.ToString.StartsWith("History Index") = True And nm.ToString.EndsWith("l") = False Then
                            'MsgBox(fls)
                            Dim sdinfo = My.Computer.FileSystem.GetFileInfo(fls)
                            Dim sSizes = Math.Round(sdinfo.Length / 1024, 2)
                            'List.Items.Add(fls, 4)
                            'List.Items(countChrom).SubItems.Add(sSizes & " KB")
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, fls)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fls))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSizes & " KB")
                            countChrom += 1
                            sized += sSizes

                        End If
                    Next
                    For Each flsinfolder In Directory.GetFiles(foldinfold & "\JumpListIcons")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(flsinfolder)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(flsinfolder, 4)
                        'List.Items(count).SubItems.Add("File")
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, flsinfolder)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(flsinfolder))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                    For Each fileinfd In Directory.GetFiles(foldinfold & "\JumpListIconsOld")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfd)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(fileinfd, 4)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, fileinfd)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fileinfd))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                Next
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Function ChromeJournalFiles()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    If filinfold.EndsWith("journal") = True Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, filinfold)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function ChromeOthers()
        Try
            If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
                For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                    ' MsgBox(foldinfold)
                    'If Directory.Exists(foldinfold) = True Then
                    Dim month As String
                    month = My.Computer.Clock.LocalTime.Month
                    If month < 10 Then
                        month = "0" & month
                    End If
                    'Dim histin = File.Exists(Functiod.Cache.GetChromeothers & "\History Index " & My.Computer.Clock.LocalTime.Year & "-" & month)
                    Dim hist = File.Exists(foldinfold & "\History")
                    Dim archist = File.Exists(foldinfold & "\Archived History")
                    Dim vislnks = File.Exists(foldinfold & "\Visited Links")
                    Dim currenttab = File.Exists(foldinfold & "\Current Tabs")
                    Dim lasttab = File.Exists(foldinfold & "\Last Tabs")
                    Dim CurrentSes = File.Exists(foldinfold & "\Current Session")
                    Dim lastSes = File.Exists(foldinfold & "\Last Session")
                    Dim dirjmplst = Directory.Exists(foldinfold & "\JumpListIcons")
                    Dim dirjmplstold = Directory.Exists(foldinfold & "\JumpListIconsOld")

                    If lastSes = True Then
                        'List.Items.Add(foldinfold & "\Last Session", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Last Session")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Last Session")
                        Else
                            AddListItem(lstBrowChrom, 4, "Last Session")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If CurrentSes = True Then
                        'List.Items.Add(foldinfold & "\Current Session", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Current Session")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Current Session")
                        Else
                            AddListItem(lstBrowChrom, 4, "Current Session")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If archist = True Then
                        'List.Items.Add(foldinfold & "\Archived History", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Archived History")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Archived History")
                        Else
                            AddListItem(lstBrowChrom, 4, "Archived History")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If vislnks = True Then
                        'List.Items.Add(foldinfold & "\Visited Links", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Visited Links")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Visited Links")
                        Else
                            AddListItem(lstBrowChrom, 4, "Visited Links")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If currenttab = True Then
                        'List.Items.Add(foldinfold & "\Current Tabs", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Current Tabs")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Current Tabs")
                        Else
                            AddListItem(lstBrowChrom, 4, "Current Tabs")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If lasttab = True Then
                        'List.Items.Add(foldinfold & "\Last Tabs", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\Last Tabs")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\Last Tabs")
                        Else
                            AddListItem(lstBrowChrom, 4, "Last Tabs")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    If hist = True Then
                        'List.Items.Add(foldinfold & "\History", 4)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(foldinfold & "\History")
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, foldinfold & "\History")
                        Else
                            AddListItem(lstBrowChrom, 4, "History")
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    End If
                    For Each fls In Directory.GetFiles(foldinfold)
                        'MsgBox(fls)
                        Dim nm = IO.Path.GetFileName(fls)
                        If nm.ToString.StartsWith("History Index") = True And nm.ToString.EndsWith("l") = False Then
                            'MsgBox(fls)
                            Dim sdinfo = My.Computer.FileSystem.GetFileInfo(fls)
                            Dim sSizes = Math.Round(sdinfo.Length / 1024, 2)
                            'List.Items.Add(fls, 4)
                            'List.Items(countChrom).SubItems.Add(sSizes & " KB")
                            If My.Settings.disas = "0" Then
                                AddListItem(lstBrowChrom, 4, fls)
                            Else
                                AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fls))
                            End If
                            AddListSubItem(lstBrowChrom, countChrom, sSizes & " KB")
                            countChrom += 1
                            sized += sSizes

                        End If
                    Next
                    For Each flsinfolder In Directory.GetFiles(foldinfold & "\JumpListIcons")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(flsinfolder)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(flsinfolder, 4)
                        'List.Items(count).SubItems.Add("File")
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, flsinfolder)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(flsinfolder))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                    For Each fileinfd In Directory.GetFiles(foldinfold & "\JumpListIconsOld")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfd)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items.Add(fileinfd, 4)
                        ''List.Items(count).SubItems.Add("File")
                        'List.Items(countChrom).SubItems.Add(sSize & " KB")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstBrowChrom, 4, fileinfd)
                        Else
                            AddListItem(lstBrowChrom, 4, IO.Path.GetFileName(fileinfd))
                        End If
                        AddListSubItem(lstBrowChrom, countChrom, sSize & " KB")
                        countChrom += 1
                        sized += sSize
                    Next
                Next
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Function safariwebpagepre()
        For Each safariweb In Directory.GetFiles(Functiod.Cache.GetSafariWebpagePreviews)
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(safariweb)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'list.Items.Add(safariweb, 5)
            '' list.Items(count).SubItems.Add("File")
            'List.Items(countSafar).SubItems.Add(sSize & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowSaf, 5, safariweb)
            Else
                AddListItem(lstBrowSaf, 5, IO.Path.GetFileName(safariweb))
            End If
            AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
            countSafar += 1
            sized += sSize
            On Error Resume Next
        Next
        Return Nothing
    End Function
    Public Function safarihistory()
        For Each safarihis In Directory.GetFiles(Functiod.Cache.GetSafariHistory)
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(safarihis)
            Dim sSize = sinfo.Length
            'List.Items.Add(safarihis, 5)
            ''List.Items(count).SubItems.Add("File")
            'List.Items(countSafar).SubItems.Add(sSize & " KB")
            If My.Settings.disas = "0" Then
                AddListItem(lstBrowSaf, 5, safarihis)
            Else
                AddListItem(lstBrowSaf, 5, IO.Path.GetFileName(safarihis))
            End If
            AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
            countSafar += 1
            sized += sSize
            On Error Resume Next
        Next
        Return Nothing
    End Function

    Public Function GetSafariCache()
        If Functiod.Cache.GetSafariCache <> "" Then
            Dim cacfilex = File.Exists(Functiod.Cache.GetSafariCache & "\Cache.db")
            If cacfilex = True Then
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(Functiod.Cache.GetSafariCache & "\Cache.db")
                'MsgBox("Executed")
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(Functiod.Cache.GetSafariCache & "\Cache.db", 5)
                '' List.Items(count).SubItems.Add("File")
                'List.Items(countSafar).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowSaf, 5, Functiod.Cache.GetSafariCache & "\Cache.db")
                Else
                    AddListItem(lstBrowSaf, 5, "Cache.db")
                End If
                AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
                countSafar += 1
                sized += sSize
            End If
        End If
        Return Nothing
    End Function

    Public Function GetSafariHistOthers()
        If Functiod.Cache.GetSafariOthers <> "" Then
            Dim hsflex = File.Exists(Functiod.Cache.GetSafariOthers & "\History.plist")
            If hsflex = True Then
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(Functiod.Cache.GetSafariOthers & "\History.plist")
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(Functiod.Cache.GetSafariOthers & "\History.plist", 5)
                '' List.Items(count).SubItems.Add("File")
                'List.Items(countSafar).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowSaf, 5, Functiod.Cache.GetSafariOthers & "\History.plist")
                Else
                    AddListItem(lstBrowSaf, 5, "History.plist")
                End If
                AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
                countSafar += 1
                sized += sSize
            End If
        End If
        Return Nothing
    End Function

    Public Function GetSafariLastSession()
        If Functiod.Cache.GetSafariOthers <> "" Then
            Dim lastsess = File.Exists(Functiod.Cache.GetSafariOthers & "\LastSession.plist")
            If lastsess = True Then
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(Functiod.Cache.GetSafariOthers & "\LastSession.plist")
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(Functiod.Cache.GetSafariOthers & "\LastSession.plist", 5)
                'List.Items(count).SubItems.Add("File")
                'List.Items(countSafar).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowSaf, 5, Functiod.Cache.GetSafariOthers & "\LastSession.plist")
                Else
                    AddListItem(lstBrowSaf, 5, "LastSession.plist")
                End If
                AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
                countSafar += 1
                sized += sSize
            End If
        End If
        Return Nothing
    End Function

    Public Function GetSafariTopSts()
        If Functiod.Cache.GetSafariOthers <> "" Then
            Dim TpSites = File.Exists(Functiod.Cache.GetSafariOthers & "\TopSites.plist")
            If TpSites = True Then
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(Functiod.Cache.GetSafariOthers & "\TopSites.plist")
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items.Add(Functiod.Cache.GetSafariOthers & "\TopSites.plist", 5)
                ''List.Items(count).SubItems.Add("File")
                'List.Items(countSafar).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowSaf, 5, Functiod.Cache.GetSafariOthers & "\TopSites.plist")
                Else
                    AddListItem(lstBrowSaf, 5, "TopSites.plist")
                End If
                AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
                countSafar += 1
                sized += sSize
            End If
        End If
        Return Nothing
    End Function

    Public Function GetSafariCookies()
        'C:\Users\Aravindh\AppData\Roaming\Apple Computer\Safari\Cookies
        Dim cook = Functiod.Cache.GetSafariOthers & "\Cookies"
        Dim cookex As Boolean = Directory.Exists(cook)
        If cookex = True Then
            For Each fil In Directory.GetFiles(cook)
                'List.Items.Add(fil, 5)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(count).SubItems.Add("File")
                'List.Items(countSafar).SubItems.Add(sSize & " KB")
                If My.Settings.disas = "0" Then
                    AddListItem(lstBrowSaf, 5, fil)
                Else
                    AddListItem(lstBrowSaf, 5, IO.Path.GetFileName(fil))
                End If
                AddListSubItem(lstBrowSaf, countSafar, sSize & " KB")
                countSafar += 1
                sized += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function SetTabs()
        Dim visIE = ""
        Dim visfire = ""
        Dim vischrom = ""
        Dim vissaf = ""
        Dim visthunder = ""
        Dim visoper = ""
        Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\settingsvisible.xml")
        If File.Exists(Application.StartupPath & "\settingsvisible.xml") = True Then
            While (dls.Read())
                Dim typ = dls.NodeType
                If typ = XmlNodeType.Element Then
                    If dls.Name = "Visibleff" Then
                        visfire = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "VisibleIE" Then
                        visIE = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "VisibleChrom" Then
                        vischrom = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Visiblesaf" Then
                        vissaf = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Visibleopr" Then
                        visoper = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Visiblethunder" Then
                        visthunder = dls.ReadInnerXml.ToString
                    End If
                End If
            End While
            dls.Close()
        End If
        If visfire = "false" Then
            tbControlBrow.TabPages.Remove(tbFire)
        End If
        If vischrom = "false" Then
            tbControlBrow.TabPages.Remove(tbChrom)
        End If
        If visIE = "false" Then
            tbControlBrow.TabPages.Remove(tbIE)
        End If
        If visoper = "false" Then
            tbControlBrow.TabPages.Remove(tbOper)
        End If
        If vissaf = "false" Then
            tbControlBrow.TabPages.Remove(tbSaf)
        End If
        If visthunder = "false" Then
            tbControlBrow.TabPages.Remove(tbThunder)
        End If

        Return Nothing
    End Function
    Private Sub InternetFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Location = New Point(main.Location.X + 24, main.Location.Y + 65)
        'Me.Size = New Size(main.panCleaner.Width - 12, main.panCleaner.Height + 20)
        SetTabs()
        count = 0
        tmrDialogPopup.Enabled = True
    End Sub

    Private Sub InternetFiles_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        main.ControlBox = True
        Me.Close()
    End Sub
    'Dim count

    Private Sub InternetFiles_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        main.ControlBox = True
        Me.Close()

    End Sub
    Public Function popup(ByVal colortocheck As Color, ByVal colortochange As Color)
        If count = 7 Then
            'panIntFls.BorderStyle = BorderStyle.FixedSingle

            panPopup.BackColor = colortocheck
            tmrDialogPopup.Enabled = False
        Else
            If panPopup.BackColor = colortocheck Then
                panPopup.BackColor = colortochange
                ' panIntFls.BorderStyle = BorderStyle.FixedSingle
            Else
                panPopup.BackColor = colortocheck
                'panIntFls.BorderStyle = BorderStyle.None
            End If
            count += 1
        End If
        Return Nothing
    End Function
    Private Sub tmrDialogPopup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDialogPopup.Tick
        Dim itms = lstBrowIE.Items.Count() + lstBrowFF.Items.Count() + lstBrowChrom.Items.Count + lstBrowOper.Items.Count + lstBrowSaf.Items.Count + lstBrowThunder.Items.Count
        If itms >= 1000 Then
            popup(Color.Firebrick, Color.IndianRed)
        ElseIf itms > 500 Then
            popup(Color.DarkGoldenrod, Color.Goldenrod)
        Else
            popup(Color.SteelBlue, Color.LightSteelBlue)
        End If

    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        main.ControlBox = True
        Me.Close()
    End Sub
    Public Function analyze()
        BackgroundWorker1.ReportProgress(0)
        Dim chkedffcach = ""
        Dim chkedffhis = ""
        Dim chkedffthumb = ""
        Dim chkedie = ""
        Dim chkedchrcach = ""
        Dim chkedchrhis = ""
        Dim chkedsaf = ""
        Dim chkedopercach = ""
        Dim chkedoperhis = ""
        Dim chkedoperthumb = ""
        Dim chkedThun = ""
        Dim chkedWMP = ""
        Dim chkedFlsh = ""
        Dim chkedUtr = ""
        Dim chkedOffRec = ""
        Dim chkedNotPlPl = ""
        Dim chkedEver = ""
        Dim chkedIDM = ""
        Dim chkedAdRd = ""
        Dim chkedLog = ""
        Dim chkedWER = ""
        Dim chkedWinRec = ""
        Dim chkedWinThum = ""
        Dim chkedAxIcon = ""
        Dim chkedQuick = ""
        Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\settingschecked.xml")
        If File.Exists(Application.StartupPath & "\settingschecked.xml") = True Then
            While (dls.Read())
                Dim typ = dls.NodeType
                If typ = XmlNodeType.Element Then
                    'MsgBox("Enter")
                    If dls.Name = "Cacheff" Then
                        chkedffcach = dls.ReadInnerXml.ToString
                        'MsgBox(chkedff)
                    End If
                    If dls.Name = "Hisff" Then
                        chkedffhis = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Thumbff" Then
                        chkedffthumb = dls.ReadInnerXml.ToString
                        'MsgBox(chkedffthumb)
                    End If
                    If dls.Name = "CheckedIE" Then
                        'Label2.Text = dls.ReadInnerXml.ToString
                        chkedie = dls.ReadInnerXml.ToString
                    End If

                    If dls.Name = "Cachechr" Then
                        chkedchrcach = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Hischr" Then
                        chkedchrhis = dls.ReadInnerXml.ToString
                    End If

                    If dls.Name = "CheckedSaf" Then
                        chkedsaf = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Cacheoper" Then
                        chkedopercach = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Hisoper" Then
                        chkedoperhis = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Thumboper" Then
                        chkedoperthumb = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedAxIcon" Then
                        chkedAxIcon = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedThunder" Then
                        chkedThun = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedWMP" Then
                        chkedWMP = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedFlsh" Then
                        chkedFlsh = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "Checkedutrr" Then
                        chkedUtr = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedOffRec" Then
                        chkedOffRec = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedNotPlPl" Then
                        chkedNotPlPl = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedEver" Then
                        chkedEver = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedIDM" Then
                        chkedIDM = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedAdobeRd" Then
                        chkedAdRd = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedQuick" Then
                        chkedQuick = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedLog" Then
                        chkedLog = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedWER" Then
                        chkedWER = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedWinRec" Then
                        chkedWinRec = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedWinThumb" Then
                        chkedWinThum = dls.ReadInnerXml.ToString
                    End If
                    'Exit While
                End If
            End While
            dls.Close()
        Else
        End If
        Try
            If chkedie = "true" Then
                main.lblScanStatus1.Text = "Status : Scanning Internet Files..."
                InternetFiles()
                'retrieval.InternetExFiles(Main.lstBrowIE)
                GetIECookies()
                BackgroundWorker1.ReportProgress(10)
                'progressbarsec.Value = 10
            End If
        Catch ex As Exception
            'errormessage = errormessage & vbNewLine & "Error Occurred at : IntrntFls ( 404 or 405 or 201) " & ex.ToString
            'Crash_Box.ShowDialog()
        End Try

        Try
            If chkedie = "true" Then
                main.lblScanStatus1.Text = "Status : Scanning IE Dtbs..."
                IEDtBs()
                BackgroundWorker1.ReportProgress(15)
            End If
        Catch ex As Exception
            'errormessage = errormessage & vbNewLine & "Error Occurred at : IEDt ( 404 or 405 or 201 ) " & ex.ToString
            'Crash_Box.ShowDialog()
        End Try

        Try
            If chkedie = "true" Then
                main.lblScanStatus1.Text = "Status : Scanning Internet Explorer Items..."
                GetContentIE5()
                'progressbar2.Value = 20
                'progressbarsec.Value = 20
                BackgroundWorker1.ReportProgress(20)
            End If
        Catch ex As Exception
            'errormessage = errormessage & vbNewLine & "Error Occurred at : IEContIE5 ( 404 or 405 or 208 ) " & ex.ToString
            'Crash_Box.ShowDialog()
        End Try

        Try
            If chkedie = "true" Then
                main.lblScanStatus1.Text = "Status : Scanning Internet Explorer Feeds Cache..."
                IEFeedsCache()
                'progressbar2.Value = 23
                'progressbarsec.Value = 23
                BackgroundWorker1.ReportProgress(23)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : IEFeedsCach ( 404 or 405 or 208 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedie = "true" Then
                main.lblScanStatus1.Text = "Status : Scanning Internet Explorer IE 5..."
                GetContentIE5ex()
                'MsgBox("ezx")
                'progressbar2.Value = 24
                'progressbarsec.Value = 24
                BackgroundWorker1.ReportProgress(24)
            End If
        Catch ex As Exception
            'errormessage = errormessage & vbNewLine & "Error Occurred at : IE Content IE5 ex (404 or 405 or 208 ) " & ex.ToString
            'Crash_Box.ShowDialog()
        End Try

        'Try
        '    If GetTempFilesWindows() <> "" Then
        '        lblScanStatus.Text = "Status : Scanning Temp Directory..."
        '        retrieval.GetTempDirWind(OtherFiles.lstTemp)
        '        Progressbar1.Value = 25
        '        progressbarsec.Value = 25
        '    End If
        'Catch ex As Exception
        '    errormessage = errormessage & vbNewLine & "Error Occurred at : TmpWnDir ( 404 or 405 or 201 ) " & ex.ToString
        '    Crash_Box.ShowDialog()
        'End Try

        'Try

        '    If retrieval.GetTempDirectory() <> "" Then
        '        retrieval.TempFiles(OtherFiles.lstTemp)
        '        Progressbar1.Value = 30
        '        progressbarsec.Value = 30
        '    End If
        'Catch ex As Exception
        '    'errormessage = errormessage & vbNewLine & "Error Occurred at : TmpDir( 404 or 405 or 201) " & ex.ToString
        '    'Crash_Box.ShowDialog()
        'End Try
        Try
            If main.ProcessRunning("chrome") > 1 Then
                'Dim ret = MsgBox("Chrome files cannot be deleted because chrome is running" & vbNewLine & "Do you want to close chrome for you ? ", MsgBoxStyle.Exclamation + vbYesNo, "Information")
                MsgBoxExChrome.ShowDialog()
                If MsgBoxExChrome.lblRet.Text = 0 Then
                    'Processes.Processos.EndChrome()
                    If chkedchrcach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Chrome Cache..."
                        ChromeCache()
                        BackgroundWorker1.ReportProgress(35)
                        'progressbar2.Value = 35
                        'progressbarsec.Value = 35
                    End If
                    If chkedchrhis = "true" Then
                        ChromeJournalFiles()
                        BackgroundWorker1.ReportProgress(35)
                    End If
                    If chkedchrhis = "true" Then
                        CanaryJournalFiles()
                        BackgroundWorker1.ReportProgress(36)
                    End If
                    If chkedchrcach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Chrome Canary Cache..."
                        CanaryCache()
                        BackgroundWorker1.ReportProgress(36)
                        'progressbar2.Value = 36
                        'progressbarsec.Value = 36
                    End If
                    If chkedchrcach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Chrome Canary media cache..."
                        CanaryMediaCache()

                        BackgroundWorker1.ReportProgress(37)
                    End If
                    If chkedchrcach = "true" Then
                        ChromeGPUCache()
                        CanaryGPUCache()
                        BackgroundWorker1.ReportProgress(38)
                    End If
                    If chkedchrcach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Chrome Media Cache..."
                        ChromeMediaCache()
                        'progressbar2.Value = 38
                        'progressbarsec.Value = 38
                        BackgroundWorker1.ReportProgress(38)
                    End If
                    If chkedchrhis = "true" Then
                        CanaryOthers()
                        'progressbar2.Value = 39
                        'progressbarsec.Value = 39
                        BackgroundWorker1.ReportProgress(39)
                    End If
                    If chkedchrcach = "true" Then
                        ChromeLocalStore()
                        CanaryLocalStore()
                        BackgroundWorker1.ReportProgress(40)
                    End If
                    If chkedchrhis = "true" Then
                        ChromeOthers()
                        'progressbar2.Value = 40
                        'progressbarsec.Value = 40
                        BackgroundWorker1.ReportProgress(40)
                    End If
                    If chkedchrcach = "true" Then
                        ChromeJumplisticons()
                        CanaryJumplisticons()
                        BackgroundWorker1.ReportProgress(40)
                    End If
                ElseIf MsgBoxExChrome.lblRet.Text = 1 Then
                    main.lblScanStatus1.Text = "Skipping chrome items..."
                Else
                    MsgBox("Something happened contact manufacturer", MsgBoxStyle.Critical + vbOKOnly, "Error")
                    Crash_Box.ShowDialog()
                End If
            Else
                If chkedchrcach = "true" Then
                    main.lblScanStatus1.Text = "Status : Scanning Chrome Cache..."
                    ChromeCache()
                    BackgroundWorker1.ReportProgress(35)
                    'progressbar2.Value = 35
                    'progressbarsec.Value = 35
                End If
                If chkedchrhis = "true" Then
                    ChromeJournalFiles()
                    BackgroundWorker1.ReportProgress(35)
                End If
                If chkedchrhis = "true" Then
                    CanaryJournalFiles()
                    BackgroundWorker1.ReportProgress(36)
                End If
                If chkedchrcach = "true" Then
                    main.lblScanStatus1.Text = "Status : Scanning Chrome Canary Cache..."
                    CanaryCache()
                    BackgroundWorker1.ReportProgress(36)
                    'progressbar2.Value = 36
                    'progressbarsec.Value = 36
                End If
                If chkedchrcach = "true" Then
                    main.lblScanStatus1.Text = "Status : Scanning Chrome Canary media cache..."
                    CanaryMediaCache()

                    BackgroundWorker1.ReportProgress(37)
                End If
                If chkedchrcach = "true" Then
                    ChromeGPUCache()
                    CanaryGPUCache()
                    BackgroundWorker1.ReportProgress(38)
                End If
                'MsgBox(Functiod.Cache.GetCanaryOthers)
                If chkedchrcach = "true" Then
                    main.lblScanStatus1.Text = "Status : Scanning Chrome Media Cache..."
                    ChromeMediaCache()
                    'progressbar2.Value = 38
                    'progressbarsec.Value = 38
                    BackgroundWorker1.ReportProgress(38)
                End If
                If chkedchrhis = "true" Then
                    CanaryOthers()
                    'progressbar2.Value = 39
                    'progressbarsec.Value = 39
                    BackgroundWorker1.ReportProgress(39)
                End If
                If chkedchrcach = "true" Then
                    ChromeLocalStore()
                    CanaryLocalStore()
                    BackgroundWorker1.ReportProgress(40)
                End If
                If chkedchrhis = "true" Then
                    ChromeOthers()
                    'progressbar2.Value = 40
                    'progressbarsec.Value = 40
                    BackgroundWorker1.ReportProgress(40)
                End If
                If chkedchrcach = "true" Then
                    ChromeJumplisticons()
                    CanaryJumplisticons()
                    BackgroundWorker1.ReportProgress(40)
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : Chrm Cac ( 404 or 405 or 208 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        '
        Try
            Dim chkedf As Integer
            If chkedffcach = "true" Or chkedffhis = "true" Or chkedffthumb = "true" Then
                chkedf = 1
            Else
                chkedf = 0
            End If
            If main.ProcessRunning("firefox") = 1 And chkedf = 1 Then
                'Dim ret = MsgBox("Firefox files cannot be scanned because firefox is running" & vbNewLine & "Do you want me to close Firefox for you ? ", MsgBoxStyle.Exclamation + vbYesNo, "Information")
                MessageBoxEx.ShowDialog()
                If MessageBoxEx.lblRet.Text = 0 Then
                    'Processes.Processos.EndFirefox()
                    If GetFirefoxCache() <> "" Then
                        If chkedffcach = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Firefox Cache..."
                            FirefoxCache()
                            'progressbar2.Value = 50
                            'progressbarsec.Value = 50
                            BackgroundWorker1.ReportProgress(50)
                            main.lblScanStatus1.Text = "Status : Scanning Firefox jumplist icon..."
                            FirefoxJmpLstIcons()
                            'progressbar2.Value = 51
                            'progressbarsec.Value = 51
                            BackgroundWorker1.ReportProgress(51)
                        End If
                        If chkedffthumb = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Firefox Web Thumbnails..."
                            FirefoxWebThumb()
                            'progressbar2.Value = 55
                            'progressbarsec.Value = 55
                            BackgroundWorker1.ReportProgress(55)
                        End If
                        If chkedffhis = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Firefox Files..."
                            FirefoxMiscillaneous()
                            ' MsgBox("1")
                            'progressbar2.Value = 60
                            'progressbarsec.Value = 60
                            BackgroundWorker1.ReportProgress(60)
                        End If
                    End If
                ElseIf MessageBoxEx.lblRet.Text = 1 Then
                    main.lblScanStatus1.Text = "Status : Skipping Firefox Items..."
                Else
                    errormessage = errormessage & vbNewLine & "Something happened contact product manuacturer"
                    Crash_Box.ShowDialog()
                End If
            Else
                If GetFirefoxCache() <> "" Then
                    If chkedffcach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Firefox Cache..."
                        FirefoxCache()
                        'progressbar2.Value = 50
                        'progressbarsec.Value = 50
                        BackgroundWorker1.ReportProgress(50)
                        main.lblScanStatus1.Text = "Status : Scanning Firefox jumplist icon..."
                        FirefoxJmpLstIcons()
                        'progressbar2.Value = 51
                        'progressbarsec.Value = 51
                        BackgroundWorker1.ReportProgress(51)
                    End If
                    If chkedffthumb = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Firefox Web Thumbnails..."
                        FirefoxWebThumb()
                        'progressbar2.Value = 55
                        'progressbarsec.Value = 55
                        BackgroundWorker1.ReportProgress(55)
                    End If
                    If chkedffhis = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Firefox Files..."
                        FirefoxMiscillaneous()
                        ' MsgBox("1")
                        'progressbar2.Value = 60
                        'progressbarsec.Value = 60
                        BackgroundWorker1.ReportProgress(60)
                    End If
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : FrFx Cac ( 404 or 405 or 209 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If main.ProcessRunning("thunderbird") = 1 And chkedThun = "true" Then
                'Dim ret = MsgBox("Thunderbird Files Cannot be scanned while it is Running" & vbNewLine & "Do you want me to close thunderbird for you ? ", MsgBoxStyle.Exclamation + vbYesNo, "Information")
                MsgBoxExThunBird.ShowDialog()

                If MsgBoxExThunBird.IblRet.Text = 0 Then
                    'Processes.Processos.EndThunderbird()
                    If chkedThun = "true" And Functiod.Cache.GetThunderbirdCache <> "" Then
                        main.lblScanStatus1.Text = "Status : Scanning Thunderbird Cache..."
                        ThunderbirdCache()
                        'progressbar2.Value = 63
                        'progressbarsec.Value = 63
                        BackgroundWorker1.ReportProgress(63)
                    End If
                    If Functiod.Cache.GetThunderbirdSes <> "" Then
                        main.lblScanStatus1.Text = "Status : Scanning Thunderbird Items..."
                        GetThunderbirdSes()
                        'progressbar2.Value = 64
                        'progressbarsec.Value = 64
                        BackgroundWorker1.ReportProgress(64)
                    End If
                Else
                    main.lblScanStatus1.Text = "Status : Skipping Thunderbird Cache..."
                End If
            Else
                If chkedThun = "true" And Functiod.Cache.GetThunderbirdCache <> "" Then
                    main.lblScanStatus1.Text = "Status : Scanning Thunderbird Cache..."
                    ThunderbirdCache()
                    'progressbar2.Value = 63
                    'progressbarsec.Value = 63
                    BackgroundWorker1.ReportProgress(63)
                End If
                If Functiod.Cache.GetThunderbirdSes <> "" Then
                    main.lblScanStatus1.Text = "Status : Scanning Thunderbird Items..."
                    GetThunderbirdSes()
                    'progressbar2.Value = 64
                    'progressbarsec.Value = 64
                    BackgroundWorker1.ReportProgress(64)
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at ThBrd Cac or ses ( 404 or 405 or 213 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            Dim chked
            If chkedopercach = "true" Or chkedoperhis = "true" Or chkedoperthumb = "true" Then
                chked = 1
            Else
                chked = 0
            End If
            If main.ProcessRunning("opera") > 1 And chked = 1 Then
                Dim ret = MsgBox("Opera files cannot be scanned because opera is running" & vbNewLine & "Do you want me to close opera for you ?", MsgBoxStyle.Exclamation + vbYesNo, "Information")
                If ret = vbYes Then
                    Processes.Processos.EndOpera()
                    If GetOperaStableCacheNew() <> "" Then
                        If chkedopercach = "true" Then
                            OperaStableCacheNew()
                            OperaStableGPUCachNew()
                            OperaStableJumpListIconsNew()
                            OperaStableJumpListIconOldNew()
                            OperaStableLocalStorageNew()
                        End If
                    End If
                    If GetOperaCache() <> "" Then
                        If chkedopercach = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Opera Cache..."
                            OperaCache()
                            'progressbar2.Value = 65
                            'progressbarsec.Value = 65
                            BackgroundWorker1.ReportProgress(65)
                            main.lblScanStatus1.Text = "Status : Scanning Opera Cache..."
                            OperaCacheVps()
                            'progressbar2.Value = 66
                            'progressbarsec.Value = 66
                            BackgroundWorker1.ReportProgress(66)
                            main.lblScanStatus1.Text = "Status : Scanning Opera op cache..."
                            OperaOpCache()
                            'progressbar2.Value = 67
                            'progressbarsec.Value = 67
                            BackgroundWorker1.ReportProgress(67)
                            main.lblScanStatus1.Text = "Status : Scanning Opera icon cache..."
                            OperaIconCache()
                            'progressbar2.Value = 68
                            'progressbarsec.Value = 68
                            BackgroundWorker1.ReportProgress(68)
                        End If
                        If chkedoperthumb = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Opera jumplist icon cache..."
                            OperaJmpLstIcnCache()
                            'progressbar2.Value = 69
                            'progressbarsec.Value = 69
                            BackgroundWorker1.ReportProgress(69)
                        End If
                        If chkedoperhis = "true" Then
                            main.lblScanStatus1.Text = "Status : Scanning Opera Sessions..."
                            Operasessions()
                            'progressbar2.Value = 70
                            'progressbarsec.Value = 70
                            BackgroundWorker1.ReportProgress(70)
                            main.lblScanStatus1.Text = "Status : Scanning Opera typed history..."
                            OperaTypedHstry()
                            'progressbar2.Value = 71
                            'progressbarsec.Value = 71
                            BackgroundWorker1.ReportProgress(71)
                            'lblScanStatus.Text = "Status : Scanning Opera Others..."
                            OperaOthers()
                            'progressbar2.Value = 72
                            'progressbarsec.Value = 72
                            BackgroundWorker1.ReportProgress(72)
                        End If
                    End If
                Else
                    main.lblScanStatus1.Text = "Status : Skipping Opera Files"
                End If
            Else
                If GetOperaStableCacheNew() <> "" Then
                    If chkedopercach = "true" Then
                        OperaStableCacheNew()
                        OperaStableGPUCachNew()
                        OperaStableJumpListIconsNew()
                        OperaStableJumpListIconOldNew()
                        OperaStableLocalStorageNew()
                    End If
                End If
                If GetOperaCache() <> "" Then
                    If chkedopercach = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Opera Cache..."
                        OperaCache()
                        'progressbar2.Value = 65
                        'progressbarsec.Value = 65
                        BackgroundWorker1.ReportProgress(65)
                        main.lblScanStatus1.Text = "Status : Scanning Opera Cache..."
                        OperaCacheVps()
                        'progressbar2.Value = 66
                        'progressbarsec.Value = 66
                        BackgroundWorker1.ReportProgress(66)
                        main.lblScanStatus1.Text = "Status : Scanning Opera op cache..."
                        OperaOpCache()
                        'progressbar2.Value = 67
                        'progressbarsec.Value = 67
                        BackgroundWorker1.ReportProgress(67)
                        main.lblScanStatus1.Text = "Status : Scanning Opera icon cache..."
                        OperaIconCache()
                        'progressbar2.Value = 68
                        'progressbarsec.Value = 68
                        BackgroundWorker1.ReportProgress(68)
                    End If
                    If chkedoperthumb = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Opera jumplist icon cache..."
                        OperaJmpLstIcnCache()
                        'progressbar2.Value = 69
                        'progressbarsec.Value = 69
                        BackgroundWorker1.ReportProgress(69)
                    End If
                    If chkedoperhis = "true" Then
                        main.lblScanStatus1.Text = "Status : Scanning Opera Sessions..."
                        Operasessions()
                        'progressbar2.Value = 70
                        'progressbarsec.Value = 70
                        BackgroundWorker1.ReportProgress(70)
                        main.lblScanStatus1.Text = "Status : Scanning Opera typed history..."
                        OperaTypedHstry()
                        'progressbar2.Value = 71
                        'progressbarsec.Value = 71
                        BackgroundWorker1.ReportProgress(71)
                        'lblScanStatus.Text = "Status : Scanning Opera Others..."
                        OperaOthers()
                        'progressbar2.Value = 72
                        'progressbarsec.Value = 72
                        BackgroundWorker1.ReportProgress(72)
                    End If
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at OPr Cac ( 404 or 405 or 213 ) " & ex.ToString
            'ProgressBar1.Value = 100
            Crash_Box.ShowDialog()
        End Try
        'lstCleaner.Items.Add("clean")
        'lstCleaner.Items(Functiod.retrieval.count).SubItems.Add("something")
        Try
            If Settings.chkPreFetch.Checked = True And Functiod.windowsfolders.GetOldPrefetchData <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Prefetch Data Files..."
                'retrieval.WindowsItems.GetPrefetchData(lstCleanerOtherfls)
                'Progressbar1.Value = 73
                'progressbarsec.Value = 73
                BackgroundWorker1.ReportProgress(73)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : PreFls ( 404 or 405 or 234 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try



        Try
            If chkedsaf = "true" And GetSafariCache() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Cache..."
                GetSafariCache()
                'progressbar2.Value = 75
                'progressbarsec.Value = 75
                BackgroundWorker1.ReportProgress(75)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : SFri Cac ( 404 or 405 or 213 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try



        'Try
        If chkedsaf = "true" And GetSafariHistory() <> "" Then
            main.lblScanStatus1.Text = "Status : Scanning Safari History..."
            safarihistory()
            'progressbar2.Value = 95
            'progressbarsec.Value = 81
            BackgroundWorker1.ReportProgress(95)
        End If
        ' Catch ex As Exception
        'errormessage = errormessage & vbNewLine & "Error Occurred at : SFHs ( 404 or 405 or 201 ) " & ex.ToString
        'Crash_Box.ShowDialog()
        'End Try
        'Progressbar1.Value = 95
        'Progressbar1.Value = 100
        'Progressbar1.Value = 0
        Try
            If chkedsaf = "true" And GetSafariOthers() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Cookies..."
                GetSafariCookies()
                'progressbar2.Value = 25
                'progressbarsec.Value = 82
                BackgroundWorker1.ReportProgress(96)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at SFCks ( 404 or 405 or 201 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedsaf = "true" And GetSafariOthers() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Other Items..."
                GetSafariHistOthers()
                'progressbar2.Value = 35
                'progressbarsec.Value = 83
                BackgroundWorker1.ReportProgress(97)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : SFHstOth ( 404 or 405 or 201 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedsaf = "true" And GetSafariOthers() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Last Sessions..."
                GetSafariLastSession()
                'progressbar2.Value = 45
                'progressbarsec.Value = 84
                BackgroundWorker1.ReportProgress(98)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : SFLstSess ( 404 or 405 or 201 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedsaf = "true" And GetSafariOthers() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Top Sites..."
                GetSafariTopSts()
                'progressbar2.Value = 55
                'progressbarsec.Value = 85
                BackgroundWorker1.ReportProgress(99)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : SFTpSites ( 404 or 405 or 201 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedsaf = "true" And GetSafariWebpagePreviews() <> "" Then
                main.lblScanStatus1.Text = "Status : Scanning Safari Web Previews..."
                safariwebpagepre()
                'progressbar2.Value = 65
                'progressbarsec.Value = 86
                BackgroundWorker1.ReportProgress(100)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : SFWPs ( 404 or 405 or 201 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        BackgroundWorker1.ReportProgress(100)
        Return Nothing
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        count = 0
        countChrom = 0
        countFF = 0
        countIE = 0
        countLog = 0
        countOper = 0
        countSafar = 0
        countThunder = 0
        BackgroundWorker1.ReportProgress(0)
        analyze()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        main.prgIntFls.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If lstBrowIE.Items.Count <> 0 Or lstBrowFF.Items.Count <> 0 Or lstBrowOper.Items.Count <> 0 Or lstBrowSaf.Items.Count <> 0 Or lstBrowChrom.Items.Count <> 0 Or lstBrowThunder.Items.Count <> 0 Then
            tbIE.Text = lstBrowIE.Items.Count & " Items"
            tbFire.Text = lstBrowFF.Items.Count & " Items"
            tbChrom.Text = lstBrowChrom.Items.Count & " Items"
            tbSaf.Text = lstBrowSaf.Items.Count & " Items"
            tbOper.Text = lstBrowOper.Items.Count & " Items"
            tbThunder.Text = lstBrowThunder.Items.Count & " Items"
            Dim sizeed = Math.Round(sized / 1024, 2)
            Dim sizeedin
            If sizeed >= 1024 Then
                sizeed = Math.Round(sized / 1024 / 1024, 2)
                sizeedin = sizeed & " GB"
            Else
                sizeed = Math.Round(sized / 1024, 2)
                sizeedin = sizeed & " MB"
            End If

            Dim siz = lstBrowIE.Items.Count() + lstBrowFF.Items.Count() + lstBrowChrom.Items.Count + lstBrowOper.Items.Count + lstBrowSaf.Items.Count + lstBrowThunder.Items.Count & " Files ( " & sizeedin & " Approx )"
            lblSzonDsk.Text = siz
            main.lblIntFlsSize.Text = siz
            main.lblIntFlsSize.Visible = True
            main.prgIntFls.Visible = False
            main.PictureBox8.Image = My.Resources._1390669896_bullet_yellow
            main.panPopupMess.BackColor = Color.Firebrick
            main.Label1.ForeColor = Color.White

            main.Label1.Text = "Scanning Completed. Unwanted files found if you want to delete the temp file click clean below"
            main.lblScanStatus1.Text = "Scanning Complete..."
            main.lblScanStatus1.Visible = False
            tbControlBrow.Visible = True
            main.bttnScanFiles.Enabled = True
        Else
            main.Label1.Text = "Scanning Completed"
            main.lblScanStatus1.Text = "Scanning Complete..."
            main.lblScanStatus1.Visible = False
            main.prgIntFls.Visible = False

            main.lblIntFlsSize.Visible = True
            main.lblIntFlsSize.Text = "(No Information)"
            main.bttnScanFiles.Enabled = True
        End If

        main.tmrloadanisp1.Enabled = False
        main.tmrloadanisp1rev.Enabled = False
        main.tmrlodanimation.Enabled = False
        main.panintfileani.Visible = False
        main.Panel4.Visible = False
        main.lod1.Visible = False

        Debug_Info.ListBox1.Items.Add("Scanning System for Temp Files Completed at " & My.Computer.Clock.LocalTime)
    End Sub

    Private Sub bttnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            lstBrowIE.View = View.Tile
            lstBrowFF.View = View.Tile
            lstBrowChrom.View = View.Tile
            lstBrowOper.View = View.Tile
            lstBrowSaf.View = View.Tile
            lstBrowThunder.View = View.Tile
            Me.WindowState = FormWindowState.Maximized


        Else
            Me.WindowState = FormWindowState.Normal
            lstBrowIE.View = View.Details
            lstBrowFF.View = View.Details
            lstBrowChrom.View = View.Details
            lstBrowOper.View = View.Details
            lstBrowSaf.View = View.Details
            lstBrowThunder.View = View.Details
        End If
    End Sub


End Class