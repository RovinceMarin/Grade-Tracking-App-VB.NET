Public Class Tasks


    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        ChkListBox.Items.Add(TxtInputBox.Text.Trim)

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ChkListBox.Items.RemoveAt(ChkListBox.SelectedIndex)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'Dim the searched text as string
        Dim searchText As String = TxtInputBox.Text.Trim()
        'initialize i as counter variable and use a loop

        For i As Integer = 0 To ChkListBox.Items.Count - 1

            Dim currentitemText As String = ChkListBox.Items(i).ToString()
            If currentitemText.Contains(searchText) Then
                ChkListBox.SetSelected(i, True)
                TxtSearchBox.Text = currentitemText

                Exit For
            End If
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Get the selected item in the CheckedListBox
        Dim selectedItem As String = ChkListBox.SelectedItem

        ' Get the description from the TextBox
        Dim description As String = TxtDescriptionBox.Text.Trim()

        ' Add the description to the item
        ChkListBox.Items(ChkListBox.SelectedIndex) = selectedItem & " - " & description
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtDescriptionBox.Text = " "
    End Sub

End Class
