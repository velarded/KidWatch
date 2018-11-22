Public Class ParentMessagesMainControl

    Private WithEvents messageStopWatch As Stopwatch = New Stopwatch()
    Private messageDuration As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        AudioMessageNotificationPanel.Location = New Point(0, 0)
        Panel1.Location = New Point(0, 0)

        AudioMessageNotificationPanel.BringToFront()

    End Sub
    Public Sub receiveAudioMessageOnPhone(messageDuration As String)
        Dim phone As ParentPhone = Me.Parent
        Me.messageDuration = messageDuration
        'Console.WriteLine("Message Duration: " + messageDuration)'
        phone.ParentMessagesMainControl1.BringToFront()
        Me.AudioMessageNotificationPanel.BringToFront()
    End Sub

    Private Sub ListenLabel_Click(sender As Object, e As EventArgs) Handles ListenLabel.Click
        Panel1.BringToFront()
        'TODO'
        ListeningMessage()
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub ListeningMessage()
        Label1.Visible = True
        EndOfAudioMessageLabel.Visible = False
        Timer1.Start()
        messageStopWatch.Reset()
        messageStopWatch.Start()

        Wait(1)
        Label1.Text = "Listening..."
        Wait(1)
        Label1.Text = "Listening....."
        Wait(1)
        Label1.Text = "Listening."
        Wait(1)
        Label1.Text = "Listening..."
    End Sub

    Private Sub ListeningTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AudioMessageListenTimerLabel.Text = String.Format("{0:00}:{1:00}",
        messageStopWatch.Elapsed.Minutes, messageStopWatch.Elapsed.Seconds)
        If (AudioMessageListenTimerLabel.Text.Equals(messageDuration)) Then
            Timer1.Stop()
            Label1.Visible = False
            EndOfAudioMessageLabel.Visible = True
            ListenAgainButton.Visible = True
        End If

    End Sub

    Private Sub CloseListeningPanelButton_Click(sender As Object, e As EventArgs) Handles CloseListeningPanelButton.Click
        Timer1.Stop()
        Dim phone As ParentPhone = Me.Parent
        phone.ParentPhoneMainControl1.BringToFront()
    End Sub

    Private Sub ListenAgainButton_Click(sender As Object, e As EventArgs) Handles ListenAgainButton.Click
        ListeningMessage()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Dim phone As ParentPhone = Me.Parent
        phone.ParentPhoneMainControl1.BringToFront()
    End Sub
End Class
