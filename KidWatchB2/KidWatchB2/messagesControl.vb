Public Class messagesControl

    Public Sub New()
        InitializeComponent()

        recordingAudioMessagePanel.Location = New Point(0, 0)
        MessageOptionspanel.Location = New Point(0, 0)
        MessageContactsPanel.Location = New Point(0, 0)
        MessageContactsPanel.BringToFront()
    End Sub
    Private Sub MomMessageButton_Click(sender As Object, e As EventArgs) Handles MomMessageButton.Click
        MessageOptionspanel.BringToFront()
    End Sub
    Private Sub SetUpRecording(name As String, picture As Image)
        RecordingContactLabel.Text = name
        RecordingContactPictureBox.BackgroundImage = picture

        RecordingMessageLabel.Text = "Recording."
        MessageContactsPanel.Visible = False
        recordingAudioMessagePanel.BackColor = Color.SaddleBrown
        StopRecordButton.Enabled = True
        TimeLabel.Visible = False
        recordingAudioMessagePanel.Visible = True

    End Sub

    Private Sub RecordingMessage()
        ' wait 4 seconds before connecting
        Wait(1)
        RecordingMessageLabel.Text = "Recording..."
        Wait(1)
        RecordingMessageLabel.Text = "Recording....."
        Wait(1)
        RecordingMessageLabel.Text = "Recording."
        Wait(1)
        RecordingMessageLabel.Text = "Recording..."
    End Sub
    Private Sub EndRecording()
        MessageTimer.Stop()

        RecordingMessageLabel.Text = "Recording Ended"
        recordingAudioMessagePanel.BackColor = Color.DimGray
    End Sub
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub AudioMessageButton_Click(sender As Object, e As EventArgs) Handles AudioMessageButton.Click
        recordingAudioMessagePanel.BringToFront()
        RecordingMessage()
    End Sub


End Class
