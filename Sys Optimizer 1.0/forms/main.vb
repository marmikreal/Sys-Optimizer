'******************************************************************************************************************
'*        Developed by Arvin Soft in association with the developers in citrus software development group         *
'*                               Copyright (C) 2010-2015 Arvin Soft. All Rights Reserved.                         *
'*                          Copyright (C) 2014 Citrus Software Development Group. All Rights Reserved             *
'*        Software Design is Copyrighted to Arvin Graphics. The Design and Concept is designed by Arvin Graphics  *
'*                               Copyright (C) 2009-2015 Arvin Graphics. All Rights Reserved.                     *
'******************************************************************************************************************
'##################################################################################################################
'#                Please don't modify the source code below if you don't know what you are doing.                 #
'#             The source code below will make the interface respond to the user commands. so don't touch         #
'##################################################################################################################
Imports System.IO
Imports System.Xml
Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Net

Public Class main
    Public val
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            If panLstSoft.Visible = True And panModules.Visible = False Then
                bttnLstSoft.BackColor = Color.LightSteelBlue
                bttnCleaner.BackColor = Color.Transparent
                bttnModules.BackColor = Color.Transparent
            ElseIf panLstSoft.Visible = True And panModules.Visible = False Then
                bttnCleaner.BackColor = Color.Transparent
                bttnLstSoft.BackColor = Color.LightSteelBlue
                bttnModules.BackColor = Color.Transparent
            ElseIf panLstSoft.Visible = False And panModules.Visible = False Then
                bttnCleaner.BackColor = Color.LightSteelBlue
                bttnLstSoft.BackColor = Color.Transparent
                bttnModules.BackColor = Color.Transparent
            End If
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        Else
            bttnCleaner.Visible = False
            bttnLstSoft.Visible = False
            bttnModules.Visible = False
            panNav.BorderStyle = BorderStyle.None
            panNav.Size = New Size(panNav.Width, 25)
            Button1.Text = "v"
        End If
    End Sub
    Dim count = 0
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
    Public Shared errormessage As String
    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'prgLdStats.Visible = True
        'prgLdStats.Value = 10
        '/TestCode/
        'Processes.Processos.GetProcUsg(Label5)
        'MsgBox("Sod")
        '/TestCode/




        Dim wc As New WebClient
        wc.Headers("content-type") = "application/x-www-form-urlencoded"
        'MsgBox(txtBxUsrNm.Text & " : " & txtBxPass.Text)
        If My.Settings.campusrnm <> "" And My.Settings.monstart = 1 Then
            'Dim response As String = wc.UploadString("http://localhost/camplocal/phppages/jqrapi/loginchecker.php", "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")
            Dim response As String = wc.UploadString("http://www.mycampin.com/phppages/jqrapi/loginchecker.php", "usrnm=" & My.Settings.campusrnm & "&sysnm=" & My.Computer.Name.ToString & "&lognm=Sys Optimizer Start Time" & "&logtm=Date : " & My.Computer.Clock.LocalTime.Day & "/" & My.Computer.Clock.LocalTime.Month & "/" & My.Computer.Clock.LocalTime.Year & " Time : " & My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute & "&apimeth=2")
            'MsgBox(response)
            If response = "success" Then

            Else
                MsgBox("some error in uploading data")
            End If
        Else
            'MsgBox("ads")
        End If





        Debug_Info.ListBox1.Items.Add("Software Loading Started at " & My.Computer.Clock.LocalTime)
        SysSplash.Status("Loading System time")
        SetTime()
        Debug_Info.ListBox1.Items.Add("Loaded System Time at " & My.Computer.Clock.LocalTime)
        SysSplash.Status("Checking System")
        'prgLdStats.Value = 50
        Dim objEDI As New clsWMI
        With objEDI
            If .BatAvl = "" Then
                'bttnBat.Visible = False
                lblBatPer.Visible = False
                PicBat.Visible = False
                lblTmRem.Visible = False
            Else
                SysSplash.Status("Checking battery settings")
                tmrBat.Enabled = True
                lblBatPer.Text = "Bat : " & .BatLvl & " %"
                lblTmRem.Text = Misc.clsWMID.batInfo.BatteryInfo()
                Debug_Info.ListBox1.Items.Add("Loaded Battery Info at " & My.Computer.Clock.LocalTime)
            End If
        End With
        'FirstRun.ShowDialog()
        'If File.Exists(Application.StartupPath & "\serial.xml") = False Then
        '    SerialCheck.ShowDialog()
        'End If
        'Misc.perk()
        SysSplash.Status("Loading os information")
        lblTm.Text = My.Computer.Info.OSFullName
        lblPro.Text = ""
        'prgLdStats.Value = 50


        ' prgLdStats.Value = 75
        SysSplash.Status("Loading running processes")

        tmrCurrTim.Enabled = True
        SysSplash.Status("Showing First Run")
        ' FirstRun.ShowDialog()
        SysSplash.Status("Loading system info")
        If File.Exists(Application.StartupPath & "\settingsvisible.xml") = False Or File.Exists(Application.StartupPath & "\settingschecked.xml") = False Then
            FirstRun.ShowDialog()
        End If
        SysSplash.Status("Loading Plugins")
        Misc.LoadPlugins(lstPlugins, imgPlugins)
        SysSplash.Status("Loading Interface")
        If My.Computer.Clock.LocalTime.Month = 12 Then
            'fl8.Visible = True
            fl9.Visible = True
        Else
            'fl8.Visible = False
            fl9.Visible = False
        End If
        If My.Settings.gameBoost = 0 Then
            picGameBoosterSwitch.Location = New Point(620, picGameBoosterSwitch.Location.Y)
            picGameBoosterSwitch.BackColor = Color.LightCoral
            stLiveTun("Live tuner And game booster Disabled")
            Timer2.Enabled = False

        Else
            'Game Booster running normally no game executables detected
            stLiveTun("Game Booster running normally no game executables detected")
            picGameBoosterSwitch.BackColor = Color.LightSeaGreen
            picGameBoosterSwitch.Location = New Point(640, picGameBoosterSwitch.Location.Y)
            Timer2.Enabled = True

        End If
        If My.Settings.tmrTyp = "1" Then
            Timer3.Enabled = True
            Timer4.Enabled = True
        End If
        ' MsgBox(Timer1.Enabled)
        'MsgBox(Timer2.Enabled)
        'If My.Settings.hrdview = 0 Then
        '    '1 = 174
        '    '0 = 152
        '    picSwitchHrd.Location = New Point(152, picSwitchHrd.Location.Y)
        '    TreeView1.Visible = False
        '    lstHrdDev.Visible = True
        'ElseIf My.Settings.hrdview = 1 Then
        '    picSwitchHrd.Location = New Point(174, picSwitchHrd.Location.Y)
        '    TreeView1.Visible = True
        '    lstHrdDev.Visible = False
        'End If

        If My.Settings.livUpdat = 1 Then
            tmrNottyNotifications.Enabled = True
            tmrShowNoti.Enabled = True
            'RTBMesages.Visible = True
            Dim xlswmi As New glsWMI
            With xlswmi
                If .GetBatAvl <> "" Then
                    tmrNottyNotifications.Enabled = True
                    tmrShowNoti.Enabled = True
                    If picGameBoosterSwitch.Location.X = 620 Then
                        RTBMesages.Text = "Live tuner And game booster Disabled"
                    Else
                        RTBMesages.Text = "Game Booster running normally no game executables detected"
                    End If
                    togglebutton.BackColor = Color.LightSeaGreen
                    togglebutton.Location = New Point(640, togglebutton.Location.Y)
                End If
            End With
            If File.Exists(Application.StartupPath & "\Sys Notifier.exe") = True Then
                If ProcessRunning("Sys Notifier") <> 1 Then
                    Process.Start(Application.StartupPath & "\Sys Notifier.exe")
                    If File.Exists(Application.StartupPath & "\RunNot.txt") = False Then
                        File.Copy(Application.StartupPath & "\Proc\RunNot.txt", Application.StartupPath & "\RunNot.txt")
                    End If
                End If
            Else
                MsgBox("Does Not exist")
            End If
            togglebutton.BackColor = Color.LightSeaGreen
            togglebutton.Location = New Point(640, togglebutton.Location.Y)
        Else
            tmrNottyNotifications.Enabled = False
            tmrShowNoti.Enabled = False
            'RTBMesages.Visible = False
            If picGameBoosterSwitch.Location.X = 620 Then
                RTBMesages.Text = "Live tuner And game booster Disabled"
            Else
                RTBMesages.Text = "Game Booster running normally no game executables detected"
            End If
            togglebutton.BackColor = Color.LightCoral
            togglebutton.Location = New Point(620, togglebutton.Location.Y)
            File.Delete(Application.StartupPath & "\RunNot.txt")
        End If
        SysSplash.Status("Settings Location Coordinates")
        lblPos.Text = "X : " & Me.Bounds.X & " Y : " & Me.Bounds.Y
        If Directory.Exists(Application.StartupPath & "\Plugins") = True Then
            If File.Exists(Application.StartupPath & "\Plugins\x.txt") = True And File.Exists(Application.StartupPath & "\Plugins\y.txt") Then
                File.Delete(Application.StartupPath & "\Plugins\x.txt")
                File.Delete(Application.StartupPath & "\Plugins\y.txt")
                rtbOx.Text = Me.Bounds.X
                rtbOx.SaveFile(Application.StartupPath & "\Plugins\x.txt", RichTextBoxStreamType.PlainText)
                rtbOx.Text = ""
                rtbOx.Text = Me.Bounds.Y
                rtbOx.SaveFile(Application.StartupPath & "\Plugins\y.txt", RichTextBoxStreamType.PlainText)
            Else
                rtbOx.Text = Me.Bounds.X
                rtbOx.SaveFile(Application.StartupPath & "\Plugins\x.txt", RichTextBoxStreamType.PlainText)
                rtbOx.Text = ""
                rtbOx.Text = Me.Bounds.Y
                rtbOx.SaveFile(Application.StartupPath & "\Plugins\y.txt", RichTextBoxStreamType.PlainText)
            End If
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Plugins")
        End If
        SysSplash.Status("Setting theme to form")
        'If My.Settings.themse = 3 Then
        'Misc.munch3(Me)
        'ElseIf My.Settings.themse = 2 Then
        'Misc.munch2()
        'ElseIf My.Settings.themse = 4 Then
        'Misc.munch4()
        'ElseIf My.Settings.themse = 5 Then
        'Misc.munch5()
        'Else
        'Misc.munch5()
        'End If
        tmrLiveTuner.Enabled = True
        lblWhatLod.Text = "loading system information..."
        lblRAMCapandUsg.Text = "RAM : " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 0) - Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, 0) & " MB / " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 0) & " MB"
        Misc.GraphicCardd(lblGraphics)
        lblRamCap1.Text = Misc.GetProcessorInformation
        Processes.Services.EnumerateServices(lstServ)
        'Misc.GetHrdInfo(TreeView1)
        Misc.SetInterface(Me)
        Dim user = My.User.Name.Remove(0, My.Computer.Name.Length + 1)
        user = user.Remove(1, user.Length - 1)
        ' MsgBox(user)
        lblUser.Text = user
        lblUserName.Text = "User Name : " & My.User.Name.Remove(0, My.Computer.Name.Length + 1)
        lblPCNm.Text = "Computer Name : " & My.Computer.Name
        If My.Computer.Screen.Bounds.Width = 1920 And My.Computer.Screen.Bounds.Height = 1080 Then
            lblScreen.Text = "Screen : Full HD ( " & My.Computer.Screen.Bounds.Width & " X " & My.Computer.Screen.Bounds.Height & " )"
        Else
            lblScreen.Text = "Screen : " & My.Computer.Screen.Bounds.Width & " X " & My.Computer.Screen.Bounds.Height
        End If
        'If ProcessRunning("firefox") = 1 Then
        '    MessageBoxEx.SetText(MessageBoxEx.lblMessToDis, MessageBoxEx.lblSubMess, "Firefox.exe is running", "You can choose close program or skip files")
        '    MessageBoxEx.ShowDialog()
        'End If

        prgLdStats.Value = 100
        prgLdStats.Visible = False
        'panPopupMess.Visible = True
        tmrProc.Enabled = True
        lblWhatLod.Text = "loading Softwares..."
        EnumSoftwareAssoc.GetInstalledProgramsonline(ProgramsLvw, imgLstSoft)
        lblWhatLod.Text = "removing duplicates from softwares..."
        RemoveDuplicates(ProgramsLvw)
        lblWhatLod.Text = "loading processes..."
        If My.Settings.oldcomp = 0 Then
            EnumProcessAssoc.EnumerateProcessonline(lstProc, imgLstProc)
        Else
            EnumProcessAssoc.EnumerateProcessonline1(lstProc, imgLstProc)
        End If
        lblWhatLod.Text = "sorting processes..."
        Sort()
        sortproc()
        Debug_Info.ListBox1.Items.Add("Software Loaded at " & My.Computer.Clock.LocalTime)
        'MsgBox(My.User.Name.Remove(0, My.Computer.Name.Length + 1) & " : " & My.User.Name.Length)
    End Sub

    Private Sub main_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'Crash_Box.ShowDialog()
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.Location.X > Me.Width - 175 Then
                ' MsgBox("Pressed after")
            Else
                panOptions.Location = New Point(e.Location.X + 10, e.Location.Y)
                panOptions.Visible = True
            End If
        End If
    End Sub

    Private Sub main_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'MsgBox(Me.Width)
        'MsgBox(e.X)
        If e.Button = MouseButtons.Left And e.Y > 0 And e.Y < 50 Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        If e.X > Me.Width - 30 Then
            lblTouch.Text = 1
            lblFrRv.Text = 0
            ' MsgBox(e.X & " " & Me.Width - 30)
            If lblNav.Text = "1" Then

                panCleaner.Enabled = False
            ElseIf lblNav.Text = "2" Then
                panLstSoft.Enabled = False
            ElseIf lblNav.Text = "3" Then
                panModules.Enabled = False
            End If
            ' panCleaner.Enabled = False
        End If
        ' MsgBox(e.X)
        If e.X > 0 And e.X < 150 Then
            lblTouch.Text = 1
            lblFrRv.Text = 1
            If lblNav.Text = "1" Then
                panCleaner.Enabled = False
                ' MsgBox("e")
            ElseIf lblNav.Text = "2" Then
                panLstSoft.Enabled = False
            ElseIf lblNav.Text = "3" Then
                panLstSoft.Enabled = True
            End If
        End If
    End Sub

    Private Sub main_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        'If lblTouch.Text = "1" Then
        '    If lblFrRv.Text = 0 Then
        '        If lblNav.Text = "1" Then

        '            'If Windows.Forms.MouseButtons.Left Then

        '            If panCleaner.Location.X > "-" & panCleaner.Width - 150 Then
        '                panCleaner.Location = New Point(e.X - panCleaner.Width - 15, 89)
        '            Else
        '                panCleaner.Location = New Point(-+panCleaner.Width, 89)
        '                prgLdStats.Visible = True
        '                prgLdStats.Value = 25
        '                panLstSoft.Visible = True
        '                panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
        '                panLstSoft.Location = New Point(18, 89)
        '                'panNavCleaner.BackColor = Color.AliceBlue 
        '                'lblScanStatus.Visible = False
        '                'lblLabelSection.ForeColor = Color.Black
        '                'lblNoOfFls.ForeColor = Color.Black
        '                prgLdStats.Value = 50
        '                lblLabelSection.Text = "Software and others"
        '                bttnCleaner.BackColor = Color.Transparent
        '                bttnLstSoft.BackColor = Color.LightSteelBlue
        '                bttnModules.BackColor = Color.Transparent
        '                prgLdStats.Value = 75
        '                'panCleaner.Hide()
        '                lblNav.Text = 2
        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    'If panLstSoft.Visible = True Then
        '                    '    bttnLstSoft.BackColor = Color.LightSteelBlue
        '                    '    bttnCleaner.BackColor = Color.Transparent
        '                    'Else
        '                    '    bttnCleaner.BackColor = Color.LightSteelBlue
        '                    '    bttnLstSoft.BackColor = Color.Transparent
        '                    'End If
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    bttnModules.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                    'MsgBox("exe")
        '                End If
        '                'System.Threading.Thread.Sleep(500)

        '                prgLdStats.Value = 100
        '                prgLdStats.Visible = False

        '                'End If
        '                'System.Threading.Thread.Sleep(500)
        '                lblTouch.Text = 0
        '            End If

        '        ElseIf lblNav.Text = "2" Then
        '            'If Windows.Forms.MouseButtons.Left Then
        '            If panLstSoft.Location.X > "-" & panLstSoft.Width - 150 Then
        '                panLstSoft.Location = New Point(e.X - panLstSoft.Width - 15, 89)
        '            Else
        '                panLstSoft.Visible = False
        '                panModules.Visible = True
        '                panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
        '                panModules.Location = New Point(18, 89)
        '                'panNavCleaner.BackColor = Color.AliceBlue
        '                'lblScanStatus.Visible = False
        '                'lblLabelSection.ForeColor = Color.Black
        '                'lblNoOfFls.ForeColor = Color.Black
        '                lblLabelSection.Text = "Modules"
        '                bttnCleaner.BackColor = Color.Transparent
        '                bttnLstSoft.BackColor = Color.Transparent
        '                bttnModules.BackColor = Color.LightSteelBlue
        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnModules.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                End If
        '                lblTouch.Text = 0
        '                lblNav.Text = 3
        '            End If
        '            'End If
        '        ElseIf lblNav.Text = "3" Then
        '            If panModules.Location.X > "-" & panModules.Width - 150 Then
        '                panModules.Location = New Point(e.X - panModules.Width - 15, 89)
        '            Else
        '                panLstSoft.Visible = False
        '                panModules.Visible = False
        '                panCleaner.Visible = True
        '                'panNavCleaner.BackColor = Color.Firebrick
        '                panCleaner.Location = New Point(18, 89)
        '                'lblScanStatus.Visible = True
        '                ' lblLabelSection.ForeColor = Color.WhiteSmoke
        '                'lblNoOfFls.ForeColor = Color.WhiteSmoke
        '                lblLabelSection.Text = "Cleaner"
        '                bttnCleaner.BackColor = Color.LightSteelBlue
        '                bttnLstSoft.BackColor = Color.Transparent
        '                bttnModules.BackColor = Color.Transparent
        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    'If panLstSoft.Visible = True Then
        '                    '    bttnLstSoft.BackColor = Color.LightSteelBlue
        '                    '    bttnCleaner.BackColor = Color.Transparent
        '                    'Else
        '                    '    bttnCleaner.BackColor = Color.LightSteelBlue
        '                    '    bttnLstSoft.BackColor = Color.Transparent
        '                    'End If
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    bttnModules.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                End If
        '                lblTouch.Text = 0
        '                lblNav.Text = 1
        '            End If
        '        End If

        '    ElseIf lblFrRv.Text = "1" Then
        '        If lblNav.Text = "1" Then
        '            ' MsgBox(panCleaner.Location.X & " " & panCleaner.Width)
        '            If panCleaner.Location.X < panCleaner.Width - 150 Then
        '                ' MsgBox("en")
        '                panCleaner.Location = New Point(e.X + 5, 89)
        '            Else
        '                ' MsgBox("hello")
        '                panCleaner.Visible = False
        '                panLstSoft.Visible = False
        '                panModules.Visible = True
        '                panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
        '                panModules.Location = New Point(18, 89)
        '                'panNavCleaner.BackColor = Color.AliceBlue
        '                'lblScanStatus.Visible = False
        '                'lblLabelSection.ForeColor = Color.Black
        '                'lblNoOfFls.ForeColor = Color.Black
        '                lblLabelSection.Text = "Modules"
        '                bttnCleaner.BackColor = Color.Transparent
        '                bttnLstSoft.BackColor = Color.Transparent
        '                bttnModules.BackColor = Color.LightSteelBlue
        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnModules.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                End If
        '                lblTouch.Text = 0
        '                lblNav.Text = 3
        '            End If
        '        ElseIf lblNav.Text = "3" Then
        '            '  MsgBox("3.0")
        '            If panModules.Location.X < panModules.Width - 150 Then
        '                panModules.Location = New Point(e.X + 5, 89)
        '                '  MsgBox("3")
        '            Else
        '                panCleaner.Location = New Point(-+panCleaner.Width, 89)
        '                prgLdStats.Visible = True
        '                prgLdStats.Value = 25
        '                panModules.Visible = False
        '                panLstSoft.Visible = True
        '                panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
        '                panLstSoft.Location = New Point(18, 89)
        '                'panNavCleaner.BackColor = Color.AliceBlue 
        '                'lblScanStatus.Visible = False
        '                'lblLabelSection.ForeColor = Color.Black
        '                'lblNoOfFls.ForeColor = Color.Black
        '                prgLdStats.Value = 50
        '                lblLabelSection.Text = "Software and others"
        '                bttnCleaner.BackColor = Color.Transparent
        '                bttnLstSoft.BackColor = Color.LightSteelBlue
        '                bttnModules.BackColor = Color.Transparent
        '                prgLdStats.Value = 75
        '                'panCleaner.Hide()

        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    'If panLstSoft.Visible = True Then
        '                    '    bttnLstSoft.BackColor = Color.LightSteelBlue
        '                    '    bttnCleaner.BackColor = Color.Transparent
        '                    'Else
        '                    '    bttnCleaner.BackColor = Color.LightSteelBlue
        '                    '    bttnLstSoft.BackColor = Color.Transparent
        '                    'End If
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    bttnModules.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                    'MsgBox("exe")
        '                End If
        '                'System.Threading.Thread.Sleep(500)

        '                prgLdStats.Value = 100
        '                prgLdStats.Visible = False

        '                'End If
        '                'System.Threading.Thread.Sleep(500)
        '                lblTouch.Text = 0
        '                lblNav.Text = 2
        '                ' MsgBox(lblNav.Text)
        '            End If
        '        ElseIf lblNav.Text = "2" Then
        '            'MsgBox("4.0")
        '            If panLstSoft.Location.X < panLstSoft.Width - 150 Then
        '                panLstSoft.Location = New Point(e.X + 5, 89)
        '                'MsgBox("4")
        '            Else
        '                panLstSoft.Visible = False
        '                panModules.Visible = False
        '                'panNavCleaner.BackColor = Color.Firebrick
        '                panCleaner.Location = New Point(18, 89)
        '                'lblScanStatus.Visible = True
        '                panCleaner.Visible = True
        '                ' lblLabelSection.ForeColor = Color.WhiteSmoke
        '                'lblNoOfFls.ForeColor = Color.WhiteSmoke
        '                lblLabelSection.Text = "Cleaner"
        '                bttnCleaner.BackColor = Color.LightSteelBlue
        '                bttnLstSoft.BackColor = Color.Transparent
        '                bttnModules.BackColor = Color.Transparent
        '                If panNav.Height = 25 Then
        '                    panNav.Size = New Size(panNav.Width, 59)
        '                    Button1.Text = "^"
        '                    'If panLstSoft.Visible = True Then
        '                    '    bttnLstSoft.BackColor = Color.LightSteelBlue
        '                    '    bttnCleaner.BackColor = Color.Transparent
        '                    'Else
        '                    '    bttnCleaner.BackColor = Color.LightSteelBlue
        '                    '    bttnLstSoft.BackColor = Color.Transparent
        '                    'End If
        '                    tmrClosNav.Enabled = True
        '                    bttnCleaner.Visible = True
        '                    bttnLstSoft.Visible = True
        '                    bttnModules.Visible = True
        '                    panNav.BorderStyle = BorderStyle.FixedSingle
        '                End If
        '                lblTouch.Text = 0
        '                lblNav.Text = 1
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub main_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        lblTouch.Text = 0

        If lblNav.Text = "1" Then
            If panCleaner.Location.X = 9 Or panCleaner.Location.X > "-" & panCleaner.Width Then
                panCleaner.Location = New Point(18, 89)
                panCleaner.Enabled = True
                ' MsgBox("1.1")
            End If
        ElseIf lblNav.Text = "2" Then
            If panLstSoft.Location.X = 9 Or panLstSoft.Location.X > "-" & panLstSoft.Width Then
                panLstSoft.Location = New Point(18, 89)
                panLstSoft.Enabled = True
                ' MsgBox("2.1")
            End If
        ElseIf lblNav.Text = "3" Then
            If panModules.Location.X = 9 Or panModules.Location.X > "-" & panModules.Width Then
                panModules.Location = New Point(18, 89)
                panModules.Enabled = True
                'MsgBox("3.1")
            End If
        End If
        'MsgBox(panCleaner.Location.X)
    End Sub

    Private Sub main_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        'MsgBox(e.Delta)
        If e.Delta > 0 Then
            count += 1
            If count = 7 Then
                If panLstSoft.Visible = False And panModules.Visible = False Then
                    panLstSoft.Visible = True
                    panModules.Visible = False
                    panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
                    panLstSoft.Location = New Point(18, 89)
                    'panNavCleaner.BackColor = Color.AliceBlue
                    'lblScanStatus.Visible = False
                    'lblLabelSection.ForeColor = Color.Black
                    'lblNoOfFls.ForeColor = Color.Black
                    lblLabelSection.Text = "Software and others"
                    bttnCleaner.BackColor = Color.Transparent
                    bttnLstSoft.BackColor = Color.LightSteelBlue
                    bttnModules.BackColor = Color.Transparent
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 2
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        'If panLstSoft.Visible = True Then
                        '    bttnLstSoft.BackColor = Color.LightSteelBlue
                        '    bttnCleaner.BackColor = Color.Transparent
                        'Else
                        '    bttnCleaner.BackColor = Color.LightSteelBlue
                        '    bttnLstSoft.BackColor = Color.Transparent
                        'End If
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnLstSoft.Visible = True
                        bttnModules.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0
                ElseIf panLstSoft.Visible = True And panModules.Visible = False Then
                    panLstSoft.Visible = False
                    panModules.Visible = True
                    panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
                    panModules.Location = New Point(18, 89)
                    'panNavCleaner.BackColor = Color.AliceBlue
                    'lblScanStatus.Visible = False
                    'lblLabelSection.ForeColor = Color.Black
                    'lblNoOfFls.ForeColor = Color.Black
                    lblLabelSection.Text = "Modules"
                    bttnCleaner.BackColor = Color.Transparent
                    bttnLstSoft.BackColor = Color.Transparent
                    bttnModules.BackColor = Color.LightSteelBlue
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 3
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnModules.Visible = True
                        bttnLstSoft.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0
                ElseIf panLstSoft.Visible = False And panModules.Visible = True Then
                    panLstSoft.Visible = False
                    panModules.Visible = False
                    'panNavCleaner.BackColor = Color.Firebrick
                    panCleaner.Location = New Point(18, 89)
                    'lblScanStatus.Visible = True
                    ' lblLabelSection.ForeColor = Color.WhiteSmoke
                    'lblNoOfFls.ForeColor = Color.WhiteSmoke
                    lblLabelSection.Text = "Cleaner"
                    bttnCleaner.BackColor = Color.LightSteelBlue
                    bttnLstSoft.BackColor = Color.Transparent
                    bttnModules.BackColor = Color.Transparent
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 1
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        'If panLstSoft.Visible = True Then
                        '    bttnLstSoft.BackColor = Color.LightSteelBlue
                        '    bttnCleaner.BackColor = Color.Transparent
                        'Else
                        '    bttnCleaner.BackColor = Color.LightSteelBlue
                        '    bttnLstSoft.BackColor = Color.Transparent
                        'End If
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnLstSoft.Visible = True
                        bttnModules.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0
                Else

                End If

            End If
        Else
            count += 1
            If count = 7 Then
                If panLstSoft.Visible = False And panModules.Visible = False Then
                    panLstSoft.Visible = False
                    panModules.Visible = True
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 3
                    panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
                    panModules.Location = New Point(18, 89)
                    'panNavCleaner.BackColor = Color.AliceBlue
                    'lblScanStatus.Visible = False
                    'lblLabelSection.ForeColor = Color.Black
                    'lblNoOfFls.ForeColor = Color.Black
                    lblLabelSection.Text = "Modules"
                    bttnCleaner.BackColor = Color.Transparent
                    bttnLstSoft.BackColor = Color.Transparent
                    bttnModules.BackColor = Color.LightSteelBlue
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnModules.Visible = True
                        bttnLstSoft.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0

                ElseIf panLstSoft.Visible = True And panModules.Visible = False Then
                    panLstSoft.Visible = False
                    panModules.Visible = False
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 1
                    panCleaner.Location = New Point(18, 89)
                    'panNavCleaner.BackColor = Color.Firebrick
                    'lblScanStatus.Visible = True
                    ' lblLabelSection.ForeColor = Color.WhiteSmoke
                    'lblNoOfFls.ForeColor = Color.WhiteSmoke
                    lblLabelSection.Text = "Cleaner"
                    bttnCleaner.BackColor = Color.LightSteelBlue
                    bttnLstSoft.BackColor = Color.Transparent
                    bttnModules.BackColor = Color.Transparent
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        'If panLstSoft.Visible = True Then
                        '    bttnLstSoft.BackColor = Color.LightSteelBlue
                        '    bttnCleaner.BackColor = Color.Transparent
                        'Else
                        '    bttnCleaner.BackColor = Color.LightSteelBlue
                        '    bttnLstSoft.BackColor = Color.Transparent
                        'End If
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnLstSoft.Visible = True
                        bttnModules.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0
                ElseIf panLstSoft.Visible = False And panModules.Visible = True Then
                    panLstSoft.Visible = True
                    panModules.Visible = False
                    panLstSoft.Enabled = True
                    panCleaner.Enabled = True
                    panModules.Enabled = True
                    lblNav.Text = 2
                    panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
                    panLstSoft.Location = New Point(18, 89)
                    'panNavCleaner.BackColor = Color.AliceBlue
                    'lblScanStatus.Visible = False
                    'lblLabelSection.ForeColor = Color.Black
                    'lblNoOfFls.ForeColor = Color.Black
                    lblLabelSection.Text = "Software and others"
                    bttnCleaner.BackColor = Color.Transparent
                    bttnLstSoft.BackColor = Color.LightSteelBlue
                    bttnModules.BackColor = Color.Transparent
                    If panNav.Height = 25 Then
                        panNav.Size = New Size(panNav.Width, 59)
                        Button1.Text = "^"
                        'If panLstSoft.Visible = True Then
                        '    bttnLstSoft.BackColor = Color.LightSteelBlue
                        '    bttnCleaner.BackColor = Color.Transparent
                        'Else
                        '    bttnCleaner.BackColor = Color.LightSteelBlue
                        '    bttnLstSoft.BackColor = Color.Transparent
                        'End If
                        tmrClosNav.Enabled = True
                        bttnCleaner.Visible = True
                        bttnLstSoft.Visible = True
                        bttnModules.Visible = True
                        panNav.BorderStyle = BorderStyle.FixedSingle
                    End If
                    count = 0

                Else

                End If

            End If
        End If
    End Sub
    Private Sub panNav_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panNav.MouseClick
        'If panNav.Height = 25 Then
        '    panNav.Size = New Size(panNav.Width, 59)
        '    Button1.Text = "^"
        '    If panLstSoft.Visible = True And panModules.Visible = False Then
        '        bttnLstSoft.BackColor = Color.LightSteelBlue
        '        bttnCleaner.BackColor = Color.Transparent
        '        bttnModules.BackColor = Color.Transparent
        '    ElseIf panLstSoft.Visible = True And panModules.Visible = False Then
        '        bttnCleaner.BackColor = Color.Transparent
        '        bttnLstSoft.BackColor = Color.LightSteelBlue
        '        bttnModules.BackColor = Color.Transparent
        '    ElseIf panLstSoft.Visible = False And panModules.Visible = False Then
        '        bttnCleaner.BackColor = Color.LightSteelBlue
        '        bttnLstSoft.BackColor = Color.Transparent
        '        bttnModules.BackColor = Color.Transparent
        '    End If
        '    bttnCleaner.Visible = True
        '    bttnLstSoft.Visible = True
        '    bttnModules.Visible = True
        '    panNav.BorderStyle = BorderStyle.FixedSingle
        'Else
        '    bttnCleaner.Visible = False
        '    bttnLstSoft.Visible = False
        '    bttnModules.Visible = False
        '    panNav.Size = New Size(panNav.Width, 25)
        '    panNav.BorderStyle = BorderStyle.None
        '    Button1.Text = "v"
        'End If
    End Sub

    Private Sub panNavCleaner_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        panOptions.Visible = False
        'If panCleaner.Visible = True Then
        '    panCleaner.Visible = False

        'Else
        '    panCleaner.Visible = True
        'End If
    End Sub


    Private Sub bttnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub bttnNavModPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNavModPrev.Click
        panLstSoft.Visible = True
        panModules.Visible = False
        panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
        panLstSoft.Location = New Point(1, 89)
        'panNavCleaner.BackColor = Color.AliceBlue
        ' lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        lblLabelSection.Text = "Software and others"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.LightSteelBlue
        bttnModules.BackColor = Color.Transparent
        panCleaner.Enabled = True
        panLstSoft.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 2
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            'If panLstSoft.Visible = True Then
            '    bttnLstSoft.BackColor = Color.LightSteelBlue
            '    bttnCleaner.BackColor = Color.Transparent
            'Else
            '    bttnCleaner.BackColor = Color.LightSteelBlue
            '    bttnLstSoft.BackColor = Color.Transparent
            'End If
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub
    Private Sub bttnNavSoftNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNavSoftNext.Click
        panLstSoft.Visible = False
        panModules.Visible = True
        panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
        panModules.Location = New Point(1, 89)
        'panNavCleaner.BackColor = Color.AliceBlue
        'lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        lblLabelSection.Text = "Modules"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.LightSteelBlue
        panCleaner.Enabled = True
        panLstSoft.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 3
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub
    Private Sub bttnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNavSoftPrev.Click
        panLstSoft.Visible = False
        'panNavCleaner.BackColor = Color.Firebrick
        'lblScanStatus.Visible = True
        'lblLabelSection.ForeColor = Color.WhiteSmoke
        ' lblNoOfFls.ForeColor = Color.WhiteSmoke
        lblLabelSection.Text = "Cleaner"
        bttnCleaner.BackColor = Color.LightSteelBlue
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.Transparent
        panCleaner.Location = New Point(1, 89)
        panCleaner.Enabled = True
        panLstSoft.Enabled = True
        panModules.Enabled = True
        panCleaner.Visible = True
        lblNav.Text = 1
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            'If panLstSoft.Visible = True Then
            '    bttnLstSoft.BackColor = Color.LightSteelBlue
            '    bttnCleaner.BackColor = Color.Transparent
            'Else
            '    bttnCleaner.BackColor = Color.LightSteelBlue
            '    bttnLstSoft.BackColor = Color.Transparent
            'End If
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub
    Private Sub bttnNavModnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnNavModnext.Click
        panLstSoft.Visible = False
        panModules.Visible = False
        panCleaner.Visible = True
        panCleaner.Location = New Point(1, 89)
        'panNavCleaner.BackColor = Color.Firebrick
        'lblScanStatus.Visible = True
        'lblLabelSection.ForeColor = Color.WhiteSmoke
        'lblNoOfFls.ForeColor = Color.WhiteSmoke
        lblLabelSection.Text = "Cleaner"
        bttnCleaner.BackColor = Color.LightSteelBlue
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.Transparent
        panCleaner.Enabled = True
        panLstSoft.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 1
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            'If panLstSoft.Visible = True Then
            '    bttnLstSoft.BackColor = Color.LightSteelBlue
            '    bttnCleaner.BackColor = Color.Transparent
            'Else
            '    bttnCleaner.BackColor = Color.LightSteelBlue
            '    bttnLstSoft.BackColor = Color.Transparent
            'End If
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub
    Public Function ProcessRunning(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function RemoveDuplicates(ByVal lstView As ListView) As Boolean
        Dim itemI As ListViewItem
        Dim itemJ As ListViewItem
        Dim progress As Integer
        Dim count As Integer
        Dim ProgressDupCounter As Integer = lstView.Items.Count
        For i As Integer = lstView.Items.Count - 1 To 0 Step -1
            itemI = lstView.Items(i)
            progress = progress + 1
            ' start one after hence +1
            For z As Integer = i + 1 To lstView.Items.Count - 1 Step 1
                itemJ = lstView.Items(z)
                If itemI.Text = itemJ.Text Then
                    'duplicate found, now delete duplicate
                    lstView.Items.Remove(itemJ)
                    count = count + 1
                    Exit For
                End If
            Next z
        Next (i)
        Return Nothing
    End Function
    Class listviewitemcomparer
        Implements IComparer
        Private col As Integer
        Public Sub New()
            col = 0
        End Sub
        Public Sub New(ByVal column As Integer)
            col = column
        End Sub
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim returnval As Integer = -1
            returnval = [String].Compare(CType(x,
                        ListViewItem).SubItems(col).Text,
                        CType(y, ListViewItem).SubItems(col).Text)
            Return returnval
        End Function
    End Class

    Dim sortColumn As Integer = -1

    Private Sub ProgramsLvw_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        Me.ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column)
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ProgramsLvw.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ProgramsLvw.Sorting = SortOrder.Ascending Then
                ProgramsLvw.Sorting = SortOrder.Descending
            Else
                ProgramsLvw.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ProgramsLvw.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        'ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column, ProgramsLvw.Sorting)
        'MsgBox(e.ToString)
    End Sub
    Public Sub Sort()
        'sortColumn = -1
        'ProgramsLvw.Sorting = SortOrder.Ascending
        Dim args = New ColumnClickEventArgs(0)
        ProgramsLvw_ColumnClick(Nothing, args)

    End Sub

    Private Sub main_Move(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Move
        If TmrMainPos.Enabled = False Then
            TmrMainPos.Enabled = True
        End If
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'If My.Computer.Clock.LocalTime.Month = 1 And My.Computer.Clock.LocalTime.Day = 1 Then
        '    MsgBox("Happy New Year " & My.Computer.Clock.LocalTime.Year)
        'End If
        'If My.Computer.Clock.LocalTime.Month = 12 And My.Computer.Clock.LocalTime.Day = 25 Then
        '    MsgBox("Merry Christmas")
        'End If

        'tmrSplash.Enabled = True
        panWaitLod.Visible = False
        tmrloadanimation.Enabled = False
        tmrloadanimationrev.Enabled = False
        'Timer5.Enabled = True
    End Sub
    Public Sub sortproc()
        Dim args = New ColumnClickEventArgs(0)
        lstProc_ColumnClick1(Nothing, args)
    End Sub
    Private Sub lstProc_ColumnClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        Me.lstProc.ListViewItemSorter = New listviewitemcomparer(e.Column)
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            lstProc.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lstProc.Sorting = SortOrder.Ascending Then
                lstProc.Sorting = SortOrder.Descending
            Else
                lstProc.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lstProc.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        'ProgramsLvw.ListViewItemSorter = New listviewitemcomparer(e.Column, ProgramsLvw.Sorting)
        'MsgBox(e.ToString)
    End Sub
    Private Sub picOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOptions.Click
        If panOptions.Visible = False Then
            panOptions.Visible = True
            panUser.Visible = False
            panOptions.Location = New Point(418, 1)
        Else

            panOptions.Visible = False

        End If
    End Sub

    Private Sub picOptions_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOptions.MouseEnter
        picOptions.Size = New Size(picOptions.Size.Width + 2, picOptions.Size.Height + 2)
        If panOptions.Visible = False Then
            'panOptions.Visible = True
            tmrOptions.Enabled = True
        Else
            panOptions.Visible = False
        End If
    End Sub

    Private Sub picOptions_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picOptions.MouseLeave
        picOptions.Size = New Size(picOptions.Size.Width - 2, picOptions.Size.Height - 2)
        tmrOptions.Enabled = False
    End Sub

    Private Sub bttnCleaner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCleaner.Click
        panLstSoft.Visible = False
        panModules.Visible = False
        'panNavCleaner.BackColor = Color.Firebrick
        panCleaner.Location = New Point(18, 89)
        'lblScanStatus.Visible = True
        ' lblLabelSection.ForeColor = Color.WhiteSmoke
        'lblNoOfFls.ForeColor = Color.WhiteSmoke
        lblLabelSection.Text = "Cleaner"
        bttnCleaner.BackColor = Color.LightSteelBlue
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.Transparent
        panLstSoft.Enabled = True
        panCleaner.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 1
    End Sub

    Private Sub bttnLstSoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnLstSoft.Click
        panLstSoft.Visible = True
        panModules.Visible = False
        panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
        panLstSoft.Location = New Point(18, 89)
        'panNavCleaner.BackColor = Color.AliceBlue
        'lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        lblLabelSection.Text = "Software and others"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.LightSteelBlue
        bttnModules.BackColor = Color.Transparent
        panLstSoft.Enabled = True
        panCleaner.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 2
    End Sub

    Private Sub bttnModules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnModules.Click
        panLstSoft.Visible = False
        panModules.Visible = True
        panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
        panModules.Location = New Point(18, 89)
        'panNavCleaner.BackColor = Color.AliceBlue
        'lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        lblLabelSection.Text = "Modules"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.LightSteelBlue
        panLstSoft.Enabled = True
        panCleaner.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 3
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnConAbout.Click
        'MsgBox("This is the temp about box" & vbNewLine & "Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved." & vbNewLine & "Copyright(C) 2011-2013 Sys Optimizer. All Rights Reserved.")
        panOptions.Visible = False
        About.ShowDialog()
    End Sub

    Private Sub bttnConUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnConUpdate.Click
        panOptions.Visible = False
        Updatedlg.ShowDialog()
    End Sub

    Private Sub tmrClosNav_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClosNav.Tick
        bttnCleaner.Visible = False
        bttnLstSoft.Visible = False
        bttnModules.Visible = False
        panNav.Size = New Size(panNav.Width, 25)
        Button1.Text = "v"
        tmrClosNav.Enabled = False
        panNav.BorderStyle = BorderStyle.None
    End Sub

    Private Sub tmrCurrTim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCurrTim.Tick
        SetTime()
        '/Test Code/
        'Processes.Processos.GetProcUsg(Label5)
        '/Test Code/

    End Sub
    Public Function SetTime()
        Dim min = My.Computer.Clock.LocalTime.Minute
        Dim retmin
        If min < 10 Then
            retmin = "0" & min
        Else
            retmin = min
        End If
        Dim hr = My.Computer.Clock.LocalTime.Hour
        Dim rethr
        Dim retampm
        If hr = 0 Then
            rethr = 12
            retampm = "AM"
        ElseIf hr = 1 Then
            rethr = 1
            retampm = "AM"
        ElseIf hr = 2 Then
            rethr = 2
            retampm = "AM"
        ElseIf hr = 3 Then
            rethr = 3
            retampm = "AM"
        ElseIf hr = 4 Then
            rethr = 4
            retampm = "AM"
        ElseIf hr = 5 Then
            rethr = 5
            retampm = "AM"
        ElseIf hr = 6 Then
            rethr = 6
            retampm = "AM"
        ElseIf hr = 7 Then
            rethr = 7
            retampm = "AM"
        ElseIf hr = 8 Then
            rethr = 8
            retampm = "AM"
        ElseIf hr = 9 Then
            rethr = 9
            retampm = "AM"
        ElseIf hr = 10 Then
            rethr = 10
            retampm = "AM"
        ElseIf hr = 11 Then
            rethr = 11
            retampm = "AM"
        ElseIf hr = 12 Then
            rethr = 12
            retampm = "PM"
        ElseIf hr = 13 Then
            rethr = 1
            retampm = "PM"
        ElseIf hr = 14 Then
            rethr = 2
            retampm = "PM"
        ElseIf hr = 15 Then
            rethr = 3
            retampm = "PM"
        ElseIf hr = 16 Then
            rethr = 4
            retampm = "PM"
        ElseIf hr = 17 Then
            rethr = 5
            retampm = "PM"
        ElseIf hr = 18 Then
            rethr = 6
            retampm = "PM"
        ElseIf hr = 19 Then
            rethr = 7
            retampm = "PM"
        ElseIf hr = 20 Then
            rethr = 8
            retampm = "PM"
        ElseIf hr = 21 Then
            rethr = 9
            retampm = "PM"
        ElseIf hr = 22 Then
            rethr = 10
            retampm = "PM"
        ElseIf hr = 23 Then
            rethr = 11
            retampm = "PM"
        Else
            rethr = hr
            retampm = ""
        End If
        lblCurrTm.Text = rethr & ":" & retmin & " " & retampm
        Return Nothing
    End Function
    Private Sub bttnScanFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnScanFiles.Click

        Label12.Visible = True
        lblIssue.Text = ""
        picOksp3.Visible = False
        Dim objEDI As New clsWMI
        With objEDI
            If Misc.GetActivePowerPln(lblPowerPlnRgCde) <> "High Performance" And .BatAvl = "" And My.Settings.perf = 1 Then
                ' MsgBox("HP not acti")
                'If Misc.getPowerPlans(lblPowerPlnRgCde) = "High Performance" Then
                panScanPerf.Visible = True
                If lblIssue.Text <> "" Then
                    lblIssue.Text = lblIssue.Text & vbNewLine & "Power Plan config warning" & Misc.GetActivePowerPlnOnlRet() & " is curretly active/ High Performance Recommended for the system"
                Else
                    lblIssue.Text = "Power Plan config warning" & Misc.GetActivePowerPlnOnlRet() & " is curretly active/ High Performance Recommended for the system"
                End If
                lblIssue.ForeColor = Color.LightCoral
                lblPowerPlnRgCde.Text = 1
                'End If
            ElseIf Misc.GetActivePowerPln(lblPowerPlnRgCde) <> "Power Saver" And .BatAvl <> "" And My.Settings.perf = 1 Then
                If lblIssue.Text <> "" Then
                    lblIssue.Text = lblIssue.Text & vbNewLine & "Power Plan config warning" & Misc.GetActivePowerPlnOnlRet() & " is curretly active/ Power saver is Recommended for the system"
                Else
                    lblIssue.Text = "Power Plan config warning" & Misc.GetActivePowerPlnOnlRet() & " is curretly active/ Power saver is Recommended for the system"
                End If
                lblIssue.ForeColor = Color.GreenYellow

                panScanPerf.Visible = True
                lblPowerPlnRgCde.Text = 2
            Else
                lblPowerPlnRgCde.Text = 0
                panScanPerf.Visible = False
            End If
        End With
        Label12.Visible = False
        lod1.Location = New Point(104, 18)
        lod2.Location = New Point(208, lod2.Location.Y)
        ' lod1.Visible = True
        'lod2.Visible = True
        'Panel4.Visible = True
        'Panel12.Visible = True
        lod1.BackColor = Color.LightCoral
        lod2.BackColor = Color.LightCoral
        tmrloadanisp1.Enabled = True
        tmrloadanisp2.Enabled = True
        panoverscan.Visible = True
        panintfileani.Visible = True
        tmrlodanimation.Enabled = True
        tmrloadanimation.Enabled = True
        picOksp1.Visible = False
        picOksp2.Visible = False
        Debug_Info.ListBox1.Items.Add("Scanning System for Temp Files and other files Started at " & My.Computer.Clock.LocalTime)
        bttnScanFiles.Enabled = False
        panPopupMess.BackColor = Color.FromArgb(239, 239, 239)
        Label1.ForeColor = Color.Black
        Label1.Text = "Scanning your computer..."
        PictureBox8.Image = My.Resources._1405694119_search
        OtherFiles.sizedother = 0
        InternetFiles.sized = 0
        lblScanStatus.Visible = True
        lblScanStatus1.Visible = True
        lblScanStatus1.Text = "Scanning for internet files..."
        lblScanStatus.Text = "Scanning for Windows and software temp Files..."
        lblIntFlsSize.Visible = False
        lblOthFlsSiz.Visible = False
        prgIntFls.Visible = True
        prgOthrFls.Visible = True
        bttnIntFlsDet.Visible = False
        bttnOthFlsDet.Visible = False
        ' bttnScanFiles.Visible = False
        Label4.Visible = False
        Label3.Visible = False
        prgLdStats.Visible = True
        '  Analyse.ScanForItem(prgOthrFls, prgIntFls, prgLdStats, OtherFiles.lstSoft, lblScanStatus)
        OtherFiles.lstTemp.Items.Clear()
        bttnIntFlsDet.Visible = True
        bttnOthFlsDet.Visible = True
        ' prgIntFls.Visible = False
        'prgOthrFls.Visible = False
        prgLdStats.Visible = False
        InternetFiles.tbControlBrow.Visible = False
        'OtherFiles.lstSoft.Visible = False
        'OtherFiles.lstTemp.Visible = False
        'OtherFiles.lstWER.Visible = False
        OtherFiles.lstSoft.Items.Clear()
        OtherFiles.lstTemp.Items.Clear()
        OtherFiles.lstWER.Items.Clear()
        InternetFiles.lstBrowChrom.Items.Clear()
        InternetFiles.lstBrowFF.Items.Clear()
        InternetFiles.lstBrowIE.Items.Clear()
        InternetFiles.lstBrowOper.Items.Clear()
        InternetFiles.lstBrowSaf.Items.Clear()
        InternetFiles.lstBrowThunder.Items.Clear()
        OtherFiles.TabControl3.Visible = False
        If OtherFiles.BackgroundWorker1.IsBusy = True Then
            MsgBox("Already a scan is in progress")
        Else
            OtherFiles.BackgroundWorker1.RunWorkerAsync()
        End If
        If InternetFiles.BackgroundWorker1.IsBusy = True Then
            MsgBox("Already a scan is in progress")
        Else
            InternetFiles.BackgroundWorker1.RunWorkerAsync()
        End If

        'If OtherFiles.lstTemp.Items.Count <> 0 Or OtherFiles.lstWER.Items.Count <> 0 Or OtherFiles.lstSoft.Items.Count <> 0 Then

        '    OtherFiles.tbTemp.Text = OtherFiles.lstTemp.Items.Count() & " Items"
        '    OtherFiles.tbWER.Text = OtherFiles.lstWER.Items.Count & " Items"
        '    OtherFiles.tbSoft.Text = OtherFiles.lstSoft.Items.Count & " Items"
        '    'Dim Sizes = Functiod.retrieval.sizedother
        'Else
        '    'main.lblscanitemsoth.Text = "There is no items to be cleaned"
        '    OtherFiles.tbTemp.Text = ""
        '    OtherFiles.tbWER.Text = ""
        '    OtherFiles.tbSoft.Text = ""
        '    OtherFiles.lblSzonDsk.Text = ""
        'End If

        'Else
        '    lblIntFlsSize.Text = "There is no items to be cleaned"
        '    InternetFiles.tbIE.Text = ""
        '    InternetFiles.tbFire.Text = ""
        '    InternetFiles.tbChrom.Text = ""
        '    InternetFiles.tbSaf.Text = ""
        '    InternetFiles.tbOper.Text = ""
        '    InternetFiles.tbThunder.Text = ""
        '    InternetFiles.lblSzonDsk.Visible = False
        'End If
        Label3.Text = "Internet Files"
        Label4.Visible = True
        Label3.Visible = True

        'lblIntFlsSize.Visible = True

        'lblScanStatus.Visible = False
        'panPopupMess.Visible = False

    End Sub


    Private Sub bttnConSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnConSettings.Click
        panOptions.Visible = False

        Settings.ShowDialog()
    End Sub


    Private Sub picIntFls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picIntFls.Click
        If bttnIntFlsDet.Visible = True Then
            Me.ControlBox = False
            InternetFiles.ShowDialog()
        End If
    End Sub

    Private Sub picIntFls_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picIntFls.MouseEnter
        picIntFls.Size = New Size(picIntFls.Width - 5, picIntFls.Height - 5)
    End Sub

    Private Sub picIntFls_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picIntFls.MouseLeave
        picIntFls.Size = New Size(picIntFls.Width + 5, picIntFls.Height + 5)
    End Sub

    Private Sub picWinOtherFls_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picWinOtherFls.MouseEnter
        picWinOtherFls.Size = New Size(picWinOtherFls.Width - 5, picWinOtherFls.Height - 5)
    End Sub

    Private Sub picWinOtherFls_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picWinOtherFls.MouseLeave
        picWinOtherFls.Size = New Size(picWinOtherFls.Width + 5, picWinOtherFls.Height + 5)
    End Sub

    Private Sub bttnConRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnConRestart.Click
        Dim rt = MsgBox("This will restart the software Do you want to continue ? ", MsgBoxStyle.Exclamation + vbYesNo, "Please confirm")
        If rt = vbYes Then
            Application.Restart()
        End If
    End Sub


    Private Sub bttnConHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Delegate Sub setTxe(ByVal [text] As String)
    Private Sub settex(ByVal [text] As String)
        If lblBatPer.InvokeRequired = True Then
            Dim d As New setTxe(AddressOf settex)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblBatPer.Text = [text]
        End If
    End Sub
    Delegate Sub setTmRem(ByVal [text] As String)
    Private Sub stTmRem(ByVal [text] As String)
        If lblTmRem.InvokeRequired = True Then
            Dim d As New setTmRem(AddressOf stTmRem)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblTmRem.Text = [text]
        End If
    End Sub
    Private Sub bttnUninstallSoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnUninstallSoft.Click
        If ProgramsLvw.SelectedItems.Count Then
            Dim mesret = MsgBox("Are you sure you want to uninstall this software ?", MsgBoxStyle.Question + vbYesNo, "Uninstall")
            If mesret = vbYes Then
                Dim getbit = Functiod.cpinfo.getOsBitness
                If getbit = "32" Then
                    enumSoftware.Softwares.UninstallSoftwares(ProgramsLvw)
                ElseIf getbit = "64" Then
                    enumSoftware.Softwares.UninstallSoftwares64bit(ProgramsLvw)
                Else
                    enumSoftware.Softwares.GetInstalledPrograms(ProgramsLvw)
                End If
            End If
        Else
            MsgBox("Please select an item  to uninstall", MsgBoxStyle.Information + vbOKOnly, "Uninstall")
        End If
    End Sub

    Private Sub bttnIntFlsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnIntFlsDet.Click
        Me.ControlBox = False
        InternetFiles.ShowDialog()
    End Sub

    Private Sub bttnOthFlsDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOthFlsDet.Click
        Me.ControlBox = False
        OtherFiles.ShowDialog()
    End Sub

    Private Sub BGwrkrBat_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGwrkrBat.DoWork
        Dim dlsWMI As New clsWMI
        With dlsWMI
            If .BatAvl <> "" And .BatStatus = 1 Then
                settex("Bat : " & .BatLvl & " %")
            Else
                settex("Bat : Charging")
            End If
        End With
        stTmRem(Misc.clsWMID.batInfo.BatteryInfo())
    End Sub

    Private Sub tmrBat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBat.Tick
        If BGwrkrBat.IsBusy = False Then
            BGwrkrBat.RunWorkerAsync()
        End If
    End Sub

    Private Sub bttnSystemInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SystemInformation.lblLd.Text = 1
        'SystemInformation.ShowDialog()
    End Sub
    Delegate Sub setRmUsg(ByVal [text] As String)
    Private Sub stRmUsg(ByVal [text] As String)
        If lblRAMCapandUsg.InvokeRequired = True Then
            Dim d As New setRmUsg(AddressOf stRmUsg)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblRAMCapandUsg.Text = [text]
        End If
    End Sub
    Private Sub bgWrKrRmUsg_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWrKrRmUsg.DoWork
        stRmUsg("RAM : " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 0) - Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, 0) & " MB / " & Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 0) & " MB")
    End Sub

    Private Sub tmrRAMUsg_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrRAMUsg.Tick
        If bgWrKrRmUsg.IsBusy = False Then
            bgWrKrRmUsg.RunWorkerAsync()
        End If
    End Sub

    Private Sub tmrSplash_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrSplash.Tick
        panPopupMess.Visible = True
        tmrSplash.Enabled = False
    End Sub

    Private Sub lstPlugins_ItemSelectionChanged(ByVal sender As Object, ByVal e As ListViewItemSelectionChangedEventArgs) Handles lstPlugins.ItemSelectionChanged
        Dim Id As Integer
        For Id = 0 To lstPlugins.SelectedItems.Count - 1
            Dim paths As String = (lstPlugins.SelectedItems(Id).Text)
            If paths <> "" Then
                For Each filinfold In Directory.GetFiles(Application.StartupPath & "\Plugins")
                    If IO.Path.GetExtension(filinfold) = ".xml" Then
                        'ListView1.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold))
                        Dim I As Integer
                        For I = 0 To lstPlugins.SelectedItems.Count - 1
                            Dim path As String = (lstPlugins.SelectedItems(I).Text)
                            'MsgBox("path " & path)
                            'MsgBox("Filinfold " & filinfold)
                            path = path.Replace("*", "")
                            If path = IO.Path.GetFileNameWithoutExtension(filinfold) Then
                                ' MsgBox("executed")
                                Dim dls As XmlReader = New XmlTextReader(filinfold)
                                If File.Exists(filinfold) = True Then
                                    While (dls.Read())
                                        Dim typ = dls.NodeType
                                        If typ = XmlNodeType.Element Then
                                            If dls.Name = "desc" Then
                                                rtfPluginDesc.Text = dls.ReadInnerXml.ToString
                                            End If
                                        End If
                                    End While
                                End If
                            End If
                        Next
                    End If
                Next
            Else
                rtfPluginDesc.Text = ""
            End If
        Next
    End Sub

    Private Sub lstPlugins_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lstPlugins.MouseDoubleClick
        For Each filinfold In Directory.GetFiles(Application.StartupPath & "\Plugins")
            If IO.Path.GetExtension(filinfold) = ".xml" Then
                'ListView1.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold))
                Dim I As Integer
                For I = 0 To lstPlugins.SelectedItems.Count - 1
                    Dim path As String = (lstPlugins.SelectedItems(I).Text)
                    path = path.Replace("*", "")
                    'MsgBox("path " & path)
                    'MsgBox("Filinfold " & filinfold)
                    If path = IO.Path.GetFileNameWithoutExtension(filinfold) Then
                        'MsgBox(Application.StartupPath & "\Plugins\PluginWorkParam\" & path & ".txt")
                        If File.Exists(Application.StartupPath & "\Plugins\PluginWorkParam\" & path & ".txt") = True Then
                            ' MsgBox("executed")
                            Dim dls As XmlReader = New XmlTextReader(filinfold)
                            If File.Exists(filinfold) = True Then
                                While (dls.Read())
                                    Dim typ = dls.NodeType
                                    If typ = XmlNodeType.Element Then
                                        If dls.Name = "pluginnameexe" Then
                                            Dim fil
                                            fil = Application.StartupPath & "\Plugins\" & dls.ReadInnerXml.ToString
                                            If File.Exists(fil) = True Then
                                                Process.Start(fil)
                                                lstPlugins.Visible = False
                                                bttnStpPlg.Visible = True
                                                tmrPlugins.Enabled = True
                                                lblPro.Text = IO.Path.GetFileNameWithoutExtension(fil)
                                            Else
                                                MsgBox("Executable file does not exists please contact plugin manufacturer")
                                            End If
                                        End If
                                    End If
                                End While
                                dls.Close()
                            End If
                        Else
                            MsgBox("Plugin not installed correctly")
                        End If
                    End If
                Next

            End If
        Next
    End Sub

    Private Sub tmrPlugins_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrPlugins.Tick
        'MsgBox(lblPro.Text)
        If ProcessRunning(lblPro.Text) = 1 Then

            'lblRun.Text = lblPro.Text & " : Running"
            lblPluginNotice.Text = "Modules are not visible when one module is running please close " & lblPro.Text & " module"
            lstPlugins.Visible = False
            'bttnStpPlg.Visible = True
            lblPluginNotice.Visible = True
            Me.ControlBox = False
            'Me.Enabled = False
        Else
            lblPro.Text = ""
            'lblRun.Text = "Not Running"
            lstPlugins.Visible = True
            'bttnStpPlg.Visible = False
            lblPluginNotice.Visible = False
            Me.ControlBox = True
            bttnStpPlg.Visible = False
            'Me.Enabled = True
            tmrPlugins.Enabled = False
            'lblPro.Text = "Stopped"
        End If
    End Sub

    Private Sub panPopupMess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panPopupMess.Click
        panOptions.Visible = False
    End Sub

    Private Sub panCleaner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panCleaner.Click

    End Sub

    Private Sub bttnStopProc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bttnStopProc.Click
        If lstProc.SelectedItems.Count <> 0 Then
            lstProc.Sorting = SortOrder.None
            Processes.Processos.EndProcess(lstProc)
            lstProc.Visible = False
            'Processes.Processos.EnumerateProcess(lstProc, imgproc)
            EnumProcessAssoc.EnumerateProcessonline(lstProc, imgLstProc)

            sortproc()
            lstProc.Visible = True
        Else
            MsgBox("Please select a processes name to end", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
    End Sub
    Delegate Sub setMainPos(ByVal [text] As String)
    Private Sub stMainPos(ByVal [text] As String)
        If rtbOx.InvokeRequired = True Then
            Dim d As New setRmUsg(AddressOf stMainPos)
            Me.Invoke(d, New Object() {[text]})
        Else
            rtbOx.Text = [text]
        End If
    End Sub
    Delegate Sub SaveFls(ByVal [FileName] As String, ByVal [values] As System.Windows.Forms.RichTextBoxStreamType)
    Private Sub SvFls(ByVal [FileName] As String, ByVal [values] As System.Windows.Forms.RichTextBoxStreamType)
        If rtbOx.InvokeRequired = True Then
            Dim d As New SaveFls(AddressOf SvFls)
            Me.Invoke(d, New Object() {[FileName], [values]})
        Else
            rtbOx.SaveFile([FileName], values)
        End If
    End Sub
    Private Sub BgWrkrPos_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgWrkrPos.DoWork
        If File.Exists(Application.StartupPath & "\Plugins\x.txt") = True And File.Exists(Application.StartupPath & "\Plugins\y.txt") Then
            File.Delete(Application.StartupPath & "\Plugins\x.txt")
            File.Delete(Application.StartupPath & "\Plugins\y.txt")
            stMainPos(Me.Bounds.X)
            SvFls(Application.StartupPath & "\Plugins\x.txt", RichTextBoxStreamType.PlainText)
            stMainPos("")
            stMainPos(Me.Bounds.Y - 98)
            SvFls(Application.StartupPath & "\Plugins\y.txt", RichTextBoxStreamType.PlainText)
        Else
            If Directory.Exists(Application.StartupPath & "\Plugins") = False Then
                Directory.CreateDirectory(Application.StartupPath & "\Plugins")
            End If
            stMainPos(Me.Bounds.X)
            SvFls(Application.StartupPath & "\Plugins\x.txt", RichTextBoxStreamType.PlainText)
            stMainPos("")
            stMainPos(Me.Bounds.Y - 98)
            SvFls(Application.StartupPath & "\Plugins\y.txt", RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub TmrMainPos_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TmrMainPos.Tick
        If BgWrkrPos.IsBusy = False Then
            BgWrkrPos.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgWrkrPos_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWrkrPos.RunWorkerCompleted
        TmrMainPos.Enabled = False
    End Sub

    Private Sub picWinOtherFls_Click(ByVal sender As Object, ByVal e As EventArgs) Handles picWinOtherFls.Click
        If bttnOthFlsDet.Visible = True Then
            Me.ControlBox = False
            OtherFiles.ShowDialog()
        End If
    End Sub
    Public Shared Function EndPlugin(ByVal txt As String)
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = txt Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Private Sub bttnStpPlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnStpPlg.Click
        If ProcessRunning(lblPro.Text) = 1 Then
            EndPlugin(lblPro.Text & ".exe")
            lblPro.Text = ""
        Else
            MsgBox("No Process running")
        End If
    End Sub

    Private Sub bttnConLicense_Click(sender As Object, e As EventArgs) Handles bttnReset.Click
        'panOptions.Visible = False
        'LicenseCheck.ShowDialog()
        panOptions.Visible = False

        Dim ret = MsgBox("Resetting will eraze the software settings that you've already saved." & vbNewLine & "Do you want to continue?", MsgBoxStyle.Exclamation + vbYesNo, "Please Confirm.")
        If ret = vbYes Then
            My.Settings.Reset()
            Try
                File.Delete(Application.StartupPath & "\settingsvisible.xml")
                File.Delete(Application.StartupPath & "\settingschecked.xml")
                MsgBox("Software will close automatically to open please run the software again", MsgBoxStyle.Information + vbOKOnly, "Information")
                End
            Catch ex As Exception
                MsgBox("Something happened when the software is working the error is " & vbNewLine & ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Critical Error")
            End Try
        End If
    End Sub
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4

#Region "Empty Recycle Bin (SUB)"

    Public Sub EmptyRecycleBin()
        SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION + SHERB_NOSOUND)
        SHUpdateRecycleBinIcon()
    End Sub

#End Region
    Private Sub bttnCleanAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCleanAllFiles.Click
        lod1.BackColor = Color.LightSeaGreen
        lod2.BackColor = Color.LightSeaGreen
        lod1.Location = New Point(104, 18)
        lod2.Location = New Point(208, lod2.Location.Y)
        lod1.Visible = True
        lod2.Visible = True
        Panel4.Visible = True
        Panel12.Visible = True
        picOksp1.Visible = False
        picOksp2.Visible = False
        tmrloadanisp1.Enabled = True
        tmrloadanisp2.Enabled = True
        Debug_Info.ListBox1.Items.Add("Cleaning Temp Files and Other Files started at " & My.Computer.Clock.LocalTime)
        panPopupMess.BackColor = Color.FromArgb(239, 239, 239)
        Label1.ForeColor = Color.Black
        Label1.Text = "Scanning and cleaning files on your computer..."
        PictureBox8.Image = My.Resources._1390670137_Zoom
        lblIntFlsSize.Visible = False
        lblOthFlsSiz.Visible = False
        prgIntFls.Visible = True
        prgOthrFls.Visible = True
        prgIntFls.Value = 0
        prgOthrFls.Value = 0
        'lblScanStatus.Visible = True
        lblOptimize.Visible = True
        bttnIntFlsDet.Visible = False
        bttnOthFlsDet.Visible = False
        If BgWrkrCleaning.IsBusy = False Then
            BgWrkrCleaning.RunWorkerAsync()
            bttnCleanAllFiles.Enabled = False
        Else
            MsgBox("Sorry already cleaning in progress", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
        lblOptimize.Text = "Cleaning your system"
    End Sub
    Delegate Sub setLiveTun(ByVal [text] As String)
    Private Sub stLiveTun(ByVal [text] As String)
        If RTBMesages.InvokeRequired = True Then
            Dim d As New setLiveTun(AddressOf stLiveTun)
            Me.Invoke(d, New Object() {[text]})
        Else
            RTBMesages.Text = [text]
        End If
    End Sub
    Private Sub bgWrKrNottyShow_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWrKrNottyShow.DoWork
        If lblen.Text = "7" Then
            stLiveTun("Normal: No process that use more than normal allocation of system resources detected")
        ElseIf lblen.Text = "1" Then
            'RTBMesages.Text = "Virtual Box is Running it may slow down your computer performance"
            Dim size = Math.Round((My.Computer.Info.TotalPhysicalMemory * 1 / 8) / 1024 / 1024, 0)
            stLiveTun(RichTextBox1.Text)
            ' tmrNoNoti.Enabled = False
        ElseIf lblen.Text = "2" Then
            stLiveTun("Your RAM is loaded above 70 % please close some programs to free up your RAM")
        ElseIf lblen.Text = "3" Then
            stLiveTun("Your RAM is loaded above 80 % please close some programs")
        ElseIf lblen.Text = "4" Then
            stLiveTun("Your RAM is loaded above critical limits please freeup your RAM to make your system work without lag")
        ElseIf lblen.Text = "5" Then
            stLiveTun("Processor usage is very high it will cause the system to overheat in seconds")
        ElseIf lblen.Text = "6" Then
            stLiveTun("Battery is getting low please connect a charger Please remove any usb devices to maximize usage")
        ElseIf lblen.Text = "8" Then
            stLiveTun("Battery is getting very low if you don't connect your charger the computer will hibernate automatically")
        Else
            stLiveTun("Normal: No process that use more than normal allocation of system resources detected")
        End If
    End Sub

    Private Sub tmrNottyNotifications_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNottyNotifications.Tick
        If bgWrKrNottyNotifications.IsBusy = False Then
            bgWrKrNottyNotifications.RunWorkerAsync()
        Else
            'MsgBox("Worker Busy")
        End If
    End Sub

    Private Sub tmrShowNoti_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShowNoti.Tick
        If bgWrKrNottyShow.IsBusy = False Then
            bgWrKrNottyShow.RunWorkerAsync()
        End If
    End Sub
    Delegate Sub seten(ByVal [text] As String)
    Private Sub sten(ByVal [text] As String)
        If lblen.InvokeRequired = True Then
            Dim d As New seten(AddressOf sten)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblen.Text = [text]
        End If
    End Sub
    Public Function GetUnwantedProbyPgFlUsg1()
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
        RichTextBox1.Text = ""
        Dim count As Integer = 0
        Dim size = Math.Round((My.Computer.Info.TotalPhysicalMemory * 1 / 8) / 1024 / 1024, 0)
        For Each queryObj As ManagementObject In searcher.Get()
            If Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 0) > My.Settings.NotRMAb And queryObj(
                "Caption") <> "System Idle Process" And queryObj("Caption") <> "wininit.exe" And queryObj(
                "Caption") <> "winlogon.exe" And queryObj("Caption") <> "svchost.exe" And queryObj("Caption") <> "explorer.exe" And queryObj(
                "Caption") <> "Notty.exe" And queryObj("Caption") <> "devenv.exe" And queryObj("Caption") <> "WDExpress.exe" Then
                lstUnwan.Items.Clear()
                lstUnwan.Items.Add(queryObj("Caption"))
                If queryObj("ExecutablePath") <> "" Then
                    If File.Exists(queryObj("ExecutablePath")) = True Then
                        RichTextBox1.Text += FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription & " is using " & Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 0) & " MB of RAM" & vbNewLine
                    Else
                        RichTextBox1.Text += queryObj("Caption") & " is using " & Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 0) & " MB of RAM" & vbNewLine

                    End If
                Else
                    RichTextBox1.Text += queryObj("Caption") & " is using " & Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 0) & " MB of RAM" & vbNewLine
                End If
                count += 1
            End If
        Next
        Return Nothing
    End Function
    Public Class clsWMInotty
        Private objbat As ManagementObjectSearcher
        Private objMgmt As ManagementObject
        Private m_batcurstts As String
        Private m_BatEstTm As String
        Private m_BatStatus As String
        Private m_RegUser As String
        Private m_RegOrg As String
        Public Sub New()
            objbat = New ManagementObjectSearcher("SELECT * FROM Win32_Battery")

            For Each Me.objMgmt In objbat.Get
                m_batcurstts = objMgmt("estimatedchargeremaining")
                m_BatEstTm = objMgmt("estimatedruntime")
                m_BatStatus = objMgmt("batterystatus")
            Next
        End Sub
        Public ReadOnly Property BatStatus()
            Get
                BatStatus = m_BatStatus
            End Get
        End Property
        Public ReadOnly Property EstimatedRunTime()
            Get
                EstimatedRunTime = m_BatEstTm
            End Get
        End Property
        Public ReadOnly Property BatCurStts()
            Get
                BatCurStts = m_batcurstts
            End Get
        End Property
    End Class
    Private Sub bgWrKrNottyNotifications_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgWrKrNottyNotifications.DoWork
        Dim srm As String
        Dim sAvlrm As String
        Dim sperus As String
        Dim sused As String
        srm = My.Computer.Info.TotalPhysicalMemory()
        sAvlrm = My.Computer.Info.AvailablePhysicalMemory()
        srm = Math.Round(srm / 1024 / 1024 / 1024, 2)
        sAvlrm = Math.Round(sAvlrm / 1024 / 1024 / 1024, 2)
        sused = srm - sAvlrm
        sperus = CInt(Math.Round(CDbl(sused) / CDbl(srm) * 100, 0))
        Dim properus = ProgrProc.Value
        'if the conditions are false display the computer is running normally
        If RichTextBox1.Text <> "" Then
            'MsgBox(GetUnwantedProbyPgFlUsg1())
            ''lblen.Text = "1"
            sten("1")
            ''bgwrkrInt.CancelAsync()
            GetUnwantedProbyPgFlUsg1()
            ''bttnShoDtls.Visible = True
            'tmrNoNoti.Enabled = False
        Else
            'lblLstUn.Text = "Unwanted Processes : 0"
            ''lblen.Text = "0"
            sten("0")
            GetUnwantedProbyPgFlUsg1()
            ''bttnShoDtls.Visible = False
        End If
        Dim dlsWMI As New clsWMInotty
        With dlsWMI
            If .BatCurStts < My.Settings.batSet And .BatCurStts <> "" And .BatStatus = 1 Then
                ''lblen.Text = "6"
                sten("6")
            End If
            If .BatCurStts <= 14 And .BatCurStts <> "" And .BatStatus = 1 Then
                ''lblen.Text = "8"
                sten("8")
            End If
        End With
        If sperus >= 70 And sperus < 80 Then
            ''lblen.Text = "2"
            sten("2")
            'bttnShoDtls.Visible = False
        End If
        If sperus >= 80 And sperus < 90 Then
            ''lblen.Text = "3"
            sten("3")
            'bttnShoDtls.Visible = False
        End If
        If sperus >= 90 Then
            ''lblen.Text = "4"
            sten("4")
            'bttnShoDtls.Visible = False
        End If
        If properus > "60" Then
            ''lblen.Text = "5"
            sten("5")
            'bttnShoDtls.Visible = False
        End If
    End Sub

    Private Sub bgwrkrLiveTuner_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwrkrLiveTuner.DoWork
        If My.Settings.livUpdat = 1 Then
            If Directory.Exists(Application.StartupPath & "\Proc") = True Then
                For Each fls In Directory.GetFiles(Application.StartupPath & "\Proc")
                    If IO.Path.GetExtension(fls) = ".xml" Then
                        Dim pth = IO.Path.GetFileNameWithoutExtension(fls)
                        Try
                            Dim sist As Integer = 0
                            Dim sd As Integer = 0
                            Dim searcher As New ManagementObjectSearcher(
                                "root\CIMV2",
                                "SELECT * FROM Win32_Process")
                            For Each queryObj As ManagementObject In searcher.Get()
                                If queryObj("Caption") <> "wininit.exe" And queryObj("Caption") <> "winlogon.exe" And queryObj("Caption") <> "System Idle Process" Then
                                    Dim name = queryObj("Caption")
                                    If name = pth Then
                                        'MsgBox(name & " Exists")
                                        Try
                                            Dim desc As String = ""
                                            If queryObj("ExecutablePath") <> "" Then
                                                If File.Exists(queryObj("ExecutablePath")) = True Then
                                                    'lstProName.Items(sist).SubItems.Add(FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription)
                                                    desc = FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription
                                                Else
                                                    desc = queryObj("Caption")

                                                End If
                                            Else
                                                RichTextBox1.Text += queryObj("Caption") & " is using " & Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 0) & " MB of RAM" & vbNewLine
                                            End If
                                            'Dim desc = queryObj("Description")
                                            Dim lstid = queryObj("ProcessId")
                                            Dim p As Process = Process.GetProcessById(lstid)
                                            p.Kill()
                                            System.Threading.Thread.Sleep(500)
                                            stLiveTun(desc & " AT " & lstid & " ID " & " Killed")
                                            System.Threading.Thread.Sleep(500)
                                        Catch ex As Exception
                                            MsgBox("Sorry Process Cannot be ended", MsgBoxStyle.OkOnly + vbCritical, "Prompt")
                                        End Try
                                        'RTBMesages.Text = pth & " Killed"

                                    End If
                                End If
                            Next
                        Catch err As ManagementException
                            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                        End Try
                    End If
                Next
            End If
        End If
    End Sub



    Private Sub tmrLiveTuner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLiveTuner.Tick
        If Settings.chkKllPro.Checked = True Then
            If bgwrkrLiveTuner.IsBusy = False Then
                bgwrkrLiveTuner.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim getbit = Functiod.cpinfo.getOsBitness
        ProgramsLvw.Sorting = SortOrder.None
        ProgramsLvw.Visible = False
        If getbit = "32" Then
            ProgramsLvw.Items.Clear()
            EnumSoftwareAssoc.GetInstalledProgramsonline(ProgramsLvw, imgLstSoft)
            RemoveDuplicates(ProgramsLvw)
        ElseIf getbit = "64" Then
            ProgramsLvw.Items.Clear()
            EnumSoftwareAssoc.GetInstalledProgramsonline(ProgramsLvw, imgLstSoft)
            'enumSoftware.Softwares.GetInstalledPrograms(ProgramsLvw)
            RemoveDuplicates(ProgramsLvw)
        Else
            ProgramsLvw.Items.Clear()
            EnumSoftwareAssoc.GetInstalledProgramsonline(ProgramsLvw, imgLstSoft)
        End If
        Sort()
        ProgramsLvw.Visible = True
    End Sub

    Private Sub bttnRefProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnRefProc.Click
        lstProc.Visible = False
        lstProc.Sorting = SortOrder.None
        'Processes.Processos.EnumerateProcess(lstProc, imgproc)
        EnumProcessAssoc.EnumerateProcessonline(lstProc, imgLstProc)
        'lblProcessRun.Text = "Processes : " & lstProc.Items.Count
        sortproc()
        lstProc.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If bttnInstPlugin.Visible = True Then
            bttnInstPlugin.Visible = False
        Else
            bttnInstPlugin.Visible = True
        End If
    End Sub

    Private Sub bttnInstPlugin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnInstPlugin.Click
        InstallPlugin.ShowDialog()
    End Sub

    Private Sub lblTmRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTmRem.Click
        lblTmRem.Visible = False
    End Sub

    Private Sub lblBatPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBatPer.Click
        lblTmRem.Visible = True
    End Sub

    Private Sub picFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFor.Click
        prgLdStats.Visible = True
        prgLdStats.Value = 25
        panLstSoft.Visible = True
        panLstSoft.Size = New Size(panCleaner.Width, panCleaner.Height)
        panLstSoft.Location = New Point(1, 89)
        'panNavCleaner.BackColor = Color.AliceBlue 
        'lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        prgLdStats.Value = 50
        lblLabelSection.Text = "Software and others"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.LightSteelBlue
        bttnModules.BackColor = Color.Transparent
        panCleaner.Enabled = True
        panLstSoft.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 2
        prgLdStats.Value = 75
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            'If panLstSoft.Visible = True Then
            '    bttnLstSoft.BackColor = Color.LightSteelBlue
            '    bttnCleaner.BackColor = Color.Transparent
            'Else
            '    bttnCleaner.BackColor = Color.LightSteelBlue
            '    bttnLstSoft.BackColor = Color.Transparent
            'End If
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnLstSoft.Visible = True
            bttnModules.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
        prgLdStats.Value = 100
        prgLdStats.Visible = False
    End Sub

    Private Sub picFor_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picFor.MouseEnter
        picFor.Image = My.Resources.right_hover
    End Sub

    Private Sub picFor_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picFor.MouseLeave
        picFor.Image = My.Resources.right
    End Sub

    Private Sub picBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBack.Click
        panLstSoft.Visible = False
        panModules.Visible = True
        panLstSoft.Enabled = True
        panCleaner.Enabled = True
        panModules.Enabled = True
        lblNav.Text = 3
        panModules.Size = New Size(panCleaner.Width, panCleaner.Height)
        panModules.Location = New Point(1, 89)
        'panNavCleaner.BackColor = Color.AliceBlue
        'lblScanStatus.Visible = False
        'lblLabelSection.ForeColor = Color.Black
        'lblNoOfFls.ForeColor = Color.Black
        lblLabelSection.Text = "Modules"
        bttnCleaner.BackColor = Color.Transparent
        bttnLstSoft.BackColor = Color.Transparent
        bttnModules.BackColor = Color.LightSteelBlue
        If panNav.Height = 25 Then
            panNav.Size = New Size(panNav.Width, 59)
            Button1.Text = "^"
            tmrClosNav.Enabled = True
            bttnCleaner.Visible = True
            bttnModules.Visible = True
            bttnLstSoft.Visible = True
            panNav.BorderStyle = BorderStyle.FixedSingle
        End If
        count = 0
    End Sub

    Private Sub picBack_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBack.MouseEnter
        picBack.Image = My.Resources.left_hover
    End Sub

    Private Sub picBack_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBack.MouseLeave
        picBack.Image = My.Resources.left
    End Sub

    Private Sub tmrOptions_Tick(sender As Object, e As EventArgs) Handles tmrOptions.Tick
        panOptions.Visible = True
        panUser.Visible = False
        tmrOptions.Enabled = False
        panOptions.Location = New Point(418, 1)
    End Sub

    Private Sub tmrProc_Tick(sender As Object, e As EventArgs) Handles tmrProc.Tick
        ProgrProc.Value = PerfCntrProc.NextValue
        lblProcPer.Text = "Processor : " & ProgrProc.Value & " %"
        If My.Settings.tmrTyp = "1" Then
            tmrProc.Interval = 700
            If picTim.Visible = True Then
                picTim.Visible = False
            Else
                picTim.Visible = True
            End If
        Else
            picTim.Visible = True
            tmrProc.Interval = 1000
        End If
    End Sub

    Private Sub lblUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblUser.Click
        If panUser.Visible = True Then
            'panUser.Visible = False
            If My.Settings.tmrTyp = "0" Then
                Timer3.Enabled = False
                Timer4.Enabled = False
                If tmrUserRev.Enabled = False And panUser.Location.X = 485 Then
                    tmrUserRev.Enabled = True
                Else
                    Debug_Info.ListBox1.Items.Add("Click Cancelled out tmrUserRev at " & My.Computer.Clock.LocalTime & " Warning : 3342")
                End If
            End If
        Else
            If My.Settings.tmrTyp = "0" Then
                Timer3.Enabled = True
                Timer4.Enabled = True
                If tmrUserFron.Enabled = False And panUser.Location.X = 685 Then
                    tmrUserFron.Enabled = True
                Else
                    Debug_Info.ListBox1.Items.Add("Click Cancelled out tmrUserFron at " & My.Computer.Clock.LocalTime & " Warning : 3343")
                End If
            End If
            panUser.Visible = True
            panOptions.Visible = False

        End If
    End Sub

    Private Sub lblUser_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles lblUser.MouseEnter
        If panUser.Visible = True Then
            'panUser.Visible = False
            If tmrUserRev.Enabled = False Then
                tmrUserRev.Enabled = True
            End If
            If My.Settings.tmrTyp = "0" Then
                Timer3.Enabled = False
                Timer4.Enabled = False
            End If
        Else
            tmrUser.Enabled = True
        End If
        'lblUser.Size = New Size(lblUser.Width + 2, lblUser.Height + 2)
    End Sub

    Private Sub tmrUser_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrUser.Tick
        panOptions.Visible = False
        panUser.Visible = True
        If My.Settings.tmrTyp = "0" Then
            Timer3.Enabled = True
            Timer4.Enabled = True
            If tmrUserFron.Enabled = False Then
                tmrUserFron.Enabled = True
            End If
        End If
        'panUser.Visible = True
        tmrUser.Enabled = False
    End Sub

    Private Sub lblUser_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles lblUser.MouseLeave
        tmrUser.Enabled = False

        'lblUser.Size = New Size(lblUser.Width - 2, lblUser.Height - 2)
    End Sub

    Private Sub tmrRm_Tick(sender As Object, e As EventArgs) Handles tmrRm.Tick
        If bgWrKrRm.IsBusy = False Then
            bgWrKrRm.RunWorkerAsync()
        End If
    End Sub
    Delegate Sub setRmUsg1(ByVal [text] As String)
    Private Sub stRmUsg1(ByVal [text] As String)
        If lblRAM.InvokeRequired = True Then
            Dim d As New setRmUsg(AddressOf stRmUsg1)
            Me.Invoke(d, New Object() {[text]})
        Else
            lblRAM.Text = [text]
        End If
    End Sub
    Delegate Sub setProgr(ByVal [val] As Integer)
    Private Sub stProgr(ByVal [val] As Integer)
        If ProgrRAM.InvokeRequired = True Then
            Dim d As New setProgr(AddressOf stProgr)
            ProgrRAM.Invoke(d, New Object() {[val]})
        Else
            ProgrRAM.Value = [val]
        End If
    End Sub
    Private Sub bgWrKrRm_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWrKrRm.DoWork
        Dim srm As String
        Dim sAvlrm As String
        Dim sperus As String
        Dim sused As String
        srm = My.Computer.Info.TotalPhysicalMemory()
        sAvlrm = My.Computer.Info.AvailablePhysicalMemory()
        srm = Math.Round(srm / 1024 / 1024 / 1024, 2)
        sAvlrm = Math.Round(sAvlrm / 1024 / 1024 / 1024, 2)
        sused = srm - sAvlrm
        sperus = CInt(Math.Round(CDbl(sused) / CDbl(srm) * 100, 0))
        'lblRm.Text = "Ram : " & sAvlrm & " GB free in " & srm & " GB (" & sperus & "% Used)"
        stRmUsg1("RAM : " & sperus & " %")
        stProgr(sperus)
    End Sub

    Private Sub tmrHrdUpdt_Tick(sender As Object, e As EventArgs) Handles tmrHrdUpdt.Tick


    End Sub

    Private Sub picSwitchHrd_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each fls In Directory.GetFiles(Application.StartupPath & "\proc1")
            Dim pth = IO.Path.GetFileNameWithoutExtension(fls)
            Dim sist As Integer = 0
            Dim sd As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") <> "wininit.exe" And queryObj("Caption") <> "winlogon.exe" And queryObj("Caption") <> "System Idle Process" Then
                    Dim name = queryObj("Caption")
                    If name = pth Then
                        Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                        p.Kill()
                    End If
                End If
            Next
        Next
    End Sub
    Dim ount = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim some(10)
        Dim count = 0
        lblProRun.Text = ""
        'Label4.Text = ""
        For Each fls In Directory.GetFiles(Application.StartupPath & "\procgmes")
            Dim pth = IO.Path.GetFileNameWithoutExtension(fls)
            Try
                Dim sist As Integer = 0
                Dim sd As Integer = 0
                Dim sds(10000) As String
                'MsgBox(ount)
                sds(ount) = pth
                ' ount += 1
                'Label4.Text = Label4.Text & vbNewLine & sds(ount)
                ' MsgBox(sds(ount))
                Dim searcher As New ManagementObjectSearcher( _
                    "root\CIMV2", _
                    "SELECT * FROM Win32_Process")

                For Each queryObj As ManagementObject In searcher.Get()
                    If queryObj("Caption") <> "wininit.exe" And queryObj("Caption") <> "winlogon.exe" And queryObj("Caption") <> "System Idle Process" Then
                        Dim name(10000)
                        name(count) = queryObj("Caption")

                        'Label3.Text = Label3.Text & vbNewLine & name(count) & " " & sds(ount)
                        'System.Threading.Thread.Sleep(10)
                        If name(count) = sds(ount) Then
                            lblProRun.Text = name(count)
                            'MsgBox(lblProRun.Text)
                            Dim prior As String = lblProRun.Text
                            prior = prior.Replace(".exe", "")
                            'Will set high priority for the process that are specified in the game booster part in the settings menu
                            'The code will check the settings for if the priority should be modified to high or not so that it will set the priority of the process.
                            'Don't modify the code below
                            'Setting priority of process is a copyright(C) 2015 Arvin Soft. All Rights Reserved.
                            If My.Settings.priori = 1 Then
                                Processes.Processos.setHighPriority(prior)
                            End If
                            'Don't modify the code above
                            'The code will check the settings for if the priority should  be modified to high or not so that it will set the priority of the process
                            'The code above will set high priority for the process that are specified in the game booster part in the settings menu.
                            'Code Copyright(C) 2010 - 2015 Arvin Soft. All Rights Reserved.
                            stLiveTun("Game executable is running closing all other process, services and aero")
                            lblSwi0.Text = 1
                            'Timer2.Enabled = False
                            lblSwi1.Text = 0
                            Dim sists As Integer = 0
                            Dim searchers As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
                            For Each queryObjs As ManagementObject In searchers.Get
                                For Each filinfold In Directory.GetFiles(Application.StartupPath & "\procche")
                                    If queryObjs("Caption") = IO.Path.GetFileNameWithoutExtension(filinfold) Then
                                        Dim p As Process = Process.GetProcessById(queryObjs("ProcessId"))
                                        Dim settings As New XmlWriterSettings
                                        Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\proc1\" & queryObjs("Caption") & ".xml")
                                        With xmld
                                            .WriteStartDocument()
                                            .WriteStartElement("data")
                                            .WriteStartElement("exepath")
                                            .WriteString(queryObjs("ExecutablePath"))
                                            .WriteEndElement()
                                            .WriteEndElement()
                                            .WriteEndDocument()
                                            .Close()
                                        End With
                                        p.Kill()
                                    End If
                                Next
                            Next

                            ount += 1
                            If lblSwi1.Text = "0" Then
                                Timer1.Enabled = True
                            End If
                            Timer2.Enabled = False
                            Dim chkedaero = ""
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
                            If chkedaero = "true" Then
                                Process.Start(Application.StartupPath & "\stop aero.bat")
                            End If

                            tmrStopTimer.Enabled = True
                        End If
                    Else

                    End If
                    count += 1

                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub tmrStopTimer_Tick(sender As Object, e As EventArgs) Handles tmrStopTimer.Tick
        ' Label5.Text = "stop timer enabled"
        If lblProRun.Text <> "" Then
            If ProcessRunning(lblProRun.Text.Remove(lblProRun.Text.Length - 4, 4)) Then
                ' Label6.Text = lblProRun.Text & " is running"
                'tmrFlashBrain.Enabled = True
                ' tmrFlashBrain.Interval = 500
            Else
                'tmrFlashBrain.Interval = 2000
                'tmrFlashBrain.Enabled = False
                ' Label6.Text = lblProRun.Text & " is not running timer enabled"
                'Label5.Text = "stop timer disabled"
                stLiveTun("Game executable is not running starting process, services and aero")
                Dim chkedaero = ""
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
                If chkedaero = "true" Then
                    Process.Start(Application.StartupPath & "\start aero.bat")
                End If
                lblSwi0.Text = 0
                Timer1.Enabled = False
                lblSwi1.Text = 1
                For Each filinfold In Directory.GetFiles(Application.StartupPath & "\proc1")
                    Dim dls As XmlReader = New XmlTextReader(filinfold)
                    While (dls.Read())
                        Dim typ = dls.NodeType
                        If typ = XmlNodeType.Element Then
                            'MsgBox("Enter")
                            If dls.Name = "exepath" Then
                                Process.Start(dls.ReadInnerXml.ToString)
                            End If
                        End If
                    End While
                    dls.Close()
                    File.Delete(filinfold)
                Next
                Timer2.Enabled = True
                tmrStopTimer.Enabled = False
                'PictureBox1.Image = My.Resources._1412382505_Brain_Games
            End If
        End If
    End Sub


    Dim scount = 0
    Dim sount = 0
    Dim bount = 0
    Dim indt(100) As Single
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If scount >= 100 Then
            'Graph1.Clear()
            'MsgBox("Cleared")
            'System.Threading.Thread.Sleep(100)
            Array.Clear(indt, 1, 100)
            scount = 1
            indt(sount) = 0

        End If
        Dim i

        'ProgrProc.Value = PerfCntrProc.NextValue
        ' lblProcPer.Text = "Processor : " & ProgrProc.Value & " %"
        Dim vals = ProgrProc.Value()
        sount += 1
        'If count > 0 Then
        '    'indt(count - 1) += 0
        '    ' MsgBox(indt.GetValue(count - 1) & " count " & count - 1)
        'End If
        'For i = 0 To 10
        'Dim i = 0 + 1
        'MsgBox(i)


        indt(scount) = ProgrProc.Value
        'Array.Clear(indt, bount + 1, bount + 1)
        'Array.Clear(indt, count, count + 1)
        'Label1.Text += ProgressBar1.Value.ToString
        'Label1.Text += indt.GetValue(count).ToString & " "

        i = ProgrProc.Value
        'System.Threading.Thread.Sleep(100)
        'MsgBox(i)
        scount += 1
        bount += 1
        If sount = 1 Then
            Graph1.Values = indt
            sount = 0
        End If
    End Sub
    Dim dsount As Integer = 0
    Dim dount As Integer = 0
    Dim nount As Integer = 0
    Dim indta(100) As Single
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
        End If
        If dsount >= 100 Then
            'Graph1.Clear()
            'MsgBox("Cleared")
            'System.Threading.Thread.Sleep(100)
            Array.Clear(indta, 1, 100)
            dsount = 1
            indta(dount) = 0

        End If
        Dim i

        'ProgrProc.Value = PerfCntrProc.NextValue
        'lblProcPer.Text = "Processor : " e & " %"
        Dim vals = ProgrRAM.Value
        dount += 1
        'If count > 0 Then
        '    'indt(count - 1) += 0
        '    ' MsgBox(indt.GetValue(count - 1) & " count " & count - 1)
        'End If
        'For i = 0 To 10
        'Dim i = 0 + 1
        'MsgBox(i)

        'MsgBox(ProgrRAM.Value)
        indta(dsount) = ProgrRAM.Value
        'Array.Clear(indt, bount + 1, bount + 1)
        'Array.Clear(indt, count, count + 1)
        'Label1.Text += ProgressBar1.Value.ToString
        'Label1.Text += indt.GetValue(count).ToString & " "

        i = ProgrRAM.Value
        'System.Threading.Thread.Sleep(100)
        'MsgBox(i)
        dsount += 1
        nount += 1
        If dount = 1 Then
            Graph2.Values = indta
            dount = 0
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim srm As String
        Dim sAvlrm As String
        Dim sperus As String
        Dim sused As String
        srm = My.Computer.Info.TotalPhysicalMemory()
        sAvlrm = My.Computer.Info.AvailablePhysicalMemory()
        srm = Math.Round(srm / 1024 / 1024 / 1024, 2)
        sAvlrm = Math.Round(sAvlrm / 1024 / 1024 / 1024, 2)
        sused = srm - sAvlrm
        sperus = CInt(Math.Round(CDbl(sused) / CDbl(srm) * 100, 0))
    End Sub

    Private Sub BgWrkrCleaning_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgWrkrCleaning.DoWork
        Delete.Delete()
        BgWrkrCleaning.ReportProgress(50)
        DeleteOthFls.DeleteOthFls()
        BgWrkrCleaning.ReportProgress(100)
    End Sub

    Private Sub BgWrkrCleaning_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BgWrkrCleaning.ProgressChanged
        If e.ProgressPercentage = 50 Then
            prgIntFls.Value = 100
            prgOthrFls.Value = 100
        ElseIf e.ProgressPercentage = 100 Then
            prgIntFls.Value = 100
            prgOthrFls.Value = 100
        End If
    End Sub

    Private Sub BgWrkrCleaning_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWrkrCleaning.RunWorkerCompleted
        Try
            bttnCleanAllFiles.Enabled = True
            Processes.Processos.Adobeupdatenotifyproend()
            Processes.Processos.WTCDProend()
            lblIntFlsSize.Visible = True
            lblOthFlsSiz.Visible = True
            prgIntFls.Visible = False
            prgOthrFls.Visible = False
            lblIntFlsSize.Text = "(No Information)"
            lblOthFlsSiz.Text = "(No Information)"
            lblOptimize.Visible = False
            tmrSplash.Enabled = True
            Label1.Text = "Cleaning Completed on your system."
            PictureBox8.Image = My.Resources._1390669904_bullet_green
            panPopupMess.BackColor = Color.LightSeaGreen
            'Main.lstCleaner.Visible = False
            ' Main.lstCleanerOtherFls.Visible = False
            lod1.Visible = False
            lod2.Visible = False
            Panel4.Visible = False
            Panel12.Visible = False

            tmrloadanisp1.Enabled = False
            tmrloadanisp1rev.Enabled = False
            tmrloadanisp2.Enabled = False
            tmrloadanisp2rev.Enabled = False
            picOksp1.Visible = True
            picOksp2.Visible = True
            If lblPowerPlnRgCde.Text = 1 And My.Settings.perf = 1 Then
                Misc.checkandactihighperform()
                picOksp3.Visible = True
                lblIssue.Text = "Issues fixed"
                lblIssue.ForeColor = Color.LightSeaGreen
            ElseIf lblPowerPlnRgCde.Text = 2 And My.Settings.perf = 1 Then
                Misc.checkandactipowersaver()
                picOksp3.Visible = True
                lblIssue.Text = "Issues fixed"
                lblIssue.ForeColor = Color.LightSeaGreen
            Else
                'MsgBox("Some serious error occurred the software can't proceed the software will close if you click ok", MsgBoxStyle.Critical + vbOKOnly, "Sorry")
                'End
            End If
            Debug_Info.ListBox1.Items.Add("Cleaning Temp Files and Other files Completed at " & My.Computer.Clock.LocalTime)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If lstProc.SelectedItems.Count <> 0 Then
        Processes.Processos.setHighPrior(lstProc)
        ' 'Else
        'MsgBox("Please select a processes name to end", MsgBoxStyle.Information + vbOKOnly, "Information")
        'End If
    End Sub

    Private Sub bttnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMinimize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        panDis.Visible = False
        panCleaner.Visible = True
        Timer5.Enabled = False
    End Sub

    Private Sub tmrUserFron_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUserFron.Tick
        If panUser.Location.X = 485 Then
            tmrUserFron.Enabled = False
            'panUser.BorderStyle = BorderStyle.FixedSingle

            'MsgBox("truefron")
        Else

            panUser.Location = New Point(panUser.Location.X - 10, panUser.Location.Y)
        End If
    End Sub

    Private Sub tmrUserRev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUserRev.Tick
        If panUser.Location.X = 685 Then
            panUser.Visible = False
            tmrUserRev.Enabled = False
            'MsgBox("truerev")
            ' panUser.BorderStyle = BorderStyle.None

        Else
            panUser.Location = New Point(panUser.Location.X + 10, panUser.Location.Y)
        End If
    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click
        Debug_Info.ShowDialog()
    End Sub

    Private Sub main_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub tmrloadanisp1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanisp1.Tick
        ' Label9.Text = lod1.Location.X
        lod1.Location = New Point(lod1.Location.X + 1, lod1.Location.Y)
        If lod1.Location.X = 168 Then
            tmrloadanisp1.Enabled = False
            tmrloadanisp1rev.Enabled = True
        End If
    End Sub

    Private Sub tmrloadanisp1rev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanisp1rev.Tick
        ' Label9.Text = lod1.Location.X
        lod1.Location = New Point(lod1.Location.X - 1, lod1.Location.Y)
        If lod1.Location.X = 104 Then
            tmrloadanisp1rev.Enabled = False
            tmrloadanisp1.Enabled = True
        End If
    End Sub

    Private Sub tmrloadanisp2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanisp2.Tick
        lod2.Location = New Point(lod2.Location.X + 1, lod2.Location.Y)
        If lod2.Location.X = 272 Then
            tmrloadanisp2.Enabled = False
            tmrloadanisp2rev.Enabled = True
        End If
    End Sub

    Private Sub tmrloadanisp2rev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanisp2rev.Tick
        lod2.Location = New Point(lod2.Location.X - 1, lod2.Location.Y)
        If lod2.Location.X = 208 Then
            tmrloadanisp2rev.Enabled = False
            tmrloadanisp2.Enabled = True
        End If
    End Sub

    Private Sub panNav_Paint(sender As Object, e As PaintEventArgs) Handles panNav.Paint

    End Sub

    Private Sub tmrtoggle_Tick(sender As Object, e As EventArgs) Handles tmrtoggle.Tick
        If picGameBoosterSwitch.Location.X = 640 Then
            tmrtoggle.Enabled = False
            'MsgBox("No")
            'Me.ShowIcon = False
            ' picGameBoosterSwitch.Location = New Point(641, picGameBoosterSwitch.Location.Y)
            picGameBoosterSwitch.BackColor = Color.LightSeaGreen
            Timer2.Enabled = True
            stLiveTun("Game Booster running normally no game executables detected")
            Dim settings As New XmlWriterSettings
            Dim xmld As XmlWriter = XmlWriter.Create(Application.StartupPath & "\gameboostRed.xml")
            With xmld
                .WriteStartDocument()
                .WriteStartElement("data")
                .WriteStartElement("REDBrain")
                .WriteString("true")
                .WriteEndElement()
                .WriteEndElement()
                .Close()
            End With
            My.Settings.gameBoost = 1
            My.Settings.Save()

        Else
            picGameBoosterSwitch.Location = New Point(picGameBoosterSwitch.Location.X + 5, picGameBoosterSwitch.Location.Y)
        End If
    End Sub
    Private Sub picGameBoosterSwitch_Click(sender As Object, e As EventArgs) Handles picGameBoosterSwitch.Click
        If picGameBoosterSwitch.Location.X = 620 Then
            tmrtoggle.Enabled = True
        Else
            tmrtogglereverse.Enabled = True
        End If
    End Sub

    Private Sub tmrtogglereverse_Tick(sender As Object, e As EventArgs) Handles tmrtogglereverse.Tick
        If picGameBoosterSwitch.Location.X = 620 Then
            tmrtogglereverse.Enabled = False
            'picGameBoosterSwitch.Location = New Point(620, picGameBoosterSwitch.Location.Y)
            picGameBoosterSwitch.BackColor = Color.LightCoral
            '  MsgBox("1")
            If togglebutton.Location.X = 620 Then
                ' MsgBox("1.1")
                stLiveTun("Live tuner and game booster Disabled")
                Try
                    File.Delete(Application.StartupPath & "\gameboostRed.xml")
                Catch ex As Exception
                    MsgBox("Something Serious has happened" & vbNewLine & ex.ToString, MsgBoxStyle.Critical + vbOKOnly, "Something Happened")
                End Try
            End If
            My.Settings.gameBoost = 0
            My.Settings.Save()
            Timer2.Enabled = False
        Else
            picGameBoosterSwitch.Location = New Point(picGameBoosterSwitch.Location.X - 5, picGameBoosterSwitch.Location.Y)
        End If

    End Sub

    Private Sub togglebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles togglebutton.Click
        If togglebutton.Location.X = 640 Then
            tmrInStCh.Enabled = True
            'tmrUpdtDel.Enabled = True
        Else
            tmrInStChrev.Enabled = True
        End If
    End Sub

    Private Sub tmrInStCh_Tick(sender As Object, e As EventArgs) Handles tmrInStCh.Tick
        If togglebutton.Location.X = 620 Then
            If My.Settings.pass = "" Then
                tmrInStCh.Enabled = False
                'disabled
                'togglebutton.Location = New Point(620, togglebutton.Location.Y)
                togglebutton.BackColor = Color.LightCoral
                My.Settings.livUpdat = 0
                tmrNottyNotifications.Enabled = False
                tmrShowNoti.Enabled = False
                'Main.RTBMesages.Visible = False
                If picGameBoosterSwitch.Location.X = 620 Then
                    RTBMesages.Text = "Live tuner and game booster Disabled"
                Else
                    RTBMesages.Text = "Game Booster running normally no game executables detected"
                End If

                If ProcessRunning("Sys Notifier") >= 1 Then
                    EndPlugin("Sys Notifier.exe")
                Else
                    MsgBox("No Process running")
                End If
                File.Delete(Application.StartupPath & "\RunNot.txt")
                My.Settings.Save()
            Else
                PassCheckLiveTuner.ShowDialog()
            End If
        Else
            togglebutton.Location = New Point(togglebutton.Location.X - 5, togglebutton.Location.Y)
        End If
    End Sub

    Private Sub tmrInStChrev_Tick(sender As Object, e As EventArgs) Handles tmrInStChrev.Tick
        If togglebutton.Location.X = 640 Then
            tmrInStChrev.Enabled = False
            My.Settings.livUpdat = 1
            tmrNottyNotifications.Enabled = True
            tmrShowNoti.Enabled = True
            'Main.RTBMesages.Visible = True
            'If RTBMesages.Text = "Live tuner and game booster Disabled" Then
            RTBMesages.Text = "Assessing your system please wait..."
            'End If
            My.Settings.Save()
            'enabled
            'togglebutton.Location = New Point(640, togglebutton.Location.Y)
            togglebutton.BackColor = Color.LightSeaGreen
            If File.Exists(Application.StartupPath & "\Sys Notifier.exe") = True Then
                If ProcessRunning("Sys Notifier") = 0 Then
                    Process.Start(Application.StartupPath & "\Sys Notifier.exe")
                    If File.Exists(Application.StartupPath & "\RunNot.txt") = False Then
                        File.Copy(Application.StartupPath & "\Proc\RunNot.txt", Application.StartupPath & "\RunNot.txt")
                    End If
                    'File.Create(Application.StartupPath & "\RunNot.txt", 123, FileOptions.None)
                End If
            Else
                MsgBox("Does not exist")
            End If
        Else
            togglebutton.Location = New Point(togglebutton.Location.X + 5, togglebutton.Location.Y)
        End If
    End Sub

    Private Sub tmrloadanimation_Tick(sender As Object, e As EventArgs) Handles tmrloadanimation.Tick
        If lod3.Visible = False Then
            t2.Visible = False
            lod3.Visible = True
        ElseIf t2.Visible = False Then
            t3.Visible = False
            t2.Visible = True
        ElseIf t3.Visible = False Then
            t3.Visible = True
            t4.Visible = False
        ElseIf t4.Visible = False Then
            t4.Visible = True
            t3.Visible = False
            tmrloadanimationrev.Enabled = True
            tmrloadanimation.Enabled = False
        End If
    End Sub

    Private Sub tmrloadanimationrev_Tick(sender As Object, e As EventArgs) Handles tmrloadanimationrev.Tick
        If t2.Visible = False Then
            t2.Visible = True
            lod3.Visible = False
            tmrloadanimation.Enabled = True
            tmrloadanimationrev.Enabled = False
        ElseIf t3.Visible = False Then
            t3.Visible = True
            t2.Visible = False
        End If
    End Sub

    Private Sub tmrlodanimation_Tick(sender As Object, e As EventArgs) Handles tmrlodanimation.Tick
        If lod4.Visible = False Then
            x2.Visible = False
            lod4.Visible = True
        ElseIf x2.Visible = False Then
            x3.Visible = False
            x2.Visible = True
        ElseIf x3.Visible = False Then
            x3.Visible = True
            x4.Visible = False
        ElseIf x4.Visible = False Then
            x4.Visible = True
            x3.Visible = False
            tmrlodanimationrev.Enabled = True
            tmrlodanimation.Enabled = False
        End If
    End Sub

    Private Sub tmrlodanimationrev_Tick(sender As Object, e As EventArgs) Handles tmrlodanimationrev.Tick
        If x2.Visible = False Then
            x2.Visible = True
            lod4.Visible = False
            tmrlodanimation.Enabled = True
            tmrlodanimationrev.Enabled = False
        ElseIf x3.Visible = False Then
            x3.Visible = True
            x2.Visible = False
        End If
    End Sub

    Private Sub fl9_Click(sender As Object, e As EventArgs) Handles fl9.Click

    End Sub

    Private Sub fl9_MouseEnter(sender As Object, e As EventArgs) Handles fl9.MouseEnter
        fl8.Visible = True
        fl9.Size = New Size(fl9.Width + 5, fl9.Height + 5)
    End Sub

    Private Sub fl9_MouseLeave(sender As Object, e As EventArgs) Handles fl9.MouseLeave
        fl8.Visible = False
        fl9.Size = New Size(fl9.Width - 5, fl9.Height - 5)
    End Sub
End Class
'******************************************************************************************************************
'*        Developed by Arvin Soft in association with the developers in citrus software development group         *
'*                               Copyright (C) 2010-2015 Arvin Soft. All Rights Reserved.                         *
'*                          Copyright (C) 2014 Citrus Software Development Group. All Rights Reserved             *
'*        Software Design is Copyrighted to Arvin Graphics. The Design and Concept is designed by Arvin Graphics  *
'*                               Copyright (C) 2009-2015 Arvin Graphics. All Rights Reserved.                     *
'******************************************************************************************************************