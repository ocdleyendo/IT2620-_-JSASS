Public Class Form1
    'Class - level constants
    Const dblMONTHS_YEAR As Double = 12          ' months per year
    Const dblNEW_RATE As Double = 0.05          ' interest rate, new cars
    Const dblUSED_RATE As Double = 0.08             ' interet rate, used cars

    'Class - level variable to hold the annual interest rate
    Dim dblAnnualRAte As Double = dblNEW_RATE

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double        'vehicle cost
        Dim dblDownPayment As Double        ' down payment
        Dim intMonths As Integer            'Number of months for the loan
        Dim dlbLoan As Double               'Amount of the loan
        Dim dblMonthlyPayment As Double     'Monthly payment
        Dim dblInterest As Double           ' interest paid for the period
        Dim dblPrincipal As Double          ' interest paid for the period
        Dim intCount As Integer             'Counter for the loop
        Dim StrOut As String                '
        Dim blInputOk As Boolean = True


    End Sub
End Class

