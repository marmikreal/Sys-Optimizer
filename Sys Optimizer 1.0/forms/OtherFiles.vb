Imports System.IO
Imports Functiod.Cache
Imports Functiod
Imports System.Xml
Public Class OtherFiles
    ' Thanks to Manuel Alves of stackoverflow.com for providing the code below
    ' Thanks for making sys optimizer a best software Manuel Alves'
    ' The Function FileInUse is provided by Manuel Alves'
    Public Shared sizedother As Integer = 0
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

    Public Shared Function GetTempDirectory() As String
        Return Environment.GetEnvironmentVariable("TEMP")
    End Function
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
    Public counttemp As Integer = 0
    Public Function TempFiles()
        ' MsgBox("true")
        For Each filepath In Directory.GetFiles(GetTempDirectory)
            If FileInUse(filepath) = False Then
                Dim spath
                spath = filepath
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filepath)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                Dim sed

                sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                'MsgBox("exe1")
               
                BackgroundWorker1.ReportProgress(45)
                If My.Settings.disas = "0" Then
                    AddListItem(lstTemp, 1, filepath)
                Else
                    AddListItem(lstTemp, 1, IO.Path.GetFileName(filepath))
                End If
                AddListSubItem(lstTemp, counttemp, sed)
                counttemp += 1
                retrieval.countTemp += 1
                sizedother += sSize
            End If

        Next
        For Each fold In Directory.GetDirectories(GetTempDirectory)
            For Each filinfold In Directory.GetFiles(fold)
                If FileInUse(filinfold) = False Then
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    Dim sed

                    sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                    'MsgBox("exe1")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstTemp, 1, filinfold)
                    Else
                        AddListItem(lstTemp, 1, IO.Path.GetFileName(filinfold))
                    End If
                    AddListSubItem(lstTemp, counttemp, sed)
                    BackgroundWorker1.ReportProgress(46)
                    counttemp += 1
                    retrieval.countTemp += 1
                    sizedother += sSize
                End If
            Next
            For Each foldinfold In Directory.GetDirectories(fold)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    If FileInUse(filinfold) = False Then
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        Dim sed

                        sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                        'MsgBox("exe1")
                        If My.Settings.disas = "0" Then
                            AddListItem(lstTemp, 1, filinfold)
                        Else
                            AddListItem(lstTemp, 1, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstTemp, counttemp, sed)
                        BackgroundWorker1.ReportProgress(47)
                        counttemp += 1
                        retrieval.countTemp += 1
                        sizedother += sSize
                    End If
                Next
                For Each foldinfoldinfold In Directory.GetDirectories(foldinfold)
                    For Each fileinfold In Directory.GetFiles(foldinfoldinfold)
                        If FileInUse(fileinfold) = False Then
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            Dim sed

                            sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                            'MsgBox("exe1")
                            If My.Settings.disas = "0" Then
                                AddListItem(lstTemp, 1, fileinfold)
                            Else
                                AddListItem(lstTemp, 1, IO.Path.GetFileName(fileinfold))
                            End If
                            AddListSubItem(lstTemp, counttemp, sed)
                            BackgroundWorker1.ReportProgress(48)
                            counttemp += 1
                            retrieval.countTemp += 1
                            sizedother += sSize
                        End If
                    Next
                    For Each foldinfoldinfoldinfold In Directory.GetDirectories(foldinfoldinfold)
                        For Each fileinfold In Directory.GetFiles(foldinfoldinfoldinfold)
                            If FileInUse(fileinfold) = False Then
                                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                Dim sed

                                sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                                'MsgBox("exe1")
                                If My.Settings.disas = "0" Then
                                    AddListItem(lstTemp, 1, fileinfold)
                                Else
                                    AddListItem(lstTemp, 1, IO.Path.GetFileName(fileinfold))
                                End If
                                AddListSubItem(lstTemp, counttemp, sed)
                                BackgroundWorker1.ReportProgress(49)
                                counttemp += 1
                                retrieval.countTemp += 1
                                sizedother += sSize
                            End If
                        Next
                        For Each foldin In Directory.GetDirectories(foldinfoldinfoldinfold)
                            For Each fileinfold In Directory.GetFiles(foldin)
                                If FileInUse(fileinfold) = False Then
                                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                    Dim sed

                                    sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                                    'MsgBox("exe1")
                                    If My.Settings.disas = "0" Then
                                        AddListItem(lstTemp, 1, fileinfold)
                                    Else
                                        AddListItem(lstTemp, 1, IO.Path.GetFileName(fileinfold))
                                    End If
                                    AddListSubItem(lstTemp, counttemp, sed)
                                    BackgroundWorker1.ReportProgress(50)
                                    counttemp += 1
                                    retrieval.countTemp += 1
                                    sizedother += sSize
                                End If
                            Next
                            For Each foldind In Directory.GetDirectories(foldin)
                                For Each fileinfold In Directory.GetFiles(foldind)
                                    If FileInUse(fileinfold) = False Then
                                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                        Dim sed

                                        sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                                        'MsgBox("exe1")
                                        If My.Settings.disas = "0" Then
                                            AddListItem(lstTemp, 1, fileinfold)
                                        Else
                                            AddListItem(lstTemp, 1, IO.Path.GetFileName(fileinfold))
                                        End If
                                        AddListSubItem(lstTemp, counttemp, sed)
                                        BackgroundWorker1.ReportProgress(51)
                                        counttemp += 1
                                        retrieval.countTemp += 1
                                        sizedother += sSize
                                    End If
                                Next
                                For Each folinfol In Directory.GetDirectories(foldind)
                                    For Each fileinfold In Directory.GetFiles(folinfol)
                                        If FileInUse(fileinfold) = False Then
                                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                            Dim sed

                                            sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                                            'MsgBox("exe1")
                                            If My.Settings.disas = "0" Then
                                                AddListItem(lstTemp, 1, fileinfold)
                                            Else
                                                AddListItem(lstTemp, 1, IO.Path.GetFileName(fileinfold))
                                            End If
                                            AddListSubItem(lstTemp, counttemp, sed)
                                            BackgroundWorker1.ReportProgress(52)
                                            counttemp += 1
                                            retrieval.countTemp += 1
                                            sizedother += sSize
                                        End If
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next
        For Each folder In Directory.GetDirectories(GetTempDirectory())
            'List.Items.Add(folder)
            'On Error Resume Next
        Next
        Return Nothing
    End Function
    Public Function GetTempDirWind()
        For Each tempfil In Directory.GetFiles(Functiod.Cache.GetTempFilesWindows)
            If FileInUse(tempfil) = False Then
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(tempfil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 0)
                'Dim sed
                'If sSize > 1024 Then
                '    sed = Math.Round(sinfo.Length / 1024 / 1024, 2) & " MB"
                '    ' MsgBox("exe")
                'Else
                '    sed = Math.Round(sinfo.Length / 1024, 2) & " KB"
                '    'MsgBox("exe1")
                'End If
                Dim spath
                spath = tempfil
                If My.Settings.disas = "0" Then
                    AddListItem(lstTemp, 1, tempfil)
                Else
                    AddListItem(lstTemp, 1, IO.Path.GetFileName(tempfil))
                End If
                AddListSubItem(lstTemp, counttemp, sSize & " KB")
                counttemp += 1
                sizedother += sSize
            End If
                On Error Resume Next
        Next
        For Each folder In Directory.GetDirectories(Functiod.Cache.GetTempFilesWindows)
            'list.Items.Add(folder)
            On Error Resume Next
        Next
        For Each fold In Directory.GetDirectories(Functiod.Cache.GetTempFilesWindows)
            For Each filin In Directory.GetFiles(fold)
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filin)
                Dim sSize = Math.Round(sinfo.Length / 1024, 0)
                If FileInUse(filin) = False Then
                    If My.Settings.disas = "0" Then
                        AddListItem(lstTemp, 1, filin)
                    Else
                        AddListItem(lstTemp, 1, IO.Path.GetFileName(filin))
                    End If
                    AddListSubItem(lstTemp, counttemp, sSize & " KB")
                    counttemp += 1
                    sizedother += sSize
                End If
            Next
            For Each foldinfold In Directory.GetDirectories(fold)
                For Each secinfold In Directory.GetFiles(foldinfold)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(secinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 0)
                    If FileInUse(secinfold) = False Then
                        If My.Settings.disas = "0" Then
                            AddListItem(lstTemp, 1, secinfold)
                        Else
                            AddListItem(lstTemp, 1, IO.Path.GetFileName(secinfold))
                        End If
                        AddListSubItem(lstTemp, counttemp, sSize & " KB")
                        counttemp += 1
                        sizedother += sSize
                    End If
                Next
                For Each foldininfold In Directory.GetDirectories(foldinfold)
                    For Each thirinfold In Directory.GetFiles(foldininfold)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(thirinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 0)
                        If FileInUse(thirinfold) = False Then
                            If My.Settings.disas = "0" Then
                                AddListItem(lstTemp, 1, thirinfold)
                            Else
                                AddListItem(lstTemp, 1, IO.Path.GetFileName(thirinfold))
                            End If
                            AddListSubItem(lstTemp, counttemp, sSize & " KB")
                            counttemp += 1
                            sizedother += sSize
                        End If
                    Next
                    For Each forfoldinfold In Directory.GetDirectories(foldininfold)
                        For Each forinfold In Directory.GetFiles(forfoldinfold)
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(forinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 0)
                            If FileInUse(forinfold) = False Then
                                If My.Settings.disas = "0" Then
                                    AddListItem(lstTemp, 1, forinfold)
                                Else
                                    AddListItem(lstTemp, 1, IO.Path.GetFileName(forinfold))
                                End If
                                AddListSubItem(lstTemp, counttemp, sSize & " KB")
                                counttemp += 1
                                sizedother += sSize
                            End If
                        Next
                    Next
                Next
            Next
        Next
        Return Nothing
    End Function
    Public Shared ount As Integer = 0
    Public Function GetPrefetchData()
        '.pf
        For Each fil In Directory.GetFiles(Functiod.windowsfolders.GetOldPrefetchData)
            If IO.Path.GetExtension(fil) = ".pf" Then
                If My.Settings.disas = "0" Then
                    AddListItem(lstTemp, 11, fil)
                Else
                    AddListItem(lstTemp, 11, IO.Path.GetFileName(fil))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add("File")
                AddListSubItem(lstTemp, counttemp, sSize & " KB")
                counttemp += 1
                sizedother += sSize
            Else
                'MsgBox("Not Compatible extension spotted")
            End If
        Next
        Return Nothing
    End Function
  
    Public Function IDM()
        Dim fil = Functiod.SoftCache.GetIDM & "\UrlHistory.txt"
        Dim fil2 = Functiod.SoftCache.GetIDM & "\foldresHistory.txt"
        If File.Exists(fil) = True Then
            'List.Items.Add(fil, 12)
            If My.Settings.disas = "0" Then
                AddListItem(lstSoft, 12, fil)
            Else
                AddListItem(lstSoft, 12, IO.Path.GetFileName(fil))
            End If
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items(ount).SubItems.Add("File")
            AddListSubItem(lstSoft, ount, sSize & " KB")
            'List.Items(ount).SubItems.Add(sSize)
            ount += 1
            sizedother += sSize
        End If
            If File.Exists(fil2) = True Then
            'List.Items.Add(fil2, 12)
            If My.Settings.disas = "0" Then
                AddListItem(lstSoft, 12, fil2)
            Else
                AddListItem(lstSoft, 12, IO.Path.GetFileName(fil2))
            End If
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil2)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items(ount).SubItems.Add("File")
            'List.Items(ount).SubItems.Add(sSize)
            AddListSubItem(lstSoft, ount, sSize & " KB")
            ount += 1
            sizedother += sSize
        End If
            Return Nothing
    End Function
    Public Function AdobeSear()
        If Functiod.SoftCache.GetAdobeSearch <> "" Then
            Dim sear As String = Functiod.SoftCache.GetAdobeSearch
            For Each filinfold In Directory.GetFiles(sear)
                'List.Items.Add(filinfold, 12)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, filinfold)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add(sSize & " KB")
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function AdobeCac()
        If Functiod.SoftCache.GetAdobeCache <> "" Then
            Dim sear As String = Functiod.SoftCache.GetAdobeCache
            For Each filinfold In Directory.GetFiles(sear)
                'List.Items.Add(filinfold, 12)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, filinfold)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Shared countlog As Integer = 0
    Public Function GetLogFiles()
        '.log
        For Each filinfold In Directory.GetFiles(Functiod.WindowsItems.GetWindowsLog)
            If IO.Path.GetExtension(filinfold) = ".log" Then
                If FileInUse(filinfold) = False Then
                    If My.Settings.disas = "0" Then
                        AddListItem(lstWER, 0, filinfold)
                    Else
                        AddListItem(lstWER, 0, IO.Path.GetFileName(filinfold))
                    End If
                    'strin.Text = "Status : " & filinfold
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items.Add(count).SubItems.Add("File")
                    'List.Items(ount).SubItems.Add("File")
                    AddListSubItem(lstWER, countlog, sSize & " KB")
                    ' MsgBox(filinfold & "File" & sSize)
                    countlog += 1
                    sizedother += sSize
                End If
                End If
        Next
        For Each fold In Directory.GetDirectories(Functiod.WindowsItems.GetWindowsLog)
            For Each filinfold In Directory.GetFiles(fold)
                If IO.Path.GetExtension(filinfold) = ".log" Then
                    If FileInUse(filinfold) = False Then
                        If My.Settings.disas = "0" Then
                            AddListItem(lstWER, 0, filinfold)
                        Else
                            AddListItem(lstWER, 0, IO.Path.GetFileName(filinfold))
                        End If
                        'strin.Text = "Status : " & filinfold
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(ount).SubItems.Add("File")
                        AddListSubItem(lstWER, countlog, sSize & " KB")
                        ' MsgBox(filinfold & "File" & sSize)
                        countlog += 1
                        sizedother += sSize
                    End If
                    End If
            Next
        Next
        Return Nothing
    End Function
    Public Function GetThumbCache()
        For Each filinfold In Directory.GetFiles(Functiod.WindowsItems.WEThumbCache)
            If IO.Path.GetExtension(filinfold) = ".db" Then
                If FileInUse(filinfold) = False Then
                    If My.Settings.disas = "0" Then
                        AddListItem(lstTemp, 1, filinfold)
                    Else
                        AddListItem(lstTemp, 1, IO.Path.GetFileName(filinfold))
                    End If
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'List.Items(ount).SubItems.Add("File")
                        AddListSubItem(lstTemp, counttemp, sSize & " KB")
                        counttemp += 1
                        sizedother += sSize
                    End If
                End If
        Next
        Return Nothing
    End Function
    Public Function GetWER()
        For Each fold In Directory.GetDirectories(Functiod.WindowsItems.WindowsErrorReporting)
            For Each fol In Directory.GetDirectories(fold)
                For Each fil In Directory.GetFiles(fol)
                    If My.Settings.disas = "0" Then
                        AddListItem(lstWER, 0, fil)
                    Else
                        AddListItem(lstWER, 0, IO.Path.GetFileName(fil))
                    End If
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items(ount).SubItems.Add("File")
                    AddListSubItem(lstWER, countlog, sSize & " KB")
                    ' MsgBox(filinfold & "File" & sSize)
                    countlog += 1
                    sizedother += sSize
                Next
            Next
        Next
        Return Nothing
    End Function
    Public Function GetWER2()
        If Functiod.WindowsItems.WindowsErrorReporting2 <> "" Then
            For Each fold In Directory.GetDirectories(Functiod.WindowsItems.WindowsErrorReporting2)
                For Each fol In Directory.GetDirectories(fold)
                    For Each fil In Directory.GetFiles(fol)
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstWER, 0, fil)
                        Else
                            AddListItem(lstWER, 0, IO.Path.GetFileName(fil))
                        End If
                        'List.Items(ount).SubItems.Add("File")
                        AddListSubItem(lstWER, countlog, sSize & " KB")
                        countlog += 1
                        sizedother += sSize
                    Next
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Function GetRecentItems()
        For Each fileinfol In Directory.GetFiles(Functiod.windowsfolders.WindowsRecent)
            If My.Settings.disas = "0" Then
                AddListItem(lstWER, 0, fileinfol)
            Else
                AddListItem(lstWER, 0, IO.Path.GetFileName(fileinfol))
            End If
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfol)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items(ount).SubItems.Add("File")
            AddListSubItem(lstWER, countlog, sSize & " KB")
            countlog += 1
            sizedother += sSize
        Next
        Return Nothing
    End Function
    Public Function GetWindowsMediaPlayerArtCac()
        For Each fileinfold In Directory.GetFiles(Functiod.WindowsItems.WindowsMediaPlayerArtCac)
            If My.Settings.disas = "0" Then
                AddListItem(lstSoft, 12, fileinfold)
            Else
                AddListItem(lstSoft, 12, IO.Path.GetFileName(fileinfold))
            End If
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items(ount).SubItems.Add("File")
            AddListSubItem(lstSoft, ount, sSize & " KB")
            ount += 1
            sizedother += sSize
        Next
        Return Nothing
    End Function
    Public Function FlashPlayerCac()
        For Each fold In Directory.GetDirectories(Functiod.SoftCache.FlashCache)
            For Each fil In Directory.GetFiles(fold)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, fil)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(fil))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add("File")
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ' MsgBox(sSize & "Size")
                'MsgBox("ount : " & ount)
                ount += 1
                sizedother += sSize
            Next

        Next
        For Each fil In Directory.GetFiles(Functiod.SoftCache.FlashCache)
            If My.Settings.disas = "0" Then
                AddListItem(lstSoft, 12, fil)
            Else
                AddListItem(lstSoft, 12, IO.Path.GetFileName(fil))
            End If
            'MsgBox(fil)
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            ' List.Items(ount).SubItems.Add("File")
            AddListSubItem(lstSoft, ount, sSize & " KB")
            ount += 1
            sizedother += sSize
        Next
        Return Nothing
    End Function
    Public Function FlashPlayerOth()
        For Each fold In Directory.GetDirectories(Functiod.SoftCache.FlashCacheOthers)
            For Each oneinfold In Directory.GetDirectories(fold)
                For Each filinfold In Directory.GetFiles(oneinfold)
                    'MsgBox(filinfold & " 0")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstSoft, 12, filinfold)
                    Else
                        AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                    End If

                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'MsgBox("First" & sSize)
                    AddListSubItem(lstSoft, ount, sSize & " KB")
                    ount += 1
                    sizedother += sSize
                Next
                For Each twoinfold In Directory.GetDirectories(oneinfold)
                    For Each filinfold In Directory.GetFiles(twoinfold)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstSoft, 12, filinfold)
                        Else
                            AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                        End If
                        ' MsgBox(filinfold & " 1")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        'MsgBox("Second" & sSize)
                        AddListSubItem(lstSoft, ount, sSize & " KB")
                        ount += 1
                        'sizedother += sSize
                    Next
                    For Each threinfold In Directory.GetDirectories(twoinfold)
                        For Each filinfold In Directory.GetFiles(threinfold)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstSoft, 12, filinfold)
                            Else
                                AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                            End If
                            ' MsgBox(filinfold & " 2")
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            'MsgBox("Third" & sSize)
                            AddListSubItem(lstSoft, ount, sSize & " KB")
                            ount += 1
                            'sizedother += sSize
                        Next
                    Next
                Next
                '        For Each fourinfold In Directory.GetDirectories(threinfold)
                '            For Each filinfold In Directory.GetFiles(fourinfold)
                '                AddListItem(lstSoft, 12, filinfold)
                '                MsgBox(filinfold & " 3")
                '                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                '                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                '                MsgBox("fourth" & sSize)
                '                AddListSubItem(lstSoft, ount, sSize & " KB")
                '                ount += 1
                '                'sizedother += sSize
                '            Next
                '            For Each fiveinfold In Directory.GetDirectories(fourinfold)
                '                For Each filinfold In Directory.GetFiles(fiveinfold)
                '                    AddListItem(lstSoft, 12, filinfold)
                '                    MsgBox(filinfold & " 4")
                '                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                '                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                '                    MsgBox("fifth" & sSize)
                '                    AddListSubItem(lstSoft, ount, sSize & " KB")
                '                    ount += 1
                '                    'sizedother += sSize
                '                Next
                '            Next
                '        Next
                '    Next
            Next
        Next
        'Next
        Return Nothing
    End Function
    Public Function GetUtrrntOldFls()
        For Each Fil In Directory.GetFiles(Functiod.SoftCache.UTrrntOldFls)
            If IO.Path.GetExtension(Fil) = ".old" Then
                If FileInUse(Fil) = False Then
                    If My.Settings.disas = "0" Then
                        AddListItem(lstSoft, 12, Fil)
                    Else
                        AddListItem(lstSoft, 12, IO.Path.GetFileName(Fil))
                    End If
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(Fil)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items(ount).SubItems.Add("File")
                    AddListSubItem(lstSoft, ount, sSize & " KB")
                    ount += 1
                    sizedother += sSize
                End If
                End If
        Next
        For Each fold In Directory.GetDirectories(Functiod.SoftCache.UTrrntOldFls)
            If fold = Functiod.SoftCache.UTrrntOldFls & "\dlimagecache" Then
                For Each Fil In Directory.GetFiles(fold)
                    If FileInUse(Fil) = False Then
                        'If IO.Path.GetExtension(Fil) = ".old" Then
                        'dlimagecache
                        If My.Settings.disas = "0" Then
                            AddListItem(lstSoft, 12, Fil)
                        Else
                            AddListItem(lstSoft, 12, IO.Path.GetFileName(Fil))
                        End If
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(Fil)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        ' List.Items(ount).SubItems.Add("File")
                        AddListSubItem(lstSoft, ount, sSize & " KB")
                        ount += 1
                        sizedother += sSize
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Function GetVLCArtCache()
        If Functiod.SoftCache.GetVLCMediaPlayerArtCache <> "" Then
            'MsgBox("ex")
            For Each foldinfold In Directory.GetDirectories(Functiod.SoftCache.GetVLCMediaPlayerArtCache)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    ' MsgBox("1")
                    If My.Settings.disas = "0" Then
                        AddListItem(lstSoft, 12, filinfold)
                    Else
                        AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                    End If

                    AddListSubItem(lstSoft, ount, sSize & " KB")
                    ount += 1
                    sizedother += sSize
                Next
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    For Each filinfold In Directory.GetFiles(secondinfold)
                        'MsgBox("2")
                        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                        If My.Settings.disas = "0" Then
                            AddListItem(lstSoft, 12, filinfold)
                        Else
                            AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                        End If
                        AddListSubItem(lstSoft, ount, sSize & " KB")
                        ount += 1
                        sizedother += sSize
                    Next
                    For Each thirdinfold In Directory.GetDirectories(secondinfold)
                        For Each filinfold In Directory.GetFiles(thirdinfold)
                            ' MsgBox("3")
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            If My.Settings.disas = "0" Then
                                AddListItem(lstSoft, 12, filinfold)
                            Else
                                AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                            End If
                            AddListSubItem(lstSoft, ount, sSize & " KB")
                            ount += 1
                            sizedother += sSize
                        Next
                        For Each fourthinfold In Directory.GetDirectories(thirdinfold)
                            For Each filinfold In Directory.GetFiles(fourthinfold)
                                'MsgBox("4")
                                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                                If My.Settings.disas = "0" Then
                                    AddListItem(lstSoft, 12, filinfold)
                                Else
                                    AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                                End If
                                AddListSubItem(lstSoft, ount, sSize & " KB")
                                ount += 1
                                sizedother += sSize
                            Next
                        Next
                    Next
                Next
            Next
        End If
        Return Nothing
    End Function
    Private Sub OtherFiles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Location = New Point(main.Location.X + 24, main.Location.Y + 65)
        'Me.Size = New Size(main.panCleaner.Width - 12, main.panCleaner.Height + 20)
        count = 0
        tmrDialogPopup.Enabled = True
        bttnClose.Visible = True
        CloseToolStripMenuItem.Enabled = False
    End Sub
    Dim count
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
        Dim itms = lstSoft.Items.Count + lstTemp.Items.Count + lstWER.Items.Count
        If itms >= 500 Then
            popup(Color.Firebrick, Color.IndianRed)
        ElseIf itms > 200 Then
            popup(Color.DarkGoldenrod, Color.Goldenrod)
        Else
            popup(Color.SteelBlue, Color.LightSteelBlue)
        End If
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        main.ControlBox = True
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        main.ControlBox = True
        Me.Close()
    End Sub
    Public Function OfficeRecent()
        If Functiod.SoftCache.OfficeRecent <> "" Then
            For Each fil In Directory.GetFiles(Functiod.SoftCache.OfficeRecent)
                'List.Items.Add(fil, 12)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, fil)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(fil))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add("File")
                'List.Items(ount).SubItems.Add(sSize & " KB")
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            Next
        End If
        Return Nothing
    End Function
    Public Function NotepadPlusPlus()
        Dim filde = Functiod.SoftCache.NotepadplusplusSes & "\session.xml"
        If File.Exists(filde) = True Then
            'List.Items.Add(filde, 12)
            If My.Settings.disas = "0" Then
                AddListItem(lstSoft, 12, filde)
            Else
                AddListItem(lstSoft, 12, IO.Path.GetFileName(filde))
            End If
            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filde)
            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
            'List.Items(ount).SubItems.Add("File")
            'List.Items(ount).SubItems.Add(sSize & " KB")
            AddListSubItem(lstSoft, ount, sSize & " KB")
            ount += 1
            sizedother += sSize
        End If
            Return Nothing
    End Function
    Public Function EvernoteLogs()
        For Each fil In Directory.GetFiles(Functiod.SoftCache.EvernoteLogs)
            If FileInUse(fil) = False Then
                'List.Items.Add(fil, 15)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 15, fil)
                Else
                    AddListItem(lstSoft, 15, IO.Path.GetFileName(fil))
                End If
                'List.Items(ount).SubItems.Add("File")
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fil)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add(sSize & " KB")
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            End If
        Next
        Return Nothing
    End Function
    Public Function freemakecac()
        For Each fileinfold In Directory.GetFiles(Functiod.SoftCache.freemake)
            If FileInUse(fileinfold) = False Then
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, fileinfold)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(fileinfold))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(fileinfold)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            End If
        Next
        Return Nothing
    End Function
    Public Function AxilIconWork()
        For Each fold In Directory.GetDirectories(Functiod.SoftCache.GetAxcilIconWork)
            ' MsgBox("1")
            For Each filinfold In Directory.GetFiles(fold)
                'MsgBox("2")
                'List.Items.Add(filinfold, 12)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, filinfold)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'MsgBox("enabled2")
                'List.Items(ount).SubItems.Add(sSize & " KB")
                AddListSubItem(lstSoft, ount, sSize & " KB")

                ount += 1
                sizedother += sSize
            Next
        Next
        Return Nothing
    End Function
    Public Function Quick()
        For Each filinfold In Directory.GetFiles(Functiod.SoftCache.GetQuickTime)
            If IO.Path.GetExtension(filinfold) = ".xml" Then
                'List.Items.Add(filinfold, 12)
                If My.Settings.disas = "0" Then
                    AddListItem(lstSoft, 12, filinfold)
                Else
                    AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                End If
                Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                'List.Items(ount).SubItems.Add(sSize & " KB")
                AddListSubItem(lstSoft, ount, sSize & " KB")
                ount += 1
                sizedother += sSize
            End If
        Next
        Return Nothing
    End Function

    Public Function QuickLow()
        For Each foldinfold In Directory.GetDirectories(Functiod.SoftCache.GetQuickTimeLocalLow)
            For Each foldin In Directory.GetDirectories(foldinfold)
                For Each filinfold In Directory.GetFiles(foldin)
                    'List.Items.Add(filinfold, 12)
                    If My.Settings.disas = "0" Then
                        AddListItem(lstSoft, 12, filinfold)
                    Else
                        AddListItem(lstSoft, 12, IO.Path.GetFileName(filinfold))
                    End If
                    Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                    Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                    'List.Items(ount).SubItems.Add(sSize & " KB")
                    AddListSubItem(lstSoft, ount, sSize & " KB")
                    ount += 1
                    sizedother += sSize
                Next
            Next
        Next
        Return Nothing
    End Function
    Public Shared errormessage As String
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
        Dim chkedVLCMedia = ""
        Dim chkedFreemake = ""
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
                    If dls.Name = "checkedFreemake" Then
                        chkedFreemake = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedVLCMedia" Then
                        chkedVLCMedia = dls.ReadInnerXml.ToString
                    End If
                    'Exit While
                End If
            End While
            dls.Close()
        Else
        End If
        Try
            If chkedFlsh = "true" And SoftCache.FlashCache <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Flash Player Cache..."
                'retrieval.SoftwareCac.FlashPlayerCa(lstCleanerOtherfls)
                FlashPlayerCac()

                BackgroundWorker1.ReportProgress(10)
                'progressbarsec.Value = 87
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : FlshPlyrCac ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If chkedFreemake = "true" And SoftCache.freemake <> "" Then
                freemakecac()
                BackgroundWorker1.ReportProgress(15)
            End If
           
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "error occured at : freemakecac (404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If chkedQuick = "true" And SoftCache.GetQuickTime <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Apple QuickTime Temp Files..."
                ' retrieval.SoftwareCac.Quick(lstCleanerOtherfls)
                Quick()
                BackgroundWorker1.ReportProgress(20)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : Quick ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedQuick = "true" And SoftCache.GetQuickTimeLocalLow <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Apple QuickTime Temp Files..."
                'retrieval.SoftwareCac.QuickLow(lstCleanerOtherfls)
                QuickLow()
                BackgroundWorker1.ReportProgress(25)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : Quick Local Low ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedFlsh = "true" And SoftCache.FlashCacheOthers <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Flash Player Cache..."
                'retrieval.SoftwareCac.FlashPlayerOth(lstCleanerOtherfls)

                FlashPlayerOth()
                BackgroundWorker1.ReportProgress(28)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : FlashPlyrOther ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedAxIcon = "true" And SoftCache.GetAxcilIconWork <> "" Then
                'MsgBox("Checked")
                main.lblScanStatus.Text = "Status : Scanning Axialis icon workshop Items..."
                AxilIconWork()
                'retrieval.SoftwareCac.AxilIconWork(lstCleanerOtherfls)
                'Progressbar1.Value = 83
                'progressbarsec.Value = 91
                BackgroundWorker1.ReportProgress(30)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : Axialicnwrkshp ( 404 or 405 or 202 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedLog = "true" And WindowsItems.GetWindowsLog <> "" Then
                ' retrieval.WindowsItems.GetLogFiles(OtherFiles.lstWER)
                main.lblScanStatus.Text = "Status : Scanning Windows Logs..."
                GetLogFiles()
                BackgroundWorker1.ReportProgress(32)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at LgFls( 404 or 405 or 201 )" & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedEver = "true" And Functiod.SoftCache.EvernoteLogs <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Evernote Files..."
                EvernoteLogs()
                'retrieval.SoftwareCac.EvernoteLogs(lstCleanerOtherfls)
                BackgroundWorker1.ReportProgress(35)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at EvrNtLgs ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedUtr = "true" And Functiod.SoftCache.UTrrntOldFls <> "" Then
                'retrieval.SoftwareCac.GetUtrrntOldFls(lstCleanerOtherfls)
                main.lblScanStatus.Text = "Status : Scanning Utorrent Files"
                GetUtrrntOldFls()
                BackgroundWorker1.ReportProgress(38)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at UTrrOldFls ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If chkedNotPlPl = "true" And Functiod.SoftCache.NotepadplusplusSes <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Notepad Plus Plus Files..."
                ' retrieval.SoftwareCac.NotepadPlusPlus(lstCleanerOtherfls)
                NotepadPlusPlus()
                BackgroundWorker1.ReportProgress(39)
                'Progressbar1.Value = 45
                'progressbarsec.Value = 45
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at NotePdPlsPls ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If SoftCache.GetAdobeCache <> "" And chkedAdRd = "true" Then
                main.lblScanStatus.Text = "Status : Scanning Adobe Reader Cache..."
                'retrieval.SoftwareCac.AdobeCac(lstCleanerOtherfls)
                AdobeCac()
                BackgroundWorker1.ReportProgress(40)
                'Progressbar1.Value = 78
                'progressbarsec.Value = 78
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : AdobRdCac ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If SoftCache.GetAdobeSearch <> "" And chkedAdRd = "true" Then
                main.lblScanStatus.Text = "Status : Scanning Adobe Reader Search Cache..."
                'retrieval.SoftwareCac.AdobeSear(lstCleanerOtherfls)
                AdobeSear()
                BackgroundWorker1.ReportProgress(45)
                'Progressbar1.Value = 80
                'progressbarsec.Value = 79
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : AdobRdSear ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedVLCMedia = "true" Then
                GetVLCArtCache()
                ' MsgBox("something")
                BackgroundWorker1.ReportProgress(46)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : VLC ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.GetIDM <> "" And chkedIDM = "true" Then
                main.lblScanStatus.Text = "Status : Scanning IDM..."
                'retrieval.SoftwareCac.IDM(lstCleanerOtherfls)
                IDM()
                BackgroundWorker1.ReportProgress(50)
                'Progressbar1.Value = 85
                'progressbarsec.Value = 80
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occured at : IDM ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If Functiod.SoftCache.OfficeRecent <> "" And chkedOffRec = "true" Then
                ' retrieval.SoftwareCac.OfficeRecent(lstCleanerOtherfls)
                main.lblScanStatus.Text = "Status : Scanning Microsoft Office Recent Files"
                OfficeRecent()
                BackgroundWorker1.ReportProgress(55)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at OffRec ( 404 or 405 or 222 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If GetTempFilesWindows() <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Folders in Windows Temp Folder..."
                'retrieval.GetTempDirWindDir(lstCleanerOtherfls)
                GetTempDirWind()
                'GetTempFilesWindows()
                'Progressbar1.Value = 94
                BackgroundWorker1.ReportProgress(58)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : TmpWndDr ( 404 or 405 or 201 )" & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If GetTempDirectory() <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Folders in Temp Folder..."
                'retrieval.TempFoldfolder(lstCleanerOtherfls)
                'GetTempDirectory()
                TempFiles()
                'BackgroundWorker1.ReportProgress(48)                'Progressbar1.Value = 95
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : TmpFold ( 404 or 405 or 201 )" & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If chkedWER = "true" And Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Windows Error Reporting..."
                'Functiod.retrieval.WindowsItems.GetWER(OtherFiles.lstWER)
                'Functiod.retrieval.WindowsItems.GetWER2(OtherFiles.lstWER)
                GetWER()
                GetWER2()
                BackgroundWorker1.ReportProgress(60)
                'Progressbar1.Value = 94
                'progressbarsec.Value = 96
            End If
            'MsgBox("true")
        Catch ex As Exception
            'MsgBox(ex.ToString)
            errormessage = errormessage & vbNewLine & "Error Ocurred at : WER ( 404 or 405 or 234 ) " & ex.ToString
            errormessage = errormessage & vbNewLine & "Error skipped at : WER ( 666 or 777 ) "
            'Crash_Box.ShowDialog()
        End Try

        Try
            If chkedWinThum = "true" And Functiod.WindowsItems.WEThumbCache <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Thumbnail Cache..."
                'Functiod.retrieval.WindowsItems.GetThumbCache(OtherFiles.lstTem)
                GetThumbCache()
                'Progressbar1.Value = 96
                'progressbarsec.Value = 97
                BackgroundWorker1.ReportProgress(61)
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at WEThumbCache ( 404 or 405 or 234 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedWMP = "true" And Functiod.WindowsItems.WindowsMediaPlayerArtCac <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Windows Media Player art Cache..."
                ' Functiod.retrieval.WindowsItems.GetWindowsMediaPlayerArtCac(lstCleanerOtherfls)
                GetWindowsMediaPlayerArtCac()
                BackgroundWorker1.ReportProgress(62)
                'Progressbar1.Value = 97
                'progressbarsec.Value = 98
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : WMPArtCac ( 404 or 405 or 234 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        'Try
        '    If chkedWMP = "true" And Functiod.WindowsItems.WindowsMediaPlayerCache <> "" Then
        '        lblScanStatus.Text = "Status : Scanning Windows Media Player Cache..."
        '        Functiod.retrieval.WindowsItems.GetWindowsMediaPlayerCache(lstCleanerOtherfls)
        '        Progressbar1.Value = 98
        '    End If
        'Catch ex As Exception
        '    errormessage = errormessage & vbNewLine & "Error Occurred at : WMPCac ( 404 or 405 or 234 ) " & ex.ToString
        '    Crash_Box.ShowDialog()
        'End Try

        Try
            If chkedWinRec = "true" And Functiod.windowsfolders.WindowsRecent <> "" Then
                main.lblScanStatus.Text = "Status : Scanning Windows Recent Files..."
                'Functiod.retrieval.WindowsItems.GetRecentItems(OtherFiles.lstWER)
                GetRecentItems()
                BackgroundWorker1.ReportProgress(100)
                'Progressbar1.Value = 99
                'progressbarsec.Value = 99
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : WinRec ( 404 or 405 or 234 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try


        Return Nothing
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        
        counttemp = 0
        countlog = 0
        ount = 0
        analyze()
        'TempFiles()
        'GetTempDirWind()
        'GetLogFiles()
        'GetWindowsMediaPlayerArtCac()
        'FlashPlayerCac()
        'FlashPlayerOth()
        'GetWER()
        'GetWER2()
        'GetUtrrntOldFls()
        'IDM()
        'AdobeCac()
        'AdobeSear()
        'OfficeRecent()
        'NotepadPlusPlus()
        'EvernoteLogs()
        'AxilIconWork()
        'Quick()
        'QuickLow()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        main.prgOthrFls.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'lstSoft.Visible = True
        'lstTemp.Visible = True
        'lstWER.Visible = True
        If lstSoft.Items.Count <> 0 Or lstTemp.Items.Count <> 0 Or lstWER.Items.Count <> 0 Then
            TabControl3.Visible = True
            main.prgOthrFls.Visible = False
            Dim sizeedd = Math.Round(OtherFiles.sizedother / 1024, 2)
            Dim szd
            If sizeedd > 1024 Then
                sizeedd = Math.Round(OtherFiles.sizedother / 1024 / 1024, 2)
                szd = sizeedd & " GB"
            Else
                sizeedd = Math.Round(OtherFiles.sizedother / 1024, 2)
                szd = sizeedd & " MB"
            End If
            Dim szced = lstTemp.Items.Count() + lstWER.Items.Count + lstSoft.Items.Count() & " Files ( " & szd & " Approx ) "
            tbSoft.Text = lstSoft.Items.Count() & " Items"
            tbTemp.Text = lstTemp.Items.Count() & " Items"
            tbWER.Text = lstWER.Items.Count() & " Items"
            lblSzonDsk.Text = szced
            main.lblOthFlsSiz.Text = szced
            main.lblOthFlsSiz.Visible = True
            bttnClose.Visible = True
            CloseToolStripMenuItem.Enabled = True
            main.PictureBox8.Image = My.Resources._1390669896_bullet_yellow
            main.panPopupMess.BackColor = Color.Firebrick
            main.Label1.ForeColor = Color.White

            main.Label1.Text = "Scanning Completed. Unwanted files found if you want to delete the temp file click clean below"
            main.lblScanStatus.Visible = False
            main.bttnScanFiles.Enabled = True
        Else
            main.Label1.Text = "Scanning Completed"
            main.lblScanStatus.Text = "Scanning Complete"
            main.lblScanStatus.Visible = False
            main.prgOthrFls.Visible = False
            main.lblOthFlsSiz.Visible = True
            main.lblOthFlsSiz.Text = "(No Information)"
        End If

        main.tmrloadanisp2.Enabled = False
        main.tmrloadanisp2rev.Enabled = False
        main.tmrloadanimation.Enabled = False
        main.tmrloadanimationrev.Enabled = False
        main.panoverscan.Visible = False
        main.Panel12.Visible = False
        main.lod2.Visible = False
        Debug_Info.ListBox1.Items.Add("Scanning System for Other Files Completed at " & My.Computer.Clock.LocalTime)
    End Sub

    Private Sub bttnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        main.ControlBox = True
        Me.Close()
    End Sub

    Private Sub bttnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            lstSoft.View = View.Tile
            lstTemp.View = View.Tile
            lstWER.View = View.Tile
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
            lstSoft.View = View.Details
            lstTemp.View = View.Details
            lstWER.View = View.Details
        End If
    End Sub
End Class