<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenamingModule
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
        Me.stripStatus = New System.Windows.Forms.StatusStrip
        Me.stripMessage = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.pcImage = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lsNames = New System.Windows.Forms.ListBox
        Me.lsSource = New System.Windows.Forms.ListBox
        Me.stripStatus.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stripStatus
        '
        Me.stripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMessage})
        Me.stripStatus.Location = New System.Drawing.Point(0, 514)
        Me.stripStatus.Name = "stripStatus"
        Me.stripStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.stripStatus.Size = New System.Drawing.Size(893, 22)
        Me.stripStatus.TabIndex = 0
        '
        'stripMessage
        '
        Me.stripMessage.Name = "stripMessage"
        Me.stripMessage.Size = New System.Drawing.Size(39, 17)
        Me.stripMessage.Text = "Ready"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(150, 100)
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.pcImage)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lsSource)
        Me.SplitContainer2.Size = New System.Drawing.Size(893, 514)
        Me.SplitContainer2.SplitterDistance = 297
        Me.SplitContainer2.TabIndex = 1
        '
        'pcImage
        '
        Me.pcImage.Location = New System.Drawing.Point(12, 46)
        Me.pcImage.Name = "pcImage"
        Me.pcImage.Size = New System.Drawing.Size(108, 81)
        Me.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcImage.TabIndex = 1
        Me.pcImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lsNames)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 288)
        Me.Panel1.TabIndex = 0
        '
        'lsNames
        '
        Me.lsNames.FormattingEnabled = True
        Me.lsNames.Location = New System.Drawing.Point(12, 16)
        Me.lsNames.Name = "lsNames"
        Me.lsNames.Size = New System.Drawing.Size(270, 251)
        Me.lsNames.TabIndex = 1
        '
        'lsSource
        '
        Me.lsSource.AllowDrop = True
        Me.lsSource.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsSource.FormattingEnabled = True
        Me.lsSource.Location = New System.Drawing.Point(0, 224)
        Me.lsSource.Name = "lsSource"
        Me.lsSource.Size = New System.Drawing.Size(592, 290)
        Me.lsSource.TabIndex = 0
        '
        'RenamingModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 536)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.stripStatus)
        Me.Name = "RenamingModule"
        Me.Text = "RenamingModule"
        Me.stripStatus.ResumeLayout(False)
        Me.stripStatus.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stripStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents stripMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lsNames As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lsSource As System.Windows.Forms.ListBox
    Friend WithEvents pcImage As System.Windows.Forms.PictureBox
End Class
