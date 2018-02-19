Public Class Form1
    Private Sub txtIntegerA_TextChanged(sender As Object, e As EventArgs) Handles txtInputA.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IntA As Integer
        Dim IntB As Integer

        If Integer.TryParse(txtInputA.Text, IntA) And Integer.TryParse(txtInputB.Text, IntB) Then
            If IntA > IntB Then lblComparisonResults.Text = "The value of A is larger than B."
            If IntB > IntA Then lblComparisonResults.Text = "The value of B is larger than A."
            If IntA = IntB Then lblComparisonResults.Text = "The values of A and B are equal."
        Else
            lblErrorMessage.Text = "Please enter a valid Integer."
        End If
    End Sub
End Class
