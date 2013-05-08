'My data

Partial Class mainform

    WithEvents pnlmydata As Panel
    WithEvents pnlcity As Panel
    WithEvents pnlgs As Panel

    Private Sub pnlmydaten()

        pnlmydata = New Panel
        pnlmydata.Name = "pnlmydata"
        pnlmydata.Parent = Me
        pnlmydata.BorderStyle = BorderStyle.None
        pnlmydata.Location = New Point(425, 85)
        pnlmydata.Size = New Size(160, 160)
        pnlmydata.Visible = True
        'pnlmydata.BackgroundImage = My.Resources.Minecraft
        'pnlmydata.BackgroundImageLayout = ImageLayout.Stretch
        'pnlmydata.BackColor = Color.Transparent
        pnlmydata.BackColor = Color.FromArgb(100, Color.LightYellow)
        pnlmydata.BringToFront()



        AddHandler pnlmydata.Click, AddressOf pnlmydata_Click


    End Sub

    Private Sub pnlmydata_Click()

        pnlmydata.Location = New Point(0, 35)
        pnlmydata.Size = New Size(1010, 485)
        pnlmydata.BackColor = Color.Transparent
        pnlmydata.BringToFront()

        pbback.Show()
        pbback.BringToFront()

        pnlgs = New Panel
        pnlgs.Name = "pnlgs"
        pnlgs.Parent = pnlmydata
        pnlgs.BorderStyle = BorderStyle.None
        pnlgs.Location = New Point(260, 150)
        pnlgs.Size = New Size(160, 160)
        pnlgs.Visible = True
        'pnlgs.BackgroundImage = My.Resources.Minecraft
        'pnlgs.BackgroundImageLayout = ImageLayout.Stretch
        'pnlgs.BackColor = Color.Transparent
        pnlgs.BackColor = Color.Black
        pnlgs.BringToFront()


        AddHandler pnlgs.Click, AddressOf pnlgs_Click


        pnlcity = New Panel
        pnlcity.Name = "pnlcity"
        pnlcity.Parent = pnlmydata
        pnlcity.BorderStyle = BorderStyle.None
        pnlcity.Location = New Point(580, 150)
        pnlcity.Size = New Size(160, 160)
        pnlcity.Visible = True
        'pnlcity.BackgroundImage = My.Resources.Minecraft
        'pnlcity.BackgroundImageLayout = ImageLayout.Stretch
        'pnlcity.BackColor = Color.Transparent
        pnlcity.BackColor = Color.Black
        pnlcity.BringToFront()

        AddHandler pnlcity.Click, AddressOf pnlcity_Click

    End Sub

    Private Sub pnlgs_Click()

        pnlgs.Dock = DockStyle.Fill

    End Sub


    Private Sub pnlcity_Click()

        pnlcity.Dock = DockStyle.Fill

    End Sub

End Class