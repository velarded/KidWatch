<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuControl))
        Me.mapsLabel = New System.Windows.Forms.Label()
        Me.walletLabel = New System.Windows.Forms.Label()
        Me.messagesLabel = New System.Windows.Forms.Label()
        Me.calendarLabel = New System.Windows.Forms.Label()
        Me.clockLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MusicLabel = New System.Windows.Forms.Label()
        Me.RemindersButton = New System.Windows.Forms.Button()
        Me.GamesButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.clockButton = New System.Windows.Forms.Button()
        Me.calendarButton = New System.Windows.Forms.Button()
        Me.messagesButton = New System.Windows.Forms.Button()
        Me.mapsButton = New System.Windows.Forms.Button()
        Me.walletButton = New System.Windows.Forms.Button()
        Me.ReminderLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mapsLabel
        '
        Me.mapsLabel.AutoSize = True
        Me.mapsLabel.BackColor = System.Drawing.Color.Transparent
        Me.mapsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapsLabel.ForeColor = System.Drawing.Color.Transparent
        Me.mapsLabel.Location = New System.Drawing.Point(34, 318)
        Me.mapsLabel.Name = "mapsLabel"
        Me.mapsLabel.Size = New System.Drawing.Size(45, 18)
        Me.mapsLabel.TabIndex = 7
        Me.mapsLabel.Text = "Maps"
        '
        'walletLabel
        '
        Me.walletLabel.AutoSize = True
        Me.walletLabel.BackColor = System.Drawing.Color.Transparent
        Me.walletLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walletLabel.ForeColor = System.Drawing.Color.Transparent
        Me.walletLabel.Location = New System.Drawing.Point(29, 911)
        Me.walletLabel.Name = "walletLabel"
        Me.walletLabel.Size = New System.Drawing.Size(49, 18)
        Me.walletLabel.TabIndex = 6
        Me.walletLabel.Text = "Wallet"
        '
        'messagesLabel
        '
        Me.messagesLabel.AutoSize = True
        Me.messagesLabel.BackColor = System.Drawing.Color.Transparent
        Me.messagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messagesLabel.ForeColor = System.Drawing.Color.Transparent
        Me.messagesLabel.Location = New System.Drawing.Point(18, 436)
        Me.messagesLabel.Name = "messagesLabel"
        Me.messagesLabel.Size = New System.Drawing.Size(77, 18)
        Me.messagesLabel.TabIndex = 9
        Me.messagesLabel.Text = "Messages"
        '
        'calendarLabel
        '
        Me.calendarLabel.AutoSize = True
        Me.calendarLabel.BackColor = System.Drawing.Color.Transparent
        Me.calendarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarLabel.ForeColor = System.Drawing.Color.Transparent
        Me.calendarLabel.Location = New System.Drawing.Point(21, 82)
        Me.calendarLabel.Name = "calendarLabel"
        Me.calendarLabel.Size = New System.Drawing.Size(67, 18)
        Me.calendarLabel.TabIndex = 11
        Me.calendarLabel.Text = "Calendar"
        '
        'clockLabel
        '
        Me.clockLabel.AutoSize = True
        Me.clockLabel.BackColor = System.Drawing.Color.Transparent
        Me.clockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockLabel.ForeColor = System.Drawing.Color.Transparent
        Me.clockLabel.Location = New System.Drawing.Point(30, 201)
        Me.clockLabel.Name = "clockLabel"
        Me.clockLabel.Size = New System.Drawing.Size(47, 18)
        Me.clockLabel.TabIndex = 13
        Me.clockLabel.Text = "Clock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 319)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Games"
        '
        'MusicLabel
        '
        Me.MusicLabel.AutoSize = True
        Me.MusicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicLabel.ForeColor = System.Drawing.Color.Transparent
        Me.MusicLabel.Location = New System.Drawing.Point(30, 675)
        Me.MusicLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MusicLabel.Name = "MusicLabel"
        Me.MusicLabel.Size = New System.Drawing.Size(48, 18)
        Me.MusicLabel.TabIndex = 17
        Me.MusicLabel.Text = "Music"
        '
        'RemindersButton
        '
        Me.RemindersButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.reminders_icon
        Me.RemindersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RemindersButton.Location = New System.Drawing.Point(15, 714)
        Me.RemindersButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RemindersButton.Name = "RemindersButton"
        Me.RemindersButton.Size = New System.Drawing.Size(80, 80)
        Me.RemindersButton.TabIndex = 18
        Me.RemindersButton.UseVisualStyleBackColor = True
        '
        'GamesButton
        '
        Me.GamesButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.Game_Center_icon
        Me.GamesButton.Location = New System.Drawing.Point(15, 240)
        Me.GamesButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GamesButton.Name = "GamesButton"
        Me.GamesButton.Size = New System.Drawing.Size(80, 80)
        Me.GamesButton.TabIndex = 15
        Me.GamesButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources._71uAfFTpYaL
        Me.MusicButton.Location = New System.Drawing.Point(15, 596)
        Me.MusicButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(80, 80)
        Me.MusicButton.TabIndex = 14
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'clockButton
        '
        Me.clockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clockButton.Image = CType(resources.GetObject("clockButton.Image"), System.Drawing.Image)
        Me.clockButton.Location = New System.Drawing.Point(15, 122)
        Me.clockButton.Name = "clockButton"
        Me.clockButton.Size = New System.Drawing.Size(80, 80)
        Me.clockButton.TabIndex = 12
        Me.clockButton.UseVisualStyleBackColor = True
        '
        'calendarButton
        '
        Me.calendarButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.calendar_icon
        Me.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.calendarButton.Location = New System.Drawing.Point(15, 4)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(80, 80)
        Me.calendarButton.TabIndex = 10
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'messagesButton
        '
        Me.messagesButton.BackgroundImage = CType(resources.GetObject("messagesButton.BackgroundImage"), System.Drawing.Image)
        Me.messagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.messagesButton.Location = New System.Drawing.Point(15, 478)
        Me.messagesButton.Name = "messagesButton"
        Me.messagesButton.Size = New System.Drawing.Size(80, 80)
        Me.messagesButton.TabIndex = 8
        Me.messagesButton.UseVisualStyleBackColor = True
        '
        'mapsButton
        '
        Me.mapsButton.BackgroundImage = CType(resources.GetObject("mapsButton.BackgroundImage"), System.Drawing.Image)
        Me.mapsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mapsButton.Location = New System.Drawing.Point(15, 360)
        Me.mapsButton.Name = "mapsButton"
        Me.mapsButton.Size = New System.Drawing.Size(80, 80)
        Me.mapsButton.TabIndex = 5
        Me.mapsButton.UseVisualStyleBackColor = True
        '
        'walletButton
        '
        Me.walletButton.BackgroundImage = CType(resources.GetObject("walletButton.BackgroundImage"), System.Drawing.Image)
        Me.walletButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.walletButton.Location = New System.Drawing.Point(15, 832)
        Me.walletButton.Name = "walletButton"
        Me.walletButton.Size = New System.Drawing.Size(80, 80)
        Me.walletButton.TabIndex = 4
        Me.walletButton.UseVisualStyleBackColor = True
        '
        'ReminderLabel
        '
        Me.ReminderLabel.AutoSize = True
        Me.ReminderLabel.BackColor = System.Drawing.Color.Black
        Me.ReminderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderLabel.ForeColor = System.Drawing.Color.Transparent
        Me.ReminderLabel.Location = New System.Drawing.Point(16, 793)
        Me.ReminderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReminderLabel.Name = "ReminderLabel"
        Me.ReminderLabel.Size = New System.Drawing.Size(80, 18)
        Me.ReminderLabel.TabIndex = 19
        Me.ReminderLabel.Text = "Reminders"
        '
        'MenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.ReminderLabel)
        Me.Controls.Add(Me.RemindersButton)
        Me.Controls.Add(Me.MusicLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.clockLabel)
        Me.Controls.Add(Me.clockButton)
        Me.Controls.Add(Me.calendarLabel)
        Me.Controls.Add(Me.calendarButton)
        Me.Controls.Add(Me.messagesLabel)
        Me.Controls.Add(Me.messagesButton)
        Me.Controls.Add(Me.mapsLabel)
        Me.Controls.Add(Me.walletLabel)
        Me.Controls.Add(Me.walletButton)
        Me.Controls.Add(Me.GamesButton)
        Me.Controls.Add(Me.mapsButton)
        Me.Name = "MenuControl"
        Me.Size = New System.Drawing.Size(116, 961)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mapsLabel As Label
    Friend WithEvents walletLabel As Label
    Friend WithEvents mapsButton As Button
    Friend WithEvents walletButton As Button
    Friend WithEvents messagesButton As Button
    Friend WithEvents messagesLabel As Label
    Friend WithEvents calendarLabel As Label
    Friend WithEvents calendarButton As Button
    Friend WithEvents clockLabel As Label
    Friend WithEvents clockButton As Button
    Friend WithEvents MusicButton As Button
    Friend WithEvents GamesButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MusicLabel As Label
    Friend WithEvents RemindersButton As Button
    Friend WithEvents ReminderLabel As Label
End Class
