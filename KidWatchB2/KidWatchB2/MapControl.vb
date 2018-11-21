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
        'Show first direction page'
        DirectionsPanel1.BringToFront()
        Wait(2)
        DirectionsPanel2.BringToFront()
        Wait(2)
        DirectionsPanel3.BringToFront()
        Wait(2)
        CurrentLocationLabel.Text = "Location: Library"
        MainMapsPage.BringToFront()
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class
