﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TimmyMessageButton = New System.Windows.Forms.Button()
        Me.LilyMessageButton = New System.Windows.Forms.Button()
        Me.DadMessageButton = New System.Windows.Forms.Button()
        Me.MomMessageButton = New System.Windows.Forms.Button()
        Me.MessageOptionspanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AudioMessageButton = New System.Windows.Forms.Button()
        Me.ViewMessagesButton = New System.Windows.Forms.Button()
        Me.recordingMessagePanel = New System.Windows.Forms.Panel()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StopRecordButton = New System.Windows.Forms.Button()
        Me.RecordingContactLabel = New System.Windows.Forms.Label()
        Me.RecordingContactPictureBox = New System.Windows.Forms.PictureBox()
        Me.RecordingMessageLabel = New System.Windows.Forms.Label()
        Me.MessageContactsPanel = New System.Windows.Forms.Panel()
        Me.MessageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MessageOptionspanel.SuspendLayout()
        Me.recordingMessagePanel.SuspendLayout()
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessageContactsPanel.SuspendLayout()
        Me.SuspendLayout()
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
        'recordingMessagePanel
        '
        Me.recordingMessagePanel.BackColor = System.Drawing.Color.SaddleBrown
        Me.recordingMessagePanel.Controls.Add(Me.TimeLabel)
        Me.recordingMessagePanel.Controls.Add(Me.StopRecordButton)
        Me.recordingMessagePanel.Controls.Add(Me.RecordingContactLabel)
        Me.recordingMessagePanel.Controls.Add(Me.RecordingContactPictureBox)
        Me.recordingMessagePanel.Controls.Add(Me.RecordingMessageLabel)
        Me.recordingMessagePanel.Location = New System.Drawing.Point(0, 590)
        Me.recordingMessagePanel.Name = "recordingMessagePanel"
        Me.recordingMessagePanel.Size = New System.Drawing.Size(116, 100)
        Me.recordingMessagePanel.TabIndex = 15
        Me.recordingMessagePanel.Visible = False
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
        'RecordingContactPictureBox
        '
        Me.RecordingContactPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RecordingContactPictureBox.Location = New System.Drawing.Point(4, 25)
        Me.RecordingContactPictureBox.Name = "RecordingContactPictureBox"
        Me.RecordingContactPictureBox.Size = New System.Drawing.Size(42, 41)
        Me.RecordingContactPictureBox.TabIndex = 1
        Me.RecordingContactPictureBox.TabStop = False
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
        'messagesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.recordingMessagePanel)
        Me.Controls.Add(Me.MessageOptionspanel)
        Me.Controls.Add(Me.MessageContactsPanel)
        Me.Name = "messagesControl"
        Me.Size = New System.Drawing.Size(116, 741)
        Me.MessageOptionspanel.ResumeLayout(False)
        Me.recordingMessagePanel.ResumeLayout(False)
        Me.recordingMessagePanel.PerformLayout()
        CType(Me.RecordingContactPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessageContactsPanel.ResumeLayout(False)
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
    Friend WithEvents recordingMessagePanel As Panel
    Friend WithEvents TimeLabel As Label
    Friend WithEvents StopRecordButton As Button
    Friend WithEvents RecordingContactLabel As Label
    Friend WithEvents RecordingContactPictureBox As PictureBox
    Friend WithEvents RecordingMessageLabel As Label
    Friend WithEvents MessageContactsPanel As Panel
    Friend WithEvents MessageTimer As Timer
End Class