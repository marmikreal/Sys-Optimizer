<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crash_Box
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crash_Box))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnCloseProgram = New System.Windows.Forms.Button()
        Me.panIntFls = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RTBTechInfoAndPara = New System.Windows.Forms.RichTextBox()
        Me.panIntFls.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 113)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(532, 186)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(479, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 70)
        Me.Panel2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(457, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Contact Us"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Software Crashed"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 43)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Aw ! Something happened. I am not supposed to crash like this please send the rep" &
    "ort to my developers so that they can work on the fix."
        '
        'bttnCloseProgram
        '
        Me.bttnCloseProgram.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.bttnCloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnCloseProgram.ForeColor = System.Drawing.Color.DimGray
        Me.bttnCloseProgram.Location = New System.Drawing.Point(263, 386)
        Me.bttnCloseProgram.Name = "bttnCloseProgram"
        Me.bttnCloseProgram.Size = New System.Drawing.Size(88, 23)
        Me.bttnCloseProgram.TabIndex = 13
        Me.bttnCloseProgram.Text = "Close program"
        Me.bttnCloseProgram.UseVisualStyleBackColor = True
        '
        'panIntFls
        '
        Me.panIntFls.BackColor = System.Drawing.Color.White
        Me.panIntFls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panIntFls.Controls.Add(Me.Button3)
        Me.panIntFls.Controls.Add(Me.Button2)
        Me.panIntFls.Controls.Add(Me.Button1)
        Me.panIntFls.Controls.Add(Me.bttnCloseProgram)
        Me.panIntFls.Controls.Add(Me.Panel2)
        Me.panIntFls.Controls.Add(Me.Panel3)
        Me.panIntFls.Controls.Add(Me.Panel1)
        Me.panIntFls.Controls.Add(Me.Label2)
        Me.panIntFls.Controls.Add(Me.RichTextBox1)
        Me.panIntFls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panIntFls.Location = New System.Drawing.Point(0, 0)
        Me.panIntFls.Name = "panIntFls"
        Me.panIntFls.Size = New System.Drawing.Size(558, 426)
        Me.panIntFls.TabIndex = 85
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(169, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Debug Info"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(359, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Ignore"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tomato
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 31)
        Me.Panel3.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(435, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0.9.x/1.0/2.0.x/3.0.x B3434"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tomato
        Me.Panel1.Location = New System.Drawing.Point(-1, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 10)
        Me.Panel1.TabIndex = 14
        '
        'RTBTechInfoAndPara
        '
        Me.RTBTechInfoAndPara.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RTBTechInfoAndPara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBTechInfoAndPara.Location = New System.Drawing.Point(13, 305)
        Me.RTBTechInfoAndPara.Name = "RTBTechInfoAndPara"
        Me.RTBTechInfoAndPara.Size = New System.Drawing.Size(532, 76)
        Me.RTBTechInfoAndPara.TabIndex = 86
        Me.RTBTechInfoAndPara.Text = ""
        '
        'Crash_Box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(558, 426)
        Me.Controls.Add(Me.RTBTechInfoAndPara)
        Me.Controls.Add(Me.panIntFls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crash_Box"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crash_Box"
        Me.TopMost = True
        Me.panIntFls.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bttnCloseProgram As System.Windows.Forms.Button
    Friend WithEvents panIntFls As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RTBTechInfoAndPara As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
