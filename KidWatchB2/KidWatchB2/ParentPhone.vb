Public Class ParentPhone

    Public mainForm As MainForm
    Public Sub New(aMainForm As MainForm)
        InitializeComponent()
        Me.mainForm = aMainForm
    End Sub
    Private Sub KidWatchAppButton_Click(sender As Object, e As EventArgs) Handles KidWatchAppButton.Click

    End Sub

End Class