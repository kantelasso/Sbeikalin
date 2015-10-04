<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ecrireButon = New System.Windows.Forms.Button()
        Me.ouvrir = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SlectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cut2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ecrire = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveButon = New System.Windows.Forms.Button()
        Me.ouvrirButon = New System.Windows.Forms.Button()
        Me.SFileDEcrire = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpBouton = New System.Windows.Forms.Button()
        Me.control = New System.Windows.Forms.Button()
        Me.noSaveEcrire = New System.Windows.Forms.Label()
        Me.noSaveOuvrir = New System.Windows.Forms.Label()
        Me.noControled = New System.Windows.Forms.Label()
        Me.pathEcrire = New System.Windows.Forms.Label()
        Me.pathOuvrir = New System.Windows.Forms.Label()
        Me.notifTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SbekalinTooToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAgainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimS = New System.Windows.Forms.Button()
        Me.endS = New System.Windows.Forms.Button()
        Me.IconeMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saveAgainButon = New System.Windows.Forms.Button()
        Me.methodeNotOuvrir = New System.Windows.Forms.Label()
        Me.methodeNotEcrire = New System.Windows.Forms.Label()
        Me.SFileDOuvrir = New System.Windows.Forms.SaveFileDialog()
        Me.OpenOrNew = New System.Windows.Forms.Label()
        Me.NoMasqueOpen = New System.Windows.Forms.Timer(Me.components)
        Me.FassoIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideBoutonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AproposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaptureEcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.IconeMenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ecrireButon
        '
        Me.ecrireButon.AutoSize = True
        Me.ecrireButon.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ecrireButon.Location = New System.Drawing.Point(10, 687)
        Me.ecrireButon.Name = "ecrireButon"
        Me.ecrireButon.Size = New System.Drawing.Size(146, 30)
        Me.ecrireButon.TabIndex = 1
        Me.ecrireButon.Text = "ߛߌ߲ߘߟߌ"
        Me.ecrireButon.UseVisualStyleBackColor = True
        '
        'ouvrir
        '
        Me.ouvrir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ouvrir.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ouvrir.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ouvrir.Location = New System.Drawing.Point(570, 42)
        Me.ouvrir.Multiline = True
        Me.ouvrir.Name = "ouvrir"
        Me.ouvrir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ouvrir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ouvrir.Size = New System.Drawing.Size(550, 644)
        Me.ouvrir.TabIndex = 4
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlectToolStripMenuItem, Me.Copy2ToolStripMenuItem, Me.Cut2ToolStripMenuItem, Me.Paste2ToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(134, 92)
        '
        'SlectToolStripMenuItem
        '
        Me.SlectToolStripMenuItem.Name = "SlectToolStripMenuItem"
        Me.SlectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SlectToolStripMenuItem.Text = "ߊ߬ ߓߍ߯ ߓߊߕߐߡߐ߲߫"
        '
        'Copy2ToolStripMenuItem
        '
        Me.Copy2ToolStripMenuItem.Name = "Copy2ToolStripMenuItem"
        Me.Copy2ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.Copy2ToolStripMenuItem.Text = "ߊ߬ ߓߊߓߌߟߊ߫"
        '
        'Cut2ToolStripMenuItem
        '
        Me.Cut2ToolStripMenuItem.Name = "Cut2ToolStripMenuItem"
        Me.Cut2ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.Cut2ToolStripMenuItem.Text = "ߊ߬ ߕߍ߰"
        '
        'Paste2ToolStripMenuItem
        '
        Me.Paste2ToolStripMenuItem.Name = "Paste2ToolStripMenuItem"
        Me.Paste2ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.Paste2ToolStripMenuItem.Text = "ߊ߬ ߣߙߊ߫"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(563, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 670)
        Me.Label1.TabIndex = 2
        '
        'ecrire
        '
        Me.ecrire.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ecrire.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ecrire.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ecrire.Location = New System.Drawing.Point(7, 42)
        Me.ecrire.Multiline = True
        Me.ecrire.Name = "ecrire"
        Me.ecrire.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ecrire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ecrire.Size = New System.Drawing.Size(550, 644)
        Me.ecrire.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.AllowMerge = False
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 92)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SelectToolStripMenuItem.MergeIndex = 0
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.SelectToolStripMenuItem.ShowShortcutKeys = False
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SelectToolStripMenuItem.Text = "ߊ߬ ߓߍ߯ ߓߊߕߐߡߐ߲߫"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CopyToolStripMenuItem.MergeIndex = 1
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.ShowShortcutKeys = False
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CopyToolStripMenuItem.Text = "ߊ߬ ߓߊߓߌߟߊ߫"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.ShowShortcutKeys = False
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CutToolStripMenuItem.Text = "ߊ߬ ߕߍ߰"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PasteToolStripMenuItem.MergeIndex = 2
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.ShowShortcutKeys = False
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PasteToolStripMenuItem.Text = "ߊ߬ ߣߙߊ߫"
        '
        'saveButon
        '
        Me.saveButon.AutoSize = True
        Me.saveButon.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButon.Location = New System.Drawing.Point(945, 687)
        Me.saveButon.Name = "saveButon"
        Me.saveButon.Size = New System.Drawing.Size(148, 30)
        Me.saveButon.TabIndex = 5
        Me.saveButon.Text = "ߊ߬ ߟߊߞߎ߲߬ߘߎ߬"
        Me.saveButon.UseVisualStyleBackColor = True
        '
        'ouvrirButon
        '
        Me.ouvrirButon.AutoSize = True
        Me.ouvrirButon.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ouvrirButon.Location = New System.Drawing.Point(791, 687)
        Me.ouvrirButon.Name = "ouvrirButon"
        Me.ouvrirButon.Size = New System.Drawing.Size(148, 30)
        Me.ouvrirButon.TabIndex = 3
        Me.ouvrirButon.Text = "ߊ߬ ߘߊߦߟߍ߬"
        Me.ouvrirButon.UseVisualStyleBackColor = True
        '
        'SFileDEcrire
        '
        Me.SFileDEcrire.DefaultExt = "ߕߐ߮ ߏ߬ ߓߘߊ߫ ߕߊ߬ ߞߊ߬ߓߊ߲߫߸ ߘߏ߫ ߜߘߍ߫ ߛߓߍ߫"
        Me.SFileDEcrire.Filter = "ߛߓߍߟߌ߫ ߜߍ (*.txt)|*.txt|ߞߟߏߛߓߍ (*.docx)|*.docx| ߜߍߛߓߍ (*.odt)|*.odt| ߞߟߏߜߍߣߍ߲ (*." & _
    "rtf)|*.rtf"
        Me.SFileDEcrire.OverwritePrompt = False
        Me.SFileDEcrire.RestoreDirectory = True
        Me.SFileDEcrire.Title = "ߛߓߍߞߎ߲ߘߊ"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "ߞߐߕߐ߮ ߘߊߦߟߍ߬ߕߊ ߘߏ߫ ߓߊߕߐߡߐ߲߫ ߝߟߐ߫"
        Me.OpenFileDialog1.Filter = "ߛߓߍߟߌ߫ ߜߍ (*.txt)|*.txt|ߞߟߏߛߓߍ (*.docx)|*.docx| ߜߍߛߓߍ (*.odt)|*.odt| ߞߟߏߜߍߣߍ߲ (*." & _
    "rtf)|*.rtf"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(485, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ߛߓߍߟߌ ߞߍ߫ ߝߊ߬ߞߊ߲ ߘߐ߫"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiniToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(111, 48)
        '
        'MiniToolStripMenuItem
        '
        Me.MiniToolStripMenuItem.Name = "MiniToolStripMenuItem"
        Me.MiniToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.MiniToolStripMenuItem.ShowShortcutKeys = False
        Me.MiniToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.MiniToolStripMenuItem.Text = "ߊ߬ ߟߊߕߎߣߎ߲߫"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.ShowShortcutKeys = False
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "ߊ߬ ߘߊߕߎ߲߯"
        '
        'helpBouton
        '
        Me.helpBouton.AutoSize = True
        Me.helpBouton.BackColor = System.Drawing.SystemColors.Highlight
        Me.helpBouton.Cursor = System.Windows.Forms.Cursors.Help
        Me.helpBouton.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpBouton.Location = New System.Drawing.Point(1019, -2)
        Me.helpBouton.Name = "helpBouton"
        Me.helpBouton.Size = New System.Drawing.Size(37, 35)
        Me.helpBouton.TabIndex = 10
        Me.helpBouton.Text = "؟"
        Me.helpBouton.UseVisualStyleBackColor = False
        '
        'control
        '
        Me.control.AutoSize = True
        Me.control.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.control.Location = New System.Drawing.Point(615, 687)
        Me.control.Name = "control"
        Me.control.Size = New System.Drawing.Size(93, 30)
        Me.control.TabIndex = 11
        Me.control.Text = "ߛߊߞߍߟߌ"
        Me.control.UseVisualStyleBackColor = True
        '
        'noSaveEcrire
        '
        Me.noSaveEcrire.AutoSize = True
        Me.noSaveEcrire.ForeColor = System.Drawing.Color.DarkRed
        Me.noSaveEcrire.Location = New System.Drawing.Point(393, 25)
        Me.noSaveEcrire.Name = "noSaveEcrire"
        Me.noSaveEcrire.Size = New System.Drawing.Size(71, 13)
        Me.noSaveEcrire.TabIndex = 12
        Me.noSaveEcrire.Text = "noSaveEcrire"
        Me.noSaveEcrire.Visible = False
        '
        'noSaveOuvrir
        '
        Me.noSaveOuvrir.AutoSize = True
        Me.noSaveOuvrir.ForeColor = System.Drawing.Color.DarkRed
        Me.noSaveOuvrir.Location = New System.Drawing.Point(929, 25)
        Me.noSaveOuvrir.Name = "noSaveOuvrir"
        Me.noSaveOuvrir.Size = New System.Drawing.Size(72, 13)
        Me.noSaveOuvrir.TabIndex = 12
        Me.noSaveOuvrir.Text = "noSaveOuvrir"
        Me.noSaveOuvrir.Visible = False
        '
        'noControled
        '
        Me.noControled.AutoSize = True
        Me.noControled.Location = New System.Drawing.Point(840, 25)
        Me.noControled.Name = "noControled"
        Me.noControled.Size = New System.Drawing.Size(64, 13)
        Me.noControled.TabIndex = 13
        Me.noControled.Text = "noControled"
        Me.noControled.Visible = False
        '
        'pathEcrire
        '
        Me.pathEcrire.AutoSize = True
        Me.pathEcrire.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathEcrire.Location = New System.Drawing.Point(244, 3)
        Me.pathEcrire.Name = "pathEcrire"
        Me.pathEcrire.Size = New System.Drawing.Size(80, 21)
        Me.pathEcrire.TabIndex = 14
        Me.pathEcrire.Text = "pathEcrire"
        Me.pathEcrire.Visible = False
        '
        'pathOuvrir
        '
        Me.pathOuvrir.AutoSize = True
        Me.pathOuvrir.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.pathOuvrir.Location = New System.Drawing.Point(748, 3)
        Me.pathOuvrir.Name = "pathOuvrir"
        Me.pathOuvrir.Size = New System.Drawing.Size(86, 21)
        Me.pathOuvrir.TabIndex = 14
        Me.pathOuvrir.Text = "pathOuvrir"
        Me.pathOuvrir.Visible = False
        '
        'notifTimer1
        '
        Me.notifTimer1.Interval = 5000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SbekalinTooToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(49, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(91, 29)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SbekalinTooToolStripMenuItem
        '
        Me.SbekalinTooToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SbekalinTooToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAgainToolStripMenuItem, Me.ToSaveToolStripMenuItem, Me.ToOpenToolStripMenuItem, Me.FullScrToolStripMenuItem, Me.ControlToolStripMenuItem, Me.ToExitToolStripMenuItem})
        Me.SbekalinTooToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SbekalinTooToolStripMenuItem.Name = "SbekalinTooToolStripMenuItem"
        Me.SbekalinTooToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.SbekalinTooToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SbekalinTooToolStripMenuItem.ShowShortcutKeys = False
        Me.SbekalinTooToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.SbekalinTooToolStripMenuItem.Text = "ߛߓߍߞߊߟߌ߲"
        Me.SbekalinTooToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveAgainToolStripMenuItem
        '
        Me.SaveAgainToolStripMenuItem.Enabled = False
        Me.SaveAgainToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SaveAgainToolStripMenuItem.Name = "SaveAgainToolStripMenuItem"
        Me.SaveAgainToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAgainToolStripMenuItem.ShowShortcutKeys = False
        Me.SaveAgainToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.SaveAgainToolStripMenuItem.Text = "ߊ߬ ߟߊߞߎ߲߬ߘߎ߬"
        '
        'ToSaveToolStripMenuItem
        '
        Me.ToSaveToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToSaveToolStripMenuItem.Name = "ToSaveToolStripMenuItem"
        Me.ToSaveToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToSaveToolStripMenuItem.ShowShortcutKeys = False
        Me.ToSaveToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ToSaveToolStripMenuItem.Text = "ߛߓߍ ߛߌ߲ߘߌ߫"
        '
        'ToOpenToolStripMenuItem
        '
        Me.ToOpenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToOpenToolStripMenuItem.Name = "ToOpenToolStripMenuItem"
        Me.ToOpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToOpenToolStripMenuItem.ShowShortcutKeys = False
        Me.ToOpenToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ToOpenToolStripMenuItem.Text = "ߊ߬ ߘߊߦߟߍ߬"
        '
        'FullScrToolStripMenuItem
        '
        Me.FullScrToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullScrToolStripMenuItem.Name = "FullScrToolStripMenuItem"
        Me.FullScrToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.FullScrToolStripMenuItem.ShowShortcutKeys = False
        Me.FullScrToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.FullScrToolStripMenuItem.Text = "ߓߍ߲߬ߒߠߊ"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ControlToolStripMenuItem.Text = "ߊ߬ ߛߊߞߍ߫"
        '
        'ToExitToolStripMenuItem
        '
        Me.ToExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToExitToolStripMenuItem.Name = "ToExitToolStripMenuItem"
        Me.ToExitToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.ToExitToolStripMenuItem.Text = "ߊ߬ ߘߊߕߎ߲߯"
        '
        'minimS
        '
        Me.minimS.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimS.Location = New System.Drawing.Point(1054, -2)
        Me.minimS.Name = "minimS"
        Me.minimS.Size = New System.Drawing.Size(37, 35)
        Me.minimS.TabIndex = 18
        Me.minimS.Text = "ߺ"
        Me.minimS.UseVisualStyleBackColor = True
        '
        'endS
        '
        Me.endS.BackColor = System.Drawing.Color.IndianRed
        Me.endS.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endS.Location = New System.Drawing.Point(1090, -2)
        Me.endS.Name = "endS"
        Me.endS.Size = New System.Drawing.Size(37, 35)
        Me.endS.TabIndex = 19
        Me.endS.Text = "x"
        Me.endS.UseVisualStyleBackColor = False
        '
        'IconeMenuStrip
        '
        Me.IconeMenuStrip.AutoSize = False
        Me.IconeMenuStrip.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.IconeMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.IconeMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.IconeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FassoIToolStripMenuItem})
        Me.IconeMenuStrip.Location = New System.Drawing.Point(20, 8)
        Me.IconeMenuStrip.Name = "IconeMenuStrip"
        Me.IconeMenuStrip.Size = New System.Drawing.Size(108, 29)
        Me.IconeMenuStrip.TabIndex = 20
        Me.IconeMenuStrip.Text = "MenuStrip2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.IconeMenuStrip)
        Me.GroupBox1.Location = New System.Drawing.Point(10, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 40)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(47, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        '
        'saveAgainButon
        '
        Me.saveAgainButon.Font = New System.Drawing.Font("Ebrima", 11.25!)
        Me.saveAgainButon.Location = New System.Drawing.Point(411, 687)
        Me.saveAgainButon.Name = "saveAgainButon"
        Me.saveAgainButon.Size = New System.Drawing.Size(146, 30)
        Me.saveAgainButon.TabIndex = 23
        Me.saveAgainButon.Text = "ߟߊ߬ߞߎ߲߬ߘߎ߬ߟߌ"
        Me.saveAgainButon.UseVisualStyleBackColor = True
        Me.saveAgainButon.Visible = False
        '
        'methodeNotOuvrir
        '
        Me.methodeNotOuvrir.AutoSize = True
        Me.methodeNotOuvrir.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.methodeNotOuvrir.Location = New System.Drawing.Point(662, 25)
        Me.methodeNotOuvrir.Name = "methodeNotOuvrir"
        Me.methodeNotOuvrir.Size = New System.Drawing.Size(98, 13)
        Me.methodeNotOuvrir.TabIndex = 24
        Me.methodeNotOuvrir.Text = "methodeNotOuvrir"
        Me.methodeNotOuvrir.Visible = False
        '
        'methodeNotEcrire
        '
        Me.methodeNotEcrire.AutoSize = True
        Me.methodeNotEcrire.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.methodeNotEcrire.Location = New System.Drawing.Point(154, 25)
        Me.methodeNotEcrire.Name = "methodeNotEcrire"
        Me.methodeNotEcrire.Size = New System.Drawing.Size(96, 13)
        Me.methodeNotEcrire.TabIndex = 24
        Me.methodeNotEcrire.Text = "methodeNotEcrire"
        Me.methodeNotEcrire.Visible = False
        '
        'SFileDOuvrir
        '
        Me.SFileDOuvrir.Filter = "ߛߓߍߟߌ߫ ߜߍ (*.txt)|*.txt|ߞߟߏߛߓߍ (*.docx)|*.docx| ߜߍߛߓߍ (*.odt)|*.odt| ߞߟߏߜߍߣߍ߲ (*." & _
    "rtf)|*.rtf"
        Me.SFileDOuvrir.Title = "ߘߊߦߟߍߞߎ߲ߘߊ"
        '
        'OpenOrNew
        '
        Me.OpenOrNew.AutoSize = True
        Me.OpenOrNew.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenOrNew.ForeColor = System.Drawing.Color.Indigo
        Me.OpenOrNew.Location = New System.Drawing.Point(922, 4)
        Me.OpenOrNew.Name = "OpenOrNew"
        Me.OpenOrNew.Size = New System.Drawing.Size(86, 19)
        Me.OpenOrNew.TabIndex = 25
        Me.OpenOrNew.Text = "OpenOrNew"
        Me.OpenOrNew.Visible = False
        '
        'NoMasqueOpen
        '
        Me.NoMasqueOpen.Interval = 50
        '
        'FassoIToolStripMenuItem
        '
        Me.FassoIToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.FassoIToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FassoIToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FassoIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideBoutonsToolStripMenuItem, Me.ControlModeToolStripMenuItem, Me.AproposToolStripMenuItem, Me.CommentToolStripMenuItem, Me.CaptureEcranToolStripMenuItem, Me.UpdateToolStripMenuItem})
        Me.FassoIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.FassoIToolStripMenuItem.Image = Global.Sbeikalin.My.Resources.Resources.FassoIcone
        Me.FassoIToolStripMenuItem.Name = "FassoIToolStripMenuItem"
        Me.FassoIToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FassoIToolStripMenuItem.ShowShortcutKeys = False
        Me.FassoIToolStripMenuItem.Size = New System.Drawing.Size(32, 25)
        Me.FassoIToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'HideBoutonsToolStripMenuItem
        '
        Me.HideBoutonsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.HideBoutonsToolStripMenuItem.Name = "HideBoutonsToolStripMenuItem"
        Me.HideBoutonsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.HideBoutonsToolStripMenuItem.ShowShortcutKeys = False
        Me.HideBoutonsToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.HideBoutonsToolStripMenuItem.Text = "ߞߎ߬ߘߎ ߟߎ߬ ߟߊߕߎߣߎ߲߫"
        '
        'ControlModeToolStripMenuItem
        '
        Me.ControlModeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ControlModeToolStripMenuItem.Name = "ControlModeToolStripMenuItem"
        Me.ControlModeToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.ControlModeToolStripMenuItem.Text = "ߛߊߞߍߟߌ ߞߍ߫ ߢߊ"
        '
        'AproposToolStripMenuItem
        '
        Me.AproposToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AproposToolStripMenuItem.Name = "AproposToolStripMenuItem"
        Me.AproposToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.AproposToolStripMenuItem.Text = "ߛߓߍߞߊߟߌ߲ ߞߊ߲߬"
        '
        'CommentToolStripMenuItem
        '
        Me.CommentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CommentToolStripMenuItem.Name = "CommentToolStripMenuItem"
        Me.CommentToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.CommentToolStripMenuItem.Text = "ߞߊ߲߬ߞߎ߬ߡߊ߬ߘߊ"
        '
        'CaptureEcranToolStripMenuItem
        '
        Me.CaptureEcranToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CaptureEcranToolStripMenuItem.Name = "CaptureEcranToolStripMenuItem"
        Me.CaptureEcranToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.CaptureEcranToolStripMenuItem.ShowShortcutKeys = False
        Me.CaptureEcranToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.CaptureEcranToolStripMenuItem.Text = "ߥߊ߲߬ߥߊ߲߬ ߖߊߛߏ߲"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.UpdateToolStripMenuItem.Text = "ߟߏ߲ߘߐߦߊߟߌ"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1128, 723)
        Me.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Controls.Add(Me.endS)
        Me.Controls.Add(Me.minimS)
        Me.Controls.Add(Me.helpBouton)
        Me.Controls.Add(Me.OpenOrNew)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.methodeNotEcrire)
        Me.Controls.Add(Me.methodeNotOuvrir)
        Me.Controls.Add(Me.saveAgainButon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pathOuvrir)
        Me.Controls.Add(Me.pathEcrire)
        Me.Controls.Add(Me.noControled)
        Me.Controls.Add(Me.noSaveOuvrir)
        Me.Controls.Add(Me.noSaveEcrire)
        Me.Controls.Add(Me.control)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ecrire)
        Me.Controls.Add(Me.saveButon)
        Me.Controls.Add(Me.ouvrirButon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ouvrir)
        Me.Controls.Add(Me.ecrireButon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1128, 723)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1128, 723)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ߊߟߎ߫ ߞߣߊ߫ ߢߌ߬ߣߊ߬ ߞߐߕߐ߮ ߟߊߞߎ߲߬ߘߎ߬ ߞߏ ߘߐ߫ ߘߋ߬. ߺ"
        Me.Text = "  "
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.IconeMenuStrip.ResumeLayout(False)
        Me.IconeMenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ecrireButon As System.Windows.Forms.Button
    Friend WithEvents ouvrir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ecrire As System.Windows.Forms.TextBox
    Friend WithEvents saveButon As System.Windows.Forms.Button
    Friend WithEvents ouvrirButon As System.Windows.Forms.Button
    Friend WithEvents SFileDEcrire As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SlectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cut2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpBouton As System.Windows.Forms.Button
    Friend WithEvents control As System.Windows.Forms.Button
    Friend WithEvents noSaveEcrire As System.Windows.Forms.Label
    Friend WithEvents noSaveOuvrir As System.Windows.Forms.Label
    Friend WithEvents noControled As System.Windows.Forms.Label
    Friend WithEvents pathEcrire As System.Windows.Forms.Label
    Friend WithEvents pathOuvrir As System.Windows.Forms.Label
    Friend WithEvents notifTimer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SbekalinTooToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToSaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimS As System.Windows.Forms.Button
    Friend WithEvents endS As System.Windows.Forms.Button
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IconeMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FassoIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideBoutonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AproposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents saveAgainButon As System.Windows.Forms.Button
    Friend WithEvents SaveAgainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents methodeNotOuvrir As System.Windows.Forms.Label
    Friend WithEvents methodeNotEcrire As System.Windows.Forms.Label
    Friend WithEvents SFileDOuvrir As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenOrNew As System.Windows.Forms.Label
    Friend WithEvents NoMasqueOpen As System.Windows.Forms.Timer
    Friend WithEvents CommentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaptureEcranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
