<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolverForm
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
        Me.PuzzleSolverLabel = New System.Windows.Forms.Label()
        Me.PuzzleSolverGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SolveButton = New System.Windows.Forms.Button()
        Me.SolutionsTextBox = New System.Windows.Forms.TextBox()
        Me.TargetTextBox = New System.Windows.Forms.TextBox()
        Me.SolutionsLabel = New System.Windows.Forms.Label()
        Me.SolutionsListBox = New System.Windows.Forms.ListBox()
        Me.TargetNumberLabel = New System.Windows.Forms.Label()
        Me.MoveDownButton = New System.Windows.Forms.Button()
        Me.MoveUpButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.AddStackNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.StackListBox = New System.Windows.Forms.ListBox()
        Me.StackLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.DividingLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PuzzleSolverGroupBox.SuspendLayout()
        CType(Me.AddStackNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StackMathLabel
        '
        Me.StackMathLabel.AutoSize = True
        Me.StackMathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackMathLabel.Location = New System.Drawing.Point(206, 14)
        Me.StackMathLabel.Name = "StackMathLabel"
        Me.StackMathLabel.Size = New System.Drawing.Size(177, 37)
        Me.StackMathLabel.TabIndex = 1
        Me.StackMathLabel.Text = "Stack Math"
        '
        'PuzzleSolverLabel
        '
        Me.PuzzleSolverLabel.AutoSize = True
        Me.PuzzleSolverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PuzzleSolverLabel.Location = New System.Drawing.Point(245, 57)
        Me.PuzzleSolverLabel.Name = "PuzzleSolverLabel"
        Me.PuzzleSolverLabel.Size = New System.Drawing.Size(99, 18)
        Me.PuzzleSolverLabel.TabIndex = 2
        Me.PuzzleSolverLabel.Text = "Puzzle Solver"
        '
        'PuzzleSolverGroupBox
        '
        Me.PuzzleSolverGroupBox.Controls.Add(Me.ClearButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.UpdateButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.SolveButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.SolutionsTextBox)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.TargetTextBox)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.SolutionsLabel)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.SolutionsListBox)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.TargetNumberLabel)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.MoveDownButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.MoveUpButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.RemoveButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.AddStackNumericUpDown)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.AddButton)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.StackListBox)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.StackLabel)
        Me.PuzzleSolverGroupBox.Controls.Add(Me.ShapeContainer1)
        Me.PuzzleSolverGroupBox.Location = New System.Drawing.Point(19, 90)
        Me.PuzzleSolverGroupBox.Name = "PuzzleSolverGroupBox"
        Me.PuzzleSolverGroupBox.Size = New System.Drawing.Size(551, 292)
        Me.PuzzleSolverGroupBox.TabIndex = 6
        Me.PuzzleSolverGroupBox.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(112, 254)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(54, 26)
        Me.UpdateButton.TabIndex = 25
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'SolveButton
        '
        Me.SolveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolveButton.Location = New System.Drawing.Point(373, 223)
        Me.SolveButton.Name = "SolveButton"
        Me.SolveButton.Size = New System.Drawing.Size(134, 50)
        Me.SolveButton.TabIndex = 24
        Me.SolveButton.Text = "Solve"
        Me.SolveButton.UseVisualStyleBackColor = True
        '
        'SolutionsTextBox
        '
        Me.SolutionsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolutionsTextBox.Location = New System.Drawing.Point(457, 25)
        Me.SolutionsTextBox.MaxLength = 255
        Me.SolutionsTextBox.Name = "SolutionsTextBox"
        Me.SolutionsTextBox.ReadOnly = True
        Me.SolutionsTextBox.Size = New System.Drawing.Size(60, 26)
        Me.SolutionsTextBox.TabIndex = 17
        '
        'TargetTextBox
        '
        Me.TargetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetTextBox.Location = New System.Drawing.Point(210, 58)
        Me.TargetTextBox.MaxLength = 255
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.Size = New System.Drawing.Size(82, 26)
        Me.TargetTextBox.TabIndex = 7
        '
        'SolutionsLabel
        '
        Me.SolutionsLabel.AutoSize = True
        Me.SolutionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolutionsLabel.Location = New System.Drawing.Point(362, 29)
        Me.SolutionsLabel.Name = "SolutionsLabel"
        Me.SolutionsLabel.Size = New System.Drawing.Size(74, 18)
        Me.SolutionsLabel.TabIndex = 19
        Me.SolutionsLabel.Text = "Solutions:"
        '
        'SolutionsListBox
        '
        Me.SolutionsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolutionsListBox.FormattingEnabled = True
        Me.SolutionsListBox.ItemHeight = 29
        Me.SolutionsListBox.Location = New System.Drawing.Point(354, 71)
        Me.SolutionsListBox.Name = "SolutionsListBox"
        Me.SolutionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.SolutionsListBox.Size = New System.Drawing.Size(174, 120)
        Me.SolutionsListBox.TabIndex = 20
        '
        'TargetNumberLabel
        '
        Me.TargetNumberLabel.AutoSize = True
        Me.TargetNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetNumberLabel.Location = New System.Drawing.Point(194, 29)
        Me.TargetNumberLabel.Name = "TargetNumberLabel"
        Me.TargetNumberLabel.Size = New System.Drawing.Size(111, 18)
        Me.TargetNumberLabel.TabIndex = 8
        Me.TargetNumberLabel.Text = "Target Number:"
        '
        'MoveDownButton
        '
        Me.MoveDownButton.Location = New System.Drawing.Point(135, 223)
        Me.MoveDownButton.Name = "MoveDownButton"
        Me.MoveDownButton.Size = New System.Drawing.Size(31, 26)
        Me.MoveDownButton.TabIndex = 16
        Me.MoveDownButton.Text = "▼"
        Me.MoveDownButton.UseVisualStyleBackColor = True
        '
        'MoveUpButton
        '
        Me.MoveUpButton.Location = New System.Drawing.Point(11, 223)
        Me.MoveUpButton.Name = "MoveUpButton"
        Me.MoveUpButton.Size = New System.Drawing.Size(31, 26)
        Me.MoveUpButton.TabIndex = 15
        Me.MoveUpButton.Text = "▲"
        Me.MoveUpButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(55, 223)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(67, 26)
        Me.RemoveButton.TabIndex = 14
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'AddStackNumericUpDown
        '
        Me.AddStackNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStackNumericUpDown.Location = New System.Drawing.Point(56, 255)
        Me.AddStackNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AddStackNumericUpDown.Name = "AddStackNumericUpDown"
        Me.AddStackNumericUpDown.Size = New System.Drawing.Size(51, 24)
        Me.AddStackNumericUpDown.TabIndex = 13
        Me.AddStackNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(11, 255)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(41, 26)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.DividingLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(545, 273)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'DividingLine
        '
        Me.DividingLine.BorderColor = System.Drawing.Color.White
        Me.DividingLine.Name = "DividingLine"
        Me.DividingLine.X1 = 326
        Me.DividingLine.X2 = 326
        Me.DividingLine.Y1 = 13
        Me.DividingLine.Y2 = 261
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(207, 402)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(175, 25)
        Me.CopyButton.TabIndex = 11
        Me.CopyButton.Text = "Copy Solution(s) to Clipboard"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(210, 230)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(82, 39)
        Me.ClearButton.TabIndex = 26
        Me.ClearButton.Text = "Clear Input"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SolverForm
        '
        Me.AcceptButton = Me.SolveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 441)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.PuzzleSolverGroupBox)
        Me.Controls.Add(Me.PuzzleSolverLabel)
        Me.Controls.Add(Me.StackMathLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SolverForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stack Math Puzzle Solver"
        Me.PuzzleSolverGroupBox.ResumeLayout(False)
        Me.PuzzleSolverGroupBox.PerformLayout()
        CType(Me.AddStackNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StackMathLabel As System.Windows.Forms.Label
    Friend WithEvents PuzzleSolverLabel As System.Windows.Forms.Label
    Friend WithEvents PuzzleSolverGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents StackListBox As System.Windows.Forms.ListBox
    Friend WithEvents StackLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents AddStackNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TargetNumberLabel As System.Windows.Forms.Label
    Friend WithEvents MoveDownButton As System.Windows.Forms.Button
    Friend WithEvents MoveUpButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents SolutionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolutionsLabel As System.Windows.Forms.Label
    Friend WithEvents SolutionsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents DividingLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents SolveButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class
