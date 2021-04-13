Imports System.Management

Public Class MsgBoxExChrome

    Private Sub ButtonEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEx1.Click
        Endchrome()
        lblRet.Text = 0
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Public Shared Function Endchrome()
        Try
            Dim sist As Integer = 0
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") = "chrome.exe" Then
                    Dim p As Process = Process.GetProcessById(queryObj("ProcessId"))
                    p.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    Private Sub ButtonEx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEx2.Click
        Me.Close()

    End Sub

    Private Sub MsgBoxExChrome_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub
End Class
