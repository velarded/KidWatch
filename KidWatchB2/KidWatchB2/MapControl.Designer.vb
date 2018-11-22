<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapControl
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
        Me.PlacesListPage = New System.Windows.Forms.Panel()
        Me.PlacesListBackButton = New System.Windows.Forms.Button()
        Me.PlaceSchoolButton = New System.Windows.Forms.Button()
        Me.PlaceLibraryButton = New System.Windows.Forms.Button()
        Me.PlaceHomeButton = New System.Windows.Forms.Button()
        Me.DirectionsPanel3 = New System.Windows.Forms.Panel()
        Me.DirectionsButton3 = New System.Windows.Forms.Button()
        Me.DirectionsPanel2 = New System.Windows.Forms.Panel()
        Me.DirectionsButton2 = New System.Windows.Forms.Button()
        Me.DirectionsPanel1 = New System.Windows.Forms.Panel()
        Me.WalkInstructionButton1 = New System.Windows.Forms.Button()
        Me.MainMapsPage = New System.Windows.Forms.Panel()
        Me.CurrentLocationLabel = New System.Windows.Forms.Label()
        Me.PlacesButton = New System.Windows.Forms.Button()
        Me.PlacesListPage.SuspendLayout()
        Me.DirectionsPanel3.SuspendLayout()
        Me.DirectionsPanel2.SuspendLayout()
        Me.DirectionsPanel1.SuspendLayout()
        Me.MainMapsPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlacesListPage
        '
        Me.PlacesListPage.AutoScroll = True
        Me.PlacesListPage.BackColor = System.Drawing.Color.Bisque
        Me.PlacesListPage.Controls.Add(Me.PlacesListBackButton)
        Me.PlacesListPage.Controls.Add(Me.PlaceSchoolButton)
        Me.PlacesListPage.Controls.Add(Me.PlaceLibraryButton)
        Me.PlacesListPage.Controls.Add(Me.PlaceHomeButton)
        Me.PlacesListPage.Location = New System.Drawing.Point(2, 104)
        Me.PlacesListPage.Margin = New System.Windows.Forms.Padding(2)
        Me.PlacesListPage.Name = "PlacesListPage"
        Me.PlacesListPage.Size = New System.Drawing.Size(116, 314)
        Me.PlacesListPage.TabIndex = 1
        '
        'PlacesListBackButton
        '
        Me.PlacesListBackButton.BackColor = System.Drawing.Color.Coral
        Me.PlacesListBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlacesListBackButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacesListBackButton.Location = New System.Drawing.Point(21, 262)
        Me.PlacesListBackButton.Name = "PlacesListBackButton"
        Me.PlacesListBackButton.Size = New System.Drawing.Size(75, 30)
        Me.PlacesListBackButton.TabIndex = 5
        Me.PlacesListBackButton.Text = "BACK"
        Me.PlacesListBackButton.UseVisualStyleBackColor = False
        '
        'PlaceSchoolButton
        '
        Me.PlaceSchoolButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.place_school_icon
        Me.PlaceSchoolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaceSchoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceSchoolButton.Location = New System.Drawing.Point(21, 177)
        Me.PlaceSchoolButton.Name = "PlaceSchoolButton"
        Me.PlaceSchoolButton.Size = New System.Drawing.Size(75, 79)
        Me.PlaceSchoolButton.TabIndex = 4
        Me.PlaceSchoolButton.UseVisualStyleBackColor = True
        '
        'PlaceLibraryButton
        '
        Me.PlaceLibraryButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.place_library_icon
        Me.PlaceLibraryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaceLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceLibraryButton.Location = New System.Drawing.Point(21, 92)
        Me.PlaceLibraryButton.Name = "PlaceLibraryButton"
        Me.PlaceLibraryButton.Size = New System.Drawing.Size(75, 79)
        Me.PlaceLibraryButton.TabIndex = 3
        Me.PlaceLibraryButton.UseVisualStyleBackColor = True
        '
        'PlaceHomeButton
        '
        Me.PlaceHomeButton.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.place_home_icon
        Me.PlaceHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaceHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaceHomeButton.Location = New System.Drawing.Point(21, 7)
        Me.PlaceHomeButton.Name = "PlaceHomeButton"
        Me.PlaceHomeButton.Size = New System.Drawing.Size(75, 79)
        Me.PlaceHomeButton.TabIndex = 2
        Me.PlaceHomeButton.UseVisualStyleBackColor = True
        '
        'DirectionsPanel3
        '
        Me.DirectionsPanel3.BackColor = System.Drawing.Color.LightCoral
        Me.DirectionsPanel3.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.directions_page_3
        Me.DirectionsPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DirectionsPanel3.Controls.Add(Me.DirectionsButton3)
        Me.DirectionsPanel3.Location = New System.Drawing.Point(2, 620)
        Me.DirectionsPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectionsPanel3.Name = "DirectionsPanel3"
        Me.DirectionsPanel3.Size = New System.Drawing.Size(116, 100)
        Me.DirectionsPanel3.TabIndex = 3
        '
        'DirectionsButton3
        '
        Me.DirectionsButton3.BackColor = System.Drawing.Color.YellowGreen
        Me.DirectionsButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DirectionsButton3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectionsButton3.Location = New System.Drawing.Point(0, 70)
        Me.DirectionsButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.DirectionsButton3.Name = "DirectionsButton3"
        Me.DirectionsButton3.Size = New System.Drawing.Size(116, 29)
        Me.DirectionsButton3.TabIndex = 0
        Me.DirectionsButton3.Text = "Arrived at library!"
        Me.DirectionsButton3.UseVisualStyleBackColor = False
        '
        'DirectionsPanel2
        '
        Me.DirectionsPanel2.BackColor = System.Drawing.Color.LightCoral
        Me.DirectionsPanel2.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.directions_page_2
        Me.DirectionsPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DirectionsPanel2.Controls.Add(Me.DirectionsButton2)
        Me.DirectionsPanel2.Location = New System.Drawing.Point(2, 521)
        Me.DirectionsPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectionsPanel2.Name = "DirectionsPanel2"
        Me.DirectionsPanel2.Size = New System.Drawing.Size(116, 100)
        Me.DirectionsPanel2.TabIndex = 2
        '
        'DirectionsButton2
        '
        Me.DirectionsButton2.BackColor = System.Drawing.Color.LightCyan
        Me.DirectionsButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DirectionsButton2.Font = New System.Drawing.Font("Comic Sans MS", 8.2!, System.Drawing.FontStyle.Bold)
        Me.DirectionsButton2.Location = New System.Drawing.Point(2, 68)
        Me.DirectionsButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.DirectionsButton2.Name = "DirectionsButton2"
        Me.DirectionsButton2.Size = New System.Drawing.Size(112, 29)
        Me.DirectionsButton2.TabIndex = 0
        Me.DirectionsButton2.Text = "Turn right 50m"
        Me.DirectionsButton2.UseVisualStyleBackColor = False
        '
        'DirectionsPanel1
        '
        Me.DirectionsPanel1.BackColor = System.Drawing.Color.LightCoral
        Me.DirectionsPanel1.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.directions_page_1
        Me.DirectionsPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DirectionsPanel1.Controls.Add(Me.WalkInstructionButton1)
        Me.DirectionsPanel1.Location = New System.Drawing.Point(2, 422)
        Me.DirectionsPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.DirectionsPanel1.Name = "DirectionsPanel1"
        Me.DirectionsPanel1.Size = New System.Drawing.Size(116, 100)
        Me.DirectionsPanel1.TabIndex = 1
        '
        'WalkInstructionButton1
        '
        Me.WalkInstructionButton1.BackColor = System.Drawing.Color.LightCyan
        Me.WalkInstructionButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WalkInstructionButton1.Font = New System.Drawing.Font("Comic Sans MS", 8.2!, System.Drawing.FontStyle.Bold)
        Me.WalkInstructionButton1.Location = New System.Drawing.Point(2, 68)
        Me.WalkInstructionButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.WalkInstructionButton1.Name = "WalkInstructionButton1"
        Me.WalkInstructionButton1.Size = New System.Drawing.Size(112, 29)
        Me.WalkInstructionButton1.TabIndex = 0
        Me.WalkInstructionButton1.Text = "Turn left 100m"
        Me.WalkInstructionButton1.UseVisualStyleBackColor = False
        '
        'MainMapsPage
        '
        Me.MainMapsPage.BackColor = System.Drawing.Color.LightCoral
        Me.MainMapsPage.BackgroundImage = Global.KidWatchB2.My.Resources.Resources.map_location
        Me.MainMapsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMapsPage.Controls.Add(Me.CurrentLocationLabel)
        Me.MainMapsPage.Controls.Add(Me.PlacesButton)
        Me.MainMapsPage.Location = New System.Drawing.Point(0, 0)
        Me.MainMapsPage.Margin = New System.Windows.Forms.Padding(2)
        Me.MainMapsPage.Name = "MainMapsPage"
        Me.MainMapsPage.Size = New System.Drawing.Size(116, 100)
        Me.MainMapsPage.TabIndex = 0
        '
        'CurrentLocationLabel
        '
        Me.CurrentLocationLabel.AutoSize = True
        Me.CurrentLocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentLocationLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentLocationLabel.Location = New System.Drawing.Point(13, 5)
        Me.CurrentLocationLabel.Name = "CurrentLocationLabel"
        Me.CurrentLocationLabel.Size = New System.Drawing.Size(97, 16)
        Me.CurrentLocationLabel.TabIndex = 1
        Me.CurrentLocationLabel.Text = "Location: School"
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
        'MapControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DirectionsPanel3)
        Me.Controls.Add(Me.DirectionsPanel2)
        Me.Controls.Add(Me.DirectionsPanel1)
        Me.Controls.Add(Me.PlacesListPage)
        Me.Controls.Add(Me.MainMapsPage)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MapControl"
        Me.Size = New System.Drawing.Size(120, 726)
        Me.PlacesListPage.ResumeLayout(False)
        Me.DirectionsPanel3.ResumeLayout(False)
        Me.DirectionsPanel2.ResumeLayout(False)
        Me.DirectionsPanel1.ResumeLayout(False)
        Me.MainMapsPage.ResumeLayout(False)
        Me.MainMapsPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMapsPage As Panel
    Friend WithEvents PlacesButton As Button
    Friend WithEvents PlacesListPage As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PlaceHomeButton As Button
    Friend WithEvents PlaceLibraryButton As Button
    Friend WithEvents PlaceSchoolButton As Button
    Friend WithEvents PlacesListBackButton As Button
    Friend WithEvents DirectionsPanel1 As Panel
    Friend WithEvents WalkInstructionButton1 As Button
    Friend WithEvents DirectionsPanel2 As Panel
    Friend WithEvents DirectionsButton2 As Button
    Friend WithEvents DirectionsPanel3 As Panel
    Friend WithEvents DirectionsButton3 As Button
    Friend WithEvents CurrentLocationLabel As Label
End Class
