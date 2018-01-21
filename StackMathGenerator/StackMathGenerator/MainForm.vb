Imports System.Collections.Specialized

Public Class MainForm

    Friend Rand As New Random          'Random Number variable
    Dim StackNumbers() As Integer   'Numbers located on the stack
    Friend ValueResults As NameValueCollection = New NameValueCollection     'List of all possible values
    Friend OperationResults As NameValueCollection = New NameValueCollection   'What operations were done to get this output
    Friend Operations() As Integer                   'List of current operations
    Friend PickList As List(Of Decimal) = New List(Of Decimal)
    Friend Answer As Integer = 0

    'Parameters for the algorithm
    Dim StackSize As Integer = 0
    Dim StackLowRange As Byte = 0
    Dim StackHighRange As Byte = 0
    Dim LowTarget As Integer = 0
    Dim HighTarget As Integer = 0
    Dim Solutions As Integer = 0

    'Form load
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the date picker to the current date
        SeedDateTimePicker.Value = Date.Today

        'Set the default difficulty
        DifficultyComboBox.SelectedIndex = 1

        'Set the random stack combo box
        StackModeComboBox.SelectedIndex = 0

    End Sub


    'Switch the visibility of the answer text box
    Private Sub AnswerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnswerCheckBox.CheckedChanged

        AnswerPanel.Visible = sender.checked

    End Sub

    'Avoid a range where the lower is greater than the higher (or vice versa)
    Private Sub LowRangeNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowRangeNumericUpDown.ValueChanged
        HighRangeNumericUpDown.Minimum = sender.Value + 1
    End Sub
    Private Sub HighRangeNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighRangeNumericUpDown.ValueChanged
        LowRangeNumericUpDown.Maximum = sender.Value - 1
    End Sub

    Private Sub TargetMinNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetMinNumericUpDown.ValueChanged
        TargetMaxNumericUpDown.Minimum = sender.value + 1
    End Sub
    Private Sub TargetMaxNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetMaxNumericUpDown.ValueChanged
        TargetMinNumericUpDown.Maximum = sender.value - 1
    End Sub


    '--------------Generate-----------------


    'Generate puzzle button
    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click

        'Start by getting the function parameters
        GetGenerationParameters()

        'Set the seed to a random value
        Rand = New Random()

        'Then generate
        GeneratePuzzle()

    End Sub


    'Seed Button
    Private Sub SetDateSeedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDateSeedButton.Click

        'Start by getting the function parameters
        GetGenerationParameters()

        'Set the seed based on the date and all of the parameters
        Dim Seed As String = String.Format("{0:MMddyyyy}", SeedDateTimePicker.Value)

        'The seed is also dependent on the stack size
        Seed = (StackSize + 1) & Seed

        Rand = New Random(Convert.ToInt32(Seed))

        'Then generate the puzzle
        GeneratePuzzle()

    End Sub


    'Set up the parameters of the algorithm
    Sub GetGenerationParameters()


        If AdvancedModeRadioButton.Checked = True Then

            'Get the size of the stack
            If RandomMode() = True Then
                StackSize = StackSizeNumericUpDown.Value - 1
            Else
                StackSize = StackListBox.Items.Count - 1
            End If

            StackLowRange = LowRangeNumericUpDown.Value
            StackHighRange = HighRangeNumericUpDown.Value

            LowTarget = TargetMinNumericUpDown.Value
            HighTarget = TargetMaxNumericUpDown.Value

            Solutions = SolutionsNumericUpDown.Value
        Else

            Select Case DifficultyComboBox.SelectedIndex
                Case 0      'Easy
                    StackSize = 4
                    StackLowRange = 1
                    StackHighRange = 9
                    LowTarget = 1
                    HighTarget = 50
                    Solutions = 1
                Case 1      'Normal
                    StackSize = 5
                    StackLowRange = 1
                    StackHighRange = 9
                    LowTarget = 1
                    HighTarget = 100
                    Solutions = 1
                Case 2      'Intermediate
                    StackSize = 6
                    StackLowRange = 1
                    StackHighRange = 9
                    LowTarget = 1
                    HighTarget = 250
                    Solutions = 1
                Case 3      'Advanced
                    StackSize = 7
                    StackLowRange = 1
                    StackHighRange = 9
                    LowTarget = 1
                    HighTarget = 500
                    Solutions = 1

                Case 4      'Expert
                    StackSize = 9
                    StackLowRange = 1
                    StackHighRange = 9
                    LowTarget = 1
                    HighTarget = 1000
                    Solutions = 1
            End Select

        End If

    End Sub



    'Generates the puzzle
    Sub GeneratePuzzle()

        'Show the loading bar
        LoadingLabel.Visible = True
        Me.Refresh()

        Dim Picks As Integer = 0

Repick:


        ReDim StackNumbers(StackSize)


        'Pick the random numbers
        If RandomMode() = True Or AdvancedModeRadioButton.Checked = False Then
            PickRandomNumbers()
        Else
            'Test to make sure there are enough numbers
            If StackListBox.Items.Count < 4 Then
                MessageBox.Show("Please input at least 4 numbers into the stack.", "Input 4 Numbers", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoadingLabel.Visible = False
                Exit Sub
            End If

            For i = 0 To StackListBox.Items.Count - 1
                StackNumbers(i) = StackListBox.Items.Item(i)
            Next
        End If


        'Cycle through all possible values
        GetAllOutputs()


        'Find the output value to use
        PickList.Clear()
        For i = 0 To ValueResults.Count - 1
            'MsgBox(ValueResults.Item(i).ToString)
            Dim Count As Decimal = ValueResults.Item(i)
            Dim Tempitem As Decimal = ValueResults.GetKey(i)

            'Only add the item if there is only 1 solution and the answer is an integer
            If (Count <= Solutions And (Math.Floor(Tempitem) = Math.Ceiling(Tempitem)) And (Tempitem <= HighTarget) And (Tempitem >= LowTarget)) Then
                PickList.Add(Tempitem)
            End If

        Next

        'Make sure there is at least one value to pick from
        If PickList.Count = 0 Then
            Picks += 1
            'Try 3 times to generate
            If (Picks < 3) And (RandomMode() = True) Then
                GoTo Repick
            Else
                MessageBox.Show("Unable to generate a puzzle with the given parameters.", "Problem Generating Puzzle.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoadingLabel.Visible = False
                Exit Sub
            End If
        End If


        'Export the list of numbers
        StackListBox.Items.Clear()
        For i = 0 To StackSize
            StackListBox.Items.Add(StackNumbers(i))
        Next
        Me.Refresh()


        'Choose a random number from 0 to count
        If AdvancedModeRadioButton.Checked = True And ChooseTargetCheckBox.Checked = True Then

            'Bring up the choose form
            If TargetForm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                'If abborted, pick random answer
                Answer = Rand.Next(0, PickList.Count)
            End If
        Else
            Answer = Rand.Next(0, PickList.Count)
        End If



        'Export the target number
        TargetTextBox.Text = PickList.Item(Answer).ToString("n0")

        'Get the operation and export to answer
        AnswerListBox.Items.Clear()

        Dim TempStr As String = ""
        Dim AllAnswerString As String = OperationResults.Get(PickList.Item(Answer).ToString).ToString & ","

        'Break apart the seperate answers
        For Each c As Char In AllAnswerString
            If c = "," Then
                AnswerListBox.Items.Add(TempStr)
                TempStr = ""
            Else
                TempStr += c
            End If
        Next

        'Show the number of answers
        AnswerTextBox.Text = AnswerListBox.Items.Count
        Me.Refresh()




        'Hide the answer
        AnswerCheckBox.Checked = False

        'Hide the loading message
        LoadingLabel.Visible = False

    End Sub


    'Fills the stack numbers array with random numbers
    Sub PickRandomNumbers()

        'Run the loop to pick a set of random numbers
        For i = 0 To StackSize Step 1
            StackNumbers(i) = Rand.Next(StackLowRange, StackHighRange + 1)
        Next

    End Sub


    'Gets all possible target number outputs
    Sub GetAllOutputs()

        'Resize the array to keep track of the operations
        '0 = +
        '1 = -
        '2 = *
        '3 = /
        ReDim Operations(StackSize - 1)

        'Clear the list of all possible values/operations
        ValueResults.Clear()
        OperationResults.Clear()

        Dim EndArray As Boolean = False 'When to stop the loop

        'Run the loop through all iterations
        Do Until EndArray = True

            Dim Update = CalculateValue()

            'Find if the value exists in the collection and increase the counter
            Try
                ValueResults.Item(Update.ToString) += 1
            Catch ex As Exception
                ValueResults.Add(Update.ToString, "1")
            End Try

            'Keep track of the operation used to get this number
            Dim OperationString As String = ""      'Temp string variable
            For i = 0 To StackSize - 1
                OperationString += GetOperationChar(Operations(i))
            Next

            'Add to the list of operations
            OperationResults.Add(Update.ToString, OperationString.ToString)


            'Update the operations array
            EndArray = UpdateOperations()

        Loop




    End Sub


    'Calculate the value from the stack array and operations list
    Function CalculateValue()

        'Calculates the value associated with the current operations
        Dim Output As Decimal = StackNumbers(0)       'Output can be decimal

        'Loop through operations
        For i = 0 To StackSize - 1 Step 1
            Select Case Operations(i)
                Case 0
                    Output += StackNumbers(i + 1)
                Case 1
                    Output -= StackNumbers(i + 1)
                Case 2
                    Output *= StackNumbers(i + 1)
                Case 3
                    Output /= StackNumbers(i + 1)
            End Select

        Next


            Try
                Convert.ToInt64(Output)
                Output = Convert.ToInt64(Output)
            Catch ex As Exception
            End Try

            Return Output

    End Function


    'Update the operations
    Function UpdateOperations()

        Dim Break As Boolean = False
        Dim i As Integer = 0        'Index in the array
        Dim ReturnType As Boolean = False

        Do Until Break = True

            If Operations(i) < 3 Then
                Operations(i) += 1
                Break = True
                ReturnType = False
            Else
                Operations(i) = 0
                i += 1

                'Run the loop until there are no more operations
                If i = StackSize Then
                    Break = True
                    ReturnType = True
                End If

            End If

        Loop

        Return ReturnType

    End Function


    'Returns the ascii character for the operation
    Function GetOperationChar(ByVal input As Integer)
        Select Case input
            Case 0
                Return "+"
            Case 1
                Return "-"
            Case 2
                Return "*"
            Case 3
                Return "/"
            Case Else
                Return " "
        End Select
    End Function


    '-----------Other Buttons-----------------


    'Copy text to clipboard
    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        'Make sure a puzzle is generated first
        If Not (StackListBox.Items.Count < 1 Or TargetTextBox.Text = "" Or AnswerTextBox.Text = "" Or AnswerListBox.Items.Count < 1) Then

            Dim str As String = ""

            'Add the stack to the string
            str += "Stack Numbers:" & Environment.NewLine
            For i = 0 To StackListBox.Items.Count - 1
                str += StackListBox.Items.Item(i) & Environment.NewLine
            Next

            'Add the target number
            str += Environment.NewLine & "Target Number: " & TargetTextBox.Text.ToString

            'If the answer is visible, add the answer
            If AnswerCheckBox.Checked = True Then
                str += Environment.NewLine & Environment.NewLine & "Answers: " & AnswerTextBox.Text.ToString & Environment.NewLine

                For i = 0 To AnswerListBox.Items.Count - 1
                    str += (AnswerListBox.Items.Item(i).ToString) & Environment.NewLine
                Next
            End If

            Clipboard.SetText(str)
            MessageBox.Show("Puzzle copied to clipboard", "Puzzle Copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please generate a puzzle first.", "Generate Puzzle First", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    'Open Solver Form
    Private Sub SolverButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolverButton.Click
        SolverForm.Show()
    End Sub




    '-----------Basic and Advanced----------------

    'Basic Mode and Advanced Mode
    Private Sub BasicAdvancedMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicModeRadioButton.CheckedChanged, AdvancedModeRadioButton.CheckedChanged

        'Switch between advanced and basic mode
        AdvancedPanel.Visible = AdvancedModeRadioButton.Checked
        DifficultyLabel.Visible = BasicModeRadioButton.Checked
        DifficultyComboBox.Visible = BasicModeRadioButton.Checked

        'Make sure to turn off the selection mode
        If AdvancedModeRadioButton.Checked = False Then
            StackListBox.SelectionMode = SelectionMode.None
        Else
            StackModeComboBox_SelectedIndexChanged(sender, e)
        End If

    End Sub

    'Stack Mode
    Private Sub StackModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackModeComboBox.SelectedIndexChanged
        Select Case StackModeComboBox.SelectedIndex
            Case 0      'Random Stack Mode
                RandomStackPanel.Visible = True
                CustomStackPanel.Visible = False
                StackListBox.SelectionMode = SelectionMode.None
            Case 1
                RandomStackPanel.Visible = False
                CustomStackPanel.Visible = True
                StackListBox.SelectionMode = SelectionMode.One
        End Select
        ClearFormItems()
    End Sub




    '------------Stack Commands--------------

    'Add Number to Stack
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        'Only have a max of 10 numbers
        If StackListBox.Items.Count < 10 Then
            StackListBox.Items.Add(AddStackNumericUpDown.Value)
        Else
            MessageBox.Show("You can only have a maximum of 10 numbers on the stack.", "10 Numbers Max", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        ClearFormItems()
    End Sub

    'Update the selected value
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Test to make sure a value is selected
        If Not StackListBox.SelectedIndex = -1 Then
            StackListBox.Items.Item(StackListBox.SelectedIndex) = AddStackNumericUpDown.Value

        Else
            MessageBox.Show("Please select an item to update.", "Select Item to Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ClearFormItems()
    End Sub

    'Remove selected number from stack
    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        'Make sure an item is selected
        If Not StackListBox.SelectedIndex = -1 Then
            StackListBox.Items.RemoveAt(StackListBox.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove.", "Select Item to Remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        ClearFormItems()
    End Sub

    'Move item up
    Private Sub MoveUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveUpButton.Click
        'Make sure an item is selected first
        If Not (StackListBox.SelectedIndex = -1 Or StackListBox.SelectedIndex = 0) Then

            Dim TempItem As String = StackListBox.Items.Item(StackListBox.SelectedIndex - 1)
            StackListBox.Items.Item(StackListBox.SelectedIndex - 1) = StackListBox.Items.Item(StackListBox.SelectedIndex)
            StackListBox.Items.Item(StackListBox.SelectedIndex) = TempItem

            'Update the selected index
            StackListBox.SelectedIndex = StackListBox.SelectedIndex - 1

            ClearFormItems()

        End If
    End Sub

    'Move item down
    Private Sub MoveDownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveDownButton.Click
        'Make sure an item is selected first
        If Not (StackListBox.SelectedIndex = -1 Or StackListBox.SelectedIndex = (StackListBox.Items.Count - 1)) Then

            Dim TempItem As String = StackListBox.Items.Item(StackListBox.SelectedIndex + 1)
            StackListBox.Items.Item(StackListBox.SelectedIndex + 1) = StackListBox.Items.Item(StackListBox.SelectedIndex)
            StackListBox.Items.Item(StackListBox.SelectedIndex) = TempItem

            'Update the selected index
            StackListBox.SelectedIndex = StackListBox.SelectedIndex + 1

            ClearFormItems()

        End If
    End Sub

    'Clear Stack Button
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        If MessageBox.Show("Clear Stack?", "Clear Stack?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StackListBox.Items.Clear()
            ClearFormItems()
        End If

    End Sub


    'Removes any left over data from the last generation
    Sub ClearFormItems()
        TargetTextBox.Clear()
        AnswerListBox.Items.Clear()
        AnswerTextBox.Clear()
    End Sub


    'Is random mode on or off
    Function RandomMode() As Boolean
        If StackModeComboBox.SelectedIndex = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
