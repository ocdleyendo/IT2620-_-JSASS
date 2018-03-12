Public Class Form1

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

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



        lblMealReimbursement.Text = CalcMealCosts(decMealCosts, intDaysofStay)
        lblMileageReimbursement.Text = CalcMileage(decMileageReimbursement)
        lblParkingFeesReimburse.Text = CalcParkingFees(decParkingReimbursement, intDaysofStay)
        lblLodgingReimbursement.Text = CalcLodging(decLodgingReimbursement, intDaysofStay)
        lblTaxiFeesReimbursement.Text = CalcTaxiFees(decTaxiReimbursement, intDaysofStay)

    End Sub

    Function CalcMealCosts(ByVal intMealCosts As Decimal, ByVal intDaysofStay As Integer) As Integer
        'Convert txtmeals to integer
        'If Not Integer.TryParse(txtDaysOfStay.Text, intDaysofStay) Or intDaysofStay < 0 Then
        '    MessageBox.Show("Please enter a positive number for the days of your stay")
        'Else
        If Not Decimal.TryParse(txtMealCosts.Text, decMealCosts) Or decMealCosts < 0 Then
            MessageBox.Show("Please enter a valid number for meal costs, if any")
        Else
            'Calculate amount to reimburse for meals per day if days of stay > 1
            If intDaysofStay = 1 And decMealCosts < 37 Then
                decMealReimbursement = decMealCosts
            Else
                decMealReimbursement = 37
            End If
                If intDaysofStay > 1 Then
                decMealCostsPerDay = intMealCosts / intDaysofStay
                If decMealCostsPerDay < 37 Then
                    decMealReimbursement = decMealCosts 'intMealCostPerday * intDaysofStay
                Else
                    'Calculate the meal reimbursement if days of stay = 1
                    decMealReimbursement = 37 * intDaysofStay
                End If
                End If
            End If
        'End If
        Return decMealReimbursement
    End Function

    'Calculate the mileage at .27 per mile, if any 
    Private Function CalcMileage(ByVal intMilesDriven As Integer) As Integer
        If Not Integer.TryParse(txtMileage.Text, intMilesDriven) Or intMilesDriven < 0 Then
            MessageBox.Show("Please enter the miles driven if a private vehicle was used")
        Else
            If intMilesDriven > 0 Then
                decMileageReimbursement = intMilesDriven * 0.27
            Else decMileageReimbursement = 0
            End If
        End If
        Return decMileageReimbursement
    End Function

    'Calculate the parking fees to be reimbursed, if any
    Function CalcParkingFees(ByVal decParkingFees As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtParkingfees to decimal
        If Not Decimal.TryParse(txtParkingFees.Text, decParkingFees) Or decParkingFees < 0 Then
            MessageBox.Show("Please enter a positive amount for parking fees, if any")
        Else

            'Calculate amount to reimburse for parking fees per day if days of stay > 1
            If intDaysofStay = 1 And decParkingFees < 10 Then
                decParkingReimbursement = decParkingFees
            Else
                decParkingReimbursement = 10
            End If

            'Calculate the parking fees if days of stay > 1
            If intDaysofStay > 1 Then
                decParkingfeesPerday = decParkingFees / intDaysofStay
                If decParkingfeesPerday < 10 Then
                    decParkingReimbursement = decParkingFees
                Else
                    'Calculate the meal reimbursement if days of stay = 1
                    decParkingReimbursement = 10 * intDaysofStay
                End If
            End If
        End If

        Return decParkingReimbursement
    End Function

    Function CalcLodging(ByVal decParkingFees As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtLodging to decimal
        If Not Decimal.TryParse(txtLodgingChargeNight.Text, decLodgingCosts) Or decLodgingCosts < 0 Then
            MessageBox.Show("Please enter a positive amount for lodging costs per night")
        Else

            'Calculate amount to reimburse for lodging per night if days of stay > 1
            If intDaysofStay = 1 And decLodgingCosts < 95 Then
                decLodgingReimbursement = decLodgingCosts
            Else
                decLodgingCosts = 95
            End If

            'Calculate the lodging costs if days of stay > 1
            If intDaysofStay > 1 Then
                decLodgingCostsPerDay = decLodgingCosts / intDaysofStay
                If decLodgingCostsPerDay < 95 Then
                    decLodgingReimbursement = decLodgingCosts
                Else
                    'Calculate the lodging reimbursement if the hotel costs < 95/per day
                    decLodgingReimbursement = 95 * intDaysofStay
                End If
            End If
        End If

        Return decLodgingReimbursement
    End Function

    Function CalcTaxiFees(ByVal decTaxiCharges As Decimal, ByVal intDaysofStay As Integer) As Decimal

        'Convert txtTaxiCharges to decimal
        If Not Decimal.TryParse(txtTaxiFare.Text, decTaxiCharges) Or decTaxiCharges < 0 Then
            MessageBox.Show("Please enter a positive amount for taxi costs, if any")
        Else

            'Calculate amount to reimburse for taxi fare if the days of stay = 1
            If intDaysofStay = 1 And decTaxiCharges < 20 Then
                decTaxiReimbursement = decTaxiCharges
            Else
                decTaxiReimbursement = 20
            End If

            'Calculate the lodging costs if days of stay > 1
            If intDaysofStay > 1 Then
                decTaxiChargesPerDay = decTaxiCharges / intDaysofStay
                If decTaxiChargesPerDay < 20 Then
                    decTaxiReimbursement = decTaxiCharges
                Else
                    'Calculate the lodging reimbursement if the hotel costs < 95/per day
                    decTaxiReimbursement = 20 * intDaysofStay
                End If
            End If
        End If

        Return decTaxiReimbursement
    End Function

    'Calculate the total reimbursement
    Function CalcTotalReimbursement(ByVal intDaysofStay As Integer,
                                    ByVal decMealReimbursement As Decimal,
                                    ByVal decMileageReimbursement As Decimal,
                                    ByVal decParkingReimbursement As Decimal,
                                    ByVal decLodgingReimbursement As Decimal,
                                    ByVal decAirfareCosts As Decimal,
                                    ByVal decTaxiReimbursement As Decimal,
                                    ByVal intRegistrationFees As Integer
                                    ) As Decimal

        'Decimal.TryParse(txtAirfareCost.Text, decAirfare)
        'Integer.TryParse(txtConferenceSeminar.Text, intRegistrationFees)
        'Integer.TryParse(txtCarRentalFees.Text, intCarRental)

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
        If decMealCosts > 0 And decMealCostsPerDay < 37 Then
            decMealCostSavings = ((37 * intDaysofStay) - decMealReimbursement)
        Else
            decMealCostSavings = 0
        End If

        'find savings for parking fees
        If decParkingFees > 0 And decParkingfeesPerday < 10 Then
            decParkingFeeSavings = ((10 * intDaysofStay) - decParkingReimbursement)
        Else
            decParkingFeeSavings = 0
        End If

        'find savings for taxi charges
        If decTaxiCharges > 0 And decTaxiChargesPerDay < 20 Then
            decTaxiChargeSavings = ((20 * intDaysofStay) - decTaxiReimbursement)
        Else
            decTaxiChargeSavings = 0
        End If

        'find savings for lodging charges
        If decLodgingCosts > 0 And decLodgingCostsPerDay < 95 Then
            decLodgingSavings = (95 - decLodgingCostsPerDay)
        End If

        decTotalSavings = (decMealCostSavings +
                           decParkingFeeSavings +
                             decTaxiChargeSavings +
                             decLodgingSavings)
        Return decTotalSavings
    End Function
    ' End Function
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
        lblAmountSaved.Text = String.Empty
        lblExcess.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
