Public Class listtolist

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        ' MsgBox(ListView1.SelectedItems.Item(0).Text)  '.SubItems(1).Text)
        stlblMessage.Text = "Status: " & ListView1.SelectedItems.Item(0).Text
    End Sub
    Private Sub ListView_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles ListView1.ItemDrag, ListView2.ItemDrag
        Dim myItem As ListViewItem
        Dim myItems(sender.SelectedItems.Count - 1) As ListViewItem
        Dim i As Integer = 0

        ' Loop though the SelectedItems collection for the source.
        For Each myItem In sender.SelectedItems
            ' Add the ListViewItem to the array of ListViewItems.
            myItems(i) = myItem
            i = i + 1
        Next
        ' Create a DataObject containg the array of ListViewItems.
        sender.DoDragDrop(New  _
        DataObject("System.Windows.Forms.ListViewItem()", myItems), _
        DragDropEffects.Move)
    End Sub

    Private Sub ListView_DragEnter(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter, _
    ListView2.DragEnter
        ' Check for the custom DataFormat ListViewItem array.
        If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListView_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop, _
    ListView2.DragDrop
        Dim myItem As ListViewItem
        Dim myItems() As ListViewItem = e.Data.GetData("System.Windows.Forms.ListViewItem()")
        Dim i As Integer = 0

        For Each myItem In myItems
            ' Add the item to the target list.
            sender.Items.Add(myItems(i).Text)
            ' Remove the item from the source list.
            If sender Is ListView1 Then
                ListView2.Items.Remove(ListView2.SelectedItems.Item(0))
                stlblMessage.Text = "Status: " & ListView1.SelectedItems.Item(0).Text
            Else
                ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
                stlblMessage.Text = "Status: " & ListView2.SelectedItems.Item(0).Text
            End If
            i = i + 1
        Next


    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class