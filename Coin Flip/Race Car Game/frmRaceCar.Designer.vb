﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRaceCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRaceCar))
        Me.picCar1 = New System.Windows.Forms.PictureBox()
        Me.picCar2 = New System.Windows.Forms.PictureBox()
        Me.picCar3 = New System.Windows.Forms.PictureBox()
        Me.picCar4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRedWins = New System.Windows.Forms.Label()
        Me.lblBlueWins = New System.Windows.Forms.Label()
        Me.lblGreenWins = New System.Windows.Forms.Label()
        Me.lblOrangeWins = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRace = New System.Windows.Forms.Button()
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCar1
        '
        Me.picCar1.Image = CType(resources.GetObject("picCar1.Image"), System.Drawing.Image)
        Me.picCar1.Location = New System.Drawing.Point(18, 18)
        Me.picCar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCar1.Name = "picCar1"
        Me.picCar1.Size = New System.Drawing.Size(225, 128)
        Me.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar1.TabIndex = 0
        Me.picCar1.TabStop = False
        '
        'picCar2
        '
        Me.picCar2.Image = CType(resources.GetObject("picCar2.Image"), System.Drawing.Image)
        Me.picCar2.Location = New System.Drawing.Point(18, 155)
        Me.picCar2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCar2.Name = "picCar2"
        Me.picCar2.Size = New System.Drawing.Size(225, 128)
        Me.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar2.TabIndex = 1
        Me.picCar2.TabStop = False
        '
        'picCar3
        '
        Me.picCar3.Image = CType(resources.GetObject("picCar3.Image"), System.Drawing.Image)
        Me.picCar3.Location = New System.Drawing.Point(18, 292)
        Me.picCar3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCar3.Name = "picCar3"
        Me.picCar3.Size = New System.Drawing.Size(225, 128)
        Me.picCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar3.TabIndex = 2
        Me.picCar3.TabStop = False
        '
        'picCar4
        '
        Me.picCar4.Image = CType(resources.GetObject("picCar4.Image"), System.Drawing.Image)
        Me.picCar4.Location = New System.Drawing.Point(18, 429)
        Me.picCar4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCar4.Name = "picCar4"
        Me.picCar4.Size = New System.Drawing.Size(225, 128)
        Me.picCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar4.TabIndex = 3
        Me.picCar4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnRace)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 603)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(657, 172)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRedWins)
        Me.GroupBox2.Controls.Add(Me.lblBlueWins)
        Me.GroupBox2.Controls.Add(Me.lblGreenWins)
        Me.GroupBox2.Controls.Add(Me.lblOrangeWins)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 137)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Wins "
        '
        'lblRedWins
        '
        Me.lblRedWins.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRedWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRedWins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRedWins.Location = New System.Drawing.Point(226, 88)
        Me.lblRedWins.Name = "lblRedWins"
        Me.lblRedWins.Size = New System.Drawing.Size(75, 23)
        Me.lblRedWins.TabIndex = 7
        '
        'lblBlueWins
        '
        Me.lblBlueWins.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblBlueWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBlueWins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBlueWins.Location = New System.Drawing.Point(228, 38)
        Me.lblBlueWins.Name = "lblBlueWins"
        Me.lblBlueWins.Size = New System.Drawing.Size(75, 23)
        Me.lblBlueWins.TabIndex = 6
        '
        'lblGreenWins
        '
        Me.lblGreenWins.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblGreenWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreenWins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGreenWins.Location = New System.Drawing.Point(78, 92)
        Me.lblGreenWins.Name = "lblGreenWins"
        Me.lblGreenWins.Size = New System.Drawing.Size(75, 23)
        Me.lblGreenWins.TabIndex = 5
        '
        'lblOrangeWins
        '
        Me.lblOrangeWins.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblOrangeWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrangeWins.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrangeWins.Location = New System.Drawing.Point(78, 38)
        Me.lblOrangeWins.Name = "lblOrangeWins"
        Me.lblOrangeWins.Size = New System.Drawing.Size(75, 23)
        Me.lblOrangeWins.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Red:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Blue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Green:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Orange:"
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(60, 28)
        Me.btnRace.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(112, 35)
        Me.btnRace.TabIndex = 2
        Me.btnRace.Text = "Race!"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'frmRaceCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1198, 803)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picCar4)
        Me.Controls.Add(Me.picCar3)
        Me.Controls.Add(Me.picCar2)
        Me.Controls.Add(Me.picCar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmRaceCar"
        Me.Text = "Race Car Game"
        CType(Me.picCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCar1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCar4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblRedWins As Label
    Friend WithEvents lblBlueWins As Label
    Friend WithEvents lblGreenWins As Label
    Friend WithEvents lblOrangeWins As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
