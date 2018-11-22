<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentMessagesMainControl
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
        Me.AudioMessageNotificationPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ListenLabel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AudioMessageReceivedLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EndOfAudioMessageLabel = New System.Windows.Forms.Label()
        Me.ListenAgainButton = New System.Windows.Forms.Button()
        Me.ContactNameLabel = New System.Windows.Forms.Label()
        Me.AudioMessageListenTimerLabel = New System.Windows.Forms.Label()
        Me.CloseListeningPanelButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AudioMessageNotificationPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioMessageNotificationPanel
        '
        Me.AudioMessageNotificationPanel.BackColor = System.Drawing.Color.Aquamarine
        Me.AudioMessageNotificationPanel.Controls.Add(Me.CloseButton)
        Me.AudioMessageNotificationPanel.Controls.Add(Me.ListenLabel)
        Me.AudioMessageNotificationPanel.Controls.Add(Me.PictureBox1)
        Me.AudioMessageNotificationPanel.Controls.Add(Me.AudioMessageReceivedLabel)
        Me.AudioMessageNotificationPanel.Location = New System.Drawing.Point(0, 0)
        Me.AudioMessageNotificationPanel.Name = "AudioMessageNotificationPanel"
        Me.AudioMessageNotificationPanel.Size = New System.Drawing.Size(248, 396)
        Me.AudioMessageNotificationPanel.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(156, 288)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ListenLabel
        '
        Me.ListenLabel.Location = New System.Drawing.Point(17, 288)
        Me.ListenLabel.Name = "ListenLabel"
        Me.ListenLabel.Size = New System.Drawing.Size(75, 23)
        Me.ListenLabel.TabIndex = 2
        Me.ListenLabel.Text = "Listen"
        Me.ListenLabel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.james
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(70, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 103)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'AudioMessageReceivedLabel
        '
        Me.AudioMessageReceivedLabel.AutoSize = True
        Me.AudioMessageReceivedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioMessageReceivedLabel.Location = New System.Drawing.Point(14, 231)
        Me.AudioMessageReceivedLabel.Name = "AudioMessageReceivedLabel"
        Me.AudioMessageReceivedLabel.Size = New System.Drawing.Size(217, 18)
        Me.AudioMessageReceivedLabel.TabIndex = 0
        Me.AudioMessageReceivedLabel.Text = "You have a new audio message"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel1.Controls.Add(Me.EndOfAudioMessageLabel)
        Me.Panel1.Controls.Add(Me.ListenAgainButton)
        Me.Panel1.Controls.Add(Me.ContactNameLabel)
        Me.Panel1.Controls.Add(Me.AudioMessageListenTimerLabel)
        Me.Panel1.Controls.Add(Me.CloseListeningPanelButton)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(254, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 396)
        Me.Panel1.TabIndex = 4
        '
        'EndOfAudioMessageLabel
        '
        Me.EndOfAudioMessageLabel.AutoSize = True
        Me.EndOfAudioMessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndOfAudioMessageLabel.Location = New System.Drawing.Point(13, 46)
        Me.EndOfAudioMessageLabel.Name = "EndOfAudioMessageLabel"
        Me.EndOfAudioMessageLabel.Size = New System.Drawing.Size(222, 24)
        Me.EndOfAudioMessageLabel.TabIndex = 7
        Me.EndOfAudioMessageLabel.Text = "End of Audio Message"
        Me.EndOfAudioMessageLabel.Visible = False
        '
        'ListenAgainButton
        '
        Me.ListenAgainButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ListenAgainButton.Location = New System.Drawing.Point(73, 269)
        Me.ListenAgainButton.Name = "ListenAgainButton"
        Me.ListenAgainButton.Size = New System.Drawing.Size(110, 42)
        Me.ListenAgainButton.TabIndex = 6
        Me.ListenAgainButton.Text = "Listen Again"
        Me.ListenAgainButton.UseVisualStyleBackColor = True
        Me.ListenAgainButton.Visible = False
        '
        'ContactNameLabel
        '
        Me.ContactNameLabel.AutoSize = True
        Me.ContactNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNameLabel.Location = New System.Drawing.Point(152, 148)
        Me.ContactNameLabel.Name = "ContactNameLabel"
        Me.ContactNameLabel.Size = New System.Drawing.Size(61, 20)
        Me.ContactNameLabel.TabIndex = 5
        Me.ContactNameLabel.Text = "James"
        '
        'AudioMessageListenTimerLabel
        '
        Me.AudioMessageListenTimerLabel.AutoSize = True
        Me.AudioMessageListenTimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioMessageListenTimerLabel.Location = New System.Drawing.Point(152, 107)
        Me.AudioMessageListenTimerLabel.Name = "AudioMessageListenTimerLabel"
        Me.AudioMessageListenTimerLabel.Size = New System.Drawing.Size(54, 20)
        Me.AudioMessageListenTimerLabel.TabIndex = 4
        Me.AudioMessageListenTimerLabel.Text = "00:00"
        '
        'CloseListeningPanelButton
        '
        Me.CloseListeningPanelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseListeningPanelButton.Location = New System.Drawing.Point(82, 317)
        Me.CloseListeningPanelButton.Name = "CloseListeningPanelButton"
        Me.CloseListeningPanelButton.Size = New System.Drawing.Size(90, 42)
        Me.CloseListeningPanelButton.TabIndex = 3
        Me.CloseListeningPanelButton.Text = "Close"
        Me.CloseListeningPanelButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.james
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(28, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 103)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listening..."
        '
        'Timer1
        '
        '
        'ParentMessagesMainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AudioMessageNotificationPanel)
        Me.Name = "ParentMessagesMainControl"
        Me.Size = New System.Drawing.Size(675, 628)
        Me.AudioMessageNotificationPanel.ResumeLayout(False)
        Me.AudioMessageNotificationPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AudioMessageNotificationPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AudioMessageReceivedLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents ListenLabel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CloseListeningPanelButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContactNameLabel As Label
    Friend WithEvents AudioMessageListenTimerLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListenAgainButton As Button
    Friend WithEvents EndOfAudioMessageLabel As Label
End Class
