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
End Class
