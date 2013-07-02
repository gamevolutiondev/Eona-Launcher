<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Me.tbpbzurück = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbback = New System.Windows.Forms.PictureBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdminimize = New System.Windows.Forms.Button()
        Me.pnllogin = New System.Windows.Forms.Panel()
        Me.lbllogin2 = New System.Windows.Forms.Label()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.bpeinstellungen = New System.Windows.Forms.PictureBox()
        Me.balkenoben = New System.Windows.Forms.PictureBox()
        Me.pbaudio = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.pbback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnllogin.SuspendLayout()
        CType(Me.bpeinstellungen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.balkenoben, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbaudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbback
        '
        Me.pbback.BackColor = System.Drawing.Color.Transparent
        Me.pbback.Image = Global.Eona_Launcher.My.Resources.Resources.zurückpfeil1
        Me.pbback.Location = New System.Drawing.Point(12, 45)
        Me.pbback.Name = "pbback"
        Me.pbback.Size = New System.Drawing.Size(71, 27)
        Me.pbback.TabIndex = 2
        Me.pbback.TabStop = False
        Me.tbpbzurück.SetToolTip(Me.pbback, "Zurück")
        Me.pbback.Visible = False
        '
        'cmdclose
        '
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Location = New System.Drawing.Point(937, 7)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(45, 22)
        Me.cmdclose.TabIndex = 4
        Me.cmdclose.Text = "X"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdminimize
        '
        Me.cmdminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdminimize.Location = New System.Drawing.Point(880, 7)
        Me.cmdminimize.Name = "cmdminimize"
        Me.cmdminimize.Size = New System.Drawing.Size(45, 22)
        Me.cmdminimize.TabIndex = 5
        Me.cmdminimize.Text = "------------"
        Me.cmdminimize.UseVisualStyleBackColor = True
        '
        'pnllogin
        '
        Me.pnllogin.Controls.Add(Me.lbllogin2)
        Me.pnllogin.Controls.Add(Me.lbllogin)
        Me.pnllogin.Location = New System.Drawing.Point(12, 477)
        Me.pnllogin.Name = "pnllogin"
        Me.pnllogin.Size = New System.Drawing.Size(401, 31)
        Me.pnllogin.TabIndex = 7
        '
        'lbllogin2
        '
        Me.lbllogin2.AutoSize = True
        Me.lbllogin2.BackColor = System.Drawing.Color.Transparent
        Me.lbllogin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbllogin2.Location = New System.Drawing.Point(101, 7)
        Me.lbllogin2.Name = "lbllogin2"
        Me.lbllogin2.Size = New System.Drawing.Size(0, 16)
        Me.lbllogin2.TabIndex = 1
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.BackColor = System.Drawing.Color.Transparent
        Me.lbllogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbllogin.Location = New System.Drawing.Point(3, 7)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(97, 16)
        Me.lbllogin.TabIndex = 0
        Me.lbllogin.Text = "Eingeloggt als:"
        '
        'bpeinstellungen
        '
        Me.bpeinstellungen.BackColor = System.Drawing.Color.Transparent
        Me.bpeinstellungen.Image = Global.Eona_Launcher.My.Resources.Resources.Zahnrad
        Me.bpeinstellungen.Location = New System.Drawing.Point(848, 7)
        Me.bpeinstellungen.Name = "bpeinstellungen"
        Me.bpeinstellungen.Size = New System.Drawing.Size(24, 22)
        Me.bpeinstellungen.TabIndex = 6
        Me.bpeinstellungen.TabStop = False
        '
        'balkenoben
        '
        Me.balkenoben.Image = Global.Eona_Launcher.My.Resources.Resources.balkenoben
        Me.balkenoben.Location = New System.Drawing.Point(0, -1)
        Me.balkenoben.Name = "balkenoben"
        Me.balkenoben.Size = New System.Drawing.Size(1027, 40)
        Me.balkenoben.TabIndex = 3
        Me.balkenoben.TabStop = False
        '
        'pbaudio
        '
        Me.pbaudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbaudio.Location = New System.Drawing.Point(818, 7)
        Me.pbaudio.Name = "pbaudio"
        Me.pbaudio.Size = New System.Drawing.Size(24, 22)
        Me.pbaudio.TabIndex = 8
        Me.pbaudio.TabStop = False
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 520)
        Me.Controls.Add(Me.pbaudio)
        Me.Controls.Add(Me.pnllogin)
        Me.Controls.Add(Me.bpeinstellungen)
        Me.Controls.Add(Me.cmdminimize)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.balkenoben)
        Me.Controls.Add(Me.pbback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainform"
        CType(Me.pbback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnllogin.ResumeLayout(False)
        Me.pnllogin.PerformLayout()
        CType(Me.bpeinstellungen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.balkenoben, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbaudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbpbzurück As System.Windows.Forms.ToolTip
    Friend WithEvents pbback As System.Windows.Forms.PictureBox
    Friend WithEvents balkenoben As System.Windows.Forms.PictureBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdminimize As System.Windows.Forms.Button
    Friend WithEvents bpeinstellungen As System.Windows.Forms.PictureBox
    Friend WithEvents pnllogin As System.Windows.Forms.Panel
    Friend WithEvents lbllogin2 As System.Windows.Forms.Label
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents pbaudio As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
