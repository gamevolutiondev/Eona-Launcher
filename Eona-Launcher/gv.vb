Imports System.IO

' Gamevolution Panel


Partial Class mainform

    WithEvents gv As Panel
    WithEvents pnlnews As Panel
    WithEvents pnlforum As Panel
    WithEvents webbrowser As WebBrowser
    WithEvents wbback As PictureBox
    WithEvents pbback2 As PictureBox



    Private Sub gvpannel()

        gv = New Panel
        gv.Name = "gv"
        gv.Parent = Me
        gv.BorderStyle = BorderStyle.None
        gv.Location = New Point(100, 300)
        gv.Size = New Size(160, 160)
        gv.Visible = True
        gv.BackgroundImage = My.Resources.GV
        gv.BackgroundImageLayout = ImageLayout.Stretch
        gv.BackColor = Color.Transparent
        'gv.BackColor = Color.FromArgb(100, Color.LightYellow)
        gv.BringToFront()


        AddHandler gv.Click, AddressOf gv_Click





    End Sub

    Private Sub gv_Click()

        pbback2 = New PictureBox
        pbback2.Parent = gv
        pbback2.Image = My.Resources.zurückpfeil1
        pbback2.Location = New Point(12, 10)
        pbback2.Size = New Size(71, 27)
        pbback2.BringToFront()
        pbback2.Hide()


        AddHandler pbback2.Click, AddressOf pbback2_CLick


        gv.Location = New Point(0, 35)
        gv.Size = New Size(1010, 485)
        gv.BackColor = Color.Transparent
        gv.BackgroundImage = Nothing
        gv.BringToFront()

        'Zurückpfeil

        pbback.Show()
        pbback.BackColor = Color.FromArgb(100, Color.LightYellow)
        pbback.BringToFront()

        'Symbole ändern
        hidesym()



        pnlnews = New Panel
        pnlnews.Name = "pnlnews"
        pnlnews.Parent = gv
        pnlnews.BorderStyle = BorderStyle.None
        pnlnews.Location = New Point(260, 150)
        pnlnews.Size = New Size(160, 160)
        pnlnews.Visible = True
        pnlnews.BackgroundImage = My.Resources.news
        pnlnews.BackgroundImageLayout = ImageLayout.Stretch
        pnlnews.BackColor = Color.Transparent
        'pnlnews.BackColor = Color.Black
        pnlnews.BringToFront()


        AddHandler pnlnews.Click, AddressOf pnlnews_Click


        pnlforum = New Panel
        pnlforum.Name = "pnlforum"
        pnlforum.Parent = gv
        pnlforum.BorderStyle = BorderStyle.None
        pnlforum.Location = New Point(580, 150)
        pnlforum.Size = New Size(160, 160)
        pnlforum.Visible = True
        pnlforum.BackgroundImage = My.Resources.forum
        pnlforum.BackgroundImageLayout = ImageLayout.Stretch
        pnlforum.BackColor = Color.Transparent
        'pnlforum.BackColor = Color.Black
        pnlforum.BringToFront()


        AddHandler pnlforum.Click, AddressOf pnlforum_Click


    End Sub


    Private Sub pnlnews_Click()


        pnlnews.Location = New Point(0, 0)
        pnlnews.Size = New Size(1010, 485)
        pnlnews.BackColor = Color.Transparent
        pnlnews.BringToFront()
        pnlnews.BackgroundImage = Nothing

        Dim urlnews As Uri = New Uri("http://eona.gamevolution.de/extern/eonalauncher/news.html")

        webbrowser = New WebBrowser
        webbrowser.Name = "webbrowsernews"
        webbrowser.Parent = pnlnews
        webbrowser.Location = New Point(0, 0)
        webbrowser.Size = New Size(1010, 485)
        webbrowser.BringToFront()
        webbrowser.Url = urlnews

        pbback.Hide()
        pbback2.Show()
        pbback2.BringToFront()

    End Sub


    Private Sub pnlforum_Click()

        Dim urlforum As Uri = New Uri("http://board.gamevolution.de/")

        pnlforum.Location = New Point(0, 0)
        pnlforum.Size = New Size(1010, 485)
        pnlforum.BackColor = Color.Black
        pnlforum.BringToFront()
        pnlforum.BackgroundImage = Nothing

        webbrowser = New WebBrowser
        webbrowser.Name = "webbrowserforum"
        webbrowser.Parent = pnlforum
        webbrowser.Location = New Point(0, 0)
        webbrowser.Size = New Size(1010, 485)
        webbrowser.BringToFront()
        webbrowser.DocumentStream = loggeForumEin()
        webbrowser.ScrollBarsEnabled = True

        wbback = New PictureBox
        wbback.Parent = webbrowser
        wbback.Image = My.Resources.zurückpfeil1
        wbback.Location = New Point(12, 40)
        wbback.Size = New Size(71, 27)
        wbback.BringToFront()

        AddHandler wbback.Click, AddressOf wbback_Click

        pbback.Hide()
        pbback2.Show()
        pbback2.BringToFront()

    End Sub

    Private Sub wbback_Click()

        webbrowser.GoBack()

    End Sub


    Private Sub pbback2_CLick()



        Try
            webbrowser.Dispose()
            pnlnews.Size = New Size(160, 160)
            pnlnews.Location = New Point(260, 150)
            pnlnews.BackgroundImage = My.Resources.news
            pnlforum.Location = New Point(580, 150)
            pnlforum.Size = New Size(160, 160)
            pnlforum.BackgroundImage = My.Resources.forum
            pbback.Show()
            pbback2.Hide()
            pbback.BringToFront()
        Catch ex As Exception

        End Try

    End Sub

    Public Function loggeForumEin() As Stream
        Dim x As New PostRequest("http://board.gamevolution.de/index.php?form=UserLogin&s=f366d163a0d628b1a28a82ffb3a8733cdf275651")
        Dim u As New User

        x.add("loginUsername", u.username)
        x.add("loginPassword", u.password)

        Return x.getStream
    End Function

End Class
