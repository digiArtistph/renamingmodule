﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class directorysample
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnGetAllFiles = New System.Windows.Forms.Button
        Me.bntFileSubDir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Entries"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Get Entries - Pattern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnGetAllFiles
        '
        Me.btnGetAllFiles.Location = New System.Drawing.Point(55, 94)
        Me.btnGetAllFiles.Name = "btnGetAllFiles"
        Me.btnGetAllFiles.Size = New System.Drawing.Size(169, 23)
        Me.btnGetAllFiles.TabIndex = 2
        Me.btnGetAllFiles.Text = "Get All Files"
        Me.btnGetAllFiles.UseVisualStyleBackColor = True
        '
        'bntFileSubDir
        '
        Me.bntFileSubDir.Location = New System.Drawing.Point(55, 123)
        Me.bntFileSubDir.Name = "bntFileSubDir"
        Me.bntFileSubDir.Size = New System.Drawing.Size(169, 23)
        Me.bntFileSubDir.TabIndex = 3
        Me.bntFileSubDir.Text = "Get All Files from Sub-directories"
        Me.bntFileSubDir.UseVisualStyleBackColor = True
        '
        'directorysample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 182)
        Me.Controls.Add(Me.bntFileSubDir)
        Me.Controls.Add(Me.btnGetAllFiles)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "directorysample"
        Me.Text = "directory"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnGetAllFiles As System.Windows.Forms.Button
    Friend WithEvents bntFileSubDir As System.Windows.Forms.Button
End Class
