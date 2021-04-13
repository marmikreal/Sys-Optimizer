Imports System.Xml
Imports System.IO

Public Class FirstRun

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        lblSave.Visible = True
        Dim path = Application.StartupPath & "\Proc"
        If Directory.Exists(path) = False Then
            Directory.CreateDirectory(path)
            If File.Exists(path & "\AAM Updates Notifier.exe.xml") = False Then
                Dim sett As New XmlWriterSettings
                Dim xmlds As XmlWriter = XmlWriter.Create(path & "\AAM Updates Notifier.exe.xml", sett)
                With xmlds
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
            End If
            If File.Exists(path & "\WTClient.exe.xml") = False Then
                Dim setd As New XmlWriterSettings
                Dim xmlns As XmlWriter = XmlWriter.Create(path & "\WTClient.exe.xml", setd)
                With xmlns
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
            End If
            If File.Exists(path & "\RunNot.txt") = False Then
                File.Create(path & "\RunNot.txt")
            End If
            If Directory.Exists(Application.StartupPath & "\procgmes") = False Then
                Directory.CreateDirectory(Application.StartupPath & "\procgmes")
            End If
            If Directory.Exists(Application.StartupPath & "\procche") = False Then
                Directory.CreateDirectory(Application.StartupPath & "\procche")
            End If
            If Directory.Exists(Application.StartupPath & "\Proc1") = False Then
                Directory.CreateDirectory(Application.StartupPath & "\Proc1")
            End If
        Else
            If File.Exists(path & "\AAM Updates Notifier.exe.xml") = False Then
                Dim sett As New XmlWriterSettings
                Dim xmlds As XmlWriter = XmlWriter.Create(path & "\AAM Updates Notifier.exe.xml", sett)
                With xmlds
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
            End If
            If File.Exists(path & "\WTClient.exe.xml") = False Then
                Dim setd As New XmlWriterSettings
                Dim xmlns As XmlWriter = XmlWriter.Create(path & "\WTClient.exe.xml", setd)
                With xmlns
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
            End If
        End If
        Dim settingsred As New XmlWriterSettings
        Dim xmlred As XmlWriter = XmlWriter.Create(Application.StartupPath & "\redbrain.xml")
        With xmlred
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("redbrainenabled")
            .WriteString("true")
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        Dim settingsredclean As New XmlWriterSettings
        Dim xmlredclean As XmlWriter = XmlWriter.Create(Application.StartupPath & "\redbrainclean.xml")
        With xmlredclean
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("redbraincleanenabled")
            .WriteString("true")
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        Dim settings As New XmlWriterSettings
        Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\settingschecked.xml")
        With xmld
            .WriteStartDocument()
            .WriteStartElement("Data")

            'Set Chrome settings to xml
            If chkInt.Checked = True Then
                If Functiod.Cache.GetChromeCache <> "" Or Functiod.Cache.GetCanaryCache <> "" Then
                    .WriteStartElement("Chrome")
                    .WriteStartElement("Checkedchr")
                    .WriteStartElement("Cachechr")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteStartElement("Hischr")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Chrome")
                    .WriteStartElement("Checkedchr")
                    .WriteStartElement("Cachechr")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteStartElement("Hischr")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                'Set firefox settings to xml

                If Functiod.Cache.GetFirefoxCache <> "" Then

                    .WriteStartElement("Firefox")
                    .WriteStartElement("Checkedff")
                    .WriteStartElement("Cacheff")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteStartElement("Hisff")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteStartElement("Thumbff")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Firefox")
                    .WriteStartElement("Checkedff")
                    .WriteStartElement("Cacheff")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteStartElement("Hisff")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteStartElement("Thumbff")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                'Set safari settings to xml

                If Functiod.Cache.GetSafariCache <> "" Then
                    .WriteStartElement("Safari")
                    .WriteStartElement("CheckedSaf")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Safari")
                    .WriteStartElement("CheckedSaf")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                'Set IE settings to xml

                'If Functiod.Cache.GetIEFiles <> "" Then
                .WriteStartElement("IE")
                .WriteStartElement("CheckedIE")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                'Else
                '    .WriteStartElement("IE")
                '    .WriteStartElement("CheckedIE")
                '    .WriteString("false")
                '    .WriteEndElement()
                '    .WriteEndElement()
                'End If

                'Set Opera settings to xml

                If Functiod.Cache.GetOperaCache <> "" Then
                    .WriteStartElement("Opera")
                    .WriteStartElement("CheckedOper")
                    .WriteStartElement("Cacheoper")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteStartElement("Hisoper")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteStartElement("Thumboper")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Opera")
                    .WriteStartElement("CheckedOper")
                    .WriteStartElement("Cacheoper")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteStartElement("Hisoper")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteStartElement("Thumboper")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                'Set Thunderbird settings to xml

                If Functiod.Cache.GetThunderbirdCache <> "" Then
                    .WriteStartElement("Thunderbird")
                    .WriteStartElement("CheckedThunder")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Thunderbird")
                    .WriteStartElement("CheckedThunder")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
            Else
                .WriteStartElement("Chrome")
                .WriteStartElement("Checkedchr")
                .WriteStartElement("Cachechr")
                .WriteString("false")
                .WriteEndElement()
                .WriteStartElement("Hischr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Firefox")
                .WriteStartElement("Checkedff")
                .WriteStartElement("Cacheff")
                .WriteString("false")
                .WriteEndElement()
                .WriteStartElement("Hisff")
                .WriteString("false")
                .WriteEndElement()
                .WriteStartElement("Thumbff")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Safari")
                .WriteStartElement("CheckedSaf")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("IE")
                .WriteStartElement("CheckedIE")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Opera")
                .WriteStartElement("CheckedOper")
                .WriteStartElement("Cacheoper")
                .WriteString("false")
                .WriteEndElement()
                .WriteStartElement("Hisoper")
                .WriteString("false")
                .WriteEndElement()
                .WriteStartElement("Thumboper")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Thunderbird")
                .WriteStartElement("CheckedThunder")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If
            'Set WMP settings to xml
            If chkSoftTemp.Checked = True Then
                If Functiod.WindowsItems.WindowsMediaPlayerArtCac <> "" Then
                    .WriteStartElement("WMP")
                    .WriteStartElement("CheckedWMP")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("WMP")
                    .WriteStartElement("CheckedWMP")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.FlashCache <> "" Then
                    .WriteStartElement("FlashPlayer")
                    .WriteStartElement("CheckedFlsh")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("FlashPlayer")
                    .WriteStartElement("CheckedFlsh")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.UTrrntOldFls <> "" Then
                    .WriteStartElement("utrrnt")
                    .WriteStartElement("Checkedutrr")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("utrrnt")
                    .WriteStartElement("Checkedutrr")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.OfficeRecent <> "" Then
                    .WriteStartElement("OfficeRece")
                    .WriteStartElement("CheckedOffRec")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("OfficeRece")
                    .WriteStartElement("CheckedOffRec")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.NotepadplusplusSes <> "" Then
                    .WriteStartElement("NotepadPl")
                    .WriteStartElement("CheckedNotPlPl")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("NotepadPl")
                    .WriteStartElement("CheckedNotPlPl")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.EvernoteLogs <> "" Then
                    .WriteStartElement("Evernote")
                    .WriteStartElement("CheckedEver")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Evernote")
                    .WriteStartElement("CheckedEver")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.GetIDM <> "" Then
                    .WriteStartElement("IDM")
                    .WriteStartElement("CheckedIDM")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("IDM")
                    .WriteStartElement("CheckedIDM")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.SoftCache.GetAxcilIconWork <> "" Then
                    .WriteStartElement("AxIcon")
                    .WriteStartElement("CheckedAxIcon")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("AxIcon")
                    .WriteStartElement("CheckedAxIcon")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
                If Functiod.SoftCache.GetQuickTime <> "" Then
                    .WriteStartElement("Quick")
                    .WriteStartElement("CheckedQuick")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Quick")
                    .WriteStartElement("CheckedQuick")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
                If Functiod.SoftCache.GetAdobeCache <> "" Then
                    .WriteStartElement("AdobeReader")
                    .WriteStartElement("CheckedAdobeRd")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("AdobeReader")
                    .WriteStartElement("CheckedAdobeRd")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
                If Functiod.SoftCache.GetVLCMediaPlayerArtCache <> "" Then
                    .WriteStartElement("VLCMedia")
                    .WriteStartElement("CheckedVLCMedia")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("VLCMedia")
                    .WriteStartElement("CheckedVLCMedia")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

            Else
                .WriteStartElement("WMP")
                .WriteStartElement("CheckedWMP")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("FlashPlayer")
                .WriteStartElement("CheckedFlsh")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("utrrnt")
                .WriteStartElement("Checkedutrr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("OfficeRece")
                .WriteStartElement("CheckedOffRec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("AxIcon")
                .WriteStartElement("CheckedAxIcon")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("NotepadPl")
                .WriteStartElement("CheckedNotPlPl")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Evernote")
                .WriteStartElement("CheckedEver")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("IDM")
                .WriteStartElement("CheckedIDM")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("AdobeReader")
                .WriteStartElement("CheckedAdobeRd")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Quick")
                .WriteStartElement("CheckedQuick")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("VLCMedia")
                .WriteStartElement("CheckedVLCMedia")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            End If
            If chkSysFls.Checked = True Then
                If Functiod.WindowsItems.GetWindowsLog <> "" Then
                    .WriteStartElement("WindowsLog")
                    .WriteStartElement("CheckedLog")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("WindowsLog")
                    .WriteStartElement("CheckedLog")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                    .WriteStartElement("WindowsErrorReporting")
                    .WriteStartElement("CheckedWER")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("WindowsErrorReporting")
                    .WriteStartElement("CheckedWER")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.windowsfolders.WindowsRecent <> "" Then
                    .WriteStartElement("WindowsRecent")
                    .WriteStartElement("CheckedWinRec")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("WindowsRecent")
                    .WriteStartElement("CheckedWinRec")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If

                If Functiod.WindowsItems.WEThumbCache <> "" Then
                    .WriteStartElement("WindowsThumb")
                    .WriteStartElement("CheckedWinThumb")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("WindowsThumb")
                    .WriteStartElement("CheckedWinThumb")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
                If Functiod.SoftCache.freemake <> "" Then
                    .WriteStartElement("Freemake")
                    .WriteStartElement("checkedFreemake")
                    .WriteString("true")
                    .WriteEndElement()
                    .WriteEndElement()
                Else
                    .WriteStartElement("Freemake")
                    .WriteStartElement("checkedFreemake")
                    .WriteString("false")
                    .WriteEndElement()
                    .WriteEndElement()
                End If
            Else
                .WriteStartElement("WindowsLog")
                .WriteStartElement("CheckedLog")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("WindowsErrorReporting")
                .WriteStartElement("CheckedWER")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("WindowsRecent")
                .WriteStartElement("CheckedWinRec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("WindowsThumb")
                .WriteStartElement("CheckedWinThumb")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("Freemake")
                .WriteStartElement("checkedFreemake")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        Dim settingsd As New XmlWriterSettings
        Dim xmls As XmlWriter = XmlWriter.Create(Application.StartupPath & "\settingsvisible.xml")
        With xmls
            .WriteStartDocument()
            .WriteStartElement("Data")
            .WriteStartElement("IE")
            .WriteStartElement("VisibleIE")
            .WriteString("true")
            .WriteEndElement()
            .WriteEndElement()
            .WriteStartElement("Log")
            .WriteStartElement("VisibleLog")
            .WriteString("true")
            .WriteEndElement()
            .WriteEndElement()

            If Functiod.Cache.GetChromeCache <> "" Then
                .WriteStartElement("Chrom")
                .WriteStartElement("VisibleChrom")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Chrom")
                .WriteStartElement("VisibleChrom")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                'chkChrom.Visible = False
                'chkChrom.Checked = False
            End If

            If Functiod.Cache.GetFirefoxCache <> "" Then
                .WriteStartElement("firefox")
                .WriteStartElement("Visibleff")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("firefox")
                .WriteStartElement("Visibleff")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.Cache.GetOperaCache <> "" Then
                .WriteStartElement("Opera")
                .WriteStartElement("Visibleopr")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Opera")
                .WriteStartElement("Visibleopr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.Cache.GetSafariCache <> "" Then
                .WriteStartElement("Safari")
                .WriteStartElement("Visiblesaf")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Safari")
                .WriteStartElement("Visiblesaf")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If
            If Functiod.windowsfolders.WindowsRecent <> "" Then
                .WriteStartElement("WinRec")
                .WriteStartElement("Visiblewrec")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("WinRec")
                .WriteStartElement("Visiblewrec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.WindowsItems.WindowsMediaPlayerArtCac <> "" Then
                .WriteStartElement("WMP")
                .WriteStartElement("Visiblewmp")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("WMP")
                .WriteStartElement("Visiblewmp")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                'lblSetNotice.Visible = True
            End If

            If Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                .WriteStartElement("WER")
                .WriteStartElement("Visiblewer")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("WER")
                .WriteStartElement("Visiblewer")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If


            If Functiod.SoftCache.UTrrntOldFls <> "" Then
                .WriteStartElement("Utrr")
                .WriteStartElement("Visibleutrr")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Utrr")
                .WriteStartElement("Visibleutrr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.Cache.GetThunderbirdCache <> "" Then
                .WriteStartElement("Thunder")
                .WriteStartElement("Visiblethunder")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Thunder")
                .WriteStartElement("Visiblethunder")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.WindowsItems.WEThumbCache <> "" Then
                .WriteStartElement("Thumbnail")
                .WriteStartElement("Visiblethumb")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Thumbnail")
                .WriteStartElement("Visiblethumb")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.FlashCache <> "" Then
                .WriteStartElement("FlashPlayer")
                .WriteStartElement("Visibleflsh")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("FlashPlayer")
                .WriteStartElement("Visibleflsh")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.OfficeRecent <> "" Then
                .WriteStartElement("OfficeRec")
                .WriteStartElement("VisibleOffRec")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("OfficeRec")
                .WriteStartElement("VisibleOffRec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.NotepadplusplusSes <> "" Then
                .WriteStartElement("NotepadPl")
                .WriteStartElement("Visiblenotepl")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("NotepadPl")
                .WriteStartElement("Visiblenotepl")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.GetAxcilIconWork <> "" Then
                .WriteStartElement("AxIcon")
                .WriteStartElement("VisibleAxIcon")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("AxIcon")
                .WriteStartElement("VisibleAxIcon")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.EvernoteLogs <> "" Then
                .WriteStartElement("Evernote")
                .WriteStartElement("Visibleever")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Evernote")
                .WriteStartElement("Visibleever")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.GetIDM <> "" Then
                .WriteStartElement("IDM")
                .WriteStartElement("Visibleidm")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("IDM")
                .WriteStartElement("Visibleidm")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            If Functiod.SoftCache.GetAdobeCache <> "" And Functiod.SoftCache.GetAdobeSearch <> "" Then
                .WriteStartElement("AdobeReader")
                .WriteStartElement("VisibleAdobReder")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("AdobeReader")
                .WriteStartElement("VisibleAdobReder")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        If Directory.Exists(Application.StartupPath & "\Plugins") = False Then
            Directory.CreateDirectory(Application.StartupPath & "\Plugins")
        End If
        If File.Exists(Application.StartupPath & "\Plugins\InterfaceSettings.xml") = False Then
            Dim settingpl As New XmlWriterSettings
            Dim xmlpl As XmlWriter = XmlWriter.Create(Application.StartupPath & "\Plugins\InterfaceSettings.xml")
            With xmlpl
                .WriteStartDocument()
                .WriteStartElement("sysoptimizer")
                .WriteStartElement("options")
                .WriteStartElement("size")
                .WriteStartElement("startwidth")
                .WriteString("717")
                '717, 561
                .WriteEndElement()
                .WriteStartElement("minwidth")
                .WriteString("678")
                .WriteEndElement()
                .WriteStartElement("startheight")
                .WriteString("561")
                .WriteEndElement()
                .WriteStartElement("minheight")
                .WriteString("540")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("prop")
                .WriteStartElement("title")
                .WriteString("Sys Optimizer 3.0")
                .WriteEndElement()
                .WriteStartElement("maxbut")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("minbut")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("ctrlbx")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("startpos")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("borstyle")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("showintaskbr")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("opac")
                .WriteEndElement()
                .WriteStartElement("showicn")
                .WriteString("1")
                .WriteEndElement()
                .WriteStartElement("tpmst")
                .WriteString(0)
                .WriteEndElement()
                .WriteStartElement("tmrstrt")
                .WriteString("1")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
        End If
        Dim settingd As New XmlWriterSettings
        Dim xmla As XmlWriter = XmlWriter.Create(Application.StartupPath & "\gamebooster.xml")
        With xmla
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("aero")
            .WriteString("true")
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        lblSave.Visible = False
        'Application.Restart()
        ' MsgBox("Please restart the application", MsgBoxStyle.Information + vbOKOnly, "Info")
        Process.Start(Application.StartupPath & "\starter.exe")
        End
        'Me.Close()
        'Me.Close()
    End Sub

    Private Sub tmrFrstRnTbs_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrFrstRnTbs.Tick
        'TabControl1.Visible = True
        PictureBox1.Visible = True
        'Label1.Visible = True
        'Label2.Visible = True
        Label3.Visible = True
        'Panel8.Visible = True
        ' panSettings.Visible = True
       
        tmrFrstRnTbs.Enabled = False
    End Sub


    Private Sub bttnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'panPersonal.Visible = False
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim settings As New XmlWriterSettings
        Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\perinfo.xml")
        With xmld
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("name")
            .WriteString("")
            .WriteEndElement()
            .WriteStartElement("city")
            .WriteString("")
            .WriteEndElement()
            .WriteStartElement("country")
            .WriteString("")
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With

    End Sub

    Private Sub FirstRun_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub tmrEnable_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnable.Tick
        panHi.Visible = False

        tmrEnable.Enabled = False
        addarvinacc.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Manual" Then
            panSettings.Visible = True
        Else
            chkInt.Checked = True
            chkSoftTemp.Checked = True
            chkSysFls.Checked = True
            panSettings.Visible = False
        End If
    End Sub
End Class