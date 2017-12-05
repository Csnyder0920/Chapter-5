Public Class frmSum_Numbers
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intCount As Integer
        Dim intNUM_INTS As Integer
        Dim strInput As String
        Dim decVal As Decimal
        Dim decSum As Decimal

        Do While intCount <= intNUM_INTS
            strInput = InputBox("Enter a positive integer value. " & intCount.ToString())
            If Decimal.TryParse(strInput, decVal) Then
                ' decVal = decSum 
                decSum = decSum + decVal
                ' intCount += 1
                intCount = intCount + 1
            Else
                MessageBox.Show("Enter a numeric value.")
            End If
        Loop
        MessageBox.Show(" The sum of the numbers 1 through " & "is " & intCount.ToString())
    End Sub
End Class
