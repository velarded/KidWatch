Public Class WalletControl
    Private paymentMachine As New PaymentMachine

    Public Sub InitPaymentMachine()
        Me.paymentMachine = New PaymentMachine
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainWalletPage.BringToFront()
        Me.paymentMachine.Close()
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        PaymentPromptPage.BringToFront()
        Me.paymentMachine = New PaymentMachine
        paymentMachine.Init(Me)
        paymentMachine.Show()
    End Sub

    Public Sub DeductPaymentTotal(paymenmtDeduction As Decimal)
        'Check if user has enough money'
        Dim balanceAmountText As String = BalanceAmountLabel.Text.Substring(1)
        Dim balanceAmount As Decimal
        Double.TryParse(balanceAmountText, balanceAmount)
        balanceAmount = balanceAmount - paymenmtDeduction
        If (balanceAmount >= 0) Then
            'Display payment success page'
            PaymentSuccessPage.BringToFront()
            BalanceAmountLabel.Text = "$" + balanceAmount.ToString("F2")
            paymentMachine.Close()
        Else
            'Display payment fail page'
            PaymentFailPage.BringToFront()
        End If

    End Sub

    Private Sub PaymentSuccessOKButton_Click(sender As Object, e As EventArgs) Handles PaymentSuccessOKButton.Click, PaymentFailedOKButton.Click
        MainWalletPage.BringToFront()
        Dim kidWatch As KidWatch = Me.ParentForm
        kidWatch.MenuScreen.BringToFront()
        Me.paymentMachine.Close()
    End Sub

    Public Sub ClosePaymentMachineIfOpen()
        paymentMachine.Close()
    End Sub
End Class
