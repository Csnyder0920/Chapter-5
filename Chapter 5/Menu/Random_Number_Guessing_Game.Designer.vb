<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Number_Guessing_Game
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number 1-100:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(221, 54)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(83, 159)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(109, 46)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(221, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 46)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(152, 211)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(109, 46)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New Game"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number of Wins:"
        '
        'lblWins
        '
        Me.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWins.Location = New System.Drawing.Point(221, 108)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(43, 23)
        Me.lblWins.TabIndex = 6
        '
        'Random_Number_Guessing_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 272)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Random_Number_Guessing_Game"
        Me.Text = "RandomNumberGuessingGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWins As System.Windows.Forms.Label
End Class
