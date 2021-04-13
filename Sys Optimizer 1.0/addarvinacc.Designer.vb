<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addarvinacc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addarvinacc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBxPass = New System.Windows.Forms.TextBox()
        Me.txtBxUsrNm = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add account"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(304, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBxPass
        '
        Me.txtBxPass.BackColor = System.Drawing.Color.White
        Me.txtBxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPass.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPass.Location = New System.Drawing.Point(25, 216)
        Me.txtBxPass.Name = "txtBxPass"
        Me.txtBxPass.Size = New System.Drawing.Size(344, 20)
        Me.txtBxPass.TabIndex = 8
        Me.txtBxPass.UseSystemPasswordChar = True
        '
        'txtBxUsrNm
        '
        Me.txtBxUsrNm.BackColor = System.Drawing.Color.White
        Me.txtBxUsrNm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUsrNm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUsrNm.Location = New System.Drawing.Point(25, 149)
        Me.txtBxUsrNm.Name = "txtBxUsrNm"
        Me.txtBxUsrNm.Size = New System.Drawing.Size(351, 20)
        Me.txtBxUsrNm.TabIndex = 7
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(23, 186)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 19)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Password"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(23, 122)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 19)
        Me.Label40.TabIndex = 5
        Me.Label40.Text = "UserName"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(24, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(25, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 25)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Skip"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(496, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.OliveDrab
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(409, 85)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Successfully logged in"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(25, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(358, 30)
        Me.Button5.TabIndex = 16
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(25, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(358, 30)
        Me.Button6.TabIndex = 17
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 38)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Please note that by Registering to Arvin Soft, you are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "accepting Arvin Soft's P" &
    "rivacy Policy"
        '
        'addarvinacc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBxPass)
        Me.Controls.Add(Me.txtBxUsrNm)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "addarvinacc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBxPass As TextBox
    Friend WithEvents txtBxUsrNm As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
End Class
