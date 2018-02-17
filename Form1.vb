Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim decClassARevenue As Decimal   'Class A seat Revenue
        Dim decClassBRevenue As Decimal     'Class B seat revenue
        Dim decClassCRevenue As Decimal     ' Class C seat revenue
        Dim decTotalRevenue As Decimal          'Total Revenue 
        Const decCLASSA_PRICE As Decimal = 15D       'class A price
        Const decCLASSB_PRICE As Decimal = 12D       'Class B price
        Const decCLASSC_PRICE As Decimal = 9D        'Class C price

        Try
            'Calculate and display the Class A Seating Revenue
            decClassARevenue = CDec(txtClassAQuantity.Text) * decCLASSA_PRICE
            lblClassARevenue.Text = decClassARevenue.ToString("c")

            'Calculate and display the Class B Seating Revenue
            decClassBRevenue = CDec(txtClassBQuantity.Text) * decCLASSB_PRICE
            lblClassBRevenue.Text = decClassBRevenue.ToString("c")

            'Calculate and display the Class C Seating Revenue
            decClassCRevenue = CDec(txtClassCQuantity.Text) * decCLASSC_PRICE
            lblClassCRevenue.Text = decClassCRevenue.ToString("c")

            'Calculate and display the Total Revenue
            decTotalRevenue = (decClassARevenue + decClassBRevenue + decClassCRevenue)
            lblTotalRevenue.Text = decTotalRevenue.ToString("c")

        Catch
            'Error Message
            MessageBox.Show("All input must be a valid number")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear the Ticket seathing fields.
        txtClassAQuantity.Clear()
        txtClassBQuantity.Clear()
        txtClassCQuantity.Clear()

        'Clear the decRevenue Fields
        lblClassARevenue.Text = String.Empty
        lblClassBRevenue.Text = String.Empty
        lblClassCRevenue.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Close the form
        Me.Close()
    End Sub
End Class
