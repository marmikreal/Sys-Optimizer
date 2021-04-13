<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxExChrome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgBoxExChrome))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonEx1 = New Sys_Optimizer_1._0.ButtonEx()
        Me.ButtonEx2 = New Sys_Optimizer_1._0.ButtonEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRet = New System.Windows.Forms.Label()
        Me.lblMessToDis = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ButtonEx1
        '
        Me.ButtonEx1.CommandLink = True
        Me.ButtonEx1.CommandLinkNote = "Close chrome and scan for files"
        Me.ButtonEx1.Location = New System.Drawing.Point(12, 102)
        Me.ButtonEx1.Name = "ButtonEx1"
        Me.ButtonEx1.Size = New System.Drawing.Size(260, 64)
        Me.ButtonEx1.TabIndex = 7
        Me.ButtonEx1.Text = "Close program"
        Me.ButtonEx1.UseVisualStyleBackColor = True
        '
        'ButtonEx2
        '
        Me.ButtonEx2.CommandLink = True
        Me.ButtonEx2.CommandLinkNote = Nothing
        Me.ButtonEx2.Location = New System.Drawing.Point(12, 180)
        Me.ButtonEx2.Name = "ButtonEx2"
        Me.ButtonEx2.Size = New System.Drawing.Size(260, 41)
        Me.ButtonEx2.TabIndex = 8
        Me.ButtonEx2.Text = "Skip files"
        Me.ButtonEx2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(73, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 48)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "I can't scan the Chrome files when its running so close the program or skip the f" &
    "iles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblRet
        '
        Me.lblRet.AutoSize = True
        Me.lblRet.Location = New System.Drawing.Point(21, 86)
        Me.lblRet.Name = "lblRet"
        Me.lblRet.Size = New System.Drawing.Size(13, 13)
        Me.lblRet.TabIndex = 10
        Me.lblRet.Text = "1"
        Me.lblRet.Visible = False
        '
        'lblMessToDis
        '
        Me.lblMessToDis.AutoSize = True
        Me.lblMessToDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessToDis.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMessToDis.Location = New System.Drawing.Point(66, 22)
        Me.lblMessToDis.Name = "lblMessToDis"
        Me.lblMessToDis.Size = New System.Drawing.Size(197, 20)
        Me.lblMessToDis.TabIndex = 11
        Me.lblMessToDis.Text = "Chrome browser is running"
        '
        'MsgBoxExChrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(297, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessToDis)
        Me.Controls.Add(Me.lblRet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonEx2)
        Me.Controls.Add(Me.ButtonEx1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxExChrome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonEx1 As Sys_Optimizer_1._0.ButtonEx
    Friend WithEvents ButtonEx2 As Sys_Optimizer_1._0.ButtonEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRet As System.Windows.Forms.Label
    Friend WithEvents lblMessToDis As System.Windows.Forms.Label
End Class
