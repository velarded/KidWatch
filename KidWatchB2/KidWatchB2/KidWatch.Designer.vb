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
        Me.MenuScreen = New KidWatchB2.MenuControl()
        Me.CalendarControl1 = New KidWatchB2.CalendarControl()
        Me.Wallet = New KidWatchB2.WalletControl()
        Me.PhoneCallScreen = New KidWatchB2.PhoneControl()
        Me.ClockControl1 = New KidWatchB2.clockControl()
        Me.MapControl1 = New KidWatchB2.MapControl()
        Me.SuspendLayout()
        '
        'CallButton
        '
        Me.CallButton.BackColor = System.Drawing.Color.Transparent
        Me.CallButton.BackgroundImage = CType(resources.GetObject("CallButton.BackgroundImage"), System.Drawing.Image)
        Me.CallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CallButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CallButton.Location = New System.Drawing.Point(63, 235)
        Me.CallButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CallButton.Name = "CallButton"
        Me.CallButton.Size = New System.Drawing.Size(27, 25)
        Me.CallButton.TabIndex = 4
        Me.CallButton.UseVisualStyleBackColor = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.MenuButton.BackgroundImage = CType(resources.GetObject("MenuButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MenuButton.Location = New System.Drawing.Point(156, 235)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(27, 25)
        Me.MenuButton.TabIndex = 5
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'currentTimeLabel
        '
        Me.currentTimeLabel.AutoSize = True
        Me.currentTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.currentTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTimeLabel.ForeColor = System.Drawing.Color.Aqua
        Me.currentTimeLabel.Location = New System.Drawing.Point(76, 86)
        Me.currentTimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentTimeLabel.Name = "currentTimeLabel"
        Me.currentTimeLabel.Size = New System.Drawing.Size(96, 24)
        Me.currentTimeLabel.TabIndex = 8
        Me.currentTimeLabel.Text = "09:06 PM"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'MenuScreen
        '
        Me.MenuScreen.AutoScroll = True
        Me.MenuScreen.BackColor = System.Drawing.Color.Black
        Me.MenuScreen.Location = New System.Drawing.Point(44, 108)
        Me.MenuScreen.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuScreen.Name = "MenuScreen"
        Me.MenuScreen.Size = New System.Drawing.Size(155, 123)
        Me.MenuScreen.TabIndex = 6
        '
        'CalendarControl1
        '
        Me.CalendarControl1.BackColor = System.Drawing.Color.Black
        Me.CalendarControl1.Location = New System.Drawing.Point(44, 108)
        Me.CalendarControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.CalendarControl1.Name = "CalendarControl1"
        Me.CalendarControl1.Size = New System.Drawing.Size(155, 123)
        Me.CalendarControl1.TabIndex = 9
        '
        'Wallet
        '
        Me.Wallet.BackColor = System.Drawing.Color.White
        Me.Wallet.Location = New System.Drawing.Point(44, 108)
        Me.Wallet.Margin = New System.Windows.Forms.Padding(5)
        Me.Wallet.Name = "Wallet"
        Me.Wallet.Size = New System.Drawing.Size(155, 123)
        Me.Wallet.TabIndex = 9
        '
        'PhoneCallScreen
        '
        Me.PhoneCallScreen.AutoScroll = True
        Me.PhoneCallScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneCallScreen.Location = New System.Drawing.Point(44, 108)
        Me.PhoneCallScreen.Margin = New System.Windows.Forms.Padding(5)
        Me.PhoneCallScreen.Name = "PhoneCallScreen"
        Me.PhoneCallScreen.Size = New System.Drawing.Size(155, 123)
        Me.PhoneCallScreen.TabIndex = 7
        '
        'ClockControl1
        '
        Me.ClockControl1.BackColor = System.Drawing.Color.Black
        Me.ClockControl1.Location = New System.Drawing.Point(44, 108)
        Me.ClockControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.ClockControl1.Name = "ClockControl1"
        Me.ClockControl1.Size = New System.Drawing.Size(155, 123)
        Me.ClockControl1.TabIndex = 9
        '
        'MapControl1
        '
        Me.MapControl1.Location = New System.Drawing.Point(44, 108)
        Me.MapControl1.Name = "MapControl1"
        Me.MapControl1.Size = New System.Drawing.Size(155, 123)
        Me.MapControl1.TabIndex = 10
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(245, 358)
        Me.Controls.Add(Me.currentTimeLabel)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.CallButton)
        Me.Controls.Add(Me.MenuScreen)
        Me.Controls.Add(Me.CalendarControl1)
        Me.Controls.Add(Me.Wallet)
        Me.Controls.Add(Me.PhoneCallScreen)
        Me.Controls.Add(Me.ClockControl1)
        Me.Controls.Add(Me.MapControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "KidWatch"
        Me.Text = "Group B2 - KidWatch"
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
    Friend WithEvents MapControl1 As MapControl
End Class
