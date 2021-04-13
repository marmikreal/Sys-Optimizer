'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyright (C) 2012-2013 A-Soft. All Rights Reserved.                     #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################
Imports Microsoft.Win32
Imports System.Windows.Forms
Public Class Softwares
    Public Shared Function GetInstalledPrograms(ByVal slst As ListView)
        Dim count As Integer = 0
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
                            If Not String.IsNullOrEmpty(dname) Then
                                slst.Items.Add(dname)
                                slst.Items(count).SubItems.Add(dvers)
                                slst.Items(count).SubItems.Add(dmanu)
                                count += 1
                            End If
                        End If
                    End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function GetInstalledProgramson64bit(ByVal slst As ListView)
        Dim count As Integer = 0
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
                            Dim sdd As ListViewItem = slst.FindItemWithText(dname)
                            If Not String.IsNullOrEmpty(dname) Then
                                'If slst.Items.Contains(sdd) <> False Then
                                slst.Items.Add(dname)
                                slst.Items(count).SubItems.Add(dvers)
                                slst.Items(count).SubItems.Add(dmanu)
                                count += 1
                                'End If
                            End If
                        End If
                    End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function GetHiddenInstalledPrograms(ByVal slst As ListView)
        Dim count As Integer = 0
        Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
            For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                    Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                    If dunstr <> "" Then
                        Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                            Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                            Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                            If Not String.IsNullOrEmpty(dname) Then
                                slst.Items.Add(dname)
                                slst.Items(count).SubItems.Add(dvers)
                                slst.Items(count).SubItems.Add(dmanu)
                                count += 1
                            End If
                        End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function GetHiddenInstalledPrograms64(ByVal slst As ListView)
        Dim count As Integer = 0
        Using uninstalled64 As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", False)
            For Each sbKeyName As String In uninstalled64.GetSubKeyNames()
                Using key As RegistryKey = uninstalled64.OpenSubKey(sbKeyName)
                    Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                    If dunstr <> "" Then
                        Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                            Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                            Dim dmanu As String = Convert.ToString(key.GetValue("Publisher"))
                            Dim sdd As ListViewItem = slst.FindItemWithText(dname)
                            If Not String.IsNullOrEmpty(dname) Then
                                'If slst.Items.Contains(sdd) <> False Then
                                slst.Items.Add(dname)
                                slst.Items(count).SubItems.Add(dvers)
                                slst.Items(count).SubItems.Add(dmanu)
                                count += 1
                                'End If
                            End If
                        End If
                End Using
            Next
        End Using
        Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
            For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                    Dim dunstr As String = Convert.ToString(key.GetValue("UninstallString"))
                    If dunstr <> "" Then
                        Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                            Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                            Dim dverss As String = Convert.ToString(key.GetValue("DisplayVersion"))
                            Dim dmanus As String = Convert.ToString(key.GetValue("Publisher"))
                            If Not String.IsNullOrEmpty(dname) Then
                                slst.Items.Add(dname)
                                slst.Items(count).SubItems.Add(dverss)
                                slst.Items(count).SubItems.Add(dmanus)
                                count += 1
                            End If
                        End If
                End Using
            Next
        End Using
        Return Nothing
    End Function
    Public Shared Function UninstallSoftwares(ByVal lst)
        Dim i As Integer
        For i = 0 To lst.SelectedItems.Count = i
            Dim retrun
            retrun = lst.SelectedItems(i).Text
            Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                        Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                        Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                        Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                        Dim dunst As String = Convert.ToString(key.GetValue("UninstallString"))
                        If retrun = dname And inssiz <> "" Then
                            Try
                                Shell(dunst)
                            Catch ex As Exception
                                MsgBox("Uninstaller Failed to Start")
                            End Try

                        End If
                    End Using

                Next
            End Using
        Next
        Return Nothing
    End Function
    Public Shared Function UninstallSoftwares64bit(ByVal lst)
        Dim i As Integer
        For i = 0 To lst.SelectedItems.Count = i
            Dim retrun
            retrun = lst.SelectedItems(i).Text
            Using uninstalled As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", False)
                For Each sbKeyName As String In uninstalled.GetSubKeyNames()
                    Using key As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                        Dim inssiz As String = Convert.ToString(key.GetValue("EstimatedSize"))
                        Dim dname As String = Convert.ToString(key.GetValue("DisplayName"))
                        Dim dvers As String = Convert.ToString(key.GetValue("DisplayVersion"))
                        Dim dunst As String = Convert.ToString(key.GetValue("UninstallString"))
                        If retrun = dname And inssiz <> "" Then
                            Try
                                Shell(dunst)
                            Catch ex As Exception
                                MsgBox("Uninstaller Failed to Start")
                            End Try
                        Else

                            'Using uninstalleds As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", False)
                            '    For Each subkeyname As String In uninstalleds.GetSubKeyNames()
                            '        Using keya As RegistryKey = uninstalled.OpenSubKey(sbKeyName)
                            '                    Dim dnames As String = Convert.ToString(keya.GetValue("DisplayName"))
                            '                    Dim dunins As String = Convert.ToString(keya.GetValue("UninstallString"))
                            '                    MsgBox(dunins & " 0")
                            '                    If retrun = dnames Then
                            '                        Try
                            '                            Shell(dunins)
                            '                            MsgBox(dunins & " 1")
                            '                        Catch ex As Exception
                            '                            MsgBox("Uninstaller Failed to Start")
                            '                        End Try
                            '                    End If
                            ' End Using
                            ' Next
                            ' End Using
                        End If
                    End Using
                Next
            End Using
        Next
        Return Nothing
    End Function
End Class
'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyright (C) 2012-2013 A-Soft. All Rights Reserved.                     #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.                     #
'##############################################################################################