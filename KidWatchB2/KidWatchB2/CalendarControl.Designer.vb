<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalendarControl
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
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.DailyScheduleButton = New System.Windows.Forms.Button()
        Me.DatePanel = New System.Windows.Forms.Panel()
        Me.DailySchedulePanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DailyScheduleLabel = New System.Windows.Forms.Label()
        Me.AppointmentPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppointmentConfirmButton = New System.Windows.Forms.Button()
        Me.DatePanel.SuspendLayout()
        Me.DailySchedulePanel.SuspendLayout()
        Me.AppointmentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.Aqua
        Me.dateLabel.Location = New System.Drawing.Point(14, 12)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(95, 23)
        Me.dateLabel.TabIndex = 0
        Me.dateLabel.Text = "22-11-2018"
        '
        'DailyScheduleButton
        '
        Me.DailyScheduleButton.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyScheduleButton.ForeColor = System.Drawing.Color.Maroon
        Me.DailyScheduleButton.Location = New System.Drawing.Point(29, 43)
        Me.DailyScheduleButton.Name = "DailyScheduleButton"
        Me.DailyScheduleButton.Size = New System.Drawing.Size(62, 43)
        Me.DailyScheduleButton.TabIndex = 1
        Me.DailyScheduleButton.Text = "Today's Schedule"
        Me.DailyScheduleButton.UseVisualStyleBackColor = True
        '
        'DatePanel
        '
        Me.DatePanel.BackColor = System.Drawing.Color.Olive
        Me.DatePanel.Controls.Add(Me.DailyScheduleButton)
        Me.DatePanel.Controls.Add(Me.dateLabel)
        Me.DatePanel.Location = New System.Drawing.Point(0, 2)
        Me.DatePanel.Name = "DatePanel"
        Me.DatePanel.Size = New System.Drawing.Size(116, 100)
        Me.DatePanel.TabIndex = 2
        '
        'DailySchedulePanel
        '
        Me.DailySchedulePanel.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.DailySchedulePanel.Controls.Add(Me.Button1)
        Me.DailySchedulePanel.Controls.Add(Me.DailyScheduleLabel)
        Me.DailySchedulePanel.Location = New System.Drawing.Point(0, 104)
        Me.DailySchedulePanel.Name = "DailySchedulePanel"
        Me.DailySchedulePanel.Size = New System.Drawing.Size(116, 100)
        Me.DailySchedulePanel.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(34, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dentist Appointment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DailyScheduleLabel
        '
        Me.DailyScheduleLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyScheduleLabel.ForeColor = System.Drawing.Color.Maroon
        Me.DailyScheduleLabel.Location = New System.Drawing.Point(0, 11)
        Me.DailyScheduleLabel.Name = "DailyScheduleLabel"
        Me.DailyScheduleLabel.Size = New System.Drawing.Size(118, 82)
        Me.DailyScheduleLabel.TabIndex = 0
        Me.DailyScheduleLabel.Text = "9AM-3PM: School" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3PM-5PM: Library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6PM: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AppointmentPanel
        '
        Me.AppointmentPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AppointmentPanel.Controls.Add(Me.AppointmentConfirmButton)
        Me.AppointmentPanel.Controls.Add(Me.Label1)
        Me.AppointmentPanel.Location = New System.Drawing.Point(0, 205)
        Me.AppointmentPanel.Name = "AppointmentPanel"
        Me.AppointmentPanel.Size = New System.Drawing.Size(116, 100)
        Me.AppointmentPanel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Go to Dr. Chan's Clinic for regular checkup"
        '
        'AppointmentConfirmButton
        '
        Me.AppointmentConfirmButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentConfirmButton.ForeColor = System.Drawing.Color.DarkGreen
        Me.AppointmentConfirmButton.Location = New System.Drawing.Point(34, 66)
        Me.AppointmentConfirmButton.Name = "AppointmentConfirmButton"
        Me.AppointmentConfirmButton.Size = New System.Drawing.Size(40, 23)
        Me.AppointmentConfirmButton.TabIndex = 1
        Me.AppointmentConfirmButton.Text = "OK"
        Me.AppointmentConfirmButton.UseVisualStyleBackColor = True
        '
        'CalendarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.AppointmentPanel)
        Me.Controls.Add(Me.DailySchedulePanel)
        Me.Controls.Add(Me.DatePanel)
        Me.Name = "CalendarControl"
        Me.Size = New System.Drawing.Size(116, 353)
        Me.DatePanel.ResumeLayout(False)
        Me.DatePanel.PerformLayout()
        Me.DailySchedulePanel.ResumeLayout(False)
        Me.AppointmentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dateLabel As Label
    Friend WithEvents DailyScheduleButton As Button
    Friend WithEvents DatePanel As Panel
    Friend WithEvents DailySchedulePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DailyScheduleLabel As Label
    Friend WithEvents AppointmentPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AppointmentConfirmButton As Button
End Class
