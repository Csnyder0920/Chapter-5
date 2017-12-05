Public Class frmRaceCar
    Dim intOrangeCarCount As Integer
    Dim intGreenCarCount As Integer
    Dim intBlueCarCount As Integer
    Dim intRedCarCount As Integer

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3, intCount4 As Integer
        Dim rand As New Random

        Dim intScore As Integer = 1
        Dim intYouWin As Integer = 10

        For intCount1 = 60 To rand.Next(250) + 450
            picCar1.Left = intCount1
        Next
        For intCount2 = 60 To rand.Next(250) + 450
            picCar2.Left = intCount2
        Next
        For intCount3 = 60 To rand.Next(250) + 450
            picCar3.Left = intCount3
        Next
        For intCount4 = 60 To rand.Next(250) + 450
            picCar4.Left = intCount4
        Next
        If intCount1 > intCount2 And intCount3 And intCount4 Then
            intOrangeCarCount = intOrangeCarCount + 1
            lblOrangeWins.Text = intOrangeCarCount
        End If
        If intCount2 > intCount1 And intCount3 And intCount4 Then
            intGreenCarCount = intGreenCarCount + 1
            lblGreenWins.Text = intGreenCarCount
        End If
        If intCount3 > intCount4 And intCount1 And intCount2 Then
            intBlueCarCount = intBlueCarCount + 1
            lblBlueWins.Text = intBlueCarCount
        End If
        If intCount4 > intCount3 And intCount2 And intCount1 Then
                intRedCarCount = intRedCarCount + 1
                lblRedWins.Text = intRedCarCount
            End If

            If intOrangeCarCount = intYouWin Then
            MessageBox.Show("Orange Car Wins!")
        End If
        If intGreenCarCount = intYouWin Then
            MessageBox.Show("Green Car Wins!")
        End If
        If intBlueCarCount = intYouWin Then
            MessageBox.Show("Blue Car Wins!")
        End If
        If intRedCarCount = intYouWin Then
            MessageBox.Show("Red Car Wins!")
        End If
    End Sub
End Class