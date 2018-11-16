<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WalletControl
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
        Me.MainWalletPage = New System.Windows.Forms.Panel()
        Me.BalanceAmountLabel = New System.Windows.Forms.Label()
        Me.BalanceTextLabel = New System.Windows.Forms.Label()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.PaymentPromptPage = New System.Windows.Forms.Panel()
        Me.PayInstructionLabel2 = New System.Windows.Forms.Label()
        Me.PayInstructionLabel1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.MainWalletPage.SuspendLayout()
        Me.PaymentPromptPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainWalletPage
        '
        Me.MainWalletPage.BackColor = System.Drawing.Color.LightGray
        Me.MainWalletPage.Controls.Add(Me.BalanceAmountLabel)
        Me.MainWalletPage.Controls.Add(Me.BalanceTextLabel)
        Me.MainWalletPage.Controls.Add(Me.PayButton)
        Me.MainWalletPage.Location = New System.Drawing.Point(0, 0)
        Me.MainWalletPage.Name = "MainWalletPage"
        Me.MainWalletPage.Size = New System.Drawing.Size(116, 100)
        Me.MainWalletPage.TabIndex = 0
        '
        'BalanceAmountLabel
        '
        Me.BalanceAmountLabel.AutoSize = True
        Me.BalanceAmountLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceAmountLabel.Location = New System.Drawing.Point(21, 29)
        Me.BalanceAmountLabel.Name = "BalanceAmountLabel"
        Me.BalanceAmountLabel.Size = New System.Drawing.Size(69, 27)
        Me.BalanceAmountLabel.TabIndex = 2
        Me.BalanceAmountLabel.Text = "$5.00"
        '
        'BalanceTextLabel
        '
        Me.BalanceTextLabel.AutoSize = True
        Me.BalanceTextLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextLabel.Location = New System.Drawing.Point(16, 0)
        Me.BalanceTextLabel.Name = "BalanceTextLabel"
        Me.BalanceTextLabel.Size = New System.Drawing.Size(82, 27)
        Me.BalanceTextLabel.TabIndex = 1
        Me.BalanceTextLabel.Text = "Balance"
        '
        'PayButton
        '
        Me.PayButton.AutoSize = True
        Me.PayButton.BackColor = System.Drawing.Color.YellowGreen
        Me.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayButton.Location = New System.Drawing.Point(21, 62)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(76, 35)
        Me.PayButton.TabIndex = 0
        Me.PayButton.Text = "Pay"
        Me.PayButton.UseVisualStyleBackColor = False
        '
        'PaymentPromptPage
        '
        Me.PaymentPromptPage.BackColor = System.Drawing.Color.LightGray
        Me.PaymentPromptPage.Controls.Add(Me.PayInstructionLabel2)
        Me.PaymentPromptPage.Controls.Add(Me.PayInstructionLabel1)
        Me.PaymentPromptPage.Controls.Add(Me.CancelButton)
        Me.PaymentPromptPage.Location = New System.Drawing.Point(0, 0)
        Me.PaymentPromptPage.Name = "PaymentPromptPage"
        Me.PaymentPromptPage.Size = New System.Drawing.Size(116, 100)
        Me.PaymentPromptPage.TabIndex = 3
        '
        'PayInstructionLabel2
        '
        Me.PayInstructionLabel2.AutoSize = True
        Me.PayInstructionLabel2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayInstructionLabel2.Location = New System.Drawing.Point(5, 42)
        Me.PayInstructionLabel2.Name = "PayInstructionLabel2"
        Me.PayInstructionLabel2.Size = New System.Drawing.Size(110, 23)
        Me.PayInstructionLabel2.TabIndex = 2
        Me.PayInstructionLabel2.Text = "near machine"
        '
        'PayInstructionLabel1
        '
        Me.PayInstructionLabel1.AutoSize = True
        Me.PayInstructionLabel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayInstructionLabel1.Location = New System.Drawing.Point(7, 1)
        Me.PayInstructionLabel1.Name = "PayInstructionLabel1"
        Me.PayInstructionLabel1.Size = New System.Drawing.Size(101, 23)
        Me.PayInstructionLabel1.TabIndex = 1
        Me.PayInstructionLabel1.Text = "Move watch"
        '
        'CancelButton
        '
        Me.CancelButton.AutoSize = True
        Me.CancelButton.BackColor = System.Drawing.Color.Coral
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(20, 66)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(67, 33)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'WalletControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MainWalletPage)
        Me.Controls.Add(Me.PaymentPromptPage)
        Me.Name = "WalletControl"
        Me.Size = New System.Drawing.Size(116, 100)
        Me.MainWalletPage.ResumeLayout(False)
        Me.MainWalletPage.PerformLayout()
        Me.PaymentPromptPage.ResumeLayout(False)
        Me.PaymentPromptPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWalletPage As Panel
    Friend WithEvents BalanceAmountLabel As Label
    Friend WithEvents BalanceTextLabel As Label
    Friend WithEvents PayButton As Button
    Friend WithEvents PaymentPromptPage As Panel
    Friend WithEvents PayInstructionLabel2 As Label
    Friend WithEvents PayInstructionLabel1 As Label
    Friend WithEvents CancelButton As Button
End Class
