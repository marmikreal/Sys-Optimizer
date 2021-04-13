Imports System.Net

Public Class addarvinacc
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub txtBxUsrNm_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBxUsrNm.MouseDown
        txtBxUsrNm.Text = ""
    End Sub
    Private Sub txtBxpass_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBxPass.MouseDown
        txtBxPass.Text = ""
    End Sub
    Public Shared Sub UploadStringCallback2(ByVal sender As Object, ByVal e As UploadStringCompletedEventArgs)
        Dim reply As String = CStr(e.Result)
        ' MsgBox(reply)
        If reply = "success" Then
            My.Settings.username = addarvinacc.txtBxUsrNm.Text
            My.Settings.password = addarvinacc.txtBxPass.Text
            addarvinacc.Timer1.Enabled = True
            addarvinacc.Label6.Visible = True
            addarvinacc.Label6.BackColor = Color.OliveDrab
            addarvinacc.Label6.Text = "Successfully logged in"
        Else
            addarvinacc.Label6.Visible = True
            addarvinacc.Label6.Text = "username or password incorrect"
            addarvinacc.Label6.BackColor = Color.IndianRed
            'MsgBox("Sorry Username or password incorrect")

        End If
        'Using reader As XmlReader = XmlReader.Create(New StringReader(reply))
        '    Dim ws As XmlWriterSettings = New XmlWriterSettings()
        '    ws.Indent = True

        '    Try
        '        ' Parse the file and display each of the nodes.
        '        While reader.Read()
        '            Select Case reader.NodeType
        '                Case XmlNodeType.Element
        '                    'MsgBox("<" & reader.Name & ">")
        '                Case XmlNodeType.Text
        '                    MsgBox(reader.Value)
        '                Case XmlNodeType.XmlDeclaration
        '                Case XmlNodeType.ProcessingInstruction
        '                    'MsgBox(reader.Name & reader.Value)

        '                Case XmlNodeType.EndElement

        '            End Select
        '        End While
        '    Catch ex As XmlException
        '        MsgBox(ex.ToString)
        '    End Try
        'End Using
    End Sub
    Public username As String
    Public password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = txtBxUsrNm.Text
        password = txtBxPass.Text
        'Dim checked As Boolean = chkBxContinu.Checked
        'If Button1.Text = "Login" Then
        Dim wc As New WebClient
        wc.Headers("content-type") = "application/x-www-form-urlencoded"
        'Uncomment the handler when unleashing the power of jQuryAPI for Arvin Soft
        AddHandler wc.UploadStringCompleted, AddressOf UploadStringCallback2
        'Uncomment the above to unleash the power of JQ

        'Dim response As String = wc.UploadString("http://localhost/camplocal/phppages/jqrapi/loginchecker.php", "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&apimeth=1")
        ' Dim uri As Uri = New Uri("http://localhost/arvinsoftofficial/jqueryapi/api.php")
        Dim uri As Uri = New Uri("http://www.arvinsoft.in/jqueryapi/api.php")
        wc.UploadStringAsync(uri, "logusrnm=" & txtBxUsrNm.Text & "&logpass=" & txtBxPass.Text & "&devnm=" & My.Computer.Name.ToString & "&opt=1")

    End Sub
End Class