

''' <summary>
''' Ein Animationspanel
''' </summary>
''' <remarks></remarks>
Public MustInherit Class AnimatorPanel
    Inherits Panel

    Protected displaySize As Size
    Protected displayLocation As Point
    Protected tileSize As Size
    Protected tileLocation As Point
    Protected WithEvents closeButton As Button
    Protected expanded As Boolean = False
    Protected loaded As Boolean = False
    Protected time As Long = 5


    Protected displayControls As New ArrayList


    Protected WithEvents tilePanel As New Panel


    Public Sub setDisplay(Width As Integer, Height As Integer, posX As Integer, posY As Integer)
        Me.displaySize = New Size(Width, Height)
        Me.displayLocation = New Point(posX, posY)
    End Sub

    Public Sub setTile(width As Integer, height As Integer, posX As Integer, posY As Integer)
        Me.tileLocation = New Point(posX, posY)
        Me.tileSize = New Size(width, height)
        Me.Size = tileSize
        Me.Location = tileLocation
    End Sub

    Public Sub setButton(cmd As Button)

        Me.closeButton = cmd
        closeButton.Location = New Point(displaySize.Width - closeButton.Size.Width - 5, 10)

    End Sub

    Public Sub setTilePanel(pic As String)
        tilePanel.Dock = DockStyle.Fill
        Dim x As New PictureBox
        x.BackgroundImage = Image.FromFile(pic)
        x.BackgroundImageLayout = ImageLayout.Stretch
        AddHandler x.Click, AddressOf startAnimation
        x.Dock = DockStyle.Fill
        tilePanel.Controls.Add(x)
    End Sub

    Protected Sub startAnimation() Handles Me.Click, tilePanel.Click
        animate_forward()
    End Sub

    Protected Sub animate_forward()

        If (displayLocation.X < Me.Location.X) Then
            For i As Integer = Me.Location.X To displayLocation.X Step -5
                If (displayLocation.Y < Me.Location.Y) Then
                    For a As Integer = Me.Location.Y To displayLocation.Y Step -5
                        Me.Location = New Point(i, a)

                    Next
                Else
                    For a As Integer = Me.Location.Y To displayLocation.Y Step 5
                        Me.Location = New Point(i, a)
                    Next
                End If
                Threading.Thread.Sleep(time)
            Next
        Else
            For i As Integer = Me.Location.X To displayLocation.X Step 5
                If (displayLocation.Y < Me.Location.Y) Then
                    For a As Integer = Me.Location.Y To displayLocation.Y Step -5
                        Me.Location = New Point(i, a)
                    Next
                Else
                    For a As Integer = Me.Location.Y To displayLocation.Y Step 5
                        Me.Location = New Point(i, a)
                    Next
                End If
                Threading.Thread.Sleep(time)
            Next
        End If

        For i As Integer = Me.Size.Width To displaySize.Width Step 5
            For j As Integer = Me.Size.Height To displaySize.Height Step 5
                Me.Size = New Size(i, j)
            Next
            Threading.Thread.Sleep(time)
        Next


        Me.Location = displayLocation
        Me.Size = displaySize
        expanded = True
    End Sub

    Protected Sub animate_backward() Handles closeButton.Click

        expanded = False
        Try
            Me.Controls.Remove(closeButton)
        Catch ex As Exception

        End Try
        If (Me.Controls.Count > 0) Then
            For i As Integer = 0 To Me.displayControls.Count - 1
                Me.Controls.Remove(displayControls(i))
            Next
        End If


        Me.Controls.Add(tilePanel)
        loaded = False

        For i As Integer = Me.Size.Width To tileSize.Width Step -5
            For j As Integer = Me.Size.Height To tileSize.Height Step -5
                Me.Size = New Size(i, j)
            Next
            Threading.Thread.Sleep(time)
        Next

        If (tileLocation.X < Me.Location.X) Then
            For i As Integer = Me.Location.X To tileLocation.X Step -5
                If (tileLocation.Y < Me.Location.Y) Then
                    For a As Integer = Me.Location.Y To tileLocation.Y Step -5
                        Me.Location = New Point(i, a)

                    Next
                Else
                    For a As Integer = Me.Location.Y To tileLocation.Y Step 5
                        Me.Location = New Point(i, a)
                    Next
                End If
                Threading.Thread.Sleep(time)
            Next
        Else
            For i As Integer = Me.Location.X To tileLocation.X Step 5
                If (tileLocation.Y < Me.Location.Y) Then
                    For a As Integer = Me.Location.Y To tileLocation.Y Step -5
                        Me.Location = New Point(i, a)
                    Next
                Else
                    For a As Integer = Me.Location.Y To tileLocation.Y Step 5
                        Me.Location = New Point(i, a)
                    Next
                End If
                Threading.Thread.Sleep(time)
            Next
        End If



        Me.Location = tileLocation
        Me.Size = tileSize
    End Sub

    Protected Sub zeigeCloseButton() Handles Me.Paint
        If (expanded) Then
            If loaded = False Then
                If (Me.Controls.Count > 0) Then
                    For i As Integer = 0 To Me.Controls.Count - 1
                        Me.Controls.RemoveAt(i)
                    Next
                End If

                For i As Integer = 0 To displayControls.Count - 1
                    Me.Controls.Add(displayControls(i))
                Next
                closeButton.BringToFront()
                Me.Controls.Add(closeButton)
                loaded = True
            End If

        Else
            Me.Controls.Add(tilePanel)

        End If
    End Sub

    Public Sub addDisplayControls(x As Control)
        displayControls.Add(x)
    End Sub

    Public Sub removeDisplayControls(x As Control)
        displayControls.Remove(x)
    End Sub

    Public Function getDisplayControls(i As Integer) As Control
        Return displayControls(i)
    End Function


End Class
