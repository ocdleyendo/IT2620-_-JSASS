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
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.lstYears = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMonths
        '
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(65, 12)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(133, 95)
        Me.lstMonths.TabIndex = 0
        '
        'lstYears
        '
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.lstYears.Location = New System.Drawing.Point(326, 12)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(124, 95)
        Me.lstYears.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(79, 157)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(326, 157)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 375)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lstYears)
        Me.Controls.Add(Me.lstMonths)
        Me.Name = "Form1"
        Me.Text = "List Box Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMonths As ListBox
    Friend WithEvents lstYears As ListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
End Class
