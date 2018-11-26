<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.OpenKidWatchButton = New System.Windows.Forms.Button()
        Me.OpenParentPhoneButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenKidWatchButton
        '
        Me.OpenKidWatchButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenKidWatchButton.Location = New System.Drawing.Point(33, 139)
        Me.OpenKidWatchButton.Name = "OpenKidWatchButton"
        Me.OpenKidWatchButton.Size = New System.Drawing.Size(143, 140)
        Me.OpenKidWatchButton.TabIndex = 0
        Me.OpenKidWatchButton.Text = "Open KidWatch"
        Me.OpenKidWatchButton.UseVisualStyleBackColor = True
        '
        'OpenParentPhoneButton
        '
        Me.OpenParentPhoneButton.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenParentPhoneButton.Location = New System.Drawing.Point(244, 139)
        Me.OpenParentPhoneButton.Name = "OpenParentPhoneButton"
        Me.OpenParentPhoneButton.Size = New System.Drawing.Size(143, 140)
        Me.OpenParentPhoneButton.TabIndex = 1
        Me.OpenParentPhoneButton.Text = "Open Parent Phone"
        Me.OpenParentPhoneButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 427)
        Me.Controls.Add(Me.OpenParentPhoneButton)
        Me.Controls.Add(Me.OpenKidWatchButton)
        Me.Name = "MainForm"
        Me.Text = "Group B2 - KidWatch"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenKidWatchButton As Button
    Friend WithEvents OpenParentPhoneButton As Button
End Class
