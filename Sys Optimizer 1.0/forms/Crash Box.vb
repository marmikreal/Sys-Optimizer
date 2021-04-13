'##############################################################################################
'#                        Source Code is a copyright of A-Soft.                               #
'#                   Copyright (C) 2013 Arvive Software Solutions. All Rights Reserved.       #
'#                        Software is a Copyright of Arvin Soft.                              #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################
'**********************************************************************************************
'                                   Crash box for Sys Optimizer                               *
'         Crash box show the crash message from the software  when the software crashes       *
'**********************************************************************************************
Imports Functiod
Imports System.Management
Public Class Crash_Box
    Public Shared Function Endsysoptimizer()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "Sys Optimizer.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Public Shared Function EndSysOptimizer1p0()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryobj As ManagementObject In searcher.Get()
                If queryobj("Caption") = "Sys Optimizer 1.0.exe" Then
                    Dim p As Process = Process.GetProcessById(queryobj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Shared Function EndBlackLight()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get
                If queryObj("Caption") = "Black Light.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Private Sub Crash_Box_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter

    End Sub

    Private Sub Crash_Box_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SpecialFoldersandDrives.crashbox = True Then
            If SpecialFoldersandDrives.crashmessage <> "" Then
                RichTextBox1.Text = ""
                RichTextBox1.Text = SpecialFoldersandDrives.crashmessage
            Else
                RichTextBox1.Text = "Error Occurred was : Unknown Error (404)"
            End If
        End If
        If cpinfo.apionSysbitness = True Then
            If cpinfo.crashmessagebitness <> "" Then
                RichTextBox1.Text = RichTextBox1.Text & vbNewLine & "Error Occurred was : " & cpinfo.crashmessagebitness
            Else
                RichTextBox1.Text = "Error Occurred was : Unknown Error (404 Bt)"
            End If
        End If
        If main.errormessage <> "" Then
            RichTextBox1.Text = vbNewLine & main.errormessage
        End If
        If OtherFiles.errormessage <> "" Then
            RichTextBox1.Text = vbNewLine & OtherFiles.errormessage
        End If
        If Analyse.errormessage <> "" Then
            RichTextBox1.Text = vbNewLine & Analyse.errormessage
        End If
        If Delete.errormessage <> "" Then
            RichTextBox1.Text = vbNewLine & Delete.errormessage
        End If
        RTBTechInfoAndPara.Text = "Technical Details and parameters and working of the software on your system" & vbNewLine
        Dim workinfo As String
        If Functiod.CheckOS.CheckUsingVersionNumber = "8" Then
            workinfo = "Software working info : 8NT\8.1NT\SysOptim\1.0\dotNet2.0\" & My.Computer.Name.ToString
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "7" Then
            workinfo = "Software working info : 7NTOld\SysOptim\1.0\dotNet2.0\" & My.Computer.Name.ToString
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "vista" Then
            workinfo = "Software working info : 6VisNTOld\SysOptim\1.0\dotNet2.0\" & My.Computer.Name.ToString
        ElseIf Functiod.CheckOS.CheckUsingVersionNumber = "xp" Then
            workinfo = "Software working info : xNTOldKer\SysOptim\1.0\dotNet2.0\" & My.Computer.Name.ToString
        Else
            workinfo = "Software working info : NotDtKer\SysOptim\1.0\dotNet2.0\" & My.Computer.Name.ToString
        End If
        RTBTechInfoAndPara.Text = RTBTechInfoAndPara.Text & "Software code 0f1s0Lb0dtfrm2p0" & " Build No : 1010 "
        RTBTechInfoAndPara.Text = RTBTechInfoAndPara.Text & workinfo & My.Computer.Info.OSFullName.ToString & cpinfo.getOsBitness & My.Computer.Info.OSPlatform &
            My.Computer.Clock.LocalTime & " " & My.Computer.Info.TotalPhysicalMemory & " " & My.Computer.Info.AvailablePhysicalMemory &
            Main.Width & " W " & Main.Height & " H " & Main.Location.X & " X " & Main.Location.Y & " Y "

    End Sub

    Private Sub Crash_Box_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If Analyse.errormessage = "Test message this is not a real error" Then
            Analyse.errormessage = ""
        End If
    End Sub

    Private Sub bttnCloseProgram_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttnCloseProgram.Click
        Endsysoptimizer()
        EndSysOptimizer1p0()
        EndBlackLight()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("http://arvinsoft.weebly.com/contact-us.html")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Debug_Info.ShowDialog()
    End Sub
End Class

'**********************************************************************************************
'                                   Crash box for Sys Optimizer                               *
'         Crash box show the crash message from the software  when the software crashes       *
'**********************************************************************************************
'##############################################################################################
'#                        Source Code is a copyright of A-Soft.                               #
'#                   Copyright (C) 2013 Arvive Software Solutions. All Rights Reserved.       #
'#                        Software is a Copyright of Arvin Soft.                              #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################
