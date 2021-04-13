Public Class InstallPlugin

    Private Sub bttnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        Me.Close()
    End Sub

    Private Sub bttnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnOpen.Click
        opnDlg.ShowDialog()
        txtPlgInPth.Text = opnDlg.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Misc.UnZip(opnDlg.FileName.ToString)
        MsgBox("Module installed", MsgBoxStyle.Information + vbOKOnly, "Success")
    End Sub
End Class