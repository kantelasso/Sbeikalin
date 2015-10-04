Imports System.Windows.Forms

Public Class beforeCloseApp
    'Les fonctions de fermeture de AfterApp; Form1 et les 2
    Public Function closeAfterApp()
        Me.Close()
    End Function

    Public Function closeForm1()
        Form1.Close()
    End Function

    Public Function closeAfterForm1()
        Me.Close()
        Form1.Close()
    End Function

    Public Function textbox1_sauve_Note()
        Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬"
    End Function

    Public Function t1_sauve_encore_note()
        Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬ ߌߞߐ߫"
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'il y avait ici : Me.DialogResult = System.Windows.Forms.DialogResult.OK


        'enregistrer le texte de la zone Ecrire

        If Form1.ecrire.Modified Then
            If Form1.noSaveEcrire.Text = "ߊ߬ ߡߊ߫ ߟߊߡߙߊ߬ ߝߟߐ߫" Then
                If Form1.pathEcrire.Visible = False Then
                    If Form1.noSaveOuvrir.Visible = False Then
                        Form1.saveTexbox1()
                        closeAfterForm1()
                        ' ----- à voir !!! ----
                    ElseIf Form1.noSaveOuvrir.Visible = True Then
                        Form1.saveTexbox1()
                        enrT2()
                        closeAfterForm1()
                    End If

                ElseIf Form1.pathEcrire.Visible = True Then
                    Form1.editerTexbox1()
                    closeAfterForm1()

                End If
            ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
                enrT2()
                closeAfterForm1()
            ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬ ߌߞߐ߫" Then
                enrT1()
                closeAfterForm1()
            End If


            'enregistre le texte de la zone Ouvrir
        ElseIf Form1.ouvrir.Modified Then
            If Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߡߊߦߟߍ߬ߡߊ߲߬" Then
                'Il verifie si le texbox1 est modifié encore ou non avec le texbox2

                'si le texbox1 ne l'est pas
                If Form1.pathOuvrir.Visible = True Then
                    If Form1.OpenOrNew.Text = "ߘߊߦߟߍ߬ߣߍ߲" Then
                        Form1.editer2()
                        closeAfterForm1()
                    ElseIf Form1.OpenOrNew.Text = "ߛߌ߲ߘߌߣߍ߲" Then
                        Form1.editerNewOuvrir()
                        closeAfterForm1()
                    End If

                ElseIf Form1.pathOuvrir.Visible = False Then
                    Form1.CréerdsOuvrir()
                    closeAfterForm1()
                End If

                'si le texbox1 l'est
            ElseIf Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
                enrT1()
                closeAfterForm1()
            ElseIf Form1.noSaveOuvrir.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
                enrT1()
                closeAfterForm1()
            End If

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        closeAfterForm1()
    End Sub

    Public Function modifiedAllNot()
        zoneTexte.Text = "ߞߟߏߜߍߘߊ ߝߌ߬ߟߊ ߓߍ߯ ߣߌ߫ ߛߓߍߟߌ߫ ߟߊߡߙߊ߬ߓߊߟߌ ߟߋ߬߸ ߦߴߊ߬ ߝߍ߬ ߞߵߊ߬ߟߎ߬ ߓߍ߯ ߟߊߡߙߊ߬؟"
    End Function

    Public Function Nosave12Note()
        zoneTexte.Text = "ߛߓߍ ߘߏ߫ ߡߊ߫ ߟߊߡߙߊ߬ ߝߟߐ߫߸ ߦߴߊ߬ ߝߍ߬ ߞߵߏ߬ ߟߊߡߙߊ߬؟"
    End Function

    Public Function enrT1()
        If Form1.noSaveEcrire.Text = "ߊ߬ ߡߊ߫ ߟߊߡߙߊ߬ ߝߟߐ߫" Then
            If Form1.pathEcrire.Visible = False Then
                Form1.saveTexbox1()

            ElseIf Form1.pathEcrire.Visible = True Then
                Form1.editerTexbox1()
                closeAfterForm1()
            End If
        ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
            closeAfterForm1()
        ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬ ߌߞߐ߫" Then
            closeAfterForm1()
        End If
    End Function

    'Enregistrer le contenu du textbox2 en fonction des condition du code

    Public Function enrT2()

        If Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߡߊߦߟߍ߬ߡߊ߲߬" Then
            If Form1.pathOuvrir.Visible = True Then
                If Form1.OpenOrNew.Text = "ߘߊߦߟߍ߬ߣߍ߲" Then
                    Form1.editer2()
                    closeAfterForm1()
                ElseIf Form1.OpenOrNew.Text = "ߛߌ߲ߘߌߣߍ߲" Then
                    Form1.editerNewOuvrir()
                    closeAfterForm1()
                End If

            ElseIf Form1.pathOuvrir.Visible = False Then
                Form1.CréerdsOuvrir()
                closeAfterForm1()
            End If

        ElseIf Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
            closeAfterForm1()
        End If

    End Function

    Public Function boiteRappelle()

        If Form1.ecrire.Modified Then
            If Form1.noSaveEcrire.Text = "ߊ߬ ߡߊ߫ ߟߊߡߙߊ߬ ߝߟߐ߫" Then
                If Form1.noSaveOuvrir.Visible = True Then
                    modifiedAllNot()

                ElseIf Form1.noSaveOuvrir.Visible = False Then
                    zoneTexte.Text = "ߌ ߡߴߌ ߟߊ߫ ߛߓߍߟߌ ߟߊߞߎ߲߬ߘߎ߬ ߝߟߐ߫߸ ߦߴߊ߬ ߝߍ߬ ߞߵߊ߬ ߟߊߞߎ߲߬ߘߎ߫ ߓߊ߬؟"
                End If

            ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
                If Form1.noSaveOuvrir.Visible = True Then
                    Nosave12Note()


                ElseIf Form1.noSaveOuvrir.Visible = False Then
                    closeAfterForm1()
                End If

            ElseIf Form1.noSaveEcrire.Text = "ߛߓߍ ߓߘߊ߫ ߟߊߡߙߊ߬ ߌߞߐ߫" Then
                If Form1.noSaveOuvrir.Visible = True Then
                    Nosave12Note()
                    enrT2()

                ElseIf Form1.noSaveOuvrir.Visible = False Then
                    closeAfterForm1()
                End If

            End If
            '------------ 

        ElseIf Form1.ouvrir.Modified Then
            If Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߡߊߦߟߍ߬ߡߊ߲߬" Then
                If Form1.pathOuvrir.Visible = True Then
                    If Form1.OpenOrNew.Text = "ߘߊߦߟߍ߬ߣߍ߲" Then
                        zoneTexte.Text = "ߌ ߓߘߊ߫ ߛߓߍ߫ ߘߊߦߟߍ߬ߣߍ߲ ߡߊߦߟߍ߬ߡߊ߲߬߸ ߦߴߊ߬ ߝߍ߬ ߞߊ߬ ߡߊ߬ߦߟߍ߬ߡߊ߲߬ߠߌ ߕߏ߫ ߊ߬ ߡߊ߬؟"
                    ElseIf Form1.OpenOrNew.Text = "ߛߌ߲ߘߌߣߍ߲" Then
                        zoneTexte.Text = "ߌ ߓߘߊ߫ ߛߓߍ߫ ߛߌ߲ߘߌߣߍ߲ ߡߊߦߟߍ߬ߡߊ߲߬߸ ߦߴߊ߬ ߝߍ߬ ߞߊ߬ ߡߊ߬ߦߟߍ߬ߡߊ߲߬ߠߌ ߕߏ߫ ߊ߬ ߡߊ߬؟"
                    End If
                ElseIf Form1.pathOuvrir.Visible = False Then
                    zoneTexte.Text = "ߌ ߡߊ߫ ߛߓߍ߫ ߛߌ߲ߘߌ߫ ߛߓߍߟߌ ߣߌ߲߬ ߢߍ߫ ߝߟߐ߫߸ ߦߴߊ߬ ߝߍ߬ ߞߵߏ߬ ߞߍ߫ ߓߊ߬؟"
                End If
                '---------------------- à voir --------------
            ElseIf Form1.noSaveOuvrir.Text = "ߊ߬ ߓߘߊ߫ ߟߊߡߙߊ߬" Then

                If Form1.noSaveEcrire.Visible = True Then
                    Nosave12Note()
                    enrT1()
                ElseIf Form1.noSaveEcrire.Visible = False Then
                    closeAfterForm1()
                End If


            ElseIf Form1.noSaveEcrire.Visible = True Then
                modifiedAllNot()

            Else
                closeAfterForm1()

            End If

        ElseIf Form1.noSaveOuvrir.Visible = False Then
            closeAfterForm1()

        End If

    End Function

    Private Sub afterCloseApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boiteRappelle()

    End Sub

    Private Sub cancelButon_Click(sender As Object, e As EventArgs) Handles cancelButon.Click
        closeAfterApp()
    End Sub
End Class
