Public Class SplashScreenForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()

    End Sub

    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Show()

    End Sub


End Class