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
    Dim decConferenceCosts As Decimal
    Dim decLodgingCosts As Decimal
    'Dim decLodgingCostsPerDay As Decimal
    Dim decLodgingReimbursement As Decimal
        Dim decTotalReimbursement As Decimal
        Dim decTaxiOverage As Decimal
        Dim decParkingOverage As Decimal
        Dim decLodgingOverage As Decimal
    Dim decTotalUnallowed As Decimal
    'Dim decCoveredExpenses = intDaysofStay * (37 + 10 + 20 + 95)

    Const decMealsCover As Double = 37D
    Const decMilesCover As Double = 0.27D
    Const decParkingCover As Double = 10D
    Const decTaxiCover As Double = 20D
    Const decLodgingCover As Double = 95D

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        If Not Decimal.TryParse(txtDaysOfStay.Text, intDaysofStay) Or intDaysofStay <= 0 Then
            MessageBox.Show("Please enter a positive number for the days of your stay")
        End If

        If Not Decimal.TryParse(txtAirfare.Text, decAirfare) Or decAirfare < 0 Then
            MessageBox.Show("Please enter a positive amount for your airfare, if any")
        Else decAirfare = txtAirfare.Text.ToString
        End If

        If Not Integer.TryParse(txtCarRentalFees.Text, intCarRental) Or intCarRental < 0 Then
            MessageBox.Show("Please enter a positive amount for your Car Rental Fees, if any")
        Else intCarRental = txtCarRentalFees.Text.ToString
        End If

        If Not Integer.TryParse(txtConferenceFees.Text, decConferenceCosts) Or decConferenceCosts < 0 Then
            MessageBox.Show("Please enter a positive amount for your Conference or Seminar Costs, if any")
        Else decConferenceCosts = txtConferenceFees.Text.ToString
        End If

        'Dim decTotalExpenses As Decimal

        'decTotalReimbursement.ToString

        lblAllowableExpenses.Text = CalcTotalReimbursement()

        lblAmountSaved.Text = CalcSaved()

        lblUnallowed.Text = CalcUnallowed(
                                 )


        lblTotalExpenses.Text = CalcTotalExpenses(
                                 )

        lblMealsReimbursement.Text = CalcMeals()

        lblParkingReimbursement.Text = CalcParkingFees()

        lblMileageReimbursement.Text = CalcMileage()

        lblTaxiReimbursement.Text = CalcTaxiFees()

        lblLodgingReimbursement.Text = CalcLodging()

    End Sub

    Function CalcMeals() As Integer
        Dim decMealReimbursement As Decimal


        If Not Decimal.TryParse(txtMealCosts.Text, decMealCosts) Then
            MessageBox.Show("Please enter a valid number for meal costs, if any")
        Else
            'Calculate amount to reimburse for meals
            decMealReimbursement = (CDec(txtDaysOfStay.Text) * decMealsCover)

        End If
        Return decMealReimbursement
    End Function

    'Calculate the mileage at .27 per mile, if any 
    Private Function CalcMileage() As Integer
        If Integer.TryParse(txtMileage.Text, intMilesDriven) Then

            decMileageReimbursement = (CDec(txtMileage.Text) * decMilesCover)
        Else
            MessageBox.Show("Please enter the miles driven if a private vehicle was used")
        End If
        Return decMileageReimbursement
    End Function

    'Calculate the parking fees to be reimbursed, if any
    Function CalcParkingFees() As Decimal

        'Convert txtParkingfees to decimal
        If Decimal.TryParse(txtParkingFees.Text, decParkingFees) Then
            decParkingReimbursement = (CDec(txtDaysOfStay.Text) * decParkingCover)
        Else
            MessageBox.Show("Please enter a positive amount for parking fees, if any")
        End If

        Return decParkingReimbursement
    End Function

    Function CalcLodging() As Decimal

        'Convert txtLodging to decimal
        If Decimal.TryParse(txtLodgingExpenses.Text, decLodgingCosts) Then

            decLodgingReimbursement = (CDec(txtDaysOfStay.Text) * decLodgingCover)
        Else
            MessageBox.Show("Please enter a positive amount for lodging costs per night")
        End If


        'Calculate amount to reimburse for lodging 

        Return decLodgingReimbursement
    End Function

    Function CalcTaxiFees() As Decimal

        'Convert txtTaxiCharges to decimal
        If Decimal.TryParse(txtTaxiCharges.Text, decTaxiCharges) Then
            decTaxiReimbursement = (CDec(txtDaysOfStay.Text) * decTaxiCover)
        Else
            MessageBox.Show("Please enter a positive amount for taxi costs, if any")

            'Calculate amount to reimburse for taxi fare
        End If
        Return decTaxiReimbursement
    End Function

    Function CalcTotalReimbursement(
                                ) As Decimal

        Dim decTotalCoveredExpenses As Decimal

        decTotalCoveredExpenses = CalcLodging() + CalcTaxiFees() + CalcMeals() + CalcParkingFees()
        Return decTotalCoveredExpenses

    End Function

    Function CalcSaved() As Decimal

        Dim decReimburseableExpenses As Decimal
        Dim decTotalSavings As Decimal
        Dim decCoveredExpenses As Decimal

        'decReimburseableExpenses = (decMealCosts + decLodgingCosts + decTaxiCharges + decParkingFees)

        'decCoveredExpenses = (intDaysofStay * (37 + 10 + 20 + 95))

        'If decCoveredExpenses > decReimburseableExpenses Then
        '    decTotalSavings = decCoveredExpenses - decReimburseableExpenses
        'Else
        '    decTotalSavings = 0
        'End If

        decTotalSavings = (CDec(txtDaysOfStay.Text) * decMealsCover - CDec(txtMealCosts.Text)) +
                           (CDec(txtDaysOfStay.Text) * decParkingCover - CDec(txtParkingFees.Text)) +
                           (CDec(txtDaysOfStay.Text) * decTaxiCover - CDec(txtTaxiCharges.Text)) +
                           (CDec(txtDaysOfStay.Text) * decLodgingCover - CDec(txtLodgingExpenses.Text))

        Return decTotalSavings

    End Function

    Function CalcTotalExpenses()

        Dim decTotalExpenses As Decimal

        'decTotalExpenses = (decMealCosts + decLodgingCosts + decTaxiCharges + decParkingFees +
        '                    decAirfare + decConferenceCosts +
        '                    (intMilesDriven * 0.27))

        decTotalExpenses = CDec(txtAirfare.Text) + CDec(txtConferenceFees.Text) + CDec(txtCarRentalFees.Text) +
                        (CDec(txtMileage.Text) * decMilesCover) + CDec(txtMealCosts.Text) + CDec(txtLodgingExpenses.Text) +
                        CDec(txtParkingFees.Text) + CDec(txtTaxiCharges.Text)
        Return decTotalExpenses
    End Function

    Function CalcUnallowed() As Decimal

        'Dim decTotalReimbursement As Decimal
        Dim decTotalUnallowed As Decimal
        'Dim decReimburseableExpenses As Decimal
        'Dim decCoveredExpenses As Decimal
        'Dim decTotalExpenses As Decimal

        'decTotalExpenses = (decParkingFees + decLodgingCosts + decTaxiCharges + decAirfare +
        '                    decConferenceCosts + decMealCosts + (intMilesDriven * 0.27)
        '                        )
        'decCoveredExpenses = (intDaysofStay * (37 + 10 + 20 + 95))

        'If decCoveredExpenses <= decReimburseableExpenses Then
        '    decTotalUnallowed = decReimburseableExpenses - decCoveredExpenses
        'End If

        'decTotalUnallowed = (decParkingOverage + decTaxiOverage + decLodgingOverage)

        decTotalUnallowed = (CDec(txtLodgingExpenses.Text) - CalcLodging()) + (CDec(txtParkingFees.Text) - CalcParkingFees()) +
                            (CDec(txtTaxiCharges.Text) - CalcTaxiFees()) + (CDec(txtMealCosts.Text) - CalcMeals())

        Return decTotalUnallowed
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAirfare.Text = String.Empty
        txtCarRentalFees.Text = String.Empty
        txtConferenceFees.Text = String.Empty
        txtDaysOfStay.Text = String.Empty
        txtLodgingExpenses.Text = String.Empty
        txtMealCosts.Text = String.Empty
            txtMileage.Text = String.Empty
            txtParkingFees.Text = String.Empty
        txtTaxiCharges.Text = String.Empty
        lblAllowableExpenses.Text = String.Empty
            lblUnallowed.Text = String.Empty
        lblAmountSaved.Text = String.Empty
        lblTotalExpenses.Text = String.Empty
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

End Class


