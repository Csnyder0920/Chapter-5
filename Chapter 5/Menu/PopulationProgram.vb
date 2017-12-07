Public Class PopulationProgram
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer
        Dim dblTotal As Double

        lstOutput.Items.Add("Day Approximate Population")
        lstOutput.Items.Add("_________________________________")
        dblTotal = 2
        intCount = 1

        lstOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)

        For intCount = intCount + 1 To cboDays.Text
            dblTotal = CDbl(txtIncrease.Text * dblTotal) / 100) + dblTotal 
            lstOutput.Items.Add(intCount.ToString + " " + dblTotal.ToString)
        Next

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