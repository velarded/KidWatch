<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WalletControl
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
        Me.PayButton = New System.Windows.Forms.Button()
        Me.BalanceTextLabel = New System.Windows.Forms.Label()
        Me.BalanceAmountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PayButton
        '
        Me.PayButton.AutoSize = True
        Me.PayButton.BackColor = System.Drawing.Color.YellowGreen
        Me.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayButton.Location = New System.Drawing.Point(24, 62)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(69, 35)
        Me.PayButton.TabIndex = 0
        Me.PayButton.Text = "Pay"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'BalanceTextLabel
        '
        Me.BalanceTextLabel.AutoSize = True
        Me.BalanceTextLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextLabel.Location = New System.Drawing.Point(14, -1)
        Me.BalanceTextLabel.Name = "BalanceTextLabel"
        Me.BalanceTextLabel.Size = New System.Drawing.Size(90, 30)
        Me.BalanceTextLabel.TabIndex = 1
        Me.BalanceTextLabel.Text = "Balance"
        '
        'BalanceAmountLabel
        '
        Me.BalanceAmountLabel.AutoSize = True
        Me.BalanceAmountLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceAmountLabel.Location = New System.Drawing.Point(19, 29)
        Me.BalanceAmountLabel.Name = "BalanceAmountLabel"
        Me.BalanceAmountLabel.Size = New System.Drawing.Size(76, 30)
        Me.BalanceAmountLabel.TabIndex = 2
        Me.BalanceAmountLabel.Text = "$5.00"
        '
        'WalletControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BalanceAmountLabel)
        Me.Controls.Add(Me.BalanceTextLabel)
        Me.Controls.Add(Me.PayButton)
        Me.Name = "WalletControl"
        Me.Size = New System.Drawing.Size(116, 100)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PayButton As Button
    Friend WithEvents BalanceTextLabel As Label
    Friend WithEvents BalanceAmountLabel As Label
End Class
