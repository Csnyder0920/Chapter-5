Public Class PopulationProgram
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Integer
        Dim Organisms As Integer
        Dim Days As Integer
    End Sub

    Private Sub tnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbOrganisms.Text = String.Empty
        cmbDays.Text = String.Empty
        txtIncrease.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class