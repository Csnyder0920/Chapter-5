
Public Class frmRPS
    Dim intUserCount1 As Integer = 0
    Dim intCompCount As Integer = 0
    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim num As Integer
        Dim intComp As Integer
        Const Rock = 1
        Const Paper = 2
        Const Scissors = 3
        num = CInt((3 * Rnd()))

        If radRock.Checked And intComp = Rock Then
            lblResult.Text = "Computer Chose Rock too! You Tie!"
        ElseIf radRock.Checked And intComp = Paper Then
            lblResult.Text = "Computer Chose Paper! You Lose!"
            intCompCount += 1
        ElseIf radRock.Checked And intComp = Scissors Then
            lblResult.Text = "Computer Chose Scissors! You Win!"
            intUserCount1 += 1
        ElseIf radPaper.Checked And intComp = Rock Then
            lblResult.Text = "Computer Chose Rock! You Win!"
            intUserCount1 += 1
        ElseIf radPaper.Checked And intComp = Paper Then
            lblResult.Text = "Computer Chose Paper! You Tie!"
        ElseIf radPaper.Checked And intComp = Scissors Then
            lblResult.Text = "Computer Chose Scissors! You Lose!"
            intCompCount += 1
        ElseIf radScissors.Checked And intComp = Rock Then
            lblResult.Text = "Computer Chose Rock!You Lose!"
        ElseIf radScissors.Checked And intComp = Scissors Then
            lblResult.Text = "Computer Chose Paper!You Win!"
            intUserCount1 += 1
        ElseIf radScissors.Checked And intComp = Scissors Then
            lblResult.Text = "Computer Chose Scissors!You Tie!"
            intCompCount += 1
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
