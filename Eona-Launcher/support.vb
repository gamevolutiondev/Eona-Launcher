
'support

Partial Class mainform

    Dim pnlsup As New Panel
    WithEvents cmdsup As Button
    WithEvents cmdteam As Button
    WithEvents cmdhystory As Button
    WithEvents cmdme As Button
    WithEvents cmdforum As Button
    WithEvents cmdemail As Button
    WithEvents cmdchangelog As Button
    WithEvents pnlsup2 As Panel
    WithEvents lblsup As Label
    WithEvents lblmever As Label
    WithEvents webbrowsersup As WebBrowser





    Public Sub pnlsupport()

        pnlsup = New Panel
        pnlsup.Name = "pnlmc"
        pnlsup.Parent = Me
        pnlsup.Location = New Point(750, 300)
        pnlsup.Size = New Size(160, 160)
        pnlsup.Visible = True
        pnlsup.BackgroundImage = My.Resources.Support
        pnlsup.BackgroundImageLayout = ImageLayout.Stretch
        pnlsup.BackColor = Color.Transparent
        'pnlsup.BackColor = Color.FromArgb(100, Color.LightYellow)
        pnlsup.BringToFront()

        AddHandler pnlsup.Click, AddressOf pnlsup_Click

    End Sub

    Private Sub pnlsup_Click()

        pnlsup.Location = New Point(0, 35)
        pnlsup.Size = New Size(1010, 485)
        pnlsup.BackColor = Color.Transparent
        pnlsup.BringToFront()
        pnlsup.BackgroundImage = Nothing

        pbback.Show()
        pbback.BringToFront()


        pnlsup2 = New Panel
        pnlsup2.Parent = pnlsup
        pnlsup2.Hide()
        pnlsup2.Location = New Point(420, 10)
        pnlsup2.Size = New Size(570, 460)
        pnlsup2.BackColor = Color.FromArgb(100, Color.LightYellow)
        pnlsup2.BringToFront()



        cmdsup = New Button
        cmdsup.Parent = pnlsup
        cmdsup.Location = New Point(100, 120)
        cmdsup.Size = New Size(250, 40)
        cmdsup.FlatStyle = FlatStyle.System
        cmdsup.Text = "Support"
        cmdsup.Font = New Font(cmdsup.Font.FontFamily, 10)

        AddHandler cmdsup.Click, AddressOf cmdsup_CLick


        cmdteam = New Button
        cmdteam.Parent = pnlsup
        cmdteam.Location = New Point(100, 200)
        cmdteam.Size = New Size(250, 40)
        cmdteam.FlatStyle = FlatStyle.System
        cmdteam.Text = "Das Team"
        cmdteam.Font = New Font(cmdteam.Font.FontFamily, 10)

        AddHandler cmdteam.Click, AddressOf cmdteam_CLick


        cmdhystory = New Button
        cmdhystory.Parent = pnlsup
        cmdhystory.Location = New Point(100, 280)
        cmdhystory.Size = New Size(250, 40)
        cmdhystory.FlatStyle = FlatStyle.System
        cmdhystory.Text = "Geschichte"
        cmdhystory.Font = New Font(cmdhystory.Font.FontFamily, 10)

        AddHandler cmdhystory.Click, AddressOf cmdhystory_CLick


        cmdme = New Button
        cmdme.Parent = pnlsup
        cmdme.Location = New Point(100, 360)
        cmdme.Size = New Size(250, 40)
        cmdme.FlatStyle = FlatStyle.System
        cmdme.Text = "Über das Programm"
        cmdme.Font = New Font(cmdme.Font.FontFamily, 10)

        AddHandler cmdme.Click, AddressOf cmdme_Click

      

    End Sub


    Private Sub cmdsup_Click()

        pnlsup2.Show()
        Try

            webbrowsersup.Dispose()
            pnl2.Controls.Remove(webbrowsersup)


        Catch ex As Exception

        End Try


        lblsup = New Label
        lblsup.Parent = pnlsup2
        lblsup.BackColor = Color.FromArgb(100, Color.LightYellow)
        lblsup.Location = New Point(15, 15)
        lblsup.Font = New Font(lblsup.Font.FontFamily, 16)
        lblsup.Text = ("Fals sie irgent ein Problem haben" & vbCrLf & "können sie sich entweder in unserem Forum melden" & vbCrLf & "oder bei unserer E-Mail Adresse." & vbCrLf & "" & vbCrLf & "Wir versuchen so schnell wie möglich zu Antworten." & vbCrLf & "Dies kann aber bis zu 24 h dauern!")
        lblsup.AutoSize = True

        cmdforum = New Button
        cmdforum.Parent = pnlsup2
        cmdforum.Location = New Point(35, 240)
        cmdforum.Size = New Size(220, 40)
        cmdforum.FlatStyle = FlatStyle.System
        cmdforum.Text = "Forum: board.gamevolution.de"
        cmdforum.Font = New Font(cmdforum.Font.FontFamily, 10)

        AddHandler cmdforum.Click, AddressOf cmdforum_Click

        cmdemail = New Button
        cmdemail.Parent = pnlsup2
        cmdemail.Location = New Point(285, 240)
        cmdemail.Size = New Size(220, 40)
        cmdemail.FlatStyle = FlatStyle.System
        cmdemail.Text = "E-Mail: support@gamevolution.de"
        cmdemail.Font = New Font(cmdemail.Font.FontFamily, 10)

        AddHandler cmdemail.Click, AddressOf cmdemail_Click

    End Sub



    Private Sub cmdteam_Click()

        Dim urlteam As Uri = New Uri("http://eona.gamevolution.de/extern/eonalauncher/teamer.html")
        '?nopanel=true"

        pnlsup2.Show()

        webbrowsersup = New WebBrowser
        webbrowsersup.Name = "webrowserteam"
        webbrowsersup.Parent = pnlsup2
        webbrowsersup.Location = New Point(0, 0)
        webbrowsersup.Size = New Size(570, 460)
        webbrowsersup.BringToFront()
        webbrowsersup.Url = urlteam
        'webbrowsersup.Document.Body.Focus(15, 15)





    End Sub


    Private Sub cmdhystory_Click()

    

        Dim urlhystory As Uri = New Uri("http://eona.gamevolution.de/extern/eonalauncher/geschichte.html")
        '?nopanel=true"

        pnlsup2.Show()


        webbrowsersup = New WebBrowser
        webbrowsersup.Name = "webbrowserhystory"
        webbrowsersup.Parent = pnlsup2
        webbrowsersup.Location = New Point(0, 0)
        webbrowsersup.Size = New Size(570, 460)
        webbrowsersup.BringToFront()
        webbrowsersup.Url = urlhystory






    End Sub


    Private Sub cmdme_CLick()

        suphide()
        pnlsup2.Show()

        Try
            webbrowsersup.Dispose()
        Catch ex As Exception

        End Try


        lblmever = New Label
        lblmever.Parent = pnlsup2
        lblmever.BackColor = Color.FromArgb(100, Color.LightYellow)
        lblmever.Location = New Point(15, 15)
        lblmever.Font = New Font(lblmever.Font.FontFamily, 16)
        lblmever.Text = ("Name:" & vbTab & "     " & My.Application.Info.ProductName & vbCrLf & "Version:" & vbTab & "  " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & vbCrLf & "" & vbCrLf & "Von:" & vbTab & "              " & My.Application.Info.CompanyName & vbCrLf & "                      " & vbTab & My.Application.Info.Copyright & vbCrLf & "Entwicklern:" & vbTab & "  " & My.Application.Info.Trademark & vbCrLf & vbCrLf & "Beschreibung:" & "   Dies ist der Launcher von Gamevolution Dev" & vbCrLf & "                           für den Minecraft Server Eona!!")
        lblmever.AutoSize = True

        cmdchangelog = New Button
        cmdchangelog.Parent = pnlsup2
        cmdchangelog.Location = New Point(15, 300)
        cmdchangelog.Size = New Size(250, 40)
        cmdchangelog.FlatStyle = FlatStyle.System
        cmdchangelog.Text = "Changelog"
        cmdchangelog.Font = New Font(cmdme.Font.FontFamily, 10)

        AddHandler cmdchangelog.Click, AddressOf cmdchangelog_Click

    End Sub


    'Forum und Email

    Private Sub cmdforum_Click()

        ' Standard-Browser mit vorgegebener URL öffnen
        Process.Start("http://board.gamevolution.de")

    End Sub

    Private Sub cmdemail_Click()

        Try
            Process.Start("mailto:support@gamevolution.de")
        Catch ex As Exception
            MsgBox("Kein Mailprogramm vorhanden")
        End Try


    End Sub

    '....

    Private Sub cmdchangelog_Click()

        Dim clwindow As New changelog
        Dim cl As New IO.FileStream(".\changelog.txt", IO.FileMode.OpenOrCreate)
        Dim clr As New IO.StreamReader(cl)
        Dim data() As String = clr.ReadToEnd().Split(vbCrLf)
        For Each s As String In data
            clwindow.tbchangelog.Text &= s & vbCrLf
        Next

        clwindow.Show()


    End Sub


    Private Sub suphide()

        Try

            lblmever.Dispose()

        Catch ex As Exception

        End Try

        Try
            webbrowsersup.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdsupclose()

        cmdsup.Dispose()
        cmdteam.Dispose()
        cmdhystory.Dispose()
        cmdme.Dispose()
        pnlsup2.Dispose()

    End Sub


End Class
