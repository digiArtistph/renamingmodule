Public Class textdrag

    Private MouseIsDown As Boolean = False

    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
        ' Set a flag to show that the mouse is down.
        MouseIsDown = True
    End Sub

    Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        If MouseIsDown Then
            ' Initiate dragging.
            TextBox1.DoDragDrop(TextBox1.Text, DragDropEffects.Copy)
        End If
        MouseIsDown = False
    End Sub

    Private Sub TextBox2_DragEnter(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles TextBox2.DragEnter
        ' Check the format of the data being dropped.
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            ' Display the copy cursor.
            e.Effect = DragDropEffects.Copy
        Else
            ' Display the no-drop cursor.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TextBox2_DragDrop(ByVal sender As Object, ByVal e As  _
    System.Windows.Forms.DragEventArgs) Handles TextBox2.DragDrop
        ' Paste the text.
        TextBox2.Text = e.Data.GetData(DataFormats.Text)
    End Sub

    Private Sub textdrag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class