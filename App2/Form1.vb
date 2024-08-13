Public Class Form1

    Private Sub SortCheckedItems()
        Dim checkedItems As New List(Of String)
        Dim uncheckedItems As New List(Of String)

        For i As Integer = 0 To clbToDoList.Items.Count - 1
            If clbToDoList.GetItemChecked(i) Then
                checkedItems.Add(clbToDoList.Items(i).ToString())
            Else
                uncheckedItems.Add(clbToDoList.Items(i).ToString())
            End If
        Next

        checkedItems.Sort()

        clbToDoList.Items.Clear()

        For Each item As String In checkedItems
            clbToDoList.Items.Add(item, True)
        Next

        For Each item As String In uncheckedItems
            clbToDoList.Items.Add(item, False)
        Next
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtInput.Text.Trim() <> "" Then
            clbToDoList.Items.Add(txtInput.Text)

            txtInput.Text = ""

            txtInput.Focus()
        End If
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        SortCheckedItems()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        clbToDoList.Items.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i As Integer = clbToDoList.Items.Count - 1 To 0 Step -1
            If clbToDoList.GetItemChecked(i) Then
                clbToDoList.Items.RemoveAt(i)
            End If
        Next
    End Sub
End Class