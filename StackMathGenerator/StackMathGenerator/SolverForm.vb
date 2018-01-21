Public Class SolverForm

    'Define variables
    Dim StackNumbers() As Integer   'Numbers located on the stack
    Dim Operations() As Integer                   'List of current operations
    Dim TargetNumber As Decimal                 'The target for the operation

    '------------Stack Commands--------------

    'Add Number to Stack
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        'Only have a max of 10 numbers
        If StackListBox.Items.Count < 10 Then
            StackListBox.Items.Add(AddStackNumericUpDown.Value)
        Else
            MessageBox.Show("You can only have a maximum of 10 numbers on the stack.", "10 Numbers Max", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Update the selected value
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Test to make sure a value is selected
        If Not StackListBox.SelectedIndex = -1 Then
            StackListBox.Items.Item(StackListBox.SelectedIndex) = AddStackNumericUpDown.Value
        Else
            MessageBox.Show("Please select an item to update.", "Select Item to Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Remove selected number from stack
    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        'Make sure an item is selected
        If Not StackListBox.SelectedIndex = -1 Then
            StackListBox.Items.RemoveAt(StackListBox.SelectedIndex)
        Else
            MessageBox.Show("Please select an item to remove.", "Select Item to Remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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

        End If
    End Sub

    'Clear Button
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        If MessageBox.Show("Clear Puzzle Input?", "Clear Input?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            TargetTextBox.Clear()
            StackListBox.Items.Clear()
            SolutionsTextBox.Clear()
            SolutionsListBox.Items.Clear()
        End If

    End Sub

    '----------Solver--------------


    'Solve Button
    Private Sub SolveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolveButton.Click

        'Test to make sure there are at least 4 items in the list
        If StackListBox.Items.Count < 4 Then
            MessageBox.Show("Please input at least 4 numbers into the stack.", "Input 4 Numbers", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Test to make sure the target is valid
        Try
            TargetNumber = Decimal.Parse(TargetTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Please type in a valid target number.", "Type in Valid Target", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try


        'Fill the stack numbers array
        ReDim StackNumbers(StackListBox.Items.Count - 1)
        For i = 0 To StackListBox.Items.Count - 1
            StackNumbers(i) = StackListBox.Items.Item(i)
        Next


        'Run a super loop to get all outputs
        GetAllOutputs()


        'Display the number of solutions
        SolutionsTextBox.Text = SolutionsListBox.Items.Count

        If SolutionsTextBox.Text = 0 Then
            MessageBox.Show("No solution exists for the given puzzle.", "No Solution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub



    'Gets all possible target number outputs
    Sub GetAllOutputs()

        'Resize the array to keep track of the operations
        '0 = +
        '1 = -
        '2 = *
        '3 = /
        ReDim Operations(StackListBox.Items.Count - 2)

        'Clear the solution lists
        SolutionsTextBox.Clear()
        SolutionsListBox.Items.Clear()


        Dim EndArray As Boolean = False 'When to stop the loop

        'Run the loop through all iterations
        Do Until EndArray = True

            Dim Update = CalculateValue()

            'Find if the value matches the target number
            If Update = TargetNumber Then

                'String to hold the operation being exported
                Dim OperationString As String = ""

                'Add the solution to the list box
                For i = 0 To StackListBox.Items.Count - 2
                    OperationString += GetOperationChar(Operations(i))
                Next

                SolutionsListBox.Items.Add(OperationString.ToString)
            End If
     

            'Update the operations array
            EndArray = UpdateOperations()

        Loop

    End Sub

    'Calculate the value from the stack array and operations list
    Function CalculateValue()

        'Calculates the value associated with the current operations
        Dim Output As Decimal = StackNumbers(0)       'Output can be decimal

        'Loop through operations
        For i = 0 To StackListBox.Items.Count - 2 Step 1
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

    'Returns the ascii character for the operation
    Function GetOperationChar(ByVal input As Integer) As String
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
                If i = StackListBox.Items.Count - 1 Then
                    Break = True
                    ReturnType = True
                End If

            End If

        Loop

        Return ReturnType

    End Function




    'Copy solutions to clipboard
    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        'Make sure that there are solutions to copy
        If Not SolutionsTextBox.Text = "" Then

            Dim str As String = ""

            'Add the stack to the string
            str += "Stack Numbers:" & Environment.NewLine
            For i = 0 To StackListBox.Items.Count - 1
                str += StackListBox.Items.Item(i) & Environment.NewLine
            Next

            'Add the target number
            str += Environment.NewLine & "Target Number: " & TargetTextBox.Text.ToString & Environment.NewLine & Environment.NewLine

            'Add the number of solutions
            str += "Solutions: " & SolutionsTextBox.Text.ToString & Environment.NewLine

            For i = 0 To SolutionsListBox.Items.Count - 1
                str += (SolutionsListBox.Items.Item(i).ToString) & Environment.NewLine
            Next

            Clipboard.SetText(str)
            MessageBox.Show("Solutions copied to clipboard", "Solutions Copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No solutions to copy.", "No Solutions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub


End Class