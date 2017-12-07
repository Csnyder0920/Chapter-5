<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.btnCoinFlip = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRockPaperScissors = New System.Windows.Forms.Button()
        Me.btnRaceCar = New System.Windows.Forms.Button()
        Me.btnSumOfNumbers = New System.Windows.Forms.Button()
        Me.btnDistanceCalculator = New System.Windows.Forms.Button()
        Me.btnPopulationProgram = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTestScoreAverage = New System.Windows.Forms.Button()
        Me.btnRunningTotal = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCoinFlip
        '
        Me.btnCoinFlip.Location = New System.Drawing.Point(124, 51)
        Me.btnCoinFlip.Name = "btnCoinFlip"
        Me.btnCoinFlip.Size = New System.Drawing.Size(75, 44)
        Me.btnCoinFlip.TabIndex = 0
        Me.btnCoinFlip.Text = "Coin Flip"
        Me.btnCoinFlip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRockPaperScissors
        '
        Me.btnRockPaperScissors.Location = New System.Drawing.Point(124, 101)
        Me.btnRockPaperScissors.Name = "btnRockPaperScissors"
        Me.btnRockPaperScissors.Size = New System.Drawing.Size(75, 44)
        Me.btnRockPaperScissors.TabIndex = 2
        Me.btnRockPaperScissors.Text = "Rock Paper Scissors"
        Me.btnRockPaperScissors.UseVisualStyleBackColor = True
        '
        'btnRaceCar
        '
        Me.btnRaceCar.Location = New System.Drawing.Point(124, 151)
        Me.btnRaceCar.Name = "btnRaceCar"
        Me.btnRaceCar.Size = New System.Drawing.Size(75, 44)
        Me.btnRaceCar.TabIndex = 3
        Me.btnRaceCar.Text = "Race Car"
        Me.btnRaceCar.UseVisualStyleBackColor = True
        '
        'btnSumOfNumbers
        '
        Me.btnSumOfNumbers.Location = New System.Drawing.Point(96, 201)
        Me.btnSumOfNumbers.Name = "btnSumOfNumbers"
        Me.btnSumOfNumbers.Size = New System.Drawing.Size(133, 23)
        Me.btnSumOfNumbers.TabIndex = 4
        Me.btnSumOfNumbers.Text = "Sum of Numbers"
        Me.btnSumOfNumbers.UseVisualStyleBackColor = True
        '
        'btnDistanceCalculator
        '
        Me.btnDistanceCalculator.Location = New System.Drawing.Point(96, 230)
        Me.btnDistanceCalculator.Name = "btnDistanceCalculator"
        Me.btnDistanceCalculator.Size = New System.Drawing.Size(133, 22)
        Me.btnDistanceCalculator.TabIndex = 5
        Me.btnDistanceCalculator.Text = "Distance Calculator"
        Me.btnDistanceCalculator.UseVisualStyleBackColor = True
        '
        'btnPopulationProgram
        '
        Me.btnPopulationProgram.Location = New System.Drawing.Point(96, 257)
        Me.btnPopulationProgram.Name = "btnPopulationProgram"
        Me.btnPopulationProgram.Size = New System.Drawing.Size(133, 22)
        Me.btnPopulationProgram.TabIndex = 6
        Me.btnPopulationProgram.Text = "Population Program"
        Me.btnPopulationProgram.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnTestScoreAverage
        '
        Me.btnTestScoreAverage.Location = New System.Drawing.Point(96, 342)
        Me.btnTestScoreAverage.Name = "btnTestScoreAverage"
        Me.btnTestScoreAverage.Size = New System.Drawing.Size(133, 22)
        Me.btnTestScoreAverage.TabIndex = 8
        Me.btnTestScoreAverage.Text = "Test Score Average"
        Me.btnTestScoreAverage.UseVisualStyleBackColor = True
        '
        'btnRunningTotal
        '
        Me.btnRunningTotal.Location = New System.Drawing.Point(96, 314)
        Me.btnRunningTotal.Name = "btnRunningTotal"
        Me.btnRunningTotal.Size = New System.Drawing.Size(133, 22)
        Me.btnRunningTotal.TabIndex = 9
        Me.btnRunningTotal.Text = "Running Total"
        Me.btnRunningTotal.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(125, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 22)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 417)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRunningTotal)
        Me.Controls.Add(Me.btnTestScoreAverage)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPopulationProgram)
        Me.Controls.Add(Me.btnDistanceCalculator)
        Me.Controls.Add(Me.btnSumOfNumbers)
        Me.Controls.Add(Me.btnRaceCar)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCoinFlip)
        Me.Name = "Menu1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCoinFlip As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
    Friend WithEvents btnRaceCar As System.Windows.Forms.Button
    Friend WithEvents btnSumOfNumbers As System.Windows.Forms.Button
    Friend WithEvents btnDistanceCalculator As System.Windows.Forms.Button
    Friend WithEvents btnPopulationProgram As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnTestScoreAverage As System.Windows.Forms.Button
    Friend WithEvents btnRunningTotal As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
