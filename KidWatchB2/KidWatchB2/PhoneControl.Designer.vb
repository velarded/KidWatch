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
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ContactsPanel = New System.Windows.Forms.Panel()
        Me.ContactTimmyButton = New System.Windows.Forms.Button()
        Me.ContactDadButton = New System.Windows.Forms.Button()
        Me.ContactLillyButton = New System.Windows.Forms.Button()
        Me.ContactMomButton = New System.Windows.Forms.Button()
        Me.CallingPanel = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.EndCallButton = New System.Windows.Forms.Button()
        Me.CallingContactLabel = New System.Windows.Forms.Label()
        Me.CallingContactPicture = New System.Windows.Forms.PictureBox()
        Me.CallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ContactsPanel.SuspendLayout()
        Me.CallingPanel.SuspendLayout()
        CType(Me.CallingContactPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(20, 1)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(68, 20)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Calling..."
        '
        'ContactsPanel
        '
        Me.ContactsPanel.Controls.Add(Me.ContactTimmyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactDadButton)
        Me.ContactsPanel.Controls.Add(Me.ContactLillyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactMomButton)
        Me.ContactsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContactsPanel.Name = "ContactsPanel"
        Me.ContactsPanel.Size = New System.Drawing.Size(99, 423)
        Me.ContactsPanel.TabIndex = 13
        '
        'ContactTimmyButton
        '
        Me.ContactTimmyButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contactCard4
        Me.ContactTimmyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactTimmyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTimmyButton.Location = New System.Drawing.Point(14, 317)
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
        Me.ContactDadButton.Location = New System.Drawing.Point(14, 105)
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
        Me.ContactLillyButton.Location = New System.Drawing.Point(14, 211)
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
        Me.ContactMomButton.Location = New System.Drawing.Point(14, 1)
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
        Me.CallingPanel.Controls.Add(Me.EndCallButton)
        Me.CallingPanel.Controls.Add(Me.CallingContactLabel)
        Me.CallingPanel.Controls.Add(Me.CallingContactPicture)
        Me.CallingPanel.Controls.Add(Me.StatusLabel)
        Me.CallingPanel.Location = New System.Drawing.Point(0, 429)
        Me.CallingPanel.Name = "CallingPanel"
        Me.CallingPanel.Size = New System.Drawing.Size(116, 100)
        Me.CallingPanel.TabIndex = 14
        Me.CallingPanel.Visible = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.Location = New System.Drawing.Point(49, 25)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(44, 18)
        Me.TimeLabel.TabIndex = 15
        Me.TimeLabel.Text = "00:00"
        '
        'EndCallButton
        '
        Me.EndCallButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndCallButton.Location = New System.Drawing.Point(16, 72)
        Me.EndCallButton.Name = "EndCallButton"
        Me.EndCallButton.Size = New System.Drawing.Size(75, 23)
        Me.EndCallButton.TabIndex = 14
        Me.EndCallButton.Text = "End Call"
        Me.EndCallButton.UseVisualStyleBackColor = True
        '
        'CallingContactLabel
        '
        Me.CallingContactLabel.AutoSize = True
        Me.CallingContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallingContactLabel.ForeColor = System.Drawing.Color.White
        Me.CallingContactLabel.Location = New System.Drawing.Point(49, 43)
        Me.CallingContactLabel.Name = "CallingContactLabel"
        Me.CallingContactLabel.Size = New System.Drawing.Size(60, 18)
        Me.CallingContactLabel.TabIndex = 13
        Me.CallingContactLabel.Text = "Contact"
        '
        'CallingContactPicture
        '
        Me.CallingContactPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallingContactPicture.Location = New System.Drawing.Point(9, 25)
        Me.CallingContactPicture.Name = "CallingContactPicture"
        Me.CallingContactPicture.Size = New System.Drawing.Size(40, 40)
        Me.CallingContactPicture.TabIndex = 1
        Me.CallingContactPicture.TabStop = False
        '
        'CallTimer
        '
        '
        'PhoneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.ContactsPanel)
        Me.Controls.Add(Me.CallingPanel)
        Me.Name = "PhoneControl"
        Me.Size = New System.Drawing.Size(116, 532)
        Me.ContactsPanel.ResumeLayout(False)
        Me.CallingPanel.ResumeLayout(False)
        Me.CallingPanel.PerformLayout()
        CType(Me.CallingContactPicture, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CallingContactPicture As PictureBox
    Friend WithEvents EndCallButton As Button
    Friend WithEvents CallTimer As Timer
    Friend WithEvents TimeLabel As Label
End Class
