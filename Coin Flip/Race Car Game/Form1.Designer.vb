<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race_Car
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Race_Car))
        Me.picCar1 = New System.Windows.Forms.PictureBox()
        Me.picCar2 = New System.Windows.Forms.PictureBox()
        Me.picCar3 = New System.Windows.Forms.PictureBox()
        Me.picCar4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.radCar1 = New System.Windows.Forms.RadioButton()
        Me.radCar2 = New System.Windows.Forms.RadioButton()
        Me.radCar3 = New System.Windows.Forms.RadioButton()
        Me.radCar4 = New System.Windows.Forms.RadioButton()
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCar1
        '
        Me.picCar1.Image = CType(resources.GetObject("picCar1.Image"), System.Drawing.Image)
        Me.picCar1.Location = New System.Drawing.Point(12, 12)
        Me.picCar1.Name = "picCar1"
        Me.picCar1.Size = New System.Drawing.Size(150, 83)
        Me.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar1.TabIndex = 0
        Me.picCar1.TabStop = False
        '
        'picCar2
        '
        Me.picCar2.Image = CType(resources.GetObject("picCar2.Image"), System.Drawing.Image)
        Me.picCar2.Location = New System.Drawing.Point(12, 101)
        Me.picCar2.Name = "picCar2"
        Me.picCar2.Size = New System.Drawing.Size(150, 83)
        Me.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar2.TabIndex = 1
        Me.picCar2.TabStop = False
        '
        'picCar3
        '
        Me.picCar3.Image = CType(resources.GetObject("picCar3.Image"), System.Drawing.Image)
        Me.picCar3.Location = New System.Drawing.Point(12, 190)
        Me.picCar3.Name = "picCar3"
        Me.picCar3.Size = New System.Drawing.Size(150, 83)
        Me.picCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar3.TabIndex = 2
        Me.picCar3.TabStop = False
        '
        'picCar4
        '
        Me.picCar4.Image = CType(resources.GetObject("picCar4.Image"), System.Drawing.Image)
        Me.picCar4.Location = New System.Drawing.Point(12, 279)
        Me.picCar4.Name = "picCar4"
        Me.picCar4.Size = New System.Drawing.Size(150, 83)
        Me.picCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar4.TabIndex = 3
        Me.picCar4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.radCar4)
        Me.GroupBox1.Controls.Add(Me.radCar3)
        Me.GroupBox1.Controls.Add(Me.radCar2)
        Me.GroupBox1.Controls.Add(Me.radCar1)
        Me.GroupBox1.Controls.Add(Me.btnRace)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 112)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bet:"
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(44, 70)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 2
        Me.btnRace.Text = "Race!"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'radCar1
        '
        Me.radCar1.AutoSize = True
        Me.radCar1.Location = New System.Drawing.Point(231, 29)
        Me.radCar1.Name = "radCar1"
        Me.radCar1.Size = New System.Drawing.Size(79, 17)
        Me.radCar1.TabIndex = 3
        Me.radCar1.TabStop = True
        Me.radCar1.Text = "Orange Car"
        Me.radCar1.UseVisualStyleBackColor = True
        '
        'radCar2
        '
        Me.radCar2.AutoSize = True
        Me.radCar2.Location = New System.Drawing.Point(231, 52)
        Me.radCar2.Name = "radCar2"
        Me.radCar2.Size = New System.Drawing.Size(73, 17)
        Me.radCar2.TabIndex = 4
        Me.radCar2.TabStop = True
        Me.radCar2.Text = "Green Car"
        Me.radCar2.UseVisualStyleBackColor = True
        '
        'radCar3
        '
        Me.radCar3.AutoSize = True
        Me.radCar3.Location = New System.Drawing.Point(327, 29)
        Me.radCar3.Name = "radCar3"
        Me.radCar3.Size = New System.Drawing.Size(65, 17)
        Me.radCar3.TabIndex = 5
        Me.radCar3.TabStop = True
        Me.radCar3.Text = "Blue Car"
        Me.radCar3.UseVisualStyleBackColor = True
        '
        'radCar4
        '
        Me.radCar4.AutoSize = True
        Me.radCar4.Location = New System.Drawing.Point(327, 52)
        Me.radCar4.Name = "radCar4"
        Me.radCar4.Size = New System.Drawing.Size(64, 17)
        Me.radCar4.TabIndex = 6
        Me.radCar4.TabStop = True
        Me.radCar4.Text = "Red Car"
        Me.radCar4.UseVisualStyleBackColor = True
        '
        'Race_Car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 516)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picCar4)
        Me.Controls.Add(Me.picCar3)
        Me.Controls.Add(Me.picCar2)
        Me.Controls.Add(Me.picCar1)
        Me.Name = "Race_Car"
        Me.Text = "Race Car Game"
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCar1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCar4 As System.Windows.Forms.RadioButton
    Friend WithEvents radCar3 As System.Windows.Forms.RadioButton
    Friend WithEvents radCar2 As System.Windows.Forms.RadioButton
    Friend WithEvents radCar1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
