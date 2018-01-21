<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.StackMathLabel = New System.Windows.Forms.Label()
        Me.PuzzleGeneratorLabel = New System.Windows.Forms.Label()
        Me.StackListBox = New System.Windows.Forms.ListBox()
        Me.StackLabel = New System.Windows.Forms.Label()
        Me.TargetTextBox = New System.Windows.Forms.TextBox()
        Me.PuzzleGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerCheckBox = New System.Windows.Forms.CheckBox()
        Me.TargetNumberLabel = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.StackSizeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.RangeLabel = New System.Windows.Forms.Label()
        Me.LowRangeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HighRangeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.TargetMaxLabel = New System.Windows.Forms.Label()
        Me.ToLabel2 = New System.Windows.Forms.Label()
        Me.TargetMinNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TargetMaxNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PuzzleGroupBox.SuspendLayout()
        CType(Me.StackSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMaxNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StackMathLabel
        '
        Me.StackMathLabel.AutoSize = True
        Me.StackMathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackMathLabel.Location = New System.Drawing.Point(105, 15)
        Me.StackMathLabel.Name = "StackMathLabel"
        Me.StackMathLabel.Size = New System.Drawing.Size(177, 37)
        Me.StackMathLabel.TabIndex = 0
        Me.StackMathLabel.Text = "Stack Math"
        '
        'PuzzleGeneratorLabel
        '
        Me.PuzzleGeneratorLabel.AutoSize = True
        Me.PuzzleGeneratorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuzzleGeneratorLabel.Location = New System.Drawing.Point(131, 55)
        Me.PuzzleGeneratorLabel.Name = "PuzzleGeneratorLabel"
        Me.PuzzleGeneratorLabel.Size = New System.Drawing.Size(124, 18)
        Me.PuzzleGeneratorLabel.TabIndex = 1
        Me.PuzzleGeneratorLabel.Text = "Puzzle Generator"
        '
        'StackListBox
        '
        Me.StackListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackListBox.FormattingEnabled = True
        Me.StackListBox.ItemHeight = 31
        Me.StackListBox.Location = New System.Drawing.Point(11, 58)
        Me.StackListBox.Name = "StackListBox"
        Me.StackListBox.Size = New System.Drawing.Size(156, 159)
        Me.StackListBox.TabIndex = 2
        '
        'StackLabel
        '
        Me.StackLabel.AutoSize = True
        Me.StackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackLabel.Location = New System.Drawing.Point(49, 28)
        Me.StackLabel.Name = "StackLabel"
        Me.StackLabel.Size = New System.Drawing.Size(79, 18)
        Me.StackLabel.TabIndex = 3
        Me.StackLabel.Text = "The Stack:"
        '
        'TargetTextBox
        '
        Me.TargetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetTextBox.Location = New System.Drawing.Point(216, 58)
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.ReadOnly = True
        Me.TargetTextBox.Size = New System.Drawing.Size(82, 26)
        Me.TargetTextBox.TabIndex = 4
        '
        'PuzzleGroupBox
        '
        Me.PuzzleGroupBox.Controls.Add(Me.AnswerTextBox)
        Me.PuzzleGroupBox.Controls.Add(Me.AnswerCheckBox)
        Me.PuzzleGroupBox.Controls.Add(Me.TargetNumberLabel)
        Me.PuzzleGroupBox.Controls.Add(Me.StackListBox)
        Me.PuzzleGroupBox.Controls.Add(Me.StackLabel)
        Me.PuzzleGroupBox.Controls.Add(Me.TargetTextBox)
        Me.PuzzleGroupBox.Location = New System.Drawing.Point(26, 127)
        Me.PuzzleGroupBox.Name = "PuzzleGroupBox"
        Me.PuzzleGroupBox.Size = New System.Drawing.Size(334, 230)
        Me.PuzzleGroupBox.TabIndex = 5
        Me.PuzzleGroupBox.TabStop = False
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.Location = New System.Drawing.Point(216, 180)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.ReadOnly = True
        Me.AnswerTextBox.Size = New System.Drawing.Size(82, 26)
        Me.AnswerTextBox.TabIndex = 7
        Me.AnswerTextBox.Visible = False
        '
        'AnswerCheckBox
        '
        Me.AnswerCheckBox.AutoSize = True
        Me.AnswerCheckBox.Location = New System.Drawing.Point(210, 148)
        Me.AnswerCheckBox.Name = "AnswerCheckBox"
        Me.AnswerCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.AnswerCheckBox.TabIndex = 6
        Me.AnswerCheckBox.Text = "Show Answer:"
        Me.AnswerCheckBox.UseVisualStyleBackColor = True
        '
        'TargetNumberLabel
        '
        Me.TargetNumberLabel.AutoSize = True
        Me.TargetNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetNumberLabel.Location = New System.Drawing.Point(201, 28)
        Me.TargetNumberLabel.Name = "TargetNumberLabel"
        Me.TargetNumberLabel.Size = New System.Drawing.Size(111, 18)
        Me.TargetNumberLabel.TabIndex = 5
        Me.TargetNumberLabel.Text = "Target Number:"
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(241, 401)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(134, 50)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "Generate New Puzzle"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeLabel.Location = New System.Drawing.Point(28, 378)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(41, 18)
        Me.SizeLabel.TabIndex = 8
        Me.SizeLabel.Text = "Size:"
        '
        'StackSizeNumericUpDown
        '
        Me.StackSizeNumericUpDown.Location = New System.Drawing.Point(89, 380)
        Me.StackSizeNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.StackSizeNumericUpDown.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.StackSizeNumericUpDown.Name = "StackSizeNumericUpDown"
        Me.StackSizeNumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.StackSizeNumericUpDown.TabIndex = 9
        Me.StackSizeNumericUpDown.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(125, 508)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(136, 25)
        Me.CopyButton.TabIndex = 10
        Me.CopyButton.Text = "Copy Puzzle to Clipboard"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeLabel.Location = New System.Drawing.Point(28, 415)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(55, 18)
        Me.RangeLabel.TabIndex = 11
        Me.RangeLabel.Text = "Range:"
        '
        'LowRangeNumericUpDown
        '
        Me.LowRangeNumericUpDown.Location = New System.Drawing.Point(89, 417)
        Me.LowRangeNumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.LowRangeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LowRangeNumericUpDown.Name = "LowRangeNumericUpDown"
        Me.LowRangeNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.LowRangeNumericUpDown.TabIndex = 12
        Me.LowRangeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HighRangeNumericUpDown
        '
        Me.HighRangeNumericUpDown.Location = New System.Drawing.Point(174, 417)
        Me.HighRangeNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.HighRangeNumericUpDown.Name = "HighRangeNumericUpDown"
        Me.HighRangeNumericUpDown.Size = New System.Drawing.Size(47, 20)
        Me.HighRangeNumericUpDown.TabIndex = 13
        Me.HighRangeNumericUpDown.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel.Location = New System.Drawing.Point(141, 419)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel.TabIndex = 14
        Me.ToLabel.Text = "To"
        '
        'TargetMaxLabel
        '
        Me.TargetMaxLabel.AutoSize = True
        Me.TargetMaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetMaxLabel.Location = New System.Drawing.Point(29, 451)
        Me.TargetMaxLabel.Name = "TargetMaxLabel"
        Me.TargetMaxLabel.Size = New System.Drawing.Size(54, 18)
        Me.TargetMaxLabel.TabIndex = 15
        Me.TargetMaxLabel.Text = "Target:"
        '
        'ToLabel2
        '
        Me.ToLabel2.AutoSize = True
        Me.ToLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel2.Location = New System.Drawing.Point(141, 455)
        Me.ToLabel2.Name = "ToLabel2"
        Me.ToLabel2.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel2.TabIndex = 18
        Me.ToLabel2.Text = "To"
        '
        'TargetMinNumericUpDown
        '
        Me.TargetMinNumericUpDown.Location = New System.Drawing.Point(89, 453)
        Me.TargetMinNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.TargetMinNumericUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.TargetMinNumericUpDown.Name = "TargetMinNumericUpDown"
        Me.TargetMinNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.TargetMinNumericUpDown.TabIndex = 16
        Me.TargetMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TargetMaxNumericUpDown
        '
        Me.TargetMaxNumericUpDown.Location = New System.Drawing.Point(175, 453)
        Me.TargetMaxNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.TargetMaxNumericUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.TargetMaxNumericUpDown.Name = "TargetMaxNumericUpDown"
        Me.TargetMaxNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.TargetMaxNumericUpDown.TabIndex = 19
        Me.TargetMaxNumericUpDown.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(110, 95)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(167, 26)
        Me.ProgrammerLabel.TabIndex = 20
        Me.ProgrammerLabel.Text = "Programmed by; Comprosoft_CEO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Bryan McClain)"
        Me.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainForm
        '
        Me.AcceptButton = Me.GenerateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 561)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.TargetMaxNumericUpDown)
        Me.Controls.Add(Me.ToLabel2)
        Me.Controls.Add(Me.TargetMinNumericUpDown)
        Me.Controls.Add(Me.TargetMaxLabel)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.HighRangeNumericUpDown)
        Me.Controls.Add(Me.LowRangeNumericUpDown)
        Me.Controls.Add(Me.RangeLabel)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.StackSizeNumericUpDown)
        Me.Controls.Add(Me.SizeLabel)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.PuzzleGroupBox)
        Me.Controls.Add(Me.PuzzleGeneratorLabel)
        Me.Controls.Add(Me.StackMathLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stack Math Puzzle Generator"
        Me.PuzzleGroupBox.ResumeLayout(False)
        Me.PuzzleGroupBox.PerformLayout()
        CType(Me.StackSizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowRangeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighRangeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetMinNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetMaxNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StackMathLabel As System.Windows.Forms.Label
    Friend WithEvents PuzzleGeneratorLabel As System.Windows.Forms.Label
    Friend WithEvents StackListBox As System.Windows.Forms.ListBox
    Friend WithEvents StackLabel As System.Windows.Forms.Label
    Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PuzzleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TargetNumberLabel As System.Windows.Forms.Label
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnswerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents SizeLabel As System.Windows.Forms.Label
    Friend WithEvents StackSizeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents RangeLabel As System.Windows.Forms.Label
    Friend WithEvents LowRangeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents HighRangeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToLabel As System.Windows.Forms.Label
    Friend WithEvents TargetMaxLabel As System.Windows.Forms.Label
    Friend WithEvents ToLabel2 As System.Windows.Forms.Label
    Friend WithEvents TargetMinNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TargetMaxNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label

End Class
