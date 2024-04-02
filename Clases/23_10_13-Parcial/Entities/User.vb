Public Class User
    Public Property Username As String
    Public Property Password As String
    Public Property Nickname As String

    Public Sub New(username As String, password As String, nickname As String)
        Me.Username = username
        Me.Password = password
        Me.Nickname = nickname
    End Sub
End Class
