<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkDinnerKeynote = New System.Windows.Forms.CheckBox()
        Me.chkConfReg = New System.Windows.Forms.CheckBox()
        Me.btnResetFormOptions = New System.Windows.Forms.Button()
        Me.btnExitFormOpt = New System.Windows.Forms.Button()
        Me.lstOptions = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "$30"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "$895"
        '
        'chkDinnerKeynote
        '
        Me.chkDinnerKeynote.AutoSize = True
        Me.chkDinnerKeynote.Location = New System.Drawing.Point(22, 70)
        Me.chkDinnerKeynote.Name = "chkDinnerKeynote"
        Me.chkDinnerKeynote.Size = New System.Drawing.Size(173, 17)
        Me.chkDinnerKeynote.TabIndex = 2
        Me.chkDinnerKeynote.Text = "Opening Night Dinner & Keynote"
        Me.chkDinnerKeynote.UseVisualStyleBackColor = True
        '
        'chkConfReg
        '
        Me.chkConfReg.AutoSize = True
        Me.chkConfReg.Location = New System.Drawing.Point(22, 29)
        Me.chkConfReg.Name = "chkConfReg"
        Me.chkConfReg.Size = New System.Drawing.Size(140, 17)
        Me.chkConfReg.TabIndex = 3
        Me.chkConfReg.Text = "Conference Registration"
        Me.chkConfReg.UseVisualStyleBackColor = True
        '
        'btnResetFormOptions
        '
        Me.btnResetFormOptions.Location = New System.Drawing.Point(349, 302)
        Me.btnResetFormOptions.Name = "btnResetFormOptions"
        Me.btnResetFormOptions.Size = New System.Drawing.Size(93, 32)
        Me.btnResetFormOptions.TabIndex = 4
        Me.btnResetFormOptions.Text = "Reset"
        Me.btnResetFormOptions.UseVisualStyleBackColor = True
        '
        'btnExitFormOpt
        '
        Me.btnExitFormOpt.Location = New System.Drawing.Point(512, 302)
        Me.btnExitFormOpt.Name = "btnExitFormOpt"
        Me.btnExitFormOpt.Size = New System.Drawing.Size(81, 32)
        Me.btnExitFormOpt.TabIndex = 5
        Me.btnExitFormOpt.Text = "Exit"
        Me.btnExitFormOpt.UseVisualStyleBackColor = True
        '
        'lstOptions
        '
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.Items.AddRange(New Object() {"Intro to E-Commerce $295", "The future of the web" & Global.Microsoft.VisualBasic.ChrW(9) & "$295", "Advanced Visual Basic " & Global.Microsoft.VisualBasic.ChrW(9) & "$395", "Network Security" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$395"})
        Me.lstOptions.Location = New System.Drawing.Point(22, 57)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(264, 82)
        Me.lstOptions.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkConfReg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkDinnerKeynote)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(268, 177)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conference"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstOptions)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 165)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preconference Workshops"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select One"
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 387)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExitFormOpt)
        Me.Controls.Add(Me.btnResetFormOptions)
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conference Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkDinnerKeynote As CheckBox
    Friend WithEvents chkConfReg As CheckBox
    Friend WithEvents btnResetFormOptions As Button
    Friend WithEvents btnExitFormOpt As Button
    Friend WithEvents lstOptions As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
End Class
