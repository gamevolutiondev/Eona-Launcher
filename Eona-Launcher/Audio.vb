Partial Class mainform


    WithEvents pbplay As PictureBox
    WithEvents pbstop As PictureBox



    Public Sub Audio()

        My.Computer.Audio.Play(My.Resources.Crusade, AudioPlayMode.BackgroundLoop)


        pbplay = New PictureBox
        pbplay.Name = "pbplay"
        pbplay.Parent = Me
        pbplay.Location = New Point(818, 7)
        pbplay.Size = New Size(24, 22)
        pbplay.Visible = True
        'pbplay.BackgroundImage = My.Resources.
        'pbplay.BackgroundImageLayout = ImageLayout.Stretch
        pbplay.BackColor = Color.Plum
        pbplay.BringToFront()
        pbplay.Visible = False

        AddHandler pbplay.Click, AddressOf pbplay_Click


        pbstop = New PictureBox
        pbstop.Name = "pbplay"
        pbstop.Parent = Me
        pbstop.Location = New Point(818, 7)
        pbstop.Size = New Size(24, 22)
        pbstop.Visible = True
        'pbstop.BackgroundImage = My.Resources.
        'pbstop.BackgroundImageLayout = ImageLayout.Stretch
        pbstop.BackColor = Color.Red
        pbstop.BringToFront()
        pbstop.Visible = True

        AddHandler pbstop.Click, AddressOf pbstop_Click


    End Sub

    Private Sub pbstop_Click()

        My.Computer.Audio.Stop()
        pbstop.Visible = False
        pbplay.Visible = True

    End Sub

    Private Sub pbplay_Click()

        My.Computer.Audio.Play(My.Resources.Crusade, AudioPlayMode.BackgroundLoop)
        pbstop.Visible = True
        pbplay.Visible = False



    End Sub

End Class
