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

End Class
