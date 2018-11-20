Imports KidWatchB2

Public Class PaymentMachine

    Private walletControl As WalletControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As String = Me.TotalLabel.Text.Substring(1)
        Dim totalDouble As Decimal
        Double.TryParse(total, totalDouble)
        walletControl.DeductPaymentTotal(totalDouble)

    End Sub

    Friend Sub Init(walletControl As WalletControl)
        Me.walletControl = walletControl
    End Sub
End Class