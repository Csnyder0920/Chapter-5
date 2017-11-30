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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalHeads = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalTails = New System.Windows.Forms.Label()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTails
        '
        Me.picTails.Image = CType(resources.GetObject("picTails.Image"), System.Drawing.Image)
        Me.picTails.Location = New System.Drawing.Point(281, 34)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(225, 224)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTails.TabIndex = 0
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = CType(resources.GetObject("picHeads.Image"), System.Drawing.Image)
        Me.picHeads.Location = New System.Drawing.Point(12, 34)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(225, 224)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHeads.TabIndex = 1
        Me.picHeads.TabStop = False
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(34, 314)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(203, 35)
        Me.btnToss.TabIndex = 2
        Me.btnToss.Text = "Toss the Coin"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(281, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Heads:"
        '
        'lblTotalHeads
        '
        Me.lblTotalHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalHeads.Location = New System.Drawing.Point(103, 379)
        Me.lblTotalHeads.Name = "lblTotalHeads"
        Me.lblTotalHeads.Size = New System.Drawing.Size(118, 27)
        Me.lblTotalHeads.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of Tails:"
        '
        'lblTotalTails
        '
        Me.lblTotalTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTails.Location = New System.Drawing.Point(352, 378)
        Me.lblTotalTails.Name = "lblTotalTails"
        Me.lblTotalTails.Size = New System.Drawing.Size(118, 26)
        Me.lblTotalTails.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 436)
        Me.Controls.Add(Me.lblTotalTails)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalHeads)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.picTails)
        Me.Name = "Form1"
        Me.Text = "Coin Flip"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalHeads As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTails As System.Windows.Forms.Label

End Class
