<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhoneControl))
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ContactsPanel = New System.Windows.Forms.Panel()
        Me.SOSButton = New System.Windows.Forms.Button()
        Me.VoicemailButton = New System.Windows.Forms.Button()
        Me.ContactTimmyButton = New System.Windows.Forms.Button()
        Me.ContactDadButton = New System.Windows.Forms.Button()
        Me.ContactLillyButton = New System.Windows.Forms.Button()
        Me.ContactMomButton = New System.Windows.Forms.Button()
        Me.CallingPanel = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StopCallButton = New System.Windows.Forms.Button()
        Me.CallingContactLabel = New System.Windows.Forms.Label()
        Me.CallingContactPictureBox = New System.Windows.Forms.PictureBox()
        Me.CallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ReceiveCallPanel = New System.Windows.Forms.Panel()
        Me.PickUpButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.CallerPictureBox = New System.Windows.Forms.PictureBox()
        Me.CallerLabel = New System.Windows.Forms.Label()
        Me.VoicemailPanel = New System.Windows.Forms.Panel()
        Me.CloseVoicemailButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VoicemailLabel = New System.Windows.Forms.Label()
        Me.ContactsPanel.SuspendLayout()
        Me.CallingPanel.SuspendLayout()
        CType(Me.CallingContactPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiveCallPanel.SuspendLayout()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VoicemailPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(8, 1)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(79, 26)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Calling..."
        '
        'ContactsPanel
        '
        Me.ContactsPanel.Controls.Add(Me.SOSButton)
        Me.ContactsPanel.Controls.Add(Me.VoicemailButton)
        Me.ContactsPanel.Controls.Add(Me.ContactTimmyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactDadButton)
        Me.ContactsPanel.Controls.Add(Me.ContactLillyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactMomButton)
        Me.ContactsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContactsPanel.Name = "ContactsPanel"
        Me.ContactsPanel.Size = New System.Drawing.Size(99, 605)
        Me.ContactsPanel.TabIndex = 13
        '
        'SOSButton
        '
        Me.SOSButton.BackgroundImage = CType(resources.GetObject("SOSButton.BackgroundImage"), System.Drawing.Image)
        Me.SOSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SOSButton.Location = New System.Drawing.Point(15, 1)
        Me.SOSButton.Name = "SOSButton"
        Me.SOSButton.Size = New System.Drawing.Size(80, 88)
        Me.SOSButton.TabIndex = 17
        Me.SOSButton.UseVisualStyleBackColor = True
        '
        'VoicemailButton
        '
        Me.VoicemailButton.BackgroundImage = CType(resources.GetObject("VoicemailButton.BackgroundImage"), System.Drawing.Image)
        Me.VoicemailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VoicemailButton.Location = New System.Drawing.Point(15, 511)
        Me.VoicemailButton.Name = "VoicemailButton"
        Me.VoicemailButton.Size = New System.Drawing.Size(80, 88)
        Me.VoicemailButton.TabIndex = 16
        Me.VoicemailButton.UseVisualStyleBackColor = True
        '
        'ContactTimmyButton
        '
        Me.ContactTimmyButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contactCard4
        Me.ContactTimmyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactTimmyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTimmyButton.Location = New System.Drawing.Point(15, 407)
        Me.ContactTimmyButton.Name = "ContactTimmyButton"
        Me.ContactTimmyButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactTimmyButton.TabIndex = 11
        Me.ContactTimmyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactTimmyButton.UseVisualStyleBackColor = True
        '
        'ContactDadButton
        '
        Me.ContactDadButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contactCard2
        Me.ContactDadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactDadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactDadButton.Location = New System.Drawing.Point(15, 197)
        Me.ContactDadButton.Name = "ContactDadButton"
        Me.ContactDadButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactDadButton.TabIndex = 7
        Me.ContactDadButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactDadButton.UseVisualStyleBackColor = True
        '
        'ContactLillyButton
        '
        Me.ContactLillyButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contactCard3
        Me.ContactLillyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactLillyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactLillyButton.Location = New System.Drawing.Point(15, 302)
        Me.ContactLillyButton.Name = "ContactLillyButton"
        Me.ContactLillyButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactLillyButton.TabIndex = 9
        Me.ContactLillyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactLillyButton.UseVisualStyleBackColor = True
        '
        'ContactMomButton
        '
        Me.ContactMomButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contactCard1
        Me.ContactMomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactMomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactMomButton.Location = New System.Drawing.Point(15, 93)
        Me.ContactMomButton.Name = "ContactMomButton"
        Me.ContactMomButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactMomButton.TabIndex = 5
        Me.ContactMomButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactMomButton.UseVisualStyleBackColor = True
        '
        'CallingPanel
        '
        Me.CallingPanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.CallingPanel.Controls.Add(Me.TimeLabel)
        Me.CallingPanel.Controls.Add(Me.StopCallButton)
        Me.CallingPanel.Controls.Add(Me.CallingContactLabel)
        Me.CallingPanel.Controls.Add(Me.CallingContactPictureBox)
        Me.CallingPanel.Controls.Add(Me.StatusLabel)
        Me.CallingPanel.Location = New System.Drawing.Point(0, 719)
        Me.CallingPanel.Name = "CallingPanel"
        Me.CallingPanel.Size = New System.Drawing.Size(116, 100)
        Me.CallingPanel.TabIndex = 14
        Me.CallingPanel.Visible = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.Location = New System.Drawing.Point(48, 25)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(55, 24)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "00:00"
        '
        'StopCallButton
        '
        Me.StopCallButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.decline
        Me.StopCallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopCallButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopCallButton.Location = New System.Drawing.Point(33, 67)
        Me.StopCallButton.Name = "StopCallButton"
        Me.StopCallButton.Size = New System.Drawing.Size(45, 32)
        Me.StopCallButton.TabIndex = 14
        Me.StopCallButton.UseVisualStyleBackColor = True
        '
        'CallingContactLabel
        '
        Me.CallingContactLabel.AutoSize = True
        Me.CallingContactLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallingContactLabel.ForeColor = System.Drawing.Color.White
        Me.CallingContactLabel.Location = New System.Drawing.Point(46, 43)
        Me.CallingContactLabel.Name = "CallingContactLabel"
        Me.CallingContactLabel.Size = New System.Drawing.Size(73, 24)
        Me.CallingContactLabel.TabIndex = 13
        Me.CallingContactLabel.Text = "Contact"
        '
        'CallingContactPictureBox
        '
        Me.CallingContactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallingContactPictureBox.Location = New System.Drawing.Point(4, 25)
        Me.CallingContactPictureBox.Name = "CallingContactPictureBox"
        Me.CallingContactPictureBox.Size = New System.Drawing.Size(42, 41)
        Me.CallingContactPictureBox.TabIndex = 1
        Me.CallingContactPictureBox.TabStop = False
        '
        'CallTimer
        '
        '
        'ReceiveCallPanel
        '
        Me.ReceiveCallPanel.BackColor = System.Drawing.Color.Goldenrod
        Me.ReceiveCallPanel.Controls.Add(Me.PickUpButton)
        Me.ReceiveCallPanel.Controls.Add(Me.DeclineButton)
        Me.ReceiveCallPanel.Controls.Add(Me.CallerPictureBox)
        Me.ReceiveCallPanel.Controls.Add(Me.CallerLabel)
        Me.ReceiveCallPanel.Location = New System.Drawing.Point(0, 613)
        Me.ReceiveCallPanel.Name = "ReceiveCallPanel"
        Me.ReceiveCallPanel.Size = New System.Drawing.Size(116, 100)
        Me.ReceiveCallPanel.TabIndex = 15
        Me.ReceiveCallPanel.Visible = False
        '
        'PickUpButton
        '
        Me.PickUpButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.accept
        Me.PickUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PickUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickUpButton.Location = New System.Drawing.Point(9, 67)
        Me.PickUpButton.Name = "PickUpButton"
        Me.PickUpButton.Size = New System.Drawing.Size(45, 32)
        Me.PickUpButton.TabIndex = 15
        Me.PickUpButton.UseVisualStyleBackColor = True
        '
        'DeclineButton
        '
        Me.DeclineButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.decline
        Me.DeclineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeclineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeclineButton.Location = New System.Drawing.Point(64, 67)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(45, 32)
        Me.DeclineButton.TabIndex = 14
        Me.DeclineButton.UseVisualStyleBackColor = True
        '
        'CallerPictureBox
        '
        Me.CallerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallerPictureBox.Location = New System.Drawing.Point(36, 22)
        Me.CallerPictureBox.Name = "CallerPictureBox"
        Me.CallerPictureBox.Size = New System.Drawing.Size(45, 45)
        Me.CallerPictureBox.TabIndex = 1
        Me.CallerPictureBox.TabStop = False
        '
        'CallerLabel
        '
        Me.CallerLabel.AutoSize = True
        Me.CallerLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallerLabel.ForeColor = System.Drawing.Color.Black
        Me.CallerLabel.Location = New System.Drawing.Point(29, 0)
        Me.CallerLabel.Name = "CallerLabel"
        Me.CallerLabel.Size = New System.Drawing.Size(62, 26)
        Me.CallerLabel.TabIndex = 0
        Me.CallerLabel.Text = "Caller"
        '
        'VoicemailPanel
        '
        Me.VoicemailPanel.BackColor = System.Drawing.Color.RosyBrown
        Me.VoicemailPanel.Controls.Add(Me.CloseVoicemailButton)
        Me.VoicemailPanel.Controls.Add(Me.PictureBox1)
        Me.VoicemailPanel.Controls.Add(Me.VoicemailLabel)
        Me.VoicemailPanel.Location = New System.Drawing.Point(0, 823)
        Me.VoicemailPanel.Name = "VoicemailPanel"
        Me.VoicemailPanel.Size = New System.Drawing.Size(116, 100)
        Me.VoicemailPanel.TabIndex = 16
        Me.VoicemailPanel.Visible = False
        '
        'CloseVoicemailButton
        '
        Me.CloseVoicemailButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.decline
        Me.CloseVoicemailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseVoicemailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseVoicemailButton.Location = New System.Drawing.Point(33, 67)
        Me.CloseVoicemailButton.Name = "CloseVoicemailButton"
        Me.CloseVoicemailButton.Size = New System.Drawing.Size(45, 32)
        Me.CloseVoicemailButton.TabIndex = 14
        Me.CloseVoicemailButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.voicemail
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(36, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'VoicemailLabel
        '
        Me.VoicemailLabel.AutoSize = True
        Me.VoicemailLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoicemailLabel.ForeColor = System.Drawing.Color.Black
        Me.VoicemailLabel.Location = New System.Drawing.Point(9, 0)
        Me.VoicemailLabel.Name = "VoicemailLabel"
        Me.VoicemailLabel.Size = New System.Drawing.Size(92, 26)
        Me.VoicemailLabel.TabIndex = 0
        Me.VoicemailLabel.Text = "Voicemail"
        '
        'PhoneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.VoicemailPanel)
        Me.Controls.Add(Me.ReceiveCallPanel)
        Me.Controls.Add(Me.ContactsPanel)
        Me.Controls.Add(Me.CallingPanel)
        Me.Name = "PhoneControl"
        Me.Size = New System.Drawing.Size(116, 942)
        Me.ContactsPanel.ResumeLayout(False)
        Me.CallingPanel.ResumeLayout(False)
        Me.CallingPanel.PerformLayout()
        CType(Me.CallingContactPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiveCallPanel.ResumeLayout(False)
        Me.ReceiveCallPanel.PerformLayout()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VoicemailPanel.ResumeLayout(False)
        Me.VoicemailPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusLabel As Label
    Friend WithEvents ContactMomButton As Button
    Friend WithEvents ContactDadButton As Button
    Friend WithEvents ContactLillyButton As Button
    Friend WithEvents ContactTimmyButton As Button
    Friend WithEvents ContactsPanel As Panel
    Friend WithEvents CallingPanel As Panel
    Friend WithEvents CallingContactLabel As Label
    Friend WithEvents CallingContactPictureBox As PictureBox
    Friend WithEvents StopCallButton As Button
    Friend WithEvents CallTimer As Timer
    Friend WithEvents ReceiveCallPanel As Panel
    Friend WithEvents PickUpButton As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents CallerPictureBox As PictureBox
    Friend WithEvents CallerLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents VoicemailButton As Button
    Friend WithEvents VoicemailPanel As Panel
    Friend WithEvents CloseVoicemailButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VoicemailLabel As Label
    Friend WithEvents SOSButton As Button
End Class
