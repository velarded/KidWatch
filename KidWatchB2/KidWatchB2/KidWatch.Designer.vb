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
        Me.PhoneButton = New System.Windows.Forms.Button()
        Me.Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PhoneButton
        '
        Me.PhoneButton.BackColor = System.Drawing.Color.Transparent
        Me.PhoneButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.WatchButtonCall
        Me.PhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PhoneButton.Location = New System.Drawing.Point(80, 329)
        Me.PhoneButton.Name = "PhoneButton"
        Me.PhoneButton.Size = New System.Drawing.Size(35, 35)
        Me.PhoneButton.TabIndex = 0
        Me.PhoneButton.UseVisualStyleBackColor = False
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.Color.Transparent
        Me.Button.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.WatchButtonMenu
        Me.Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button.Location = New System.Drawing.Point(213, 329)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(35, 35)
        Me.Button.TabIndex = 1
        Me.Button.UseVisualStyleBackColor = False
        '
        'KidWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(334, 501)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.PhoneButton)
        Me.Name = "KidWatch"
        Me.Text = "Group B2 - KidWatch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PhoneButton As Button
    Friend WithEvents Button As Button
End Class
