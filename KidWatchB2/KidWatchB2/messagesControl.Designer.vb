<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class messagesControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MessageOptionspanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AudioMessageButton = New System.Windows.Forms.Button()
        Me.ViewMessagesButton = New System.Windows.Forms.Button()
        Me.recordingAudioMessagePanel = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StopRecordButton = New System.Windows.Forms.Button()
        Me.RecordingContactLabel = New System.Windows.Forms.Label()
        Me.RecordingMessageLabel = New System.Windows.Forms.Label()
        Me.MessageContactsPanel = New System.Windows.Forms.Panel()
        Me.MessageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ConfirmationPanel = New System.Windows.Forms.Panel()
        Me.MessageSentLabel = New System.Windows.Forms.Label()
        Me.PictureMessagePanel = New System.Windows.Forms.Panel()
        Me.SelectPictureLabel = New System.Windows.Forms.Label()
        Me.Picture3 = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Button()
        Me.Picture2 = New System.Windows.Forms.Button()
        Me.Picture4 = New System.Windows.Forms.Button()
        Me.CheckMarkPictureBox = New System.Windows.Forms.PictureBox()
        Me.RecordingContactPictureBox = New System.Windows.Forms.PictureBox()
        Me.LilyMessageButton = New System.Windows.Forms.Button()
        Me.MomMessageButton = New System.Windows.Forms.Button()
        Me.TimmyMessageButton = New System.Windows.Forms.Button()
        Me.DadMessageButton = New System.Windows.Forms.Button()
        Me.ViewMessagePanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListenMessageButton = New System.Windows.Forms.Button()
        Me.MessageOptionspanel.SuspendLayout()
        Me.recordingAudioMessagePanel.SuspendLayout()
        Me.MessageContactsPanel.SuspendLayout()
        Me.ConfirmationPanel.SuspendLayout()
        Me.PictureMessagePanel.SuspendLayout()
        CType(Me.CheckMarkPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewMessagePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageOptionspanel
        '
        Me.MessageOptionspanel.AutoSize = True
        Me.MessageOptionspanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MessageOptionspanel.Controls.Add(Me.Button1)
        Me.MessageOptionspanel.Controls.Add(Me.Button3)
        Me.MessageOptionspanel.Controls.Add(Me.AudioMessageButton)
        Me.MessageOptionspanel.Controls.Add(Me.ViewMessagesButton)
        Me.MessageOptionspanel.Location = New System.Drawing.Point(0, 474)
        Me.MessageOptionspanel.Name = "MessageOptionspanel"
        Me.MessageOptionspanel.Size = New System.Drawing.Size(116, 101)
        Me.MessageOptionspanel.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Send Picture "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 25)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Send Video"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AudioMessageButton
        '
        Me.AudioMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioMessageButton.Location = New System.Drawing.Point(14, 25)
        Me.AudioMessageButton.Name = "AudioMessageButton"
        Me.AudioMessageButton.Size = New System.Drawing.Size(87, 23)
        Me.AudioMessageButton.TabIndex = 1
        Me.AudioMessageButton.Text = "Send Audio "
        Me.AudioMessageButton.UseVisualStyleBackColor = True
        '
        'ViewMessagesButton
        '
        Me.ViewMessagesButton.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMessagesButton.Location = New System.Drawing.Point(5, 2)
        Me.ViewMessagesButton.Name = "ViewMessagesButton"
        Me.ViewMessagesButton.Size = New System.Drawing.Size(107, 23)
        Me.ViewMessagesButton.TabIndex = 0
        Me.ViewMessagesButton.Text = "View Messages"
        Me.ViewMessagesButton.UseVisualStyleBackColor = True
        '
        'recordingAudioMessagePanel
        '
        Me.recordingAudioMessagePanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.recordingAudioMessagePanel.Controls.Add(Me.TimeLabel)
        Me.recordingAudioMessagePanel.Controls.Add(Me.StopRecordButton)
        Me.recordingAudioMessagePanel.Controls.Add(Me.RecordingContactLabel)
        Me.recordingAudioMessagePanel.Controls.Add(Me.RecordingContactPictureBox)
        Me.recordingAudioMessagePanel.Controls.Add(Me.RecordingMessageLabel)
        Me.recordingAudioMessagePanel.Location = New System.Drawing.Point(0, 590)
        Me.recordingAudioMessagePanel.Name = "recordingAudioMessagePanel"
        Me.recordingAudioMessagePanel.Size = New System.Drawing.Size(116, 100)
        Me.recordingAudioMessagePanel.TabIndex = 15
        Me.recordingAudioMessagePanel.Visible = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.Location = New System.Drawing.Point(57, 25)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(55, 24)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "00:00"
        '
        'StopRecordButton
        '
        Me.StopRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopRecordButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopRecordButton.Location = New System.Drawing.Point(33, 67)
        Me.StopRecordButton.Name = "StopRecordButton"
        Me.StopRecordButton.Size = New System.Drawing.Size(45, 32)
        Me.StopRecordButton.TabIndex = 14
        Me.StopRecordButton.Text = "End"
        Me.StopRecordButton.UseVisualStyleBackColor = True
        '
        'RecordingContactLabel
        '
        Me.RecordingContactLabel.AutoSize = True
        Me.RecordingContactLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordingContactLabel.ForeColor = System.Drawing.Color.White
        Me.RecordingContactLabel.Location = New System.Drawing.Point(46, 43)
        Me.RecordingContactLabel.Name = "RecordingContactLabel"
        Me.RecordingContactLabel.Size = New System.Drawing.Size(73, 24)
        Me.RecordingContactLabel.TabIndex = 13
        Me.RecordingContactLabel.Text = "Contact"
        '
        'RecordingMessageLabel
        '
        Me.RecordingMessageLabel.AutoSize = True
        Me.RecordingMessageLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordingMessageLabel.ForeColor = System.Drawing.Color.White
        Me.RecordingMessageLabel.Location = New System.Drawing.Point(2, 1)
        Me.RecordingMessageLabel.Name = "RecordingMessageLabel"
        Me.RecordingMessageLabel.Size = New System.Drawing.Size(95, 23)
        Me.RecordingMessageLabel.TabIndex = 0
        Me.RecordingMessageLabel.Text = "Recording..."
        '
        'MessageContactsPanel
        '
        Me.MessageContactsPanel.BackColor = System.Drawing.Color.Transparent
        Me.MessageContactsPanel.Controls.Add(Me.LilyMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.MomMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.TimmyMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.DadMessageButton)
        Me.MessageContactsPanel.Location = New System.Drawing.Point(3, 3)
        Me.MessageContactsPanel.Name = "MessageContactsPanel"
        Me.MessageContactsPanel.Size = New System.Drawing.Size(101, 468)
        Me.MessageContactsPanel.TabIndex = 16
        '
        'ConfirmationPanel
        '
        Me.ConfirmationPanel.AutoSize = True
        Me.ConfirmationPanel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ConfirmationPanel.Controls.Add(Me.CheckMarkPictureBox)
        Me.ConfirmationPanel.Controls.Add(Me.MessageSentLabel)
        Me.ConfirmationPanel.Location = New System.Drawing.Point(0, 708)
        Me.ConfirmationPanel.Name = "ConfirmationPanel"
        Me.ConfirmationPanel.Size = New System.Drawing.Size(119, 101)
        Me.ConfirmationPanel.TabIndex = 17
        '
        'MessageSentLabel
        '
        Me.MessageSentLabel.AutoSize = True
        Me.MessageSentLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageSentLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageSentLabel.Location = New System.Drawing.Point(2, 14)
        Me.MessageSentLabel.Name = "MessageSentLabel"
        Me.MessageSentLabel.Size = New System.Drawing.Size(114, 23)
        Me.MessageSentLabel.TabIndex = 0
        Me.MessageSentLabel.Text = "Message Sent!"
        '
        'PictureMessagePanel
        '
        Me.PictureMessagePanel.AutoSize = True
        Me.PictureMessagePanel.BackColor = System.Drawing.Color.Thistle
        Me.PictureMessagePanel.Controls.Add(Me.Picture3)
        Me.PictureMessagePanel.Controls.Add(Me.Picture1)
        Me.PictureMessagePanel.Controls.Add(Me.Picture2)
        Me.PictureMessagePanel.Controls.Add(Me.Picture4)
        Me.PictureMessagePanel.Controls.Add(Me.SelectPictureLabel)
        Me.PictureMessagePanel.Location = New System.Drawing.Point(0, 832)
        Me.PictureMessagePanel.Name = "PictureMessagePanel"
        Me.PictureMessagePanel.Size = New System.Drawing.Size(119, 111)
        Me.PictureMessagePanel.TabIndex = 18
        '
        'SelectPictureLabel
        '
        Me.SelectPictureLabel.AutoSize = True
        Me.SelectPictureLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectPictureLabel.ForeColor = System.Drawing.Color.Red
        Me.SelectPictureLabel.Location = New System.Drawing.Point(-1, 0)
        Me.SelectPictureLabel.Name = "SelectPictureLabel"
        Me.SelectPictureLabel.Size = New System.Drawing.Size(112, 19)
        Me.SelectPictureLabel.TabIndex = 0
        Me.SelectPictureLabel.Text = "Select a picture"
        '
        'Picture3
        '
        Me.Picture3.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.download
        Me.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture3.Location = New System.Drawing.Point(12, 63)
        Me.Picture3.Name = "Picture3"
        Me.Picture3.Size = New System.Drawing.Size(40, 40)
        Me.Picture3.TabIndex = 4
        Me.Picture3.UseVisualStyleBackColor = True
        '
        'Picture1
        '
        Me.Picture1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.images
        Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture1.Location = New System.Drawing.Point(12, 19)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(40, 40)
        Me.Picture1.TabIndex = 3
        Me.Picture1.UseVisualStyleBackColor = True
        '
        'Picture2
        '
        Me.Picture2.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.seasonal_weather_landscape_icon_vector_19925537
        Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture2.Location = New System.Drawing.Point(61, 19)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.Size = New System.Drawing.Size(40, 40)
        Me.Picture2.TabIndex = 2
        Me.Picture2.UseVisualStyleBackColor = True
        '
        'Picture4
        '
        Me.Picture4.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.Hugging_Face_Emoji_2028ce8b_c213_4d45_94aa_21e1a0842b4d_large
        Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture4.Location = New System.Drawing.Point(61, 63)
        Me.Picture4.Name = "Picture4"
        Me.Picture4.Size = New System.Drawing.Size(40, 40)
        Me.Picture4.TabIndex = 1
        Me.Picture4.UseVisualStyleBackColor = True
        '
        'CheckMarkPictureBox
        '
        Me.CheckMarkPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.check_1769866__3401
        Me.CheckMarkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckMarkPictureBox.Location = New System.Drawing.Point(26, 44)
        Me.CheckMarkPictureBox.Name = "CheckMarkPictureBox"
        Me.CheckMarkPictureBox.Size = New System.Drawing.Size(60, 53)
        Me.CheckMarkPictureBox.TabIndex = 1
        Me.CheckMarkPictureBox.TabStop = False
        '
        'RecordingContactPictureBox
        '
        Me.RecordingContactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecordingContactPictureBox.Location = New System.Drawing.Point(4, 25)
        Me.RecordingContactPictureBox.Name = "RecordingContactPictureBox"
        Me.RecordingContactPictureBox.Size = New System.Drawing.Size(42, 41)
        Me.RecordingContactPictureBox.TabIndex = 1
        Me.RecordingContactPictureBox.TabStop = False
        '
        'LilyMessageButton
        '
        Me.LilyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.lilymessage
        Me.LilyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LilyMessageButton.Location = New System.Drawing.Point(3, 238)
        Me.LilyMessageButton.Name = "LilyMessageButton"
        Me.LilyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.LilyMessageButton.TabIndex = 2
        Me.LilyMessageButton.UseVisualStyleBackColor = True
        '
        'MomMessageButton
        '
        Me.MomMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.mommeassage
        Me.MomMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MomMessageButton.Location = New System.Drawing.Point(3, 4)
        Me.MomMessageButton.Name = "MomMessageButton"
        Me.MomMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.MomMessageButton.TabIndex = 0
        Me.MomMessageButton.UseVisualStyleBackColor = True
        '
        'TimmyMessageButton
        '
        Me.TimmyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.timmymessage
        Me.TimmyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TimmyMessageButton.Location = New System.Drawing.Point(3, 356)
        Me.TimmyMessageButton.Name = "TimmyMessageButton"
        Me.TimmyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.TimmyMessageButton.TabIndex = 3
        Me.TimmyMessageButton.UseVisualStyleBackColor = True
        '
        'DadMessageButton
        '
        Me.DadMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.dadmessage
        Me.DadMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DadMessageButton.Location = New System.Drawing.Point(3, 120)
        Me.DadMessageButton.Name = "DadMessageButton"
        Me.DadMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.DadMessageButton.TabIndex = 1
        Me.DadMessageButton.UseVisualStyleBackColor = True
        '
        'ViewMessagePanel
        '
        Me.ViewMessagePanel.AutoSize = True
        Me.ViewMessagePanel.BackColor = System.Drawing.Color.Moccasin
        Me.ViewMessagePanel.Controls.Add(Me.ListenMessageButton)
        Me.ViewMessagePanel.Controls.Add(Me.Label1)
        Me.ViewMessagePanel.Location = New System.Drawing.Point(0, 964)
        Me.ViewMessagePanel.Name = "ViewMessagePanel"
        Me.ViewMessagePanel.Size = New System.Drawing.Size(134, 101)
        Me.ViewMessagePanel.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1 Audio Message      Received"
        '
        'ListenMessageButton
        '
        Me.ListenMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenMessageButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.ListenMessageButton.Location = New System.Drawing.Point(28, 57)
        Me.ListenMessageButton.Name = "ListenMessageButton"
        Me.ListenMessageButton.Size = New System.Drawing.Size(56, 31)
        Me.ListenMessageButton.TabIndex = 1
        Me.ListenMessageButton.Text = "Listen"
        Me.ListenMessageButton.UseVisualStyleBackColor = True
        '
        'messagesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.ViewMessagePanel)
        Me.Controls.Add(Me.PictureMessagePanel)
        Me.Controls.Add(Me.ConfirmationPanel)
        Me.Controls.Add(Me.recordingAudioMessagePanel)
        Me.Controls.Add(Me.MessageOptionspanel)
        Me.Controls.Add(Me.MessageContactsPanel)
        Me.Name = "messagesControl"
        Me.Size = New System.Drawing.Size(116, 1083)
        Me.MessageOptionspanel.ResumeLayout(False)
        Me.recordingAudioMessagePanel.ResumeLayout(False)
        Me.recordingAudioMessagePanel.PerformLayout()
        Me.MessageContactsPanel.ResumeLayout(False)
        Me.ConfirmationPanel.ResumeLayout(False)
        Me.ConfirmationPanel.PerformLayout()
        Me.PictureMessagePanel.ResumeLayout(False)
        Me.PictureMessagePanel.PerformLayout()
        CType(Me.CheckMarkPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewMessagePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MomMessageButton As Button
    Friend WithEvents DadMessageButton As Button
    Friend WithEvents LilyMessageButton As Button
    Friend WithEvents TimmyMessageButton As Button
    Friend WithEvents MessageOptionspanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents AudioMessageButton As Button
    Friend WithEvents ViewMessagesButton As Button
    Friend WithEvents recordingAudioMessagePanel As Panel
    Friend WithEvents TimeLabel As Label
    Friend WithEvents StopRecordButton As Button
    Friend WithEvents RecordingContactLabel As Label
    Friend WithEvents RecordingContactPictureBox As PictureBox
    Friend WithEvents RecordingMessageLabel As Label
    Friend WithEvents MessageContactsPanel As Panel
    Friend WithEvents MessageTimer As Timer
    Friend WithEvents ConfirmationPanel As Panel
    Friend WithEvents MessageSentLabel As Label
    Friend WithEvents CheckMarkPictureBox As PictureBox
    Friend WithEvents PictureMessagePanel As Panel
    Friend WithEvents Picture3 As Button
    Friend WithEvents Picture1 As Button
    Friend WithEvents Picture2 As Button
    Friend WithEvents Picture4 As Button
    Friend WithEvents SelectPictureLabel As Label
    Friend WithEvents ViewMessagePanel As Panel
    Friend WithEvents ListenMessageButton As Button
    Friend WithEvents Label1 As Label
End Class
