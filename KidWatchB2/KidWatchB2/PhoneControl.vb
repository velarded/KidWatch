Public Class PhoneControl
    Private WithEvents callStopwatch As Stopwatch = New Stopwatch()
    Public Sub New()
        InitializeComponent()
        ReceiveCallPanel.Location = New Point(0, 0)
        CallingPanel.Location = New Point(0, 0)
        VoicemailPanel.Location = New Point(0, 0)
        ContactsPanel.Location = New Point(0, 0)
        ContactsPanel.BringToFront()
    End Sub

    ' CALL THIS TO TRIGGER DAD CALLING
    Public Sub CallKidWatch()
        ReceiveCall()
        Me.BringToFront()
    End Sub

    ' Call this if dad hangs up
    Public Sub EndCallKidWatch(sender As Object)
        Dim kidForm As KidWatch = Me.ParentForm
        EndCall()
        If sender.Name.Equals(Me.Name) Then
            kidForm.mainForm.parentPhone.ParentPhoneMainControl1.EndParentCall(Me)
        Else
            Wait(2)
        End If
        CloseCallPanel()
    End Sub

    Public Sub ConnectCallKidWatch()
        OngoingCall()
    End Sub

    ' Mom will NOT pick up. TODO: Automatic transfer to Dad
    Private Sub ContactMomButton_Click(sender As Object, e As EventArgs) Handles ContactMomButton.Click
        Dim pickup = False
        Dim transfer = True
        SetUpCalling("Mom", My.Resources.person1, pickup, transfer)
    End Sub

    ' Dad will pick up
    Private Sub ContactDadButton_Click(sender As Object, e As EventArgs) Handles ContactDadButton.Click, SOSButton.Click
        SetUpCalling("Dad", My.Resources.person2)
    End Sub

    ' Friend will NOT answer. TODO: leave message
    Private Sub ContactLilyButton_Click(sender As Object, e As EventArgs) Handles ContactLilyButton.Click
        Dim pickup = False
        Dim transfer = False ' will leave message and no transfer
        SetUpCalling("Lily", My.Resources.person3, pickup, transfer)
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
        CallingPanel.Visible = True
        WaitingCall(name, pickUp, transfer)
    End Sub

    Private Sub WaitingCall(name As String, Optional pickUp As Boolean = True, Optional ByVal transfer As Boolean = False)
        If name = "Dad" Then
            StatusLabel.Text = "Calling..."
            Dim kidForm As KidWatch = Me.ParentForm
            kidForm.mainForm.parentPhone.ParentPhoneMainControl1.ReceiveParentCall()
        Else
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
                If transfer = True Then
                    ' transfer to Dad
                    StatusLabel.Text = "Transfering"
                    Wait(2)
                    SetUpCalling("Dad", My.Resources.person2)
                Else
                    ' leave message
                    SendToVoicemail()
                End If
            End If
        End If
    End Sub

    Private Sub OngoingCall()
        StatusLabel.Text = "Connected"
        CallingPanel.BackColor = Color.DarkGreen
        StopCallButton.Enabled = True
        CallTimer.Start()
        callStopwatch.Reset()
        callStopwatch.Start()
        TimeLabel.Visible = True
    End Sub

    Private Sub SendToVoicemail()
        LeaveMsgLabel.Visible = True
        LeaveMsgLabel.BringToFront()
        StopCallButton.Enabled = True
        CallTimer.Start()
        callStopwatch.Reset()
        callStopwatch.Start()
        TimeLabel.Visible = True
    End Sub

    Private Sub EndCall()
        CallTimer.Stop()
        callStopwatch.Stop()
        LeaveMsgLabel.Visible = False
        StatusLabel.Text = "Call Ended"
        CallingPanel.BackColor = Color.DimGray
    End Sub

    Private Sub CloseCallPanel()
        CallingPanel.Visible = False
        ContactsPanel.Visible = True
        Dim kidWatch As KidWatch = Me.ParentForm
        kidWatch.MenuScreen.BringToFront()
    End Sub

    Private Sub EndCallButton_Click(sender As Object, e As EventArgs) Handles StopCallButton.Click
        StopCallButton.Enabled = False
        EndCallKidWatch(Me)
    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub OngoingCallTimer_Tick(sender As Object, e As EventArgs) Handles CallTimer.Tick
        If StatusLabel.Text = "Connected" Or CallingContactLabel.Text = "Lily" Then
            TimeLabel.Text = String.Format("{0:00}:{1:00}",
                 callStopwatch.Elapsed.Minutes, callStopwatch.Elapsed.Seconds)
        End If

        If VoicemailPanel.Visible = True Then
            VoicemailTimeLabel.Text = String.Format("{0:00}:{1:00}",
                 callStopwatch.Elapsed.Minutes, callStopwatch.Elapsed.Seconds)
        End If

        ' drop the call after 10 seconds if no pick up
        If ReceiveCallPanel.Visible = True Then
            If callStopwatch.Elapsed.Seconds >= 10 Then
                CallTimer.Stop()
                callStopwatch.Stop()
                NoAnswer()
            End If
        End If

    End Sub

    Private Sub VoicemailButton_Click(sender As Object, e As EventArgs) Handles VoicemailButton.Click
        callStopwatch.Reset()
        ContactsPanel.Visible = False
        VoicemailPanel.Visible = True
        CallTimer.Start()
        callStopwatch.Start()
    End Sub

    Private Sub CloseVoicemailButton_Click(sender As Object, e As EventArgs) Handles CloseVoicemailButton.Click
        callStopwatch.Stop()
        VoicemailPanel.Visible = False
        ContactsPanel.Visible = True
        CloseCallPanel()
    End Sub

    ' Receive call from Dad
    Private Sub ReceiveCall()
        ContactsPanel.Visible = False
        ReceiveCallPanel.BackColor = Color.Goldenrod
        ReceiveCallPanel.Visible = True
        CallerLabel.Text = "Dad"
        CallerPictureBox.BackgroundImage = My.Resources.person2

        PickUpButton.Enabled = True
        DeclineButton.Enabled = True

        ' call timer and wait 5 seconds
        CallTimer.Start()
        callStopwatch.Reset()
        callStopwatch.Start()
    End Sub

    'Pick up call from dad
    Private Sub PickUpButton_Click(sender As Object, e As EventArgs) Handles PickUpButton.Click
        ReceiveCallPanel.Visible = False
        CallingPanel.Visible = True

        Dim watch As KidWatch = Me.Parent

        Dim mainform As MainForm = watch.mainForm
        mainform.parentPhone.ParentPhoneMainControl1.ConnectParentCall()

        StatusLabel.Text = "Connected"
        CallingContactLabel.Text = "Dad"
        CallingContactPictureBox.BackgroundImage = My.Resources.person2
        OngoingCall()
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs) Handles DeclineButton.Click
        NoAnswer()
    End Sub

    Private Sub NoAnswer()
        ReceiveCallPanel.BackColor = Color.DimGray
        PickUpButton.Enabled = False
        DeclineButton.Enabled = False
        EndCallKidWatch(Me)
        Wait(2)
        ReceiveCallPanel.Visible = False
        ContactsPanel.Visible = True
    End Sub

End Class
