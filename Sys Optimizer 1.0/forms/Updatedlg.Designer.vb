<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updatedlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updatedlg))
        Me.PicUptodate = New System.Windows.Forms.PictureBox()
        Me.picerror = New System.Windows.Forms.PictureBox()
        Me.bttnCheckForUpdates = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDownSize = New System.Windows.Forms.Label()
        Me.lblDownLink = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDown86 = New System.Windows.Forms.Label()
        Me.lblLatVer = New System.Windows.Forms.Label()
        Me.lblCurVer = New System.Windows.Forms.Label()
        Me.lblProdNm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tlTpUpdt = New System.Windows.Forms.ToolTip(Me.components)
        Me.BgWrKrChkUpdt = New System.ComponentModel.BackgroundWorker()
        CType(Me.PicUptodate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicUptodate
        '
        Me.PicUptodate.BackColor = System.Drawing.Color.White
        Me.PicUptodate.Image = CType(resources.GetObject("PicUptodate.Image"), System.Drawing.Image)
        Me.PicUptodate.Location = New System.Drawing.Point(16, 20)
        Me.PicUptodate.Name = "PicUptodate"
        Me.PicUptodate.Size = New System.Drawing.Size(16, 16)
        Me.PicUptodate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicUptodate.TabIndex = 113
        Me.PicUptodate.TabStop = False
        Me.tlTpUpdt.SetToolTip(Me.PicUptodate, "Version up to date")
        Me.PicUptodate.Visible = False
        '
        'picerror
        '
        Me.picerror.BackColor = System.Drawing.Color.White
        Me.picerror.Image = CType(resources.GetObject("picerror.Image"), System.Drawing.Image)
        Me.picerror.Location = New System.Drawing.Point(13, 17)
        Me.picerror.Name = "picerror"
        Me.picerror.Size = New System.Drawing.Size(19, 20)
        Me.picerror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picerror.TabIndex = 112
        Me.picerror.TabStop = False
        Me.tlTpUpdt.SetToolTip(Me.picerror, "Update available")
        Me.picerror.Visible = False
        '
        'bttnCheckForUpdates
        '
        Me.bttnCheckForUpdates.BackColor = System.Drawing.Color.White
        Me.bttnCheckForUpdates.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite
        Me.bttnCheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnCheckForUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCheckForUpdates.Location = New System.Drawing.Point(163, 314)
        Me.bttnCheckForUpdates.Name = "bttnCheckForUpdates"
        Me.bttnCheckForUpdates.Size = New System.Drawing.Size(142, 28)
        Me.bttnCheckForUpdates.TabIndex = 110
        Me.bttnCheckForUpdates.Text = "Check for updates"
        Me.bttnCheckForUpdates.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bttnCheckForUpdates.UseVisualStyleBackColor = False
        Me.bttnCheckForUpdates.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblDownSize)
        Me.Panel1.Controls.Add(Me.lblDownLink)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.PicUptodate)
        Me.Panel1.Controls.Add(Me.picerror)
        Me.Panel1.Controls.Add(Me.lblDown86)
        Me.Panel1.Controls.Add(Me.lblLatVer)
        Me.Panel1.Controls.Add(Me.lblCurVer)
        Me.Panel1.Controls.Add(Me.lblProdNm)
        Me.Panel1.Location = New System.Drawing.Point(-3, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 273)
        Me.Panel1.TabIndex = 114
        '
        'lblDownSize
        '
        Me.lblDownSize.AutoSize = True
        Me.lblDownSize.Location = New System.Drawing.Point(47, 95)
        Me.lblDownSize.Name = "lblDownSize"
        Me.lblDownSize.Size = New System.Drawing.Size(87, 13)
        Me.lblDownSize.TabIndex = 126
        Me.lblDownSize.Text = "Download Size : "
        Me.lblDownSize.Visible = False
        '
        'lblDownLink
        '
        Me.lblDownLink.AutoSize = True
        Me.lblDownLink.Location = New System.Drawing.Point(47, 129)
        Me.lblDownLink.Name = "lblDownLink"
        Me.lblDownLink.Size = New System.Drawing.Size(87, 13)
        Me.lblDownLink.TabIndex = 125
        Me.lblDownLink.Text = "Download Link : "
        Me.lblDownLink.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(47, 23)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(110, 13)
        Me.lblStatus.TabIndex = 124
        Me.lblStatus.Text = "Checking for Updates"
        '
        'lblDown86
        '
        Me.lblDown86.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDown86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDown86.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDown86.Location = New System.Drawing.Point(135, 129)
        Me.lblDown86.Name = "lblDown86"
        Me.lblDown86.Size = New System.Drawing.Size(222, 54)
        Me.lblDown86.TabIndex = 122
        '
        'lblLatVer
        '
        Me.lblLatVer.AutoSize = True
        Me.lblLatVer.Location = New System.Drawing.Point(13, 95)
        Me.lblLatVer.Name = "lblLatVer"
        Me.lblLatVer.Size = New System.Drawing.Size(0, 13)
        Me.lblLatVer.TabIndex = 121
        '
        'lblCurVer
        '
        Me.lblCurVer.AutoSize = True
        Me.lblCurVer.Location = New System.Drawing.Point(13, 72)
        Me.lblCurVer.Name = "lblCurVer"
        Me.lblCurVer.Size = New System.Drawing.Size(0, 13)
        Me.lblCurVer.TabIndex = 120
        '
        'lblProdNm
        '
        Me.lblProdNm.AutoSize = True
        Me.lblProdNm.Location = New System.Drawing.Point(13, 48)
        Me.lblProdNm.Name = "lblProdNm"
        Me.lblProdNm.Size = New System.Drawing.Size(0, 13)
        Me.lblProdNm.TabIndex = 119
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(80, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 33)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Update Sys Optimizer "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(311, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 28)
        Me.Button2.TabIndex = 115
        Me.Button2.Text = "Close"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BgWrKrChkUpdt
        '
        '
        'Updatedlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(388, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bttnCheckForUpdates)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Updatedlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PicUptodate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picerror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicUptodate As System.Windows.Forms.PictureBox
    Friend WithEvents picerror As System.Windows.Forms.PictureBox
    Friend WithEvents bttnCheckForUpdates As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDown86 As System.Windows.Forms.Label
    Friend WithEvents lblLatVer As System.Windows.Forms.Label
    Friend WithEvents lblCurVer As System.Windows.Forms.Label
    Friend WithEvents lblProdNm As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tlTpUpdt As System.Windows.Forms.ToolTip
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents BgWrKrChkUpdt As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblDownLink As System.Windows.Forms.Label
    Friend WithEvents lblDownSize As Label
End Class
