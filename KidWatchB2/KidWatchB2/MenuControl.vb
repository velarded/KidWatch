Public Class MenuControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub walletButton_Click(sender As Object, e As EventArgs) Handles walletButton.Click
        Dim walletButton As Button = sender
        Dim kidWatch As KidWatch = walletButton.Parent.Parent

        kidWatch.Wallet.BringToFront()
    End Sub
End Class
