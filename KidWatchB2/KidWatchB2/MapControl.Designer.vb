<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapControl
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
        Me.MainMapsPage = New System.Windows.Forms.Panel()
        Me.PlacesButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainMapsPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMapsPage
        '
        Me.MainMapsPage.BackColor = System.Drawing.Color.LightCoral
        Me.MainMapsPage.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.map_location
        Me.MainMapsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMapsPage.Controls.Add(Me.PlacesButton)
        Me.MainMapsPage.Location = New System.Drawing.Point(0, 0)
        Me.MainMapsPage.Name = "MainMapsPage"
        Me.MainMapsPage.Size = New System.Drawing.Size(155, 123)
        Me.MainMapsPage.TabIndex = 0
        '
        'PlacesButton
        '
        Me.PlacesButton.BackColor = System.Drawing.Color.LightCyan
        Me.PlacesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlacesButton.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.PlacesButton.Location = New System.Drawing.Point(40, 83)
        Me.PlacesButton.Name = "PlacesButton"
        Me.PlacesButton.Size = New System.Drawing.Size(75, 37)
        Me.PlacesButton.TabIndex = 0
        Me.PlacesButton.Text = "Places"
        Me.PlacesButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(227, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 399)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'MapControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MainMapsPage)
        Me.Name = "MapControl"
        Me.Size = New System.Drawing.Size(527, 473)
        Me.MainMapsPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMapsPage As Panel
    Friend WithEvents PlacesButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
