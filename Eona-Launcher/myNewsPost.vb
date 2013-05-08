Imports GamevolutionEngine.Databases.MySQLInterface
Imports CodeKicker.BBCode
Imports System.IO
Public Class myNewsPost
    Inherits WebBrowser

    Private dbConn As MySQLClient
    Private mode As String

    Public Sub New(mode As String)
        dbConn = New MySQLClient(My.Settings.dbhost, My.Settings.user, My.Settings.passwort, My.Settings.dbname)
        Me.mode = mode
        Me.Dock = DockStyle.Fill
        loadNews()
    End Sub

    Private Sub loadNews()
        Dim x As MySQLResult
        If mode = "GVNW" Then
            x = dbConn.ExecuteReader("wbb1_1_post", "*", "threadID IN (SELECT threadID FROM wbb1_1_thread WHERE boardID='2')", "postID DESC", 1)
        Else
            x = dbConn.ExecuteReader("wbb1_1_post", "*", "boardID='8'", "postID DESC", 1)
        End If

        Dim subject As String = x.getElement(0, "subject")
        Dim message As String = x.getElement(0, "message")

        If (Not Directory.Exists(".\news")) Then
            Directory.CreateDirectory(".\news")
        End If


        If (File.Exists(".\news\post.htm")) Then
            File.Delete(".\news\post.htm")

        End If

        Dim fs As New FileStream(".\news\post.htm", FileMode.OpenOrCreate)
        Dim sw As New StreamWriter(fs)

        sw.WriteLine("<!DOCTYPE html>")
        sw.WriteLine("<html>")
        sw.WriteLine("  <head>")
        sw.WriteLine("      <title>" & subject & "</title>")
        sw.WriteLine("      <link rel='stylesheet' href='style.css'>")
        sw.WriteLine("  </head>")
        sw.WriteLine("  <body>")
        sw.WriteLine("      " & BBCode.ToHtml(message) & "")
        sw.WriteLine("  </body>")
        sw.WriteLine("</html>")
        sw.Close()
        fs.Close()

        Dim datei As New FileInfo(".\news\post.htm")
        Me.Navigate("file://" & datei.FullName)

    End Sub

    
End Class
