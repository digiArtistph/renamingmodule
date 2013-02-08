Imports System.Threading

Public Class main

    Private arraySize As Integer = 5
    Private picBoxes() As PictureBox
    Private ppImages As PopulateImages
    Private confg As ConfigurationSettings
    Private cellSuffx As String ' this is for cell edit in suffix field

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
        Dim oldfilename, newfilenameToRename As String
        Dim rename As New ModifyFileName()
        Dim s As New System.Text.RegularExpressions.Regex("^([\d]+\.[\d]+\b|[\d]+\b)$")
        'Dim confg As New ConfigurationSettings()

        ' reads settings from xml file
        confg.ReadSetting()
        oldfilename = dgridPictures.Item(6, e.RowIndex).Value
        newfilenameToRename = dgridPictures.Item(3, e.RowIndex).Value
        sitenumber = dgridPictures.Item(1, e.RowIndex).Value
        suffix = dgridPictures.Item(2, e.RowIndex).Value
        filename = oldfilename
        rename.OutputFormat = confg.FormatName
        rename.DoParseName(sitenumber, suffix, filename)
        filename = rename.ParseName(Me.dgridPictures.Rows, True)

        If dgridPictures.Item(2, e.RowIndex).Value <> "" Then
            If s.IsMatch(suffix) Then
                ' updates filename cell
                dgridPictures.Item(3, e.RowIndex).Value = filename

                If imageExistInGrid(newfilenameToRename, 3) = False Then
                    dgridPictures.Item(3, e.RowIndex).Value = filename
                Else
                    dgridPictures.Item(3, e.RowIndex).Value = newfilenameToRename
                    'dgridPictures.Item(2, e.RowIndex).Value = suffix
                    MsgBox("The filename: " & newfilenameToRename & " is already in the list. Please choose another file", MsgBoxStyle.Exclamation, "Duplicate File")
                End If
            Else
                dgridPictures.Item(2, e.RowIndex).Value = cellSuffx
                MsgBox("Please provide numbers only with or without decimal" & vbCrLf & "e.g. : 123.00 or 123.0 or 123", MsgBoxStyle.Critical, "Error Input")
            End If
        Else
            dgridPictures.Item(2, e.RowIndex).Value = cellSuffx
            MsgBox("Please provide numbers only with or without decimal" & vbCrLf & "e.g. : 123.00 or 123.0 or 123", MsgBoxStyle.Critical, "Error Input")
        End If

    End Sub

    Private Sub dgridPictures_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridPictures.CellEnter

        cellSuffx = dgridPictures.Item(2, e.RowIndex).Value

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
            newFileName = rename.ParseName(dgridPictures.Rows)

            '' checks for the image if exist already in the dgrid            
            If imageExistInGridDrag(currentFile) = False Then
                '' if suffix increment is turned TRUE then increment suffixes on each file
                'dgridPictures.Rows.Add(New String() {False, Trim(confg.SiteNumber), Trim(confg.Suffix), newFileName, ppImages.SourcePath & "\" & e.Data.GetData(DataFormats.Text), "Delete", e.Data.GetData(DataFormats.Text)})
                dgridPictures.Rows.Add(New String() {False, Trim(confg.SiteNumber), getNewSuffix(dgridPictures.Rows), newFileName, ppImages.SourcePath & "\" & e.Data.GetData(DataFormats.Text), "Delete", e.Data.GetData(DataFormats.Text)})
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

        ' test here
        Dim TestNumber As Integer = 254
        ' Returns "45,600.00".
        Dim TestString As String = FormatNumber(TestNumber, 2, , , TriState.True)
        Dim strNum As String = Format(TestNumber + 89, "#\.##\.##\.##")

        Console.WriteLine("==> " & TestNumber)
        Console.WriteLine(">>> " + strNum)
        System.Console.WriteLine(TestString)


    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        configuration.ShowDialog()
    End Sub

    Public Sub loadSettings()
        confg = New ConfigurationSettings()
        confg.ReadSetting()

        ' refreshes some controls
        'Me.xlblDestinationPath.Text = "Destination Directory: " & Trim(confg.DestinationDirectory)
        Me.lblDestinationPath.Text = "Open Destination Directory: " & Trim(confg.DestinationDirectory)
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

        Try
            Dim processExplore As Process

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

                FileCopy(rec.Cells(4).Value, confg.DestinationDirectory & confg._parseSlashes(rec.Cells(3).Value))

                ' updates the progressbar status
                'ProgressDialogRenamingModule.ReportProgress(((i / picCount) * 100), "Renaming Module", "Renaming pictures is on progress.")

                ' increments the counter
                'i = i + 1
            Next

            '' opens the explorer
            If Me.lblDestinationPath.CheckState = CheckState.Checked Then
                processExplore = Process.Start(confg.DestinationDirectory)
            End If

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

#Region "backup_imageExistInGrid"
    'Private Function imageExistInGrid(ByVal imageName As String, Optional ByVal colNumber As Integer = 6) As Boolean

    '    Dim grdRows As DataGridViewRowCollection
    '    Dim drow As DataGridViewRow

    '    grdRows = dgridPictures.Rows

    '    For Each drow In grdRows
    '        If drow.Index < (grdRows.Count - 1) Then
    '            'Console.WriteLine(">>> " & drow.Cells(6).Value.ToString())
    '            If imageName = drow.Cells(colNumber).Value.ToString() Then
    '                Return True
    '            End If

    '        End If
    '    Next

    '    Return False

    'End Function
#End Region

    Private Function imageExistInGridDrag(ByVal imageName As String, Optional ByVal colNumber As Integer = 6) As Boolean

        Dim grdRows As DataGridViewRowCollection
        Dim drow As DataGridViewRow

        grdRows = dgridPictures.Rows

        For Each drow In grdRows
            If drow.Index < (grdRows.Count - 1) Then
                'Console.WriteLine(">>> " & drow.Cells(6).Value.ToString())
                If imageName = drow.Cells(colNumber).Value.ToString() Then
                    Return True
                End If

            End If
        Next

        Return False

    End Function

    Private Function imageExistInGrid(ByVal imageName As String, Optional ByVal colNumber As Integer = 6) As Boolean

        Dim grdRows As DataGridViewRowCollection
        Dim drow As DataGridViewRow
        Dim cntr As Integer = 0

        grdRows = dgridPictures.Rows

        For Each drow In grdRows
            If drow.Index < (grdRows.Count - 1) Then
                'Console.WriteLine(">>> " & drow.Cells(6).Value.ToString())
                If imageName = drow.Cells(colNumber).Value.ToString() Then
                    'Return True
                    cntr += 1
                End If

            End If
        Next

        If cntr > 1 Then Return True

        Return False

    End Function

    Private Function getNewSuffix(ByVal dgrdRow As DataGridViewRowCollection) As String

        Dim confSuffix As Single
        Dim suffixMaxValue As Single
        Dim retVal As String = ""
        Dim row As DataGridViewRow
        Dim booIsDecimal As Boolean = False

        confg = New ConfigurationSettings()

        Try
            '' gets the configurations
            confg.ReadSetting()

            confSuffix = Convert.ToSingle(Trim(confg.Suffix))

            ' regex
            Dim s As New System.Text.RegularExpressions.Regex("\.")

            booIsDecimal = s.IsMatch(Convert.ToString(confSuffix))
            suffixMaxValue = confSuffix

            'System.Console.WriteLine(Format(123.12, "###.#"))

            For Each row In dgrdRow
                If row.Index < (dgrdRow.Count - 1) Then
                    Dim tmpsuffix = Convert.ToSingle(row.Cells(2).Value.ToString())
                    If tmpsuffix > suffixMaxValue Then
                        suffixMaxValue = tmpsuffix
                    End If

                    'System.Console.WriteLine(row.Cells(2).Value.ToString())
                End If
            Next

            If booIsDecimal = True Then
                retVal = Convert.ToString(Format(suffixMaxValue + 0.1, "#.#"))
            Else
                retVal = Convert.ToString(Format(suffixMaxValue + 1, "#"))
            End If

            Return retVal
        Catch ex As Exception
            MsgBox("Error " + ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

        Return retVal

    End Function


    Private Sub toolstripmnuClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripmnuClearList.Click

        Try
            Dim rowCol As DataGridViewRowCollection = dgridPictures.Rows

            If (rowCol.Count - 1) = 0 Then
                MsgBox("No record existing in the list", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            End If

            If (MsgBox("Do you really want to clear the list?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Message") = MsgBoxResult.Yes) Then
                Do While rowCol.GetLastRow(DataGridViewElementStates.Displayed)
                    rowCol.RemoveAt(0)
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub dgridPictures_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgridPictures.KeyDown

        Try
            Dim curRow As DataGridViewRow = dgridPictures.CurrentRow

            If e.KeyCode = Keys.F2 Then
                If (curRow.Cells(1).Selected Or curRow.Cells(3).Selected) Then
                    MsgBox("This cell is locked. Use the SUFFIX field instead.", MsgBoxStyle.Exclamation, Me.Text)
                    curRow.Cells(2).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub toolstripeditsuffix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripeditsuffix.Click

        Try
            Dim rowCol As DataGridViewRowCollection = dgridPictures.Rows

            If (rowCol.Count - 1) = 0 Then
                Exit Sub
            End If

            SendKeys.Send("{F2}")
            dgridPictures.CurrentRow.Cells(2).Selected = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try


    End Sub

End Class