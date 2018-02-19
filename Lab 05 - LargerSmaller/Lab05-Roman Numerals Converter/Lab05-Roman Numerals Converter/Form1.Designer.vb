<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RomanNumeralConverter
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEnterDecimal = New System.Windows.Forms.Label()
        Me.txtInputNumber = New System.Windows.Forms.TextBox()
        Me.lblRomanNumeral = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(115, 124)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(226, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Equivalent Roman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                Numeral:  "
        '
        'lblEnterDecimal
        '
        Me.lblEnterDecimal.AutoSize = True
        Me.lblEnterDecimal.Location = New System.Drawing.Point(94, 6)
        Me.lblEnterDecimal.Name = "lblEnterDecimal"
        Me.lblEnterDecimal.Size = New System.Drawing.Size(120, 26)
        Me.lblEnterDecimal.TabIndex = 3
        Me.lblEnterDecimal.Text = "Enter a decimal integer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         in the range 1 -10:"
        '
        'txtInputNumber
        '
        Me.txtInputNumber.Location = New System.Drawing.Point(223, 6)
        Me.txtInputNumber.Name = "txtInputNumber"
        Me.txtInputNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInputNumber.TabIndex = 4
        '
        'lblRomanNumeral
        '
        Me.lblRomanNumeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRomanNumeral.Location = New System.Drawing.Point(223, 55)
        Me.lblRomanNumeral.Name = "lblRomanNumeral"
        Me.lblRomanNumeral.Size = New System.Drawing.Size(100, 23)
        Me.lblRomanNumeral.TabIndex = 5
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(175, 96)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 6
        '
        'RomanNumeralConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 225)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblRomanNumeral)
        Me.Controls.Add(Me.txtInputNumber)
        Me.Controls.Add(Me.lblEnterDecimal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "RomanNumeralConverter"
        Me.Text = "RomanNumeralConverterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEnterDecimal As Label
    Friend WithEvents txtInputNumber As TextBox
    Friend WithEvents lblRomanNumeral As Label
    Friend WithEvents lblMessage As Label
End Class
