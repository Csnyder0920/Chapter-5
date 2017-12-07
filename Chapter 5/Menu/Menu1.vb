

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
        Dim box = New SumOfNumbers()
        box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New frmRPS()
        box.Show()
    End Sub

    Private Sub btnRunningTotal_Click(sender As Object, e As EventArgs) Handles btnRunningTotal.Click
        Dim box = New RunningTotal1()
        box.Show()
    End Sub

    Private Sub btnTestScoreAverage_Click(sender As Object, e As EventArgs) Handles btnTestScoreAverage.Click
        Dim box = New TestScoreAverage1()
        box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDistanceCalculator_Click(sender As Object, e As EventArgs) Handles btnDistanceCalculator.Click
        Dim box = New DistanceCalculator()
        box.Show()
    End Sub

    Private Sub btnPopulationProgram_Click(sender As Object, e As EventArgs) Handles btnPopulationProgram.Click
        Dim box = New PopulationProgram()
        box.Show()
    End Sub
End Class