Public Class MainForm
    Public kidWatch As KidWatch = New KidWatch(Me)
    Public parentPhone As ParentPhone = New ParentPhone(Me)

    Private Sub OpenKidWatchButton_Click(sender As Object, e As EventArgs) Handles OpenKidWatchButton.Click
        kidWatch.Show()
    End Sub

    Private Sub OpenParentPhoneButton_Click(sender As Object, e As EventArgs) Handles OpenParentPhoneButton.Click
        parentPhone.Show()
    End Sub

End Class