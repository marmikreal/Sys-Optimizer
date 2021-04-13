<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProcess
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.opnDlg = New System.Windows.Forms.OpenFileDialog()
        Me.panPass = New System.Windows.Forms.Panel()
        Me.lblcheck = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.bttnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstRunPro = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bttnBrowForPro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProc = New System.Windows.Forms.TextBox()
        Me.bttnProcAdd = New System.Windows.Forms.Button()
        Me.panPass.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add process from the running process or browse for the filename" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To select from" & _
            " the running process click the process and click the add button"
        '
        'opnDlg
        '
        Me.opnDlg.Filter = "Executable files(*.exe)|*.exe"
        '
        'panPass
        '
        Me.panPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panPass.Controls.Add(Me.lblcheck)
        Me.panPass.Controls.Add(Me.Label20)
        Me.panPass.Controls.Add(Me.Button2)
        Me.panPass.Controls.Add(Me.MaskedTextBox2)
        Me.panPass.Location = New System.Drawing.Point(102, 125)
        Me.panPass.Name = "panPass"
        Me.panPass.Size = New System.Drawing.Size(361, 100)
        Me.panPass.TabIndex = 88
        Me.panPass.Visible = False
        '
        'lblcheck
        '
        Me.lblcheck.AutoSize = True
        Me.lblcheck.Location = New System.Drawing.Point(243, 9)
        Me.lblcheck.Name = "lblcheck"
        Me.lblcheck.Size = New System.Drawing.Size(13, 13)
        Me.lblcheck.TabIndex = 81
        Me.lblcheck.Text = "0"
        Me.lblcheck.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Password"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(246, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(14, 43)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaskedTextBox2.Size = New System.Drawing.Size(216, 20)
        Me.MaskedTextBox2.TabIndex = 0
        '
        'bttnCancel
        '
        Me.bttnCancel.BackColor = System.Drawing.Color.White
        Me.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnCancel.Location = New System.Drawing.Point(470, 354)
        Me.bttnCancel.Name = "bttnCancel"
        Me.bttnCancel.Size = New System.Drawing.Size(75, 23)
        Me.bttnCancel.TabIndex = 86
        Me.bttnCancel.Text = "Cancel"
        Me.bttnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lstRunPro)
        Me.Panel1.Location = New System.Drawing.Point(9, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 170)
        Me.Panel1.TabIndex = 5
        '
        'lstRunPro
        '
        Me.lstRunPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRunPro.FormattingEnabled = True
        Me.lstRunPro.Location = New System.Drawing.Point(0, 0)
        Me.lstRunPro.Name = "lstRunPro"
        Me.lstRunPro.Size = New System.Drawing.Size(526, 170)
        Me.lstRunPro.Sorted = True
        Me.lstRunPro.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.bttnBrowForPro)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtProc)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(541, 317)
        Me.Panel2.TabIndex = 87
        '
        'bttnBrowForPro
        '
        Me.bttnBrowForPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnBrowForPro.Location = New System.Drawing.Point(460, 271)
        Me.bttnBrowForPro.Name = "bttnBrowForPro"
        Me.bttnBrowForPro.Size = New System.Drawing.Size(75, 23)
        Me.bttnBrowForPro.TabIndex = 9
        Me.bttnBrowForPro.Text = "Browse"
        Me.bttnBrowForPro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "OR"
        '
        'txtProc
        '
        Me.txtProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProc.Location = New System.Drawing.Point(9, 272)
        Me.txtProc.Name = "txtProc"
        Me.txtProc.Size = New System.Drawing.Size(445, 22)
        Me.txtProc.TabIndex = 7
        '
        'bttnProcAdd
        '
        Me.bttnProcAdd.BackColor = System.Drawing.Color.White
        Me.bttnProcAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnProcAdd.Location = New System.Drawing.Point(389, 354)
        Me.bttnProcAdd.Name = "bttnProcAdd"
        Me.bttnProcAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnProcAdd.TabIndex = 85
        Me.bttnProcAdd.Text = "Add"
        Me.bttnProcAdd.UseVisualStyleBackColor = False
        '
        'AddProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 391)
        Me.Controls.Add(Me.panPass)
        Me.Controls.Add(Me.bttnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bttnProcAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProcess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Process"
        Me.panPass.ResumeLayout(False)
        Me.panPass.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents opnDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents panPass As System.Windows.Forms.Panel
    Friend WithEvents lblcheck As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents bttnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstRunPro As System.Windows.Forms.ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bttnBrowForPro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProc As System.Windows.Forms.TextBox
    Friend WithEvents bttnProcAdd As System.Windows.Forms.Button
End Class
