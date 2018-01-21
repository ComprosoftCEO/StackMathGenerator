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
        Me.SolutionsLabel = New System.Windows.Forms.Label()
        Me.SolutionsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SolverButton = New System.Windows.Forms.Button()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.SeedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SetDateSeedButton = New System.Windows.Forms.Button()
        Me.ChooseTargetCheckBox = New System.Windows.Forms.CheckBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.CustomStackPanel = New System.Windows.Forms.Panel()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MoveDownButton = New System.Windows.Forms.Button()
        Me.AddStackNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MoveUpButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.RandomStackPanel = New System.Windows.Forms.Panel()
        Me.AdvancedPanel = New System.Windows.Forms.Panel()
        Me.StackModeComboBox = New System.Windows.Forms.ComboBox()
        Me.BasicModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdvancedModeRadioButton = New System.Windows.Forms.RadioButton()
        Me.DifficultyLabel = New System.Windows.Forms.Label()
        Me.DifficultyComboBox = New System.Windows.Forms.ComboBox()
        Me.PuzzleGroupBox.SuspendLayout()
        Me.AnswerPanel.SuspendLayout()
        CType(Me.StackSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighRangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetMaxNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolutionsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomStackPanel.SuspendLayout()
        CType(Me.AddStackNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RandomStackPanel.SuspendLayout()
        Me.AdvancedPanel.SuspendLayout()
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
        Me.SizeLabel.Location = New System.Drawing.Point(7, 6)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(41, 18)
        Me.SizeLabel.TabIndex = 8
        Me.SizeLabel.Text = "Size:"
        '
        'StackSizeNumericUpDown
        '
        Me.StackSizeNumericUpDown.Location = New System.Drawing.Point(68, 6)
        Me.StackSizeNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.StackSizeNumericUpDown.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.StackSizeNumericUpDown.Name = "StackSizeNumericUpDown"
        Me.StackSizeNumericUpDown.Size = New System.Drawing.Size(65, 20)
        Me.StackSizeNumericUpDown.TabIndex = 9
        Me.StackSizeNumericUpDown.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(172, 598)
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
        Me.RangeLabel.Location = New System.Drawing.Point(7, 40)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(55, 18)
        Me.RangeLabel.TabIndex = 11
        Me.RangeLabel.Text = "Range:"
        '
        'LowRangeNumericUpDown
        '
        Me.LowRangeNumericUpDown.Location = New System.Drawing.Point(68, 40)
        Me.LowRangeNumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.LowRangeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LowRangeNumericUpDown.Name = "LowRangeNumericUpDown"
        Me.LowRangeNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.LowRangeNumericUpDown.TabIndex = 12
        Me.LowRangeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HighRangeNumericUpDown
        '
        Me.HighRangeNumericUpDown.Location = New System.Drawing.Point(153, 40)
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
        Me.ToLabel.Location = New System.Drawing.Point(120, 41)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel.TabIndex = 14
        Me.ToLabel.Text = "To"
        '
        'TargetMaxLabel
        '
        Me.TargetMaxLabel.AutoSize = True
        Me.TargetMaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetMaxLabel.Location = New System.Drawing.Point(4, 108)
        Me.TargetMaxLabel.Name = "TargetMaxLabel"
        Me.TargetMaxLabel.Size = New System.Drawing.Size(54, 18)
        Me.TargetMaxLabel.TabIndex = 15
        Me.TargetMaxLabel.Text = "Target:"
        '
        'ToLabel2
        '
        Me.ToLabel2.AutoSize = True
        Me.ToLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel2.Location = New System.Drawing.Point(116, 109)
        Me.ToLabel2.Name = "ToLabel2"
        Me.ToLabel2.Size = New System.Drawing.Size(26, 18)
        Me.ToLabel2.TabIndex = 18
        Me.ToLabel2.Text = "To"
        '
        'TargetMinNumericUpDown
        '
        Me.TargetMinNumericUpDown.Location = New System.Drawing.Point(64, 108)
        Me.TargetMinNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.TargetMinNumericUpDown.Minimum = New Decimal(New Integer() {100000000, 0, 0, -2147483648})
        Me.TargetMinNumericUpDown.Name = "TargetMinNumericUpDown"
        Me.TargetMinNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.TargetMinNumericUpDown.TabIndex = 16
        Me.TargetMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TargetMaxNumericUpDown
        '
        Me.TargetMaxNumericUpDown.Location = New System.Drawing.Point(150, 109)
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
        'SolutionsLabel
        '
        Me.SolutionsLabel.AutoSize = True
        Me.SolutionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolutionsLabel.Location = New System.Drawing.Point(4, 142)
        Me.SolutionsLabel.Name = "SolutionsLabel"
        Me.SolutionsLabel.Size = New System.Drawing.Size(74, 18)
        Me.SolutionsLabel.TabIndex = 21
        Me.SolutionsLabel.Text = "Solutions:"
        '
        'SolutionsNumericUpDown
        '
        Me.SolutionsNumericUpDown.Location = New System.Drawing.Point(88, 144)
        Me.SolutionsNumericUpDown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.SolutionsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SolutionsNumericUpDown.Name = "SolutionsNumericUpDown"
        Me.SolutionsNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.SolutionsNumericUpDown.TabIndex = 22
        Me.SolutionsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SolverButton
        '
        Me.SolverButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolverButton.Location = New System.Drawing.Point(261, 546)
        Me.SolverButton.Name = "SolverButton"
        Me.SolverButton.Size = New System.Drawing.Size(152, 33)
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
        Me.SeedDateTimePicker.Location = New System.Drawing.Point(261, 482)
        Me.SeedDateTimePicker.Name = "SeedDateTimePicker"
        Me.SeedDateTimePicker.Size = New System.Drawing.Size(96, 22)
        Me.SeedDateTimePicker.TabIndex = 25
        Me.SeedDateTimePicker.Value = New Date(2016, 6, 1, 15, 20, 0, 0)
        '
        'SetDateSeedButton
        '
        Me.SetDateSeedButton.Location = New System.Drawing.Point(363, 482)
        Me.SetDateSeedButton.Name = "SetDateSeedButton"
        Me.SetDateSeedButton.Size = New System.Drawing.Size(48, 22)
        Me.SetDateSeedButton.TabIndex = 26
        Me.SetDateSeedButton.Text = "Seed"
        Me.SetDateSeedButton.UseVisualStyleBackColor = True
        '
        'ChooseTargetCheckBox
        '
        Me.ChooseTargetCheckBox.AutoSize = True
        Me.ChooseTargetCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseTargetCheckBox.Location = New System.Drawing.Point(6, 175)
        Me.ChooseTargetCheckBox.Name = "ChooseTargetCheckBox"
        Me.ChooseTargetCheckBox.Size = New System.Drawing.Size(117, 20)
        Me.ChooseTargetCheckBox.TabIndex = 27
        Me.ChooseTargetCheckBox.Text = "Choose Target"
        Me.ChooseTargetCheckBox.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.Location = New System.Drawing.Point(366, 619)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(60, 13)
        Me.VersionLabel.TabIndex = 28
        Me.VersionLabel.Text = "Version 2.3"
        '
        'CustomStackPanel
        '
        Me.CustomStackPanel.Controls.Add(Me.ClearButton)
        Me.CustomStackPanel.Controls.Add(Me.UpdateButton)
        Me.CustomStackPanel.Controls.Add(Me.AddButton)
        Me.CustomStackPanel.Controls.Add(Me.MoveDownButton)
        Me.CustomStackPanel.Controls.Add(Me.AddStackNumericUpDown)
        Me.CustomStackPanel.Controls.Add(Me.MoveUpButton)
        Me.CustomStackPanel.Controls.Add(Me.RemoveButton)
        Me.CustomStackPanel.Location = New System.Drawing.Point(3, 32)
        Me.CustomStackPanel.Name = "CustomStackPanel"
        Me.CustomStackPanel.Size = New System.Drawing.Size(206, 78)
        Me.CustomStackPanel.TabIndex = 29
        Me.CustomStackPanel.Visible = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(160, 6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(50, 57)
        Me.ClearButton.TabIndex = 36
        Me.ClearButton.Text = "Clear Stack"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(104, 38)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(54, 26)
        Me.UpdateButton.TabIndex = 35
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(3, 39)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(41, 26)
        Me.AddButton.TabIndex = 30
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MoveDownButton
        '
        Me.MoveDownButton.Location = New System.Drawing.Point(127, 7)
        Me.MoveDownButton.Name = "MoveDownButton"
        Me.MoveDownButton.Size = New System.Drawing.Size(31, 26)
        Me.MoveDownButton.TabIndex = 34
        Me.MoveDownButton.Text = "▼"
        Me.MoveDownButton.UseVisualStyleBackColor = True
        '
        'AddStackNumericUpDown
        '
        Me.AddStackNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStackNumericUpDown.Location = New System.Drawing.Point(48, 39)
        Me.AddStackNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AddStackNumericUpDown.Name = "AddStackNumericUpDown"
        Me.AddStackNumericUpDown.Size = New System.Drawing.Size(51, 24)
        Me.AddStackNumericUpDown.TabIndex = 31
        Me.AddStackNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MoveUpButton
        '
        Me.MoveUpButton.Location = New System.Drawing.Point(3, 7)
        Me.MoveUpButton.Name = "MoveUpButton"
        Me.MoveUpButton.Size = New System.Drawing.Size(31, 26)
        Me.MoveUpButton.TabIndex = 33
        Me.MoveUpButton.Text = "▲"
        Me.MoveUpButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(47, 7)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(67, 26)
        Me.RemoveButton.TabIndex = 32
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'RandomStackPanel
        '
        Me.RandomStackPanel.Controls.Add(Me.SizeLabel)
        Me.RandomStackPanel.Controls.Add(Me.StackSizeNumericUpDown)
        Me.RandomStackPanel.Controls.Add(Me.RangeLabel)
        Me.RandomStackPanel.Controls.Add(Me.LowRangeNumericUpDown)
        Me.RandomStackPanel.Controls.Add(Me.HighRangeNumericUpDown)
        Me.RandomStackPanel.Controls.Add(Me.ToLabel)
        Me.RandomStackPanel.Location = New System.Drawing.Point(-4, 35)
        Me.RandomStackPanel.Name = "RandomStackPanel"
        Me.RandomStackPanel.Size = New System.Drawing.Size(205, 73)
        Me.RandomStackPanel.TabIndex = 30
        '
        'AdvancedPanel
        '
        Me.AdvancedPanel.Controls.Add(Me.StackModeComboBox)
        Me.AdvancedPanel.Controls.Add(Me.TargetMaxLabel)
        Me.AdvancedPanel.Controls.Add(Me.TargetMinNumericUpDown)
        Me.AdvancedPanel.Controls.Add(Me.ToLabel2)
        Me.AdvancedPanel.Controls.Add(Me.TargetMaxNumericUpDown)
        Me.AdvancedPanel.Controls.Add(Me.ChooseTargetCheckBox)
        Me.AdvancedPanel.Controls.Add(Me.SolutionsLabel)
        Me.AdvancedPanel.Controls.Add(Me.SolutionsNumericUpDown)
        Me.AdvancedPanel.Controls.Add(Me.RandomStackPanel)
        Me.AdvancedPanel.Controls.Add(Me.CustomStackPanel)
        Me.AdvancedPanel.Location = New System.Drawing.Point(17, 425)
        Me.AdvancedPanel.Name = "AdvancedPanel"
        Me.AdvancedPanel.Size = New System.Drawing.Size(214, 207)
        Me.AdvancedPanel.TabIndex = 31
        Me.AdvancedPanel.Visible = False
        '
        'StackModeComboBox
        '
        Me.StackModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StackModeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackModeComboBox.FormattingEnabled = True
        Me.StackModeComboBox.Items.AddRange(New Object() {"Random Stack", "Custom Stack"})
        Me.StackModeComboBox.Location = New System.Drawing.Point(38, 3)
        Me.StackModeComboBox.Name = "StackModeComboBox"
        Me.StackModeComboBox.Size = New System.Drawing.Size(150, 26)
        Me.StackModeComboBox.TabIndex = 28
        '
        'BasicModeRadioButton
        '
        Me.BasicModeRadioButton.AutoSize = True
        Me.BasicModeRadioButton.Checked = True
        Me.BasicModeRadioButton.Location = New System.Drawing.Point(23, 404)
        Me.BasicModeRadioButton.Name = "BasicModeRadioButton"
        Me.BasicModeRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.BasicModeRadioButton.TabIndex = 32
        Me.BasicModeRadioButton.TabStop = True
        Me.BasicModeRadioButton.Text = "Basic Mode"
        Me.BasicModeRadioButton.UseVisualStyleBackColor = True
        '
        'AdvancedModeRadioButton
        '
        Me.AdvancedModeRadioButton.AutoSize = True
        Me.AdvancedModeRadioButton.Location = New System.Drawing.Point(129, 404)
        Me.AdvancedModeRadioButton.Name = "AdvancedModeRadioButton"
        Me.AdvancedModeRadioButton.Size = New System.Drawing.Size(104, 17)
        Me.AdvancedModeRadioButton.TabIndex = 33
        Me.AdvancedModeRadioButton.Text = "Advanced Mode"
        Me.AdvancedModeRadioButton.UseVisualStyleBackColor = True
        '
        'DifficultyLabel
        '
        Me.DifficultyLabel.AutoSize = True
        Me.DifficultyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifficultyLabel.Location = New System.Drawing.Point(72, 484)
        Me.DifficultyLabel.Name = "DifficultyLabel"
        Me.DifficultyLabel.Size = New System.Drawing.Size(82, 24)
        Me.DifficultyLabel.TabIndex = 31
        Me.DifficultyLabel.Text = "Difficulty:"
        '
        'DifficultyComboBox
        '
        Me.DifficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DifficultyComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifficultyComboBox.FormattingEnabled = True
        Me.DifficultyComboBox.Items.AddRange(New Object() {"Easy", "Normal", "Intermediate", "Advanced", "Expert"})
        Me.DifficultyComboBox.Location = New System.Drawing.Point(34, 518)
        Me.DifficultyComboBox.Name = "DifficultyComboBox"
        Me.DifficultyComboBox.Size = New System.Drawing.Size(157, 33)
        Me.DifficultyComboBox.TabIndex = 34
        '
        'MainForm
        '
        Me.AcceptButton = Me.GenerateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 632)
        Me.Controls.Add(Me.DifficultyComboBox)
        Me.Controls.Add(Me.DifficultyLabel)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.AdvancedModeRadioButton)
        Me.Controls.Add(Me.BasicModeRadioButton)
        Me.Controls.Add(Me.AdvancedPanel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SetDateSeedButton)
        Me.Controls.Add(Me.SeedDateTimePicker)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.SolverButton)
        Me.Controls.Add(Me.ProgrammerLabel)
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
        Me.CustomStackPanel.ResumeLayout(False)
        CType(Me.AddStackNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RandomStackPanel.ResumeLayout(False)
        Me.RandomStackPanel.PerformLayout()
        Me.AdvancedPanel.ResumeLayout(False)
        Me.AdvancedPanel.PerformLayout()
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
    Friend WithEvents SolutionsLabel As System.Windows.Forms.Label
    Friend WithEvents SolutionsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SolverButton As System.Windows.Forms.Button
    Friend WithEvents AnswerPanel As System.Windows.Forms.Panel
    Friend WithEvents AnswersLabel As System.Windows.Forms.Label
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnswerListBox As System.Windows.Forms.ListBox
    Friend WithEvents LoadingLabel As System.Windows.Forms.Label
    Friend WithEvents SeedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SetDateSeedButton As System.Windows.Forms.Button
    Friend WithEvents ChooseTargetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents CustomStackPanel As System.Windows.Forms.Panel
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents MoveDownButton As System.Windows.Forms.Button
    Friend WithEvents MoveUpButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AddStackNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents RandomStackPanel As System.Windows.Forms.Panel
    Friend WithEvents AdvancedPanel As System.Windows.Forms.Panel
    Friend WithEvents StackModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BasicModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AdvancedModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents DifficultyComboBox As System.Windows.Forms.ComboBox

End Class
