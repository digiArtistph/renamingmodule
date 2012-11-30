Public Class RenamingModule

    Private MouseIsDown As Boolean = False
    Private popIMg As PopulateImages

    Private Sub RenamingModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lsNames.Items.Add("Kenneth")
        lsNames.Items.Add("Myla")
        lsNames.Items.Add("Megan")
        lsNames.Items.Add("Kyla")
        lsNames.Items.Add("Miko")

        'MsgBox("Item 2: " + lsNames.SelectedValue)
        pcImage.ImageLocation = "D:\Online_Jobs\oDesk\metro rf\source\icons\image_icon1 copy.png"

        Dim cBox = New CheckBox

        With cBox
            .Name = "cboxtest"
            .Text = "Language of your choice"
            .AutoSize = True
            .Checked = True
            .Visible = True
            .Top = 50
        End With



    End Sub

    Private Sub lsNames_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsNames.MouseDown

        MouseIsDown = True

    End Sub

    Private Sub lsNames_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsNames.MouseMove
        If MouseIsDown Then
            lsNames.DoDragDrop(lsNames.SelectedItem, DragDropEffects.Copy)            
        End If
        MouseIsDown = False
    End Sub

    Private Sub lsNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsNames.SelectedIndexChanged
        'MsgBox("Name: " + lsNames.SelectedItem)
    End Sub

    Private Sub lsSource_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsSource.DragDrop
        lsSource.Items.Add(e.Data.GetData(DataFormats.Text))
    End Sub

    Private Sub lsSource_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lsSource.DragEnter
        ' Check the format of the data being dropped.
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            ' Display the copy cursor.
            e.Effect = DragDropEffects.Copy
        Else
            ' Display the no-drop cursor.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pcImage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcImage.MouseDown
        If Not pcImage.Image Is Nothing Then
            MouseIsDown = True
        End If

    End Sub

    Private Sub pcImage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcImage.MouseMove
        If MouseIsDown Then
            'pcImage.DoDragDrop(pcImage.Image, DragDropEffects.Copy)
            pcImage.DoDragDrop(pcImage.ImageLocation.ToString, DragDropEffects.Copy)
        End If
        MouseIsDown = False
    End Sub

    Private Sub SplitContainer2_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub
End Class