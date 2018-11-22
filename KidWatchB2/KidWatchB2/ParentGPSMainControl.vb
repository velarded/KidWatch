Public Class ParentGPSMainControl
    Private Sub CloseLocationAppButton_Click(sender As Object, e As EventArgs) Handles CloseLocationAppButton.Click
        Dim phone As ParentPhone = Me.Parent
        phone.ParentPhoneMainControl1.BringToFront()
    End Sub
End Class
