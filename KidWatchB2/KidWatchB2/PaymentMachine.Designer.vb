<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MachinePromptLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MachinePromptLabel
        '
        Me.MachinePromptLabel.AutoSize = True
        Me.MachinePromptLabel.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachinePromptLabel.Location = New System.Drawing.Point(141, 81)
        Me.MachinePromptLabel.Name = "MachinePromptLabel"
        Me.MachinePromptLabel.Size = New System.Drawing.Size(166, 49)
        Me.MachinePromptLabel.TabIndex = 0
        Me.MachinePromptLabel.Text = "Total is:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(157, 145)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(124, 49)
        Me.TotalLabel.TabIndex = 1
        Me.TotalLabel.Text = "$2.00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(131, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 89)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Press button to repesent action of watch tap"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PaymentMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.MachinePromptLabel)
        Me.Name = "PaymentMachine"
        Me.Text = "PaymentMachine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MachinePromptLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Button1 As Button
End Class
