<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changelog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbchangelog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbchangelog
        '
        Me.tbchangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbchangelog.Location = New System.Drawing.Point(0, 0)
        Me.tbchangelog.Multiline = True
        Me.tbchangelog.Name = "tbchangelog"
        Me.tbchangelog.ReadOnly = True
        Me.tbchangelog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.tbchangelog.Size = New System.Drawing.Size(637, 423)
        Me.tbchangelog.TabIndex = 0
        '
        'changelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 423)
        Me.Controls.Add(Me.tbchangelog)
        Me.Name = "changelog"
        Me.Text = "changelog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbchangelog As System.Windows.Forms.TextBox
End Class
