'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyleft (C) 2012-2013 A-Soft. All Rights Reserved.                      #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyleft (C) 2010-2013 Arvin Soft. All Rights Reserved.                      #
'##############################################################################################
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.icon
Public Class retrieval
   
    Public Shared count As Integer = 0
    Public Shared countIE As Integer = 0
    Public Shared countFF As Integer = 0
    Public Shared countChrom As Integer = 0
    Public Shared countOper As Integer = 0
    Public Shared countSafar As Integer = 0
    Public Shared countThunder As Integer = 0
    Public Shared countTemp As Integer = 0
    Public Shared countLog As Integer = 0
    Public Shared ount As Integer = 0
    Public Shared sized As Integer = 0

    

    Public Shared Function GetTempDirectory() As String
        Return Environment.GetEnvironmentVariable("TEMP")
    End Function


  

    'Public Shared Function GetTempDirWindDir(ByVal list As ListView)
    '    For Each Folder In Directory.GetDirectories(Functiod.Cache.GetTempFilesWindows)
    '        list.Items.Add(Folder, 4)
    '        list.Items(ount).SubItems.Add("Folder")
    '        list.Items(ount).SubItems.Add("No Data")
    '        ount += 1
    '        On Error Resume Next
    '    Next
    '    Return Nothing
    'End Function

    ' Thanks to Manuel Alves of stackoverflow.com for providing the code below
    ' Thanks for making sys optimizer a best software Manuel Alves'
    ' The Function FileInUse is provided by Manuel Alves'

    Public Shared Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function
    ' Thanks to Manuel Alves of stackoverflow.com for providing the code Above
    ' Thanks for making sys optimizer a best software Manuel Alves'
    ' The Function FileInUse is provided by Manuel Alves'

    
    'Public Shared Function TempFoldfolder(ByVal list As ListView)
    '    For Each folder In Directory.GetDirectories(GetTempDirectory())
    '        list.Items.Add(folder, 4)
    '        list.Items(ount).SubItems.Add("Folder")
    '        list.Items(ount).SubItems.Add("No Data")
    '        ount += 1
    '        On Error Resume Next
    '    Next
    '    Return Nothing
    'End Function

    
    Public Class Thunderbird
        
    End Class

    Public Class Firefox
        
    End Class

    Public Class chrome
        
    End Class

    Public Class Safari
        
    End Class

    Public Class WindowsItems
       
        
       
       
       
        'Public Shared Function GetWindowsMediaPlayerCache(ByVal List As ListView)
        '    For Each filinfold In Directory.GetFiles(Functiod.WindowsItems.WindowsMediaPlayerCache)
        '        List.Items.Add(filinfold, 12)
        '        Dim sinfo = My.Computer.FileSystem.GetFileInfo(filinfold)
        '        Dim sSize = Math.Round(sinfo.Length / 1024, 2)
        '        List.Items(ount).SubItems.Add(sSize & " KB")
        '        ount += 1
        '        sizedother += sSize
        '    Next
        '    Return Nothing
        'End Function
    End Class

    Public Class SoftwareCac
        
        
        

      
       
        
       
       
      
    End Class

End Class
'##############################################################################################
'#                        Source Code is a copyleft of A-Soft.                                #
'#                   Copyleft (C) 2012-2013 A-Soft. All Rights Reserved.                      #
'#                        Software is a Copyleft of Arvin Soft.                               #
'#               Copyleft (C) 2010-2013 Arvin Soft. All Rights Reserved.                      #
'##############################################################################################