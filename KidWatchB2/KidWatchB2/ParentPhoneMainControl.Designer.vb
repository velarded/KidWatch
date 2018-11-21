<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentPhoneMainControl
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
        Me.KidWatchLabel = New System.Windows.Forms.Label()
        Me.KidWatchAppButton = New System.Windows.Forms.Button()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PhoneButton = New System.Windows.Forms.Button()
        Me.MessagesAppLabel = New System.Windows.Forms.Label()
        Me.MessagesAppButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'KidWatchLabel
        '
        Me.KidWatchLabel.AutoSize = True
        Me.KidWatchLabel.BackColor = System.Drawing.Color.Transparent
        Me.KidWatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KidWatchLabel.ForeColor = System.Drawing.Color.Transparent
        Me.KidWatchLabel.Location = New System.Drawing.Point(15, 76)
        Me.KidWatchLabel.Name = "KidWatchLabel"
        Me.KidWatchLabel.Size = New System.Drawing.Size(72, 18)
        Me.KidWatchLabel.TabIndex = 9
        Me.KidWatchLabel.Text = "KidWatch"
        '
        'KidWatchAppButton
        '
        Me.KidWatchAppButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.kidwatch_app_icon
        Me.KidWatchAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KidWatchAppButton.Location = New System.Drawing.Point(18, 12)
        Me.KidWatchAppButton.Name = "KidWatchAppButton"
        Me.KidWatchAppButton.Size = New System.Drawing.Size(61, 61)
        Me.KidWatchAppButton.TabIndex = 8
        Me.KidWatchAppButton.UseVisualStyleBackColor = True
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PhoneLabel.Location = New System.Drawing.Point(23, 368)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(51, 18)
        Me.PhoneLabel.TabIndex = 11
        Me.PhoneLabel.Text = "Phone"
        '
        'PhoneButton
        '
        Me.PhoneButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.phone_call_app_icon
        Me.PhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PhoneButton.Location = New System.Drawing.Point(18, 304)
        Me.PhoneButton.Name = "PhoneButton"
        Me.PhoneButton.Size = New System.Drawing.Size(61, 61)
        Me.PhoneButton.TabIndex = 10
        Me.PhoneButton.UseVisualStyleBackColor = True
        '
        'MessagesAppLabel
        '
        Me.MessagesAppLabel.AutoSize = True
        Me.MessagesAppLabel.BackColor = System.Drawing.Color.Transparent
        Me.MessagesAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesAppLabel.ForeColor = System.Drawing.Color.Transparent
        Me.MessagesAppLabel.Location = New System.Drawing.Point(163, 368)
        Me.MessagesAppLabel.Name = "MessagesAppLabel"
        Me.MessagesAppLabel.Size = New System.Drawing.Size(77, 18)
        Me.MessagesAppLabel.TabIndex = 13
        Me.MessagesAppLabel.Text = "Messages"
        '
        'MessagesAppButton
        '
        Me.MessagesAppButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.phone_messages_icon
        Me.MessagesAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MessagesAppButton.Location = New System.Drawing.Point(171, 304)
        Me.MessagesAppButton.Name = "MessagesAppButton"
        Me.MessagesAppButton.Size = New System.Drawing.Size(61, 61)
        Me.MessagesAppButton.TabIndex = 12
        Me.MessagesAppButton.UseVisualStyleBackColor = True
        '
        'ParentPhoneMainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.MessagesAppLabel)
        Me.Controls.Add(Me.MessagesAppButton)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.PhoneButton)
        Me.Controls.Add(Me.KidWatchLabel)
        Me.Controls.Add(Me.KidWatchAppButton)
        Me.Name = "ParentPhoneMainControl"
        Me.Size = New System.Drawing.Size(248, 396)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KidWatchLabel As Label
    Friend WithEvents KidWatchAppButton As Button
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents PhoneButton As Button
    Friend WithEvents MessagesAppLabel As Label
    Friend WithEvents MessagesAppButton As Button
End Class
