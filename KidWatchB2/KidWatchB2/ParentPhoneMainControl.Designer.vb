<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentPhoneMainControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MessagesAppLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.GamesLabel = New System.Windows.Forms.Label()
        Me.GamesButton = New System.Windows.Forms.Button()
        Me.HealthLabel = New System.Windows.Forms.Label()
        Me.HealthButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ScheduleLabel = New System.Windows.Forms.Label()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.PlaylistLabel = New System.Windows.Forms.Label()
        Me.PlaylistButton = New System.Windows.Forms.Button()
        Me.ConfigButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CallingPanel = New System.Windows.Forms.Panel()
        Me.CallingPictureBox = New System.Windows.Forms.PictureBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StopCallButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MessagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ConfigPictureBox = New System.Windows.Forms.PictureBox()
        Me.ScheduleButton = New System.Windows.Forms.Button()
        Me.LocationButton = New System.Windows.Forms.Button()
        Me.JamesPictureBox = New System.Windows.Forms.PictureBox()
        Me.MessagesButton = New System.Windows.Forms.Button()
        Me.CallButton = New System.Windows.Forms.Button()
        Me.PickUpButton = New System.Windows.Forms.Button()
        Me.ReceiveCallControlsPanel = New System.Windows.Forms.Panel()
        Me.StopCallButton2 = New System.Windows.Forms.Button()
        Me.CallingPanel.SuspendLayout()
        CType(Me.CallingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JamesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiveCallControlsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(66, 20)
        Me.TitleLabel.MaximumSize = New System.Drawing.Size(150, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(128, 40)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Connected to: James KidWatch"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MessagesAppLabel
        '
        Me.MessagesAppLabel.AutoSize = True
        Me.MessagesAppLabel.BackColor = System.Drawing.Color.Transparent
        Me.MessagesAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesAppLabel.ForeColor = System.Drawing.Color.Black
        Me.MessagesAppLabel.Location = New System.Drawing.Point(61, 141)
        Me.MessagesAppLabel.Name = "MessagesAppLabel"
        Me.MessagesAppLabel.Size = New System.Drawing.Size(65, 16)
        Me.MessagesAppLabel.TabIndex = 21
        Me.MessagesAppLabel.Text = "Message"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.ForeColor = System.Drawing.Color.Black
        Me.PhoneLabel.Location = New System.Drawing.Point(15, 141)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(31, 16)
        Me.PhoneLabel.TabIndex = 19
        Me.PhoneLabel.Text = "Call"
        '
        'GamesLabel
        '
        Me.GamesLabel.AutoSize = True
        Me.GamesLabel.BackColor = System.Drawing.Color.Transparent
        Me.GamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesLabel.ForeColor = System.Drawing.Color.Black
        Me.GamesLabel.Location = New System.Drawing.Point(130, 223)
        Me.GamesLabel.Name = "GamesLabel"
        Me.GamesLabel.Size = New System.Drawing.Size(52, 16)
        Me.GamesLabel.TabIndex = 25
        Me.GamesLabel.Text = "Games"
        '
        'GamesButton
        '
        Me.GamesButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.Game_Center_icon
        Me.GamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GamesButton.Location = New System.Drawing.Point(131, 170)
        Me.GamesButton.Name = "GamesButton"
        Me.GamesButton.Size = New System.Drawing.Size(50, 50)
        Me.GamesButton.TabIndex = 24
        Me.GamesButton.UseVisualStyleBackColor = True
        '
        'HealthLabel
        '
        Me.HealthLabel.AutoSize = True
        Me.HealthLabel.BackColor = System.Drawing.Color.Transparent
        Me.HealthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HealthLabel.ForeColor = System.Drawing.Color.Black
        Me.HealthLabel.Location = New System.Drawing.Point(134, 141)
        Me.HealthLabel.Name = "HealthLabel"
        Me.HealthLabel.Size = New System.Drawing.Size(47, 16)
        Me.HealthLabel.TabIndex = 23
        Me.HealthLabel.Text = "Health"
        '
        'HealthButton
        '
        Me.HealthButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.health_icon
        Me.HealthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HealthButton.Location = New System.Drawing.Point(132, 88)
        Me.HealthButton.Name = "HealthButton"
        Me.HealthButton.Size = New System.Drawing.Size(50, 50)
        Me.HealthButton.TabIndex = 22
        Me.HealthButton.UseVisualStyleBackColor = True
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.BackColor = System.Drawing.Color.Transparent
        Me.LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel.ForeColor = System.Drawing.Color.Black
        Me.LocationLabel.Location = New System.Drawing.Point(189, 141)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(59, 16)
        Me.LocationLabel.TabIndex = 27
        Me.LocationLabel.Text = "Location"
        '
        'ScheduleLabel
        '
        Me.ScheduleLabel.AutoSize = True
        Me.ScheduleLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScheduleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleLabel.ForeColor = System.Drawing.Color.Black
        Me.ScheduleLabel.Location = New System.Drawing.Point(-1, 223)
        Me.ScheduleLabel.Name = "ScheduleLabel"
        Me.ScheduleLabel.Size = New System.Drawing.Size(65, 16)
        Me.ScheduleLabel.TabIndex = 29
        Me.ScheduleLabel.Text = "Schedule"
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SettingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsLabel.ForeColor = System.Drawing.Color.Black
        Me.SettingsLabel.Location = New System.Drawing.Point(7, 288)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(59, 16)
        Me.SettingsLabel.TabIndex = 33
        Me.SettingsLabel.Text = "Settings:"
        '
        'PlaylistLabel
        '
        Me.PlaylistLabel.AutoSize = True
        Me.PlaylistLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlaylistLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaylistLabel.ForeColor = System.Drawing.Color.Black
        Me.PlaylistLabel.Location = New System.Drawing.Point(71, 223)
        Me.PlaylistLabel.Name = "PlaylistLabel"
        Me.PlaylistLabel.Size = New System.Drawing.Size(43, 16)
        Me.PlaylistLabel.TabIndex = 31
        Me.PlaylistLabel.Text = "Music"
        '
        'PlaylistButton
        '
        Me.PlaylistButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources._71uAfFTpYaL
        Me.PlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaylistButton.Location = New System.Drawing.Point(68, 170)
        Me.PlaylistButton.Name = "PlaylistButton"
        Me.PlaylistButton.Size = New System.Drawing.Size(50, 50)
        Me.PlaylistButton.TabIndex = 30
        Me.PlaylistButton.UseVisualStyleBackColor = True
        '
        'ConfigButton
        '
        Me.ConfigButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfigButton.Location = New System.Drawing.Point(46, 307)
        Me.ConfigButton.Name = "ConfigButton"
        Me.ConfigButton.Size = New System.Drawing.Size(173, 35)
        Me.ConfigButton.TabIndex = 38
        Me.ConfigButton.Text = "Watch Configuration"
        Me.ConfigButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(46, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 35)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Message Management"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CallingPanel
        '
        Me.CallingPanel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.CallingPanel.Controls.Add(Me.ReceiveCallControlsPanel)
        Me.CallingPanel.Controls.Add(Me.CallingPictureBox)
        Me.CallingPanel.Controls.Add(Me.TimeLabel)
        Me.CallingPanel.Controls.Add(Me.StopCallButton)
        Me.CallingPanel.Controls.Add(Me.StatusLabel)
        Me.CallingPanel.Location = New System.Drawing.Point(1, 74)
        Me.CallingPanel.Name = "CallingPanel"
        Me.CallingPanel.Size = New System.Drawing.Size(243, 319)
        Me.CallingPanel.TabIndex = 15
        Me.CallingPanel.Visible = False
        '
        'CallingPictureBox
        '
        Me.CallingPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.james
        Me.CallingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallingPictureBox.Location = New System.Drawing.Point(44, 92)
        Me.CallingPictureBox.Name = "CallingPictureBox"
        Me.CallingPictureBox.Size = New System.Drawing.Size(136, 138)
        Me.CallingPictureBox.TabIndex = 16
        Me.CallingPictureBox.TabStop = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.Black
        Me.TimeLabel.Location = New System.Drawing.Point(73, 57)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(71, 29)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "00:00"
        '
        'StopCallButton
        '
        Me.StopCallButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.decline
        Me.StopCallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopCallButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopCallButton.Location = New System.Drawing.Point(78, 242)
        Me.StopCallButton.Name = "StopCallButton"
        Me.StopCallButton.Size = New System.Drawing.Size(62, 49)
        Me.StopCallButton.TabIndex = 14
        Me.StopCallButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Black
        Me.StatusLabel.Location = New System.Drawing.Point(56, 14)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(121, 31)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Calling..."
        '
        'Timer1
        '
        '
        'MessagePictureBox
        '
        Me.MessagePictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.phone_messages_icon
        Me.MessagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MessagePictureBox.Location = New System.Drawing.Point(8, 348)
        Me.MessagePictureBox.Name = "MessagePictureBox"
        Me.MessagePictureBox.Size = New System.Drawing.Size(35, 35)
        Me.MessagePictureBox.TabIndex = 37
        Me.MessagePictureBox.TabStop = False
        '
        'ConfigPictureBox
        '
        Me.ConfigPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.settings_icon
        Me.ConfigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfigPictureBox.Location = New System.Drawing.Point(8, 307)
        Me.ConfigPictureBox.Name = "ConfigPictureBox"
        Me.ConfigPictureBox.Size = New System.Drawing.Size(35, 35)
        Me.ConfigPictureBox.TabIndex = 36
        Me.ConfigPictureBox.TabStop = False
        '
        'ScheduleButton
        '
        Me.ScheduleButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.calendar_icon
        Me.ScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ScheduleButton.Location = New System.Drawing.Point(5, 170)
        Me.ScheduleButton.Name = "ScheduleButton"
        Me.ScheduleButton.Size = New System.Drawing.Size(50, 50)
        Me.ScheduleButton.TabIndex = 28
        Me.ScheduleButton.UseVisualStyleBackColor = True
        '
        'LocationButton
        '
        Me.LocationButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.maps_icon
        Me.LocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LocationButton.Location = New System.Drawing.Point(193, 88)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(50, 50)
        Me.LocationButton.TabIndex = 26
        Me.LocationButton.UseVisualStyleBackColor = True
        '
        'JamesPictureBox
        '
        Me.JamesPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.james
        Me.JamesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JamesPictureBox.Location = New System.Drawing.Point(10, 11)
        Me.JamesPictureBox.Name = "JamesPictureBox"
        Me.JamesPictureBox.Size = New System.Drawing.Size(55, 57)
        Me.JamesPictureBox.TabIndex = 0
        Me.JamesPictureBox.TabStop = False
        '
        'MessagesButton
        '
        Me.MessagesButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.phone_messages_icon
        Me.MessagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MessagesButton.Location = New System.Drawing.Point(68, 88)
        Me.MessagesButton.Name = "MessagesButton"
        Me.MessagesButton.Size = New System.Drawing.Size(50, 50)
        Me.MessagesButton.TabIndex = 20
        Me.MessagesButton.UseVisualStyleBackColor = True
        '
        'CallButton
        '
        Me.CallButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.phone_call_app_icon
        Me.CallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallButton.Location = New System.Drawing.Point(5, 88)
        Me.CallButton.Name = "CallButton"
        Me.CallButton.Size = New System.Drawing.Size(50, 50)
        Me.CallButton.TabIndex = 18
        Me.CallButton.UseVisualStyleBackColor = True
        '
        'PickUpButton
        '
        Me.PickUpButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.accept
        Me.PickUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PickUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUpButton.Location = New System.Drawing.Point(12, 13)
        Me.PickUpButton.Name = "PickUpButton"
        Me.PickUpButton.Size = New System.Drawing.Size(56, 49)
        Me.PickUpButton.TabIndex = 17
        Me.PickUpButton.UseVisualStyleBackColor = True
        '
        'ReceiveCallControlsPanel
        '
        Me.ReceiveCallControlsPanel.Controls.Add(Me.StopCallButton2)
        Me.ReceiveCallControlsPanel.Controls.Add(Me.PickUpButton)
        Me.ReceiveCallControlsPanel.Location = New System.Drawing.Point(17, 242)
        Me.ReceiveCallControlsPanel.Name = "ReceiveCallControlsPanel"
        Me.ReceiveCallControlsPanel.Size = New System.Drawing.Size(201, 74)
        Me.ReceiveCallControlsPanel.TabIndex = 18
        Me.ReceiveCallControlsPanel.Visible = False
        '
        'StopCallButton2
        '
        Me.StopCallButton2.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.decline
        Me.StopCallButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopCallButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopCallButton2.Location = New System.Drawing.Point(119, 13)
        Me.StopCallButton2.Name = "StopCallButton2"
        Me.StopCallButton2.Size = New System.Drawing.Size(62, 49)
        Me.StopCallButton2.TabIndex = 18
        Me.StopCallButton2.UseVisualStyleBackColor = True
        '
        'ParentPhoneMainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.Controls.Add(Me.CallingPanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ConfigButton)
        Me.Controls.Add(Me.MessagePictureBox)
        Me.Controls.Add(Me.ConfigPictureBox)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.PlaylistLabel)
        Me.Controls.Add(Me.PlaylistButton)
        Me.Controls.Add(Me.ScheduleLabel)
        Me.Controls.Add(Me.ScheduleButton)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.LocationButton)
        Me.Controls.Add(Me.GamesLabel)
        Me.Controls.Add(Me.GamesButton)
        Me.Controls.Add(Me.HealthLabel)
        Me.Controls.Add(Me.HealthButton)
        Me.Controls.Add(Me.MessagesAppLabel)
        Me.Controls.Add(Me.JamesPictureBox)
        Me.Controls.Add(Me.MessagesButton)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.CallButton)
        Me.Name = "ParentPhoneMainControl"
        Me.Size = New System.Drawing.Size(248, 396)
        Me.CallingPanel.ResumeLayout(False)
        Me.CallingPanel.PerformLayout()
        CType(Me.CallingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JamesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiveCallControlsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents JamesPictureBox As PictureBox
    Friend WithEvents MessagesAppLabel As Label
    Friend WithEvents MessagesButton As Button
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents CallButton As Button
    Friend WithEvents GamesLabel As Label
    Friend WithEvents GamesButton As Button
    Friend WithEvents HealthLabel As Label
    Friend WithEvents HealthButton As Button
    Friend WithEvents LocationLabel As Label
    Friend WithEvents LocationButton As Button
    Friend WithEvents ScheduleLabel As Label
    Friend WithEvents ScheduleButton As Button
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents PlaylistLabel As Label
    Friend WithEvents PlaylistButton As Button
    Friend WithEvents ConfigPictureBox As PictureBox
    Friend WithEvents MessagePictureBox As PictureBox
    Friend WithEvents ConfigButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CallingPanel As Panel
    Friend WithEvents CallingPictureBox As PictureBox
    Friend WithEvents TimeLabel As Label
    Friend WithEvents StopCallButton As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReceiveCallControlsPanel As Panel
    Friend WithEvents StopCallButton2 As Button
    Friend WithEvents PickUpButton As Button
End Class
