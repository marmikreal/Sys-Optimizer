Imports Microsoft.Win32
Imports System.IO

Public Class EnumSoftwareAssoc
    Public Shared countsx As Integer = 0
    Public Shared Function GetInstalledProgramsonline(ByVal slst As ListView, ByVal imgLst As ImageList)
        'Dim countsx As Integer = 0
        countsx = 0
        imgLst.Images.Clear()
        Try
            Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                        Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                        If dunstr <> "" Then
                            Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            If inssiz <> "" Then
                                Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                                Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                                Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                                Dim dIcon As String = Convert.ToString(key.GetValue("DisplayIcon"))
                                'Dim dinst As String = Convert.ToString(key.GetValue("InstallDate"))
                                If Not String.IsNullOrEmpty(dname) Then
                                    If dIcon <> "" Then
                                        'MsgBox(dname & " " & dIcon)
                                        Dim nm
                                        If dIcon.EndsWith(0) = True Then
                                            Dim nmln = dIcon.Length()
                                            nm = dIcon.Remove(nmln - 2, 2)
                                        Else
                                            nm = dIcon
                                        End If
                                        If File.Exists(nm) = True Then
                                            'MsgBox(dname & " " & nm)
                                            imgLst.Images.Add(Icon.ExtractAssociatedIcon(nm))
                                        Else
                                            imgLst.Images.Add(My.Resources._1371432167_window_list)
                                        End If
                                    Else
                                        imgLst.Images.Add(My.Resources._1371432167_window_list)
                                    End If
                                    slst.Items.Add(dname, countsx)
                                    If dvers <> "" Then
                                        slst.Items(countsx).SubItems.Add(dvers)
                                    Else
                                        slst.Items(countsx).SubItems.Add("(No Information)")
                                    End If
                                    'slst.Items(countsx).SubItems.Add(dinst)
                                    If dmanu <> "" Then
                                        slst.Items(countsx).SubItems.Add(dmanu)
                                    Else
                                        slst.Items(countsx).SubItems.Add("(No Information)")
                                    End If
                                    countsx += 1
                                End If
                                End If
                            End If
                    End Using
                Next
            End Using
            'MsgBox(countsx)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing

    End Function
    Public Shared Function GetInstalledProgramson64bit(ByVal slst As ListView, ByVal imgLst As ImageList)
        Try
            Using uninstalled64 As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled64.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled64.OpenSubKey(sbKeyName)
                        Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                        If dunstr <> "" Then
                            Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            If inssiz <> "" Then
                                Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                                Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                                Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                                Dim dIcon As String = Convert.ToString(key.GetValue("DisplayIcon"))
                                If Not String.IsNullOrEmpty(dname) Then
                                    If dIcon <> "" Then
                                        If File.Exists(dIcon) = True Then
                                            imgLst.Images.Add(Icon.ExtractAssociatedIcon(dIcon))
                                        Else
                                            imgLst.Images.Add(My.Resources._1371432167_window_list)
                                        End If
                                    Else
                                        imgLst.Images.Add(My.Resources._1371432167_window_list)
                                    End If
                                    slst.Items.Add(dname, countsx)
                                    slst.Items(countsx).SubItems.Add(dvers)
                                    slst.Items(countsx).SubItems.Add(dmanu)
                                    countsx += 1
                                End If
                            End If
                        End If
                    End Using
                Next
            End Using
            MsgBox(countsx)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing

    End Function

End Class
