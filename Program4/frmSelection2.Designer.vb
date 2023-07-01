<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelection2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbUserSelection = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMegaMillions = New System.Windows.Forms.Button()
        Me.btnFantasy5 = New System.Windows.Forms.Button()
        Me.btnCash4 = New System.Windows.Forms.Button()
        Me.btnCash3 = New System.Windows.Forms.Button()
        Me.grbUserSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbUserSelection
        '
        Me.grbUserSelection.BackColor = System.Drawing.Color.MediumPurple
        Me.grbUserSelection.Controls.Add(Me.Label1)
        Me.grbUserSelection.Controls.Add(Me.btnMegaMillions)
        Me.grbUserSelection.Controls.Add(Me.btnFantasy5)
        Me.grbUserSelection.Controls.Add(Me.btnCash4)
        Me.grbUserSelection.Controls.Add(Me.btnCash3)
        Me.grbUserSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grbUserSelection.Location = New System.Drawing.Point(12, 12)
        Me.grbUserSelection.Name = "grbUserSelection"
        Me.grbUserSelection.Size = New System.Drawing.Size(776, 426)
        Me.grbUserSelection.TabIndex = 3
        Me.grbUserSelection.TabStop = False
        Me.grbUserSelection.Text = "grbUserSelection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(311, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose one :"
        '
        'btnMegaMillions
        '
        Me.btnMegaMillions.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnMegaMillions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMegaMillions.ForeColor = System.Drawing.Color.White
        Me.btnMegaMillions.Location = New System.Drawing.Point(268, 311)
        Me.btnMegaMillions.Name = "btnMegaMillions"
        Me.btnMegaMillions.Size = New System.Drawing.Size(268, 61)
        Me.btnMegaMillions.TabIndex = 3
        Me.btnMegaMillions.Text = "MegaMillions"
        Me.btnMegaMillions.UseVisualStyleBackColor = False
        '
        'btnFantasy5
        '
        Me.btnFantasy5.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnFantasy5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFantasy5.ForeColor = System.Drawing.Color.White
        Me.btnFantasy5.Location = New System.Drawing.Point(268, 244)
        Me.btnFantasy5.Name = "btnFantasy5"
        Me.btnFantasy5.Size = New System.Drawing.Size(268, 61)
        Me.btnFantasy5.TabIndex = 2
        Me.btnFantasy5.Text = "Fantasy5"
        Me.btnFantasy5.UseVisualStyleBackColor = False
        '
        'btnCash4
        '
        Me.btnCash4.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnCash4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash4.ForeColor = System.Drawing.Color.White
        Me.btnCash4.Location = New System.Drawing.Point(268, 177)
        Me.btnCash4.Name = "btnCash4"
        Me.btnCash4.Size = New System.Drawing.Size(268, 61)
        Me.btnCash4.TabIndex = 1
        Me.btnCash4.Text = "Cash4"
        Me.btnCash4.UseVisualStyleBackColor = False
        '
        'btnCash3
        '
        Me.btnCash3.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnCash3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash3.ForeColor = System.Drawing.Color.White
        Me.btnCash3.Location = New System.Drawing.Point(268, 110)
        Me.btnCash3.Name = "btnCash3"
        Me.btnCash3.Size = New System.Drawing.Size(268, 61)
        Me.btnCash3.TabIndex = 0
        Me.btnCash3.Text = "Cash3"
        Me.btnCash3.UseVisualStyleBackColor = False
        '
        'frmSelection2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbUserSelection)
        Me.Name = "frmSelection2"
        Me.Text = "frmSelection2"
        Me.grbUserSelection.ResumeLayout(False)
        Me.grbUserSelection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbUserSelection As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMegaMillions As Button
    Friend WithEvents btnFantasy5 As Button
    Friend WithEvents btnCash4 As Button
    Friend WithEvents btnCash3 As Button
End Class
