Public Class CalendarControl
    Public Sub New()
        InitializeComponent()


        DatePanel.Location = New Point(0, 0)
        DailySchedulePanel.Location = New Point(0, 0)
        AppointmentPanel.Location = New Point(0, 0)

        DatePanel.BringToFront()

    End Sub

    Private Sub DailyScheduleButton_Click(sender As Object, e As EventArgs) Handles DailyScheduleButton.Click
        DailySchedulePanel.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppointmentPanel.BringToFront()
    End Sub

    Private Sub AppointmentConfirmButton_Click(sender As Object, e As EventArgs) Handles AppointmentConfirmButton.Click
        DailySchedulePanel.BringToFront()
    End Sub
End Class
