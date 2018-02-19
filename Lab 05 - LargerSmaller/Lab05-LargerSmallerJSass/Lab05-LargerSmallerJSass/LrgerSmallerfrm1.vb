Public Class Form1
    Private Sub txtIntegerA_TextChanged(sender As Object, e As EventArgs) Handles txtInputA.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IntA As Integer
        Dim IntB As Integer

        If Integer.TryParse(txtInputA.Text, IntA) And Integer.TryParse(txtInputB.Text, IntB) Then
            If IntA > IntB Then lblComparisonResults.Text = "The value of A is larger than B"
            If IntB > IntA Then lblComparisonResults.Text = "The value of B is larger than A"
            If IntA = IntB Then lblComparisonResults.Text = "The values of A and B are equal"
        Else
            lblErrorMessage.Text = "Please enter a valid Integer"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'close the form.
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Clear the input text boxes and Comparison result box
        txtInputA.Clear()
        txtInputB.Clear()
        lblComparisonResults.Text = String.Empty
        lblErrorMessage.Text = String.Empty

    End Sub
End Class
