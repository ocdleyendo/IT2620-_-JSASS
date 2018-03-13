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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtConferenceSeminar = New System.Windows.Forms.TextBox()
        Me.txtCarRentalFees = New System.Windows.Forms.TextBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtParkingFees = New System.Windows.Forms.TextBox()
        Me.txtTaxiFare = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblAmountSaved = New System.Windows.Forms.Label()
        Me.lblUnallowed = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAllowableExpenses = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMealCosts = New System.Windows.Forms.TextBox()
        Me.txtAirfareCost = New System.Windows.Forms.TextBox()
        Me.txtLodgingChargeNight = New System.Windows.Forms.TextBox()
        Me.txtDaysOfStay = New System.Windows.Forms.TextBox()
        Me.lblMealReimbursement = New System.Windows.Forms.Label()
        Me.lblParkingFeesReimburse = New System.Windows.Forms.Label()
        Me.lblTaxiFeesReimbursement = New System.Windows.Forms.Label()
        Me.lblLodgingReimbursement = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMileageReimbursement = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtConferenceSeminar)
        Me.GroupBox3.Controls.Add(Me.txtCarRentalFees)
        Me.GroupBox3.Controls.Add(Me.txtMileage)
        Me.GroupBox3.Controls.Add(Me.txtParkingFees)
        Me.GroupBox3.Controls.Add(Me.txtTaxiFare)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(454, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(355, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'txtConferenceSeminar
        '
        Me.txtConferenceSeminar.Location = New System.Drawing.Point(213, 219)
        Me.txtConferenceSeminar.Name = "txtConferenceSeminar"
        Me.txtConferenceSeminar.Size = New System.Drawing.Size(100, 20)
        Me.txtConferenceSeminar.TabIndex = 19
        '
        'txtCarRentalFees
        '
        Me.txtCarRentalFees.Location = New System.Drawing.Point(213, 37)
        Me.txtCarRentalFees.Name = "txtCarRentalFees"
        Me.txtCarRentalFees.Size = New System.Drawing.Size(100, 20)
        Me.txtCarRentalFees.TabIndex = 18
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(213, 91)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(100, 20)
        Me.txtMileage.TabIndex = 17
        '
        'txtParkingFees
        '
        Me.txtParkingFees.Location = New System.Drawing.Point(213, 134)
        Me.txtParkingFees.Name = "txtParkingFees"
        Me.txtParkingFees.Size = New System.Drawing.Size(100, 20)
        Me.txtParkingFees.TabIndex = 16
        '
        'txtTaxiFare
        '
        Me.txtTaxiFare.Location = New System.Drawing.Point(213, 173)
        Me.txtTaxiFare.Name = "txtTaxiFare"
        Me.txtTaxiFare.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxiFare.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Car Rental Fees, if any"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Conference or Seminar fees"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Miles Driven in a private car"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Taxi Charges, if any"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Parking Fees, if any"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblAmountSaved)
        Me.GroupBox4.Controls.Add(Me.lblUnallowed)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblAllowableExpenses)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(53, 299)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(366, 184)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'lblAmountSaved
        '
        Me.lblAmountSaved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountSaved.Location = New System.Drawing.Point(191, 129)
        Me.lblAmountSaved.Name = "lblAmountSaved"
        Me.lblAmountSaved.Size = New System.Drawing.Size(93, 23)
        Me.lblAmountSaved.TabIndex = 16
        '
        'lblUnallowed
        '
        Me.lblUnallowed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnallowed.Location = New System.Drawing.Point(191, 85)
        Me.lblUnallowed.Name = "lblUnallowed"
        Me.lblUnallowed.Size = New System.Drawing.Size(93, 23)
        Me.lblUnallowed.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Amount to be paid by Employee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total Reimbursement"
        '
        'lblAllowableExpenses
        '
        Me.lblAllowableExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAllowableExpenses.Location = New System.Drawing.Point(190, 38)
        Me.lblAllowableExpenses.Name = "lblAllowableExpenses"
        Me.lblAllowableExpenses.Size = New System.Drawing.Size(93, 23)
        Me.lblAllowableExpenses.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount Saved"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Meal Costs Reimbursed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Days of Stay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Meal Costs, if any"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Airfare Costs, if any"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Lodging Charges per Night"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMealCosts)
        Me.GroupBox1.Controls.Add(Me.txtAirfareCost)
        Me.GroupBox1.Controls.Add(Me.txtLodgingChargeNight)
        Me.GroupBox1.Controls.Add(Me.txtDaysOfStay)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 239)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtMealCosts
        '
        Me.txtMealCosts.Location = New System.Drawing.Point(190, 176)
        Me.txtMealCosts.Name = "txtMealCosts"
        Me.txtMealCosts.Size = New System.Drawing.Size(100, 20)
        Me.txtMealCosts.TabIndex = 17
        '
        'txtAirfareCost
        '
        Me.txtAirfareCost.Location = New System.Drawing.Point(190, 130)
        Me.txtAirfareCost.Name = "txtAirfareCost"
        Me.txtAirfareCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAirfareCost.TabIndex = 16
        '
        'txtLodgingChargeNight
        '
        Me.txtLodgingChargeNight.Location = New System.Drawing.Point(190, 91)
        Me.txtLodgingChargeNight.Name = "txtLodgingChargeNight"
        Me.txtLodgingChargeNight.Size = New System.Drawing.Size(100, 20)
        Me.txtLodgingChargeNight.TabIndex = 15
        '
        'txtDaysOfStay
        '
        Me.txtDaysOfStay.Location = New System.Drawing.Point(191, 44)
        Me.txtDaysOfStay.Name = "txtDaysOfStay"
        Me.txtDaysOfStay.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysOfStay.TabIndex = 14
        '
        'lblMealReimbursement
        '
        Me.lblMealReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealReimbursement.Location = New System.Drawing.Point(192, 521)
        Me.lblMealReimbursement.Name = "lblMealReimbursement"
        Me.lblMealReimbursement.Size = New System.Drawing.Size(93, 23)
        Me.lblMealReimbursement.TabIndex = 16
        '
        'lblParkingFeesReimburse
        '
        Me.lblParkingFeesReimburse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParkingFeesReimburse.Location = New System.Drawing.Point(192, 570)
        Me.lblParkingFeesReimburse.Name = "lblParkingFeesReimburse"
        Me.lblParkingFeesReimburse.Size = New System.Drawing.Size(93, 23)
        Me.lblParkingFeesReimburse.TabIndex = 17
        '
        'lblTaxiFeesReimbursement
        '
        Me.lblTaxiFeesReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxiFeesReimbursement.Location = New System.Drawing.Point(474, 521)
        Me.lblTaxiFeesReimbursement.Name = "lblTaxiFeesReimbursement"
        Me.lblTaxiFeesReimbursement.Size = New System.Drawing.Size(93, 23)
        Me.lblTaxiFeesReimbursement.TabIndex = 18
        '
        'lblLodgingReimbursement
        '
        Me.lblLodgingReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLodgingReimbursement.Location = New System.Drawing.Point(474, 569)
        Me.lblLodgingReimbursement.Name = "lblLodgingReimbursement"
        Me.lblLodgingReimbursement.Size = New System.Drawing.Size(93, 23)
        Me.lblLodgingReimbursement.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(50, 579)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Parking Fees Reimbursed"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(351, 571)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Lodging Reimbursed"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(346, 522)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Taxi fees Reimbursed"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(474, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(183, 23)
        Me.btnCalculate.TabIndex = 23
        Me.btnCalculate.Text = "Calculcate Reimbursements"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(482, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(482, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMileageReimbursement
        '
        Me.lblMileageReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMileageReimbursement.Location = New System.Drawing.Point(737, 521)
        Me.lblMileageReimbursement.Name = "lblMileageReimbursement"
        Me.lblMileageReimbursement.Size = New System.Drawing.Size(93, 23)
        Me.lblMileageReimbursement.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(611, 522)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Mileage Reimbursement"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 622)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblMileageReimbursement)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblLodgingReimbursement)
        Me.Controls.Add(Me.lblTaxiFeesReimbursement)
        Me.Controls.Add(Me.lblParkingFeesReimburse)
        Me.Controls.Add(Me.lblMealReimbursement)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Form1"
        Me.Text = "Travel Expenses"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAllowableExpenses As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMealCosts As TextBox
    Friend WithEvents txtAirfareCost As TextBox
    Friend WithEvents txtLodgingChargeNight As TextBox
    Friend WithEvents txtDaysOfStay As TextBox
    Friend WithEvents txtConferenceSeminar As TextBox
    Friend WithEvents txtCarRentalFees As TextBox
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtParkingFees As TextBox
    Friend WithEvents txtTaxiFare As TextBox
    Friend WithEvents lblAmountSaved As Label
    Friend WithEvents lblUnallowed As Label
    Friend WithEvents lblMealReimbursement As Label
    Friend WithEvents lblTaxiFeesReimbursement As Label
    Friend WithEvents lblLodgingReimbursement As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblMileageReimbursement As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblParkingFeesReimburse As Label
End Class
