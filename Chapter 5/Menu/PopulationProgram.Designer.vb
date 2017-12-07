<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopulationProgram
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
        Me.cmbOrganism = New System.Windows.Forms.ComboBox()
        Me.cmbDays = New System.Windows.Forms.ComboBox()
        Me.txtIncrease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbOrganism
        '
        Me.cmbOrganism.FormattingEnabled = True
        Me.cmbOrganism.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbOrganism.Location = New System.Drawing.Point(34, 74)
        Me.cmbOrganism.Name = "cmbOrganism"
        Me.cmbOrganism.Size = New System.Drawing.Size(121, 28)
        Me.cmbOrganism.TabIndex = 0
        '
        'cmbDays
        '
        Me.cmbDays.FormattingEnabled = True
        Me.cmbDays.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "10", "15", "20", "25", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbDays.Location = New System.Drawing.Point(384, 74)
        Me.cmbDays.Name = "cmbDays"
        Me.cmbDays.Size = New System.Drawing.Size(121, 28)
        Me.cmbDays.TabIndex = 1
        '
        'txtIncrease
        '
        Me.txtIncrease.Location = New System.Drawing.Point(225, 74)
        Me.txtIncrease.Name = "txtIncrease"
        Me.txtIncrease.Size = New System.Drawing.Size(100, 26)
        Me.txtIncrease.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starting Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Organisms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Days" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Multiply"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 202)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 60)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Average Daily" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Increase"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(209, 202)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 60)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 60)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(34, 141)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(471, 33)
        Me.lblResults.TabIndex = 9
        '
        'PopulationProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 365)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIncrease)
        Me.Controls.Add(Me.cmbDays)
        Me.Controls.Add(Me.cmbOrganism)
        Me.Name = "PopulationProgram"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbOrganism As ComboBox
    Friend WithEvents cmbDays As ComboBox
    Friend WithEvents txtIncrease As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResults As Label
End Class
