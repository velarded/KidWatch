Public Class PhoneControl
    Private WithEvents callStopwatch As Stopwatch = New Stopwatch()
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Mom will NOT pick up. TODO: Automatic transfer to Dad
    Private Sub ContactMomButton_Click(sender As Object, e As EventArgs) Handles ContactMomButton.Click
        Dim pickup = False
        Dim transfer = True
        SetUpCalling("Mom", My.Resources.person1, pickup, transfer)
    End Sub

    ' Dad will pick up
    Private Sub ContactDadButton_Click(sender As Object, e As EventArgs) Handles ContactDadButton.Click
        SetUpCalling("Dad", My.Resources.person2)
    End Sub

    ' Friend will NOT answer. TODO: leave message
    Private Sub ContactLillyButton_Click(sender As Object, e As EventArgs) Handles ContactLillyButton.Click
        Dim pickup = False
        Dim transfer = False ' will leave message and no transfer
        SetUpCalling("Lilly", My.Resources.person3, pickup, transfer)
    End Sub

    ' Friend will answer just like Dad
    Private Sub ContactTimmyButton_Click(sender As Object, e As EventArgs) Handles ContactTimmyButton.Click
        SetUpCalling("Timmy", My.Resources.person4)
    End Sub

    Private Sub SetUpCalling(name As String, picture As Image, Optional pickUp As Boolean = True, Optional ByVal transfer As Boolean = False)
        CallingContactLabel.Text = name
        CallingContactPictureBox.BackgroundImage = picture

        StatusLabel.Text = "Calling."
        ContactsPanel.Visible = False
        CallingPanel.BackColor = Color.SaddleBrown
        StopCallButton.Enabled = True
        TimeLabel.Visible = False
        CallingPanel.Location = New Point(0, 0)
        CallingPanel.Visible = True
        WaitingCall(pickUp)
    End Sub

    Private Sub WaitingCall(Optional pickUp As Boolean = True, Optional ByVal transfer As Boolean = False)
        ' wait 4 seconds before connecting
        Wait(1)
        StatusLabel.Text = "Calling..."
        Wait(1)
        StatusLabel.Text = "Calling....."
        Wait(1)
        StatusLabel.Text = "Calling."
        Wait(1)
        StatusLabel.Text = "Calling..."
        If pickUp Then
            OngoingCall()
        Else
            If transfer Then
                ' transfer to Dad
                StatusLabel.Text = "Transfer."
            Else
                ' leave message
                StatusLabel.Text = "Leave message."
            End If
        End If
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

    Private Sub EndCallButton_Click(sender As Object, e As EventArgs) Handles StopCallButton.Click
        StopCallButton.Enabled = False
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
