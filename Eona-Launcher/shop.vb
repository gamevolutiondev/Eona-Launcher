
'shop

Partial Class mainform

    Dim pnlshop As New Panel
    WithEvents webbrowsershop As WebBrowser


    Public Sub pnlshopsub()

        pnlshop = New Panel
        pnlshop.Name = "pnlmc"
        pnlshop.Parent = Me
        pnlshop.Location = New Point(750, 85)
        pnlshop.Size = New Size(160, 160)
        pnlshop.Visible = True
        pnlshop.BackgroundImage = My.Resources.shop
        pnlshop.BackgroundImageLayout = ImageLayout.Stretch
        pnlshop.BackColor = Color.Transparent
        pnlshop.BringToFront()

        AddHandler pnlshop.Click, AddressOf pnlshop_Click

    End Sub

    Private Sub pnlshop_Click()

        Dim urldyn As Uri = New Uri("http://eona.gamevolution.de/MCShop")
        '?nopanel=true"

        pnlshop.Dock = DockStyle.Fill
        pnlshop.BringToFront()
        balkenoben.BringToFront()
        cmdclose.BringToFront()
        cmdminimize.BringToFront()
        bpeinstellungen.BringToFront()


        webbrowsershop = New WebBrowser
        webbrowsershop.Parent = pnlshop
        webbrowsershop.Dock = DockStyle.Fill



    End Sub
End Class

