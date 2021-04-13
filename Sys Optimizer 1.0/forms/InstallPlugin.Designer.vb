<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallPlugin
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bttnOpen = New System.Windows.Forms.Button()
        Me.txtPlgInPth = New System.Windows.Forms.TextBox()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.opnDlg = New System.Windows.Forms.OpenFileDialog()
        Me.OpFlDlgPlg = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(172, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Install Module"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bttnOpen
        '
        Me.bttnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnOpen.Location = New System.Drawing.Point(319, 67)
        Me.bttnOpen.Name = "bttnOpen"
        Me.bttnOpen.Size = New System.Drawing.Size(89, 23)
        Me.bttnOpen.TabIndex = 4
        Me.bttnOpen.Text = "Browse"
        Me.bttnOpen.UseVisualStyleBackColor = True
        '
        'txtPlgInPth
        '
        Me.txtPlgInPth.Location = New System.Drawing.Point(58, 70)
        Me.txtPlgInPth.Name = "txtPlgInPth"
        Me.txtPlgInPth.Size = New System.Drawing.Size(235, 20)
        Me.txtPlgInPth.TabIndex = 3
        '
        'bttnClose
        '
        Me.bttnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.Black
        Me.bttnClose.Location = New System.Drawing.Point(401, 2)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(35, 27)
        Me.bttnClose.TabIndex = 84
        Me.bttnClose.Text = "X"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(12, 9)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(107, 20)
        Me.lblSettings.TabIndex = 85
        Me.lblSettings.Text = "Install Module"
        '
        'opnDlg
        '
        Me.opnDlg.Filter = "Zip Files(*.zip)|*.zip"
        '
        'OpFlDlgPlg
        '
        Me.OpFlDlgPlg.Filter = "Executable files(*.exe)|*.exe"
        '
        'InstallPlugin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bttnOpen)
        Me.Controls.Add(Me.txtPlgInPth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InstallPlugin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bttnOpen As System.Windows.Forms.Button
    Friend WithEvents txtPlgInPth As System.Windows.Forms.TextBox
    Friend WithEvents bttnClose As System.Windows.Forms.Button
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents opnDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpFlDlgPlg As System.Windows.Forms.OpenFileDialog
End Class
