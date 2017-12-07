Public Class PopulationProgram
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Integer
        Dim organisms As Double
        Dim days As Integer
        Dim Increase As Double

        'getting data from form
        organisms = CDbl(cmbOrganism.Text)
        days = CInt(cmbDays.Text)
        Increase = CDbl(txtIncrease.Text)
        Dim lstOutput As New List(Of String)


        'adding data to list box 
        lstOutput.Clear()
        lstOutput.Add("Day" & vbTab & "Approximate Population")
        lstOutput.Add(1 & vbTab & organisms)
        For i = 2 To days

        Next

        'calculating approximate population 
        organisms = organisms + (organisms * Increase) / 100
        lstOutput.Add(i & vbTab & Math.Round(organisms, 2))
        End
    End Sub

    Private Sub tnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbOrganism.Text = String.Empty
        cmbDays.Text = String.Empty
        txtIncrease.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class