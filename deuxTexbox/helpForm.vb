Public Class helpForm

    Private Sub fassoSite_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub fassoLien_Click(sender As Object, e As EventArgs) Handles fassoLien.Click
        Process.Start("Http://fasso.org")
        Me.TopMost = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub guideUtilisation_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Kadambo.Show()
        Me.Close()

    End Sub

    Private Sub kadanNadjiNote_Click(sender As Object, e As EventArgs) Handles kadanNadjiNote.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        kadambo2.Show()
        Me.Close()
    End Sub
End Class