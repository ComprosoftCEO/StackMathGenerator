Public Class TargetForm

    Dim AllowClose As Boolean = False       'Stop the user from closing prematurely
    Dim NumbersList As List(Of Decimal) = New List(Of Decimal)    'List of the numbers in the check box in the order of the numbers
    Dim PickList As List(Of Decimal) = New List(Of Decimal)

    'When the form is shown, display the various information
    Private Sub TargetForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Set the dialog result
        'Me.DialogResult = Windows.Forms.DialogResult.OK

        'Hide the answer box
        AnswerCheckBox.Checked = False

        'Reset the cancel form
        AllowClose = False

        'Fill in a list of all the numbers sorted
        TargetCheckedListBox.Items.Clear()
        NumbersList.Clear()
        For i = 0 To MainForm.PickList.Count - 1

            NumbersList.Add(MainForm.PickList(i))

        Next
        NumbersList.Sort()

        'Then conver the list to the checked list box
        For i = 0 To MainForm.PickList.Count - 1

            Dim Number As Decimal = NumbersList(i)
            Dim Count As Decimal = MainForm.ValueResults.Item(Number.ToString)

            TargetCheckedListBox.Items.Add(Number.ToString & " - " & Count.ToString & " Ans.")

        Next


    End Sub


    'Form Closing
    Private Sub TargetForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Cancel the closing
        If AllowClose = False Then
            If MessageBox.Show("Cancel Custom Target? If yes, a random one will be picked instead.", "Cancel Custom Target?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                e.Cancel = True
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub


    '-----------Buttons----------------


    'Cancel Button
    Private Sub CancelFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelFormButton.Click
        'Close the form, but ask first
        Me.Close()
    End Sub

    'Show/Hide the answer box
    Private Sub AnswerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnswerCheckBox.CheckedChanged
        AnswerPanel.Visible = AnswerCheckBox.Checked
    End Sub

    'Show the answer when an item is selected
    Private Sub TargetCheckedListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetCheckedListBox.SelectedIndexChanged

        Dim Number As Decimal = NumbersList(TargetCheckedListBox.SelectedIndex)

        'Get the operation and export to answer
        AnswerListBox.Items.Clear()

        Dim TempStr As String = ""
        Dim AllAnswerString As String = MainForm.OperationResults.Get(Number.ToString).ToString & ","

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


    End Sub


    '--------Select, Deselect, Pick---------

    'Select all
    Private Sub SelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectButton.Click

        For i = 0 To TargetCheckedListBox.Items.Count - 1

            TargetCheckedListBox.SetItemCheckState(i, CheckState.Checked)

        Next
    End Sub

    'Deselect All
    Private Sub DeselectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeselectButton.Click

        For i = 0 To TargetCheckedListBox.Items.Count - 1

            TargetCheckedListBox.SetItemCheckState(i, CheckState.Unchecked)
        Next
    End Sub

    'Pick from selected
    Private Sub PickButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickButton.Click

        'Make sure there is at least one number selected
        If Not TargetCheckedListBox.CheckedItems.Count = 0 Then

            'Fill a list with all numbers
            PickList.Clear()
            For i = 0 To TargetCheckedListBox.CheckedItems.Count - 1

                Dim Index = TargetCheckedListBox.Items.IndexOf(TargetCheckedListBox.CheckedItems.Item(i))
                PickList.Add(NumbersList(Index))

            Next

            'Pick a number from the list
            Dim Number As Decimal = PickList.Item(MainForm.Rand.Next(0, PickList.Count))

            'Then locate the number in the origional list
            For i = 0 To MainForm.PickList.Count - 1

                If MainForm.PickList.Item(i) = Number Then
                    MainForm.Answer = i
                    Exit For
                End If

            Next

            'Then close the form
            AllowClose = True
            Me.Close()

        Else
            MessageBox.Show("Please select at least one item to pick from!", "Select One Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class