Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Updatedlg

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Delegate Sub setNm(ByVal [text] As String)
    Private Sub stNm(ByVal [text] As String)
        If lblProdNm.InvokeRequired = True Then
            Dim d As New setNm(AddressOf stNm)
            lblProdNm.Invoke(d, New Object() {[text]})
        Else
            lblProdNm.Text = [text]
        End If
    End Sub
    Delegate Sub setCurVer(ByVal [text] As String)
    Private Sub stCurVer(ByVal [text] As String)
        If lblCurVer.InvokeRequired = True Then
            Dim d As New setNm(AddressOf stCurVer)
            lblCurVer.Invoke(d, New Object() {[text]})
        Else
            lblCurVer.Text = [text]
        End If
    End Sub
    Delegate Sub setLatVer(ByVal [text] As String)
    Private Sub stLatVer(ByVal [text] As String)
        If lblLatVer.InvokeRequired = True Then
            Dim d As New setLatVer(AddressOf stLatVer)
            lblLatVer.Invoke(d, New Object() {[text]})
        Else
            lblLatVer.Text = [text]
        End If
    End Sub
    Delegate Sub setDown86(ByVal [text] As String)
    Private Sub stDown86(ByVal [text] As String)
        If lblDown86.InvokeRequired = True Then
            Dim d As New setDown86(AddressOf stDown86)
            lblDown86.Invoke(d, New Object() {[text]})
        Else
            lblDown86.Text = [text]
        End If
    End Sub
    Private Sub Updatedlg_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Misc.GetUpdateInformation(lblProdNm, lblCurVer, lblLatVer, lblDown86, Label7, Label1, Label6)
        Dim wc As New WebClient
        wc.Headers("content-type") = "application/x-www-form-urlencoded"
        'Uncomment the handler when unleashing the power of jQuryAPI for Arvin Soft
        AddHandler wc.UploadStringCompleted, AddressOf UploadStringCallback2
        'Uncomment the above to unleash the power of JQ
        'MsgBox(txtBxUsrNm.Text & " : " & txtBxPass.Text)
        'Dim response As String = wc.UploadString("http://localhost/camplocal/phppages/jqrapi/loginchecker.php", "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")
        'Dim uri As Uri = New Uri("http://localhost/arvinsoftofficial/jqueryapi/api.php")
        Dim uri As Uri = New Uri("http://www.arvinsoft.in/jqueryapi/api.php")
        wc.UploadStringAsync(uri, "logusrnm=" & My.Settings.username & "&logpass=" & My.Settings.password & "&opt=9")
    End Sub
    Private Shared Sub UploadStringCallback2(ByVal sender As Object, ByVal e As UploadStringCompletedEventArgs)
        Dim reply As String = CStr(e.Result)
        ' MsgBox(reply)
        'MsgBox(reply)
        If reply = "" Then
            'MsgBox("Please login to continue", MsgBoxStyle.Critical + vbOKOnly, "Sorry")

        Else
            Dim name As String = ""
            Using reader As XmlReader = XmlReader.Create(New StringReader(reply))
                Dim ws As XmlWriterSettings = New XmlWriterSettings()
                ws.Indent = True

                Try
                    ' Parse the file and display each of the nodes.
                    Dim count = 0
                    While reader.Read()
                        Select Case reader.NodeType
                            Case XmlNodeType.Element
                                'MsgBox("<" & reader.Name & ">")
                                name = reader.Name
                            Case XmlNodeType.Text

                                Dim link As String = ""
                                If name = "downloadlink" Then
                                    link = reader.Value
                                    Updatedlg.lblDown86.Text = link
                                End If
                                If name = "downsize" Then
                                    Updatedlg.lblDownSize.Text = "Download Size : " & reader.Value
                                End If
                                If (name = "latestver") Then
                                    If reader.Value > "3.0" Then
                                        Updatedlg.lblStatus.Text = "Update Available" & vbNewLine & vbNewLine & vbNewLine & "Latest Version : Sys Optimizer v" & reader.Value
                                        Updatedlg.lblDown86.Visible = True
                                        Updatedlg.lblDownLink.Visible = True
                                        Updatedlg.picerror.Visible = True
                                        Updatedlg.PicUptodate.Visible = False
                                        Updatedlg.lblDownSize.Visible = True
                                        Updatedlg.bttnCheckForUpdates.Visible = True

                                    Else
                                        Updatedlg.lblStatus.Text = "You are using the latest version : Sys Optimizer v" & reader.Value
                                        Updatedlg.lblStatus.Visible = True
                                        Updatedlg.PicUptodate.Visible = True
                                        Updatedlg.picerror.Visible = False
                                        Updatedlg.lblDown86.Visible = False
                                        Updatedlg.lblDownLink.Visible = False
                                        Updatedlg.lblDownSize.Visible = False
                                        Updatedlg.bttnCheckForUpdates.Visible = True

                                    End If

                                    '  MsgBox(reader.Value)
                                    'mainfrm.ListView1.Items.Add(reader.Value)
                                    'mainfrm.ListBox2.Items.Add(reader.Value)
                                    'mainfrm.ListView1.Items(count).SubItems.Add(".aaxt")
                                    count += 1

                                End If
                            Case XmlNodeType.XmlDeclaration
                            Case XmlNodeType.ProcessingInstruction
                            'MsgBox(reader.Name & reader.Value)

                            Case XmlNodeType.EndElement

                        End Select
                    End While
                Catch ex As XmlException
                    MsgBox(ex.ToString)
                End Try
            End Using
        End If


    End Sub
    Private Sub BgWrKrChkUpdt_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWrKrChkUpdt.DoWork


        'Misc.GetUpdateInformationThreadSafe("http://arvivesolutions.weebly.com/uploads/4/6/0/9/4609554/update_sys_optimizer.xml")
        'If Misc.nm = "Version Up to date" Then
        '    stNm(Misc.nm)
        '    stCurVer("")
        '    stLatVer("")
        '    stDown86("")
        '    'PicUptodate.Visible = True
        '    'picerror.Visible = False
        '    'lblStatus.Visible = False
        'Else
        '    stNm("Product Name : " & Misc.nm)
        '    stCurVer("Current Version : " & Misc.currver)
        '    stLatVer("Latest Version : " & Misc.latver)
        '    stDown86(Misc.down86)
        '    PicUptodate.Visible = False
        '    'picerror.Visible = True
        '    'lblStatus.Text = "Update Available"
        '    'lblStatus.Visible = True
        'End If

    End Sub

    Private Sub Updatedlg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If BgWrKrChkUpdt.IsBusy = False Then
            BgWrKrChkUpdt.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgWrKrChkUpdt_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWrKrChkUpdt.RunWorkerCompleted
        'If lblCurVer.Text <> "Current Version : Error Connecting Server" And lblCurVer.Text <> "" Then
        '    lblStatus.Visible = True
        '    lblStatus.Text = "Update Available"
        '    picerror.Visible = True
        '    PicUptodate.Visible = False
        '    lblDownLink.Visible = True
        'ElseIf lblCurVer.Text = "Current Version : Error Connecting Server" Then
        '    lblStatus.Visible = True
        '    lblStatus.Text = "Error Connecting Server"
        '    picerror.Visible = True
        '    PicUptodate.Visible = False
        '    lblDownLink.Visible = True
        'Else
        '    lblDownLink.Visible = False
        '    lblStatus.Visible = False
        '    picerror.Visible = False
        '    PicUptodate.Visible = True
        'End If
    End Sub

    Private Sub bttnCheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCheckForUpdates.Click
        bttnCheckForUpdates.Visible = False
        'If BgWrKrChkUpdt.IsBusy = False Then
        '    BgWrKrChkUpdt.RunWorkerAsync()
        'End If
        ''lblStatus.Visible = False
        'lblStatus.Text = "Checking for updates"
        'picerror.Visible = False
        'PicUptodate.Visible = False
        'lblCurVer.Text = ""
        'lblDown86.Text = ""
        'lblLatVer.Text = ""
        'lblProdNm.Text = ""
        'lblStatus.Text = ""
        ' Misc.GetUpdateInformation(lblProdNm, lblCurVer, lblLatVer, lblDown86, Label7, Label1, Label6)
        Dim wc As New WebClient
        wc.Headers("content-type") = "application/x-www-form-urlencoded"
        'Uncomment the handler when unleashing the power of jQuryAPI for Arvin Soft
        AddHandler wc.UploadStringCompleted, AddressOf UploadStringCallback2
        'Uncomment the above to unleash the power of JQ
        'MsgBox(txtBxUsrNm.Text & " : " & txtBxPass.Text)
        'Dim response As String = wc.UploadString("http://localhost/camplocal/phppages/jqrapi/loginchecker.php", "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")
        'Dim uri As Uri = New Uri("http://localhost/arvinsoftofficial/jqueryapi/api.php")
        Dim uri As Uri = New Uri("http://www.arvinsoft.in/jqueryapi/api.php")
        wc.UploadStringAsync(uri, "logusrnm=" & My.Settings.username & "&logpass=" & My.Settings.password & "&opt=9")
    End Sub

    Private Sub lblDown86_Click(sender As Object, e As EventArgs) Handles lblDown86.Click
        If lblDown86.Text <> "Error Connecting Server" And lblDown86.Text <> "" Then
            Process.Start(lblDown86.Text.Replace("Download Link : ", ""))
        End If
    End Sub
End Class