Public Class configuration

    Private config As ConfigurationSettings

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpFileFormat.Enter

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' loads settings
        loadSettings()

    End Sub

    Private Sub loadSettings()


        config = New ConfigurationSettings
        config.ReadSetting()

        With config
            Me.txtSourceDirectory.Text = .SourceDirectory
            Me.txtDestinationDirectory.Text = .DestinationDirectory
            Me.txtSiteNumber.Text = .SiteNumber
            Me.txtSuffix.Text = .Suffix
            Me.chkSuffixIncrement.Checked = IIf(.SuffixIsIncrement = True, True, False)

            Select Case .FormatName
                Case 1
                    frmtOne.Checked = True
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 2
                    frmtOne.Checked = False
                    frmtTwo.Checked = True
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 3
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = True
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 4
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = True
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 5
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = True
                    frmtSix.Checked = False
                Case 6
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = True
            End Select
        End With

    End Sub


    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click

        With config
            .SourceDirectory = Me.txtSourceDirectory.Text
            .DestinationDirectory = Me.txtDestinationDirectory.Text
            .SiteNumber = Me.txtSiteNumber.Text
            .Suffix = Me.txtSuffix.Text
            .SuffixIsIncrement = Me.chkSuffixIncrement.Checked
            If frmtOne.Checked Then .FormatName = 1
            If frmtTwo.Checked Then .FormatName = 2
            If frmThree.Checked Then .FormatName = 3
            If frmFour.Checked Then .FormatName = 4
            If frmtFive.Checked Then .FormatName = 5
            If frmtSix.Checked Then .FormatName = 6
        End With
        main.loadSettings()
        MsgBox("Settings have been saved", MsgBoxStyle.Information, "Confirm Message")
    End Sub

  
    Private Sub btnSourceDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSourceDir.Click
        If Not txtSourceDirectory.Text Is Nothing Then vfldrbrowserSourceDir.SelectedPath = txtSourceDirectory.Text

        If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSourceDirectory.Text = Trim(vfldrbrowserSourceDir.SelectedPath)
        End If

    End Sub

    Private Sub btbDestinationDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbDestinationDir.Click
        If Not txtDestinationDirectory.Text Is Nothing Then vfldrbrowserSourceDir.SelectedPath = txtDestinationDirectory.Text

        If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDestinationDirectory.Text = Trim(vfldrbrowserSourceDir.SelectedPath)
        End If
    End Sub
End Class