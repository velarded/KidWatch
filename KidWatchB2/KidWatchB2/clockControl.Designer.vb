﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clockControl
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
        Me.components = New System.ComponentModel.Container()
        Me.AnalogClockPictureBox = New System.Windows.Forms.PictureBox()
        Me.DigitalTimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AnalogClockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnalogClockPictureBox
        '
        Me.AnalogClockPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.ios_clock_icon2
        Me.AnalogClockPictureBox.Location = New System.Drawing.Point(27, 9)
        Me.AnalogClockPictureBox.Name = "AnalogClockPictureBox"
        Me.AnalogClockPictureBox.Size = New System.Drawing.Size(59, 59)
        Me.AnalogClockPictureBox.TabIndex = 0
        Me.AnalogClockPictureBox.TabStop = False
        '
        'DigitalTimeLabel
        '
        Me.DigitalTimeLabel.AutoSize = True
        Me.DigitalTimeLabel.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalTimeLabel.ForeColor = System.Drawing.Color.Aqua
        Me.DigitalTimeLabel.Location = New System.Drawing.Point(13, 69)
        Me.DigitalTimeLabel.Name = "DigitalTimeLabel"
        Me.DigitalTimeLabel.Size = New System.Drawing.Size(100, 19)
        Me.DigitalTimeLabel.TabIndex = 1
        Me.DigitalTimeLabel.Text = Date.Now.ToString("hh:mm:ss tt")
        '
        'Timer1
        '
        '
        'clockControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.DigitalTimeLabel)
        Me.Controls.Add(Me.AnalogClockPictureBox)
        Me.Name = "clockControl"
        Me.Size = New System.Drawing.Size(116, 100)
        CType(Me.AnalogClockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AnalogClockPictureBox As PictureBox
    Friend WithEvents DigitalTimeLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
