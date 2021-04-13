Public NotInheritable Class SysSplash

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SysSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Misc.CheckUsingVersionNumber = "xp" Then
            MsgBox("Windows xp don't support Softview GUI v2.3 display model" & vbNewLine & "Please download Sys Optimizer 2.0 XP from Arvin Soft", MsgBoxStyle.Exclamation + vbOKOnly, "Unsupported Os")
            End
        End If
        If My.Computer.Screen.Bounds.Height < 768 Or My.Computer.Screen.Bounds.Width < 1024 Then
            MsgBox("The screen resolution you've selected don't support Softview GUI so please change your display resolution to 1024 x 768 or above", MsgBoxStyle.Critical + vbOKOnly, "Minimum requirement not met")
            End
        End If
        If My.Computer.Screen.Bounds.Height = 768 Or My.Computer.Screen.Bounds.Width > 1024 And My.Computer.Screen.Bounds.Width < 1366 Then
            'MsgBox("The screen resolution you've selected has met the minimum but not meet the recommended resolution", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
        tmrloadanimation.Enabled = True
    End Sub
    ' Our declared delegate routine for updating the splash screen on a different thread.
    Private Delegate Sub UpdateStatus(ByVal text As String)

    Private Sub UpdateStatusText(ByVal text As String)
        'lblLoading.Text = text
    End Sub

    Public Sub Status(ByVal text As String)

        ' Had to put this check in because on some slow machines the main form thread would be
        ' trying to update the status text before the splash form had been created.
        If Me.Created Then
            'lblLoading.Invoke(New UpdateStatus(AddressOf UpdateStatusText), New Object() {text})
        End If

    End Sub

    Private Sub tmrloadanimation_Tick(sender As Object, e As EventArgs) Handles tmrloadanimation.Tick
        ' lod1.Location = New Point(lod1.Location.X + 5, lod1.Location.Y)
        'If lod1.Location.X = 185 Then
        '    tmrloadanimation.Enabled = False
        '    tmrloadanimationrev.Enabled = True
        'End If
        If lod1.Visible = False Then
            t2.Visible = False
            lod1.Visible = True
        ElseIf t2.Visible = False Then
            t3.Visible = False
            t2.Visible = True
        ElseIf t3.Visible = False Then
            t3.Visible = True
            t4.Visible = False
        ElseIf t4.Visible = False Then
            t4.Visible = True
            t3.Visible = False
            tmrloadanimationrev.Enabled = True
            tmrloadanimation.Enabled = False
        End If
    End Sub

    Private Sub tmrloadanimationrev_Tick(sender As Object, e As EventArgs) Handles tmrloadanimationrev.Tick
        If t2.Visible = False Then
            t2.Visible = True
            lod1.Visible = False
            tmrloadanimation.Enabled = True
            tmrloadanimationrev.Enabled = False
        ElseIf t3.Visible = False Then
            t3.Visible = True
            t2.Visible = False
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
