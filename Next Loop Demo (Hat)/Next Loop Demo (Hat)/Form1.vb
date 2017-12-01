Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer      ' Loop counter

        ' Move the image across the form.
        For intCount = 16 To 328
            picSpinnerHat.Left = intCount
        Next
        For intCount = 16 To 328
        Next
        For intCount = 16 To 328
        Next
        For intCount = 16 To 328
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
