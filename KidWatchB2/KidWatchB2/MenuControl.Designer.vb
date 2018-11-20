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
        Me.clockButton = New System.Windows.Forms.Button()
        Me.calendarButton = New System.Windows.Forms.Button()
        Me.messagesButton = New System.Windows.Forms.Button()
        Me.mapsButton = New System.Windows.Forms.Button()
        Me.walletButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mapsLabel
        '
        Me.mapsLabel.AutoSize = True
        Me.mapsLabel.BackColor = System.Drawing.Color.Transparent
        Me.mapsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapsLabel.ForeColor = System.Drawing.Color.Transparent
        Me.mapsLabel.Location = New System.Drawing.Point(45, 391)
        Me.mapsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mapsLabel.Name = "mapsLabel"
        Me.mapsLabel.Size = New System.Drawing.Size(56, 24)
        Me.mapsLabel.TabIndex = 7
        Me.mapsLabel.Text = "Maps"
        '
        'walletLabel
        '
        Me.walletLabel.AutoSize = True
        Me.walletLabel.BackColor = System.Drawing.Color.Transparent
        Me.walletLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walletLabel.ForeColor = System.Drawing.Color.Transparent
        Me.walletLabel.Location = New System.Drawing.Point(40, 682)
        Me.walletLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.walletLabel.Name = "walletLabel"
        Me.walletLabel.Size = New System.Drawing.Size(61, 24)
        Me.walletLabel.TabIndex = 6
        Me.walletLabel.Text = "Wallet"
        '
        'messagesLabel
        '
        Me.messagesLabel.AutoSize = True
        Me.messagesLabel.BackColor = System.Drawing.Color.Transparent
        Me.messagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messagesLabel.ForeColor = System.Drawing.Color.Transparent
        Me.messagesLabel.Location = New System.Drawing.Point(24, 537)
        Me.messagesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.messagesLabel.Name = "messagesLabel"
        Me.messagesLabel.Size = New System.Drawing.Size(96, 24)
        Me.messagesLabel.TabIndex = 9
        Me.messagesLabel.Text = "Messages"
        '
        'calendarLabel
        '
        Me.calendarLabel.AutoSize = True
        Me.calendarLabel.BackColor = System.Drawing.Color.Transparent
        Me.calendarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendarLabel.ForeColor = System.Drawing.Color.Transparent
        Me.calendarLabel.Location = New System.Drawing.Point(28, 101)
        Me.calendarLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.calendarLabel.Name = "calendarLabel"
        Me.calendarLabel.Size = New System.Drawing.Size(86, 24)
        Me.calendarLabel.TabIndex = 11
        Me.calendarLabel.Text = "Calendar"
        '
        'clockLabel
        '
        Me.clockLabel.AutoSize = True
        Me.clockLabel.BackColor = System.Drawing.Color.Transparent
        Me.clockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockLabel.ForeColor = System.Drawing.Color.Transparent
        Me.clockLabel.Location = New System.Drawing.Point(40, 246)
        Me.clockLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.clockLabel.Name = "clockLabel"
        Me.clockLabel.Size = New System.Drawing.Size(57, 24)
        Me.clockLabel.TabIndex = 13
        Me.clockLabel.Text = "Clock"
        '
        'clockButton
        '
        Me.clockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clockButton.Image = CType(resources.GetObject("clockButton.Image"), System.Drawing.Image)
        Me.clockButton.Location = New System.Drawing.Point(20, 149)
        Me.clockButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clockButton.Name = "clockButton"
        Me.clockButton.Size = New System.Drawing.Size(107, 98)
        Me.clockButton.TabIndex = 12
        Me.clockButton.UseVisualStyleBackColor = True
        '
        'calendarButton
        '
        Me.calendarButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.calendar_icon
        Me.calendarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.calendarButton.Location = New System.Drawing.Point(20, 4)
        Me.calendarButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.calendarButton.Name = "calendarButton"
        Me.calendarButton.Size = New System.Drawing.Size(107, 98)
        Me.calendarButton.TabIndex = 10
        Me.calendarButton.UseVisualStyleBackColor = True
        '
        'messagesButton
        '
        Me.messagesButton.BackgroundImage = CType(resources.GetObject("messagesButton.BackgroundImage"), System.Drawing.Image)
        Me.messagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.messagesButton.Location = New System.Drawing.Point(20, 439)
        Me.messagesButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.messagesButton.Name = "messagesButton"
        Me.messagesButton.Size = New System.Drawing.Size(107, 98)
        Me.messagesButton.TabIndex = 8
        Me.messagesButton.UseVisualStyleBackColor = True
        '
        'mapsButton
        '
        Me.mapsButton.BackgroundImage = CType(resources.GetObject("mapsButton.BackgroundImage"), System.Drawing.Image)
        Me.mapsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mapsButton.Location = New System.Drawing.Point(20, 294)
        Me.mapsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mapsButton.Name = "mapsButton"
        Me.mapsButton.Size = New System.Drawing.Size(107, 98)
        Me.mapsButton.TabIndex = 5
        Me.mapsButton.UseVisualStyleBackColor = True
        '
        'walletButton
        '
        Me.walletButton.BackgroundImage = CType(resources.GetObject("walletButton.BackgroundImage"), System.Drawing.Image)
        Me.walletButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.walletButton.Location = New System.Drawing.Point(20, 585)
        Me.walletButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.walletButton.Name = "walletButton"
        Me.walletButton.Size = New System.Drawing.Size(107, 98)
        Me.walletButton.TabIndex = 4
        Me.walletButton.UseVisualStyleBackColor = True
        '
        'MenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.clockLabel)
        Me.Controls.Add(Me.clockButton)
        Me.Controls.Add(Me.calendarLabel)
        Me.Controls.Add(Me.calendarButton)
        Me.Controls.Add(Me.messagesLabel)
        Me.Controls.Add(Me.messagesButton)
        Me.Controls.Add(Me.mapsLabel)
        Me.Controls.Add(Me.walletLabel)
        Me.Controls.Add(Me.mapsButton)
        Me.Controls.Add(Me.walletButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuControl"
        Me.Size = New System.Drawing.Size(155, 799)
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
End Class
