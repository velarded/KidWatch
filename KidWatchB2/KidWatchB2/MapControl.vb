Public Class MapControl
    Private Sub PlacesButton_Click(sender As Object, e As EventArgs) Handles PlacesButton.Click
        'TODO: Make a UserControl or Panel to contain a list of saved configured places'
        Console.WriteLine("Display a List of Places here")
        PlacesListPage.BringToFront()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click, Label2.Click
        MainMapsPage.BringToFront()
    End Sub
End Class
