<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class captureDEcran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(captureDEcran))
        Me.closeButon = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HidecapturerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.notesaving = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButon
        '
        Me.closeButon.AutoSize = True
        Me.closeButon.BackColor = System.Drawing.Color.IndianRed
        Me.closeButon.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButon.Location = New System.Drawing.Point(-1, -1)
        Me.closeButon.Name = "closeButon"
        Me.closeButon.Size = New System.Drawing.Size(58, 29)
        Me.closeButon.TabIndex = 0
        Me.closeButon.Text = "ߊ߬ ߘߊߕߎ߲߯"
        Me.closeButon.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaptureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(855, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(77, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CaptureToolStripMenuItem
        '
        Me.CaptureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturerToolStripMenuItem, Me.HidecapturerToolStripMenuItem, Me.SaveImageToolStripMenuItem, Me.ExiteToolStripMenuItem})
        Me.CaptureToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.CaptureToolStripMenuItem.Name = "CaptureToolStripMenuItem"
        Me.CaptureToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.CaptureToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.CaptureToolStripMenuItem.Text = "ߖߊ߬ߛߏ߲߬ߠߌ"
        '
        'CapturerToolStripMenuItem
        '
        Me.CapturerToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.CapturerToolStripMenuItem.Name = "CapturerToolStripMenuItem"
        Me.CapturerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.CapturerToolStripMenuItem.ShowShortcutKeys = False
        Me.CapturerToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.CapturerToolStripMenuItem.Text = "ߊ߬ ߖߊ߬ߛߏ߲߬"
        '
        'HidecapturerToolStripMenuItem
        '
        Me.HidecapturerToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.HidecapturerToolStripMenuItem.Name = "HidecapturerToolStripMenuItem"
        Me.HidecapturerToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.HidecapturerToolStripMenuItem.ShowShortcutKeys = False
        Me.HidecapturerToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.HidecapturerToolStripMenuItem.Text = "ߕߎߣߎ߲߫ ߞߵߊ߬ ߖߊ߬ߛߏ߲߬"
        '
        'SaveImageToolStripMenuItem
        '
        Me.SaveImageToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.SaveImageToolStripMenuItem.Name = "SaveImageToolStripMenuItem"
        Me.SaveImageToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.SaveImageToolStripMenuItem.Text = "ߖߌ߬ߦߊ ߟߊߡߙߊ߬"
        '
        'ExiteToolStripMenuItem
        '
        Me.ExiteToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.ExiteToolStripMenuItem.Name = "ExiteToolStripMenuItem"
        Me.ExiteToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.ExiteToolStripMenuItem.Text = "ߊ߬ ߘߊߕߎ߲߯"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(912, 496)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'notesaving
        '
        Me.notesaving.AutoSize = True
        Me.notesaving.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notesaving.Location = New System.Drawing.Point(443, 8)
        Me.notesaving.Name = "notesaving"
        Me.notesaving.Size = New System.Drawing.Size(49, 19)
        Me.notesaving.TabIndex = 3
        Me.notesaving.Text = "Label1"
        Me.notesaving.Visible = False
        '
        'captureDEcran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.notesaving)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.closeButon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "captureDEcran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ߥߊ߲߬ߥߊ߲߬ ߖߊߛߏ߲"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeButon As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HidecapturerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents notesaving As System.Windows.Forms.Label
End Class
