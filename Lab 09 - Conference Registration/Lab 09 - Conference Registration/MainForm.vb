Public Class MainForm

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        ' shows the second form (OptionForm)
        OptionsForm.ShowDialog()
    End Sub

    Public Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.
        Click
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        ' Clearing fields in main form
        lblTotal.Text = String.Empty
        txtCity.Text = String.Empty
        txtCompany.Text = String.Empty
        txtEmail.Text = String.Empty
        txtPhone.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty
        txtAddress.Text = String.Empty
        txtName.Text = String.Empty
    End Sub


    Private Sub txtZip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZip.TextChanged
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.
       Click
        Me.Close()
    End Sub

End Class