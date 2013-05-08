'dynmap

Partial Class mainform

    WithEvents pnldyn As Panel
    WithEvents webbrowser2 As WebBrowser

    Public Sub dynmappannel()

        pnldyn = New Panel
        pnldyn.Name = "pnldyn"
        pnldyn.Parent = Me
        pnldyn.BorderStyle = BorderStyle.None
        pnldyn.Location = New Point(425, 300)
        pnldyn.Size = New Size(160, 160)
        pnldyn.Visible = True
        'gv.BackgroundImage = My.Resources.
        'gv.BackgroundImageLayout = ImageLayout.Stretch
        'gv.BackColor = Color.Transparent
        pnldyn.BackColor = Color.FromArgb(100, Color.LightYellow)
        pnldyn.BringToFront()


        AddHandler pnldyn.Click, AddressOf pnldyn_Click

    End Sub


    Private Sub pnldyn_Click()

        Dim urldyn As Uri = New Uri("http://eona.gamevolution.de:8123/")
        '?nopanel=true"


        pnldyn.Location = New Point(0, 35)
        pnldyn.Size = New Size(1010, 485)
        pnldyn.BackColor = Color.Transparent
        pnldyn.BringToFront()

        webbrowser2 = New WebBrowser
        webbrowser2.Name = "webbrowserdyn"
        webbrowser2.Parent = pnldyn
        webbrowser2.Location = New Point(0, 0)
        webbrowser2.Size = New Size(1010, 485)
        webbrowser2.BringToFront()
        webbrowser2.Url = urldyn

        pbback.Show()
        pbback.Location = New Point(40, 45)
        pbback.BackColor = Color.FromArgb(100, Color.LightYellow)
        pbback.BringToFront()


    End Sub

End Class