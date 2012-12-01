Imports System.IO
Imports System.Xml
Imports System.Text.RegularExpressions

Public Class ConfigurationSettings

    Private mFileSettings As String
    Private mSpecialFolderApp As Environment.SpecialFolder
    Private mFileSettingsPath As String = "aliasing"
    Private mSourceDirectory As String
    Private mDestinationDirectory As String
    Private mSiteNumber As String
    Private mSuffix As String
    Private mSuffixIsIncrement As String
    Private mSettingPath As String

    Public Sub New()
        ' initializes some member variables
        mSpecialFolderApp = Environment.SpecialFolder.ApplicationData
        mFileSettings = _getPath(mSpecialFolderApp, mFileSettingsPath & "\" & "retitlesetting.xml")

        ' checks if settings exists
        '' if not then call _createSettings
        System.Console.WriteLine(mFileSettings)

        If _isExistSettings() Then
            System.Console.WriteLine("File exists")
        Else
            System.Console.WriteLine("File doesn't exists")
            System.Console.WriteLine("---------------------")
            _createSettings()
            System.Console.WriteLine("Created a new xml file")
            System.Console.WriteLine("---------------------")
        End If

    End Sub

    Public Sub ReadSetting()
        Dim xmlSettings As New XmlDataDocument()
        Dim fs As New FileStream(mFileSettings, FileMode.Open, FileAccess.Read)
        Dim xmlNode As XmlNodeList

        ' loads the xmlfile
        xmlSettings.Load(fs)
        xmlNode = xmlSettings.GetElementsByTagName("env")

        For Each rootNode In xmlNode
            For Each chldNode In rootNode
                System.Console.WriteLine(chldNode.Name & " -- " & chldNode.InnerText)
            Next
        Next

        fs.Close()

    End Sub

    Public Sub WriteSetting()

        Dim xmlSettings As New XmlDocument()
        Dim nodeSetting As XmlNode

        xmlSettings.Load(mFileSettings)

        nodeSetting = xmlSettings.DocumentElement

        For Each chdNode In nodeSetting
            Select Case chdNode.Name.ToString
                Case "suffix"
                    chdNode.InnerText = "2.1"
            End Select
        Next

        xmlSettings.Save(mFileSettings)


    End Sub

    Private Sub _writeSetting(ByVal settingName As String, ByVal settingValue As String)

        Dim xmlSettings As New XmlDocument()
        Dim nodeSetting As XmlNode

        xmlSettings.Load(mFileSettings)

        nodeSetting = xmlSettings.DocumentElement

        For Each chdNode In nodeSetting
            If chdNode.Name = settingName Then
                chdNode.InnerText = settingValue
            End If
        Next

        xmlSettings.Save(mFileSettings)


    End Sub

    Private Function _isExistSettings() As Boolean

        ' checks file if existst
        '' return false if it doesn't
        Dim mFile As New FileInfo(mFileSettings)

        If Not mFile.Exists Then
            Return False
        End If

        Return True

    End Function

    Private Function _createSettings() As Boolean

        'Dim xmlSetting As New XmlTextWriter(mFileSettings, System.Text.Encoding.UTF8)
        Dim xmlSetting As XmlTextWriter
        Dim currAppPath As String = _getPath(mSpecialFolderApp, _parseSlashes(mFileSettingsPath))
        Dim currFullAppPath As New DirectoryInfo(currAppPath)

        If Not currFullAppPath.Exists Then
            currFullAppPath.Create()
        End If

        xmlSetting = New XmlTextWriter(mFileSettings, System.Text.Encoding.UTF8)

        With xmlSetting
            .WriteStartDocument(True)
            .Formatting = Formatting.Indented
            .Indentation = 4
        End With

        ' root node
        xmlSetting.WriteStartElement("env")
        _createChildNode("source_directory", "C:\temp", xmlSetting)
        _createChildNode("destination_directory", "C:\temp\dest", xmlSetting)
        _createChildNode("site_number", "SB12XC345", xmlSetting)
        _createChildNode("suffix", "2.1", xmlSetting)
        _createChildNode("suffix_is_inrement", "TRUE", xmlSetting)
        _createChildNode("setting_path", mFileSettings, xmlSetting)
        xmlSetting.WriteEndElement()
        xmlSetting.WriteEndDocument()
        xmlSetting.Close()


    End Function

    Private Sub _createChildNode(ByVal nodeName As String, ByVal nodeValue As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement(nodeName)
        writer.WriteString(nodeValue)
        writer.WriteEndElement()
    End Sub

    Private Function _getPath(ByVal strVal As Environment.SpecialFolder, Optional ByVal strFile As String = "") As String

        Return Trim(Environment.GetFolderPath(strVal) & IIf(strFile <> "", _parseSlashes(strFile), ""))

    End Function

    Private Function _parseSlashes(ByVal strVal As String, Optional ByVal endSlash As Boolean = False)
        Dim pattern As New System.Text.RegularExpressions.Regex("((?<=\\)[\w\s\W]+(?=\\$)|(?<=\\)[\w\s\W]+|^[^\\][\w\s\W]+)")
        Dim pattMatch As MatchCollection = pattern.Matches(strVal)

        For Each singleMatch As Match In pattMatch
            If endSlash Then
                Return Trim("\" & singleMatch.Value & "\")
            Else
                Return Trim("\" & singleMatch.Value)
            End If

        Next

        Return Trim(strVal)

    End Function

    Property SourceDirectory()
        Get
            Return mSourceDirectory
        End Get
        Set(ByVal value)
            _writeSetting("source_directory", value)
        End Set
    End Property

    Property DestinationDirectory()
        Get
            Return mDestinationDirectory
        End Get
        Set(ByVal value)
            _writeSetting("destination_directory", value)
        End Set
    End Property

    Property SiteNumber()
        Get
            Return mSiteNumber
        End Get
        Set(ByVal value)
            _writeSetting("site_number", value)
        End Set
    End Property

    Property Suffix()
        Get
            Return mSuffix
        End Get
        Set(ByVal value)
            _writeSetting("suffix", value)
        End Set
    End Property

    Property SuffixIsIncrement()
        Get
            Return mSuffixIsIncrement
        End Get
        Set(ByVal value)
            _writeSetting("suffix_is_inrement", value)
        End Set
    End Property

    Property SettingPath()
        Get
            Return mSettingPath
        End Get
        Set(ByVal value)
            _writeSetting("setting_path", value)
        End Set
    End Property

End Class
