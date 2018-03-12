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
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConferenceSeminar = New System.Windows.Forms.TextBox()
        Me.txtDaysOfStay = New System.Windows.Forms.TextBox()
        Me.txtLodgingChargeNight = New System.Windows.Forms.TextBox()
        Me.txtMealCosts = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblparkingFees = New System.Windows.Forms.Label()
        Me.txtParkingFees = New System.Windows.Forms.TextBox()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtTaxiFare = New System.Windows.Forms.TextBox()
        Me.txtAirfareCost = New System.Windows.Forms.TextBox()
        Me.txtCarRentalFees = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblAmountSaved = New System.Windows.Forms.Label()
        Me.lblExcess = New System.Windows.Forms.Label()
        Me.lblAllowableExpenses = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMileageReimbursement = New System.Windows.Forms.Label()
        Me.lblParkingFeesReimburse = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMealReimbursement = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblLodgingReimbursement = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTaxiFeesReimbursement = New System.Windows.Forms.Label()
        Me.taxi = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(457, 287)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(104, 23)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate Totals"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(486, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Data"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(486, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Days"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Meals"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Airfare"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Car Rental Fees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mileage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Conference/Seminar"
        Me.Label6.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Lodging Charges/night"
        Me.Label7.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Taxi Fare"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConferenceSeminar)
        Me.GroupBox1.Controls.Add(Me.txtDaysOfStay)
        Me.GroupBox1.Controls.Add(Me.txtLodgingChargeNight)
        Me.GroupBox1.Controls.Add(Me.txtMealCosts)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 186)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room & Board Charges"
        Me.GroupBox1.UseWaitCursor = True
        '
        'txtConferenceSeminar
        '
        Me.txtConferenceSeminar.Location = New System.Drawing.Point(170, 151)
        Me.txtConferenceSeminar.Name = "txtConferenceSeminar"
        Me.txtConferenceSeminar.Size = New System.Drawing.Size(100, 20)
        Me.txtConferenceSeminar.TabIndex = 17
        Me.txtConferenceSeminar.UseWaitCursor = True
        '
        'txtDaysOfStay
        '
        Me.txtDaysOfStay.Location = New System.Drawing.Point(170, 32)
        Me.txtDaysOfStay.Name = "txtDaysOfStay"
        Me.txtDaysOfStay.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysOfStay.TabIndex = 12
        Me.txtDaysOfStay.UseWaitCursor = True
        '
        'txtLodgingChargeNight
        '
        Me.txtLodgingChargeNight.Location = New System.Drawing.Point(170, 70)
        Me.txtLodgingChargeNight.Name = "txtLodgingChargeNight"
        Me.txtLodgingChargeNight.Size = New System.Drawing.Size(100, 20)
        Me.txtLodgingChargeNight.TabIndex = 11
        Me.txtLodgingChargeNight.UseWaitCursor = True
        '
        'txtMealCosts
        '
        Me.txtMealCosts.Location = New System.Drawing.Point(170, 110)
        Me.txtMealCosts.Name = "txtMealCosts"
        Me.txtMealCosts.Size = New System.Drawing.Size(100, 20)
        Me.txtMealCosts.TabIndex = 10
        Me.txtMealCosts.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblparkingFees)
        Me.GroupBox2.Controls.Add(Me.txtParkingFees)
        Me.GroupBox2.Controls.Add(Me.txtMileage)
        Me.GroupBox2.Controls.Add(Me.txtTaxiFare)
        Me.GroupBox2.Controls.Add(Me.txtAirfareCost)
        Me.GroupBox2.Controls.Add(Me.txtCarRentalFees)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 236)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Airfare And  Vehicle Expenses"
        '
        'lblparkingFees
        '
        Me.lblparkingFees.AutoSize = True
        Me.lblparkingFees.Location = New System.Drawing.Point(100, 190)
        Me.lblparkingFees.Name = "lblparkingFees"
        Me.lblparkingFees.Size = New System.Drawing.Size(69, 13)
        Me.lblparkingFees.TabIndex = 19
        Me.lblparkingFees.Text = "Parking Fees"
        '
        'txtParkingFees
        '
        Me.txtParkingFees.Location = New System.Drawing.Point(200, 187)
        Me.txtParkingFees.Name = "txtParkingFees"
        Me.txtParkingFees.Size = New System.Drawing.Size(100, 20)
        Me.txtParkingFees.TabIndex = 18
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(200, 151)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(100, 20)
        Me.txtMileage.TabIndex = 16
        '
        'txtTaxiFare
        '
        Me.txtTaxiFare.Location = New System.Drawing.Point(200, 107)
        Me.txtTaxiFare.Name = "txtTaxiFare"
        Me.txtTaxiFare.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxiFare.TabIndex = 15
        '
        'txtAirfareCost
        '
        Me.txtAirfareCost.Location = New System.Drawing.Point(200, 25)
        Me.txtAirfareCost.Name = "txtAirfareCost"
        Me.txtAirfareCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAirfareCost.TabIndex = 14
        '
        'txtCarRentalFees
        '
        Me.txtCarRentalFees.Location = New System.Drawing.Point(200, 63)
        Me.txtCarRentalFees.Name = "txtCarRentalFees"
        Me.txtCarRentalFees.Size = New System.Drawing.Size(100, 20)
        Me.txtCarRentalFees.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAmountSaved)
        Me.GroupBox3.Controls.Add(Me.lblExcess)
        Me.GroupBox3.Controls.Add(Me.lblAllowableExpenses)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 250)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 175)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sum of Expenses"
        '
        'lblAmountSaved
        '
        Me.lblAmountSaved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountSaved.Location = New System.Drawing.Point(188, 126)
        Me.lblAmountSaved.Name = "lblAmountSaved"
        Me.lblAmountSaved.Size = New System.Drawing.Size(82, 23)
        Me.lblAmountSaved.TabIndex = 5
        '
        'lblExcess
        '
        Me.lblExcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExcess.Location = New System.Drawing.Point(188, 81)
        Me.lblExcess.Name = "lblExcess"
        Me.lblExcess.Size = New System.Drawing.Size(82, 23)
        Me.lblExcess.TabIndex = 4
        '
        'lblAllowableExpenses
        '
        Me.lblAllowableExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAllowableExpenses.Location = New System.Drawing.Point(188, 41)
        Me.lblAllowableExpenses.Name = "lblAllowableExpenses"
        Me.lblAllowableExpenses.Size = New System.Drawing.Size(82, 23)
        Me.lblAllowableExpenses.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Amount Saved by Employee"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Excess to be paid by Employee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Allowable Expenses"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Mileage Reimbursement"
        '
        'lblMileageReimbursement
        '
        Me.lblMileageReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMileageReimbursement.Location = New System.Drawing.Point(169, 16)
        Me.lblMileageReimbursement.Name = "lblMileageReimbursement"
        Me.lblMileageReimbursement.Size = New System.Drawing.Size(82, 23)
        Me.lblMileageReimbursement.TabIndex = 15
        '
        'lblParkingFeesReimburse
        '
        Me.lblParkingFeesReimburse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParkingFeesReimburse.Location = New System.Drawing.Point(176, 74)
        Me.lblParkingFeesReimburse.Name = "lblParkingFeesReimburse"
        Me.lblParkingFeesReimburse.Size = New System.Drawing.Size(82, 23)
        Me.lblParkingFeesReimburse.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Parking Reimbursement"
        '
        'lblMealReimbursement
        '
        Me.lblMealReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealReimbursement.Location = New System.Drawing.Point(435, 26)
        Me.lblMealReimbursement.Name = "lblMealReimbursement"
        Me.lblMealReimbursement.Size = New System.Drawing.Size(82, 23)
        Me.lblMealReimbursement.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(306, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Meal Reimbursement"
        '
        'lblLodgingReimbursement
        '
        Me.lblLodgingReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLodgingReimbursement.Location = New System.Drawing.Point(435, 75)
        Me.lblLodgingReimbursement.Name = "lblLodgingReimbursement"
        Me.lblLodgingReimbursement.Size = New System.Drawing.Size(82, 23)
        Me.lblLodgingReimbursement.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(306, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "lodging reimbursement"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.taxi)
        Me.GroupBox4.Controls.Add(Me.lblTaxiFeesReimbursement)
        Me.GroupBox4.Controls.Add(Me.lblMileageReimbursement)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblLodgingReimbursement)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblMealReimbursement)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblParkingFeesReimburse)
        Me.GroupBox4.Location = New System.Drawing.Point(51, 444)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(623, 194)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'lblTaxiFeesReimbursement
        '
        Me.lblTaxiFeesReimbursement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxiFeesReimbursement.Location = New System.Drawing.Point(176, 134)
        Me.lblTaxiFeesReimbursement.Name = "lblTaxiFeesReimbursement"
        Me.lblTaxiFeesReimbursement.Size = New System.Drawing.Size(82, 23)
        Me.lblTaxiFeesReimbursement.TabIndex = 22
        '
        'taxi
        '
        Me.taxi.AutoSize = True
        Me.taxi.Location = New System.Drawing.Point(34, 134)
        Me.taxi.Name = "taxi"
        Me.taxi.Size = New System.Drawing.Size(129, 13)
        Me.taxi.TabIndex = 23
        Me.taxi.Text = "Taxi Fees Reimbursement"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 650)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Travel Expenses "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDaysOfStay As TextBox
    Friend WithEvents txtLodgingChargeNight As TextBox
    Friend WithEvents txtMealCosts As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtConferenceSeminar As TextBox
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtTaxiFare As TextBox
    Friend WithEvents txtAirfareCost As TextBox
    Friend WithEvents txtCarRentalFees As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblAllowableExpenses As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAmountSaved As Label
    Friend WithEvents lblExcess As Label
    Friend WithEvents lblparkingFees As Label
    Friend WithEvents txtParkingFees As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblMileageReimbursement As Label
    Friend WithEvents lblParkingFeesReimburse As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblMealReimbursement As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblLodgingReimbursement As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents taxi As Label
    Friend WithEvents lblTaxiFeesReimbursement As Label
End Class
