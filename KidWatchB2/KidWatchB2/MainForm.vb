Public Class MainForm
    Private Sub OpenKidWatchButton_Click(sender As Object, e As EventArgs) Handles OpenKidWatchButton.Click
        Dim kidWatch As New KidWatch
        kidWatch.Show()
    End Sub

    Private Sub OpenParentPhoneButton_Click(sender As Object, e As EventArgs) Handles OpenParentPhoneButton.Click
        Dim parentPhone As New ParentPhone
        parentPhone.Show()
    End Sub
End Class