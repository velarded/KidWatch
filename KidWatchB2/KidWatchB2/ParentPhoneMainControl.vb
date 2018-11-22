Public Class ParentPhoneMainControl

    Private WithEvents callStopwatch As Stopwatch = New Stopwatch()

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        StatusLabel.Text = "Calling..."
        CallingPanel.BackColor = Color.PaleTurquoise
        callStopwatch.Reset()
        TimeLabel.Visible = False
        CallingPanel.Visible = True
        CallingPanel.BringToFront()
        Wait(2)
        StatusLabel.Text = "Connected"
        TimeLabel.Visible = True
        Timer1.Start()
        callStopwatch.Start()
    End Sub

    Private Sub StopCallButton_Click(sender As Object, e As EventArgs) Handles StopCallButton.Click
        Timer1.Stop()
        callStopwatch.Stop()
        StatusLabel.Text = "Call Ended"
        CallingPanel.BackColor = Color.DimGray
        Wait(2)
        CallingPanel.Visible = False
        CallingPanel.SendToBack()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If StatusLabel.Text = "Connected" Then
            TimeLabel.Text = String.Format("{0:00}:{1:00}",
                 callStopwatch.Elapsed.Minutes, callStopwatch.Elapsed.Seconds)
        End If
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class
