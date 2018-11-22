<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentPhone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentPhone))
        Me.KidWatchLabel = New System.Windows.Forms.Label()
        Me.KidWatchAppButton = New System.Windows.Forms.Button()
        Me.ParentPhoneMainControl1 = New KidWatchB2.ParentPhoneMainControl()
        Me.ParentMessagesMainControl1 = New KidWatchB2.ParentMessagesMainControl()
        Me.SuspendLayout()
        '
        'KidWatchLabel
        '
        Me.KidWatchLabel.AutoSize = True
        Me.KidWatchLabel.BackColor = System.Drawing.Color.Transparent
        Me.KidWatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KidWatchLabel.ForeColor = System.Drawing.Color.Transparent
        Me.KidWatchLabel.Location = New System.Drawing.Point(50, 163)
        Me.KidWatchLabel.Name = "KidWatchLabel"
        Me.KidWatchLabel.Size = New System.Drawing.Size(72, 18)
        Me.KidWatchLabel.TabIndex = 19
        Me.KidWatchLabel.Text = "KidWatch"
        '
        'KidWatchAppButton
        '
        Me.KidWatchAppButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.kidwatch_app_icon
        Me.KidWatchAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KidWatchAppButton.Location = New System.Drawing.Point(53, 99)
        Me.KidWatchAppButton.Name = "KidWatchAppButton"
        Me.KidWatchAppButton.Size = New System.Drawing.Size(61, 61)
        Me.KidWatchAppButton.TabIndex = 18
        Me.KidWatchAppButton.UseVisualStyleBackColor = True
        '
        'ParentPhoneMainControl1
        '
        Me.ParentPhoneMainControl1.BackColor = System.Drawing.Color.LightCyan
        Me.ParentPhoneMainControl1.Location = New System.Drawing.Point(32, 84)
        Me.ParentPhoneMainControl1.Name = "ParentPhoneMainControl1"
        Me.ParentPhoneMainControl1.Size = New System.Drawing.Size(248, 396)
        Me.ParentPhoneMainControl1.TabIndex = 20
        '
        'ParentMessagesMainControl1
        '
        Me.ParentMessagesMainControl1.Location = New System.Drawing.Point(32, 84)
        Me.ParentMessagesMainControl1.Name = "ParentMessagesMainControl1"
        Me.ParentMessagesMainControl1.Size = New System.Drawing.Size(248, 396)
        Me.ParentMessagesMainControl1.TabIndex = 21
        '
        'ParentPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 567)
        Me.Controls.Add(Me.ParentPhoneMainControl1)
        Me.Controls.Add(Me.KidWatchLabel)
        Me.Controls.Add(Me.KidWatchAppButton)
        Me.Controls.Add(Me.ParentMessagesMainControl1)
        Me.Name = "ParentPhone"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "ParentPhone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KidWatchLabel As Label
    Friend WithEvents KidWatchAppButton As Button
    Friend WithEvents ParentPhoneMainControl1 As ParentPhoneMainControl
    Friend WithEvents ParentMessagesMainControl1 As ParentMessagesMainControl
End Class
