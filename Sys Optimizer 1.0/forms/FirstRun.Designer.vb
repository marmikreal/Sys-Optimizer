<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstRun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstRun))
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.tmrFrstRnTbs = New System.Windows.Forms.Timer(Me.components)
        Me.panSettings = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkSoftTemp = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkSysFls = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.chkInt = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.panHi = New System.Windows.Forms.Panel()
        Me.lblHi = New System.Windows.Forms.Label()
        Me.tmrEnable = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panSettings.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panHi.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.White
        Me.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.Black
        Me.bttnClose.Location = New System.Drawing.Point(331, 428)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(66, 27)
        Me.bttnClose.TabIndex = 7
        Me.bttnClose.Text = "Save"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'tmrFrstRnTbs
        '
        Me.tmrFrstRnTbs.Enabled = True
        Me.tmrFrstRnTbs.Interval = 1000
        '
        'panSettings
        '
        Me.panSettings.BackColor = System.Drawing.Color.Transparent
        Me.panSettings.Controls.Add(Me.Label6)
        Me.panSettings.Controls.Add(Me.chkSoftTemp)
        Me.panSettings.Controls.Add(Me.Label7)
        Me.panSettings.Controls.Add(Me.PictureBox3)
        Me.panSettings.Controls.Add(Me.Label9)
        Me.panSettings.Controls.Add(Me.chkSysFls)
        Me.panSettings.Controls.Add(Me.PictureBox4)
        Me.panSettings.Controls.Add(Me.chkInt)
        Me.panSettings.Controls.Add(Me.PictureBox5)
        Me.panSettings.ForeColor = System.Drawing.Color.White
        Me.panSettings.Location = New System.Drawing.Point(4, 167)
        Me.panSettings.Name = "panSettings"
        Me.panSettings.Size = New System.Drawing.Size(403, 218)
        Me.panSettings.TabIndex = 85
        Me.panSettings.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Software Temp Files"
        '
        'chkSoftTemp
        '
        Me.chkSoftTemp.AutoSize = True
        Me.chkSoftTemp.Checked = True
        Me.chkSoftTemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoftTemp.Location = New System.Drawing.Point(30, 166)
        Me.chkSoftTemp.Name = "chkSoftTemp"
        Me.chkSoftTemp.Size = New System.Drawing.Size(15, 14)
        Me.chkSoftTemp.TabIndex = 19
        Me.chkSoftTemp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "System Files"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(54, 155)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Internet Browsers"
        '
        'chkSysFls
        '
        Me.chkSysFls.AutoSize = True
        Me.chkSysFls.Checked = True
        Me.chkSysFls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSysFls.Location = New System.Drawing.Point(30, 100)
        Me.chkSysFls.Name = "chkSysFls"
        Me.chkSysFls.Size = New System.Drawing.Size(15, 14)
        Me.chkSysFls.TabIndex = 3
        Me.chkSysFls.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(54, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'chkInt
        '
        Me.chkInt.AutoSize = True
        Me.chkInt.Checked = True
        Me.chkInt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInt.Location = New System.Drawing.Point(30, 34)
        Me.chkInt.Name = "chkInt"
        Me.chkInt.Size = New System.Drawing.Size(15, 14)
        Me.chkInt.TabIndex = 2
        Me.chkInt.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(52, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.ForeColor = System.Drawing.Color.White
        Me.lblSave.Location = New System.Drawing.Point(268, 435)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(52, 15)
        Me.lblSave.TabIndex = 86
        Me.lblSave.Text = "Saving..."
        Me.lblSave.Visible = False
        '
        'panHi
        '
        Me.panHi.BackColor = System.Drawing.Color.White
        Me.panHi.Controls.Add(Me.lblHi)
        Me.panHi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panHi.Location = New System.Drawing.Point(0, 0)
        Me.panHi.Name = "panHi"
        Me.panHi.Size = New System.Drawing.Size(409, 467)
        Me.panHi.TabIndex = 87
        '
        'lblHi
        '
        Me.lblHi.AutoSize = True
        Me.lblHi.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHi.Location = New System.Drawing.Point(176, 215)
        Me.lblHi.Name = "lblHi"
        Me.lblHi.Size = New System.Drawing.Size(56, 36)
        Me.lblHi.TabIndex = 0
        Me.lblHi.Text = "Hi !"
        '
        'tmrEnable
        '
        Me.tmrEnable.Enabled = True
        Me.tmrEnable.Interval = 2000
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Automatic", "Manual"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 23)
        Me.ComboBox1.TabIndex = 89
        Me.ComboBox1.Text = "Automatic"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 19)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Choose which is best"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 224)
        Me.Panel1.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 70)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "In this configuration i can configure whatever files that are predefined in my se" &
    "arch index"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "First Run"
        '
        'FirstRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.panHi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panSettings)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirstRun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.panSettings.ResumeLayout(False)
        Me.panSettings.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panHi.ResumeLayout(False)
        Me.panHi.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents tmrFrstRnTbs As System.Windows.Forms.Timer
    Friend WithEvents panSettings As System.Windows.Forms.Panel
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents panHi As System.Windows.Forms.Panel
    Friend WithEvents lblHi As System.Windows.Forms.Label
    Friend WithEvents tmrEnable As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkSoftTemp As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkSysFls As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents chkInt As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As Label
End Class
