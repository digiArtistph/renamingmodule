Imports System.Threading

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

    Private Sub dgridPictures_CellBorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgridPictures.CellBorderStyleChanged

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
        Dim sitenumber As String
        Dim suffix As String
        Dim filename As String
        Dim oldfilename As String
        Dim rename As New ModifyFileName()
        'Dim confg As New ConfigurationSettings()

        ' reads settings from xml file
        confg.ReadSetting()
        oldfilename = dgridPictures.Item(6, e.RowIndex).Value
        sitenumber = dgridPictures.Item(1, e.RowIndex).Value
        suffix = dgridPictures.Item(2, e.RowIndex).Value
        filename = oldfilename
        rename.OutputFormat = confg.FormatName
        rename.DoParseName(sitenumber, suffix, filename)
        filename = rename.ParseName

        ' updates filename cell
        dgridPictures.Item(3, e.RowIndex).Value = filename

    End Sub

    Private Sub dgridPictures_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgridPictures.DragDrop
        Try
            'Dim confg As New ConfigurationSettings()
            Dim rename As New ModifyFileName()
            Dim newFileName As String
            Dim currentFile As String

            confg.ReadSetting()
            rename.OutputFormat = confg.FormatName
            rename.DoParseName(confg.SiteNumber, confg.Suffix, e.Data.GetData(DataFormats.Text))
            currentFile = e.Data.GetData(DataFormats.Text)
            newFileName = rename.ParseName

            '' checks for the image if exist already in the dgrid            
            If imageExistInGrid(currentFile) = False Then
                '' if suffix increment is turned TRUE then increment suffixes on each file
                dgridPictures.Rows.Add(New String() {False, Trim(confg.SiteNumber), Trim(confg.Suffix), newFileName, ppImages.SourcePath & "\" & e.Data.GetData(DataFormats.Text), "Delete", e.Data.GetData(DataFormats.Text)})
            Else
                MsgBox("The file: " & currentFile & " is alreading in the list. Please choose another file", MsgBoxStyle.Exclamation, "Duplicate File")
            End If


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

        If (MsgBox("You're about to close this application." & vbCrLf & "Are your sure?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Message")) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnBrowseSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSource.Click

        Try

            If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ppImages = New PopulateImages()
                lblSourcePath.Text = "Source Directory: " & vfldrbrowserSourceDir.SelectedPath
                ppImages.SourcePath = vfldrbrowserSourceDir.SelectedPath
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

        ' checks license
        'checkLicense()

        'renStr = New ModifyFileName()
        'renStr.DoParseName("SB12", "2.1", "394657_10151073425524686_600706546_n.jpg")
        'renStr.OutputFormat = ModifyFileName.ParseFormat.AdCdB
        'System.Console.WriteLine(">>> " & renStr.ParseName & " <<<")
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

    Private Sub BrowsePicturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowsePicturesToolStripMenuItem.Click
        Try
            If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ppImages = New PopulateImages()
                lblSourcePath.Text = "Source Directory: " & vfldrbrowserSourceDir.SelectedPath
                ppImages.SourcePath = vfldrbrowserSourceDir.SelectedPath
                ppImages.LoadImages(Me.flwSourcePictures)

                picbxSourceViewer.ImageLocation = Nothing
                repaintPictureBoxes()
            End If
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnRenamePictures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenamePictures.Click
        ' renames images
        doRenameImages()

    End Sub

    Private Sub checkLicense()
        Dim trialLicense As Date = #12/4/2012#

        If (Date.Now > trialLicense) Then
            MsgBox("You're trial is over")
            Me.Close()
        End If

    End Sub
#Region "backup of doRenameImages"
    'confg.ReadSetting()

    'If dgridPictures.RowCount <= 1 Then
    '    MsgBox("Please drag an image or images to process", MsgBoxStyle.Information, "Confirm Message")
    '    Exit Sub
    'End If

    'Try
    '    For Each rec In dgridPictures.Rows
    '        If rec.Cells(3).Value = "" Then Exit For

    '        FileCopy(rec.Cells(4).Value, confg.DestinationDirectory & confg._parseSlashes(rec.Cells(3).Value))

    '    Next

    '    MsgBox("Renaming files done!", MsgBoxStyle.Information, "Confirmation Message")

    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
    'End Try

#End Region

    Private Sub doRenameImages()

        Try
            If dgridPictures.RowCount <= 1 Then
                MsgBox("Please drag an image or images to process", MsgBoxStyle.Information, "Confirm Message")
                Exit Sub
            End If

            If (MsgBox("You're about to rename pictures that are on the list." & vbCr & "Would you like to proceed?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Please Confirm Message")) = MsgBoxResult.Yes Then
                If ProgressDialogRenamingModule.IsBusy Then
                    MessageBox.Show("The progressbar is already displayed.", "Renaming Module")
                Else
                    ProgressDialogRenamingModule.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try



    End Sub

    Private Sub RenamePToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenamePToolStripMenuItem.Click

        ' rename images
        doRenameImages()

    End Sub

    Private Sub ProgressDialog1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProgressDialogRenamingModule.DoWork

        'For i As Integer = 1 To 50 Step 1
        '    Thread.Sleep(250)

        '    If ProgressDialogRenamingModule.CancellationPending Then
        '        Return
        '    End If

        '    ProgressDialogRenamingModule.ReportProgress(i, "Renaming pictures is on progress.", String.Format(System.Globalization.CultureInfo.CurrentCulture, "Processing: {0}%", i))
        'Next

        Try

            confg.ReadSetting()
            Dim picCount As Integer = dgridPictures.RowCount

            For Each rec In dgridPictures.Rows
                'For i As Integer = 0 To (dgridPictures.RowCount - 1) Step 1

                Thread.Sleep(250)

                If rec.Cells(3).Value = "" Then Exit For

                ' when the user presses the cancel button
                If ProgressDialogRenamingModule.CancellationPending Then
                    Return
                End If

                ' @todo: 
                ' - appending increment when file exists. US#2
                ' - do some filename prep here
                FileCopy(rec.Cells(4).Value, confg.DestinationDirectory & confg._parseSlashes(rec.Cells(3).Value))

                ' updates the progressbar status
                'ProgressDialogRenamingModule.ReportProgress(((i / picCount) * 100), "Renaming Module", "Renaming pictures is on progress.")

                ' increments the counter
                'i = i + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

    End Sub

    Private Sub ProgressDialogRenamingModule_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProgressDialogRenamingModule.RunWorkerCompleted
        MsgBox("Renaming files done!", MsgBoxStyle.Information, "Confirmation Message")
    End Sub

    'Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
    '    System.Diagnostics.Process.Start("C:\Users\kenn\Documents\Visual Studio 2008\Projects\RenamingModule\RenamingModule\Resources\helpme.html")
    'End Sub

    Private Function imageExistInGrid(ByVal imageName As String) As Boolean

        Dim grdRows As DataGridViewRowCollection
        Dim drow As DataGridViewRow

        grdRows = dgridPictures.Rows

        For Each drow In grdRows
            If drow.Index < (grdRows.Count - 1) Then
                'Console.WriteLine(">>> " & drow.Cells(6).Value.ToString())
                If imageName = drow.Cells(6).Value.ToString() Then
                    Return True
                End If

            End If
        Next

        Return False

    End Function
End Class