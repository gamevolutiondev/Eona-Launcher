Imports GamevolutionEngine.Databases.MySQLInterface
Imports EonaLauncher
Imports System.IO

Public Class mainform


    Private liste As New ArrayList
    Private thr_back As Boolean = False

    Public Delegate Sub delADD(x As Control)

    Private Sub add(x As Control)
        Me.Controls.Add(x)
    End Sub


    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        pnllogin.BackColor = Color.FromArgb(50, Color.LightYellow)


        'Userdata lesen
        Dim user As New User
        user.load()
        lbllogin2.Text = user.username
        lbllogin2.AutoSize = True
        lbllogin2.Parent = pnllogin
        lbllogin.Parent = pnllogin

        CheckForIllegalCrossThreadCalls = False
        Dim changer As New Threading.Thread(AddressOf backgroundchanger)
        changer.Start()

        pannelsshow()


        
    End Sub

    'Zeigt Panels an


    Public Sub pannelsshow()

        gvpannel()
        dynmappannel()
        pnlminecraft()
        pnlshopsub()
        pnlsupport()
        pnlmydaten()

    End Sub

    'Hintergrund ändern

    Public Sub backgroundchanger()

        Dim txt2 As New Label
        txt2.TextAlign = ContentAlignment.MiddleCenter
        txt2.Text = "Eona-Launcher wird geladen ..."
        txt2.Font = New Font(txt2.Font.FontFamily, 22)
        txt2.Visible = True
        txt2.AutoSize = True
        txt2.Location = New Point(290, 250)
        Me.Invoke(New delADD(AddressOf add), txt2)

        Try
            Dim client As New MySQLClient(My.Settings.dbhost, My.Settings.user, My.Settings.passwort, My.Settings.dbname)
            Dim ergebniss As MySQLResult = client.ExecuteReader("bilder")

            If Not Directory.Exists(".\bilder") Then
                Directory.CreateDirectory(".\bilder")

            End If


            Dim anzahl As Integer = ergebniss.getRowCount
            For i As Integer = 0 To ergebniss.getRowCount - 1
                Dim pfad As String = ".\bilder\bild" & i & ".png"
                If (File.Exists(pfad)) Then
                    File.Delete(pfad)
                End If
                My.Computer.Network.DownloadFile(ergebniss.getElement(i, "pfad"), pfad)

            Next

            Me.Controls.Remove(txt2)

            Dim a As Integer = 0
            Do Until thr_back
                If a = anzahl Then
                    a = 0
                End If
                Me.BackgroundImage = Image.FromFile(".\bilder\bild" & a & ".png")

                Try
                    Threading.Thread.Sleep(10000) '300000
                    a += 1
                Catch ex As Exception

                End Try
            Loop


        Catch ex As Exception

            Me.BackgroundImage = My.Resources.background
            Me.Controls.Remove(txt2)

        End Try


    End Sub

    'Autostart


    ''' <summary>
    ''' Prüft ob ein Eintrag vorhanden ist
    ''' </summary>
    ''' <returns>Boolean : true wenn ja, false wenn nicht</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckAutorun() As Boolean
        Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        Dim namen() As String = key.GetValueNames
        For Each s As String In namen
            If s = My.Application.Info.ProductName Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Fügt sich selbst dem Autostart hinzu
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub AddToAutorun()
        Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        key.SetValue(My.Application.Info.ProductName, """" & System.Reflection.Assembly.GetEntryAssembly.Location & """")
    End Sub

    ''' <summary>
    ''' Löscht Sich aus dem AutoStart
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub RemoveFromAutorun()
        Dim key As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
        key.DeleteValue(My.Application.Info.ProductName, False)
    End Sub


    Private Sub chboxautostart_checkedchanged()

        If chboxautostart.Checked Then
            AddToAutorun()
        Else
            RemoveFromAutorun()
        End If

    End Sub


    'Update


    Private Sub cmdupdate_CLick()



    End Sub

    'Passwort speichern

    Private Sub cmdsave_Click()

        Dim x As New User(tbusname.Text, tbuspass.Text)
        x.save()

        'Userdata lesen
        Dim user As New User
        user.load()

        tbusname1.Text = user.username
        Dim checkUser As New PostRequest("http://eona.gamevolution.de/extern/checkUser.php")
        checkUser.add("data", user.username & ";" & user.password)
        If (checkUser.getResponse = "true") Then
            txtlogininfo.ForeColor = Color.Green
            txtlogininfo.Text = "Erfolgreich"
        Else
            txtlogininfo.ForeColor = Color.Red
            txtlogininfo.Text = "Fehlgeschlagen"
        End If
    End Sub


    Private Sub chboxpass_checkedchanged()



    End Sub

    'Für panels class
    'loginpannel wegzumachen

    Public Sub hidesym()

        Me.pnllogin.Hide()

    End Sub


    'minimieren, schliesen, zurück

    Private Sub cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click

        thr_back = True
        Me.Close()

    End Sub


    Private Sub cmdminimize_Click(sender As Object, e As EventArgs) Handles cmdminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub pbback_Click(sender As Object, e As EventArgs) Handles pbback.Click


        'Support panel

        Try

            Me.Controls.Remove(pnlsup2)
            cmdsupclose()
            pnlsup.Location = New Point(750, 300)
            pnlsup.Size = New Size(160, 160)
            'pnlsup.BackgroundImage = My.Resources.shop
            'pnlsup.BackgroundImageLayout = ImageLayout.Stretch
            'pnlsup.BackColor = Color.Transparent
            pnlsup.BackColor = Color.FromArgb(100, Color.LightYellow)
            pbback.Hide()

        Catch ex As Exception

        End Try

        Try

            webbrowsersup.Dispose()

        Catch ex As Exception

        End Try

        'Dynmap panel

        Try

            webbrowser2.Dispose()
            pnldyn.Location = New Point(425, 300)
            pnldyn.Size = New Size(160, 160)
            'pnldyn.BackgroundImage = My.Resources.
            'pnldyn.BackgroundImageLayout = ImageLayout.Stretch
            'pnldyn.BackColor = Color.Transparent
            pnldyn.BackColor = Color.FromArgb(100, Color.LightYellow)


        Catch ex As Exception

        End Try


        'Einstellungspanel

        Try

            Me.Controls.Remove(pnl)
            Me.pbback.Hide()
            Me.pbback.Parent = Me

        Catch ex As Exception

        End Try


        'GV panel

        Try
            Me.Controls.Remove(pnlnews)
            Me.Controls.Remove(pnlforum)
            gv.Location = New Point(100, 300)
            gv.Size = New Size(160, 160)
            'gv.BackgroundImage = My.Resources.
            'gv.BackgroundImageLayout = ImageLayout.Stretch
            'gv.BackColor = Color.Transparent
            gv.BackColor = Color.FromArgb(100, Color.LightYellow)
            pbback.Hide()
          

        Catch ex As Exception

        End Try

        'Userpanel

        Try

            'pnlmydata.BackgroundImage = My.Resources.Minecraft
            'pnlmydata.BackgroundImageLayout = ImageLayout.Stretch
            'pnlmydata.BackColor = Color.Transparent
            pnlmydata.BackColor = Color.FromArgb(100, Color.LightYellow)
            pnlmydata.Location = New Point(425, 85)
            pnlmydata.Size = New Size(160, 160)

        Catch ex As Exception

        End Try

    End Sub
End Class

