<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentPhoneKidWatchAppControl
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
        Me.ViewChildLocationButton = New System.Windows.Forms.Button()
        Me.KidWatchMainAppPage = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KidWatchMainAppPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewChildLocationButton
        '
        Me.ViewChildLocationButton.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewChildLocationButton.Location = New System.Drawing.Point(3, 3)
        Me.ViewChildLocationButton.Name = "ViewChildLocationButton"
        Me.ViewChildLocationButton.Size = New System.Drawing.Size(138, 104)
        Me.ViewChildLocationButton.TabIndex = 0
        Me.ViewChildLocationButton.Text = "View Child Location"
        Me.ViewChildLocationButton.UseVisualStyleBackColor = True
        '
        'KidWatchMainAppPage
        '
        Me.KidWatchMainAppPage.Controls.Add(Me.ViewChildLocationButton)
        Me.KidWatchMainAppPage.Location = New System.Drawing.Point(0, 0)
        Me.KidWatchMainAppPage.Name = "KidWatchMainAppPage"
        Me.KidWatchMainAppPage.Size = New System.Drawing.Size(331, 487)
        Me.KidWatchMainAppPage.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(337, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(331, 487)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 236)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ParentPhoneKidWatchAppControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.KidWatchMainAppPage)
        Me.Name = "ParentPhoneKidWatchAppControl"
        Me.Size = New System.Drawing.Size(878, 575)
        Me.KidWatchMainAppPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewChildLocationButton As Button
    Friend WithEvents KidWatchMainAppPage As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
