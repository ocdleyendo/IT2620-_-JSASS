﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.lblPunchline = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.Location = New System.Drawing.Point(249, 138)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(0, 13)
        Me.lblSetup.TabIndex = 0
        '
        'lblPunchline
        '
        Me.lblPunchline.AutoSize = True
        Me.lblPunchline.Location = New System.Drawing.Point(249, 218)
        Me.lblPunchline.Name = "lblPunchline"
        Me.lblPunchline.Size = New System.Drawing.Size(0, 13)
        Me.lblPunchline.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Setup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Punchline"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 335)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPunchline)
        Me.Controls.Add(Me.lblSetup)
        Me.Name = "Form1"
        Me.Text = "Joke And Pinch Line Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSetup As Label
    Friend WithEvents lblPunchline As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
