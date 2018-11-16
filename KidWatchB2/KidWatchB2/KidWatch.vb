Public Class KidWatch
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        MenuScreen.BringToFront()
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        PhoneCallScreen.BringToFront()
    End Sub


End Class
