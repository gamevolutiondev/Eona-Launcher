Imports Serializer
<Serializable()>
Public Class User

    Public username As String
    Public password As String

    Public Sub New()

    End Sub

    Public Sub New(user As String, pw As String)
        Me.username = user
        Me.password = pw
    End Sub

    Public Sub save()
        Serializer.Serializer.Serialize(Of User)(".\userdata.dat", Me)
    End Sub

    Public Sub load()
        Dim x As New User
        x = Serializer.Serializer.DeSerialize(Of User)(".\userdata.dat")
        Me.username = x.username
        Me.password = x.password
    End Sub
End Class
