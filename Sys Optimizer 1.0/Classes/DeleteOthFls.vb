Imports System.Xml
Imports System.IO
Imports Functiod
Public Class DeleteOthFls
    Public Shared errormessage As String

    Public Shared Function DeleteOthFls()
        ' ProgressBar1.Value = 0
        Dim chkedff = ""
        Dim chkedie = ""
        Dim chkedchr = ""
        Dim chkedsaf = ""
        Dim chkedOper = ""
        Dim chkedThun = ""
        Dim chkedWMP = ""
        Dim chkedFlsh = ""
        Dim chkedUtr = ""
        Dim chkedOffRec = ""
        Dim chkedAxIcon = ""
        Dim chkedNotPlPl = ""
        Dim chkedEver = ""
        Dim chkedIDM = ""
        Dim chkedAdRd = ""
        Dim chkedLog = ""
        Dim chkedWER = ""
        Dim chkedWinRec = ""
        Dim chkedWinThum = ""
        Dim chkedQuick = ""
        Dim chkedVLC = ""
        Dim chkedFreemake = ""
        Dim dls As XmlReader = New XmlTextReader(Application.StartupPath & "\settingschecked.xml")
        If File.Exists(Application.StartupPath & "\settingschecked.xml") = True Then
            While (dls.Read())
                Dim typ = dls.NodeType
                If typ = XmlNodeType.Element Then
                    'MsgBox("Enter")
                    If dls.Name = "Checkedff" Then
                        chkedff = dls.ReadInnerXml.ToString
                        'MsgBox(chkedff)
                    End If
                    If dls.Name = "CheckedIE" Then
                        'Label2.Text = dls.ReadInnerXml.ToString
                        chkedie = dls.ReadInnerXml.ToString
                    End If

                    If dls.Name = "Checkedchr" Then
                        chkedchr = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedSaf" Then
                        chkedsaf = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedOper" Then
                        chkedOper = dls.ReadInnerXml.ToString
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
                    If dls.Name = "CheckedAxIcon" Then
                        chkedAxIcon = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedOffRec" Then
                        chkedOffRec = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedNotPlPl" Then
                        chkedNotPlPl = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "CheckedQuick" Then
                        chkedQuick = dls.ReadInnerXml.ToString
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
                    If dls.Name = "CheckedVLCMedia" Then
                        chkedVLC = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "checkedFreemake" Then
                        chkedFreemake = dls.ReadInnerXml.ToString
                    End If
                    'Exit While
                End If
            End While
            dls.Close()
        Else
        End If
        Try
            If Settings.chkPreFetch.Checked = True And Functiod.windowsfolders.GetOldPrefetchData <> "" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Prefetch Data Files..."
                removal.WindowsFiles.PrefetchData()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : PrefDat ( 404 or 1400 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedLog = "true" And Functiod.WindowsItems.GetWindowsLog <> "" Then
                '  lblScanStatus.Text = "Status : Searching and cleaning Windows Log Files..."
                removal.WindowsFiles.LogFiles()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            'errormessage = errormessage & vbNewLine & "Error Occurred at : WinLg ( 404 or 1402 ) " & ex.ToString
            'Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.windowsfolders.WindowsRecent <> "" And chkedWinRec = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Windows Recent Items..."
                removal.WindowsFiles.RecentItems()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : RecItms ( 404 or 1408 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.EvernoteLogs <> "" And chkedEver = "true" Then
                'lblScanStatus.Text = "Status : Searching and cleaning Evernote Logs..."
                removal.SoftwareCac.EvernoteLogs()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at EvrNtLgs ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.GetQuickTime <> "" And chkedQuick = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Apple QuickTime temp files..."
                removal.SoftwareCac.Quick()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at Quick ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.GetQuickTimeLocalLow <> "" And chkedQuick = "true" Then
                'lblScanStatus.Text = "Status : Searching and cleaning Apple QuickTime temp files..."
                removal.SoftwareCac.QuickLow()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at Quick Low ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.WindowsItems.WindowsMediaPlayerArtCac <> "" And chkedWMP = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Windows Media Player Art Cache..."
                removal.WindowsFiles.WMPArtCac()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at : WMPArtCac ( 404 or 1289 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            Dim setr
            setr = My.Settings.clsrecycle
            If setr = "1" Then
                ' lblScanStatus.Text = "Status: Searching and cleaning Recycle bin Items..."
                main.EmptyRecycleBin()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RCycleBn ( 404 or 1433 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try
        Try
            If chkedWER = "true" And Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Windows Error Reporting Archives..."
                removal.WindowsFiles.RemWER()
                removal.WindowsFiles.RemWER2()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemWER ( 404 or 1234 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedIDM = "true" And Functiod.SoftCache.GetIDM <> "" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning IDM Files..."
                Functiod.removal.SoftwareCac.IDM()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at IDM ( 404 or 233 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            ' lblScanStatus.Text = "Status: Searching and cleaning Temp Files..."
            Functiod.removal.TempFiles()
            ' ProgressBar1.PerformStep()
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at TmpFls ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.OfficeRecent <> "" And chkedOffRec = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning office recent files..."
                Functiod.removal.SoftwareCac.RemOffRec()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at OffRec ( 404 or 204 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedWinThum = "true" And Functiod.WindowsItems.WEThumbCache <> "" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Thumbnail Cache..."
                Functiod.removal.WindowsFiles.RemThumbCach()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at TMBCac ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.NotepadplusplusSes <> "" And chkedNotPlPl = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Notepad Plus Plus Sessions..."
                Functiod.removal.SoftwareCac.NotepadPlusPlus()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at NotPdPluPlu ( 404 or 405 or 233 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If Functiod.SoftCache.GetAxcilIconWork <> "" And chkedAxIcon = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning Axialis icon workshop items..."
                Functiod.removal.SoftwareCac.AxilIconWork()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at Axilicnwrkshp ( 404 or 405 or 233 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            'lblScanStatus.Text = "Status: Searching and cleaning Temp Files in Windows Folder..."
            Functiod.removal.TempFileWinDir()
            ' ProgressBar1.PerformStep()
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at TmpFlsWmdFld ( 404 or 133 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedFlsh = "true" And Functiod.SoftCache.FlashCache <> "" Then
                Functiod.removal.SoftwareCac.RemFlshCac()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemFlsPlCac ( 404 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedFlsh = "true" And Functiod.SoftCache.FlashCacheOthers <> "" Then
                Functiod.removal.SoftwareCac.RemFlashPlayerOth()
                'ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemFlsPlCacOther ( 404 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedAdRd = "true" And Functiod.SoftCache.GetAdobeCache <> "" Then
                'lblScanStatus.Text = "Status : Searching and cleaning Adobe search cache..."
                Functiod.removal.SoftwareCac.AdobeCac()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemAdobCac ( 404 or 2333 )" & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedVLC = "true" Then
                ' lblScanStatus.Text = "Status : Searching and cleaning VLC Media Player Art Cache..."
                Functiod.removal.SoftwareCac.REMVLCArtCache()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at REMVLCMedia ( 404 or 203 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedAdRd = "true" And Functiod.SoftCache.GetAdobeSearch <> "" Then
                '  lblScanStatus.Text = "Status : Searching and cleaning Adobe Search Cache..."
                Functiod.removal.SoftwareCac.AdobeSear()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemAdobSear ( 404 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedFreemake = "true" And Functiod.SoftCache.freemake <> "" Then
                Functiod.removal.SoftwareCac.Freemakecache()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at RemFreemake ( 404 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        Try
            If chkedUtr = "true" And Functiod.SoftCache.UTrrntOldFls <> "" Then
                Functiod.removal.SoftwareCac.RemUtrrntOldFls()
                ' ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occured at RemUtrrntFls ( 404 or 2333 ) " & ex.ToString
            Crash_Box.ShowDialog()
        End Try

        If Settings.CheckBox1.Checked = True Then
            Try
                Shell("netsh winsock reset")
            Catch ex As Exception
                errormessage = errormessage & vbNewLine & "Error Occurred at netsh winsock reset" & ex.ToString
                Crash_Box.ShowDialog()
            End Try
            Dim srd = Functiod.DialogBoxes.yesno("You've just resetted the winsock catalog inorder to complete the reset please restart your system if you want to restart click yes if you manage to restart later click no ", "Restart Required", "FUNCTOID_MESSAGE_ICON_EXCLAMATION")
            If srd = vbYes Then
                Shell("shutdown -r -tt 00")
            ElseIf srd = vbNo Then
                '  lstCleane.Items.Add("Restart Pending")
                'lblScanStatus.Text = "Status: Cleaning Complete - Restart Required"
            Else
                errormessage = errormessage & vbNewLine & "Please contact the product manufacturer"
                Crash_Box.ShowDialog()
                'MsgBox("Something happened contact product manufacturer")
            End If
        End If
        '  lblScanStatus.Text = "Status: Cleaning Completed on Other Files"
        ' ProgressBar1.PerformStep()
        ' ProgressBar1.Value = 100
        ' lblScanStatus.Text = "Status: Cleaning Completed on Other Files"
        'lblscanitemsoth.Visible = False
        'lblscansizeoth.Visible = False
        'bttnClean.Visible = False
        'Panel1.Visible = False
        'Panel2.Visible = False
        Return Nothing
    End Function
End Class
