<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysSplash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrloadanimationrev = New System.Windows.Forms.Timer(Me.components)
        Me.tmrloadanimation = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lod1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.t2 = New System.Windows.Forms.PictureBox()
        Me.t3 = New System.Windows.Forms.PictureBox()
        Me.t4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lod1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sys Optimizer"
        '
        'tmrloadanimationrev
        '
        Me.tmrloadanimationrev.Interval = 300
        '
        'tmrloadanimation
        '
        Me.tmrloadanimation.Interval = 300
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(0, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 33)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Loosening some knots and tying some..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Arvin Soft"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(31, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'lod1
        '
        Me.lod1.BackColor = System.Drawing.Color.LightCoral
        Me.lod1.Location = New System.Drawing.Point(301, 175)
        Me.lod1.Name = "lod1"
        Me.lod1.Size = New System.Drawing.Size(10, 10)
        Me.lod1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.lod1.TabIndex = 67
        Me.lod1.TabStop = False
        Me.lod1.Visible = False
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.Color.LimeGreen
        Me.t2.Location = New System.Drawing.Point(315, 175)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(10, 10)
        Me.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.t2.TabIndex = 71
        Me.t2.TabStop = False
        '
        't3
        '
        Me.t3.BackColor = System.Drawing.Color.DodgerBlue
        Me.t3.Location = New System.Drawing.Point(301, 189)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(10, 10)
        Me.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.t3.TabIndex = 72
        Me.t3.TabStop = False
        '
        't4
        '
        Me.t4.BackColor = System.Drawing.Color.Gold
        Me.t4.Location = New System.Drawing.Point(315, 189)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(10, 10)
        Me.t4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.t4.TabIndex = 73
        Me.t4.TabStop = False
        '
        'SysSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(332, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.lod1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lod1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrloadanimationrev As System.Windows.Forms.Timer
    Friend WithEvents tmrloadanimation As System.Windows.Forms.Timer
    Friend WithEvents lod1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t4 As PictureBox
    Friend WithEvents t3 As PictureBox
    Friend WithEvents t2 As PictureBox
End Class
