Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intTotal As Integer = 0
        Dim intDistance As Integer = 0
        Dim decSpeed As Decimal = 0
        Dim decTime As Decimal = 0
        Dim decTotal As Decimal
        Dim strSpeedInput As String
        Dim strHoursInput As String

        'Get the speed
        strSpeedInput = InputBox(“Enter the speed (in miles per hour) of the vehicle:”)

        'conver to decimal
        If Decimal.TryParse(strSpeedInput, decSpeed) Then
            'get time
            strHoursInput = InputBox(“Enter the time (in hours) that the vehicle is traveling:”)
            'Convert to decimal
            If Decimal.TryParse(strHoursInput, decTime) Then
                'Calculate the distance
                decTotal = decTime * decSpeed

                'display the speed
                strSpeedInput = “Vehicle Speed:  “ & decSpeed.ToString() & “ MPH”
                lstVehicleDist.Items.Add(strSpeedInput)

                'display time traveled
                lstVehicleDist.Items.Add(“Time Traveled: “ & decTime.ToString() & “ Hours”)


                'adds hours and distance traveled columns
                lstVehicleDist.Items.Add(“Hours           Distance    Traveled”)

                'shows gap seperation
                lstVehicleDist.Items.Add(“--------------------“)

                For intTotal = 1 To 7
                    'calculate the distance
                    intDistance = CInt(intTotal * decSpeed)
                    lstVehicleDist.Items.Add(intTotal.ToString & “          “ & intDistance.ToString)   ' puts more space between hours and distance
                Next

                'add the total to the list box
                lstVehicleDist.Items.Add(“Total Distance:    “ & decTotal.ToString)
            Else
                MessageBox.Show(“Please enter a numeric value for hours.”)
            End If
        Else
            MessageBox.Show(“Please enter a number for speed.”)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
