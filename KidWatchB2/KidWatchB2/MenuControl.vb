﻿Public Class MenuControl
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
        kidwatch.CalendarControl1.DatePanel.BringToFront()
    End Sub

    Private Sub walletButton_Click(sender As Object, e As EventArgs) Handles walletButton.Click
        Dim walletButton As Button = sender
        Dim kidWatch As KidWatch = walletButton.Parent.Parent

        kidWatch.Wallet.BringToFront()
        kidWatch.Wallet.MainWalletPage.BringToFront()
        kidWatch.Wallet.InitPaymentMachine()
    End Sub

    Private Sub messagesButton_Click(sender As Object, e As EventArgs) Handles messagesButton.Click
        Dim messageButton As Button = sender
        Dim kidWatch As KidWatch = messageButton.Parent.Parent

        kidWatch.MessagesControl1.BringToFront()
        kidWatch.MessagesControl1.MessageContactsPanel.BringToFront()

    End Sub

    Private Sub RemindersButton_Click(sender As Object, e As EventArgs) Handles RemindersButton.Click
        Dim reminderButton As Button = sender
        Dim kidWatch As KidWatch = reminderButton.Parent.Parent
        kidWatch.ReminderScreen.BringToFront()
    End Sub
    
    Private Sub mapsButton_Click(sender As Object, e As EventArgs) Handles mapsButton.Click
        'Create new map control'
        Dim mapButton As Button = sender
        Dim kidWatch As KidWatch = mapButton.Parent.Parent
        kidWatch.MapControl1.BringToFront()
        kidWatch.MapControl1.MainMapsPage.BringToFront()

    End Sub
End Class
