Imports System.Net

Public Class Londohyali

    Dim senahBoko As String = "߁.߀"
    Dim MAJ As New WebClient
    Dim kohlaBohko As String = MAJ.DownloadString("https://www.dropbox.com/s/crbeszpxhakz0sw/newVersion.txt?dl=0")

    Public Function chekUpdates()

        If senahBoko = kohlaBohko Then
            bokoNote.Text = "ߛߓߍߞߊߟߌ߲ ߟߏ߲ߘߐߦߊߣߍ߲߫ ߞߊ߬ߓߊ߲߫߹"
            ' metAJourButon.Visible = False
            ' AjourBonBouton.Visible = False
        Else
            bokoNote.Text = "ߛߓߍߞߊߟߌ߲ ߓߐߞߏ߫ ߞߎߘߊ:"
            versionNumber.Text = "߁.߀"
            ' metAJourButon.Visible = True
            ' AjourBonBouton.Visible = True
        End If

    End Function

    Private Sub metAJourButon_Click(sender As Object, e As EventArgs) Handles metAJourButon.Click
        'Process.Start()

    End Sub

    Private Sub Londohyali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chekUpdates()
    End Sub

    Private Sub AjourBonBouton_Click(sender As Object, e As EventArgs) Handles AjourBonBouton.Click
        Me.Close()
    End Sub
End Class