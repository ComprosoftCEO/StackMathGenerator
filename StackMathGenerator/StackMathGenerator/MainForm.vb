Imports System.Collections.Specialized

Public Class MainForm

    Dim Rand As New Random          'Random Number variable
    Dim StackNumbers() As Integer   'Numbers located on the stack
    Dim ValueResults As NameValueCollection = New NameValueCollection     'List of all possible values
    Dim OperationResults As NameValueCollection = New NameValueCollection   'What operations were done to get this output
    Dim Operations() As Integer                   'List of current operations
    Dim PickList As List(Of Decimal) = New List(Of Decimal)


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

    'Generate puzzle
    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click

        LoadingLabel.Visible = True
        Application.DoEvents()

        Dim Picks As Integer = 0

Repick:
        'Reset the size of the array
        ReDim StackNumbers(StackSizeNumericUpDown.Value - 1)

        'Pick the random numbers
        PickRandomNumbers()

        'Cycle through all possible values
        GetAllOutputs()

        'Find the output value to use
        PickList.Clear()
        For i = 0 To ValueResults.Count - 1
            'MsgBox(ValueResults.Item(i).ToString)
            Dim Count As Decimal = ValueResults.Item(i)
            Dim Tempitem As Decimal = ValueResults.GetKey(i)

            'Only add the item if there is only 1 solution and the answer is an integer
            If (Count <= SolutionsNumericUpDown.Value And (Math.Floor(Tempitem) = Math.Ceiling(Tempitem)) And (Tempitem <= TargetMaxNumericUpDown.Value) And (Tempitem >= TargetMinNumericUpDown.Value)) Then
                PickList.Add(Tempitem)
            End If

        Next

        'Make sure there is at least one value to pick from
        If PickList.Count = 0 Then
            Picks += 1
            'Try 3 times to generate
            If Picks < 3 Then
                GoTo Repick
            Else
                MessageBox.Show("Unable to generate a puzzle with the given parameters.", "Problem Generating Puzzle.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoadingLabel.Visible = False
                Exit Sub
            End If
        End If


        'Choose a random number from 0 to count
        Dim Answer = Rand.Next(0, PickList.Count)


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



        'Export the list of numbers
        StackListBox.Items.Clear()
        For i = 0 To StackSizeNumericUpDown.Value - 1
            StackListBox.Items.Add(StackNumbers(i))
        Next

        'Hide the answer
        AnswerCheckBox.Checked = False

        'Hide the loading message
        LoadingLabel.Visible = False

    End Sub

    'Fills the stack numbers array with random numbers
    Sub PickRandomNumbers()

        'Run the loop to pick a set of random numbers
        For i = 0 To StackSizeNumericUpDown.Value - 1 Step 1
            StackNumbers(i) = Rand.Next(LowRangeNumericUpDown.Value, HighRangeNumericUpDown.Value + 1)
        Next

    End Sub

    'Gets all possible target number outputs
    Sub GetAllOutputs()

        'Resize the array to keep track of the operations
        '0 = +
        '1 = -
        '2 = *
        '3 = /
        ReDim Operations(StackSizeNumericUpDown.Value - 2)

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
            For i = 0 To StackSizeNumericUpDown.Value - 2
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
            For i = 0 To StackSizeNumericUpDown.Value - 2 Step 1
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
                If i = StackSizeNumericUpDown.Value - 1 Then
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



    'Copy text to clipboard
    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        'Make sure a puzzle is generated first
        If Not StackListBox.Items.Count < 1 Then

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
        Else
            MessageBox.Show("Please generate a puzzle first.", "Generate Puzzle First", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    'Open Solver Form
    Private Sub SolverButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolverButton.Click
        SolverForm.Show()
    End Sub
End Class
