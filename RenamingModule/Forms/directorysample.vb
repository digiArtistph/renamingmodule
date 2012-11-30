Imports System
Imports System.IO
Imports System.IO.File
Imports System.Collections
Imports System.IO.Directory

Public Class directorysample

    Private path As String
    Private pattern As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            ' Obtain the file system entries in the directory path. 
            Dim directoryEntries As String()
            directoryEntries = System.IO.Directory.GetFileSystemEntries(path)
            Dim str As String
            For Each str In directoryEntries
                System.Console.WriteLine(str)
            Next str
        Catch exp As ArgumentNullException
            System.Console.WriteLine("Path is a null reference.")
        Catch exp As System.Security.SecurityException
            System.Console.WriteLine("The caller does not have the " + _
                                    "required permission.")
        Catch exp As ArgumentException
            System.Console.WriteLine("Path is an empty string, " + _
                                    "contains only white spaces, " + _
                                    "or contains invalid characters.")
        Catch exp As System.IO.DirectoryNotFoundException
            System.Console.WriteLine("The path encapsulated in the " + _
                                    "Directory object does not exist.")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ' Obtain the file system entries in the directory 
            ' path that match the pattern. 
            Dim directoryEntries As String()
            Dim dirc As DirectoryInfo = New DirectoryInfo(path)

            directoryEntries = System.IO.Directory.GetFileSystemEntries(path, pattern) 'System.IO.Directory.GetDirectories(path)  '

            Dim str As String
            For Each str In directoryEntries
                'If Directory.Exists(str) Then
                System.Console.WriteLine(str)
                'End If

            Next str
        Catch exp As ArgumentNullException
            System.Console.WriteLine("Path is a null reference.")
        Catch exp As System.Security.SecurityException
            System.Console.WriteLine("The caller does not have the " + _
                                    "required permission.")
        Catch exp As ArgumentException
            System.Console.WriteLine("Path is an empty string, " + _
                                    "contains only white spaces, " + _
                                    "or contains invalid characters.")
        Catch exp As System.IO.DirectoryNotFoundException
            System.Console.WriteLine("The path encapsulated in the " + _
                                    "Directory object does not exist.")
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        path = "D:\Our Pictures"
        pattern = "*.*"
    End Sub

    Private Sub directorysample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnGetAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAllFiles.Click
        Dim fldr As New DirectoryInfo(path)


        Dim allfiles As FileInfo() = fldr.GetFiles("*.jpg")
        Dim fileTmp As FileInfo

        For Each fileTmp In allfiles
            Console.WriteLine(fileTmp.Directory)
        Next fileTmp
    End Sub

    Private Sub bntFileSubDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntFileSubDir.Click
        Dim fldr As New DirectoryInfo(path)

        Dim allfiles As FileSystemInfo() = fldr.GetFileSystemInfos
        Dim tmpFile As FileSystemInfo

        For Each tmpFile In allfiles
            If tmpFile.Attributes = FileAttributes.Directory Then
                Console.WriteLine(tmpFile.FullName)
            End If
        Next

    End Sub
End Class