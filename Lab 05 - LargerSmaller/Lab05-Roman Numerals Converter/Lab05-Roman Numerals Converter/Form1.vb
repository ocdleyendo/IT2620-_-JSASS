﻿Public Class RomanNumeralConverter
    Private Sub RomanNumeralConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare Variables

        Dim intRomNumeral As Integer
        Try
            lblRomanNumeral.Text = String.Empty
            'Assign the textbox value to the integer
            txtInputNumber.Text = CInt(txtInputNumber.Text)

            'Get the roman numeral for the integer

            If Integer.TryParse(txtInputNumber.Text, intRomNumeral) Then

                'Input validation that the integer entered is >=1 and <=10
                If intRomNumeral >= 1 And intRomNumeral <= 10 Then

                    Select Case intRomNumeral                   'Select Case 1

                        Case 1
                            If intRomNumeral = 1 Then
                                lblRomanNumeral.Text = "I"
                            End If
                        Case 2                                      'Select Case 2
                            If intRomNumeral = 2 Then
                                lblRomanNumeral.Text = "II"
                            End If
                        Case 3                                  'Select Case 3
                            If intRomNumeral = 3 Then
                                lblRomanNumeral.Text = "III"
                            End If
                        Case 4                                  'Select Case 4
                            If intRomNumeral = 4 Then
                                lblRomanNumeral.Text = "IV"
                            End If
                        Case 5                                     'Select Case 5
                            If intRomNumeral = 5 Then
                                lblRomanNumeral.Text = "V"
                            End If
                        Case 6                                      'Select Case 6
                            If intRomNumeral = 6 Then
                                lblRomanNumeral.Text = "VI"
                            End If
                        Case 7                                      'Select Case 7
                            If intRomNumeral = 7 Then
                                lblRomanNumeral.Text = "VII"
                            End If
                        Case 8                                      'Select Case 8
                            If intRomNumeral = 8 Then
                                lblRomanNumeral.Text = "VIII"
                            End If
                        Case 9                                          'Select Case 9
                            If intRomNumeral = 9 Then
                                lblRomanNumeral.Text = "IX"
                            End If
                        Case 10                                         'Select Case 10
                            If intRomNumeral = 10 Then
                                lblRomanNumeral.Text = "X"
                            End If

                    End Select

                Else lblMessage.Text = "Please enter a value greater than or equal to 1 or less than or equal to 10."
                End If
            End If
        Catch
            'Display error message
            lblMessage.Text = "Please enter a valid integer."
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
