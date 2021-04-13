Imports System.Xml
Imports System.IO
Imports System.Management

Public Class AddProcess

    Public Function EnumerateProcess(ByVal lstProName As ListBox)
        lstProName.Items.Clear()
        Try
            Dim sist As Integer = 0
            Dim sd As Integer = 0
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")
            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Caption") <> "wininit.exe" And queryObj("Caption") <> "winlogon.exe" And queryObj("Caption") <> "System Idle Process" And queryObj("Caption") <> "System" And queryObj("Caption") <> "svchost.exe" Then
                    Dim name = queryObj("Caption")
                    lstProName.Items.Add(queryObj("Caption"))
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
        Return Nothing
    End Function
    Private Sub bttnBrowForPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnBrowForPro.Click
        Dim fls
        opnDlg.ShowDialog()
        fls = opnDlg.FileName()
        Dim nm = IO.Path.GetFileName(fls)
        txtProc.Text = nm
    End Sub

    Private Sub ProAdd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        EnumerateProcess(lstRunPro)
    End Sub
    Public Function addpro()
        Dim path = Application.StartupPath & "\Proc"
        If Directory.Exists(path) = False Then
            Directory.CreateDirectory(path)
            If File.Exists(path & "\" & txtProc.Text & ".xml") = False Then
                Dim sett As New XmlWriterSettings
                Dim xmld As XmlWriter = XmlWriter.Create(path & "\" & txtProc.Text & ".xml", sett)
                With xmld
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
                Settings.lstBxUnwanPro.Items.Add(txtProc.Text)
                Me.Close()
            Else
                MsgBox("Item already added can't add again", MsgBoxStyle.Information + vbOKOnly, "Information")
            End If
        Else
            If File.Exists(path & "\" & txtProc.Text & ".xml") = False Then
                Dim sett As New XmlWriterSettings
                Dim xmld As XmlWriter = XmlWriter.Create(path & "\" & txtProc.Text & ".xml", sett)
                With xmld
                    .WriteStartDocument()
                    .WriteStartElement("Data")
                    .WriteEndElement()
                    .WriteEndDocument()
                    .Close()
                End With
                Settings.lstBxUnwanPro.Items.Add(txtProc.Text)
                Me.Close()
            Else
                MsgBox("Item already added can't add again", MsgBoxStyle.Information + vbOKOnly, "Information")
            End If
        End If
        Return Nothing
    End Function
    Private Sub bttnProcAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnProcAdd.Click
        If My.Settings.pass = "" Then
            addpro()
        Else
            panPass.Visible = True
        End If
    End Sub

    Private Sub lstRunPro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstRunPro.SelectedIndexChanged
        If lstRunPro.SelectedItem <> "" Then
            txtProc.Text = lstRunPro.SelectedItem.ToString
        End If
    End Sub

    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MaskedTextBox2.Text = My.Settings.pass Then
            panPass.Visible = False
            MaskedTextBox2.Text = ""
            addpro()
        End If
    End Sub
End Class