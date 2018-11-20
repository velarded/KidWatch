<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TimmyMessageButton = New System.Windows.Forms.Button()
        Me.LilyMessageButton = New System.Windows.Forms.Button()
        Me.DadMessageButton = New System.Windows.Forms.Button()
        Me.MomMessageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TimmyMessageButton
        '
        Me.TimmyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.timmymessage
        Me.TimmyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TimmyMessageButton.Location = New System.Drawing.Point(7, 355)
        Me.TimmyMessageButton.Name = "TimmyMessageButton"
        Me.TimmyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.TimmyMessageButton.TabIndex = 3
        Me.TimmyMessageButton.UseVisualStyleBackColor = True
        '
        'LilyMessageButton
        '
        Me.LilyMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.lilymessage
        Me.LilyMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LilyMessageButton.Location = New System.Drawing.Point(7, 237)
        Me.LilyMessageButton.Name = "LilyMessageButton"
        Me.LilyMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.LilyMessageButton.TabIndex = 2
        Me.LilyMessageButton.UseVisualStyleBackColor = True
        '
        'DadMessageButton
        '
        Me.DadMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.dadmessage
        Me.DadMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DadMessageButton.Location = New System.Drawing.Point(7, 119)
        Me.DadMessageButton.Name = "DadMessageButton"
        Me.DadMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.DadMessageButton.TabIndex = 1
        Me.DadMessageButton.UseVisualStyleBackColor = True
        '
        'MomMessageButton
        '
        Me.MomMessageButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.mommeassage
        Me.MomMessageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MomMessageButton.Location = New System.Drawing.Point(7, 3)
        Me.MomMessageButton.Name = "MomMessageButton"
        Me.MomMessageButton.Size = New System.Drawing.Size(80, 100)
        Me.MomMessageButton.TabIndex = 0
        Me.MomMessageButton.UseVisualStyleBackColor = True
        '
        'messagesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.TimmyMessageButton)
        Me.Controls.Add(Me.LilyMessageButton)
        Me.Controls.Add(Me.DadMessageButton)
        Me.Controls.Add(Me.MomMessageButton)
        Me.Name = "messagesControl"
        Me.Size = New System.Drawing.Size(116, 462)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MomMessageButton As Button
    Friend WithEvents DadMessageButton As Button
    Friend WithEvents LilyMessageButton As Button
    Friend WithEvents TimmyMessageButton As Button
End Class
