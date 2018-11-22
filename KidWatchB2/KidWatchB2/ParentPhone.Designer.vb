<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentPhone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentPhone))
        Me.ParentPhoneMainControl1 = New KidWatchB2.ParentPhoneMainControl()
        Me.SuspendLayout()
        '
        'ParentPhoneMainControl1
        '
        Me.ParentPhoneMainControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ParentPhoneMainControl1.Location = New System.Drawing.Point(33, 84)
        Me.ParentPhoneMainControl1.Name = "ParentPhoneMainControl1"
        Me.ParentPhoneMainControl1.Size = New System.Drawing.Size(248, 396)
        Me.ParentPhoneMainControl1.TabIndex = 0
        '
        'ParentPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 567)
        Me.Controls.Add(Me.ParentPhoneMainControl1)
        Me.Name = "ParentPhone"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "ParentPhone"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParentPhoneMainControl1 As ParentPhoneMainControl
End Class
