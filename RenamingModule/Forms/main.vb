Public Class main

    Private arraySize As Integer = 5
    Private picBoxes() As PictureBox
    Private ppImages As PopulateImages

    Public Sub mypicclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Name: " & sender.name, MsgBoxStyle.Information, "Confirmation Message")

    End Sub

    Public Sub clkCBox(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("You\'ve clicked the checkbox", MsgBoxStyle.Information, "Checkbox Message")

    End Sub

    Private Sub dgridPictures_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellClick    

        Try
            picbxDestinationViewer.ImageLocation = dgridPictures.Item(4, e.RowIndex).Value
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
        dgridPictures.Rows.Add(New String() {False, "SB12", "2.1", e.Data.GetData(DataFormats.Text), ppImages.SourcePath & "\" & e.Data.GetData(DataFormats.Text), "Delete"})
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

        Try
            If dlgresult Then
                ppImages = New PopulateImages()
                lblSourcePath.Text = "Source Directory: " & fdlrdlgSourcePictures.SelectedPath
                ppImages.SourcePath = fdlrdlgSourcePictures.SelectedPath
                ppImages.LoadImages(Me.flwSourcePictures)
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

        Dim confg As ConfigurationSettings

        confg = New ConfigurationSettings()

        With confg
            .SourceDirectory = "D:\Install"
            .DestinationDirectory = "D:\Online_Jobs"
            .SiteNumber = "SB12XC345"
            .Suffix = "3.21.3"
            .SuffixIsIncrement = False
        End With

    End Sub

End Class