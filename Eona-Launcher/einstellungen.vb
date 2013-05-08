'einstellungen

Partial Class mainform


    WithEvents pnl As Panel
    WithEvents pnl2 As Panel
    WithEvents pnl3 As Panel
    WithEvents tbusname1 As TextBox
    WithEvents tbusname As TextBox
    WithEvents tbuspass As TextBox
    WithEvents txtpass As Label
    WithEvents txtname As Label
    WithEvents txtinfo As Label
    WithEvents txt As Label
    WithEvents txtlogininfo As Label
    WithEvents cmdlogin As Button
    WithEvents cmdexit As Button
    WithEvents cmdupdate As Button
    WithEvents cmdsave As Button
    WithEvents chbox As CheckBox
    Dim chboxpass As New CheckBox
    Dim chboxautostart As CheckBox




    Private Sub pbeinstellungen_Click(sender As Object, e As EventArgs) Handles bpeinstellungen.Click




        'mainpanel

        pnl = New Panel
        pnl.Name = "pnleinstellungen"
        pnl.Parent = Me
        pnl.BorderStyle = BorderStyle.None
        pnl.Location = New Point(0, 35)
        pnl.Size = New Size(1010, 485)
        pnl.Visible = True
        pnl.BackColor = Color.FromArgb(100, Color.LightYellow)
        pnl.BringToFront()


        'Zurückpfeil
        Me.pbback.Show()
        pbback.BringToFront()
        pbback.Parent = pnl

        'operatepanel

        pnl2 = New Panel
        pnl2.Name = "pnloperate"
        pnl2.Parent = pnl
        pnl2.BorderStyle = BorderStyle.None
        pnl2.Location = New Point(5, 40)
        pnl2.Size = New Size(445, 430)
        pnl2.Visible = True
        pnl2.BackColor = Color.Transparent
        pnl.Controls.Add(pnl2)


        'Userdata lesen
        Dim user As New User
        user.load()



        'Login anzeige

        txt = New Label
        txt.Name = "txtlogin"
        txt.Parent = pnl2
        txt.Location = New Point(10, 55)
        txt.Size = New Size(123, 21)
        txt.Text = "Angemeldet als:"
        txt.Font = New Font(txt.Font.FontFamily, 12)

        tbusname1 = New TextBox
        tbusname1.Name = "tblogin"
        tbusname1.Parent = pnl2
        tbusname1.Location = New Point(210, 55)
        tbusname1.Size = New Size(150, 21)
        tbusname1.Text = User.username
        tbusname1.ReadOnly = True

        cmdlogin = New Button
        cmdlogin.Name = "cmdlogin"
        cmdlogin.Parent = pnl2
        cmdlogin.FlatStyle = FlatStyle.Flat
        cmdlogin.Location = New Point(370, 55)
        cmdlogin.Size = New Size(60, 21)
        cmdlogin.BackColor = Color.White
        cmdlogin.Text = "Ändern"
        AddHandler cmdlogin.Click, AddressOf cmdlogin_Click


        'pass merken


        txt = New Label
        txt.Name = "txtlogin"
        txt.Parent = pnl2
        txt.Location = New Point(10, 120)
        txt.Size = New Size(195, 21)
        txt.Text = "Passwort merken:"
        txt.Font = New Font(txt.Font.FontFamily, 12)


        chboxpass = New CheckBox
        chboxpass.Name = "chboxpass"
        chboxpass.Parent = pnl2
        chboxpass.Location = New Point(210, 120)

        AddHandler chboxpass.CheckedChanged, AddressOf chboxpass_checkedchanged

        'Systemstart

        txt = New Label
        txt.Name = "txtsysstart"
        txt.Parent = pnl2
        txt.Location = New Point(10, 185)
        txt.Size = New Size(195, 21)
        txt.Text = "Beim Systemstart starten:"
        txt.Font = New Font(txt.Font.FontFamily, 12)

        chboxautostart = New CheckBox
        chboxautostart.Name = "chboxautostart"
        chboxautostart.Parent = pnl2
        chboxautostart.Location = New Point(210, 184)

        If CheckAutorun() Then
            chboxautostart.Checked = True
        End If

        AddHandler chboxautostart.CheckedChanged, AddressOf chboxautostart_checkedchanged

        'Hintergrundbild

        txt = New Label
        txt.Name = "txtbg"
        txt.Parent = pnl2
        txt.Location = New Point(10, 250)
        txt.Size = New Size(195, 21)
        txt.Text = "Hintergrund ändern:"
        txt.Font = New Font(txt.Font.FontFamily, 12)

        chbox = New CheckBox
        chbox.Name = "chboxbg"
        chbox.Parent = pnl2
        chbox.Location = New Point(210, 250)

        'Eona login

        txt = New Label
        txt.Name = "txtlogin"
        txt.Parent = pnl2
        txt.Location = New Point(10, 320)
        txt.Size = New Size(195, 21)
        txt.Text = "Eona Login:"
        txt.Font = New Font(txt.Font.FontFamily, 12)

        chbox = New CheckBox
        chbox.Name = "chboxlogin"
        chbox.Parent = pnl2
        chbox.Location = New Point(210, 320)


        'Update suche


        txt = New Label
        txt.Name = "txtautoupdate"
        txt.Parent = pnl2
        txt.Location = New Point(10, 385)
        txt.Size = New Size(195, 21)
        txt.Text = "Automatisches Update:"
        txt.Font = New Font(txt.Font.FontFamily, 12)

        chbox = New CheckBox
        chbox.Name = "chboxautoupdate"
        chbox.Parent = pnl2
        chbox.Location = New Point(210, 385)

        cmdupdate = New Button
        cmdupdate.Name = "cmdupdate"
        cmdupdate.Parent = pnl2
        cmdupdate.BringToFront()
        cmdupdate.FlatStyle = FlatStyle.Flat
        cmdupdate.Location = New Point(245, 383)
        cmdupdate.Size = New Size(90, 24)
        cmdupdate.Text = "Update Now"
        cmdupdate.BackColor = Color.FromArgb(20, Color.Black)
        AddHandler cmdupdate.Click, AddressOf cmdupdate_CLick



    End Sub


    Private Sub cmdlogin_Click()


        'Userdata lesen
        Dim user As New User
        user.load()

        'loginpanel


        pnl3 = New Panel
        pnl3.Name = "pnleinstellungen"
        'pnl3.Parent = pnl
        pnl3.BorderStyle = BorderStyle.None
        pnl3.Location = New Point(490, 40)
        pnl3.Size = New Size(485, 430)
        pnl3.Visible = True
        pnl3.BackColor = Color.FromArgb(150, Color.LightYellow)
        pnl.Controls.Add(pnl3)

        'inhalt des panels

        txtinfo = New Label
        txtinfo.Name = "txtinfo"
        txtinfo.Parent = pnl3
        txtinfo.Location = New Point(15, 55)
        txtinfo.AutoSize = True
        txtinfo.Font = New Font(txt.Font.FontFamily, 16)
        txtinfo.BackColor = Color.Transparent
        txtinfo.ForeColor = Color.Red
        txtinfo.Text = "ACHTUNG: DIESE FUNKTION IST NICHT" & vbCrLf & "DAZU DA MIT MEHREREN ACCOUNTS ZU" & vbCrLf & "SPIELEN!" & vbCrLf & "MULTIACCOUNT SPIELER " & vbCrLf & "WERDEN MIT IPBAN BESTRAFT!!"

        'txtbox und label für namens änderung

        txtname = New Label
        txtname.Name = "txtname"
        txtname.Parent = pnl3
        txtname.Location = New Point(15, 230)
        txtname.BackColor = Color.Transparent
        txtname.Font = New Font(txt.Font.FontFamily, 14)
        txtname.AutoSize = True
        txtname.Text = "Username:"

        tbusname = New TextBox
        tbusname.Name = "tbusname"
        tbusname.Parent = pnl3
        tbusname.Location = New Point(180, 233)
        tbusname.Size = New Size(280, 16)
        tbusname.Text = user.username
        tbusname.ReadOnly = False

        'textbox und lable für passwort eingabe

        txtpass = New Label
        txtpass.Name = "txtpass"
        txtpass.Parent = pnl3
        txtpass.Location = New Point(15, 270)
        txtpass.BackColor = Color.Transparent
        txtpass.Font = New Font(txt.Font.FontFamily, 14)
        txtpass.AutoSize = True
        txtpass.Text = "Passwort:"



        tbuspass = New TextBox
        tbuspass.Name = "tbuspass"
        tbuspass.Parent = pnl3
        tbuspass.Location = New Point(180, 270)
        tbuspass.Size = New Size(280, 16)
        tbuspass.ReadOnly = False
        tbuspass.PasswordChar = "*"
        tbuspass.Text = user.password


        ' Info label ob Erfolgreich

        txtlogininfo = New Label
        txtlogininfo.Name = "lbllogininfo"
        txtlogininfo.Parent = pnl3
        txtlogininfo.Location = New Point(180, 310)
        txtlogininfo.BackColor = Color.Transparent
        txtlogininfo.Font = New Font(txt.Font.FontFamily, 22)
        txtlogininfo.AutoSize = True

        'button zum speichern

        cmdsave = New Button
        cmdsave.Name = "cmdsave"
        cmdsave.Parent = pnl3
        cmdsave.FlatStyle = FlatStyle.Flat
        cmdsave.Location = New Point(350, 380)
        cmdsave.Size = New Size(100, 25)
        cmdsave.BackColor = Color.White
        cmdsave.Text = "Speichern"
        AddHandler cmdsave.Click, AddressOf cmdsave_Click


        'Button zum abbrechen

        cmdexit = New Button
        cmdexit.Name = "cmdexit"
        cmdexit.Parent = pnl3
        cmdexit.FlatStyle = FlatStyle.Flat
        cmdexit.Location = New Point(200, 380)
        cmdexit.Size = New Size(100, 25)
        cmdexit.BackColor = Color.White
        cmdexit.Text = "Abbrechen"
        AddHandler cmdexit.Click, AddressOf cmdexit_Click



    End Sub

    Private Sub cmdexit_Click()

        Try

            pnl.Controls.Remove(pnl3)

        Catch ex As Exception

        End Try


    End Sub


   
End Class