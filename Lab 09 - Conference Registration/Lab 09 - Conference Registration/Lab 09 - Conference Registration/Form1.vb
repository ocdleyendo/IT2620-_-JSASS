Public Class OptionsForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFormOptions.Click
        ' clear all fields by deselecting items and checkboxes and ressetting global variable
        lstOptions.SelectedItem() = Nothing
        chkConfReg.Checked = False
        chkDinnerKeynote.Checked = False
        MainForm.lblTotal.Text = String.Empty
        g_Total = 0
    End Sub
    Private Sub chkConfReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConfReg.CheckedChanged
        ' checking the checkbox for Conference fee, cannot select
        ' anything else until this checkbox is selected

        If chkConfReg.Checked = True Then
            lstOptions.Enabled = True
            chkDinnerKeynote.Enabled = True
            g_Total = dblCONFERENCE
            MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
        End If
        If chkConfReg.Checked = False Then
            lstOptions.Enabled = False
            chkDinnerKeynote.Enabled = False
            MainForm.lblTotal.Text = String.Empty
        End If
    End Sub
    Public Sub lstOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOptions.SelectedIndexChanged
        Dim strSelected As String
        strSelected = CStr(lstOptions.SelectedItem())
        If chkDinnerKeynote.Checked = True Then
            If strSelected = strIntroEcommerce Then
                g_OptionSelected = dblINTRO_ECOM
                g_Total = dblCONFERENCE + g_OptionSelected + dblDINNER_KEYNOTE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strFutureWeb Then
                g_OptionSelected = dblFUTURE_WEB
                g_Total = dblCONFERENCE + g_OptionSelected + dblDINNER_KEYNOTE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strAdvancedVB Then
                g_OptionSelected = dblADVANCED_VB
                g_Total = dblCONFERENCE + g_OptionSelected + dblDINNER_KEYNOTE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strNetworkSecurity Then
                g_OptionSelected = dblNETWORK_SECURITY
                g_Total = dblCONFERENCE + g_OptionSelected + dblDINNER_KEYNOTE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            End If
        End If

        If chkDinnerKeynote.Checked = False Then
            If strSelected = strIntroEcommerce Then
                g_OptionSelected = dblINTRO_ECOM
                g_Total = dblCONFERENCE + g_OptionSelected
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strFutureWeb Then
                g_OptionSelected = dblFUTURE_WEB
                g_Total = dblCONFERENCE + g_OptionSelected
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strAdvancedVB Then
                g_OptionSelected = dblADVANCED_VB
                g_Total = dblCONFERENCE + g_OptionSelected
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            ElseIf strSelected = strNetworkSecurity Then
                g_OptionSelected = dblNETWORK_SECURITY
                g_Total = dblCONFERENCE + g_OptionSelected
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            End If
        End If
    End Sub
    Private Sub chkDinnerKeynote_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDinnerKeynote.CheckedChanged

        If chkDinnerKeynote.Checked = True Then
            If g_OptionSelected > 0 Then
                g_Total = (g_Total + dblDINNER_KEYNOTE)
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            Else : chkDinnerKeynote.Checked = True
                g_Total = dblCONFERENCE + dblDINNER_KEYNOTE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            End If
        End If
        If chkDinnerKeynote.Checked = False Then
            If g_OptionSelected > 0 Then
                g_Total = dblCONFERENCE + g_OptionSelected
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            Else : chkDinnerKeynote.Checked = False
                g_Total = dblCONFERENCE
                MainForm.lblTotal.Text = CStr(g_Total.ToString("c"))
            End If
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitFormOpt.Click
        Me.Close()
    End Sub
    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.
Load
        g_Total = 0
    End Sub
End Class

