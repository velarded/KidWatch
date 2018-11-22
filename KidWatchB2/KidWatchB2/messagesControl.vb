Public Class messagesControl

    Private SelectedContact As String
    Private WithEvents messageStopwatch As Stopwatch = New Stopwatch()
    Public Sub New()
        InitializeComponent()
        ConfirmationPanel.Location = New Point(0, 0)
        PictureMessagePanel.Location = New Point(0, 0)
        ViewMessagePanel.Location = New Point(0, 0)
        RecordAudioMessagePage.Location = New Point(0, 0)
        MessageOptionspanel.Location = New Point(0, 0)
        MessageContactsPanel.Location = New Point(0, 0)
        ListeningAudioMessagePanel.Location = New Point(0, 0)
        viewPicturePanel.Location = New Point(0, 0)
        MessageContactsPanel.BringToFront()
    End Sub
    Private Sub MomMessageButton_Click(sender As Object, e As EventArgs) Handles MomMessageButton.Click
        MessageOptionspanel.BringToFront()
        SelectedContact = "Mom"
    End Sub
    Private Sub SetUpRecording(name As String, picture As Image)
        RecordingContactLabel.Text = name
        RecordingContactPictureBox.BackgroundImage = picture

        RecordingMessageLabel.Text = "Recording."
        MessageContactsPanel.Visible = False
        RecordAudioMessagePage.BackColor = Color.SaddleBrown
        StopRecordButton.Enabled = True
        TimeLabel.Visible = False
        RecordAudioMessagePage.Visible = True

    End Sub

    Private Sub RecordingMessage()
        MessageTimer.Start()
        messageStopwatch.Reset()
        messageStopwatch.Start()

        Wait(1)
        RecordingMessageLabel.Text = "Recording..."
        Wait(1)
        RecordingMessageLabel.Text = "Recording....."
        Wait(1)
        RecordingMessageLabel.Text = "Recording."
        Wait(1)
        RecordingMessageLabel.Text = "Recording..."
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub AudioMessageButton_Click(sender As Object, e As EventArgs) Handles AudioMessageButton.Click
        RecordingContactLabel.Text = SelectedContact

        If (SelectedContact.Equals("Mom")) Then
            RecordingContactPictureBox.BackgroundImage = My.Resources.person1
        End If
        If (SelectedContact.Equals("Dad")) Then
            RecordingContactPictureBox.BackgroundImage = My.Resources.person2
        End If
        If (SelectedContact.Equals("Lily")) Then
            RecordingContactPictureBox.BackgroundImage = My.Resources.person3
        End If
        If (SelectedContact.Equals("Timmy")) Then
            RecordingContactPictureBox.BackgroundImage = My.Resources.person4
        End If
        RecordAudioMessagePage.BringToFront()
        RecordingMessage()
    End Sub

    Private Sub StopRecordButton_Click(sender As Object, e As EventArgs) Handles StopRecordButton.Click
        MessageTimer.Stop()


        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()

        Dim kidWatch As KidWatch = Me.Parent
        kidWatch.mainForm.parentPhone.ParentMessagesMainControl1.receiveAudioMessageOnPhone(TimeLabel.Text)

    End Sub

    Private Sub DadMessageButton_Click(sender As Object, e As EventArgs) Handles DadMessageButton.Click
        MessageOptionspanel.BringToFront()
        SelectedContact = "Dad"
    End Sub

    Private Sub LilyMessageButton_Click(sender As Object, e As EventArgs) Handles LilyMessageButton.Click
        MessageOptionspanel.BringToFront()
        SelectedContact = "Lily"
    End Sub

    Private Sub TimmyMessageButton_Click(sender As Object, e As EventArgs) Handles TimmyMessageButton.Click
        MessageOptionspanel.BringToFront()
        SelectedContact = "Timmy"
    End Sub

    Private Sub pictureMessageButton_Click(sender As Object, e As EventArgs) Handles pictureMessageButton.Click
        PictureMessagePanel.BringToFront()
    End Sub

    Private Sub ViewMessagesButton_Click(sender As Object, e As EventArgs) Handles ViewMessagesButton.Click
        ViewMessagePanel.BringToFront()
    End Sub

    Private Sub Picture1_Click(sender As Object, e As EventArgs) Handles Picture1.Click
        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub

    Private Sub Picture2_Click(sender As Object, e As EventArgs) Handles Picture2.Click
        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub

    Private Sub Picture3_Click(sender As Object, e As EventArgs) Handles Picture3.Click
        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub

    Private Sub Picture4_Click(sender As Object, e As EventArgs) Handles Picture4.Click
        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub

    Private Sub ListeningTimer_Tick(sender As Object, e As EventArgs) Handles MessageTimer.Tick

        ListeningTimeLabel.Text = String.Format("{0:00}:{1:00}",
                 messageStopwatch.Elapsed.Minutes, messageStopwatch.Elapsed.Seconds)
    End Sub

    Private Sub ListenMessageButton_Click(sender As Object, e As EventArgs) Handles ListenMessageButton.Click

        ListeningContactLabel.Text = SelectedContact
        If (SelectedContact.Equals("Mom")) Then
            ListeningContactPictureBox.BackgroundImage = My.Resources.person1
        End If
        If (SelectedContact.Equals("Dad")) Then
            ListeningContactPictureBox.BackgroundImage = My.Resources.person2
        End If
        If (SelectedContact.Equals("Lily")) Then
            ListeningContactPictureBox.BackgroundImage = My.Resources.person3
        End If
        If (SelectedContact.Equals("Timmy")) Then
            ListeningContactPictureBox.BackgroundImage = My.Resources.person4
        End If
        ListeningAudioMessagePanel.BringToFront()
        ListeningMessage()

    End Sub
    Private Sub ListeningMessage()
        MessageTimer.Start()
        messageStopwatch.Reset()
        messageStopwatch.Start()

        Wait(1)
        ListeningMessageLabel.Text = "Listening..."
        Wait(1)
        ListeningMessageLabel.Text = "Listening....."
        Wait(1)
        ListeningMessageLabel.Text = "Listening."
        Wait(1)
        ListeningMessageLabel.Text = "Listening..."
    End Sub

    Private Sub EndListeningButton_Click(sender As Object, e As EventArgs) Handles EndListeningButton.Click
        ViewMessagePanel.BringToFront()
        MessageTimer.Stop()
        Wait(2)
        MessageOptionspanel.BringToFront()


    End Sub
    Private Sub RecordingTimer_Tick(sender As Object, e As EventArgs) Handles MessageTimer.Tick

        TimeLabel.Text = String.Format("{0:00}:{1:00}",
                 messageStopwatch.Elapsed.Minutes, messageStopwatch.Elapsed.Seconds)
    End Sub

    Private Sub BackButtonButton_Click(sender As Object, e As EventArgs) Handles BackButtonButton.Click
        ViewMessagePanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub

    Private Sub viewPictureMessageButton_Click(sender As Object, e As EventArgs) Handles viewPictureMessageButton.Click
        viewPicturePanel.BringToFront()
    End Sub
End Class
