Public Class frmRaceCar

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        picCar1.Left += Rnd() * 2
        picCar2.Left += Rnd() * 4

        picCar3.Left += Rnd() * 3
        picCar4.Left += Rnd() * 3

        If Me.picCar1.Left > 1100 Then
            Timer1.Stop()
            Me.btnRace.Enabled = False
            MessageBox.Show("Orange Car Wins!")
            Me.lblOrangeWins.Text = Val(lblOrangeWins.Text) + 1
        End If
        If Me.picCar2.Left > 1100 Then
            Timer1.Stop()
            Me.btnRace.Enabled = False
            MessageBox.Show("Green Car Wins!")
            Me.lblGreenWins.Text = Val(lblGreenWins.Text) + 1
        End If
        If Me.picCar3.Left > 1100 Then
            Timer1.Stop()
            Me.btnRace.Enabled = False
            MessageBox.Show("Blue Car Wins!")
            Me.lblBlueWins.Text = Val(lblBlueWins.Text) + 1
        End If
        If Me.picCar4.Left > 1100 Then
            Timer1.Stop()
            Me.btnRace.Enabled = False
            MessageBox.Show("Red Car Wins!")
            Me.lblRedWins.Text = Val(lblRedWins.Text) + 1
        End If
    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Me.picCar1.Left += 22
    End Sub

    Private Sub btnAceAgain_Click(sender As Object, e As EventArgs) Handles btnAceAgain.Click
        Me.btnRace.Enabled = False
        Me.picCar1.Location = New Point(18, 18)
        Me.picCar2.Location = New Point(18, 155)
        Me.picCar3.Location = New Point(18, 292)
        Me.picCar4.Location = New Point(18, 429)
        Me.btnAceAgain.Visible = False


    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.btnRace.Enabled = True
        Me.btnRace.Visible = True
        Me.btnPlay.Visible = False
        Timer1.Start()
        Me.Select()
    End Sub
End Class