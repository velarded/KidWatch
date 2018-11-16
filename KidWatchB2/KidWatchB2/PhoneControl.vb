Public Class PhoneControl
    Private WithEvents callStopwatch As Stopwatch = New Stopwatch()
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ContactMomButton_Click(sender As Object, e As EventArgs) Handles ContactMomButton.Click
        CallingContactLabel.Text = "Mom"
        CallingContactPicture.BackgroundImage = My.Resources.person1
        SetUpCalling()
    End Sub

    Private Sub ContactDadButton_Click(sender As Object, e As EventArgs) Handles ContactDadButton.Click
        CallingContactLabel.Text = "Dad"
        CallingContactPicture.BackgroundImage = My.Resources.person2
        SetUpCalling()
    End Sub

    Private Sub ContactLillyButton_Click(sender As Object, e As EventArgs) Handles ContactLillyButton.Click
        CallingContactLabel.Text = "Lilly"
        CallingContactPicture.BackgroundImage = My.Resources.person3
        SetUpCalling()
    End Sub

    Private Sub ContactTimmyButton_Click(sender As Object, e As EventArgs) Handles ContactTimmyButton.Click
        CallingContactLabel.Text = "Timmy"
        CallingContactPicture.BackgroundImage = My.Resources.person4
        SetUpCalling()
    End Sub

    Private Sub SetUpCalling()
        StatusLabel.Text = "Calling."
        ContactsPanel.Visible = False
        CallingPanel.BackColor = Color.SaddleBrown
        EndCallButton.Enabled = True
        TimeLabel.Visible = False
        CallingPanel.Location = New Point(0, 0)
        CallingPanel.Visible = True
        WaitingCall()
    End Sub

    Private Sub WaitingCall()
        ' wait 4 seconds before connecting
        Wait(1)
        StatusLabel.Text = "Calling..."
        Wait(1)
        StatusLabel.Text = "Calling....."
        Wait(1)
        StatusLabel.Text = "Calling."
        Wait(1)
        StatusLabel.Text = "Calling..."
        OngoingCall()
    End Sub

    Private Sub OngoingCall()
        StatusLabel.Text = "Connected"
        TimeLabel.Visible = True
        CallingPanel.BackColor = Color.DarkGreen
        CallTimer.Start()
        callStopwatch.Reset()
        callStopwatch.Start()
    End Sub

    Private Sub EndCall()
        CallTimer.Stop()
        callStopwatch.Stop()
        StatusLabel.Text = "Call Ended"
        CallingPanel.BackColor = Color.DimGray
    End Sub

    Private Sub CloseCallPanel()
        CallingPanel.Visible = False
        ContactsPanel.Visible = True
    End Sub

    Private Sub EndCallButton_Click(sender As Object, e As EventArgs) Handles EndCallButton.Click
        EndCallButton.Enabled = False
        EndCall()
        Wait(2)
        CloseCallPanel()
    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub OngoingCallTimer_Tick(sender As Object, e As EventArgs) Handles CallTimer.Tick
        If StatusLabel.Text = "Connected" Then
            TimeLabel.Text = String.Format("{0:00}:{1:00}",
                 callStopwatch.Elapsed.Minutes, callStopwatch.Elapsed.Seconds)
        End If
    End Sub

End Class
