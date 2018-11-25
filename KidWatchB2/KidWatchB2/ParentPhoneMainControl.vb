Public Class ParentPhoneMainControl

    Private WithEvents callStopwatch As Stopwatch = New Stopwatch()

    ' CALLED BY KID WATCH
    Public Sub ConnectParentCall()
        StatusLabel.Text = "Connected"
        TimeLabel.Visible = True
        Me.Timer1.Start()
        callStopwatch.Reset()
        callStopwatch.Start()
        ReceiveCallControlsPanel.Visible = False
    End Sub

    Public Sub ReceiveParentCall()
        CallingPanel.BackColor = Color.PaleTurquoise
        StatusLabel.Text = "James"
        CallingPanel.Visible = True
        TimeLabel.Visible = False
        CallingPanel.BringToFront()

        ReceiveCallControlsPanel.Visible = True
        ReceiveCallControlsPanel.BringToFront()
    End Sub

    ' CALLED BY KID WATCH OR END CALL BUTTON
    Public Sub EndParentCall(sender As Object)
        Me.Timer1.Stop()
        callStopwatch.Stop()
        StatusLabel.Text = "Call Ended"
        CallingPanel.BackColor = Color.DimGray
        Dim parentPhone As ParentPhone = Me.Parent

        If sender.Name.Equals(Me.Name) Then
            parentPhone.mainForm.kidWatch.PhoneCallScreen.EndCallKidWatch(Me)
        Else
            Wait(2)
        End If

        CallingPanel.Visible = False
        CallingPanel.SendToBack()
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        ReceiveCallControlsPanel.Visible = False
        StatusLabel.Text = "Calling..."
        CallingPanel.BackColor = Color.PaleTurquoise
        callStopwatch.Reset()
        TimeLabel.Visible = False
        CallingPanel.Visible = True
        CallingPanel.BringToFront()

        Dim parentPhone As ParentPhone = Me.ParentForm
        parentPhone.mainForm.kidWatch.PhoneCallScreen.CallKidWatch()
    End Sub

    Private Sub StopCallButton_Click(sender As Object, e As EventArgs) Handles StopCallButton.Click
        EndParentCall(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If StatusLabel.Text = "Connected" Then
            TimeLabel.Text = String.Format("{0:00}:{1:00}",
                 callStopwatch.Elapsed.Minutes, callStopwatch.Elapsed.Seconds)
        End If
    End Sub

    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub PickUpButton_Click(sender As Object, e As EventArgs) Handles PickUpButton.Click
        Dim phone As ParentPhone = Me.Parent
        phone.mainForm.kidWatch.PhoneCallScreen.ConnectCallKidWatch()
        ReceiveCallControlsPanel.Visible = False
        TimeLabel.Visible = True
        ConnectParentCall()


    End Sub

    Private Sub StopCallButton2_Click(sender As Object, e As EventArgs) Handles StopCallButton2.Click
        EndParentCall(Me)
    End Sub

    Private Sub LocationButton_Click(sender As Object, e As EventArgs) Handles LocationButton.Click
        Dim phone As ParentPhone = Me.Parent
        Dim currentChildLocation As String = phone.mainForm.kidWatch.MapControl1.CurrentLocationLabel.Text
        phone.ParentGPSMainControl1.CurrentChildLocationLabel.Text = "James' " + currentChildLocation

        phone.ParentGPSMainControl1.BringToFront()
    End Sub
End Class
