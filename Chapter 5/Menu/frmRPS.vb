
Public Class frmRPS
    Dim intUserCount1 As Integer = 0
    Dim NumCount As Integer = 0
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim Num As Integer
        Dim rand As New Random
        lblUserWins.Text = intUserCount1
        lblCompWins.Text = NumCount
        Const Rock = 1
        Const Paper = 2
        Const Scissors = 3
        Num = rand.Next(4)

        If radRock.Checked And Rock = Num Then
            lblResult.Text = "Computer Chose Rock too! You Tie!"
        ElseIf radRock.Checked And Paper = Num Then
            lblResult.Text = "Computer Chose Paper! You Lose!"
            NumCount += 1
        ElseIf radRock.Checked And Scissors = Num Then
            lblResult.Text = "Computer Chose Scissors! You Win!"
            intUserCount1 += 1
        End If

        If radPaper.Checked And Rock = Num Then
            lblResult.Text = "Computer Chose Rock! You Win!"
            intUserCount1 += 1
        ElseIf radPaper.Checked And Paper = Num Then
            lblResult.Text = "Computer Chose Paper! You Tie!"
        ElseIf radPaper.Checked And Scissors = Num Then
            lblResult.Text = "Computer Chose Scissors! You Lose!"
            NumCount += 1
        End If
        If radScissors.Checked And Rock = Num Then
            lblResult.Text = "Computer Chose Rock!You Lose!"
            NumCount += 1
        ElseIf radScissors.Checked And Paper = Num Then
            lblResult.Text = "Computer Chose Paper!You Win!"
            intUserCount1 += 1
        ElseIf radScissors.Checked And Scissors = Num Then
            lblResult.Text = "Computer Chose Scissors!You Tie!"

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
