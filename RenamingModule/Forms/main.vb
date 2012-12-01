Public Class main

    Private arraySize As Integer = 5
    Private picBoxes() As PictureBox
    Private ppImages As PopulateImages
    Private confg As ConfigurationSettings

    Public Sub mypicclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Name: " & sender.name, MsgBoxStyle.Information, "Confirmation Message")

    End Sub

    Public Sub clkCBox(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("You\'ve clicked the checkbox", MsgBoxStyle.Information, "Checkbox Message")

    End Sub

    Private Sub dgridPictures_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellClick    

        Try
            picbxDestinationViewer.ImageLocation = dgridPictures.Item(4, e.RowIndex).Value            
            repaintPictureBoxes()
        Catch ex As Exception
            Console.WriteLine("dgridPictures_CellClick. " & ex.Message)
        End Try

    End Sub

    Private Sub dgridPictures_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                'MsgBox("You pressed the delete button")

                If (dgridPictures.Item(1, e.RowIndex).Value <> "" And dgridPictures.Item(2, e.RowIndex).Value <> "" And dgridPictures.Item(3, e.RowIndex).Value <> "") Then
                    If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm Message") = MsgBoxResult.Yes Then
                        dgridPictures.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
                
            End If
        Catch ex As Exception
            Console.WriteLine("dgridPictures_CellContentClick. " & ex.Message)
        End Try
    End Sub

    Private Sub dgridPictures_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellEndEdit
        MsgBox("You are done editing this cell " & dgridPictures.Item(e.ColumnIndex, e.RowIndex).Value)
    End Sub

    Private Sub dgridPictures_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgridPictures.DragDrop
        Try
            dgridPictures.Rows.Add(New String() {False, Trim(confg.SiteNumber), Trim(confg.Suffix), e.Data.GetData(DataFormats.Text), ppImages.SourcePath & "\" & e.Data.GetData(DataFormats.Text), "Delete"})
        Catch ex As Exception
            MsgBox("dgridPictures_DragDrop -- " & ex.Message)
        End Try

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
        fdlrdlgSourcePictures.SelectedPath = confg.SourceDirectory        
        fdlrdlgSourcePictures.ShowDialog()

        Dim dlgresult = DialogResult.OK

        Try
            If dlgresult Then
                ppImages = New PopulateImages()
                lblSourcePath.Text = "Source Directory: " & fdlrdlgSourcePictures.SelectedPath
                ppImages.SourcePath = fdlrdlgSourcePictures.SelectedPath
                ppImages.LoadImages(Me.flwSourcePictures)

                picbxSourceViewer.ImageLocation = Nothing
                repaintPictureBoxes()
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
        

    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim renStr As ModifyFileName

        renStr = New ModifyFileName("SB12", "2.1", "394657_10151073425524686_600706546_n.jpg")
        renStr.OutputFormat = ModifyFileName.ParseFormat.AB
        System.Console.WriteLine(">>> " & renStr.ParseName & " <<<")
        renStr = Nothing

        loadSettings()
        repaintPictureBoxes()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        configuration.ShowDialog()
    End Sub

    Public Sub loadSettings()
        confg = New ConfigurationSettings()
        confg.ReadSetting()

        ' refreshes some controls
        Me.lblDestinationPath.Text = "Destination Directory: " & Trim(confg.DestinationDirectory)
        Me.lblSourcePath.Text = "Source Directory: " & Trim(confg.SourceDirectory)
    End Sub

    Private Sub mnuMainMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuMainMenu.ItemClicked

    End Sub

    Public Sub repaintPictureBoxes()
        If picbxSourceViewer.ImageLocation Is Nothing Then
            picbxSourceViewer.Visible = False
            picSourceLabel.Visible = True
        Else
            picbxSourceViewer.Visible = True
            picSourceLabel.Visible = False
        End If

        If picbxDestinationViewer.ImageLocation Is Nothing Then
            picbxDestinationViewer.Visible = False
            picDestinationLabel.Visible = True
        Else
            picbxDestinationViewer.Visible = True
            picDestinationLabel.Visible = False
        End If
    End Sub
End Class