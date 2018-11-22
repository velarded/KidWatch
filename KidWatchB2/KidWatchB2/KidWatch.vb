Public Class KidWatch
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        MenuScreen.BringToFront()
        Wallet.ClosePaymentMachineIfOpen()
        currentTimeLabel.Visible = True
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        PhoneCallScreen.BringToFront()
        Wallet.ClosePaymentMachineIfOpen()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        currentTimeLabel.Text = Date.Now.ToString("hh:mm tt")
    End Sub

    Private Sub VolumeUpButton_Click(sender As Object, e As EventArgs) Handles VolumeUpButton.Click
        VolumePictureBox.BackgroundImage = My.Resources.volumeUp
        VolumePictureBox.BringToFront()
        Wait(1)
        VolumePictureBox.SendToBack()
    End Sub

    Private Sub VolumeDownButton_Click(sender As Object, e As EventArgs) Handles VolumeDownButton.Click
        VolumePictureBox.BackgroundImage = My.Resources.volumeDown
        VolumePictureBox.BringToFront()
        Wait(1)
        VolumePictureBox.SendToBack()
    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

End Class
