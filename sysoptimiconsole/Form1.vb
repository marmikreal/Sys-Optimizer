Imports System.IO
Imports System.Xml
Public Class Form1
    Public Shared errormessage As String
    Public Function ProcessRunning(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Delete(ByVal lblScanStatus As Label, ByVal ProgressBar1 As ProgressBar)
        ProgressBar1.Value = 0
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

        'Try
        '    If InStr(LCase(My.Computer.Info.OSFullName), "windows 7") Or InStr(LCase(My.Computer.Info.OSFullName), "vista") Then
        '        lblScanStatus.Text = "Status: Removing Internet Explorer Items..."
        '        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255")
        '        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8")
        '    Else
        '        'MsgBox("Sorry you cannot delete ie history in this Operating system using Command Line")
        '    End If
        'Catch ex As Exception
        '    errormessage = errormessage & vbNewLine & "Error Occurred at IE HIs ( 909 or 293 or 345 )" & ex.ToString
        '    Crash_Box.ShowDialog()
        'End Try

        If ProcessRunning("chrome") >= 1 Then
            'Dim ret = MsgBox("Chrome files cannot be deleted because chrome is running" & vbNewLine & "Do you want to close chrome for you ? ", MsgBoxStyle.Exclamation + vbYesNo, "Information")
            'If ret = vbYes Then
        Else
        Try
            If chkedchrcach = "true" And Functiod.Cache.GetChromeCache() <> "" Then
                lblScanStatus.Text = "Status : Searching and cleaning Chrome Items..."
                'MsgBox("in 1")
                Functiod.removal.ChromeCache()
                    Functiod.removal.ChromeMediaCache()
                    Functiod.removal.ChromeGPUCache()
                    Functiod.removal.ChromeLocalStore()
                    Functiod.removal.ChromeJumplisticons()
                    Functiod.removal.ChromeJournalFiles()
            End If
            If chkedchrhis = "true" Then
                Functiod.removal.Chromeothers()
                ProgressBar1.PerformStep()
                End If
                Try
                    If Functiod.Cache.GetCanaryCache <> "" And chkedchrcach = "true" Then
                        ' MsgBox("exe")
                        lblScanStatus.Text = "Status : Searching and cleaning canary items..."
                        Functiod.removal.CanaryCache()
                        Functiod.removal.CanaryMediaCache()
                        Functiod.removal.CanaryGPUCache()
                        Functiod.removal.CanaryLocalStore()
                        Functiod.removal.CanaryJumplisticons()
                        Functiod.removal.CanaryJournalFiles()
                        If chkedchrhis = "true" Then
                            Functiod.removal.CanaryOthers()
                            ProgressBar1.PerformStep()
                        End If
                    End If
                Catch ex As Exception
                    errormessage = errormessage & vbNewLine & "Error Occurred at canary Itms ( 909 or 454 or 293 or 345 ) " & ex.ToString
                    ' Crash_Box.ShowDialog()
                End Try
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at Chrm Itms ( 909 or 454 or 293 or 345 ) " & ex.ToString
                'Crash_Box.ShowDialog()
        End Try
        End If
       

        Try
            Dim chked As Integer
            If chkedffcach = "true" Or chkedffhis = "true" Or chkedffthumb = "true" Then
                chked = 1
            Else
                chked = 0
            End If
            If ProcessRunning("firefox") = 1 And chked = 1 Then
            Else
                If Functiod.Cache.GetFirefoxCache <> "" Then
                    If chkedffcach = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Firefox Items..."
                        Functiod.removal.FirefoxCache()
                        lblScanStatus.Text = "Status : Searching and cleaning Firefox Jump list items..."
                        Functiod.removal.FirefoxJmpLst()
                    End If
                    If chkedffhis = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Firefox Miscillaneous items..."
                        Functiod.removal.FirefoxMiscil()
                    End If
                    If chkedffthumb = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Firefox Web Thumbnail..."
                        Functiod.removal.FirefoxWebThumb()
                    End If
                    ProgressBar1.PerformStep()
                End If

            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at FreFx ( 909 or 454 or 293 or 345 ) " & ex.ToString
        End Try

        Try
            If ProcessRunning("thunderbird") = 1 And chkedThun = "true" Then
            Else
                If chkedThun = "true" And Functiod.Cache.GetThunderbirdCache <> "" Then
                    lblScanStatus.Text = "Status : Searching and cleaning Thunderbird Cache..."
                    Functiod.removal.Thunderbird.ThunderbirdCache()
                    lblScanStatus.Text = "Status : Searching and cleaning Thunderbird Items..."
                    Functiod.removal.Thunderbird.ThunderbirdSes()
                    ProgressBar1.PerformStep()
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at ThBrdCac or ThBrdSes ( 404 or 909 or 293 or 345 ) " & ex.ToString
        End Try

        Try
            If Functiod.Cache.GetIECookies <> "" And chkedie = "true" Then
                Functiod.removal.IECookies()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at IntEx ( 909 or 293 or 345 ) " & ex.ToString
        End Try

        Try
            If chkedie = "true" And Functiod.Cache.getInernetFiles <> "" Then
                lblScanStatus.Text = "Status : Searching and cleaning Internet Explorer Items..."
                Functiod.removal.InternetFiles()
                Functiod.removal.IECookies()
                Functiod.removal.ContentIE5()
                Functiod.removal.IEFeedsCache()
                Functiod.removal.IEDtBse()
                ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at IntFls ( 909 or 293 or 345 ) " & ex.ToString
        End Try

        Try
            Dim chked As Integer
            If chkedopercach = "true" Or chkedoperhis = "true" Or chkedoperthumb = "true" Then
                chked = 1
            Else
                chked = 0
            End If
            If ProcessRunning("opera") = 1 And chked = 1 Then
            Else
                If Functiod.Cache.GetOperaCache <> "" Then
                    If chkedopercach = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Items..."
                        Functiod.removal.Opera.OperaCache()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Cache..."
                        Functiod.removal.Opera.OperaCachVps()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Icon Cache..."
                        Functiod.removal.Opera.OperaIconCache()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Cache..."
                        Functiod.removal.Opera.OperaOpCache()
                        Functiod.removal.Opera.OperaStableCacheNew()
                        Functiod.removal.Opera.OperaStableGPUCacheNew()
                        Functiod.removal.Opera.OperaStableJumpListIconsNew()
                        Functiod.removal.Opera.OperaStableJumpListIconOldNew()
                        Functiod.removal.Opera.OperaStableLocalStorageNew()
                    End If
                    If chkedoperhis = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Sessions..."
                        Functiod.removal.Opera.OperaSessions()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Typed History..."
                        Functiod.removal.Opera.OperaTypedHstry()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Temp_Down..."
                        Functiod.removal.Opera.OperaTemp_Down()
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Others..."
                        Functiod.removal.Opera.OperaOthers()

                        ProgressBar1.PerformStep()
                    End If
                    If chkedoperthumb = "true" Then
                        lblScanStatus.Text = "Status : Searching and cleaning Opera Jump list icon cache..."
                        Functiod.removal.Opera.OperaJmpLstIcnCache()
                    End If
                End If
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at OPra Cac ( 909 or 293 or 555 ) " & ex.ToString
        End Try

        Try
            If chkedsaf = "true" And Functiod.Cache.GetSafariCache <> "" Then
                lblScanStatus.Text = "Status : Searching and cleaning Safari cache..."
                Functiod.removal.SafariCache()
                lblScanStatus.Text = "Status : Searching and cleaning Safari History..."
                Functiod.removal.safarihistory()
                lblScanStatus.Text = "Status : Searching and cleaning Safari Web Previews..."
                Functiod.removal.SafariWebPre()
                lblScanStatus.Text = "Status : Searching and cleaning Safari Other Files..."
                Functiod.removal.SafariOthers()
                lblScanStatus.Text = "Status : Searching and cleaning Safari Cookies..."
                Functiod.removal.SafariCookies()
                ProgressBar1.PerformStep()
            End If
        Catch ex As Exception
            errormessage = errormessage & vbNewLine & "Error Occurred at SFri Cac, HStry, WBPrvws ( 909 or 293 or 546 or 345 ) " & ex.ToString
        End Try
        ProgressBar1.Value = 100
        lblScanStatus.Text = "Status: Searching and cleaning completed on Internet Files"
        Me.Close()
        Return Nothing
    End Function
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Delete(Label1, ProgressBar1)
    End Sub
End Class
