<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVerification1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grbVerification = New System.Windows.Forms.GroupBox()
        Me.btnAge = New System.Windows.Forms.Button()
        Me.lblAgeVerification = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblVerification = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grbVerification.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbVerification
        '
        Me.grbVerification.BackColor = System.Drawing.Color.Lavender
        Me.grbVerification.Controls.Add(Me.btnExit)
        Me.grbVerification.Controls.Add(Me.btnAge)
        Me.grbVerification.Controls.Add(Me.lblAgeVerification)
        Me.grbVerification.Controls.Add(Me.DateTimePicker1)
        Me.grbVerification.Controls.Add(Me.lblVerification)
        Me.grbVerification.Location = New System.Drawing.Point(12, 13)
        Me.grbVerification.Name = "grbVerification"
        Me.grbVerification.Size = New System.Drawing.Size(1213, 708)
        Me.grbVerification.TabIndex = 0
        Me.grbVerification.TabStop = False
        Me.grbVerification.Text = "grbVerification"
        '
        'btnAge
        '
        Me.btnAge.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAge.Location = New System.Drawing.Point(534, 439)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(176, 64)
        Me.btnAge.TabIndex = 3
        Me.btnAge.Text = "OK"
        Me.btnAge.UseVisualStyleBackColor = False
        '
        'lblAgeVerification
        '
        Me.lblAgeVerification.AutoSize = True
        Me.lblAgeVerification.Font = New System.Drawing.Font("Rockwell", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeVerification.Location = New System.Drawing.Point(266, 206)
        Me.lblAgeVerification.Name = "lblAgeVerification"
        Me.lblAgeVerification.Size = New System.Drawing.Size(809, 50)
        Me.lblAgeVerification.TabIndex = 2
        Me.lblAgeVerification.Text = "Please enter your birth date to continue:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(407, 363)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(423, 35)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblVerification
        '
        Me.lblVerification.AutoSize = True
        Me.lblVerification.Location = New System.Drawing.Point(7, 26)
        Me.lblVerification.Name = "lblVerification"
        Me.lblVerification.Size = New System.Drawing.Size(0, 20)
        Me.lblVerification.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Teal
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(1047, 633)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 69)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmVerification1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 733)
        Me.Controls.Add(Me.grbVerification)
        Me.Name = "frmVerification1"
        Me.Text = "Form1"
        Me.grbVerification.ResumeLayout(False)
        Me.grbVerification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbVerification As GroupBox
    Friend WithEvents lblVerification As Label
    Friend WithEvents btnAge As Button
    Friend WithEvents lblAgeVerification As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnExit As Button
End Class
