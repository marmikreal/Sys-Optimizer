<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassCheckLiveTuner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassCheckLiveTuner))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnCheckPass = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.MskInPuBxPass = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'bttnCheckPass
        '
        Me.bttnCheckPass.BackColor = System.Drawing.Color.White
        Me.bttnCheckPass.BackgroundImage = CType(resources.GetObject("bttnCheckPass.BackgroundImage"), System.Drawing.Image)
        Me.bttnCheckPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnCheckPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnCheckPass.Location = New System.Drawing.Point(257, 76)
        Me.bttnCheckPass.Name = "bttnCheckPass"
        Me.bttnCheckPass.Size = New System.Drawing.Size(75, 23)
        Me.bttnCheckPass.TabIndex = 2
        Me.bttnCheckPass.Text = "Submit"
        Me.bttnCheckPass.UseVisualStyleBackColor = False
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.White
        Me.bttnClose.BackgroundImage = CType(resources.GetObject("bttnClose.BackgroundImage"), System.Drawing.Image)
        Me.bttnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Location = New System.Drawing.Point(176, 76)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(75, 23)
        Me.bttnClose.TabIndex = 3
        Me.bttnClose.Text = "Close"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'MskInPuBxPass
        '
        Me.MskInPuBxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MskInPuBxPass.Location = New System.Drawing.Point(15, 39)
        Me.MskInPuBxPass.Name = "MskInPuBxPass"
        Me.MskInPuBxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MskInPuBxPass.Size = New System.Drawing.Size(317, 20)
        Me.MskInPuBxPass.TabIndex = 80
        Me.MskInPuBxPass.UseSystemPasswordChar = True
        '
        'PassCheckLiveTuner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 99)
        Me.ControlBox = False
        Me.Controls.Add(Me.MskInPuBxPass)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.bttnCheckPass)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(360, 115)
        Me.MinimumSize = New System.Drawing.Size(360, 115)
        Me.Name = "PassCheckLiveTuner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnCheckPass As System.Windows.Forms.Button
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents MskInPuBxPass As System.Windows.Forms.MaskedTextBox
End Class
