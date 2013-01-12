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
    Private confg As ConfigurationSettings

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

    Public Function ParseName(ByVal dgrRows As DataGridViewRowCollection, Optional ByVal renFlag As Boolean = False) As String
        Dim retVal As String

        '' preps the msuffix
        If renFlag = False Then
            mSuffix = getNewSuffix(dgrRows)
        End If

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
