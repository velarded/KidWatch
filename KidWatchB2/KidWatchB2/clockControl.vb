Public Class clockControl

    Public Sub New()
        InitializeComponent()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DigitalTimeLabel.Text = Date.Now.ToString("hh:mm:ss tt")

    End Sub
End Class
