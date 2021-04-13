Imports System.Management
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class clsWMI
    Private objOs As ManagementObjectSearcher
    Private objMo As ManagementObjectSearcher
    Private objMODev As ManagementObjectSearcher
    Private objBIOS As ManagementObjectSearcher
    Private objPro As ManagementObjectSearcher
    Private objDesMoni As ManagementObjectSearcher
    Private objVidCon As ManagementObjectSearcher
    Private objBat As ManagementObjectSearcher

    Private objMgmt As ManagementObject
    Private m_OperServicePck As String
    Private m_OperManu As String
    Private m_OperVers As String
    Private m_OperBuildNum As String
    Private m_OperBuildTyp As String
    Private m_OperSystemDire As String
    Private m_OperWinDire As String
    Private m_OperBootDevice As String
    Private m_OperSerialNum As String
    Private m_RegUser As String
    Private m_RegOrg As String
    Private m_MoManufac As String
    Private m_MoProduct As String
    Private m_MoVersion As String
    Private m_MoSerial As String
    Private m_MoPriBsTyp As String
    Private m_MoSecBsTyp As String
    Private m_BIOSManu As String
    Private m_BIOSVers As String
    Private m_SMBIOSVers As String
    Private m_ProName As String
    Private m_VidoManu As String
    Private m_VidoNm As String
    Private m_VidoMem As String
    Private m_VidoDriverVers As String
    Private m_VidoBitsperPix As String
    Private m_VidoCurrRefRate As String
    Private m_CurrScnMode As String
    Private m_VideoCrdAvl As String
    Private m_BatAvl As String
    Private m_ProManu As String
    Private m_ProNm As String
    Private m_ProIden As String
    Private m_PSockDesig As String
    Private m_PArchi As String
    Private m_PNoOfCores As String
    Private m_PNoOfLogPro As String
    Private m_PClockSpeed As String
    Private m_MaxClockSpeed As String
    Private m_ExtClock As String
    Private m_PVolt As String
    Private m_WindowsFolder As String
    Private m_BatStatus As String
    Private m_BatLvl As String


    Public Sub New()
        objOs = New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        objMo = New ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")
        objMODev = New ManagementObjectSearcher("SELECT * FROM Win32_MotherBoardDevice")
        objBIOS = New ManagementObjectSearcher("SELECT * FROM Win32_BIOS")
        objPro = New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
        objDesMoni = New ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor")
        objVidCon = New ManagementObjectSearcher("SELECT * FROM Win32_VideoController")
        objBat = New ManagementObjectSearcher("SELECT * FROM Win32_Battery")

        For Each Me.objMgmt In objBat.Get
            m_BatAvl = objMgmt("Availability")
            m_BatStatus = objMgmt("batteryStatus")
            m_BatLvl = objMgmt("estimatedchargeremaining")
        Next

        For Each Me.objMgmt In objVidCon.Get
            m_VidoManu = objMgmt("adaptercompatibility")
            On Error Resume Next
            m_VidoNm = objMgmt("caption")
            On Error Resume Next
            m_VidoMem = objMgmt("AdapterRAM")
            On Error Resume Next
            m_VidoDriverVers = objMgmt("driverversion")
            On Error Resume Next
            m_VidoBitsperPix = objMgmt("currentbitsperpixel")
            On Error Resume Next
            m_VidoCurrRefRate = objMgmt("currentrefreshrate")
            On Error Resume Next
            m_CurrScnMode = objMgmt("currentscanmode")
            On Error Resume Next
            m_VideoCrdAvl = objMgmt("Availability")
            On Error Resume Next
        Next

        For Each Me.objMgmt In objPro.Get
            m_ProName = objMgmt("name")
            m_ProManu = objMgmt("manufacturer")
            m_ProNm = objMgmt("name")
            m_ProIden = objMgmt("caption")
            m_PSockDesig = objMgmt("socketdesignation")
            On Error Resume Next
            m_PArchi = objMgmt("architecture")
            m_PNoOfCores = objMgmt("numberofcores")
            On Error Resume Next
            m_PNoOfLogPro = objMgmt("numberoflogicalprocessors")
            m_PClockSpeed = objMgmt("currentclockspeed")
            m_MaxClockSpeed = objMgmt("maxclockspeed")
            m_ExtClock = objMgmt("extclock")
            m_PVolt = objMgmt("voltagecaps")
        Next


        For Each Me.objMgmt In objOs.Get
            m_OperServicePck = objMgmt("CSDVersion")
            m_OperManu = objMgmt("manufacturer")
            m_OperVers = objMgmt("version")
            m_OperBuildNum = objMgmt("buildnumber")
            m_OperBuildTyp = objMgmt("buildtype")
            m_OperSystemDire = objMgmt("systemdirectory")
            m_OperWinDire = objMgmt("windowsdirectory")
            m_OperBootDevice = objMgmt("bootdevice")
            m_OperSerialNum = objMgmt("serialnumber")
            m_RegUser = objMgmt("Registereduser")
            m_RegOrg = objMgmt("organization")
            m_WindowsFolder = objMgmt("SystemDrive")
        Next
        For Each Me.objMgmt In objMo.Get
            m_MoManufac = objMgmt("manufacturer")
            m_MoProduct = objMgmt("product")
            m_MoVersion = objMgmt("version")
            m_MoSerial = objMgmt("serialnumber")
        Next
        For Each Me.objMgmt In objMODev.Get
            m_MoPriBsTyp = objMgmt("primarybustype")
            m_MoSecBsTyp = objMgmt("secondarybustype")
        Next
        For Each Me.objMgmt In objBIOS.Get
            m_BIOSManu = objMgmt("manufacturer")
            m_BIOSVers = objMgmt("version")
            m_SMBIOSVers = objMgmt("smbiosbiosversion")
        Next

    End Sub
    Public ReadOnly Property BatLvl()
        Get
            BatLvl = m_BatLvl
        End Get
    End Property
    Public ReadOnly Property BatStatus()
        Get
            BatStatus = m_BatStatus
        End Get
    End Property
    Public ReadOnly Property WindowsFolder()
        Get
            WindowsFolder = m_WindowsFolder
        End Get
    End Property
    Public ReadOnly Property PVolt()
        Get
            PVolt = m_PVolt
        End Get
    End Property
    Public ReadOnly Property PClockSpeed()
        Get
            PClockSpeed = m_PClockSpeed
        End Get
    End Property
    Public ReadOnly Property MaxClockSpeed()
        Get
            MaxClockSpeed = m_MaxClockSpeed
        End Get
    End Property
    Public ReadOnly Property ExtClock()
        Get
            ExtClock = m_ExtClock
        End Get
    End Property
    Public ReadOnly Property proNoOfCores()
        Get
            proNoOfCores = m_PNoOfCores
        End Get
    End Property
    Public ReadOnly Property proNoOfLogPro()
        Get
            proNoOfLogPro = m_PNoOfLogPro
        End Get
    End Property
    Public ReadOnly Property proSockDes()
        Get
            proSockDes = m_PSockDesig
        End Get
    End Property
    Public ReadOnly Property proArchi()
        Get
            proArchi = m_PArchi
        End Get
    End Property
    Public ReadOnly Property ProManu()
        Get
            ProManu = m_ProManu
        End Get
    End Property
    Public ReadOnly Property ProNm()
        Get
            ProNm = m_ProNm
        End Get
    End Property
    Public ReadOnly Property ProIden()
        Get
            ProIden = m_ProIden
        End Get
    End Property
    Public ReadOnly Property BatAvl()
        Get
            BatAvl = m_BatAvl
        End Get
    End Property
    Public ReadOnly Property VideoCurrScnMode()
        Get
            VideoCurrScnMode = m_CurrScnMode
        End Get
    End Property
    Public ReadOnly Property VideoCurrentRefRate()
        Get
            VideoCurrentRefRate = m_VidoCurrRefRate
        End Get
    End Property
    Public ReadOnly Property VideoBitsPerPix()
        Get
            VideoBitsPerPix = m_VidoBitsperPix
        End Get
    End Property
    Public ReadOnly Property VideoDriverVers()
        Get
            VideoDriverVers = m_VidoDriverVers
        End Get
    End Property
    Public ReadOnly Property VideoMem()
        Get
            VideoMem = m_VidoMem
        End Get
    End Property
    Public ReadOnly Property VideoNm()
        Get
            VideoNm = m_VidoNm
        End Get
    End Property
    Public ReadOnly Property VideoManu()
        Get
            VideoManu = m_VidoManu
        End Get
    End Property
    Public ReadOnly Property ProcessorName()
        Get
            ProcessorName = m_ProName
        End Get
    End Property

    Public ReadOnly Property SMBIOSVers()
        Get
            SMBIOSVers = m_SMBIOSVers
        End Get
    End Property
    Public ReadOnly Property BIOSVers()
        Get
            BIOSVers = m_BIOSVers
        End Get
    End Property
    Public ReadOnly Property BIOSManu()
        Get
            BIOSManu = m_BIOSManu
        End Get
    End Property
    Public ReadOnly Property MoPriBsTyp()
        Get
            MoPriBsTyp = m_MoPriBsTyp
        End Get
    End Property
    Public ReadOnly Property MoSecBsTyp()
        Get
            MoSecBsTyp = m_MoSecBsTyp
        End Get
    End Property
    Public ReadOnly Property MoSerial()
        Get
            MoSerial = m_MoSerial
        End Get
    End Property
    Public ReadOnly Property MoVersion()
        Get
            MoVersion = m_MoVersion
        End Get
    End Property
    Public ReadOnly Property MoManufact()
        Get
            MoManufact = m_MoManufac
        End Get
    End Property
    Public ReadOnly Property MoProduct()
        Get
            MoProduct = m_MoProduct
        End Get
    End Property
    Public ReadOnly Property OperRegUser()
        Get
            OperRegUser = m_RegUser
        End Get
    End Property
    Public ReadOnly Property OperRegOrg()
        Get
            OperRegOrg = m_RegOrg
        End Get
    End Property
    Public ReadOnly Property OperSerialNum()
        Get
            OperSerialNum = m_OperSerialNum
        End Get
    End Property
    Public ReadOnly Property OperBootDevice()
        Get
            OperBootDevice = m_OperBootDevice
        End Get
    End Property
    Public ReadOnly Property OperWinDirec()
        Get
            OperWinDirec = m_OperWinDire
        End Get
    End Property
    Public ReadOnly Property OperSysDirec()
        Get
            OperSysDirec = m_OperSystemDire
        End Get
    End Property
    Public ReadOnly Property OperBuildType()
        Get
            OperBuildType = m_OperBuildTyp
        End Get
    End Property
    Public ReadOnly Property OperBuildNum()
        Get
            OperBuildNum = m_OperBuildNum
        End Get
    End Property
    Public ReadOnly Property OperVersion()
        Get
            OperVersion = m_OperVers
        End Get
    End Property
    Public ReadOnly Property OperManufac()
        Get
            OperManufac = m_OperManu
        End Get
    End Property
    Public ReadOnly Property OperServicePack()
        Get
            OperServicePack = m_OperServicePck
        End Get
    End Property
End Class
Public Class Systemd
    Public Shared Function Uptime()
        Dim q As Integer = System.Environment.TickCount
        'Dim w As Integer = q / 1000 / 60 / 60
        Dim m As Integer = q / 1000 / 60
        Dim w = Math.Round(q / 1000 / 60 / 60, 2)
        Dim fo = Math.Floor(m / 60)
        Dim min = m Mod 60
        If m > 60 Then
            Return fo.ToString & " hrs : " & min & " min"
        Else
            Return m.ToString & " min"
        End If
    End Function
    Public Shared Function LastBootUpTime()
        Dim dtmInstallDate As DateTime
        Dim oSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        For Each oMgmtObj As ManagementObject In oSearcher.Get
            dtmInstallDate = ManagementDateTimeConverter.ToDateTime(CStr(oMgmtObj("lastbootuptime")))
        Next
        Return dtmInstallDate
    End Function
End Class
Public Class CheckOs
    Public Shared Function CheckUsingVersionNumber()
        Dim osver = System.Environment.OSVersion.Version.ToString
        Dim osname As String
        If osver >= "6.1.7600" Then
            osname = "7"
        ElseIf osver >= "6.0" Then
            osname = "vista"
        ElseIf osver >= "5.1" Then
            osname = "xp"
        ElseIf osver >= "5.0" Then
            osname = "2000"
        Else
            osname = Nothing
        End If
        'MsgBox(osname)
        Return osname
    End Function
End Class
Public Class os
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

            'MsgBox("We have a SysInfo API problem...")
            Return "Unknown"
        End Try
    End Function
    Public Shared Function InstallationDate()
        Dim dtmInstallDate As DateTime
        Dim oSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        For Each oMgmtObj As ManagementObject In oSearcher.Get
            dtmInstallDate = ManagementDateTimeConverter.ToDateTime(CStr(oMgmtObj("InstallDate")))
        Next
        Return dtmInstallDate
    End Function
End Class
Public Class Bios
    Public Shared Function ReleaseDate()
        Dim dtmReleaseDate As DateTime
        Dim oSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_BIOS")
        For Each oMgmtObj As ManagementObject In oSearcher.Get
            dtmReleaseDate = ManagementDateTimeConverter.ToDateTime(CStr(oMgmtObj("releasedate")))
        Next
        Return dtmReleaseDate
    End Function
End Class