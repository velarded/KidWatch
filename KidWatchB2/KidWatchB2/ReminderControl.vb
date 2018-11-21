Public Class ReminderControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' CALL THIS TO POP UP THE REMINDER IN THE WATCH (after 2 seconds)
    Public Sub PopupReminder()
        Wait(2)
        HmwkPopupPanel.BringToFront()
        Me.BringToFront()
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        HmwkPopupDetailsPanel.BringToFront()
    End Sub

    Private Sub OpenReminderButton_Click(sender As Object, e As EventArgs) Handles OpenReminderButton.Click
        HmwkDetailsPanel.BringToFront()
    End Sub

    ' The ok button when the hmwk details is opened manually
    Private Sub OKButton1_Click(sender As Object, e As EventArgs) Handles OKButton1.Click
        RemindersPanel.BringToFront()
    End Sub

    ' The ok buttons when the reminder pops up (1 on popup, 1 after clicking details)
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton2.Click, OKButton3.Click
        RemindersPanel.BringToFront()
        Me.SendToBack()
    End Sub

    ' The snooze buttons when the reminder pops up (1 on popup, 1 after clicking details)
    Private Sub SnoozeButton_Click(sender As Object, e As EventArgs) Handles SnoozeButton1.Click, SnoozeButton2.Click
        RemindersPanel.BringToFront()
        Me.SendToBack()
        ' TODO: put timer to pop up again?
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

End Class
