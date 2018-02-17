Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables for the calculations.

        Dim decRoomCharges As Decimal               'Room Charges total
        Dim decAddCharges As Decimal                'Additional Charges
        Dim decSubtotal As Decimal                   'subtotal
        Dim decTax As Decimal                        'Tax
        Dim dectotal As Decimal                     'Total of all Charges
        Const decTAX_RATE As Decimal = 0.08D        'tax Rate

        Try
            'Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'Calculate and display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            'Calculate and display the total charges.
            dectotal = decSubtotal + decTax
            lblTotal.Text = dectotal.ToString("c")

        Catch
            'Error Message
            MessageBox.Show("All input must be valid numeric Values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the room info fields
        txtNights.Clear()
        txtNightlyCharge.Clear()

        'Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        'Clear the decTotal Fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        'Get today's date from the operating system and display it.
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the operating system and display it.
        lblTimeToday.Text = Now.ToString("T")

        'Reset the focus to the first field.
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
