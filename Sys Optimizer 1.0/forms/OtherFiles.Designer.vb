<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OtherFiles))
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tbTemp = New System.Windows.Forms.TabPage()
        Me.lstTemp = New System.Windows.Forms.ListView()
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgOther = New System.Windows.Forms.ImageList(Me.components)
        Me.tbWER = New System.Windows.Forms.TabPage()
        Me.lstWER = New System.Windows.Forms.ListView()
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbSoft = New System.Windows.Forms.TabPage()
        Me.lstSoft = New System.Windows.Forms.ListView()
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.imgproc1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panIntFls = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panPopup = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.bttnMax = New System.Windows.Forms.Button()
        Me.lblSzonDsk = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tmrDialogPopup = New System.Windows.Forms.Timer(Me.components)
        Me.CnMnOtherFls = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl3.SuspendLayout()
        Me.tbTemp.SuspendLayout()
        Me.tbWER.SuspendLayout()
        Me.tbSoft.SuspendLayout()
        Me.panIntFls.SuspendLayout()
        Me.panPopup.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.CnMnOtherFls.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.tbTemp)
        Me.TabControl3.Controls.Add(Me.tbWER)
        Me.TabControl3.Controls.Add(Me.tbSoft)
        Me.TabControl3.ImageList = Me.ImageList1
        Me.TabControl3.ItemSize = New System.Drawing.Size(42, 25)
        Me.TabControl3.Location = New System.Drawing.Point(-1, 39)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(665, 328)
        Me.TabControl3.TabIndex = 35
        '
        'tbTemp
        '
        Me.tbTemp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbTemp.Controls.Add(Me.lstTemp)
        Me.tbTemp.ImageIndex = 1
        Me.tbTemp.Location = New System.Drawing.Point(4, 29)
        Me.tbTemp.Name = "tbTemp"
        Me.tbTemp.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTemp.Size = New System.Drawing.Size(657, 295)
        Me.tbTemp.TabIndex = 0
        '
        'lstTemp
        '
        Me.lstTemp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTemp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstTemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstTemp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader32, Me.ColumnHeader33})
        Me.lstTemp.FullRowSelect = True
        Me.lstTemp.LargeImageList = Me.imgOther
        Me.lstTemp.Location = New System.Drawing.Point(3, 3)
        Me.lstTemp.Name = "lstTemp"
        Me.lstTemp.Size = New System.Drawing.Size(633, 271)
        Me.lstTemp.SmallImageList = Me.imgOther
        Me.lstTemp.TabIndex = 32
        Me.lstTemp.TileSize = New System.Drawing.Size(250, 65)
        Me.lstTemp.UseCompatibleStateImageBehavior = False
        Me.lstTemp.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "File Name"
        Me.ColumnHeader32.Width = 450
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Size ( KB/MB )"
        Me.ColumnHeader33.Width = 110
        '
        'imgOther
        '
        Me.imgOther.ImageStream = CType(resources.GetObject("imgOther.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgOther.TransparentColor = System.Drawing.Color.Transparent
        Me.imgOther.Images.SetKeyName(0, "1371677667_text-x-log.png")
        Me.imgOther.Images.SetKeyName(1, "1371678406_file_temporary.png")
        Me.imgOther.Images.SetKeyName(2, "1371498889_system-software-installer.png")
        '
        'tbWER
        '
        Me.tbWER.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbWER.Controls.Add(Me.lstWER)
        Me.tbWER.ImageIndex = 0
        Me.tbWER.Location = New System.Drawing.Point(4, 29)
        Me.tbWER.Name = "tbWER"
        Me.tbWER.Padding = New System.Windows.Forms.Padding(3)
        Me.tbWER.Size = New System.Drawing.Size(657, 295)
        Me.tbWER.TabIndex = 1
        '
        'lstWER
        '
        Me.lstWER.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstWER.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstWER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstWER.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34, Me.ColumnHeader35})
        Me.lstWER.FullRowSelect = True
        Me.lstWER.LargeImageList = Me.imgOther
        Me.lstWER.Location = New System.Drawing.Point(3, 3)
        Me.lstWER.Name = "lstWER"
        Me.lstWER.Size = New System.Drawing.Size(633, 271)
        Me.lstWER.SmallImageList = Me.imgOther
        Me.lstWER.TabIndex = 33
        Me.lstWER.TileSize = New System.Drawing.Size(250, 65)
        Me.lstWER.UseCompatibleStateImageBehavior = False
        Me.lstWER.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "File Name"
        Me.ColumnHeader34.Width = 447
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Size ( KB/MB )"
        Me.ColumnHeader35.Width = 110
        '
        'tbSoft
        '
        Me.tbSoft.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbSoft.Controls.Add(Me.lstSoft)
        Me.tbSoft.ImageIndex = 2
        Me.tbSoft.Location = New System.Drawing.Point(4, 29)
        Me.tbSoft.Name = "tbSoft"
        Me.tbSoft.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSoft.Size = New System.Drawing.Size(657, 295)
        Me.tbSoft.TabIndex = 2
        '
        'lstSoft
        '
        Me.lstSoft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSoft.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstSoft.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSoft.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader36, Me.ColumnHeader37})
        Me.lstSoft.FullRowSelect = True
        Me.lstSoft.LargeImageList = Me.imgproc1
        Me.lstSoft.Location = New System.Drawing.Point(3, 3)
        Me.lstSoft.Name = "lstSoft"
        Me.lstSoft.Size = New System.Drawing.Size(633, 271)
        Me.lstSoft.SmallImageList = Me.imgproc1
        Me.lstSoft.TabIndex = 33
        Me.lstSoft.TileSize = New System.Drawing.Size(250, 65)
        Me.lstSoft.UseCompatibleStateImageBehavior = False
        Me.lstSoft.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "File Name"
        Me.ColumnHeader36.Width = 444
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "Size ( KB/MB )"
        Me.ColumnHeader37.Width = 110
        '
        'imgproc1
        '
        Me.imgproc1.ImageStream = CType(resources.GetObject("imgproc1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgproc1.TransparentColor = System.Drawing.Color.Transparent
        Me.imgproc1.Images.SetKeyName(0, "cmd(1).png")
        Me.imgproc1.Images.SetKeyName(1, "1344594568_zip.png")
        Me.imgproc1.Images.SetKeyName(2, "1344594735_firefox-icon.png")
        Me.imgproc1.Images.SetKeyName(3, "ess_icon_80x80.jpg")
        Me.imgproc1.Images.SetKeyName(4, "1344595239_Folder.png")
        Me.imgproc1.Images.SetKeyName(5, "ati_radeon_icon_by_antoan11-d47vj1w.png")
        Me.imgproc1.Images.SetKeyName(6, "Ashampoo_Snap_2012.08.10_16h21m00s_001_.png")
        Me.imgproc1.Images.SetKeyName(7, "1344599081_Internet-explorer.png")
        Me.imgproc1.Images.SetKeyName(8, "1344600002_google-chrome.png")
        Me.imgproc1.Images.SetKeyName(9, "1344600200_opera.png")
        Me.imgproc1.Images.SetKeyName(10, "1344600395_safari_browser.png")
        Me.imgproc1.Images.SetKeyName(11, "1344878938_mycomputer.png")
        Me.imgproc1.Images.SetKeyName(12, "1344879326_software_development.png")
        Me.imgproc1.Images.SetKeyName(13, "1345211171_thunderbird-icon.png")
        Me.imgproc1.Images.SetKeyName(14, "1323106859_picons17.png")
        Me.imgproc1.Images.SetKeyName(15, "1351758038_Evernote.png")
        Me.imgproc1.Images.SetKeyName(16, "1351758343_utorrent.png")
        Me.imgproc1.Images.SetKeyName(17, "1351759252_nvidia-settings.png")
        Me.imgproc1.Images.SetKeyName(18, "1339493250_preferences-system 16x16.png")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1371677667_text-x-log.png")
        Me.ImageList1.Images.SetKeyName(1, "1371678406_file_temporary.png")
        Me.ImageList1.Images.SetKeyName(2, "1371498889_system-software-installer.png")
        '
        'panIntFls
        '
        Me.panIntFls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panIntFls.Controls.Add(Me.TabControl3)
        Me.panIntFls.Controls.Add(Me.Label1)
        Me.panIntFls.Controls.Add(Me.panPopup)
        Me.panIntFls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panIntFls.Location = New System.Drawing.Point(0, 0)
        Me.panIntFls.Name = "panIntFls"
        Me.panIntFls.Size = New System.Drawing.Size(652, 355)
        Me.panIntFls.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Please wait till scanning completes..."
        '
        'panPopup
        '
        Me.panPopup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panPopup.BackColor = System.Drawing.Color.Firebrick
        Me.panPopup.BackgroundImage = CType(resources.GetObject("panPopup.BackgroundImage"), System.Drawing.Image)
        Me.panPopup.Controls.Add(Me.Panel8)
        Me.panPopup.Controls.Add(Me.lblSzonDsk)
        Me.panPopup.Controls.Add(Me.Label7)
        Me.panPopup.Location = New System.Drawing.Point(-1, -1)
        Me.panPopup.Name = "panPopup"
        Me.panPopup.Size = New System.Drawing.Size(652, 34)
        Me.panPopup.TabIndex = 83
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.bttnClose)
        Me.Panel8.Controls.Add(Me.bttnMax)
        Me.Panel8.Location = New System.Drawing.Point(579, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(76, 34)
        Me.Panel8.TabIndex = 82
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.Transparent
        Me.bttnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.White
        Me.bttnClose.Location = New System.Drawing.Point(38, 0)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(32, 32)
        Me.bttnClose.TabIndex = 7
        Me.bttnClose.Text = "X"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'bttnMax
        '
        Me.bttnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnMax.BackColor = System.Drawing.Color.Transparent
        Me.bttnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnMax.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.bttnMax.FlatAppearance.BorderSize = 0
        Me.bttnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.bttnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.bttnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnMax.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnMax.ForeColor = System.Drawing.Color.Black
        Me.bttnMax.Image = CType(resources.GetObject("bttnMax.Image"), System.Drawing.Image)
        Me.bttnMax.Location = New System.Drawing.Point(2, -2)
        Me.bttnMax.Name = "bttnMax"
        Me.bttnMax.Size = New System.Drawing.Size(32, 32)
        Me.bttnMax.TabIndex = 83
        Me.bttnMax.UseVisualStyleBackColor = False
        '
        'lblSzonDsk
        '
        Me.lblSzonDsk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSzonDsk.AutoSize = True
        Me.lblSzonDsk.BackColor = System.Drawing.Color.Transparent
        Me.lblSzonDsk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSzonDsk.Location = New System.Drawing.Point(364, 9)
        Me.lblSzonDsk.Name = "lblSzonDsk"
        Me.lblSzonDsk.Size = New System.Drawing.Size(0, 13)
        Me.lblSzonDsk.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Other Files"
        '
        'tmrDialogPopup
        '
        Me.tmrDialogPopup.Enabled = True
        Me.tmrDialogPopup.Interval = 250
        '
        'CnMnOtherFls
        '
        Me.CnMnOtherFls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.CnMnOtherFls.Name = "CnMnIntFls"
        Me.CnMnOtherFls.Size = New System.Drawing.Size(104, 26)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'OtherFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 355)
        Me.ContextMenuStrip = Me.CnMnOtherFls
        Me.Controls.Add(Me.panIntFls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OtherFiles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OtherFiles"
        Me.TabControl3.ResumeLayout(False)
        Me.tbTemp.ResumeLayout(False)
        Me.tbWER.ResumeLayout(False)
        Me.tbSoft.ResumeLayout(False)
        Me.panIntFls.ResumeLayout(False)
        Me.panIntFls.PerformLayout()
        Me.panPopup.ResumeLayout(False)
        Me.panPopup.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.CnMnOtherFls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents tbTemp As System.Windows.Forms.TabPage
    Friend WithEvents tbWER As System.Windows.Forms.TabPage
    Friend WithEvents tbSoft As System.Windows.Forms.TabPage
    Friend WithEvents panIntFls As System.Windows.Forms.Panel
    Friend WithEvents panPopup As System.Windows.Forms.Panel
    Friend WithEvents lblSzonDsk As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tmrDialogPopup As System.Windows.Forms.Timer
    Friend WithEvents imgOther As System.Windows.Forms.ImageList
    Friend WithEvents imgproc1 As System.Windows.Forms.ImageList
    Friend WithEvents lstTemp As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstWER As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstSoft As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CnMnOtherFls As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents bttnMax As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
