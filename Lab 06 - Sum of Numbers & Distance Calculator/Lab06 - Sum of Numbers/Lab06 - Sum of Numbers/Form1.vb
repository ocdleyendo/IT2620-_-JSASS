Public Class Form1
    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim struserInput As String
        Dim IntUserInput As Integer
        Dim intTotal As Integer
        Dim intCount As Integer = 0


        struserInput = InputBox(“Enter a positive integer value”, “Input Needed”, 10)

        If Not IsNumeric(struserInput) Then
            MessageBox.Show("You did not enter a number.")
        Else
            If struserInput <> String.Empty Then
                Double.TryParse(struserInput, IntUserInput)

                If IntUserInput <= 0 Then
                    MessageBox.Show(“Please enter a postive number.”)
                Else
                    For intCount = 1 To IntUserInput
                        'Calculate the sum of intcount

                        'Add the number to the accumulator.
                        intTotal += intCount

                    Next
                    'Display the total in a message box
                    MessageBox.Show(“The sum of 1 through ” & (IntUserInput.ToString) & " is " &
                                         (intTotal.ToString), "Sum of Numbers", MessageBoxButtons.OK)

                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
