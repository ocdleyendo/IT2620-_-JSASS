Public Class Form1
    Dim blnStatus As Boolean

    Private Sub btnTestPassword_Click(sender As Object, e As EventArgs) Handles btnTestPassword.Click

        If IsValid(blnStatus) = True Then
            MessageBox.Show("You entered a valid password!  Great job")
        Else
            MessageBox.Show("Please enter a valid password")

        End If
    End Sub

    Function IsValid(ByVal strPassword As String) As Boolean
        strPassword = txtPassword.Text
        Dim L = strPassword.Length
        Dim Length, HasNumber, HasLetter As Boolean
        Dim WordSplit As String
        Dim i As Integer
        'Dim Password As String

        If (strPassword.Trim.Length >= 6) Then
            Length = True
        Else
            Length = False
        End If

        If L >= 6 Then
            i = 0
            For i = 1 To L
                WordSplit = Mid(strPassword, i, 1)
                If IsNumeric(WordSplit) = True Then
                    HasNumber = True
                    Exit For
                End If
            Next
            i = 0

            For i = 1 To L
                WordSplit = Mid(strPassword, i, 1)
                If IsNumeric(WordSplit) = False Then
                    HasLetter = True
                    Exit For
                End If
            Next

        End If

        If HasNumber = True And HasLetter = True And Length = True Then
            'If Length = True And HasNumber = True Then
            blnStatus = True
        Else blnStatus = False
        End If
        'TryParse.txtPassword.Text to 
        'If Char.IsLetter(txtPassword.Text.Chars(txtPassword.Text - 5)) = True Then
        'ElseIf IsNumeric(txtPassword) Then
        'ElseIf (strPassword.Trim.Length >= 6) Then
        '    blnStatus = True
        'Else
        '    blnStatus = False
        'End If

        Return blnStatus
    End Function




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

