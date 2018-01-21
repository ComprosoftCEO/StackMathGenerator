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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StackMathLabel = New System.Windows.Forms.Label()
        Me.PuzzleGeneratorLabel = New System.Windows.Forms.Label()
        Me.StackListBox = New System.Windows.Forms.ListBox()
        Me.StackLabel = New System.Windows.Forms.Label()
        Me.TargetTextBox = New System.Windows.Forms.TextBox()
        Me.PuzzleGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnswerPanel = New System.Windows.Forms.Panel()
        Me.AnswersLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerListBox = New System.Windows.Forms.ListBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SolutionsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SolverButton = New System.Windows.Forms.Button()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.SeedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SetDateSeedButton = New System.Windows.Forms.Button()
        Me.PuzzleGroupBox.SuspendLayout()
        Me.AnswerPanel.SuspendLayout()
        CType(Me.StackSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMaxNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolutionsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StackMathLabel
        '
        Me.StackMathLabel.AutoSize = True
        Me.StackMathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackMathLabel.Location = New System.Drawing.Point(124, 15)
        Me.StackMathLabel.Name = "StackMathLabel"
        Me.StackMathLabel.Size = New System.Drawing.Size(177, 37)
        Me.StackMathLabel.TabIndex = 0
        Me.StackMathLabel.Text = "Stack Math"
        '
        'PuzzleGeneratorLabel
        '
        Me.PuzzleGeneratorLabel.AutoSize = True
        Me.PuzzleGeneratorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuzzleGeneratorLabel.Location = New System.Drawing.Point(150, 55)
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
        Me.StackListBox.Location = New System.Drawing.Point(11, 48)
        Me.StackListBox.Name = "StackListBox"
        Me.StackListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.StackListBox.Size = New System.Drawing.Size(156, 190)
        Me.StackListBox.TabIndex = 2
        '
        'StackLabel
        '
        Me.StackLabel.AutoSize = True
        Me.StackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackLabel.Location = New System.Drawing.Point(49, 18)
        Me.StackLabel.Name = "StackLabel"
        Me.StackLabel.Size = New System.Drawing.Size(79, 18)
        Me.StackLabel.TabIndex = 3
        Me.StackLabel.Text = "The Stack:"
        '
        'TargetTextBox
        '
        Me.TargetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetTextBox.Location = New System.Drawing.Point(234, 48)
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.ReadOnly = True
        Me.TargetTextBox.Size = New System.Drawing.Size(82, 26)
        Me.TargetTextBox.TabIndex = 4
        '
        'PuzzleGroupBox
        '
        Me.PuzzleGroupBox.Controls.Add(Me.AnswerPanel)
        Me.PuzzleGroupBox.Controls.Add(Me.AnswerCheckBox)
        Me.PuzzleGroupBox.Controls.Add(Me.TargetNumberLabel)
        Me.PuzzleGroupBox.Controls.Add(Me.StackListBox)
        Me.PuzzleGroupBox.Controls.Add(Me.StackLabel)
        Me.PuzzleGroupBox.Controls.Add(Me.TargetTextBox)
        Me.PuzzleGroupBox.Location = New System.Drawing.Point(27, 127)
        Me.PuzzleGroupBox.Name = "PuzzleGroupBox"
        Me.PuzzleGroupBox.Size = New System.Drawing.Size(371, 247)
        Me.PuzzleGroupBox.TabIndex = 5
        Me.PuzzleGroupBox.TabStop = False
        '
        'AnswerPanel
        '
        Me.AnswerPanel.Controls.Add(Me.AnswersLabel)
        Me.AnswerPanel.Controls.Add(Me.AnswerTextBox)
        Me.AnswerPanel.Controls.Add(Me.AnswerListBox)
        Me.AnswerPanel.Location = New System.Drawing.Point(193, 140)
        Me.AnswerPanel.Name = "AnswerPanel"
        Me.AnswerPanel.Size = New System.Drawing.Size(156, 100)
        Me.AnswerPanel.TabIndex = 7
        Me.AnswerPanel.Visible = False
        '
        'AnswersLabel
        '
        Me.AnswersLabel.AutoSize = True
        Me.AnswersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswersLabel.Location = New System.Drawing.Point(11, 7)
        Me.AnswersLabel.Name = "AnswersLabel"
        Me.AnswersLabel.Size = New System.Drawing.Size(69, 18)
        Me.AnswersLabel.TabIndex = 28
        Me.AnswersLabel.Text = "Answers:"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTextBox.Location = New System.Drawing.Point(91, 4)
        Me.AnswerTextBox.MaxLength = 255
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.ReadOnly = True
        Me.AnswerTextBox.Size = New System.Drawing.Size(55, 22)
        Me.AnswerTextBox.TabIndex = 27
        '
        'AnswerListBox
        '
        Me.AnswerListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerListBox.FormattingEnabled = True
        Me.AnswerListBox.ItemHeight = 20
        Me.AnswerListBox.Location = New System.Drawing.Point(11, 33)
        Me.AnswerListBox.Name = "AnswerListBox"
        Me.AnswerListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.AnswerListBox.Size = New System.Drawing.Size(135, 64)
        Me.AnswerListBox.TabIndex = 29
        '
        'AnswerCheckBox
        '
        Me.AnswerCheckBox.AutoSize = True
        Me.AnswerCheckBox.Location = New System.Drawing.Point(222, 113)
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
        Me.TargetNumberLabel.Location = New System.Drawing.Point(219, 18)
        Me.TargetNumberLabel.Name = "TargetNumberLabel"
        Me.TargetNumberLabel.Size = New System.Drawing.Size(111, 18)
        Me.TargetNumberLabel.TabIndex = 5
        Me.TargetNumberLabel.Text = "Target Number:"
        '
        'GenerateButton
        '
        Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(261, 425)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(152, 50)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "Generate New Puzzle"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeLabel.Location = New System.Drawing.Point(28, 404)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(41, 18)
        Me.SizeLabel.TabIndex = 8
        Me.SizeLabel.Text = "Size:"
        '
        'StackSizeNumericUpDown
        '
        Me.StackSizeNumericUpDown.Location = New System.Drawing.Point(89, 406)
        Me.StackSizeNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.StackSizeNumericUpDown.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.StackSizeNumericUpDown.Name = "StackSizeNumericUpDown"
        Me.StackSizeNumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.StackSizeNumericUpDown.TabIndex = 9
        Me.StackSizeNumericUpDown.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(22, 560)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(155, 25)
        Me.CopyButton.TabIndex = 10
        Me.CopyButton.Text = "Copy Puzzle to Clipboard"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeLabel.Location = New System.Drawing.Point(28, 441)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(55, 18)
        Me.RangeLabel.TabIndex = 11
        Me.RangeLabel.Text = "Range:"
        '
        'LowRangeNumericUpDown
        '
        Me.LowRangeNumericUpDown.Location = New System.Drawing.Point(89, 443)
        Me.LowRangeNumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.LowRangeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LowRangeNumericUpDown.Name = "LowRangeNumericUpDown"
        Me.LowRangeNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.LowRangeNumericUpDown.TabIndex = 12
        Me.LowRangeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HighRangeNumericUpDown
        '
        Me.HighRangeNumericUpDown.Location = New System.Drawing.Point(174, 443)
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
        Me.ToLabel.Location = New System.Drawing.Point(141, 445)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel.TabIndex = 14
        Me.ToLabel.Text = "To"
        '
        'TargetMaxLabel
        '
        Me.TargetMaxLabel.AutoSize = True
        Me.TargetMaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetMaxLabel.Location = New System.Drawing.Point(29, 477)
        Me.TargetMaxLabel.Name = "TargetMaxLabel"
        Me.TargetMaxLabel.Size = New System.Drawing.Size(54, 18)
        Me.TargetMaxLabel.TabIndex = 15
        Me.TargetMaxLabel.Text = "Target:"
        '
        'ToLabel2
        '
        Me.ToLabel2.AutoSize = True
        Me.ToLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel2.Location = New System.Drawing.Point(141, 481)
        Me.ToLabel2.Name = "ToLabel2"
        Me.ToLabel2.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel2.TabIndex = 18
        Me.ToLabel2.Text = "To"
        '
        'TargetMinNumericUpDown
        '
        Me.TargetMinNumericUpDown.Location = New System.Drawing.Point(89, 479)
        Me.TargetMinNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.TargetMinNumericUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.TargetMinNumericUpDown.Name = "TargetMinNumericUpDown"
        Me.TargetMinNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.TargetMinNumericUpDown.TabIndex = 16
        Me.TargetMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TargetMaxNumericUpDown
        '
        Me.TargetMaxNumericUpDown.Location = New System.Drawing.Point(175, 479)
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
        Me.ProgrammerLabel.Location = New System.Drawing.Point(129, 95)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(167, 26)
        Me.ProgrammerLabel.TabIndex = 20
        Me.ProgrammerLabel.Text = "Programmed by; Comprosoft_CEO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Bryan McClain)"
        Me.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 511)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Solutions:"
        '
        'SolutionsNumericUpDown
        '
        Me.SolutionsNumericUpDown.Location = New System.Drawing.Point(113, 513)
        Me.SolutionsNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.SolutionsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SolutionsNumericUpDown.Name = "SolutionsNumericUpDown"
        Me.SolutionsNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.SolutionsNumericUpDown.TabIndex = 22
        Me.SolutionsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SolverButton
        '
        Me.SolverButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolverButton.Location = New System.Drawing.Point(244, 560)
        Me.SolverButton.Name = "SolverButton"
        Me.SolverButton.Size = New System.Drawing.Size(159, 25)
        Me.SolverButton.TabIndex = 23
        Me.SolverButton.Text = "Solver"
        Me.SolverButton.UseVisualStyleBackColor = True
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLabel.ForeColor = System.Drawing.Color.Red
        Me.LoadingLabel.Location = New System.Drawing.Point(116, 377)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(193, 20)
        Me.LoadingLabel.TabIndex = 8
        Me.LoadingLabel.Text = "Loading, Please Wait..."
        Me.LoadingLabel.Visible = False
        '
        'SeedDateTimePicker
        '
        Me.SeedDateTimePicker.CustomFormat = ""
        Me.SeedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SeedDateTimePicker.Location = New System.Drawing.Point(261, 493)
        Me.SeedDateTimePicker.Name = "SeedDateTimePicker"
        Me.SeedDateTimePicker.Size = New System.Drawing.Size(96, 22)
        Me.SeedDateTimePicker.TabIndex = 25
        Me.SeedDateTimePicker.Value = New Date(2016, 6, 1, 15, 20, 0, 0)
        '
        'SetDateSeedButton
        '
        Me.SetDateSeedButton.Location = New System.Drawing.Point(363, 493)
        Me.SetDateSeedButton.Name = "SetDateSeedButton"
        Me.SetDateSeedButton.Size = New System.Drawing.Size(48, 22)
        Me.SetDateSeedButton.TabIndex = 26
        Me.SetDateSeedButton.Text = "Seed"
        Me.SetDateSeedButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.GenerateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 596)
        Me.Controls.Add(Me.SetDateSeedButton)
        Me.Controls.Add(Me.SeedDateTimePicker)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.SolverButton)
        Me.Controls.Add(Me.SolutionsNumericUpDown)
        Me.Controls.Add(Me.Label1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stack Math Puzzle Generator"
        Me.PuzzleGroupBox.ResumeLayout(False)
        Me.PuzzleGroupBox.PerformLayout()
        Me.AnswerPanel.ResumeLayout(False)
        Me.AnswerPanel.PerformLayout()
        CType(Me.StackSizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowRangeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighRangeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetMinNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetMaxNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolutionsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SolutionsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SolverButton As System.Windows.Forms.Button
    Friend WithEvents AnswerPanel As System.Windows.Forms.Panel
    Friend WithEvents AnswersLabel As System.Windows.Forms.Label
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnswerListBox As System.Windows.Forms.ListBox
    Friend WithEvents LoadingLabel As System.Windows.Forms.Label
    Friend WithEvents SeedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SetDateSeedButton As System.Windows.Forms.Button

End Class
