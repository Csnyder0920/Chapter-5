Public Class SumOfNumbers


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUserInput
        Dim IntUserInput As Integer
        Dim intCount As Integer = 0
        Dim intNumScore As Integer

        strUserInput = InputBox("Enter a positive integer value", "Input Needed", "10")
        If Integer.TryParse(strUserInput, IntUserInput) Then
            If IntUserInput < 0 Then
                MessageBox.Show("Please input a positive number.")
            Else
                Do Until intCount = IntUserInput
                    strUserInput += 1
                    intNumScore += intCount
                Loop
                MessageBox.Show("The sum of the numbers 1 through " & " is " & intNumScore)
            End If
        Else
            MessageBox.Show("Please input a valid number.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class