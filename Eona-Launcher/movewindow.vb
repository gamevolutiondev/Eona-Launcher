'movewindow
Partial Class mainform


    ' Maus-Koordinaten

    Dim nStartPos As Point
    Dim nDragPos As Point

    'Thread
    Dim stopped As Boolean = False

    'balkenoben

    Public Sub balkenoben_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles balkenoben.MouseDown

        ' Position des Fensters und der Maus merken
        If e.Button = Windows.Forms.MouseButtons.Left Then
            nStartPos = Me.Location
            nDragPos = Me.PointToScreen(New Point(e.X, e.Y))
        End If
    End Sub


    Public Sub baleknoben_MouseMove(ByVal sender As Object, _
   ByVal e As System.Windows.Forms.MouseEventArgs) Handles balkenoben.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' aktuelle Mausposition bezogen auf den Desktop
            Dim nCurPos As Point = Me.PointToScreen(New Point(e.X, e.Y))

            ' Fenster an neuen Position verschieben
            Me.Location = New Point(nStartPos.X + nCurPos.X - nDragPos.X, _
              nStartPos.Y + nCurPos.Y - nDragPos.Y)
        End If
    End Sub


End Class
