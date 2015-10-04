Imports System.Windows.Forms

Public Class avantControlBoite

    Public Function fermerEtControler()
        Me.Close()
        Form1.corrigeSeulement()
    End Function

    Public Function invisibleLesNoteOuvrir()
        'il rend la note OpenOrNew invisible car c'est un nouveau textse qui vient d'être ecrit dans la zone Ouvrir 
        Form1.OpenOrNew.Visible = False
        Form1.pathOuvrir.Visible = False
        Form1.noSaveOuvrir.Visible = False
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'il enregistre d'abord le texte dans un fichier puis il met le corrigé du texte de la zone d'ecriture

        If Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߡߊߦߟߍ߬ߡߊ߲߬" Then

            If Form1.pathOuvrir.Visible = True Then
                If Form1.OpenOrNew.Text = "ߘߊߦߟߍ߬ߣߍ߲" Then
                    Form1.editer2()
                    fermerEtControler()
                ElseIf Form1.OpenOrNew.Text = "ߛߌ߲ߘߌߣߍ߲" Then
                    Form1.editerNewOuvrir()
                    fermerEtControler()
                End If
                invisibleLesNoteOuvrir()

            ElseIf Form1.pathOuvrir.Visible = False Then
                Form1.CréerdsOuvrir()
                fermerEtControler()
                invisibleLesNoteOuvrir()
            End If

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Form1.corrigeSeulement()
        fermerEtControler()
        invisibleLesNoteOuvrir()
    End Sub

    Private Sub beforControlNote_Click(sender As Object, e As EventArgs) Handles beforControlNote.Click

    End Sub
End Class
