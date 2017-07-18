Public Class Form1
    Private Sub SnowyButton_CheckedChanged(sender As Object, e As EventArgs) Handles SnowyButton.CheckedChanged
        WeatherPic.Image = My.Resources.Snow
        WeatherText.Text = "It looks like it's going to be snowy out there, " + NameBox.Text & "."
    End Sub

    Private Sub SunnyButton_CheckedChanged(sender As Object, e As EventArgs) Handles SunnyButton.CheckedChanged
        WeatherPic.Image = My.Resources.Sun
        WeatherText.Text = "Great day to go to the pool, " + NameBox.Text & "."
    End Sub

    Private Sub ChooseWeatherBox_Enter(sender As Object, e As EventArgs) Handles ChooseWeatherBox.Enter

    End Sub

    Private Sub RainyButton_CheckedChanged(sender As Object, e As EventArgs) Handles RainyButton.CheckedChanged
        WeatherPic.Image = My.Resources.Rain
        WeatherText.Text = "Make sure to bring an umbrella today, " + NameBox.Text & "."
    End Sub

    Private Sub CloudyButton_CheckedChanged(sender As Object, e As EventArgs) Handles CloudyButton.CheckedChanged
        WeatherPic.Image = My.Resources.Cloud
        WeatherText.Text = "Today is a bit cloudy and gloomy, " + NameBox.Text & "."
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged

    End Sub

    Private Sub WeatherPic_Click(sender As Object, e As EventArgs) Handles WeatherPic.Click

    End Sub

    Private Sub WeatherText_TextChanged(sender As Object, e As EventArgs) Handles WeatherText.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
