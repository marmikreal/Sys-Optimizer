'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyleft (C) 2012-2013 A-Soft. All Rights Reserved.                      #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyleft (C) 2010-2013 Arvin Soft. All Rights Reserved.                      #
'##############################################################################################
Imports System.IO

Public Class removal
    Public Shared Function InternetFiles()
        If Functiod.Cache.getInernetFiles <> "" Then
            For Each folded In Directory.GetDirectories(Functiod.Cache.getInernetFiles)
                Try
                    Directory.Delete(folded)
                Catch ex As Exception

                End Try
                If folded <> "" Then
                    If Directory.Exists(folded) = True Then
                        For Each filed In Directory.GetFiles(folded)
                            Dim foldex = Directory.Exists(folded)
                            If foldex = True Then
                                Try
                                    File.Delete(filed)
                                Catch ex As Exception
                                End Try
                            End If
                        Next
                        For Each fod In Directory.GetDirectories(folded)
                            For Each fileinfod In Directory.GetFiles(fod)
                                Try
                                    File.Delete(fileinfod)
                                Catch ex As Exception
                                End Try
                            Next
                        Next
                    End If
                End If
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function IEDtBse()
        If Functiod.Cache.GetIEDtBses <> "" Then
            For Each fil In Directory.GetFiles(Functiod.Cache.GetIEDtBses)
                Try
                    File.Delete(fil)
                Catch ex As Exception
                End Try
            Next
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEDtBses)
                For Each fil In Directory.GetFiles(fold)
                    Try
                        File.Delete(fil)
                    Catch ex As Exception
                    End Try
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function InternetExFiles()
        If Functiod.Cache.GetIEFiles <> "" Then
            'MsgBox("true")
            For Each files In Directory.GetFiles(Functiod.Cache.GetIEFiles)
                Try
                    File.Delete(files)
                Catch ex As Exception
                End Try
                ' MsgBox("Internet Ex Files " & Functiod.Cache.GetIEFiles & sized)
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function IEFeedsCache()
        If Functiod.Cache.GetIEFeedsCache <> "" Then
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFeedsCache)
                For Each fil In Directory.GetFiles(fold)
                    If IO.Path.GetExtension(fil) <> ".ini" Then
                        Try
                            File.Delete(fil)
                        Catch ex As Exception
                        End Try
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ContentIE5()
        If Functiod.Cache.GetIEFilesContentIE5 <> "" Then
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFilesContentIE5)
                For Each fild In Directory.GetFiles(fold)
                    Try
                        'MsgBox(fild)
                        File.Delete(fild)
                    Catch ex As Exception
                    End Try
                Next
            Next
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetIEFilesContentIE5)
                For Each foldinfold In Directory.GetDirectories(fold)
                    For Each fil In Directory.GetFiles(foldinfold)
                        Try
                            File.Delete(fil)
                        Catch ex As Exception
                        End Try
                    Next
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function IECookies()
        If Functiod.Cache.GetIECookies <> "" Then
            For Each FileunFol In Directory.GetFiles(Functiod.Cache.GetIECookies)
                Try
                    File.Delete(FileunFol)
                Catch ex As Exception
                    'MsgBox("Error Occurred Contact Product manufacturer", MsgBoxStyle.Critical + vbOKOnly, "Error Occurred")
                End Try
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function TempFiles()
        For Each filepath In Directory.GetFiles(Functiod.retrieval.GetTempDirectory)
            Dim spath
            spath = filepath
            Try
                File.Delete(spath)
            Catch ex As Exception

            End Try
        Next
        For Each folder In Directory.GetDirectories(Functiod.retrieval.GetTempDirectory())
            Try
                Directory.Delete(folder, True)
            Catch ex As Exception

            End Try
        Next
        Return Nothing
    End Function

    Public Shared Function TempFileWinDir()
        For Each filepath In Directory.GetFiles(Functiod.Cache.GetTempFilesWindows)
            Dim spath
            spath = filepath
            Try
                File.Delete(spath)
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        Next
        For Each Folder In Directory.GetDirectories(Functiod.Cache.GetTempFilesWindows())
            Try
                Directory.Delete(Folder, True)
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        Next
        Return Nothing
    End Function

    Public Class Opera
        Public Shared Function OperaStableCacheNew()
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableCacheNew)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function OperaStableGPUCacheNew()
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableGPUCacheNew)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function OperaStableJumpListIconsNew()
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableJumpListIconsNew)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function OperaStableJumpListIconOldNew()
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableJumpListIconsOldNew)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function OperaStableLocalStorageNew()
            For Each filinfold In Directory.GetFiles(Functiod.Cache.GetOperaStableLocalStorageNew)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function OperaCache()
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetOperaCache)
                For Each fileinfold In Directory.GetFiles(fold)
                    Try
                        File.Delete(fileinfold)
                    Catch ex As Exception
                    End Try
                Next
            Next
            For Each Files In Directory.GetFiles(Functiod.Cache.GetOperaCache)
                Try
                    File.Delete(Files)
                Catch ex As Exception

                End Try
            Next
            For Each fold In Directory.GetDirectories(Functiod.Cache.GetOperaCache)
                For Each fol In Directory.GetDirectories(fold)
                    For Each filinfol In Directory.GetFiles(fol)
                        Try
                            File.Delete(filinfol)
                        Catch ex As Exception

                        End Try
                    Next
                Next
            Next
            Return Nothing
        End Function
        Public Shared Function OperaSessions()
            If Functiod.Cache.GetOperaOthers <> "" Then
                For Each files In Directory.GetFiles(Functiod.Cache.GetOperaOthers & "\Sessions")
                    Try
                        File.Delete(files)
                    Catch ex As Exception

                    End Try
                Next
            End If
            Return Nothing
        End Function

        Public Shared Function OperaCachVps()
            If Functiod.Cache.GetOperaStandard <> "" Then
                For Each fold In Directory.GetDirectories(Cache.GetOperaStandard & "\vps")
                    For Each filinfold In Directory.GetFiles(fold)
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    Next
                Next
            End If
            Return Nothing
        End Function

        Public Shared Function OperaOpCache()
            If Functiod.Cache.GetOperaStandard <> "" Then
                For Each fold In Directory.GetDirectories(Cache.GetOperaStandard & "\opcache")
                    For Each fol In Directory.GetFiles(fold)
                        Try
                            File.Delete(fol)
                        Catch ex As Exception

                        End Try
                    Next
                Next
                For Each fil In Directory.GetFiles(Cache.GetOperaStandard & "\opcache")
                    Try
                        File.Delete(fil)
                    Catch ex As Exception

                    End Try
                Next
            End If
            Return Nothing
        End Function

        Public Shared Function OperaIconCache()
            If Functiod.Cache.GetOperaStandard <> "" Then
                For Each fold In Directory.GetDirectories(Functiod.Cache.GetOperaStandard & "\icons\cache")
                    For Each filinfold In Directory.GetFiles(fold)
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    Next
                Next
                For Each fil In Directory.GetFiles(Functiod.Cache.GetOperaStandard & "\icons\cache")
                    Try
                        File.Delete(fil)
                    Catch ex As Exception

                    End Try
                Next
            End If
            If Cache.GetOperaStandard <> "" Then
                Dim OpIconFol As String
                OpIconFol = Cache.GetOperaStandard & "\icons"
                Dim opIconFolex As Boolean
                opIconFolex = Directory.Exists(OpIconFol)
                If opIconFolex = True Then
                    For Each filinfold In Directory.GetFiles(OpIconFol)
                        If IO.Path.GetExtension(filinfold) = ".idx" Then
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception
                            End Try
                        End If
                        If IO.Path.GetExtension(filinfold) = ".png" Then
                            Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
                            Dim sSize = Math.Round(sinfo.Length / 1024, 2)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                End If
            End If


            Return Nothing
        End Function
        Public Shared Function OperaTemp_Down()
            'temporary_downloads
            Dim opTempDown As String
            opTempDown = Cache.GetOperaStandard & "\temporary_downloads"
            Dim opTempDownex As Boolean
            opTempDownex = Directory.Exists(opTempDown)
            If opTempDownex = True Then
                For Each fileinfold In Directory.GetFiles(opTempDown)
                    If IO.Path.GetExtension(fileinfold) = ".exe" Then
                        Try
                            File.Delete(fileinfold)
                        Catch ex As Exception

                        End Try
                    End If
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function OperaJmpLstIcnCache()
            If Functiod.Cache.GetOperaStandard <> "" Then
                Dim opJmpLstIconCache = Cache.GetOperaStandard & "\jumplist_icon_cache"
                Dim opJmpLstIconCacheex As Boolean
                opJmpLstIconCacheex = IO.Directory.Exists(opJmpLstIconCache)
                If opJmpLstIconCacheex = True Then
                    For Each fil In Directory.GetFiles(opJmpLstIconCache)
                        Try
                            File.Delete(fil)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            End If
            Return Nothing
        End Function
        Public Shared Function OperaTypedHstry()
            If Functiod.Cache.GetOperaOthers <> "" Then
                Dim OperaTypedHstryfl As String
                OperaTypedHstryfl = Cache.GetOperaOthers & "\typed_history.xml"
                Dim OperaTypedHstryflex As Boolean
                OperaTypedHstryflex = File.Exists(OperaTypedHstryfl)
                If OperaTypedHstryflex = True Then
                    Try
                        File.Delete(OperaTypedHstryfl)
                    Catch ex As Exception

                    End Try
                End If
            End If
            Return Nothing
        End Function
        Public Shared Function OperaOthers()
            Dim operadownloads As String
            operadownloads = Cache.GetOperaOthers & "\Download.dat"
            If File.Exists(operadownloads) = True Then
                Try
                    File.Delete(operadownloads)
                Catch ex As Exception
                End Try
            End If
            Dim operaglobalhis As String
            operaglobalhis = Cache.GetOperaOthers & "\global_history.dat"
            If File.Exists(operaglobalhis) = True Then
                Try
                    File.Delete(operaglobalhis)
                Catch ex As Exception
                End Try
            End If
            Dim vlink As String
            vlink = Cache.GetOperaOthers & "\vlink4.dat"
            If File.Exists(vlink) = True Then
                Try
                    File.Delete(vlink)
                Catch ex As Exception
                End Try
            End If
            Return Nothing
        End Function
    End Class
    Public Class Thunderbird
        Public Shared Function ThunderbirdCache()
            For Each cache In Directory.GetDirectories(Functiod.Cache.GetThunderbirdCache)
                Dim sexis
                sexis = Directory.Exists(cache & "\Cache")
                If sexis = True Then
                    For Each files In Directory.GetFiles(cache & "\Cache")
                        Try
                            File.Delete(files)
                        Catch ex As Exception

                        End Try
                    Next
                    For Each folder In Directory.GetDirectories(cache & "\Cache")
                        Try
                            Directory.Delete(folder, True)
                        Catch ex As Exception

                        End Try
                    Next
                    For Each filess In Directory.GetFiles(cache)
                        Try
                            File.Delete(filess)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            Next
            Return Nothing
        End Function
        Public Shared Function ThunderbirdSes()
            For Each sesprodir In Directory.GetDirectories(Functiod.Cache.GetThunderbirdSes)
                Dim name = sesprodir & "\session.json"
                If File.Exists(name) = True Then
                    Try
                        File.Delete(name)
                    Catch ex As Exception
                    End Try
                End If
            Next
            Return Nothing
        End Function
    End Class
    Public Shared Function FirefoxCache()
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
                                Try
                                    File.Delete(foldin)
                                Catch ex As Exception

                                End Try
                            Next
                        Next
                    Next
                    For Each foldinfold In Directory.GetDirectories(cache)
                        For Each filinfold In Directory.GetFiles(foldinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                    Next
                    For Each files In Directory.GetFiles(cache)
                        Try
                            File.Delete(files)
                        Catch ex As Exception

                        End Try
                        ' On Error Resume Next
                    Next
                    'For Each folder In Directory.GetDirectories(cache & "\Cache")
                    '    List.Items.Add(folder)
                    '    On Error Resume Next
                    'Next
                    For Each filess In Directory.GetFiles(cache)
                        Try
                            File.Delete(filess)
                        Catch ex As Exception

                        End Try
                        ' On Error Resume Next
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'For Each cache In Directory.GetDirectories(Functiod.Cache.GetFirefoxCache)
        '    Dim sexis
        '    sexis = Directory.Exists(cache & "\Cache")
        '    If sexis = True Then
        '        For Each files In Directory.GetFiles(cache & "\Cache")
        '            Try
        '                File.Delete(files)
        '            Catch ex As Exception

        '            End Try
        '        Next
        '        For Each folder In Directory.GetDirectories(cache & "\Cache")
        '            Try
        '                Directory.Delete(folder, True)
        '            Catch ex As Exception

        '            End Try
        '        Next
        '        For Each filess In Directory.GetFiles(cache)
        '            Try
        '                File.Delete(filess)
        '            Catch ex As Exception

        '            End Try
        '        Next
        '    End If
        'Next
        Return Nothing
    End Function
    Public Shared Function FirefoxWebThumb()
        For Each cache In Directory.GetDirectories(Functiod.Cache.GetFirefoxCache)
            'C:\Users\Aravindh\AppData\Local\Mozilla\Firefox\Profiles\jftl47mb.default-1370183395194\thumbnails
            Dim sexis
            sexis = cache & "\thumbnails"
            If Directory.Exists(sexis) = True Then
                For Each fileinfold In Directory.GetFiles(sexis)
                    Try
                        File.Delete(fileinfold)
                    Catch ex As Exception
                    End Try
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function FirefoxJmpLst()
        If Functiod.Cache.GetFirefoxJumpLst <> "" Then
            For Each cached In Directory.GetDirectories(Functiod.Cache.GetFirefoxJumpLst)
                Dim sexis
                sexis = Directory.Exists(cached & "\jumpListCache")
                If sexis = True Then
                    For Each filesinfold In Directory.GetFiles(cached & "\jumpListCache")
                        Try
                            File.Delete(filesinfold)
                        Catch ex As Exception

                        End Try
                    Next
                End If
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function FirefoxMiscil()
        If Functiod.Cache.GetFirefoxMiscl <> "" Then
            For Each direct In Directory.GetDirectories(Functiod.Cache.GetFirefoxMiscl)
                If File.Exists(direct & "\downloads.sqlite") = True Then
                    File.Delete(direct & "\downloads.sqlite")
                End If
                If File.Exists(direct & "\sessionstore.js") = True Then
                    File.Delete(direct & "\sessionstore.js")
                End If
                If File.Exists(direct & "\sessionstore.bak") = True Then
                    File.Delete(direct & "\sessionstore.bak")
                End If
                If File.Exists(direct & "\content-prefs.sqlite") = True Then
                    File.Delete(direct & "\content-prefs.sqlite")
                End If
                If File.Exists(direct & "\places.sqlite") = True Then
                    File.Delete(direct & "\places.sqlite")
                End If
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function CanaryGPUCache()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each filinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each fold In Directory.GetDirectories(filinfold)
                    If IO.Path.GetFileNameWithoutExtension(fold) = "GPUCache" Then
                        ' MsgBox("e")
                        For Each fil In Directory.GetFiles(fold)
                            Try
                                File.Delete(fil)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ChromeGPUCache()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each filinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each fold In Directory.GetDirectories(filinfold)
                    If IO.Path.GetFileNameWithoutExtension(fold) = "GPUCache" Then
                        For Each fil In Directory.GetFiles(fold)
                            Try
                                File.Delete(fil)
                            Catch ex As Exception

                            End Try

                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ChromeLocalStore()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "Local Storage" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function CanaryLocalStore()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "Local Storage" Then
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ChromeJumplisticons()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "JumpListIcons" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function CanaryJumplisticons()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each secondinfold In Directory.GetDirectories(foldinfold)
                    If IO.Path.GetFileNameWithoutExtension(secondinfold) = "JumpListIcons" Then
                        'MsgBox(secondinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function CanaryJournalFiles()
        If Directory.Exists(Functiod.Cache.GetCanaryOthers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    If filinfold.EndsWith("journal") = True Then
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ChromeJournalFiles()
        If Directory.Exists(Functiod.Cache.GetChromeothers) = True Then
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                For Each filinfold In Directory.GetFiles(foldinfold)
                    If filinfold.EndsWith("journal") = True Then
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    End If
                Next
            Next
        End If
        Return Nothing
    End Function
    Public Shared Function ChromeCache()
        'MsgBox("cache")
        For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeCache)
            If Directory.Exists(foldinfold & "\Cache") = True Then
                For Each canary In Directory.GetFiles(foldinfold & "\Cache")
                    Try
                        File.Delete(canary)

                    Catch ex As IOException
                        MsgBox(ex.ToString)

                    End Try
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function CanaryCache()
        For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryCache)

            'For Each foldinfold1 In Directory.GetDirectories(foldinfold)
            ' MsgBox(foldinfold1)
            If Directory.Exists(foldinfold & "\Cache") = True Then
                ' MsgBox("true")
                For Each canary In Directory.GetFiles(foldinfold & "\Cache")
                    'MsgBox(canary)
                    Try
                        File.Delete(canary)
                    Catch ex As Exception

                    End Try
                Next
            Else
                'MsgBox("false")
            End If
            'Next
        Next
        Return Nothing
    End Function
    Public Shared Function ChromeMediaCache()
        ' MsgBox("media cache")
        For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeMediaCache)
            If Directory.Exists(foldinfold & "\Media Cache") = True Then
                For Each filinfold In Directory.GetFiles(foldinfold & "\Media Cache")
                    Try
                        File.Delete(filinfold)
                    Catch ex As IOException
                        MsgBox(ex.ToString)

                    End Try

                Next
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function CanaryMediaCache()
        For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryMediaCache)
            If Directory.Exists(foldinfold & "\Media Cache") = True Then
                For Each filinfold In Directory.GetFiles(foldinfold & "\Media Cache")
                    Try
                        File.Delete(filinfold)
                    Catch ex As Exception

                    End Try
                Next
            End If
        Next
        Return Nothing
    End Function
    Public Shared Function safarihistory()
        If Functiod.Cache.GetSafariHistory <> "" Then
            For Each safarihis In Directory.GetFiles(Functiod.Cache.GetSafariHistory)
                Try
                    File.Delete(safarihis)
                Catch ex As Exception

                End Try
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function SafariWebPre()
        If Functiod.Cache.GetSafariWebpagePreviews <> "" Then
            For Each safariweb In Directory.GetFiles(Functiod.Cache.GetSafariWebpagePreviews)
                Try
                    File.Delete(safariweb)
                Catch ex As Exception

                End Try
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function SafariOthers()
        If Functiod.Cache.GetSafariOthers <> "" Then
            Dim flex = File.Exists(Functiod.Cache.GetSafariOthers & "\History.plist")
            Dim flLstSes = Functiod.Cache.GetSafariOthers & "\LastSession.plist"
            Dim flexlastses = File.Exists(flLstSes)
            Dim flTpStes = Functiod.Cache.GetSafariOthers & "\TopSites.plist"
            Dim flexTopSites = File.Exists(flTpStes)
            If flex = True Then
                Try
                    File.Delete(Functiod.Cache.GetSafariOthers & "\History.plist")
                Catch ex As Exception

                End Try
            End If
            If flexlastses = True Then
                Try
                    File.Delete(flLstSes)
                Catch ex As Exception

                End Try
            End If
            If flexTopSites = True Then
                Try
                    File.Delete(flTpStes)
                Catch ex As Exception

                End Try
            End If
        End If
        Return Nothing
    End Function

    Public Shared Function SafariCookies()
        If Functiod.Cache.GetSafariOthers <> "" Then
            'C:\Users\Aravindh\AppData\Roaming\Apple Computer\Safari\Cookies
            Dim cook = Functiod.Cache.GetSafariOthers & "\Cookies"
            For Each fil In Directory.GetFiles(cook)
                Try
                    File.Delete(fil)
                Catch ex As Exception

                End Try
            Next
        End If
        Return Nothing
    End Function

    Public Shared Function SafariCache()
        If Functiod.Cache.GetSafariCache() <> "" Then
            Try
                'If File.Exists(Functiod.Cache.GetSafariCache & "\Cache.db") = True Then
                File.Delete(Functiod.Cache.GetSafariCache & "\Cache.db")
                '     MsgBox("Executed")
                'Else
                '    MsgBox("Not Executed")
                'End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return Nothing
    End Function
    Public Shared Function CanaryOthers()
        Try
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetCanaryOthers)
                'MsgBox(foldinfold)
                'MsgBox("CanOth : " & Functiod.Cache.GetCanaryOthers)
                Dim month As String
                month = My.Computer.Clock.LocalTime.Month
                If month < 10 Then
                    month = "0" & month
                End If
                For Each fls In Directory.GetFiles(foldinfold)
                    Dim nm = IO.Path.GetFileName(fls)
                    If nm.ToString.StartsWith("History Index") = True And nm.ToString.EndsWith("l") = False Then
                        File.Delete(fls)
                    End If
                Next
                File.Delete(foldinfold & "\History")
                File.Delete(foldinfold & "\Archived History")
                File.Delete(foldinfold & "\Visited Links")
                File.Delete(foldinfold & "\Current Tabs")
                File.Delete(foldinfold & "\Last Tabs")
                File.Delete(foldinfold & "\Current Session")
                File.Delete(foldinfold & "\Last Session")
                For Each filinfolder In Directory.GetFiles(foldinfold & "\JumpListIcons")
                    File.Delete(filinfolder)
                Next
                For Each filinfolder In Directory.GetFiles(foldinfold & "\JumpListIconsOld")
                    File.Delete(filinfolder)
                Next
            Next
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Shared Function Chromeothers()
        Try
            For Each foldinfold In Directory.GetDirectories(Functiod.Cache.GetChromeothers)
                Dim month As String
                month = My.Computer.Clock.LocalTime.Month
                If month < 10 Then
                    month = "0" & month
                End If
                'MsgBox(month)
                'MsgBox(My.Computer.Clock.LocalTime.Year)
                'File.Delete(Functiod.Cache.GetChromeothers & "\History Index " & My.Computer.Clock.LocalTime.Year & "-" & month)
                For Each fls In Directory.GetFiles(foldinfold)
                    'MsgBox(fls)
                    Dim nm = IO.Path.GetFileName(fls)
                    If nm.ToString.StartsWith("History Index") = True And nm.ToString.EndsWith("l") = False Then
                        'MsgBox(fls)
                        File.Delete(fls)
                    End If
                Next
                File.Delete(foldinfold & "\History")
                File.Delete(foldinfold & "\Archived History")
                File.Delete(foldinfold & "\Visited Links")
                File.Delete(foldinfold & "\Current Tabs")
                File.Delete(foldinfold & "\Last Tabs")
                File.Delete(foldinfold & "\Current Session")
                File.Delete(foldinfold & "\Last Session")
                For Each flsinfolder In Directory.GetFiles(foldinfold & "\JumpListIcons")
                    File.Delete(flsinfolder)
                Next
                For Each fileinfd In Directory.GetFiles(foldinfold & "\JumpListIconsOld")
                    File.Delete(fileinfd)
                Next
            Next
            'File.Delete(Functiod.Cache.GetChromeothers & "\History Index 2011-04")
        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Class WindowsFiles
        Public Shared Function PrefetchData()
            For Each fil In Directory.GetFiles(Functiod.windowsfolders.GetOldPrefetchData)
                If IO.Path.GetExtension(fil) = ".pf" Then
                    File.Delete(fil)
                Else
                    'MsgBox("Not Compatible extension spotted")
                End If
            Next
            Return Nothing
        End Function
        Public Shared Function LogFiles()
            For Each fil In Directory.GetFiles(Functiod.WindowsItems.GetWindowsLog)
                If IO.Path.GetExtension(fil) = ".log" Then
                    File.Delete(fil)
                End If
            Next
            For Each Fold In Directory.GetDirectories(Functiod.WindowsItems.GetWindowsLog)
                For Each fil In Directory.GetFiles(Fold)
                    File.Delete(fil)
                Next
            Next
            Return Nothing
        End Function
        Public Shared Function RecentItems()
            For Each fileinfold In Directory.GetFiles(Functiod.windowsfolders.WindowsRecent)
                Try
                    File.Delete(fileinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function WMPArtCac()
            For Each fileinfold In Directory.GetFiles(Functiod.WindowsItems.WindowsMediaPlayerArtCac)
                Try
                    File.Delete(fileinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function RemWER()
            If Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                For Each fold In Directory.GetDirectories(Functiod.WindowsItems.WindowsErrorReporting)
                    For Each fol In Directory.GetDirectories(fold)
                        For Each fileinfold In Directory.GetFiles(fol)
                            Try
                                File.Delete(fileinfold)
                            Catch ex As Exception
                            End Try
                        Next
                    Next
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function RemWER2()
            If Functiod.WindowsItems.WindowsErrorReporting2 <> "" Then
                For Each fold In Directory.GetDirectories(Functiod.WindowsItems.WindowsErrorReporting2)
                    For Each fol In Directory.GetDirectories(fold)
                        For Each fileinfold In Directory.GetFiles(fol)
                            Try
                                File.Delete(fileinfold)
                            Catch ex As Exception
                            End Try
                        Next
                    Next
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function RemThumbCach()
            If Functiod.WindowsItems.WEThumbCache <> "" Then
                For Each filinfold In Directory.GetFiles(Functiod.WindowsItems.WEThumbCache)
                    If IO.Path.GetExtension(filinfold) = ".db" Then
                        If Functiod.retrieval.FileInUse(filinfold) = False Then
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                Next
            End If
            Return Nothing
        End Function
    End Class

    Public Class SoftwareCac
        Public Shared Function RemFlshCac()
            For Each fold In Directory.GetDirectories(Functiod.SoftCache.FlashCache)
                For Each fil In Directory.GetFiles(fold)
                    Try
                        File.Delete(fil)
                    Catch ex As Exception
                    End Try
                Next
            Next
            For Each fil In Directory.GetFiles(Functiod.SoftCache.FlashCache)
                Try
                    File.Delete(fil)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function RemFlashPlayerOth()
            For Each fold In Directory.GetDirectories(Functiod.SoftCache.FlashCacheOthers)
                For Each oneinfold In Directory.GetDirectories(fold)
                    For Each filinfold In Directory.GetFiles(oneinfold)
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception
                        End Try
                    Next
                    For Each twoinfold In Directory.GetDirectories(oneinfold)
                        For Each filinfold In Directory.GetFiles(twoinfold)
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception
                            End Try
                        Next
                        For Each threinfold In Directory.GetDirectories(twoinfold)
                            For Each filinfold In Directory.GetFiles(threinfold)
                               Try
                                    File.Delete(filinfold)
                                Catch ex As Exception
                                End Try
                            Next
                            For Each fourinfold In Directory.GetDirectories(threinfold)
                                For Each filinfold In Directory.GetFiles(fourinfold)
                                    Try
                                        File.Delete(filinfold)
                                    Catch ex As Exception
                                    End Try
                                Next
                                For Each fiveinfold In Directory.GetDirectories(fourinfold)
                                    For Each filinfold In Directory.GetFiles(fiveinfold)
                                        Try
                                            File.Delete(filinfold)
                                        Catch ex As Exception
                                        End Try
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
            Return Nothing
        End Function
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
        Public Shared Function RemUtrrntOldFls()
            For Each Fil In Directory.GetFiles(Functiod.SoftCache.UTrrntOldFls)
                If IO.Path.GetExtension(Fil) = ".old" Then
                    Try
                        File.Delete(Fil)
                    Catch ex As Exception
                    End Try
                End If
            Next
            For Each fold In Directory.GetDirectories(Functiod.SoftCache.UTrrntOldFls)
                If fold = Functiod.SoftCache.UTrrntOldFls & "\dlimagecache" Then
                    For Each Fil In Directory.GetFiles(fold)
                        'If IO.Path.GetExtension(Fil) = ".old" Then
                        'dlimagecache
                        Try
                            File.Delete(Fil)
                        Catch ex As Exception
                        End Try
                        'End If
                    Next
                End If
            Next
            Return Nothing
        End Function
        Public Shared Function RemOffRec()
            If Functiod.SoftCache.OfficeRecent <> "" Then
                For Each fil In Directory.GetFiles(Functiod.SoftCache.OfficeRecent)
                    Try
                        File.Delete(fil)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function NotepadPlusPlus()
            If Functiod.SoftCache.NotepadplusplusSes <> "" Then
                Dim name = Functiod.SoftCache.NotepadplusplusSes & "\session.xml"
                If File.Exists(name) Then
                    Try
                        File.Delete(name)
                    Catch ex As Exception
                    End Try
                End If
            End If
            Return Nothing
        End Function
        Public Shared Function EvernoteLogs()
            For Each fil In Directory.GetFiles(Functiod.SoftCache.EvernoteLogs)
                Try
                    File.Delete(fil)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function IDM()
            Dim fil = Functiod.SoftCache.GetIDM & "\UrlHistory.txt"
            Dim fil2 = Functiod.SoftCache.GetIDM & "\foldresHistory.txt"
            If File.Exists(fil) = True Then
                Try
                    File.Delete(fil)
                Catch ex As Exception
                End Try
            End If
            If File.Exists(fil2) = True Then
                Try
                    File.Delete(fil2)
                Catch ex As Exception
                End Try
            End If
            Return Nothing
        End Function
        Public Shared Function AdobeSear()
            Dim sear As String = Functiod.SoftCache.GetAdobeSearch
            For Each filinfold In Directory.GetFiles(sear)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function AdobeCac()
            Dim sear As String = Functiod.SoftCache.GetAdobeCache
            For Each filinfold In Directory.GetFiles(sear)
                Try
                    File.Delete(filinfold)
                Catch ex As Exception
                End Try
            Next
            Return Nothing
        End Function
        Public Shared Function AxilIconWork()
            For Each fold In Directory.GetDirectories(Functiod.SoftCache.GetAxcilIconWork)
                ' MsgBox("1")
                For Each filinfold In Directory.GetFiles(fold)
                    'MsgBox("2")
                    Try
                        File.Delete(filinfold)
                    Catch ex As Exception
                    End Try
                Next
            Next
            Return Nothing
        End Function
        Public Shared Function Quick()
            For Each filinfold In Directory.GetFiles(Functiod.SoftCache.GetQuickTime)
                If IO.Path.GetExtension(filinfold) = ".xml" Then
                    Try
                        File.Delete(filinfold)
                    Catch ex As Exception
                    End Try
                End If
            Next
            Return Nothing
        End Function
        Public Shared Function QuickLow()
            For Each foldinfold In Directory.GetDirectories(Functiod.SoftCache.GetQuickTimeLocalLow)
                For Each foldin In Directory.GetDirectories(foldinfold)
                    For Each filinfold In Directory.GetFiles(foldin)
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    Next
                Next
            Next
            Return Nothing
        End Function
        Public Shared Function REMVLCArtCache()
            If Functiod.SoftCache.GetVLCMediaPlayerArtCache <> "" Then
                'MsgBox("ex")
                For Each foldinfold In Directory.GetDirectories(Functiod.SoftCache.GetVLCMediaPlayerArtCache)
                    For Each filinfold In Directory.GetFiles(foldinfold)
                        Try
                            File.Delete(filinfold)
                        Catch ex As Exception

                        End Try
                    Next
                    For Each secondinfold In Directory.GetDirectories(foldinfold)
                        For Each filinfold In Directory.GetFiles(secondinfold)
                            'MsgBox("2")
                            Try
                                File.Delete(filinfold)
                            Catch ex As Exception

                            End Try
                        Next
                        For Each thirdinfold In Directory.GetDirectories(secondinfold)
                            For Each filinfold In Directory.GetFiles(thirdinfold)
                                ' MsgBox("3")
                                Try
                                    File.Delete(filinfold)
                                Catch ex As Exception

                                End Try
                            Next
                            For Each fourthinfold In Directory.GetDirectories(thirdinfold)
                                For Each filinfold In Directory.GetFiles(fourthinfold)
                                    Try
                                        File.Delete(filinfold)
                                    Catch ex As Exception

                                    End Try
                                Next
                            Next
                        Next
                    Next
                Next
            End If
            Return Nothing
        End Function
        Public Shared Function Freemakecache()
            For Each fileinfold In Directory.GetFiles(Functiod.SoftCache.freemake)
                If FileInUse(fileinfold) = False Then
                    Try
                        File.Delete(fileinfold)
                    Catch ex As Exception
                    End Try
                End If
            Next
            Return Nothing
        End Function
    End Class
End Class
'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyleft (C) 2012-2013 A-Soft. All Rights Reserved.                      #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyleft (C) 2010-2013 Arvin Soft. All Rights Reserved.                      #
'##############################################################################################