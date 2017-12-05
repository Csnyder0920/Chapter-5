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

    Private Sub BtnSumOfNumbers_Click(sender As Object, e As EventArgs) Handles btnSumOfNumbers.Click
        Dim box = New frmSum_Numbers()
        box.Show()
    End Sub
End Class