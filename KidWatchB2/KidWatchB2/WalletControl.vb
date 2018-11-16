Public Class WalletControl

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainWalletPage.BringToFront()
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        PaymentPromptPage.BringToFront()
    End Sub
End Class
