'############################################################################################################
'#          Analyse function to retrieve the temp files from the computer using the functiod.dll            #
'#                    Copyright (C) 2010 - 2013 Arvin Soft. All Rights Reserved.                            #
'#                   Copyright (C) 2010-2013 Arvive Systems. All Rights Reserved.                           #
'#                Copyright (C) 2012-2013 Arvive Software Solutions. All Rights Reserved.                   #
'#                     Copyright (C) 2014 Citrus Labs India. All Rights Reserved.                           #
'############################################################################################################
'********************************************************************************************************************
'*     Analyse class retrieve files from the temp folder using libRetrieve.vb from Funtiod.dll and perform          *
'*                           the scan for item command in the main program                                          *
'*              Please don't modify the code below if you don't know what you are doing                             *
'*                         Product of Arvive Software Solutions for Arvin Soft                                      *
'*                         Product of Citrus Labs India and Citrus Software Development Group                       *
'********************************************************************************************************************
Imports Functiod.Cache
Imports Functiod
Imports System.Xml
Imports System.IO
Public Class Analyse
    Public Shared errormessage As String
    Public Shared Function ScanForItem(ByVal Progressbar1 As ProgressBar, ByVal progressbar2 As ProgressBar, ByVal progressbarsec As ProgressBar, ByVal lstCleanerOtherfls As ListView, ByVal lblScanStatus As Label)
        'Scan for temp files using functiod function
        'The Defenition of the function can be found on the class functiod and on the file libretrieve.vb
        'Please don't change anything without your knowledge
        'Copyright (C) 2013 A-Soft. All Rights Reserved.
        'Copyright (C) 2010-2013 Arvin Soft. All Rights Reserved.
        'Crash_Box.ShowDialog()
       
        'lstCleaner.Items.Clear()
        InternetFiles.lstBrowIE.Items.Clear()
        InternetFiles.lstBrowFF.Items.Clear()
        InternetFiles.lstBrowChrom.Items.Clear()
        InternetFiles.lstBrowOper.Items.Clear()
        InternetFiles.lstBrowSaf.Items.Clear()
        InternetFiles.lstBrowThunder.Items.Clear()
        OtherFiles.lstTemp.Items.Clear()
        OtherFiles.lstWER.Items.Clear()
        OtherFiles.lstSoft.Items.Clear()
        lstCleanerOtherfls.Items.Clear()
        Functiod.retrieval.count = 0
        Functiod.retrieval.countIE = 0
        Functiod.retrieval.countFF = 0
        Functiod.retrieval.countChrom = 0
        Functiod.retrieval.countOper = 0
        Functiod.retrieval.countSafar = 0
        Functiod.retrieval.countThunder = 0
        Functiod.retrieval.countTemp = 0
        Functiod.retrieval.countLog = 0
        Functiod.retrieval.ount = 0
        Functiod.retrieval.sized = 0
        'Functiod.retrieval.sizedother = 0
        Progressbar1.Value = 0
        progressbarsec.Value = 0
        If SpecialFoldersandDrives.crashbox = True Then
            Crash_Box.ShowDialog()
        End If
        
       

        Progressbar1.Value = 100
        progressbarsec.Value = 100
        lblScanStatus.Text = "Status : Scan Complete"
        ' ProgressBar1.Value = 0

        Return Nothing
        Progressbar1.Value = 100
        progressbar2.Value = 100
        main.prgIntFls.Visible = False
       
        'lblSizeonDs.Visible = True
        ' MsgBox(Functiod.retrieval.sized)
    End Function
End Class
'############################################################################################################
'#          Analyse function to retrieve the temp files from the computer using the functiod.dll            #
'#                    Copyright (C) 2010 - 2013 Arvin Soft. All Rights Reserved.                            #
'#                   Copyright (C) 2010-2013 Arvive Systems. All Rights Reserved.                           #
'#                Copyright (C) 2012-2013 Arvive Software Solutions. All Rights Reserved.                   #
'#                     Copyright (C) 2014 Citrus Labs India. All Rights Reserved.                           #
'############################################################################################################
'********************************************************************************************************************
'*     Analyse class retrieve files from the temp folder using libRetrieve.vb from Funtiod.dll and perform          *
'*                           the scan for item command in the main program                                          *
'*              Please don't modify the code below if you don't know what you are doing                             *
'*                         Product of Arvive Software Solutions for Arvin Soft                                      *
'*                         Product of Citrus Labs India and Citrus Software Development Group                       *
'********************************************************************************************************************