Imports System.IO
Imports System.Net
Imports System.Text

Public Class PostRequest

    Private postData As New ArrayList
    Private url As String = ""


    Public Sub New(url As String)
        Me.url = url
    End Sub


    Public Sub add(key As String, value As String)
        postData.Add(key & "=" & value)
    End Sub


    Public Function getResponse() As String
        Try
            Dim cookieCon As New CookieContainer
            Dim request As HttpWebRequest = HttpWebRequest.Create(Me.url)
            request.Method = "POST"
            request.CookieContainer = cookieCon
            request.ContentType = "application/x-www-form-urlencoded"
            Dim post As String = ""
            For i As Integer = 0 To postData.Count - 1
                If (i = postData.Count - 1) Then
                    post &= postData(i)
                Else
                    post &= postData(i) & "&"
                End If
            Next
            Dim data() As Byte = Encoding.Default.GetBytes(post)
            request.ContentLength = data.Length
            Dim dataStream As Stream = request.GetRequestStream
            dataStream.Write(data, 0, data.Length)

            Dim response As HttpWebResponse = request.GetResponse
            Dim str As Stream = response.GetResponseStream
            Dim strR As New StreamReader(str)

            Return strR.ReadToEnd
        Catch ex As Exception
            Return "Fehler: " & ex.Message
        End Try


    End Function

    Public Function getStream() As Stream
        Try
            Dim cookieCon As New CookieContainer
            Dim request As HttpWebRequest = HttpWebRequest.Create(Me.url)
            request.Method = "POST"
            request.CookieContainer = cookieCon
            request.ContentType = "application/x-www-form-urlencoded"
            Dim post As String = ""
            For i As Integer = 0 To postData.Count - 1
                If (i = postData.Count - 1) Then
                    post &= postData(i)
                Else
                    post &= postData(i) & "&"
                End If
            Next
            Dim data() As Byte = Encoding.Default.GetBytes(post)
            request.ContentLength = data.Length
            Dim dataStream As Stream = request.GetRequestStream
            dataStream.Write(data, 0, data.Length)

            Dim response As HttpWebResponse = request.GetResponse
            Dim str As Stream = response.GetResponseStream
            Dim strR As New StreamReader(str)

            Return str
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
