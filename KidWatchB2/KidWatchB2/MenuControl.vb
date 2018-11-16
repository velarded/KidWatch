Public Class MenuControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub calendarButton_Click(sender As Object, e As EventArgs) Handles calendarButton.Click
        Dim calendarButton As Button = sender
        Dim kidwatch As KidWatch = calendarButton.Parent.Parent
        kidwatch.CalendarControl1.BringToFront()

    End Sub
End Class
