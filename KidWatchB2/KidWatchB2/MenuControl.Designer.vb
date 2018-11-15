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
        Me.mapsLabel = New System.Windows.Forms.Label()
        Me.walletLabel = New System.Windows.Forms.Label()
        Me.TextButton = New System.Windows.Forms.Button()
        Me.mapsButton = New System.Windows.Forms.Button()
        Me.walletButton = New System.Windows.Forms.Button()
        Me.MessagesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mapsLabel
        '
        Me.mapsLabel.AutoSize = True
        Me.mapsLabel.BackColor = System.Drawing.Color.Black
        Me.mapsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mapsLabel.ForeColor = System.Drawing.Color.Transparent
        Me.mapsLabel.Location = New System.Drawing.Point(35, 140)
        Me.mapsLabel.Name = "mapsLabel"
        Me.mapsLabel.Size = New System.Drawing.Size(45, 18)
        Me.mapsLabel.TabIndex = 7
        Me.mapsLabel.Text = "Maps"
        '
        'walletLabel
        '
        Me.walletLabel.AutoSize = True
        Me.walletLabel.BackColor = System.Drawing.Color.Black
        Me.walletLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.walletLabel.ForeColor = System.Drawing.Color.Transparent
        Me.walletLabel.Location = New System.Drawing.Point(33, 59)
        Me.walletLabel.Name = "walletLabel"
        Me.walletLabel.Size = New System.Drawing.Size(49, 18)
        Me.walletLabel.TabIndex = 6
        Me.walletLabel.Text = "Wallet"
        '
        'TextButton
        '
        Me.TextButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources._1891029
        Me.TextButton.Location = New System.Drawing.Point(32, 178)
        Me.TextButton.Name = "TextButton"
        Me.TextButton.Size = New System.Drawing.Size(49, 49)
        Me.TextButton.TabIndex = 8
        Me.TextButton.UseVisualStyleBackColor = True
        '
        'mapsButton
        '
        Me.mapsButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.Apps_Google_Maps_icon
        Me.mapsButton.Location = New System.Drawing.Point(32, 84)
        Me.mapsButton.Name = "mapsButton"
        Me.mapsButton.Size = New System.Drawing.Size(51, 53)
        Me.mapsButton.TabIndex = 5
        Me.mapsButton.UseVisualStyleBackColor = True
        '
        'walletButton
        '
        Me.walletButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.ios9_wallet_applepay_app_icon1
        Me.walletButton.Location = New System.Drawing.Point(32, 3)
        Me.walletButton.Name = "walletButton"
        Me.walletButton.Size = New System.Drawing.Size(52, 53)
        Me.walletButton.TabIndex = 4
        Me.walletButton.UseVisualStyleBackColor = True
        '
        'MessagesLabel
        '
        Me.MessagesLabel.AutoSize = True
        Me.MessagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesLabel.ForeColor = System.Drawing.Color.Transparent
        Me.MessagesLabel.Location = New System.Drawing.Point(19, 230)
        Me.MessagesLabel.Name = "MessagesLabel"
        Me.MessagesLabel.Size = New System.Drawing.Size(77, 18)
        Me.MessagesLabel.TabIndex = 9
        Me.MessagesLabel.Text = "Messages"
        '
        'MenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.MessagesLabel)
        Me.Controls.Add(Me.TextButton)
        Me.Controls.Add(Me.mapsLabel)
        Me.Controls.Add(Me.walletLabel)
        Me.Controls.Add(Me.mapsButton)
        Me.Controls.Add(Me.walletButton)
        Me.Name = "MenuControl"
        Me.Size = New System.Drawing.Size(116, 365)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mapsLabel As Label
    Friend WithEvents walletLabel As Label
    Friend WithEvents mapsButton As Button
    Friend WithEvents walletButton As Button
    Friend WithEvents TextButton As Button
    Friend WithEvents MessagesLabel As Label
End Class
