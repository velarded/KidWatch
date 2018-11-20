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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PayInstructionLabel2 = New System.Windows.Forms.Label()
        Me.PayInstructionLabel1 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PaymentFailPage = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaymentSuccessPage = New System.Windows.Forms.Panel()
        Me.PaymentSuccessOKButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaymentSuccessLabel = New System.Windows.Forms.Label()
        Me.PaymentFailedOKButton = New System.Windows.Forms.Button()
        Me.MainWalletPage.SuspendLayout()
        Me.PaymentPromptPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentFailPage.SuspendLayout()
        Me.PaymentSuccessPage.SuspendLayout()
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
        Me.PaymentPromptPage.Controls.Add(Me.PictureBox1)
        Me.PaymentPromptPage.Controls.Add(Me.PayInstructionLabel2)
        Me.PaymentPromptPage.Controls.Add(Me.PayInstructionLabel1)
        Me.PaymentPromptPage.Controls.Add(Me.CancelButton)
        Me.PaymentPromptPage.Location = New System.Drawing.Point(0, 0)
        Me.PaymentPromptPage.Name = "PaymentPromptPage"
        Me.PaymentPromptPage.Size = New System.Drawing.Size(116, 100)
        Me.PaymentPromptPage.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.tap_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(30, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PayInstructionLabel2
        '
        Me.PayInstructionLabel2.AutoSize = True
        Me.PayInstructionLabel2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayInstructionLabel2.Location = New System.Drawing.Point(5, 44)
        Me.PayInstructionLabel2.Name = "PayInstructionLabel2"
        Me.PayInstructionLabel2.Size = New System.Drawing.Size(110, 23)
        Me.PayInstructionLabel2.TabIndex = 2
        Me.PayInstructionLabel2.Text = "near machine"
        '
        'PayInstructionLabel1
        '
        Me.PayInstructionLabel1.AutoSize = True
        Me.PayInstructionLabel1.BackColor = System.Drawing.Color.Transparent
        Me.PayInstructionLabel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayInstructionLabel1.Location = New System.Drawing.Point(7, -2)
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
        Me.CancelButton.Location = New System.Drawing.Point(21, 64)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(67, 33)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'PaymentFailPage
        '
        Me.PaymentFailPage.BackColor = System.Drawing.Color.LightGray
        Me.PaymentFailPage.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.sad_face
        Me.PaymentFailPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PaymentFailPage.Controls.Add(Me.PaymentFailedOKButton)
        Me.PaymentFailPage.Controls.Add(Me.Label3)
        Me.PaymentFailPage.Controls.Add(Me.Label2)
        Me.PaymentFailPage.Controls.Add(Me.Label4)
        Me.PaymentFailPage.Location = New System.Drawing.Point(0, 0)
        Me.PaymentFailPage.Name = "PaymentFailPage"
        Me.PaymentFailPage.Size = New System.Drawing.Size(116, 100)
        Me.PaymentFailPage.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "money"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "more"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "You need"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PaymentSuccessPage
        '
        Me.PaymentSuccessPage.BackColor = System.Drawing.Color.LightGray
        Me.PaymentSuccessPage.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.garfield
        Me.PaymentSuccessPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PaymentSuccessPage.Controls.Add(Me.PaymentSuccessOKButton)
        Me.PaymentSuccessPage.Controls.Add(Me.Label1)
        Me.PaymentSuccessPage.Controls.Add(Me.PaymentSuccessLabel)
        Me.PaymentSuccessPage.Location = New System.Drawing.Point(0, 0)
        Me.PaymentSuccessPage.Name = "PaymentSuccessPage"
        Me.PaymentSuccessPage.Size = New System.Drawing.Size(116, 100)
        Me.PaymentSuccessPage.TabIndex = 3
        '
        'PaymentSuccessOKButton
        '
        Me.PaymentSuccessOKButton.BackColor = System.Drawing.Color.YellowGreen
        Me.PaymentSuccessOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PaymentSuccessOKButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentSuccessOKButton.Location = New System.Drawing.Point(27, 71)
        Me.PaymentSuccessOKButton.Name = "PaymentSuccessOKButton"
        Me.PaymentSuccessOKButton.Size = New System.Drawing.Size(62, 29)
        Me.PaymentSuccessOKButton.TabIndex = 3
        Me.PaymentSuccessOKButton.Text = "OK"
        Me.PaymentSuccessOKButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "sent!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PaymentSuccessLabel
        '
        Me.PaymentSuccessLabel.AutoSize = True
        Me.PaymentSuccessLabel.BackColor = System.Drawing.Color.Transparent
        Me.PaymentSuccessLabel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentSuccessLabel.Location = New System.Drawing.Point(2, 2)
        Me.PaymentSuccessLabel.Name = "PaymentSuccessLabel"
        Me.PaymentSuccessLabel.Size = New System.Drawing.Size(78, 30)
        Me.PaymentSuccessLabel.TabIndex = 1
        Me.PaymentSuccessLabel.Text = "Money" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.PaymentSuccessLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PaymentFailedOKButton
        '
        Me.PaymentFailedOKButton.BackColor = System.Drawing.Color.YellowGreen
        Me.PaymentFailedOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PaymentFailedOKButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentFailedOKButton.Location = New System.Drawing.Point(7, 62)
        Me.PaymentFailedOKButton.Name = "PaymentFailedOKButton"
        Me.PaymentFailedOKButton.Size = New System.Drawing.Size(53, 31)
        Me.PaymentFailedOKButton.TabIndex = 5
        Me.PaymentFailedOKButton.Text = "OK"
        Me.PaymentFailedOKButton.UseVisualStyleBackColor = False
        '
        'WalletControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PaymentFailPage)
        Me.Controls.Add(Me.PaymentSuccessPage)
        Me.Controls.Add(Me.MainWalletPage)
        Me.Controls.Add(Me.PaymentPromptPage)
        Me.Name = "WalletControl"
        Me.Size = New System.Drawing.Size(626, 403)
        Me.MainWalletPage.ResumeLayout(False)
        Me.MainWalletPage.PerformLayout()
        Me.PaymentPromptPage.ResumeLayout(False)
        Me.PaymentPromptPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentFailPage.ResumeLayout(False)
        Me.PaymentFailPage.PerformLayout()
        Me.PaymentSuccessPage.ResumeLayout(False)
        Me.PaymentSuccessPage.PerformLayout()
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
    Friend WithEvents PaymentSuccessPage As Panel
    Friend WithEvents PaymentSuccessLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PaymentFailPage As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PaymentSuccessOKButton As Button
    Friend WithEvents PaymentFailedOKButton As Button
End Class
