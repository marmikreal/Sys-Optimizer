Imports System.Management
Imports System.IO

Public Class EnumProcessAssoc
    Public Shared Function getPriori(ByVal procenm As String)
        Try
            Dim psList() As Process
            Try

                psList = Process.GetProcesses()
                Dim retrun = procenm
                retrun = retrun.ToString.Replace(".exe", "")
                MsgBox(retrun)
                If retrun <> "System Idle Process" And retrun <> "System" Then
                    For Each p As Process In psList
                        'MsgBox("2. " & retrun & " = " & p.ProcessName)
                        If p.ProcessName = retrun Then
                            If p.PriorityClass = ProcessPriorityClass.High Then
                                ' MsgBox("Hello" & p.ProcessName & "  " & retrun)
                                Return "high"
                            ElseIf p.PriorityClass = ProcessPriorityClass.Normal Then
                                Return "normal"
                            Else
                                Return "som"
                            End If
                        End If
                    Next p
                End If
            Catch ex As Exception
                MsgBox("some error occurred" & ex.ToString)
                Return "No Priority"
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function
    Public Shared Function EnumerateProcessonline(ByVal lstProc As ListView, ByVal imglst As ImageList)
        Try
            lstProc.Items.Clear()
            imglst.Images.Clear()
            imglst.TransparentColor = Color.Black
            Dim systemgroup As New ListViewGroup("System")
            Dim programs As New ListViewGroup("Programs")
            Dim systemprograms As New ListViewGroup("System Programs")
            lstProc.Groups.Add(systemprograms)
            lstProc.Groups.Add(programs)
            lstProc.Groups.Add(systemgroup)


            'lstProName.Items.Clear()

            Dim sist As Integer = 0
            Dim sd As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "wininit.exe" Or queryObj("Caption") = "winlogon.exe" Or queryObj("Caption") = "System Idle Process" _
                    Or queryObj("Caption") = "System" Or queryObj("Caption") = "svchost.exe" _
                    Or queryObj("Caption") = "lsass.exe" Then
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            imglst.Images.Add(Icon.ExtractAssociatedIcon(queryObj("ExecutablePath")))
                        Else
                            imglst.Images.Add(My.Resources._1371432167_window_list)
                        End If
                    Else
                        imglst.Images.Add(My.Resources._1371432167_window_list)
                    End If
                    Dim name(1000) As String
                    name(sist) = queryObj("Caption")
                    ' Dim itm As New ListViewItem(queryObj("Caption"), systemgroup)

                    lstProc.Items.Add(New ListViewItem(New String() {name(sist)}, sist, systemgroup))
                    lstProc.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProc.Items(sist).SubItems.Add(Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 2) & " MB")
                    '* The code below is the test code to get the priority of the process
                    'MsgBox(name(sist) & " - " & getPriori(Convert.ToString(name(sist))))
                    ' lstProc.Items(sist).SubItems.Add(getPriori(Convert.ToString(name(sist))))
                    'The code above is the test code to get the priority of the process
                    'Copyright (C) 2015 Arvin Soft. All Rights Reserved.
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            lstProc.Items(sist).SubItems.Add(FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription)
                        Else
                            lstProc.Items(sist).SubItems.Add("(No Description)")
                        End If
                    Else
                        lstProc.Items(sist).SubItems.Add("(No Description)")
                    End If
                    sist += 1
                    sd = (+1)
                ElseIf queryObj("Caption") = "explorer.exe" Or queryObj("Caption") = "taskmgr.exe" Then
                    Dim name(1000) As String
                    name(sist) = queryObj("Caption")
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            imglst.Images.Add(Icon.ExtractAssociatedIcon(queryObj("ExecutablePath")))
                        Else
                            imglst.Images.Add(My.Resources._1371432167_window_list)
                        End If
                    Else
                        imglst.Images.Add(My.Resources._1371432167_window_list)
                    End If
                    lstProc.Items.Add(New ListViewItem(New String() {name(sist)}, sist, systemprograms))
                    lstProc.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProc.Items(sist).SubItems.Add(Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 2) & " MB")
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            lstProc.Items(sist).SubItems.Add(FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription)
                        Else
                            lstProc.Items(sist).SubItems.Add("(No Description)")
                        End If
                    Else
                        lstProc.Items(sist).SubItems.Add("(No Description)")
                    End If
                    sist += 1
                    sd = (+1)
                Else
                    Dim name(1000) As String
                    name(sist) = queryObj("Caption")
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            imglst.Images.Add(Icon.ExtractAssociatedIcon(queryObj("ExecutablePath")))
                        Else
                            imglst.Images.Add(My.Resources._1371432167_window_list)
                        End If
                    Else
                        imglst.Images.Add(My.Resources._1371432167_window_list)
                    End If
                    lstProc.Items.Add(New ListViewItem(New String() {name(sist)}, sist, programs))
                    lstProc.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProc.Items(sist).SubItems.Add(Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 2) & " MB")
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            lstProc.Items(sist).SubItems.Add(FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription)
                        Else
                            lstProc.Items(sist).SubItems.Add("(No Description)")
                        End If
                    Else
                        lstProc.Items(sist).SubItems.Add("(No Description)")
                    End If
                    sist += 1
                    sd = (+1)
                End If


            Next
        Catch ex As IndexOutOfRangeException
            MsgBox("There is a problem with the new module and it will not work correctly in your system" & vbNewLine & "The software will work with the old module on your system", MsgBoxStyle.Information + vbOKOnly, "Information")
            My.Settings.oldcomp = 1
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
        Return Nothing
    End Function
    Public Shared Function EnumerateProcessonline1(ByVal lstProName As ListView, ByVal imglst As ImageList)
        lstProName.Items.Clear()
        imglst.Images.Clear()
        imglst.TransparentColor = Color.Black
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")

            For Each queryObj As ManagementObject In searcher.Get()

                Dim name = queryObj("Caption")
                If name <> "wininit.exe" And name <> "System Idle Process" And name <> "svchost.exe" And name <> "system" And name <> "" Then
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            imglst.Images.Add(Icon.ExtractAssociatedIcon(queryObj("ExecutablePath")))
                        Else
                            imglst.Images.Add(My.Resources._1371432167_window_list)
                        End If
                    Else
                        imglst.Images.Add(My.Resources._1371432167_window_list)
                    End If
                    ' MsgBox(queryObj("ProcessId"))
                    lstProName.Items.Add(queryObj("Caption"), sist)
                    lstProName.Items(sist).SubItems.Add(queryObj("ProcessId"))
                    lstProName.Items(sist).SubItems.Add(Math.Round(queryObj("WorkingSetSize") / 1024 / 1024, 2) & " MB")
                    'lstProName.Items(sist).SubItems.Add(Misc.GetProcessInstanceName(queryObj("ProcessId")))
                    If queryObj("ExecutablePath") <> "" Then
                        If File.Exists(queryObj("ExecutablePath")) = True Then
                            lstProName.Items(sist).SubItems.Add(FileVersionInfo.GetVersionInfo(queryObj("ExecutablePath")).FileDescription)
                        Else
                            lstProName.Items(sist).SubItems.Add("")
                        End If
                    Else
                        lstProName.Items(sist).SubItems.Add("")
                    End If
                    'lstProName.Items(sist).SubItems.Add(queryObj("ThreadCount"))
                    'If queryObj("CreationDate") <> "" Then
                    '    lstProName.Items(sist).SubItems.Add(ManagementDateTimeConverter.ToDateTime(queryObj("CreationDate")))
                    'End If
                    sist += 1
                End If
            Next
        Catch err As ManagementException
            ' MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            'Motherboard.ereror = err.ToString
            'CrashBox.ShowDialog()
        End Try
        Return Nothing
    End Function
End Class
