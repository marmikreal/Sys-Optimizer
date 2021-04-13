Imports System.IO
Imports System.Xml
Public Class AddGame

    Private Sub AddGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For Each filinfold In Directory.GetFiles(Application.StartupPath & "\procgmes")
            ListBox1.Items.Add(IO.Path.GetFileNameWithoutExtension(filinfold))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fls
        opnDlg.ShowDialog()
        fls = opnDlg.FileName()
        Dim nm = IO.Path.GetFileName(fls)
        txtProc.Text = nm
    End Sub
    Public Function addpro()
        'Dim path = Application.StartupPath & "\Proc"
        'If Directory.Exists(path) = False Then
        'Directory.CreateDirectory(Path)
        If File.Exists(Application.StartupPath & "\procgmes\" & txtProc.Text & ".txt") = False Then
            File.Create(Application.StartupPath & "\procgmes\" & txtProc.Text & ".txt")
            ListBox1.Items.Add(txtProc.Text)
            ' Me.Close()
        Else
            MsgBox("Item already added can't add again", MsgBoxStyle.Information + vbOKOnly, "Information")
        End If
        txtProc.Text = ""
        Return Nothing
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addpro()
    End Sub
    Public Function DelSelPro()
        If Directory.Exists(Application.StartupPath & "\procgmes") = True Then
            For Each fls In Directory.GetFiles(Application.StartupPath & "\procgmes")
                'MsgBox(fls)
                'MsgBox(ListBox1.SelectedItem)
                If IO.Path.GetFileNameWithoutExtension(fls) = ListBox1.SelectedItem Then
                    'MsgBox(lstBxUnwanPro.SelectedItem & ".xml")
                    Try
                        File.Delete(fls)
                    Catch ex As Exception
                    End Try
                End If
            Next
            Threading.Thread.Sleep(100)
            ListBox1.Items.Clear()
            For Each fls In Directory.GetFiles(Application.StartupPath & "\procgmes")
                    ListBox1.Items.Add(IO.Path.GetFileNameWithoutExtension(fls))
            Next
        End If
        Return Nothing
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DelSelPro()
    End Sub
End Class