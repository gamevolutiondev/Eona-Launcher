

'minecraft

Partial Class mainform

    Dim pnlmc As New Panel


    Public Sub pnlminecraft()

        pnlmc = New Panel
        pnlmc.Name = "pnlmc"
        pnlmc.Parent = Me
        pnlmc.Location = New Point(100, 85)
        pnlmc.Size = New Size(160, 160)
        pnlmc.Visible = True
        pnlmc.BackgroundImage = My.Resources.Minecraft
        pnlmc.BackgroundImageLayout = ImageLayout.Stretch
        pnlmc.BackColor = Color.Transparent
        pnlmc.BringToFront()

        AddHandler pnlmc.Click, AddressOf pnlmc_Click


    End Sub

    Private Sub pnlmc_Click()

        Dim p As New Process
        If Not IO.File.Exists(".\Resources\EonaLauncher.jar") Then
            My.Computer.FileSystem.WriteAllBytes(".\Resources\EonaLauncher.jar", My.Resources.EonaLauncher, False)
        End If

        p.StartInfo.FileName = ".\Resources\EonaLauncher.jar"
        Dim u As New User
        u.load()

        p.StartInfo.Arguments = "name=" & u.username & " directPlay=1"
        p.Start()



    End Sub

End Class
