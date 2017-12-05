Imports Race_Car_Game

Public Class Menu1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCoinFlip.Click
        Dim box = New frmCoinFlip()
        box.Show()
    End Sub

    Private Sub btnRaceCar_Click(sender As Object, e As EventArgs) Handles btnRaceCar.Click
        Dim box = New frmRaceCar()
        box.Show()
    End Sub

    Private Sub btnSumOfNumbers_Click(sender As Object, e As EventArgs) Handles btnSumOfNumbers.Click

    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New frmRPS()
        box.Show
    End Sub
End Class