'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyright (C) 2012-2013 A-Soft. All Rights Reserved.                     #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################
Imports System.Windows.Forms
Imports System.Management
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Processos
    
    'Need Three Columns for enumerating Process
    Public Shared Function EnumerateProcess(ByVal lstProName As ListView, ByVal imglst As ImageList)
        lstProName.Items.Clear()
        Try
            Dim sist As Integer = 0
            Dim sd As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") <> "wininit.exe" And queryObj("Caption") <> "winlogon.exe" And queryObj("Caption") <> "System Idle Process" Then
                    Dim name = queryObj("Caption")
                    lstProName.Items.Add(queryObj("Caption"))
                    lstProName.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProName.Items(sist).SubItems.Add(Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 2) & " MB")
                    lstProName.Items(sist).SubItems.Add(queryObj("ThreadCount"))
                    If queryObj("CreationDate") <> "" Then
                        lstProName.Items(sist).SubItems.Add(ManagementDateTimeConverter.ToDateTime(queryObj("CreationDate")))
                    End If
                    sist += 1
                    sd = (+1)
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
        Return Nothing
    End Function
    Public Shared Function EndProcess(ByVal lstprocesse As ListView)
        Dim i As Integer
        For i = 0 To lstprocesse.SelectedItems.Count = i
            Dim retrun
            retrun = lstprocesse.SelectedItems(i).Text
            Try
                Dim sist As Integer = 0
                Dim searcher As New ManagementObjectSearcher( _
                    "root\CIMV2", _
                    "SELECT * FROM Win32_Process")
                For Each queryObj As ManagementObject In searcher.Get()
                    Try
                        Dim lstprocess = queryObj("Caption")
                        Dim lstid = queryObj("ProcessId")
                        If lstprocess = retrun Then
                            Dim p As Process = Process.GetProcessById(lstid)
                            Try
                                p.Kill()
                            Catch ex As Exception
                                MsgBox("Sorry Process Cannot be ended", MsgBoxStyle.OkOnly + vbCritical, "Prompt")
                            End Try
                        End If
                    Catch ex As Exception
                    End Try
                Next
            Catch err As ManagementException
                MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            End Try
        Next
        Return Nothing
    End Function
    Public Shared Function setHighPrior(ByVal lstprocesse As ListView)
        Dim i As Integer
        For i = 0 To lstprocesse.SelectedItems.Count = i
            Dim retrun
            retrun = lstprocesse.SelectedItems(i).Text
            ' MsgBox(retrun)
            Try
                Dim psList() As Process
                    Try

                        psList = Process.GetProcesses()
                    retrun = retrun.ToString.Replace(".exe", "")
                        For Each p As Process In psList
                        'MsgBox("2. " & retrun & " = " & p.ProcessName)
                        If p.ProcessName = retrun Then

                            p.PriorityClass = ProcessPriorityClass.High
                            ' MsgBox("Hello" & p.ProcessName & "  " & retrun)
                        End If
                        Next p

                Catch ex As Exception
                    MsgBox("some error occurred" & ex.ToString)
                    End Try
            Catch ex As Exception

            End Try
        Next
        Return Nothing
    End Function
    Public Shared Function setHighPriority(ByVal lblproc As String)
            Try
                Dim psList() As Process
                Try
                Dim retrun As String = lblproc
                    psList = Process.GetProcesses()
                    retrun = retrun.ToString.Replace(".exe", "")
                    For Each p As Process In psList
                        'MsgBox("2. " & retrun & " = " & p.ProcessName)
                        If p.ProcessName = retrun Then

                            p.PriorityClass = ProcessPriorityClass.High
                            ' MsgBox("Hello" & p.ProcessName & "  " & retrun)
                        End If
                    Next p

                Catch ex As Exception
                    MsgBox("some error occurred" & ex.ToString)
                End Try
            Catch ex As Exception

            End Try
        Return Nothing
    End Function
    Public Shared Function GetProcUsg(ByVal getsys As Label)

        'Dim a As Process = Process.GetProcessById("Sys Optimizer.exe")
        ' MsgBox(a.TotalProcessorTime)
        'Try
        Dim sist As Integer = 0
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
        For Each queryObj As ManagementObject In searcher.Get()
            'MsgBox(queryObj("Caption"))
            If queryObj("Caption") = "Sys Optimizer.exe" Then
                'MsgBox("Sys")
                Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                Static prev = p.TotalProcessorTime.TotalMilliseconds
                ' MsgBox("Skip")
                ' MsgBox(p.UserProcessorTime.ToString)
                p.Refresh()

                Dim change = p.TotalProcessorTime.TotalMilliseconds - prev
                Dim total = change

                getsys.Text = total / 100
                System.Threading.Thread.Sleep(500)
                prev = change
                'prev = change
            End If
        Next
        'Catch ex As Exception
        ' MsgBox(ex.ToString)
        'End Try
        Return Nothing
    End Function
    Public Shared Function DoubleClickEndProcess(ByVal lstprocess As ListView)
        Dim Resued = MsgBox("Are You Sure you want to end this process", MsgBoxStyle.Question + vbYesNo)
        If Resued = vbYes Then
            EndProcess(lstprocess)
            'EnumerateProcess(lstprocess)
        End If
        Return Nothing
    End Function
    Public Shared proc As Integer = 0
    Public Shared sisted As Integer = 0
    Public Shared Function AdobeupdatenotifyPro(ByVal lstProName As ListView)
        'lstProName.Items.Clear()
        Try

            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "AAM Updates Notifier.exe" Then
                    lstProName.Items.Add(queryObj("Caption"))
                    lstProName.Items(sisted).SubItems.Add(queryObj("ProcessId"))
                    lstProName.Items(sisted).SubItems.Add(queryObj("PageFileUsage"))
                    sisted += 1
                    proc += 1
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function WTCDPro(ByVal lstProName As ListView)
        'lstProName.Items.Clear()
        Try
            ' Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "WTClient.exe" Then
                    lstProName.Items.Add(queryObj("Caption"))
                    lstProName.Items(sisted).SubItems.Add(queryObj("ProcessId"))
                    lstProName.Items(sisted).SubItems.Add(queryObj("PageFileUsage"))
                    sisted += 1
                    proc += 1
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function EndFirefox()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "firefox.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function EndChrome()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get
                If queryObj("Caption") = "chrome.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function EndOpera()
        Try
            Dim sinst As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "opera.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function EndThunderbird()
        Try
            Dim sinst As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "thunderbird.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function WTCDProend()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "WTClient.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function Adobeupdatenotifyproend()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "AAM Updates Notifier.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
End Class
    Public Class Services
        'Need Four Columns for enumerating Services
        Public Shared Function EnumerateServices(ByVal lstservices As ListView)
            Dim sst As Integer = 0
            Try
                Dim sist As Integer = 0
                Dim searcher As New ManagementObjectSearcher( _
                    "root\CIMV2", _
                    "SELECT * FROM Win32_Service")
                For Each queryObj As ManagementObject In searcher.Get()
                    lstservices.Items.Add(queryObj("name"))
                    lstservices.Items(sst).SubItems.Add(queryObj("processid"))
                    lstservices.Items(sst).SubItems.Add(queryObj("DisplayName"))
                    lstservices.Items(sst).SubItems.Add(queryObj("state"))
                    sst += 1
                Next
            Catch ex As Exception
            End Try
            Return Nothing
        End Function
    End Class
'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyright (C) 2012-2013 A-Soft. All Rights Reserved.                     #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################