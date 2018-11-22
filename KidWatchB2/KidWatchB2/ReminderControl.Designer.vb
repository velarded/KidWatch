<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReminderControl
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
        Me.HomeworkLabel2 = New System.Windows.Forms.Label()
        Me.OKButton2 = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.HmwkPopupPanel = New System.Windows.Forms.Panel()
        Me.SnoozeButton1 = New System.Windows.Forms.Button()
        Me.HmwkPopupDetailsPanel = New System.Windows.Forms.Panel()
        Me.HmwkDetailsLabel = New System.Windows.Forms.Label()
        Me.SnoozeButton2 = New System.Windows.Forms.Button()
        Me.OKButton3 = New System.Windows.Forms.Button()
        Me.HomeworkLabel3 = New System.Windows.Forms.Label()
        Me.RemindersPanel = New System.Windows.Forms.Panel()
        Me.NoneLabel = New System.Windows.Forms.Label()
        Me.TomorrowLabel = New System.Windows.Forms.Label()
        Me.TodayLabel = New System.Windows.Forms.Label()
        Me.OpenReminderButton = New System.Windows.Forms.Button()
        Me.RemindersLabel = New System.Windows.Forms.Label()
        Me.HmwkDetailsPanel = New System.Windows.Forms.Panel()
        Me.HmwkDetailsLabel1 = New System.Windows.Forms.Label()
        Me.OKButton1 = New System.Windows.Forms.Button()
        Me.HomeworkLabel1 = New System.Windows.Forms.Label()
        Me.HmwkPopupPanel.SuspendLayout()
        Me.HmwkPopupDetailsPanel.SuspendLayout()
        Me.RemindersPanel.SuspendLayout()
        Me.HmwkDetailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HomeworkLabel2
        '
        Me.HomeworkLabel2.AutoSize = True
        Me.HomeworkLabel2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeworkLabel2.Location = New System.Drawing.Point(3, 6)
        Me.HomeworkLabel2.Name = "HomeworkLabel2"
        Me.HomeworkLabel2.Size = New System.Drawing.Size(110, 23)
        Me.HomeworkLabel2.TabIndex = 0
        Me.HomeworkLabel2.Text = "Do Homework"
        '
        'OKButton2
        '
        Me.OKButton2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton2.Location = New System.Drawing.Point(2, 67)
        Me.OKButton2.Name = "OKButton2"
        Me.OKButton2.Size = New System.Drawing.Size(51, 30)
        Me.OKButton2.TabIndex = 1
        Me.OKButton2.Text = "OK"
        Me.OKButton2.UseVisualStyleBackColor = True
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
        'HmwkPopupPanel
        '
        Me.HmwkPopupPanel.BackColor = System.Drawing.Color.Transparent
        Me.HmwkPopupPanel.Controls.Add(Me.SnoozeButton1)
        Me.HmwkPopupPanel.Controls.Add(Me.HomeworkLabel2)
        Me.HmwkPopupPanel.Controls.Add(Me.DetailsButton)
        Me.HmwkPopupPanel.Controls.Add(Me.OKButton2)
        Me.HmwkPopupPanel.Location = New System.Drawing.Point(0, 0)
        Me.HmwkPopupPanel.Name = "HmwkPopupPanel"
        Me.HmwkPopupPanel.Size = New System.Drawing.Size(116, 100)
        Me.HmwkPopupPanel.TabIndex = 3
        '
        'SnoozeButton1
        '
        Me.SnoozeButton1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnoozeButton1.Location = New System.Drawing.Point(53, 67)
        Me.SnoozeButton1.Name = "SnoozeButton1"
        Me.SnoozeButton1.Size = New System.Drawing.Size(60, 30)
        Me.SnoozeButton1.TabIndex = 3
        Me.SnoozeButton1.Text = "Snooze"
        Me.SnoozeButton1.UseVisualStyleBackColor = True
        '
        'HmwkPopupDetailsPanel
        '
        Me.HmwkPopupDetailsPanel.BackColor = System.Drawing.Color.Transparent
        Me.HmwkPopupDetailsPanel.Controls.Add(Me.HmwkDetailsLabel)
        Me.HmwkPopupDetailsPanel.Controls.Add(Me.SnoozeButton2)
        Me.HmwkPopupDetailsPanel.Controls.Add(Me.OKButton3)
        Me.HmwkPopupDetailsPanel.Controls.Add(Me.HomeworkLabel3)
        Me.HmwkPopupDetailsPanel.Location = New System.Drawing.Point(0, 0)
        Me.HmwkPopupDetailsPanel.Name = "HmwkPopupDetailsPanel"
        Me.HmwkPopupDetailsPanel.Size = New System.Drawing.Size(116, 100)
        Me.HmwkPopupDetailsPanel.TabIndex = 4
        '
        'HmwkDetailsLabel
        '
        Me.HmwkDetailsLabel.AutoSize = True
        Me.HmwkDetailsLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HmwkDetailsLabel.ForeColor = System.Drawing.Color.Black
        Me.HmwkDetailsLabel.Location = New System.Drawing.Point(4, 29)
        Me.HmwkDetailsLabel.MaximumSize = New System.Drawing.Size(120, 0)
        Me.HmwkDetailsLabel.Name = "HmwkDetailsLabel"
        Me.HmwkDetailsLabel.Size = New System.Drawing.Size(106, 36)
        Me.HmwkDetailsLabel.TabIndex = 6
        Me.HmwkDetailsLabel.Text = "Finish math homework today"
        Me.HmwkDetailsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SnoozeButton2
        '
        Me.SnoozeButton2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnoozeButton2.Location = New System.Drawing.Point(53, 67)
        Me.SnoozeButton2.Name = "SnoozeButton2"
        Me.SnoozeButton2.Size = New System.Drawing.Size(60, 30)
        Me.SnoozeButton2.TabIndex = 5
        Me.SnoozeButton2.Text = "Snooze"
        Me.SnoozeButton2.UseVisualStyleBackColor = True
        '
        'OKButton3
        '
        Me.OKButton3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton3.Location = New System.Drawing.Point(2, 67)
        Me.OKButton3.Name = "OKButton3"
        Me.OKButton3.Size = New System.Drawing.Size(51, 30)
        Me.OKButton3.TabIndex = 4
        Me.OKButton3.Text = "OK"
        Me.OKButton3.UseVisualStyleBackColor = True
        '
        'HomeworkLabel3
        '
        Me.HomeworkLabel3.AutoSize = True
        Me.HomeworkLabel3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeworkLabel3.Location = New System.Drawing.Point(3, 5)
        Me.HomeworkLabel3.Name = "HomeworkLabel3"
        Me.HomeworkLabel3.Size = New System.Drawing.Size(110, 23)
        Me.HomeworkLabel3.TabIndex = 0
        Me.HomeworkLabel3.Text = "Do Homework"
        '
        'RemindersPanel
        '
        Me.RemindersPanel.BackColor = System.Drawing.Color.Transparent
        Me.RemindersPanel.Controls.Add(Me.NoneLabel)
        Me.RemindersPanel.Controls.Add(Me.TomorrowLabel)
        Me.RemindersPanel.Controls.Add(Me.TodayLabel)
        Me.RemindersPanel.Controls.Add(Me.OpenReminderButton)
        Me.RemindersPanel.Controls.Add(Me.RemindersLabel)
        Me.RemindersPanel.Location = New System.Drawing.Point(0, 0)
        Me.RemindersPanel.Name = "RemindersPanel"
        Me.RemindersPanel.Size = New System.Drawing.Size(116, 100)
        Me.RemindersPanel.TabIndex = 5
        '
        'NoneLabel
        '
        Me.NoneLabel.AutoSize = True
        Me.NoneLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoneLabel.Location = New System.Drawing.Point(16, 79)
        Me.NoneLabel.Name = "NoneLabel"
        Me.NoneLabel.Size = New System.Drawing.Size(39, 18)
        Me.NoneLabel.TabIndex = 4
        Me.NoneLabel.Text = "None"
        '
        'TomorrowLabel
        '
        Me.TomorrowLabel.AutoSize = True
        Me.TomorrowLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomorrowLabel.Location = New System.Drawing.Point(4, 62)
        Me.TomorrowLabel.Name = "TomorrowLabel"
        Me.TomorrowLabel.Size = New System.Drawing.Size(69, 18)
        Me.TomorrowLabel.TabIndex = 3
        Me.TomorrowLabel.Text = "Tomorrow"
        '
        'TodayLabel
        '
        Me.TodayLabel.AutoSize = True
        Me.TodayLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodayLabel.Location = New System.Drawing.Point(4, 20)
        Me.TodayLabel.Name = "TodayLabel"
        Me.TodayLabel.Size = New System.Drawing.Size(46, 18)
        Me.TodayLabel.TabIndex = 2
        Me.TodayLabel.Text = "Today"
        '
        'OpenReminderButton
        '
        Me.OpenReminderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OpenReminderButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenReminderButton.Location = New System.Drawing.Point(10, 39)
        Me.OpenReminderButton.Name = "OpenReminderButton"
        Me.OpenReminderButton.Size = New System.Drawing.Size(100, 23)
        Me.OpenReminderButton.TabIndex = 1
        Me.OpenReminderButton.Text = "Do Homework"
        Me.OpenReminderButton.UseVisualStyleBackColor = False
        '
        'RemindersLabel
        '
        Me.RemindersLabel.AutoSize = True
        Me.RemindersLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemindersLabel.Location = New System.Drawing.Point(16, 1)
        Me.RemindersLabel.Name = "RemindersLabel"
        Me.RemindersLabel.Size = New System.Drawing.Size(85, 23)
        Me.RemindersLabel.TabIndex = 0
        Me.RemindersLabel.Text = "Reminders"
        '
        'HmwkDetailsPanel
        '
        Me.HmwkDetailsPanel.BackColor = System.Drawing.Color.Transparent
        Me.HmwkDetailsPanel.Controls.Add(Me.HmwkDetailsLabel1)
        Me.HmwkDetailsPanel.Controls.Add(Me.OKButton1)
        Me.HmwkDetailsPanel.Controls.Add(Me.HomeworkLabel1)
        Me.HmwkDetailsPanel.Location = New System.Drawing.Point(0, 0)
        Me.HmwkDetailsPanel.Name = "HmwkDetailsPanel"
        Me.HmwkDetailsPanel.Size = New System.Drawing.Size(116, 100)
        Me.HmwkDetailsPanel.TabIndex = 6
        '
        'HmwkDetailsLabel1
        '
        Me.HmwkDetailsLabel1.AutoSize = True
        Me.HmwkDetailsLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HmwkDetailsLabel1.ForeColor = System.Drawing.Color.Black
        Me.HmwkDetailsLabel1.Location = New System.Drawing.Point(4, 29)
        Me.HmwkDetailsLabel1.MaximumSize = New System.Drawing.Size(120, 0)
        Me.HmwkDetailsLabel1.Name = "HmwkDetailsLabel1"
        Me.HmwkDetailsLabel1.Size = New System.Drawing.Size(106, 36)
        Me.HmwkDetailsLabel1.TabIndex = 6
        Me.HmwkDetailsLabel1.Text = "Finish math homework today"
        Me.HmwkDetailsLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OKButton1
        '
        Me.OKButton1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton1.Location = New System.Drawing.Point(31, 67)
        Me.OKButton1.Name = "OKButton1"
        Me.OKButton1.Size = New System.Drawing.Size(51, 30)
        Me.OKButton1.TabIndex = 4
        Me.OKButton1.Text = "OK"
        Me.OKButton1.UseVisualStyleBackColor = True
        '
        'HomeworkLabel1
        '
        Me.HomeworkLabel1.AutoSize = True
        Me.HomeworkLabel1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeworkLabel1.Location = New System.Drawing.Point(3, 5)
        Me.HomeworkLabel1.Name = "HomeworkLabel1"
        Me.HomeworkLabel1.Size = New System.Drawing.Size(110, 23)
        Me.HomeworkLabel1.TabIndex = 0
        Me.HomeworkLabel1.Text = "Do Homework"
        '
        'ReminderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.RemindersPanel)
        Me.Controls.Add(Me.HmwkDetailsPanel)
        Me.Controls.Add(Me.HmwkPopupDetailsPanel)
        Me.Controls.Add(Me.HmwkPopupPanel)
        Me.Name = "ReminderControl"
        Me.Size = New System.Drawing.Size(116, 105)
        Me.HmwkPopupPanel.ResumeLayout(False)
        Me.HmwkPopupPanel.PerformLayout()
        Me.HmwkPopupDetailsPanel.ResumeLayout(False)
        Me.HmwkPopupDetailsPanel.PerformLayout()
        Me.RemindersPanel.ResumeLayout(False)
        Me.RemindersPanel.PerformLayout()
        Me.HmwkDetailsPanel.ResumeLayout(False)
        Me.HmwkDetailsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeworkLabel2 As Label
    Friend WithEvents OKButton2 As Button
    Friend WithEvents DetailsButton As Button
    Friend WithEvents HmwkPopupPanel As Panel
    Friend WithEvents HmwkPopupDetailsPanel As Panel
    Friend WithEvents HomeworkLabel3 As Label
    Friend WithEvents SnoozeButton1 As Button
    Friend WithEvents HmwkDetailsLabel As Label
    Friend WithEvents SnoozeButton2 As Button
    Friend WithEvents OKButton3 As Button
    Friend WithEvents RemindersPanel As Panel
    Friend WithEvents RemindersLabel As Label
    Friend WithEvents NoneLabel As Label
    Friend WithEvents TomorrowLabel As Label
    Friend WithEvents TodayLabel As Label
    Friend WithEvents OpenReminderButton As Button
    Friend WithEvents HmwkDetailsPanel As Panel
    Friend WithEvents HmwkDetailsLabel1 As Label
    Friend WithEvents OKButton1 As Button
    Friend WithEvents HomeworkLabel1 As Label
End Class
