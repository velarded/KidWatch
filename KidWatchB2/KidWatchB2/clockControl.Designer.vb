<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clockControl
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
        Me.components = New System.ComponentModel.Container()
        Me.DigitalTimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AnalogClockPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.AnalogClockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DigitalTimeLabel
        '
        Me.DigitalTimeLabel.AutoSize = True
        Me.DigitalTimeLabel.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalTimeLabel.ForeColor = System.Drawing.Color.Aqua
        Me.DigitalTimeLabel.Location = New System.Drawing.Point(11, 76)
        Me.DigitalTimeLabel.Name = "DigitalTimeLabel"
        Me.DigitalTimeLabel.Size = New System.Drawing.Size(103, 19)
        Me.DigitalTimeLabel.TabIndex = 1
        Me.DigitalTimeLabel.Text = "10:10:30 AM"
        '
        'Timer1
        '
        '
        'AnalogClockPictureBox
        '
        Me.AnalogClockPictureBox.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.clipart_arabic_clock_19
        Me.AnalogClockPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AnalogClockPictureBox.Location = New System.Drawing.Point(16, -2)
        Me.AnalogClockPictureBox.Name = "AnalogClockPictureBox"
        Me.AnalogClockPictureBox.Size = New System.Drawing.Size(80, 80)
        Me.AnalogClockPictureBox.TabIndex = 0
        Me.AnalogClockPictureBox.TabStop = False
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
