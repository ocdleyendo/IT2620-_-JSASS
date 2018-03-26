Public Class Form1

    Dim intDaysofStay As Integer '= CInt(txtDaysOfStay.Text)
    Dim decAirfare As Decimal
    Dim decMealCosts As Decimal
    Dim decMealCostsPerDay As Decimal = 0
    Dim decMealReimbursement As Decimal = 0
    Dim decMealCostSavings As Decimal
    Dim decParkingFeeSavings As Decimal
    Dim decTaxiChargeSavings As Decimal
    Dim decLodgingSavings As Decimal
    Dim decTotalSavings As Decimal
    Dim intCarRental As Integer
    Dim intMilesDriven As Integer
    Dim decMileageReimbursement As Decimal
    Dim decParkingFees As Decimal
    Dim decParkingReimbursement As Decimal
    Dim decParkingfeesPerday As Decimal
    Dim decTaxiCharges As Decimal
    Dim decTaxiChargesPerDay As Decimal
    Dim decTaxiReimbursement As Decimal
    Dim intRegistrationFees As Integer
    Dim decLodgingCosts As Decimal
    Dim decLodgingCostsPerDay As Decimal
    Dim decLodgingReimbursement As Decimal
    Dim decTotalReimbursement As Decimal
    Dim decTaxiOverage As Decimal
    Dim decParkingOverage As Decimal
    Dim decLodgingOverage As Decimal
    Dim decTotalUnallowed As Decimal

    Const dblMealsCover As Double = 37
    Const dblMilesCover As Double = 0.27
    Const dblParkingCover As Double = 10
    Const dblTaxiCover As Double = 20
    Const dblLodgingCover As Double = 95

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        If Not Decimal.TryParse(txtDaysOfStay.Text, intDaysofStay) Or intDaysofStay <= 0 Then
            MessageBox.Show("Please enter a positive number for the days of your stay")
        End If

        If Not Decimal.TryParse(txtAirfareCost.Text, decAirfare) Or decAirfare < 0 Then
            MessageBox.Show("Please enter a positive amount for your airfare, if any")
        Else decAirfare = txtAirfareCost.Text.ToString
        End If

        If Not Integer.TryParse(txtCarRentalFees.Text, intCarRental) Or intCarRental < 0 Then
            MessageBox.Show("Please enter a positive amount for your Car Rental Fees, if any")
        Else intCarRental = txtCarRentalFees.Text.ToString
        End If

        If Not Integer.TryParse(txtConferenceSeminar.Text, intRegistrationFees) Or intRegistrationFees < 0 Then
            MessageBox.Show("Please enter a positive amount for your Conference or Seminar Costs, if any")
        Else intRegistrationFees = txtConferenceSeminar.Text.ToString
        End If

        'decTotalReimbursement.ToString

        lblAllowableExpenses.Text = CalcTotalReimbursement(decMealReimbursement,
                                                       decTotalReimbursement,
                                                       decAirfare,
                                                       decMileageReimbursement,
                                                       decParkingReimbursement,
                                                       decLodgingReimbursement,
                                                       decTaxiReimbursement,
                                                       intRegistrationFees)


        lblAmountSaved.Text = CalcSaved(intDaysofStay,
                                decMealCostSavings,
                                 decParkingFeeSavings,
                                 decLodgingReimbursement,
                                 decLodgingSavings
                                )

        lblUnallowed.Text = CalcUnallowed(decParkingOverage, decTaxiOverage, decLodgingOverage)

        lblMealReimbursement.Text = CalcMealCosts(decMealCosts, intDaysofStay)
        lblMileageReimbursement.Text = CalcMileage(decMileageReimbursement)
        lblParkingFeesReimburse.Text = CalcParkingFees(decParkingReimbursement, intDaysofStay)
        lblLodgingReimbursement.Text = CalcLodging(decLodgingReimbursement, intDaysofStay)
        lblTaxiFeesReimbursement.Text = CalcTaxiFees(decTaxiReimbursement, intDaysofStay)

    End Sub

    Function CalcMealCosts(ByVal intMealCosts As Decimal, ByVal intDaysofStay As Integer) As Integer

        If Not Decimal.TryParse(txtMealCosts.Text, decMealCosts) Then
            MessageBox.Show("Please enter a valid number for meal costs, if any")
        Else
            'Calculate amount to reimburse for meals
            decMealReimbursement = intDaysofStay * dblMealsCover
            If decMealCosts <= decMealReimbursement Then
                decMealCostSavings = 0
            Else
                decMealCostSavings = decMealReimbursement - decMealCosts
            End If
        End If
        Return decMealReimbursement '& decMealCostSavings
    End Function

    'Calculate the mileage at .27 per mile, if any 
    Private Function CalcMileage(ByVal intMilesDriven As Integer) As Integer
        If Integer.TryParse(txtMileage.Text, intMilesDriven) Then
            If intMilesDriven > 0 Then
                decMileageReimbursement = intMilesDriven * 0.27
            Else
                decMileageReimbursement = 0
            End If
            Else
            MessageBox.Show("Please enter the miles driven if a private vehicle was used")
        End If
        Return decMileageReimbursement
    End Function

    'Calculate the parking fees to be reimbursed, if any
    Function CalcParkingFees(ByVal decParkingFees As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtParkingfees to decimal
        If Decimal.TryParse(txtParkingFees.Text, decParkingFees) Then
            decParkingReimbursement = intDaysofStay * dblParkingCover
        Else
            MessageBox.Show("Please enter a positive amount for parking fees, if any")
        End If

        If decParkingFees <= decParkingReimbursement Then
            decParkingFeeSavings = 0
        Else
            decParkingFeeSavings = decParkingReimbursement - decParkingFees
        End If
        Return decParkingReimbursement & decParkingFeeSavings
    End Function

    Function CalcLodging(ByVal decParkingFees As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtLodging to decimal
        If Decimal.TryParse(txtLodgingChargeNight.Text, decLodgingCosts) Then
            If decLodgingCosts > 0 Then
                decLodgingReimbursement = intDaysofStay * dblLodgingCover
            Else
                MessageBox.Show("Please enter a positive amount for lodging costs per night")
            End If

        End If
        'Calculate amount to reimburse for lodging 

        If decLodgingCosts < decLodgingReimbursement Then
            decLodgingSavings = 0
        Else
            decLodgingSavings = decLodgingCosts - decLodgingReimbursement
        End If

        Return decLodgingReimbursement
    End Function

    Function CalcTaxiFees(ByVal decTaxiCharges As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtTaxiCharges to decimal
        If Decimal.TryParse(txtTaxiFare.Text, decTaxiCharges) Then
            decTaxiReimbursement = intDaysofStay * dblTaxiCover
        Else
            MessageBox.Show("Please enter a positive amount for taxi costs, if any")

            'Calculate amount to reimburse for taxi fare

            If decTaxiCharges <= decTaxiReimbursement Then
                decTaxiChargeSavings = 0
            Else
                decTaxiChargeSavings = decTaxiReimbursement - decTaxiCharges
            End If
        End If
            Return decTaxiReimbursement
    End Function

    'Calculate the total reimbursement
    'first result = sum the amounts of all textboxes, and put it, 
    'into another New textbox Or label that Is For total expenses

    'second result = this is ((# of days * (37 + 10 + 20 +95)) + (.27 * amount of miles)) -> 
    'amount of miles is on the vehicles miles textbox you put at the begining,
    'put this result In another textbox Or label, As total allowable expenses

    'third result = first result - second result -> If this value Is gretter than 0 
    ' Then the person had an excess If Is lower than 0 he made some saving, 
    'And If its 0 Then he was even.

    'If (first result - second result) > 0 Then
    'he spended more
    'ElseIf (first result - second result) < 0 Then
    'he had savings
    'Else
    'he has even
    'End If

    Function CalcTotalReimbursement(ByVal intDaysofStay As Integer,
                                ByVal dblMealCover As Decimal,
                                ByVal dblLodgingCover As Decimal,
                                ByVal dblTaxiCover As Decimal,
                                ByVal decLodgingReimbursement As Decimal,
                                ByVal decAirfareCosts As Decimal,
                                ByVal decTaxiReimbursement As Decimal,
                                ByVal intRegistrationFees As Integer
                                ) As Decimal

        Dim decTotalExpenses As Decimal
        Dim decTotalCoveredExpenses As Decimal

        Const dblMealsCover As Double = 37
        Const dblMilesCover As Double = 0.27
        Const dblParkingCover As Double = 10
        Const dblTaxiCover As Double = 20
        Const dblLodgingCover As Double = 95

        decTotalExpenses = decMealCosts + decLodgingCosts + decAirfareCosts + decTaxiCharges +
                            intRegistrationFees + intCarRental + (dblMilesCover * intMilesDriven)

        decTotalCoveredExpenses = decMealCosts + decLodgingCosts + decTaxiCharges + intCarRental

        decTotalReimbursement = (decMealReimbursement +
                              decMileageReimbursement +
                              decParkingReimbursement +
                              decLodgingReimbursement +
                              decAirfareCosts +
                              decTaxiReimbursement +
                              intRegistrationFees)

        Return decTotalReimbursement

    End Function

    Function CalcSaved(ByVal intDaysofStay As Integer,
                                ByVal decMealReimbursement As Decimal,
                                ByVal decParkingReimbursement As Decimal,
                                ByVal decTaxiReimbursement As Decimal,
                                ByVal decLodgingCostsPerDay As Decimal
                                ) As Decimal

        'Find savings for meals
        If ((37 * intDaysofStay) - decMealReimbursement) > 0 Then
            decMealCostSavings = ((37 * intDaysofStay) - decMealReimbursement)
        Else
            decMealCostSavings = 0
        End If

        'find savings for parking fees
        If ((10 * intDaysofStay) - decParkingReimbursement) > 0 Then
            decParkingFeeSavings = ((10 * intDaysofStay) - decParkingReimbursement)
        Else
            decParkingFeeSavings = 0
        End If

        'find savings for taxi charges
        If ((20 * intDaysofStay) - decTaxiReimbursement) > 0 Then
            decTaxiChargeSavings = ((20 * intDaysofStay) - decTaxiReimbursement)
        Else
            decTaxiChargeSavings = 0
        End If

        'find savings for lodging charges
        If (95 - decLodgingCostsPerDay) > 0 Then
            decLodgingSavings = (95 - decLodgingCostsPerDay)
        Else
            decLodgingSavings = 0
        End If

        decTotalSavings = (decMealCostSavings +
                             decParkingFeeSavings +
                              decTaxiChargeSavings +
                                 decLodgingSavings)
        Return decTotalSavings
    End Function

    Function CalcUnallowed(ByVal decParkingfeesPerDay As Decimal, ByVal decTaxiChargesPerDay As Decimal,
                           ByVal decLodgingCostsPerDay As Decimal) As Decimal


        If (decParkingfeesPerDay - 10) > 0 Then
            decParkingOverage = (decParkingfeesPerDay - 10)
        Else
            decParkingOverage = 0
        End If

        If (decTaxiChargesPerDay - 20) > 0 Then
            decTaxiOverage = (decTaxiCharges - 20)
        Else
            decTaxiOverage = 0
        End If

        If (decLodgingCostsPerDay - 95) > 0 Then
            decLodgingOverage = (decLodgingCostsPerDay - 20)
        Else
            decLodgingOverage = 0
        End If

        decTotalUnallowed = (decParkingOverage + decTaxiOverage + decLodgingOverage)

        Return decTotalUnallowed
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAirfareCost.Text = String.Empty
        txtCarRentalFees.Text = String.Empty
        txtConferenceSeminar.Text = String.Empty
        txtDaysOfStay.Text = String.Empty
        txtLodgingChargeNight.Text = String.Empty
        txtMealCosts.Text = String.Empty
        txtMileage.Text = String.Empty
        txtParkingFees.Text = String.Empty
        txtTaxiFare.Text = String.Empty
        lblAllowableExpenses.Text = String.Empty
        lblUnallowed.Text = String.Empty
        lblUnallowed.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub


End Class
