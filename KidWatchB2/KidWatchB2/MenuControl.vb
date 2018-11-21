Public Class MenuControl
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub clockButton_Click(sender As Object, e As EventArgs) Handles clockButton.Click
        Dim clockButton As Button = sender
        Dim kidWatch As KidWatch = clockButton.Parent.Parent

        kidWatch.ClockControl1.BringToFront()
        kidWatch.currentTimeLabel.Visible = False


    End Sub

    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        Dim calendarButton As Button = sender
        Dim kidwatch As KidWatch = calendarButton.Parent.Parent
        kidwatch.CalendarControl1.BringToFront()
    End Sub

    Private Sub walletButton_Click(sender As Object, e As EventArgs) Handles walletButton.Click
        Dim walletButton As Button = sender
        Dim kidWatch As KidWatch = walletButton.Parent.Parent

        kidWatch.Wallet.BringToFront()
        kidWatch.Wallet.MainWalletPage.BringToFront()
        kidWatch.Wallet.InitPaymentMachine()
    End Sub

    Private Sub RemindersButton_Click(sender As Object, e As EventArgs) Handles RemindersButton.Click
        Dim reminderButton As Button = sender
        Dim kidWatch As KidWatch = reminderButton.Parent.Parent
        kidWatch.ReminderScreen.BringToFront()
    End Sub
End Class
