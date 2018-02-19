<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInputB = New System.Windows.Forms.TextBox()
        Me.txtInputA = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblComparisonResults = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Two Integers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "B:"
        '
        'txtInputB
        '
        Me.txtInputB.Location = New System.Drawing.Point(360, 117)
        Me.txtInputB.Name = "txtInputB"
        Me.txtInputB.Size = New System.Drawing.Size(100, 20)
        Me.txtInputB.TabIndex = 1
        '
        'txtInputA
        '
        Me.txtInputA.Location = New System.Drawing.Point(121, 117)
        Me.txtInputA.Name = "txtInputA"
        Me.txtInputA.Size = New System.Drawing.Size(100, 20)
        Me.txtInputA.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(371, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Compare"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblComparisonResults
        '
        Me.lblComparisonResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComparisonResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComparisonResults.Location = New System.Drawing.Point(121, 190)
        Me.lblComparisonResults.Name = "lblComparisonResults"
        Me.lblComparisonResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblComparisonResults.Size = New System.Drawing.Size(339, 28)
        Me.lblComparisonResults.TabIndex = 7
        Me.lblComparisonResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Location = New System.Drawing.Point(130, 159)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorMessage.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "C&lear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 500)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.lblComparisonResults)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtInputA)
        Me.Controls.Add(Me.txtInputB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInputB As TextBox
    Friend WithEvents txtInputA As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblComparisonResults As Label
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents Button3 As Button
End Class
