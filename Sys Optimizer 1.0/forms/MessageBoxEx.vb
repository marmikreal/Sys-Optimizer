Imports System.Management

Public Class MessageBoxEx

    Private Sub ButtonEx2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEx2.Click
        Me.Close()
    End Sub
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
    Public Shared Function SetText(ByVal lblmess As Label, ByVal lblsubmessfunc As Label, ByVal message As String, ByVal submessage As String)
        lblmess.Text = message
        lblsubmessfunc.Text = submessage
        Return Nothing
    End Function
    Private Sub ButtonEx1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEx1.Click
        EndFirefox()
        lblRet.Text = 0
        Me.Close()
    End Sub

    Private Sub MessageBoxEx_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
    End Sub

    Private Sub lblSubMess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSubMess.Click

    End Sub
End Class