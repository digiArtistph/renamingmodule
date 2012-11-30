Public Class main

    Private arraySize As Integer = 5
    Private picBoxes() As PictureBox
    Private ppImages As PopulateImages

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim test As PopulateImages

        'ppImages = New PopulateImages(Me.flwSourcePictures)
        'ppImages = New PopulateImages()

    End Sub

    Public Sub mypicclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Name: " & sender.name, MsgBoxStyle.Information, "Confirmation Message")

    End Sub

    Public Sub clkCBox(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("You\'ve clicked the checkbox", MsgBoxStyle.Information, "Checkbox Message")

    End Sub


    Private Sub statSystemState_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles statSystemState.ItemClicked

    End Sub

    Private Sub picbxSourceViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbxSourceViewer.Click

    End Sub

    Private Sub dgridPictures_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellClick
        MsgBox(dgridPictures.Item(0, e.RowIndex).Value & dgridPictures.Item(2, e.RowIndex).Value & dgridPictures.Item(1, e.RowIndex).Value)
    End Sub

    Private Sub dgridPictures_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellContentClick

        'MsgBox(dgridPictures.Rows.Item(e.RowIndex).Cells(0).Value)

    End Sub

    Private Sub dgridPictures_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgridPictures.DragDrop
        dgridPictures.Rows.Add(New String() {"SB12", "2.1", e.Data.GetData(DataFormats.Text)})
    End Sub

    Private Sub dgridPictures_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgridPictures.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy        
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        aboutrenamingmodule.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnBrowseSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSource.Click

        fdlrdlgSourcePictures.RootFolder = Environment.SpecialFolder.MyComputer
        fdlrdlgSourcePictures.ShowDialog()

        Dim dlgresult = DialogResult.OK

        'Try
        If dlgresult Then
            ppImages = New PopulateImages()
            lblSourcePath.Text = "Source Directory: " & fdlrdlgSourcePictures.SelectedPath
            ppImages.SourcePath = fdlrdlgSourcePictures.SelectedPath
            ppImages.LoadImages(Me.flwSourcePictures)
        End If
        ' Catch ex As Exception
        'MsgBox("Error " + ex.Message)
        'End Try
        

    End Sub
End Class