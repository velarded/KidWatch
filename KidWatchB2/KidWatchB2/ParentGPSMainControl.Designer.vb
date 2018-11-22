<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentGPSMainControl
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
        Me.CloseLocationAppButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CurrentChildLocationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseLocationAppButton
        '
        Me.CloseLocationAppButton.Location = New System.Drawing.Point(68, 326)
        Me.CloseLocationAppButton.Name = "CloseLocationAppButton"
        Me.CloseLocationAppButton.Size = New System.Drawing.Size(109, 39)
        Me.CloseLocationAppButton.TabIndex = 0
        Me.CloseLocationAppButton.Text = "Exit App"
        Me.CloseLocationAppButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.map_location
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(21, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 188)
        Me.Panel1.TabIndex = 1
        '
        'CurrentChildLocationLabel
        '
        Me.CurrentChildLocationLabel.AutoSize = True
        Me.CurrentChildLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CurrentChildLocationLabel.Location = New System.Drawing.Point(32, 32)
        Me.CurrentChildLocationLabel.Name = "CurrentChildLocationLabel"
        Me.CurrentChildLocationLabel.Size = New System.Drawing.Size(125, 18)
        Me.CurrentChildLocationLabel.TabIndex = 2
        Me.CurrentChildLocationLabel.Text = "James' Location: "
        '
        'ParentGPSMainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.CurrentChildLocationLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CloseLocationAppButton)
        Me.Name = "ParentGPSMainControl"
        Me.Size = New System.Drawing.Size(248, 396)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseLocationAppButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CurrentChildLocationLabel As Label
End Class
