<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCash3
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
        Me.grbCash3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCash3OK = New System.Windows.Forms.Button()
        Me.btnQuickpick = New System.Windows.Forms.Button()
        Me.lblCash3Info = New System.Windows.Forms.Label()
        Me.txt3Cash3 = New System.Windows.Forms.TextBox()
        Me.txt2Cash3 = New System.Windows.Forms.TextBox()
        Me.txt1Cash3 = New System.Windows.Forms.TextBox()
        Me.grbCash3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCash3
        '
        Me.grbCash3.BackColor = System.Drawing.Color.Honeydew
        Me.grbCash3.Controls.Add(Me.btnExit)
        Me.grbCash3.Controls.Add(Me.btnCash3OK)
        Me.grbCash3.Controls.Add(Me.btnQuickpick)
        Me.grbCash3.Controls.Add(Me.lblCash3Info)
        Me.grbCash3.Controls.Add(Me.txt3Cash3)
        Me.grbCash3.Controls.Add(Me.txt2Cash3)
        Me.grbCash3.Controls.Add(Me.txt1Cash3)
        Me.grbCash3.Location = New System.Drawing.Point(2, 3)
        Me.grbCash3.Name = "grbCash3"
        Me.grbCash3.Size = New System.Drawing.Size(793, 444)
        Me.grbCash3.TabIndex = 4
        Me.grbCash3.TabStop = False
        Me.grbCash3.Text = "grbCash3"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Teal
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(660, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 63)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCash3OK
        '
        Me.btnCash3OK.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCash3OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash3OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCash3OK.Location = New System.Drawing.Point(371, 109)
        Me.btnCash3OK.Name = "btnCash3OK"
        Me.btnCash3OK.Size = New System.Drawing.Size(119, 55)
        Me.btnCash3OK.TabIndex = 5
        Me.btnCash3OK.Text = "OK"
        Me.btnCash3OK.UseVisualStyleBackColor = False
        '
        'btnQuickpick
        '
        Me.btnQuickpick.BackColor = System.Drawing.Color.Teal
        Me.btnQuickpick.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickpick.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnQuickpick.Location = New System.Drawing.Point(335, 12)
        Me.btnQuickpick.Name = "btnQuickpick"
        Me.btnQuickpick.Size = New System.Drawing.Size(155, 51)
        Me.btnQuickpick.TabIndex = 4
        Me.btnQuickpick.Text = "QUICK PICK"
        Me.btnQuickpick.UseVisualStyleBackColor = False
        '
        'lblCash3Info
        '
        Me.lblCash3Info.AutoSize = True
        Me.lblCash3Info.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash3Info.Location = New System.Drawing.Point(8, 22)
        Me.lblCash3Info.Name = "lblCash3Info"
        Me.lblCash3Info.Size = New System.Drawing.Size(321, 27)
        Me.lblCash3Info.TabIndex = 3
        Me.lblCash3Info.Text = "Enter 3 numbers from 0 - 9 :"
        '
        'txt3Cash3
        '
        Me.txt3Cash3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3Cash3.Location = New System.Drawing.Point(273, 120)
        Me.txt3Cash3.Name = "txt3Cash3"
        Me.txt3Cash3.Size = New System.Drawing.Size(56, 36)
        Me.txt3Cash3.TabIndex = 2
        '
        'txt2Cash3
        '
        Me.txt2Cash3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2Cash3.Location = New System.Drawing.Point(211, 120)
        Me.txt2Cash3.Name = "txt2Cash3"
        Me.txt2Cash3.Size = New System.Drawing.Size(56, 36)
        Me.txt2Cash3.TabIndex = 1
        '
        'txt1Cash3
        '
        Me.txt1Cash3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1Cash3.Location = New System.Drawing.Point(149, 120)
        Me.txt1Cash3.Name = "txt1Cash3"
        Me.txt1Cash3.Size = New System.Drawing.Size(56, 36)
        Me.txt1Cash3.TabIndex = 0
        '
        'frmCash3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbCash3)
        Me.Name = "frmCash3"
        Me.Text = "frmCash3"
        Me.grbCash3.ResumeLayout(False)
        Me.grbCash3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbCash3 As GroupBox
    Friend WithEvents btnCash3OK As Button
    Friend WithEvents btnQuickpick As Button
    Friend WithEvents lblCash3Info As Label
    Friend WithEvents txt3Cash3 As TextBox
    Friend WithEvents txt2Cash3 As TextBox
    Friend WithEvents txt1Cash3 As TextBox
    Friend WithEvents btnExit As Button
End Class
