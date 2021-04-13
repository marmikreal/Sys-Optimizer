<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxEx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBoxEx))
        Me.lblMessToDis = New System.Windows.Forms.Label()
        Me.lblSubMess = New System.Windows.Forms.Label()
        Me.lblRet = New System.Windows.Forms.Label()
        Me.ButtonEx2 = New Sys_Optimizer_1._0.ButtonEx()
        Me.ButtonEx1 = New Sys_Optimizer_1._0.ButtonEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessToDis
        '
        Me.lblMessToDis.AutoSize = True
        Me.lblMessToDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessToDis.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblMessToDis.Location = New System.Drawing.Point(66, 22)
        Me.lblMessToDis.Name = "lblMessToDis"
        Me.lblMessToDis.Size = New System.Drawing.Size(189, 20)
        Me.lblMessToDis.TabIndex = 2
        Me.lblMessToDis.Text = "Firefox browser is running"
        '
        'lblSubMess
        '
        Me.lblSubMess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMess.Location = New System.Drawing.Point(68, 47)
        Me.lblSubMess.Name = "lblSubMess"
        Me.lblSubMess.Size = New System.Drawing.Size(209, 47)
        Me.lblSubMess.TabIndex = 3
        Me.lblSubMess.Text = "I can't scan the firefox files when it is running so close the program or skip th" &
    "e files"
        '
        'lblRet
        '
        Me.lblRet.AutoSize = True
        Me.lblRet.Location = New System.Drawing.Point(12, 81)
        Me.lblRet.Name = "lblRet"
        Me.lblRet.Size = New System.Drawing.Size(13, 13)
        Me.lblRet.TabIndex = 5
        Me.lblRet.Text = "1"
        Me.lblRet.Visible = False
        '
        'ButtonEx2
        '
        Me.ButtonEx2.CommandLink = True
        Me.ButtonEx2.CommandLinkNote = Nothing
        Me.ButtonEx2.Location = New System.Drawing.Point(12, 179)
        Me.ButtonEx2.Name = "ButtonEx2"
        Me.ButtonEx2.Size = New System.Drawing.Size(273, 41)
        Me.ButtonEx2.TabIndex = 1
        Me.ButtonEx2.Text = "Skip files"
        Me.ButtonEx2.UseVisualStyleBackColor = True
        '
        'ButtonEx1
        '
        Me.ButtonEx1.CommandLink = True
        Me.ButtonEx1.CommandLinkNote = "Close firefox and scan for files"
        Me.ButtonEx1.Location = New System.Drawing.Point(12, 109)
        Me.ButtonEx1.Name = "ButtonEx1"
        Me.ButtonEx1.Size = New System.Drawing.Size(273, 64)
        Me.ButtonEx1.TabIndex = 0
        Me.ButtonEx1.Text = "Close program"
        Me.ButtonEx1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MessageBoxEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(297, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSubMess)
        Me.Controls.Add(Me.lblMessToDis)
        Me.Controls.Add(Me.ButtonEx2)
        Me.Controls.Add(Me.ButtonEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBoxEx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEx1 As Sys_Optimizer_1._0.ButtonEx
    Friend WithEvents ButtonEx2 As Sys_Optimizer_1._0.ButtonEx
    Friend WithEvents lblMessToDis As System.Windows.Forms.Label
    Friend WithEvents lblSubMess As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRet As System.Windows.Forms.Label
End Class
