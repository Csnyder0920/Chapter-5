Public Class TestScoreAverage

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        ' This procedure gets the test scores, then calculates and 
        ' displays the average.
        Dim intNumScores As Integer = 5             ' The number of test scores
        Dim dblTestScore As Double                  ' To hold a test score
        Dim dblTotal As Double = 0                  ' Accumulator, intialized to 0
        Dim dblAverage As Double                    ' The average of test scores
        Dim strInput As String                      ' To hold user input    
        Dim intCount As Integer = 1                 ' Counter variable, intialized to 1

        ' Promt the user for the number of  test scores.
        strInput = InputBox("How many test scores do you want to average?")

        ' Convert the input to an integer.
        If Integer.TryParse(strInput, intNumScores) Then

            ' Get the test scores.
            Do Until intCount > intNumScores

                'Prompt the user for a score.
                strInput = InputBox("Enter a test score " & intCount.ToString())

                ' Convert the input to a double.
                If Double.TryParse(strInput, dblTestScore) Then

                    ' Add the score to the accumulator. 
                    dblTotal += dblTestScore

                    ' Add 1 to the counter. 
                    intCount += 1

                    ' Invalid test score. 
                    MessageBox.Show("Enter a numeric test score")
                End If
            Loop

        End If
    End Sub
End Class