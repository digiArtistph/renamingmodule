<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listtolist
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Kenneth", "One, Two, Three, Four, Five"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Myla")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Megan")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Kyla")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Miko")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.stlblMessage = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(582, 331)
        Me.SplitContainer1.SplitterDistance = 194
        Me.SplitContainer1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewItem1.ToolTipText = "Kenneth P. Vallejos"
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(194, 331)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ListView2
        '
        Me.ListView2.AllowDrop = True
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(384, 331)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.List
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlblMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 309)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(582, 22)
        Me.StatusStrip1.TabIndex = 1
        '
        'stlblMessage
        '
        Me.stlblMessage.Name = "stlblMessage"
        Me.stlblMessage.Size = New System.Drawing.Size(77, 17)
        Me.stlblMessage.Text = "Status: Ready"
        '
        'listtolist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 331)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "listtolist"
        Me.Text = "listtolist"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stlblMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
End Class
