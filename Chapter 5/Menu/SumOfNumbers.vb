Public Class SumOfNumbers


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim i As Integer

        strUserInput = InputBox("Enter a positive integer value", "Input Needed", 10)
        If strUserInput <> String.Empty Then
            Try
                IntUserInput = CInt(IntUserInput)
                If IntUserInput < 0 Then
                    MessageBox.Show("Negative numbers are not accepted.")
                    Exit Sub
                End If
                'IntUserInput = (IntUserInput + i)
                MessageBox.Show("Sum of numbers", "The Sum of numbers" & (i + IntUserInput), MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Quanity amount must be numeric.")
            End Try
            'Show Messagebox,
        Else
            MessageBox.Show("Incorrect input", "You must enter a positive integer value" & (i + IntUserInput), MessageBoxButtons.OK)
            Exit Sub
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class