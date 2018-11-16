<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidWatch))
        Me.CallButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.currentTimeLabel = New System.Windows.Forms.Label()
        Me.MenuScreen = New KidWatchB2.MenuControl()
        Me.PhoneCallScreen = New KidWatchB2.PhoneControl()
        Me.ClockControl1 = New KidWatchB2.clockControl()
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
        Me.currentTimeLabel.Size = New System.Drawing.Size(78, 18)
        Me.currentTimeLabel.TabIndex = 8
        Me.currentTimeLabel.Text = "10:10 AM"
        '
        'MenuScreen
        '
        Me.MenuScreen.AutoScroll = True
        Me.MenuScreen.BackColor = System.Drawing.Color.Black
        Me.MenuScreen.Location = New System.Drawing.Point(33, 88)
        Me.MenuScreen.Name = "MenuScreen"
        Me.MenuScreen.Size = New System.Drawing.Size(116, 100)
        Me.MenuScreen.TabIndex = 6
        '
        'PhoneCallScreen
        '
        Me.PhoneCallScreen.BackColor = System.Drawing.Color.Black
        Me.PhoneCallScreen.Location = New System.Drawing.Point(33, 88)
        Me.PhoneCallScreen.Name = "PhoneCallScreen"
        Me.PhoneCallScreen.Size = New System.Drawing.Size(116, 100)
        Me.PhoneCallScreen.TabIndex = 7
        '
        'ClockControl1
        '
        Me.ClockControl1.BackColor = System.Drawing.Color.Black
        Me.ClockControl1.Location = New System.Drawing.Point(33, 88)
        Me.ClockControl1.Name = "ClockControl1"
        Me.ClockControl1.Size = New System.Drawing.Size(116, 100)
        Me.ClockControl1.TabIndex = 9
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(184, 291)
        Me.Controls.Add(Me.currentTimeLabel)
        Me.Controls.Add(Me.MenuScreen)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.CallButton)
        Me.Controls.Add(Me.PhoneCallScreen)
        Me.Controls.Add(Me.ClockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "KidWatch"
        Me.Text = "Group B2 - KidWatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CallButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents MenuScreen As MenuControl
    Friend WithEvents PhoneCallScreen As PhoneControl
    Friend WithEvents currentTimeLabel As Label
    Friend WithEvents ClockControl1 As clockControl
End Class
