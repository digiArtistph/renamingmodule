Imports System.IO
Imports System.IO.DirectoryInfo
Imports Ookii.Dialogs.ProgressDialog

Public Class PopulateImages

    Private picCount As Integer
    Private mImagesCount As Integer
    Private picBoxes() As PictureBox
    Private onMouseDown As Boolean = False
    Private mSourcePath As String
    Private mDestinationPath As String
    Private objImageContainerLists As Windows.Forms.Control ' container of the images

    Property SourcePath()
        Get
            Return mSourcePath
        End Get
        Set(ByVal vSourcePath)
            mSourcePath = vSourcePath
        End Set
    End Property

    Property DestinationPath()
        Get
            Return mDestinationPath
        End Get
        Set(ByVal vDestinationPath)
            mDestinationPath = vDestinationPath
        End Set
    End Property

    Private Sub createImages(ByVal panel As Windows.Forms.Control, ByVal imgs As System.IO.FileInfo())
        ReDim picBoxes(imgs.Length - 1)
        Dim tmpImg As FileInfo
        Dim cntr As Integer = 0

        For Each tmpImg In imgs
            picBoxes(cntr) = New PictureBox()
            With picBoxes(cntr)
                .Name = tmpImg.Name 'tmpImg.DirectoryName & "\" & 
                .Height = 45
                .Width = 45
                .SizeMode = PictureBoxSizeMode.Zoom
                .Cursor = Cursors.Hand
                .Image = My.Resources.image_icon1_copy                
                .ImageLocation = imgs(cntr).DirectoryName & "\" & imgs(cntr).Name '"D:\Online_Jobs\oDesk\metro rf\source\icons\image_icon1 copy.png"
                AddHandler .Click, AddressOf Picture_click
                AddHandler .MouseMove, AddressOf Picture_msmove
                AddHandler .MouseDown, AddressOf Picture_msdown
                panel.Controls.Add(picBoxes(cntr))

                ' increments the counter
                cntr += 1
            End With
        Next

    End Sub

    Public Sub Picture_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Name: " & sender.name, MsgBoxStyle.Information, "Confirm Message")
        main.picbxSourceViewer.ImageLocation = sender.ImageLocation

        ' shows what has been currently selected
        'sender.BorderStyle = BorderStyle.FixedSingle '' use loop on this

        updateStatusBar(sender.ImageLocation.ToString)
        main.repaintPictureBoxes()

    End Sub

    Public Sub Picture_msmove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If onMouseDown Then
            'MsgBox("You hovered the mouse on " & sender.name, MsgBoxStyle.Information, "Confirm Message")
            sender.DoDragDrop(sender.Name.ToString, DragDropEffects.Copy)
        End If
        onMouseDown = False
    End Sub

    Public Sub Picture_msdown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        onMouseDown = True
    End Sub

    Public Sub LoadImages(ByVal myform As Windows.Forms.Control)

        Try
            Dim currentDirectory As New DirectoryInfo(mSourcePath)
            Dim allImageFiles As FileInfo() = currentDirectory.GetFiles("*.jpg")

            If allImageFiles.Length = 0 Then
                'System.Console.WriteLine("No image file found.")
                removeAllImages(myform)
                Exit Sub
            End If

            For Each tmpImgFile In allImageFiles
                System.Console.WriteLine(tmpImgFile.DirectoryName & "\" & tmpImgFile.Name)
            Next
            removeAllImages(myform)
            createImages(myform, allImageFiles)

        Catch exp As Exception
            MsgBox(exp.Message, MsgBoxStyle.Critical, "Populate Images")
            main.lblSourcePath.Text = "Source Directory:"
        End Try
    End Sub

    Private Sub removeAllImages(ByVal panel As Windows.Forms.Control)

        Try
            For i As Integer = panel.Controls.Count - 1 To 0 Step -1
                panel.Controls.RemoveAt(i)
            Next

            updateStatusBar("Status: Ready")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Removing Images")
        End Try
    End Sub

    Private Sub updateStatusBar(ByVal strVal As String)
        main.stripLabel.Text = strVal
    End Sub
End Class
