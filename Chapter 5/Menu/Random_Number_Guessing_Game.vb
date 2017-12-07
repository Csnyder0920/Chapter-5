Public Class Random_Number_Guessing_Game
    Dim guesses As Integer
    Dim CG As Integer
    Dim prng As New Random

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'guess

        Dim UG As Integer
        If Integer.TryParse(txtNumber.Text, UG) Then
            guesses = guesses + 1
            If UG = CG Then
                MessageBox.Show("You guessed my Number!")
                btnPlay.Enabled = False

                'some action here to start new game
            ElseIf guesses = 3 Then
                btnPlay.Enabled = False
                Stop
                'end current game here
            ElseIf UG < CG Then
                MessageBox.Show("Your guess is too low")
            ElseIf UG > CG Then
                MessageBox.Show("Your guess is too high.")
            End If
            txtNumber.SelectAll()
        Else
            MessageBox.Show("Please enter a number and try agian")
        End If

    End Sub
End Class