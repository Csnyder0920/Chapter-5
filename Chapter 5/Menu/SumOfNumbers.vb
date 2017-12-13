Public Class SumOfNumbers
    Dim strUserInput
    Dim IntUserInput As Integer
    Dim i As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
        If strUserInput <> String.Empty Then
            Try
                intUserInput = CInt(strUserInput)
                If IntUserInput < 0 Then
                    MessageBox.Show("Negative numbers are not accepted.")
                    Exit Sub
                End If

                'IntUserInput = (IntUserInput + i)
                MessageBox.Show("Sum of Numbers", "The sum of numbers" & (i + IntUserInput), MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Quantity amount must be numeric.")
            End Try
            'Show messagebox,
        Else
            MessageBox.Show("Incorrect input", "You must enter a positive integer value", MessageBoxButtons.OK)
            Exit Sub
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class