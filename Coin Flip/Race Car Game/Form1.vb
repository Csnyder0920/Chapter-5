Public Class Race_Car

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Randomize()
        picCar1.Left += Rnd() * 2
        picCar2.Left += Rnd() * 4

        picCar3.Left += Rnd() * 3
        picCar4.Left += Rnd() * 3
    End Sub
End Class
