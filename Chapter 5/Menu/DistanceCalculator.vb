Public Class DistanceCalculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Speed of the vehicle in MPH
        Dim intSpeed As Integer
        Dim strSpeed As String

        'Time in hours
        Dim intTime As Integer
        Dim strTime As String

        'distance
        Dim intTotal As Integer

        'user input
        Dim strInput As String

        'counter variable
        Dim intCount As Integer = 1

        'output 
        Dim strDistance As String

        'prompt the user to enter speed
        strInput = InputBox("What is the speed in miles-per-hour?", "Enter Speed")
    End Sub
End Class