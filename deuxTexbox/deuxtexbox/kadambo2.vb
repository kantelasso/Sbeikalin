Public Class kadambo2

    Private Sub kadambo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Kadambo.Show()
        Me.Close()


    End Sub

    Private Sub canceler_Click(sender As Object, e As EventArgs) Handles canceler.Click
        Me.Close()
    End Sub
End Class