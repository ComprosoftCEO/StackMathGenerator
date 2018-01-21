<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TargetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TargetForm))
        Me.ChooseTargetLabel = New System.Windows.Forms.Label()
        Me.TargetCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.DeselectButton = New System.Windows.Forms.Button()
        Me.PickButton = New System.Windows.Forms.Button()
        Me.AnswerPanel = New System.Windows.Forms.Panel()
        Me.AnswersLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerListBox = New System.Windows.Forms.ListBox()
        Me.AnswerCheckBox = New System.Windows.Forms.CheckBox()
        Me.CancelFormButton = New System.Windows.Forms.Button()
        Me.AnswerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChooseTargetLabel
        '
        Me.ChooseTargetLabel.AutoSize = True
        Me.ChooseTargetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseTargetLabel.Location = New System.Drawing.Point(33, 18)
        Me.ChooseTargetLabel.Name = "ChooseTargetLabel"
        Me.ChooseTargetLabel.Size = New System.Drawing.Size(353, 37)
        Me.ChooseTargetLabel.TabIndex = 1
        Me.ChooseTargetLabel.Text = "Choose Target Number"
        '
        'TargetCheckedListBox
        '
        Me.TargetCheckedListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetCheckedListBox.FormattingEnabled = True
        Me.TargetCheckedListBox.HorizontalScrollbar = True
        Me.TargetCheckedListBox.Location = New System.Drawing.Point(21, 71)
        Me.TargetCheckedListBox.Name = "TargetCheckedListBox"
        Me.TargetCheckedListBox.Size = New System.Drawing.Size(195, 130)
        Me.TargetCheckedListBox.TabIndex = 2
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(21, 206)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(88, 25)
        Me.SelectButton.TabIndex = 11
        Me.SelectButton.Text = "Select All"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'DeselectButton
        '
        Me.DeselectButton.Location = New System.Drawing.Point(128, 206)
        Me.DeselectButton.Name = "DeselectButton"
        Me.DeselectButton.Size = New System.Drawing.Size(88, 25)
        Me.DeselectButton.TabIndex = 12
        Me.DeselectButton.Text = "Deselect All"
        Me.DeselectButton.UseVisualStyleBackColor = True
        '
        'PickButton
        '
        Me.PickButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PickButton.Location = New System.Drawing.Point(21, 250)
        Me.PickButton.Name = "PickButton"
        Me.PickButton.Size = New System.Drawing.Size(195, 33)
        Me.PickButton.TabIndex = 13
        Me.PickButton.Text = "Pick From Selected"
        Me.PickButton.UseVisualStyleBackColor = True
        '
        'AnswerPanel
        '
        Me.AnswerPanel.Controls.Add(Me.AnswersLabel)
        Me.AnswerPanel.Controls.Add(Me.AnswerTextBox)
        Me.AnswerPanel.Controls.Add(Me.AnswerListBox)
        Me.AnswerPanel.Location = New System.Drawing.Point(243, 101)
        Me.AnswerPanel.Name = "AnswerPanel"
        Me.AnswerPanel.Size = New System.Drawing.Size(156, 130)
        Me.AnswerPanel.TabIndex = 15
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
        Me.AnswerListBox.Size = New System.Drawing.Size(135, 84)
        Me.AnswerListBox.TabIndex = 29
        '
        'AnswerCheckBox
        '
        Me.AnswerCheckBox.AutoSize = True
        Me.AnswerCheckBox.Location = New System.Drawing.Point(271, 78)
        Me.AnswerCheckBox.Name = "AnswerCheckBox"
        Me.AnswerCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.AnswerCheckBox.TabIndex = 14
        Me.AnswerCheckBox.Text = "Show Answer:"
        Me.AnswerCheckBox.UseVisualStyleBackColor = True
        '
        'CancelFormButton
        '
        Me.CancelFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelFormButton.Location = New System.Drawing.Point(234, 250)
        Me.CancelFormButton.Name = "CancelFormButton"
        Me.CancelFormButton.Size = New System.Drawing.Size(165, 33)
        Me.CancelFormButton.TabIndex = 16
        Me.CancelFormButton.Text = "Cancel"
        Me.CancelFormButton.UseVisualStyleBackColor = True
        '
        'TargetForm
        '
        Me.AcceptButton = Me.PickButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 295)
        Me.Controls.Add(Me.CancelFormButton)
        Me.Controls.Add(Me.AnswerPanel)
        Me.Controls.Add(Me.AnswerCheckBox)
        Me.Controls.Add(Me.PickButton)
        Me.Controls.Add(Me.DeselectButton)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.TargetCheckedListBox)
        Me.Controls.Add(Me.ChooseTargetLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TargetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Target Number:"
        Me.AnswerPanel.ResumeLayout(False)
        Me.AnswerPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChooseTargetLabel As System.Windows.Forms.Label
    Friend WithEvents TargetCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents SelectButton As System.Windows.Forms.Button
    Friend WithEvents DeselectButton As System.Windows.Forms.Button
    Friend WithEvents PickButton As System.Windows.Forms.Button
    Friend WithEvents AnswerPanel As System.Windows.Forms.Panel
    Friend WithEvents AnswersLabel As System.Windows.Forms.Label
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnswerListBox As System.Windows.Forms.ListBox
    Friend WithEvents AnswerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CancelFormButton As System.Windows.Forms.Button
End Class
