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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the Picture of a Number to Display the Word of that Number!"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(291, 309)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(172, 13)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "                                                       "
        '
        'picOne
        '
        Me.picOne.Image = CType(resources.GetObject("picOne.Image"), System.Drawing.Image)
        Me.picOne.Location = New System.Drawing.Point(12, 113)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(84, 146)
        Me.picOne.TabIndex = 2
        Me.picOne.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(148, 113)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(83, 146)
        Me.picTwo.TabIndex = 3
        Me.picTwo.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = CType(resources.GetObject("picThree.Image"), System.Drawing.Image)
        Me.picThree.Location = New System.Drawing.Point(294, 113)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(80, 149)
        Me.picThree.TabIndex = 4
        Me.picThree.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = CType(resources.GetObject("picFour.Image"), System.Drawing.Image)
        Me.picFour.Location = New System.Drawing.Point(451, 113)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(83, 146)
        Me.picFour.TabIndex = 5
        Me.picFour.TabStop = False
        '
        'picFive
        '
        Me.picFive.Image = CType(resources.GetObject("picFive.Image"), System.Drawing.Image)
        Me.picFive.Location = New System.Drawing.Point(611, 113)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(83, 146)
        Me.picFive.TabIndex = 6
        Me.picFive.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 360)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ClickableNumbersForm"
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picFive As PictureBox
End Class
