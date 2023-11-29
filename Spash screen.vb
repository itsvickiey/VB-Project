Public Class Spash_screen

    Private Sub Spash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled() = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If (ProgressBar1.Value = 100) Then
            Me.Hide()
            LOGIN.Show()
            Timer1.Enabled = False
            Timer1.Stop()
        End If

    End Sub

End Class