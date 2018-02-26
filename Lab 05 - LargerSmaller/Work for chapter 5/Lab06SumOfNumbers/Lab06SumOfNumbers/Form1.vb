Public Class Form1

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim i As Integer
        Dim intCount As Integer = 1

        Do While intCount <= IntUserInput
            intCount += 1
            strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
            If Integer.TryParse(strUserInput, i) Then

                IntUserInput = CInt(strUserInput)
                If IntUserInput < 0 Then
                    MessageBox.Show("Negative numbers are not accepted.")
                Else
                    MessageBox.Show("Quantity amount must be numeric.")
                End If
            End If
        Loop
            'IntUserInput = (IntUserInput + i)
            MessageBox.Show("Sum of Numbers", "The sum of numbers" & (i + IntUserInput), MessageBoxButtons.OK)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
