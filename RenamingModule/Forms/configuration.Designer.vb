<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configuration))
        Me.btnApply = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkSuffixIncrement = New System.Windows.Forms.CheckBox
        Me.txtSourceDirectory = New System.Windows.Forms.TextBox
        Me.txtDestinationDirectory = New System.Windows.Forms.TextBox
        Me.txtSiteNumber = New System.Windows.Forms.TextBox
        Me.txtSuffix = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.buttonDestinationDIR = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSourceDir = New System.Windows.Forms.Button
        Me.grpFileFormat = New System.Windows.Forms.GroupBox
        Me.frmtSix = New System.Windows.Forms.RadioButton
        Me.frmtFive = New System.Windows.Forms.RadioButton
        Me.frmFour = New System.Windows.Forms.RadioButton
        Me.frmThree = New System.Windows.Forms.RadioButton
        Me.frmtTwo = New System.Windows.Forms.RadioButton
        Me.frmtOne = New System.Windows.Forms.RadioButton
        Me.vfldrbrowserSourceDir = New Ookii.Dialogs.VistaFolderBrowserDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.grpFileFormat.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(510, 228)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(90, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(606, 228)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Source Directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destination Directory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Site Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Suffix"
        '
        'chkSuffixIncrement
        '
        Me.chkSuffixIncrement.AutoSize = True
        Me.chkSuffixIncrement.Location = New System.Drawing.Point(131, 151)
        Me.chkSuffixIncrement.Name = "chkSuffixIncrement"
        Me.chkSuffixIncrement.Size = New System.Drawing.Size(102, 17)
        Me.chkSuffixIncrement.TabIndex = 4
        Me.chkSuffixIncrement.Text = "Increment Suffix"
        Me.chkSuffixIncrement.UseVisualStyleBackColor = True
        '
        'txtSourceDirectory
        '
        Me.txtSourceDirectory.Enabled = False
        Me.txtSourceDirectory.Location = New System.Drawing.Point(131, 39)
        Me.txtSourceDirectory.Name = "txtSourceDirectory"
        Me.txtSourceDirectory.Size = New System.Drawing.Size(216, 20)
        Me.txtSourceDirectory.TabIndex = 7
        '
        'txtDestinationDirectory
        '
        Me.txtDestinationDirectory.Enabled = False
        Me.txtDestinationDirectory.Location = New System.Drawing.Point(131, 69)
        Me.txtDestinationDirectory.Name = "txtDestinationDirectory"
        Me.txtDestinationDirectory.Size = New System.Drawing.Size(216, 20)
        Me.txtDestinationDirectory.TabIndex = 8
        '
        'txtSiteNumber
        '
        Me.txtSiteNumber.Location = New System.Drawing.Point(131, 97)
        Me.txtSiteNumber.Name = "txtSiteNumber"
        Me.txtSiteNumber.Size = New System.Drawing.Size(250, 20)
        Me.txtSiteNumber.TabIndex = 2
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(131, 125)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(102, 20)
        Me.txtSuffix.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.buttonDestinationDIR)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSourceDir)
        Me.GroupBox1.Controls.Add(Me.txtSiteNumber)
        Me.GroupBox1.Controls.Add(Me.txtSuffix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDestinationDirectory)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSourceDirectory)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chkSuffixIncrement)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Renaming Module Settings"
        '
        'buttonDestinationDIR
        '
        Me.buttonDestinationDIR.Location = New System.Drawing.Point(353, 66)
        Me.buttonDestinationDIR.Name = "buttonDestinationDIR"
        Me.buttonDestinationDIR.Size = New System.Drawing.Size(28, 24)
        Me.buttonDestinationDIR.TabIndex = 11
        Me.buttonDestinationDIR.Text = "..."
        Me.buttonDestinationDIR.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(230, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(239, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "e.g. 123.2 or 123"
        '
        'btnSourceDir
        '
        Me.btnSourceDir.Location = New System.Drawing.Point(353, 35)
        Me.btnSourceDir.Name = "btnSourceDir"
        Me.btnSourceDir.Size = New System.Drawing.Size(28, 24)
        Me.btnSourceDir.TabIndex = 0
        Me.btnSourceDir.Text = "..."
        Me.btnSourceDir.UseVisualStyleBackColor = True
        '
        'grpFileFormat
        '
        Me.grpFileFormat.Controls.Add(Me.frmtSix)
        Me.grpFileFormat.Controls.Add(Me.frmtFive)
        Me.grpFileFormat.Controls.Add(Me.frmFour)
        Me.grpFileFormat.Controls.Add(Me.frmThree)
        Me.grpFileFormat.Controls.Add(Me.frmtTwo)
        Me.grpFileFormat.Controls.Add(Me.frmtOne)
        Me.grpFileFormat.Location = New System.Drawing.Point(420, 16)
        Me.grpFileFormat.Name = "grpFileFormat"
        Me.grpFileFormat.Size = New System.Drawing.Size(276, 196)
        Me.grpFileFormat.TabIndex = 1
        Me.grpFileFormat.TabStop = False
        Me.grpFileFormat.Text = "Filename Formatting"
        '
        'frmtSix
        '
        Me.frmtSix.AutoSize = True
        Me.frmtSix.Location = New System.Drawing.Point(25, 147)
        Me.frmtSix.Name = "frmtSix"
        Me.frmtSix.Size = New System.Drawing.Size(192, 17)
        Me.frmtSix.TabIndex = 10
        Me.frmtSix.Text = "<SiteNumber>-<FileName>-<Suffix>"
        Me.frmtSix.UseVisualStyleBackColor = True
        '
        'frmtFive
        '
        Me.frmtFive.AutoSize = True
        Me.frmtFive.Location = New System.Drawing.Point(25, 122)
        Me.frmtFive.Name = "frmtFive"
        Me.frmtFive.Size = New System.Drawing.Size(198, 17)
        Me.frmtFive.TabIndex = 9
        Me.frmtFive.Text = "<SiteNumber>_<FileName>_<Suffix>"
        Me.frmtFive.UseVisualStyleBackColor = True
        '
        'frmFour
        '
        Me.frmFour.AutoSize = True
        Me.frmFour.Location = New System.Drawing.Point(25, 100)
        Me.frmFour.Name = "frmFour"
        Me.frmFour.Size = New System.Drawing.Size(133, 17)
        Me.frmFour.TabIndex = 8
        Me.frmFour.Text = "<SiteNumber>-<Suffix>"
        Me.frmFour.UseVisualStyleBackColor = True
        '
        'frmThree
        '
        Me.frmThree.AutoSize = True
        Me.frmThree.Location = New System.Drawing.Point(25, 77)
        Me.frmThree.Name = "frmThree"
        Me.frmThree.Size = New System.Drawing.Size(136, 17)
        Me.frmThree.TabIndex = 7
        Me.frmThree.Text = "<SiteNumber>_<Suffix>"
        Me.frmThree.UseVisualStyleBackColor = True
        '
        'frmtTwo
        '
        Me.frmtTwo.AutoSize = True
        Me.frmtTwo.Checked = True
        Me.frmtTwo.Location = New System.Drawing.Point(25, 54)
        Me.frmtTwo.Name = "frmtTwo"
        Me.frmtTwo.Size = New System.Drawing.Size(215, 17)
        Me.frmtTwo.TabIndex = 6
        Me.frmtTwo.TabStop = True
        Me.frmtTwo.Text = "<SiteNumber><ImageFileName><Suffix>"
        Me.frmtTwo.UseVisualStyleBackColor = True
        '
        'frmtOne
        '
        Me.frmtOne.AutoSize = True
        Me.frmtOne.Location = New System.Drawing.Point(25, 31)
        Me.frmtOne.Name = "frmtOne"
        Me.frmtOne.Size = New System.Drawing.Size(130, 17)
        Me.frmtOne.TabIndex = 5
        Me.frmtOne.Text = "<SiteNumber><Suffix>"
        Me.frmtOne.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(9, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "* Increments by 0.1 if suffix has decimal numbers, otherwise by 1."
        '
        'configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(714, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpFileFormat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpFileFormat.ResumeLayout(False)
        Me.grpFileFormat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSuffixIncrement As System.Windows.Forms.CheckBox
    Friend WithEvents txtSourceDirectory As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationDirectory As System.Windows.Forms.TextBox
    Friend WithEvents txtSiteNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpFileFormat As System.Windows.Forms.GroupBox
    Friend WithEvents frmtTwo As System.Windows.Forms.RadioButton
    Friend WithEvents frmtOne As System.Windows.Forms.RadioButton
    Friend WithEvents frmtSix As System.Windows.Forms.RadioButton
    Friend WithEvents frmtFive As System.Windows.Forms.RadioButton
    Friend WithEvents frmFour As System.Windows.Forms.RadioButton
    Friend WithEvents frmThree As System.Windows.Forms.RadioButton
    Friend WithEvents btnSourceDir As System.Windows.Forms.Button
    Friend WithEvents vfldrbrowserSourceDir As Ookii.Dialogs.VistaFolderBrowserDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents buttonDestinationDIR As System.Windows.Forms.Button

End Class
