<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxExThunBird
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgBoxExThunBird))
        Me.lblMessToDis = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IblRet = New System.Windows.Forms.Label()
        Me.ButtonEx1 = New Sys_Optimizer_1._0.ButtonEx()
        Me.ButtonEx2 = New Sys_Optimizer_1._0.ButtonEx()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessToDis
        '
        Me.lblMessToDis.AutoSize = True
        Me.lblMessToDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessToDis.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMessToDis.Location = New System.Drawing.Point(56, 24)
        Me.lblMessToDis.Name = "lblMessToDis"
        Me.lblMessToDis.Size = New System.Drawing.Size(172, 20)
        Me.lblMessToDis.TabIndex = 12
        Me.lblMessToDis.Text = "Thunder Bird is running"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 48)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "I can't scan the Thunder Bird files when its running so close the program or skip" &
    " the files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'IblRet
        '
        Me.IblRet.AutoSize = True
        Me.IblRet.Location = New System.Drawing.Point(12, 88)
        Me.IblRet.Name = "IblRet"
        Me.IblRet.Size = New System.Drawing.Size(13, 13)
        Me.IblRet.TabIndex = 14
        Me.IblRet.Text = "1"
        '
        'ButtonEx1
        '
        Me.ButtonEx1.CommandLink = True
        Me.ButtonEx1.CommandLinkNote = "Close chrome and scan for files"
        Me.ButtonEx1.Location = New System.Drawing.Point(12, 116)
        Me.ButtonEx1.Name = "ButtonEx1"
        Me.ButtonEx1.Size = New System.Drawing.Size(260, 64)
        Me.ButtonEx1.TabIndex = 15
        Me.ButtonEx1.Text = "Close program"
        Me.ButtonEx1.UseVisualStyleBackColor = True
        '
        'ButtonEx2
        '
        Me.ButtonEx2.CommandLink = True
        Me.ButtonEx2.CommandLinkNote = Nothing
        Me.ButtonEx2.Location = New System.Drawing.Point(12, 186)
        Me.ButtonEx2.Name = "ButtonEx2"
        Me.ButtonEx2.Size = New System.Drawing.Size(260, 41)
        Me.ButtonEx2.TabIndex = 16
        Me.ButtonEx2.Text = "Skip files"
        Me.ButtonEx2.UseVisualStyleBackColor = True
        '
        'MsgBoxExThunBird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonEx2)
        Me.Controls.Add(Me.ButtonEx1)
        Me.Controls.Add(Me.IblRet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMessToDis)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxExThunBird"
        Me.ShowInTaskbar = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessToDis As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IblRet As System.Windows.Forms.Label
    Friend WithEvents ButtonEx1 As Sys_Optimizer_1._0.ButtonEx
    Friend WithEvents ButtonEx2 As Sys_Optimizer_1._0.ButtonEx
End Class
