<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(helpForm))
        Me.corpsText = New System.Windows.Forms.Label()
        Me.conseils = New System.Windows.Forms.Label()
        Me.fassoLien = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kadanNadjiNote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'corpsText
        '
        Me.corpsText.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corpsText.Location = New System.Drawing.Point(35, 62)
        Me.corpsText.Name = "corpsText"
        Me.corpsText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.corpsText.Size = New System.Drawing.Size(643, 137)
        Me.corpsText.TabIndex = 0
        Me.corpsText.Text = resources.GetString("corpsText.Text")
        '
        'conseils
        '
        Me.conseils.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conseils.Location = New System.Drawing.Point(35, 494)
        Me.conseils.Name = "conseils"
        Me.conseils.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.conseils.Size = New System.Drawing.Size(643, 154)
        Me.conseils.TabIndex = 3
        Me.conseils.Text = resources.GetString("conseils.Text")
        '
        'fassoLien
        '
        Me.fassoLien.AutoSize = True
        Me.fassoLien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fassoLien.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fassoLien.ForeColor = System.Drawing.Color.MediumBlue
        Me.fassoLien.Location = New System.Drawing.Point(30, 663)
        Me.fassoLien.Name = "fassoLien"
        Me.fassoLien.Size = New System.Drawing.Size(52, 26)
        Me.fassoLien.TabIndex = 4
        Me.fassoLien.Text = "ߝߊ߬ߛߏ"
        Me.fassoLien.Visible = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ߣߌ߲߬ ߘߊߕߎ߲߯"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(306, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ߘߍ߬ߡߍ߲߬ߠߌ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(55, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(623, 280)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(558, 663)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ߞߊߘߊ߲ߓߐߣߍ߲ ߁߭"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(448, 663)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ߞߊߘߊ߲ߓߐߣߍ߲ ߂߲"
        '
        'kadanNadjiNote
        '
        Me.kadanNadjiNote.AutoSize = True
        Me.kadanNadjiNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kadanNadjiNote.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kadanNadjiNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kadanNadjiNote.Location = New System.Drawing.Point(162, 664)
        Me.kadanNadjiNote.Name = "kadanNadjiNote"
        Me.kadanNadjiNote.Size = New System.Drawing.Size(163, 25)
        Me.kadanNadjiNote.TabIndex = 10
        Me.kadanNadjiNote.Text = "ߞߊߘߊ߲ߓߐ ߞߊ߬ߝߊ ߘߊߦߟߍ߬"
        '
        'helpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(703, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.kadanNadjiNote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fassoLien)
        Me.Controls.Add(Me.conseils)
        Me.Controls.Add(Me.corpsText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(703, 704)
        Me.MinimumSize = New System.Drawing.Size(703, 704)
        Me.Name = "helpForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ߘߍ߬ߡߍ߲߬ߠߌ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents corpsText As System.Windows.Forms.Label
    Friend WithEvents conseils As System.Windows.Forms.Label
    Friend WithEvents fassoLien As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kadanNadjiNote As System.Windows.Forms.Label
End Class
