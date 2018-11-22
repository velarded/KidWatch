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
        Me.pictureMessageButton = New System.Windows.Forms.Button()
        Me.videoMessageButton = New System.Windows.Forms.Button()
        Me.AudioMessageButton = New System.Windows.Forms.Button()
        Me.ViewMessagesButton = New System.Windows.Forms.Button()
        Me.MessageContactsPanel = New System.Windows.Forms.Panel()
        Me.LilyMessageButton = New System.Windows.Forms.Button()
        Me.MomMessageButton = New System.Windows.Forms.Button()
        Me.TimmyMessageButton = New System.Windows.Forms.Button()
        Me.DadMessageButton = New System.Windows.Forms.Button()
        Me.MessageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ConfirmationPanel = New System.Windows.Forms.Panel()
        Me.CheckMarkPictureBox = New System.Windows.Forms.PictureBox()
        Me.MessageSentLabel = New System.Windows.Forms.Label()
        Me.PictureMessagePanel = New System.Windows.Forms.Panel()
        Me.Picture3 = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Button()
        Me.Picture2 = New System.Windows.Forms.Button()
        Me.Picture4 = New System.Windows.Forms.Button()
        Me.SelectPictureLabel = New System.Windows.Forms.Label()
        Me.ViewMessagePanel = New System.Windows.Forms.Panel()
        Me.ListenMessageButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecordingMessageLabel = New System.Windows.Forms.Label()
        Me.RecordingContactPictureBox = New System.Windows.Forms.PictureBox()
        Me.RecordingContactLabel = New System.Windows.Forms.Label()
        Me.StopRecordButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.RecordAudioMessagePage = New System.Windows.Forms.Panel()
        Me.ListeningAudioMessagePanel = New System.Windows.Forms.Panel()
        Me.ListeningTimeLabel = New System.Windows.Forms.Label()
        Me.EndListeningButton = New System.Windows.Forms.Button()
        Me.ListeningContactLabel = New System.Windows.Forms.Label()
        Me.ListeningContactPictureBox = New System.Windows.Forms.PictureBox()
        Me.ListeningMessageLabel = New System.Windows.Forms.Label()
        Me.viewPictureMessageButton = New System.Windows.Forms.Button()
        Me.viewPicturePanel = New System.Windows.Forms.Panel()
        Me.BackButtonButton = New System.Windows.Forms.Button()
        Me.viewPicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.MessageOptionspanel.SuspendLayout()
        Me.MessageContactsPanel.SuspendLayout()
        Me.ConfirmationPanel.SuspendLayout()
        CType(Me.CheckMarkPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureMessagePanel.SuspendLayout()
        Me.ViewMessagePanel.SuspendLayout()
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordAudioMessagePage.SuspendLayout()
        Me.ListeningAudioMessagePanel.SuspendLayout()
        CType(Me.ListeningContactPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewPicturePanel.SuspendLayout()
        CType(Me.viewPicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MessageOptionspanel
        '
        Me.MessageOptionspanel.AutoSize = True
        Me.MessageOptionspanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MessageOptionspanel.Controls.Add(Me.pictureMessageButton)
        Me.MessageOptionspanel.Controls.Add(Me.videoMessageButton)
        Me.MessageOptionspanel.Controls.Add(Me.AudioMessageButton)
        Me.MessageOptionspanel.Controls.Add(Me.ViewMessagesButton)
        Me.MessageOptionspanel.Location = New System.Drawing.Point(0, 102)
        Me.MessageOptionspanel.Name = "MessageOptionspanel"
        Me.MessageOptionspanel.Size = New System.Drawing.Size(116, 100)
        Me.MessageOptionspanel.TabIndex = 4
        '
        'pictureMessageButton
        '
        Me.pictureMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pictureMessageButton.Location = New System.Drawing.Point(15, 74)
        Me.pictureMessageButton.Name = "pictureMessageButton"
        Me.pictureMessageButton.Size = New System.Drawing.Size(86, 23)
        Me.pictureMessageButton.TabIndex = 3
        Me.pictureMessageButton.Text = "Send Picture "
        Me.pictureMessageButton.UseVisualStyleBackColor = True
        '
        'videoMessageButton
        '
        Me.videoMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.videoMessageButton.Location = New System.Drawing.Point(15, 49)
        Me.videoMessageButton.Name = "videoMessageButton"
        Me.videoMessageButton.Size = New System.Drawing.Size(86, 25)
        Me.videoMessageButton.TabIndex = 2
        Me.videoMessageButton.Text = "Send Video"
        Me.videoMessageButton.UseVisualStyleBackColor = True
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
        Me.ViewMessagesButton.Location = New System.Drawing.Point(5, 3)
        Me.ViewMessagesButton.Name = "ViewMessagesButton"
        Me.ViewMessagesButton.Size = New System.Drawing.Size(107, 23)
        Me.ViewMessagesButton.TabIndex = 0
        Me.ViewMessagesButton.Text = "View Messages"
        Me.ViewMessagesButton.UseVisualStyleBackColor = True
        '
        'MessageContactsPanel
        '
        Me.MessageContactsPanel.AutoScroll = True
        Me.MessageContactsPanel.BackColor = System.Drawing.Color.Transparent
        Me.MessageContactsPanel.Controls.Add(Me.LilyMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.MomMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.TimmyMessageButton)
        Me.MessageContactsPanel.Controls.Add(Me.DadMessageButton)
        Me.MessageContactsPanel.Location = New System.Drawing.Point(0, 0)
        Me.MessageContactsPanel.Name = "MessageContactsPanel"
        Me.MessageContactsPanel.Size = New System.Drawing.Size(116, 100)
        Me.MessageContactsPanel.TabIndex = 16
        '
        'LilyMessageButton
        '
        Me.LilyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.lilymessage
        Me.LilyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LilyMessageButton.Location = New System.Drawing.Point(18, 238)
        Me.LilyMessageButton.Name = "LilyMessageButton"
        Me.LilyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.LilyMessageButton.TabIndex = 2
        Me.LilyMessageButton.UseVisualStyleBackColor = True
        '
        'MomMessageButton
        '
        Me.MomMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.mommeassage
        Me.MomMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MomMessageButton.Location = New System.Drawing.Point(18, 2)
        Me.MomMessageButton.Name = "MomMessageButton"
        Me.MomMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.MomMessageButton.TabIndex = 0
        Me.MomMessageButton.UseVisualStyleBackColor = True
        '
        'TimmyMessageButton
        '
        Me.TimmyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.timmymessage
        Me.TimmyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TimmyMessageButton.Location = New System.Drawing.Point(18, 356)
        Me.TimmyMessageButton.Name = "TimmyMessageButton"
        Me.TimmyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.TimmyMessageButton.TabIndex = 3
        Me.TimmyMessageButton.UseVisualStyleBackColor = True
        '
        'DadMessageButton
        '
        Me.DadMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.dadmessage
        Me.DadMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DadMessageButton.Location = New System.Drawing.Point(18, 120)
        Me.DadMessageButton.Name = "DadMessageButton"
        Me.DadMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.DadMessageButton.TabIndex = 1
        Me.DadMessageButton.UseVisualStyleBackColor = True
        '
        'MessageTimer
        '
        '
        'ConfirmationPanel
        '
        Me.ConfirmationPanel.AutoSize = True
        Me.ConfirmationPanel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ConfirmationPanel.Controls.Add(Me.CheckMarkPictureBox)
        Me.ConfirmationPanel.Controls.Add(Me.MessageSentLabel)
        Me.ConfirmationPanel.Location = New System.Drawing.Point(0, 304)
        Me.ConfirmationPanel.Name = "ConfirmationPanel"
        Me.ConfirmationPanel.Size = New System.Drawing.Size(116, 100)
        Me.ConfirmationPanel.TabIndex = 17
        '
        'CheckMarkPictureBox
        '
        Me.CheckMarkPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.check_1769866__3401
        Me.CheckMarkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckMarkPictureBox.Location = New System.Drawing.Point(26, 41)
        Me.CheckMarkPictureBox.Name = "CheckMarkPictureBox"
        Me.CheckMarkPictureBox.Size = New System.Drawing.Size(60, 53)
        Me.CheckMarkPictureBox.TabIndex = 1
        Me.CheckMarkPictureBox.TabStop = False
        '
        'MessageSentLabel
        '
        Me.MessageSentLabel.AutoSize = True
        Me.MessageSentLabel.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.MessageSentLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageSentLabel.Location = New System.Drawing.Point(3, 9)
        Me.MessageSentLabel.Name = "MessageSentLabel"
        Me.MessageSentLabel.Size = New System.Drawing.Size(109, 20)
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
        Me.PictureMessagePanel.Location = New System.Drawing.Point(0, 405)
        Me.PictureMessagePanel.Name = "PictureMessagePanel"
        Me.PictureMessagePanel.Size = New System.Drawing.Size(116, 100)
        Me.PictureMessagePanel.TabIndex = 18
        '
        'Picture3
        '
        Me.Picture3.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.download
        Me.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picture3.Location = New System.Drawing.Point(12, 57)
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
        Me.Picture4.Location = New System.Drawing.Point(61, 57)
        Me.Picture4.Name = "Picture4"
        Me.Picture4.Size = New System.Drawing.Size(40, 40)
        Me.Picture4.TabIndex = 1
        Me.Picture4.UseVisualStyleBackColor = True
        '
        'SelectPictureLabel
        '
        Me.SelectPictureLabel.AutoSize = True
        Me.SelectPictureLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.75!, System.Drawing.FontStyle.Bold)
        Me.SelectPictureLabel.ForeColor = System.Drawing.Color.Red
        Me.SelectPictureLabel.Location = New System.Drawing.Point(8, 2)
        Me.SelectPictureLabel.Name = "SelectPictureLabel"
        Me.SelectPictureLabel.Size = New System.Drawing.Size(102, 16)
        Me.SelectPictureLabel.TabIndex = 0
        Me.SelectPictureLabel.Text = "Select a picture"
        '
        'ViewMessagePanel
        '
        Me.ViewMessagePanel.AutoSize = True
        Me.ViewMessagePanel.BackColor = System.Drawing.Color.Moccasin
        Me.ViewMessagePanel.Controls.Add(Me.viewPictureMessageButton)
        Me.ViewMessagePanel.Controls.Add(Me.ListenMessageButton)
        Me.ViewMessagePanel.Controls.Add(Me.Label1)
        Me.ViewMessagePanel.Location = New System.Drawing.Point(0, 506)
        Me.ViewMessagePanel.Name = "ViewMessagePanel"
        Me.ViewMessagePanel.Size = New System.Drawing.Size(122, 100)
        Me.ViewMessagePanel.TabIndex = 19
        '
        'ListenMessageButton
        '
        Me.ListenMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListenMessageButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.ListenMessageButton.Location = New System.Drawing.Point(5, 58)
        Me.ListenMessageButton.Name = "ListenMessageButton"
        Me.ListenMessageButton.Size = New System.Drawing.Size(56, 31)
        Me.ListenMessageButton.TabIndex = 1
        Me.ListenMessageButton.Text = "Listen"
        Me.ListenMessageButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You have 1 audio and 1 picture message!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'RecordingContactPictureBox
        '
        Me.RecordingContactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecordingContactPictureBox.Location = New System.Drawing.Point(4, 25)
        Me.RecordingContactPictureBox.Name = "RecordingContactPictureBox"
        Me.RecordingContactPictureBox.Size = New System.Drawing.Size(42, 41)
        Me.RecordingContactPictureBox.TabIndex = 1
        Me.RecordingContactPictureBox.TabStop = False
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
        'RecordAudioMessagePage
        '
        Me.RecordAudioMessagePage.BackColor = System.Drawing.Color.SaddleBrown
        Me.RecordAudioMessagePage.Controls.Add(Me.TimeLabel)
        Me.RecordAudioMessagePage.Controls.Add(Me.StopRecordButton)
        Me.RecordAudioMessagePage.Controls.Add(Me.RecordingContactLabel)
        Me.RecordAudioMessagePage.Controls.Add(Me.RecordingContactPictureBox)
        Me.RecordAudioMessagePage.Controls.Add(Me.RecordingMessageLabel)
        Me.RecordAudioMessagePage.Location = New System.Drawing.Point(0, 203)
        Me.RecordAudioMessagePage.Name = "RecordAudioMessagePage"
        Me.RecordAudioMessagePage.Size = New System.Drawing.Size(116, 100)
        Me.RecordAudioMessagePage.TabIndex = 15
        '
        'ListeningAudioMessagePanel
        '
        Me.ListeningAudioMessagePanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.ListeningAudioMessagePanel.Controls.Add(Me.ListeningTimeLabel)
        Me.ListeningAudioMessagePanel.Controls.Add(Me.EndListeningButton)
        Me.ListeningAudioMessagePanel.Controls.Add(Me.ListeningContactLabel)
        Me.ListeningAudioMessagePanel.Controls.Add(Me.ListeningContactPictureBox)
        Me.ListeningAudioMessagePanel.Controls.Add(Me.ListeningMessageLabel)
        Me.ListeningAudioMessagePanel.Location = New System.Drawing.Point(0, 608)
        Me.ListeningAudioMessagePanel.Name = "ListeningAudioMessagePanel"
        Me.ListeningAudioMessagePanel.Size = New System.Drawing.Size(116, 100)
        Me.ListeningAudioMessagePanel.TabIndex = 20
        '
        'ListeningTimeLabel
        '
        Me.ListeningTimeLabel.AutoSize = True
        Me.ListeningTimeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeningTimeLabel.ForeColor = System.Drawing.Color.White
        Me.ListeningTimeLabel.Location = New System.Drawing.Point(57, 25)
        Me.ListeningTimeLabel.Name = "ListeningTimeLabel"
        Me.ListeningTimeLabel.Size = New System.Drawing.Size(55, 24)
        Me.ListeningTimeLabel.TabIndex = 15
        Me.ListeningTimeLabel.Text = "00:00"
        '
        'EndListeningButton
        '
        Me.EndListeningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EndListeningButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndListeningButton.Location = New System.Drawing.Point(33, 67)
        Me.EndListeningButton.Name = "EndListeningButton"
        Me.EndListeningButton.Size = New System.Drawing.Size(45, 32)
        Me.EndListeningButton.TabIndex = 14
        Me.EndListeningButton.Text = "End"
        Me.EndListeningButton.UseVisualStyleBackColor = True
        '
        'ListeningContactLabel
        '
        Me.ListeningContactLabel.AutoSize = True
        Me.ListeningContactLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeningContactLabel.ForeColor = System.Drawing.Color.White
        Me.ListeningContactLabel.Location = New System.Drawing.Point(46, 43)
        Me.ListeningContactLabel.Name = "ListeningContactLabel"
        Me.ListeningContactLabel.Size = New System.Drawing.Size(73, 24)
        Me.ListeningContactLabel.TabIndex = 13
        Me.ListeningContactLabel.Text = "Contact"
        '
        'ListeningContactPictureBox
        '
        Me.ListeningContactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ListeningContactPictureBox.Location = New System.Drawing.Point(4, 25)
        Me.ListeningContactPictureBox.Name = "ListeningContactPictureBox"
        Me.ListeningContactPictureBox.Size = New System.Drawing.Size(42, 41)
        Me.ListeningContactPictureBox.TabIndex = 1
        Me.ListeningContactPictureBox.TabStop = False
        '
        'ListeningMessageLabel
        '
        Me.ListeningMessageLabel.AutoSize = True
        Me.ListeningMessageLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeningMessageLabel.ForeColor = System.Drawing.Color.White
        Me.ListeningMessageLabel.Location = New System.Drawing.Point(2, 1)
        Me.ListeningMessageLabel.Name = "ListeningMessageLabel"
        Me.ListeningMessageLabel.Size = New System.Drawing.Size(87, 23)
        Me.ListeningMessageLabel.TabIndex = 0
        Me.ListeningMessageLabel.Text = "Listening..."
        '
        'viewPictureMessageButton
        '
        Me.viewPictureMessageButton.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewPictureMessageButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.viewPictureMessageButton.Location = New System.Drawing.Point(61, 58)
        Me.viewPictureMessageButton.Name = "viewPictureMessageButton"
        Me.viewPictureMessageButton.Size = New System.Drawing.Size(51, 31)
        Me.viewPictureMessageButton.TabIndex = 2
        Me.viewPictureMessageButton.Text = "View"
        Me.viewPictureMessageButton.UseVisualStyleBackColor = True
        '
        'viewPicturePanel
        '
        Me.viewPicturePanel.AutoSize = True
        Me.viewPicturePanel.BackColor = System.Drawing.Color.Moccasin
        Me.viewPicturePanel.Controls.Add(Me.viewPicturePictureBox)
        Me.viewPicturePanel.Controls.Add(Me.BackButtonButton)
        Me.viewPicturePanel.Location = New System.Drawing.Point(-3, 710)
        Me.viewPicturePanel.Name = "viewPicturePanel"
        Me.viewPicturePanel.Size = New System.Drawing.Size(122, 100)
        Me.viewPicturePanel.TabIndex = 21
        '
        'BackButtonButton
        '
        Me.BackButtonButton.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButtonButton.ForeColor = System.Drawing.Color.ForestGreen
        Me.BackButtonButton.Location = New System.Drawing.Point(31, 66)
        Me.BackButtonButton.Name = "BackButtonButton"
        Me.BackButtonButton.Size = New System.Drawing.Size(51, 31)
        Me.BackButtonButton.TabIndex = 2
        Me.BackButtonButton.Text = "Back"
        Me.BackButtonButton.UseVisualStyleBackColor = True
        '
        'viewPicturePictureBox
        '
        Me.viewPicturePictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.images
        Me.viewPicturePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewPicturePictureBox.Location = New System.Drawing.Point(29, 9)
        Me.viewPicturePictureBox.Name = "viewPicturePictureBox"
        Me.viewPicturePictureBox.Size = New System.Drawing.Size(54, 50)
        Me.viewPicturePictureBox.TabIndex = 3
        Me.viewPicturePictureBox.TabStop = False
        '
        'messagesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.viewPicturePanel)
        Me.Controls.Add(Me.ListeningAudioMessagePanel)
        Me.Controls.Add(Me.ViewMessagePanel)
        Me.Controls.Add(Me.PictureMessagePanel)
        Me.Controls.Add(Me.ConfirmationPanel)
        Me.Controls.Add(Me.RecordAudioMessagePage)
        Me.Controls.Add(Me.MessageOptionspanel)
        Me.Controls.Add(Me.MessageContactsPanel)
        Me.Name = "messagesControl"
        Me.Size = New System.Drawing.Size(116, 1083)
        Me.MessageOptionspanel.ResumeLayout(False)
        Me.MessageContactsPanel.ResumeLayout(False)
        Me.ConfirmationPanel.ResumeLayout(False)
        Me.ConfirmationPanel.PerformLayout()
        CType(Me.CheckMarkPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureMessagePanel.ResumeLayout(False)
        Me.PictureMessagePanel.PerformLayout()
        Me.ViewMessagePanel.ResumeLayout(False)
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordAudioMessagePage.ResumeLayout(False)
        Me.RecordAudioMessagePage.PerformLayout()
        Me.ListeningAudioMessagePanel.ResumeLayout(False)
        Me.ListeningAudioMessagePanel.PerformLayout()
        CType(Me.ListeningContactPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewPicturePanel.ResumeLayout(False)
        CType(Me.viewPicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MomMessageButton As Button
    Friend WithEvents DadMessageButton As Button
    Friend WithEvents LilyMessageButton As Button
    Friend WithEvents TimmyMessageButton As Button
    Friend WithEvents MessageOptionspanel As Panel
    Friend WithEvents pictureMessageButton As Button
    Friend WithEvents videoMessageButton As Button
    Friend WithEvents AudioMessageButton As Button
    Friend WithEvents ViewMessagesButton As Button
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
    Friend WithEvents RecordingMessageLabel As Label
    Friend WithEvents RecordingContactPictureBox As PictureBox
    Friend WithEvents RecordingContactLabel As Label
    Friend WithEvents StopRecordButton As Button
    Friend WithEvents TimeLabel As Label
    Friend WithEvents RecordAudioMessagePage As Panel
    Friend WithEvents ListeningAudioMessagePanel As Panel
    Friend WithEvents ListeningTimeLabel As Label
    Friend WithEvents EndListeningButton As Button
    Friend WithEvents ListeningContactLabel As Label
    Friend WithEvents ListeningContactPictureBox As PictureBox
    Friend WithEvents ListeningMessageLabel As Label
    Friend WithEvents viewPictureMessageButton As Button
    Friend WithEvents viewPicturePanel As Panel
    Friend WithEvents viewPicturePictureBox As PictureBox
    Friend WithEvents BackButtonButton As Button
End Class
