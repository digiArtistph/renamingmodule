<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.spltcntrMain = New System.Windows.Forms.SplitContainer
        Me.spltSourceUpperLower = New System.Windows.Forms.SplitContainer
        Me.picbxSourceViewer = New System.Windows.Forms.PictureBox
        Me.lblSourcePath = New System.Windows.Forms.Label
        Me.btnBrowseSource = New System.Windows.Forms.Button
        Me.flwSourcePictures = New System.Windows.Forms.FlowLayoutPanel
        Me.spltDestination = New System.Windows.Forms.SplitContainer
        Me.picbxDestinationViewer = New System.Windows.Forms.PictureBox
        Me.spltDestinationUpperLower = New System.Windows.Forms.SplitContainer
        Me.dgridPictures = New System.Windows.Forms.DataGridView
        Me.selectid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.sitenumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.suffix = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.newfilename = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.absolutepath = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btndel = New System.Windows.Forms.DataGridViewButtonColumn
        Me.lblDestinationPath = New System.Windows.Forms.Label
        Me.btnRenamePictures = New System.Windows.Forms.Button
        Me.statSystemState = New System.Windows.Forms.StatusStrip
        Me.stripLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BrowsePicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RenamePToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.fdlrdlgSourcePictures = New System.Windows.Forms.FolderBrowserDialog
        Me.picSourceLabel = New System.Windows.Forms.Label
        Me.picDestinationLabel = New System.Windows.Forms.Label
        Me.spltcntrMain.Panel1.SuspendLayout()
        Me.spltcntrMain.Panel2.SuspendLayout()
        Me.spltcntrMain.SuspendLayout()
        Me.spltSourceUpperLower.Panel1.SuspendLayout()
        Me.spltSourceUpperLower.Panel2.SuspendLayout()
        Me.spltSourceUpperLower.SuspendLayout()
        CType(Me.picbxSourceViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltDestination.Panel1.SuspendLayout()
        Me.spltDestination.Panel2.SuspendLayout()
        Me.spltDestination.SuspendLayout()
        CType(Me.picbxDestinationViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltDestinationUpperLower.Panel1.SuspendLayout()
        Me.spltDestinationUpperLower.Panel2.SuspendLayout()
        Me.spltDestinationUpperLower.SuspendLayout()
        CType(Me.dgridPictures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statSystemState.SuspendLayout()
        Me.mnuMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'spltcntrMain
        '
        Me.spltcntrMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spltcntrMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltcntrMain.IsSplitterFixed = True
        Me.spltcntrMain.Location = New System.Drawing.Point(0, 24)
        Me.spltcntrMain.Name = "spltcntrMain"
        '
        'spltcntrMain.Panel1
        '
        Me.spltcntrMain.Panel1.Controls.Add(Me.spltSourceUpperLower)
        '
        'spltcntrMain.Panel2
        '
        Me.spltcntrMain.Panel2.Controls.Add(Me.spltDestination)
        Me.spltcntrMain.Size = New System.Drawing.Size(1008, 636)
        Me.spltcntrMain.SplitterDistance = 483
        Me.spltcntrMain.TabIndex = 0
        '
        'spltSourceUpperLower
        '
        Me.spltSourceUpperLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spltSourceUpperLower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltSourceUpperLower.Location = New System.Drawing.Point(0, 0)
        Me.spltSourceUpperLower.Name = "spltSourceUpperLower"
        Me.spltSourceUpperLower.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltSourceUpperLower.Panel1
        '
        Me.spltSourceUpperLower.Panel1.Controls.Add(Me.picSourceLabel)
        Me.spltSourceUpperLower.Panel1.Controls.Add(Me.picbxSourceViewer)
        '
        'spltSourceUpperLower.Panel2
        '
        Me.spltSourceUpperLower.Panel2.Controls.Add(Me.lblSourcePath)
        Me.spltSourceUpperLower.Panel2.Controls.Add(Me.btnBrowseSource)
        Me.spltSourceUpperLower.Panel2.Controls.Add(Me.flwSourcePictures)
        Me.spltSourceUpperLower.Size = New System.Drawing.Size(483, 636)
        Me.spltSourceUpperLower.SplitterDistance = 276
        Me.spltSourceUpperLower.TabIndex = 0
        '
        'picbxSourceViewer
        '
        Me.picbxSourceViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.picbxSourceViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picbxSourceViewer.Image = Global.RenamingModule.My.Resources.Resources.image_icon1_copy
        Me.picbxSourceViewer.Location = New System.Drawing.Point(0, 0)
        Me.picbxSourceViewer.Name = "picbxSourceViewer"
        Me.picbxSourceViewer.Size = New System.Drawing.Size(479, 272)
        Me.picbxSourceViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbxSourceViewer.TabIndex = 1
        Me.picbxSourceViewer.TabStop = False
        '
        'lblSourcePath
        '
        Me.lblSourcePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSourcePath.AutoSize = True
        Me.lblSourcePath.Location = New System.Drawing.Point(10, 318)
        Me.lblSourcePath.Name = "lblSourcePath"
        Me.lblSourcePath.Size = New System.Drawing.Size(89, 13)
        Me.lblSourcePath.TabIndex = 2
        Me.lblSourcePath.Text = "Source Directory:"
        '
        'btnBrowseSource
        '
        Me.btnBrowseSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseSource.Location = New System.Drawing.Point(324, 306)
        Me.btnBrowseSource.Name = "btnBrowseSource"
        Me.btnBrowseSource.Size = New System.Drawing.Size(142, 36)
        Me.btnBrowseSource.TabIndex = 1
        Me.btnBrowseSource.Text = "Browse Pictures"
        Me.btnBrowseSource.UseVisualStyleBackColor = True
        '
        'flwSourcePictures
        '
        Me.flwSourcePictures.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flwSourcePictures.AutoScroll = True
        Me.flwSourcePictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flwSourcePictures.Location = New System.Drawing.Point(0, 0)
        Me.flwSourcePictures.Name = "flwSourcePictures"
        Me.flwSourcePictures.Size = New System.Drawing.Size(479, 294)
        Me.flwSourcePictures.TabIndex = 0
        '
        'spltDestination
        '
        Me.spltDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spltDestination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltDestination.Location = New System.Drawing.Point(0, 0)
        Me.spltDestination.Name = "spltDestination"
        Me.spltDestination.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltDestination.Panel1
        '
        Me.spltDestination.Panel1.Controls.Add(Me.picDestinationLabel)
        Me.spltDestination.Panel1.Controls.Add(Me.picbxDestinationViewer)
        '
        'spltDestination.Panel2
        '
        Me.spltDestination.Panel2.Controls.Add(Me.spltDestinationUpperLower)
        Me.spltDestination.Size = New System.Drawing.Size(521, 636)
        Me.spltDestination.SplitterDistance = 276
        Me.spltDestination.TabIndex = 0
        '
        'picbxDestinationViewer
        '
        Me.picbxDestinationViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picbxDestinationViewer.Image = Global.RenamingModule.My.Resources.Resources.image_icon1_copy
        Me.picbxDestinationViewer.Location = New System.Drawing.Point(0, 0)
        Me.picbxDestinationViewer.Name = "picbxDestinationViewer"
        Me.picbxDestinationViewer.Size = New System.Drawing.Size(517, 272)
        Me.picbxDestinationViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbxDestinationViewer.TabIndex = 2
        Me.picbxDestinationViewer.TabStop = False
        '
        'spltDestinationUpperLower
        '
        Me.spltDestinationUpperLower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spltDestinationUpperLower.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spltDestinationUpperLower.Location = New System.Drawing.Point(0, 0)
        Me.spltDestinationUpperLower.Name = "spltDestinationUpperLower"
        Me.spltDestinationUpperLower.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spltDestinationUpperLower.Panel1
        '
        Me.spltDestinationUpperLower.Panel1.Controls.Add(Me.dgridPictures)
        '
        'spltDestinationUpperLower.Panel2
        '
        Me.spltDestinationUpperLower.Panel2.Controls.Add(Me.lblDestinationPath)
        Me.spltDestinationUpperLower.Panel2.Controls.Add(Me.btnRenamePictures)
        Me.spltDestinationUpperLower.Size = New System.Drawing.Size(517, 352)
        Me.spltDestinationUpperLower.SplitterDistance = 294
        Me.spltDestinationUpperLower.TabIndex = 0
        '
        'dgridPictures
        '
        Me.dgridPictures.AllowDrop = True
        Me.dgridPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPictures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectid, Me.sitenumber, Me.suffix, Me.newfilename, Me.absolutepath, Me.btndel})
        Me.dgridPictures.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgridPictures.Location = New System.Drawing.Point(0, 0)
        Me.dgridPictures.MultiSelect = False
        Me.dgridPictures.Name = "dgridPictures"
        Me.dgridPictures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridPictures.Size = New System.Drawing.Size(517, 294)
        Me.dgridPictures.TabIndex = 6
        '
        'selectid
        '
        Me.selectid.HeaderText = ""
        Me.selectid.Name = "selectid"
        Me.selectid.Visible = False
        Me.selectid.Width = 20
        '
        'sitenumber
        '
        Me.sitenumber.HeaderText = "Site Number"
        Me.sitenumber.Name = "sitenumber"
        '
        'suffix
        '
        Me.suffix.HeaderText = "Suffx"
        Me.suffix.Name = "suffix"
        '
        'newfilename
        '
        Me.newfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.newfilename.HeaderText = "File Name"
        Me.newfilename.Name = "newfilename"
        '
        'absolutepath
        '
        Me.absolutepath.HeaderText = "Absolute Path"
        Me.absolutepath.Name = "absolutepath"
        Me.absolutepath.Visible = False
        '
        'btndel
        '
        Me.btndel.HeaderText = "Commands"
        Me.btndel.Name = "btndel"
        Me.btndel.Width = 75
        '
        'lblDestinationPath
        '
        Me.lblDestinationPath.AutoSize = True
        Me.lblDestinationPath.Location = New System.Drawing.Point(13, 20)
        Me.lblDestinationPath.Name = "lblDestinationPath"
        Me.lblDestinationPath.Size = New System.Drawing.Size(108, 13)
        Me.lblDestinationPath.TabIndex = 3
        Me.lblDestinationPath.Text = "Destination Directory:"
        '
        'btnRenamePictures
        '
        Me.btnRenamePictures.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenamePictures.Location = New System.Drawing.Point(365, 8)
        Me.btnRenamePictures.Name = "btnRenamePictures"
        Me.btnRenamePictures.Size = New System.Drawing.Size(142, 36)
        Me.btnRenamePictures.TabIndex = 0
        Me.btnRenamePictures.Text = "Rename Pictures"
        Me.btnRenamePictures.UseVisualStyleBackColor = True
        '
        'statSystemState
        '
        Me.statSystemState.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripLabel})
        Me.statSystemState.Location = New System.Drawing.Point(0, 660)
        Me.statSystemState.Name = "statSystemState"
        Me.statSystemState.Size = New System.Drawing.Size(1008, 22)
        Me.statSystemState.TabIndex = 0
        Me.statSystemState.Text = "StatusStrip1"
        '
        'stripLabel
        '
        Me.stripLabel.Name = "stripLabel"
        Me.stripLabel.Size = New System.Drawing.Size(77, 17)
        Me.stripLabel.Text = "Status: Ready"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ProcessToolStripMenuItem, Me.OptionToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 24)
        Me.mnuMainMenu.TabIndex = 2
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowsePicturesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'BrowsePicturesToolStripMenuItem
        '
        Me.BrowsePicturesToolStripMenuItem.Name = "BrowsePicturesToolStripMenuItem"
        Me.BrowsePicturesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BrowsePicturesToolStripMenuItem.Text = "Browse Pictures"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenamePToolStripMenuItem})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProcessToolStripMenuItem.Text = "&Process"
        '
        'RenamePToolStripMenuItem
        '
        Me.RenamePToolStripMenuItem.Name = "RenamePToolStripMenuItem"
        Me.RenamePToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RenamePToolStripMenuItem.Text = "Ren&ame Pictures"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'fdlrdlgSourcePictures
        '
        Me.fdlrdlgSourcePictures.ShowNewFolderButton = False
        '
        'picSourceLabel
        '
        Me.picSourceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSourceLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.picSourceLabel.Location = New System.Drawing.Point(1, 110)
        Me.picSourceLabel.Name = "picSourceLabel"
        Me.picSourceLabel.Size = New System.Drawing.Size(477, 13)
        Me.picSourceLabel.TabIndex = 2
        Me.picSourceLabel.Text = "Select a file to preview."
        Me.picSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDestinationLabel
        '
        Me.picDestinationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picDestinationLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.picDestinationLabel.Location = New System.Drawing.Point(1, 110)
        Me.picDestinationLabel.Name = "picDestinationLabel"
        Me.picDestinationLabel.Size = New System.Drawing.Size(518, 13)
        Me.picDestinationLabel.TabIndex = 3
        Me.picDestinationLabel.Text = "Select a file to preview."
        Me.picDestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 682)
        Me.Controls.Add(Me.spltcntrMain)
        Me.Controls.Add(Me.statSystemState)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Renaming Module"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spltcntrMain.Panel1.ResumeLayout(False)
        Me.spltcntrMain.Panel2.ResumeLayout(False)
        Me.spltcntrMain.ResumeLayout(False)
        Me.spltSourceUpperLower.Panel1.ResumeLayout(False)
        Me.spltSourceUpperLower.Panel2.ResumeLayout(False)
        Me.spltSourceUpperLower.Panel2.PerformLayout()
        Me.spltSourceUpperLower.ResumeLayout(False)
        CType(Me.picbxSourceViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltDestination.Panel1.ResumeLayout(False)
        Me.spltDestination.Panel2.ResumeLayout(False)
        Me.spltDestination.ResumeLayout(False)
        CType(Me.picbxDestinationViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltDestinationUpperLower.Panel1.ResumeLayout(False)
        Me.spltDestinationUpperLower.Panel2.ResumeLayout(False)
        Me.spltDestinationUpperLower.Panel2.PerformLayout()
        Me.spltDestinationUpperLower.ResumeLayout(False)
        CType(Me.dgridPictures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statSystemState.ResumeLayout(False)
        Me.statSystemState.PerformLayout()
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents spltcntrMain As System.Windows.Forms.SplitContainer
    Friend WithEvents statSystemState As System.Windows.Forms.StatusStrip
    Friend WithEvents stripLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents spltDestination As System.Windows.Forms.SplitContainer
    Friend WithEvents picbxDestinationViewer As System.Windows.Forms.PictureBox
    Friend WithEvents spltDestinationUpperLower As System.Windows.Forms.SplitContainer
    Friend WithEvents dgridPictures As System.Windows.Forms.DataGridView
    Friend WithEvents btnRenamePictures As System.Windows.Forms.Button
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowsePicturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenamePToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents spltSourceUpperLower As System.Windows.Forms.SplitContainer
    Friend WithEvents picbxSourceViewer As System.Windows.Forms.PictureBox
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents flwSourcePictures As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnBrowseSource As System.Windows.Forms.Button
    Friend WithEvents lblSourcePath As System.Windows.Forms.Label
    Friend WithEvents lblDestinationPath As System.Windows.Forms.Label
    Friend WithEvents fdlrdlgSourcePictures As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents selectid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sitenumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suffix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents newfilename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents absolutepath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents picSourceLabel As System.Windows.Forms.Label
    Friend WithEvents picDestinationLabel As System.Windows.Forms.Label
End Class
