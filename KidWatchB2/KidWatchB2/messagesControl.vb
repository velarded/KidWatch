Public Class messagesControl

    Private SelectedContact As String

    Public Sub New()
        InitializeComponent()
        ConfirmationPanel.Location = New Point(0, 0)
        PictureMessagePanel.Location = New Point(0, 0)
        ViewMessagePanel.Location = New Point(0, 0)
        RecordAudioMessagePage.Location = New Point(0, 0)
        MessageOptionspanel.Location = New Point(0, 0)
        MessageContactsPanel.Location = New Point(0, 0)
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
        RecordAudioMessagePage.BackColor = Color.DimGray
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
            RecordingContactPictureBox.BackgroundImage = My.Resources.mommeassage
        End If
        RecordAudioMessagePage.BringToFront()
        RecordingMessage()
    End Sub

    Private Sub StopRecordButton_Click(sender As Object, e As EventArgs) Handles StopRecordButton.Click
        ConfirmationPanel.BringToFront()
        Wait(2)
        MessageOptionspanel.BringToFront()
    End Sub
End Class
