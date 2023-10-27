Imports System.IO

Public Class FsUsersDataService
    Implements IUsersService
    Private ReadOnly FilePath As String = "..\..\..\TxtData\users.txt"
    Private Shared FsUsersDataService As FsUsersDataService
    Public Function GetUser(username As String) As User Implements IUsersService.GetUser
        If Not File.Exists(FilePath) Then
            Throw New Exception("No se pudo acceder al registro de usuarios. Contacte al desarrollador.")
        End If

        Dim user As User = Nothing
        Using reader As New StreamReader(FilePath)
            While Not reader.EndOfStream
                Dim userData As String = reader.ReadLine()
                If userData.Contains(username) Then
                    user = MapUserFromLine(userData)
                End If
            End While
        End Using

        If user Is Nothing Then
            Throw New Exception("No se pudo recuperar la información del usuario. Contacte al desarrollador.")
        End If
        Return user
    End Function

    Public Shared Function MapUserFromLine(userData) As User
        Dim userProperties As String() = userData.Split(";")
        Dim user As New User(userProperties(0), userProperties(1), userProperties(2))
        Return user
    End Function
    Public Shared Function GetInstance() As FsUsersDataService
        If FsUsersDataService Is Nothing Then
            FsUsersDataService = New FsUsersDataService()
        End If

        Return FsUsersDataService
    End Function
End Class
