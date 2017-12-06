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
        'Comvert the input to a decimal.
        If Decimal.TryParse(strInput, intSpeed) Then

            'prompt the user to enter hours
            strInput = InputBox("What is the amount of time in hours?" & intCount.ToString(), "Enter Time.")

            'Convert the input to a decimal
            If Decimal.TryParse(strInput, intTime) Then

                'Create a string to display the speed and time.
                strSpeed = "Vehicle Speed: " & intSpeed.ToString() & "MPH: "
                strTime = "Time Traveled: " & intTime.ToString() & " hours"

                'Insert speed and time to list box
                lstCalculations.Items.Insert(0, strSpeed)
                lstCalculations.Items.Insert(1, strTime)

                'Create a heading
                lstCalculations.Items.Insert(2, "Hours" & "    " & "Distance Traveled")

                'Insert a line
                lstCalculations.Items.Insert(3, "____________________")

                'Calculate the distance
                Do Until intCount > intTime
                    intTotal = intSpeed * intCount

                    'Create a string to display the distance
                    strDistance = intCount.ToString() & "            " & intTotal.ToString()

                    'add the string to the list box
                    lstCalculations.Items.Add(strDistance)

                    'add 1 to the counter
                    intCount += 1
                Loop

                'add total distance
                lstCalculations.Items.Add("Total Distance: " & intSpeed * intTime)
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class