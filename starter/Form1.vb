Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Process.Start(Application.StartupPath & "\Sys Optimizer.exe")
        Me.Close()
    End Sub
End Class
