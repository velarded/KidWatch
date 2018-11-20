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
        Me.PlacesListPage = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeLabel = New System.Windows.Forms.Label()
        Me.MainMapsPage.SuspendLayout()
        Me.PlacesListPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMapsPage
        '
        Me.MainMapsPage.BackColor = System.Drawing.Color.LightCoral
        Me.MainMapsPage.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.map_location
        Me.MainMapsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMapsPage.Controls.Add(Me.PlacesButton)
        Me.MainMapsPage.Location = New System.Drawing.Point(0, 0)
        Me.MainMapsPage.Margin = New System.Windows.Forms.Padding(2)
        Me.MainMapsPage.Name = "MainMapsPage"
        Me.MainMapsPage.Size = New System.Drawing.Size(116, 100)
        Me.MainMapsPage.TabIndex = 0
        '
        'PlacesButton
        '
        Me.PlacesButton.BackColor = System.Drawing.Color.LightCyan
        Me.PlacesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlacesButton.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold)
        Me.PlacesButton.Location = New System.Drawing.Point(28, 67)
        Me.PlacesButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PlacesButton.Name = "PlacesButton"
        Me.PlacesButton.Size = New System.Drawing.Size(61, 30)
        Me.PlacesButton.TabIndex = 0
        Me.PlacesButton.Text = "Places"
        Me.PlacesButton.UseVisualStyleBackColor = False
        '
        'PlacesListPage
        '
        Me.PlacesListPage.AutoScroll = True
        Me.PlacesListPage.BackColor = System.Drawing.Color.Bisque
        Me.PlacesListPage.Controls.Add(Me.Label2)
        Me.PlacesListPage.Controls.Add(Me.HomeLabel)
        Me.PlacesListPage.Location = New System.Drawing.Point(0, 0)
        Me.PlacesListPage.Margin = New System.Windows.Forms.Padding(2)
        Me.PlacesListPage.Name = "PlacesListPage"
        Me.PlacesListPage.Size = New System.Drawing.Size(116, 100)
        Me.PlacesListPage.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'HomeLabel
        '
        Me.HomeLabel.AutoSize = True
        Me.HomeLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeLabel.Location = New System.Drawing.Point(38, 10)
        Me.HomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(51, 23)
        Me.HomeLabel.TabIndex = 0
        Me.HomeLabel.Text = "Home"
        '
        'MapControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PlacesListPage)
        Me.Controls.Add(Me.MainMapsPage)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MapControl"
        Me.Size = New System.Drawing.Size(116, 100)
        Me.MainMapsPage.ResumeLayout(False)
        Me.PlacesListPage.ResumeLayout(False)
        Me.PlacesListPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMapsPage As Panel
    Friend WithEvents PlacesButton As Button
    Friend WithEvents PlacesListPage As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents HomeLabel As Label
End Class
