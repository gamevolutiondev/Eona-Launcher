
'shop

Partial Class mainform

    Dim pnlshop As New Panel


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



    End Sub


End Class

