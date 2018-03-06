Public Class Form1

    Private Sub btnGetRetailPrice_Click(sender As Object, e As EventArgs) Handles btnGetRetailPrice.Click

        Dim dblWholesaleCost As Double '= (txtWholesaleCost.Text)   'To hold the wholesale price
        Dim dblMarkupPercentage As Double '= (txtMarkupPercentage.Text / 100)    'To hold the discount percentage

        Try
            If Double.TryParse(txtWholesaleCost.Text, dblWholesaleCost) And dblWholesaleCost > 0 Then
                If Double.TryParse(txtMarkupPercentage.Text, dblMarkupPercentage) And dblMarkupPercentage > 0 Then


                    lblRetailPrice.Text = dblWholesaleCost +
                               (CalcRetailPrice(dblWholesaleCost, dblMarkupPercentage / 100))

                Else
                    MessageBox.Show("Please enter a numeric value greater than zero")
                End If
            Else
                MessageBox.Show("Please enter a numeric value greater than zero")
            End If
            'Else
            '    MessageBox.Show("Please enter a postive number")
            'End If

        Catch ex As InvalidCastException
            MessageBox.Show("Please enter a postive number")
        End Try

    End Sub

    Private Function CalcRetailPrice(ByVal WholesaleCost As Double,
                                    ByVal MarkupPercentage As Double) As Double


        Return (WholesaleCost * MarkupPercentage)
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
