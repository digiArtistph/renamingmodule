Imports System.Text.RegularExpressions

Public Class ModifyFileName

    Private mFileType As String
    Private mFileName As String
    Private mNewFileName As String
    Private mSiteName As String
    Private mSuffix As String
    Private mFormat As ParseFormat
    Private mDashChar As Char
    Private mUnderScoreChar As Char

    Public Enum ParseFormat
        AB = 0
        ACB = 1
        AdB = 2
        AeB = 3
        AdCdB = 4
        AeCeB = 5
    End Enum

    Public Sub DoParseName(ByVal sitename As String, ByVal suffix As String, ByVal filename As String)
        Dim r As New System.Text.RegularExpressions.Regex("[\w\.\s]+.\b(?=.jpg|.jpeg|.png|.gif|.tiff)")
        Dim matchFiles As MatchCollection = r.Matches(filename)

        ' resets current values of member variables
        purge()

        ' initializes some private member variables
        mSiteName = sitename
        mSuffix = suffix
        'mFormat = ParseFormat.ACB
        mDashChar = "-"
        mUnderScoreChar = "_"

        ' strips off filname
        For Each flname As Match In matchFiles
            mFileName = Trim(flname.Value)
        Next

        ' strips off the file extension
        Dim s As New System.Text.RegularExpressions.Regex("[\.](jpg|jpeg|png|gif|tiff)$")
        Dim matchExtensionFile As MatchCollection = s.Matches(filename)

        For Each xtension As Match In matchExtensionFile
            mFileType = Trim(xtension.Value.Substring(1))
        Next

        mNewFileName = sitename & mFileName & suffix & "." & mFileType
        ' outputs into the console
        'System.Console.WriteLine("Filename: " + mFileName + vbCrLf + "File type: " & mFileType & vbCrLf & _
        '                         "---> " & mNewFileName & " <---")

    End Sub

    Public Function ParseName() As String
        Dim retVal As String

        Select Case mFormat
            Case ParseFormat.AB
                retVal = mSiteName & mSuffix & "." & mFileType

            Case ParseFormat.ACB
                retVal = mSiteName & mFileName & mSuffix & "." & mFileType

            Case ParseFormat.AdB
                retVal = mSiteName & mUnderScoreChar & mSuffix & "." & mFileType

            Case ParseFormat.AeB
                retVal = mSiteName & mDashChar & mSuffix & "." & mFileType

            Case ParseFormat.AdCdB
                retVal = mSiteName & mUnderScoreChar & mFileName & mUnderScoreChar & mSuffix & "." & mFileType

            Case ParseFormat.AeCeB
                retVal = mSiteName & mDashChar & mFileName & mDashChar & mSuffix & "." & mFileType
            Case Else
                retVal = mSiteName & mSuffix & "." & mFileType
        End Select

        Return Trim(retVal)

    End Function

    Private Sub purge()
        ' resets member variables
        mFileName = ""
        mNewFileName = ""
        mSiteName = ""
        mSuffix = ""
        mFileType = ""

    End Sub

    Property OutputFormat()
        Get
            Return mFormat
        End Get
        Set(ByVal value)
            mFormat = value
        End Set
    End Property

    ReadOnly Property FileType()
        Get
            Return mFileType
        End Get
    End Property

    ReadOnly Property FileName()
        Get
            Return mFileName
        End Get
    End Property

    ReadOnly Property NewFileName()
        Get
            Return mNewFileName
        End Get
    End Property

End Class
