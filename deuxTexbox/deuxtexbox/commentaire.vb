Imports System.Net.Mail

Public Class commentaire

    Private Sub exitApropos_Click(sender As Object, e As EventArgs) Handles exitApropos.Click
        Me.Close()
        Form1.WindowState = FormWindowState.Normal
    End Sub

    Public Function noteConBon()
        noteConnexion.ForeColor = Color.DarkGreen
        noteConnexion.Visible = True
    End Function

    Public Function noteConBad()
        noteConnexion.ForeColor = Color.DarkRed
        noteConnexion.Visible = True
        emeteur.Clear()
        emeteurPassword.Clear()
    End Function

    Public Function connecterdejas()
        gbankrou.Enabled = False
        noteSending.Enabled = True
        send.Enabled = True
        noteConnexion.Text = "ߌ ߓߘߊ߫ ߜߊ߲߬ߞߎ߲߬"
        noteConBon()
    End Function

    Private Sub connexionApropos_Click(sender As Object, e As EventArgs) Handles connexionButton.Click

        If emeteur.Text.EndsWith("@gmail.com") Then
            connecterdejas()
        ElseIf emeteur.Text.EndsWith("@yahoo.fr") Then
            connecterdejas()
        ElseIf emeteur.Text.EndsWith("@yahoo.com") Then
            connecterdejas()
        ElseIf emeteur.Text.EndsWith("@hotmail.fr") Then
            connecterdejas()
        ElseIf emeteur.Text.EndsWith("@outlook.fr") Then
            connecterdejas()
        ElseIf emeteur.Text.EndsWith("@outlook.com") Then
            connecterdejas()
        Else
            noteConnexion.Text = "ߌ ߡߊ߫ ߜߊ߲߬ߞߎ߲߬ ߝߟߐ߫"
            noteConBad()
            emeteur.Focus()
            notConnetNote.Text = "ߞߏ߲߬ߘߏ߬ߒߕߊ߲"
        End If

    End Sub
    ' Le serveur SMTP de GMAIL
    Public Function gmailSender()
        Dim kankoumaGmail As New MailMessage
        Dim SMTPgmail As New SmtpClient("smtp.gmail.com")

        kankoumaGmail.From = New MailAddress(emeteur.Text)
        kankoumaGmail.To.Add("kantemou@gmail.com")
        kankoumaGmail.Subject = subjetBox.Text
        kankoumaGmail.Body = messageSend.Text

        SMTPgmail.Port = "587"
        SMTPgmail.Credentials = New System.Net.NetworkCredential(emeteur.Text, emeteurPassword.Text)
        SMTPgmail.EnableSsl = True

        SMTPgmail.Send(kankoumaGmail)

    End Function

    ' Le serveur SMTP de YAHOO
    Public Function yahooSender()
        Dim kankoumaYahoo As New MailMessage
        Dim SMTPyahoo As New SmtpClient("smtp.mail.yahoo.fr")

        kankoumaYahoo.From = New MailAddress(emeteur.Text)
        kankoumaYahoo.To.Add("kantemou@gmail.com")
        kankoumaYahoo.Subject = subjetBox.Text
        kankoumaYahoo.Body = messageSend.Text

        SMTPyahoo.Port = "465"
        SMTPyahoo.Credentials = New System.Net.NetworkCredential(emeteur.Text, emeteurPassword.Text)
        SMTPyahoo.EnableSsl = True

        SMTPyahoo.Send(kankoumaYahoo)
    End Function
    ' Le serveur SMTP de HOTMAIL
    Public Function hotmailSender()
        Dim kankoumaHotmail As New MailMessage
        Dim SMTPhotmail As New SmtpClient("smtp.live.com")

        kankoumaHotmail.From = New MailAddress(emeteur.Text)
        kankoumaHotmail.To.Add("kantemou@gmail.com")
        kankoumaHotmail.Subject = subjetBox.Text
        kankoumaHotmail.Body = messageSend.Text

        SMTPhotmail.Port = "25"
        SMTPhotmail.Credentials = New System.Net.NetworkCredential(emeteur.Text, emeteurPassword.Text)
        SMTPhotmail.EnableSsl = True

        SMTPhotmail.Send(kankoumaHotmail)
    End Function

    Public Function noComteSender()
        Dim kankoumaGmail As New MailMessage
        Dim SMTPgmail As New SmtpClient("smtp.gmail.com")

        Dim defaultCompte As String
        Dim defaultPassword As String

        defaultCompte = "sbeikalinfassoden@gmail.com"
        defaultPassword = "FassoKadii100%"


        kankoumaGmail.From = New MailAddress(defaultCompte)
        kankoumaGmail.To.Add("kantemou@gmail.com")
        kankoumaGmail.Subject = subjetBox.Text

        kankoumaGmail.Body = messageSend.Text & vbNewLine & "ߞߊ߬ ߝߙߊ߫ " & emeteur.Text & " " & emeteurPassword.Text & " ߟߊ߫߸ " & "ߒ ߛߊ߲߬ߓߊ߬ߕߐ߮ ߦߋ߫" & sambatoo.Text & "ߟߋ߬ ߘߌ߫."

        SMTPgmail.Port = "587"
        SMTPgmail.Credentials = New System.Net.NetworkCredential(defaultCompte, defaultPassword)
        SMTPgmail.EnableSsl = True

        'la progressebar lors de l'envoi du message

        SMTPgmail.Send(kankoumaGmail)
    End Function

    Public Function progress()
        TimerProgressBar.Start()
        
    End Function

    Private Sub TimerProgressBar_Tick(sender As Object, e As EventArgs) Handles TimerProgressBar.Tick
        sendProgressBar.Increment(10)
        sendProgressBar.Visible = True
        If sendProgressBar.Value = 100 Then
            sendProgressBar.Visible = False
            noteSending.Text = "ߞߋߛߓߍ ߓߘߊ߫ ߟߊߕߊ߯ ߞߏ߫ ߢߊ߬߹"
            noteSending.Visible = True
            TimerProgressBar.Stop()
        End If

    End Sub

    Private Sub send_Click(sender As Object, e As EventArgs) Handles send.Click

        progress()

        If emeteur.Text.EndsWith("@gmail.com") Then
            gmailSender()

        ElseIf emeteur.Text.EndsWith("@yahoo.fr") Then
            yahooSender()

        ElseIf emeteur.Text.EndsWith("@yahoo.com") Then
            yahooSender()

        ElseIf emeteur.Text.EndsWith("@hotmail.fr") Then
            hotmailSender()

        ElseIf emeteur.Text.EndsWith("@outlook.fr") Then
            hotmailSender()

        ElseIf emeteur.Text.EndsWith("@outlook.com") Then
            hotmailSender()

        ElseIf notConnet.Checked = True Then
            noComteSender()

        End If

    End Sub

    Private Sub notConnet_CheckedChanged(sender As Object, e As EventArgs) Handles notConnet.CheckedChanged
        If notConnet.Checked = True Then
            lataala.Text = "ߌ ߕߐ߮"
            taminkan.Text = "ߌ ߛߌ"
            notConnet.ForeColor = Color.DarkViolet
            notConnetNote.Text = "ߞߊ߲߬ߞߎߡߊ ߟߊߕߊ߯ߕߐ߫ ߌ ߕߐ߮ ߣߴߌ ߛߌ ߟߋ߬ ߘߌ߫"
            notConnetNote.Visible = True
            emeteurPassword.UseSystemPasswordChar = False
            connexionButton.Visible = False
            sambatooBox.Visible = True
            sambatoo.Visible = True

        ElseIf notConnet.Checked = False Then

            lataala.Text = "ߛߊ߲߬ߓߊ߬ߕߐ߮"
            taminkan.Text = "ߕߊ߬ߡߌ߲߬ߞߊ߲"
            emeteurPassword.UseSystemPasswordChar = True
            notConnet.ForeColor = Color.Gray
            notConnetNote.Visible = False
            connexionButton.Visible = True
            sambatooBox.Visible = False
            sambatoo.Visible = False

        End If
       
    End Sub

    Public Function medText()


    End Function

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        messageSend.SelectAll()
    End Sub

    Private Sub CopyTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTexteToolStripMenuItem.Click
        messageSend.Copy()
    End Sub

    Private Sub PasteTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteTexteToolStripMenuItem.Click
            messageSend.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
            messageSend.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        subjetBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        subjetBox.Paste()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        subjetBox.Cut()
    End Sub

    Private Sub commentaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class