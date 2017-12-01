Public Class Form1
    Dim tailsTotal As Integer = 0
    Dim headsTotal As Integer = 0
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer
        Dim intCount As Integer
        Dim rand As New Random

        intSideUp = rand.Next(2)
        If intSideUp = 0 Then
            picHeads.Visible = True
            picTails.Visible = False
            tailsTotal = 1 + tailsTotal

        Else
            picTails.Visible = True
            picHeads.Visible = False
            headsTotal = 1 + headsTotal

        End If
        lblTotalHeads.Text = tailsTotal.ToString("n")
        lblTotalTails.Text = headsTotal.ToString("n")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
