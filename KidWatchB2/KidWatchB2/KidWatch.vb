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

End Class
