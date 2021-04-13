Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        If My.Computer.Clock.LocalTime.Month = 12 Then
            fl1.Visible = True
            fl2.Visible = True
            fl3.Visible = True
            fl4.Visible = True
            fl5.Visible = True
            fl6.Visible = True
            fl7.Visible = True
            fl8.Visible = True
            fl9.Visible = True
        Else
            fl1.Visible = False
            fl2.Visible = False
            fl3.Visible = False
            fl4.Visible = False
            fl5.Visible = False
            fl6.Visible = False
            fl7.Visible = False
            fl8.Visible = False
            fl9.Visible = False
        End If
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        'Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        'lstLib.Items.Clear()
        'lstLib.Items.Add("Functiod Library")
        'lstLib.Items(0).SubItems.Add("2.0")
        'lstLib.Items.Add("enumSoftware Library")
        'lstLib.Items(1).SubItems.Add("0.5.4")
        'lstLib.Items.Add("Processes Library")
        'lstLib.Items(2).SubItems.Add("0.5.3")
        'lstLib.Items.Add("Game Booster Module")
        'lstLib.Items(3).SubItems.Add("0.1")
        'lstLib.Items.Add("Game Booster Neural Module")
        'lstLib.Items(4).SubItems.Add("0.1")
        'lstLib.Items.Add("Empty Folder finder Module")
        'lstLib.Items(5).SubItems.Add("0.0.2")
        'lstLib.Items.Add("Notty Component Module")
        'lstLib.Items(6).SubItems.Add("1.0")
        'lstLib.Items.Add("Notty Message Identifier Module")
        'lstLib.Items(7).SubItems.Add("1.0")
        'lstLib.Items.Add("Notty Message Updater Module")
        'lstLib.Items(8).SubItems.Add("1.0")
        'lstLib.Items.Add("Process Identifier Module for Notty")
        'lstLib.Items(9).SubItems.Add("1.0")
        'lstLib.Items.Add("Crash Box Module")
        'lstLib.Items(10).SubItems.Add("0.4")
        'lstLib.Items.Add("Crash Message Provider Module")
        'lstLib.Items(11).SubItems.Add("0.4")
        'lstLib.Items.Add("Software Update Module")
        'lstLib.Items(12).SubItems.Add("2.0")
        'lstLib.Items.Add("Update Software XML Module")
        'lstLib.Items(13).SubItems.Add("1.0")
        'lstLib.Items.Add("Update Software XML Checker Module")
        'lstLib.Items(14).SubItems.Add("1.0")
        'lstLib.Items.Add("Power Plans Changer Module")
        'lstLib.Items(15).SubItems.Add("1.0")
        'lstLib.Items.Add("Enumeration Module")
        'lstLib.Items(16).SubItems.Add("2.0")
        'lstLib.Items.Add("Battery Analyzer Module")
        'lstLib.Items(17).SubItems.Add("0.2")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub bttnLicensePan_Click(sender As System.Object, e As System.EventArgs) Handles bttnLicensePan.Click
        panLicense.Visible = False
        RichTextBox1.Visible = False
    End Sub

   
    Private Sub bttnLicenseShow_Click(sender As System.Object, e As System.EventArgs) Handles bttnLicenseShow.Click
        tmrShowOpenSourceIni.Enabled = True
        panLicense.Visible = True
    End Sub

    Private Sub tmrShowOpenSourceIni_Tick(sender As System.Object, e As System.EventArgs) Handles tmrShowOpenSourceIni.Tick
        RichTextBox1.Visible = True
        tmrShowOpenSourceIni.Enabled = False
    End Sub

    Private Sub bttnAboutSoftview_Click(sender As Object, e As System.EventArgs) Handles bttnAboutSoftview.Click
        panAboutSoftview.Visible = True
    End Sub

    Private Sub bttnClosePanAboutSoftview_Click(sender As System.Object, e As System.EventArgs) Handles bttnClosePanAboutSoftview.Click
        panAboutSoftview.Visible = False
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub About_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub

    Private Sub panAboutSoftview_Paint(sender As Object, e As PaintEventArgs) Handles panAboutSoftview.Paint

    End Sub

    Private Sub panAboutSoftview_MouseClick(sender As Object, e As MouseEventArgs) Handles panAboutSoftview.MouseClick
        panAboutSoftview.Visible = False
    End Sub
End Class
