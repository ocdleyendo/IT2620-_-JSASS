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
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.btnGetRetailPrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMarkupPercentage = New System.Windows.Forms.TextBox()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wholesale Cost of Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Markup %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Retail Price"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailPrice.Location = New System.Drawing.Point(180, 113)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblRetailPrice.TabIndex = 3
        '
        'btnGetRetailPrice
        '
        Me.btnGetRetailPrice.Location = New System.Drawing.Point(55, 188)
        Me.btnGetRetailPrice.Name = "btnGetRetailPrice"
        Me.btnGetRetailPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRetailPrice.TabIndex = 4
        Me.btnGetRetailPrice.Text = "Get Retail"
        Me.btnGetRetailPrice.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 188)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtMarkupPercentage
        '
        Me.txtMarkupPercentage.Location = New System.Drawing.Point(180, 64)
        Me.txtMarkupPercentage.Name = "txtMarkupPercentage"
        Me.txtMarkupPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkupPercentage.TabIndex = 6
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.Location = New System.Drawing.Point(180, 24)
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(100, 20)
        Me.txtWholesaleCost.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 270)
        Me.Controls.Add(Me.txtWholesaleCost)
        Me.Controls.Add(Me.txtMarkupPercentage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetailPrice)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRetailPrice As Label
    Friend WithEvents btnGetRetailPrice As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMarkupPercentage As TextBox
    Friend WithEvents txtWholesaleCost As TextBox
End Class
