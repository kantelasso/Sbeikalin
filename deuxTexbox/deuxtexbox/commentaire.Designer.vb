<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commentaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(commentaire))
        Me.messageSend = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTexteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTexteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommentSbeikalin = New System.Windows.Forms.Label()
        Me.exitApropos = New System.Windows.Forms.Button()
        Me.gbankrou = New System.Windows.Forms.GroupBox()
        Me.notConnet = New System.Windows.Forms.CheckBox()
        Me.emeteurPassword = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.emeteur = New System.Windows.Forms.TextBox()
        Me.connexionButton = New System.Windows.Forms.Button()
        Me.notConnetNote = New System.Windows.Forms.Label()
        Me.noteConnexion = New System.Windows.Forms.Label()
        Me.taminkan = New System.Windows.Forms.Label()
        Me.lataala = New System.Windows.Forms.Label()
        Me.sendingComment = New System.Windows.Forms.GroupBox()
        Me.fohma = New System.Windows.Forms.Label()
        Me.subjetBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sambatooBox = New System.Windows.Forms.TextBox()
        Me.sambatoo = New System.Windows.Forms.Label()
        Me.noteSending = New System.Windows.Forms.Label()
        Me.send = New System.Windows.Forms.Button()
        Me.sendProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TimerProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbankrou.SuspendLayout()
        Me.sendingComment.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'messageSend
        '
        Me.messageSend.AllowDrop = True
        Me.messageSend.ContextMenuStrip = Me.ContextMenuStrip1
        Me.messageSend.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageSend.Location = New System.Drawing.Point(12, 200)
        Me.messageSend.Multiline = True
        Me.messageSend.Name = "messageSend"
        Me.messageSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.messageSend.Size = New System.Drawing.Size(518, 352)
        Me.messageSend.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.CopyTexteToolStripMenuItem, Me.PasteTexteToolStripMenuItem, Me.CutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 92)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SelectAllToolStripMenuItem.Text = "ߊ߬ ߓߍ߯ ߓߊߕߐߡߐ߲߫"
        '
        'CopyTexteToolStripMenuItem
        '
        Me.CopyTexteToolStripMenuItem.Name = "CopyTexteToolStripMenuItem"
        Me.CopyTexteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CopyTexteToolStripMenuItem.Text = "ߊ߬ ߓߊߓߌߟߊ߫"
        '
        'PasteTexteToolStripMenuItem
        '
        Me.PasteTexteToolStripMenuItem.Name = "PasteTexteToolStripMenuItem"
        Me.PasteTexteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PasteTexteToolStripMenuItem.Text = "ߊ߬ ߣߙߊ߫"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CutToolStripMenuItem.Text = "ߊ߬ ߕߍ߰"
        '
        'CommentSbeikalin
        '
        Me.CommentSbeikalin.AutoSize = True
        Me.CommentSbeikalin.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentSbeikalin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CommentSbeikalin.Location = New System.Drawing.Point(229, 7)
        Me.CommentSbeikalin.Name = "CommentSbeikalin"
        Me.CommentSbeikalin.Size = New System.Drawing.Size(84, 25)
        Me.CommentSbeikalin.TabIndex = 5
        Me.CommentSbeikalin.Text = "ߞߊ߲߬ߞߎ߬ߡߊ߬ߘߊ"
        '
        'exitApropos
        '
        Me.exitApropos.BackColor = System.Drawing.Color.Brown
        Me.exitApropos.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitApropos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.exitApropos.Location = New System.Drawing.Point(-1, -1)
        Me.exitApropos.Name = "exitApropos"
        Me.exitApropos.Size = New System.Drawing.Size(43, 33)
        Me.exitApropos.TabIndex = 0
        Me.exitApropos.TabStop = False
        Me.exitApropos.Text = "x"
        Me.exitApropos.UseVisualStyleBackColor = False
        '
        'gbankrou
        '
        Me.gbankrou.Controls.Add(Me.notConnet)
        Me.gbankrou.Controls.Add(Me.emeteurPassword)
        Me.gbankrou.Controls.Add(Me.emeteur)
        Me.gbankrou.Controls.Add(Me.connexionButton)
        Me.gbankrou.Controls.Add(Me.notConnetNote)
        Me.gbankrou.Controls.Add(Me.noteConnexion)
        Me.gbankrou.Controls.Add(Me.taminkan)
        Me.gbankrou.Controls.Add(Me.lataala)
        Me.gbankrou.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbankrou.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbankrou.Location = New System.Drawing.Point(12, 28)
        Me.gbankrou.Name = "gbankrou"
        Me.gbankrou.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbankrou.Size = New System.Drawing.Size(518, 113)
        Me.gbankrou.TabIndex = 0
        Me.gbankrou.TabStop = False
        Me.gbankrou.Text = "ߜߊ߲߬ߞߎ߲߬ߢߊ"
        '
        'notConnet
        '
        Me.notConnet.AutoSize = True
        Me.notConnet.Location = New System.Drawing.Point(364, 86)
        Me.notConnet.Name = "notConnet"
        Me.notConnet.Size = New System.Drawing.Size(123, 24)
        Me.notConnet.TabIndex = 13
        Me.notConnet.TabStop = False
        Me.notConnet.Text = "ߒ ߕߍ߫ ߒ ߜߊ߲߬ߞߎ߲߬ ߠߊ߫"
        Me.notConnet.UseVisualStyleBackColor = True
        '
        'emeteurPassword
        '
        Me.emeteurPassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.emeteurPassword.ContextMenuStrip = Me.ContextMenuStrip3
        Me.emeteurPassword.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emeteurPassword.Location = New System.Drawing.Point(172, 56)
        Me.emeteurPassword.Name = "emeteurPassword"
        Me.emeteurPassword.Size = New System.Drawing.Size(260, 29)
        Me.emeteurPassword.TabIndex = 1
        Me.emeteurPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.emeteurPassword.UseSystemPasswordChar = True
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'emeteur
        '
        Me.emeteur.BackColor = System.Drawing.SystemColors.ControlLight
        Me.emeteur.ContextMenuStrip = Me.ContextMenuStrip3
        Me.emeteur.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emeteur.Location = New System.Drawing.Point(172, 22)
        Me.emeteur.Name = "emeteur"
        Me.emeteur.Size = New System.Drawing.Size(260, 29)
        Me.emeteur.TabIndex = 0
        Me.emeteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'connexionButton
        '
        Me.connexionButton.AutoSize = True
        Me.connexionButton.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connexionButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.connexionButton.Location = New System.Drawing.Point(4, 14)
        Me.connexionButton.Name = "connexionButton"
        Me.connexionButton.Size = New System.Drawing.Size(98, 31)
        Me.connexionButton.TabIndex = 2
        Me.connexionButton.Text = "ߜߊ߲߬ߞߎ߲߬ߠߌ"
        Me.connexionButton.UseVisualStyleBackColor = True
        '
        'notConnetNote
        '
        Me.notConnetNote.AutoSize = True
        Me.notConnetNote.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notConnetNote.ForeColor = System.Drawing.SystemColors.ControlText
        Me.notConnetNote.Location = New System.Drawing.Point(20, 89)
        Me.notConnetNote.Name = "notConnetNote"
        Me.notConnetNote.Size = New System.Drawing.Size(105, 19)
        Me.notConnetNote.TabIndex = 12
        Me.notConnetNote.Text = "notConnetNote"
        Me.notConnetNote.Visible = False
        '
        'noteConnexion
        '
        Me.noteConnexion.AutoSize = True
        Me.noteConnexion.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteConnexion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.noteConnexion.Location = New System.Drawing.Point(20, 54)
        Me.noteConnexion.Name = "noteConnexion"
        Me.noteConnexion.Size = New System.Drawing.Size(102, 19)
        Me.noteConnexion.TabIndex = 12
        Me.noteConnexion.Text = "noteConnexion"
        Me.noteConnexion.Visible = False
        '
        'taminkan
        '
        Me.taminkan.AutoSize = True
        Me.taminkan.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taminkan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.taminkan.Location = New System.Drawing.Point(436, 60)
        Me.taminkan.Name = "taminkan"
        Me.taminkan.Size = New System.Drawing.Size(51, 21)
        Me.taminkan.TabIndex = 11
        Me.taminkan.Text = "ߕߊ߬ߡߌ߲߬ߞߊ߲"
        '
        'lataala
        '
        Me.lataala.AutoSize = True
        Me.lataala.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lataala.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lataala.Location = New System.Drawing.Point(435, 26)
        Me.lataala.Name = "lataala"
        Me.lataala.Size = New System.Drawing.Size(56, 21)
        Me.lataala.TabIndex = 11
        Me.lataala.Text = "ߛߊ߲߬ߓߊ߬ߕߐ߮"
        '
        'sendingComment
        '
        Me.sendingComment.Controls.Add(Me.fohma)
        Me.sendingComment.Controls.Add(Me.subjetBox)
        Me.sendingComment.Controls.Add(Me.sambatooBox)
        Me.sendingComment.Controls.Add(Me.sambatoo)
        Me.sendingComment.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendingComment.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.sendingComment.Location = New System.Drawing.Point(12, 145)
        Me.sendingComment.Name = "sendingComment"
        Me.sendingComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sendingComment.Size = New System.Drawing.Size(518, 50)
        Me.sendingComment.TabIndex = 3
        Me.sendingComment.TabStop = False
        Me.sendingComment.Text = "ߟߊ߬ߕߊ߰ߟߌ"
        '
        'fohma
        '
        Me.fohma.AutoSize = True
        Me.fohma.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fohma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fohma.Location = New System.Drawing.Point(464, 19)
        Me.fohma.Name = "fohma"
        Me.fohma.Size = New System.Drawing.Size(46, 21)
        Me.fohma.TabIndex = 14
        Me.fohma.Text = "ߝߐߡߊ"
        '
        'subjetBox
        '
        Me.subjetBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.subjetBox.ContextMenuStrip = Me.ContextMenuStrip2
        Me.subjetBox.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjetBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.subjetBox.Location = New System.Drawing.Point(280, 15)
        Me.subjetBox.Name = "subjetBox"
        Me.subjetBox.Size = New System.Drawing.Size(178, 29)
        Me.subjetBox.TabIndex = 3
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(109, 70)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CopyToolStripMenuItem.Text = "ߊ߬ ߓߊߓߌߟߊ߫"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PasteToolStripMenuItem.Text = "ߊ߬ ߣߙߊ߫"
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.CutToolStripMenuItem1.Text = "ߊ߬ ߕߍ߰"
        '
        'sambatooBox
        '
        Me.sambatooBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.sambatooBox.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sambatooBox.Location = New System.Drawing.Point(6, 15)
        Me.sambatooBox.Name = "sambatooBox"
        Me.sambatooBox.Size = New System.Drawing.Size(210, 29)
        Me.sambatooBox.TabIndex = 0
        Me.sambatooBox.TabStop = False
        Me.sambatooBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.sambatooBox.Visible = False
        '
        'sambatoo
        '
        Me.sambatoo.AutoSize = True
        Me.sambatoo.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sambatoo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sambatoo.Location = New System.Drawing.Point(217, 19)
        Me.sambatoo.Name = "sambatoo"
        Me.sambatoo.Size = New System.Drawing.Size(56, 21)
        Me.sambatoo.TabIndex = 11
        Me.sambatoo.Text = "ߛߊ߲߬ߓߊ߬ߕߐ߮"
        Me.sambatoo.Visible = False
        '
        'noteSending
        '
        Me.noteSending.AutoSize = True
        Me.noteSending.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteSending.ForeColor = System.Drawing.SystemColors.ControlText
        Me.noteSending.Location = New System.Drawing.Point(77, 561)
        Me.noteSending.Name = "noteSending"
        Me.noteSending.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.noteSending.Size = New System.Drawing.Size(86, 19)
        Me.noteSending.TabIndex = 15
        Me.noteSending.Text = "noteSending"
        Me.noteSending.Visible = False
        '
        'send
        '
        Me.send.AutoSize = True
        Me.send.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send.ForeColor = System.Drawing.SystemColors.ControlText
        Me.send.Location = New System.Drawing.Point(245, 555)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(57, 31)
        Me.send.TabIndex = 5
        Me.send.Text = "ߊ߬ ߟߊߕߊ߯"
        Me.send.UseVisualStyleBackColor = True
        '
        'sendProgressBar
        '
        Me.sendProgressBar.Location = New System.Drawing.Point(12, 559)
        Me.sendProgressBar.Name = "sendProgressBar"
        Me.sendProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sendProgressBar.RightToLeftLayout = True
        Me.sendProgressBar.Size = New System.Drawing.Size(216, 23)
        Me.sendProgressBar.TabIndex = 16
        Me.sendProgressBar.Visible = False
        '
        'TimerProgressBar
        '
        '
        'commentaire
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(546, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.noteSending)
        Me.Controls.Add(Me.exitApropos)
        Me.Controls.Add(Me.CommentSbeikalin)
        Me.Controls.Add(Me.messageSend)
        Me.Controls.Add(Me.gbankrou)
        Me.Controls.Add(Me.sendingComment)
        Me.Controls.Add(Me.send)
        Me.Controls.Add(Me.sendProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 590)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(546, 590)
        Me.Name = "commentaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "apropos"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbankrou.ResumeLayout(False)
        Me.gbankrou.PerformLayout()
        Me.sendingComment.ResumeLayout(False)
        Me.sendingComment.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents messageSend As System.Windows.Forms.TextBox
    Friend WithEvents CommentSbeikalin As System.Windows.Forms.Label
    Friend WithEvents exitApropos As System.Windows.Forms.Button
    Friend WithEvents gbankrou As System.Windows.Forms.GroupBox
    Friend WithEvents sendingComment As System.Windows.Forms.GroupBox
    Friend WithEvents send As System.Windows.Forms.Button
    Friend WithEvents connexionButton As System.Windows.Forms.Button
    Friend WithEvents noteConnexion As System.Windows.Forms.Label
    Friend WithEvents taminkan As System.Windows.Forms.Label
    Friend WithEvents lataala As System.Windows.Forms.Label
    Friend WithEvents noteSending As System.Windows.Forms.Label
    Friend WithEvents fohma As System.Windows.Forms.Label
    Friend WithEvents subjetBox As System.Windows.Forms.TextBox
    Friend WithEvents emeteurPassword As System.Windows.Forms.TextBox
    Friend WithEvents emeteur As System.Windows.Forms.TextBox
    Friend WithEvents notConnetNote As System.Windows.Forms.Label
    Friend WithEvents notConnet As System.Windows.Forms.CheckBox
    Friend WithEvents sambatooBox As System.Windows.Forms.TextBox
    Friend WithEvents sambatoo As System.Windows.Forms.Label
    Friend WithEvents sendProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TimerProgressBar As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTexteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteTexteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
End Class
