Public Class Form1


    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        txtCountry.Text = cboCountries.Text
        txtPlay.Text = cboPlays.Text
        txtArtist.Text = cboArtists.Text

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
