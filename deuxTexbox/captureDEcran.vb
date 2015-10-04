Public Class captureDEcran

    Public Function capturerLEcran()
        Dim largeur As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim hauteur As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim djasson As New Bitmap(largeur, hauteur)
        Dim grapEcran As Graphics = Graphics.FromImage(djasson)
        grapEcran.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)

        PictureBox1.Visible = True
        PictureBox1.Image = djasson
    End Function

    Public Function capteWindow()
        Dim loh As Integer
        Dim kanka As Integer

        Dim djas As New Bitmap(loh, kanka)
        Dim graphEc As Graphics = Graphics.FromImage(djas)



    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        capturerLEcran()
    End Sub

    Private Sub CapturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturerToolStripMenuItem.Click
        capturerLEcran()
    End Sub

    Private Sub HidecapturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HidecapturerToolStripMenuItem.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        capturerLEcran()
        Me.Opacity = 1
        Me.ShowInTaskbar = True
        Timer1.Stop()

    End Sub

    Public Function savImage()
        Dim ImageSaver As New SaveFileDialog
        ImageSaver.Filter = "ߖߌ߬ߦߊ߬ ߜߍ |*.png| ߖߌ߬ߦߊ߬ ߓߘߍ |*.jpg"
        ImageSaver.FileName = ""
        ImageSaver.Title = "ߟߊ߬ߡߙߊ߬ߟߌ߬ ߘߊ"

        If ImageSaver.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(ImageSaver.FileName)
        End If
        notesaving.Text = "ߖߌ߬ߦߊ ߓߘߊ߫ ߟߊߡߙߊ߬"
        notesaving.Visible = True
        notesaving.ForeColor = Color.DarkGreen

    End Function

    Private Sub SaveImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveImageToolStripMenuItem.Click
        savImage()
    End Sub

    'Fermer capture d'ecran
    Public Function closeCapture()
        If PictureBox1.Visible = True Then
            If notesaving.Text = "ߖߌ߬ߦߊ ߓߘߊ߫ ߟߊߡߙߊ߬" Then
                Me.Close()
            ElseIf notesaving.Visible = False Then
                rappelCapture.Show()
            End If

        Else
            Me.Close()
        End If

    End Function

    Private Sub ExiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExiteToolStripMenuItem.Click
        closeCapture()
    End Sub

    Private Sub closeButon_Click(sender As Object, e As EventArgs) Handles closeButon.Click
        closeCapture()
    End Sub

    Private Sub captureDEcran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class