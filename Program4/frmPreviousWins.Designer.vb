<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviousWins
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
        Me.grbPreviousWins = New System.Windows.Forms.GroupBox()
        Me.btnShowData = New System.Windows.Forms.Button()
        Me.btnPreviousWins = New System.Windows.Forms.Button()
        Me.lblPreviousWins = New System.Windows.Forms.Label()
        Me.lstWins = New System.Windows.Forms.ListBox()
        Me.grbPreviousWins.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPreviousWins
        '
        Me.grbPreviousWins.BackColor = System.Drawing.Color.LavenderBlush
        Me.grbPreviousWins.Controls.Add(Me.lstWins)
        Me.grbPreviousWins.Controls.Add(Me.btnShowData)
        Me.grbPreviousWins.Controls.Add(Me.btnPreviousWins)
        Me.grbPreviousWins.Controls.Add(Me.lblPreviousWins)
        Me.grbPreviousWins.Location = New System.Drawing.Point(12, 12)
        Me.grbPreviousWins.Name = "grbPreviousWins"
        Me.grbPreviousWins.Size = New System.Drawing.Size(946, 561)
        Me.grbPreviousWins.TabIndex = 2
        Me.grbPreviousWins.TabStop = False
        Me.grbPreviousWins.Text = "grbPreviousWins"
        '
        'btnShowData
        '
        Me.btnShowData.BackColor = System.Drawing.Color.BlueViolet
        Me.btnShowData.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShowData.Location = New System.Drawing.Point(683, 251)
        Me.btnShowData.Name = "btnShowData"
        Me.btnShowData.Size = New System.Drawing.Size(118, 76)
        Me.btnShowData.TabIndex = 6
        Me.btnShowData.Text = "Show Data"
        Me.btnShowData.UseVisualStyleBackColor = False
        '
        'btnPreviousWins
        '
        Me.btnPreviousWins.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnPreviousWins.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPreviousWins.Location = New System.Drawing.Point(847, 513)
        Me.btnPreviousWins.Name = "btnPreviousWins"
        Me.btnPreviousWins.Size = New System.Drawing.Size(93, 42)
        Me.btnPreviousWins.TabIndex = 4
        Me.btnPreviousWins.Text = "OK"
        Me.btnPreviousWins.UseVisualStyleBackColor = False
        '
        'lblPreviousWins
        '
        Me.lblPreviousWins.AutoSize = True
        Me.lblPreviousWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousWins.Location = New System.Drawing.Point(271, 38)
        Me.lblPreviousWins.Name = "lblPreviousWins"
        Me.lblPreviousWins.Size = New System.Drawing.Size(194, 25)
        Me.lblPreviousWins.TabIndex = 0
        Me.lblPreviousWins.Text = "The previous wins:"
        '
        'lstWins
        '
        Me.lstWins.FormattingEnabled = True
        Me.lstWins.ItemHeight = 20
        Me.lstWins.Location = New System.Drawing.Point(6, 66)
        Me.lstWins.Name = "lstWins"
        Me.lstWins.Size = New System.Drawing.Size(671, 484)
        Me.lstWins.TabIndex = 7
        '
        'frmPreviousWins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 585)
        Me.Controls.Add(Me.grbPreviousWins)
        Me.Name = "frmPreviousWins"
        Me.Text = "frmPreviousWins"
        Me.grbPreviousWins.ResumeLayout(False)
        Me.grbPreviousWins.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPreviousWins As GroupBox
    Friend WithEvents btnPreviousWins As Button
    Friend WithEvents lblPreviousWins As Label
    Friend WithEvents btnShowData As Button
    Friend WithEvents lstWins As ListBox
End Class
