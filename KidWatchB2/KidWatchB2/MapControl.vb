Public Class MapControl
    Public Sub New()
        InitializeComponent()
        DirectionsPanel3.Location = New Point(0, 0)
        DirectionsPanel2.Location = New Point(0, 0)
        DirectionsPanel1.Location = New Point(0, 0)
        PlacesListPage.Size = New Size(116, 100)
        PlacesListPage.Location = New Point(0, 0)
        MainMapsPage.Location = New Point(0, 0)
        MainMapsPage.BringToFront()
    End Sub

    Private Sub PlacesButton_Click(sender As Object, e As EventArgs) Handles PlacesButton.Click
        PlacesListPage.BringToFront()
    End Sub

    Private Sub PlacesListBackButton_Click(sender As Object, e As EventArgs) Handles PlacesListBackButton.Click
        MainMapsPage.BringToFront()
    End Sub

    Private Sub PlacesListButtons_Click(sender As Object, e As EventArgs) Handles PlaceHomeButton.Click, PlaceLibraryButton.Click, PlaceSchoolButton.Click
        Dim button As Button = sender
        If (button.Name.Equals("PlaceHomeButton")) Then
            DirectionsButton3.Text = "Arrived at Home!"
        ElseIf (button.Name.Equals("PlaceLibraryButton")) Then
            DirectionsButton3.Text = "Arrived at Library!"
        Else
            DirectionsButton3.Text = "Arrived at School!"
        End If

        'Show first direction page'
        DirectionsPanel1.BringToFront()
        Wait(2)
        DirectionsPanel2.BringToFront()
        Wait(2)

        DirectionsPanel3.BringToFront()

        Wait(2)

        If (button.Name.Equals("PlaceHomeButton")) Then
            CurrentLocationLabel.Text = "Location: Home"
        ElseIf (button.Name.Equals("PlaceLibraryButton")) Then
            CurrentLocationLabel.Text = "Location: Library"
        Else
            CurrentLocationLabel.Text = "Location: School"
        End If

        MainMapsPage.BringToFront()
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class
