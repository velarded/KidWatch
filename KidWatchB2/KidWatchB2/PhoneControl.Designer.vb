<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhoneControl
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
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.MomLabel = New System.Windows.Forms.Label()
        Me.ContactMomButton = New System.Windows.Forms.Button()
        Me.DadLabel = New System.Windows.Forms.Label()
        Me.ContactDadButton = New System.Windows.Forms.Button()
        Me.LillyLabel = New System.Windows.Forms.Label()
        Me.ContactLillyButton = New System.Windows.Forms.Button()
        Me.TimmyLabel = New System.Windows.Forms.Label()
        Me.ContactTimmyButton = New System.Windows.Forms.Button()
        Me.ContactsPanel = New System.Windows.Forms.Panel()
        Me.ContactsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(20, 465)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(64, 18)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Calling..."
        '
        'MomLabel
        '
        Me.MomLabel.AutoSize = True
        Me.MomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MomLabel.ForeColor = System.Drawing.Color.White
        Me.MomLabel.Location = New System.Drawing.Point(38, 78)
        Me.MomLabel.Name = "MomLabel"
        Me.MomLabel.Size = New System.Drawing.Size(43, 18)
        Me.MomLabel.TabIndex = 6
        Me.MomLabel.Text = "Mom"
        '
        'ContactMomButton
        '
        Me.ContactMomButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contact1
        Me.ContactMomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactMomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactMomButton.Location = New System.Drawing.Point(15, 1)
        Me.ContactMomButton.Name = "ContactMomButton"
        Me.ContactMomButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactMomButton.TabIndex = 5
        Me.ContactMomButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactMomButton.UseVisualStyleBackColor = True
        '
        'DadLabel
        '
        Me.DadLabel.AutoSize = True
        Me.DadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DadLabel.ForeColor = System.Drawing.Color.White
        Me.DadLabel.Location = New System.Drawing.Point(38, 182)
        Me.DadLabel.Name = "DadLabel"
        Me.DadLabel.Size = New System.Drawing.Size(35, 18)
        Me.DadLabel.TabIndex = 8
        Me.DadLabel.Text = "Dad"
        '
        'ContactDadButton
        '
        Me.ContactDadButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contact2
        Me.ContactDadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactDadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactDadButton.Location = New System.Drawing.Point(15, 105)
        Me.ContactDadButton.Name = "ContactDadButton"
        Me.ContactDadButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactDadButton.TabIndex = 7
        Me.ContactDadButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactDadButton.UseVisualStyleBackColor = True
        '
        'LillyLabel
        '
        Me.LillyLabel.AutoSize = True
        Me.LillyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LillyLabel.ForeColor = System.Drawing.Color.White
        Me.LillyLabel.Location = New System.Drawing.Point(38, 288)
        Me.LillyLabel.Name = "LillyLabel"
        Me.LillyLabel.Size = New System.Drawing.Size(32, 18)
        Me.LillyLabel.TabIndex = 10
        Me.LillyLabel.Text = "Lilly"
        '
        'ContactLillyButton
        '
        Me.ContactLillyButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contact3
        Me.ContactLillyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactLillyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactLillyButton.Location = New System.Drawing.Point(15, 211)
        Me.ContactLillyButton.Name = "ContactLillyButton"
        Me.ContactLillyButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactLillyButton.TabIndex = 9
        Me.ContactLillyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactLillyButton.UseVisualStyleBackColor = True
        '
        'TimmyLabel
        '
        Me.TimmyLabel.AutoSize = True
        Me.TimmyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimmyLabel.ForeColor = System.Drawing.Color.White
        Me.TimmyLabel.Location = New System.Drawing.Point(38, 394)
        Me.TimmyLabel.Name = "TimmyLabel"
        Me.TimmyLabel.Size = New System.Drawing.Size(53, 18)
        Me.TimmyLabel.TabIndex = 12
        Me.TimmyLabel.Text = "Timmy"
        '
        'ContactTimmyButton
        '
        Me.ContactTimmyButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.contact4
        Me.ContactTimmyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContactTimmyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTimmyButton.Location = New System.Drawing.Point(15, 317)
        Me.ContactTimmyButton.Name = "ContactTimmyButton"
        Me.ContactTimmyButton.Size = New System.Drawing.Size(80, 100)
        Me.ContactTimmyButton.TabIndex = 11
        Me.ContactTimmyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ContactTimmyButton.UseVisualStyleBackColor = True
        '
        'ContactsPanel
        '
        Me.ContactsPanel.Controls.Add(Me.TimmyLabel)
        Me.ContactsPanel.Controls.Add(Me.MomLabel)
        Me.ContactsPanel.Controls.Add(Me.DadLabel)
        Me.ContactsPanel.Controls.Add(Me.LillyLabel)
        Me.ContactsPanel.Controls.Add(Me.ContactTimmyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactDadButton)
        Me.ContactsPanel.Controls.Add(Me.ContactLillyButton)
        Me.ContactsPanel.Controls.Add(Me.ContactMomButton)
        Me.ContactsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ContactsPanel.Name = "ContactsPanel"
        Me.ContactsPanel.Size = New System.Drawing.Size(99, 436)
        Me.ContactsPanel.TabIndex = 13
        '
        'PhoneControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.ContactsPanel)
        Me.Name = "PhoneControl"
        Me.Size = New System.Drawing.Size(116, 514)
        Me.ContactsPanel.ResumeLayout(False)
        Me.ContactsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusLabel As Label
    Friend WithEvents ContactMomButton As Button
    Friend WithEvents MomLabel As Label
    Friend WithEvents DadLabel As Label
    Friend WithEvents ContactDadButton As Button
    Friend WithEvents LillyLabel As Label
    Friend WithEvents ContactLillyButton As Button
    Friend WithEvents TimmyLabel As Label
    Friend WithEvents ContactTimmyButton As Button
    Friend WithEvents ContactsPanel As Panel
End Class
