<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.PopupPanel = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SnoozeButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PopupPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 4)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(110, 23)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Do Homework"
        '
        'OKButton
        '
        Me.OKButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(7, 67)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(41, 30)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'DetailsButton
        '
        Me.DetailsButton.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.Location = New System.Drawing.Point(21, 35)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(70, 30)
        Me.DetailsButton.TabIndex = 2
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.UseVisualStyleBackColor = True
        '
        'PopupPanel
        '
        Me.PopupPanel.BackColor = System.Drawing.Color.Transparent
        Me.PopupPanel.Controls.Add(Me.SnoozeButton)
        Me.PopupPanel.Controls.Add(Me.TitleLabel)
        Me.PopupPanel.Controls.Add(Me.DetailsButton)
        Me.PopupPanel.Controls.Add(Me.OKButton)
        Me.PopupPanel.Location = New System.Drawing.Point(0, 0)
        Me.PopupPanel.Name = "PopupPanel"
        Me.PopupPanel.Size = New System.Drawing.Size(116, 100)
        Me.PopupPanel.TabIndex = 3
        '
        'DetailsPanel
        '
        Me.DetailsPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsPanel.Controls.Add(Me.Label2)
        Me.DetailsPanel.Controls.Add(Me.Button1)
        Me.DetailsPanel.Controls.Add(Me.Button2)
        Me.DetailsPanel.Controls.Add(Me.Label1)
        Me.DetailsPanel.Location = New System.Drawing.Point(0, 104)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(116, 100)
        Me.DetailsPanel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do Homework"
        '
        'SnoozeButton
        '
        Me.SnoozeButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnoozeButton.Location = New System.Drawing.Point(50, 67)
        Me.SnoozeButton.Name = "SnoozeButton"
        Me.SnoozeButton.Size = New System.Drawing.Size(63, 30)
        Me.SnoozeButton.TabIndex = 3
        Me.SnoozeButton.Text = "Snooze"
        Me.SnoozeButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(50, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Snooze"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(7, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 24)
        Me.Label2.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Finish math homework"
        '
        'Reminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.PopupPanel)
        Me.Name = "Reminder"
        Me.Size = New System.Drawing.Size(116, 218)
        Me.PopupPanel.ResumeLayout(False)
        Me.PopupPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents DetailsButton As Button
    Friend WithEvents PopupPanel As Panel
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SnoozeButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
