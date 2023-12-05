<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtKM = New System.Windows.Forms.TextBox()
        Me.ButtonconverttoKM = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rdoKMinput = New System.Windows.Forms.RadioButton()
        Me.rdoMInput = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(61, 159)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(186, 20)
        Me.txtMiles.TabIndex = 0
        '
        'txtKM
        '
        Me.txtKM.Location = New System.Drawing.Point(534, 159)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(205, 20)
        Me.txtKM.TabIndex = 1
        '
        'ButtonconverttoKM
        '
        Me.ButtonconverttoKM.Font = New System.Drawing.Font("Vivaldi", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonconverttoKM.Location = New System.Drawing.Point(0, 246)
        Me.ButtonconverttoKM.Name = "ButtonconverttoKM"
        Me.ButtonconverttoKM.Size = New System.Drawing.Size(401, 219)
        Me.ButtonconverttoKM.TabIndex = 3
        Me.ButtonconverttoKM.Text = "Convert to KM"
        Me.ButtonconverttoKM.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Parchment", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(273, 6)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(226, 102)
        Me.Label.TabIndex = 4
        Me.Label.Text = "Convert"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Vivaldi", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(393, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(415, 219)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Convert to Miles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rdoKMinput
        '
        Me.rdoKMinput.AutoSize = True
        Me.rdoKMinput.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKMinput.Location = New System.Drawing.Point(7, 16)
        Me.rdoKMinput.Name = "rdoKMinput"
        Me.rdoKMinput.Size = New System.Drawing.Size(47, 19)
        Me.rdoKMinput.TabIndex = 6
        Me.rdoKMinput.TabStop = True
        Me.rdoKMinput.Text = " KM"
        Me.rdoKMinput.UseVisualStyleBackColor = True
        '
        'rdoMInput
        '
        Me.rdoMInput.AutoSize = True
        Me.rdoMInput.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMInput.Location = New System.Drawing.Point(7, 37)
        Me.rdoMInput.Name = "rdoMInput"
        Me.rdoMInput.Size = New System.Drawing.Size(54, 19)
        Me.rdoMInput.TabIndex = 7
        Me.rdoMInput.TabStop = True
        Me.rdoMInput.Text = "Mile"
        Me.rdoMInput.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(10, 15)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(10, 38)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoMInput)
        Me.GroupBox1.Controls.Add(Me.rdoKMinput)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Location = New System.Drawing.Point(588, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 60)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(69, 135)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(70, 21)
        Me.lblInput.TabIndex = 11
        Me.lblInput.Text = "distance"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(594, 136)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(70, 21)
        Me.lblOutput.TabIndex = 12
        Me.lblOutput.Text = "distance"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ButtonconverttoKM)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.txtMiles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtKM As TextBox
    Friend WithEvents ButtonconverttoKM As Button
    Protected WithEvents Label As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents rdoKMinput As RadioButton
    Friend WithEvents rdoMInput As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblInput As Label
    Friend WithEvents lblOutput As Label
End Class
