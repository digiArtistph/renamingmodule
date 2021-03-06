﻿Imports System.Text.RegularExpressions

Public Class configuration

    Private config As ConfigurationSettings
    Private nonNumberEntered As Boolean = False

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpFileFormat.Enter

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' loads settings
        loadSettings()

        ' disables the suffix field when dgdPictures has record/s
        If main.dgridPictures.RowCount > 1 Then
            txtSuffix.Enabled = False
        Else
            txtSuffix.Enabled = True
        End If

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
                Case 0
                    frmtOne.Checked = True
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 1
                    frmtOne.Checked = False
                    frmtTwo.Checked = True
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 2
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = True
                    frmFour.Checked = False
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 3
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = True
                    frmtFive.Checked = False
                    frmtSix.Checked = False
                Case 4
                    frmtOne.Checked = False
                    frmtTwo.Checked = False
                    frmThree.Checked = False
                    frmFour.Checked = False
                    frmtFive.Checked = True
                    frmtSix.Checked = False
                Case 5
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
            If frmtOne.Checked Then .FormatName = ModifyFileName.ParseFormat.AB
            If frmtTwo.Checked Then .FormatName = ModifyFileName.ParseFormat.ACB
            If frmThree.Checked Then .FormatName = ModifyFileName.ParseFormat.AdB
            If frmFour.Checked Then .FormatName = ModifyFileName.ParseFormat.AeB
            If frmtFive.Checked Then .FormatName = ModifyFileName.ParseFormat.AdCdB
            If frmtSix.Checked Then .FormatName = ModifyFileName.ParseFormat.AeCeB
        End With
        main.loadSettings()
        MsgBox("Settings have been saved", MsgBoxStyle.Information, "Confirm Message")
        Me.Close()

    End Sub


    Private Sub btnSourceDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSourceDir.Click
        If Not txtSourceDirectory.Text Is Nothing Then vfldrbrowserSourceDir.SelectedPath = txtSourceDirectory.Text

        If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtSourceDirectory.Text = Trim(vfldrbrowserSourceDir.SelectedPath)
        End If

    End Sub

    Private Sub txtSuffix_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSuffix.LostFocus
        Dim s As New System.Text.RegularExpressions.Regex("^(?!0)([\d]+(\.[\d]+\b)+|[\d]+\b)$")
        Dim curTextValue = txtSuffix.Text

        config.ReadSetting()

        If s.IsMatch(txtSuffix.Text.ToString()) = False Then
            txtSuffix.Text = config.Suffix
            MsgBox("Please provide numbers only with or without decimal" & vbCrLf & "e.g. : 123.0.0.1 or 123.0 or 123", MsgBoxStyle.Critical, "Error Input")

        End If
    End Sub

    Private Sub buttonDestinationDIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDestinationDIR.Click
        If Not txtDestinationDirectory.Text Is Nothing Then vfldrbrowserSourceDir.SelectedPath = txtDestinationDirectory.Text

        If vfldrbrowserSourceDir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtDestinationDirectory.Text = Trim(vfldrbrowserSourceDir.SelectedPath)
        End If
    End Sub

    Private Sub txtSuffix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuffix.TextChanged

    End Sub
End Class