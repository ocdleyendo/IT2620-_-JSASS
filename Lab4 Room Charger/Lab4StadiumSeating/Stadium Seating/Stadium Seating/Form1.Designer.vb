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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClassCQuantity = New System.Windows.Forms.TextBox()
        Me.txtClassBQuantity = New System.Windows.Forms.TextBox()
        Me.txtClassAQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblClassCRevenue = New System.Windows.Forms.Label()
        Me.lblClassBRevenue = New System.Windows.Forms.Label()
        Me.lblClassARevenue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassCQuantity)
        Me.GroupBox1.Controls.Add(Me.txtClassBQuantity)
        Me.GroupBox1.Controls.Add(Me.txtClassAQuantity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNumberOfTickets)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtClassCQuantity
        '
        Me.txtClassCQuantity.Location = New System.Drawing.Point(171, 148)
        Me.txtClassCQuantity.Name = "txtClassCQuantity"
        Me.txtClassCQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtClassCQuantity.TabIndex = 12
        '
        'txtClassBQuantity
        '
        Me.txtClassBQuantity.Location = New System.Drawing.Point(171, 107)
        Me.txtClassBQuantity.Name = "txtClassBQuantity"
        Me.txtClassBQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtClassBQuantity.TabIndex = 11
        '
        'txtClassAQuantity
        '
        Me.txtClassAQuantity.Location = New System.Drawing.Point(171, 69)
        Me.txtClassAQuantity.Name = "txtClassAQuantity"
        Me.txtClassAQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtClassAQuantity.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Class C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Class B:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class A:"
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(57, 31)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(164, 40)
        Me.lblNumberOfTickets.TabIndex = 0
        Me.lblNumberOfTickets.Text = "Enter the number of tickets sold for each clas of seats"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassCRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassBRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassARevenue)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 249)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(152, 195)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(104, 22)
        Me.lblTotalRevenue.TabIndex = 9
        '
        'lblClassCRevenue
        '
        Me.lblClassCRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassCRevenue.Location = New System.Drawing.Point(152, 150)
        Me.lblClassCRevenue.Name = "lblClassCRevenue"
        Me.lblClassCRevenue.Size = New System.Drawing.Size(104, 22)
        Me.lblClassCRevenue.TabIndex = 8
        '
        'lblClassBRevenue
        '
        Me.lblClassBRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassBRevenue.Location = New System.Drawing.Point(152, 110)
        Me.lblClassBRevenue.Name = "lblClassBRevenue"
        Me.lblClassBRevenue.Size = New System.Drawing.Size(104, 24)
        Me.lblClassBRevenue.TabIndex = 7
        '
        'lblClassARevenue
        '
        Me.lblClassARevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassARevenue.Location = New System.Drawing.Point(152, 71)
        Me.lblClassARevenue.Name = "lblClassARevenue"
        Me.lblClassARevenue.Size = New System.Drawing.Size(104, 22)
        Me.lblClassARevenue.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Revenue:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Class C:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Class B:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Class A:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "C&alculate Revenue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(324, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Clea&r"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 324)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 34)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "E&xit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 480)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtClassAQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblClassCRevenue As Label
    Friend WithEvents lblClassBRevenue As Label
    Friend WithEvents lblClassARevenue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtClassCQuantity As TextBox
    Friend WithEvents txtClassBQuantity As TextBox
End Class
