Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.IO
Imports System.Net

Public Class Settings
    <StructLayout(LayoutKind.Sequential)>
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function
    Public Function SetListboxITems()
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
        Dim chkedaero = ""
        Dim chkedFreemake = ""
        '.WriteStartElement("CheckedQuick")

        If File.Exists(Application.StartupPath & "\gamebooster.xml") = True Then
            Dim dlss As XmlReader = New XmlTextReader(Application.StartupPath & "\gamebooster.xml")
            While (dlss.Read())
                Dim typ = dlss.NodeType
                If typ = XmlNodeType.Element Then
                    If dlss.Name = "aero" Then
                        chkedaero = dlss.ReadInnerXml.ToString
                    End If
                End If
            End While
            dlss.Close()
        End If
        If My.Settings.campusrnm <> "" Then
            txtBxUsrNm.Visible = False
            txtBxPass.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Button1.Text = "Logout"
            lblusrnm.Visible = True
            lblusrnm.Text = "You are logged in as " & My.Settings.campusrnm.ToString
        End If
        If My.Settings.monstart = 0 Then
            CheckBox3.Checked = False
        Else
            CheckBox3.Checked = True
        End If
        If File.Exists(Application.StartupPath & "\redbrain.xml") = True Then
            chkBxRedBrain.Checked = True
        Else
            chkBxRedBrain.Checked = False
        End If
        If chkedaero = "true" Then
            chkBxAeroEn.Checked = True
        Else
            chkBxAeroEn.Checked = False
        End If
        If File.Exists(Application.StartupPath & "\redbrainclean.xml") = True Then
            chkBxRedBrainCleanFls.Checked = True
        Else
            chkBxRedBrainCleanFls.Checked = False
        End If
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
                    If dls.Name = "CheckedAxIcon" Then
                        chkedAxIcon = dls.ReadInnerXml.ToString
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
                    If dls.Name = "CheckedVLCMedia" Then
                        chkedVLCMedia = dls.ReadInnerXml.ToString
                    End If
                    If dls.Name = "checkedFreemake" Then
                        chkedFreemake = dls.ReadInnerXml.ToString
                    End If
                End If
            End While
            dls.Close()
        Else
        End If
        Dim settings As New XmlWriterSettings
        Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\settingsvisible.xml")
        With xmld
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
            chkIE.Visible = True
            If chkedie = "true" Then
                chkIE.Checked = True

            Else
                chkIE.Checked = False
            End If
            If chkedLog = "true" Then
                ChkLog.Checked = True

            Else
                ChkLog.Checked = False
            End If
            If My.Settings.start = 1 Then
                chkBxStart.Checked = True
            Else
                chkBxStart.Checked = False
            End If
            If Functiod.Cache.GetChromeCache <> "" Or Functiod.Cache.GetCanaryCache <> "" Then
                If chkedchrcach = "true" Then
                    chkChromCach.Checked = True
                Else
                    chkChromCach.Checked = False
                End If
                If chkedchrhis = "true" Then
                    chkChromHis.Checked = True
                Else
                    chkChromHis.Checked = False
                End If
                If chkedchrcach = "true" And chkedchrhis = "true" Then
                    chkChrom.Checked = True
                Else
                    'chkChrom.Checked = False
                End If
                .WriteStartElement("Chrom")
                .WriteStartElement("VisibleChrom")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkChrom.Visible = True
            Else
                .WriteStartElement("Chrom")
                .WriteStartElement("VisibleChrom")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                'chkChrom.Visible = False
                'chkChrom.Checked = False
                TbControlBrow.TabPages.Remove(tbChro)
            End If

            If Functiod.Cache.GetFirefoxCache <> "" Then
                If chkedffcach = "true" Then
                    chkFFCach.Checked = True
                Else
                    chkFFCach.Checked = False
                End If
                If chkedffhis = "true" Then
                    chkFFhis.Checked = True
                Else
                    chkFFhis.Checked = False
                End If
                If chkedffthumb = "true" Then
                    chkFFThum.Checked = True
                Else
                    chkFFThum.Checked = False
                End If
                If chkedffcach = "true" And chkedffhis = "true" And chkedffthumb = "true" Then
                    chkFF.Checked = True
                Else
                    'chkFF.Checked = False
                End If
                .WriteStartElement("firefox")
                .WriteStartElement("Visibleff")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkFF.Visible = True
            Else
                .WriteStartElement("firefox")
                .WriteStartElement("Visibleff")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkFF.Visible = False
                chkFF.Checked = False
                TbControlBrow.TabPages.Remove(tbFire)
            End If

            If Functiod.Cache.GetOperaCache <> "" Then
                If chkedopercach = "true" Then
                    chkOpraCach.Checked = True
                Else
                    chkOpraCach.Checked = False
                End If
                If chkedoperhis = "true" Then
                    chkOpraHis.Checked = True
                Else
                    chkOpraHis.Checked = False
                End If
                If chkedoperthumb = "true" Then
                    chkOpraThumb.Checked = True
                Else
                    chkOpraThumb.Checked = False
                End If
                If chkedopercach = "true" And chkedoperhis = "true" And chkedoperthumb = "true" Then
                    chkOpra.Checked = True
                Else
                    'chkOpra.Checked = False
                End If
                .WriteStartElement("Opera")
                .WriteStartElement("Visibleopr")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkOpra.Visible = True
            Else
                .WriteStartElement("Opera")
                .WriteStartElement("Visibleopr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkOpra.Visible = False
                chkOpra.Checked = False
                TbControlBrow.TabPages.Remove(tbOper)
            End If

            If Functiod.Cache.GetSafariCache <> "" Then
                If chkedsaf = "true" Then
                    chkSafri.Checked = True
                Else
                    chkSafri.Checked = False
                End If
                .WriteStartElement("Safari")
                .WriteStartElement("Visiblesaf")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkSafri.Visible = True
            Else
                .WriteStartElement("Safari")
                .WriteStartElement("Visiblesaf")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkSafri.Visible = False
                chkSafri.Checked = False
                TbControlBrow.TabPages.Remove(tbSaf)
            End If

            If My.Settings.clsrecycle = "1" Then
                clsrecycle.Checked = True
            Else
                clsrecycle.Checked = False
            End If

            If Functiod.windowsfolders.WindowsRecent <> "" Then
                If chkedWinRec = "true" Then
                    chkWindowsRecent.Checked = True
                Else
                    chkWindowsRecent.Checked = False
                End If
                .WriteStartElement("WinRec")
                .WriteStartElement("Visiblewrec")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkWindowsRecent.Visible = True
            Else
                .WriteStartElement("WinRec")
                .WriteStartElement("Visiblewrec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkWindowsRecent.Visible = True
                chkWindowsRecent.Visible = False
                chkWindowsRecent.Checked = False
            End If

            If Functiod.WindowsItems.WindowsMediaPlayerArtCac <> "" Then
                If chkedWMP = "true" Then
                    chkWMPArtCac.Checked = True
                Else
                    chkWMPArtCac.Checked = False
                End If
                .WriteStartElement("WMP")
                .WriteStartElement("Visiblewmp")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkWMPArtCac.Visible = True
            Else
                .WriteStartElement("WMP")
                .WriteStartElement("Visiblewmp")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkWMPArtCac.Visible = False
                chkWMPArtCac.Checked = False
                'lblSetNotice.Visible = True
            End If

            If Functiod.WindowsItems.WindowsErrorReporting <> "" Then
                If chkedWER = "true" Then
                    chkWER.Checked = True
                Else
                    chkWER.Checked = False
                End If
                .WriteStartElement("WER")
                .WriteStartElement("Visiblewer")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkWER.Visible = True
            Else
                .WriteStartElement("WER")
                .WriteStartElement("Visiblewer")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkWER.Visible = False
                chkWER.Checked = False
            End If



            If Functiod.SoftCache.UTrrntOldFls <> "" Then
                If chkedUtr = "true" Then
                    chkUtrrnt.Checked = True
                Else
                    chkUtrrnt.Checked = False
                End If
                .WriteStartElement("Utrr")
                .WriteStartElement("Visibleutrr")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkUtrrnt.Visible = True
            Else
                .WriteStartElement("Utrr")
                .WriteStartElement("Visibleutrr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkUtrrnt.Visible = False
                chkUtrrnt.Checked = False
            End If

            If Functiod.SoftCache.GetAxcilIconWork <> "" Then
                If chkedAxIcon = "true" Then
                    chkAxIcon.Checked = True
                Else
                    chkAxIcon.Checked = False
                End If
                .WriteStartElement("AxIcon")
                .WriteStartElement("VisibleAxIcon")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkAxIcon.Visible = True
            Else
                .WriteStartElement("AxIcon")
                .WriteStartElement("VisibleAxIcon")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkAxIcon.Visible = False
                chkAxIcon.Checked = False
            End If

            If Functiod.SoftCache.GetQuickTime <> "" Then
                If chkedQuick = "true" Then
                    chkQuick.Checked = True
                Else
                    chkQuick.Checked = False
                End If
                .WriteStartElement("Quick")
                .WriteStartElement("VisibleQuick")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Quick")
                .WriteStartElement("VisibleQuick")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkQuick.Visible = False
                chkQuick.Checked = False
            End If

            If Functiod.Cache.GetThunderbirdCache <> "" Then
                If chkedThun = "true" Then
                    chkThunderbrd.Checked = True
                Else
                    chkThunderbrd.Checked = False
                End If
                .WriteStartElement("Thunder")
                .WriteStartElement("Visiblethunder")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkThunderbrd.Visible = True
            Else
                .WriteStartElement("Thunder")
                .WriteStartElement("Visiblethunder")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkThunderbrd.Visible = False
                chkThunderbrd.Checked = False
                TbControlBrow.TabPages.Remove(tbThunder)
            End If

            If Functiod.WindowsItems.WEThumbCache <> "" Then
                If chkedWinThum = "true" Then
                    chkThumbCach.Checked = True
                Else
                    chkThumbCach.Checked = False
                End If
                .WriteStartElement("Thumbnail")
                .WriteStartElement("Visiblethumb")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkThumbCach.Visible = True
            Else
                .WriteStartElement("Thumbnail")
                .WriteStartElement("Visiblethumb")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkThumbCach.Visible = False
                chkThumbCach.Checked = False
            End If

            If Functiod.SoftCache.FlashCache <> "" Then
                If chkedFlsh = "true" Then
                    chkFlshplr.Checked = True
                Else
                    chkFlshplr.Checked = False
                End If
                .WriteStartElement("FlashPlayer")
                .WriteStartElement("Visibleflsh")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkFlshplr.Visible = True
            Else
                .WriteStartElement("FlashPlayer")
                .WriteStartElement("Visibleflsh")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkFlshplr.Visible = False
                chkFlshplr.Checked = False
            End If

            If Functiod.SoftCache.OfficeRecent <> "" Then
                If chkedOffRec = "true" Then
                    chkOffRec.Checked = True
                Else
                    chkOffRec.Checked = False
                End If
                .WriteStartElement("OfficeRec")
                .WriteStartElement("VisibleOffRec")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkOffRec.Visible = True
            Else
                .WriteStartElement("OfficeRec")
                .WriteStartElement("VisibleOffRec")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkOffRec.Visible = False
                chkOffRec.Checked = False
            End If

            If Functiod.SoftCache.NotepadplusplusSes <> "" Then
                If chkedNotPlPl = "true" Then
                    chkntepdplspls.Checked = True
                Else
                    chkntepdplspls.Checked = False
                End If
                .WriteStartElement("NotepadPl")
                .WriteStartElement("Visiblenotepl")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkntepdplspls.Visible = True
            Else
                .WriteStartElement("NotepadPl")
                .WriteStartElement("Visiblenotepl")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkntepdplspls.Visible = False
                chkntepdplspls.Checked = False
            End If

            If Functiod.SoftCache.EvernoteLogs <> "" Then
                If chkedEver = "true" Then
                    chkeverntitms.Checked = True
                Else
                    chkeverntitms.Checked = False
                End If
                .WriteStartElement("Evernote")
                .WriteStartElement("Visibleever")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkeverntitms.Visible = True
            Else
                .WriteStartElement("Evernote")
                .WriteStartElement("Visibleever")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkeverntitms.Visible = False
                chkeverntitms.Checked = False
            End If

            If Functiod.SoftCache.GetIDM <> "" Then
                If chkedIDM = "true" Then
                    chkIDM.Checked = True
                Else
                    chkIDM.Checked = False
                End If
                .WriteStartElement("IDM")
                .WriteStartElement("Visibleidm")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkIDM.Visible = True
            Else
                .WriteStartElement("IDM")
                .WriteStartElement("Visibleidm")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkIDM.Visible = False
                chkIDM.Checked = False
            End If
            If Functiod.SoftCache.freemake <> "" Then
                If chkedFreemake = "true" Then
                    ChkBxFreeMake.Checked = True
                Else
                    ChkBxFreeMake.Checked = False
                End If
                .WriteStartElement("Freemake")
                .WriteStartElement("VisibleFreemake")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                ChkBxFreeMake.Visible = True
            Else
                .WriteStartElement("Freemake")
                .WriteStartElement("VisibleFreemake")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                ChkBxFreeMake.Visible = False
            End If
            If Functiod.SoftCache.GetAdobeCache <> "" And Functiod.SoftCache.GetAdobeSearch <> "" Then
                If chkedAdRd = "true" Then
                    chkAdob.Checked = True
                Else
                    chkAdob.Checked = False
                End If
                .WriteStartElement("AdobeReader")
                .WriteStartElement("VisibleAdobReder")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                chkAdob.Visible = True
            Else
                .WriteStartElement("AdobeReader")
                .WriteStartElement("VisibleAdobReder")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                chkAdob.Visible = False
                chkAdob.Checked = False
            End If
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        If chkedVLCMedia = "true" Then
            chkVLC.Checked = True
        Else
            chkVLC.Checked = False
        End If
        If My.Settings.priori = 1 Then
            chkBxHighPrior.Checked = True
        Else
            chkBxHighPrior.Checked = False
        End If
        If My.Settings.themse = 1 Then
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.themse = 2 Then
            panColorSelect2.BorderStyle = BorderStyle.FixedSingle
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.themse = 3 Then
            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.FixedSingle
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.themse = 4 Then

            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.FixedSingle
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.None
        ElseIf My.Settings.themse = 5 Then

            panColorSelect2.BorderStyle = BorderStyle.None
            panColorSelect3.BorderStyle = BorderStyle.None
            panColorSelect4.BorderStyle = BorderStyle.None
            panColorSelect5.BorderStyle = BorderStyle.FixedSingle
        Else
            panColorSelect2.BorderStyle = BorderStyle.None
        End If
        txtBxNotty.Text = My.Settings.NotRMAb.ToString
        lstBxUnwanPro.Items.Clear()
        If Directory.Exists(Application.StartupPath & "\Proc") = True Then
            For Each fls In Directory.GetFiles(Application.StartupPath & "\Proc")
                If IO.Path.GetExtension(fls) = ".xml" Then
                    lstBxUnwanPro.Items.Add(IO.Path.GetFileNameWithoutExtension(fls))
                End If
            Next
        End If
        If My.Settings.pass = "" Then
            lblProte.Text = "Not Protected"
        Else
            lblProte.Text = "Protected"
        End If
        Return Nothing
    End Function
    Private Sub bttnSetNavCleanerSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSetNavCleanerSet.Click
        panCleaner.Size = New Size(panSoftSettings.Width, panSoftSettings.Height)
        panCleaner.Location = New Point(panSoftSettings.Location.X, panSoftSettings.Location.Y)
        panSoftSettings.Visible = False
        panCleaner.Visible = True
        bttnSetNavCleanerSet.BackColor = Color.SteelBlue
        bttnSetNavCleanerSet.ForeColor = Color.White
        bttnSetNavCleanerSet.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        bttnSetNavCleanerSet.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        bttnSetNavSoftSet.BackColor = Color.Transparent
        bttnSetNavSoftSet.ForeColor = Color.Black
    End Sub

    Private Sub bttnSetNavSoftSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSetNavSoftSet.Click
        panCleaner.Visible = False
        panSoftSettings.Visible = True
        bttnSetNavCleanerSet.BackColor = Color.Transparent
        bttnSetNavCleanerSet.ForeColor = Color.Black
        'bttnSetNavCleanerSet.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        'bttnSetNavCleanerSet.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        bttnSetNavSoftSet.BackColor = Color.SteelBlue
        bttnSetNavSoftSet.ForeColor = Color.White
    End Sub
    Public Function okbutton()
        If txtBxNotty.Text >= 100 Then
            My.Settings.NotRMAb = txtBxNotty.Text
        Else
            MsgBox("Process that use less than 100MB of RAM will not slowdown your system please set values higher than or equal to 100MB", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
        My.Settings.Save()
        If chkBxPerfIssues.Checked = True Then
            My.Settings.perf = 1
            My.Settings.Save()
        Else
            My.Settings.perf = 0
            My.Settings.Save()
        End If

        lblSaving.Visible = True
        If chkBxStart.Checked = True And My.Settings.start = 0 Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Sys Optimizer Launcher", Application.StartupPath & "\starter.exe")
            My.Settings.start = 1
            My.Settings.Save()
        ElseIf chkBxStart.Checked = False And My.Settings.start = 1 Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            My.Settings.start = 0
            My.Settings.Save()
        End If
        Dim settingd As New XmlWriterSettings
        Dim xmls As XmlWriter = XmlWriter.Create(Application.StartupPath & "\gamebooster.xml")
        With xmls
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("aero")
            If chkBxAeroEn.Checked = True Then
                .WriteString("true")
            Else
                .WriteString("false")
            End If
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With

        If chkBxRedBrain.Checked = True Then
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
        Else
            Try
                File.Delete(Application.StartupPath & "\redbrain.xml")
            Catch ex As Exception
                MsgBox("There is a problem when saving the settings", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
        End If
        If chkBxRedBrainCleanFls.Checked = True Then
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
        Else
            Try
                File.Delete(Application.StartupPath & "\redbrainclean.xml")
            Catch ex As Exception
                MsgBox("There is a problem when saving the settings", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
        End If
        Dim settings As New XmlWriterSettings
        Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\settingschecked.xml")
        With xmld
            .WriteStartDocument()
            .WriteStartElement("Data")

            'Set Chrome settings to xml

            If chkChromCach.Checked = True Then
                .WriteStartElement("Chrome")
                .WriteStartElement("Checkedchr")
                .WriteStartElement("Cachechr")
                .WriteString("true")
                .WriteEndElement()
            Else
                .WriteStartElement("Chrome")
                .WriteStartElement("Checkedchr")
                .WriteStartElement("Cachechr")
                .WriteString("false")
                .WriteEndElement()
            End If

            If chkChromHis.Checked = True Then
                .WriteStartElement("Hischr")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Hischr")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            End If

            'Set firefox settings to xml

            If chkFFCach.Checked = True Then

                .WriteStartElement("Firefox")
                .WriteStartElement("Checkedff")
                .WriteStartElement("Cacheff")
                .WriteString("true")
                .WriteEndElement()
            Else

                .WriteStartElement("Firefox")
                .WriteStartElement("Checkedff")
                .WriteStartElement("Cacheff")
                .WriteString("false")
                .WriteEndElement()
            End If

            If chkFFhis.Checked = True Then
                .WriteStartElement("Hisff")
                .WriteString("true")
                .WriteEndElement()
            Else
                .WriteStartElement("Hisff")
                .WriteString("false")
                .WriteEndElement()
            End If

            If chkFFThum.Checked = True Then
                .WriteStartElement("Thumbff")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Thumbff")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            End If

            'Set safari settings to xml

            If chkSafri.Checked = True Then
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

            If chkIE.Checked = True Then
                .WriteStartElement("IE")
                .WriteStartElement("CheckedIE")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("IE")
                .WriteStartElement("CheckedIE")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
            End If

            'Set Opera settings to xml

            If chkOpraCach.Checked = True Then
                .WriteStartElement("Opera")
                .WriteStartElement("CheckedOper")
                .WriteStartElement("Cacheoper")
                .WriteString("true")
                .WriteEndElement()
            Else
                .WriteStartElement("Opera")
                .WriteStartElement("CheckedOper")
                .WriteStartElement("Cacheoper")
                .WriteString("false")
                .WriteEndElement()
            End If

            If chkOpraHis.Checked = True Then
                .WriteStartElement("Hisoper")
                .WriteString("true")
                .WriteEndElement()
            Else
                .WriteStartElement("Hisoper")
                .WriteString("false")
                .WriteEndElement()
            End If

            If chkOpraThumb.Checked = True Then
                .WriteStartElement("Thumboper")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            Else
                .WriteStartElement("Thumboper")
                .WriteString("false")
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndElement()
            End If

            'Set Thunderbird settings to xml

            If chkThunderbrd.Checked = True Then
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

            'Set WMP settings to xml

            If chkWMPArtCac.Checked = True Then
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

            If chkFlshplr.Checked = True Then
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

            If chkUtrrnt.Checked = True Then
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

            If chkOffRec.Checked = True Then
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

            If chkntepdplspls.Checked = True Then
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

            If chkeverntitms.Checked = True Then
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

            If chkIDM.Checked = True Then
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

            If chkAxIcon.Checked = True Then
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

            If chkAdob.Checked = True Then
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

            If chkQuick.Checked = True Then
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

            If chkVLC.Checked = True Then
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

            If ChkLog.Checked = True Then
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

            If chkWER.Checked = True Then
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

            If chkWindowsRecent.Checked = True Then
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

            If chkThumbCach.Checked = True Then
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
            If ChkBxFreeMake.Checked = True Then
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
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        lblSaving.Visible = False
        Return Nothing
    End Function
    Public Function ifsimyes()
        If txtBxNotty.Text >= 100 Then
            My.Settings.NotRMAb = txtBxNotty.Text
        Else
            MsgBox("Process that use less than 100MB of RAM will not slowdown your system please set values higher than or equal to 100MB", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
        My.Settings.Save()
        lblSaving.Visible = True
        Dim settingd As New XmlWriterSettings
        Dim xmls As XmlWriter = XmlWriter.Create(Application.StartupPath & "\gamebooster.xml")
        With xmls
            .WriteStartDocument()
            .WriteStartElement("data")
            .WriteStartElement("aero")
            If chkBxAeroEn.Checked = True Then
                .WriteString("true")
            Else
                .WriteString("false")
            End If
            .WriteEndElement()
            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With
        If chkBxStart.Checked = True And My.Settings.start = 0 Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Sys Optimizer Launcher", Application.StartupPath & "\starter.exe")
            My.Settings.start = 1
            My.Settings.Save()
        ElseIf chkBxStart.Checked = False And My.Settings.start = 1 Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("Sys Optimizer Launcher")
            My.Settings.start = 0
            My.Settings.Save()
        End If
        If chkBxRedBrain.Checked = True Then
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
        Else
            Try
                File.Delete(Application.StartupPath & "\redbrain.xml")
            Catch ex As Exception
                MsgBox("There is a problem when saving the settings", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
        End If
        If chkBxRedBrainCleanFls.Checked = True Then
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
        Else
            Try
                File.Delete(Application.StartupPath & "\redbrainclean.xml")
            Catch ex As Exception
                MsgBox("There is a problem when saving the settings", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
        End If
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
        Dim xmlsd As XmlWriter = XmlWriter.Create(Application.StartupPath & "\settingsvisible.xml")
        With xmlsd
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
        Return Nothing
    End Function
    Private Sub bttnSetSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSetSave.Click
        If My.Settings.pass = "" Then
            If lblifSim.Text = 1 Then
                okbutton()
            Else
                ifsimyes()
                If chkBxPerfIssues.Checked = True Then
                    My.Settings.perf = 1
                    My.Settings.Save()
                Else
                    My.Settings.perf = 0
                    My.Settings.Save()
                End If
                lblSaving.Visible = False
            End If
            Me.Close()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            panPass.Visible = True
        End If
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Settings_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'Crash_Box.ShowDialog()
    End Sub

    Private Sub panColorSelect4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panColorSelect4.Click
        main.BackColor = Color.DimGray

        ' main.TreeView1.BackColor = Color.DimGray
        main.RTBMesages.BackColor = Color.DimGray
        main.panSplitCont.BackColor = Color.DimGray
        'main.panIntFlsDet.BackColor = Color.DimGray
        'main.panOthFlsDet.BackColor = Color.DimGray
        'main.lblIntFlsSize.ForeColor = Color.White
        'main.lblOthFlsSiz.ForeColor = Color.White
        main.lblTmRem.ForeColor = Color.White
        main.lblCurrTm.ForeColor = Color.White
        main.lblTm.ForeColor = Color.White
        main.lblLabelSection.ForeColor = Color.White
        main.lblRamCap.ForeColor = Color.White
        main.lblRAMCapandUsg.ForeColor = Color.White
        main.lblGraphics.ForeColor = Color.White

        ' main.TreeView1.ForeColor = Color.White
        main.RTBMesages.ForeColor = Color.White
        main.lblLabelSysStat.ForeColor = Color.White
        main.lblBatPer.ForeColor = Color.White
        panColorSelect4.BorderStyle = BorderStyle.FixedSingle
        panColorSelect5.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect2.BorderStyle = BorderStyle.None
        My.Settings.themse = 3
        My.Settings.Save()
    End Sub

    Private Sub panColorSelect3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panColorSelect3.Click
        main.BackColor = Color.DarkGray

        main.panSplitCont.BackColor = Color.DarkGray
        ' main.TreeView1.BackColor = Color.DarkGray
        main.RTBMesages.BackColor = Color.DarkGray

        main.lblTmRem.ForeColor = Color.Black
        main.lblIntFlsSize.ForeColor = Color.Black
        main.lblOthFlsSiz.ForeColor = Color.Black
        main.lblCurrTm.ForeColor = Color.Black
        main.lblTm.ForeColor = Color.Black
        main.lblLabelSection.ForeColor = Color.Black
        main.lblRamCap.ForeColor = Color.Black
        main.lblRAMCapandUsg.ForeColor = Color.Black
        main.lblGraphics.ForeColor = Color.Black

        '  main.TreeView1.ForeColor = Color.Black
        main.RTBMesages.ForeColor = Color.Black
        main.lblLabelSysStat.ForeColor = Color.Black
        main.lblBatPer.ForeColor = Color.Black
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.FixedSingle
        panColorSelect2.BorderStyle = BorderStyle.None
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 0
        margins.cxRightWidth = 0
        margins.cyTopHeight = 0
        margins.cyButtomheight = 0
        Dim hwnd As IntPtr = main.Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
        My.Settings.themse = 4
        My.Settings.Save()
    End Sub

    Private Sub panColorSelect2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panColorSelect2.Click
        main.BackColor = Color.Gainsboro

        main.panSplitCont.BackColor = Color.Gainsboro
        'main.panNav.BackColor = Color.WhiteSmoke
        ' main.TreeView1.BackColor = Color.Gainsboro
        main.RTBMesages.BackColor = Color.Gainsboro
        main.lblTmRem.ForeColor = Color.Black
        main.lblIntFlsSize.ForeColor = Color.Black
        main.lblOthFlsSiz.ForeColor = Color.Black
        main.lblCurrTm.ForeColor = Color.Black
        main.lblTm.ForeColor = Color.Black
        main.lblLabelSection.ForeColor = Color.Black
        main.lblRamCap.ForeColor = Color.Black
        main.lblRAMCapandUsg.ForeColor = Color.Black
        main.lblGraphics.ForeColor = Color.Black

        'main.TreeView1.ForeColor = Color.Black
        main.RTBMesages.ForeColor = Color.Black
        main.lblLabelSysStat.ForeColor = Color.Black
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.None
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect2.BorderStyle = BorderStyle.FixedSingle
        main.lblBatPer.ForeColor = Color.Black
        My.Settings.themse = 2
        My.Settings.Save()
    End Sub

    Private Sub panColorSelect5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panColorSelect5.Click
        main.BackColor = Color.LightSteelBlue

        main.panSplitCont.BackColor = Color.LightSteelBlue
        'main.panNav.BackColor = Color.AliceBlue
        ' main.TreeView1.BackColor = Color.LightSteelBlue
        main.RTBMesages.BackColor = Color.LightSteelBlue
        'main.panIntFlsDet.BackColor = Color.LightSteelBlue
        'main.panOthFlsDet.BackColor = Color.LightSteelBlue
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
        panColorSelect4.BorderStyle = BorderStyle.None
        panColorSelect5.BorderStyle = BorderStyle.FixedSingle
        panColorSelect3.BorderStyle = BorderStyle.None
        panColorSelect2.BorderStyle = BorderStyle.None
        main.lblBatPer.ForeColor = Color.Black
        My.Settings.themse = 5
        My.Settings.Save()
    End Sub


    Private Sub chkScanAtStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub clsrecycle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clsrecycle.CheckedChanged
        If clsrecycle.Checked Then
            My.Settings.clsrecycle = 1
        Else
            My.Settings.clsrecycle = 0
        End If
    End Sub

    Private Sub chkChrom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChrom.CheckedChanged
        If chkChrom.Checked = True Then
            chkChromCach.Checked = True
            chkChromHis.Checked = True
        ElseIf chkChrom.Checked = False Then
            chkChromCach.Checked = False
            chkChromHis.Checked = False
        Else
            chkChromCach.Checked = True
            chkChromHis.Checked = True
        End If
    End Sub

    Private Sub chkFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFF.CheckedChanged
        If chkFF.Checked = True Then
            chkFFCach.Checked = True
            chkFFhis.Checked = True
            chkFFThum.Checked = True
        ElseIf chkFF.Checked = False Then
            chkFFCach.Checked = False
            chkFFhis.Checked = False
            chkFFThum.Checked = False
        Else
            chkFFCach.Checked = True
            chkFFhis.Checked = True
            chkFFThum.Checked = True
        End If
    End Sub

    Private Sub chkOpra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpra.CheckedChanged
        If chkOpra.Checked = True Then
            chkOpraCach.Checked = True
            chkOpraHis.Checked = True
            chkOpraThumb.Checked = True
        ElseIf chkOpra.Checked = False Then
            chkOpraCach.Checked = False
            chkOpraHis.Checked = False
            chkOpraThumb.Checked = False
        Else
            chkOpraCach.Checked = True
            chkOpraHis.Checked = True
            chkOpraThumb.Checked = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If My.Settings.pass = "" Then
            If MskInPuBxPass.Text <> "" Then
                If MskInPuBxPass.Text = MskInPuBxPassRep.Text Then
                    My.Settings.pass = MskInPuBxPass.Text
                    MsgBox("Settings are now password protected", MsgBoxStyle.Information + vbOKOnly, "Information")
                    MskInPuBxPass.Text = ""
                    MskInPuBxPassRep.Text = ""
                    If My.Settings.pass = "" Then
                        lblProte.Text = "Not Protected"
                    Else
                        lblProte.Text = "Protected"
                    End If
                Else
                    MsgBox("Passwords don't match please check", MsgBoxStyle.Exclamation + vbOKOnly, "Passwords Don't match")
                End If
            End If
        Else
            lblcheck.Text = 1
            panPass.Visible = True
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub
    Public Function DelSelPro()
        If Directory.Exists(Application.StartupPath & "\Proc") = True Then
            For Each fls In Directory.GetFiles(Application.StartupPath & "\Proc")
                ' MsgBox(fls)
                'MsgBox(lstBxUnwanPro.SelectedItem & ".xml")
                If IO.Path.GetFileNameWithoutExtension(fls) = lstBxUnwanPro.SelectedItem Then
                    'MsgBox(lstBxUnwanPro.SelectedItem & ".xml")
                    Try
                        File.Delete(fls)
                    Catch ex As Exception
                    End Try
                End If
            Next
            Threading.Thread.Sleep(100)
            lstBxUnwanPro.Items.Clear()
            For Each fls In Directory.GetFiles(Application.StartupPath & "\Proc")
                If IO.Path.GetExtension(fls) = ".xml" Then
                    lstBxUnwanPro.Items.Add(IO.Path.GetFileNameWithoutExtension(fls))
                End If
            Next
        End If
        Return Nothing
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MaskedTextBox2.Text = My.Settings.pass Then
            If lblcheck.Text = 1 Then
                My.Settings.pass = MskInPuBxPass.Text
                If MskInPuBxPass.Text <> "" Then
                    If MskInPuBxPass.Text = MskInPuBxPassRep.Text Then
                        MsgBox("Settings Password Updated", MsgBoxStyle.Information + vbOKOnly, "Information")
                    Else
                        MsgBox("Passwords don't match please check", MsgBoxStyle.Exclamation + vbOKOnly, "Passwords Don't match")
                    End If
                Else
                    MsgBox("Settings Password removed", MsgBoxStyle.Information + vbOKOnly, "Information")
                End If
                MskInPuBxPass.Text = ""
                MskInPuBxPassRep.Text = ""
                MaskedTextBox2.Text = ""
                lblcheck.Text = 0
                panPass.Visible = False
                'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
            Else
                okbutton()
                panPass.Visible = False
                MaskedTextBox2.Text = ""
                MsgBox("Settings Saved", MsgBoxStyle.Information + vbOKOnly, "Information")
                Me.Close()
            End If
            If lblDelSelCheck.Text = 1 Then
                DelSelPro()
                lblDelSelCheck.Text = 0
            End If
            If My.Settings.pass = "" Then
                lblProte.Text = "Not Protected"
            Else
                lblProte.Text = "Protected"
            End If
        Else
            MsgBox("Incorrect Password" & vbNewLine & "Password is case sensitive", MsgBoxStyle.Critical + vbOKOnly, "Sorry")
        End If
    End Sub

    Private Sub bttnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnAdd.Click
        AddProcess.ShowDialog()
    End Sub

    Private Sub bttnDelSel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnDelSel.Click
        If My.Settings.pass = "" Then
            DelSelPro()
        Else
            panPass.Visible = True
            lblDelSelCheck.Text = 1
        End If
    End Sub

    Private Sub bttnClPss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClPss.Click
        panPass.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim ret
            ret = MsgBox("Enabling this item will need a system restart for the changes to take effect Do you want to continue? ", MsgBoxStyle.Information + vbYesNo)
            If ret = vbYes Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub chkPreFetch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreFetch.CheckedChanged
        If chkPreFetch.Checked = True Then
            Dim ret
            ret = MsgBox("Enabling this item will remove all the prefetch data that is used by the software and Os to start fast. Removing this will have software and Os instability Do You Realy Want to Continue?", MsgBoxStyle.Information + vbYesNo)
            If ret = vbYes Then
                chkPreFetch.Checked = True
            Else
                chkPreFetch.Checked = False
            End If
        End If
    End Sub

    Private Sub Settings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        SetListboxITems()
        If My.Settings.perf = 0 Then
            chkBxPerfIssues.Checked = False
        Else
            chkBxPerfIssues.Checked = True
        End If
        If My.Settings.tmrTyp = 0 Then
            'Real Timer
            'Strategic Timer
            cmboBxTmrTyp.Text = "Strategic Timer"
        Else
            cmboBxTmrTyp.Text = "Real Timer"
        End If
        If My.Settings.disas = 0 Then
            cmboBxDisResAs.Text = "Full Path"
        Else
            cmboBxDisResAs.Text = "Only File Names"
        End If
        lblloading.Visible = False
        Panel2.Visible = True
        panControls.Visible = True
        bttnSetSave.Visible = True
    End Sub

    Private Sub bttnConfigureGames_Click(sender As Object, e As EventArgs) Handles bttnConfigureGames.Click
        AddGame.ShowDialog()
    End Sub

    Private Sub bttnSoftToClos_Click(sender As Object, e As EventArgs) Handles bttnSoftToClos.Click
        AddSoftwares.ShowDialog()
    End Sub

    Private Sub cmboBxTmrTyp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboBxTmrTyp.SelectedIndexChanged
        lblSave.Text = ""
    End Sub

    Private Sub bttnTmrTyp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnTmrTyp.Click
        If cmboBxTmrTyp.Text = "Real Timer" Then
            Dim ret = MsgBox("This type of timer will need to run continuously when the software is running. Running this type of timer will result in high processor usage." & vbNewLine & "Do you want to continue?", vbYesNo + MsgBoxStyle.Exclamation, "Confirm")
            If ret = vbYes Then
                My.Settings.tmrTyp = "1"
                My.Settings.Save()
                'lblSave.Text = ""
                'System.Threading.Thread.Sleep(500)
                lblSave.Text = "Saved"
            End If

        ElseIf cmboBxTmrTyp.Text = "Strategic Timer" Then
            My.Settings.tmrTyp = "0"
            My.Settings.Save()
            'lblSave.Text = ""
            ' lblSave.Visible = False
            'System.Threading.Thread.Sleep(500)
            'lblSave.Visible = True
            lblSave.Text = "Saved"
        Else
            lblSave.Text = "Not Saved !043"
            MsgBox("Something happened please contact product manufacturer", MsgBoxStyle.Critical + vbOKOnly, "Sorry")

        End If
    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub cmboBxDisResAs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboBxDisResAs.SelectedIndexChanged
        lblSaveScanRes.Text = ""
    End Sub

    Private Sub bttnSaveScanResAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSaveScanResAs.Click
        If cmboBxDisResAs.Text = "Full Path" Then
            My.Settings.disas = "0"
            lblSaveScanRes.Text = "Saved"
        Else
            My.Settings.disas = "1"
            lblSaveScanRes.Text = "Saved"
        End If
        My.Settings.Save()
    End Sub

    Private Sub chkBxHighPrior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBxHighPrior.CheckedChanged
        If chkBxHighPrior.Checked = True Then
            My.Settings.priori = 1
            My.Settings.Save()
        Else
            My.Settings.priori = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub panEasySet_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        panEasySet.Visible = False
    End Sub

    Private Sub bttnAdvSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAdvSet.Click
        lblifSim.Text = 1
        panCleanerAdv.Visible = True
        panEasySet.Visible = False
        bttnAdvSet.BackColor = Color.White
        bttnAdvSet.FlatAppearance.MouseDownBackColor = Color.White
        bttnAdvSet.FlatAppearance.MouseOverBackColor = Color.White
        bttnSimpleSet.BackColor = Color.Transparent
        bttnSimpleSet.FlatAppearance.MouseDownBackColor = Nothing
        bttnSimpleSet.FlatAppearance.MouseOverBackColor = Nothing
    End Sub

    Private Sub bttnSimpleSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSimpleSet.Click
        lblifSim.Text = 0
        panCleanerAdv.Visible = False
        panEasySet.Visible = True
        bttnAdvSet.BackColor = Color.Transparent
        bttnAdvSet.FlatAppearance.MouseDownBackColor = Nothing
        bttnAdvSet.FlatAppearance.MouseOverBackColor = Nothing
        bttnSimpleSet.BackColor = Color.White
        bttnSimpleSet.FlatAppearance.MouseDownBackColor = Color.White
        bttnSimpleSet.FlatAppearance.MouseOverBackColor = Color.White
    End Sub

    Private Sub lod1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lod1.Click
        If lod1.Location.X = 30 Then
            If tmrMove.Enabled = False And lod1.Location.X = 30 Then
                tmrMove.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4401")
            End If
        ElseIf lod1.Location.X = 260 Then
            If tmrMove2.Enabled = False And lod1.Location.X = 260 Then
                tmrMove2.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4402")
            End If
        Else
            If tmrMove3.Enabled = False And lod1.Location.X = 490 Then
                tmrMove3.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4403")
            End If
        End If
    End Sub

    Private Sub Panel9_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel9.MouseClick
        If lod1.Location.X = 30 Then
            If tmrMove.Enabled = False And lod1.Location.X = 30 Then
                tmrMove.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4401")
            End If
        ElseIf lod1.Location.X = 260 Then
            If tmrMove2.Enabled = False And lod1.Location.X = 260 Then
                tmrMove2.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4402")
            End If
        Else
            If tmrMove3.Enabled = False And lod1.Location.X = 490 Then
                tmrMove3.Enabled = True
            Else
                Debug_Info.ListBox1.Items.Add("Click Cancelled out at Settings Cleaner at " & My.Computer.Clock.LocalTime & " Warning : SET 4403")
            End If
        End If
    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick
        'If lod1.Location.X = 35 Then
        If lod1.Location.X = 260 Then
            tmrMove.Enabled = False
        Else
            lod1.Location = New Point(lod1.Location.X + 10, lod1.Location.Y)
        End If
        'ElseIf lod1.Location.X = 260 Then
        '    If lod1.Location.X = 485 Then
        '        tmrMove.Enabled = False
        '    Else
        '        lod1.Location = New Point(lod1.Location.X + 5, lod1.Location.Y)
        '    End If
        'Else
        '    If lod1.Location.X = 35 Then
        '        tmrMove.Enabled = False
        '    Else
        '        lod1.Location = New Point(lod1.Location.X - 10, lod1.Location.Y)
        '    End If
        ' End If
    End Sub

    Private Sub tmrMove2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove2.Tick
        If lod1.Location.X = 490 Then
            tmrMove2.Enabled = False
        Else
            lod1.Location = New Point(lod1.Location.X + 10, lod1.Location.Y)
        End If
    End Sub

    Private Sub tmrMove3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove3.Tick
        If lod1.Location.X = 30 Then
            tmrMove3.Enabled = False
        Else
            lod1.Location = New Point(lod1.Location.X - 10, lod1.Location.Y)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Sys Optimizer Launcher", Application.StartupPath & "\starter.exe")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

        'Debug_Info.ShowDialog()
    End Sub
    Private Shared Sub UploadStringCallback2(ByVal sender As Object, ByVal e As UploadStringCompletedEventArgs)
        Dim reply As String = CStr(e.Result)
        MsgBox(reply)
        Using reader As XmlReader = XmlReader.Create(New StringReader(reply))
            Dim ws As XmlWriterSettings = New XmlWriterSettings()
            ws.Indent = True

            Try
                ' Parse the file and display each of the nodes.
                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            'MsgBox("<" & reader.Name & ">")
                        Case XmlNodeType.Text
                            MsgBox(reader.Value)
                        Case XmlNodeType.XmlDeclaration
                        Case XmlNodeType.ProcessingInstruction
                            'MsgBox(reader.Name & reader.Value)

                        Case XmlNodeType.EndElement

                    End Select
                End While
            Catch ex As XmlException
                MsgBox(ex.ToString)
            End Try
        End Using



    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Login" Then
            Dim wc As New WebClient
            wc.Headers("content-type") = "application/x-www-form-urlencoded"
            'Uncomment the handler when unleashing the power of jQuryAPI for Arvin Soft
            'AddHandler wc.UploadStringCompleted, AddressOf UploadStringCallback2
            'Uncomment the above to unleash the power of JQuryAPI for Arvin Soft
            'MsgBox(txtBxUsrNm.Text & " : " & txtBxPass.Text)
            'Dim response As String = wc.UploadString("http://localhost/camplocal/phppages/jqrapi/loginchecker.php", "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")
            Dim uri As Uri = New Uri("http://www.mycampin.com/phppages/jqrapi/loginchecker.php")
            'wc.UploadStringAsync should be used below to unleash
            Dim response As String = wc.UploadString(uri, "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")

            If response = "success" Then
                My.Settings.campusrnm = txtBxUsrNm.Text
                lblusrnm.Text = "You are logged in as " & My.Settings.campusrnm.ToString
                lblusrnm.Visible = True
                txtBxUsrNm.Visible = False
                txtBxPass.Visible = False
                Label40.Visible = False
                Label41.Visible = False
                Button1.Text = "Logout"
            Else
                MsgBox("login failed")
            End If
        Else
            txtBxUsrNm.Visible = True
        txtBxUsrNm.Text = ""
        txtBxPass.Visible = True
        txtBxPass.Text = ""
        Label40.Visible = True
        Label41.Visible = True
        Button1.Text = "Login"
        My.Settings.campusrnm = ""
        lblusrnm.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Settings.monstart = 1
        Else
            My.Settings.monstart = 0
        End If
    End Sub
End Class