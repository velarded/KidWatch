﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KidWatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidWatch))
        Me.CallButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.currentTimeLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MessagesControl1 = New KidWatchB2.messagesControl()
        Me.VolumeUpButton = New System.Windows.Forms.Button()
        Me.VolumeDownButton = New System.Windows.Forms.Button()
        Me.VolumePictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuScreen = New KidWatchB2.MenuControl()
        Me.CalendarControl1 = New KidWatchB2.CalendarControl()
        Me.Wallet = New KidWatchB2.WalletControl()
        Me.PhoneCallScreen = New KidWatchB2.PhoneControl()
        Me.ClockControl1 = New KidWatchB2.clockControl()
        Me.ReminderScreen = New KidWatchB2.ReminderControl()
        Me.MapControl1 = New KidWatchB2.MapControl()
        CType(Me.VolumePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallButton
        '
        Me.CallButton.BackColor = System.Drawing.Color.Transparent
        Me.CallButton.BackgroundImage = CType(resources.GetObject("CallButton.BackgroundImage"), System.Drawing.Image)
        Me.CallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CallButton.Location = New System.Drawing.Point(47, 191)
        Me.CallButton.Name = "CallButton"
        Me.CallButton.Size = New System.Drawing.Size(20, 20)
        Me.CallButton.TabIndex = 4
        Me.CallButton.UseVisualStyleBackColor = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MenuButton.Location = New System.Drawing.Point(117, 191)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(20, 20)
        Me.MenuButton.TabIndex = 5
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'currentTimeLabel
        '
        Me.currentTimeLabel.AutoSize = True
        Me.currentTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.currentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTimeLabel.ForeColor = System.Drawing.Color.Aqua
        Me.currentTimeLabel.Location = New System.Drawing.Point(57, 70)
        Me.currentTimeLabel.Name = "currentTimeLabel"
        Me.currentTimeLabel.Size = New System.Drawing.Size(79, 18)
        Me.currentTimeLabel.TabIndex = 8
        Me.currentTimeLabel.Text = "09:06 PM"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'MessagesControl1
        '
        Me.MessagesControl1.BackColor = System.Drawing.Color.Black
        Me.MessagesControl1.Location = New System.Drawing.Point(33, 88)
        Me.MessagesControl1.Name = "MessagesControl1"
        Me.MessagesControl1.Size = New System.Drawing.Size(116, 100)
        Me.MessagesControl1.TabIndex = 10
        '
        'VolumeUpButton
        '
        Me.VolumeUpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VolumeUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeUpButton.Font = New System.Drawing.Font("Arial Black", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumeUpButton.Location = New System.Drawing.Point(163, 88)
        Me.VolumeUpButton.Name = "VolumeUpButton"
        Me.VolumeUpButton.Size = New System.Drawing.Size(22, 50)
        Me.VolumeUpButton.TabIndex = 10
        Me.VolumeUpButton.Text = "+"
        Me.VolumeUpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.VolumeUpButton.UseVisualStyleBackColor = False
        '
        'VolumeDownButton
        '
        Me.VolumeDownButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VolumeDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumeDownButton.Font = New System.Drawing.Font("Arial Black", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolumeDownButton.Location = New System.Drawing.Point(163, 152)
        Me.VolumeDownButton.Name = "VolumeDownButton"
        Me.VolumeDownButton.Size = New System.Drawing.Size(22, 50)
        Me.VolumeDownButton.TabIndex = 11
        Me.VolumeDownButton.Text = "-"
        Me.VolumeDownButton.UseVisualStyleBackColor = False
        '
        'VolumePictureBox
        '
        Me.VolumePictureBox.BackColor = System.Drawing.SystemColors.Control
        Me.VolumePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VolumePictureBox.Location = New System.Drawing.Point(62, 106)
        Me.VolumePictureBox.Name = "VolumePictureBox"
        Me.VolumePictureBox.Size = New System.Drawing.Size(50, 50)
        Me.VolumePictureBox.TabIndex = 12
        Me.VolumePictureBox.TabStop = False
        '
        'MenuScreen
        '
        Me.MenuScreen.AutoScroll = True
        Me.MenuScreen.BackColor = System.Drawing.Color.Black
        Me.MenuScreen.Location = New System.Drawing.Point(33, 88)
        Me.MenuScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuScreen.Name = "MenuScreen"
        Me.MenuScreen.Size = New System.Drawing.Size(116, 100)
        Me.MenuScreen.TabIndex = 6
        '
        'CalendarControl1
        '
        Me.CalendarControl1.BackColor = System.Drawing.Color.Black
        Me.CalendarControl1.Location = New System.Drawing.Point(33, 88)
        Me.CalendarControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.CalendarControl1.Name = "CalendarControl1"
        Me.CalendarControl1.Size = New System.Drawing.Size(116, 100)
        Me.CalendarControl1.TabIndex = 9
        '
        'Wallet
        '
        Me.Wallet.BackColor = System.Drawing.Color.White
        Me.Wallet.Location = New System.Drawing.Point(33, 88)
        Me.Wallet.Margin = New System.Windows.Forms.Padding(4)
        Me.Wallet.Name = "Wallet"
        Me.Wallet.Size = New System.Drawing.Size(116, 100)
        Me.Wallet.TabIndex = 9
        '
        'PhoneCallScreen
        '
        Me.PhoneCallScreen.AutoScroll = True
        Me.PhoneCallScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneCallScreen.Location = New System.Drawing.Point(33, 88)
        Me.PhoneCallScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneCallScreen.Name = "PhoneCallScreen"
        Me.PhoneCallScreen.Size = New System.Drawing.Size(116, 100)
        Me.PhoneCallScreen.TabIndex = 7
        '
        'ClockControl1
        '
        Me.ClockControl1.BackColor = System.Drawing.Color.Black
        Me.ClockControl1.Location = New System.Drawing.Point(33, 88)
        Me.ClockControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.ClockControl1.Name = "ClockControl1"
        Me.ClockControl1.Size = New System.Drawing.Size(116, 100)
        Me.ClockControl1.TabIndex = 9
        '
        'ReminderScreen
        '
        Me.ReminderScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReminderScreen.Location = New System.Drawing.Point(33, 88)
        Me.ReminderScreen.Name = "ReminderScreen"
        Me.ReminderScreen.Size = New System.Drawing.Size(116, 100)
        Me.ReminderScreen.TabIndex = 13
        '
        'MapControl1
        '
        Me.MapControl1.Location = New System.Drawing.Point(33, 88)
        Me.MapControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.MapControl1.Name = "MapControl1"
        Me.MapControl1.Size = New System.Drawing.Size(116, 100)
        Me.MapControl1.TabIndex = 10
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(184, 291)
        Me.Controls.Add(Me.VolumeDownButton)
        Me.Controls.Add(Me.VolumeUpButton)
        Me.Controls.Add(Me.currentTimeLabel)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.CallButton)
        Me.Controls.Add(Me.MenuScreen)
        Me.Controls.Add(Me.CalendarControl1)
        Me.Controls.Add(Me.Wallet)
        Me.Controls.Add(Me.PhoneCallScreen)
        Me.Controls.Add(Me.ClockControl1)
        Me.Controls.Add(Me.MessagesControl1)
        Me.Controls.Add(Me.VolumePictureBox)
        Me.Controls.Add(Me.ReminderScreen)
        Me.Controls.Add(Me.MapControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "KidWatch"
        Me.Text = "KidWatch"
        CType(Me.VolumePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents MenuScreen As MenuControl
    Friend WithEvents currentTimeLabel As Label
    Friend WithEvents ClockControl1 As clockControl
    Friend WithEvents CalendarControl1 As CalendarControl
    Friend WithEvents Wallet As WalletControl
    Friend WithEvents PhoneCallScreen As PhoneControl
    Friend WithEvents Timer2 As Timer

    Friend WithEvents MessagesControl1 As messagesControl

    Friend WithEvents VolumeUpButton As Button
    Friend WithEvents VolumeDownButton As Button
    Friend WithEvents VolumePictureBox As PictureBox
    Friend WithEvents ReminderScreen As ReminderControl

    Friend WithEvents MapControl1 As MapControl

End Class
