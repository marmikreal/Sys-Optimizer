Imports System.IO

Public Class PassCheckLiveTuner

    Private Sub bttnCheckPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckPass.Click
        If MskInPuBxPass.Text = My.Settings.pass Then
            main.togglebutton.Location = New Point(620, main.togglebutton.Location.Y)
            My.Settings.livUpdat = 0
            main.tmrNottyNotifications.Enabled = False
            main.tmrShowNoti.Enabled = False
            'Main.RTBMesages.Visible = False
            main.RTBMesages.Text = "Live tuner disabled"
            If main.ProcessRunning("Sys Notifier") >= 1 Then
                main.EndPlugin("Sys Notifier.exe")
                main.EndPlugin("ForceCloseProtection")
            Else
                MsgBox("No Process running")
            End If
            File.Delete(Application.StartupPath & "\RunNot.txt")
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Sorry Password not correct. Please remember password is case sensitive", MsgBoxStyle.Information + vbOKOnly, "password not correct")
        End If
    End Sub

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub PassCheckLiveTuner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MskInPuBxPass.Text = ""
    End Sub
End Class